
using Entities;

namespace coderview_API.IService
{
    public interface ISkillsService
    {
        int PostSkills(SkillsItem skillsItem);
        void UpdateSkills(SkillsItem skillsItem);
        void DeactivateSkills(int id);
        void GetSkills(int id);
        List<SkillsItem> GetAllSkills();
    }
}
