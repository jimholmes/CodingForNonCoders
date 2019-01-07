using System;

namespace L14.Spike
{
    /*
        A contrived example which hides report storage location 
        from users.

        Creating a new object will automatically cause the Report to
        be saved at a secret location.

        Please note: there's no error checking, validation, etc. This
        is only meant to show some things about information hiding and
        exception handling.
     */
    
    public class ReportArchiver
    {
        private Report _report;
        private string _secretStorageLocation;

        public ReportArchiver(Report report)
        {
            _report = report;
            _secretStorageLocation = GetSecretStorageLocation();
            SaveReport();
        }

        private int SaveReport() {
            string reportFilename = _report.Author + "_" + _report.Timestamp;
            // This shows a good design concept of passing in all the things
            //  a new object needs right at creation/instantiation time.
            DiskWriter writer = new DiskWriter(reportFilename, _secretStorageLocation);
            int numBytesWritten;

            try
            {
                numBytesWritten = writer.WriteStream(_report.Contents);
            }
            /*
                In this catch block we're grabbing any thrown IOExceptions, no other
                kinds of Exceptions.

                We're showing how one might throw a new Exception with sanitized
                information. None of the info from the original Exception will make 
                it out of this class. (Exceptions of different types *would* make it
                out of this class because they weren't handled.)
             */
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
                throw new System.IO.IOException("Problem saving report. Contact admins.");
            }

            return numBytesWritten;
        }

        private string GetSecretStorageLocation()
        {
            //This is simulating loading the secret from some other location
            //  such as a configuration file, database, etc.
            return "Some hidden location";
        }
    }

}
