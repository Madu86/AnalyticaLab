using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;


namespace Analytica_Lab
{
    class FileOperator
    {
        public List<List<string>> ReadTextFile(string fileName)
        {
            int counter = 0;
            string line;

            List<List<string>> lstTreeViewData = new List<List<string>>();

            List<string> lstSampleNames = new List<string>();
            List<string> lstTreeNodePaths = new List<string>();
            List<string> lstSampleIndices = new List<string>();


            StreamReader file = new StreamReader(fileName);

            string s = file.ReadToEnd();

            var splitted_S = s.Split(new string[] { "*****", "*****" }, StringSplitOptions.None);

            for (int i = 1; i < splitted_S.Length - 1; i++) 
            {

                var arrString_0 = splitted_S[i].Split(new string[] { "~", "~" }, StringSplitOptions.None);

                lstSampleNames.Add(arrString_0[1]);

                var arrString_1 = arrString_0[2].Split(new string[] { "<Tree_Node_Path_" + (i-1).ToString() + ">", "</Tree_Node_Path_" + (i-1).ToString() + ">" }, StringSplitOptions.None);

                lstTreeNodePaths.Add(arrString_1[1]);

                var arrString_2 = arrString_1[2].Split(new string[] { "<Sample Index>", "</Sample Index>" }, StringSplitOptions.None);
                
                lstSampleIndices.Add(arrString_2[1]);

                var arrString_3 = arrString_2[2].Split(new string[] { "<Components_In_Sample>", "</Components_In_Sample>" }, StringSplitOptions.None);

                int numberOfComponents = Convert.ToInt32(arrString_3[1]);

                List<string> lstTempCompoundName = new List<string>();
                List<string> lstTempColor = new List<string>();
                List<string> lstTempStates = new List<string>();

                for (int j = 0; j < numberOfComponents; j++) 
                {

                    var arrString_4 = arrString_3[0].Split(new string[] { "<Compound_" + j.ToString() + ">", "</Compound_" + j.ToString() + ">" }, StringSplitOptions.None);

                    lstTempCompoundName.Add(arrString_4[1]);

                    var arrString_5 = arrString_4[2].Split(new string[] { "<Color_" + j.ToString() + ">", "</Color_" + j.ToString() + ">" }, StringSplitOptions.None);

                    lstTempColor.Add(arrString_5[1]);

                    var arrString_6 = arrString_5[2].Split(new string[] { "<States_" + j.ToString() + ">", "</States_" + j.ToString() + ">" }, StringSplitOptions.None);

                    lstTempStates.Add(arrString_6[1]);
                }

                Sample.lst_Samples.Add(lstTempCompoundName);
                Sample.lst_Colors.Add(lstTempColor);
                Sample.lst_State.Add(lstTempStates);
            }

            lstTreeViewData.Add(lstSampleNames);
            lstTreeViewData.Add(lstTreeNodePaths);
            lstTreeViewData.Add(lstSampleIndices);

            return lstTreeViewData;
        
        }

        public void WriteTextFile(string path, List<string> nodeNames, List<List<string>> samples, List<List<string>> colors, List<List<string>> states, List<string> treeNodePaths, List<string> sampleIndices)
        {
          
            TextWriter tw = new StreamWriter(path);
            tw.WriteLine("Analytica Lab version 1.0.0.0 - University of Colombo (2013) - All rights reserved.");
            tw.WriteLine("");

            int i = 0;
            foreach (string nodeName in nodeNames)
            {
                tw.WriteLine("*****");
                tw.WriteLine("~"+nodeName+"~");

                var treeNodePath = treeNodePaths.ElementAt(i);
                var sampleIndex = sampleIndices.ElementAt(i);
                var lstSample = samples.ElementAt(i);
                var lstColors = colors.ElementAt(i);
                var lstStates = states.ElementAt(i);

                tw.WriteLine("<" + "Tree_Node_Path_" + i.ToString() + ">" + treeNodePath + "</Tree_Node_Path_" + i.ToString() + ">");
                tw.WriteLine("<Sample Index>" + sampleIndex + "</Sample Index>");

                int k = 0;
                for (int j = 0; j < lstSample.Count; j++)
                {
                    
                    tw.WriteLine("<" + "Compound_" + j.ToString() + ">" + lstSample.ElementAt(j)+"</Compound_"+j.ToString()+">");
                    tw.WriteLine("<" + "Color_" + j.ToString() + ">" + lstColors.ElementAt(j) + "</Color_" + j.ToString() + ">");
                    tw.WriteLine("<" + "States_" + j.ToString() + ">" + lstStates.ElementAt(j) + "</States_" + j.ToString() + ">");
                    k += 1;
                }

                tw.WriteLine("<Components_In_Sample>" + k.ToString() + "</Components_In_Sample>");
                tw.WriteLine("~/" + nodeName + "~");
                tw.WriteLine("");

                i += 1;
            }

            tw.WriteLine("*****");

            //tw.WriteLine("<Number_of_Samples>" + i + "</Number_of_Samples>"); 

            tw.Close();
        }

        //modifies and saves changes for a given file.. 
        public void ModifyXML(string documetPath, string nodeName, string value)
        {

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(documetPath);
            }
            catch
            {
                throw new Exception("System cannot find the " + documetPath + " file...!");
            }

            XmlNode root = doc.DocumentElement;


            try
            {
                root.SelectSingleNode("/" + nodeName).InnerText = value;
            }
            catch
            {
                throw new Exception("Given node name" + nodeName + " does not exist in the specified file.");
            }


            try
            {
                doc.Save(documetPath);
            }
            catch
            {
                throw new Exception("System cannot find the " + documetPath + " file...!");
            }

        }


        //returns a string value for a given node name in a specified file...
        public string GetXMLValue(string documetPath, string nodeName)
        {

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(documetPath);
            }
            catch
            {
                throw new Exception("System cannot find the " + documetPath + " file...!");
            }
            XmlNode root = doc.DocumentElement;


            try
            {
                return root.SelectSingleNode("/" + nodeName).InnerText;
            }
            catch
            {
                throw new Exception("Given node name" + nodeName + " does not exist in the specified file.");
            }

        }



    }
}
