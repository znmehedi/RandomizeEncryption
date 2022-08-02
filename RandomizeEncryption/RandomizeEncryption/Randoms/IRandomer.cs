namespace RandomizeEncryption.Randoms
{
    public interface IRandomer
    {
        string? GetUniqueKey(string pattern, int size);
    }
}