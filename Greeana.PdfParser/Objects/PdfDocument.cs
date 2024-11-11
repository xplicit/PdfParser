namespace Greeana.PdfParser.Objects;

/// <summary>
/// See 7.5
/// </summary>
public class PdfDocument
{
    public object Header { get; set; }
    public object Body { get; set; }
    public CrossReferenceTable Objects { get; set; }
    public object Trailer { get; set; }
}