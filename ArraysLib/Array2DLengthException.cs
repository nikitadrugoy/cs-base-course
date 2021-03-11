using System;

namespace ArraysLib
{
    public class Array2DLengthException : Exception
    {
        public override string Message => "Длина массива не может быть меньше 0.";
    }
}