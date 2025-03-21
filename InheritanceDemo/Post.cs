﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Post
    {
        private static int currentPostId;
        protected int ID {  get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My firs post";
            SendByUsername = "Daniel S" ;
            IsPublic = true;
        }

        // Instance constructor that has three parameters 
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Virtual method override the System.Object.ToString method that is inherited
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}",this.ID, this.Title, this.SendByUsername);
        }
    }
}
