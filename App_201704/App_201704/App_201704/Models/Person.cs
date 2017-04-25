using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_201704.Models
{
    public class Person
    {
        public string Name { get; private set; }

        public string ImageUrl { get; private set; }

        public string PhoneNumber { get; private set; }

        public Person(string name, string imageUrl, string phoneNumber)
        {
            this.Name = name;
            this.ImageUrl = imageUrl;
            this.PhoneNumber = phoneNumber;
        }
        


    }
}
