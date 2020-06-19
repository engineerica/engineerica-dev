# OpenAPI\Client\SessionattendancelogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionattendancelogAddnote**](SessionattendancelogApi.md#sessionattendancelogAddnote) | **GET** /sessionattendancelog/addnote | Add a note to a class attendance log
[**sessionattendancelogGet**](SessionattendancelogApi.md#sessionattendancelogGet) | **GET** /sessionattendancelog/{id} | View details of a class attendance log
[**sessionattendancelogGetuser**](SessionattendancelogApi.md#sessionattendancelogGetuser) | **GET** /sessionattendancelog/getuser | View the class session attendance information for a specific user
[**sessionattendancelogList**](SessionattendancelogApi.md#sessionattendancelogList) | **GET** /sessionattendancelog/list | View attendance logs of the specified session
[**sessionattendancelogListevent**](SessionattendancelogApi.md#sessionattendancelogListevent) | **GET** /sessionattendancelog/listevent | View the attendance information of an entire class
[**sessionattendancelogListsummary**](SessionattendancelogApi.md#sessionattendancelogListsummary) | **GET** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
[**sessionattendancelogMylistsummary**](SessionattendancelogApi.md#sessionattendancelogMylistsummary) | **GET** /sessionattendancelog/mylistsummary | View my attendance summary
[**sessionattendancelogSave**](SessionattendancelogApi.md#sessionattendancelogSave) | **POST** /sessionattendancelog/{id} | Create or edit a class attendance log
[**sessionattendancelogSaveswipe**](SessionattendancelogApi.md#sessionattendancelogSaveswipe) | **POST** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe



## sessionattendancelogAddnote

> sessionattendancelogAddnote($id, $text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the attendance log.
$text = 'text_example'; // string | The text of the note to add.

try {
    $apiInstance->sessionattendancelogAddnote($id, $text);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogAddnote: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the attendance log. |
 **text** | **string**| The text of the note to add. |

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


## sessionattendancelogGet

> sessionattendancelogGet($id, $photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the attendance log to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->sessionattendancelogGet($id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the attendance log to get. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional]

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


## sessionattendancelogGetuser

> sessionattendancelogGetuser($attendee, $eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$attendee = 'attendee_example'; // string | The id of the attendee to get statistic for.
$eventid = 'eventid_example'; // string | The id of the event whose attendee statistics have to be returned.

try {
    $apiInstance->sessionattendancelogGetuser($attendee, $eventid);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogGetuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**string**](../Model/.md)| The id of the attendee to get statistic for. |
 **eventid** | [**string**](../Model/.md)| The id of the event whose attendee statistics have to be returned. |

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


## sessionattendancelogList

> sessionattendancelogList($session, $from, $count, $photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$session = 'session_example'; // string | The id of the session whose attendees logs have to be returned.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->sessionattendancelogList($session, $from, $count, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **session** | [**string**](../Model/.md)| The id of the session whose attendees logs have to be returned. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
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


## sessionattendancelogListevent

> sessionattendancelogListevent($eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event whose attendance has to be returned.

try {
    $apiInstance->sessionattendancelogListevent($eventid);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogListevent: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event whose attendance has to be returned. |

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


## sessionattendancelogListsummary

> sessionattendancelogListsummary($eventid, $attendeeid, $groupid, $start, $end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event whose attendance has to be returned.
$attendeeid = 'attendeeid_example'; // string | The id of the attendee whose attendance has to be returned.
$groupid = 'groupid_example'; // string | The id of the group whose attendance has to be returned.
$start = 'start_example'; // string | The start date to filter (beginning of time by default).
$end = 'end_example'; // string | The end date to filter (today by default).

try {
    $apiInstance->sessionattendancelogListsummary($eventid, $attendeeid, $groupid, $start, $end);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogListsummary: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event whose attendance has to be returned. | [optional]
 **attendeeid** | [**string**](../Model/.md)| The id of the attendee whose attendance has to be returned. | [optional]
 **groupid** | [**string**](../Model/.md)| The id of the group whose attendance has to be returned. | [optional]
 **start** | **string**| The start date to filter (beginning of time by default). | [optional]
 **end** | **string**| The end date to filter (today by default). | [optional]

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


## sessionattendancelogMylistsummary

> sessionattendancelogMylistsummary($eventid, $start, $end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event whose attendance has to be returned.
$start = 'start_example'; // string | The start date to filter (beginning of time by default).
$end = 'end_example'; // string | The end date to filter (today by default).

try {
    $apiInstance->sessionattendancelogMylistsummary($eventid, $start, $end);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogMylistsummary: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event whose attendance has to be returned. | [optional]
 **start** | **string**| The start date to filter (beginning of time by default). | [optional]
 **end** | **string**| The end date to filter (today by default). | [optional]

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


## sessionattendancelogSave

> sessionattendancelogSave($id, $unknown_base_type)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the att log to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->sessionattendancelogSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the att log to save (leave empty to create a new one). |
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


## sessionattendancelogSaveswipe

> sessionattendancelogSaveswipe($unknown_base_type)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionattendancelogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->sessionattendancelogSaveswipe($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling SessionattendancelogApi->sessionattendancelogSaveswipe: ', $e->getMessage(), PHP_EOL;
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

