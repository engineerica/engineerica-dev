# OpenAPI\Client\PushApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pushDeregister**](PushApi.md#pushDeregister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
[**pushRegister**](PushApi.md#pushRegister) | **GET** /push/register | Registers the current device to receive push notifications



## pushDeregister

> pushDeregister($devicetoken, $platform)

Deregisters the current device to receive push notifications

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\PushApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$devicetoken = 'devicetoken_example'; // string | The device token where to send the notification.
$platform = 'platform_example'; // string | Either ios or android

try {
    $apiInstance->pushDeregister($devicetoken, $platform);
} catch (Exception $e) {
    echo 'Exception when calling PushApi->pushDeregister: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **string**| The device token where to send the notification. |
 **platform** | **string**| Either ios or android |

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


## pushRegister

> pushRegister($devicetoken, $platform)

Registers the current device to receive push notifications

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\PushApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$devicetoken = 'devicetoken_example'; // string | The device token where to send the notification.
$platform = 'platform_example'; // string | Either ios or android

try {
    $apiInstance->pushRegister($devicetoken, $platform);
} catch (Exception $e) {
    echo 'Exception when calling PushApi->pushRegister: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **string**| The device token where to send the notification. |
 **platform** | **string**| Either ios or android |

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

