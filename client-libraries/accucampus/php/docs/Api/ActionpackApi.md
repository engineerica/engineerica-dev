# OpenAPI\Client\ActionpackApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionpackAssign**](ActionpackApi.md#actionpackAssign) | **GET** /actionpack/assign | Assign an action item pack to a user
[**actionpackDelete**](ActionpackApi.md#actionpackDelete) | **DELETE** /actionpack/{id} | Delete an action item pack
[**actionpackGet**](ActionpackApi.md#actionpackGet) | **GET** /actionpack/{id} | View details of an action item pack
[**actionpackList**](ActionpackApi.md#actionpackList) | **GET** /actionpack/list | View a list of action item packs
[**actionpackSave**](ActionpackApi.md#actionpackSave) | **POST** /actionpack/{id} | Create or edit an action item pack



## actionpackAssign

> actionpackAssign($pack, $itemsdata, $assignee, $group, $notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionpackApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$pack = 'pack_example'; // string | The id of the action pack to assign.
$itemsdata = True; // bool | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
$assignee = 'assignee_example'; // string | The assignee of the pack.
$group = 'group_example'; // string | The group to assign the pack.
$notes = 'notes_example'; // string | The assignment's notes.

try {
    $apiInstance->actionpackAssign($pack, $itemsdata, $assignee, $group, $notes);
} catch (Exception $e) {
    echo 'Exception when calling ActionpackApi->actionpackAssign: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pack** | [**string**](../Model/.md)| The id of the action pack to assign. |
 **itemsdata** | **bool**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). |
 **assignee** | [**string**](../Model/.md)| The assignee of the pack. | [optional]
 **group** | [**string**](../Model/.md)| The group to assign the pack. | [optional]
 **notes** | **string**| The assignment&#39;s notes. | [optional]

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


## actionpackDelete

> actionpackDelete($id, $body)

Delete an action item pack

Allows the user to delete an action item pack.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionpackApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the action pack to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->actionpackDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling ActionpackApi->actionpackDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the action pack to delete. |
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


## actionpackGet

> actionpackGet($id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionpackApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the action pack to get.

try {
    $apiInstance->actionpackGet($id);
} catch (Exception $e) {
    echo 'Exception when calling ActionpackApi->actionpackGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the action pack to get. |

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


## actionpackList

> actionpackList($from, $count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionpackApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->actionpackList($from, $count);
} catch (Exception $e) {
    echo 'Exception when calling ActionpackApi->actionpackList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |

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


## actionpackSave

> actionpackSave($id, $unknown_base_type)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionpackApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the action pack to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->actionpackSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling ActionpackApi->actionpackSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the action pack to save (leave empty to create a new one). |
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

