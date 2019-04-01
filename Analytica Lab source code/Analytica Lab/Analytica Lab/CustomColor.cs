using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Analytica_Lab
{
    class CustomColor
    {
        // Gets the RGB color value attached to each field in WebColor enum as a string.. 
        private string GetDescriptionByValue(WebColorEnum value)
        {

            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            FieldInfo field = type.GetField(name);

            DescriptionAttribute att = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return att.Description;

        }

        //Retruns the name of the color for a given color code...
        private WebColorEnum GetValueByDescription(string description) {

            WebColorEnum wbc = WebColorEnum.Alice_Blue;
            Type enumType = typeof(WebColorEnum);

            foreach (var field in enumType.GetFields())
            {

                DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {

                    if (attribute.Description == description)
                    {

                        wbc = (WebColorEnum)field.GetValue(null);
                        break;
                    }
                    else {

                        if (field.Name == description) {
                            wbc = (WebColorEnum)field.GetValue(null);
                            break;
                        }
                    }
                
                }
            
            }

            return wbc;
        }

        //Gets the mixed color of two or more colors... 
        public Color DetermineMixedColor(List<Color> lstColor)
        {

            Color c = Color.White;

            double red = 0.0; double blue = 0.0; double green = 0.0;
            double alpha = 0.0;


            foreach (Color col in lstColor)
            {

                alpha += col.A;
                red += col.R;
                blue += col.B;
                green += col.G;

            }

            alpha = alpha / lstColor.Count;
            red = red / lstColor.Count;
            blue = blue / lstColor.Count;
            green = green / lstColor.Count;

            c = Color.FromArgb((int)alpha, (int)(red), (int)(green), (int)(blue));
            return c;


        }

        //Returns the name of closest color name for a given custom color...
        public string GetNearestColorName(Color customColor)
        {
      
            double minimumDeviation = 100000;
            int closestIndex = 0;
            List<string> lstColorCodesFromEnum = new List<string>();
            List<string> lstColorNameFromEnum = new List<string>();

            foreach (WebColorEnum s in Enum.GetValues(typeof(WebColorEnum)))
            {

                lstColorCodesFromEnum.Add(GetDescriptionByValue(s));
                lstColorNameFromEnum.Add(Convert.ToString(s));
            }

            int a = 0;

            foreach (string s in lstColorCodesFromEnum)
            {

                var colorArray = s.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                int R_FromEnum = Convert.ToInt32(colorArray[0]);
                int G_FromEnum = Convert.ToInt32(colorArray[1]);
                int B_FromEnum = Convert.ToInt32(colorArray[2]);

                double deviation = Math.Pow((R_FromEnum - customColor.R) * 0.3, 2) + Math.Pow((G_FromEnum - customColor.G) * 0.59, 2) + Math.Pow((B_FromEnum - customColor.B) * 0.11, 2);

                if (minimumDeviation > deviation)
                {

                    minimumDeviation = deviation;
                    closestIndex = a;
                }
                a += 1;
            }

        
            return lstColorNameFromEnum[closestIndex];
        }

    }
}
