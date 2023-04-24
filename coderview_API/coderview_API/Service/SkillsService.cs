using coderview_API.IService;
using Data;
using Entities;
using Logic.ILogic;
using Logic.Logic;

namespace coderview_API.Service
{
    public class SkillsService : ISkillsService
    {
        private readonly ISkillsLogic _skillsLogic;
        private readonly ServiceContext _serviceContext;

        public  SkillsService(ISkillsLogic skillsLogic)
        {   
            _skillsLogic = skillsLogic;
        }

        public List<SkillsItem> GetAllSkills()
        {
            return _skillsLogic.GetAllSkills();
        }
        int ISkillsService.PostSkills(SkillsItem skill) 
        {
            _skillsLogic.PostSkills(skill);
            return skill.Id;
        }
        public void UpdateSkills(SkillsItem skill)
        {
            _skillsLogic.UpdateSkills(skill);
        }
        void ISkillsService.DeactivateSkills(int id)
        { 
            _skillsLogic.DeactivateSkills(id); 
        }

    }
}
