# AccuCampusOpenApi3.WaitinglineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**waitinglineAdduser**](WaitinglineApi.md#waitinglineAdduser) | **GET** /waitingline/adduser | Put user in a waiting line
[**waitinglineDelete**](WaitinglineApi.md#waitinglineDelete) | **DELETE** /waitingline/{id} | Delete a waiting line
[**waitinglineGet**](WaitinglineApi.md#waitinglineGet) | **GET** /waitingline/{id} | View details of a waiting line
[**waitinglineIsuserin**](WaitinglineApi.md#waitinglineIsuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**waitinglineList**](WaitinglineApi.md#waitinglineList) | **GET** /waitingline/list | View a list of waiting lines
[**waitinglineRemoveuser**](WaitinglineApi.md#waitinglineRemoveuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
[**waitinglineSave**](WaitinglineApi.md#waitinglineSave) | **POST** /waitingline/{id} | Create or edit a waiting line
[**waitinglineSigninuser**](WaitinglineApi.md#waitinglineSigninuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line



## waitinglineAdduser

> waitinglineAdduser(station, user, opts)

Put user in a waiting line

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.WaitinglineApi();
let station = null; // String | The id of the sign-in station.
let user = "user_example"; // String | The user's card number.
let opts = {
  'locationid': null, // String | The location's id where the swipe must be saved.
  'time': new Date("2013-10-20T19:20:30+01:00"), // Date | The date and time of the swipe.
  'signinrole': "signinrole_example", // String | Specifies if the sign-in is for an attendee or a staff member
  'roleid': null, // String | Specifies the role the user has selected in order to sign-in
  'services': "services_example", // String | The services ids the user has selected.
  'eventid': null, // String | The id of the event the user selected.
  'staff': null, // String | The id of the staff member the user selected.
  'photosize': 56 // Number | The swiping user's photo size.
};
apiInstance.waitinglineAdduser(station, user, opts, (error, data, response) => {
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
 **station** | [**String**](.md)| The id of the sign-in station. | 
 **user** | **String**| The user&#39;s card number. | 
 **locationid** | [**String**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **Date**| The date and time of the swipe. | [optional] 
 **signinrole** | **String**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**String**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **String**| The services ids the user has selected. | [optional] 
 **eventid** | [**String**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**String**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **Number**| The swiping user&#39;s photo size. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineDelete

> waitinglineDelete(id, opts)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.WaitinglineApi();
let id = null; // String | The id of the line to delete.
let opts = {
  'body': new AccuCampusOpenApi3.AnyType() // AnyType | 
};
apiInstance.waitinglineDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the line to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## waitinglineGet

> waitinglineGet(id, opts)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.WaitinglineApi();
let id = null; // String | The id of the waiting line to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.waitinglineGet(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the waiting line to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineIsuserin

> waitinglineIsuserin(station, time, user, opts)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.WaitinglineApi();
let station = null; // String | The id of the sign-in station.
let time = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time of the swipe.
let user = "user_example"; // String | The card number of the user.
let opts = {
  'location': null // String | The id of the location the user picked.
};
apiInstance.waitinglineIsuserin(station, time, user, opts, (error, data, response) => {
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
 **station** | [**String**](.md)| The id of the sign-in station. | 
 **time** | **Date**| The date and time of the swipe. | 
 **user** | **String**| The card number of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineList

> waitinglineList(from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.WaitinglineApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.waitinglineList(from, count, (error, data, response) => {
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

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineRemoveuser

> waitinglineRemoveuser(waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.WaitinglineApi();
let waitingline = null; // String | The id of the waiting line whose item has to be removed.
let itemid = null; // String | The ID of the item that has to be removed.
apiInstance.waitinglineRemoveuser(waitingline, itemid, (error, data, response) => {
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
 **waitingline** | [**String**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**String**](.md)| The ID of the item that has to be removed. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineSave

> waitinglineSave(id, opts)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.WaitinglineApi();
let id = null; // String | The id of the waiting line save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.waitinglineSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the waiting line save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## waitinglineSigninuser

> waitinglineSigninuser(waitingline, itemid, staff, opts)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.WaitinglineApi();
let waitingline = null; // String | The id of the waiting line whose item needs to be signed-in.
let itemid = null; // String | The ID of the item that has to be signed-in.
let staff = null; // String | The id of the staff member selected to sign-in.
let opts = {
  'photosize': 56 // Number | The swiping user's photo size.
};
apiInstance.waitinglineSigninuser(waitingline, itemid, staff, opts, (error, data, response) => {
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
 **waitingline** | [**String**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**String**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**String**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **Number**| The swiping user&#39;s photo size. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

