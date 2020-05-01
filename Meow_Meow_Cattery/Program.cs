using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Meow_Cattery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("================== (^•,•^) ==================");

            //Test Cat
            Cat SphynxMeow = new Cat(1, eBreeds.Sphynx, "Yellow");
            SphynxMeow.infoCat();

            Console.WriteLine();
            Console.ReadKey();

            //Tạo kho
            Repository MeowMeowCatteryRepo = new Repository();
            //Thêm mèo vào kho tương ứng với từng giống
            MeowMeowCatteryRepo.addCat(123, eBreeds.Sphynx, "Orange");
            MeowMeowCatteryRepo.addCat(187, eBreeds.Sphynx, "Gray");
            MeowMeowCatteryRepo.addCat(148, eBreeds.Burmese, "Gray");
            MeowMeowCatteryRepo.addCat(154, eBreeds.Toyger, "White");


            //Test Search
            MeowMeowCatteryRepo.Search(eBreeds.Sphynx);
            MeowMeowCatteryRepo.Search(eBreeds.Somali);
            MeowMeowCatteryRepo.Search(eBreeds.Burmese);

            //Test Order
            MeowMeowCatteryRepo.CreateOrder(123, eBreeds.Sphynx, new DateTime(2020, 12, 1));
            MeowMeowCatteryRepo.CreateOrder(133, eBreeds.Somali, new DateTime(2020, 12, 1));
        }
    }
}
