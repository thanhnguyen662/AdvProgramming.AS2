using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Meow_Cattery
{
    public enum eBreeds
    {
        Sphynx, Burmese, Toyger, Somali
    };
    public class Cat
    {
        public int Id;
        public string Color;
        public string Name;
        public eBreeds Breed;
        public List<Order> Orders;

        //Khởi tạo đối tượng mèo
        public Cat(int id, eBreeds breed, string color)
        {
            Id = id;
            Breed = breed;
            Color = color;
            Orders = new List<Order>();
        }

        //Khởi tạo thông tin mèo
        public void infoCat()
        {
            Console.WriteLine(" - ID: {0} | Breed: {1} | Color: {2}", Id, Breed, Color);
        }

        public void addOrder(DateTime appointmentSchedule)
        {
            Orders.Add(new Order(appointmentSchedule));
        }
    }
}
