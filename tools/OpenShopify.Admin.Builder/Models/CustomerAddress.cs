﻿using System.Text.Json.Serialization;

namespace OpenShopify.Admin.Builder.Models;

public partial record CustomerAddressBase
{
    /// <summary>
    /// Indicates whether this address is the default address.
    /// </summary>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }
}
