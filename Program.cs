//вариант 12 срендний уровень 
public class Tablitsa
{
    public static bool LF1(bool x, bool y, bool z)
    {
        return (!(x && y) || (x && !z));
    }

    public static bool LF2(bool x, bool y, bool z)
    {
        return (x && !(!y || z) || y);
    }

    public static int CalculateValue(Func<bool, bool, bool, bool> logicFunctiion, int x, int y, int z)
    {
        return Convert.ToInt32(logicFunctiion(Convert.ToBoolean(x), Convert.ToBoolean(y), Convert.ToBoolean(z)));
    }

    public static void Main()
    {
        Console.WriteLine("Таблица истинности для заданных функций:");
        Console.WriteLine("X  |  Y  |  Z  | LF1 | LF2");
        for (int x = 0; x <= 1; x++)
            for (int y = 0; y <= 1; y++)
                for (int z = 0; z <= 1; z++)
                    Console.WriteLine($"{x}  |  {y}  |  {z}  |  {CalculateValue(LF1, x, y, z)} |  {CalculateValue(LF2, x, y, z)}");

        Console.ReadKey();
    }
}
