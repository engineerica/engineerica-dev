# Org.OpenAPITools.Api.FeatureApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FeatureList**](FeatureApi.md#featurelist) | **GET** /feature/list | Lists the available features.


<a name="featurelist"></a>
# **FeatureList**
> void FeatureList ()

Lists the available features.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FeatureListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeatureApi();

            try
            {
                // Lists the available features.
                apiInstance.FeatureList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.FeatureList: " + e.Message );
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

