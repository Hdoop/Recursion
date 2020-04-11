using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string data = @"{""trends"": [
            //  {
            //    ""name"": ""Croke Park II"",
            //    ""url"": ""http://twitter.com/search?q=%22Croke+Park+II%22"",
            //    ""promoted_content"": null,
            //    ""query"": ""%22Croke+Park+II%22"",
            //    ""events"": null,
            //    ""List"":{
            //                ""events"": null,
            //                ""Level3"" :{ ""Name"":""Rav"",""RX"":"" CC""}
            //            },
            //    ""List2"":{
            //                ""Level3"" :{ ""Name"":""Rav"",""RX"":"" CC""},
            //                ""events"": null
            //            },
            //    ""Prop1"":""Prop Value"",
            //    ""Level4"":{""L4"":""L4 Name"",""L5"":""L4 Name""},
            //    ""Level5"":{""L"":""L4 Name"",""L7"":""L4 Name""}
            //  },
            //  {
            //    ""name"": ""Siptu"",
            //    ""url"": ""http://twitter.com/search?q=Siptu"",
            //    ""promoted_content"": null,
            //    ""query"": ""Siptu"",
            //    ""events"": null
            //  },
            //  {
            //    ""name"": ""#HNCJ"",
            //    ""url"": ""http://twitter.com/search?q=%23HNCJ"",
            //    ""promoted_content"": null,
            //    ""query"": ""%23HNCJ"",
            //    ""events"": null
            //  },
            //  {
            //    ""name"": ""Boston"",
            //    ""url"": ""http://twitter.com/search?q=Boston"",
            //    ""promoted_content"": null,
            //    ""query"": ""Boston"",
            //    ""events"": null
            //  },
            //  {
            //    ""name"": ""#prayforboston"",
            //    ""url"": ""http://twitter.com/search?q=%23prayforboston"",
            //    ""promoted_content"": null,
            //    ""query"": ""%23prayforboston"",
            //    ""events"": null
            //  },
            //  {
            //    ""name"": ""#TheMrsCarterShow"",
            //    ""url"": ""http://twitter.com/search?q=%23TheMrsCarterShow"",
            //    ""promoted_content"": null,
            //    ""query"": ""%23TheMrsCarterShow"",
            //    ""events"": null
            //  },
            //  {
            //    ""name"": ""#Raw"",
            //    ""url"": ""http://twitter.com/search?q=%23Raw"",
            //    ""promoted_content"": null,
            //    ""query"": ""%23Raw"",
            //    ""events"": null
            //  },
            //  {
            //    ""name"": ""Iran"",
            //    ""url"": ""http://twitter.com/search?q=Iran"",
            //    ""promoted_content"": null,
            //    ""query"": ""Iran"",
            //    ""events"": null
            //  },
            //  {
            //    ""name"": ""#gaa"",
            //    ""url"": ""http://twitter.com/search?q=%23gaa"",
            //    ""promoted_content"": null,
            //    ""query"": ""gaa"",
            //    ""events"": null
            //  },
            //  {
            //    ""name"": ""Facebook"",
            //    ""url"": ""http://twitter.com/search?q=Facebook"",
            //    ""promoted_content"": null,
            //    ""query"": ""Facebook"",
            //    ""events"": null
            //  }]}";


            //new Tester().GetJsonToExcel(data);

            string data = @"{""properties"": {
                ""mode"": ""all"",
                ""parameters"": {
                            ""allowedLocations"": {
                                ""type"": ""array"",
                        ""metadata"": {
                                    ""description"": ""test"",
                            ""strongType"": ""location"",
                            ""displayName"": ""Allowed locations""
                        },
                        ""defaultValue"": ""test""
                            }
                        },
                ""displayName"": ""Allowed locations"",
                ""description"": ""test"",
                ""policyRule"": {
                    ""if"": {
                        ""not"": {
                            ""field"": ""location"",
                    ""in"": ""test""
                        }
                    },
                ""then"": {
                        ""effect"": ""deny""
            }
                }
            }
        }";

         data = @"{
                ""name"": ""string"",
  ""type"": ""Microsoft.Network / trafficmanagerprofiles"",
  ""apiVersion"": ""2018 - 04 - 01"",
  ""tags"": { },
  ""location"": ""string"",
  ""properties"": {
                    ""profileStatus"": ""string"",
    ""trafficRoutingMethod"": ""string"",
    ""dnsConfig"": {
                        ""relativeName"": ""string"",
      ""ttl"": ""integer""
    },
    ""monitorConfig"": {
                        ""profileMonitorStatus"": ""string"",
      ""protocol"": ""string"",
      ""port"": ""integer"",
      ""path"": ""string"",
      ""intervalInSeconds"": ""integer"",
      ""timeoutInSeconds"": ""integer"",
      ""toleratedNumberOfFailures"": ""integer"",
      ""customHeaders"": [
        {
          ""name"": ""string"",
          ""value"": ""string""
        }
      ],
      ""expectedStatusCodeRanges"": 
        {
          ""min"": ""integer"",
          ""max"": ""integer""
        }
      
    },
    ""endpoints"": [
      {
        ""id"": ""string"",
        ""name"": ""string"",
        ""type"": ""string"",
        ""properties"": {
          ""targetResourceId"": ""string"",
          ""target"": ""string"",
          ""endpointStatus"": ""string"",
          ""weight"": ""integer"",
          ""priority"": ""integer"",
          ""endpointLocation"": ""string"",
          ""endpointMonitorStatus"": ""string"",
          ""minChildEndpoints"": ""integer"",
          ""geoMapping"": [
            ""string""
          ],
          ""subnets"": [
            {
              ""first"": ""string"",
              ""last"": ""string"",
              ""scope"": ""integer""
            }
          ],
          ""customHeaders"": [
            {
              ""name"": ""string"",
              ""value"": ""string""
            }
          ]
        }
      }
    ],
    ""trafficViewEnrollmentStatus"": ""string"",
    ""maxReturn"": ""integer""
  }
}";

           string  data1 = @"{""$schema"": ""https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#"",
            ""contentVersion"": ""1.0.0.0"",
  ""parameters"": {
                ""dnsNamePrefix"": {
                    ""type"": ""string"",
      ""metadata"": {
                        ""description"": ""Sets the domain name prefix for the cluster.  The concatenation of the domain name and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address.""
      }
                },
    ""agentCount"": {
                    ""type"": ""int"",
      ""defaultValue"": 1,
      ""metadata"": {
                        ""description"": ""The number of swarm nodes for the cluster.  This value can be from 1 to 100""
      },
      ""minValue"": 1,
      ""maxValue"": 100
    },
    ""agentVMSize"": {
                    ""type"": ""string"",
      ""defaultValue"": ""Standard_D2_v2"",
      ""allowedValues"": [
        ""Standard_A0"",
        ""Standard_A1"",
        ""Standard_A2"",
        ""Standard_A3"",
        ""Standard_A4"",
        ""Standard_A5"",
        ""Standard_A6"",
        ""Standard_A7"",
        ""Standard_A8"",
        ""Standard_A9"",
        ""Standard_A10"",
        ""Standard_A11"",
        ""Standard_D1"",
        ""Standard_D2"",
        ""Standard_D3"",
        ""Standard_D4"",
        ""Standard_D11"",
        ""Standard_D12"",
        ""Standard_D13"",
        ""Standard_D14"",
        ""Standard_D1_v2"",
        ""Standard_D2_v2"",
        ""Standard_D3_v2"",
        ""Standard_D4_v2"",
        ""Standard_D5_v2"",
        ""Standard_D11_v2"",
        ""Standard_D12_v2"",
        ""Standard_D13_v2"",
        ""Standard_D14_v2"",
        ""Standard_G1"",
        ""Standard_G2"",
        ""Standard_G3"",
        ""Standard_G4"",
        ""Standard_G5"",
        ""Standard_DS1"",
        ""Standard_DS2"",
        ""Standard_DS3"",
        ""Standard_DS4"",
        ""Standard_DS11"",
        ""Standard_DS12"",
        ""Standard_DS13"",
        ""Standard_DS14"",
        ""Standard_GS1"",
        ""Standard_GS2"",
        ""Standard_GS3"",
        ""Standard_GS4"",
        ""Standard_GS5""
      ],
      ""metadata"": {
        ""description"": ""The size of the Virtual Machine.""
      }
    },
    ""linuxAdminUsername"": {
      ""type"": ""string"",
      ""defaultValue"": ""azureuser"",
      ""metadata"": {
        ""description"": ""User name for the Linux Virtual Machines.""
      }
    },
    ""orchestratorType"": {
      ""type"": ""string"",
      ""defaultValue"": ""Swarm"",
      ""allowedValues"": [
        ""DCOS"",
        ""Swarm""
      ],
      ""metadata"": {
        ""description"": ""The type of orchestrator used to manage the applications on the cluster.""
      }
    },
    ""masterCount"": {
      ""type"": ""int"",
      ""defaultValue"": 1,
      ""allowedValues"": [
        1,
        3,
        5
      ],
      ""metadata"": {
        ""description"": ""The number of Swarm managers for the cluster.""
      }
    },
    ""sshRSAPublicKey"": {
      ""type"": ""string"",
      ""metadata"": {
        ""description"": ""Configure all linux machines with the SSH RSA public key string.  Your key should include three parts, for example 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm'""
      }
    },
    ""enableDiagnostics"": {
      ""type"": ""bool"",
      ""defaultValue"": false,
      ""metadata"": {
        ""description"": ""Enable or disable VM diagnostics.""
      }
    },
    ""location"": {
      ""type"": ""string"",
      ""defaultValue"": ""[resourceGroup().location]"",
      ""metadata"": {
        ""description"": ""Location for all resources.""
      }
    }
  },
  ""variables"": {
    ""adminUsername"": ""[parameters('linuxAdminUsername')]"",
    ""agentCount"": ""[parameters('agentCount')]"",
    ""agentsEndpointDNSNamePrefix"": ""[concat(parameters('dnsNamePrefix'),'agents')]"",
    ""agentVMSize"": ""[parameters('agentVMSize')]"",
    ""masterCount"": ""[parameters('masterCount')]"",
    ""mastersEndpointDNSNamePrefix"": ""[concat(parameters('dnsNamePrefix'),'mgmt')]"",
    ""orchestratorType"": ""[parameters('orchestratorType')]"",
    ""sshRSAPublicKey"": ""[parameters('sshRSAPublicKey')]"",
    ""enableDiagnostics"": ""[parameters('enableDiagnostics')]""
  },
  ""resources"": [
    {
      ""apiVersion"": ""2016-09-30"",
      ""type"": ""Microsoft.ContainerService/containerServices"",
      ""location"": ""[parameters('location')]"",
      ""name"": ""[concat('containerservice-',resourceGroup().name)]"",
      ""properties"": {
        ""orchestratorProfile"": {
          ""orchestratorType"": ""[variables('orchestratorType')]""
        },
        ""masterProfile"": {
          ""count"": ""[variables('masterCount')]"",
          ""dnsPrefix"": ""[variables('mastersEndpointDNSNamePrefix')]""
        },
        ""agentPoolProfiles"": [
          {
            ""name"": ""agentpools"",
            ""count"": ""[variables('agentCount')]"",
            ""vmSize"": ""[variables('agentVMSize')]"",
            ""dnsPrefix"": ""[variables('agentsEndpointDNSNamePrefix')]""
          }
        ],
        ""diagnosticsProfile"": {
          ""vmDiagnostics"": {
            ""enabled"": ""[variables('enableDiagnostics')]""
          }
        },
        ""linuxProfile"": {
          ""adminUsername"": ""[variables('adminUsername')]"",
          ""ssh"": {
            ""publicKeys"": [
              {
                ""keyData"": ""[variables('sshRSAPublicKey')]""
              }
            ]
          }
        }
      }
    }
  ],
  ""outputs"": {
    ""masterFQDN"": {
      ""type"": ""string"",
      ""value"": ""[reference(concat('Microsoft.ContainerService/containerServices/', 'containerservice-', resourceGroup().name)).masterProfile.fqdn]""
    },
    ""sshMaster0"": {
      ""type"": ""string"",
      ""value"": ""[concat('ssh ', variables('adminUsername'), '@', reference(concat('Microsoft.ContainerService/containerServices/', 'containerservice-', resourceGroup().name)).masterProfile.fqdn, ' -A -p 2200')]""
    },
    ""agentFQDN"": {
      ""type"": ""string"",
      ""value"": ""[reference(concat('Microsoft.ContainerService/containerServices/', 'containerservice-', resourceGroup().name)).agentPoolProfiles[0].fqdn]""
    }
  }
}";

            new Tester().GetJsonToExcel_V2(data);

        }

       
        public class Tester
        {
            static int col = 1, row = 1; int colreset =1;int level = 0; int precol = 0;
            bool IsLastProperty = false;
            int MaxCol = 1;
            LinkedList<LinklistCell> LList = new LinkedList<LinklistCell>();
            public void GetJsonToExcel(string data)
            {
                try
                {

                    var roottoken = JToken.Parse(data);
                    
                    foreach (var child in roottoken.Children<JProperty>())
                    {
                        if (child.HasValues)
                            NextNode1(child.First()[0]);
                        else
                        {
                            Console.WriteLine($"Properties {row}:{col} {((JProperty)child.Parent).Name} --- {((JProperty)child.Parent).Value}");
                            // row++;
                        }
                    }
                    Console.ReadLine();

                }
                catch (System.Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }

            }
            #region New Block
            private void NodeLastChild(JToken child)
            {

                foreach (var item in child.Children())
                {
                    if (item.HasValues)
                    {
                        switch (item.Type)
                        {
                            case JTokenType.None:
                                break;
                            case JTokenType.Object:

                                if (LastChild.Where(it => it.Key == item.Path).Count() == 0)
                                    LastChild.Add(item.Path, child);

                                break;
                            case JTokenType.Array:

                                if (LastChild.Where(it => it.Key == item.Path).Count() == 0)
                                    LastChild.Add(item.Path, item);

                                break;
                            case JTokenType.Property:

                                if (LastChild.Where(it => it.Key == item.Path).Count() == 0)
                                    LastChild.Add(item.Path, item);

                                break;
                            default:
                                break;

                        }
                        NodeLastChild(item);
                    }
                }
            }

            private void GroupColumn(LinkedList<NodeCell> ll,int maxcolumn,out int maxcolumnCtr)
            {
                int tempmaxcolumnCtr = 0;
                maxcolumnCtr = 0;
                try
                {
                    var _llmod = ll.First;
                    int ctr = 1;

                    maxcolumnCtr = 0;
                    int maxcol = 1;
                    do
                    {
                        _llmod.Next.Value.Col = _llmod.Next.Value.Node.Split('.').Length;
                        _llmod.Next.Value.Level = _llmod.Next.Value.Node.Split('.').Length == 2 ? ctr++ : ctr;
                        if (_llmod.Next.Value.Node.Split('.').Length > maxcol)
                        {
                            _llmod.Next.Value.MaxCol = (_llmod.Next.Value.Node.Split('.').Length - 2) + maxcol;
                        }

                        if (_llmod.Next.Value.Col > 2)
                        {

                            _llmod.Next.Value.MaxCol = (_llmod.Next.Value.Node.Split('.').Length - 2) + maxcol;

                        }
                        if (_llmod.Next.Value.Col == 2)
                        {

                            _llmod.Next.Value.MaxCol = 1;

                        }
                        //Console.WriteLine($"{_llmod.Next.Value.Row}{_llmod.Next.Value.Level}:{_llmod.Next.Value.Col}:{_llmod.Next.Value.MaxCol}{_llmod.Next.Value.Node}");
                        _llmod = _llmod.Next;
                        if (_llmod.Next != null && _llmod.Next.Value.Node.Split('.').Length == 2)
                        {
                            var anyprevious = _llmod.Next;
                            while (anyprevious != null && anyprevious.Value.Col != 2)
                            {

                                if (anyprevious.Value.MaxCol > maxcol)
                                {
                                    maxcol = anyprevious.Value.MaxCol;
                                }
                                anyprevious = anyprevious.Previous;

                            }
                        }


                    } while (_llmod.Next != null);


                    _llmod = ll.First;
                    ctr = 1;
                    int mincolumn = 0;
                    string header = "";
                    do
                    {

                        int innerctr = 3;
                        var _levellist = ll.Where(item => item.Level == ctr + 1).ToList<NodeCell>();
                        var _innerlist = ll.Where(item => item.Col == 2 && item.Level == ctr).ToList<NodeCell>();
                        var maxcitem = _levellist.Count() > 1 ? _levellist.Select(item => item.Col) : null;
                        int maxc = 0;
                        if (maxcitem != null && maxcitem.Count() > 0)
                        {
                            maxc = maxcitem.Max();
                        }
                        if (_innerlist.Count > 0)
                        {
                            Console.WriteLine($"{ctr}:{_innerlist[0].Col +maxcolumn}{_innerlist[0].Node}");
                            mincolumn = _levellist.Count() > 1 ? _levellist.Select(item => item.Col).Min() : 0;
                            header = _innerlist[0].Node;
                            var haschildnode = _levellist.Where(item => item.Col == innerctr).ToList<NodeCell>();
                            //if (ctr != mincolumn && haschildnode.Count() > 1)
                            //{
                            //    Console.WriteLine($"{1}:{maxc}{_innerlist[0].Node} Properties");
                            //}
                            //else if (ctr == 2)
                            //{
                            //    Console.WriteLine($"{1}:{maxc}{_innerlist[0].Node} Properties");
                            //}
                        }
                        int headercnt = 0;
                        do
                        {
                            int _row = 1;
                            var maxcollevel=_levellist.Select(item => item.MaxCol);
                            if (maxcollevel != null && maxcollevel.Count() > 0)
                            {
                                tempmaxcolumnCtr= maxcollevel.Max();

                            }
                            _innerlist = _levellist.Where(item => item.Col == innerctr).ToList<NodeCell>();
                            foreach (var item in _innerlist)
                            {
                                if (item.Level ==2)
                                {
                                    Console.WriteLine($"{1}:{item.Col + maxcolumn}{item.Node}");
                                }
                                else if (_row == 1 && item.Col == 3 && item.MaxCol > mincolumn)
                                {
                                    Console.WriteLine($"{1}:{item.MaxCol+1+maxcolumn}{item.Node}");
                                }
                                else
                                {
                                    Console.WriteLine($"{_row}:{item.MaxCol+1+ maxcolumn}{item.Node}");
                                }
                                headercnt++;
                               
                                item.Row = _row++;
                            }
                            innerctr++;
                        } while (innerctr <= maxc);

                        _llmod = _llmod.Next;
                        ctr++;


                    } while (_llmod.Next != null);

                }

                catch (Exception ex)
                {

                }
                maxcolumnCtr = tempmaxcolumnCtr+maxcolumn ;
            }

            private void GroupColumn(Dictionary<String, JToken> keyValues)
            {
                var grplist = (from it in keyValues.Keys
                              select it.Split('.')[0] into gp
                              group gp by gp).ToList();
                int maxcolumn =0, maxcolumnCtr = 0; row = 1;
                foreach (var startwith in grplist)
                {

                    //Object
                    //string startwith = key.Substring(0, key.IndexOf(".", 0));
                    var ll = new LinkedList<NodeCell>();

                    foreach (var it in keyValues.Where(item => item.Key.StartsWith(startwith.Key)))
                    {
                        ll.AddLast(new NodeCell() { Node = it.Key });
                    }

                    
                    if (ll.Count > 1)
                    {
                        Console.WriteLine($"{row++}:{1} {startwith.Key} ");
                        GroupColumn(ll,maxcolumn,out maxcolumnCtr);
                        maxcolumn = maxcolumnCtr;
                    }
                    else
                    {
                        Console.WriteLine($"{row++}:{1} {startwith.Key} ");
                    }


                }
            }
            public void GetJsonToExcel_V2(string data)
            {
                try
                {

                    var roottoken = JToken.Parse(data);
                    //Console.WriteLine($"Properties {row}:{col} {((JProperty)roottoken).Name} --- ");
                    //LList.AddLast(new LinklistCell() { Row = row, Col = col });

                    if (roottoken != null && roottoken.HasValues)
                    {
                        NodeLastChild(roottoken);

                        GroupColumn(LastChild);


                        //NextNode(roottoken);
                    }



                    Console.ReadLine();

                }
                catch (System.Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }

            }

            #endregion New Block
            int Level = 0;
            public void GetJsonToExcel_V1(string data)
            {
                try
                {
                     var roottoken = JToken.Parse(data);
                    //Console.WriteLine($"Properties {row}:{col} {((JProperty)roottoken).Name} --- ");
                    //LList.AddLast(new LinklistCell() { Row = row, Col = col });

                    if (roottoken != null && roottoken.HasValues) {

                        //NodeLastChild(roottoken);
                        //Node_V1();
                        NextNode_V2(roottoken);
                    }

                    
                    foreach (var child in roottoken.Children<JProperty>())
                    {
                        Console.WriteLine($"Properties {row}:{col} {((JProperty)child).Name} --- ");
                        //LList.AddLast(new LinklistCell() { Row = row, Col = col });
                        
                        if (child.HasValues)
                        {
                            NextNode(child);
                        }
                        else
                        {
                            Console.WriteLine($"Properties {row}:{col} {((JProperty)child.Parent).Name} --- {((JProperty)child.Parent).Value}");
                            // row++;
                        }
                    }
                    
                    Console.ReadLine();

                }
                catch (System.Exception ex)
                {
                    throw new System.Exception(ex.Message);
                }

            }
            public LinklistCell LST
            {
                get;set;
            }
            JToken GetParent(JToken token, int parent = 0)
            {
                if (token == null)
                    return null;
                if (parent < 0)
                    throw new ArgumentOutOfRangeException("Must be positive");

                var skipTokens = new[]
                {
                    typeof(JProperty),
                };
                return token.Ancestors()
                    .Where(a => skipTokens.All(t => !t.IsInstanceOfType(a)))
                    .Skip(parent)
                    .FirstOrDefault();
            }
            Dictionary<string, JToken> LastChild = new Dictionary<string, JToken>();
          

            List<LinklistCell> TrackList = new List<LinklistCell>();
            bool IsLast = false;
            int l = 0;

            private void Node_V1()
            {
                foreach (var d in LastChild.Keys)
                {
                    col = d.Split('.').Count();
                    row = 0;
                    foreach (var dx in LastChild[d].Values())
                    {

                        Node(dx);
                    }
                }

            }
            int lastcolumn = 1;
            private void NextNode_V2(JToken child)
            {
                

                if ((child.First == child.Last) && child.Next is null && child.Last.Count() == 0)
                {
                    int tempcol = 0;
                    int temprow = 0;
                    if (LList.Count > 0)
                    {
                        tempcol = LList.Last.Value.Col;
                        temprow = LList.Last.Value.Row;

                    }
                    LList.AddLast(new LinklistCell() { Row = row, Col = col, Current = child });

                    col = tempcol;
                    row = temprow;

                }
                foreach (var item in child.Children())
                {

                    if (item.HasValues)
                    {
                        switch (item.Type)
                        {
                            case JTokenType.None:
                                break;
                            case JTokenType.Object:

                                //if (LList.Where(it => it.Col == col).Count() == 0)
                                //LList.AddLast(new LinklistCell() { Row = row, Col = col, Current = child.Last });

                                //Console.WriteLine($"Object {row}:{col} {item}");
                                if (item.Parent != null && (item.Parent.Type != JTokenType.Array || item.Parent.Type != JTokenType.Property))
                                {
                                    //LList.AddLast(new LinklistCell() { Row = row, Col = col });

                                    //if (item.Next is null)
                                    //    IsLastObject = true;
                                    MaxCol++;
                                    col = MaxCol;
                                    row = 1;
                                }
                                break;
                            case JTokenType.Array:

                                //if (LList.Where(it => it.Col == col).Count() == 0)
                                //LList.AddLast(new LinklistCell() { Row = row, Col = col, Current = child.Last });
                                //row = 1;
                                //Console.WriteLine($"Properties {row}:{col} {((JProperty)item.Parent).Name} --- {((JProperty)item.Parent).Value}");
                                //AddRow(sheet, 14, row, col, row, col, "Arial", $"{((JProperty)item.Parent).Name}", false, ExcelHorizontalAlignment.Center, ExcelVerticalAlignment.Center, false);

                                //MaxCol++;
                                //col = MaxCol;
                                //col = MaxCol;
                                //if (item.Next is null )
                                //    IsLastArray = true;

                                break;
                            case JTokenType.Constructor:
                                break;
                            case JTokenType.Property:

                                Console.WriteLine($" {row}:{col}{((JProperty)item).Name} --- {((JProperty)item).Name}");
                                //AddRow(sheet, 14, row, col, row, col, "Arial", $"{((JProperty)item).Name}", false, ExcelHorizontalAlignment.Center, ExcelVerticalAlignment.Center, false);
                                row++;
                                //if ((item.First == item.Last) && item.Next is null && IsLastProperty ==false)
                                //{
                                //    cnt = item.Last.LongCount();
                                //    IsLastProperty = true;
                                //}
                                //if(cnt > 0 && IsLastProperty)
                                //{
                                //    cntnext++;
                                //}

                                break;
                            case JTokenType.Comment:
                                break;
                            case JTokenType.Integer:
                                break;
                            case JTokenType.Float:
                                break;
                            case JTokenType.String:
                                break;
                            case JTokenType.Boolean:
                                break;
                            case JTokenType.Null:
                                break;
                            case JTokenType.Undefined:
                                break;
                            case JTokenType.Date:
                                break;
                            case JTokenType.Raw:
                                break;
                            case JTokenType.Bytes:
                                break;
                            case JTokenType.Guid:
                                break;
                            case JTokenType.Uri:
                                break;
                            case JTokenType.TimeSpan:
                                break;
                            default:
                                break;
                        }
                        NextNode_V2(item);

                    }


                }
            }
            private void Node(JToken child)
            {
                foreach (var item in child.Children())
                {

                    if (item.HasValues)
                    {
                        switch (item.Type)
                        {
                            case JTokenType.None:
                                break;
                            case JTokenType.Object:
                                Level = MaxCol;

                                LList.AddLast(new LinklistCell() { Row = row, Col = col, Current = child.Last });

                                Console.WriteLine($"Parent and item Type Respectually {row}:{col}L{Level} {(item.Parent != null ? item.Parent.Type : item.Type)}");
                                if (item.Parent != null && (item.Parent.Type != JTokenType.Array || item.Parent.Type != JTokenType.Property))
                                {
                                    MaxCol++;
                                    col = MaxCol;
                                    row = 1;
                                }
                                break;
                            case JTokenType.Array:
                                Level++;
                                LList.AddLast(new LinklistCell() { Row = row, Col = col, Current = child.Last });
                                

                                break;
                            case JTokenType.Constructor:
                                break;
                            case JTokenType.Property:

                                Console.WriteLine($" {row}:{col}L{Level} {((JProperty)item).Name} --- {((JProperty)item).Name}");
                                //AddRow(sheet, 14, row, col, row, col, "Arial", $"{((JProperty)item).Name}", false, ExcelHorizontalAlignment.Center, ExcelVerticalAlignment.Center, false);
                                row++;
                                

                                break;
                            case JTokenType.Comment:
                                break;
                            case JTokenType.Integer:
                                break;
                            case JTokenType.Float:
                                break;
                            case JTokenType.String:
                                break;
                            case JTokenType.Boolean:
                                break;
                            case JTokenType.Null:
                                break;
                            case JTokenType.Undefined:
                                break;
                            case JTokenType.Date:
                                break;
                            case JTokenType.Raw:
                                break;
                            case JTokenType.Bytes:
                                break;
                            case JTokenType.Guid:
                                break;
                            case JTokenType.Uri:
                                break;
                            case JTokenType.TimeSpan:
                                break;
                            default:
                                break;
                        }
                        Node(item);

                    }
                    //else
                    //{
                    //    if (IsLastProperty)
                    //    {
                    //        if (LList.Count() > 0)
                    //        {

                    //            if (LList.Count() >= 1)
                    //            {
                    //                var currentNode = LastNode();
                    //                row = currentNode.Row;
                    //                col = currentNode.Col;


                    //            }

                                


                    //        }
                           
                    //        IsLastProperty = false;
                    //    }
                    //}
                }
            }
            private void NextNode(JToken child)
            {

                if (( child.Parent !=  null && child.Parent.Last == child))//&& child.Next is null && (child.Last is null || child.Last.Count() == 0)
                {
                    IsLastProperty = true;
                    IsLast = false;
                    if (LList.Count() > 0)
                    {
                        row = LList.Last.Value.Row;
                        col = LList.Last.Value.Col;
                    }
                    /*
                    TrackList.Clear();
                    if (LList.Count() > 0)
                    {
                        var currentNode = LastNode();
                        row = currentNode.Row;
                        col = currentNode.Col;


                        /*
                        row = LList.Last.Value.Row;
                        col = LList.Last.Value.Col;
                        var current = LList.Last.Value.Current;
                        int total = LList.Count;
                        for (int ix = total - 1; ix >= 0; ix--)
                        {
                            var track = LList.ToList()[ix];
                            if (track.Current.Last != null)
                            {
                                if (track.Current.Last.HasValues)
                                {
                                    if (track.Current.Last.First != null)
                                    {
                                        //Console.WriteLine($"Current Path === First :Col {track.Col} { current.Path } =  {track.Current.Last.First.Path}[{track.JType}]");
                                        string prop = current.Path.EndsWith("[0]")== true? current.Path.Substring(0, current.Path.Length-3): current.Path;

                                        if ((track.Current.Last.First.Path == prop) || ((child.Type == JTokenType.Property) && (track.Current.Last.First.Path == $"{prop}.{((Newtonsoft.Json.Linq.JProperty)child).Name}")))
                                        {

                                            IsLast = true;
                                            TrackList.Add(track);
                                            //int nthLevel = prop.Split('.').Length;
                                            //TrackList.Clear();
                                            //TrackList.AddRange(LList.Skip((LList.Count - nthLevel)+2).Take(nthLevel-2));
                                            //var ll = LList.Where(litem => !TrackList.Any(ite => ite.Col == litem.Col)).Last();

                                        }
                                    }
                                }
                            }

                        }
                        if (IsLast == true)
                        {
                            foreach(var itx in TrackList)
                            {
                                LList.Remove(itx);
                            }
                            //var noded = LList.Where(itx => TrackList.Any(ite => ite.Col == itx.Col)).AsEnumerable();//&& _parent.Split(',').Any(pi => itx.Col.ToString() == pi)
                            //if (noded != null && noded.Count() >= 1)
                            //{
                            //    for (int ix = 0; ix <= noded.Count(); ix++)
                            //    {
                            //        var removeit = new LinklistCell() { Row = row, Col = col };
                            //        LList.Remove(removeit);
                            //    }

                            //}
                        }
                        if (LList.Count() >= 1)
                        {
                            var nodex = LList.Where(itx => (itx.Col == MaxCol)).AsEnumerable();//&& _parent.Split(',').Any(pi => itx.Col.ToString() == pi)
                            if (nodex != null && nodex.Count() >= 1)
                            {
                                for (int ix = 0; ix <= nodex.Count(); ix++)
                                {
                                    var removeit = new LinklistCell() { Row = row, Col = col };
                                    LList.Remove(removeit);
                                }

                            }

                            //LList.RemoveLast();
                        }

                        //
                        //foreach (var track in LList)
                        //{
                        //    if (track.Current.Last != null)
                        //    {
                        //        if (track.Current.Last.First != null)
                        //        {
                        //            Console.WriteLine($"Current Path === First :Col {track.Col} { current.Path } =  {track.Current.Last.First.Path}[{track.JType}]");
                        //            if (current.Path.Contains(track.Current.Last.First.Path))
                        //            {
                        //                row = LList.Last.Value.Row;
                        //                col = LList.Last.Value.Col;
                        //            }
                                    
                        //        }
                        //    }
                            
                        //}
                        //
                        */
                       
                 //   }
                       
                    
                }
                
                foreach (var item in child.Children())
                {

                    if (item.HasValues)
                    {
                        switch (item.Type)
                        {
                            case JTokenType.None:
                                break;
                            case JTokenType.Object:
                                Level= MaxCol;
                                MaxCol++;
                                col = MaxCol;
                                row = 1;
                                LList.AddLast(new LinklistCell() { Row = row, Col = col,Current =child.Last });
                                
                                //Console.WriteLine($"Parent and item Type Respectually {row}:{col}L{Level} {(item.Parent != null ? item.Parent.Type : item.Type)}");
                                if (item.Parent != null && (item.Parent.Type != JTokenType.Array || item.Parent.Type != JTokenType.Property))
                                {
                                    //LList.AddLast(new LinklistCell() { Row = row, Col = col });

                                    //if (item.Next is null)
                                    //    IsLastObject = true;
                                    MaxCol++;
                                    col = MaxCol;
                                    row = 1;
                                }
                                break;
                            case JTokenType.Array:
                                Level++;
                                LList.AddLast(new LinklistCell() { Row = row, Col = col, Current = child.Last }) ;
                                //row = 1;
                                //Console.WriteLine($"Properties {row}:{col} {((JProperty)item.Parent).Name} --- {((JProperty)item.Parent).Value}");
                                //AddRow(sheet, 14, row, col, row, col, "Arial", $"{((JProperty)item.Parent).Name}", false, ExcelHorizontalAlignment.Center, ExcelVerticalAlignment.Center, false);

                                //MaxCol++;
                                //col = MaxCol;
                                //col = MaxCol;
                                //if (item.Next is null )
                                //    IsLastArray = true;

                                break;
                            case JTokenType.Constructor:
                                break;
                            case JTokenType.Property:
                                
                                Console.WriteLine($" {row}:{col}L{Level} {((JProperty)item).Name} --- {((JProperty)item).Name}");
                                //AddRow(sheet, 14, row, col, row, col, "Arial", $"{((JProperty)item).Name}", false, ExcelHorizontalAlignment.Center, ExcelVerticalAlignment.Center, false);
                                row++;
                                //if ((item.First == item.Last) && item.Next is null && IsLastProperty ==false)
                                //{
                                //    cnt = item.Last.LongCount();
                                //    IsLastProperty = true;
                                //}
                                //if(cnt > 0 && IsLastProperty)
                                //{
                                //    cntnext++;
                                //}

                                break;
                            case JTokenType.Comment:
                                break;
                            case JTokenType.Integer:
                                break;
                            case JTokenType.Float:
                                break;
                            case JTokenType.String:
                                break;
                            case JTokenType.Boolean:
                                break;
                            case JTokenType.Null:

                                break;
                            case JTokenType.Undefined:
                                break;
                            case JTokenType.Date:
                                break;
                            case JTokenType.Raw:
                                break;
                            case JTokenType.Bytes:
                                break;
                            case JTokenType.Guid:
                                break;
                            case JTokenType.Uri:
                                break;
                            case JTokenType.TimeSpan:
                                break;
                            default:
                                break;
                        }
                        NextNode(item);
                        
                    }
                    else
                    {
                        if (IsLastProperty)
                        {
                            if (LList.Count() > 0)
                            {
                                
                                if (LList.Count() >= 1)
                                {
                                    //var currentNode = LastNode();
                                    //row = currentNode.Row;
                                    //col = currentNode.Col;

                                    row = LList.Last.Value.Row;
                                    col = LList.Last.Value.Col;
                                    //_parent = $"{col}";

                                    //if (LList.Count() >= 1)
                                    //{
                                    //    var nodex = LList.Where(itx => (itx.Col == col || itx.Col == MaxCol ) ).AsEnumerable();//&& _parent.Split(',').Any(pi => itx.Col.ToString() == pi)
                                    //    if (nodex != null && nodex.Count() >= 1)
                                    //    {
                                    //        for (int ix = 0; ix <= nodex.Count(); ix++)
                                    //        {
                                    //            var removeit = new LinklistCell() { Row = row, Col = col };
                                    //            LList.Remove(removeit);
                                    //        }

                                    //    }

                                    //    //LList.RemoveLast();
                                    //}

                                }

                                //row = LList.Last.Value.Row;
                                //col = LList.Last.Value.Col;

                                //Console.WriteLine($"###### Path {_parent} ");
                                //Console.WriteLine($">>>>>!!!!!>>> Max {MaxCol} --- Last {col} --- {LList.Last.Value.IsArray}");
                                //if (_parent.StartsWith(","))
                                //{
                                //    _parent=_parent.Substring(1, _parent.Length-1);
                                //}
                                //string  _col = _parent.Split(',').First();

                                //var index = LList.Where(itx => itx.Col.ToString() == _col).FirstOrDefault();

                                //_parent = $"{col}";
                                //row = index.Row;
                                //col = index.Col;


                            }
                            //if (LList.Count() == 1)
                            //    LList.RemoveLast();
                            IsLastProperty = false;
                        }                        
                        //row = current.Previous.Row;
                        //col = current.Previous.Col;
                        //Console.WriteLine($"Properties {((JProperty)item.Parent).Name} --- {((JProperty)item.Parent).Value}");
                    }
                }

            }
            private LinklistCell LastNode()
            {
                int cnt=0;
                string path = LList.Last.Value.Current.Path;
                foreach( var itx in LList)
                {
                    if(itx.Current.Path.Contains(path))
                    {
                        cnt++;
                    }
                }
                switch (cnt)
                {
                    case 1:
                        //LList.RemoveLast();
                        return LList.Last.Value;                        
                    case 2:
                        //LList.RemoveLast();
                        //LList.RemoveLast();
                        return LList.Last.Value;
                    default:
                        return LList.Last.Value;
                }
                

            }
            private void Delete()
            {
                if (LList.Count() > 0)
                {
                    var nodes = LList.Where(itx => itx.Col == col);
                    int temprow = LList.Last.Value.Row;
                    int tempcol = LList.Last.Value.Col;

                    if (nodes != null && nodes.Count() >= 1)
                    {
                        for (int ix = 0; ix <= nodes.Count(); ix++)
                        {
                            var removeit = new LinklistCell() { Row = temprow, Col = col };
                            LList.Remove(removeit);
                        }
                        temprow = LList.Last.Value.Row;
                        tempcol = LList.Last.Value.Col;
                    }
                    else
                    {
                        var nodex = LList.Where(itx => itx.Col == tempcol).AsEnumerable();
                        if (nodex != null && nodex.Count() >= 1)
                        {
                            for (int ix = 0; ix <= nodex.Count(); ix++)
                            {
                                var removeit = new LinklistCell() { Row = temprow, Col = tempcol };
                                LList.Remove(removeit);
                            }
                            temprow = LList.Last.Value.Row;
                            tempcol = LList.Last.Value.Col;

                        }

                    }
                    col = tempcol;
                    row = temprow;

                }
            }

            private void NextNode1(JToken child)
            {
                if((child.First == child.Last) && child.Next is null && child.Last.Count()==0)
                {
                    IsLastProperty = true;
                }
                foreach (var item in child.Children())
                {
                    
                    if (item.HasValues)
                    {
                        switch (item.Type)
                        {
                            case JTokenType.None:
                                break;
                            case JTokenType.Object:
                                
                                LList.AddLast(new LinklistCell() { Row = row, Col = col });

                                //if (item.Next is null)
                                //    IsLastObject = true;
                                MaxCol++;
                                col = MaxCol;
                                row = 0;
                                break;
                            case JTokenType.Array:
                                LList.AddLast(new LinklistCell() { Row = row, Col = col });
                                row = 0;
                                //Console.WriteLine($"Properties {row}:{col} {((JProperty)item.Parent).Name} --- {((JProperty)item.Parent).Value}");
                                MaxCol++;
                                
                                col = MaxCol;
                                //if (item.Next is null )
                                //    IsLastArray = true;

                                break;
                            case JTokenType.Constructor:
                                break;
                            case JTokenType.Property:
                                row++;
                                Console.WriteLine($"Properties {row}:{col} {((JProperty)item).Name} --- {((JProperty)item).Name}");
                                
                                //if ((item.First == item.Last) && item.Next is null && IsLastProperty ==false)
                                //{
                                //    cnt = item.Last.LongCount();
                                //    IsLastProperty = true;
                                //}
                                //if(cnt > 0 && IsLastProperty)
                                //{
                                //    cntnext++;
                                //}
                             
                                break;
                            case JTokenType.Comment:
                                break;
                            case JTokenType.Integer:
                                break;
                            case JTokenType.Float:
                                break;
                            case JTokenType.String:
                                break;
                            case JTokenType.Boolean:
                                break;
                            case JTokenType.Null:
                                break;
                            case JTokenType.Undefined:
                                break;
                            case JTokenType.Date:
                                break;
                            case JTokenType.Raw:
                                break;
                            case JTokenType.Bytes:
                                break;
                            case JTokenType.Guid:
                                break;
                            case JTokenType.Uri:
                                break;
                            case JTokenType.TimeSpan:
                                break;
                            default:
                                break;
                        }
                        NextNode(item);
                    }
                    else
                    {
                        if(IsLastProperty)
                        {

                            if(LList.Count() > 1 )
                                LList.RemoveLast();
                            if (LList.Count() > 0)
                            {
                                row = LList.Last.Value.Row;
                                col = LList.Last.Value.Col;
                            }
                            if (LList.Count() > 0)
                                LList.RemoveLast();
                            IsLastProperty = false;
                        }
                        
                        //row = current.Previous.Row;
                        //col = current.Previous.Col;
                        //Console.WriteLine($"Properties {((JProperty)item.Parent).Name} --- {((JProperty)item.Parent).Value}");
                    }
                }

            }
        }
    }
    public class NodeCell
    {
        public string Node
        {
            get;set;
        }
        public int Row
        {
            get; set;
        }
        public int Col
        {
            get; set;
        }
        public int Level
        {
            get;set;
        }
        public int MaxCol
        {
            get;set;
        }
    }
    public class LinklistCell
    {
        public override bool Equals(object obj)
        {
            return (this.Col == ((LinklistCell)obj).Col);             
        }
        public int Row
        {
            get;set;
        }
        public int Col
        {
            get; set;
        }
        public JToken Current
        {
            get;set;
        }




    }
    public static class JsonExtensions
    {
        public static bool IsNullOrEmpty(this JToken token)
        {
            return (token == null) ||
                   (token.Type == JTokenType.Array && !token.HasValues) ||
                   (token.Type == JTokenType.Object && !token.HasValues) ||
                   (token.Type == JTokenType.String && token.ToString() == String.Empty) ||
                   (token.Type == JTokenType.Null);
        }
    }

}
