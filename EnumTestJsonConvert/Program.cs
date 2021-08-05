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

            AliCloudChinaSMSTemplateOutput singleTemplate = JsonConvert.DeserializeObject<AliCloudChinaSMSTemplateOutput>(singleTemplateString);
            JObject directSingleTemplate = JObject.Parse(JsonConvert.SerializeObject(singleTemplate));

            Console.WriteLine("------------------------------------------- [START] Single Template -------------------------------------------");
            Console.WriteLine("Converted using '.ToString()':");
            Console.WriteLine(singleTemplate.ToString() + "\n");

            Console.WriteLine("Converted using '.SerializeObject()':");
            Console.WriteLine(JsonConvert.SerializeObject(singleTemplate) + "\n");
            
            Console.WriteLine("Output directly:");
            Console.WriteLine(directSingleTemplate);
            Console.WriteLine("------------------------------------------- [END] Single Template -------------------------------------------");



            var allTemplateString = File.ReadAllText("./Samples/allTemplates.json");
            JArray allTemplates = JArray.Parse(allTemplateString);
            JArray allTemplatesConverted = new JArray();
            foreach (JObject item in allTemplates)
            {
                AliCloudChinaSMSTemplateOutput tempItem = JsonConvert.DeserializeObject<AliCloudChinaSMSTemplateOutput>(item.ToString());
                allTemplatesConverted.Add(JObject.Parse(JsonConvert.SerializeObject(tempItem)));
            }


            Console.WriteLine("------------------------------------------- [START] All Templates -------------------------------------------");
            Console.WriteLine("Converted using '.ToString()':");
            Console.WriteLine(allTemplates.ToString() + "\n");

            Console.WriteLine("Converted using '.SerializeObject()':");
            Console.WriteLine(JsonConvert.SerializeObject(allTemplates) + "\n");

            Console.WriteLine("Output directly:");
            Console.WriteLine(allTemplatesConverted);
            Console.WriteLine("------------------------------------------- [END] All Templates -------------------------------------------");

            Console.ReadKey();
        }
    }
}
