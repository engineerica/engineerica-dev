# AccuTrainingOpenApi3.SsoApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ssoGeneratekey**](SsoApi.md#ssoGeneratekey) | **GET** /sso/generatekey | Generate/reset single sign on access key.
[**ssoGetsettings**](SsoApi.md#ssoGetsettings) | **GET** /sso/getsettings | View single sign on settings.
[**ssoIssuetoken**](SsoApi.md#ssoIssuetoken) | **GET** /sso/issuetoken | Issue single sign-on token
[**ssoSavesettings**](SsoApi.md#ssoSavesettings) | **POST** /sso/savesettings | Edit single sign-on settings.



## ssoGeneratekey

> ssoGeneratekey()

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.SsoApi();
apiInstance.ssoGeneratekey((error, data, response) => {
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


## ssoGetsettings

> ssoGetsettings()

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.SsoApi();
apiInstance.ssoGetsettings((error, data, response) => {
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


## ssoIssuetoken

> ssoIssuetoken(key, username, opts)

Issue single sign-on token

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';

let apiInstance = new AccuTrainingOpenApi3.SsoApi();
let key = "key_example"; // String | The single sign-on key of the account.
let username = "username_example"; // String | The email of the user to sign-on.
let opts = {
  'expires': true // Boolean | Specifies whether the session should expire when inactive.
};
apiInstance.ssoIssuetoken(key, username, opts, (error, data, response) => {
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
 **key** | **String**| The single sign-on key of the account. | 
 **username** | **String**| The email of the user to sign-on. | 
 **expires** | **Boolean**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ssoSavesettings

> ssoSavesettings(opts)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.SsoApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuTrainingOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.ssoSavesettings(opts, (error, data, response) => {
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

