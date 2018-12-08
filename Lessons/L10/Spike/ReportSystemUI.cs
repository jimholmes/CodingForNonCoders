using System;

namespace L10.Spike
{
    /*
        Part of the very contrived example to demonstrate exception flow.
        The premise is a system that writes reports with sensitive information to
        a location that's hidden from most users due to security concerns. Most 
        users shouldn't know where the location is, so they never see it shown on
        the UI, nor do they get to chose where it is.

        Moreover, the system should never reveal information about the location if
        there's some sort of a problem saving.

        This is all very simplistic and contrived. Don't write your system code this
        way. Please.
     */
    public class ReportSystemUI
    {
        public void WriteTheReport() {
            Report report = new Report("Stuff to save", "Jim Holmes");
            ReportArchiver archiver;
            // We have to surround calls that might cause Exceptions
            //  with a try/catch block
            try
            {
                archiver = new ReportArchiver(report);   
            }
            //This 'catch' will handle ANY type of System Exception, not just
            // System.IO.IOException that's thrown by our example.
            //This may or may not be a good idea for your particular situation.
            //  It's just an illustration here.
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }    

        }
    }
    
}