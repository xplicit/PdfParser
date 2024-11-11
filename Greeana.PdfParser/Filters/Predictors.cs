namespace Greeana.PdfParser.Filters;

public enum Predictors : int
{
    NoPrediction = 1,
    TiffPredictor2 = 2,
    PngPredictionNone = 10,
    PngPredictionSub = 11,
    PngPredictionUp = 12,
    PngPredictionAverage = 13,
    PngPredictionPaeth = 14,
    PngPredictionOptimum = 15
}