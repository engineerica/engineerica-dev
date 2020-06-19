# Org.OpenAPITools.Api.SearchApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchGetentities**](SearchApi.md#searchgetentities) | **GET** /search/getentities | Get the information of the entities that can be searched


<a name="searchgetentities"></a>
# **SearchGetentities**
> void SearchGetentities ()

Get the information of the entities that can be searched

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchGetentitiesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();

            try
            {
                // Get the information of the entities that can be searched
                apiInstance.SearchGetentities();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchGetentities: " + e.Message );
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

