﻿using Infrastructure.Services.Comment;
using Infrastructure.Services.Group;
using Infrastructure.Services.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Post
{
    public class PostServiceModel
    {
        public PostServiceModel()
        {
            this.TaggedFriends = new List<UserServiceModel>();
            this._comments = new List<CommentServiceModel>();
        }

        public int PostId { get; set; }

        public string Content { get; set; }

        public DateTime DatePosted { get; set; }

        public UserServiceModel Author { get; set; }

        public int? GroupId { get; set; }

        public GroupServiceModel Group { get; set; }

        public ICollection<UserServiceModel> TaggedFriends { get; set; }

        private List<CommentServiceModel> _comments;
        public ICollection<CommentServiceModel> Comments
        {
            get => this._comments;
            set
            {
                if (value.Count > 0)
                {
                    this._comments = value
                        .OrderByDescending(d => d.DatePosted)
                        .ToList();
                }
            }
        }
    }
}
