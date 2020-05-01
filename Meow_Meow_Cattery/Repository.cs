using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Meow_Cattery
{
    public class Repository
    {
        //Khai báo List<Cat>
        public List<Cat> Sphynx;
        public List<Cat> Burmese;
        public List<Cat> Toyger;
        public List<Cat> Somali;
        public List<Cat> Breeds;

        //Tạo kho tương ứng với 4 giống mèo
        public Repository()
        {
            Sphynx = new List<Cat>();
            Burmese = new List<Cat>();
            Toyger = new List<Cat>();
            Somali = new List<Cat>();
            Breeds = new List<Cat>();
        }

        //Tạo phương thức thêm mèo vào kho của từng giống và kho chung(Breeds)
        public void addCat(int id, eBreeds breed, string color)
        {
            //Thêm mèo theo từng giống
            if(breed == eBreeds.Sphynx)
            {
                Sphynx.Add(new Cat(id, breed, color));
                Breeds.Add(new Cat(id, breed, color));
            }

            else if (breed == eBreeds.Burmese)
            {
                Burmese.Add(new Cat(id, breed, color));
                Breeds.Add(new Cat(id, breed, color));
            }

            else if (breed == eBreeds.Toyger)
            {
                Toyger.Add(new Cat(id, breed, color));
                Breeds.Add(new Cat(id, breed, color));
            }

            else
            {
                Somali.Add(new Cat(id, breed, color));
                Breeds.Add(new Cat(id, breed, color));
            }
        }

        //Tạo phương thức kiểm tra mèo theo từng giống và kho chung(Breeds) hỗ trợ phương thức Search
        public bool isAvailable(eBreeds breeds)
        {
            bool result = true;
            Cat tempResult = null;

            //Kiểm tra giống mèo còn trong kho chung
            tempResult = Breeds.FirstOrDefault(x => x.Breed == breeds); // x = Breeds
            {
                if(tempResult == null)
                {
                    result = false;
                }
            }
            return result;
        }


        //Tạo phương thức search mèo theo từng giống
        public void Search(eBreeds breeds)
        {
            Console.WriteLine();
            Console.WriteLine("All cats of the breed are currently available {0}", breeds);
            Console.WriteLine();

            //Search mèo theo từng giống
            if (breeds == eBreeds.Sphynx)
            {
                if (isAvailable(breeds) == true)
                {
                    foreach (var sphynx in Sphynx)
                    {
                        sphynx.infoCat();
                    }
                }
                else
                {
                    Console.WriteLine(" - This breed (Sphynx) has sold out, choose another breed! ");
                    Console.WriteLine();
                }
            }

            if (breeds == eBreeds.Burmese)
            {
                if (isAvailable(breeds) == true)
                {
                    foreach (var sphynx in Burmese)
                    {
                        sphynx.infoCat();
                    }
                }
                else
                {
                    Console.WriteLine(" - This breed (Burmese) has sold out, choose another breed! ");
                }
            }

            if (breeds == eBreeds.Toyger)
            {
                if (isAvailable(breeds) == true)
                {
                    foreach (var sphynx in Toyger)
                    {
                        sphynx.infoCat();
                    }
                }
                else
                {
                    Console.WriteLine(" - This breed (Toyger) has sold out, choose another breed! ");
                }
            }

            if (breeds == eBreeds.Somali)
            {
                if (isAvailable(breeds) == true)
                {
                    foreach (var sphynx in Somali)
                    {
                        sphynx.infoCat();
                    }
                }
                else
                {
                    Console.WriteLine(" - This breed (Somali) has sold out, choose another breed! ");
                }
            }
        }

        //Khởi tạo Order để đặt mua mèo
        public Cat CreateOrder(int id, eBreeds breeds, DateTime appointmentSchedule)
        {
            Cat Result = null;
            Result = Breeds.SingleOrDefault(x => x.Id == id && isAvailable(x.Breed));
            //Kiểm tra mèo theo id còn trong kho hay không 
            if (Result == null)
            {
                Console.WriteLine(" - Cat is not available");
            }
            else
            {
                Console.WriteLine();
                Result.addOrder(appointmentSchedule);
                Console.WriteLine("Order detail: ");
                Result.infoCat();
                Console.WriteLine(" + Please come to the store to accept pets at: {0}", appointmentSchedule);
                Console.WriteLine();
            }
            return Result;
        }
    }
}
