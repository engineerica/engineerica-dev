# \TranslationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TranslationGet**](TranslationApi.md#TranslationGet) | **Get** /translation/get | Gets the translations of the specified values
[**TranslationGetcachefile**](TranslationApi.md#TranslationGetcachefile) | **Get** /translation/getcachefile | Get the file containing the translations
[**TranslationList**](TranslationApi.md#TranslationList) | **Get** /translation/list | Lists all the available translations in the system
[**TranslationSave**](TranslationApi.md#TranslationSave) | **Post** /translation/{id} | Edit a translation



## TranslationGet

> TranslationGet(ctx, universal)

Gets the translations of the specified values

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**universal** | **string**| Pipe separated list of universal text to be translated. | 

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


## TranslationGetcachefile

> TranslationGetcachefile(ctx, optional)

Get the file containing the translations

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TranslationGetcachefileOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TranslationGetcachefileOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **optional.String**| The id of the account whose translations file has to be retrieved. | 

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


## TranslationList

> TranslationList(ctx, optional)

Lists all the available translations in the system

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TranslationListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TranslationListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **optional.String**| Text to search/filter translations. | 
 **nondefaultonly** | **optional.Bool**| If true then it returns only the terms translated. Otherwise, it returns all. | 
 **appdefaultasuniversal** | **optional.Bool**| If true then it uses the app default translation as the universal term. | 

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


## TranslationSave

> TranslationSave(ctx, id, optional)

Edit a translation

Allows the user to edit a translation for the entire account.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | **string**| The id of the translation as returned by translation.list. | 
 **optional** | ***TranslationSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TranslationSaveOpts struct


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

