using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void bunnyAnimation()
        {
            string[] frames = new string[3];
            string loop = " ";

            for (int i = 0; i < frames.Length; i++)
            {
                frames[i] = "";
            }

            frames[0] += @"
 (\_/)
(='.'=)
(A)_(A)>     
";

            frames[1] += @"
 (\_/)
(O^.^O)
(B)_(B)  >   
";

            frames[2] += @"
 (\_/)
(O^.^O)
(C)_(C)    > 
";
            while (loop != "")
            {
                for (int i = 0; i < frames.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine(frames[i]);
                    Thread.Sleep(500);
                }

            }
        }
        static void carAnimation()
        {
            string[] frames = new string[6];
            string loop = " ";
            for (int i = 0; i < frames.Length; i++)
            {
                frames[i] = "";
            }
            frames[0] += @"
                                                                                          
                                                                                                                                                                                    ____/   ___
                                                                                                                                                                                       |_   \__'  _\
                                                                                                                                                                                       `-(*)----(*)'
";
            frames[1] += @"
                                                                                                                                                     ____/   ___
                                                                                                                                                        |_   \__'  _\
                                                                                                                                                        `-(*)----(*)'

";
        }
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}
