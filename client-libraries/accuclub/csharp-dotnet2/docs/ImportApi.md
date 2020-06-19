# Org.OpenAPITools.Api.ImportApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportListtypes**](ImportApi.md#importlisttypes) | **GET** /import/listtypes | Lists available import types


<a name="importlisttypes"></a>
# **ImportListtypes**
> void ImportListtypes ()

Lists available import types

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ImportListtypesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImportApi();

            try
            {
                // Lists available import types
                apiInstance.ImportListtypes();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportApi.ImportListtypes: " + e.Message );
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

