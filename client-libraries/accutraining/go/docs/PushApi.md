# \PushApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PushDeregister**](PushApi.md#PushDeregister) | **Get** /push/deregister | Deregisters the current device to receive push notifications
[**PushRegister**](PushApi.md#PushRegister) | **Get** /push/register | Registers the current device to receive push notifications



## PushDeregister

> PushDeregister(ctx, devicetoken, platform)

Deregisters the current device to receive push notifications

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**devicetoken** | **string**| The device token where to send the notification. | 
**platform** | **string**| Either ios or android | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PushRegister

> PushRegister(ctx, devicetoken, platform)

Registers the current device to receive push notifications

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**devicetoken** | **string**| The device token where to send the notification. | 
**platform** | **string**| Either ios or android | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

