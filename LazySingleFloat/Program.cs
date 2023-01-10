using System;

namespace LazySingleFloat
{
    public class Program
    {
        private static void Main()
        {
            SetValue(1.234f);
            PrintValue();
        }

        private static void SetValue(float value)
        {
            FloatManager.Instance.Value = value;
        }

        private static void PrintValue()
        {
            Console.WriteLine(FloatManager.Instance.Value);
        }
    }
}
