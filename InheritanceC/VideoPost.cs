using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;
using System.Threading;

namespace InheritanceC
{
    class VideoPost : Post
    {
        //Member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        //Properties
        public string VideoURL { get; set; }
        public int VideoLength { get; set; }
        
        

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, int videoLength, bool isPublic)
        {
            //All Properies  inherited by post except VideoURL and VideoLength 
            this.ID = GetNextID();  //GetNextID() is also inherited by the parent class and can be called simply
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.VideoURL = videoURL;       //properties not inheritted by parent class
            this.VideoLength = videoLength;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            if (IsPublic)
            {
                return string.Format("{0} - {1} by {2} URL: {3}, Videos length is {4}", this.ID, this.Title, this.SendByUserName, this.VideoURL, this.VideoLength);
            }
            else
            {
                return "Sorry this post is Private";
            }
        }

        //Method to start playing the video
        public void Play()
        {

            if (!isPlaying)
            {
                isPlaying = true;                         //Boolean set so that it can be stopped later
                Console.WriteLine("Video Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);    //Setting up a timer with a callback every second (1000 ms)
            }
        }

        //Every time the timer callback period has elapsed this method will be called
        private void TimerCallback(Object o)
        {
            if (currDuration < VideoLength)
            {
                
                currDuration++;
                Console.WriteLine("Video Time {0}", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();     //if video has finished Stop method will be called
            }

        }

        //Method to stop video from playing
        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying = false;
                if(currDuration >= VideoLength)
                {
                    Console.WriteLine("Video has finished playing");
                }
                else
                {
                    Console.WriteLine("Video Stopped at {0}", currDuration);
                }
                Console.WriteLine("Video Stopped at {0}", currDuration);
                currDuration = 0;       //Reset currDuration to be used again
                timer.Dispose();        //dispose of timer when done using
            }
            
            
        }
        
        
    }
}
