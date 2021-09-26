using System;

namespace DotnetStdinStdout
{
    class Program
    {
        static void Main(string[] args)
        {
            string output;
            while((output = Console.ReadLine()) != null) {
                string result = null;
                try{
                    var message = Read.Deserialize(output.Split(" "));
                    result = Read.DoSomething(message);
                } catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(result);
            }
        }
    }
}
