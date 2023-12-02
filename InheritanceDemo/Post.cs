using System;
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
            Console.WriteLine("Constructor set");
        }

    }
}
