using System;
using Xunit;
using System.Text.Json;
namespace DotnetStdinStdout.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var jsonOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            string output;
            while((output = Console.ReadLine()) != null) {
                string result = null;
                try{
                    var message = JsonSerializer.Deserialize<JsonCollection>(output);
                    result = DoSomething(message);
                } catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(result);
            }
        }

        public string DoSomething(JsonCollection message){
            return $"{message.Href}";
        }
    }
}
