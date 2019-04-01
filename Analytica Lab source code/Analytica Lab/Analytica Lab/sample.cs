using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;



namespace Analytica_Lab
{
    class Sample
    {
        #region ~Class level variable declarations~

        //Create a major list that can hold a series of string lists.. 
        public static List<List<string>> lst_Samples = new List<List<string>>();
        public static List<List<string>> lst_Colors = new List<List<string>>();
        public static List<List<string>> lst_State = new List<List<string>>();

        public static List<Bitmap> lst_Images = new List<Bitmap>();

        private frmMain mainForm;
        #endregion

        public Sample(frmMain mainForm) {

            this.mainForm = mainForm;
        
        }


        ////Creates nodes in sampleTreeView...~
        public void CreateNewSample(string sampleName)
        {


            //Check whether the entered name is already existing in the treeview..

            for (int i = 0; i < mainForm.treeViewSample.Nodes.Count; i++)
            {

                var nodeName = mainForm.treeViewSample.Nodes[i].Text;
                if (nodeName == sampleName)
                {

                    throw new Exception("You can't use the same name for different samples...!");

                }

            }

            //if not existing, create a new node..

            CustomTreeNode subSampleTreeNode = new CustomTreeNode();
            subSampleTreeNode.Text = sampleName;
            subSampleTreeNode.ForeColor = Color.Black;
            subSampleTreeNode.BackColor = Color.White;

            if (mainForm.treeViewSample.SelectedNode == null)
            {
                subSampleTreeNode.SampleIndex = Sample.lst_Samples.Count;
                mainForm.treeViewSample.Nodes.Add(subSampleTreeNode);
                mainForm.treeViewSample.ExpandAll();

                //Make a copy of each list within multiple list holders..

                var sampleAtIndex = Sample.lst_Samples.ElementAt(Sample.lst_Samples.Count - 1);
                Sample.lst_Samples.Insert(subSampleTreeNode.SampleIndex, sampleAtIndex);

                var colorAtIndex = Sample.lst_Colors.ElementAt(Sample.lst_Colors.Count - 1);
                Sample.lst_Colors.Insert(subSampleTreeNode.SampleIndex, colorAtIndex);

                var stateAtIndex = Sample.lst_State.ElementAt(Sample.lst_State.Count - 1);
                Sample.lst_State.Insert(subSampleTreeNode.SampleIndex, stateAtIndex);

                var imageAtIndex = Sample.lst_Images.ElementAt(Sample.lst_Images.Count - 1);
                Sample.lst_Images.Insert(subSampleTreeNode.SampleIndex, imageAtIndex);

            }
            else
            {

                var selectedSampleIndex = ((CustomTreeNode)mainForm.treeViewSample.SelectedNode).SampleIndex;

                //IncreaseSampleIndexOnNodeAddition(selectedSampleIndex);

                //Add the node after selected node in the tree view...
                subSampleTreeNode.SampleIndex = lst_Samples.Count; //Sample index is the index of sample at lst_Sample list..
                mainForm.treeViewSample.SelectedNode.Nodes.Add(subSampleTreeNode);
                mainForm.treeViewSample.ExpandAll();

                //Insert a copy of the selected list in to multiple array list holder... 
                var sampleAtIndex = Sample.lst_Samples.ElementAt(selectedSampleIndex);
                Sample.lst_Samples.Add(sampleAtIndex);

                var colorAtIndex = Sample.lst_Colors.ElementAt(selectedSampleIndex);
                Sample.lst_Colors.Add(colorAtIndex);

                var stateAtIndex = Sample.lst_State.ElementAt(selectedSampleIndex);
                Sample.lst_State.Add(stateAtIndex);

                var imageAtIndex = Sample.lst_Images.ElementAt(selectedSampleIndex);
                Sample.lst_Images.Add(imageAtIndex);




            }

            mainForm.UpdateStatus("A portion from " + mainForm.treeViewSample.SelectedNode.Text + " was taken and labelled as " + sampleName+"...");

        }

        //Increase the sample index of nodes below the selected node by one...
        public void IncreaseSampleIndexOnNodeAddition(int selectedSampleIndex)
        {


            for (int i = (selectedSampleIndex + 1); i < Sample.lst_State.Count; i++)
            {
                foreach (TreeNode tn in mainForm.GetAllNodes(mainForm.treeViewSample))
                {
                    int sampleIndex = ((CustomTreeNode)tn).SampleIndex;

                    if (i == sampleIndex)
                    {
                        ((CustomTreeNode)tn).SampleIndex += 1;
                        break;
                    }

                }

            }

        }

        //Reduces the sample index of nodes below the selected node by one...
        public void DecreaseSampleIndexOnNodeDisposal(int selectedSampleIndex)
        {

            for (int i = (selectedSampleIndex + 1); i < Sample.lst_State.Count; i++)
            {
                foreach (TreeNode tn in mainForm.GetAllNodes(mainForm.treeViewSample))
                {
                    int sampleIndex = ((CustomTreeNode)tn).SampleIndex;

                    if (i == sampleIndex)
                    {
                        ((CustomTreeNode)tn).SampleIndex -= 1;
                        break;
                    }

                }

            }

        }

        //Returns an array of string lists.. [0]-List of names of species in solution.. [1]-List of names of species in ppt..[3]-State of species in soln..[4]-State of species in ppt..[5]-Color of species in soln..[6]-Color of species in ppt..
        public List<string>[] SeperateSample(List<string> sampleToSeperate_States, List<string> sampleToSeperate_Sample, List<string> sampleToSeperate_Colors) {

            List<string> tempLstSolution = new List<string>();
            List<string> tempLstPpt = new List<string>();

            List<string> lstSolutionStates = new List<string>();
            List<string> lstPptStates = new List<string>();

            List<string> lstSolutionColors = new List<string>();
            List<string> lstPptColors = new List<string>();


            int i = 0;
            foreach (string s in sampleToSeperate_States)
            {

                if (Convert.ToBoolean(s.Trim() == "solution"))
                {

                    tempLstSolution.Add(sampleToSeperate_Sample[i]);
                    lstSolutionColors.Add(sampleToSeperate_Colors.ElementAt(i));
                    lstSolutionStates.Add(sampleToSeperate_States.ElementAt(i));

                }
                else
                {

                    tempLstPpt.Add(sampleToSeperate_Sample[i]);
                    lstPptColors.Add(sampleToSeperate_Colors.ElementAt(i));
                    lstPptStates.Add(sampleToSeperate_States.ElementAt(i));


                }

                i += 1;
            }

            List<string>[] arrayOfStringLists = new List<string>[] { tempLstSolution, tempLstPpt, lstSolutionStates, lstPptStates, lstSolutionColors, lstPptColors };
           
            return arrayOfStringLists;
        }

        //Seperates solution from the precipitate...
        public void CentrifugeAndSeperateSample(TreeNode treeNode)
        {
            var selectedSampleIndex = ((CustomTreeNode)treeNode).SampleIndex;

            var sampleToSeperate_States = Sample.lst_State.ElementAt(selectedSampleIndex);
            var sampleToSeperate_Sample = Sample.lst_Samples.ElementAt(selectedSampleIndex);
            var sampleToSeperate_Colors = Sample.lst_Colors.ElementAt(selectedSampleIndex);

            var arrayObj = SeperateSample(sampleToSeperate_States, sampleToSeperate_Sample, sampleToSeperate_Colors);


            List<string> tempLstSolution = arrayObj[0];
            List<string> tempLstPpt = arrayObj[1];

            List<string> lstSolutionStates = arrayObj[2];
            List<string> lstPptStates = arrayObj[3];

            List<string> lstSolutionColors = arrayObj[4];
            List<string> lstPptColors = arrayObj[5];

            MediaOperator mop = new MediaOperator(mainForm);

            Bitmap bmp_Soln = mop.GetImage(tempLstSolution, lstSolutionStates, lstSolutionColors);

            Bitmap bmp_Ppt = mop.GetImage(tempLstPpt, lstPptStates, lstPptColors);



            if (tempLstPpt.Count == 0)
            {

                throw new Exception("You have nothing to seperate in this sample...!");


            }
            else
            {

                string nameOfSampleToBeSeperated = treeNode.Text;

                //Increase the sample indices of tree nodes after the selected node...
                //IncreaseSampleIndexOnNodeAddition(selectedSampleIndex);

                //Ammend the text of selected node for the supernatant.. 
                mainForm.treeViewSample.SelectedNode.Text += "_" + selectedSampleIndex.ToString()+"_1";

                //Create a new node for ppt..

                CustomTreeNode subSampleTreeNode = new CustomTreeNode();
                subSampleTreeNode.Text = "Precipitate_"+selectedSampleIndex.ToString()+"_1";
                subSampleTreeNode.ForeColor = Color.Black;
                subSampleTreeNode.BackColor = Color.White;

                //Add the node after selected node in the tree view...
                subSampleTreeNode.SampleIndex = lst_Samples.Count;
                mainForm.treeViewSample.SelectedNode.Nodes.Add(subSampleTreeNode);
                mainForm.treeViewSample.ExpandAll();

                //Replace selected solution with supernatant...
                lst_Samples[selectedSampleIndex] = tempLstSolution;
                lst_Images[selectedSampleIndex] = bmp_Soln;

 

                //Insert precipitate into the sample list after the supernatant...

                lst_Samples.Add(tempLstPpt);
                lst_Images.Add(bmp_Ppt);

                //Ammend color & state lists in similar manner... 

                lst_Colors[selectedSampleIndex] = lstSolutionColors;

                lst_Colors.Add(lstPptColors);

                lst_State[selectedSampleIndex] = lstSolutionStates;

                lst_State.Add(lstPptStates);

                mainForm.UpdateStatus("Sample labelled as " + nameOfSampleToBeSeperated + " was centrifuged and seperated. The supernatant was labelled as " +
                mainForm.treeViewSample.SelectedNode.Text + " & the precipitate as " + subSampleTreeNode.Text + "...");

            }




        }

    }
}
