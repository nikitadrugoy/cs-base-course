namespace Task1Complex
{
    public struct ComplexStruct
    {
        public double im;
        public double re;

        public ComplexStruct Plus(ComplexStruct complex)
        {
            return new ComplexStruct()
            {
                im = im + complex.im,
                re = re + complex.re,
            };
        }

        public ComplexStruct Minus(ComplexStruct complex)
        {
            return new ComplexStruct()
            {
                im = im - complex.im,
                re = re - complex.re,
            };
        }

        public ComplexStruct Multi(ComplexStruct complex)
        {
            return new ComplexStruct()
            {
                im = im * complex.im,
                re = re * complex.re,
            };
        }
        
        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }
}