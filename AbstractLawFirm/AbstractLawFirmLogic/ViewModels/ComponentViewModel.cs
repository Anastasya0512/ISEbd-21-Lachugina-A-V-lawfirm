﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace AbstractLawFirmLogic.ViewModels
{
    public class ComponentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название компонента")]
        public string ComponentName { get; set; }
    }
}
