namespace Greeana.PdfParser.Filters;

/// <summary>
/// See 7.4.2
/// </summary>
public class AsciiHexDecodeFilter : PdfStreamFilter
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