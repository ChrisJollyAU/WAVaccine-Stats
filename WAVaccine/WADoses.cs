using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
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
    class WADoses
    {
        public static void DoDoses()
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
@"                                                            ""Source"": ""a1""
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
@"                                                            ""Source"": ""a1""
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
@"                                                            ""Source"": ""a1""
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
@"                                                            ""Source"": ""a1""
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
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            JObject des = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
            var bb = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["PH"][0]["DM0"];

            bb.First.First.Remove();
            var cc = bb.SelectMany(v => v.First);
            List<DoseObject> to = new List<DoseObject>();
            DateTime latestdate = DateTime.UnixEpoch;
            foreach (var it in cc)
            {
                DoseObject so = new DoseObject();
                JProperty R = (JProperty)it.Parent.Next;
                long unixmil = long.Parse(it[0].ToString());
                var itdate = DateTimeOffset.FromUnixTimeMilliseconds(unixmil);
                if (itdate.DateTime > latestdate) latestdate = itdate.DateTime;
                if (R?.Name == "R")
                {
                    var sRval = ((JValue)R.First()).Value.ToString();
                    var i = 0;
                    var rVal = Convert.ToInt32(sRval);
                    if ((rVal & 1) == 1)
                    {
                        so.date = to.Last().date;
                    }
                    else
                    {
                        so.date = itdate.ToString("yyyy-MM-dd");
                        i++;
                    }
                    if ((rVal & 2) == 2)
                    {
                        so.total_administered = to.Last().total_administered;
                    }
                    else
                    {
                        so.total_administered = Convert.ToInt32(it[i]);
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
                    so.date = itdate.ToString("yyyy-MM-dd");
                    so.total_administered = Convert.ToInt32(it[1]);
                    so.dose_1 = Convert.ToInt32(it[2]);
                    so.dose_2 = Convert.ToInt32(it[3]);
                    so.dose_3 = Convert.ToInt32(it[4]);
                }
                to.Add(so);
            }
            var xxx = to.GroupBy(x => x.date);
            JsonObject item = new JsonObject();
            item.Add("date_updated", latestdate.ToString("yyyy-MM-dd"));
            item.Add("data", to);
            File.WriteAllText("data/doses.json", JsonConvert.SerializeObject(item, Formatting.Indented));
            Queue<DoseObject> queue = new Queue<DoseObject>();
            List<DoseObject> rollavg = new List<DoseObject>();
            var grpitems = to.GroupBy(tt => tt.date);
            foreach (var it in grpitems)
            {
                queue.Enqueue(it.First());
                if (queue.Count > 7) queue.Dequeue();
                DoseObject doo = new DoseObject();
                doo.date = it.Key;
                doo.dose_1 = queue.Average(qq => qq.dose_1);
                doo.dose_2 = queue.Average(qq => qq.dose_2);
                doo.dose_3 = queue.Average(qq => qq.dose_3);
                doo.total_administered = queue.Average(qq => qq.total_administered);
                rollavg.Add(doo);
            }
            JsonObject item2 = new JsonObject();
            item2.Add("date_updated", latestdate.ToString("yyyy-MM-dd"));
            item2.Add("data", rollavg);
            File.WriteAllText("data/rollavgfirstsecond.json", JsonConvert.SerializeObject(item2, Formatting.Indented));
        }
    }

    public class DoseObject
    {
        public string date { get; set; }
        public decimal total_administered { get; set; }
        public decimal dose_1 { get; set; }
        public decimal dose_2 { get; set; }
        public decimal dose_3 { get; set; }
    }
}
