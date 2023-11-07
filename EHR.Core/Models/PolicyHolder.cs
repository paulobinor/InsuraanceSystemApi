using System.ComponentModel.DataAnnotations;

namespace EHR.Core.Models
{
    public class PolicyHolder
    {
        [Key]
        public int Id { get; set; }
        public DateTime DoB { get; set; }
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string SurName { get; set; }
        public string NationalID { get; set; }
        public string PolicyNumber { get; set; }

    }
}