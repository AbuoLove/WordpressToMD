using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordpressToMD.Services
{
    public interface IConvertWpToMdService
    {
        string Convert(string input);
    }
}
