using TZ_Med.Models.BaseModels;

namespace TZ_Med.Models
{
    public class SpecializationDoctor : BaseEntity
    {
        public int? SpecializitionId { get; set; }
        public Specialization? Specialization { get; set; }

        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
