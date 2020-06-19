# OpenAPI\Client\InteractionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**interactionDelete**](InteractionApi.md#interactionDelete) | **DELETE** /interaction/{id} | Delete an interaction
[**interactionFeed**](InteractionApi.md#interactionFeed) | **GET** /interaction/feed | Get the interactions feed
[**interactionGet**](InteractionApi.md#interactionGet) | **GET** /interaction/{id} | View an interaction
[**interactionListprivatesummary**](InteractionApi.md#interactionListprivatesummary) | **GET** /interaction/listprivatesummary | Get current user&#39;s latest private interactions
[**interactionSave**](InteractionApi.md#interactionSave) | **POST** /interaction/{id} | Save an interaction



## interactionDelete

> interactionDelete($id, $body)

Delete an interaction

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\InteractionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the interaction to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->interactionDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling InteractionApi->interactionDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the interaction to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## interactionFeed

> interactionFeed($from, $count, $startdate, $public, $contexttype, $contextid, $types, $photosize, $showdefaultphoto, $orderdescending)

Get the interactions feed

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\InteractionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If set, only interactions that happened after this date are returned.
$public = True; // bool | Specifies whether to return public or private interactions.
$contexttype = 'contexttype_example'; // string | The type of the context of the interactions to return.
$contextid = 'contextid_example'; // string | The id of the context of the interactions to return.
$types = 'types_example'; // string | The  comma separated types of the interactions to return.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
$showdefaultphoto = True; // bool | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
$orderdescending = True; // bool | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.

try {
    $apiInstance->interactionFeed($from, $count, $startdate, $public, $contexttype, $contextid, $types, $photosize, $showdefaultphoto, $orderdescending);
} catch (Exception $e) {
    echo 'Exception when calling InteractionApi->interactionFeed: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **startdate** | **\DateTime**| If set, only interactions that happened after this date are returned. | [optional]
 **public** | **bool**| Specifies whether to return public or private interactions. | [optional]
 **contexttype** | **string**| The type of the context of the interactions to return. | [optional]
 **contextid** | [**string**](../Model/.md)| The id of the context of the interactions to return. | [optional]
 **types** | **string**| The  comma separated types of the interactions to return. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]
 **orderdescending** | **bool**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional]

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


## interactionGet

> interactionGet($id, $thumbnailmediasize, $photosize)

View an interaction

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\InteractionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the interaction.
$thumbnailmediasize = 56; // int | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->interactionGet($id, $thumbnailmediasize, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling InteractionApi->interactionGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the interaction. |
 **thumbnailmediasize** | **int**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional]
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


## interactionListprivatesummary

> interactionListprivatesummary($photosize, $showdefaultphoto)

Get current user's latest private interactions

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\InteractionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
$showdefaultphoto = True; // bool | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.

try {
    $apiInstance->interactionListprivatesummary($photosize, $showdefaultphoto);
} catch (Exception $e) {
    echo 'Exception when calling InteractionApi->interactionListprivatesummary: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
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


## interactionSave

> interactionSave($id, $unknown_base_type)

Save an interaction

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\InteractionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the interaction to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->interactionSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling InteractionApi->interactionSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the interaction to save (leave empty to create a new one). |
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

