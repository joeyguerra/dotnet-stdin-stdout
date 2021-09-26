using System;
using Xunit;
using System.Text.Json;
using System.Collections.Generic;

namespace DotnetStdinStdout.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string output;
            while((output = Console.ReadLine()) != null) {
                string result = null;
                try{
                    var message = Deserialize(output.Split(" "));
                    result = DoSomething(message);
                } catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(result);
            }
        }
        public Dictionary<string, string> Deserialize(string[] parts){
            var dict = new Dictionary<string, string>();
            for(var i = 0; i < parts.Length - 1; i = i+2){
                dict[parts[i]] = parts[i+1];
            }
            return dict;
        }
        public string DoSomething(Dictionary<string, string> message){
            var output = "";
            foreach(var key in message.Keys){
                output += $"{key} = {message[key]}{Environment.NewLine}";
            }
            return output;
        }
    }
}
