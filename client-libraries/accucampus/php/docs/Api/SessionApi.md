# OpenAPI\Client\SessionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionBulkupdate**](SessionApi.md#sessionBulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
[**sessionGet**](SessionApi.md#sessionGet) | **GET** /session/{id} | View details of a session
[**sessionGetschedule**](SessionApi.md#sessionGetschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**sessionList**](SessionApi.md#sessionList) | **GET** /session/list | Gets all future sessions of the current semester



## sessionBulkupdate

> sessionBulkupdate($eventid, $sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event to bulk update.
$sessions = 'sessions_example'; // string | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

try {
    $apiInstance->sessionBulkupdate($eventid, $sessions);
} catch (Exception $e) {
    echo 'Exception when calling SessionApi->sessionBulkupdate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event to bulk update. |
 **sessions** | **string**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. |

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


## sessionGet

> sessionGet($id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the session to get.

try {
    $apiInstance->sessionGet($id);
} catch (Exception $e) {
    echo 'Exception when calling SessionApi->sessionGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the session to get. |

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


## sessionGetschedule

> sessionGetschedule($day, $attendee, $location, $instructor)

Gets the schedule for a location, instructor or attendees

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$day = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The day to return. It will also return the whole week for that day.
$attendee = 'attendee_example'; // string | The id of the attendee to get the schedule.
$location = 'location_example'; // string | The id of the location to get the schedule.
$instructor = 'instructor_example'; // string | The id of the instructor to get the schedule.

try {
    $apiInstance->sessionGetschedule($day, $attendee, $location, $instructor);
} catch (Exception $e) {
    echo 'Exception when calling SessionApi->sessionGetschedule: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **day** | **\DateTime**| The day to return. It will also return the whole week for that day. | [optional]
 **attendee** | [**string**](../Model/.md)| The id of the attendee to get the schedule. | [optional]
 **location** | [**string**](../Model/.md)| The id of the location to get the schedule. | [optional]
 **instructor** | [**string**](../Model/.md)| The id of the instructor to get the schedule. | [optional]

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


## sessionList

> sessionList($from, $count, $startdate, $enddate)

Gets all future sessions of the current semester

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date to filter the sessions
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date to filter the sessions.

try {
    $apiInstance->sessionList($from, $count, $startdate, $enddate);
} catch (Exception $e) {
    echo 'Exception when calling SessionApi->sessionList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **startdate** | **\DateTime**| The start date to filter the sessions | [optional]
 **enddate** | **\DateTime**| The end date to filter the sessions. | [optional]

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

