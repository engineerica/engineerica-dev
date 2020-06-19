# AccuTrainingOpenApi3.SearchApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**searchGetentities**](SearchApi.md#searchGetentities) | **GET** /search/getentities | Get the information of the entities that can be searched



## searchGetentities

> searchGetentities()

Get the information of the entities that can be searched

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.SearchApi();
apiInstance.searchGetentities((error, data, response) => {
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

