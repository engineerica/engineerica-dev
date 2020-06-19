# Org.OpenAPITools.Api.AppshareApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppshareGetphone**](AppshareApi.md#appsharegetphone) | **GET** /appshare/getphone | Gets the phone number of the current user
[**AppshareSendtext**](AppshareApi.md#appsharesendtext) | **GET** /appshare/sendtext | Sends an SMS with the link to the app


<a name="appsharegetphone"></a>
# **AppshareGetphone**
> void AppshareGetphone ()

Gets the phone number of the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppshareGetphoneExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppshareApi();

            try
            {
                // Gets the phone number of the current user
                apiInstance.AppshareGetphone();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppshareApi.AppshareGetphone: " + e.Message );
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

<a name="appsharesendtext"></a>
# **AppshareSendtext**
> void AppshareSendtext (string phonenumber)

Sends an SMS with the link to the app

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppshareSendtextExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppshareApi();
            var phonenumber = phonenumber_example;  // string | Phone number to where to send the link. Leave empty to the number on file. (optional) 

            try
            {
                // Sends an SMS with the link to the app
                apiInstance.AppshareSendtext(phonenumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppshareApi.AppshareSendtext: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phonenumber** | **string**| Phone number to where to send the link. Leave empty to the number on file. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

