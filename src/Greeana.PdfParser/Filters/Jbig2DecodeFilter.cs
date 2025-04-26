using Greeana.PdfParser.Objects;

namespace Greeana.PdfParser.Filters;

/// <summary>
/// See 7.4.7
/// </summary>
public class Jbig2DecodeFilter : PdfStreamFilter
{
    public PdfStream? Jbig2Globals { get; set; }

    public Jbig2DecodeFilter(PdfStream jbig2Globals)
    {
        Jbig2Globals = jbig2Globals;
    }

    public Jbig2DecodeFilter()
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