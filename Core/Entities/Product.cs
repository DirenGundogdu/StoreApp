﻿namespace Core.Entities;

public class Product : Base
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal OldPrice { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public Category? Category { get; set; }


}