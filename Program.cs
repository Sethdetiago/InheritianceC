using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object with default constructor
            Post post1 = new Post();
            Console.WriteLine("{0}", post1.ToString());

            //Create object to create a custom post
            Post post2 = new Post("Hello Friends", "Seth Moffett", true);
            Console.WriteLine("{0}", post2.ToString()); 


            //Now using inheritance, Creating an image Post which was inheritted by the post class
            ImagePost imagepost1 = new ImagePost();     //still calling default constuctor from parent class
            Console.WriteLine(imagepost1.ToString());   //class inherits parents ToString Method

            ImagePost imagepost2 = new ImagePost("Hello this is my first imagepost", "Seth Moffett", "https://www.imageposts.com/post1", true);
            Console.WriteLine(imagepost2);

            Console.ReadKey();


        }
    }
}
