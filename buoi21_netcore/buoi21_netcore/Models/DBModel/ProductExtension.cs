﻿using System;
using System.Collections.Generic;

namespace buoi21_netcore.Models.DBModel;

public partial class ProductExtension
{
    public int Id { get; set; }

    public int? Pid { get; set; }

    public int? Eid { get; set; }

    public string? Content { get; set; }
}
