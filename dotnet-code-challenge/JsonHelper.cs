using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dotnet_code_challenge
{
    public class JsonHelper
    {
        public Race ImportJson(string filename)
        {
            JsonSerializer serial = new JsonSerializer();
            try
            {
                using (StreamReader reader = new StreamReader(filename)) //Assuming the file exists and is valid
                {
                    string data = reader.ReadToEnd();
                    Race response = (Race)serial.Deserialize(new JsonTextReader(new StringReader(data)), typeof(Race));
                    return response;
                }
            }catch(FileNotFoundException e)
            {
                return null; //Not exactly an error check given we aren't returning anything to a user or have handle logic but this is at least a response to validate
            }
        }

        /**
         * While this is a lot of data to simply throw away, in the event something this large is imported i'd hope its being stored somewhere
         * and in the event its returned from the database, the query or like only returns necessary data
        **/
        public List<KeyValuePair<string, double>> SortHorsesJson(Market[] markets)
        {
            List<KeyValuePair<string, double>> response = new List<KeyValuePair<string, double>>();
            //Assuming that there are multiple markets but each horse is unique to all of them and we want all markets as one result
            foreach (Market m in markets)
            {
                foreach (Selection s in m.Selections)
                {
                    response.Add(new KeyValuePair<string, double>(s.Tags.Name, s.Price));
                }
            }
            response.Sort((obj1, obj2) =>
            {
                return obj2.Value.CompareTo(obj1.Value);
            });
            return response;
        }
    }
}
