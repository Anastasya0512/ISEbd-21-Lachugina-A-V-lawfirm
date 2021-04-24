using System;
using System.Collections.Generic;
using System.Text;

namespace LawFirmBusinessLogic.ViewModels
{
    public class ReportComponentDocumentViewModel
    {
        public string DocumentName { get; set; }

        public int TotalCount { get; set; }

        public List<Tuple<string, int>> Components { get; set; } 
    }
}
