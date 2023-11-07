using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR.Core.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public required string ClaimID { get; set; }

        [ForeignKey(nameof(ClaimID))]
        public Claim Claim { get; set; }
        [Column(TypeName = "varchar(50)")]
        public  string ExpenseType { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ExpenseDescription { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Amount { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ExpenseDate { get; set; }

    }
}