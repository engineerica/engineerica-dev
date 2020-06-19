# OpenAPI\Client\ScheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**scheduleDelete**](ScheduleApi.md#scheduleDelete) | **DELETE** /schedule/delete | Delete a schedule slot
[**scheduleDeletemine**](ScheduleApi.md#scheduleDeletemine) | **DELETE** /schedule/deletemine | Delete a specific block from a user&#39;s own schedule
[**scheduleEnable**](ScheduleApi.md#scheduleEnable) | **GET** /schedule/enable | Enable or disable the schedule for a specific person
[**scheduleEnablemine**](ScheduleApi.md#scheduleEnablemine) | **GET** /schedule/enablemine | Enable or disable current user&#39;s schedule
[**scheduleFindallstaffslots**](ScheduleApi.md#scheduleFindallstaffslots) | **GET** /schedule/findallstaffslots | Search available schedule slots by service, event, date
[**scheduleFindslots**](ScheduleApi.md#scheduleFindslots) | **GET** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
[**scheduleFindstaffavail**](ScheduleApi.md#scheduleFindstaffavail) | **GET** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
[**scheduleGet**](ScheduleApi.md#scheduleGet) | **GET** /schedule/get | Search and view details of a specific schedule slot
[**scheduleGetmine**](ScheduleApi.md#scheduleGetmine) | **GET** /schedule/getmine | View details of a specific schedule block, for current user
[**scheduleGetstaff**](ScheduleApi.md#scheduleGetstaff) | **GET** /schedule/getstaff | View a list of schedule information of a specified person
[**scheduleGetstaffmine**](ScheduleApi.md#scheduleGetstaffmine) | **GET** /schedule/getstaffmine | View current user&#39;s schedule information
[**scheduleMyofftimes**](ScheduleApi.md#scheduleMyofftimes) | **GET** /schedule/myofftimes | View current user&#39;s schedule exceptions
[**scheduleSave**](ScheduleApi.md#scheduleSave) | **POST** /schedule/save | Create or edit a schedule slot
[**scheduleSavemine**](ScheduleApi.md#scheduleSavemine) | **POST** /schedule/savemine | Create or edit a block in current user&#39;s schedule



## scheduleDelete

> scheduleDelete($unknown_base_type)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->scheduleDelete($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleDelete: ', $e->getMessage(), PHP_EOL;
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


## scheduleDeletemine

> scheduleDeletemine($unknown_base_type)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->scheduleDeletemine($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleDeletemine: ', $e->getMessage(), PHP_EOL;
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


## scheduleEnable

> scheduleEnable($userid, $enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to enable or disable the schedule.
$enable = True; // bool | True to enable schedules, false to disable.

try {
    $apiInstance->scheduleEnable($userid, $enable);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleEnable: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to enable or disable the schedule. |
 **enable** | **bool**| True to enable schedules, false to disable. |

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


## scheduleEnablemine

> scheduleEnablemine($enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$enable = True; // bool | True to enable schedules, false to disable.

try {
    $apiInstance->scheduleEnablemine($enable);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleEnablemine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enable** | **bool**| True to enable schedules, false to disable. |

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


## scheduleFindallstaffslots

> scheduleFindallstaffslots($starttime, $endtime, $staffid, $serviceids, $eventid, $locationid, $staffroleids, $availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$staffid = 'staffid_example'; // string | The id of the staff to filter by.
$serviceids = 'serviceids_example'; // string | CSV list of the service Ids to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the location to filter by.
$staffroleids = 'staffroleids_example'; // string | CSV list of the staff member role ids to filter by.
$availablefor = 'availablefor_example'; // string | The specific availability type to filter by.

try {
    $apiInstance->scheduleFindallstaffslots($starttime, $endtime, $staffid, $serviceids, $eventid, $locationid, $staffroleids, $availablefor);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleFindallstaffslots: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **staffid** | [**string**](../Model/.md)| The id of the staff to filter by. | [optional]
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the location to filter by. | [optional]
 **staffroleids** | **string**| CSV list of the staff member role ids to filter by. | [optional]
 **availablefor** | **string**| The specific availability type to filter by. | [optional]

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


## scheduleFindslots

> scheduleFindslots($staffid, $starttime, $endtime, $serviceids, $eventid, $locationid, $availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$staffid = 'staffid_example'; // string | The id of the staff to filter by.
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$serviceids = 'serviceids_example'; // string | CSV list of the service Ids to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.
$availablefor = 'availablefor_example'; // string | The specific availability type to filter by.

try {
    $apiInstance->scheduleFindslots($staffid, $starttime, $endtime, $serviceids, $eventid, $locationid, $availablefor);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleFindslots: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**string**](../Model/.md)| The id of the staff to filter by. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. | [optional]
 **availablefor** | **string**| The specific availability type to filter by. | [optional]

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


## scheduleFindstaffavail

> scheduleFindstaffavail($starttime, $endtime, $serviceids, $eventid, $locationid, $staffroleids, $availablefor, $photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$serviceids = 'serviceids_example'; // string | CSV list of the service ids to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.
$staffroleids = 'staffroleids_example'; // string | CSV list of the staff member role ids to filter by.
$availablefor = 'availablefor_example'; // string | Filter slots by a specific availability type.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->scheduleFindstaffavail($starttime, $endtime, $serviceids, $eventid, $locationid, $staffroleids, $availablefor, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleFindstaffavail: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **serviceids** | **string**| CSV list of the service ids to filter by. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. | [optional]
 **staffroleids** | **string**| CSV list of the staff member role ids to filter by. | [optional]
 **availablefor** | **string**| Filter slots by a specific availability type. | [optional]
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


## scheduleGet

> scheduleGet($scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$scheduleid = 'scheduleid_example'; // string | The id of the schedule.

try {
    $apiInstance->scheduleGet($scheduleid);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**string**](../Model/.md)| The id of the schedule. |

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


## scheduleGetmine

> scheduleGetmine($scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$scheduleid = 'scheduleid_example'; // string | The id of the schedule.

try {
    $apiInstance->scheduleGetmine($scheduleid);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleGetmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**string**](../Model/.md)| The id of the schedule. |

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


## scheduleGetstaff

> scheduleGetstaff($userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to get info.

try {
    $apiInstance->scheduleGetstaff($userid);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleGetstaff: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to get info. |

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


## scheduleGetstaffmine

> scheduleGetstaffmine()

View current user's schedule information

Allows the user to view their own schedule.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->scheduleGetstaffmine();
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleGetstaffmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

This endpoint does not need any parameter.

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


## scheduleMyofftimes

> scheduleMyofftimes($includedeleted, $onlyupcoming, $modifiedafter)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$includedeleted = True; // bool | If true the deleted offtimes are also returned.
$onlyupcoming = True; // bool | If true then only upcoming offtimes are returned.
$modifiedafter = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only offtimes modified after the specified date will be returned.

try {
    $apiInstance->scheduleMyofftimes($includedeleted, $onlyupcoming, $modifiedafter);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleMyofftimes: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includedeleted** | **bool**| If true the deleted offtimes are also returned. | [optional]
 **onlyupcoming** | **bool**| If true then only upcoming offtimes are returned. | [optional]
 **modifiedafter** | **\DateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional]

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


## scheduleSave

> scheduleSave($unknown_base_type)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->scheduleSave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleSave: ', $e->getMessage(), PHP_EOL;
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


## scheduleSavemine

> scheduleSavemine($unknown_base_type)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ScheduleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->scheduleSavemine($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling ScheduleApi->scheduleSavemine: ', $e->getMessage(), PHP_EOL;
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

