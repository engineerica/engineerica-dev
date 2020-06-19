# AccuTrainingOpenApi3.ActionlogApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionlogList**](ActionlogApi.md#actionlogList) | **GET** /actionlog/list | View a list of users action logs



## actionlogList

> actionlogList(from, count, opts)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';
let defaultClient = AccuTrainingOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuTrainingOpenApi3.ActionlogApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'user': null, // String | The id of the user whose action logs have to be returned.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the logs.
  'enddate': new Date("2013-10-20T19:20:30+01:00"), // Date | The end date of the period to filter the logs.
  'resource': "resource_example", // String | The resource to filter the action logs.
  'actionfilter': "actionfilter_example", // String | The action to filter the action logs.
  'argument': "argument_example" // String | The id of the entity that was the argument of the executed action.
};
apiInstance.actionlogList(from, count, opts, (error, data, response) => {
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
 **user** | [**String**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the logs. | [optional] 
 **resource** | **String**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **String**| The action to filter the action logs. | [optional] 
 **argument** | **String**| The id of the entity that was the argument of the executed action. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

