# AccuTrainingOpenApi3.AppshareApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appshareGetphone**](AppshareApi.md#appshareGetphone) | **GET** /appshare/getphone | Gets the phone number of the current user
[**appshareSendtext**](AppshareApi.md#appshareSendtext) | **GET** /appshare/sendtext | Sends an SMS with the link to the app



## appshareGetphone

> appshareGetphone()

Gets the phone number of the current user

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.AppshareApi();
apiInstance.appshareGetphone((error, data, response) => {
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


## appshareSendtext

> appshareSendtext(opts)

Sends an SMS with the link to the app

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.AppshareApi();
let opts = {
  'phonenumber': "phonenumber_example" // String | Phone number to where to send the link. Leave empty to the number on file.
};
apiInstance.appshareSendtext(opts, (error, data, response) => {
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
 **phonenumber** | **String**| Phone number to where to send the link. Leave empty to the number on file. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

