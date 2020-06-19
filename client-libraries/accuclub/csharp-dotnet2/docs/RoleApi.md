# Org.OpenAPITools.Api.RoleApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RoleList**](RoleApi.md#rolelist) | **GET** /role/list | Show a list of roles


<a name="rolelist"></a>
# **RoleList**
> void RoleList (string name)

Show a list of roles

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RoleListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RoleApi();
            var name = name_example;  // string | Filter by name of the role. (optional) 

            try
            {
                // Show a list of roles
                apiInstance.RoleList(name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoleApi.RoleList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

