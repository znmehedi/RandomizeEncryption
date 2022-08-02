using RandomizeEncryption.Cryptos;


Crypto crypto = new Crypto();
var res1 = crypto.Encrypt("Mehedi", "12");
Console.WriteLine(res1);

var res2 = crypto.Decrypt(res1, "12");
Console.WriteLine(res2);
