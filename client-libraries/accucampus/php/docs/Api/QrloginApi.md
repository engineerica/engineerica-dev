# OpenAPI\Client\QrloginApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrloginGet**](QrloginApi.md#qrloginGet) | **GET** /qrlogin/get | Gets an image of a QR token
[**qrloginLogin**](QrloginApi.md#qrloginLogin) | **GET** /qrlogin/login | Login



## qrloginGet

> qrloginGet()

Gets an image of a QR token

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QrloginApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->qrloginGet();
} catch (Exception $e) {
    echo 'Exception when calling QrloginApi->qrloginGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## qrloginLogin

> qrloginLogin($onetimetoken)

Login

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\QrloginApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$onetimetoken = 'onetimetoken_example'; // string | The token read from the QR code.

try {
    $apiInstance->qrloginLogin($onetimetoken);
} catch (Exception $e) {
    echo 'Exception when calling QrloginApi->qrloginLogin: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

