﻿using System.Text.Json.Serialization;

namespace OpenShopify.Admin.Builder.Models;

public class ErrorResponse
{
    [JsonPropertyName("errors")]
    public string? Message { get; set; }
}