
using Entities;

namespace coderview_API.IService
{
    public interface ISkillsService
    {
        int PostSkills(SkillsItem skill);
        void UpdateSkills(SkillsItem skill);
        void DeactivateSkills(int id);
        List<SkillsItem> GetAllSkills();
    }
}
