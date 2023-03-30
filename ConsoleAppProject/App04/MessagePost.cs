using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// version 0.1
    /// </author>
    public class MessagePost
    {
        
        // an arbitrarily long, multi-line message
        public String Message { get; }

       
        public MessagePost(String text)
        {
           
            Message = text;
           
        }

       
      

        ///
        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public void Display()
        {
            Console.WriteLine();
          
            Console.WriteLine($"    Message: {Message}");
          
            Console.WriteLine();

         
        }

       
        }
    }
}

