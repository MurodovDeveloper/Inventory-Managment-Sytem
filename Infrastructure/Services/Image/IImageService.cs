﻿using Infrastructure.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Image
{
    public interface IImageService 
    {
        Task AddImageAsync(ImageServiceModel serviceModel);
        Task DeleteAvatarAsync(string userId);
        Task DeleteImageAsync(int imageId);
        Task<string> GetAvatarAsync(string userId);
        Task<string> GetImageByIdAsync(int imageId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>KeyValuePair where int is storing id and string storing base64 image</returns>
        IEnumerable<KeyValuePair<int, string>> GetAllImagesByUserId(string userId);
        bool IsThereAvatar(string userId);
        Task<bool> IsImageExistAsync(int imageId);
        Task AddAvatarAsync(AvatarServiceModel avatarServiceModel);
    }
}
