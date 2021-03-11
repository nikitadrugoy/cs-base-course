using System;
using System.IO;
using System.Linq;

namespace ArraysLib
{
    public class D2Array
    {
        public int Min => MinValue();
        public int Max => MaxValue(out var index);
        
        private int[,] _array; // Rider ругается, если поля (private) не начинаются с _
        private int _maxRandomValue = 1000; // Числа поменьше для наглаядности

        public D2Array(int lengthX, int lengthY)
        {
            if (lengthX < 0 || lengthY < 0)
            {
                throw new Array2DLengthException();
            }
            
            _array = new int[lengthX, lengthY];

            FillRandom();
        }

        public D2Array(string filePath)
        {
            LoadFromFile(filePath);
        }
        
        public int this[int x, int y]
        {
            get => _array[x, y];
            set => _array[x, y] = value;
        }

        public void FillRandom()
        {
            var rand = new Random();
            
            for (var x = 0; x < _array.GetLength(0); x++)
            {
                for (var y = 0; y < _array.GetLength(1); y++)
                {
                    _array[x, y] = rand.Next(_maxRandomValue);
                }
            }
        }

        public long Sum(int minValue = 0)
        {
            long sum = 0;

            foreach (var value in _array)
            {
                if (value > minValue)
                {
                    sum += value;
                }
            }

            return sum;
        }

        public int MinValue()
        {
            var min = _array[0, 0];

            foreach (var value in _array)
            {
                if (value < min)
                {
                    min = value;
                }
            }

            return min;
        }

        public int MaxValue(out (int, int) index)
        {
            var max = _array[0, 0];
            
            index = (0, 0);

            for (var x = 0; x < _array.GetLength(0); x++)
            {
                for (var y = 0; y < _array.GetLength(1); y++)
                {
                    var value = _array[x, y];
                    
                    if (value > max)
                    {
                        max = value;
                        index = (x, y);
                    }
                }
            }

            return max;
        }

        public override string ToString()
        {
            var result = $"{".",3} |"; // Не понимаю как использовать динамический alignment (из переменной) без конкатинации

            for (var y = 0; y < _array.GetLength(1); y++)
            {
                result += $" {y,4}";
            }

            result += Environment.NewLine;
            result += string.Empty.PadLeft(_array.GetLength(1) * 5 + 5, '-');

            for (var x = 0; x < _array.GetLength(0); x++)
            {
                result += Environment.NewLine;
                result += $"{x,3} |";
                
                for (var y = 0; y < _array.GetLength(1); y++)
                {
                    var value = _array[x, y];
                    
                    result += $" {value,4}";
                }
            }

            return result;
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                _array = default;
            }
            
            var lines = File.ReadLines(filePath).ToArray();
            var valueCount = lines.Length > 0 
                ? lines[0].Split(';').Length 
                : 0;

            _array = new int[lines.Length, valueCount];

            for (var x = 0; x < lines.Length; x++)
            {
                var line = lines[x];
                var values = line.Split(';');

                for (var y = 0; y < values.Length; y++)
                {
                    _array[x, y] = int.Parse(values[y]);
                }
            }
        }

        public void SaveToFile(string filePath)
        {
            var contents = "";
            
            for (var x = 0; x < _array.GetLength(0); x++)
            {
                if (x > 0)
                {
                    contents += Environment.NewLine;
                }
                
                for (var y = 0; y < _array.GetLength(1); y++)
                {
                    var value = _array[x, y];

                    if (y > 0)
                    {
                        contents += ";";
                    }
                    
                    contents += value;
                }
            }
            
            File.WriteAllText(filePath, contents);
        }
    }
}