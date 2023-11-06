using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EHR.Api.Dtos
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string ExpenseType { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string ExpenseDescription { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Amount { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ExpenseDate { get; set; }

    }
}