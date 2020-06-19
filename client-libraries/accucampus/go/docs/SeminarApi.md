# \SeminarApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SeminarDelete**](SeminarApi.md#SeminarDelete) | **Delete** /seminar/{id} | Delete an event
[**SeminarGet**](SeminarApi.md#SeminarGet) | **Get** /seminar/{id} | Search and view details of a event
[**SeminarList**](SeminarApi.md#SeminarList) | **Get** /seminar/list | View a list of events
[**SeminarSave**](SeminarApi.md#SeminarSave) | **Post** /seminar/{id} | Create or edit a event



## SeminarDelete

> SeminarDelete(ctx, id, optional)

Delete an event

Allows the user to delete an existing event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the seminar to delete. | 
 **optional** | ***SeminarDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SeminarDeleteOpts struct


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


## SeminarGet

> SeminarGet(ctx, id)

Search and view details of a event

Allows the user to view a event and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the seminar to get. | 

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


## SeminarList

> SeminarList(ctx, from, count, optional)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **string**| The first record to return. | 
**count** | **string**| The max number of records to return. | 
 **optional** | ***SeminarListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SeminarListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **summaryonly** | **optional.Bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | 
 **termid** | [**optional.Interface of string**](.md)| Id of the term to list the events. Null to list all events. | 

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


## SeminarSave

> SeminarSave(ctx, id, optional)

Create or edit a event

Allows the user to create or edit a event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the event to save (leave empty to create a new one). | 
 **optional** | ***SeminarSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SeminarSaveOpts struct


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

