using Iyzipay.Request;
using IyzipayApi.Models;
using IyzipayApi.Models.CredentialsModels;
using IyzipayApi.Models.Request;
using IyzipayApi.Models.Resource;
using Address = IyzipayApi.Models.Address;
using BasketItem = IyzipayApi.Models.BasketItem;
using BasketItemType = IyzipayApi.Models.Enums.BasketItemType;
using Buyer = IyzipayApi.Models.Buyer;
using Currency = IyzipayApi.Models.Currency;
using Locale = IyzipayApi.Models.Locale;
using PaymentChannel = IyzipayApi.Models.Enums.PaymentChannel;
using PaymentGroup = IyzipayApi.Models.Enums.PaymentGroup;

namespace IyzipayApi.Services;

public class CreatePaymentService
{
    private readonly IConfiguration configuration;

    public CreatePaymentService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public void CreatePaymentMethod(IyzipayCreateRequest request)
    {
        var iyzipayOptions = configuration.GetSection("IyzipayOptions").Get<IyzipayOptions>();
        Options options = new Options
        {
            ApiKey = iyzipayOptions.ApiKey,
            SecretKey = iyzipayOptions.SecretKey,
            BaseUrl = iyzipayOptions.BaseUrl,
        };


        request.Locale = Locale.TR.ToString();
        request.ConversationId = "321321321";
        request.Price = "2";
        request.PaidPrice = "1.5";
        request.Currency = Currency.TRY.ToString();
        request.CountryCode = "TR";
        request.PaymentChannel = PaymentChannel.WEB.ToString();
        request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
        request.AccountHolderName = "success";
        request.MerchantCallbackUrl = "https://www.merchant.com/callback";
        request.MerchantErrorUrl = "https://www.merchant.com/error";
        request.MerchantNotificationUrl = "https://www.merchant.com/notification";
        request.ApmType = Models.Enums.ApmType.SOFORT.ToString();

        Buyer buyer = new Buyer();
        buyer.Id = "BY789";
        buyer.Name = "Selim";
        buyer.Surname = "Memduhoglu";
        buyer.GsmNumber = "+905445510873";
        buyer.Email = "seli@gmail.com";
        buyer.IdentityNumber = "74300864791";
        buyer.LastLoginDate = "2015-10-05 12:43:35";
        buyer.RegistrationDate = "2013-04-21 15:12:09";
        buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        buyer.Ip = "85.34.78.112";
        buyer.City = "Istanbul";
        buyer.Country = "Turkey";
        buyer.ZipCode = "34771";
        request.Buyer = buyer;

        Address shippingAddress = new Address();
        shippingAddress.ContactName = "Selim Memduhoglu";
        shippingAddress.City = "Istanbul";
        shippingAddress.Country = "Turkey";
        shippingAddress.Description = "Ümraniye, Ihlamurkuyu Mah. Turnalı Sok. No:8";
        shippingAddress.ZipCode = "34771";
        request.ShippingAddress = shippingAddress;

        Address billingAddress = new Address();
        billingAddress.ContactName = "Selim Memduhoglu";
        billingAddress.City = "Istanbul";
        billingAddress.Country = "Turkey";
        billingAddress.Description = "Ümraniye, Ihlamurkuyu Mah. Turnalı Sok. No:8";
        billingAddress.ZipCode = "34771";
        request.BillingAddress = billingAddress;

        List<BasketItem> basketItems = new List<BasketItem>();
        BasketItem firstBasketItem = new BasketItem();
        firstBasketItem.Id = "BI101";
        firstBasketItem.Name = "Binocular";
        firstBasketItem.Category1 = "Collectibles";
        firstBasketItem.Category2 = "Accessories";
        firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
        firstBasketItem.Price = "0.7";
        basketItems.Add(firstBasketItem);

        BasketItem secondBasketItem = new BasketItem();
        secondBasketItem.Id = "BI102";
        secondBasketItem.Name = "Game code";
        secondBasketItem.Category1 = "Game";
        secondBasketItem.Category2 = "Online Game Items";
        secondBasketItem.ItemType = BasketItemType.VIRTUAL.ToString();
        secondBasketItem.Price = "0.5";
        basketItems.Add(secondBasketItem);

        BasketItem thirdBasketItem = new BasketItem();
        thirdBasketItem.Id = "BI103";
        thirdBasketItem.Name = "Usb";
        thirdBasketItem.Category1 = "Electronics";
        thirdBasketItem.Category2 = "Usb / Cable";
        thirdBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
        thirdBasketItem.Price = "0.8";
        basketItems.Add(thirdBasketItem);
        request.BasketItems = basketItems;

        Apm apmInitialize = Apm.Create(request, options);

    }
    public void CancelPaymentMethod(IyzipayCancelRequest request)
    {
        var iyzipayOptions = configuration.GetSection("IyzipayOptions").Get<IyzipayOptions>();
        Options options = new Options
        {
            ApiKey = iyzipayOptions.ApiKey,
            SecretKey = iyzipayOptions.SecretKey,
            BaseUrl = iyzipayOptions.BaseUrl,
        };

        request.ConversationId = "123456789";
        request.Locale = Locale.TR.ToString();
        request.PaymentId = "1";
        request.Ip = "85.34.78.112";

        Cancel cancel = Cancel.Create(request, options);


    }
    public void CancelPaymentMethod(IyzipayRefundRequest request)
    {
        var iyzipayOptions = configuration.GetSection("IyzipayOptions").Get<IyzipayOptions>();
        Options options = new Options
        {
            ApiKey = iyzipayOptions.ApiKey,
            SecretKey = iyzipayOptions.SecretKey,
            BaseUrl = iyzipayOptions.BaseUrl,
        };

        request.ConversationId = "123456789";
        request.Locale = Locale.TR.ToString();
        request.PaymentTransactionId = "1";
        request.Price = "0.5";
        request.Ip = "85.34.78.112";
        request.Currency = Currency.TRY.ToString();

        Refund refund = Refund.Create(request, options);

    }

}
