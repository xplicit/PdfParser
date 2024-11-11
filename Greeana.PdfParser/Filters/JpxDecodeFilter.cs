namespace Greeana.PdfParser.Filters;

/// <summary>
/// See 7.4.9
/// </summary>
public class JpxDecodeFilter : PdfStreamFilter
{
    public override Memory<byte> Decode(Memory<byte> data)
    {
        throw new NotImplementedException();
    }

    public override Memory<byte> Encode(Memory<byte> data)
    {
        throw new NotImplementedException();
    }
}