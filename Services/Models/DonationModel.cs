using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{

    public enum EMOP { Cash, CreditCard, Check }
    public class DonationModel
    {
        public int DonationId { get; set; }
        public int DonorId { get; set; }
        [ForeignKey("DonorId")]
        public virtual DonorModel Donor { get; set; }
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual StudentModel Student { get; set; }
        public List<GiftModel> Gifts { get; set; }
        public double Amount { get; set; }
        public int MyProperty { get; set; }
        public EMOP MOP { get; set; }
        public bool PrintReceipt { get; set; }

    }
}
