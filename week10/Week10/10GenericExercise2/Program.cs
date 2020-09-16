using System;

namespace _10GenericExercise2
{
    class DecimalCalculator
    {
        decimal Add(decimal d1, decimal d2)
        {
            return d1 + d2;
        }

        decimal Sub(decimal d1, decimal d2)
        {
            return d1 - d2;
        }
    }

    class IntCalculator
    {
        int Add(int d1, int d2)
        {
            return d1 + d2;
        }

        int Sub(int d1, int d2)
        {
            return d1 - d2;
        }
    }

    class FloatCalculator
    {
        float Add(float d1, float d2)
        {
            return d1 + d2;
        }

        float Sub(float d1, float d2)
        {
            return d1 - d2;
        }
    }

    public class GenericCalculator<T>
    {
        public T Add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        public T Sub(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }
    }

    public class GenericCalculatorV2<T> where T : IAdditon<T>, IComparable
    {
        public T Add(T a, T b)
        {
            return a.Add(b);
        }

        public T Sub(T a, T b)
        {
            return (dynamic) a - (dynamic)b;
        }

        public T Min(T a, T b)
        {
            if(a.CompareTo(b) < 0)
            {
                return a;
            }
            {
                return b;
            }
        }
    }

    public interface IAdditon<T>
    {
        public T Add(T param);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var floatCalc = new FloatCalculator();

            var floatGenericCalc = new GenericCalculator<float>();
        }
    }
}
