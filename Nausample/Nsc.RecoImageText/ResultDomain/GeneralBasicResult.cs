using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsc.RecoImageText.ResultDomain
{
    public class GeneralBasicResult
    {
        public string direction { get; set; }
        public string log_id { get; set; }
        public int words_result_num { get; set; }
        public List<WordsInfo> words_result { get; set; }
    }

    public class WordsInfo
    {
        public string words { get; set; }
    }
}
