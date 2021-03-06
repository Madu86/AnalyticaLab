﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Analytica_Lab
{


    public enum WebColorEnum {
    
    [Description("255,192,203")]Pink,
    [Description("255,182,193")]Light_Pink,
    [Description("255,105,180")]Hot_Pink,
    [Description("255,20,147")]Deep_Pink,
    [Description("219,112,147")]Pale_Violet_Red,
    [Description("199,21,133")]Medium_Violet_Red,
    [Description("255,160,122")]Light_Salmon	,	
    [Description("250,128,114")]Salmon	,	
    [Description("233,150,122")]Dark_Salmon	,
    [Description("240,128,128")]Light_Coral	,
    [Description("205,92,92")]IndianRed	,
    [Description("220,20,60")]Crimson	,
    [Description("178,34,34")]Fire_Brick	,
    [Description("139,0,0")]Dark_Red	,
    [Description("255,0,0")]Red	,
    [Description("255,69,0")]Orange_Red	,
    [Description("255,99,71")]Tomato	,
    [Description("255,127,80")]Coral	,
    [Description("255,140,0")]Dark_Orange	,
    [Description("255,165,0")]Orange	,
    [Description("255,215,0")]Gold,
    [Description("255,255,0")]Yellow,
    [Description("255,255,224")]Light_Yellow,
    [Description("255,250,205")]Lemon_Chiffon,
    [Description("250,250,210")]Light_Goldenrod_Yellow,	
	[Description("255,239,213")]Papaya_Whip,	
	[Description("255,228,181")]Moccasin,
	[Description("255,218,185")]Peach_Puff,
	[Description("238,232,170")]Pale_Goldenrod,
	[Description("240,230,140")]Khaki	,
	[Description("189,183,107")]Dark_Khaki	,
    [Description("255,248,220")]Cornsilk	,
    [Description("255,235,205")]Blanched_Almond	,
	[Description("255,228,196")]Bisque,
	[Description("255,222,173")]Navajo_White,
	[Description("245,222,179")]Wheat,
	[Description("222,184,135")]Burly_Wood	,
	[Description("210,180,140")]Tan,	
	[Description("188,143,143")]Rosy_Brown,	
    [Description("244,164,96")]Sandy_Brown,
	[Description("218,165,32")]Goldenrod,
	[Description("184,134,11")]Dark_Goldenrod		,
	[Description("205,133,63")]Peru,	
	[Description("210,105,30")]Chocolate,	
	[Description("139,69,19")]Saddle_Brown,
	[Description("160,82,45")]Sienna,
	[Description("165,42,42")]Brown		,
	[Description("128,0,0")]Maroon,	
	[Description("85,107,47")]Dark_Olive_Green,	
	[Description("128,128,0")]Olive,
	[Description("107,142,35")]Olive_Drab,
	[Description("154,205,50")]Yellow_Green,
	[Description("50,205,50")]Lime_Green,	
	[Description("0,255,0")]Lime,	
	[Description("124,252,0")]Lawn_Green,
	[Description("127,255,0")]Chartreuse,
	[Description("173,255,47")]Green_Yellow,
	[Description("0,255,127")]Spring_Green,	
	[Description("0,250,154")]Medium_Spring_Green,	 
    [Description("144,238,144")]Light_Green,
	[Description("152,251,152")]Pale_Green,
	[Description("143,188,143")]Dark_Sea_Green,
	[Description("60,179,113")]Medium_Sea_Green,	
	[Description("46,139,87")]Sea_Green,		  
	[Description("34,139,34")]Forest_Green,
	[Description("0,128,0")]Green,
	[Description("0,100,0")]Dark_Green,
	[Description("102,205,170")]Medium_Aquamarine,	
	[Description("0,255,255")]Aqua,  	
	[Description("224,255,255")]Light_Cyan,
	[Description("175,238,238")]Pale_Turquoise,
	[Description("127,255,212")]Aquamarine,	
	[Description("64,224,208")]Turquoise,  	 
	[Description("72,209,204")]Medium_Turquoise	,
	[Description("0,206,209")]Dark_Turquoise,
	[Description("32,178,170")]Light_Sea_Green,
	[Description("95,158,160")]Cadet_Blue,	
	[Description("0,139,139")]Dark_Cyan, 
	[Description("0,128,128")]Teal	,
	[Description("176,196,222")]Light_Steel_Blue,
	[Description("176,224,230")]Powder_Blue,
	[Description("173,216,230")]Light_Blue,	
	[Description("135,206,235")]SkyBlue,   
	[Description("135,206,250")]Light_Sky_Blue	,
	[Description("0,191,255")]Deep_Sky_Blue,
	[Description("30,144,255")]Dodger_Blue,
	[Description("100,149,237")]Cornflower_Blue,	
	[Description("70,130,180")]Steel_Blue, 	   
	[Description("65,105,225")]Royal_Blue	,
	[Description("0,0,255")]Blue,
	[Description("0,0,205")]Medium_Blue,
	[Description("0,0,139")]Dark_Blue,	
	[Description("0,0,128")]Navy,	  	  
	[Description("25,25,112")]Midnight_Blue	,
	[Description("230,230,250")]Lavender,
	[Description("216,191,216")]Thistle	,
	[Description("221,160,221")]Plum,	
	[Description("238,130,238")]Violet,	 
  	[Description("218,112,214")]Orchid	,
	[Description("255,0,255")]Fuchsia,
	[Description("255,0,255")]Magenta	,
	[Description("186,85,211")]Medium_Orchid,	
	[Description("147,112,219")]Medium_Purple,	 
	[Description("138,43,226")]Blue_Violet	,
	[Description("148,0,211")]Dark_Violet,
	[Description("153,50,204")]Dark_Orchid	,
	[Description("139,0,139")]Dark_Magenta,	
	[Description("128,0,128")]Purple,	
	[Description("75,0,130")]Indigo	,
	[Description("72,61,139")]Dark_Slate_Blue,
	[Description("106,90,205")]Slate_Blue	,
	[Description("123,104,238")]Medium_Slate_Blue	,	
	[Description("255,255,255")]White,		
	[Description("255,250,250")]Snow	,
	[Description("240,255,240")]Honeydew,
	[Description("245,255,250")]Mint_Cream	,
	[Description("240,255,255")]Azure	,	
	[Description("240,248,255")]Alice_Blue,	
	[Description("248,248,255")]Ghost_White	,
	[Description("245,245,245")]White_Smoke,
	[Description("255,245,238")]Seashell	,
	[Description("245,245,220")]Beige	,	
	[Description("253,245,230")]Old_Lace,	
    [Description("255,250,240")]Floral_White	,
	[Description("255,255,240")]Ivory,
	[Description("250,235,215")]Antique_White,
	[Description("250,240,230")]Linen	,	
	[Description("255,240,245")]Lavender_Blush,	
	[Description("255,228,225")]Misty_Rose	,
	[Description("220,220,220")]Gainsboro,
	[Description("211,211,211")]Light_Gray,
	[Description("192,192,192")]Silver		,	
	[Description("169,169,169")]Dark_Gray,	
	[Description("128,128,128")]Gray,
	[Description("105,105,105")]DimGray,
	[Description("119,136,153")]LightSlateGray,
	[Description("112,128,144")]SlateGray,	
	[Description("47,79,79")]DarkSlateGray,
    [Description("0,0,0")]Black,
	



    }
}
