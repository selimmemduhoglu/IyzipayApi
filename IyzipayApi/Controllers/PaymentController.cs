﻿using IyzipayApi.Models;
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
    public void CreatePaymentService(IyzipayCreateRequest iyzipayCreateRequest)
    {
        createPaymentService.CreatePaymentMethod(iyzipayCreateRequest);
    }


    [HttpPost]
    public void CancelPaymentService(IyzipayCreateRequest iyzipayCreateRequest)
    {
        createPaymentService.CreatePaymentMethod(iyzipayCreateRequest);
    }


    [HttpPost]
    public void RefundPaymentService(IyzipayCreateRequest iyzipayCreateRequest)
    {
        createPaymentService.CreatePaymentMethod(iyzipayCreateRequest);
    }


}
