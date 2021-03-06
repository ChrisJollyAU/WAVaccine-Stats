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
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Aggregation"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""Column"": {
" + "\n" +
@"                                                    ""Expression"": {
" + "\n" +
@"                                                        ""SourceRef"": {
" + "\n" +
@"                                                            ""Source"": ""a""
" + "\n" +
@"                                                        }
" + "\n" +
@"                                                    },
" + "\n" +
@"                                                    ""Property"": ""vaccines""
" + "\n" +
@"                                                },
" + "\n" +
@"                                                ""Name"": ""AIR.vaccines""
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Function"": 0
" + "\n" +
@"                                        }
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Aggregation"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""Column"": {
" + "\n" +
@"                                                    ""Expression"": {
" + "\n" +
@"                                                        ""SourceRef"": {
" + "\n" +
@"                                                            ""Source"": ""a""
" + "\n" +
@"                                                        }
" + "\n" +
@"                                                    },
" + "\n" +
@"                                                    ""Property"": ""dose_one""
" + "\n" +
@"                                                },
" + "\n" +
@"                                                ""Name"": ""AIR.dose_one""
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Function"": 0
" + "\n" +
@"                                        }
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Aggregation"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""Column"": {
" + "\n" +
@"                                                    ""Expression"": {
" + "\n" +
@"                                                        ""SourceRef"": {
" + "\n" +
@"                                                            ""Source"": ""a""
" + "\n" +
@"                                                        }
" + "\n" +
@"                                                    },
" + "\n" +
@"                                                    ""Property"": ""dose_two""
" + "\n" +
@"                                                },
" + "\n" +
@"                                                ""Name"": ""AIR.dose_two""
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Function"": 0
" + "\n" +
@"                                        }
" + "\n" +
@"                                    },
" + "\n" +
@"                                    {
" + "\n" +
@"                                        ""Aggregation"": {
" + "\n" +
@"                                            ""Expression"": {
" + "\n" +
@"                                                ""Column"": {
" + "\n" +
@"                                                    ""Expression"": {
" + "\n" +
@"                                                        ""SourceRef"": {
" + "\n" +
@"                                                            ""Source"": ""a""
" + "\n" +
@"                                                        }
" + "\n" +
@"                                                    },
" + "\n" +
@"                                                    ""Property"": ""dose_3""
" + "\n" +
@"                                                },
" + "\n" +
@"                                                ""Name"": ""AIR.dose_3""
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Function"": 0
" + "\n" +
@"                                        }
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
@"                                                4,
" + "\n" +
@"                                                5
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
                    if ((rVal & 32) == 32)
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
                    so.dose_3 = Convert.ToInt32(it[5]);
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
                pop.c5_plus = total - pop.c_0_4;
                pop.pop = total;
                sa2pop.Add(pop);
            }

            var grpsa2sub = sa2sub.GroupBy(ss => ss.SA2_Name);
            List<SA2DetailAge> sa2det = new List<SA2DetailAge>();
            List<SA2PopOb> usedsa2 = new List<SA2PopOb>();
            foreach (var it in grpsa2sub)
            {
                SA2DetailAge sdet = new SA2DetailAge();
                sdet.SA2Name = it.Key;
                var s2pop = sa2pop.SingleOrDefault(sp => sp.SA2 == it.Key);
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
                    usedsa2.Add(s2pop);
                }

                foreach (var it2 in it)
                {
                    List<SuburbObjectAge> obs = to.Where(tt => tt.suburb_name == it2.name).ToList();
                    foreach (var ob in obs)
                    {
                        if (ob.AgeGroup == "0 to 4")
                        {
                            sdet.dose1_0_4 += ob.dose_1;
                            sdet.dose2_0_4 += ob.dose_2;
                            sdet.dose3_0_4 += ob.dose_3;
                            sdet.total_doses += ob.total_dose;
                        }
                        else if (ob.AgeGroup == "5 to 11")
                        {
                            sdet.dose1_5_11 += ob.dose_1;
                            sdet.dose2_5_11 += ob.dose_2;
                            sdet.dose3_5_11 += ob.dose_3;
                            sdet.total_doses += ob.total_dose;
                        }
                        else if (ob.AgeGroup == "12 to 15")
                        {
                            sdet.dose1_12_15 += ob.dose_1;
                            sdet.dose2_12_15 += ob.dose_2;
                            sdet.dose3_12_15 += ob.dose_3;
                            sdet.total_doses += ob.total_dose;
                        }
                        else if (ob.AgeGroup == "16 to 49")
                        {
                            sdet.dose1_16_49 += ob.dose_1;
                            sdet.dose2_16_49 += ob.dose_2;
                            sdet.dose3_16_49 += ob.dose_3;
                            sdet.total_doses += ob.total_dose;
                        }
                        else if (ob.AgeGroup == "50 to 69")
                        {
                            sdet.dose1_50_69 += ob.dose_1;
                            sdet.dose2_50_69 += ob.dose_2;
                            sdet.dose3_50_69 += ob.dose_3;
                            sdet.total_doses += ob.total_dose;
                        }
                        else if (ob.AgeGroup == "70 and over")
                        {
                            sdet.dose1_70p += ob.dose_1;
                            sdet.dose2_70p += ob.dose_2;
                            sdet.dose3_70p += ob.dose_3;
                            sdet.total_doses += ob.total_dose;
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
            var xyz = sa2pop.Where(x => x.State == "Western Australia").Except(usedsa2).ToList();
            foreach (var it in xyz)
            {
                SA2DetailAge sdet = new SA2DetailAge();
                sdet.SA2Name = it.SA2;
                sdet.c16_plus = (int)it.c16_plus;
                sdet.c12_plus = (int)it.c12_plus;
                sdet.c5_plus = (int)it.c5_plus;
                sdet.pop = (int)it.pop;
                int ct_50_69 = 0;
                int ct_70p = 0;
                int ct_16_49 = 0;
                int ct_0_4 = 0;
                int ct_5_11 = 0;
                ct_50_69 = (int)(it.c_50_54 + it.c_55_59 + it.c_60_64 + it.c_65_69);
                ct_70p = (int)(it.c_70_74 + it.c_75_79 + it.c_80_84 + it.c_85p);
                ct_16_49 = (int)(it.c_16_19 + it.c_20_24 + it.c_25_29 + it.c_30_34 + it.c_35_39 + it.c_40_44 + it.c_45_49);
                ct_0_4 = (int)(it.c_0_4);
                ct_5_11 = (int)(it.c_5_11);
                sdet.c_12_15 = (int)it.c_12_15;
                sdet.c_16_49 = ct_16_49;
                sdet.c_50_69 = ct_50_69;
                sdet.c_70p = ct_70p;
                sdet.c_0_4 = ct_0_4;
                sdet.c_5_11 = ct_5_11;
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
                        sdet.c12_plus += s2det.c12_plus;
                        sdet.c5_plus += s2det.c5_plus;
                        sdet.pop += s2det.pop;
                        sdet.c_0_4 += s2det.c_0_4;
                        sdet.c_5_11 += s2det.c_5_11;
                        sdet.c_12_15 += s2det.c_12_15;
                        sdet.c_16_49 += s2det.c_16_49;
                        sdet.c_50_69 += s2det.c_50_69;
                        sdet.c_70p += s2det.c_70p;
                        sdet.dose1_0_4 += s2det.dose1_0_4;
                        sdet.dose1_5_11 += s2det.dose1_5_11;
                        sdet.dose1_12_15 += s2det.dose1_12_15;
                        sdet.dose1_16_49 += s2det.dose1_16_49;
                        sdet.dose1_50_69 += s2det.dose1_50_69;
                        sdet.dose1_70p += s2det.dose1_70p;
                        sdet.dose2_0_4 += s2det.dose2_0_4;
                        sdet.dose2_5_11 += s2det.dose2_5_11;
                        sdet.dose2_12_15 += s2det.dose2_12_15;
                        sdet.dose2_16_49 += s2det.dose2_16_49;
                        sdet.dose2_50_69 += s2det.dose2_50_69;
                        sdet.dose2_70p += s2det.dose2_70p;
                        sdet.dose3_0_4 += s2det.dose3_0_4;
                        sdet.dose3_5_11 += s2det.dose3_5_11;
                        sdet.dose3_12_15 += s2det.dose3_12_15;
                        sdet.dose3_16_49 += s2det.dose3_16_49;
                        sdet.dose3_50_69 += s2det.dose3_50_69;
                        sdet.dose3_70p += s2det.dose3_70p;
                    }
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
                if (sdet.c5_plus > 0)
                {
                    sdet.atleast_1dose_percent5 = (sdet.dose1_5_11 + sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.full_vaccinated_percent5 = (sdet.dose2_5_11 + sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.D3_vaccinated_percent5 = (sdet.dose3_5_11 + sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c5_plus * 100;
                }
                if (sdet.c_5_11 > 0)
                {
                    sdet.min1d_5_11_pc = (sdet.dose1_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.full_5_11_pc = (sdet.dose2_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.D3_5_11_pc = (sdet.dose3_5_11) / (decimal)sdet.c_5_11 * 100;
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent12 = (sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent12 = (sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent12 = (sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c12_plus * 100;
                }
                if (sdet.c_12_15 > 0)
                {
                    sdet.min1d_12_15_pc = (sdet.dose1_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.full_12_15_pc = (sdet.dose2_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.D3_12_15_pc = (sdet.dose3_12_15) / (decimal)sdet.c_12_15 * 100;
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.D3_vaccinated_percent = (sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c16_plus * 100;
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
                        sdet.c12_plus += s2det.c12_plus;
                        sdet.c5_plus += s2det.c5_plus;
                        sdet.pop += s2det.pop;
                        sdet.c_0_4 += s2det.c_0_4;
                        sdet.c_5_11 += s2det.c_5_11;
                        sdet.c_12_15 += s2det.c_12_15;
                        sdet.c_16_49 += s2det.c_16_49;
                        sdet.c_50_69 += s2det.c_50_69;
                        sdet.c_70p += s2det.c_70p;
                        sdet.dose1_0_4 += s2det.dose1_0_4;
                        sdet.dose1_5_11 += s2det.dose1_5_11;
                        sdet.dose1_12_15 += s2det.dose1_12_15;
                        sdet.dose1_16_49 += s2det.dose1_16_49;
                        sdet.dose1_50_69 += s2det.dose1_50_69;
                        sdet.dose1_70p += s2det.dose1_70p;
                        sdet.dose2_0_4 += s2det.dose2_0_4;
                        sdet.dose2_5_11 += s2det.dose2_5_11;
                        sdet.dose2_12_15 += s2det.dose2_12_15;
                        sdet.dose2_16_49 += s2det.dose2_16_49;
                        sdet.dose2_50_69 += s2det.dose2_50_69;
                        sdet.dose2_70p += s2det.dose2_70p;
                        sdet.dose3_0_4 += s2det.dose3_0_4;
                        sdet.dose3_5_11 += s2det.dose3_5_11;
                        sdet.dose3_12_15 += s2det.dose3_12_15;
                        sdet.dose3_16_49 += s2det.dose3_16_49;
                        sdet.dose3_50_69 += s2det.dose3_50_69;
                        sdet.dose3_70p += s2det.dose3_70p;
                    }
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
                if (sdet.c5_plus > 0)
                {
                    sdet.atleast_1dose_percent5 = (sdet.dose1_5_11 + sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.full_vaccinated_percent5 = (sdet.dose2_5_11 + sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.D3_vaccinated_percent5 = (sdet.dose3_5_11 + sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c5_plus * 100;
                }
                if (sdet.c_5_11 > 0)
                {
                    sdet.min1d_5_11_pc = (sdet.dose1_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.full_5_11_pc = (sdet.dose2_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.D3_5_11_pc = (sdet.dose3_5_11) / (decimal)sdet.c_5_11 * 100;
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent12 = (sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent12 = (sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent12 = (sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c12_plus * 100;
                }
                if (sdet.c_12_15 > 0)
                {
                    sdet.min1d_12_15_pc = (sdet.dose1_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.full_12_15_pc = (sdet.dose2_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.D3_12_15_pc = (sdet.dose3_12_15) / (decimal)sdet.c_12_15 * 100;
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.D3_vaccinated_percent = (sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c16_plus * 100;
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
                        sdet.c12_plus += s2det.c12_plus;
                        sdet.c5_plus += s2det.c5_plus;
                        sdet.pop += s2det.pop;
                        sdet.c_0_4 += s2det.c_0_4;
                        sdet.c_5_11 += s2det.c_5_11;
                        sdet.c_12_15 += s2det.c_12_15;
                        sdet.c_16_49 += s2det.c_16_49;
                        sdet.c_50_69 += s2det.c_50_69;
                        sdet.c_70p += s2det.c_70p;
                        sdet.dose1_0_4 += s2det.dose1_0_4;
                        sdet.dose1_5_11 += s2det.dose1_5_11;
                        sdet.dose1_12_15 += s2det.dose1_12_15;
                        sdet.dose1_16_49 += s2det.dose1_16_49;
                        sdet.dose1_50_69 += s2det.dose1_50_69;
                        sdet.dose1_70p += s2det.dose1_70p;
                        sdet.dose2_0_4 += s2det.dose2_0_4;
                        sdet.dose2_5_11 += s2det.dose2_5_11;
                        sdet.dose2_12_15 += s2det.dose2_12_15;
                        sdet.dose2_16_49 += s2det.dose2_16_49;
                        sdet.dose2_50_69 += s2det.dose2_50_69;
                        sdet.dose2_70p += s2det.dose2_70p;
                        sdet.dose3_0_4 += s2det.dose3_0_4;
                        sdet.dose3_5_11 += s2det.dose3_5_11;
                        sdet.dose3_12_15 += s2det.dose3_12_15;
                        sdet.dose3_16_49 += s2det.dose3_16_49;
                        sdet.dose3_50_69 += s2det.dose3_50_69;
                        sdet.dose3_70p += s2det.dose3_70p;
                    }
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
                if (sdet.c5_plus > 0)
                {
                    sdet.atleast_1dose_percent5 = (sdet.dose1_5_11 + sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.full_vaccinated_percent5 = (sdet.dose2_5_11 + sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.D3_vaccinated_percent5 = (sdet.dose3_5_11 + sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c5_plus * 100;
                }
                if (sdet.c_5_11 > 0)
                {
                    sdet.min1d_5_11_pc = (sdet.dose1_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.full_5_11_pc = (sdet.dose2_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.D3_5_11_pc = (sdet.dose3_5_11) / (decimal)sdet.c_5_11 * 100;
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent12 = (sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent12 = (sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent12 = (sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c12_plus * 100;
                }
                if (sdet.c_12_15 > 0)
                {
                    sdet.min1d_12_15_pc = (sdet.dose1_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.full_12_15_pc = (sdet.dose2_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.D3_12_15_pc = (sdet.dose3_12_15) / (decimal)sdet.c_12_15 * 100;
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.D3_vaccinated_percent = (sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c16_plus * 100;
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
                        sdet.c12_plus += s2det.c12_plus;
                        sdet.c5_plus += s2det.c5_plus;
                        sdet.pop += s2det.pop;
                        sdet.c_0_4 += s2det.c_0_4;
                        sdet.c_5_11 += s2det.c_5_11;
                        sdet.c_12_15 += s2det.c_12_15;
                        sdet.c_16_49 += s2det.c_16_49;
                        sdet.c_50_69 += s2det.c_50_69;
                        sdet.c_70p += s2det.c_70p;
                        sdet.dose1_0_4 += s2det.dose1_0_4;
                        sdet.dose1_5_11 += s2det.dose1_5_11;
                        sdet.dose1_12_15 += s2det.dose1_12_15;
                        sdet.dose1_16_49 += s2det.dose1_16_49;
                        sdet.dose1_50_69 += s2det.dose1_50_69;
                        sdet.dose1_70p += s2det.dose1_70p;
                        sdet.dose2_0_4 += s2det.dose2_0_4;
                        sdet.dose2_5_11 += s2det.dose2_5_11;
                        sdet.dose2_12_15 += s2det.dose2_12_15;
                        sdet.dose2_16_49 += s2det.dose2_16_49;
                        sdet.dose2_50_69 += s2det.dose2_50_69;
                        sdet.dose2_70p += s2det.dose2_70p;
                        sdet.dose3_0_4 += s2det.dose3_0_4;
                        sdet.dose3_5_11 += s2det.dose3_5_11;
                        sdet.dose3_12_15 += s2det.dose3_12_15;
                        sdet.dose3_16_49 += s2det.dose3_16_49;
                        sdet.dose3_50_69 += s2det.dose3_50_69;
                        sdet.dose3_70p += s2det.dose3_70p;
                    }
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
                if (sdet.c5_plus > 0)
                {
                    sdet.atleast_1dose_percent5 = (sdet.dose1_5_11 + sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.full_vaccinated_percent5 = (sdet.dose2_5_11 + sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c5_plus * 100;
                    sdet.D3_vaccinated_percent5 = (sdet.dose3_5_11 + sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c5_plus * 100;
                }
                if (sdet.c_5_11 > 0)
                {
                    sdet.min1d_5_11_pc = (sdet.dose1_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.full_5_11_pc = (sdet.dose2_5_11) / (decimal)sdet.c_5_11 * 100;
                    sdet.D3_5_11_pc = (sdet.dose3_5_11) / (decimal)sdet.c_5_11 * 100;
                }
                if (sdet.c12_plus > 0)
                {
                    sdet.atleast_1dose_percent12 = (sdet.dose1_12_15 + sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.full_vaccinated_percent12 = (sdet.dose2_12_15 + sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c12_plus * 100;
                    sdet.D3_vaccinated_percent12 = (sdet.dose3_12_15 + sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c12_plus * 100;
                }
                if (sdet.c_12_15 > 0)
                {
                    sdet.min1d_12_15_pc = (sdet.dose1_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.full_12_15_pc = (sdet.dose2_12_15) / (decimal)sdet.c_12_15 * 100;
                    sdet.D3_12_15_pc = (sdet.dose3_12_15) / (decimal)sdet.c_12_15 * 100;
                }
                if (sdet.c16_plus > 0)
                {
                    sdet.atleast_1dose_percent = (sdet.dose1_16_49 + sdet.dose1_50_69 + sdet.dose1_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.full_vaccinated_percent = (sdet.dose2_16_49 + sdet.dose2_50_69 + sdet.dose2_70p) / (decimal)sdet.c16_plus * 100;
                    sdet.D3_vaccinated_percent = (sdet.dose3_16_49 + sdet.dose3_50_69 + sdet.dose3_70p) / (decimal)sdet.c16_plus * 100;
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
                }
                gccsadet.Add(sdet);
            }
            var date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
            JsonObject item = new JsonObject();
            item.Add("date", date);
            item.Add("data", gccsadet);
            File.WriteAllText("data/wasummaryage-" + date + ".json", JsonConvert.SerializeObject(item, Formatting.Indented));
            File.WriteAllText("data/wasummaryage-latest.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
    }

    class SuburbObjectAge
    {
        public string suburb_name { get; set; }
        public int total_dose { get; set; }
        public int dose_1 { get; set; }
        public int dose_2 { get; set; }
        public int dose_3 { get; internal set; }
        public string AgeGroup { get; set; }
    }
    class SA2DetailAge
    {
        internal decimal D3_5_11_pc;

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
        public int c12_plus { get; set; }
        public int dose1_12_15 { get; set; }
        public int dose2_12_15 { get; set; }
        public decimal atleast_1dose_percent12 { get; set; }
        public decimal full_vaccinated_percent12 { get; set; }
        public int c_12_15 { get; set; }
        public decimal min1d_12_15_pc { get; set; }
        public decimal full_12_15_pc { get; set; }
        public int dose3_12_15 { get; internal set; }
        public int dose3_16_49 { get; internal set; }
        public int dose3_50_69 { get; internal set; }
        public int dose3_70p { get; internal set; }
        public decimal D3_vaccinated_percent { get; internal set; }
        public decimal D3_vaccinated_percent12 { get; internal set; }
        public decimal D3_70p_pc { get; internal set; }
        public decimal D3_50_69_pc { get; internal set; }
        public decimal D3_16_49_pc { get; internal set; }
        public decimal D3_12_15_pc { get; internal set; }
        public int c5_plus { get; internal set; }
        public int pop { get; internal set; }
        public int c_0_4 { get; internal set; }
        public int c_5_11 { get; internal set; }
        public int dose1_0_4 { get; internal set; }
        public int dose2_0_4 { get; internal set; }
        public int dose3_0_4 { get; internal set; }
        public int dose1_5_11 { get; internal set; }
        public int dose2_5_11 { get; internal set; }
        public int dose3_5_11 { get; internal set; }
        public decimal min1d_0_4_pc { get; internal set; }
        public decimal full_0_4_pc { get; internal set; }
        public decimal D3_0_4_pc { get; internal set; }
        public decimal min1d_5_11_pc { get; internal set; }
        public decimal full_5_11_pc { get; internal set; }
        public decimal atleast_1dose_percent0 { get; internal set; }
        public decimal full_vaccinated_percent0 { get; internal set; }
        public decimal D3_vaccinated_percent0 { get; internal set; }
        public decimal atleast_1dose_percent5 { get; internal set; }
        public decimal full_vaccinated_percent5 { get; internal set; }
        public decimal D3_vaccinated_percent5 { get; internal set; }

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
        public int c12_plus { get; set; }
        public int c_12_15 { get; set; }
        public int dose1_12_15 { get; set; }
        public int dose2_12_15 { get; set; }
        public decimal atleast_1dose_percent12 { get; set; }
        public decimal full_vaccinated_percent12 { get; set; }
        public decimal min1d_12_15_pc { get; set; }
        public decimal full_12_15_pc { get; set; }
        public int dose3_12_15 { get; internal set; }
        public int dose3_16_49 { get; internal set; }
        public int dose3_50_69 { get; internal set; }
        public int dose3_70p { get; internal set; }
        public decimal D3_vaccinated_percent12 { get; internal set; }
        public decimal D3_12_15_pc { get; internal set; }
        public decimal D3_vaccinated_percent { get; internal set; }
        public decimal D3_16_49_pc { get; internal set; }
        public decimal D3_50_69_pc { get; internal set; }
        public decimal D3_70p_pc { get; internal set; }
        public int c5_plus { get; internal set; }
        public int pop { get; internal set; }
        public int c_0_4 { get; internal set; }
        public int c_5_11 { get; internal set; }
        public int dose1_0_4 { get; internal set; }
        public int dose1_5_11 { get; internal set; }
        public int dose2_0_4 { get; internal set; }
        public int dose2_5_11 { get; internal set; }
        public int dose3_0_4 { get; internal set; }
        public int dose3_5_11 { get; internal set; }
        public decimal min1d_0_4_pc { get; internal set; }
        public decimal full_0_4_pc { get; internal set; }
        public decimal D3_0_4_pc { get; internal set; }
        public decimal min1d_5_11_pc { get; internal set; }
        public decimal full_5_11_pc { get; internal set; }
        public decimal D3_5_11_pc { get; internal set; }
        public decimal atleast_1dose_percent0 { get; internal set; }
        public decimal full_vaccinated_percent0 { get; internal set; }
        public decimal D3_vaccinated_percent0 { get; internal set; }
        public decimal atleast_1dose_percent5 { get; internal set; }
        public decimal full_vaccinated_percent5 { get; internal set; }
        public decimal D3_vaccinated_percent5 { get; internal set; }
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
        public int c12_plus { get; set; }
        public int c_12_15 { get; set; }
        public int dose1_12_15 { get; set; }
        public int dose2_12_15 { get; set; }
        public decimal atleast_1dose_percent12 { get; set; }
        public decimal full_vaccinated_percent12 { get; set; }
        public decimal min1d_12_15_pc { get; set; }
        public decimal full_12_15_pc { get; set; }
        public int dose3_12_15 { get; internal set; }
        public int dose3_16_49 { get; internal set; }
        public int dose3_50_69 { get; internal set; }
        public int dose3_70p { get; internal set; }
        public decimal D3_vaccinated_percent12 { get; internal set; }
        public decimal D3_12_15_pc { get; internal set; }
        public decimal D3_vaccinated_percent { get; internal set; }
        public decimal D3_70p_pc { get; internal set; }
        public decimal D3_50_69_pc { get; internal set; }
        public decimal D3_16_49_pc { get; internal set; }
        public int c5_plus { get; internal set; }
        public int pop { get; internal set; }
        public int c_0_4 { get; internal set; }
        public int c_5_11 { get; internal set; }
        public int dose1_0_4 { get; internal set; }
        public int dose1_5_11 { get; internal set; }
        public int dose2_0_4 { get; internal set; }
        public int dose2_5_11 { get; internal set; }
        public int dose3_0_4 { get; internal set; }
        public int dose3_5_11 { get; internal set; }
        public decimal min1d_0_4_pc { get; internal set; }
        public decimal full_0_4_pc { get; internal set; }
        public decimal D3_0_4_pc { get; internal set; }
        public decimal min1d_5_11_pc { get; internal set; }
        public decimal full_5_11_pc { get; internal set; }
        public decimal D3_5_11_pc { get; internal set; }
        public decimal atleast_1dose_percent0 { get; internal set; }
        public decimal full_vaccinated_percent0 { get; internal set; }
        public decimal D3_vaccinated_percent0 { get; internal set; }
        public decimal atleast_1dose_percent5 { get; internal set; }
        public decimal full_vaccinated_percent5 { get; internal set; }
        public decimal D3_vaccinated_percent5 { get; internal set; }
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
        public int c12_plus { get; set; }
        public int c_12_15 { get; set; }
        public int dose1_12_15 { get; set; }
        public int dose2_12_15 { get; set; }
        public decimal atleast_1dose_percent12 { get; set; }
        public decimal full_vaccinated_percent12 { get; set; }
        public decimal min1d_12_15_pc { get; set; }
        public decimal full_12_15_pc { get; set; }
        public int dose3_12_15 { get; internal set; }
        public int dose3_16_49 { get; internal set; }
        public int dose3_50_69 { get; internal set; }
        public int dose3_70p { get; internal set; }
        public decimal D3_vaccinated_percent12 { get; internal set; }
        public decimal D3_12_15_pc { get; internal set; }
        public decimal D3_vaccinated_percent { get; internal set; }
        public decimal D3_16_49_pc { get; internal set; }
        public decimal D3_50_69_pc { get; internal set; }
        public decimal D3_70p_pc { get; internal set; }
        public int c5_plus { get; internal set; }
        public int pop { get; internal set; }
        public int c_0_4 { get; internal set; }
        public int c_5_11 { get; internal set; }
        public int dose1_0_4 { get; internal set; }
        public int dose1_5_11 { get; internal set; }
        public int dose2_0_4 { get; internal set; }
        public int dose2_5_11 { get; internal set; }
        public int dose3_0_4 { get; internal set; }
        public int dose3_5_11 { get; internal set; }
        public decimal min1d_0_4_pc { get; internal set; }
        public decimal full_0_4_pc { get; internal set; }
        public decimal D3_0_4_pc { get; internal set; }
        public decimal min1d_5_11_pc { get; internal set; }
        public decimal full_5_11_pc { get; internal set; }
        public decimal D3_5_11_pc { get; internal set; }
        public decimal atleast_1dose_percent0 { get; internal set; }
        public decimal full_vaccinated_percent0 { get; internal set; }
        public decimal D3_vaccinated_percent0 { get; internal set; }
        public decimal atleast_1dose_percent5 { get; internal set; }
        public decimal full_vaccinated_percent5 { get; internal set; }
        public decimal D3_vaccinated_percent5 { get; internal set; }
    }
}
