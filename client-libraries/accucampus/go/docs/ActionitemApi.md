# \ActionitemApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionitemDelete**](ActionitemApi.md#ActionitemDelete) | **Delete** /actionitem/{id} | Delete an action item
[**ActionitemGet**](ActionitemApi.md#ActionitemGet) | **Get** /actionitem/{id} | Search and view details of an action item
[**ActionitemList**](ActionitemApi.md#ActionitemList) | **Get** /actionitem/list | View a list of action items
[**ActionitemSave**](ActionitemApi.md#ActionitemSave) | **Post** /actionitem/{id} | Create or edit an action item



## ActionitemDelete

> ActionitemDelete(ctx, id, optional)

Delete an action item

Allows the user to delete an action item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the action item to delete. | 
 **optional** | ***ActionitemDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionitemDeleteOpts struct


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


## ActionitemGet

> ActionitemGet(ctx, id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the action item to get. | 

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


## ActionitemList

> ActionitemList(ctx, from, count)

View a list of action items

Allows the user to view a list of action items

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


## ActionitemSave

> ActionitemSave(ctx, id, optional)

Create or edit an action item

Allows the user to edit an action item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the action item to save (leave empty to create a new one). | 
 **optional** | ***ActionitemSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionitemSaveOpts struct


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

