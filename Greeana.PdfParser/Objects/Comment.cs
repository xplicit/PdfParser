namespace Greeana.PdfParser.Objects;

/// <summary>
/// Represent comment in PDF file
/// </summary>
/// <remarks>See 7.2.3</remarks>
public class Comment
{
    public const byte StartCommentToken = Constants.PercentSign;
    
    //TODO: Should we use Memory<byte> here?
    public string Text { get; set; }
}
