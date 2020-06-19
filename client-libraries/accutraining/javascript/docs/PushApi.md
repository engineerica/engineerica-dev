# AccuTrainingOpenApi3.PushApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pushDeregister**](PushApi.md#pushDeregister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
[**pushRegister**](PushApi.md#pushRegister) | **GET** /push/register | Registers the current device to receive push notifications



## pushDeregister

> pushDeregister(devicetoken, platform)

Deregisters the current device to receive push notifications

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';

let apiInstance = new AccuTrainingOpenApi3.PushApi();
let devicetoken = "devicetoken_example"; // String | The device token where to send the notification.
let platform = "platform_example"; // String | Either ios or android
apiInstance.pushDeregister(devicetoken, platform, (error, data, response) => {
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
 **devicetoken** | **String**| The device token where to send the notification. | 
 **platform** | **String**| Either ios or android | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## pushRegister

> pushRegister(devicetoken, platform)

Registers the current device to receive push notifications

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';

let apiInstance = new AccuTrainingOpenApi3.PushApi();
let devicetoken = "devicetoken_example"; // String | The device token where to send the notification.
let platform = "platform_example"; // String | Either ios or android
apiInstance.pushRegister(devicetoken, platform, (error, data, response) => {
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
 **devicetoken** | **String**| The device token where to send the notification. | 
 **platform** | **String**| Either ios or android | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

