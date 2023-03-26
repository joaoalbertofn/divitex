using System;
using System.Drawing;
using ChartJs.Blazor.Common;
using ChartJs.Blazor.Common.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
//using MudBlazor;
//using MudBlazor.Charts;
using MyFirstBlazor.Pages;
using static MudBlazor.Colors;
using System.Reflection;
using System.Security.Cryptography;
using System.Drawing;

namespace MyFirstBlazor.Helpres
{
    public class ChartHelper
    {
        public ChartHelper() { }

        //public Color GetRandomColor(string text)
        //{
        //    int seed = text.GetHashCode();
        //    Random random = new Random(seed);
        //    return System.Drawing.Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        //}

        public string[] GetColors()
        {
            var colors = new[] {
                "#FF6384", "#36A2EB", "#FFCE56", "#4BC0C0", "#9966FF", "#00CC99", "#FF9900", "#CCCCFF", "#66FF66", "#FF6666",
                "#999966", "#FFCC99", "#D94F70", "#56A9F9", "#DBB93D", "#49A88F", "#E86E2F", "#BDDBEA", "#8EDF9D", "#F05A72",
                "#A5A34D", "#F1A1AD", "#60C3E8", "#F9D54E", "#A5CCD1", "#B1D1E1", "#B2F2B0", "#F98BAF", "#B2B072", "#D8BB90",
                "#D5C7E5", "#D5E5C7", "#9FD7F9", "#F9CC9F", "#D1B2B7", "#C7D5E5", "#C7E5D5", "#A2EB36", "#CEFFA6", "#FFC738",
                "#FFB8D1", "#A9D1E4", "#B4D4A4", "#D3A3A3", "#A3D3C3", "#D3C1A3", "#C4A3D3", "#E3D3A3", "#A3D3D3", "#D3A3D3"};

            return colors;
        }

    }
}

