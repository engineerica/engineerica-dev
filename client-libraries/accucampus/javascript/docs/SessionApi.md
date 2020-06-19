# AccuCampusOpenApi3.SessionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionBulkupdate**](SessionApi.md#sessionBulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
[**sessionGet**](SessionApi.md#sessionGet) | **GET** /session/{id} | View details of a session
[**sessionGetschedule**](SessionApi.md#sessionGetschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**sessionList**](SessionApi.md#sessionList) | **GET** /session/list | Gets all future sessions of the current semester



## sessionBulkupdate

> sessionBulkupdate(eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionApi();
let eventid = null; // String | The id of the event to bulk update.
let sessions = "sessions_example"; // String | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.
apiInstance.sessionBulkupdate(eventid, sessions, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The id of the event to bulk update. | 
 **sessions** | **String**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionGet

> sessionGet(id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionApi();
let id = null; // String | The id of the session to get.
apiInstance.sessionGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the session to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionGetschedule

> sessionGetschedule(opts)

Gets the schedule for a location, instructor or attendees

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionApi();
let opts = {
  'day': new Date("2013-10-20T19:20:30+01:00"), // Date | The day to return. It will also return the whole week for that day.
  'attendee': null, // String | The id of the attendee to get the schedule.
  'location': null, // String | The id of the location to get the schedule.
  'instructor': null // String | The id of the instructor to get the schedule.
};
apiInstance.sessionGetschedule(opts, (error, data, response) => {
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
 **day** | **Date**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**String**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**String**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**String**](.md)| The id of the instructor to get the schedule. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionList

> sessionList(from, count, opts)

Gets all future sessions of the current semester

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date to filter the sessions
  'enddate': new Date("2013-10-20T19:20:30+01:00") // Date | The end date to filter the sessions.
};
apiInstance.sessionList(from, count, opts, (error, data, response) => {
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
 **startdate** | **Date**| The start date to filter the sessions | [optional] 
 **enddate** | **Date**| The end date to filter the sessions. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

