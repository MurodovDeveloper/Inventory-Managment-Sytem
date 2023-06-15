﻿using Infrastructure.Services.Friendship;
using Infrastructure.Services.Post;
using Infrastructure.Services.UserServices;

namespace Infrastructure.Services.Profile
{
    public class ProfileServiceModel
    {
        public ProfileServiceModel()
        {
            this._posts = new List<PostServiceModel>();
        }

        public UserServiceModel User { get; set; }

        public string CurrentUserId { get; set; }

        public string AvatarUrl { get; set; }

        private List<PostServiceModel> _posts;
        public ICollection<PostServiceModel> Posts
        {
            get => this._posts;
            set
            {
                if (value.Count > 0)
                {
                    this._posts = value
                        .OrderByDescending(d => d.DatePosted)
                        .ToList();
                }
            }
        }

        /// <summary>
        /// Depending of the enum value it will be generated different layout
        /// </summary>
        public ServiceModelFriendshipStatus FriendshipStatus { get; set; }
    }
}