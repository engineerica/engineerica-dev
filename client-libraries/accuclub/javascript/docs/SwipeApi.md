# AccuClubOpenApi3.SwipeApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**swipeDelete**](SwipeApi.md#swipeDelete) | **DELETE** /swipe/{id} | Delete a swipe
[**swipeGet**](SwipeApi.md#swipeGet) | **GET** /swipe/{id} | Search and view details of a swipe
[**swipeList**](SwipeApi.md#swipeList) | **GET** /swipe/list | View a list of swipes
[**swipeSave**](SwipeApi.md#swipeSave) | **POST** /swipe/save | Create or edit a swipe, and if possible, save the related attendance log
[**swipeSaveanonym**](SwipeApi.md#swipeSaveanonym) | **POST** /swipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log



## swipeDelete

> swipeDelete(id, opts)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.SwipeApi();
let id = null; // String | The id of the swipe to delete.
let opts = {
  'body': new AccuClubOpenApi3.AnyType() // AnyType | 
};
apiInstance.swipeDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the swipe to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## swipeGet

> swipeGet(id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.SwipeApi();
let id = null; // String | The id of the swipe to get.
apiInstance.swipeGet(id, (error, data, response) => {
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


## swipeList

> swipeList(from, count)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.SwipeApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.swipeList(from, count, (error, data, response) => {
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


## swipeSave

> swipeSave(opts)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.SwipeApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.swipeSave(opts, (error, data, response) => {
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


## swipeSaveanonym

> swipeSaveanonym(opts)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.SwipeApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.swipeSaveanonym(opts, (error, data, response) => {
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

