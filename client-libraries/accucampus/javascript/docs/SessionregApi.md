# AccuCampusOpenApi3.SessionregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

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

> sessionregAddcurrentuser(eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let eventid = null; // String | The id of the event.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time when the session starts.
apiInstance.sessionregAddcurrentuser(eventid, sessiondate, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **Date**| The date and time when the session starts. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregAdduser

> sessionregAdduser(userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let userid = null; // String | The id of the user to add.
let eventid = null; // String | The id of the event.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time when the session starts.
apiInstance.sessionregAdduser(userid, eventid, sessiondate, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user to add. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **Date**| The date and time when the session starts. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregGetmysessions

> sessionregGetmysessions(opts)

View all the sessions the logged user is registered to

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let opts = {
  '_date': new Date("2013-10-20T19:20:30+01:00") // Date | Start date to filter the sessions.
};
apiInstance.sessionregGetmysessions(opts, (error, data, response) => {
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
 **_date** | **Date**| Start date to filter the sessions. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregGetsessions

> sessionregGetsessions(userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let userid = null; // String | The user id to list sessions.
apiInstance.sessionregGetsessions(userid, (error, data, response) => {
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
 **userid** | [**String**](.md)| The user id to list sessions. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregGetsettings

> sessionregGetsettings(opts)

Get the settings for session registration

Allows the user to view a event&#39;s session registration settings.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let opts = {
  'locationid': null, // String | The id of the location to save settings.
  'eventid': null, // String | The id of the event to save settings.
  'sessiondate': new Date("2013-10-20T19:20:30+01:00"), // Date | The date and time when the session starts.
  'noinherit': true // Boolean | True to get the location/event/session specific settings without looking for the more global settings.
};
apiInstance.sessionregGetsettings(opts, (error, data, response) => {
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
 **locationid** | [**String**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **Date**| The date and time when the session starts. | [optional] 
 **noinherit** | **Boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregGetusers

> sessionregGetusers(eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let eventid = null; // String | The event id to list sessions.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date of the session to find.
apiInstance.sessionregGetusers(eventid, sessiondate, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The event id to list sessions. | 
 **sessiondate** | **Date**| The date of the session to find. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregListsessions

> sessionregListsessions(eventid, opts)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let eventid = null; // String | The event id to list sessions.
let opts = {
  'sessiondate': new Date("2013-10-20T19:20:30+01:00") // Date | The date of the session to find.
};
apiInstance.sessionregListsessions(eventid, opts, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The event id to list sessions. | 
 **sessiondate** | **Date**| The date of the session to find. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregListupcoming

> sessionregListupcoming(_date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let _date = new Date("2013-10-20T19:20:30+01:00"); // Date | Only sessions in the week of the specified date will be returned.
apiInstance.sessionregListupcoming(_date, (error, data, response) => {
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
 **_date** | **Date**| Only sessions in the week of the specified date will be returned. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregListupcomingevent

> sessionregListupcomingevent(_date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let _date = new Date("2013-10-20T19:20:30+01:00"); // Date | Start date to filter the returned sessions.
let event = null; // String | The id of the event whose sessions will be returned
apiInstance.sessionregListupcomingevent(_date, event, (error, data, response) => {
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
 **_date** | **Date**| Start date to filter the returned sessions. | 
 **event** | [**String**](.md)| The id of the event whose sessions will be returned | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregRemovecurrentuser

> sessionregRemovecurrentuser(eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let eventid = null; // String | The id of the event.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time when the session starts.
apiInstance.sessionregRemovecurrentuser(eventid, sessiondate, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **Date**| The date and time when the session starts. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregRemoveuser

> sessionregRemoveuser(userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let userid = null; // String | The id of the user to remove.
let eventid = null; // String | The id of the event.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time when the session starts.
apiInstance.sessionregRemoveuser(userid, eventid, sessiondate, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **Date**| The date and time when the session starts. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregSavesettings

> sessionregSavesettings(opts)

Save the settings for an event&#39;s session registration

Allows the user to save the settings for an event.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionregApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionregSavesettings(opts, (error, data, response) => {
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

