using App2.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.ViewModel
{
    public class SalesViewModel
    {
        public List<SaleInfo> SalesData { get; set; }

        public SalesViewModel()
        {
            SalesData = new List<SaleInfo>();

            SalesData.Add(new SaleInfo { State = "Abia", Total_Employment = 1919458, Employment = 1501773, Unemployed = 417685 });
            SalesData.Add(new SaleInfo { State = "Adamawa", Total_Employment = 1445800, Employment = 1369885, Unemployed = 75915 });
            SalesData.Add(new SaleInfo { State = "AkwaIbom", Total_Employment = 3217171, Employment = 2313438, Unemployed = 903733 });
            SalesData.Add(new SaleInfo { State = "Anambra", Total_Employment = 3009646, Employment = 2692768, Unemployed = 316878 });
            SalesData.Add(new SaleInfo { State = "Bauchi", Total_Employment = 1825977, Employment = 1698480, Unemployed = 127497 });
            SalesData.Add(new SaleInfo { State = "Bayelsa", Total_Employment = 1225375, Employment = 936616, Unemployed = 285759 });
            SalesData.Add(new SaleInfo { State = "Benue", Total_Employment = 2368743, Employment = 2173505, Unemployed = 195238 });
            SalesData.Add(new SaleInfo { State = "Borno", Total_Employment = 2204832, Employment = 1806905, Unemployed = 397927 });
            SalesData.Add(new SaleInfo { State = "CrossRiver", Total_Employment = 1747085, Employment = 1475364, Unemployed = 271721 });
            SalesData.Add(new SaleInfo { State = "Delta", Total_Employment = 2852244, Employment = 2458575, Unemployed = 393669 });
            SalesData.Add(new SaleInfo { State = "Ebonyi", Total_Employment = 1397158, Employment = 1198822, Unemployed = 198336 });
            SalesData.Add(new SaleInfo { State = "Edo", Total_Employment = 1923837, Employment = 1628541, Unemployed = 295296 });
            SalesData.Add(new SaleInfo { State = "Ekiti", Total_Employment = 1676724, Employment = 1489582, Unemployed = 187142 });
            SalesData.Add(new SaleInfo { State = "Enugu", Total_Employment = 2296296, Employment = 1939884, Unemployed = 356412 });
            SalesData.Add(new SaleInfo { State = "Gombe", Total_Employment = 816956, Employment = 748176, Unemployed = 68780 });
            SalesData.Add(new SaleInfo { State = "Imo", Total_Employment = 2840619, Employment = 2197591, Unemployed = 643028 });
            SalesData.Add(new SaleInfo { State = "Jigawa", Total_Employment = 1369716, Employment = 1165371, Unemployed = 204345 });
            SalesData.Add(new SaleInfo { State = "Kaduna", Total_Employment = 3163022, Employment = 2459425, Unemployed = 703597 });
            SalesData.Add(new SaleInfo { State = "Kano", Total_Employment = 3604743, Employment = 3059223, Unemployed = 545520 });
            SalesData.Add(new SaleInfo { State = "Katsina", Total_Employment = 1667140, Employment = 1626102, Unemployed = 41038 });
            SalesData.Add(new SaleInfo { State = "Kebbi", Total_Employment = 1434057, Employment = 1345825, Unemployed = 88232 });
            SalesData.Add(new SaleInfo { State = "Kogi", Total_Employment = 2252143, Employment = 1881404, Unemployed = 370739 });
            SalesData.Add(new SaleInfo { State = "Kwara", Total_Employment = 1467465, Employment = 1318075, Unemployed = 149390 });
            SalesData.Add(new SaleInfo { State = "Lagos", Total_Employment = 6909301, Employment = 5966614, Unemployed = 942687 });
            SalesData.Add(new SaleInfo { State = "Nasarawa", Total_Employment = 1236654, Employment = 961783, Unemployed = 274871 });
            SalesData.Add(new SaleInfo { State = "Niger", Total_Employment = 1756668, Employment = 1614196, Unemployed = 142472 });
            SalesData.Add(new SaleInfo { State = "Ogun", Total_Employment = 2922932, Employment = 2705912, Unemployed = 217020 });
            SalesData.Add(new SaleInfo { State = "Ondo", Total_Employment = 2320211, Employment = 2044617, Unemployed = 275594 });
            SalesData.Add(new SaleInfo { State = "Osun", Total_Employment = 2296230, Employment = 2202128, Unemployed = 94102 });
            SalesData.Add(new SaleInfo { State = "Oyo", Total_Employment = 3792840, Employment = 3526160, Unemployed = 266680 });
            SalesData.Add(new SaleInfo { State = "Plateau", Total_Employment = 1885617, Employment = 1516845, Unemployed = 368772 });
            SalesData.Add(new SaleInfo { State = "Rivers", Total_Employment = 4175796, Employment = 2834614, Unemployed = 1341182 });
            SalesData.Add(new SaleInfo { State = "Sokoto", Total_Employment = 1520392, Employment = 1303673, Unemployed = 216719 });
            SalesData.Add(new SaleInfo { State = "Taraba", Total_Employment = 2101774, Employment = 1985749, Unemployed = 116025 });
            SalesData.Add(new SaleInfo { State = "Yobe", Total_Employment = 1006850, Employment = 841470, Unemployed = 165380 });
            SalesData.Add(new SaleInfo { State = "Zamfara", Total_Employment = 1361270, Employment = 1282007, Unemployed = 79263 });
            SalesData.Add(new SaleInfo { State = "FCT", Total_Employment = 1579381, Employment = 1391801, Unemployed = 187580 });
        }
    }
}
