using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraNetExtensions.StringExt;
using TerraSharp.Core.Keys.Constants;

namespace TerraSharp.Key
{
    public class CLIKey : Key
    {
        private string accAddress;
        public readonly CLIKeyParams @params;
        public CLIKey(CLIKeyParams @params) : base(null)
        {
            this.@params = @params;
            if (string.IsNullOrWhiteSpace(this.@params.CliPath))
            {
                this.@params.CliPath = TerraPubKeys.TERRA_KEY_NAME_D;
            }
        }

        public override Task<byte[]> Sign(byte[] payload)
        {
            throw new InvalidOperationException("CLIKey does not use sign() -- use createSignature() directly.");
        }

        private string GenerateCommand(string args)
        {
            return string.Concat(this.@params.CliPath, $" {args} --output json " +
                $"{(!string.IsNullOrWhiteSpace(this.@params.Home) ? $"--home {this.@params.Home}" : String.Empty)}");
        }

        private void LoadAccountDetails()
        {
            var details = TerraStringExtensions.GetJSONFromobject(this.GenerateCommand($"keys show {this.@params.KeyName}"));

        }


    }

    public class CLIKeyParams
    {
        public string KeyName { get; set; }
        public string Multisig { get; set; }
        public string CliPath { get; set; }
        public string Home { get; set; }
    }
}
