using Google.Protobuf.WellKnownTypes;
using Terra.Microsoft.Extensions.ProtoBufs;
using Terra.Microsoft.Extensions.StringExt;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.upgrade.v1beta1;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Terra.Microsoft.Client.Core.Upgrade
{
    public class Plan
    {
        public readonly string name;
        public readonly DateTime? time;
        public readonly string height;
        public readonly string info;
        public readonly Any upgraded_client_state;

        public Plan(
            string name,
            DateTime? time,
            string height,
            string info,
            Any upgraded_client_state)
        {
            this.name = name;
            this.time = time;
            this.height = height;
            this.info = info;
            this.upgraded_client_state = upgraded_client_state;
        }

        public static Plan FromAmino(PlanAminoArgs data)
        {
            return new Plan(
                data.Name,
                TerraStringExtensions.GetISODateTimeFromString(data.Time),
                data.Height,
                data.Info,
                data.Upgraded_Client_State);
        }

        public static Plan FromData(PlanDataArgs data)
        {
            return new Plan(
                data.Name,
                TerraStringExtensions.GetISODateTimeFromString(data.Time),
                data.Height,
                data.Info,
                data.Upgraded_Client_State);
        }

        public static Plan FromProto(PROTO.Plan data)
        {
            return new Plan(
                data.Name,
                data.Time,
                data.Height.ToString(),
                data.Info,
                data.UpgradedClientState);
        }

        public PlanAminoArgs ToAmino()
        {
            return new PlanAminoArgs()
            {
                Name = this.name,
                Time = TerraStringExtensions.GetISOStringFromDate(this.time.Value),
                Upgraded_Client_State = this.upgraded_client_state,
                Height = this.height,
                Info = this.info,
            };
        }

        public PlanDataArgs ToData()
        {
            return new PlanDataArgs()
            {
                Name = this.name,
                Time = TerraStringExtensions.GetISOStringFromDate(this.time.Value),
                Upgraded_Client_State = this.upgraded_client_state,
                Height = this.height,
                Info = this.info,
            };
        }


        public PROTO.Plan ToProtoWithType()
        {
            return new PROTO.Plan()
            {
                Height = long.Parse(this.height),
                Info = this.info,
                Time = this.time,
                Name = this.name,
                UpgradedClientState = this.upgraded_client_state
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class PlanAminoArgs : PlanCommonArgs
    {
    }

    public class PlanDataArgs : PlanCommonArgs
    {
    }

    public class PlanCommonArgs
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string Height { get; set; }
        public string Info { get; set; }
        public Any Upgraded_Client_State { get; set; }
    }
}
