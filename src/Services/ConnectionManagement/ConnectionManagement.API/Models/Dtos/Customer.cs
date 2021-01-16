using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionManagement.API.Models.Dtos
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public int ZIPCode { get; set; }
        public int PhoneNumber { get; set; }
        public string AlbumPhotoCustomer { get; set; }
    }
}