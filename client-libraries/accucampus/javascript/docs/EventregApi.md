# AccuCampusOpenApi3.EventregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventregAddme**](EventregApi.md#eventregAddme) | **GET** /eventreg/addme | Register current user to a course
[**eventregAddmetoall**](EventregApi.md#eventregAddmetoall) | **GET** /eventreg/addmetoall | Register current user to all courses
[**eventregAddmetogroup**](EventregApi.md#eventregAddmetogroup) | **GET** /eventreg/addmetogroup | Register current user to a course group
[**eventregAdduser**](EventregApi.md#eventregAdduser) | **GET** /eventreg/adduser | Register a user to a course for attendance
[**eventregAddusertoall**](EventregApi.md#eventregAddusertoall) | **GET** /eventreg/addusertoall | Register a user to assist with all courses
[**eventregAddusertogroup**](EventregApi.md#eventregAddusertogroup) | **GET** /eventreg/addusertogroup | Register a user to an course group
[**eventregGetevents**](EventregApi.md#eventregGetevents) | **GET** /eventreg/getevents | View course registration by user
[**eventregGetgroups**](EventregApi.md#eventregGetgroups) | **GET** /eventreg/getgroups | Lists the course group registrations of a user
[**eventregGetmyevents**](EventregApi.md#eventregGetmyevents) | **GET** /eventreg/getmyevents | View the event registrations of the current user
[**eventregGetmygroups**](EventregApi.md#eventregGetmygroups) | **GET** /eventreg/getmygroups | View all current user registrations to course groups
[**eventregGetusers**](EventregApi.md#eventregGetusers) | **GET** /eventreg/getusers | View course registration
[**eventregGetusersfromgroup**](EventregApi.md#eventregGetusersfromgroup) | **GET** /eventreg/getusersfromgroup | Lists the registrations for a course group
[**eventregGetuserstoall**](EventregApi.md#eventregGetuserstoall) | **GET** /eventreg/getuserstoall | View the users that are registered to all courses
[**eventregRemoveme**](EventregApi.md#eventregRemoveme) | **GET** /eventreg/removeme | Unregister current user from a course
[**eventregRemovemefromall**](EventregApi.md#eventregRemovemefromall) | **GET** /eventreg/removemefromall | Remove current user from the registration to all courses
[**eventregRemovemefromgroup**](EventregApi.md#eventregRemovemefromgroup) | **GET** /eventreg/removemefromgroup | Remove current user from a course group
[**eventregRemoveuser**](EventregApi.md#eventregRemoveuser) | **GET** /eventreg/removeuser | Remove a user from a course
[**eventregRemoveuserfromall**](EventregApi.md#eventregRemoveuserfromall) | **GET** /eventreg/removeuserfromall | Remove a user from the registration to all courses
[**eventregRemoveuserfromgroup**](EventregApi.md#eventregRemoveuserfromgroup) | **GET** /eventreg/removeuserfromgroup | Remove a user from a course group



## eventregAddme

> eventregAddme(eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let eventid = null; // String | The id of the event.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregAddme(eventid, listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregAddmetoall

> eventregAddmetoall(listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregAddmetoall(listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregAddmetogroup

> eventregAddmetogroup(codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let codegroup = "codegroup_example"; // String | The code used to group events.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregAddmetogroup(codegroup, listname, (error, data, response) => {
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
 **codegroup** | **String**| The code used to group events. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregAdduser

> eventregAdduser(userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let userid = null; // String | The id of the user to add.
let eventid = null; // String | The id of the event.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregAdduser(userid, eventid, listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregAddusertoall

> eventregAddusertoall(userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let userid = null; // String | The id of the user to add.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregAddusertoall(userid, listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregAddusertogroup

> eventregAddusertogroup(userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let userid = null; // String | The id of the user to add.
let codegroup = "codegroup_example"; // String | The code used to group events.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregAddusertogroup(userid, codegroup, listname, (error, data, response) => {
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
 **codegroup** | **String**| The code used to group events. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregGetevents

> eventregGetevents(userid, listname, opts)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let userid = null; // String | The user id to list events.
let listname = "listname_example"; // String | The name of the list where the user is registered.
let opts = {
  'termid': null, // String | The term id to list events.
  'namefilter': "namefilter_example" // String | The value used to filter the events by name.
};
apiInstance.eventregGetevents(userid, listname, opts, (error, data, response) => {
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
 **userid** | [**String**](.md)| The user id to list events. | 
 **listname** | **String**| The name of the list where the user is registered. | 
 **termid** | [**String**](.md)| The term id to list events. | [optional] 
 **namefilter** | **String**| The value used to filter the events by name. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregGetgroups

> eventregGetgroups(userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let userid = null; // String | The user id to list events.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregGetgroups(userid, listname, (error, data, response) => {
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
 **userid** | [**String**](.md)| The user id to list events. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregGetmyevents

> eventregGetmyevents(listname, opts)

View the event registrations of the current user

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let listname = "listname_example"; // String | The name of the list where the user is registered.
let opts = {
  'termid': null, // String | The term id to list events.
  'namefilter': "namefilter_example" // String | The value used to filter the events by name.
};
apiInstance.eventregGetmyevents(listname, opts, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user is registered. | 
 **termid** | [**String**](.md)| The term id to list events. | [optional] 
 **namefilter** | **String**| The value used to filter the events by name. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregGetmygroups

> eventregGetmygroups(listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregGetmygroups(listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregGetusers

> eventregGetusers(eventid, listname, opts)

View course registration

Allows the user to view all users registered for an individual course.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let eventid = null; // String | The event id to list users.
let listname = "listname_example"; // String | The name of the list to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.eventregGetusers(eventid, listname, opts, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The event id to list users. | 
 **listname** | **String**| The name of the list to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregGetusersfromgroup

> eventregGetusersfromgroup(codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let codegroup = null; // String | The code group to list users.
let listname = "listname_example"; // String | The name of the list to get.
apiInstance.eventregGetusersfromgroup(codegroup, listname, (error, data, response) => {
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
 **codegroup** | [**String**](.md)| The code group to list users. | 
 **listname** | **String**| The name of the list to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregGetuserstoall

> eventregGetuserstoall(listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let listname = "listname_example"; // String | The name of the list to get.
apiInstance.eventregGetuserstoall(listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregRemoveme

> eventregRemoveme(eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let eventid = null; // String | The id of the event.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregRemoveme(eventid, listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregRemovemefromall

> eventregRemovemefromall(listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregRemovemefromall(listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregRemovemefromgroup

> eventregRemovemefromgroup(codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let codegroup = null; // String | The code group of the events/courses.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregRemovemefromgroup(codegroup, listname, (error, data, response) => {
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
 **codegroup** | [**String**](.md)| The code group of the events/courses. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregRemoveuser

> eventregRemoveuser(userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course&#39;s registration.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let userid = null; // String | The id of the user to remove.
let eventid = null; // String | The id of the event.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregRemoveuser(userid, eventid, listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregRemoveuserfromall

> eventregRemoveuserfromall(userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let userid = null; // String | The id of the user to remove.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregRemoveuserfromall(userid, listname, (error, data, response) => {
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
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregRemoveuserfromgroup

> eventregRemoveuserfromgroup(userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.EventregApi();
let userid = null; // String | The id of the user to remove.
let codegroup = null; // String | The code group of the events/courses.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregRemoveuserfromgroup(userid, codegroup, listname, (error, data, response) => {
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
 **codegroup** | [**String**](.md)| The code group of the events/courses. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

