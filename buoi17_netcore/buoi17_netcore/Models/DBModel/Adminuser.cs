﻿using System;
using System.Collections.Generic;

namespace buoi17_netcore.Models.DBModel;

public partial class Adminuser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Emial { get; set; }
}
