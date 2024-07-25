using System.Security.Cryptography;
using System.Text;

namespace Blockchain;

public static class Program
{
    private static void Main()
    {
        string inputData = "¡Blockchain!";
        Console.WriteLine($"Original hash: {inputData}");

        using var sha256 = SHA256.Create();
        var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputData));
        var hash = new StringBuilder();

        foreach (var t in hashBytes)
        {
            hash.Append(t.ToString("x2"));
        }

        Console.WriteLine($"Hash SHA256: {hash}");
    }
}