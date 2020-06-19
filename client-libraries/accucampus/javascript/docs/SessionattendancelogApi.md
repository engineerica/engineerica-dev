# AccuCampusOpenApi3.SessionattendancelogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionattendancelogAddnote**](SessionattendancelogApi.md#sessionattendancelogAddnote) | **GET** /sessionattendancelog/addnote | Add a note to a class attendance log
[**sessionattendancelogGet**](SessionattendancelogApi.md#sessionattendancelogGet) | **GET** /sessionattendancelog/{id} | View details of a class attendance log
[**sessionattendancelogGetuser**](SessionattendancelogApi.md#sessionattendancelogGetuser) | **GET** /sessionattendancelog/getuser | View the class session attendance information for a specific user
[**sessionattendancelogList**](SessionattendancelogApi.md#sessionattendancelogList) | **GET** /sessionattendancelog/list | View attendance logs of the specified session
[**sessionattendancelogListevent**](SessionattendancelogApi.md#sessionattendancelogListevent) | **GET** /sessionattendancelog/listevent | View the attendance information of an entire class
[**sessionattendancelogListsummary**](SessionattendancelogApi.md#sessionattendancelogListsummary) | **GET** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
[**sessionattendancelogMylistsummary**](SessionattendancelogApi.md#sessionattendancelogMylistsummary) | **GET** /sessionattendancelog/mylistsummary | View my attendance summary
[**sessionattendancelogSave**](SessionattendancelogApi.md#sessionattendancelogSave) | **POST** /sessionattendancelog/{id} | Create or edit a class attendance log
[**sessionattendancelogSaveswipe**](SessionattendancelogApi.md#sessionattendancelogSaveswipe) | **POST** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe



## sessionattendancelogAddnote

> sessionattendancelogAddnote(id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let id = null; // String | The id of the attendance log.
let text = "text_example"; // String | The text of the note to add.
apiInstance.sessionattendancelogAddnote(id, text, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the attendance log. | 
 **text** | **String**| The text of the note to add. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogGet

> sessionattendancelogGet(id, opts)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let id = null; // String | The id of the attendance log to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.
};
apiInstance.sessionattendancelogGet(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the attendance log to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogGetuser

> sessionattendancelogGetuser(attendee, eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let attendee = null; // String | The id of the attendee to get statistic for.
let eventid = null; // String | The id of the event whose attendee statistics have to be returned.
apiInstance.sessionattendancelogGetuser(attendee, eventid, (error, data, response) => {
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
 **attendee** | [**String**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**String**](.md)| The id of the event whose attendee statistics have to be returned. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogList

> sessionattendancelogList(session, from, count, opts)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let session = null; // String | The id of the session whose attendees logs have to be returned.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.sessionattendancelogList(session, from, count, opts, (error, data, response) => {
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
 **session** | [**String**](.md)| The id of the session whose attendees logs have to be returned. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogListevent

> sessionattendancelogListevent(eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let eventid = null; // String | The id of the event whose attendance has to be returned.
apiInstance.sessionattendancelogListevent(eventid, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogListsummary

> sessionattendancelogListsummary(opts)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let opts = {
  'eventid': null, // String | The id of the event whose attendance has to be returned.
  'attendeeid': null, // String | The id of the attendee whose attendance has to be returned.
  'groupid': null, // String | The id of the group whose attendance has to be returned.
  'start': "start_example", // String | The start date to filter (beginning of time by default).
  'end': "end_example" // String | The end date to filter (today by default).
};
apiInstance.sessionattendancelogListsummary(opts, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**String**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**String**](.md)| The id of the group whose attendance has to be returned. | [optional] 
 **start** | **String**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **String**| The end date to filter (today by default). | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogMylistsummary

> sessionattendancelogMylistsummary(opts)

View my attendance summary

Allows the user to view their own attendance summary.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let opts = {
  'eventid': null, // String | The id of the event whose attendance has to be returned.
  'start': "start_example", // String | The start date to filter (beginning of time by default).
  'end': "end_example" // String | The end date to filter (today by default).
};
apiInstance.sessionattendancelogMylistsummary(opts, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **start** | **String**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **String**| The end date to filter (today by default). | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogSave

> sessionattendancelogSave(id, opts)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let id = null; // String | The id of the att log to save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionattendancelogSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the att log to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionattendancelogSaveswipe

> sessionattendancelogSaveswipe(opts)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionattendancelogApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionattendancelogSaveswipe(opts, (error, data, response) => {
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

