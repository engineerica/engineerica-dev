# OpenAPI\Client\QrlabelsApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrlabelsPrint**](QrlabelsApi.md#qrlabelsPrint) | **GET** /qrlabels/print | Print and email QR labels



## qrlabelsPrint

> qrlabelsPrint($user, $group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QrlabelsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$user = 'user_example'; // string | The id of the user whose label needs to be printed.
$group = 'group_example'; // string | The id of the group whose members' labels need to be printed.

try {
    $apiInstance->qrlabelsPrint($user, $group);
} catch (Exception $e) {
    echo 'Exception when calling QrlabelsApi->qrlabelsPrint: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**string**](../Model/.md)| The id of the user whose label needs to be printed. | [optional]
 **group** | [**string**](../Model/.md)| The id of the group whose members&#39; labels need to be printed. | [optional]

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

