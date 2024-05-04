namespace Lab5Example;

public class InvalidMontExeption : Exception
{
    public InvalidMontExeption(int wrongMonth)
    : base($"Wrong month: {wrongMonth}")
    {
        
    }
}