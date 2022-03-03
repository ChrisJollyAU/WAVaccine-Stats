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
    class WARaw2
    {
        public static void DWARaw2()
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
@"                                        ""Name"": ""d"",
" + "\n" +
@"                                        ""Entity"": ""Dates"",
" + "\n" +
@"                                        ""Type"": 0
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Name"": ""a1"",
" + "\n" +
@"                                        ""Entity"": ""AIR by HR"",
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
@"                                                    ""Source"": ""d""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""Date""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""Date.Date""
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
@"                                                    ""Source"": ""a1""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""Health_Region""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Health_Region""
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
@"                                                    ""Source"": ""a1""
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
@"                                                    ""Source"": ""a1""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""dose_one""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.dose_one""
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
@"                                                    ""Source"": ""a1""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""dose_two""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.dose_two""
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
@"                                                        ""Source"": ""d""
" + "\n" +
@"                                                    }
" + "\n" +
@"                                                },
" + "\n" +
@"                                                ""Property"": ""Date""
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
@"                                        ""Window"": {
" + "\n" +
@"                                            ""Count"":30000,
" + "\n" +
@"                                            ""RestartTokens"": []
" + "\n" +
@"                                        }
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
@"                        ""VisualId"": ""ee826142406ee886ea2e""
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
            bool hasmore = true;
            List<WARawOb2> to = new List<WARawOb2>();
            DateTime latestdate = DateTime.UnixEpoch;
            do
            {
                request.AddOrUpdateParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                JObject des = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
                var bb = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["PH"][0]["DM0"];
                /*var rf = bb[0]["RF"];
                if (rf != null) rf.Remove();
                bb.First.First.Remove();*/
                var cc = bb.SelectTokens("$..C");
                var d0 = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["ValueDicts"]["D0"];
                var d1 = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["ValueDicts"]["D1"];
                foreach (var it in cc)
                {
                    WARawOb2 so = new WARawOb2();
                    JProperty R = (JProperty)it.Parent.Next;
                    if (R?.Name == "R")
                    {
                        var sRval = ((JValue)R.First()).Value.ToString();
                        var rVal = Convert.ToInt32(sRval);
                        var i = 0;
                        if ((rVal & 1) == 1)
                        {
                            so.date = to.Last().date;
                        }
                        else
                        {
                            so.date = it[i].ToString();
                            i++;
                            long unixmil = long.Parse(so.date);
                            var itdate = DateTimeOffset.FromUnixTimeMilliseconds(unixmil);
                            if (itdate.DateTime > latestdate) latestdate = itdate.DateTime;
                            so.date = itdate.ToString("yyyy-MM-dd");
                        }
                        if ((rVal & 2) == 2)
                        {
                            so.Health_Region = to.Last().Health_Region;
                        }
                        else
                        {
                            so.Health_Region = Convert.ToString(it[i]);
                            int hrint = 0;
                            if (int.TryParse(so.Health_Region, out hrint))
                            {
                                so.Health_Region = d0[hrint].ToString();
                            }
                            i++;
                        }
                        if ((rVal & 4) == 4)
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
                        if ((rVal & 8) == 8)
                        {
                            so.dose1 = to.Last().dose1;
                        }
                        else
                        {
                            so.dose1 = Convert.ToInt32(it[i]);
                            i++;
                        }
                        if ((rVal & 16) == 16)
                        {
                            so.dose2 = to.Last().dose2;
                        }
                        else
                        {
                            so.dose2 = Convert.ToInt32(it[i]);
                            i++;
                        }
                    }
                    else
                    {
                        so.date = it[0].ToString();
                        long unixmil = long.Parse(so.date);
                        var itdate = DateTimeOffset.FromUnixTimeMilliseconds(unixmil);
                        if (itdate.DateTime > latestdate) latestdate = itdate.DateTime;
                        so.date = itdate.ToString("yyyy-MM-dd");
                        so.Health_Region = Convert.ToString(it[1]);
                        int hrint = 0;
                        if (int.TryParse(so.Health_Region, out hrint))
                        {
                            so.Health_Region = d0[hrint].ToString();
                        }
                        so.AgeGroup = Convert.ToString(it[2]);
                        if (int.TryParse(so.AgeGroup, out int agegrp))
                        {
                            so.AgeGroup = d1[agegrp].ToString();
                        }
                        so.dose1 = Convert.ToInt32(it[3]);
                        so.dose2 = Convert.ToInt32(it[4]);
                    }
                    to.Add(so);
                }
                JToken RT = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["RT"];
                if (RT == null) hasmore = false;
                else
                {
                    JObject nbody = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(body);
                    JArray rtarray = (JArray)nbody["queries"][0]["Query"]["Commands"][0]["SemanticQueryDataShapeCommand"]["Binding"]["DataReduction"]["Primary"]["Window"]["RestartTokens"];
                    rtarray.Clear();
                    rtarray.Add(RT.Children());
                    body = nbody.ToString();
                    to.Remove(to.Last());
                }
            }
            while (hasmore);
            var grpitems = to.GroupBy(a => new { a.date, a.Health_Region, a.AgeGroup }).ToList();
            List<WARawOb2> results = new List<WARawOb2>();
            foreach (var it in grpitems)
            {
                WARawOb2 no = new WARawOb2();
                no.date = it.Key.date;
                no.Health_Region = it.Key.Health_Region;
                no.AgeGroup = it.Key.AgeGroup;
                no.dose1 = it.Sum(v => v.dose1);
                no.dose2 = it.Sum(v => v.dose2);
                results.Add(no);
            }

            var rlist = new List<List<WARawOb2>>();

            for (int i = 0; i < results.Count; i += 480000)
            {
                rlist.Add(results.GetRange(i, Math.Min(480000, results.Count - i)));
            }

            int A = 1;
            foreach (var ll in rlist)
            {
                JsonObject item = new JsonObject
                {
                    { "date_updated", latestdate },
                    { "data", ll }
                };
                File.WriteAllText("datav2/daily/all" + A +".json", JsonConvert.SerializeObject(item, Formatting.Indented));
                A++;
            }
            
            /*DoPostcodeStats(to);
            DoPostcodeStatsAge(to);
            DoLGAStats(to);
            DoLGAStatsAge(to);*/
        }

        public static void DoPostcodeStats(List<WARawOb> to)
        {
            var poapop2020 = System.IO.File.ReadAllLines("data/poapop2020.csv");
            List<PostcodePop> poplist = new List<PostcodePop>();
            foreach (var ln in poapop2020)
            {
                var cols = ln.Split(',');
                PostcodePop pop = new PostcodePop
                {
                    name = cols[2],
                    c_0_4 = Convert.ToInt32(cols[3]),
                    c_5_11 = Convert.ToInt32(cols[4]),
                    c_12_15 = Convert.ToInt32(cols[5]),
                    c_16_19 = Convert.ToInt32(cols[6]),
                    c_20_24 = Convert.ToInt32(cols[7]),
                    c_25_29 = Convert.ToInt32(cols[8]),
                    c_30_34 = Convert.ToInt32(cols[9]),
                    c_35_39 = Convert.ToInt32(cols[10]),
                    c_40_44 = Convert.ToInt32(cols[11]),
                    c_45_49 = Convert.ToInt32(cols[12]),
                    c_50_54 = Convert.ToInt32(cols[13]),
                    c_55_59 = Convert.ToInt32(cols[14]),
                    c_60_64 = Convert.ToInt32(cols[15]),
                    c_65_69 = Convert.ToInt32(cols[16]),
                    c_70_74 = Convert.ToInt32(cols[17]),
                    c_75_79 = Convert.ToInt32(cols[18]),
                    c_80_84 = Convert.ToInt32(cols[19]),
                    c_85p = Convert.ToInt32(cols[20]),
                };
                var total = Convert.ToInt32(cols[21]);
                pop.c12_plus = total - pop.c_0_4 - pop.c_5_11;
                pop.c16_plus = total - pop.c_0_4 - pop.c_5_11 - pop.c_12_15;
                pop.c5_plus = total - pop.c_0_4;
                pop.pop = total;
                poplist.Add(pop);
            }

            var grppost = to.GroupBy(ss => ss.postcode);
            List<GCCSADetail> sa2det = new List<GCCSADetail>();
            foreach (var it in grppost)
            {
                GCCSADetail sdet = new GCCSADetail();
                sdet.Name = it.Key;
                var s2popa = poplist.Where(sp => sp.name == it.Key);
                PostcodePop s2pop = new PostcodePop();
                s2pop.name = it.Key;
                s2pop.c12_plus = s2popa.Sum(a => a.c12_plus);
                s2pop.c16_plus = s2popa.Sum(a => a.c16_plus);
                s2pop.c_0_4 = s2popa.Sum(a => a.c_0_4);
                s2pop.c_5_11 = s2popa.Sum(a => a.c_5_11);
                s2pop.c_12_15 = s2popa.Sum(a => a.c_12_15);
                s2pop.c_16_19 = s2popa.Sum(a => a.c_16_19);
                s2pop.c_20_24 = s2popa.Sum(a => a.c_20_24);
                s2pop.c_25_29 = s2popa.Sum(a => a.c_25_29);
                s2pop.c_30_34 = s2popa.Sum(a => a.c_30_34);
                s2pop.c_35_39 = s2popa.Sum(a => a.c_35_39);
                s2pop.c_40_44 = s2popa.Sum(a => a.c_40_44);
                s2pop.c_45_49 = s2popa.Sum(a => a.c_45_49);
                s2pop.c_50_54 = s2popa.Sum(a => a.c_50_54);
                s2pop.c_55_59 = s2popa.Sum(a => a.c_55_59);
                s2pop.c_60_64 = s2popa.Sum(a => a.c_60_64);
                s2pop.c_65_69 = s2popa.Sum(a => a.c_65_69);
                s2pop.c_70_74 = s2popa.Sum(a => a.c_70_74);
                s2pop.c_75_79 = s2popa.Sum(a => a.c_75_79);
                s2pop.c_80_84 = s2popa.Sum(a => a.c_80_84);
                s2pop.c_85p = s2popa.Sum(a => a.c_85p);
                if (s2pop != null)
                {
                    sdet.c16_plus = (int)s2pop.c16_plus;
                    sdet.c12_plus = (int)s2pop.c12_plus;
                    sdet.c5_plus = (int)s2pop.c5_plus;
                    sdet.pop = (int)s2pop.pop;
                }
                foreach (var it2 in it)
                {
                    sdet.dose1 += it2.dose1;
                    sdet.dose2 += it2.dose2;
                    sdet.dose3 += it2.dose3;
                    sdet.total_doses += it2.vaccines;
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent = (decimal)sdet.dose1 / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent = (decimal)sdet.dose2 / (decimal)sdet.c12_plus * 100;
                }
                sa2det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa2det);
            File.WriteAllText("data/postcodesummary-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/postcodesummary-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }

        public static void DoPostcodeStatsAge(List<WARawOb> to)
        {
            var poapop2020 = System.IO.File.ReadAllLines("data/poapop2020.csv");
            List<PostcodePop> poplist = new List<PostcodePop>();
            foreach (var ln in poapop2020)
            {
                var cols = ln.Split(',');
                PostcodePop pop = new PostcodePop
                {
                    name = cols[2],
                    c_0_4 = Convert.ToInt32(cols[3]),
                    c_5_11 = Convert.ToInt32(cols[4]),
                    c_12_15 = Convert.ToInt32(cols[5]),
                    c_16_19 = Convert.ToInt32(cols[6]),
                    c_20_24 = Convert.ToInt32(cols[7]),
                    c_25_29 = Convert.ToInt32(cols[8]),
                    c_30_34 = Convert.ToInt32(cols[9]),
                    c_35_39 = Convert.ToInt32(cols[10]),
                    c_40_44 = Convert.ToInt32(cols[11]),
                    c_45_49 = Convert.ToInt32(cols[12]),
                    c_50_54 = Convert.ToInt32(cols[13]),
                    c_55_59 = Convert.ToInt32(cols[14]),
                    c_60_64 = Convert.ToInt32(cols[15]),
                    c_65_69 = Convert.ToInt32(cols[16]),
                    c_70_74 = Convert.ToInt32(cols[17]),
                    c_75_79 = Convert.ToInt32(cols[18]),
                    c_80_84 = Convert.ToInt32(cols[19]),
                    c_85p = Convert.ToInt32(cols[20]),
                };
                var total = Convert.ToInt32(cols[21]);
                pop.c12_plus = total - pop.c_0_4 - pop.c_5_11;
                pop.c16_plus = total - pop.c_0_4 - pop.c_5_11 - pop.c_12_15;
                pop.c5_plus = total - pop.c_0_4;
                pop.pop = total;

                poplist.Add(pop);
            }

            var grppost = to.GroupBy(ss => ss.postcode);
            List<GCCSADetailAge> sa2det = new List<GCCSADetailAge>();
            foreach (var it in grppost)
            {
                GCCSADetailAge sdet = new GCCSADetailAge();
                sdet.Name = it.Key;
                var s2popa = poplist.Where(sp => sp.name == it.Key);
                PostcodePop s2pop = new PostcodePop();
                s2pop.name = it.Key;
                s2pop.c12_plus = s2popa.Sum(a => a.c12_plus);
                s2pop.c16_plus = s2popa.Sum(a => a.c16_plus);
                s2pop.c5_plus = s2popa.Sum(a => a.c5_plus);
                s2pop.pop = s2popa.Sum(a => a.pop);
                s2pop.c_0_4 = s2popa.Sum(a => a.c_0_4);
                s2pop.c_5_11 = s2popa.Sum(a => a.c_5_11);
                s2pop.c_12_15 = s2popa.Sum(a => a.c_12_15);
                s2pop.c_16_19 = s2popa.Sum(a => a.c_16_19);
                s2pop.c_20_24 = s2popa.Sum(a => a.c_20_24);
                s2pop.c_25_29 = s2popa.Sum(a => a.c_25_29);
                s2pop.c_30_34 = s2popa.Sum(a => a.c_30_34);
                s2pop.c_35_39 = s2popa.Sum(a => a.c_35_39);
                s2pop.c_40_44 = s2popa.Sum(a => a.c_40_44);
                s2pop.c_45_49 = s2popa.Sum(a => a.c_45_49);
                s2pop.c_50_54 = s2popa.Sum(a => a.c_50_54);
                s2pop.c_55_59 = s2popa.Sum(a => a.c_55_59);
                s2pop.c_60_64 = s2popa.Sum(a => a.c_60_64);
                s2pop.c_65_69 = s2popa.Sum(a => a.c_65_69);
                s2pop.c_70_74 = s2popa.Sum(a => a.c_70_74);
                s2pop.c_75_79 = s2popa.Sum(a => a.c_75_79);
                s2pop.c_80_84 = s2popa.Sum(a => a.c_80_84);
                s2pop.c_85p = s2popa.Sum(a => a.c_85p);
                if (s2pop != null)
                {
                    sdet.c16_plus = (int)s2pop.c16_plus;
                    sdet.c12_plus = (int)s2pop.c12_plus;
                    sdet.c5_plus = (int)s2pop.c5_plus;
                    sdet.pop = (int)s2pop.pop;
                    int ct_50_69 = 0;
                    int ct_70p = 0;
                    int ct_16_49 = 0;
                    int ct_0_4 = 0;
                    int ct_5_11 = 0;
                    ct_50_69 = (int)(s2pop.c_50_54 + s2pop.c_55_59 + s2pop.c_60_64 + s2pop.c_65_69);
                    ct_70p = (int)(s2pop.c_70_74 + s2pop.c_75_79 + s2pop.c_80_84 + s2pop.c_85p);
                    ct_16_49 = (int)(s2pop.c_16_19 + s2pop.c_20_24 + s2pop.c_25_29 + s2pop.c_30_34 + s2pop.c_35_39 + s2pop.c_40_44 + s2pop.c_45_49);
                    ct_0_4 = (int)(s2pop.c_0_4);
                    ct_5_11 = (int)(s2pop.c_5_11);
                    sdet.c_12_15 = (int)s2pop.c_12_15;
                    sdet.c_16_49 = ct_16_49;
                    sdet.c_50_69 = ct_50_69;
                    sdet.c_70p = ct_70p;
                    sdet.c_0_4 = ct_0_4;
                    sdet.c_5_11 = ct_5_11;
                }

                foreach (var it2 in it)
                {
                    if (it2.AgeGroup == "0 to 4")
                    {
                        sdet.dose1_0_4 += it2.dose1;
                        sdet.dose2_0_4 += it2.dose2;
                        sdet.dose3_0_4 += it2.dose3;
                        sdet.total_doses += it2.vaccines;
                    }
                    else if (it2.AgeGroup == "5 to 11")
                    {
                        sdet.dose1_5_11 += it2.dose1;
                        sdet.dose2_5_11 += it2.dose2;
                        sdet.dose3_5_11 += it2.dose3;
                        sdet.total_doses += it2.vaccines;
                    }
                    else if (it2.AgeGroup == "12 to 15")
                    {
                        sdet.dose1_12_15 += it2.dose1;
                        sdet.dose2_12_15 += it2.dose2;
                        sdet.dose3_12_15 += it2.dose3;
                        sdet.total_doses += it2.vaccines;
                    }
                    else if (it2.AgeGroup == "16 to 49")
                    {
                        sdet.dose1_16_49 += it2.dose1;
                        sdet.dose2_16_49 += it2.dose2;
                        sdet.dose3_16_49 += it2.dose3;
                        sdet.total_doses += it2.vaccines;
                    }
                    else if (it2.AgeGroup == "50 to 69")
                    {
                        sdet.dose1_50_69 += it2.dose1;
                        sdet.dose2_50_69 += it2.dose2;
                        sdet.dose3_50_69 += it2.dose3;
                        sdet.total_doses += it2.vaccines;
                    }
                    else if (it2.AgeGroup == "70 and over")
                    {
                        sdet.dose1_70p += it2.dose1;
                        sdet.dose2_70p += it2.dose2;
                        sdet.dose3_70p += it2.dose3;
                        sdet.total_doses += it2.vaccines;
                    }
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.D3_vaccinated_percent = (sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c16_plus * 100;
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent12 = (sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent12 = (sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent12 = (sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c12_plus * 100;
                }
                if (sdet.c5_plus > 0)
                {
                    sdet.atleast_1dose_percent5 = (sdet.dose1_5_11 + sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.full_vaccinated_percent5 = (sdet.dose2_5_11 + sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.D3_vaccinated_percent5 = (sdet.dose3_5_11 + sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c5_plus * 100;
                }
                if (sdet.pop > 0)
                {
                    sdet.atleast_1dose_percent0 = (sdet.dose1_0_4 + sdet.dose1_5_11 + sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.pop * 100;
                    sdet.full_vaccinated_percent0 = (sdet.dose2_0_4 + sdet.dose2_5_11 + sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.pop * 100;
                    sdet.D3_vaccinated_percent0 = (sdet.dose3_0_4 + sdet.dose3_5_11 + sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.pop * 100;
                }
                if (sdet.c_0_4 > 0)
                {
                    sdet.min1d_0_4_pc = (sdet.dose1_0_4) / (decimal)sdet.c_0_4 * 100;
                    sdet.full_0_4_pc = (sdet.dose2_0_4) / (decimal)sdet.c_0_4 * 100;
                    sdet.D3_0_4_pc = (sdet.dose3_0_4) / (decimal)sdet.c_0_4 * 100;
                }
                if (sdet.c_5_11 > 0)
                {
                    sdet.min1d_5_11_pc = (sdet.dose1_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.full_5_11_pc = (sdet.dose2_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.D3_5_11_pc = (sdet.dose3_5_11) / (decimal)sdet.c_5_11 * 100;
                }
                if (sdet.c_12_15 > 0)
                {
                    sdet.min1d_12_15_pc = (sdet.dose1_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.full_12_15_pc = (sdet.dose2_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.D3_12_15_pc = (sdet.dose3_12_15) / (decimal)sdet.c_12_15 * 100;
                }
                if (sdet.c_16_49 > 0)
                {
                    sdet.min1d_16_49_pc = (sdet.dose1_16_49) / (decimal)sdet.c_16_49 * 100;
                    sdet.full_16_49_pc = (sdet.dose2_16_49) / (decimal)sdet.c_16_49 * 100;
                    sdet.D3_16_49_pc = (sdet.dose3_16_49) / (decimal)sdet.c_16_49 * 100;
                }
                if (sdet.c_50_69 > 0)
                {
                    sdet.min1d_50_69_pc = (sdet.dose1_50_69) / (decimal)sdet.c_50_69 * 100;
                    sdet.full_50_69_pc = (sdet.dose2_50_69) / (decimal)sdet.c_50_69 * 100;
                    sdet.D3_50_69_pc = (sdet.dose3_50_69) / (decimal)sdet.c_50_69 * 100;
                }
                if (sdet.c_70p > 0)
                {
                    sdet.min1d_70p_pc = (sdet.dose1_70p) / (decimal)sdet.c_70p * 100;
                    sdet.full_70p_pc = (sdet.dose2_70p) / (decimal)sdet.c_70p * 100;
                    sdet.D3_70p_pc = (sdet.dose3_70p) / (decimal)sdet.c_70p * 100;
                }
                sa2det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa2det);
            File.WriteAllText("data/postcodesummaryage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/postcodesummaryage-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }

        public static void DoLGAStats(List<WARawOb> to)
        {
            var lgapop2020 = System.IO.File.ReadAllLines("data/lgapop2020.csv");
            List<LGAPop> poplist = new List<LGAPop>();
            foreach (var ln in lgapop2020)
            {
                var cols = ln.Split(',');
                LGAPop pop = new LGAPop
                {
                    name = cols[3],
                    c_0_4 = Convert.ToInt32(cols[4]),
                    c_5_11 = Convert.ToInt32(cols[5]),
                    c_12_15 = Convert.ToInt32(cols[6]),
                    c_16_19 = Convert.ToInt32(cols[7]),
                    c_20_24 = Convert.ToInt32(cols[8]),
                    c_25_29 = Convert.ToInt32(cols[9]),
                    c_30_34 = Convert.ToInt32(cols[10]),
                    c_35_39 = Convert.ToInt32(cols[11]),
                    c_40_44 = Convert.ToInt32(cols[12]),
                    c_45_49 = Convert.ToInt32(cols[13]),
                    c_50_54 = Convert.ToInt32(cols[14]),
                    c_55_59 = Convert.ToInt32(cols[15]),
                    c_60_64 = Convert.ToInt32(cols[16]),
                    c_65_69 = Convert.ToInt32(cols[17]),
                    c_70_74 = Convert.ToInt32(cols[18]),
                    c_75_79 = Convert.ToInt32(cols[19]),
                    c_80_84 = Convert.ToInt32(cols[20]),
                    c_85p = Convert.ToInt32(cols[21]),
                };
                var total = Convert.ToInt32(cols[22]);
                pop.c12_plus = total - pop.c_0_4 - pop.c_5_11;
                pop.c16_plus = total - pop.c_0_4 - pop.c_5_11 - pop.c_12_15;
                pop.c5_plus = total - pop.c_0_4;
                pop.pop = total;
                poplist.Add(pop);
            }

            var lgaposttext = File.ReadAllText("data/lgapost.json");
            JObject lgapostjson = (JObject)JsonConvert.DeserializeObject(lgaposttext);
            JArray ar2 = (JArray)lgapostjson["data"];
            var lgapost = JsonConvert.DeserializeObject<List<LGAPostcode>>(ar2.ToString());

            var lgaoverridetext = File.ReadAllText("data/lgaoverride.json");
            JObject lgaoverridejson = (JObject)JsonConvert.DeserializeObject(lgaoverridetext);
            JArray ar3 = (JArray)lgaoverridejson["data"];
            var lgaoverride = JsonConvert.DeserializeObject<List<LGAPostcode>>(ar3.ToString());

            lgapost.AddRange(lgaoverride);

            var lgagrp = lgapost.GroupBy(s => s.LGA_NAME20);
            List<GCCSADetail> sa2det = new List<GCCSADetail>();
            foreach (var it in lgagrp)
            {
                GCCSADetail sdet = new GCCSADetail();
                sdet.Name = it.Key;
                var s2pop = poplist.SingleOrDefault(sp => sp.name == it.Key);
                if (s2pop != null)
                {
                    sdet.c16_plus = (int)s2pop.c16_plus;
                    sdet.c12_plus = (int)s2pop.c12_plus;
                }
                foreach (var it2 in it)
                {
                    var items2 = to.Where(s => s.postcode == it2.POSTCODE);
                    if (it2.locality == "")
                    {
                        var lgovit = lgaoverride.Where(s => s.POSTCODE == it2.POSTCODE);
                        foreach (var lit2 in lgovit)
                        {
                            items2 = items2.Where(s => s.locality != lit2.locality);
                        }
                    }
                    else
                    {
                        items2 = items2.Where(s => s.locality == it2.locality);
                    }

                    var items = items2.ToList();
                    foreach (var items1 in items)
                    {
                        sdet.dose1 += items1.dose1;
                        sdet.dose2 += items1.dose2;
                        sdet.dose3 += items1.dose3;
                        sdet.total_doses += items1.vaccines;
                    }
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent = (decimal)sdet.dose1 / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent = (decimal)sdet.dose2 / (decimal)sdet.c12_plus * 100;
                }
                sa2det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa2det);
            File.WriteAllText("data/lgasummary-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/lgasummary-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }

        public static void DoLGAStatsAge(List<WARawOb> to)
        {
            var lgapop2020 = System.IO.File.ReadAllLines("data/lgapop2020.csv");
            List<LGAPop> poplist = new List<LGAPop>();
            foreach (var ln in lgapop2020)
            {
                var cols = ln.Split(',');
                LGAPop pop = new LGAPop
                {
                    name = cols[3],
                    c_0_4 = Convert.ToInt32(cols[4]),
                    c_5_11 = Convert.ToInt32(cols[5]),
                    c_12_15 = Convert.ToInt32(cols[6]),
                    c_16_19 = Convert.ToInt32(cols[7]),
                    c_20_24 = Convert.ToInt32(cols[8]),
                    c_25_29 = Convert.ToInt32(cols[9]),
                    c_30_34 = Convert.ToInt32(cols[10]),
                    c_35_39 = Convert.ToInt32(cols[11]),
                    c_40_44 = Convert.ToInt32(cols[12]),
                    c_45_49 = Convert.ToInt32(cols[13]),
                    c_50_54 = Convert.ToInt32(cols[14]),
                    c_55_59 = Convert.ToInt32(cols[15]),
                    c_60_64 = Convert.ToInt32(cols[16]),
                    c_65_69 = Convert.ToInt32(cols[17]),
                    c_70_74 = Convert.ToInt32(cols[18]),
                    c_75_79 = Convert.ToInt32(cols[19]),
                    c_80_84 = Convert.ToInt32(cols[20]),
                    c_85p = Convert.ToInt32(cols[21]),
                };
                var total = Convert.ToInt32(cols[22]);
                pop.c12_plus = total - pop.c_0_4 - pop.c_5_11;
                pop.c16_plus = total - pop.c_0_4 - pop.c_5_11 - pop.c_12_15;
                pop.c5_plus = total - pop.c_0_4;
                pop.pop = total;
                poplist.Add(pop);
            }

            var lgaposttext = File.ReadAllText("data/lgapost.json");
            JObject lgapostjson = (JObject)JsonConvert.DeserializeObject(lgaposttext);
            JArray ar2 = (JArray)lgapostjson["data"];
            var lgapost = JsonConvert.DeserializeObject<List<LGAPostcode>>(ar2.ToString());
            var lgagrp = lgapost.GroupBy(s => s.LGA_NAME20);
            List<GCCSADetailAge> sa2det = new List<GCCSADetailAge>();
            foreach (var it in lgagrp)
            {
                GCCSADetailAge sdet = new GCCSADetailAge();
                sdet.Name = it.Key;
                var s2pop = poplist.SingleOrDefault(sp => sp.name == it.Key);
                if (s2pop != null)
                {
                    sdet.c16_plus = (int)s2pop.c16_plus;
                    sdet.c12_plus = (int)s2pop.c12_plus;
                    sdet.c5_plus = (int)s2pop.c5_plus;
                    sdet.pop = (int)s2pop.pop;
                    int ct_50_69 = 0;
                    int ct_70p = 0;
                    int ct_16_49 = 0;
                    int ct_0_4 = 0;
                    int ct_5_11 = 0;
                    ct_50_69 = (int)(s2pop.c_50_54 + s2pop.c_55_59 + s2pop.c_60_64 + s2pop.c_65_69);
                    ct_70p = (int)(s2pop.c_70_74 + s2pop.c_75_79 + s2pop.c_80_84 + s2pop.c_85p);
                    ct_16_49 = (int)(s2pop.c_16_19 + s2pop.c_20_24 + s2pop.c_25_29 + s2pop.c_30_34 + s2pop.c_35_39 + s2pop.c_40_44 + s2pop.c_45_49);
                    ct_0_4 = (int)(s2pop.c_0_4);
                    ct_5_11 = (int)(s2pop.c_5_11);
                    sdet.c_12_15 = (int)s2pop.c_12_15;
                    sdet.c_16_49 = ct_16_49;
                    sdet.c_50_69 = ct_50_69;
                    sdet.c_70p = ct_70p;
                    sdet.c_0_4 = ct_0_4;
                    sdet.c_5_11 = ct_5_11;
                }

                foreach (var it2 in it)
                {
                    var items = to.Where(s => s.postcode == it2.POSTCODE).ToList();
                    foreach (var items1 in items)
                    {
                        if (items1.AgeGroup == "0 to 4")
                        {
                            sdet.dose1_0_4 += items1.dose1;
                            sdet.dose2_0_4 += items1.dose2;
                            sdet.dose3_0_4 += items1.dose3;
                            sdet.total_doses += items1.vaccines;
                        }
                        else if (items1.AgeGroup == "5 to 11")
                        {
                            sdet.dose1_5_11 += items1.dose1;
                            sdet.dose2_5_11 += items1.dose2;
                            sdet.dose3_5_11 += items1.dose3;
                            sdet.total_doses += items1.vaccines;
                        }
                        else if (items1.AgeGroup == "12 to 15")
                        {
                            sdet.dose1_12_15 += items1.dose1;
                            sdet.dose2_12_15 += items1.dose2;
                            sdet.dose3_12_15 += items1.dose3;
                            sdet.total_doses += items1.vaccines;
                        }
                        else if (items1.AgeGroup == "16 to 49")
                        {
                            sdet.dose1_16_49 += items1.dose1;
                            sdet.dose2_16_49 += items1.dose2;
                            sdet.dose3_16_49 += items1.dose3;
                            sdet.total_doses += items1.vaccines;
                        }
                        else if (items1.AgeGroup == "50 to 69")
                        {
                            sdet.dose1_50_69 += items1.dose1;
                            sdet.dose2_50_69 += items1.dose2;
                            sdet.dose3_50_69 += items1.dose3;
                            sdet.total_doses += items1.vaccines;
                        }
                        else if (items1.AgeGroup == "70 and over")
                        {
                            sdet.dose1_70p += items1.dose1;
                            sdet.dose2_70p += items1.dose2;
                            sdet.dose3_70p += items1.dose3;
                            sdet.total_doses += items1.vaccines;
                        }
                    }
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.D3_vaccinated_percent = (sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c16_plus * 100;
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent12 = (sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent12 = (sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent12 = (sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c12_plus * 100;
                }
                if (sdet.c5_plus > 0)
                {
                    sdet.atleast_1dose_percent5 = (sdet.dose1_5_11 + sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.full_vaccinated_percent5 = (sdet.dose2_5_11 + sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.D3_vaccinated_percent5 = (sdet.dose3_5_11 + sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c5_plus * 100;
                }
                if (sdet.pop > 0)
                {
                    sdet.atleast_1dose_percent0 = (sdet.dose1_0_4 + sdet.dose1_5_11 + sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.pop * 100;
                    sdet.full_vaccinated_percent0 = (sdet.dose2_0_4 + sdet.dose2_5_11 + sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.pop * 100;
                    sdet.D3_vaccinated_percent0 = (sdet.dose3_0_4 + sdet.dose3_5_11 + sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.pop * 100;
                }
                if (sdet.c_0_4 > 0)
                {
                    sdet.min1d_0_4_pc = (sdet.dose1_0_4) / (decimal)sdet.c_0_4 * 100;
                    sdet.full_0_4_pc = (sdet.dose2_0_4) / (decimal)sdet.c_0_4 * 100;
                    sdet.D3_0_4_pc = (sdet.dose3_0_4) / (decimal)sdet.c_0_4 * 100;
                }
                if (sdet.c_5_11 > 0)
                {
                    sdet.min1d_5_11_pc = (sdet.dose1_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.full_5_11_pc = (sdet.dose2_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.D3_5_11_pc = (sdet.dose3_5_11) / (decimal)sdet.c_5_11 * 100;
                }
                if (sdet.c_12_15 > 0)
                {
                    sdet.min1d_12_15_pc = (sdet.dose1_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.full_12_15_pc = (sdet.dose2_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.D3_12_15_pc = (sdet.dose3_12_15) / (decimal)sdet.c_12_15 * 100;
                }
                if (sdet.c_16_49 > 0)
                {
                    sdet.min1d_16_49_pc = (sdet.dose1_16_49) / (decimal)sdet.c_16_49 * 100;
                    sdet.full_16_49_pc = (sdet.dose2_16_49) / (decimal)sdet.c_16_49 * 100;
                    sdet.D3_16_49_pc = (sdet.dose3_16_49) / (decimal)sdet.c_16_49 * 100;
                }
                if (sdet.c_50_69 > 0)
                {
                    sdet.min1d_50_69_pc = (sdet.dose1_50_69) / (decimal)sdet.c_50_69 * 100;
                    sdet.full_50_69_pc = (sdet.dose2_50_69) / (decimal)sdet.c_50_69 * 100;
                    sdet.D3_50_69_pc = (sdet.dose3_50_69) / (decimal)sdet.c_50_69 * 100;
                }
                if (sdet.c_70p > 0)
                {
                    sdet.min1d_70p_pc = (sdet.dose1_70p) / (decimal)sdet.c_70p * 100;
                    sdet.full_70p_pc = (sdet.dose2_70p) / (decimal)sdet.c_70p * 100;
                    sdet.D3_70p_pc = (sdet.dose3_70p) / (decimal)sdet.c_70p * 100;
                }
                sa2det.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", sa2det);
            File.WriteAllText("data/lgasummaryage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/lgasummaryage-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
    }

    class WARawOb2
    {
        public string date { get; set; }
        public string Health_Region { get; set; }
        public int dose1 { get; set; }
        public int dose2 { get; set; }
        public string AgeGroup { get; set; }
    }
}
