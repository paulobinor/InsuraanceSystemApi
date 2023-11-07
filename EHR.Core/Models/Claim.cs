using EHR.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR.Core.Models
{
    public class Claim
    {

        [Key]
        [Column(TypeName = "varchar(64)")]
        public string ClaimID { get; set; } = System.Guid.NewGuid().ToString();
        public int NationalID { get; set; }
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
        [Column(TypeName = "varchar(50)")]
        public string ClaimStatus { get; set; } = ClaimsStatus.Submitted.ToString();
        [NotMapped]
        public decimal TotalAmount
        {
            get
            {
                return Expenses.Sum(x => x.Amount);
            }
        }
      
    }
}