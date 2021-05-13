﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LawFirmBusinessLogic.Enums;
using System;

namespace LawFirmDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int DocumentId { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public decimal Sum { get; set; }

        [Required]
        public OrderStatus Status { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }

        public DateTime? DateImplement { get; set; }

        public virtual Document Document { get; set; }

        public virtual Client Client { get; set; }
    }
}
