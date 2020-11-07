using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_062.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public DateTime? TglPengembalian { get; set; }

        [Required(ErrorMessage = "ID Peminjaman tidak boleh kosong")]
        public int? IdPeminjaman { get; set; }

        [Required(ErrorMessage = "ID Kondisi tidak boleh kosong")]
        public int? IdKondisi { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int? Denda { get; set; }

        public Peminjaman IdPeminjamanNavigation { get; set; }
        public KondisiKendaraan IdPengembalianNavigation { get; set; }
    }
}
