namespace Greeana.PdfParser.Objects;

/// <summary>
/// Name Objects. See 7.3.5
/// </summary>
public class NameObject
{
    /// <summary>
    /// Reference to original sequence of bytes in PDF document
    /// </summary>
    public Memory<byte> Ref { get; set; }
    
    //TODO: Add comparison extension between two names
}