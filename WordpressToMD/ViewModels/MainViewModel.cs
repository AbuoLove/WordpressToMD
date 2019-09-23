using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordpressToMD.ViewModels
{
    public class MainViewModel
    {
        public string WpText { get; set; }
        public string MdText { get; set; }

        public void ConvertText()
        {
            MdText = $"Converted {WpText}";
        }
    }
}
