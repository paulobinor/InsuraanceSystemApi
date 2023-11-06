using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EHR.Api.Dtos
{
    public class PolicyHolder
    {
        [Key]
        public string Id { get; set; }
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