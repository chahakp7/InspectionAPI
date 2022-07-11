using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class InspectionType
    {
        public int Id { get; set; }  // Primary Key 

        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;

    }
}
