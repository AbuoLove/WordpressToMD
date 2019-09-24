using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordpressToMD.Services;

namespace WordpressToMD.ViewModels
{
    public class MainViewModel
    {
        private readonly IConvertWpToMdService _convertWpToMdService;

        public MainViewModel(IConvertWpToMdService convertWpToMdService)
        {
            _convertWpToMdService = convertWpToMdService;
        }

        public string WpText { get; set; }
        public string MdText { get; set; }

        public void ConvertText()
        {
            _convertWpToMdService.Convert(WpText);
        }
    }
}
