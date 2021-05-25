﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using LawFirmBusinessLogic.Enums;
using LawFirmBusinessLogic.Attributes;
using System.Runtime.Serialization;

namespace LawFirmBusinessLogic.ViewModels
{
    [DataContract]
    public class OrderViewModel
    {
        [Column(title: "Номер", width: 100, visible: false)]
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public int DocumentId { get; set; }

        [DataMember]
        public int? ImplementerId { get; set; }

        [DataMember]
        [Column(title: "Клиент", width: 150)]
        public string ClientFIO { get; set; }

        [DataMember]
        [Column(title: "Исполнитель", width: 150)]
        public string ImplementerFIO { get; set; }


        [DataMember]
        [Column(title: "Документ", gridViewAutoSize: GridViewAutoSize.AllCells)]
        public string DocumentName { get; set; }

        [DataMember]
        [Column(title: "Количество", width: 100)]
        public int Count { get; set; }

        [DataMember]
        [Column(title: "Сумма", width: 50)]
        public decimal Sum { get; set; }

        [DataMember]
        [Column(title: "Статус", width: 100)]
        public OrderStatus Status { get; set; }

        [DataMember]
        [Column(title: "Дата создания", width: 100, dateFormat: "d")]
        public DateTime DateCreate { get; set; }


        [DataMember]
        [Column(title: "Дата выполнения", width: 100, dateFormat: "d")]
        public DateTime? DateImplement { get; set; }
    }
}
