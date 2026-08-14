using System.Security.Cryptography;

public class DotNetChaCha20Poly1305Test
{
    // TODO: make sure that is valid C# code
    public void TestChaChaCreate()
    {
        byte[] key = new byte [32];;
        var chaCha = new ChaCha20Poly1305(key); // Noncompliant
    }

    public void TestChaChaEncrypt()
    {
        byte[] key = new byte [32];
        var chaCha = new ChaCha20Poly1305(key); // Noncompliant

        byte[] nonce = new byte[12];
        byte[] plainText = new byte[32];
        byte[] cipherText = new byte[32];
        byte[] tag = new byte[16];
        byte[] associatedData = new byte[32];

        chaCha.Encrypt(nonce, plainText, cipherText, tag, associatedData);
    }

    public void TestChaChaDecrypt()
    {
       byte[] key = new byte [32];
       var chaCha = new ChaCha20Poly1305(key); // Noncompliant

       byte[] nonce = new byte[12];
       byte[] plainText = new byte[32];
       byte[] cipherText = new byte[32];
       byte[] tag = new byte[16];
       byte[] associatedData = new byte[32];

        chaCha.Decrypt(nonce, plainText, cipherText, tag, associatedData);
    }
}
