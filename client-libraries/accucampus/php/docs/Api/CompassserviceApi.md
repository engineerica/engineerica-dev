# OpenAPI\Client\CompassserviceApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**compassserviceList**](CompassserviceApi.md#compassserviceList) | **GET** /compassservice/list | View all the services added to the compass
[**compassserviceListlocations**](CompassserviceApi.md#compassserviceListlocations) | **GET** /compassservice/listlocations | View all the locations where a service added to the compass is available



## compassserviceList

> compassserviceList($category)

View all the services added to the compass

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\CompassserviceApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$category = 'category_example'; // string | The id of the category to filter the services.

try {
    $apiInstance->compassserviceList($category);
} catch (Exception $e) {
    echo 'Exception when calling CompassserviceApi->compassserviceList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**string**](../Model/.md)| The id of the category to filter the services. | [optional]

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


## compassserviceListlocations

> compassserviceListlocations($serviceid)

View all the locations where a service added to the compass is available

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\CompassserviceApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceid = 'serviceid_example'; // string | The id of the service to get its locations.

try {
    $apiInstance->compassserviceListlocations($serviceid);
} catch (Exception $e) {
    echo 'Exception when calling CompassserviceApi->compassserviceListlocations: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](../Model/.md)| The id of the service to get its locations. |

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

