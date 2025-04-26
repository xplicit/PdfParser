namespace Greeana.PdfParser.Filters;

/// <summary>
/// See 7.4.3
/// </summary>
public class Ascii85DecodeFilter : PdfStreamFilter
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