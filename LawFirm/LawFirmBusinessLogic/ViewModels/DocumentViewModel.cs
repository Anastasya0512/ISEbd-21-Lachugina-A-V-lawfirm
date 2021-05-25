using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using LawFirmBusinessLogic.Attributes;

namespace LawFirmBusinessLogic.ViewModels
{
    [DataContract]
    public class DocumentViewModel
    {
        [DataMember]
        [Column(title: "Номер", width: 100, visible: false)]
        public int Id { get; set; }

        [DataMember]
        [Column(title: "Название документа", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string DocumentName { get; set; }

        [DataMember]
        [Column(title: "Цена", width: 100)]
        public decimal Price { get; set; }

        [DataMember]
        public Dictionary<int, (string, int)> DocumentComponents { get; set; }
    }
}
