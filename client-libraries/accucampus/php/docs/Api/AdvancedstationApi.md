# OpenAPI\Client\AdvancedstationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advancedstationCheckunknownuser**](AdvancedstationApi.md#advancedstationCheckunknownuser) | **GET** /advancedstation/checkunknownuser | Check whether the user is known by the system.
[**advancedstationCheckuserrole**](AdvancedstationApi.md#advancedstationCheckuserrole) | **GET** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
[**advancedstationCreateuser**](AdvancedstationApi.md#advancedstationCreateuser) | **GET** /advancedstation/createuser | Creates a user via a sign-in station.
[**advancedstationGetevents**](AdvancedstationApi.md#advancedstationGetevents) | **GET** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
[**advancedstationGetinfo**](AdvancedstationApi.md#advancedstationGetinfo) | **GET** /advancedstation/getinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**advancedstationGetlocations**](AdvancedstationApi.md#advancedstationGetlocations) | **GET** /advancedstation/getlocations | Gets the locations available in a sign-in station.
[**advancedstationGetlogstaff**](AdvancedstationApi.md#advancedstationGetlogstaff) | **GET** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**advancedstationGetroles**](AdvancedstationApi.md#advancedstationGetroles) | **GET** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
[**advancedstationGetservices**](AdvancedstationApi.md#advancedstationGetservices) | **GET** /advancedstation/getservices | Gets the services available for a specific location.
[**advancedstationGetstaff**](AdvancedstationApi.md#advancedstationGetstaff) | **GET** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
[**advancedstationIssignedin**](AdvancedstationApi.md#advancedstationIssignedin) | **GET** /advancedstation/issignedin | Gets whether a user is signed-in or not.



## advancedstationCheckunknownuser

> advancedstationCheckunknownuser($station, $user, $location)

Check whether the user is known by the system.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->advancedstationCheckunknownuser($station, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationCheckunknownuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. |

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


## advancedstationCheckuserrole

> advancedstationCheckuserrole($station, $user, $location)

Check whether the user is a staff member, an attendee or both.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->advancedstationCheckuserrole($station, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationCheckuserrole: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. |

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


## advancedstationCreateuser

> advancedstationCreateuser($station, $user, $location, $firstname, $lastname, $email, $middlename)

Creates a user via a sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user to create.
$location = 'location_example'; // string | The id of the location the user picked.
$firstname = 'firstname_example'; // string | The first name of the user to create.
$lastname = 'lastname_example'; // string | The last name of the user to create.
$email = 'email_example'; // string | The email of the user to create.
$middlename = 'middlename_example'; // string | The middle name of the user to create.

try {
    $apiInstance->advancedstationCreateuser($station, $user, $location, $firstname, $lastname, $email, $middlename);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationCreateuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user to create. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. |
 **firstname** | **string**| The first name of the user to create. |
 **lastname** | **string**| The last name of the user to create. |
 **email** | **string**| The email of the user to create. |
 **middlename** | **string**| The middle name of the user to create. | [optional]

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


## advancedstationGetevents

> advancedstationGetevents($station, $location, $user)

Gets the courses available for a specific location and a specific student.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$location = 'location_example'; // string | The id of the location the student picked.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->advancedstationGetevents($station, $location, $user);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationGetevents: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **location** | [**string**](../Model/.md)| The id of the location the student picked. |
 **user** | **string**| The card of the user. |

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


## advancedstationGetinfo

> advancedstationGetinfo($id, $event)

Gets the info to display in the sign-in station by it's ID.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = 'id_example'; // string | The id of the sign-in station to get.
$event = 'event_example'; // string | The id of the event (or session), to override the scheduled one.

try {
    $apiInstance->advancedstationGetinfo($id, $event);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationGetinfo: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **event** | [**string**](../Model/.md)| The id of the event (or session), to override the scheduled one. | [optional]

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


## advancedstationGetlocations

> advancedstationGetlocations($station, $user)

Gets the locations available in a sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station whose locations have to be returned.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->advancedstationGetlocations($station, $user);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationGetlocations: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station whose locations have to be returned. |
 **user** | **string**| The card of the user. |

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


## advancedstationGetlogstaff

> advancedstationGetlogstaff($station, $attendancelog, $photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$attendancelog = 'attendancelog_example'; // string | The id of the attendance log to filter the staff members.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->advancedstationGetlogstaff($station, $attendancelog, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationGetlogstaff: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **attendancelog** | [**string**](../Model/.md)| The id of the attendance log to filter the staff members. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

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


## advancedstationGetroles

> advancedstationGetroles($station, $signinrole, $user, $location)

Gets the user roles of the user trying to sign-in.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$signinrole = 'signinrole_example'; // string | Specifies how the user is signing-in.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->advancedstationGetroles($station, $signinrole, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationGetroles: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **signinrole** | **string**| Specifies how the user is signing-in. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. |

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


## advancedstationGetservices

> advancedstationGetservices($station, $location, $user)

Gets the services available for a specific location.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$location = 'location_example'; // string | The id of the location the student picked.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->advancedstationGetservices($station, $location, $user);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationGetservices: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **location** | [**string**](../Model/.md)| The id of the location the student picked. |
 **user** | **string**| The card of the user. |

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


## advancedstationGetstaff

> advancedstationGetstaff($station, $locationid, $user, $services, $eventid, $photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$locationid = 'locationid_example'; // string | The id of the location the student picked.
$user = 'user_example'; // string | The card of the user.
$services = 'services_example'; // string | The list of services selected by the user, in JSON format.
$eventid = 'eventid_example'; // string | The ID of the event selected.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->advancedstationGetstaff($station, $locationid, $user, $services, $eventid, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationGetstaff: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **locationid** | [**string**](../Model/.md)| The id of the location the student picked. |
 **user** | **string**| The card of the user. |
 **services** | **string**| The list of services selected by the user, in JSON format. | [optional]
 **eventid** | [**string**](../Model/.md)| The ID of the event selected. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

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


## advancedstationIssignedin

> advancedstationIssignedin($station, $time, $user, $location)

Gets whether a user is signed-in or not.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\AdvancedstationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$time = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time of the swipe.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->advancedstationIssignedin($station, $time, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling AdvancedstationApi->advancedstationIssignedin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **time** | **\DateTime**| The date and time of the swipe. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. | [optional]

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

