using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.IO;
using System.Linq;

namespace WAVaccine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*WASA2Pop.Execute();
            WAPostLGA.Execute();
            WASA2Suburb.Execute();
            WAPostcode.DoPostcode();
            WAPostcodeAge.DoPostcodeAge();
            WASuburb.DoSuburb();
            WASuburbAge.DoSuburbAge();
            WATimeline.DoTimeline();
            //WATimelineAge.DoTimelineAge();
            WADoses.DoDoses();
            WADosesAge.DoDosesAge();
            WARaw.DWARaw();
            WAPostcodeTimeline.Execute();
            WAPostcodeTimelineAge.Execute();
            WASuburbTimeline.Execute();
            WASuburbTimelineAge.Execute();
            WARollAvg.Execute();
            WARollAvgAge.Execute();*/
            WARaw2.DWARaw2();
        }
    }
}
