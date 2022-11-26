using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewStore.API.OrderAggregate;

namespace NewStore.API.DTOs
{
    public class CreateOrderDto
    {
        public bool SaveAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
    }
}