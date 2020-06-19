# \CaptchaApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CaptchaGetchallenge**](CaptchaApi.md#CaptchaGetchallenge) | **Get** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**CaptchaGetimage**](CaptchaApi.md#CaptchaGetimage) | **Get** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.



## CaptchaGetchallenge

> CaptchaGetchallenge(ctx, )

Gets a captcha challenge that the user must complete to do certain requests.

### Required Parameters

This endpoint does not need any parameter.

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CaptchaGetimage

> CaptchaGetimage(ctx, captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**captchatoken** | **string**| The captcha token or ID returned by the captcha.getchallenge action | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

