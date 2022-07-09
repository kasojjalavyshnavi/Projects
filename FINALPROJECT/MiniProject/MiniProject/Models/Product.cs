using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MiniProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [DataType(DataType.Currency)]
        public Double? Price { get; set; }
        public string Brand { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0 : yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public string ManufactureDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpirationDate { get; set; }
    }
}

