public class Product
{
    private string name;
    private int id;
    private decimal price;
    private int quantity;

    public Product(string name, int id, decimal price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetPrice()
    {
        return this.price * this.quantity;
    }

    public string GetName()
    {
        return this.name;
    }

    public int GetId()
    {
        return this.id;
    }
}