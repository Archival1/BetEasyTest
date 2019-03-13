using System;
using System.Collections.Generic;
using Xunit;

namespace dotnet_code_challenge.Test
{
    public class UnitTest1
    {
        /**
         * 
         **/
        [Fact]
        public void HappyPath()
        {
            //There is likely a better way to make comparison data but this is it for now
            List< KeyValuePair<string, double>> expectedResult = new List<KeyValuePair<string, double>>();
            expectedResult.Add(new KeyValuePair<string, double>("Toolatetodelegate", 10.0));
            expectedResult.Add(new KeyValuePair<string, double>("Fikhaar", 4.4));
            Race r = new JsonHelper().ImportJson("./FeedData/Wolferhampton_Race1.json");
            Assert.NotNull(r);
            List<KeyValuePair<string, double>> horseList = new JsonHelper().SortHorsesJson(r.RawData.Markets);
            Assert.Equal(horseList, expectedResult);
        }

        [Fact]
        public void NoFileException()
        {
            Assert.Null(new JsonHelper().ImportJson("badfilepath.json"));
        }

        //Include a few more ensuring bad or missing input leads to correct exceptions or responses being sent (If those were actually implemented in this)
    }
}
