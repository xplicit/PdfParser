using System.Text;
using Greeana.PdfParser.Filters;

namespace Greeana.PdfParser;

/// <summary>
/// 
/// </summary>
public class PdfStreamFilterFactory
{
    public const string AsciiHexDecode = "ASCIIHexDecode";
    public const string Ascii85Decode = "ASCII85Decode";
    public const string LzwDecode = "LZWDecode";
    public const string FlateDecode = "FlateDecode";
    public const string RunLengthDecode = "RunLengthDecode";
    public const string CcittFaxDecode = "CCITTFaxDecode";
    public const string Jbig2Decode = "JBIG2Decode";
    public const string DctDecode = "DctDecode";
    public const string JpxDecode = "JpxDecode";
    public const string Crypt = "Crypt";

    public static PdfStreamFilter CreateFilter(string name)
    {
        PdfStreamFilter filter = name switch
        {
            AsciiHexDecode => new AsciiHexDecodeFilter(),
            Ascii85Decode => new Ascii85DecodeFilter(),
            LzwDecode => new LzwDecodeFilter(),
            FlateDecode => new FlateDecodeFilter(),
            RunLengthDecode => new RunLengthDecodeFilter(),
            CcittFaxDecode => new CcittFaxDecodeFilter(),
            Jbig2Decode => new Jbig2DecodeFilter(),
            DctDecode => new DctDecodeFilter(),
            JpxDecode => new JpxDecodeFilter(),
            Crypt => new CryptFilter(),
            _ => throw new NotImplementedException()
        };

        return filter;
    }
}
