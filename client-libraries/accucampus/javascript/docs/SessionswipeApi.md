# AccuCampusOpenApi3.SessionswipeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionswipeDelete**](SessionswipeApi.md#sessionswipeDelete) | **DELETE** /sessionswipe/{id} | Delete a session swipe
[**sessionswipeGet**](SessionswipeApi.md#sessionswipeGet) | **GET** /sessionswipe/{id} | View details of a class attendance swipe
[**sessionswipeListunresolved**](SessionswipeApi.md#sessionswipeListunresolved) | **GET** /sessionswipe/listunresolved | View a list of unresolved swipes
[**sessionswipeResolve**](SessionswipeApi.md#sessionswipeResolve) | **GET** /sessionswipe/resolve | Resolve a swipe and create the corresponding attendance log
[**sessionswipeSave**](SessionswipeApi.md#sessionswipeSave) | **POST** /sessionswipe/save | Creates a new swipe, and if possible, creates the attendance log
[**sessionswipeSaveanonym**](SessionswipeApi.md#sessionswipeSaveanonym) | **POST** /sessionswipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log



## sessionswipeDelete

> sessionswipeDelete(id, opts)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionswipeApi();
let id = null; // String | The id of the session swipe to delete.
let opts = {
  'body': new AccuCampusOpenApi3.AnyType() // AnyType | 
};
apiInstance.sessionswipeDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the session swipe to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionswipeGet

> sessionswipeGet(id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionswipeApi();
let id = null; // String | The id of the swipe to get.
apiInstance.sessionswipeGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the swipe to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionswipeListunresolved

> sessionswipeListunresolved(from, count)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionswipeApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.sessionswipeListunresolved(from, count, (error, data, response) => {
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


## sessionswipeResolve

> sessionswipeResolve(id, opts)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionswipeApi();
let id = null; // String | The id of the swipe to resolve.
let opts = {
  'session': null, // String | The id of the session whose swipe has to be saved.
  'user': null // String | The id of the user who signed-in.
};
apiInstance.sessionswipeResolve(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the swipe to resolve. | 
 **session** | [**String**](.md)| The id of the session whose swipe has to be saved. | [optional] 
 **user** | [**String**](.md)| The id of the user who signed-in. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionswipeSave

> sessionswipeSave(opts)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SessionswipeApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionswipeSave(opts, (error, data, response) => {
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


## sessionswipeSaveanonym

> sessionswipeSaveanonym(opts)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.SessionswipeApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionswipeSaveanonym(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

