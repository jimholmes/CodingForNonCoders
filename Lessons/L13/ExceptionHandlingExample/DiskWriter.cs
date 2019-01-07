using System;

namespace L13.ExceptionHandlingExample
{

    public class DiskWriter
    {
        private string _fileName;
        private string _fileLocation;

        public DiskWriter(string fileName, string fileLocation){
            _fileName = fileName;
            _fileLocation = fileLocation;

        }

        public int WriteStream(string textToWrite) {
            /*
                Simulates trying to write a file to a physical file; however,
                we're pretending the disk is damaged and as such this operation
                will throw an exception.

                Note the exception thrown is specifically calling out the location
                of the file. This is something that is fine at this level of the 
                system, but remember: we do NOT want to show this to users at
                a higher level of the system!
             */

             if (textToWrite.Length > 0)
             {
                throw new System.IO.IOException("Error writing to disk at " + _fileLocation);    
             }
 
            return 0;
        }
        
    }
    
}
