namespace Terra.Microsoft.Rest.IBCTransfer
{
    public class IBCTransferCommonJson
    {
        public DenomTraceJSON[] denom_traces { get; set; }
        public DenomTraceJSON denom_trace { get; set; }
        public CommonTypeValueArgs pagination { get; set; }
        public IBCTransferParams @params { get; set; }
    }
}
