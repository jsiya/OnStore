using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace OnStore;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ImageLink { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public bool IsCheck { get; set; }
    public Product()
    {
       
    }
    public Product(Guid id, string name, string description, float price, string imageLink)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        ImageLink = imageLink;
        IsCheck = false;
    }
    public Product(Product product)
    {
        Id = product.Id; 
        Name = product.Name; 
        Description = product.Description; 
        Price = product.Price; 
        ImageLink = product.ImageLink;
        IsCheck = product.IsCheck;
    }
}
