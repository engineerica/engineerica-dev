# \MemorizedreportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MemorizedreportDelete**](MemorizedreportApi.md#MemorizedreportDelete) | **Delete** /memorizedreport/{id} | Delete memorized report
[**MemorizedreportGet**](MemorizedreportApi.md#MemorizedreportGet) | **Get** /memorizedreport/{id} | View details of a memorized report
[**MemorizedreportList**](MemorizedreportApi.md#MemorizedreportList) | **Get** /memorizedreport/list | View a list of all his memorized reports
[**MemorizedreportSave**](MemorizedreportApi.md#MemorizedreportSave) | **Post** /memorizedreport/{id} | Create or edit a memorized report



## MemorizedreportDelete

> MemorizedreportDelete(ctx, id, optional)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the report settings to delete. | 
 **optional** | ***MemorizedreportDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MemorizedreportDeleteOpts struct


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


## MemorizedreportGet

> MemorizedreportGet(ctx, id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the report configuration to get. | 

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


## MemorizedreportList

> MemorizedreportList(ctx, from, count, optional)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***MemorizedreportListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MemorizedreportListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **customname** | **optional.String**| If specified filters the memorized reports by custom name. | 

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


## MemorizedreportSave

> MemorizedreportSave(ctx, id, optional)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the report settings to save (leave empty to create a new one). | 
 **optional** | ***MemorizedreportSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MemorizedreportSaveOpts struct


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

