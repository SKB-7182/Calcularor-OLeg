using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcularor_OLeg
{
    static class Class1
    {
        public static calculator2 cal1(int count)
        {
            switch (count)
            {
                case 1:
                    return new Plus();
                case 2:
                    return new Minus();
                case 3:
                    return new Myltiply();
                case 4:
                    return new division();
                case 5:
                    return new power();
                default:
                    return new Plus();
            }


        }
    }

    interface calculator2
    {
        double calculate(double a, double b);
    }

    class Plus : calculator2
    {
        public double calculate(double firstValue, double secendValue)
        {
            return firstValue + secendValue;
        }

    }

    class Minus : calculator2
    {
        public double calculate(double firstValue, double secendValue)
        {
            return firstValue - secendValue;
        }
    }
    class Myltiply : calculator2
    {
        public double calculate(double firstValue, double secendValue)
        {
            return firstValue * secendValue;
        }
    }
    class division : calculator2
    {
        public double calculate(double firstValue, double secendValue)
        {
            return firstValue / secendValue;
        }
    }

    class power : calculator2
    {
        public double calculate(double firstValue, double secendValue)
        {
            return Math.Pow(2,firstValue);
        }

    }

}
