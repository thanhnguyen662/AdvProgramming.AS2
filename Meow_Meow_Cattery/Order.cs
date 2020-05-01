using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Meow_Cattery
{
    public class Order
    {
        public DateTime AppointmentSchedule;
        public Order(DateTime appointmentSchedule)
        {
            AppointmentSchedule = appointmentSchedule;
        }
    }
}
