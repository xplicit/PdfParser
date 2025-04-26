namespace Greeana.PdfParser.Objects;

/// <summary>
/// See 7.5.5 File Trailer
/// </summary>
/// <remarks>
/// The trailer of a PDF file enables a conforming reader to quickly find the cross-reference table and certain
/// special objects. Conforming readers should read a PDF file from its end
/// </remarks>
public class FileTrailer
{
    public PdfDictionary Dictionary { get; set; }
    
    /// <summary>
    /// The total number of entries in
    /// the file’s cross-reference table, as defined by the combination of the original
    /// section and all update sections. Equivalently, this value shall be 1 greater
    /// than the highest object number defined in the file.
    /// Any object in a cross-reference section whose number is greater than this
    /// value shall be ignored and defined to be missing by a conforming reader.
    /// </summary>
    public int Size { get; set; }
    
    /// <summary>
    /// The byte offset in the decoded stream from the
    /// beginning of the file to the beginning of the previous cross-reference section.
    /// </summary>
    public int Prev { get; set; }
    
    /// <summary>
    /// The catalog dictionary for the PDF document contained in the file (see 7.7.2, "Document Catalog")
    /// </summary>
    public PdfDictionary Root { get; set; }
    
    /// <summary>
    /// The document’s encryption dictionary (see 7.6, "Encryption")
    /// </summary>
    public PdfDictionary Encrypt { get; set; }
    
    /// <summary>
    /// The document’s information dictionary (see 14.3.3, "Document Information Dictionary")
    /// </summary>
    public PdfDictionary Info { get; set; }
    
    /// <summary>
    /// An array of two byte-strings constituting a file identifier (see 14.4, "File
    /// Identifiers") for the file. If there is an Encrypt entry this array and the two
    /// byte-strings shall be direct objects and shall be unencrypted
    /// </summary>
    public PdfArray Id { get; set; }
    
    /// <summary>
    /// The byte offset in the decoded stream from the beginning of the file of a cross-reference stream.
    /// See 7.5.8.4
    /// </summary>
    public int XRefStm { get; set; }
}