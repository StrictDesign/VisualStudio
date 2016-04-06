using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrictDesign.Demo
{
    public class ErrorHandling
    {
        static void Main(string[] args)
        {
            ErrorHandling e = new ErrorHandling();
            e.division(24, 0);
            Console.ReadKey();
        }
        int result;
        ErrorHandling()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
}
