
using TerraSharp.Rest.Configuration.Environment;

namespace TerraSharp.Maui.Example
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            TerraStartup.InitializeKernel(TerraEnvironment.ClassicTestNet); // Run this method to initialize the TerraSharp Library
        }
    }
}