# OpenAPI\Client\ServiceassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**serviceassignmentAddservice**](ServiceassignmentApi.md#serviceassignmentAddservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
[**serviceassignmentGetlocation**](ServiceassignmentApi.md#serviceassignmentGetlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**serviceassignmentGetservice**](ServiceassignmentApi.md#serviceassignmentGetservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
[**serviceassignmentRemoveservice**](ServiceassignmentApi.md#serviceassignmentRemoveservice) | **GET** /serviceassignment/removeservice | Remove a service from a location



## serviceassignmentAddservice

> serviceassignmentAddservice($serviceid, $locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ServiceassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceid = 'serviceid_example'; // string | The id of the service to add.
$locationid = 'locationid_example'; // string | The id of the location.

try {
    $apiInstance->serviceassignmentAddservice($serviceid, $locationid);
} catch (Exception $e) {
    echo 'Exception when calling ServiceassignmentApi->serviceassignmentAddservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](../Model/.md)| The id of the service to add. |
 **locationid** | [**string**](../Model/.md)| The id of the location. |

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


## serviceassignmentGetlocation

> serviceassignmentGetlocation($locationid, $includegloballyavailable, $namefilter, $count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ServiceassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$locationid = 'locationid_example'; // string | The id of the location to get.
$includegloballyavailable = True; // bool | Specifies whether the services available globally must be returned or not.
$namefilter = True; // bool | Filters the name of the services to return.
$count = 56; // int | The max number of services to return.

try {
    $apiInstance->serviceassignmentGetlocation($locationid, $includegloballyavailable, $namefilter, $count);
} catch (Exception $e) {
    echo 'Exception when calling ServiceassignmentApi->serviceassignmentGetlocation: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**string**](../Model/.md)| The id of the location to get. |
 **includegloballyavailable** | **bool**| Specifies whether the services available globally must be returned or not. | [optional]
 **namefilter** | **bool**| Filters the name of the services to return. | [optional]
 **count** | **int**| The max number of services to return. | [optional]

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


## serviceassignmentGetservice

> serviceassignmentGetservice($serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ServiceassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceid = 'serviceid_example'; // string | The id of the service to get its locations.

try {
    $apiInstance->serviceassignmentGetservice($serviceid);
} catch (Exception $e) {
    echo 'Exception when calling ServiceassignmentApi->serviceassignmentGetservice: ', $e->getMessage(), PHP_EOL;
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


## serviceassignmentRemoveservice

> serviceassignmentRemoveservice($serviceid, $locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ServiceassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceid = 'serviceid_example'; // string | The id of the service to remove.
$locationid = 'locationid_example'; // string | The id of the location to remove the service from.

try {
    $apiInstance->serviceassignmentRemoveservice($serviceid, $locationid);
} catch (Exception $e) {
    echo 'Exception when calling ServiceassignmentApi->serviceassignmentRemoveservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](../Model/.md)| The id of the service to remove. |
 **locationid** | [**string**](../Model/.md)| The id of the location to remove the service from. |

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

