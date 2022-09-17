using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{   
    //Image post inherits from Post class and adds
    //a property (ImageURL) and two constuctors
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //All Properies  inherited by post except ImageURL 
            this.ID = GetNextID();  //GetNextID() is also inherited by the parent class and can be called simply
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.ImageURL = imageURL;       //only property not inherited by Post thus not recognized by Parent Class
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} by {2} URL: {3}", ID, Title, SendByUserName, ImageURL);
        }


    }
}
