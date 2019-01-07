namespace MyApp.IO.Disk
{
    class Reader
    {
        public int everybody;
        internal int friends;
        private int me;

        public string ReadAFile(string filename){
            //This would be implementation details
            // specific for reading a file from a 
            // **DISK** device.

            return "File contents";
        }

        public void Foo() {
            // As in the lesson, this is mean to show visibility/accessibility
            // in methods and blocks.
            int count = 0;

            //the above declaration is the same as
            // private int count = 0;

            //public and internal may not be used in a method or block. Ergo,
            //the following would cause errors:
            // public int count = 0;
            // internal int count = 0;

            for (int i = 0; i < 10; i++)
            {
                // this variable is visible ONLY WITHIN this for loop!
                int index = i;
            }

            // index can't even be seen outside the loop!
            //   index = 42;

        }
       

    }
}