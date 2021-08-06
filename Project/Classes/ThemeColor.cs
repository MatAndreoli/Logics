using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace APP.Classes
{
    class ThemeColor
    {
        #region Variables and Instances
        public static Color PrimaryColor { get; set; }
        Random rand = new Random();
        private int colorIndex;
        public static List<string> ColorList = new List<string>()
        {
            "#7bed9f",
            "#2ed573",
            "#1abc9c",
            "#16a085",
            "#eccc68",
            "#ffa502",
            "#ff7f50",
            "#ff6348",
            "#d35400",
            "#ff6b81",
            "#ff4757",
            "#e74c3c",
            "#8e44ad",
            "#70a1ff",
            "#1e90ff",
            "#5352ed",
            "#3742fa"
        };
        #endregion

        #region Methods
        public Color SelectColor()
        {
            int index = rand.Next(ColorList.Count);
            while (index == colorIndex)
            {
                index = rand.Next(ColorList.Count);
            }
            colorIndex = index;
            string color = ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        #endregion
    }
}
