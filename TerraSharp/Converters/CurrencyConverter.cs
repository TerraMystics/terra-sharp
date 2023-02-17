namespace TerraSharp.Converters
{
    public static class CurrencyConverter
    {
        public static double ConvertMicroToStandard(double uLuna)
        {
            return uLuna / 1e6;
        }

        public static double ConvertStandardToMicro(double uLuna)
        {
            return uLuna * 1e6;
        }
    }
}
