# OpenapiClient::CaptchaApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**captcha_getchallenge**](CaptchaApi.md#captcha_getchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captcha_getimage**](CaptchaApi.md#captcha_getimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.



## captcha_getchallenge

> captcha_getchallenge

Gets a captcha challenge that the user must complete to do certain requests.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::CaptchaApi.new

begin
  #Gets a captcha challenge that the user must complete to do certain requests.
  api_instance.captcha_getchallenge
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CaptchaApi->captcha_getchallenge: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## captcha_getimage

> captcha_getimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::CaptchaApi.new
captchatoken = 'captchatoken_example' # String | The captcha token or ID returned by the captcha.getchallenge action

begin
  #Gets a captcha image that the user must complete to do certain requests.
  api_instance.captcha_getimage(captchatoken)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CaptchaApi->captcha_getimage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **String**| The captcha token or ID returned by the captcha.getchallenge action | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

