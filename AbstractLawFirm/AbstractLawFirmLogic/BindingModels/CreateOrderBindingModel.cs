﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLawFirmLogic.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int DocumentId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
