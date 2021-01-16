using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionManagement.API.Models.Dtos
{
    public class Authentification
    {
        public int IdAuthentification { get; set; }
        public int IdCustomer { get; set; }
        public string Email { get; set; }
    }
}