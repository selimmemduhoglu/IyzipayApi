using IyzipayApi.Models;
using System.Security.Cryptography;
using System.Text;

namespace IyzipayApi.Helpers;

public sealed class HashGenerator
{
    private HashGenerator()
    {
    }

    public static String GenerateHash(String apiKey, String secretkey, String randomString, BaseRequest request)
    {
        HashAlgorithm algorithm = new SHA1Managed();
        string hashStr = apiKey + randomString + secretkey + request.ToPKIRequestString();
        byte[] computeHast = algorithm.ComputeHash(Encoding.UTF8.GetBytes(hashStr));
        return Convert.ToBase64String(computeHast);
    }


}
