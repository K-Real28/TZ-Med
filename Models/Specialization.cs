using TZ_Med.Models.BaseModels;

namespace TZ_Med.Models
{
    public class Specialization : NamedBaseEnity
    {
        public List<SpecializationDoctor> SpecializationDoctors { get; set; } = new();
    }
}
