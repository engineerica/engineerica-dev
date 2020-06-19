# Org.OpenAPITools.Api.TextcreditApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TextcreditRemaining**](TextcreditApi.md#textcreditremaining) | **GET** /textcredit/remaining | Gets the remaining text credits for the account


<a name="textcreditremaining"></a>
# **TextcreditRemaining**
> void TextcreditRemaining ()

Gets the remaining text credits for the account

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TextcreditRemainingExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TextcreditApi();

            try
            {
                // Gets the remaining text credits for the account
                apiInstance.TextcreditRemaining();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextcreditApi.TextcreditRemaining: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

