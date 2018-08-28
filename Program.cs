using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0 )
            {
                foreach(string s in args)
                {
                    if( int.TryParse( s, out int num))
                    {
                        string output = string.Empty;
                        if(num % 3 == 0)
                        {
                            output += "fizz";
                        }
                        
                        if(num % 5 == 0)
                        {
                            output += "buzz";
                        }

                        Console.Out.WriteLine(output);
                    }else
                    {
                        Console.Error.WriteLine("All parameters must be numbers");
                        Environment.Exit(-1);
                    }
                }
                Environment.Exit(0);
            }
            else
            {
                Console.Error.WriteLine("Missing number parameter");
                Environment.Exit(-1);
            }
        }
    }
}
