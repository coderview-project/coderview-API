using coderview_API.Attributes;
using coderview_API.IService;
using coderview_API.Models;
using Entities;
using Microsoft.AspNetCore.Authorization;
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

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "PostSkills")]
        public int AddSkills(SkillsItem skill)
        {
            return _skillsService.AddSkills(skill);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetAllSkills")]
        public List<SkillsItem> GetAllSkills()
        {
            return _skillsService.GetAllSkills();
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPatch(Name = "ModifySkills")]
        public void UpdateSkills([FromBody] SkillsItem skill)
        {
            _skillsService.UpdateSkills(skill);  
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete(Name ="DeactivateSkills")]
        public void DeactivateSkills([FromQuery]int id)
        {
            _skillsService.DeactivateSkills(id);
        }








      


       
    }
}
