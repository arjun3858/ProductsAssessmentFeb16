﻿// See https://aka.ms/new-console-template for more information
using AssessmentFeb16;
// Display details
SortedList<int, Products> products = new SortedList<int, Products>();

// Add sample products
products.Add(1, new Products("Shampoo", 100, "Brand1", new DateTime(2023, 2, 16), new DateTime(2024, 2, 16)));


// Display details
Console.WriteLine("Index Key | PName    | Price | Brand | MfDate    | ExpDate");
foreach (var product in products)
{
    Console.WriteLine($"{product.Key,-10} | {product.Value.PName,-8} | {product.Value.PPrice,-5} | {product.Value.PBrand,-5} | {product.Value.ManufacturingDate.ToString("yyyy-MM-dd"),-10} | {product.Value.ExpiryDate.ToString("yyyy-MM-dd"),-10}");
}