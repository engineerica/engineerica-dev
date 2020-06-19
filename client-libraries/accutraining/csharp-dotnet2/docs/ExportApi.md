# Org.OpenAPITools.Api.ExportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportListtypes**](ExportApi.md#exportlisttypes) | **GET** /export/listtypes | Lists available export types


<a name="exportlisttypes"></a>
# **ExportListtypes**
> void ExportListtypes ()

Lists available export types

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ExportListtypesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExportApi();

            try
            {
                // Lists available export types
                apiInstance.ExportListtypes();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportApi.ExportListtypes: " + e.Message );
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

