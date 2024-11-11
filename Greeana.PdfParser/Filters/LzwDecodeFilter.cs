namespace Greeana.PdfParser.Filters;

/// <summary>
/// See 7.4.4
/// </summary>
public class LzwDecodeFilter : PdfStreamFilter
{
    public int Predictor { get; set; }
    public int Colors { get; set; }
    public int BitsPerComponent { get; set; }
    public int Columns { get; set; }
    public int EarlyChange { get; set; }
    
    public LzwDecodeFilter(int predictor, int colors, int bitsPerComponent, int columns, int earlyChange)
    {
        Predictor = predictor;
        Colors = colors;
        BitsPerComponent = bitsPerComponent;
        Columns = columns;
        EarlyChange = earlyChange;
    }

    public LzwDecodeFilter()
    {
    }

    public override Memory<byte> Decode(Memory<byte> data)
    {
        throw new NotImplementedException();
    }

    public override Memory<byte> Encode(Memory<byte> data)
    {
        throw new NotImplementedException();
    }
}