# AccuTrainingOpenApi3.MemorizedreportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**memorizedreportDelete**](MemorizedreportApi.md#memorizedreportDelete) | **DELETE** /memorizedreport/{id} | Delete memorized report
[**memorizedreportGet**](MemorizedreportApi.md#memorizedreportGet) | **GET** /memorizedreport/{id} | View details of a memorized report
[**memorizedreportList**](MemorizedreportApi.md#memorizedreportList) | **GET** /memorizedreport/list | View a list of all his memorized reports
[**memorizedreportSave**](MemorizedreportApi.md#memorizedreportSave) | **POST** /memorizedreport/{id} | Create or edit a memorized report



## memorizedreportDelete

> memorizedreportDelete(id, opts)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.MemorizedreportApi();
let id = null; // String | The id of the report settings to delete.
let opts = {
  'body': new AccuTrainingOpenApi3.AnyType() // AnyType | 
};
apiInstance.memorizedreportDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the report settings to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## memorizedreportGet

> memorizedreportGet(id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.MemorizedreportApi();
let id = null; // String | The id of the report configuration to get.
apiInstance.memorizedreportGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the report configuration to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## memorizedreportList

> memorizedreportList(from, count, opts)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.MemorizedreportApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'customname': "customname_example" // String | If specified filters the memorized reports by custom name.
};
apiInstance.memorizedreportList(from, count, opts, (error, data, response) => {
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
 **customname** | **String**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## memorizedreportSave

> memorizedreportSave(id, opts)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.MemorizedreportApi();
let id = null; // String | The id of the report settings to save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuTrainingOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.memorizedreportSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the report settings to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

