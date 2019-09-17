using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var name = ConfigurationManager.AppSettings["name"];
            Console.WriteLine(name);

            try
            {
                int a, b;
                a = 2;
                b = 0;
                // int x = a / b;
               
                switch (name)
                {
                    case Names.roman:
                        break;
                    case Names.amma:
                        break;
                    case Names.adam:
                        Console.WriteLine(name);
                        break;
                    default:
                        break;
                }

                Test test = new Test();
                test.x = 0; // 
                Test.Name = "Roman";


                throw new Exception("test error ");
            }
            catch (DivideByZeroException dbzero)
            {
                Console.WriteLine(dbzero.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Koniec programu");
            }    

            Console.ReadKey();
        }
    }
}
