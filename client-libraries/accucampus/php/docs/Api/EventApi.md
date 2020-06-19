# OpenAPI\Client\EventApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventChecksessions**](EventApi.md#eventChecksessions) | **GET** /event/checksessions | Edit an event&#39;s sessions according to their schedule
[**eventDelete**](EventApi.md#eventDelete) | **DELETE** /event/{id} | Delete a course
[**eventGet**](EventApi.md#eventGet) | **GET** /event/{id} | Search and view details of a course
[**eventGetsessionsbydate**](EventApi.md#eventGetsessionsbydate) | **GET** /event/getsessionsbydate | View a list of courses by date
[**eventList**](EventApi.md#eventList) | **GET** /event/list | View a list of courses
[**eventListregistered**](EventApi.md#eventListregistered) | **GET** /event/listregistered | View a list of courses I am registered to
[**eventSave**](EventApi.md#eventSave) | **POST** /event/{id} | Create or edit a course
[**eventSearchgroup**](EventApi.md#eventSearchgroup) | **GET** /event/searchgroup | Searches for the available event groups



## eventChecksessions

> eventChecksessions($eventid, $autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event to check.
$autorepair = True; // bool | True to automatically fix the invalid sessions.

try {
    $apiInstance->eventChecksessions($eventid, $autorepair);
} catch (Exception $e) {
    echo 'Exception when calling EventApi->eventChecksessions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event to check. |
 **autorepair** | **bool**| True to automatically fix the invalid sessions. |

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


## eventDelete

> eventDelete($id, $body)

Delete a course

Allows the user to delete an existing course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the event to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->eventDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling EventApi->eventDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the event to delete. |
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


## eventGet

> eventGet($id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the event to get.

try {
    $apiInstance->eventGet($id);
} catch (Exception $e) {
    echo 'Exception when calling EventApi->eventGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the event to get. |

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


## eventGetsessionsbydate

> eventGetsessionsbydate($location, $date, $type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$location = 'location_example'; // string | The location to filter the events.
$date = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date to filter the events. Today will be used if this parameter is omitted.
$type = 'type_example'; // string | Type of event to list.

try {
    $apiInstance->eventGetsessionsbydate($location, $date, $type);
} catch (Exception $e) {
    echo 'Exception when calling EventApi->eventGetsessionsbydate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**string**](../Model/.md)| The location to filter the events. | [optional]
 **date** | **\DateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional]
 **type** | **string**| Type of event to list. | [optional]

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


## eventList

> eventList($from, $count, $summaryonly, $termid)

View a list of courses

Allows the user to view the full list of courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 'from_example'; // string | The first record to return.
$count = 'count_example'; // string | The max number of records to return.
$summaryonly = True; // bool | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
$termid = 'termid_example'; // string | Id of the term to list the events. Null to list all events.

try {
    $apiInstance->eventList($from, $count, $summaryonly, $termid);
} catch (Exception $e) {
    echo 'Exception when calling EventApi->eventList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**| The first record to return. |
 **count** | **string**| The max number of records to return. |
 **summaryonly** | **bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**string**](../Model/.md)| Id of the term to list the events. Null to list all events. | [optional]

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


## eventListregistered

> eventListregistered($from, $count, $summaryonly, $termid)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 'from_example'; // string | The first record to return.
$count = 'count_example'; // string | The max number of records to return.
$summaryonly = True; // bool | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
$termid = 'termid_example'; // string | Id of the term to list the events. Null to list all events.

try {
    $apiInstance->eventListregistered($from, $count, $summaryonly, $termid);
} catch (Exception $e) {
    echo 'Exception when calling EventApi->eventListregistered: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**| The first record to return. |
 **count** | **string**| The max number of records to return. |
 **summaryonly** | **bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**string**](../Model/.md)| Id of the term to list the events. Null to list all events. | [optional]

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


## eventSave

> eventSave($id, $unknown_base_type)

Create or edit a course

Allows the user to create or edit a course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the event to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->eventSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling EventApi->eventSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the event to save (leave empty to create a new one). |
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


## eventSearchgroup

> eventSearchgroup($query)

Searches for the available event groups

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$query = 'query_example'; // string | Query to search event groups.

try {
    $apiInstance->eventSearchgroup($query);
} catch (Exception $e) {
    echo 'Exception when calling EventApi->eventSearchgroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**string**](../Model/.md)| Query to search event groups. |

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

