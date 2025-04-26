namespace Greeana.PdfParser.Filters;

public abstract class PdfStreamFilter
{
    public abstract Memory<byte> Decode(Memory<byte> data);
    public abstract Memory<byte> Encode(Memory<byte> data);
}