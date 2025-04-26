namespace Greeana.PdfParser.Objects;

public class Constants
{
    public const byte CR = 0x0D;
    public const byte LF = 0x0A;
    public readonly byte[] CRLF = [0x0D, 0x0A];
    public const byte Null = 0x00;

    // Delimiter characters. See 7.2.2
    public const byte LeftParenthesis = 0x28;       // (
    public const byte RightParenthesis = 0x29;      // )
    public const byte LessThanSign = 0x3C;          // <
    public const byte GreaterThanSign = 0x3E;       // >
    public const byte LeftSquareBracket = 0x5B;     // [
    public const byte RightSquareBracket = 0x5D;    // ]
    public const byte LeftCurlyBracket = 0x7B;      // {
    public const byte RightCurlyBracket = 0x7D;     // }
    public const byte Solidus = 0x2F;               // /
    public const byte PercentSign = 0x2C;           // %
    
    // Booleans. See 7.3.2
    public const string True = "true";
    public const string False = "false";
    
    // Literal Strings. See 7.3.4.2
    public const byte ReverseSolidus = 0x5C;        // \

    // Named Objects
    public const byte NumberSign = 0x23;            // #
    public const byte ExclamationMark = 0x21;       // !
    public const byte Tilde = 0x7E;                 // ~
    
    /// <summary>
    /// Please see 4.42 for list of space characters
    /// </summary>
    public readonly char[] SpaceCharacters = [ (char)0x09, (char)0x0A, (char)0x0B, (char)0x0C, (char)0x0D,
    (char)0x20, (char)0xA0, (char)0x2002, (char)0x2003, (char)0x2007, (char)0x2008, (char)0x2009,
    (char)0x200A, (char)0x200B, (char)0x3000,];

    /// <summary>
    /// Please see 4.46 for list of white space characters
    /// </summary>
    public readonly char[] WhiteSpaceCharacters = [(char)0x09, (char)0x0A, (char)0x0C, (char)0x0D, (char)0x20];
}