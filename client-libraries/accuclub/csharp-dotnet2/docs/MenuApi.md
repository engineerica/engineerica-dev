# Org.OpenAPITools.Api.MenuApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MenuGetitems**](MenuApi.md#menugetitems) | **GET** /menu/getitems | Gets the items on the menu


<a name="menugetitems"></a>
# **MenuGetitems**
> void MenuGetitems (string menuid)

Gets the items on the menu

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MenuGetitemsExample
    {
        public void main()
        {
            var apiInstance = new MenuApi();
            var menuid = menuid_example;  // string | The Id of the menu to get.

            try
            {
                // Gets the items on the menu
                apiInstance.MenuGetitems(menuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MenuApi.MenuGetitems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuid** | **string**| The Id of the menu to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

