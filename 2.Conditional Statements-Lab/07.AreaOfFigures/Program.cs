using System.Drawing;

namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* вида и размерите на геометрична фигура и пресмята лицето й квадрат(square), 
             * правоъгълник(rectangle), кръг(circle) и триъгълник(triangle).*/
            string nameOfShape = (Console.ReadLine());
            //(square): на следващия ред се чете едно дробно число -дължина на страната му
            if (nameOfShape == "square")
            {
                double lengthSquare = double.Parse(Console.ReadLine());
                double faceOfSquare = lengthSquare * lengthSquare;
                Console.WriteLine($"{faceOfSquare :f3}");
            }
            //(rectangle): на следващите два реда четат две дробни числа -дължините на страните му
            else if (nameOfShape == "rectangle")
            {
                double lengthRectangle1 = double.Parse(Console.ReadLine());
                double lengthRectangle2 = double.Parse(Console.ReadLine());
                double faceOfRectangle = lengthRectangle1 * lengthRectangle2;
                Console.WriteLine($"{faceOfRectangle:f3}");
            }
            //(circle): на следващия ред чете едно дробно число - радиусът на кръга
            else if (nameOfShape == "circle")
            {
                double radiusCircle = double.Parse(Console.ReadLine());
                double faceOfCircle = Math.PI * radiusCircle * radiusCircle;
                Console.WriteLine($"{faceOfCircle:f3}");
            }

            //(triangle): на следващите два реда четат две дробни числа -дължината на страната му и дължината на височината към нея
            else if (nameOfShape == "triangle")
            {
                double lengthTriangle = double.Parse(Console.ReadLine());
                double higthTriangle = double.Parse(Console.ReadLine());
                double faceOfTriangle = (lengthTriangle * higthTriangle) / 2;
                Console.WriteLine($"{faceOfTriangle:f3}");
            }
           
        }
    }
}