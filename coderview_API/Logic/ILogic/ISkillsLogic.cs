using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface ISkillsLogic 
    {
        int PostSkills(SkillsItem skill);
        void UpdateSkills(SkillsItem skill);
        void DeactivateSkills(int id);
        List<SkillsItem> GetAllSkills();

    }
}
