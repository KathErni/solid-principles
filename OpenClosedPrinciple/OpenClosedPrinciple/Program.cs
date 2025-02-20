using System;

public class Encryption
{
    public string Type { get; set; }
}

public interface IEncryption
{
    string Encrypt(Encryption encryption);
}
public class AES : IEncryption
{
    public string Encrypt(Encryption encryption)
    {
        return "AES Encrypted data";
    }
}
public class RSA : IEncryption
{
    public string Encrypt(Encryption encryption)
    {
        return "RSA Encrypted data";
    }
}

public class encryptType
{
    private readonly IEncryption _encryption;

    public encryptType(Encryption encryption)
    {
        _encryption = GetEncryptionStrategy(encryption.Type);
    }

    private IEncryption GetEncryptionStrategy(string type)
    {
        return type switch
        {
            "AES" => new AES(),
            "RSA" => new RSA(),
            // Add more cases for new encryption types here
            _ => throw new NotSupportedException($"Encryption type '{type}' is not supported.")
        };
    }

    public string Encrypt(Encryption encryption)
    {
        return _encryption.Encrypt(encryption);
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var aesrun = new Encryption { Type = "DES" };
                var typeEncrypt = new encryptType(aesrun);
                Console.WriteLine($"Type for {aesrun.Type}: {typeEncrypt.Encrypt(aesrun)}");

                var rsarun = new Encryption { Type = "RSA" };
                var typeEncrypt2 = new encryptType(rsarun);
                Console.WriteLine($"Type for {rsarun.Type}: {typeEncrypt2.Encrypt(rsarun)}");

                // Example of unsupported type
                var invalidRun = new Encryption { Type = "INVALID_TYPE" };
                var typeEncrypt3 = new encryptType(invalidRun);
                Console.WriteLine($"Type for {invalidRun.Type}: {typeEncrypt3.Encrypt(invalidRun)}");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}





