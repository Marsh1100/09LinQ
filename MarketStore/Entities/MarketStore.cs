
namespace marketStore.Entities;
public class MarketStore{
    private List<Product> products = new List<Product>();
    private List<Category> categories = new List<Category>();

    public List<Category> Categories
    { 
        get { return this.categories; }
        set { this.categories = value; }
    }

    public List<Product> Products
    {
        get { return this.products; }
        set { this.products = value; }
    }

    public MarketStore(){}

}