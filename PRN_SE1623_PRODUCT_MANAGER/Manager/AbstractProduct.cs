namespace Prn.Se1623;

public abstract class AbstractProduct
{
    private Product[]? _product;

    protected AbstractProduct()
    {
        this._product = new Product[Utils.InitLength];
    }
}