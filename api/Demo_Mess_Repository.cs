namespace DemoTestEffort.api
{
    public class Demo_Mess_Repository
    {
        
        public void WriteToDatabase(int Remainder)
        {
            if (Remainder == 0)
            {
                // write A

            }
            else
            {
                // write B
            }
        }

        public void WriteToDatabase_Changed(int Remainder)
        {
            if (Remainder == 0)
            {
                // write A
            }
            else if (Remainder == 1)
            {
                // write B
            }
            else if (Remainder == 2)
            {
                // write C
            }
        }
    }
}