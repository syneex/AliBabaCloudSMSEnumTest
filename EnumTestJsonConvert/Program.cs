using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace EnumTestJsonConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleTemplateString = File.ReadAllText("./Samples/singleTemplate.json");
            // var allTemplateString = File.ReadAllText("./Samples/allTemplates.json");

            AliCloudChinaSMSTemplate singleTemplate = JsonConvert.DeserializeObject<AliCloudChinaSMSTemplateOutput>(singleTemplateString);

            Console.WriteLine(".ToString():");
            Console.WriteLine(singleTemplate.ToString());
            Console.WriteLine("\nJsonConvert.Serialize");
            Console.WriteLine(JsonConvert.SerializeObject(singleTemplate));

            Console.ReadKey();
        }
    }
}
