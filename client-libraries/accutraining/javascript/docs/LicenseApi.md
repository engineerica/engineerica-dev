# AccuTrainingOpenApi3.LicenseApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**licenseAcceptagreement**](LicenseApi.md#licenseAcceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
[**licenseGetagreementstatus**](LicenseApi.md#licenseGetagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
[**licenseGetcurrent**](LicenseApi.md#licenseGetcurrent) | **GET** /license/getcurrent | Gets the current license information
[**licenseRenew**](LicenseApi.md#licenseRenew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuTraining subscription



## licenseAcceptagreement

> licenseAcceptagreement()

Accept the license agreement

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.LicenseApi();
apiInstance.licenseAcceptagreement((error, data, response) => {
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


## licenseGetagreementstatus

> licenseGetagreementstatus()

Check if license agreement has been accepted

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.LicenseApi();
apiInstance.licenseGetagreementstatus((error, data, response) => {
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


## licenseGetcurrent

> licenseGetcurrent()

Gets the current license information

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.LicenseApi();
apiInstance.licenseGetcurrent((error, data, response) => {
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


## licenseRenew

> licenseRenew(email, phonenumber, opts)

Contact Engineerica in order to renew the AccuTraining subscription

Allows the user to select the option to contact Engineerica when the AccuTraining account is nearing its renewal date.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.LicenseApi();
let email = "email_example"; // String | The e-mail of the user sending the request.
let phonenumber = "phonenumber_example"; // String | The phone number of the user sending the request.
let opts = {
  'jobtitle': "jobtitle_example", // String | The job title of the user sending the request.
  'institution': "institution_example", // String | The institution of the user sending the request.
  'comments': "comments_example" // String | Comments entered by the user sending the request.
};
apiInstance.licenseRenew(email, phonenumber, opts, (error, data, response) => {
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
 **email** | **String**| The e-mail of the user sending the request. | 
 **phonenumber** | **String**| The phone number of the user sending the request. | 
 **jobtitle** | **String**| The job title of the user sending the request. | [optional] 
 **institution** | **String**| The institution of the user sending the request. | [optional] 
 **comments** | **String**| Comments entered by the user sending the request. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

