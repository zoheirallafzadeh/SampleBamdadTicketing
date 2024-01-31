﻿using App.Domain.Core.Tickets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Tickets.DTOs
{
    public class TicketDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<int> MessegesId { get; set; }
        public int? UnitId { get; set; }
        public int? UnitPartId { get; set; }
        public StateEnum State { get; set; }
        public int CustomerUserId { get; set; }
    }
}