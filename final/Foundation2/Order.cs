public class Order
{
    private Customer customer;
    private Product[] products;

    public Order(Customer customer, Product[] products)
    {
        this.customer = customer;
        this.products = products;
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;

        foreach (Product product in this.products)
        {
            totalPrice += product.GetPrice();
        }

        if (this.customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in this.products)
        {
            packingLabel += $"{product.GetName()} ({product.GetId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"{this.customer.GetName()}\n{this.customer.GetAddress().GetFormattedAddress()}";

        return shippingLabel;
    }
}