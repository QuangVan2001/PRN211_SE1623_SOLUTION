namespace Prn.Se1623;
public class ProductManagement : AbstractProduct, IProduct
{
    public ProductManagement()
    {

    }
    public void Display()
    {
        for (int i = 0; i < this.Size; i++)
        {
            Console.WriteLine(Products[i]);
        }
    }

    public void Add(Product p)
    {
        this.Products[Size++] = p;
    }
}