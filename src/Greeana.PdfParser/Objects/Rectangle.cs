namespace Greeana.PdfParser.Objects;

// ?? should be real type for coordinates?
public class Rectangle
{
    public int LowerLeftX { get; set; }
    public int LowerLeftY { get; set; }
    public int UpperRightX { get; set; }
    public int UpperRightY { get; set; }
}