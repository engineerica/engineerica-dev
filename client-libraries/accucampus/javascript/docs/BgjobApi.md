# AccuCampusOpenApi3.BgjobApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bgjobGetstatus**](BgjobApi.md#bgjobGetstatus) | **GET** /bgjob/getstatus | Get background job status



## bgjobGetstatus

> bgjobGetstatus(opts)

Get background job status

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BgjobApi();
let opts = {
  'jobid': null, // String | The ID of the job to get the status. 10 most recent will be returned if not specified.
  'jobtype': "jobtype_example" // String | The job type to filter by.
};
apiInstance.bgjobGetstatus(opts, (error, data, response) => {
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
 **jobid** | [**String**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **String**| The job type to filter by. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

