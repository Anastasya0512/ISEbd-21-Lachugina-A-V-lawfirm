using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace LawFirmBusinessLogic.ViewModels
{
    public class DocumentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название документа")]
        public string DocumentName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> DocumentComponents { get; set; }
    }
}
