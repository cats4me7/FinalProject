using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PassRegistration.Models
{
    public class PassRegistration
    {
        
        public int Id { get; set; }
        
        public string UserName { get; set; }
       
        public string Name { get; set; }
        public int NumberInHouse { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public PassRegistration()
        {
            UserName = "Not Provided.";
            Name = "Not Provided.";
            NumberInHouse = 0;
            Address = "Not Provided.";
            City = "Not Provided.";
            ZipCode = 00000;
            PhoneNumber = "Not Provided.";
            Email = "Not Provided.";
            Status = "Pending.";
        }
    }

}

