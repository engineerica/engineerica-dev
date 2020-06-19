# \CreditplanApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreditplanDelete**](CreditplanApi.md#CreditplanDelete) | **Delete** /creditplan/{id} | Deletes a credit plan
[**CreditplanGet**](CreditplanApi.md#CreditplanGet) | **Get** /creditplan/{id} | Gets a credit plan
[**CreditplanList**](CreditplanApi.md#CreditplanList) | **Get** /creditplan/list | Gets the credit plans available
[**CreditplanSave**](CreditplanApi.md#CreditplanSave) | **Post** /creditplan/{id} | Saves a credit plan



## CreditplanDelete

> CreditplanDelete(ctx, id, optional)

Deletes a credit plan

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the credit plan to delete. | 
 **optional** | ***CreditplanDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CreditplanDeleteOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **body** | **optional.Interface{}**|  | 

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


## CreditplanGet

> CreditplanGet(ctx, id)

Gets a credit plan

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the credit plan to get. | 

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


## CreditplanList

> CreditplanList(ctx, from, count)

Gets the credit plans available

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## CreditplanSave

> CreditplanSave(ctx, id, optional)

Saves a credit plan

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the credit save (leave empty to create a new one). | 
 **optional** | ***CreditplanSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CreditplanSaveOpts struct


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

