namespace Greeana.PdfParser.Objects;

/// <summary>
/// Heaader of PDF file. See 7.5.2 
/// </summary>
public class Header
{
    public Memory<byte> Ref { get; set; }

    public Tuple<int, int> Version { get; set; }
}
