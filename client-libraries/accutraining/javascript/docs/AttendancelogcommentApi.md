# AccuTrainingOpenApi3.AttendancelogcommentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogcommentDelete**](AttendancelogcommentApi.md#attendancelogcommentDelete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
[**attendancelogcommentGet**](AttendancelogcommentApi.md#attendancelogcommentGet) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
[**attendancelogcommentList**](AttendancelogcommentApi.md#attendancelogcommentList) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
[**attendancelogcommentSave**](AttendancelogcommentApi.md#attendancelogcommentSave) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log



## attendancelogcommentDelete

> attendancelogcommentDelete(id, opts)

Delete a comment on an attendance log

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.AttendancelogcommentApi();
let id = null; // String | The id of the attendance log comment to delete.
let opts = {
  'body': new AccuTrainingOpenApi3.AnyType() // AnyType | 
};
apiInstance.attendancelogcommentDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the attendance log comment to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## attendancelogcommentGet

> attendancelogcommentGet(id)

View a comment on an attendance log

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.AttendancelogcommentApi();
let id = null; // String | The id of the comment to get.
apiInstance.attendancelogcommentGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the comment to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentList

> attendancelogcommentList(attendancelog)

View all the comments on a specific attendance log

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.AttendancelogcommentApi();
let attendancelog = null; // String | The id of the attendance log whose comments have to be retrieved.
apiInstance.attendancelogcommentList(attendancelog, (error, data, response) => {
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
 **attendancelog** | [**String**](.md)| The id of the attendance log whose comments have to be retrieved. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentSave

> attendancelogcommentSave(id, opts)

Save a comment on an attendance log

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.AttendancelogcommentApi();
let id = null; // String | The id of the comment to edit (leave empty to create a new one)
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuTrainingOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.attendancelogcommentSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the comment to edit (leave empty to create a new one) | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

