using DPBD.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    [DPValidation]
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string IdCardNumber { get; set; }
        [Required]
        public string Country { get; set; }
     
    }

}
