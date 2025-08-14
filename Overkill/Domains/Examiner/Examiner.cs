using Overkill.Domains.Examiner.Exception;

namespace Overkill.Domains.Examiner;

public class Examiner
{
    public List<string> CheckProductList(List<Product> products)
    {
        return products.Select(product =>
        {
            try
            {
                CheckProduct(product);
            }
            catch (System.Exception exception)
            {
                return $"{product.Id}-{exception.GetType().Name}";
            }
            return null;
        }).Where(x => x != null).ToList()!;
    }

    private static void CheckProduct(Product product)
    {
        if (product.Size != 70)
            throw new SizeException("Product size must be exactly 70.");
        if (product.PressureTolerance < 1000)
            throw new PressureToleranceException("Product pressure tolerance must be greater or equal than 1000.");
        if (product.ColorTransparency is not (>= 235 and <= 245))
            throw new ColorTransparencyException("Product color transparency must be between 235 and 245.");
    }
}