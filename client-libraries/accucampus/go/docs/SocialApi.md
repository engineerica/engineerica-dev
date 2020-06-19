# \SocialApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SocialContacts**](SocialApi.md#SocialContacts) | **Get** /social/contacts | Gets the list of contacts in the network



## SocialContacts

> SocialContacts(ctx, optional)

Gets the list of contacts in the network

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SocialContactsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SocialContactsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **optional.String**| Text to filter results. | 
 **showdefaultphoto** | **optional.Bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | 

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

