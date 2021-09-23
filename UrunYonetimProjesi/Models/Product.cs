using System;
using System.Collections.Generic;


namespace UrunYonetimProjesi.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime ProductExpireDate { get; set; }
        public decimal ProductFee { get; set; }
        public string CurrencyName { get; set; }

    }
}
