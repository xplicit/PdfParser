namespace Greeana.PdfParser.Objects;

/// <summary>
/// Stream object. See 7.3.8
/// </summary>
public class PdfStream
{
    //Tokens
    public const string StartToken = "stream";
    public const string EndToken = "emdstream";
    
    // Keys: Table 5 – Entries common to all stream dictionaries
    public const string LengthKey = "Length";
    public const string FilterKey = "Filter";
    public const string DecodeParamsKey = "DecodeParms";
    public const string FileKey = "F";
    public const string FileFilterKey = "FFilter";
    public const string FileDecodeParamsKey = "FDecodeParms";
    public const string DecodedLengthKey = "DL";
    
    // Keys: Table 16 – Additional entries specific to an object stream dictionary
    // See 7.5.7
    public const string TypeKey = "Type";
    public const string NumberOfIndirectObjectsKey = "N";
    public const string FirstByteOffsetKey = "First";
    public const string ExtendsKey = "Extends";

    
    // Properties: Table 5 – Entries common to all stream dictionaries
    
    /// <summary>
    /// (Required) The number of bytes from the beginning of the line
    /// following the keyword stream to the last byte just before the
    /// keyword endstream. (There may be an additional EOL
    /// marker, preceding endstream, that is not included in the count
    /// and is not logically part of the stream data.) See 7.3.8.2,
    /// "Stream Extent", for further discussion
    /// </summary>
    public int Length { get; set; }
    
    /// <summary>
    /// (Optional) The name of a filter that shall be applied in
    /// processing the stream data found between the keywords
    /// stream and endstream, or an array of zero, one or several
    /// names. Multiple filters shall be specified in the order in which
    /// they are to be applied
    /// </summary>
    /// <returns>name or array type</returns>
    public object? Filter { get; set; }
    
    /// <summary>
    /// Optional) A parameter dictionary or an array of such
    /// dictionaries, used by the filters specified by Filter. If there is
    /// only one filter and that filter has parameters, DecodeParms
    /// shall be set to the filter’s parameter dictionary unless all the
    /// filter’s parameters have their default values, in which case the
    /// DecodeParms entry may be omitted. If there are multiple
    /// filters and any of the filters has parameters set to nondefault
    /// values, DecodeParms shall be an array with one entry for
    /// each filter: either the parameter dictionary for that filter, or the
    /// null object if that filter has no parameters (or if all of its
    /// parameters have their default values). If none of the filters
    /// have parameters, or if all their parameters have default values,
    /// the DecodeParms entry may be omitted.
    /// </summary>
    /// <returns>dictionary or array type</returns>
    public object? DecodeParams { get; set; }
    
    /// <summary>
    /// (Optional; PDF 1.2) The file containing the stream data. If this
    /// entry is present, the bytes between stream and endstream
    /// shall be ignored. However, the Length entry should still specify
    /// the number of those bytes (usually, there are no bytes and
    /// Length is 0). The filters that are applied to the file data shall be
    /// specified by FFilter and the filter parameters shall be specified
    /// by FDecodeParms
    /// </summary>
    /// <returns>file specification</returns>
    public object? File { get; set; }
    
    /// <summary>
    /// (Optional; PDF 1.2) The name of a filter to be applied in
    /// processing the data found in the stream’s external file, or an
    /// array of zero, one or several such names. The same rules
    /// apply as for Filter.
    /// </summary>
    /// <returns>name or array type</returns>
    public object? FileFilter { get; set; }
    
    /// <summary>
    /// (Optional; PDF 1.2) A parameter dictionary, or an array of such
    /// dictionaries, used by the filters specified by FFilter. The same
    /// rules apply as for DecodeParms.
    /// </summary>
    /// <returns>dictionary or array type</returns>
    public object? FileDecodeParams { get; set; }
    
    /// <summary>
    /// (Optional; PDF 1.5) A non-negative integer representing the
    /// number of bytes in the decoded (defiltered) stream. It can be
    /// used to determine, for example, whether enough disk space is
    /// available to write a stream to a file.
    /// This value shall be considered a hint only; for some stream
    /// filters, it may not be possible to determine this value precisely.
    /// </summary>
    public int? DecodedLength { get; set; }
    
    // Properties: Table 16 – Additional entries specific to an object stream dictionary
    // See 7.5.7
    
    /// <summary>
    /// (Required) The type of PDF object that this dictionary describes; shall be
    /// ObjStm for an object stream.
    /// </summary>
    public NameObject Type { get; set; }
    
    /// <summary>
    /// (Required) The number of indirect objects stored in the stream
    /// </summary>
    public int NumberOfIndirectObjects { get; set; }
    
    /// <summary>
    /// (Required) The byte offset in the decoded stream of the first compressed object
    /// </summary>
    public int FirstByteOffset { get; set; }
    
    /// <summary>
    /// Optional) A reference to another object stream, of which the current object
    /// stream shall be considered an extension. Both streams are considered part
    /// of a collection of object streams (see below). A given collection consists of a
    /// set of streams whose Extends links form a directed acyclic graph
    /// </summary>
    public PdfStream Extends { get; set; }
}