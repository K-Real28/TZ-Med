using TZ_Med.Models.BaseModels;

namespace TZ_Med.Models
{
    public class City : NamedBaseEnity
    {
        public List<Polyclinic> Polyclinics { get; set; } = new();
    }
}
