
using coderview_API.Attributes;
using coderview_API.IService;
using coderview_API.Models;
using coderview_API.Service;
using Data;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IUserSecurityService _userSecurityService; 
        private readonly IFileService _fileService;
        public UserController(IUserService userService, IUserSecurityService userSecurityService, IFileService fileService)
        {
            _userService = userService;
            _userSecurityService = userSecurityService;
            _fileService = fileService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "LoginUser")]
        public string Login([FromBody] LoginRequestModel loginRequest)
        {

            return _userSecurityService.GenerateAuthorizationToken(loginRequest.UserName, loginRequest.UserPassword);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpPost(Name = "PostUser")]
        public int PostUser(NewUserRequestModel newUserRequest)
        {

            return _userService.PostUser(newUserRequest);
        }
        [EndpointAuthorize(AllowedUserRols = "Administrador, Formador")]
        [HttpGet(Name = "GetAllUsers")]
        public List<UserItem> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
        [EndpointAuthorize(AllowedUserRols = "Administrador, Formador, Coder")]
        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] PatchUserRequestModel patchUserRequestModel)
        {
            try
            {
                var fileItem = new FileItem();

                fileItem.Id = 0;
                fileItem.Name = patchUserRequestModel.FileData.FileName;
                fileItem.InsertDate = DateTime.Now;
                fileItem.UpdateDate = DateTime.Now;
                fileItem.Content = Convert.FromBase64String(patchUserRequestModel.FileData.Base64FileContent);

                var fileId = _fileService.PostFile(fileItem);

                var userItem = new UserItem();
                userItem.UserName = patchUserRequestModel.UserData.UserName;
                userItem.LastName = patchUserRequestModel.UserData.LastName;
                userItem.Email = patchUserRequestModel.UserData.Email;
                userItem.Password = patchUserRequestModel.UserData.Password;
                userItem.IdPhotoFile = fileId;
                _userService.UpdateUser(userItem);
            }
            catch
            {
                throw new Exception("No se ha podido registrar los cambios."); 
            }
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpDelete(Name = "DeactivateUser")]
        public void DeactivateUser([FromQuery] int id)
        {
            _userService.DeactivateUser(id);
        }


    }
}