using System;
using System.Collections.Generic;
using System.Text;
using LawFirmBusinessLogic.Attributes;
using System.ComponentModel;

namespace LawFirmBusinessLogic.ViewModels
{
    public class ComponentViewModel
    {
        [Column(title: "Номер", width: 100, visible: false)]
        public int Id { get; set; }
        [Column(title: "Название компонента", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }
    }
}
