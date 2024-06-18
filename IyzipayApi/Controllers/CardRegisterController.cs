using IyzipayApi.Models;
using IyzipayApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IyzipayApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CardRegisterController : ControllerBase
{
    private readonly CreatePaymentService createPaymentService;

    public CardRegisterController(CreatePaymentService createPaymentService)
    {
        this.createPaymentService = createPaymentService;
    }

    [HttpPost]
    public void CreateUserAndCardService(IyzipayCreateRequest iyzipayCreateRequest)
    {
        createPaymentService.CreatePaymentMethod(iyzipayCreateRequest);
    }

    [HttpPost]
    public void CreateCardService(IyzipayCreateRequest iyzipayCreateRequest)
    {
        createPaymentService.CreatePaymentMethod(iyzipayCreateRequest);
    }

    [HttpDelete]
    public void DeleteCardService(IyzipayCreateRequest iyzipayCreateRequest)
    {
        createPaymentService.CreatePaymentMethod(iyzipayCreateRequest);
    }

    [HttpPost]
    public void RetrieveCardService(IyzipayCreateRequest iyzipayCreateRequest)
    {
        createPaymentService.CreatePaymentMethod(iyzipayCreateRequest);
    }



}
