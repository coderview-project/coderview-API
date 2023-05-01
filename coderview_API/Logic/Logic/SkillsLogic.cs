using Data;
using Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class SkillsLogic : ISkillsLogic

    {
        private readonly ServiceContext _serviceContext;

        public SkillsLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<SkillsItem> GetAllSkills()
        {
            return _serviceContext.Set<SkillsItem>()
                .Where(u => u.IsActive == true) 
                .ToList();

        }
        public int AddSkills(SkillsItem skill)
        {
           return skill.Id;
        }
        public void UpdateSkills(SkillsItem skill)
        {
            _serviceContext.Skills.Update(skill);
            _serviceContext.SaveChanges();
        }

        public void DeactivateSkills(int id)
        {
            var skillToDeactivate = _serviceContext.Set<SkillsItem>()
                .Where(u => u.Id == id).First();

            skillToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();

        }

        
    }
}
