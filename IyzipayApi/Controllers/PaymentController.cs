using IyzipayApi.Models;
using IyzipayApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IyzipayApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly CreatePaymentService createPaymentService;

    public PaymentController(CreatePaymentService createPaymentService)
    {
        this.createPaymentService = createPaymentService;
    }

    [HttpPost]
    public void PaymentService(IyzipayCreateRequest iyzipayCreateRequest)
    {
        createPaymentService.CreatePaymentMethod(iyzipayCreateRequest);
    }



}
