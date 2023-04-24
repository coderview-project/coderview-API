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
        public int PostSkills(SkillsItem skillsItem)
        {
           return skillsItem.Id;
        }
        public void UpdateSkills(SkillsItem skillsItem)
        {
            throw new NotImplementedException();
        }

        public void DeactivateSkills(int id)
        {
            var skillsToDeactivate = _serviceContext.Set<SkillsItem>()
                .Where(u => u.Id == id).First();

            skillsToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();

        }

        
    }
}
