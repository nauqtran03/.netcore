﻿using System;
using System.Collections.Generic;

namespace buoi17_netcore.Models.DBModel;

public partial class OrdersDetail
{
    public int Id { get; set; }

    public int? OrdersId { get; set; }

    public int? ProductId { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public double? TotalPrice { get; set; }

    public virtual Order? Orders { get; set; }

    public virtual Product? Product { get; set; }
}
