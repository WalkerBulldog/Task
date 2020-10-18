using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Figure
    {
        private Cirkle[] cirkles = new Cirkle[10];
        private Hexagon[] hexagons = new Hexagon[10];        
        private Rectangle[] rectangles = new Rectangle[10];
        private Square[] squares = new Square[10];
        private Trapezoid[] trapezoids = new Trapezoid[10];
        private Triangle[] triangles = new Triangle[10];
        public void MenuFigures()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("Максимум может быть по 10 фигур каждого типа.");
                Console.WriteLine("1. Окружность.");
                EnterCirkles();
                Console.WriteLine("2. Шестиугольник.");
                EnterHexagons();
                Console.WriteLine("3. Прямоугольник. ");
                EnterRectangles();
                Console.WriteLine("4. Квадрат.");
                EnterSquares();
                Console.WriteLine("5. Трапеция.");
                EnterTrapezoids();
                Console.WriteLine("6. Треугольник. ");
                EnterTiangles();
                for (int i = 0; i < 10; i++)
                {
                    if (cirkles[i].ItsRight() || hexagons[i].ItsRight() || squares[i].ItsRight() || rectangles[i].ItsRight() || trapezoids[i].ItsRight() || triangles[i].ItsRight())
                        f = false;                   
                }
                if (f)
                    Console.WriteLine("Должна быть задана хотя бы 1 фигура.");
            }
            Menu();
        }
        public void Menu()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("\tМеню ");
                Console.WriteLine("1. Создать новые фигуры.");
                Console.WriteLine("2. Найти фигуру наибольшей площади.");
                Console.WriteLine("3. Найти тип фигуры, средний периметр которого наибольший.");
                Console.WriteLine("4. Средний периметр всех фигур.");
                Console.WriteLine("5. Сумма площадей всех фигур.");
                Console.WriteLine("0. Выйти.");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                    MenuFigures();
                else if (ch == 2)
                    BiggestAreaFigure();
                else if (ch == 3)
                    BiggestHalfPerimeterType();
                else if (ch == 4)
                    AllMidPerimeters();
                else if (ch == 5)
                    SummAllAreas();
                else if (ch == 0)
                    f = false;
            }
            Console.Clear();
            Console.WriteLine("Работа окончена.");
            Console.ReadKey();
        }
        public void SummAllAreas()
        {
            double sum = 0;
            for (int i = 0; i<cirkles.Length; i++)
            {
                sum += cirkles[i].Area();
                sum += hexagons[i].Area();
                sum += rectangles[i].Area();
                sum += squares[i].Area();
                sum += trapezoids[i].Area();
                sum += triangles[i].Area();
            }
            Console.WriteLine("Сумма площадей всех фигур - " + Math.Round(sum,2));
        }
        public void EnterCirkles()
        {
            Console.WriteLine("Сколько таких фигур необходимо создать?");
            int kol = Convert.ToInt32(Console.ReadLine());
            while (kol>10 || kol<0)         
                kol = Convert.ToInt32(Console.ReadLine());           
            for (int i = 0; i < kol; i++) 
            {
                bool f = true;
                while (f)
                {
                    Console.WriteLine("Введите радиус окружности номер " + (i + 1) + ": ");
                    Cirkle test = new Cirkle(Convert.ToDouble(Console.ReadLine()));
                    if(test.ItsRight())
                    {
                        cirkles[i] = test;
                        f = false;
                    }
                    else
                        Console.WriteLine("Введите корректные значения!");
                }
            }
            if (kol < 10)
                for (int i = kol; i < 10; i++)
                    cirkles[i] = new Cirkle(0);
        }
        public void EnterHexagons()
        {
            Console.WriteLine("Сколько таких фигур необходимо создать?");
            int kol = Convert.ToInt32(Console.ReadLine());
            while (kol > 10 || kol < 0)
                kol = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kol; i++)
            {
                bool f = true;
                while (f)
                {
                    Console.WriteLine("Введите длину ребра шестиугольника номер " + (i + 1) + ": ");
                    Hexagon test = new Hexagon(Convert.ToDouble(Console.ReadLine()));
                    if (test.ItsRight())
                    {
                        hexagons[i] = test;
                        f = false;
                    }
                    else
                        Console.WriteLine("Введите корректные значения!");
                }
            }
            if (kol < 10)
                for (int i = kol; i < 10; i++)
                    hexagons[i] = new Hexagon(0);
        }
        public void EnterRectangles()
        {
            Console.WriteLine("Сколько таких фигур необходимо создать?");
            int kol = Convert.ToInt32(Console.ReadLine());
            while (kol > 10 || kol < 0)
                kol = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kol; i++)
            {
                bool f = true;
                while (f)
                {
                    Console.WriteLine("Введите длину и ширину прямоугольника номер " + (i + 1) + ": ");
                    Rectangle test = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    if (test.ItsRight())
                    {
                        rectangles[i] = test;
                        f = false;
                    }
                    else
                        Console.WriteLine("Введите корректные значения!");
                }
            }
            if (kol < 10)
                for (int i = kol; i < 10; i++)
                    rectangles[i] = new Rectangle(0, 0);
        }
        public double[] MidPerimeter()
        {
            double[] massP = { 0, 0, 0, 0, 0, 0 };
            int i = 0;
            while (i < 10 && cirkles[i].ItsRight())
            {
                massP[0] += cirkles[i].Perimeter();
                i += 1;
            }
            if (i == 0)
                massP[0] = 0;
            else
                massP[0] = massP[0] / i;
            i = 0;
            while (i < 10 && hexagons[i].ItsRight())
            {
                massP[1] += hexagons[i].Perimeter();
                i += 1;
            }
            if (i == 0)
                massP[1] = 0;
            else
                massP[1] = massP[1] / i;
            i = 0;
            while (i < 10 && squares[i].ItsRight())
            {
                massP[2] += squares[i].Perimeter();
                i += 1;
            }
            if (i == 0)
                massP[2] = 0;
            else
                massP[2] = massP[2] / i;
            i = 0;
            while (i < 10 && rectangles[i].ItsRight())
            {
                massP[3] += rectangles[i].Perimeter();
                i += 1;
            }
            if (i == 0)
                massP[3] = 0;
            else
                massP[3] = massP[3] / i;
            i = 0;
            while (i < 10 && trapezoids[i].ItsRight())
            {
                massP[4] += trapezoids[i].Perimeter();
                i += 1;
            }
            if (i == 0)
                massP[4] = 0;
            else
                massP[4] = massP[4] / i;
            i = 0;
            while (i < 10 && triangles[i].ItsRight())
            {
                massP[5] += triangles[i].Perimeter();
                i += 1;
            }
            if (i == 0)
                massP[5] = 0;
            else
                massP[5] = massP[5] / i;
            return massP;
        }
        public void BiggestHalfPerimeterType()
        {
            double[] mass = MidPerimeter();
            string[] names = { "окружности", "шестиугольника", "квадрата", "прямоугольника", "трапеции", "треугольника" };
            double max = mass[0];
            string name = names[0];
            for (int i = 1; i<mass.Length; i++)
                if (mass[i]>max)
                {
                    max = mass[i];
                    name = names[i];
                }
            Console.WriteLine("Наибольший средний периметр у " + name + " - " + Math.Round(max,2));
        }
        public void AllMidPerimeters()
        {
            double[] mass = MidPerimeter();
            double mid = 0;
            int kol = 0;
            for (int i = 0; i < mass.Length; i++)
                if (mass[i] != 0) 
                {
                    mid = mid + mass[i];                    
                    kol += 1;
                }
            mid = mid/kol;
            Console.WriteLine("Cредний периметр всех фигур - " + Math.Round(mid, 2));
        }
        public void EnterSquares()
        {
            Console.WriteLine("Сколько таких фигур необходимо создать?");
            int kol = Convert.ToInt32(Console.ReadLine());
            while (kol > 10 || kol < 0)
                kol = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kol; i++)
            {
                bool f = true;
                while (f)
                {
                    Console.WriteLine("Введите длину ребра квадрата номер " + (i + 1) + ": ");
                    Square test = new Square(Convert.ToDouble(Console.ReadLine()));
                    if (test.ItsRight())
                    {
                        squares[i] = test;
                        f = false;
                    }
                    else
                        Console.WriteLine("Введите корректные значения!");
                }             
            }
            if (kol < 10)
                for (int i = kol; i < 10; i++)
                    squares[i] = new Square(0);
        }
        public void EnterTrapezoids()
        {
            Console.WriteLine("Сколько таких фигур необходимо создать?");
            int kol = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kol; i++)
            {
                bool f = true;
                while (f)
                {
                    Console.WriteLine("Введите длину оснований трапеции номер " + (i + 1) + ":");
                    double top = Convert.ToDouble(Console.ReadLine());
                    double bottom = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите высоту трапеции номер " + (i + 1) + ":");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Trapezoid test = new Trapezoid(bottom, top, height);
                    if (test.ItsRight())
                    {
                        trapezoids[i] = test;
                        f = false;
                    }
                    else
                        Console.WriteLine("Введите корректные значения!");
                }
            }
            if (kol < 10)
                for (int i = kol; i < 10; i++)
                    trapezoids[i] = new Trapezoid(0, 0, 0);
        }
        public void EnterTiangles()
        {
            Console.WriteLine("Сколько таких фигур необходимо создать?");
            int kol = Convert.ToInt32(Console.ReadLine());
            while (kol > 10 || kol < 0)
                kol = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kol; i++)
            {
                bool f = true;
                while (f)
                {
                    Console.WriteLine("Введите длину основания и высоту треугольника номер " + (i + 1) + ": ");
                Triangle test = new Triangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    if (test.ItsRight())
                    {
                        triangles[i] = test;
                        f = false;
                    }
                    else
                        Console.WriteLine("Введите корректные значения!");
                }
            }
            if (kol < 10)
                for (int i = kol; i < 10; i++)
                    triangles[i] = new Triangle(0, 0);
        }
        public void BiggestAreaFigure()
        {
            double[] areas = { BiggestAreaCirkle(), BiggestAreaHexagon(), BiggestAreaSquare(), BiggestAreaRectangle(), BiggestAreaTrapezoid(), BiggestAreaTriangle() };
            double max = areas[0];
            string[] names = { "круг", "шестиугольник", "квадрат", "прямоугольник", "треапеция", "треугольник" };
            double[] index = IndexOfBiggest();
            int num = 0;
            for(int i=1;i<areas.Length;i++)
            {
                if (areas[i]>max)
                {
                    max = areas[i];
                    num = i;
                }
            }
            Console.WriteLine("Наибольшая фигура по площади - " + names[num] + " " + (index[num]+1) + ". S = " + Math.Round(areas[num],2));
        }
        public double[] IndexOfBiggest()
        {
            int iCirkle = 0, iHex = 0, iSq = 0, iRek = 0, iTrap = 0, iTr = 0;
            for (int i = 1; i < 10; i++) 
            {
                if (cirkles[i].Area() > cirkles[i - 1].Area())
                    iCirkle = i;
                if (hexagons[i].Area() > hexagons[i - 1].Area())
                    iHex = i;
                if (squares[i].Area() > squares[i - 1].Area())
                    iSq = i;
                if (rectangles[i].Area() > rectangles[i - 1].Area())
                    iRek = i;
                if (trapezoids[i].Area() > trapezoids[i - 1].Area())
                    iTrap = i;
                if (triangles[i].Area() > triangles[i - 1].Area())
                    iTr = i;
            }
            double[] index = { iCirkle, iHex, iSq, iRek, iTrap, iTr };
            return index;
        }
        public double BiggestAreaCirkle()
        {
            double max = cirkles[0].Area();
            for (int i = 1; i < cirkles.Length; i++) 
            {
                if (cirkles[i].Area() > max)
                    max = cirkles[i].Area();
            }
            return max;
        }
        public double BiggestAreaHexagon()
        {
            double max = hexagons[0].Area();
            for (int i = 1; i < hexagons.Length; i++)
            {
                if (hexagons[i].Area() > max)
                    max = hexagons[i].Area();
            }
            return max;
        }
        public double BiggestAreaSquare()
        {
            double max = squares[0].Area();
            for (int i = 1; i < squares.Length; i++)
            {
                if (squares[i].Area() > max)
                    max = squares[i].Area();
            }
            return max;
        }
        public double BiggestAreaRectangle()
        {
            double max = rectangles[0].Area();
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Area() > max)
                    max = rectangles[i].Area();
            }
            return max;
        }
        public double BiggestAreaTrapezoid()
        {
            double max = trapezoids[0].Area();
            for (int i = 1; i < trapezoids.Length; i++)
            {
                if (trapezoids[i].Area() > max)
                    max = trapezoids[i].Area();
            }
            return max;
        }
        public double BiggestAreaTriangle()
        {
            double max = triangles[0].Area();
            for (int i = 1; i < triangles.Length; i++)
            {
                if (triangles[i].Area() > max)
                    max = triangles[i].Area();
            }
            return max;
        }

    }
}
