using System;
using System.ComponentModel.DataAnnotations;
namespace RazorTees.Models
{
    public class Tees
    {
        public int Shirt_ID { get; set; }
        public string ProductName { get; set; }
        [DataType(DataType.Date)]
   
    }
}


