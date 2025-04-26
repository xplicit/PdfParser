namespace Greeana.PdfParser.Filters;

public class FlateDecodeFilter : PdfStreamFilter
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