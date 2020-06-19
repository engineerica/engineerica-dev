# AccuCampusOpenApi3.NotificationApi

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

> notificationDelete(id, opts)

Delete a notification

Allows the user to delete an existing notification.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let id = null; // String | The id of the notification to delete.
let opts = {
  'body': new AccuCampusOpenApi3.AnyType() // AnyType | 
};
apiInstance.notificationDelete(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## notificationGet

> notificationGet(id)

View a notification

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let id = null; // String | The id of the notification to get.
apiInstance.notificationGet(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationGetforstation

> notificationGetforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
apiInstance.notificationGetforstation(station, user, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationGetunreadcount

> notificationGetunreadcount()

Get the number of unread notifications

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
apiInstance.notificationGetunreadcount((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationList

> notificationList(from, count, opts)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'recipient': null, // String | The recipient whose notifications have to be listed.
  'status': 56, // Number | The status of the notifications to list. Read, Unread or All.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the notifications.
  'enddate': new Date("2013-10-20T19:20:30+01:00"), // Date | The end date of the period to filter the notifications.
  'sentonscreen': true, // Boolean | Specifies whether to list the notifications that were sent on-screen or not.
  'sentemail': true, // Boolean | Specifies whether to list the notifications that were sent via e-mail or not.
  'sentsms': true // Boolean | Specifies whether to list the notifications that were sent via sms or not.
};
apiInstance.notificationList(from, count, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **recipient** | [**String**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **Number**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **Boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **Boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **Boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationListmine

> notificationListmine(from, count, opts)

View all the notifications sent to the current user

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'status': 56, // Number | Specifies the status of the notifications to list. Read, Unread or All.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the notifications.
  'enddate': new Date("2013-10-20T19:20:30+01:00") // Date | The end date of the period to filter the notifications.
};
apiInstance.notificationListmine(from, count, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **status** | **Number**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the notifications. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationMarkasread

> notificationMarkasread(opts)

Mark a notification as read

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let opts = {
  'id': null, // String | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
  'status': 56, // Number | Specifies the status to filter the notifications. Read, Unread or All.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the notifications.
  'enddate': new Date("2013-10-20T19:20:30+01:00") // Date | The end date of the period to filter the notifications.
};
apiInstance.notificationMarkasread(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **Number**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the notifications. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationMarkasunread

> notificationMarkasunread(opts)

Mark a notification as unread

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let opts = {
  'id': null, // String | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
  'status': 56, // Number | Specifies the status to filter the notifications. Read, Unread or All.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the notifications.
  'enddate': new Date("2013-10-20T19:20:30+01:00") // Date | The end date of the period to filter the notifications.
};
apiInstance.notificationMarkasunread(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **Number**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the notifications. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationSend

> notificationSend(emailenabled, onscreenenabled, smsenabled, title, opts)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let emailenabled = true; // Boolean | Whether send the notification via email.
let onscreenenabled = true; // Boolean | Whether to display the notification on screen.
let smsenabled = true; // Boolean | Whether to send the notification via text message.
let title = "title_example"; // String | Notification title.
let opts = {
  'tousers': "tousers_example", // String | Comma-separated Ids of users to send the notification.
  'togroups': "togroups_example", // String | Comma-separated Ids of user groups to send the notification.
  'onscreenbody': "onscreenbody_example", // String | Body of the message for on-screen display.
  'onscreenclick': "onscreenclick_example", // String | What to do when the notification is clicked. Valid values: hide, view, url.
  'onscreenurl': "onscreenurl_example", // String | Url to redirect the user, if onscreenclick=url.
  'onscreenclass': "onscreenclass_example", // String | How to display the notification. Valid values: info, success, warning, error
  'onscreenduration': 56, // Number | Time in seconds to display the notification.
  'showonstation': 56, // Number | Whether to show the notification in the sign-in station.
  'emailfromname': "emailfromname_example", // String | Name of the email sender.
  'emailfrom': "emailfrom_example", // String | Reply-to email.
  'emailsubject': "emailsubject_example", // String | Subject of the email.
  'emailbody': "emailbody_example", // String | Body of the email.
  'textmessagebody': "textmessagebody_example" // String | Message for SMS. Max 160 characters.
};
apiInstance.notificationSend(emailenabled, onscreenenabled, smsenabled, title, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailenabled** | **Boolean**| Whether send the notification via email. | 
 **onscreenenabled** | **Boolean**| Whether to display the notification on screen. | 
 **smsenabled** | **Boolean**| Whether to send the notification via text message. | 
 **title** | **String**| Notification title. | 
 **tousers** | **String**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **String**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **String**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **String**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **String**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **String**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **Number**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **Number**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **String**| Name of the email sender. | [optional] 
 **emailfrom** | **String**| Reply-to email. | [optional] 
 **emailsubject** | **String**| Subject of the email. | [optional] 
 **emailbody** | **String**| Body of the email. | [optional] 
 **textmessagebody** | **String**| Message for SMS. Max 160 characters. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationSendonscreen

> notificationSendonscreen(notification)

Send on-screen notifications

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.NotificationApi();
let notification = null; // String | The ID of the notification to send.
apiInstance.notificationSendonscreen(notification, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**String**](.md)| The ID of the notification to send. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

