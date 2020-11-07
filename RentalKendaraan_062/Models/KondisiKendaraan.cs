using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_062.Models
{
    public partial class KondisiKendaraan
    {
        [Required(ErrorMessage = "ID Kondisi tidak boleh kosong")]
        public int IdKondisi { get; set; }

        [Required(ErrorMessage = "Kondisi tidak boleh kosong")]
        public string NamaKondisi { get; set; }

        public Pengembalian Pengembalian { get; set; }
    }
}
