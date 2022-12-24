using Google.Protobuf.WellKnownTypes;
using BASE = TerraProto.CSharp.third_party.proto.cosmos.auth.v1beta1;
using TerraSharp.Core.Constants;
using TerraNetExtensions.ProtoBufs;
using TerraProto.CSharp.proto.keys;
using Newtonsoft.Json;

namespace TerraSharp.Core.Auth
{
    public class BaseAccount : SharedAccounts
    {
        public readonly string address;
        public readonly KeysDto public_key;
        public readonly double account_number;
        public readonly double sequence;

        public BaseAccount(string address, KeysDto public_key, double account_number, double sequence)
        {
            this.address = address;
            this.public_key = public_key;
            this.account_number = account_number;
            this.sequence = sequence;
        }

        public override double GetAccountNumber()
        {
            return this.account_number;
        }

        public override double GetSequenceNumber()
        {
            return this.sequence;
        }

        public override KeysDto GetPublicKey()
        {
            return this.public_key;
        }

        public BaseAccountAminoArgs ToAmino()
        {
            return new BaseAccountAminoArgs()
            {
                Value = new BaseAccountAminoValueArgs()
                {
                    Account_Number = this.account_number.ToString(),
                    Address = this.address,
                    Public_Key = this.public_key,
                    Sequence = this.sequence.ToString()
                }
            };
        }

        public static BaseAccount FromAmino(BaseAccountAminoArgs args)
        {
            var data = args.Value;
            return new BaseAccount(data.Address, data.Public_Key, double.Parse(data.Account_Number), double.Parse(data.Sequence));
        }

        public static BaseAccount FromData(BaseAccountDataArgs data)
        {
            return new BaseAccount(data.Address, data.Public_Key, double.Parse(data.Account_Number), double.Parse(data.Sequence));
        }

        public BaseAccountDataArgs ToData()
        {
            return new BaseAccountDataArgs()
            {
                Address = this.address,
                Public_Key = this.public_key,
                Sequence = this.sequence.ToString(),
                Account_Number = this.account_number.ToString()
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(new BASE.BaseAccount()
            {
                Address = this.address,
                PubKey = this.public_key.PackAny(this.public_key.Key),
                Sequence = (ulong)this.sequence,
                AccountNumber = (ulong)this.account_number
            });
        }

        public BASE.BaseAccount ToProtoWithType()
        {
            return new BASE.BaseAccount()
            {
                Address = this.address,
                PubKey = this.public_key.PackAny(this.public_key.Key),
                Sequence = (ulong)this.sequence,
                AccountNumber = (ulong)this.account_number
            };
        }

        public Any PackAny()
        {
            return new Any()
            {
                TypeUrl = CosmosConstants.COSMOS_AUTH,
                Value = this.ToProto()
            };
        }
    }

    public class BaseAccountAminoArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public BaseAccountAminoValueArgs Value { get; set; }

        public BaseAccountAminoArgs()
        {
            this.Type = AccountsConstants.BASE_ACCOUNT_AMINO_TYPE;
        }
    }

    public class BaseAccountAminoValueArgs
    {
        public string Address { get; set; }
        public KeysDto Public_Key { get; set; }
        public string Account_Number { get; set; }
        public string Sequence { get; set; }
    }

    public class BaseAccountDataValueArgs
    {
        public string Address { get; set; }
        public KeysDto Public_Key { get; set; }
        public string Account_Number { get; set; }
        public string Sequence { get; set; }
    }

    public class BaseAccountDataArgs : BaseAccountDataValueArgs
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public BaseAccountDataArgs()
        {
            this.Type = CosmosConstants.COSMOS_AUTH;
        }
    }

}
