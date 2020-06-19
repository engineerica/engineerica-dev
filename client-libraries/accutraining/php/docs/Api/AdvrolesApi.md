# OpenAPI\Client\AdvrolesApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advrolesUserlist**](AdvrolesApi.md#advrolesUserlist) | **GET** /advroles/userlist | List users. Alias to user.list, use that one instead.



## advrolesUserlist

> advrolesUserlist($from, $count, $roleid, $onlywithoutcard, $photosize)

List users. Alias to user.list, use that one instead.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvrolesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$roleid = 'roleid_example'; // string | The id of the role to filter users by, or empty to return all users.
$onlywithoutcard = 'onlywithoutcard_example'; // string | If is 1 then only the users without a card are returned, otherwise all users are returned.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->advrolesUserlist($from, $count, $roleid, $onlywithoutcard, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling AdvrolesApi->advrolesUserlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **roleid** | [**string**](../Model/.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

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

