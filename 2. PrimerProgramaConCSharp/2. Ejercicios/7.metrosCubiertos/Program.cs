namespace _7.metrosCubiertos;
class Program
{
    static void Main(string[] args)
    {
        float mCubiertos, mTotales,mDescubiertos;
        Console.WriteLine("Ingrese los metros cubiertos: ");
        mCubiertos = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los metros totales: ");
        mTotales = float.Parse(Console.ReadLine());
        mDescubiertos = mTotales - mCubiertos;

        Console.WriteLine("Los metros cubiertos son: " + mCubiertos + " ("+ (mCubiertos / mTotales).ToString("0.00%") + ")");
        Console.WriteLine("Los metros descubiertos son: " + mDescubiertos + " ("+ (mDescubiertos / mTotales * 100).ToString("0.00") + "%)" );
    }
}
