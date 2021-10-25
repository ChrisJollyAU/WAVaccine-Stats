using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAVaccine
{
    class WASuburb
    {
        public static void DoSuburb()
        {
            var client = new RestClient("https://wabi-australia-southeast-api.analysis.windows.net/public/reports/querydata?synchronous=true");
            client.Timeout = -1;
            client.UseNewtonsoftJson();
            var request = new RestRequest(Method.POST);
            request.AddHeader("ActivityId", "8218c55c-bf10-4c88-ad6d-b94b1941307a");
            request.AddHeader("RequestId", "5269c938-fb76-59d4-6de8-d272d6b94c74");
            request.AddHeader("X-PowerBI-ResourceKey", "030227c5-6905-436e-bd82-b45af84cce64");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
@"    ""version"": ""1.0.0"",
" + "\n" +
@"    ""queries"": [
" + "\n" +
@"        {
" + "\n" +
@"            ""Query"": {
" + "\n" +
@"                ""Commands"": [
" + "\n" +
@"                    {
" + "\n" +
@"                        ""SemanticQueryDataShapeCommand"": {
" + "\n" +
@"                            ""Query"": {
" + "\n" +
@"                                ""Version"": 2,
" + "\n" +
@"                                ""From"": [
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Name"": ""a"",
" + "\n" +
@"                                        ""Entity"": ""AIR"",
" + "\n" +
@"                                        ""Type"": 0
" + "\n" +
@"                                    }
" + "\n" +
@"                                ],
" + "\n" +
@"                                ""Select"": [
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Column"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""SourceRef"": {
" + "\n" +
@"                                                    ""Source"": ""a""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""locality""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.locality""
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Column"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""SourceRef"": {
" + "\n" +
@"                                                    ""Source"": ""a""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""vaccines""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Doses administered""
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Column"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""SourceRef"": {
" + "\n" +
@"                                                    ""Source"": ""a""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""dose_one""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Dose 1""
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Column"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""SourceRef"": {
" + "\n" +
@"                                                    ""Source"": ""a""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""dose_two""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Dose 2""
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Column"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""SourceRef"": {
" + "\n" +
@"                                                    ""Source"": ""a""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""dose_3""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Dose 3""
" + "\n" +
@"                                    }
" + "\n" +
@"                                ],
" + "\n" +
@"                                ""OrderBy"": [
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Direction"": 1,
" + "\n" +
@"                                        ""Expression"": {
" + "\n" +
@"                                            ""Column"": {
" + "\n" +
@"                                                ""Expression"": {
" + "\n" +
@"                                                    ""SourceRef"": {
" + "\n" +
@"                                                        ""Source"": ""a""
" + "\n" +
@"                                                    }
" + "\n" +
@"                                                },
" + "\n" +
@"                                                ""Property"": ""locality""
" + "\n" +
@"                                            }
" + "\n" +
@"                                        }
" + "\n" +
@"                                    }
" + "\n" +
@"                                ]
" + "\n" +
@"                            },
" + "\n" +
@"                            ""Binding"": {
" + "\n" +
@"                                ""Primary"": {
" + "\n" +
@"                                    ""Groupings"": [
" + "\n" +
@"                                        {
" + "\n" +
@"                                            ""Projections"": [
" + "\n" +
@"                                                0,
" + "\n" +
@"                                                1,
" + "\n" +
@"                                                2,
" + "\n" +
@"                                                3,
" + "\n" +
@"                                                4
" + "\n" +
@"                                            ]
" + "\n" +
@"                                        }
" + "\n" +
@"                                    ]
" + "\n" +
@"                                },
" + "\n" +
@"                                ""DataReduction"": {
" + "\n" +
@"                                    ""DataVolume"": 6,
" + "\n" +
@"                                    ""Primary"": {
" + "\n" +
@"                                        ""Top"": {}
" + "\n" +
@"                                    }
" + "\n" +
@"                                },
" + "\n" +
@"                                ""Version"": 1
" + "\n" +
@"                            },
" + "\n" +
@"                            ""ExecutionMetricsKind"": 1
" + "\n" +
@"                        }
" + "\n" +
@"                    }
" + "\n" +
@"                ]
" + "\n" +
@"            },
" + "\n" +
@"            ""QueryId"": """",
" + "\n" +
@"            ""ApplicationContext"": {
" + "\n" +
@"                ""DatasetId"": ""def25ac4-7ae6-4f04-a18d-b09aeab61acd"",
" + "\n" +
@"                ""Sources"": [
" + "\n" +
@"                    {
" + "\n" +
@"                        ""ReportId"": ""e06eb9c9-16ef-4f52-b3f3-75714ab08f87"",
" + "\n" +
@"                        ""VisualId"": ""79901dfa544d31e9c7ea""
" + "\n" +
@"                    }
" + "\n" +
@"                ]
" + "\n" +
@"            }
" + "\n" +
@"        }
" + "\n" +
@"    ],
" + "\n" +
@"    ""cancelQueries"": [],
" + "\n" +
@"    ""modelId"": 2443166
" + "\n" +
@"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            JObject des = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
            var bb = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["PH"][0]["DM0"];

            bb.First.First.Remove();
            var cc = bb.SelectMany(v => v.First);
            List<SuburbObject> to = new List<SuburbObject>();
            foreach (var it in cc)
            {
                SuburbObject so = new SuburbObject();
                JProperty R = (JProperty)it.Parent.Next;
                if (R?.Name == "R")
                {
                    var sRval = ((JValue)R.First()).Value.ToString();
                    var rVal = Convert.ToInt32(sRval);
                    
                    var i = 0;
                    if ((rVal & 1) == 1)
                    {
                        so.suburb_name = to.Last().suburb_name;
                    }
                    else
                    {
                        so.suburb_name = it[0].ToString();
                        i++;
                    }
                    if ((rVal & 2) == 2)
                    {
                        so.total_dose = to.Last().total_dose;
                    }
                    else
                    {
                        so.total_dose = Convert.ToInt32(it[i]);
                        i++;
                    }
                    if ((rVal & 4) == 4)
                    {
                        so.dose_1 = to.Last().dose_1;
                    }
                    else
                    {
                        so.dose_1 = Convert.ToInt32(it[i]);
                        i++;
                    }
                    if ((rVal & 8) == 8)
                    {
                        so.dose_2 = to.Last().dose_2;
                    }
                    else
                    {
                        so.dose_2 = Convert.ToInt32(it[i]);
                        i++;
                    }
                    if ((rVal & 16) == 16)
                    {
                        so.dose_3 = to.Last().dose_3;
                    }
                    else
                    {
                        so.dose_3 = Convert.ToInt32(it[i]);
                        i++;
                    }
                }
                else
                {
                    so.suburb_name = it[0].ToString();
                    so.total_dose = Convert.ToInt32(it[1]);
                    so.dose_1 = Convert.ToInt32(it[2]);
                    so.dose_2 = Convert.ToInt32(it[3]);
                    so.dose_3 = Convert.ToInt32(it[4]);
                }
                to.Add(so);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", to);
            File.WriteAllText("data/suburb-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/suburb-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
            var sa2 = DoSa2Stats(to);
            DoSa3Stats(sa2);
            DoSa4Stats(sa2);
            DoGCCSAStats(sa2);
            DoWAStats(sa2);
        }

        private static List<SA2Detail> DoSa2Stats(List<SuburbObject> to)
        {
            var sa2suburbtext = File.ReadAllText("data/sa2suburb.json");
            var sa2suburbextratext = File.ReadAllText("data/sa2suburbextra.json");
            JObject sa2subjson = (JObject)JsonConvert.DeserializeObject(sa2suburbtext);
            JObject sa2subextrajson = (JObject)JsonConvert.DeserializeObject(sa2suburbextratext);
            JArray ar2 = (JArray)sa2subjson["data"];
            JArray ar2extra = (JArray)sa2subextrajson["data"];
            var sa2sub = JsonConvert.DeserializeObject<List<SA2SuburbOb>>(ar2.ToString());
            var sa2subextra = JsonConvert.DeserializeObject<List<SA2SuburbOb>>(ar2extra.ToString());
            sa2sub.AddRange(sa2subextra);

            var sa2pop2020 = System.IO.File.ReadAllLines("data/sa2pop2020.csv");
            List<SA2PopOb> sa2pop = new List<SA2PopOb>();
            foreach (var ln in sa2pop2020)
            {
                var cols = ln.Split(',');
                SA2PopOb pop = new SA2PopOb
                {
                    State = cols[1],
                    GCCSA = cols[3],
                    SA4 = cols[5],
                    SA3 = cols[7],
                    SA2 = cols[9],
                    c_0_4 = Convert.ToInt32(cols[10]),
                    c_5_11 = Convert.ToInt32(cols[11]),
                    c_12_15 = Convert.ToInt32(cols[12]),
                    c_16_19 = Convert.ToInt32(cols[13]),
                    c_20_24 = Convert.ToInt32(cols[14]),
                    c_25_29 = Convert.ToInt32(cols[15]),
                    c_30_34 = Convert.ToInt32(cols[16]),
                    c_35_39 = Convert.ToInt32(cols[17]),
                    c_40_44 = Convert.ToInt32(cols[18]),
                    c_45_49 = Convert.ToInt32(cols[19]),
                    c_50_54 = Convert.ToInt32(cols[20]),
                    c_55_59 = Convert.ToInt32(cols[21]),
                    c_60_64 = Convert.ToInt32(cols[22]),
                    c_65_69 = Convert.ToInt32(cols[23]),
                    c_70_74 = Convert.ToInt32(cols[24]),
                    c_75_79 = Convert.ToInt32(cols[25]),
                    c_80_84 = Convert.ToInt32(cols[26]),
                    c_85p = Convert.ToInt32(cols[27]),
                };
                var total = Convert.ToInt32(cols[28]);
                pop.c12_plus = total - pop.c_0_4 - pop.c_5_11;
                pop.c16_plus = total - pop.c_0_4 - pop.c_5_11 - pop.c_12_15;
                sa2pop.Add(pop);
            }

            var grpsa2sub = sa2sub.GroupBy(ss => ss.SA2_Name);
            List<SuburbObject> used = new List<SuburbObject>();
            List<SA2Detail> sa2det = new List<SA2Detail>();
            foreach (var it in grpsa2sub)
            {
                SA2Detail sdet = new SA2Detail();
                sdet.SA2Name = it.Key;
                var s2pop = sa2pop.SingleOrDefault(sp => sp.SA2 == it.Key);
                if (s2pop != null) {
                    sdet.c16_plus = (int)s2pop.c16_plus;
                    sdet.c12_plus = (int)s2pop.c12_plus;
                }
                foreach (var it2 in it)
                {
                    var ob1 = to.Where(tt => tt.suburb_name == it2.name);
                    foreach (var ob in ob1)
                    if (ob != null)
                    {
                        sdet.dose1 += ob.dose_1;
                        sdet.dose2 += ob.dose_2;
                        sdet.dose3 += ob.dose_3;
                        sdet.total_doses += ob.total_dose;
                        used.Add(ob);
                    }
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent = (decimal)sdet.dose1 / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent = (decimal)sdet.dose2 / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent = (decimal)sdet.dose3 / (decimal)sdet.c12_plus * 100;
                }
                sa2det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa2det);
            File.WriteAllText("data/sa2summary-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/sa2summary-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
            return sa2det;
        }

        private static void DoSa3Stats(List<SA2Detail> to)
        {
            var sa2list = File.ReadAllLines("data/SA2_2016_AUST.csv");
            List<SA2Map> sa2mapping = new();
            foreach (var line in sa2list)
            {
                var cols = line.Split(',');
                SA2Map it = new SA2Map
                {
                    SA2_Name = cols[2],
                    SA3_Name = cols[4],
                    SA4_Name = cols[6],
                    GCCSA = cols[8],
                    State = cols[10]
                };
                sa2mapping.Add(it);
            }
            sa2mapping.RemoveAt(0);
            var sa3 = sa2mapping.GroupBy(ss => ss.SA3_Name);
            List<SA2Detail> used = new List<SA2Detail>();
            List<SA3Detail> sa3det = new List<SA3Detail>();
            foreach (var it1 in sa3)
            {
                SA3Detail sdet = new SA3Detail();
                sdet.SA3Name = it1.Key;
                foreach (var it in it1)
                {
                    SA2Detail s2det = to.SingleOrDefault(tt => tt.SA2Name == it.SA2_Name);
                    if (s2det != null)
                    {
                        sdet.total_doses += s2det.total_doses;
                        sdet.dose1 += s2det.dose1;
                        sdet.dose2 += s2det.dose2;
                        sdet.dose3 += s2det.dose3;
                        sdet.c16_plus += s2det.c16_plus;
                        sdet.c12_plus += s2det.c12_plus;
                        used.Add(s2det);
                    }
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent = (decimal)sdet.dose1 / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent = (decimal)sdet.dose2 / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent = (decimal)sdet.dose3 / (decimal)sdet.c12_plus * 100;
                }
                sa3det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa3det);
            File.WriteAllText("data/sa3summary-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/sa3summary-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
        private static void DoSa4Stats(List<SA2Detail> to)
        {
            var sa2list = File.ReadAllLines("data/SA2_2016_AUST.csv");
            List<SA2Map> sa2mapping = new();
            foreach (var line in sa2list)
            {
                var cols = line.Split(',');
                SA2Map it = new SA2Map
                {
                    SA2_Name = cols[2],
                    SA3_Name = cols[4],
                    SA4_Name = cols[6],
                    GCCSA = cols[8],
                    State = cols[10]
                };
                sa2mapping.Add(it);
            }
            sa2mapping.RemoveAt(0);
            var sa4 = sa2mapping.GroupBy(ss => ss.SA4_Name);
            List<SA4Detail> sa4det = new List<SA4Detail>();
            foreach (var it1 in sa4)
            {
                SA4Detail sdet = new SA4Detail();
                sdet.SA4Name = it1.Key;
                foreach (var it in it1)
                {
                    SA2Detail s2det = to.SingleOrDefault(tt => tt.SA2Name == it.SA2_Name);
                    if (s2det != null)
                    {
                        sdet.total_doses += s2det.total_doses;
                        sdet.dose1 += s2det.dose1;
                        sdet.dose2 += s2det.dose2;
                        sdet.dose3 += s2det.dose3;
                        sdet.c16_plus += s2det.c16_plus;
                        sdet.c12_plus += s2det.c12_plus;
                    }
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent = (decimal)sdet.dose1 / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent = (decimal)sdet.dose2 / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent = (decimal)sdet.dose3 / (decimal)sdet.c12_plus * 100;
                }
                sa4det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa4det);
            File.WriteAllText("data/sa4summary-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/sa4summary-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
        private static void DoGCCSAStats(List<SA2Detail> to)
        {
            var sa2list = File.ReadAllLines("data/SA2_2016_AUST.csv");
            List<SA2Map> sa2mapping = new();
            foreach (var line in sa2list)
            {
                var cols = line.Split(',');
                SA2Map it = new SA2Map
                {
                    SA2_Name = cols[2],
                    SA3_Name = cols[4],
                    SA4_Name = cols[6],
                    GCCSA = cols[8],
                    State = cols[10]
                };
                sa2mapping.Add(it);
            }
            sa2mapping.RemoveAt(0);
            var gccsa = sa2mapping.GroupBy(ss => ss.GCCSA);
            List<GCCSADetail> gccsadet = new List<GCCSADetail>();
            foreach (var it1 in gccsa)
            {
                GCCSADetail sdet = new GCCSADetail();
                sdet.Name = it1.Key;
                foreach (var it in it1)
                {
                    SA2Detail s2det = to.SingleOrDefault(tt => tt.SA2Name == it.SA2_Name);
                    if (s2det != null)
                    {
                        sdet.total_doses += s2det.total_doses;
                        sdet.dose1 += s2det.dose1;
                        sdet.dose2 += s2det.dose2;
                        sdet.dose3 += s2det.dose3;
                        sdet.c16_plus += s2det.c16_plus;
                        sdet.c12_plus += s2det.c12_plus;
                    }
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent = (decimal)sdet.dose1 / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent = (decimal)sdet.dose2 / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent = (decimal)sdet.dose3 / (decimal)sdet.c12_plus * 100;
                }
                gccsadet.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", gccsadet);
            File.WriteAllText("data/gccsasummary-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/gccsasummary-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
        private static void DoWAStats(List<SA2Detail> to)
        {
            var sa2list = File.ReadAllLines("data/SA2_2016_AUST.csv");
            List<SA2Map> sa2mapping = new();
            foreach (var line in sa2list)
            {
                var cols = line.Split(',');
                SA2Map it = new SA2Map
                {
                    SA2_Name = cols[2],
                    SA3_Name = cols[4],
                    SA4_Name = cols[6],
                    GCCSA = cols[8],
                    State = cols[10]
                };
                sa2mapping.Add(it);
            }
            sa2mapping.RemoveAt(0);
            var gccsa = sa2mapping.GroupBy(ss => ss.State);
            List<GCCSADetail> gccsadet = new List<GCCSADetail>();
            foreach (var it1 in gccsa)
            {
                GCCSADetail sdet = new GCCSADetail();
                sdet.Name = it1.Key;
                foreach (var it in it1)
                {
                    SA2Detail s2det = to.SingleOrDefault(tt => tt.SA2Name == it.SA2_Name);
                    if (s2det != null)
                    {
                        sdet.total_doses += s2det.total_doses;
                        sdet.dose1 += s2det.dose1;
                        sdet.dose2 += s2det.dose2;
                        sdet.dose3 += s2det.dose3;
                        sdet.c16_plus += s2det.c16_plus;
                        sdet.c12_plus += s2det.c12_plus;
                    }
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent = (decimal)sdet.dose1 / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent = (decimal)sdet.dose2 / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent = (decimal)sdet.dose3 / (decimal)sdet.c12_plus * 100;
                }
                gccsadet.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", gccsadet);
            File.WriteAllText("data/wasummary-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/wasummary-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
    }

    class SA2Map
    {
        public string SA2_Name { get; set; }
        public string SA3_Name { get; set; }
        public string SA4_Name { get; set; }
        public string GCCSA { get; set; }
        public string State { get; set; }
    }

    class SuburbObject
    {
        public string suburb_name { get; set; }
        public int total_dose { get; set; }
        public int dose_1 { get; set; }
        public int dose_2 { get; set; }
        public int dose_3 { get; internal set; }
    }

    class SA2Detail
    {
        public string SA2Name { get; set; }
        public int c16_plus { get; set; }
        public int dose1 { get; set; }
        public int dose2 { get; set; }
        public int total_doses { get; set; }
        public decimal atleast_1dose_percent { get; set; }
        public decimal full_vaccinated_percent { get; set; }
        public int c12_plus { get; set; }
        public int dose3 { get; internal set; }
        public decimal D3_vaccinated_percent { get; internal set; }
    }
    class SA3Detail
    {
        public string SA3Name { get; set; }
        public int c16_plus { get; set; }
        public int dose1 { get; set; }
        public int dose2 { get; set; }
        public int total_doses { get; set; }
        public decimal atleast_1dose_percent { get; set; }
        public decimal full_vaccinated_percent { get; set; }
        public int c12_plus { get; set; }
        public int dose3 { get; internal set; }
        public decimal D3_vaccinated_percent { get; internal set; }
    }
    class SA4Detail
    {
        public string SA4Name { get; set; }
        public int c16_plus { get; set; }
        public int dose1 { get; set; }
        public int dose2 { get; set; }
        public int total_doses { get; set; }
        public decimal atleast_1dose_percent { get; set; }
        public decimal full_vaccinated_percent { get; set; }
        public int c12_plus { get; set; }
        public int dose3 { get; internal set; }
        public decimal D3_vaccinated_percent { get; internal set; }
    }
    class GCCSADetail
    {
        public string Name { get; set; }
        public int c16_plus { get; set; }
        public int dose1 { get; set; }
        public int dose2 { get; set; }
        public int total_doses { get; set; }
        public decimal atleast_1dose_percent { get; set; }
        public decimal full_vaccinated_percent { get; set; }
        public int c12_plus { get; set; }
        public int dose3 { get; set; }
        public decimal D3_vaccinated_percent { get; internal set; }
    }
}
