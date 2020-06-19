# Org.OpenAPITools.Api.QrloginApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QrloginGet**](QrloginApi.md#qrloginget) | **GET** /qrlogin/get | Gets an image of a QR token
[**QrloginLogin**](QrloginApi.md#qrloginlogin) | **GET** /qrlogin/login | Login


<a name="qrloginget"></a>
# **QrloginGet**
> void QrloginGet ()

Gets an image of a QR token

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrloginGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QrloginApi();

            try
            {
                // Gets an image of a QR token
                apiInstance.QrloginGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QrloginApi.QrloginGet: " + e.Message );
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

<a name="qrloginlogin"></a>
# **QrloginLogin**
> void QrloginLogin (string onetimetoken)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrloginLoginExample
    {
        public void main()
        {
            var apiInstance = new QrloginApi();
            var onetimetoken = onetimetoken_example;  // string | The token read from the QR code.

            try
            {
                // Login
                apiInstance.QrloginLogin(onetimetoken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QrloginApi.QrloginLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onetimetoken** | **string**| The token read from the QR code. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

