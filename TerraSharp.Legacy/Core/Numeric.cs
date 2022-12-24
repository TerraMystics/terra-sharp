namespace TerraSharp.Core
{
    public interface INumeric<T, R>
    {
        T Add(R value);
        T Sub(R value);

        T Mul(R value);

        T Div(R value);

        T Mod(R value);
    }
}
