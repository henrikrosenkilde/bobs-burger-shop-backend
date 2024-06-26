﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace bobs_burger_api.Models.Orders
{
    public class OrderPost
    {
        public string UserId { get; set; }
        public List<int> ProductIds { get; set; }
        public double Total { get; set; }
    }
}
