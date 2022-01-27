using System;

    namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        ///<summary> 
        ///This is the main sample application function
        ///</summary>
        
        static void Main(string[] args)
        {
            // Single line comments starts with two slashes
            // You can have as may as these as you want

            Console.WriteLine("Hello World!");

            /*
            Multiple line comments starts with a slash and a star
            and can continue for several lines
            until a closing star and slash are encountered.
            */
        }
    }
}
