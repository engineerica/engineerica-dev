# OpenAPI\Client\SessionregApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionregAddcurrentuser**](SessionregApi.md#sessionregAddcurrentuser) | **GET** /sessionreg/addcurrentuser | Register current user to an event session
[**sessionregAdduser**](SessionregApi.md#sessionregAdduser) | **GET** /sessionreg/adduser | Register users for events
[**sessionregGetmysessions**](SessionregApi.md#sessionregGetmysessions) | **GET** /sessionreg/getmysessions | View all the sessions the logged user is registered to
[**sessionregGetsessions**](SessionregApi.md#sessionregGetsessions) | **GET** /sessionreg/getsessions | Lists the registrations for a specific user
[**sessionregGetsettings**](SessionregApi.md#sessionregGetsettings) | **GET** /sessionreg/getsettings | Get the settings for session registration
[**sessionregGetusers**](SessionregApi.md#sessionregGetusers) | **GET** /sessionreg/getusers | Lists the registrations for a specific session
[**sessionregListsessions**](SessionregApi.md#sessionregListsessions) | **GET** /sessionreg/listsessions | List the sessions available for a specific event
[**sessionregListupcoming**](SessionregApi.md#sessionregListupcoming) | **GET** /sessionreg/listupcoming | View a list of upcoming event sessions
[**sessionregListupcomingevent**](SessionregApi.md#sessionregListupcomingevent) | **GET** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
[**sessionregRemovecurrentuser**](SessionregApi.md#sessionregRemovecurrentuser) | **GET** /sessionreg/removecurrentuser | Unregister current user from an event session
[**sessionregRemoveuser**](SessionregApi.md#sessionregRemoveuser) | **GET** /sessionreg/removeuser | Removes a user from an event session
[**sessionregSavesettings**](SessionregApi.md#sessionregSavesettings) | **POST** /sessionreg/savesettings | Save the settings for an event&#39;s session registration



## sessionregAddcurrentuser

> sessionregAddcurrentuser($eventid, $sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.

try {
    $apiInstance->sessionregAddcurrentuser($eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregAddcurrentuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **sessiondate** | **\DateTime**| The date and time when the session starts. |

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


## sessionregAdduser

> sessionregAdduser($userid, $eventid, $sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to add.
$eventid = 'eventid_example'; // string | The id of the event.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.

try {
    $apiInstance->sessionregAdduser($userid, $eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregAdduser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **sessiondate** | **\DateTime**| The date and time when the session starts. |

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


## sessionregGetmysessions

> sessionregGetmysessions($date)

View all the sessions the logged user is registered to

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$date = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | Start date to filter the sessions.

try {
    $apiInstance->sessionregGetmysessions($date);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregGetmysessions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **\DateTime**| Start date to filter the sessions. | [optional]

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


## sessionregGetsessions

> sessionregGetsessions($userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The user id to list sessions.

try {
    $apiInstance->sessionregGetsessions($userid);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregGetsessions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The user id to list sessions. |

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


## sessionregGetsettings

> sessionregGetsettings($locationid, $eventid, $sessiondate, $noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$locationid = 'locationid_example'; // string | The id of the location to save settings.
$eventid = 'eventid_example'; // string | The id of the event to save settings.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.
$noinherit = True; // bool | True to get the location/event/session specific settings without looking for the more global settings.

try {
    $apiInstance->sessionregGetsettings($locationid, $eventid, $sessiondate, $noinherit);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregGetsettings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**string**](../Model/.md)| The id of the location to save settings. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event to save settings. | [optional]
 **sessiondate** | **\DateTime**| The date and time when the session starts. | [optional]
 **noinherit** | **bool**| True to get the location/event/session specific settings without looking for the more global settings. | [optional]

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


## sessionregGetusers

> sessionregGetusers($eventid, $sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The event id to list sessions.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date of the session to find.

try {
    $apiInstance->sessionregGetusers($eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregGetusers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The event id to list sessions. |
 **sessiondate** | **\DateTime**| The date of the session to find. |

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


## sessionregListsessions

> sessionregListsessions($eventid, $sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The event id to list sessions.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date of the session to find.

try {
    $apiInstance->sessionregListsessions($eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregListsessions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The event id to list sessions. |
 **sessiondate** | **\DateTime**| The date of the session to find. | [optional]

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


## sessionregListupcoming

> sessionregListupcoming($date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$date = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | Only sessions in the week of the specified date will be returned.

try {
    $apiInstance->sessionregListupcoming($date);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregListupcoming: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **\DateTime**| Only sessions in the week of the specified date will be returned. |

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


## sessionregListupcomingevent

> sessionregListupcomingevent($date, $event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$date = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | Start date to filter the returned sessions.
$event = 'event_example'; // string | The id of the event whose sessions will be returned

try {
    $apiInstance->sessionregListupcomingevent($date, $event);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregListupcomingevent: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **\DateTime**| Start date to filter the returned sessions. |
 **event** | [**string**](../Model/.md)| The id of the event whose sessions will be returned |

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


## sessionregRemovecurrentuser

> sessionregRemovecurrentuser($eventid, $sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.

try {
    $apiInstance->sessionregRemovecurrentuser($eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregRemovecurrentuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **sessiondate** | **\DateTime**| The date and time when the session starts. |

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


## sessionregRemoveuser

> sessionregRemoveuser($userid, $eventid, $sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to remove.
$eventid = 'eventid_example'; // string | The id of the event.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.

try {
    $apiInstance->sessionregRemoveuser($userid, $eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregRemoveuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **sessiondate** | **\DateTime**| The date and time when the session starts. |

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


## sessionregSavesettings

> sessionregSavesettings($unknown_base_type)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SessionregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->sessionregSavesettings($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling SessionregApi->sessionregSavesettings: ', $e->getMessage(), PHP_EOL;
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

