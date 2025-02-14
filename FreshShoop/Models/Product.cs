﻿using System;
using System.Collections.Generic;

namespace FreshShoop.Models;

public partial class Product
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Image1 { get; set; }

    public string? Image { get; set; }

    public string? Image3 { get; set; }

    public string Description { get; set; } = null!;

    public int Qunatity { get; set; }

    public double UnitPrice { get; set; }

    public double SalePrice { get; set; }

    public string CategoryId { get; set; } = null!;

    public string Satatus { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
}
