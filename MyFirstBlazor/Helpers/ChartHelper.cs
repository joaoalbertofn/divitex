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

        public Color GetRandomColor(string text)
        {
            int seed = text.GetHashCode();
            Random random = new Random(seed);
            return System.Drawing.Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

    }
}

