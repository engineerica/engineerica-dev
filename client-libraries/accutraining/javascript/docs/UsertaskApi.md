# AccuTrainingOpenApi3.UsertaskApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usertaskDeleteplan**](UsertaskApi.md#usertaskDeleteplan) | **DELETE** /usertask/deleteplan | Deletes a task plan
[**usertaskGetmine**](UsertaskApi.md#usertaskGetmine) | **GET** /usertask/getmine | Lists the task plans of the logged user
[**usertaskGetplan**](UsertaskApi.md#usertaskGetplan) | **GET** /usertask/getplan | Gets a task plan by Id
[**usertaskListdefs**](UsertaskApi.md#usertaskListdefs) | **GET** /usertask/listdefs | Lists task types or definitions
[**usertaskListplan**](UsertaskApi.md#usertaskListplan) | **GET** /usertask/listplan | Lists task plans
[**usertaskSaveplan**](UsertaskApi.md#usertaskSaveplan) | **POST** /usertask/saveplan | Saves a task plan



## usertaskDeleteplan

> usertaskDeleteplan(opts)

Deletes a task plan

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.UsertaskApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuTrainingOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.usertaskDeleteplan(opts, (error, data, response) => {
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


## usertaskGetmine

> usertaskGetmine()

Lists the task plans of the logged user

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.UsertaskApi();
apiInstance.usertaskGetmine((error, data, response) => {
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


## usertaskGetplan

> usertaskGetplan(id)

Gets a task plan by Id

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.UsertaskApi();
let id = null; // String | The id of the task plan to get.
apiInstance.usertaskGetplan(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the task plan to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usertaskListdefs

> usertaskListdefs()

Lists task types or definitions

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';

let apiInstance = new AccuTrainingOpenApi3.UsertaskApi();
apiInstance.usertaskListdefs((error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usertaskListplan

> usertaskListplan(from, count)

Lists task plans

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.UsertaskApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.usertaskListplan(from, count, (error, data, response) => {
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


## usertaskSaveplan

> usertaskSaveplan(opts)

Saves a task plan

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.UsertaskApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuTrainingOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.usertaskSaveplan(opts, (error, data, response) => {
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

