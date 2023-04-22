using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace hd
{
    public class Test
    {

        public static String Read(string name)
        {
            try
            {
                using (var sr = new StreamReader( DataBase.strExeFilePath.Substring(0, DataBase.strExeFilePath.Length - 6) + $"/{name}"))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return "";
            }
        }

        public static int QuestionCount(string name)
        {
            string json = Read(name);
            var jsonObject = JObject.Parse(json);
    
            if (jsonObject.TryGetValue("questions", out JToken questionsToken) && questionsToken is JArray questionsArray)
            {
                return questionsArray.Count;
            }

            return 0;
        }

    }
}