# WWW::OpenAPIClient::CaptchaApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::CaptchaApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**captcha_getchallenge**](CaptchaApi.md#captcha_getchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captcha_getimage**](CaptchaApi.md#captcha_getimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.


# **captcha_getchallenge**
> captcha_getchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CaptchaApi;
my $api_instance = WWW::OpenAPIClient::CaptchaApi->new(
);


eval { 
    $api_instance->captcha_getchallenge();
};
if ($@) {
    warn "Exception when calling CaptchaApi->captcha_getchallenge: $@\n";
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

# **captcha_getimage**
> captcha_getimage(captchatoken => $captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CaptchaApi;
my $api_instance = WWW::OpenAPIClient::CaptchaApi->new(
);

my $captchatoken = "captchatoken_example"; # string | The captcha token or ID returned by the captcha.getchallenge action

eval { 
    $api_instance->captcha_getimage(captchatoken => $captchatoken);
};
if ($@) {
    warn "Exception when calling CaptchaApi->captcha_getimage: $@\n";
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

