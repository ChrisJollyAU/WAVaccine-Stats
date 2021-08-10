using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAVaccine
{
    class WASuburbAge
    {
        public static void DoSuburbAge()
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
@"                                        ""Measure"": {
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
@"                                            ""Property"": ""Doses administered""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Doses administered""
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Measure"": {
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
@"                                            ""Property"": ""Dose 1""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Dose 1""
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Measure"": {
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
@"                                            ""Property"": ""Dose 2""
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
@"                                            ""Property"": ""Age_Group""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Age_Group""
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
            var cc = bb.SelectTokens("$..C");
            var d0 = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["ValueDicts"]["D0"];
            var d1 = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["ValueDicts"]["D1"];
            List<SuburbObjectAge> to = new List<SuburbObjectAge>();
            foreach (var it in cc)
            {
                SuburbObjectAge so = new SuburbObjectAge();
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
                        so.suburb_name = Convert.ToString(it[i]);
                        int subint;
                        if (int.TryParse(so.suburb_name, out subint))
                        {
                            so.suburb_name = d0[subint].ToString();
                        }
                        i++;
                    }
                    if ((rVal & 2) == 2)
                    {
                        so.AgeGroup = to.Last().AgeGroup;
                    }
                    else
                    {
                        so.AgeGroup = Convert.ToString(it[i]);
                        if (int.TryParse(so.AgeGroup, out int agegrp))
                        {
                            so.AgeGroup = d1[agegrp].ToString();
                        }
                        i++;
                    }
                    if ((rVal & 4) == 4)
                    {
                        so.total_dose = to.Last().total_dose;
                    }
                    else
                    {
                        so.total_dose = Convert.ToInt32(it[i]);
                        i++;
                    }
                    if ((rVal & 8) == 8)
                    {
                        so.dose_1 = to.Last().dose_1;
                    }
                    else
                    {
                        so.dose_1 = Convert.ToInt32(it[i]);
                        i++;
                    }
                    if ((rVal & 16) == 16)
                    {
                        so.dose_2 = to.Last().dose_2;
                    }
                    else
                    {
                        so.dose_2 = Convert.ToInt32(it[i]);
                        i++;
                    }
                }
                else
                {
                    so.suburb_name = it[0].ToString();
                    int subint;
                    if (int.TryParse(so.suburb_name, out subint))
{
                        so.suburb_name = d0[subint].ToString();
                    }
                    so.AgeGroup = it[1].ToString();
                    if (int.TryParse(so.AgeGroup, out int agegrp))
                    {
                        so.AgeGroup = d1[agegrp].ToString();
                    }
                    so.total_dose = Convert.ToInt32(it[2]);
                    so.dose_1 = Convert.ToInt32(it[3]);
                    so.dose_2 = Convert.ToInt32(it[4]);
                }
                to.Add(so);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", to);
            File.WriteAllText("data/suburbage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/suburbage-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));

            var sa2 = DoSa2Stats(to);
            DoSa3Stats(sa2);
            DoSa4Stats(sa2);
            DoGCCSAStats(sa2);
            DoWAStats(sa2);
        }

        private static List<SA2DetailAge> DoSa2Stats(List<SuburbObjectAge> to)
        {
            var sa2poptext = File.ReadAllText("data/sa2pop.json");
            var sa2suburbtext = File.ReadAllText("data/sa2suburb.json");
            var sa2subagetext = File.ReadAllText("data/sa2agegrp.json");
            var sa2suburbextratext = File.ReadAllText("data/sa2suburbextra.json");
            JObject sa2json = (JObject) JsonConvert.DeserializeObject(sa2poptext);
            JObject sa2subjson = (JObject)JsonConvert.DeserializeObject(sa2suburbtext);
            JObject sa2subagejson = (JObject)JsonConvert.DeserializeObject(sa2subagetext);
            JObject sa2subextrajson = (JObject)JsonConvert.DeserializeObject(sa2suburbextratext);
            JArray ar1 = (JArray)sa2json["data"];
            JArray ar2 = (JArray)sa2subjson["data"];
            JArray ar2extra = (JArray)sa2subextrajson["data"];
            var sa2pop = JsonConvert.DeserializeObject<List<SA2PopOb>>(ar1.ToString());
            var sa2sub = JsonConvert.DeserializeObject<List<SA2SuburbOb>>(ar2.ToString());
            var sa2subextra = JsonConvert.DeserializeObject<List<SA2SuburbOb>>(ar2extra.ToString());
            sa2sub.AddRange(sa2subextra);
            var grpsa2sub = sa2sub.GroupBy(ss => ss.SA2_Name);
            List<SA2DetailAge> sa2det = new List<SA2DetailAge>();
            foreach (var it in grpsa2sub)
            {
                SA2DetailAge sdet = new SA2DetailAge();
                sdet.SA2Name = it.Key;
                var s2pop = sa2pop.SingleOrDefault(sp => sp.name == it.Key);
                if (s2pop != null)
                {
                    sdet.c16_plus = (int)s2pop.c16_plus;
                }
                var subage = sa2subagejson[it.Key];
                int ct_50_69 = 0;
                int ct_70p = 0;
                int ct_16_49 = 0;
                if (subage != null)
                {
                    ct_50_69 = Convert.ToInt32(subage["FIELD2"].ToString());
                    ct_70p = Convert.ToInt32(subage["FIELD3"].ToString());
                    ct_16_49 = sdet.c16_plus - ct_50_69 - ct_70p;
                    sdet.c_16_49 = ct_16_49;
                    sdet.c_50_69 = ct_50_69;
                    sdet.c_70p = ct_70p;
                }
                
                foreach (var it2 in it)
                {
                    List<SuburbObjectAge> obs = to.Where(tt => tt.suburb_name == it2.name).ToList();
                    foreach (var ob in obs)
                    {
                        if (ob.AgeGroup == "16 to 49")
{
                            sdet.dose1_16_49 += ob.dose_1;
                            sdet.dose2_16_49 += ob.dose_2;
                            sdet.total_doses += ob.total_dose;
                        }
                        else if (ob.AgeGroup == "50 to 69")
                        {
                            sdet.dose1_50_69 += ob.dose_1;
                            sdet.dose2_50_69 += ob.dose_2;
                            sdet.total_doses += ob.total_dose;
                        }
                        else if (ob.AgeGroup == "70 and over")
                        {
                            sdet.dose1_70p += ob.dose_1;
                            sdet.dose2_70p += ob.dose_2;
                            sdet.total_doses += ob.total_dose;
                        }
                    }
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                }
                if (ct_16_49 > 0)
                {
                    sdet.min1d_16_49_pc = (sdet.dose1_16_49) / (decimal)ct_16_49 * 100;
                    sdet.full_16_49_pc = (sdet.dose2_16_49) / (decimal)ct_16_49 * 100;
                }
                if (ct_50_69 > 0)
                {
                    sdet.min1d_50_69_pc = (sdet.dose1_50_69) / (decimal)ct_50_69 * 100;
                    sdet.full_50_69_pc = (sdet.dose2_50_69) / (decimal)ct_50_69 * 100;
                }
                if (ct_70p > 0)
                {
                    sdet.min1d_70p_pc = (sdet.dose1_70p) / (decimal)ct_70p * 100;
                    sdet.full_70p_pc = (sdet.dose2_70p) / (decimal)ct_70p * 100;
                }
                sa2det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa2det);
            File.WriteAllText("data/sa2summaryage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/sa2summaryage-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
            return sa2det;
        }
        private static void DoSa3Stats(List<SA2DetailAge> to)
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
            List<SA3DetailAge> sa3det = new List<SA3DetailAge>();
            foreach (var it1 in sa3)
            {
                SA3DetailAge sdet = new SA3DetailAge();
                sdet.SA3Name = it1.Key;
                foreach (var it in it1)
                {
                    SA2DetailAge s2det = to.SingleOrDefault(tt => tt.SA2Name == it.SA2_Name);
                    if (s2det != null)
                    {
                        sdet.total_doses += s2det.total_doses;
                        sdet.c16_plus += s2det.c16_plus;
                        sdet.c_16_49 += s2det.c_16_49;
                        sdet.c_50_69 += s2det.c_50_69;
                        sdet.c_70p += s2det.c_70p;
                        sdet.dose1_16_49 += s2det.dose1_16_49;
                        sdet.dose1_50_69 += s2det.dose1_50_69;
                        sdet.dose1_70p += s2det.dose1_70p;
                        sdet.dose2_16_49 += s2det.dose2_16_49;
                        sdet.dose2_50_69 += s2det.dose2_50_69;
                        sdet.dose2_70p += s2det.dose2_70p;
                    }
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    if (sdet.c_16_49 > 0)
                    {
                        sdet.min1d_16_49_pc = (sdet.dose1_16_49) / (decimal)sdet.c_16_49 * 100;
                        sdet.full_16_49_pc = (sdet.dose2_16_49) / (decimal)sdet.c_16_49 * 100;
                    }
                    if (sdet.c_50_69 > 0)
                    {
                        sdet.min1d_50_69_pc = (sdet.dose1_50_69) / (decimal)sdet.c_50_69 * 100;
                        sdet.full_50_69_pc = (sdet.dose2_50_69) / (decimal)sdet.c_50_69 * 100;
                    }
                    if (sdet.c_70p > 0)
                    {
                        sdet.min1d_70p_pc = (sdet.dose1_70p) / (decimal)sdet.c_70p * 100;
                        sdet.full_70p_pc = (sdet.dose2_70p) / (decimal)sdet.c_70p * 100;
                    }
                }
                sa3det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa3det);
            File.WriteAllText("data/sa3summaryage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/sa3summaryage-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
        private static void DoSa4Stats(List<SA2DetailAge> to)
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
            List<SA4DetailAge> sa4det = new List<SA4DetailAge>();
            foreach (var it1 in sa4)
            {
                SA4DetailAge sdet = new SA4DetailAge();
                sdet.SA4Name = it1.Key;
                foreach (var it in it1)
                {
                    SA2DetailAge s2det = to.SingleOrDefault(tt => tt.SA2Name == it.SA2_Name);
                    if (s2det != null)
                    {
                        sdet.total_doses += s2det.total_doses;
                        sdet.c16_plus += s2det.c16_plus;
                        sdet.c_16_49 += s2det.c_16_49;
                        sdet.c_50_69 += s2det.c_50_69;
                        sdet.c_70p += s2det.c_70p;
                        sdet.dose1_16_49 += s2det.dose1_16_49;
                        sdet.dose1_50_69 += s2det.dose1_50_69;
                        sdet.dose1_70p += s2det.dose1_70p;
                        sdet.dose2_16_49 += s2det.dose2_16_49;
                        sdet.dose2_50_69 += s2det.dose2_50_69;
                        sdet.dose2_70p += s2det.dose2_70p;
                    }
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    if (sdet.c_16_49 > 0)
                    {
                        sdet.min1d_16_49_pc = (sdet.dose1_16_49) / (decimal)sdet.c_16_49 * 100;
                        sdet.full_16_49_pc = (sdet.dose2_16_49) / (decimal)sdet.c_16_49 * 100;
                    }
                    if (sdet.c_50_69 > 0)
                    {
                        sdet.min1d_50_69_pc = (sdet.dose1_50_69) / (decimal)sdet.c_50_69 * 100;
                        sdet.full_50_69_pc = (sdet.dose2_50_69) / (decimal)sdet.c_50_69 * 100;
                    }
                    if (sdet.c_70p > 0)
                    {
                        sdet.min1d_70p_pc = (sdet.dose1_70p) / (decimal)sdet.c_70p * 100;
                        sdet.full_70p_pc = (sdet.dose2_70p) / (decimal)sdet.c_70p * 100;
                    }
                }
                sa4det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa4det);
            File.WriteAllText("data/sa4summaryage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/sa4summaryage-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
        private static void DoGCCSAStats(List<SA2DetailAge> to)
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
            List<GCCSADetailAge> gccsadet = new List<GCCSADetailAge>();
            foreach (var it1 in gccsa)
            {
                GCCSADetailAge sdet = new GCCSADetailAge();
                sdet.Name = it1.Key;
                foreach (var it in it1)
                {
                    SA2DetailAge s2det = to.SingleOrDefault(tt => tt.SA2Name == it.SA2_Name);
                    if (s2det != null)
                    {
                        sdet.total_doses += s2det.total_doses;
                        sdet.c16_plus += s2det.c16_plus;
                        sdet.c_16_49 += s2det.c_16_49;
                        sdet.c_50_69 += s2det.c_50_69;
                        sdet.c_70p += s2det.c_70p;
                        sdet.dose1_16_49 += s2det.dose1_16_49;
                        sdet.dose1_50_69 += s2det.dose1_50_69;
                        sdet.dose1_70p += s2det.dose1_70p;
                        sdet.dose2_16_49 += s2det.dose2_16_49;
                        sdet.dose2_50_69 += s2det.dose2_50_69;
                        sdet.dose2_70p += s2det.dose2_70p;
                    }
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    if (sdet.c_16_49 > 0)
                    {
                        sdet.min1d_16_49_pc = (sdet.dose1_16_49) / (decimal)sdet.c_16_49 * 100;
                        sdet.full_16_49_pc = (sdet.dose2_16_49) / (decimal)sdet.c_16_49 * 100;
                    }
                    if (sdet.c_50_69 > 0)
                    {
                        sdet.min1d_50_69_pc = (sdet.dose1_50_69) / (decimal)sdet.c_50_69 * 100;
                        sdet.full_50_69_pc = (sdet.dose2_50_69) / (decimal)sdet.c_50_69 * 100;
                    }
                    if (sdet.c_70p > 0)
                    {
                        sdet.min1d_70p_pc = (sdet.dose1_70p) / (decimal)sdet.c_70p * 100;
                        sdet.full_70p_pc = (sdet.dose2_70p) / (decimal)sdet.c_70p * 100;
                    }
                }
                gccsadet.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", gccsadet);
            File.WriteAllText("data/gccsasummaryage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/gccsasummaryage-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
        private static void DoWAStats(List<SA2DetailAge> to)
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
            List<GCCSADetailAge> gccsadet = new List<GCCSADetailAge>();
            foreach (var it1 in gccsa)
            {
                GCCSADetailAge sdet = new GCCSADetailAge();
                sdet.Name = it1.Key;
                foreach (var it in it1)
                {
                    SA2DetailAge s2det = to.SingleOrDefault(tt => tt.SA2Name == it.SA2_Name);
                    if (s2det != null)
                    {
                        sdet.total_doses += s2det.total_doses;
                        sdet.c16_plus += s2det.c16_plus;
                        sdet.c_16_49 += s2det.c_16_49;
                        sdet.c_50_69 += s2det.c_50_69;
                        sdet.c_70p += s2det.c_70p;
                        sdet.dose1_16_49 += s2det.dose1_16_49;
                        sdet.dose1_50_69 += s2det.dose1_50_69;
                        sdet.dose1_70p += s2det.dose1_70p;
                        sdet.dose2_16_49 += s2det.dose2_16_49;
                        sdet.dose2_50_69 += s2det.dose2_50_69;
                        sdet.dose2_70p += s2det.dose2_70p;
                    }
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    if (sdet.c_16_49 > 0)
                    {
                        sdet.min1d_16_49_pc = (sdet.dose1_16_49) / (decimal)sdet.c_16_49 * 100;
                        sdet.full_16_49_pc = (sdet.dose2_16_49) / (decimal)sdet.c_16_49 * 100;
                    }
                    if (sdet.c_50_69 > 0)
                    {
                        sdet.min1d_50_69_pc = (sdet.dose1_50_69) / (decimal)sdet.c_50_69 * 100;
                        sdet.full_50_69_pc = (sdet.dose2_50_69) / (decimal)sdet.c_50_69 * 100;
                    }
                    if (sdet.c_70p > 0)
                    {
                        sdet.min1d_70p_pc = (sdet.dose1_70p) / (decimal)sdet.c_70p * 100;
                        sdet.full_70p_pc = (sdet.dose2_70p) / (decimal)sdet.c_70p * 100;
                    }
                }
                gccsadet.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", gccsadet);
            File.WriteAllText("data/wasummaryage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/wasummaryage-.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
    }

    class SuburbObjectAge
    {
        public string suburb_name { get; set; }
        public int total_dose { get; set; }
        public int dose_1 { get; set; }
        public int dose_2 { get; set; }

        public string AgeGroup { get; set; }
    }
    class SA2DetailAge
    {
        public string SA2Name { get; set; }
        public int c16_plus { get; set; }
        public int c_16_49 { get; set; }
        public int c_50_69 { get; set; }
        public int c_70p { get; set; }
        public int dose1_16_49 { get; set; }
        public int dose2_16_49 { get; set; }
        public int dose1_50_69 { get; set; }
        public int dose2_50_69 { get; set; }
        public int dose1_70p { get; set; }
        public int dose2_70p { get; set; }
        public int total_doses { get; set; }
        public decimal atleast_1dose_percent { get; set; }
        public decimal full_vaccinated_percent { get; set; }
        public decimal min1d_16_49_pc {get;set;}
        public decimal full_16_49_pc { get; set; }
        public decimal min1d_50_69_pc { get; set; }
        public decimal full_50_69_pc { get; set; }
        public decimal min1d_70p_pc { get; set; }
        public decimal full_70p_pc { get; set; }
    }
    class SA3DetailAge
    {
        public string SA3Name { get; set; }
        public int c16_plus { get; set; }
        public int c_16_49 { get; set; }
        public int c_50_69 { get; set; }
        public int c_70p { get; set; }
        public int dose1_16_49 { get; set; }
        public int dose2_16_49 { get; set; }
        public int dose1_50_69 { get; set; }
        public int dose2_50_69 { get; set; }
        public int dose1_70p { get; set; }
        public int dose2_70p { get; set; }
        public int total_doses { get; set; }
        public decimal atleast_1dose_percent { get; set; }
        public decimal full_vaccinated_percent { get; set; }
        public decimal min1d_16_49_pc { get; set; }
        public decimal full_16_49_pc { get; set; }
        public decimal min1d_50_69_pc { get; set; }
        public decimal full_50_69_pc { get; set; }
        public decimal min1d_70p_pc { get; set; }
        public decimal full_70p_pc { get; set; }
    }
    class SA4DetailAge
    {
        public string SA4Name { get; set; }
        public int c16_plus { get; set; }
        public int c_16_49 { get; set; }
        public int c_50_69 { get; set; }
        public int c_70p { get; set; }
        public int dose1_16_49 { get; set; }
        public int dose2_16_49 { get; set; }
        public int dose1_50_69 { get; set; }
        public int dose2_50_69 { get; set; }
        public int dose1_70p { get; set; }
        public int dose2_70p { get; set; }
        public int total_doses { get; set; }
        public decimal atleast_1dose_percent { get; set; }
        public decimal full_vaccinated_percent { get; set; }
        public decimal min1d_16_49_pc { get; set; }
        public decimal full_16_49_pc { get; set; }
        public decimal min1d_50_69_pc { get; set; }
        public decimal full_50_69_pc { get; set; }
        public decimal min1d_70p_pc { get; set; }
        public decimal full_70p_pc { get; set; }
    }
    class GCCSADetailAge
    {
        public string Name { get; set; }
        public int c16_plus { get; set; }
        public int c_16_49 { get; set; }
        public int c_50_69 { get; set; }
        public int c_70p { get; set; }
        public int dose1_16_49 { get; set; }
        public int dose2_16_49 { get; set; }
        public int dose1_50_69 { get; set; }
        public int dose2_50_69 { get; set; }
        public int dose1_70p { get; set; }
        public int dose2_70p { get; set; }
        public int total_doses { get; set; }
        public decimal atleast_1dose_percent { get; set; }
        public decimal full_vaccinated_percent { get; set; }
        public decimal min1d_16_49_pc { get; set; }
        public decimal full_16_49_pc { get; set; }
        public decimal min1d_50_69_pc { get; set; }
        public decimal full_50_69_pc { get; set; }
        public decimal min1d_70p_pc { get; set; }
        public decimal full_70p_pc { get; set; }
    }
}
