using IyzipayApi.Models;

namespace IyzipayApi.Services;

public class Sample
{
    protected Options options;

    public void Initialize()
    {
        options = new Options();
        options.ApiKey = "sandbox-mcu2voksqvqkczMgUnaWr6SaIqLjaCsa";
        options.SecretKey = "sandbox-nynrsX0BMoSbzwZYUfoXi2SjEzyimwjk";
        options.BaseUrl = "https://sandbox-api.iyzipay.com";

    }
}
