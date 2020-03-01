using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightwebClientNamespace;
using System.IO;
using System.Runtime.CompilerServices;
using XLDeployNamespace;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using Serialization;
using System.Xml.Linq;

namespace PocRestApiAndXlDeploy
{
    class Program
    {
        static void Main(string[] args)
        {
            LightWebClient lwc = new LightWebClient("server", "pasword");

            Boolean testXml = true;
            Boolean testList = false;
            try
            {
                if (testXml)
                {
                    if (testList)
                    {
                        TaskAwaiter<Stream> tat = lwc.GetStreamAsync(@"https://xldeploy.toto.com/deployit/repository/query?type=udm.DeployedApplication&resultsPerPage=-1", "XML").GetAwaiter();
                        Stream st = tat.GetResult();

                        ListOfCi loci = SerializerXml<XLDeployNamespace.ListOfCi>.GetInstance().Deserialize(st);
                        Console.WriteLine(loci.lstCi[0].reference + "    " + loci.lstCi[0].type);
                    }
                    else
                    {
                        TaskAwaiter<Stream> tat = lwc.GetStreamAsync(@"https://xldeploy.toto.com/deployit/repository/ci/Environments/DEV/project/environment/deployments/product_deployment", "XML").GetAwaiter();
                        Stream st = tat.GetResult();
                        XElement elem = XDocument.Load(st).Root;
                        Console.WriteLine(elem.Name.LocalName);
                        st.Seek(0, 0);
                       XLDeployNamespace.Dictionary dict = SerializerXml<XLDeployNamespace.Dictionary>.GetInstance().Deserialize(st);
                        

                    }
                }
                else
                {
                    TaskAwaiter<Stream> tat = lwc.GetStreamAsync(@"https://xldeploy.toto.com/deployit/repository/query?type=udm.DeployedApplication&resultsPerPage=-1", "JSON").GetAwaiter();
                    
                    Stream st = tat.GetResult();
                    //StreamReader reader = new StreamReader(st);
                    //string text = reader.ReadToEnd();
                    //Console.Write(text);
                    //ListOfCi loci = new ListOfCi();
                    List<CiListElement> loci = new List<CiListElement>();
                    //var serializer = new XmlSerializer(typeof(ListOfCi));
                    //Application di = new Application();
                    //var serializer = new DataContractJsonSerializer(typeof(Application));
                    //var serializer = new DataContractJsonSerializer(typeof(ListOfCi));
                    var serializer = new DataContractJsonSerializer(typeof(List<CiListElement>));
                    loci = (List<CiListElement>)serializer.ReadObject(st);
                    //di = (Application)serializer.ReadObject(st);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
             Console.ReadKey();
        }
    }
}
