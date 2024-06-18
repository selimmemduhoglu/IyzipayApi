using IyzipayApi.Models.Clients;
using IyzipayApi.Models.Request;

namespace IyzipayApi.Models.Resource;

public class CardList : IyzipayResource
{
    public String CardUserKey { get; set; }
    public List<Card> CardDetails { get; set; }

    public static CardList Retrieve(RetrieveCardListRequest request, Options options)
    {
        return RestHttpClient.Create().Post<CardList>(options.BaseUrl + "/cardstorage/cards", GetHttpHeaders(request, options), request);
    }
}
