using coderview_API.IService;
using coderview_API.Models;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route ("[controller]/[action]")]
    public class SkillsController : ControllerBase
    {

        private readonly ISkillsService _skillsService;

        public SkillsController(ISkillsService skillsService)
        {
            _skillsService = skillsService;
        }

        [HttpPost(Name = "PostSkills")]
        public int PostSkills(SkillsItem skill)
        {
            return _skillsService.PostSkills(skill);
        }

        [HttpGet(Name = "GetAllSkills")]
        public List<SkillsItem> GetAllSkills()
        {
            return _skillsService.GetAllSkills();
        }

        [HttpPatch(Name = "ModifySkills")]
        public void UpdateSkills([FromBody] SkillsItem skill)
        {
            _skillsService.UpdateSkills(skill);  
        }
        [HttpDelete(Name ="DeactivateSkills")]
        public void DeactivateSkills([FromQuery]int id)
        {
            _skillsService.DeactivateSkills(id);
        }








      


       
    }
}
