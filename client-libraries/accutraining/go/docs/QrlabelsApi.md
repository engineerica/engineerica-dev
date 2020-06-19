# \QrlabelsApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QrlabelsPrint**](QrlabelsApi.md#QrlabelsPrint) | **Get** /qrlabels/print | Print and email QR labels



## QrlabelsPrint

> QrlabelsPrint(ctx, optional)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***QrlabelsPrintOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a QrlabelsPrintOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**optional.Interface of string**](.md)| The id of the user whose label needs to be printed. | 
 **group** | [**optional.Interface of string**](.md)| The id of the group whose members&#39; labels need to be printed. | 

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

