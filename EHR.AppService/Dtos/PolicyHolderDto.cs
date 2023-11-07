using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EHR.Api.Dtos
{
    public class PolicyHolderDto
    {
        public DateTime DoB { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string NationalID { get; set; }
        public string PolicyNumber { get; set; }

    }
}