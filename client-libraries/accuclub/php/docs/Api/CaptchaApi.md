# OpenAPI\Client\CaptchaApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**captchaGetchallenge**](CaptchaApi.md#captchaGetchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captchaGetimage**](CaptchaApi.md#captchaGetimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.



## captchaGetchallenge

> captchaGetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\CaptchaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->captchaGetchallenge();
} catch (Exception $e) {
    echo 'Exception when calling CaptchaApi->captchaGetchallenge: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## captchaGetimage

> captchaGetimage($captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\CaptchaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$captchatoken = 'captchatoken_example'; // string | The captcha token or ID returned by the captcha.getchallenge action

try {
    $apiInstance->captchaGetimage($captchatoken);
} catch (Exception $e) {
    echo 'Exception when calling CaptchaApi->captchaGetimage: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

