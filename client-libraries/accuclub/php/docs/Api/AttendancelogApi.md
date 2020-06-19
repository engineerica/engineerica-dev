# OpenAPI\Client\AttendancelogApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogDelete**](AttendancelogApi.md#attendancelogDelete) | **DELETE** /attendancelog/{id} | Delete an attendance log
[**attendancelogGet**](AttendancelogApi.md#attendancelogGet) | **GET** /attendancelog/{id} | Search and view details of an attendance log
[**attendancelogGetchangehistory**](AttendancelogApi.md#attendancelogGetchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log&#39;s swipe history
[**attendancelogList**](AttendancelogApi.md#attendancelogList) | **GET** /attendancelog/list | View a list of attendance logs
[**attendancelogListmine**](AttendancelogApi.md#attendancelogListmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
[**attendancelogSave**](AttendancelogApi.md#attendancelogSave) | **POST** /attendancelog/{id} | Create or edit an attendance log
[**attendancelogSignout**](AttendancelogApi.md#attendancelogSignout) | **GET** /attendancelog/signout | Sign out an attendance log
[**attendancelogWhosin**](AttendancelogApi.md#attendancelogWhosin) | **GET** /attendancelog/whosin | View who&#39;s in a location



## attendancelogDelete

> attendancelogDelete($id, $body)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AttendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the attendance log to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->attendancelogDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling AttendancelogApi->attendancelogDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the attendance log to delete. |
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


## attendancelogGet

> attendancelogGet($id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AttendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the attendance log to get.

try {
    $apiInstance->attendancelogGet($id);
} catch (Exception $e) {
    echo 'Exception when calling AttendancelogApi->attendancelogGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the attendance log to get. |

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


## attendancelogGetchangehistory

> attendancelogGetchangehistory($id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AttendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the attendance log to get.

try {
    $apiInstance->attendancelogGetchangehistory($id);
} catch (Exception $e) {
    echo 'Exception when calling AttendancelogApi->attendancelogGetchangehistory: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the attendance log to get. |

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


## attendancelogList

> attendancelogList($from, $count, $filter, $userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AttendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$filter = 'filter_example'; // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
$userid = 'userid_example'; // string | The user ID of the user to get the logs.

try {
    $apiInstance->attendancelogList($from, $count, $filter, $userid);
} catch (Exception $e) {
    echo 'Exception when calling AttendancelogApi->attendancelogList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]
 **userid** | [**string**](../Model/.md)| The user ID of the user to get the logs. | [optional]

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


## attendancelogListmine

> attendancelogListmine($from, $count, $filter)

Gets the attendance logs of the current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AttendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$filter = 'filter_example'; // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.

try {
    $apiInstance->attendancelogListmine($from, $count, $filter);
} catch (Exception $e) {
    echo 'Exception when calling AttendancelogApi->attendancelogListmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]

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


## attendancelogSave

> attendancelogSave($id, $unknown_base_type)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AttendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the room to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->attendancelogSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling AttendancelogApi->attendancelogSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the room to save (leave empty to create a new one). |
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


## attendancelogSignout

> attendancelogSignout($id, $location, $event, $datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AttendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the attendance log to sign-out.
$location = 'location_example'; // string | The id of the location to filter the users to sign out.
$event = 'event_example'; // string | The id of the event to filter the users to sign out.
$datetime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | Specifies the date and time when the specified logs have to be signed out.

try {
    $apiInstance->attendancelogSignout($id, $location, $event, $datetime);
} catch (Exception $e) {
    echo 'Exception when calling AttendancelogApi->attendancelogSignout: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the attendance log to sign-out. | [optional]
 **location** | [**string**](../Model/.md)| The id of the location to filter the users to sign out. | [optional]
 **event** | [**string**](../Model/.md)| The id of the event to filter the users to sign out. | [optional]
 **datetime** | **\DateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional]

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


## attendancelogWhosin

> attendancelogWhosin($from, $count, $location, $event, $sorting, $roles, $photosize, $extensions, $export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AttendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$location = 'location_example'; // string | The id of the location to search for users that are in.
$event = 'event_example'; // string | The id of the event to search for users that are in.
$sorting = 'sorting_example'; // string | Field to sort by. Either first-name, last-name or sign-in-time.
$roles = 'roles_example'; // string | The comma-separated list of ids of the roles to search for users that are in.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
$extensions = 'extensions_example'; // string | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
$export = True; // bool | True to export the results as CSV

try {
    $apiInstance->attendancelogWhosin($from, $count, $location, $event, $sorting, $roles, $photosize, $extensions, $export);
} catch (Exception $e) {
    echo 'Exception when calling AttendancelogApi->attendancelogWhosin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **location** | [**string**](../Model/.md)| The id of the location to search for users that are in. | [optional]
 **event** | [**string**](../Model/.md)| The id of the event to search for users that are in. | [optional]
 **sorting** | **string**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional]
 **roles** | **string**| The comma-separated list of ids of the roles to search for users that are in. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **extensions** | **string**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional]
 **export** | **bool**| True to export the results as CSV | [optional]

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

