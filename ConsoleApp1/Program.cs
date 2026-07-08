using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int smallCarpetPrice = 25;
            //int largeCarpetPrice = 35;
            //double tax = 6;

            //Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");
            //Console.WriteLine(".....................");

            //Console.WriteLine("Please enter the number of small rooms you would like cleaned:");
            //int smallRoomNum = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the number of large rooms you would like cleaned:");
            //int largeRoomNum = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Estimate for carpet cleaning service");
            //Console.WriteLine($"Number of small carpets:{smallRoomNum}");
            //Console.WriteLine($"Number of large carpets:{largeRoomNum}");
            //Console.WriteLine($"Price per small carpet:{smallCarpetPrice}$");
            //Console.WriteLine($"Price per large carpet:{largeCarpetPrice}$");

            //int largeCarpetsCost = largeCarpetPrice * largeRoomNum;
            //int smallCarpetsCost = smallCarpetPrice * smallRoomNum;
            //int totalCost = smallCarpetsCost + largeCarpetsCost;
            //Console.WriteLine($"Cost:{totalCost}$");

            //double smallCarpetsTax = (smallCarpetPrice * smallRoomNum) * tax / 100;
            //double largeCarpetsTax = (largeCarpetsCost * largeRoomNum) * tax / 100;
            //double totalTax = smallCarpetsTax + largeCarpetsTax;
            //Console.WriteLine($"tax:{totalTax}$");

            //Console.WriteLine("===============================");
            //Console.WriteLine($"Total estimate:{totalCost + totalTax}$");
            //Console.WriteLine(  "This estimate is valid for 30 days");

            //---------------------------------------------------------------------------

            int perSmall = 25;
            int perLarg = 35;
            double tax = 6;


            Console.WriteLine("Welcome To Islam's Carpet Cleaning Service");

            Console.WriteLine("Please Enter Your Small Room Of Number");
            int sRoomNu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Your Larg Room Of Number");
            int lRoomNu = Convert.ToInt32(Console.ReadLine());

            int perSmallPrice = perSmall * sRoomNu;
            int perLargPrice = perLarg * lRoomNu;
            int cost = perSmallPrice + perLargPrice;
            double totalTax = cost * (tax/100);
            double totalEstimate = cost + totalTax;

            Console.WriteLine($"Number of small carpets:{sRoomNu}");
            Console.WriteLine($"Number of large carpets:{lRoomNu}");
            Console.WriteLine($"Price per small carpet:{perSmall:C}");
            Console.WriteLine($"Price per larg carpet:{perLarg:C}");
            Console.WriteLine($"Sales tax rate is:{tax:P}");
            Console.WriteLine($"Cost:{cost:C}");
            Console.WriteLine($"tax:{totalTax:C}");
            Console.WriteLine($"Total estimate:{totalEstimate:C}");


        }
    }
}
