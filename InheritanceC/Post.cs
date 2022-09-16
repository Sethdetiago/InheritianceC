using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class Post
    {
        private static int currentPostID;

        //Properties
        protected int ID { get; set; } //protected allows it to be modified by derived from Post class
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }


        //Default constructor. Default constructor is called implicitly if base constructor is not invoked
        //by deriving class.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            SendByUserName = "Default User";
            IsPublic = true;
        }

        //Instance Constuctor 
        public Post(string title, string sendByUserName, bool isPublic)
        {
            this.ID = GetNextID();        //additional method generates ID
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;

        }

        //Virtual Override of System.Object.ToString()
        public override string ToString()
        {
            return string.Format("{0} - {1} by {2}", this.ID, this.Title, this.SendByUserName);
        }


    }
}
