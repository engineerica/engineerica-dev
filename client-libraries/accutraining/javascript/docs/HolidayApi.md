# AccuTrainingOpenApi3.HolidayApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**holidayList**](HolidayApi.md#holidayList) | **GET** /holiday/list | View a list of entered holidays
[**holidaySave**](HolidayApi.md#holidaySave) | **POST** /holiday/save | Create or edit a list of holidays
[**holidaySuggest**](HolidayApi.md#holidaySuggest) | **GET** /holiday/suggest | View the holiday suggestions in the given term



## holidayList

> holidayList(term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.HolidayApi();
let term = null; // String | The term to get holidays from.
apiInstance.holidayList(term, (error, data, response) => {
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
 **term** | [**String**](.md)| The term to get holidays from. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## holidaySave

> holidaySave(opts)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.HolidayApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuTrainingOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.holidaySave(opts, (error, data, response) => {
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


## holidaySuggest

> holidaySuggest(term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.HolidayApi();
let term = null; // String | The term to get holidays from.
apiInstance.holidaySuggest(term, (error, data, response) => {
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
 **term** | [**String**](.md)| The term to get holidays from. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

