using System.ComponentModel.DataAnnotations;


namespace DefaultStore.Models
{
    public class Product
    {

        public int Barcode { get; set; }

        public string Name { get; set; }

        public string Description { get; set; } 

        public decimal Price { get; set; }

    }
}
