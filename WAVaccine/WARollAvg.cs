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
    class WARollAvg
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
@"                                            ""Property"": ""Rolling 7 day average measure""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""AIR.Rolling 7 day average measure""
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
@"                                        ""Name"": ""Dates.Date""
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
@"                                                1
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
@"                                    ""DataVolume"": 4,
" + "\n" +
@"                                    ""Primary"": {
" + "\n" +
@"                                        ""BinnedLineSample"": {}
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
@"                        ""VisualId"": ""5e668d21d6e4669c83c2""
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
            List<RollAvgOb> to = new List<RollAvgOb>();
            DateTime latestdate = DateTime.UnixEpoch;
            foreach (var it in cc)
            {
                RollAvgOb po = new RollAvgOb();
                JProperty R = (JProperty)it.Parent.Next;
                if (R?.Name == "R")
                {
                    var sRval = ((JValue)R.First()).Value.ToString();
                    var rVal = Convert.ToInt32(sRval);
                    var i = 0;
                    if ((rVal & 1) == 1)
                    {
                        po.date = to.Last().date;
                    }
                    else
                    {
                        po.date = it[i].ToString();
                        i++;
                        long unixmil = long.Parse(po.date);
                        var itdate = DateTimeOffset.FromUnixTimeMilliseconds(unixmil);
                        if (itdate.DateTime > latestdate) latestdate = itdate.DateTime;
                        po.date = itdate.ToString("yyyy-MM-dd");
                    }
                    if ((rVal & 2) == 2)
                    {
                        po.doses = to.Last().doses;
                    }
                    else
                    {
                        po.doses = Convert.ToDecimal(it[i]);
                        i++;
                    }
                }
                else
                {
                    po.date = it[0].ToString();
                    long unixmil = long.Parse(po.date);
                    var itdate = DateTimeOffset.FromUnixTimeMilliseconds(unixmil);
                    if (itdate.DateTime > latestdate) latestdate = itdate.DateTime;
                    po.date = itdate.ToString("yyyy-MM-dd");
                    po.doses = Convert.ToDecimal(it[1]);
                }
                to.Add(po);
            }
            JsonObject item = new JsonObject();
            item.Add("date_updated", latestdate);
            item.Add("data", to);
            File.WriteAllText("data/rollavg.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
    }

    class RollAvgOb
    {
        public string date { get; set; }
        public decimal doses { get; set; }
    }
}
