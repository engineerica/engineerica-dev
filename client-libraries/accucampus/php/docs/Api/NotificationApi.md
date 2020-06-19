# OpenAPI\Client\NotificationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notificationDelete**](NotificationApi.md#notificationDelete) | **DELETE** /notification/{id} | Delete a notification
[**notificationGet**](NotificationApi.md#notificationGet) | **GET** /notification/{id} | View a notification
[**notificationGetforstation**](NotificationApi.md#notificationGetforstation) | **GET** /notification/getforstation | Gets all public (in station) notifications for the specific user
[**notificationGetunreadcount**](NotificationApi.md#notificationGetunreadcount) | **GET** /notification/getunreadcount | Get the number of unread notifications
[**notificationList**](NotificationApi.md#notificationList) | **GET** /notification/list | View a list of all sent notifications
[**notificationListmine**](NotificationApi.md#notificationListmine) | **GET** /notification/listmine | View all the notifications sent to the current user
[**notificationMarkasread**](NotificationApi.md#notificationMarkasread) | **GET** /notification/markasread | Mark a notification as read
[**notificationMarkasunread**](NotificationApi.md#notificationMarkasunread) | **GET** /notification/markasunread | Mark a notification as unread
[**notificationSend**](NotificationApi.md#notificationSend) | **GET** /notification/send | Send notifications on screen, via email or text to users
[**notificationSendonscreen**](NotificationApi.md#notificationSendonscreen) | **GET** /notification/sendonscreen | Send on-screen notifications



## notificationDelete

> notificationDelete($id, $body)

Delete a notification

Allows the user to delete an existing notification.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the notification to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->notificationDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the notification to delete. |
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


## notificationGet

> notificationGet($id)

View a notification

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the notification to get.

try {
    $apiInstance->notificationGet($id);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the notification to get. |

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


## notificationGetforstation

> notificationGetforstation($station, $user)

Gets all public (in station) notifications for the specific user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->notificationGetforstation($station, $user);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationGetforstation: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
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


## notificationGetunreadcount

> notificationGetunreadcount()

Get the number of unread notifications

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->notificationGetunreadcount();
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationGetunreadcount: ', $e->getMessage(), PHP_EOL;
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


## notificationList

> notificationList($from, $count, $recipient, $status, $startdate, $enddate, $sentonscreen, $sentemail, $sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$recipient = 'recipient_example'; // string | The recipient whose notifications have to be listed.
$status = 56; // int | The status of the notifications to list. Read, Unread or All.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the notifications.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the notifications.
$sentonscreen = True; // bool | Specifies whether to list the notifications that were sent on-screen or not.
$sentemail = True; // bool | Specifies whether to list the notifications that were sent via e-mail or not.
$sentsms = True; // bool | Specifies whether to list the notifications that were sent via sms or not.

try {
    $apiInstance->notificationList($from, $count, $recipient, $status, $startdate, $enddate, $sentonscreen, $sentemail, $sentsms);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **recipient** | [**string**](../Model/.md)| The recipient whose notifications have to be listed. | [optional]
 **status** | **int**| The status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the notifications. | [optional]
 **sentonscreen** | **bool**| Specifies whether to list the notifications that were sent on-screen or not. | [optional]
 **sentemail** | **bool**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional]
 **sentsms** | **bool**| Specifies whether to list the notifications that were sent via sms or not. | [optional]

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


## notificationListmine

> notificationListmine($from, $count, $status, $startdate, $enddate)

View all the notifications sent to the current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$status = 56; // int | Specifies the status of the notifications to list. Read, Unread or All.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the notifications.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the notifications.

try {
    $apiInstance->notificationListmine($from, $count, $status, $startdate, $enddate);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationListmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **status** | **int**| Specifies the status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the notifications. | [optional]

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


## notificationMarkasread

> notificationMarkasread($id, $status, $startdate, $enddate)

Mark a notification as read

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
$status = 56; // int | Specifies the status to filter the notifications. Read, Unread or All.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the notifications.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the notifications.

try {
    $apiInstance->notificationMarkasread($id, $status, $startdate, $enddate);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationMarkasread: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional]
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the notifications. | [optional]

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


## notificationMarkasunread

> notificationMarkasunread($id, $status, $startdate, $enddate)

Mark a notification as unread

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
$status = 56; // int | Specifies the status to filter the notifications. Read, Unread or All.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the notifications.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the notifications.

try {
    $apiInstance->notificationMarkasunread($id, $status, $startdate, $enddate);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationMarkasunread: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional]
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the notifications. | [optional]

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


## notificationSend

> notificationSend($emailenabled, $onscreenenabled, $smsenabled, $title, $tousers, $togroups, $onscreenbody, $onscreenclick, $onscreenurl, $onscreenclass, $onscreenduration, $showonstation, $emailfromname, $emailfrom, $emailsubject, $emailbody, $textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$emailenabled = True; // bool | Whether send the notification via email.
$onscreenenabled = True; // bool | Whether to display the notification on screen.
$smsenabled = True; // bool | Whether to send the notification via text message.
$title = 'title_example'; // string | Notification title.
$tousers = 'tousers_example'; // string | Comma-separated Ids of users to send the notification.
$togroups = 'togroups_example'; // string | Comma-separated Ids of user groups to send the notification.
$onscreenbody = 'onscreenbody_example'; // string | Body of the message for on-screen display.
$onscreenclick = 'onscreenclick_example'; // string | What to do when the notification is clicked. Valid values: hide, view, url.
$onscreenurl = 'onscreenurl_example'; // string | Url to redirect the user, if onscreenclick=url.
$onscreenclass = 'onscreenclass_example'; // string | How to display the notification. Valid values: info, success, warning, error
$onscreenduration = 56; // int | Time in seconds to display the notification.
$showonstation = 56; // int | Whether to show the notification in the sign-in station.
$emailfromname = 'emailfromname_example'; // string | Name of the email sender.
$emailfrom = 'emailfrom_example'; // string | Reply-to email.
$emailsubject = 'emailsubject_example'; // string | Subject of the email.
$emailbody = 'emailbody_example'; // string | Body of the email.
$textmessagebody = 'textmessagebody_example'; // string | Message for SMS. Max 160 characters.

try {
    $apiInstance->notificationSend($emailenabled, $onscreenenabled, $smsenabled, $title, $tousers, $togroups, $onscreenbody, $onscreenclick, $onscreenurl, $onscreenclass, $onscreenduration, $showonstation, $emailfromname, $emailfrom, $emailsubject, $emailbody, $textmessagebody);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationSend: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailenabled** | **bool**| Whether send the notification via email. |
 **onscreenenabled** | **bool**| Whether to display the notification on screen. |
 **smsenabled** | **bool**| Whether to send the notification via text message. |
 **title** | **string**| Notification title. |
 **tousers** | **string**| Comma-separated Ids of users to send the notification. | [optional]
 **togroups** | **string**| Comma-separated Ids of user groups to send the notification. | [optional]
 **onscreenbody** | **string**| Body of the message for on-screen display. | [optional]
 **onscreenclick** | **string**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional]
 **onscreenurl** | **string**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional]
 **onscreenclass** | **string**| How to display the notification. Valid values: info, success, warning, error | [optional]
 **onscreenduration** | **int**| Time in seconds to display the notification. | [optional]
 **showonstation** | **int**| Whether to show the notification in the sign-in station. | [optional]
 **emailfromname** | **string**| Name of the email sender. | [optional]
 **emailfrom** | **string**| Reply-to email. | [optional]
 **emailsubject** | **string**| Subject of the email. | [optional]
 **emailbody** | **string**| Body of the email. | [optional]
 **textmessagebody** | **string**| Message for SMS. Max 160 characters. | [optional]

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


## notificationSendonscreen

> notificationSendonscreen($notification)

Send on-screen notifications

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\NotificationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$notification = 'notification_example'; // string | The ID of the notification to send.

try {
    $apiInstance->notificationSendonscreen($notification);
} catch (Exception $e) {
    echo 'Exception when calling NotificationApi->notificationSendonscreen: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**string**](../Model/.md)| The ID of the notification to send. |

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

