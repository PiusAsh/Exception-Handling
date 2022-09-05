using System;

namespace Error_Handling
{
    class Program
    {

        int result;

        Program()
        {
            result = 0;
        }

        public void Division(int[] a)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                { 
                    int z = i + 1;
                    result = Math.Max(result, a[i] / a[z]);
                }


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);

            }

            finally
            {
                Console.WriteLine($"The result is {result}");
            }
        }
        static void Main(string[] args)
        {
           var program = new Program();
            int[] a = { 24, 5, 0, 56};
            program.Division(a);
            
        }
    }
}
