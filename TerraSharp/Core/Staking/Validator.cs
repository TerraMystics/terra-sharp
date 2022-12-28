using Terra.Microsoft.Rest.Converters;
using Terra.Microsoft.Rest.Staking;
using PROTO = Terra.Microsoft.ProtoBufs.third_party.proto.cosmos.staking.v1beta1;
using System;
using Terra.Microsoft.Client.Core.Staking.Terra.Microsoft.Client.Core.Staking.Validators.CommissionsRates;
using Terra.Microsoft.Client.Core.Keys;
using Terra.Microsoft.Extensions.StringExt;
using Terra.Microsoft.Extensions.ProtoBufs;

namespace Terra.Microsoft.Client.Core.Staking
{
    using VAL_DESC = Terra.Microsoft.Client.Core.Staking.Validators.Description;
    using CM = Terra.Microsoft.Client.Core.Staking.Validators.Commissions;

    public class Validator
    {
        public readonly string operator_address;
        public readonly ValConsPublicKey consensus_pubkey;
        public readonly bool jailed;
        public readonly PROTO.BondStatus status;
        public readonly long tokens;
        public readonly decimal delegator_shares;
        public readonly VAL_DESC.ValidatorDescription description;
        public readonly double unbonding_height;
        public readonly DateTime unbonding_time;
        public readonly CM.Commission commission;
        public readonly long min_self_delegation;

        public Validator(
            string operator_address,
            ValConsPublicKey consensus_pubkey,
            bool jailed,
            PROTO.BondStatus status,
            long tokens,
            decimal delegator_shares,
            VAL_DESC.ValidatorDescription description,
            double unbonding_height,
            DateTime unbonding_time,
            CM.Commission commission,
            long min_self_delegation)
        {
            this.operator_address = operator_address;
            this.consensus_pubkey = consensus_pubkey;
            this.jailed = jailed;
            this.status = status;
            this.tokens = tokens;
            this.delegator_shares = delegator_shares;
            this.description = description;
            this.unbonding_height = unbonding_height;
            this.unbonding_time = unbonding_time;
            this.commission = commission;
            this.min_self_delegation = min_self_delegation;
        }

        public static Validator FromAmino(ValidatorAminoArgs data)
        {
            return new Validator(
                data.Operator_Address,
                ValConsPublicKey.FromAmino(data.Consensus_Pubkey),
                data.Jailed,
                data.Status,
                long.Parse(data.Tokens),
                decimal.Parse(data.Delegator_shares),
                VAL_DESC.ValidatorDescription.FromAmino(data.Description),
                double.Parse(data.Unbonding_Height),
                TerraStringExtensions.GetISODateTimeFromString(data.Unbonding_Time),
                CM.Commission.FromAmino(data.Commission),
                long.Parse(data.Min_Self_Delegation));
        }

        public static Validator FromData(ValidatorDataArgs data)
        {
            return new Validator(
                data.Operator_Address,
                ValConsPublicKey.FromData(data.Consensus_Pubkey),
                data.Jailed,
                data.Status,
                long.Parse(data.Tokens),
                decimal.Parse(data.Delegator_shares),
                VAL_DESC.ValidatorDescription.FromData(data.Description),
                double.Parse(data.Unbonding_Height),
                TerraStringExtensions.GetISODateTimeFromString(data.Unbonding_Time),
                CM.Commission.FromData(data.Commission),
                long.Parse(data.Min_Self_Delegation));
        }
        public static Validator FromJSON(ValidatorDataArgsJSON data)
        {
            return new Validator(
                data.operator_Address,
                ValConsPublicKey.FromJSON(data.consensus_pubkey),
                data.jailed,
                BondStatusConverter.GetFromString(data.status),
                long.Parse(data.tokens),
                decimal.Parse(data.delegator_shares),
                VAL_DESC.ValidatorDescription.FromJSON(data.description),
                double.Parse(data.unbonding_Height),
                data.unbonding_Time,
                CM.Commission.FromJSON(data.commission),
                long.Parse(data.min_Self_Delegation));
        }

        public static Validator FromProto(PROTO.Validator data)
        {
            return new Validator(
                data.OperatorAddress,
                ValConsPublicKey.UnPackAny(data.ConsensusPubkey),
                data.Jailed,
                data.Status,
                long.Parse(data.Tokens),
                decimal.Parse(data.DelegatorShares),
                VAL_DESC.ValidatorDescription.FromProto(data.Description),
                data.UnbondingHeight,
                data.UnbondingTime.Value,
                CM.Commission.FromProto(data.Commission),
                long.Parse(data.MinSelfDelegation));
        }

        public ValidatorAminoArgs ToAmino()
        {
            return new ValidatorAminoArgs()
            {
                Description = this.description.ToAmino(),
                Commission = this.commission.ToAmino(),
                Consensus_Pubkey = this.consensus_pubkey.ToAmino(),
                Delegator_shares = this.delegator_shares.ToString(),
                Jailed = this.jailed,
                Min_Self_Delegation = this.min_self_delegation.ToString(),
                Operator_Address = this.operator_address,
                Status = this.status,
                Tokens = this.tokens.ToString(),
                Unbonding_Height = this.unbonding_height.ToString(),
                Unbonding_Time = this.unbonding_time.ToString()
            };
        }

        public ValidatorDataArgs ToData()
        {
            return new ValidatorDataArgs()
            {
                Description = this.description.ToData(),
                Commission = this.commission.ToData(),
                Consensus_Pubkey = this.consensus_pubkey.ToData(),
                Delegator_shares = this.delegator_shares.ToString(),
                Jailed = this.jailed,
                Min_Self_Delegation = this.min_self_delegation.ToString(),
                Operator_Address = this.operator_address,
                Status = this.status,
                Tokens = this.tokens.ToString(),
                Unbonding_Height = this.unbonding_height.ToString(),
                Unbonding_Time = this.unbonding_time.ToString()
            };
        }

        public PROTO.Validator ToProtoWithType()
        {
            return new PROTO.Validator()
            {
                Commission = this.commission.ToProtoWithType(),
                ConsensusPubkey = this.consensus_pubkey.PackAny(),
                DelegatorShares = this.delegator_shares.ToString(),
                Description = this.description.ToProtoWithType(),
                Jailed = this.jailed,
                MinSelfDelegation = this.min_self_delegation.ToString(),
                OperatorAddress = this.operator_address,
                Status = this.status,
                Tokens = this.tokens.ToString(),
                UnbondingHeight = (long)this.unbonding_height,
                UnbondingTime = this.unbonding_time
            };
        }

        public byte[] ToProto()
        {
            return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
        }
    }

    public class ValidatorAminoArgs : ValidatorCommonArgs
    {
        public ValConsPublicKeyAminoArgs Consensus_Pubkey { get; set; }
        public VAL_DESC.ValidatorDescriptionAminoArgs Description { get; set; }
        public CM.CommissionAminoArgs Commission { get; set; }
    }

    public class ValidatorDataArgs : ValidatorCommonArgs
    {
        public ValConsPublicKeyDataArgs Consensus_Pubkey { get; set; }
        public VAL_DESC.ValidatorDescriptionDataArgs Description { get; set; }
        public CM.CommissionDataArgs Commission { get; set; }
    }

    public class ValidatorCommonArgs
    {
        public string Operator_Address { get; set; }
        public bool Jailed { get; set; }
        public PROTO.BondStatus Status { get; set; }
        public string Tokens { get; set; }
        public string Delegator_shares { get; set; }
        public string Unbonding_Height { get; set; }
        public string Unbonding_Time { get; set; }
        public string Min_Self_Delegation { get; set; }
    }

    namespace Terra.Microsoft.Client.Core.Staking.Validators.Description
    {
        public class ValidatorDescription
        {
            public readonly string moniker;
            public readonly string identity;
            public readonly string website;
            public readonly string details;
            public readonly string security_contact;

            public ValidatorDescription(
                string moniker,
                string identity,
                string website,
                string details,
                string security_contact)
            {
                this.moniker = moniker;
                this.identity = identity;
                this.website = website;
                this.details = details;
                this.security_contact = security_contact;
            }

            public static ValidatorDescription FromAmino(ValidatorDescriptionAminoArgs data)
            {
                return new ValidatorDescription(
                    data.Moniker,
                    data.Identity,
                    data.Website,
                    data.Details,
                    data.Security_Contact);
            }

            public static ValidatorDescription FromData(ValidatorDescriptionDataArgs data)
            {
                return new ValidatorDescription(
                    data.Moniker,
                    data.Identity,
                    data.Website,
                    data.Details,
                    data.Security_Contact);
            }
            public static ValidatorDescription FromJSON(ValidatorDescriptionJSON data)
            {
                return new ValidatorDescription(
                    data.moniker,
                    data.identity,
                    data.website,
                    data.details,
                    data.security_contact);
            }

            public static ValidatorDescription FromProto(PROTO.Description data)
            {
                return new ValidatorDescription(
                    data.Moniker,
                    data.Identity,
                    data.Website,
                    data.Details,
                    data.SecurityContact);
            }

            public ValidatorDescriptionAminoArgs ToAmino()
            {
                return new ValidatorDescriptionAminoArgs()
                {
                    Website = this.website,
                    Security_Contact = this.security_contact,
                    Details = this.details,
                    Identity = this.identity,
                    Moniker = this.moniker
                };
            }

            public ValidatorDescriptionDataArgs ToData()
            {
                return new ValidatorDescriptionDataArgs()
                {
                    Website = this.website,
                    Security_Contact = this.security_contact,
                    Details = this.details,
                    Identity = this.identity,
                    Moniker = this.moniker
                };
            }

            public PROTO.Description ToProtoWithType()
            {
                return new PROTO.Description()
                {
                    Details = this.details,
                    Identity = this.identity,
                    Moniker = this.moniker,
                    SecurityContact = this.security_contact,
                    Website = this.website
                };
            }

            public byte[] ToProto()
            {
                return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
            }
        }

        public class ValidatorDescriptionAminoArgs : ValidatorDescriptionCommonArgs
        {

        }
        public class ValidatorDescriptionDataArgs : ValidatorDescriptionCommonArgs
        {

        }

        public class ValidatorDescriptionCommonArgs
        {
            public string Moniker { get; set; }
            public string Identity { get; set; }
            public string Website { get; set; }
            public string Details { get; set; }
            public string Security_Contact { get; set; }
        }
    }

    namespace Terra.Microsoft.Client.Core.Staking.Validators.CommissionsRates
    {
        public class CommissionRates
        {
            public readonly decimal rate;
            public readonly decimal max_rate;
            public readonly decimal max_change_rate;

            public CommissionRates(
                decimal rate,
                decimal max_rate,
                decimal max_change_rate)
            {
                this.rate = rate;
                this.max_rate = max_rate;
                this.max_change_rate = max_change_rate;
            }


            public static CommissionRates FromAmino(CommissionRatesAminoArgs data)
            {
                return new CommissionRates(
                    data.Rate,
                    data.Max_Rate,
                    data.Max_Change_Rate);
            }

            public static CommissionRates FromData(CommissionRatesDataArgs data)
            {
                return new CommissionRates(
                    data.Rate,
                    data.Max_Rate,
                    data.Max_Change_Rate);
            }
            public static CommissionRates FromJSON(CommissionRatesCommonValueArgs data)
            {
                return new CommissionRates(
                    data.Rate,
                    data.Max_Rate,
                    data.Max_Change_Rate);
            }

            public static CommissionRates FromProto(PROTO.CommissionRates data)
            {
                return new CommissionRates(
                    decimal.Parse(data.Rate),
                    decimal.Parse(data.MaxRate),
                    decimal.Parse(data.MaxChangeRate));
            }

            public CommissionRatesAminoArgs ToAmino()
            {
                return new CommissionRatesAminoArgs()
                {
                    Max_Change_Rate = this.max_change_rate,
                    Max_Rate = this.max_rate,
                    Rate = this.rate
                };
            }

            public CommissionRatesDataArgs ToData()
            {
                return new CommissionRatesDataArgs()
                {
                    Max_Change_Rate = this.max_change_rate,
                    Max_Rate = this.max_rate,
                    Rate = this.rate
                };
            }

            public PROTO.CommissionRates ToProtoWithType()
            {
                return new PROTO.CommissionRates()
                {
                    MaxChangeRate = this.max_change_rate.ToString(),
                    MaxRate = this.max_rate.ToString(),
                    Rate = this.rate.ToString()
                };
            }

            public byte[] ToProto()
            {
                return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
            }
        }

        public class CommissionRatesAminoArgs : CommissionRatesCommonArgs
        {

        }
        public class CommissionRatesDataArgs : CommissionRatesCommonArgs
        {

        }

        public class CommissionRatesCommonArgs
        {
            public decimal Rate { get; set; }
            public decimal Max_Rate { get; set; }
            public decimal Max_Change_Rate { get; set; }
        }
    }

    namespace Terra.Microsoft.Client.Core.Staking.Validators.Commissions
    {
        public class Commission
        {
            public readonly CommissionRates commission_rates;
            public readonly DateTime? update_time;

            public Commission(
                CommissionRates commission_rates,
                DateTime? update_time)
            {
                this.commission_rates = commission_rates;
                this.update_time = update_time;
            }


            public static Commission FromAmino(CommissionAminoArgs data)
            {
                return new Commission(
                    CommissionRates.FromAmino(data.Commission_Rates),
                    TerraStringExtensions.GetISODateTimeFromString(data.Update_Time));
            }

            public static Commission FromData(CommissionDataArgs data)
            {
                return new Commission(
                    CommissionRates.FromData(data.Commission_Rates),
                    TerraStringExtensions.GetISODateTimeFromString(data.Update_Time));
            }
            public static Commission FromJSON(CommissionCommonArgsJSON data)
            {
                return new Commission(
                    CommissionRates.FromJSON(data.commission_rates),
                    data.update_time);
            }


            public static Commission FromProto(PROTO.Commission data)
            {
                return new Commission(
                    CommissionRates.FromProto(data.CommissionRates),
                    data.UpdateTime);
            }

            public CommissionAminoArgs ToAmino()
            {
                return new CommissionAminoArgs()
                {
                    Update_Time = TerraStringExtensions.GetISOStringFromDate(this.update_time.Value),
                    Commission_Rates = this.commission_rates.ToAmino()
                };
            }

            public CommissionDataArgs ToData()
            {
                return new CommissionDataArgs()
                {
                    Update_Time = TerraStringExtensions.GetISOStringFromDate(this.update_time.Value),
                    Commission_Rates = this.commission_rates.ToData()
                };
            }

            public PROTO.Commission ToProtoWithType()
            {
                return new PROTO.Commission()
                {
                    CommissionRates = this.commission_rates.ToProtoWithType(),
                    UpdateTime = this.update_time
                };
            }

            public byte[] ToProto()
            {
                return ProtoExtensions.SerialiseFromData(this.ToProtoWithType());
            }
        }

        public class CommissionAminoArgs : CommissionCommonArgs
        {
            public CommissionRatesAminoArgs Commission_Rates { get; set; }
        }
        public class CommissionDataArgs : CommissionCommonArgs
        {
            public CommissionRatesDataArgs Commission_Rates { get; set; }
        }

        public class CommissionCommonArgs
        {
            public string Update_Time { get; set; }
        }
    }
}
