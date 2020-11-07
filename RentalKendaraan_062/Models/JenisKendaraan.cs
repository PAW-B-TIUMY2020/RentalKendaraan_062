using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_062.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraan = new HashSet<Kendaraan>();
        }

        [Required(ErrorMessage = "ID Jenis kendaraan tidak boleh kosong")]
        public int IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Jenis kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public ICollection<Kendaraan> Kendaraan { get; set; }
    }
}
