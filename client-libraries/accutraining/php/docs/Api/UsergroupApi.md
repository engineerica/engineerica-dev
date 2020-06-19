# OpenAPI\Client\UsergroupApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usergroupAddmember**](UsergroupApi.md#usergroupAddmember) | **GET** /usergroup/addmember | Add a user to a group
[**usergroupDelete**](UsergroupApi.md#usergroupDelete) | **DELETE** /usergroup/{id} | Delete a group
[**usergroupGet**](UsergroupApi.md#usergroupGet) | **GET** /usergroup/{id} | Search and view details of a user group
[**usergroupGetmembers**](UsergroupApi.md#usergroupGetmembers) | **GET** /usergroup/getmembers | View the members of a user group
[**usergroupGetuser**](UsergroupApi.md#usergroupGetuser) | **GET** /usergroup/getuser | View the groups which a user is registered to
[**usergroupList**](UsergroupApi.md#usergroupList) | **GET** /usergroup/list | View a list of user groups
[**usergroupRefresh**](UsergroupApi.md#usergroupRefresh) | **GET** /usergroup/refresh | Refresh the dynamic group
[**usergroupRemovemember**](UsergroupApi.md#usergroupRemovemember) | **GET** /usergroup/removemember | Remove a user from a group
[**usergroupSave**](UsergroupApi.md#usergroupSave) | **POST** /usergroup/{id} | Create or edit a group



## usergroupAddmember

> usergroupAddmember($userid, $groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to add.
$groupid = 'groupid_example'; // string | The id of the group.

try {
    $apiInstance->usergroupAddmember($userid, $groupid);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupAddmember: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **groupid** | [**string**](../Model/.md)| The id of the group. |

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


## usergroupDelete

> usergroupDelete($id, $body)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the group to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->usergroupDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the group to delete. |
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


## usergroupGet

> usergroupGet($id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the user group to get.

try {
    $apiInstance->usergroupGet($id);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the user group to get. |

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


## usergroupGetmembers

> usergroupGetmembers($groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$groupid = 'groupid_example'; // string | The id of the user group to get.

try {
    $apiInstance->usergroupGetmembers($groupid);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupGetmembers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | [**string**](../Model/.md)| The id of the user group to get. |

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


## usergroupGetuser

> usergroupGetuser($userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to get his groups.

try {
    $apiInstance->usergroupGetuser($userid);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupGetuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to get his groups. |

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


## usergroupList

> usergroupList($from, $count, $type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$type = 'type_example'; // string | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.

try {
    $apiInstance->usergroupList($from, $count, $type);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | [optional]
 **count** | **int**| The max number of records to return. | [optional]
 **type** | **string**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional]

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


## usergroupRefresh

> usergroupRefresh($group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$group = 'group_example'; // string | The ID of the group to refresh.

try {
    $apiInstance->usergroupRefresh($group);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupRefresh: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**string**](../Model/.md)| The ID of the group to refresh. |

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


## usergroupRemovemember

> usergroupRemovemember($userid, $groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to remove.
$groupid = 'groupid_example'; // string | The id of the group.

try {
    $apiInstance->usergroupRemovemember($userid, $groupid);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupRemovemember: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **groupid** | [**string**](../Model/.md)| The id of the group. |

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


## usergroupSave

> usergroupSave($id, $unknown_base_type)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UsergroupApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the group to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->usergroupSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling UsergroupApi->usergroupSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the group to save (leave empty to create a new one). |
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

