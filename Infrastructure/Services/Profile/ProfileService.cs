using Infrastructure.Services.Image;
using Infrastructure.Services.Post;
using Infrastructure.Services.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Profile
{
    public class ProfileService : IProfileService
    {
        private readonly IPostService _postService;
        private readonly IUserService _userService;
        private readonly IImageService _imageService;

        public ProfileService(
            IPostService postService,
            IUserService userService,
            IImageService imageService)
        {
            this._postService = postService;
            this._userService = userService;
            this._imageService = imageService;
        }

        public async Task<ProfileServiceModel> GetProfileAsync(string userId)
            => new ProfileServiceModel()
            {
                User = await this._userService
                    .GetUserByIdAsync(userId),
                Posts = await this._postService
                    .GetPostsByUserIdAsync(userId),
                AvatarUrl = await this._imageService
                    .GetAvatarAsync(userId)
            };
    }
}
