using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
    }

    public class NewManager
    {
        public static List<Product> GetProduct()
        {
            var product = new List<Product>();
            product.Add(new Product { Id = 1, Name = "Samsung S9",Category = "Samsung", Price = "999", Image = "Assets/s9.png" });
            product.Add(new Product { Id = 2, Name = "Samsung S10", Category = "Samsung", Price = "999", Image = "Assets/s10.png" });
            product.Add(new Product { Id = 3, Name = "Samsung S20", Category = "Samsung", Price = "999", Image = "Assets/s20.png" });
            product.Add(new Product { Id = 4, Name = "Iphone 10", Category = "Iphone", Price = "999", Image = "Assets/i10.png" });
            product.Add(new Product { Id = 5, Name = "Iphone 11", Category = "Iphone", Price = "999", Image = "Assets/i11.png" });
            product.Add(new Product { Id = 6, Name = "Iphone 12", Category = "Iphone", Price = "999", Image = "Assets/i12.png" });product.Add(new Product { Id = 1, Name = "Samsung S9",Category = "Samsung", Price = "999", Image = "Assets/s9.png" });
            product.Add(new Product { Id = 7, Name = "Samsung S10", Category = "Samsung", Price = "999", Image = "Assets/s10.png" });
            product.Add(new Product { Id = 8, Name = "Samsung S20", Category = "Samsung", Price = "999", Image = "Assets/s20.png" });
            product.Add(new Product { Id = 9, Name = "Iphone 10", Category = "Iphone", Price = "999", Image = "Assets/i10.png" });
            product.Add(new Product { Id = 10, Name = "Iphone 11", Category = "Iphone", Price = "999", Image = "Assets/i11.png" });
            product.Add(new Product { Id = 11, Name = "Iphone 12", Category = "Iphone", Price = "999", Image = "Assets/i12.png" });
            return product;
        }
        public static void GetNews(string category, ObservableCollection<Product> newProduct)
        {
            var allItems = GetProduct();

            var filterItems = allItems
                .Where(p => p.Category == category)
                .ToList();
            newProduct.Clear();
            filterItems.ForEach(p => newProduct.Add(p));
        }
        public static void GetAll(ObservableCollection<Product> products)
        {
            var allItem = GetProduct();
            
            allItem.ForEach(p => products.Add(p));
        }
    }
}
