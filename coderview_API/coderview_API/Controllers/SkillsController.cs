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
        public int PostSkills(SkillsItem skillsItem)
        {
            return _skillsService.PostSkills(skillsItem);
        }

        [HttpGet(Name = "GetAllSkills")]
        public List<SkillsItem> GetAllSkills()
        {
            return _skillsService.GetAllSkills();
        }

        [HttpPatch(Name = "ModifySkills")]
        public void Patch([FromBody] PatchSkillsRequestModel patchSkillsRequestModel)
        {
            try
            {
                var skillsItem = new SkillsItem();

                skillsItem.Title = patchSkillsRequestModel.SkillsData.Title;
                skillsItem.Criteria = patchSkillsRequestModel.SkillsData.Criteria;
                skillsItem.Actions = patchSkillsRequestModel.SkillsData.Actions;
                _skillsService.UpdateSkills(skillsItem);
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        [HttpDelete(Name ="DeactivateSkills")]
        public void DeactivateSkills([FromQuery]int id)
        {
            _skillsService.DeactivateSkills(id);
        }








      


       
    }
}
