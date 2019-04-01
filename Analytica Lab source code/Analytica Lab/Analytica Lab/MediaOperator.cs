using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Analytica_Lab
{
    class MediaOperator
    {
        frmMain mainForm;
        public MediaOperator(frmMain mainForm) {

            this.mainForm = mainForm;
        }



        //Loads an image from file, replace the color of solution or ppt and returns..
        private Bitmap GetNewImageFromFile(string fileName,Color color_1) {

            Bitmap bmp = new Bitmap(fileName);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color gotColor = bmp.GetPixel(x, y);
                    gotColor = Color.FromArgb(gotColor.R, gotColor.G, gotColor.B);
                    if (gotColor.R == 255 && gotColor.G == 0 && gotColor.B == 0)
                    {

                        bmp.SetPixel(x, y, color_1);

                    }

                }

            }
            return bmp;
        }

        //Loads an image from file, replece both the colors of solution and ppt and returns.. 
        private Bitmap GetNewImageFromFile(string fileName, Color color_Solution, Color color_Ppt) {

            Bitmap bmp = new Bitmap(fileName);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color gotColor = bmp.GetPixel(x, y);
                    gotColor = Color.FromArgb(gotColor.R, gotColor.G, gotColor.B);
                    if (gotColor.R == 255 && gotColor.G == 0 && gotColor.B == 0)
                    {

                        bmp.SetPixel(x, y, color_Solution);

                    }
                    else if (gotColor.R == 0 && gotColor.G == 0 && gotColor.B == 255)
                    {
                        bmp.SetPixel(x, y, color_Ppt);
                    
                    }

                }

            }

            return bmp;
        }

        //Returns an image which can be added to image list and then visualize on the picture box...
        public Bitmap GetImage(List<string> lstSample, List<string> lstStates, List<string> lstColors)
        {

            Bitmap bmp = new Bitmap("soln_1.png");
            Sample smpl = new Sample(mainForm);
            var arrObj = smpl.SeperateSample(lstStates, lstSample, lstColors);

           

            if (arrObj[0].Count == 0)
            {

                string color = mainForm.DetermineColor(arrObj[5]);
                if (color != "###,###,###")
                {

                    List<string> lstS = color.Split(',').ToList();
                    Color c = Color.FromArgb(Convert.ToInt32(lstS[0]), Convert.ToInt32(lstS[1]), Convert.ToInt32(lstS[2]));

                    bmp = GetNewImageFromFile("ppt.png", c);
                }

            }
            else if (arrObj[1].Count == 0)
            {

                string color = mainForm.DetermineColor(arrObj[4]);
                if (color != "###,###,###")
                {

                    List<string> lstS = color.Split(',').ToList();
                    Color c = Color.FromArgb(Convert.ToInt32(lstS[0]), Convert.ToInt32(lstS[1]), Convert.ToInt32(lstS[2]));

                    bmp = GetNewImageFromFile("soln_1.png", c);
                }
                else
                {

                    bmp = GetNewImageFromFile("soln_1.png", Color.FromArgb(120,255,255,255));
                }

            }
            else if (arrObj[0].Count != 0 && arrObj[1].Count != 0)
            {

                string color_Soln = mainForm.DetermineColor(arrObj[4]);
                string color_Ppt = mainForm.DetermineColor(arrObj[5]);

                Color c_Soln;
                Color c_Ppt;

                if (color_Soln != "###,###,###")
                {

                    List<string> lstS = color_Soln.Split(',').ToList();
                    c_Soln = Color.FromArgb(Convert.ToInt32(lstS[0]), Convert.ToInt32(lstS[1]), Convert.ToInt32(lstS[2]));

                }
                else
                {

                    c_Soln = Color.FromArgb(128,0,0,0);
                }

                if (color_Ppt != "###,###,###")
                {
                    List<string> lstS = color_Ppt.Split(',').ToList();
                    c_Ppt = Color.FromArgb(Convert.ToInt32(lstS[0]), Convert.ToInt32(lstS[1]), Convert.ToInt32(lstS[2]));
                }
                else
                {

                    c_Ppt = Color.White;
                }

                bmp = GetNewImageFromFile("soln_ppt.png", c_Soln, c_Ppt);
            }

            return bmp;
        }


        
    }
}
