# \AppshareApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppshareGetphone**](AppshareApi.md#AppshareGetphone) | **Get** /appshare/getphone | Gets the phone number of the current user
[**AppshareSendtext**](AppshareApi.md#AppshareSendtext) | **Get** /appshare/sendtext | Sends an SMS with the link to the app



## AppshareGetphone

> AppshareGetphone(ctx, )

Gets the phone number of the current user

### Required Parameters

This endpoint does not need any parameter.

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


## AppshareSendtext

> AppshareSendtext(ctx, optional)

Sends an SMS with the link to the app

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AppshareSendtextOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppshareSendtextOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phonenumber** | **optional.String**| Phone number to where to send the link. Leave empty to the number on file. | 

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

