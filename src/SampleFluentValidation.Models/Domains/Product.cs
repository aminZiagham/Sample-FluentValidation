using System;

namespace SampleFluentValidation.Models.Domains 
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CreationDate { get; set; }
    }
}