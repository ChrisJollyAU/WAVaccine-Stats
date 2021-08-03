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
    class WAPostcodeTimeline
    {
        public static void Execute()
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
@"                                            ""Property"": ""postcode""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.postcode""
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
@"                                                    ""Source"": ""a1""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""Dose 1""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.dose_one""
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
@"                                                    ""Source"": ""a1""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""Dose 2""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.dose_two""
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
@"                                                    ""Source"": ""a1""
" + "\n" +
@"                                                }
" + "\n" +
@"                                            },
" + "\n" +
@"                                            ""Property"": ""Doses administered""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.vaccines""
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
@"                                    },
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
@"                                                        ""Source"": ""a1""
" + "\n" +
@"                                                    }
" + "\n" +
@"                                                },
" + "\n" +
@"                                                ""Property"": ""postcode""
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
            List<WAPostTimeOb> to = new List<WAPostTimeOb>();
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
                //var d1 = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["ValueDicts"]["D1"];
                foreach (var it in cc)
                {
                    WAPostTimeOb so = new WAPostTimeOb();
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
                            so.postcode = to.Last().postcode;
                        }
                        else
                        {
                            so.postcode = Convert.ToString(it[i]);
                            int postint = 0;
                            if (int.TryParse(so.postcode, out postint))
                            {
                                if (postint < 6000)
                                {
                                    so.postcode = d0[postint].ToString();
                                }
                            }
                            i++;
                        }
                        if ((rVal & 4) == 4)
                        {
                            so.dose1 = to.Last().dose1;
                        }
                        else
                        {
                            so.dose1 = Convert.ToInt32(it[i]);
                            i++;
                        }
                        if ((rVal & 8) == 8)
                        {
                            so.dose2 = to.Last().dose2;
                        }
                        else
                        {
                            so.dose2 = Convert.ToInt32(it[i]);
                            i++;
                        }
                        if ((rVal & 16) == 16)
                        {
                            so.vaccines = to.Last().vaccines;
                        }
                        else
                        {
                            so.vaccines = Convert.ToInt32(it[i]);
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
                        so.postcode = Convert.ToString(it[1]);
                        int postint = 0;
                        if (int.TryParse(so.postcode, out postint))
                        {
                            if (postint < 6000)
                            {
                                so.postcode = d0[postint].ToString();
                            }
                        }
                        so.dose1 = Convert.ToInt32(it[2]);
                        so.dose2 = Convert.ToInt32(it[3]);
                        so.vaccines = Convert.ToInt32(it[4]);
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
            var hispost = to.GroupBy(d => new { d.postcode });
            foreach (var post in hispost)
            {
                var grp = post.ToList().GroupBy(ll => ll.date).Select(hi => new WAPostTimeOb
                {
                    date = hi.First().date,
                    postcode = hi.First().postcode,
                    dose1 = hi.Sum(x => x.dose1),
                    dose2 = hi.Sum(x => x.dose2),
                    vaccines = hi.Sum(x => x.vaccines)
                });
                JsonObject litem = new JsonObject();
                litem.Add("date_updated", latestdate);
                litem.Add("postcode", post.Key.postcode);
                litem.Add("data", grp.ToList());
                File.WriteAllText("data/daily/postcode/" + post.Key.postcode + ".json", JsonConvert.SerializeObject(litem, Formatting.Indented));
            }
        }
    }

    class WAPostTimeOb
    {
        public string date { get; set; }
        public string postcode { get; set; }
        public int dose1 { get; set; }
        public int dose2 { get; set; }
        public int vaccines { get; set; }
    }
}
