using System;
using System.Collections.Generic;

#nullable disable

namespace UCP1_PAW_054_A.Models
{
    public partial class Transaksi
    {
        public int IdTransaksi { get; set; }
        public string IdCustomer { get; set; }
        public string IdProduk { get; set; }
        public string TotalTransaksi { get; set; }
    }
}
