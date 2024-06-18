using Iyzipay.Request;
using IyzipayApi.Models.Clients;
using IyzipayApi.Models.Request;

namespace IyzipayApi.Models.Resource;

public class Refund : IyzipayResource
{
    public String PaymentId { get; set; }
    public String PaymentTransactionId { get; set; }
    public String Price { get; set; }
    public String Currency { get; set; }
    public String ConnectorName { get; set; }
    public String AuthCode { get; set; }
    public String HostReference { get; set; }

    public static Refund Create(IyzipayRefundRequest request, Options options)
    {
        return RestHttpClient.Create().Post<Refund>(options.BaseUrl + "/payment/refund", GetHttpHeaders(request, options), request);
    }

    //public static Refund CreateAmountBasedRefundRequest(CreateAmountBasedRefundRequest request, Options options)
    //{
    //    return RestHttpClient.Create().Post<Refund>(options.BaseUrl + "/v2/payment/refund", GetHttpHeaders(request, options), request);
    //}

}
