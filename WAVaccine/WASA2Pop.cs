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
    class WASA2Pop
    {
        public static void Execute()
        {
            /*var client = new RestClient("https://wabi-australia-southeast-api.analysis.windows.net/public/reports/querydata?synchronous=true");
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
@"                                        ""Entity"": ""SA2 Population"",
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
@"                                            ""Property"": ""SA2_Name""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""SA2 Population.SA2_Name""
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
@"                                            ""Property"": ""C16_Plus""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""SA2 Population.C16_Plus""
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
@"                                            ""Property"": ""C12_Plus""
" + "\n" +
@"                                        },
" + "\n" +
@"                                        ""Name"": ""SA2 Population.C12_Plus""
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
@"                                                ""Property"": ""SA2_Name""
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
            var cc = bb.SelectTokens("$..C");
            List<SA2PopOb> to = new List<SA2PopOb>();
            DateTime latestdate = DateTime.UnixEpoch;
            foreach (var it in cc)
            {
                SA2PopOb po = new SA2PopOb();
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
                        po.c16_plus = to.Last().c16_plus;
                    }
                    else
                    {
                        po.c16_plus = Convert.ToDecimal(it[i]);
                        i++;
                    }
                    if ((rVal & 4) == 4)
                    {
                        po.c12_plus = to.Last().c12_plus;
                    }
                    else
                    {
                        po.c12_plus = Convert.ToDecimal(it[i]);
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
                    po.c16_plus = Convert.ToDecimal(it[1]);
                    po.c12_plus = Convert.ToDecimal(it[2]);
                }
                to.Add(po);
            }
            JsonObject item = new JsonObject();
            item.Add("date_updated", latestdate);
            item.Add("data", to);
            File.WriteAllText("data/sa2pop.json", JsonConvert.SerializeObject(item, Formatting.Indented));*/
        }
    }

    class SA2PopOb
    {
        public string SA2 { get; set; }
        public string SA3 { get; set; }
        public string SA4 { get; set; }
        public string GCCSA { get; set; }
        public string State { get; set; }
        public decimal c12_plus { get; set; }
        public decimal c16_plus { get; set; }
        public decimal c_0_4 { get; set; }
        public decimal c_5_11 { get; set; }
        public decimal c_12_15 { get; set; }
        public decimal c_16_19 { get; set; }
        public decimal c_20_24 { get; set; }
        public decimal c_25_29 { get; set; }
        public decimal c_30_34 { get; set; }
        public decimal c_35_39 { get; set; }
        public decimal c_40_44 { get; set; }
        public decimal c_45_49 { get; set; }
        public decimal c_50_54 { get; set; }
        public decimal c_55_59 { get; set; }
        public decimal c_60_64 { get; set; }
        public decimal c_65_69 { get; set; }
        public decimal c_70_74 { get; set; }
        public decimal c_75_79 { get; set; }
        public decimal c_80_84 { get; set; }
        public decimal c_85p { get; set; }
    }
}
