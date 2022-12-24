using TerraSharp;
using TerraSharp.Client.Lcd;
using TerraSharp.Client.Lcd.Api;
using TerraSharp.Client.LocalTerra;

namespace TerraSharpTest
{
    class TerraSharpTestExecutable
    {
        public static void Main(string[] args)
        {
            TerraStartup.InitializeKernel(TerraProto.CSharp.proto.Environment.TerraEnvironment.PiscoTestNet); // Run this method to initialize the TerraSharp Library

            Test();

        }

        private static void Test()
        {
            Task.Run(async () =>
            {
                var result = await TerraStartup.GetService<LCDClient>().bank.GetBalance("terra1067mhg3qwdccep2sp95cca8nmj8ds395w2rue7");

                Console.WriteLine($"BALANCE: {result.Length}");
            });

            Thread.Sleep(5000);
        }
    }
}