using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RentalKendaraan_062.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }
        [DisplayName("ID")]
        public int IdPeminjaman { get; set; }
        [DisplayName("Tanggal Peminjaman")]
        public DateTime? TglPeminjaman { get; set; }
        [DisplayName("Kendaraan")]
        public int? IdKendaraan { get; set; }
        [DisplayName("Customer")]
        public int? IdCustomer { get; set; }
        [DisplayName("Jaminan")]
        public int? IdJaminan { get; set; }
        [DisplayName("Biaya")]
        public int? Biaya { get; set; }
        [DisplayName("Customer")]
        public Customer IdCustomerNavigation { get; set; }
        [DisplayName("Jaminan")]
        public Jaminan IdJaminanNavigation { get; set; }
        [DisplayName("Kendaraan")]
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
