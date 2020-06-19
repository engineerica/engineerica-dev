# OpenAPI\Client\ActionassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionassignmentDelete**](ActionassignmentApi.md#actionassignmentDelete) | **DELETE** /actionassignment/{id} | Remove an action item from an action plan
[**actionassignmentGet**](ActionassignmentApi.md#actionassignmentGet) | **GET** /actionassignment/{id} | Search and view details of an action item assigned to a user
[**actionassignmentList**](ActionassignmentApi.md#actionassignmentList) | **GET** /actionassignment/list | View a list of action items in a user&#39;s plan
[**actionassignmentListhistory**](ActionassignmentApi.md#actionassignmentListhistory) | **GET** /actionassignment/listhistory | View the history of an action item assigned to a user
[**actionassignmentListmine**](ActionassignmentApi.md#actionassignmentListmine) | **GET** /actionassignment/listmine | List public action assignments assigned to the logged user
[**actionassignmentListpublichistory**](ActionassignmentApi.md#actionassignmentListpublichistory) | **GET** /actionassignment/listpublichistory | List public action assignment history
[**actionassignmentMarkcomplete**](ActionassignmentApi.md#actionassignmentMarkcomplete) | **GET** /actionassignment/markcomplete | Bulk complete action items
[**actionassignmentSave**](ActionassignmentApi.md#actionassignmentSave) | **POST** /actionassignment/save | Add an action item to a user&#39;s action plan
[**actionassignmentSavehistory**](ActionassignmentApi.md#actionassignmentSavehistory) | **POST** /actionassignment/savehistory | Update an action item assigned to a user



## actionassignmentDelete

> actionassignmentDelete($id, $body)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the action assignment to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->actionassignmentDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the action assignment to delete. |
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


## actionassignmentGet

> actionassignmentGet($id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the action assignment to get.

try {
    $apiInstance->actionassignmentGet($id);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the action assignment to get. |

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


## actionassignmentList

> actionassignmentList($from, $count, $assignee, $status)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$assignee = 56; // int | The assignee's id to filter the assignments.
$status = 56; // int | The status to filter the assignments.

try {
    $apiInstance->actionassignmentList($from, $count, $assignee, $status);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **assignee** | **int**| The assignee&#39;s id to filter the assignments. | [optional]
 **status** | **int**| The status to filter the assignments. | [optional]

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


## actionassignmentListhistory

> actionassignmentListhistory($actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$actionassignment = 'actionassignment_example'; // string | The action assignment's id whose history the user wants to get.

try {
    $apiInstance->actionassignmentListhistory($actionassignment);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentListhistory: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**string**](../Model/.md)| The action assignment&#39;s id whose history the user wants to get. |

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


## actionassignmentListmine

> actionassignmentListmine($from, $count, $status)

List public action assignments assigned to the logged user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$status = 56; // int | The status to filter the assignments.

try {
    $apiInstance->actionassignmentListmine($from, $count, $status);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentListmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **status** | **int**| The status to filter the assignments. | [optional]

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


## actionassignmentListpublichistory

> actionassignmentListpublichistory($actionassignment)

List public action assignment history

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$actionassignment = 'actionassignment_example'; // string | The action assignment's id whose history the user wants to get.

try {
    $apiInstance->actionassignmentListpublichistory($actionassignment);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentListpublichistory: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**string**](../Model/.md)| The action assignment&#39;s id whose history the user wants to get. |

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


## actionassignmentMarkcomplete

> actionassignmentMarkcomplete($item, $assignee, $group, $notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$item = 'item_example'; // string | The action item to assign.
$assignee = 'assignee_example'; // string | The assignee of the item.
$group = 'group_example'; // string | The group to assing the item.
$notes = 'notes_example'; // string | The assignment's notes.

try {
    $apiInstance->actionassignmentMarkcomplete($item, $assignee, $group, $notes);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentMarkcomplete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | **string**| The action item to assign. |
 **assignee** | [**string**](../Model/.md)| The assignee of the item. | [optional]
 **group** | [**string**](../Model/.md)| The group to assing the item. | [optional]
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


## actionassignmentSave

> actionassignmentSave($unknown_base_type)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->actionassignmentSave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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


## actionassignmentSavehistory

> actionassignmentSavehistory($unknown_base_type)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionassignmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->actionassignmentSavehistory($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling ActionassignmentApi->actionassignmentSavehistory: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

