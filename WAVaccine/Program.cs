﻿using Newtonsoft.Json;
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
            WAPostcode.DoPostcode();
            WASuburb.DoSuburb();
            WATimeline.DoTimeline();
            WADoses.DoDoses();
            WARaw.DWARaw();
            WAPostcodeTimeline.Execute();
            WASuburbTimeline.Execute();
            WARollAvg.Execute();
        }
    }
}
