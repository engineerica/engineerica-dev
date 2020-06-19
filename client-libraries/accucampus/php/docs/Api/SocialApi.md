# OpenAPI\Client\SocialApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**socialContacts**](SocialApi.md#socialContacts) | **GET** /social/contacts | Gets the list of contacts in the network



## socialContacts

> socialContacts($filter, $showdefaultphoto)

Gets the list of contacts in the network

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SocialApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$filter = 'filter_example'; // string | Text to filter results.
$showdefaultphoto = True; // bool | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.

try {
    $apiInstance->socialContacts($filter, $showdefaultphoto);
} catch (Exception $e) {
    echo 'Exception when calling SocialApi->socialContacts: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Text to filter results. | [optional]
 **showdefaultphoto** | **bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]

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

