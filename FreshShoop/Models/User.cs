﻿using System;
using System.Collections.Generic;

namespace FreshShoop.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phno { get; set; } = null!;

    public string Address { get; set; } = null!;
}
