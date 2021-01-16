using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API.Models.Dtos
{
    public class Booking
    {
        public int IdBooking { get; set; }
        public int IdCustomer { get; set; }
        public int IdPayment { get; set; }
        public bool FIrstValidation { get; set; }
        public bool FinalValidation { get; set; }
    }
}
