namespace Greeana.PdfParser.Filters;

/// <summary>
/// See 7.4.8
/// </summary>
public class DctDecodeFilter : PdfStreamFilter
{
    public int ColorTransform { get; set; }

    public DctDecodeFilter(int colorTransform)
    {
        ColorTransform = colorTransform;
    }

    public DctDecodeFilter()
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