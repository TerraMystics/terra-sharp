using System;
using System.IO;
using System.Linq;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Rest.Tx.Transaction;
using CN = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.signing.v1beta1;
using COMB = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.crypto.multisig.v1beta1;

namespace Terra.Microsoft.Client.Core
{
    public class CompactBitArray
    {
        public readonly uint extra_bits_stored;
        public readonly byte[] elems;
        public CompactBitArray(uint extra_bits_stored, byte[] elems)
        {
            this.extra_bits_stored = extra_bits_stored;
            this.elems = elems;
        }

        public static CompactBitArray FromBits(uint bits)
        {
            if (bits <= 0)
            {
                throw new Exception("CompactBitArray bits must be bigger than 0");
            }

            var numElems = (bits + 7) / 8;
            if (numElems <= 0 || numElems > (Math.Pow(2, 32) - 1))
            {
                throw new Exception("CompactBitArray overflow");
            }

            return new CompactBitArray(bits % 8, new byte[(int)numElems]);
        }

        public long Count()
        {
            if (this.extra_bits_stored == 0)
            {
                return this.elems.Length * 8;
            }

            return (this.elems.Length - 1) * 8 + this.extra_bits_stored;
        }

        public bool GetIndex(int i)
        {
            if (i < 0 || i >= this.Count())
            {
                return false;
            }

            using (var stream = new MemoryStream(this.elems))
            {
                return (stream.Read(this.elems, i >> 3, (int)this.Count()) & (1 << (7 - (i % 8)))) > 0;
            }
        }

        public bool SetIndex(int i, bool v)
        {
            if (i < 0 || i >= this.Count())
            {
                return false;
            }

            if (v)
            {
                this.elems[i >> 3] |= (byte)(1 << (7 - (i % 8)));
            }
            else
            {
                this.elems[i >> 3] &= (byte)~(1 << (7 - (i % 8)));
            }

            return true;
        }

        public double NumTrueBitsBefore(long index)
        {
            var countOneBits = new Func<byte, int>((n) =>
            {
                return n.ToString().ElementAt(2).ToString().Split('0').Length;
            });

            int ones_count = 0;
            var max = this.Count();
            if (index > max)
            {
                index = max;
            }

            for (int elem = 0; elem < this.elems.Length; elem++)
            {
                if ((elem * 8 + 7) >= index)
                {
                    var offset = (byte)(this.elems[elem] >> (7 - ((byte)index % 8) + 1));
                    return (ones_count += countOneBits(offset));
                }

                ones_count += countOneBits(this.elems[elem]);
            }

            return ones_count;
        }

        public static CompactBitArray FromProto(COMB.CompactBitArray proto)
        {
            return new CompactBitArray(proto.ExtraBitsStored, proto.Elems);
        }
        public static CompactBitArray FromProto(Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.tx.signing.v1beta1.CompactBitArray proto)
        {
            return new CompactBitArray(proto.ExtraBitsStored, proto.Elems);
        }

        public static CompactBitArray FromData(CompactBitArrayData data)
        {
            return new CompactBitArray(data.ExtraBitsStored, TerraStringExtensions.GetBytesFromString(TerraStringExtensions.GetBase64FromString(data.Elems)));
        }

        public CompactBitArrayData ToData()
        {
            return new CompactBitArrayData()
            {
                Elems = TerraStringExtensions.GetBase64FromString(TerraStringExtensions.GetStringFromBytes(this.elems)),
                ExtraBitsStored = this.extra_bits_stored
            };
        }

        public TxBitArray ToJSON()
        {
            return new TxBitArray()
            {
                elems = TerraStringExtensions.GetBase64FromString(TerraStringExtensions.GetStringFromBytes(this.elems)),
                extra_bits_stored = this.extra_bits_stored
            };
        }

        public COMB.CompactBitArray ToProtoWithType()
        {
            return new COMB.CompactBitArray()
            {
                Elems = this.elems,
                ExtraBitsStored = (uint)this.extra_bits_stored
            };
        }
        public CN.CompactBitArray ToProtoWithTypeSign()
        {
            return new CN.CompactBitArray()
            {
                Elems = this.elems,
                ExtraBitsStored = (uint)this.extra_bits_stored
            };
        }

        public byte[] ToProto(bool withSign = false)
        {
            if (withSign)
            {
                return ProtoExtensions.SerialiseFromData(this.ToProtoWithTypeSign());
            }

            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class CompactBitArrayData
    {
        public uint ExtraBitsStored { get; set; }
        public string Elems { get; set; }
    }
}
