# CaptchaApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**captchaGetchallenge**](CaptchaApi.md#captchaGetchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captchaGetimage**](CaptchaApi.md#captchaGetimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.


<a name="captchaGetchallenge"></a>
# **captchaGetchallenge**
> captchaGetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CaptchaApi()
try {
    apiInstance.captchaGetchallenge()
} catch (e: ClientException) {
    println("4xx response calling CaptchaApi#captchaGetchallenge")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CaptchaApi#captchaGetchallenge")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="captchaGetimage"></a>
# **captchaGetimage**
> captchaGetimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CaptchaApi()
val captchatoken : kotlin.String = captchatoken_example // kotlin.String | The captcha token or ID returned by the captcha.getchallenge action
try {
    apiInstance.captchaGetimage(captchatoken)
} catch (e: ClientException) {
    println("4xx response calling CaptchaApi#captchaGetimage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CaptchaApi#captchaGetimage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **kotlin.String**| The captcha token or ID returned by the captcha.getchallenge action |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

