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

            //Tạo kho
            Repository MeowMeowCatteryRepo = new Repository();
            //Thêm mèo vào kho tương ứng với từng giống
            MeowMeowCatteryRepo.addCat(123, eBreeds.Sphynx, "Orange");
            MeowMeowCatteryRepo.addCat(187, eBreeds.Sphynx, "Gray");
            MeowMeowCatteryRepo.addCat(148, eBreeds.Burmese, "Gray");
            MeowMeowCatteryRepo.addCat(154, eBreeds.Toyger, "White");


            Console.WriteLine("        Welcome to MeowMeow Cattery!"); //InputYourChoose          
            Console.WriteLine("=============================================");
            Console.WriteLine("1. Search Cat"); //InputSearch
            Console.WriteLine("2. Add Cat");
            Console.WriteLine("3. Create Order");

            Console.WriteLine();
            Console.Write("Input Your Choose: ");

            int InputYourChoose = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (InputYourChoose)
            {
                case 1:
                    {
                        Console.WriteLine("You can search in keywords: Sphynx, Toyger, Somali, Burmese");
                        Console.WriteLine("===========================================================");
                        string InputSearch = Console.ReadLine();
                        switch (InputSearch)
                        {
                            case "Sphynx":
                                {
                                    MeowMeowCatteryRepo.Search(eBreeds.Sphynx);
                                    break;
                                }
                            case "Toyger":
                                {
                                    MeowMeowCatteryRepo.Search(eBreeds.Toyger);
                                    break;
                                }
                            case "Somali ":
                                {
                                    MeowMeowCatteryRepo.Search(eBreeds.Somali);
                                    break;
                                }
                            case "Burmese":
                                {
                                    MeowMeowCatteryRepo.Search(eBreeds.Burmese);
                                    break;
                                }
                            default:
                                Console.WriteLine("No Result!");
                                break;
                        }
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("1. Sphynx");
                        Console.WriteLine("2. Toyger");
                        Console.WriteLine("3. Somali");
                        Console.WriteLine("4. Burmese");
                        Console.WriteLine("==========");
                        Console.Write("Input Breed: ");
                        int InputBreed = int.Parse(Console.ReadLine());
                        {
                            switch (InputBreed)
                            {
                                case 1:
                                    {
                                        Console.Write("Input ID: ");
                                        int InputId = int.Parse(Console.ReadLine());
                                        Console.Write("Input Color: ");
                                        string InputColor = Console.ReadLine();
                                        MeowMeowCatteryRepo.addCat(InputId, eBreeds.Sphynx, InputColor);
                                        Console.WriteLine("Add successfully: {0} | {1} | {2}", InputId, eBreeds.Sphynx, InputColor);
                                        Console.WriteLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.Write("Input ID: ");
                                        int InputId = int.Parse(Console.ReadLine());
                                        Console.Write("Input Color: ");
                                        string InputColor = Console.ReadLine();
                                        MeowMeowCatteryRepo.addCat(InputId, eBreeds.Burmese, InputColor);
                                        Console.WriteLine("Add successfully: {0} | {1} | {2}", InputId, eBreeds.Burmese, InputColor);
                                        Console.WriteLine();
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.Write("Input ID: ");
                                        int InputId = int.Parse(Console.ReadLine());
                                        Console.Write("Input Color: ");
                                        string InputColor = Console.ReadLine();
                                        MeowMeowCatteryRepo.addCat(InputId, eBreeds.Toyger, InputColor);
                                        Console.WriteLine("Add successfully: {0} | {1} | {2}", InputId, eBreeds.Toyger, InputColor);
                                        Console.WriteLine();
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.Write("Input ID: ");
                                        int InputId = int.Parse(Console.ReadLine());
                                        Console.Write("Input Color: ");
                                        string InputColor = Console.ReadLine();
                                        MeowMeowCatteryRepo.addCat(InputId, eBreeds.Somali, InputColor);
                                        Console.WriteLine("Add successfully: {0} | {1} | {2}", InputId, eBreeds.Somali, InputColor);
                                        Console.WriteLine();
                                    }
                                    break;
                            }
                            Console.ReadKey();
                        }
                    }
                    break;
                    

                case 3:
                    {
                        Console.WriteLine("Create Order");
                        Console.WriteLine("============");
                        Console.WriteLine("1. Sphynx");
                        Console.WriteLine("2. Toyger");
                        Console.WriteLine("3. Somali");
                        Console.WriteLine("4. Burmese");
                        Console.WriteLine();
                        Console.Write("Input Breed you want to buy: ");
                        int InputOrderBreed = int.Parse(Console.ReadLine());
                        switch (InputOrderBreed)
                        {
                            case 1:
                                {
                                    MeowMeowCatteryRepo.Search(eBreeds.Sphynx);
                                    Console.Write("Input ID: ");
                                    int InputOrderID = int.Parse(Console.ReadLine());
                                    Console.Write("Input DateTime To Take Meow: ");
                                    DateTime InputOrderTime = DateTime.Parse(Console.ReadLine());
                                    MeowMeowCatteryRepo.CreateOrder(InputOrderID, eBreeds.Sphynx, InputOrderTime);
                                    Console.WriteLine("Create Order Successfully: {0} | {1} | {2}", InputOrderID, eBreeds.Sphynx, InputOrderTime);
                                    Console.WriteLine();
                                }
                                break;
                            case 2:
                                {
                                    MeowMeowCatteryRepo.Search(eBreeds.Toyger);
                                    Console.Write("Input Meow ID you want to buy: ");
                                    int InputOrderID = int.Parse(Console.ReadLine());
                                    Console.Write("Input Color: ");
                                    DateTime InputOrderTime = DateTime.Parse(Console.ReadLine());
                                    MeowMeowCatteryRepo.CreateOrder(InputOrderID, eBreeds.Toyger, InputOrderTime);
                                    Console.WriteLine("Create Order Successfully: {0} | {1} | {2}", InputOrderID, eBreeds.Toyger, InputOrderTime);
                                    Console.WriteLine();
                                }
                                break;
                            case 3:
                                {
                                    MeowMeowCatteryRepo.Search(eBreeds.Somali);
                                    Console.Write("Input ID: ");
                                    int InputOrderID = int.Parse(Console.ReadLine());
                                    Console.Write("Input DateTime To Take Meow you want to buy : ");
                                    DateTime InputOrderTime = DateTime.Parse(Console.ReadLine());
                                    MeowMeowCatteryRepo.CreateOrder(InputOrderID, eBreeds.Somali, InputOrderTime);
                                    Console.WriteLine("Create Order Successfully: {0} | {1} | {2}", InputOrderID, eBreeds.Somali, InputOrderTime);
                                    Console.WriteLine();
                                }
                                break;
                            case 4:
                                {
                                    MeowMeowCatteryRepo.Search(eBreeds.Burmese);
                                    Console.Write("Input ID: ");
                                    int InputOrderID = int.Parse(Console.ReadLine());
                                    Console.Write("Input DateTime To Take Meow you want to buy: ");
                                    DateTime InputOrderTime = DateTime.Parse(Console.ReadLine());
                                    MeowMeowCatteryRepo.CreateOrder(InputOrderID, eBreeds.Burmese, InputOrderTime);
                                    Console.WriteLine("Create Order Successfully: {0} | {1} | {2}", InputOrderID, eBreeds.Burmese, InputOrderTime);
                                    Console.WriteLine();
                                }
                                break;
                        }

                    }
                    break;
            }
        }
    }
}
