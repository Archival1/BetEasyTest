using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

/**
 * This version of the code challenge authored by Shaun Sexton 13/03/19
 **/
namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given how simple the data used internally is probably not worth making an entire object for 2 values
            List<KeyValuePair<string, double>> horseList; // { name: string, float: price}
            Race race = new JsonHelper().ImportJson("./FeedData/Wolferhampton_Race1.json");
            horseList = new JsonHelper().SortHorsesJson(race.RawData.Markets);
            horseList.ForEach(x =>
            {
                Debug.WriteLine("Horse: " + x.Key + " Valued at: " + x.Value);
            });
            //In place of any actual response or output given
        }
        void ImportXML()
        {
            //See readme for information regarding this empty method and a few of my own notes
        }
    }
}
