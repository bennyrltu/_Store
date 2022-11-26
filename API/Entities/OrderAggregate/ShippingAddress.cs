using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewStore.API.Entities;

namespace NewStore.API.OrderAggregate
{
    [Owned]
    public class ShippingAddress : Address
    {

    }
}