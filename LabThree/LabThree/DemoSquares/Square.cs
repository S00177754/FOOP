using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSquares
{
    class Square
    {
        private readonly int area = 0;
        private readonly int length = 0;

        public Square(int sqLength)
        {
            length = sqLength;
            area = CalculateArea(length);
            Display();

        }

        private int CalculateArea(int squareLength)
        {
            squareLength *= squareLength;
            return squareLength;
        }

        private void Display()
        {
            Console.WriteLine($"The area of a {length} by {length} square is {area}");
        }
    }
}
