
using Iyzipay.Request;
using IyzipayApi.Models.Clients;

namespace IyzipayApi.Models.Resource;

public class Apm : ApmResource
{
    public static Apm Create(IyzipayCreateRequest request, Options options)
    {
        return RestHttpClient.Create().Post<Apm>(options.BaseUrl + "/payment/apm/initialize", GetHttpHeaders(request, options), request);
    }

    public static Apm Retrieve(RetrieveApmRequest request, Options options)
    {
        return RestHttpClient.Create().Post<Apm>(options.BaseUrl + "/payment/apm/retrieve", GetHttpHeaders(request, options), request);
    }
}
