using SolidPrinciples.DependencyInversion.FollowPrinciple;
using SolidPrinciples.LiskovSubstitution;
using System.Drawing;

namespace SolidPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //LiskovSubstitution.Rectangle rectangle = new LiskovSubstitution.Rectangle(10,20);
            //GetArea(rectangle);
            LiskovSubstitution.Rectangle square = new Square();
            //square.Height = 10;
            //Console.WriteLine(square.GetArea());
            ////GetArea(square);
            INotifier emailer = new Emailer();
            INotifier sms = new Sms();
            WeatherTraker weatherTraker = new WeatherTraker(sms);
            weatherTraker.SetCurrentCondition("Test");
        }

        public static void GetArea(LiskovSubstitution.Rectangle rectangle)
        {
            int width =rectangle.GetWidth();
            rectangle.SetHeight(100);
            Console.WriteLine($"Area01 ={width * 100}" );
            Console.WriteLine($"Area02 ={rectangle.GetArea()}");
        }


    }
}
