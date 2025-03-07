using System;
using System.Collections.Generic;

namespace buoi21_netcore.Models.DBModel;

public partial class ProductImage
{
    public int Id { get; set; }

    public int? Pid { get; set; }

    public string? Image { get; set; }
}
