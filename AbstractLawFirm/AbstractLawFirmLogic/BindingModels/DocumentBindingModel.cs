using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLawFirmLogic.BindingModels
{
    public class DocumentBindingModel
    {
        public int? Id { get; set; }
        public string DocumentName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> DocumentComponents { get; set; }
    }
}
