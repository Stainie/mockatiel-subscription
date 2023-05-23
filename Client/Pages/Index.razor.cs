﻿using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using SharedResources.Models;

namespace Client.Pages;

public partial class Index
{
    [Inject]
    public HttpClient HttpClient { get; set; } = default!;

    [Inject]
    public IJSRuntime JsRuntime { get; set; } = default!;

    private List<Product>? _products;
    private IEnumerable<Product[]>? _productChunksOf4;

    private const string DevApiBaseAddress = "https://localhost:7285";

    protected override async Task OnInitializedAsync()
    {
        _products = await HttpClient.GetFromJsonAsync<List<Product>>($"{DevApiBaseAddress}/product");

        if (_products is not null)
        {
            _productChunksOf4 = _products.Chunk(4);
        }
    }

    private async Task OnClickBtnBuyNowAsync(Product product)
    {
        var response = await HttpClient.PostAsJsonAsync($"{DevApiBaseAddress}/checkout", product);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var checkoutOrderResponse = JsonConvert.DeserializeObject<CheckoutOrderResponse>(responseBody);

        // Opens up Stripe.
        await JsRuntime.InvokeVoidAsync("checkout", checkoutOrderResponse.PublishableKey, checkoutOrderResponse.SessionId);
    }
}
