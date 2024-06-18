using IyzipayApi.Models;
using IyzipayApi.Models.Request;
using IyzipayApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IyzipayApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CardRegisterController : ControllerBase
{
    private readonly CardStorageService cardStorageService;

    public CardRegisterController(CardStorageService cardStorageService)
    {
        this.cardStorageService = cardStorageService;
    }

    [HttpPost("CreateUserAndCardService")]
    public void CreateUserAndCardService(CreateCardRequest iyzipayCreateRequest)
    {
        cardStorageService.CreateUserAndCardService(iyzipayCreateRequest);
    }

    [HttpPost("CreateCardService")]
    public void CreateCardService(CreateCardRequest iyzipayCreateRequest)
    {
        cardStorageService.CreateCardService(iyzipayCreateRequest);
    }

    [HttpDelete("DeleteCardService")]
    public void DeleteCardService(DeleteCardRequest iyzipayCreateRequest)
    {
        cardStorageService.DeleteCardService(iyzipayCreateRequest);
    }

    [HttpPost("RetrieveCardService")]
    public void RetrieveCardService(RetrieveCardListRequest iyzipayCreateRequest)
    {
        cardStorageService.RetrieveCardService(iyzipayCreateRequest);
    }

}
