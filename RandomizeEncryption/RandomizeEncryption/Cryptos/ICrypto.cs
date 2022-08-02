namespace RandomizeEncryption.Cryptos
{
    public interface ICrypto
    {
        string? Encrypt(string plainText, string privateKey);
        string? Decrypt(string cipherText, string privateKey);
    }
}
