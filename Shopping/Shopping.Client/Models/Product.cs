namespace Shopping.Client.Models
{
	public class Product
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
		public string ImageFile { get; set; }
		public decimal Price { get; set; }

		public Product ToProduct(int index)
		{
			Product product = new Product();
			product.Id = index.ToString();
			product.Name = string.Concat("Product", index.ToString());
			product.Category = string.Concat("Category", index.ToString());
			product.Description = string.Concat("Description", index.ToString());
			product.ImageFile = string.Concat("ImageFile", index.ToString());
			product.Price = 100;
			return product;

		}
	}
}
