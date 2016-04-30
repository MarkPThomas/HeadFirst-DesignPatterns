using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IODecorator
{
    public class InputTest
    {
        public static void Run()
        {
            int c;

            try
            {
                using (StreamReader stream =
                        new LowerCaseInputStream(
                            new BufferedStream(
                                new FileStream("test.txt", FileMode.Open))))
                {
                    while ((c = stream.Read()) >= 0)
                    {
                        Console.Write((char)c);
                    }
                }        
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
