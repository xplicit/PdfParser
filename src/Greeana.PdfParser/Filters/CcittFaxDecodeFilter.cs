namespace Greeana.PdfParser.Filters;

/// <summary>
/// See 7.4.6
/// </summary>
public class CcittFaxDecodeFilter : PdfStreamFilter
{
    public int K { get; set; }
    public bool EndOfLine { get; set; }
    public bool EncodedByteAlign { get; set; }
    public int Colors { get; set; }
    public int Rows { get; set; }
    public int EndOfBlock { get; set; }
    public bool BlackLs1 { get; set; }
    public int DamagedRowsBeforeError { get; set; }

    public CcittFaxDecodeFilter(int k, bool endOfLine, bool encodedByteAlign, int colors, int rows,
        int endOfBlock, bool blackLs1, int damagedRowsBeforeError)
    {
        K = k;
        EndOfLine = endOfLine;
        EncodedByteAlign = encodedByteAlign;
        Colors = colors;
        Rows = rows;
        EndOfBlock = endOfBlock;
        BlackLs1 = blackLs1;
        DamagedRowsBeforeError = damagedRowsBeforeError;
    }

    public CcittFaxDecodeFilter()
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