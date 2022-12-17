using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace complete_crud_mvc_6.Models
{
    public class Trans
    {
        [Key]
        public int TransID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Account ID")]
        [Required(ErrorMessage="This is field is required")]
        [MaxLength(12,ErrorMessage ="Max 12")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd-MMM-yy")]
        public DateTime Date { get; set; }
    }
}
