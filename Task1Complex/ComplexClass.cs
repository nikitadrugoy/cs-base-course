using System;

namespace Task1Complex
{
    public class ComplexClass
    {
        public double im;
        public double re;

        public void Plus(ComplexClass complex)
        {
            im += complex.im;
            re += complex.re;
        }

        public void Minus(ComplexClass complex)
        {
            im -= complex.im;
            re -= complex.re;
        }
        
        public void Multi(ComplexClass complex)
        {
            im *= complex.im;
            re *= complex.re;
        }
        
        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }

}