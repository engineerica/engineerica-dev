# OpenAPI\Client\AppointmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appointmentCancel**](AppointmentApi.md#appointmentCancel) | **GET** /appointment/cancel | Cancel an appointment
[**appointmentCheckisvalid**](AppointmentApi.md#appointmentCheckisvalid) | **GET** /appointment/checkisvalid | Check if an appointment is valid or not
[**appointmentEditanyway**](AppointmentApi.md#appointmentEditanyway) | **GET** /appointment/editanyway | Edit an appointment even if it breaks activated rules
[**appointmentEditpresence**](AppointmentApi.md#appointmentEditpresence) | **GET** /appointment/editpresence | Edit the no-show status of an appointment
[**appointmentFindallstaffslots**](AppointmentApi.md#appointmentFindallstaffslots) | **GET** /appointment/findallstaffslots | Finds all staff available slots filtered by service, date, etc
[**appointmentFindslots**](AppointmentApi.md#appointmentFindslots) | **GET** /appointment/findslots | Finds available slots filtered by service, date, staff, etc
[**appointmentFindstaff**](AppointmentApi.md#appointmentFindstaff) | **GET** /appointment/findstaff | Finds staff available by service, date, event, etc
[**appointmentGet**](AppointmentApi.md#appointmentGet) | **GET** /appointment/{id} | Search and view details of an appointment
[**appointmentGetcurrent**](AppointmentApi.md#appointmentGetcurrent) | **GET** /appointment/getcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**appointmentGetlocations**](AppointmentApi.md#appointmentGetlocations) | **GET** /appointment/getlocations | Find locations where a service is available
[**appointmentList**](AppointmentApi.md#appointmentList) | **GET** /appointment/list | View a list of appointments
[**appointmentListmine**](AppointmentApi.md#appointmentListmine) | **GET** /appointment/listmine | View all my upcoming appointments
[**appointmentListupcoming**](AppointmentApi.md#appointmentListupcoming) | **GET** /appointment/listupcoming | Search and view details of all my upcoming appointments
[**appointmentRescheduleoutlook**](AppointmentApi.md#appointmentRescheduleoutlook) | **GET** /appointment/rescheduleoutlook | Reschedule an appointment from MS Outlook.
[**appointmentRestore**](AppointmentApi.md#appointmentRestore) | **GET** /appointment/restore | Restore an appointment
[**appointmentRestoreanyway**](AppointmentApi.md#appointmentRestoreanyway) | **GET** /appointment/restoreanyway | Restore an appointment even if it breaks activated rules
[**appointmentSave**](AppointmentApi.md#appointmentSave) | **POST** /appointment/{id} | Schedule an appointment
[**appointmentSetasvalid**](AppointmentApi.md#appointmentSetasvalid) | **GET** /appointment/setasvalid | Schedule an appointment even if it breaks activated rules
[**appointmentSuggestlocations**](AppointmentApi.md#appointmentSuggestlocations) | **GET** /appointment/suggestlocations | View the locations with most appointments
[**appointmentSuggestservices**](AppointmentApi.md#appointmentSuggestservices) | **GET** /appointment/suggestservices | View the services with most appointments
[**appointmentVoid**](AppointmentApi.md#appointmentVoid) | **GET** /appointment/void | Void an appointment



## appointmentCancel

> appointmentCancel($id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to cancel.

try {
    $apiInstance->appointmentCancel($id);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentCancel: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to cancel. |

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


## appointmentCheckisvalid

> appointmentCheckisvalid($id, $editing)

Check if an appointment is valid or not

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to check.
$editing = True; // bool | Specifies whether the check is for a new appointment or an existing one.

try {
    $apiInstance->appointmentCheckisvalid($id, $editing);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentCheckisvalid: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to check. |
 **editing** | **bool**| Specifies whether the check is for a new appointment or an existing one. | [optional]

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


## appointmentEditanyway

> appointmentEditanyway($id, $attendee, $staff, $location, $start, $end, $term, $event, $services, $notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to edit.
$attendee = 'attendee_example'; // string | The id of the attendee involved in the appointment.
$staff = 'staff_example'; // string | The id of the staff member involved in the appointment.
$location = 'location_example'; // string | The id of the location where the appointment will take place.
$start = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The appointment's start date & time.
$end = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The appointment's end date & time.
$term = 'term_example'; // string | The id of the term when the appointment takes place.
$event = 'event_example'; // string | The id of the event of the appointment.
$services = 'services_example'; // string | Comma-separated string containing the ids of the services of the appointment.
$notes = 'notes_example'; // string | The notes of the appointment.

try {
    $apiInstance->appointmentEditanyway($id, $attendee, $staff, $location, $start, $end, $term, $event, $services, $notes);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentEditanyway: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to edit. |
 **attendee** | [**string**](../Model/.md)| The id of the attendee involved in the appointment. |
 **staff** | [**string**](../Model/.md)| The id of the staff member involved in the appointment. |
 **location** | [**string**](../Model/.md)| The id of the location where the appointment will take place. |
 **start** | **\DateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **\DateTime**| The appointment&#39;s end date &amp; time. |
 **term** | [**string**](../Model/.md)| The id of the term when the appointment takes place. | [optional]
 **event** | [**string**](../Model/.md)| The id of the event of the appointment. | [optional]
 **services** | **string**| Comma-separated string containing the ids of the services of the appointment. | [optional]
 **notes** | **string**| The notes of the appointment. | [optional]

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


## appointmentEditpresence

> appointmentEditpresence($id, $showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to edit its presence.
$showedup = True; // bool | Specifies whether the attendee was showed-up or not in the appointment.

try {
    $apiInstance->appointmentEditpresence($id, $showedup);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentEditpresence: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to edit its presence. |
 **showedup** | **bool**| Specifies whether the attendee was showed-up or not in the appointment. |

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


## appointmentFindallstaffslots

> appointmentFindallstaffslots($starttime, $endtime, $serviceids, $locationid, $eventid, $photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$serviceids = 'serviceids_example'; // string | CSV list of the service Ids to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->appointmentFindallstaffslots($starttime, $endtime, $serviceids, $locationid, $eventid, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentFindallstaffslots: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **serviceids** | **string**| CSV list of the service Ids to filter by. |
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. |
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
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


## appointmentFindslots

> appointmentFindslots($staffid, $starttime, $endtime, $serviceids, $eventid, $locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
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

try {
    $apiInstance->appointmentFindslots($staffid, $starttime, $endtime, $serviceids, $eventid, $locationid);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentFindslots: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**string**](../Model/.md)| The id of the staff to filter by. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **serviceids** | **string**| CSV list of the service Ids to filter by. |
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. | [optional]

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


## appointmentFindstaff

> appointmentFindstaff($serviceids, $starttime, $endtime, $eventid, $locationid, $photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceids = 'serviceids_example'; // string | CSV list of the service ids to filter by.
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->appointmentFindstaff($serviceids, $starttime, $endtime, $eventid, $locationid, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentFindstaff: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceids** | **string**| CSV list of the service ids to filter by. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. | [optional]
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


## appointmentGet

> appointmentGet($id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to get.

try {
    $apiInstance->appointmentGet($id);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to get. |

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


## appointmentGetcurrent

> appointmentGetcurrent($station, $user, $location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location where the user wants to sign-in.

try {
    $apiInstance->appointmentGetcurrent($station, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentGetcurrent: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location where the user wants to sign-in. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentGetlocations

> appointmentGetlocations($serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceid = 'serviceid_example'; // string | The id of the service to get its locations.

try {
    $apiInstance->appointmentGetlocations($serviceid);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentGetlocations: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](../Model/.md)| The id of the service to get its locations. |

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


## appointmentList

> appointmentList($from, $count, $startdate, $enddate, $userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the appointments.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the appointments.
$userid = 'userid_example'; // string | The attendee id to filter the appointments.

try {
    $apiInstance->appointmentList($from, $count, $startdate, $enddate, $userid);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **startdate** | **\DateTime**| The start date of the period to filter the appointments. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the appointments. | [optional]
 **userid** | [**string**](../Model/.md)| The attendee id to filter the appointments. | [optional]

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


## appointmentListmine

> appointmentListmine($start, $modifiedafter)

View all my upcoming appointments

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$start = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only appointments that start after the specified date will be returned.
$modifiedafter = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only appointments modified after the specified date will be returned.

try {
    $apiInstance->appointmentListmine($start, $modifiedafter);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentListmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **\DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **\DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

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


## appointmentListupcoming

> appointmentListupcoming($start, $modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$start = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only appointments that start after the specified date will be returned.
$modifiedafter = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only appointments modified after the specified date will be returned.

try {
    $apiInstance->appointmentListupcoming($start, $modifiedafter);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentListupcoming: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **\DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **\DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

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


## appointmentRescheduleoutlook

> appointmentRescheduleoutlook($id, $start, $end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to edit.
$start = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The appointment's start date & time.
$end = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The appointment's end date & time.

try {
    $apiInstance->appointmentRescheduleoutlook($id, $start, $end);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentRescheduleoutlook: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to edit. |
 **start** | **\DateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **\DateTime**| The appointment&#39;s end date &amp; time. |

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


## appointmentRestore

> appointmentRestore($id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to restore.

try {
    $apiInstance->appointmentRestore($id);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentRestore: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to restore. |

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


## appointmentRestoreanyway

> appointmentRestoreanyway($id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to restore.

try {
    $apiInstance->appointmentRestoreanyway($id);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentRestoreanyway: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to restore. |

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


## appointmentSave

> appointmentSave($id, $unknown_base_type)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->appointmentSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to save (leave empty to create a new one). |
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


## appointmentSetasvalid

> appointmentSetasvalid($id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to set as valid.

try {
    $apiInstance->appointmentSetasvalid($id);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentSetasvalid: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to set as valid. |

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


## appointmentSuggestlocations

> appointmentSuggestlocations()

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->appointmentSuggestlocations();
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentSuggestlocations: ', $e->getMessage(), PHP_EOL;
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


## appointmentSuggestservices

> appointmentSuggestservices()

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->appointmentSuggestservices();
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentSuggestservices: ', $e->getMessage(), PHP_EOL;
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


## appointmentVoid

> appointmentVoid($id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AppointmentApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the appointment to cancel.

try {
    $apiInstance->appointmentVoid($id);
} catch (Exception $e) {
    echo 'Exception when calling AppointmentApi->appointmentVoid: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the appointment to cancel. |

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

