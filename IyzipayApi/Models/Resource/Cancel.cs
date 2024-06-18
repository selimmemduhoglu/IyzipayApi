using Iyzipay.Request;
using IyzipayApi.Models.Clients;
using IyzipayApi.Models.Request;

namespace IyzipayApi.Models.Resource;

public class Cancel : IyzipayResource
{
    public String PaymentId { get; set; }
    public String Price { get; set; }
    public String Currency { get; set; }
    public String ConnectorName { get; set; }
    public String AuthCode { get; set; }
    public String HostReference { get; set; }

    public static Cancel Create(IyzipayCancelRequest request, Options options)
    {
        return RestHttpClient.Create().Post<Cancel>(options.BaseUrl + "/payment/cancel", GetHttpHeaders(request, options), request);
    }
}
