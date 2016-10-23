using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparetion
{
    class SweetDesert
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int guestNumber = int.Parse(Console.ReadLine());
            double bannanaPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());
            var portion = 2 * bannanaPrice + 4 * eggsPrice + 0.2 * berriesPrice;
            var neededPortion =Math.Ceiling(guestNumber / 6.0);
            var portionPrices = portion *neededPortion;
            if (portionPrices>money)
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", portionPrices - money);
            }
            else
            {
                Console.WriteLine("Ivancho has");
            }
        }
    }
}
