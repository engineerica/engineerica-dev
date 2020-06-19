# AccuTrainingOpenApi3.QrloginApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrloginGet**](QrloginApi.md#qrloginGet) | **GET** /qrlogin/get | Gets an image of a QR token
[**qrloginLogin**](QrloginApi.md#qrloginLogin) | **GET** /qrlogin/login | Login



## qrloginGet

> qrloginGet()

Gets an image of a QR token

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.QrloginApi();
apiInstance.qrloginGet((error, data, response) => {
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


## qrloginLogin

> qrloginLogin(onetimetoken)

Login

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';

let apiInstance = new AccuTrainingOpenApi3.QrloginApi();
let onetimetoken = "onetimetoken_example"; // String | The token read from the QR code.
apiInstance.qrloginLogin(onetimetoken, (error, data, response) => {
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
 **onetimetoken** | **String**| The token read from the QR code. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

