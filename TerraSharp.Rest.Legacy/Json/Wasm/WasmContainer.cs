namespace Terra.Microsoft.Rest.Wasm
{
    public class WasmContainer
    {
        public WasmCodeInfo code_info { get; set; }
        public WasmContractInfo contract_info { get; set; }
        public string query_result { get; set; }
        public WasmParams @params{ get; set; }
}
}
