namespace Overkill.Domains.Examiner;

public class Product(int id, int size, int pressureTolerance, int colorTransparency)
{
    public int Id { get; set; } = id;
    public int Size { get; set; } = size;
    public int PressureTolerance { get; set; } = pressureTolerance;
    public int ColorTransparency { get; set; } = colorTransparency;
}