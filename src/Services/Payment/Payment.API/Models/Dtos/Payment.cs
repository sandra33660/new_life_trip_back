using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Models.Dtos
{
    public class Payment
    {
        public int IdPayment { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Sum { get; set; }
    }
}
