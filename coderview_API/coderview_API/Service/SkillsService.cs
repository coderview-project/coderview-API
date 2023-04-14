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

        public  SkillsService(ServiceContext serviceContext, ISkillsLogic skillsLogic)
        {
            _serviceContext = serviceContext;
            _skillsLogic = skillsLogic;

        }

        public List<SkillsItem> GetAllSkills()
        {
            return _skillsLogic.GetAllSkills();
        }
        int ISkillsService.PostSkills(SkillsItem skillsItem) 
        {
            _skillsLogic.PostSkills(skillsItem);
            return skillsItem.Id;
        }
        public void UpdateSkills(SkillsItem skillsItem)
        {
            _skillsLogic.UpdateSkills(skillsItem);
        }
        void ISkillsService.DeactivateSkills(int id)
        { 
            _skillsLogic.DeactivateSkills(id); 
        }

        
        public void GetSkills(int id)
        {
            throw new NotImplementedException();
        }
    }
}
