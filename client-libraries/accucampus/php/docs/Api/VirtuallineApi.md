# OpenAPI\Client\VirtuallineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**virtuallineAddmyself**](VirtuallineApi.md#virtuallineAddmyself) | **GET** /virtualline/addmyself | Add myself to a waiting line
[**virtuallineList**](VirtuallineApi.md#virtuallineList) | **GET** /virtualline/list | Lists waiting lines that have remote access enabled
[**virtuallineRemovemyself**](VirtuallineApi.md#virtuallineRemovemyself) | **GET** /virtualline/removemyself | Remove myself from a waiting line



## virtuallineAddmyself

> virtuallineAddmyself($waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\VirtuallineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$waitinglineid = 'waitinglineid_example'; // string | ID of the waiting line to join.

try {
    $apiInstance->virtuallineAddmyself($waitinglineid);
} catch (Exception $e) {
    echo 'Exception when calling VirtuallineApi->virtuallineAddmyself: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitinglineid** | [**string**](../Model/.md)| ID of the waiting line to join. |

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


## virtuallineList

> virtuallineList()

Lists waiting lines that have remote access enabled

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\VirtuallineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->virtuallineList();
} catch (Exception $e) {
    echo 'Exception when calling VirtuallineApi->virtuallineList: ', $e->getMessage(), PHP_EOL;
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


## virtuallineRemovemyself

> virtuallineRemovemyself()

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\VirtuallineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->virtuallineRemovemyself();
} catch (Exception $e) {
    echo 'Exception when calling VirtuallineApi->virtuallineRemovemyself: ', $e->getMessage(), PHP_EOL;
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

