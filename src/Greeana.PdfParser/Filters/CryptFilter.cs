using Greeana.PdfParser.Objects;

namespace Greeana.PdfParser.Filters;

/// <summary>
/// See 7.4.10
/// </summary>
public class CryptFilter : PdfStreamFilter
{
    public NameObject Type { get; set; }
    public NameObject Name { get; set; }

    public CryptFilter(NameObject type, NameObject name)
    {
        Type = type;
        Name = name;
    }

    public CryptFilter()
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