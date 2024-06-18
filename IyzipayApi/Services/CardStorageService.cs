using Iyzipay.Request;
using IyzipayApi.Models;
using IyzipayApi.Models.CredentialsModels;
using IyzipayApi.Models.Request;
using IyzipayApi.Models.Resource;
using Locale = IyzipayApi.Models.Locale;



namespace IyzipayApi.Services;

public class CardStorageService
{
    private readonly IConfiguration configuration;

    public CardStorageService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public void CreateUserAndCardService(Models.Request.CreateCardRequest request)
    {
        var iyzipayOptions = configuration.GetSection("IyzipayOptions").Get<IyzipayOptions>();
        Options options = new Options
        {
            ApiKey = iyzipayOptions.ApiKey,
            SecretKey = iyzipayOptions.SecretKey,
            BaseUrl = iyzipayOptions.BaseUrl,
        };
        request.Locale = Locale.TR.ToString();
        request.ConversationId = "123456789";
        request.Email = "email@email.com";
        request.ExternalId = "external id";

        CardInformation cardInformation = new CardInformation();
        cardInformation.CardAlias = "card alias";
        cardInformation.CardHolderName = "John Doe";
        cardInformation.CardNumber = "5528790000000008";
        cardInformation.ExpireMonth = "12";
        cardInformation.ExpireYear = "2030";
        request.Card = cardInformation;

        Card card = Card.Create(request, options);

    }
    public void CreateCardService(Models.Request.CreateCardRequest request)
    {
        var iyzipayOptions = configuration.GetSection("IyzipayOptions").Get<IyzipayOptions>();
        Options options = new Options
        {
            ApiKey = iyzipayOptions.ApiKey,
            SecretKey = iyzipayOptions.SecretKey,
            BaseUrl = iyzipayOptions.BaseUrl,
        };
        request.Locale = Locale.TR.ToString();
        request.ConversationId = "123456789";
        request.CardUserKey = "card user key";

        CardInformation cardInformation = new CardInformation();
        cardInformation.CardAlias = "card alias";
        cardInformation.CardHolderName = "John Doe";
        cardInformation.CardNumber = "5528790000000008";
        cardInformation.ExpireMonth = "12";
        cardInformation.ExpireYear = "2030";
        request.Card = cardInformation;

        Card card = Card.Create(request, options);
    }
    public void DeleteCardService(Models.Request.DeleteCardRequest request)
    {
        var iyzipayOptions = configuration.GetSection("IyzipayOptions").Get<IyzipayOptions>();
        Options options = new Options
        {
            ApiKey = iyzipayOptions.ApiKey,
            SecretKey = iyzipayOptions.SecretKey,
            BaseUrl = iyzipayOptions.BaseUrl,
        };
        request.Locale = Locale.TR.ToString();
        request.ConversationId = "123456789";
        request.CardToken = "card token";
        request.CardUserKey = "card user key";

        Card card = Card.Delete(request, options);
    }
    public void RetrieveCardService(Models.Request.RetrieveCardListRequest request)
    {
        var iyzipayOptions = configuration.GetSection("IyzipayOptions").Get<IyzipayOptions>();
        Options options = new Options
        {
            ApiKey = iyzipayOptions.ApiKey,
            SecretKey = iyzipayOptions.SecretKey,
            BaseUrl = iyzipayOptions.BaseUrl,
        };
        request.Locale = Locale.TR.ToString();
        request.ConversationId = "123456789";
        request.CardUserKey = "card user key";

        CardList cardList = CardList.Retrieve(request, options);
    }

}
