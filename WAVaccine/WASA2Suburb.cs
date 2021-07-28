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
    class WASA2Suburb
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
@"                                        ""Name"": ""a"",
" + "\n" +
@"                                        ""Entity"": ""Suburb SA2"",
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
@"                                            ""Property"": ""NAME""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""Suburb SA2.NAME""
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
@"                                            ""Property"": ""POSTCODE""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""Suburb SA2.POSTCODE""
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
@"                                            ""Property"": ""SA2_NAME16""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""Suburb SA2.SA2_NAME16""
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
@"                                                ""Property"": ""NAME""
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
@"                                                2
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
            var d0 = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["ValueDicts"]["D0"];
            var d1 = des["results"][0]["result"]["data"]["dsr"]["DS"][0]["ValueDicts"]["D1"];
            var cc = bb.SelectTokens("$..C");
            List<SA2SuburbOb> to = new List<SA2SuburbOb>();
            DateTime latestdate = DateTime.UnixEpoch;
            foreach (var it in cc)
            {
                SA2SuburbOb po = new SA2SuburbOb();
                JProperty R = (JProperty)it.Parent.Next;
                if (R?.Name == "R")
                {
                    var sRval = ((JValue)R.First()).Value.ToString();
                    var rVal = Convert.ToInt32(sRval);
                    var i = 0;
                    if ((rVal & 1) == 1)
                    {
                        po.name = to.Last().name;
                    }
                    else
                    {
                        po.name = it[i].ToString();
                        if (Int32.TryParse(po.name, out int result))
                        {
                            po.name = d0[result].ToString();
                        }
                        i++;
                    }
                    if ((rVal & 2) == 2)
                    {
                        po.postcode = to.Last().postcode;
                    }
                    else
                    {
                        po.postcode = Convert.ToString(it[i]);
                        i++;
                    }
                    if ((rVal & 4) == 4)
                    {
                        po.SA2_Name = to.Last().SA2_Name;
                    }
                    else
                    {
                        po.SA2_Name = Convert.ToString(it[i]);
                        if (Int32.TryParse(po.SA2_Name, out int result2))
                        {
                            po.SA2_Name = d1[result2].ToString();
                        }
                        i++;
                    }
                }
                else
                {
                    po.name = it[0].ToString();
                    if (Int32.TryParse(po.name, out int result))
                    {
                        po.name = d0[result].ToString();
                    }
                    po.postcode = Convert.ToString(it[1]);
                    po.SA2_Name = Convert.ToString(it[2]);
                    if (Int32.TryParse(po.SA2_Name, out int result2))
                    {
                        po.SA2_Name = d1[result2].ToString();
                    }
                }
                to.Add(po);
            }
            JsonObject item = new JsonObject();
            item.Add("date_updated", latestdate);
            item.Add("data", to);
            File.WriteAllText("data/sa2suburb.json", JsonConvert.SerializeObject(item, Formatting.Indented));
        }
    }

    class SA2SuburbOb
    {
        public string name { get; set; }
        public string postcode { get; set; }
        public string SA2_Name { get; set; }
    }
}
