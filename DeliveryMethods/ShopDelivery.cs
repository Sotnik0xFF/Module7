﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Module7.OrderAggregate;

namespace Module7.DeliveryMethods
{
    public class ShopDelivery : DeliveryMethod
    {
        public override string Details => "Доставка в розничный магазин";
    }
}
