using System;
using System.Collections.Generic;

namespace DotnetStdinStdout
{
    public class Read
    {
        public static Dictionary<string, string> Deserialize(string[] parts){
            var dict = new Dictionary<string, string>();
            for(var i = 0; i < parts.Length - 1; i = i+2){
                dict[parts[i]] = parts[i+1];
            }
            return dict;
        }
        public static string DoSomething(Dictionary<string, string> message){
            var output = "";
            foreach(var key in message.Keys){
                output += $"{key} = {message[key]}{Environment.NewLine}";
            }
            return output;
        }
    }

}
