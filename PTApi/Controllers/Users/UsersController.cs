using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using PTApi.Data.Repositories;
using PTApi.Methods;
using PTApi.Models;
using PTApi.Persistence.Blob;
using PTApi.Services;
using PTApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PTApi.Controllers
{

    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController: Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IBlobStorage _blobStorage;
        CloudBlobClient blobClient;
        string baseUri = "https://pmofilesdb.blob.core.windows.net/";

        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        private readonly IGetIdsWithPartIdsMethod _getIdsWithPartIds;
        private readonly IGeneratePublicIdMethod _getpublicId;

        public string CreateNewId(string id)
        {
            return _getpublicId.PartId(id, 8);
        }


        public UsersController(UserManager<ApplicationUser> userManager, IMapper mapper, IBlobStorage blobStorage, IUserService userService,
            IGeneratePublicIdMethod getpublicId, IGetIdsWithPartIdsMethod getIdsWithPartIds, IUnitOfWork unitOfWork)
        {
            _userService = userService;
            _userManager = userManager;
            _mapper = mapper;
            _blobStorage = blobStorage;
            _getIdsWithPartIds = getIdsWithPartIds;
            _getpublicId = getpublicId;
            _unitOfWork = unitOfWork;
            var credentials = new StorageCredentials("pmofilesdb", "tb9gl6ComX8UHTFrrfx++v3C9YQO9pcMy/ZxHOEffR9wZzIhZWbJppvhqBLMiVZ1Ki0Y8x5EAKEk1eEsCxpTyQ==");
            blobClient = new CloudBlobClient(new Uri(baseUri), credentials);
        }

        public class EditProfileData
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

       
        

        [HttpGet("getusers/{companyId}")]
        [Authorize]
        public async Task<IEnumerable<UsersViewModel>> GetUsers(string companyId)
        {
            var roleGroup = _userService.UserRoleGroup();
            var comp = _userService.GetSecureUserCompany();

            if (companyId != comp)
            {
                return await Task.FromResult<IEnumerable<UsersViewModel>>(null);

            }

            var allUsers = _unitOfWork.Users.GetAllCompanyUserFromResourceList(comp);

            return await Task.FromResult(allUsers);
        }



    }
}