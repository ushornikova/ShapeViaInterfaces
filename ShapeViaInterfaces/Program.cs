using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeViaInterfaces
{
    interface IShape
    {
        void Square();
    }

    interface ITriangle
    {
        int side { get; set; }
        int Height { get; set; }
        int TriangleSquare { get; set; }
    }

    interface IRectangle
    {
        int SideA { get; set; }
        int SideB { get; set; }
        int RectangleSquare { get; set; }
    }

    class Triangle: IShape, ITriangle
    {
        public int side { get; set; }
        public int Height { get; set; }
        public int TriangleSquare { get; set; }
        public void Square()
        {
            TriangleSquare = side * Height;
            Console.WriteLine("triangle square is " + TriangleSquare);

        }
     }

    class Rectangle: IShape, IRectangle
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int RectangleSquare { get; set; }
        public void Square()
        {
            RectangleSquare = SideA * SideB;
            Console.WriteLine("reqtangle square is " + RectangleSquare);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int varNumber = 15;
                Triangle varTriangle = new Triangle();
                varTriangle.side = 5;
                varTriangle.Height = 6;
                varTriangle.Square();
               Console.ReadLine();

            Rectangle varRectangle = new Rectangle();
            varRectangle.SideA = 4;
            varRectangle.SideB = 2;
            varRectangle.Square();
            Console.ReadLine();

            if (varNumber > varTriangle.TriangleSquare)
            {
                
                varRectangle.Square();
                Console.ReadLine();
            }
            else //(varNumber > varRectangle.RectangleSquare)
            {
                varTriangle.Square();
                Console.ReadLine();
            }
        }
    }
}
