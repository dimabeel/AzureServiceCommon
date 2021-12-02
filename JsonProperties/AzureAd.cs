﻿namespace AzureServices.JsonProperties;

public class AzureAd
{
    public string TenantId { get; set; } = string.Empty;

    public string ClientId { get; set; } = string.Empty;

    public string ClientSecret { get; set; } = string.Empty;

    public string Domain { get; set; } = string.Empty;

    public string Instance { get; set; } = string.Empty;

    public string CallbackPath { get; set; } = string.Empty;

    public string SignedOutCallbackPath { get; set; } = string.Empty;
}