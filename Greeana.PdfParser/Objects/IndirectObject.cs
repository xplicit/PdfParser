namespace Greeana.PdfParser.Objects;

/// <summary>
/// Indirect Object. See 7.3.10 
/// </summary>
public class IndirectObject
{
    public const string StartToken = "obj";
    public const string EndToken = "endobj";
    public const string IndirectReferenceToken = "R";
    
    public int Number { get; set; }
    public int GenerationNumber { get; set; }
    //TODO: Should have embedded object be Generic or be parent for all objects. 
}
