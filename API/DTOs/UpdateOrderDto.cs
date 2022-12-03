using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewStore.API.OrderAggregate;

namespace _Store.API.DTOs
{
    public class UpdateOrderDto
    {     

           public int Id { get; set; }
           public OrderStatus OrderStatus { get; set; }

    }
}