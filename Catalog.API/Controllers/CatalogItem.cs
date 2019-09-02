namespace Catalog.API.Controllers
{
    public class CatalogItem
    {
        public int ProductId { get; set; }

        public decimal NewPrice { get; set; }

        public decimal OldPrice { get; set; }
    }
}