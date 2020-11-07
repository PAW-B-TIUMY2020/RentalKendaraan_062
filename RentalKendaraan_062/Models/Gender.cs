using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_062.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        [Required(ErrorMessage = "ID Gender tidak boleh kosong")]
        public int IdGender { get; set; }

        [Required(ErrorMessage = "Nama tidak boleh kosong")]
        public string NamaGender { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
