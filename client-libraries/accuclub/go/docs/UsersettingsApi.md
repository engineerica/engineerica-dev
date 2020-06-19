# \UsersettingsApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersettingsGet**](UsersettingsApi.md#UsersettingsGet) | **Get** /usersettings/get | Lists available user settings
[**UsersettingsGetmultiple**](UsersettingsApi.md#UsersettingsGetmultiple) | **Get** /usersettings/getmultiple | Get multiple user settings
[**UsersettingsSave**](UsersettingsApi.md#UsersettingsSave) | **Post** /usersettings/save | Saves a user setting
[**UsersettingsSavemultiple**](UsersettingsApi.md#UsersettingsSavemultiple) | **Post** /usersettings/savemultiple | Save multiple user settings at once



## UsersettingsGet

> UsersettingsGet(ctx, keys, optional)

Lists available user settings

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **optional** | ***UsersettingsGetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersettingsGetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **user** | [**optional.Interface of string**](.md)| The user id whose settings have to be returned. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersettingsGetmultiple

> UsersettingsGetmultiple(ctx, keys, optional)

Get multiple user settings

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **optional** | ***UsersettingsGetmultipleOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersettingsGetmultipleOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **user** | [**optional.Interface of string**](.md)| The user id whose settings have to be returned. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersettingsSave

> UsersettingsSave(ctx, optional)

Saves a user setting

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UsersettingsSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersettingsSaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UsersettingsSavemultiple

> UsersettingsSavemultiple(ctx, optional)

Save multiple user settings at once

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UsersettingsSavemultipleOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersettingsSavemultipleOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

