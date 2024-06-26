namespace BinaryFunction;

public static class BinaryCount
{
    public static int BinaryCountForNumber(int number)
    {
        var binaryNumber = Convert.ToString(number, toBase:2);
        return binaryNumber.Count(e => e == '1');
    }
}