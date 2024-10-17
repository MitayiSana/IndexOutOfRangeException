namespace IndexOutOfRangeExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] series = { 10, 20, 30, 40 };
            try
            {
                for(int i=0;i < series.Length;i++)
                {
                    Console.WriteLine(series[5]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
