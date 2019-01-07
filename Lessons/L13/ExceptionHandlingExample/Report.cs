using System;

namespace L13.ExceptionHandlingExample
{
    /*
        A simple object to show you the concept of passing objects as
        data around a system.
     */
    public class Report
    {
        private string _contents;
        private string _author;
        private DateTime _timestamp;

        /*
            These three accessors are how .NET handles "properties."
            Properties can provide get (retrive) and set (save) access
            to prviate fields in a class. Both get and set work as methods--
            you can write complex behaviors there.

            The concept of get/set having access to class variables sort of
            breaks the OOP fundamental of encapsulation. Go read the provocative
            post by Allen Holub:
            https://www.javaworld.com/article/2073723/core-java/why-getter-and-setter-methods-are-evil.html
    
         */
        public string Author{
            get{ return _author; }
        }

        public string Contents{
            get {return _contents; }
        }

        public DateTime Timestamp{
            get { return _timestamp; }
        }

        /*
            A very basic constructor (also called 'ctor').

            The DateTime.Now call is a nifty way to get current date time.
         */
        public Report(string contents, string author) {
            _contents = contents;
            _author = author;
            _timestamp = DateTime.Now;
        }

        /*
            ToString is implemented at the most basic Object level in .NET. It
            provides an easy way for objects/types to spit out a string of what
            they're holding. Complex types need to create their own ToString if
            they want to put out sensible output for thier contents.

            The keyword "override" simply says I'm replacing the basic Object.ToString
            with my own implementation.
         */
        public override string ToString() {
            return 
                "Author: " + _author +
                " Timestamp: " + _timestamp.ToShortDateString() + 
                " Contents: " + _contents;
        }
    }
}
