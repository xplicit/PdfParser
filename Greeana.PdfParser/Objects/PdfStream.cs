namespace Greeana.PdfParser.Objects;

/// <summary>
/// Stream object. See 7.3.8
/// </summary>
public class PdfStream
{
    //Tokens
    public const string StartToken = "stream";
    public const string EndToken = "emdstream";
    
    //Keys
    public const string LengthKey = "Length";
    public const string FilterKey = "Filter";
    public const string DecodeParamsKey = "DecodeParms";
    public const string FileKey = "F";
    public const string FileFilterKey = "FFilter";
    public const string FileDecodeParamsKey = "FDecodeParms";
    public const string DecodedLengthKey = "DL";

    //
}