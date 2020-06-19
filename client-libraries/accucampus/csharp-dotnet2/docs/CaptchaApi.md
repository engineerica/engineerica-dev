# Org.OpenAPITools.Api.CaptchaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CaptchaGetchallenge**](CaptchaApi.md#captchagetchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**CaptchaGetimage**](CaptchaApi.md#captchagetimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.


<a name="captchagetchallenge"></a>
# **CaptchaGetchallenge**
> void CaptchaGetchallenge ()

Gets a captcha challenge that the user must complete to do certain requests.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CaptchaGetchallengeExample
    {
        public void main()
        {
            var apiInstance = new CaptchaApi();

            try
            {
                // Gets a captcha challenge that the user must complete to do certain requests.
                apiInstance.CaptchaGetchallenge();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaptchaApi.CaptchaGetchallenge: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="captchagetimage"></a>
# **CaptchaGetimage**
> void CaptchaGetimage (string captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CaptchaGetimageExample
    {
        public void main()
        {
            var apiInstance = new CaptchaApi();
            var captchatoken = captchatoken_example;  // string | The captcha token or ID returned by the captcha.getchallenge action

            try
            {
                // Gets a captcha image that the user must complete to do certain requests.
                apiInstance.CaptchaGetimage(captchatoken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CaptchaApi.CaptchaGetimage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **string**| The captcha token or ID returned by the captcha.getchallenge action | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

