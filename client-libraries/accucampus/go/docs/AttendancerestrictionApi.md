# \AttendancerestrictionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttendancerestrictionDelete**](AttendancerestrictionApi.md#AttendancerestrictionDelete) | **Delete** /attendancerestriction/{id} | Delete an attendance restriction
[**AttendancerestrictionGet**](AttendancerestrictionApi.md#AttendancerestrictionGet) | **Get** /attendancerestriction/{id} | View details of an attendance restriction
[**AttendancerestrictionList**](AttendancerestrictionApi.md#AttendancerestrictionList) | **Get** /attendancerestriction/list | View a list of attendance restrictions
[**AttendancerestrictionSave**](AttendancerestrictionApi.md#AttendancerestrictionSave) | **Post** /attendancerestriction/{id} | Create or edit an attendance restriction



## AttendancerestrictionDelete

> AttendancerestrictionDelete(ctx, id, optional)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the restriction to delete. | 
 **optional** | ***AttendancerestrictionDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancerestrictionDeleteOpts struct


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


## AttendancerestrictionGet

> AttendancerestrictionGet(ctx, id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the restriction to get. | 

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


## AttendancerestrictionList

> AttendancerestrictionList(ctx, from, count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

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


## AttendancerestrictionSave

> AttendancerestrictionSave(ctx, id, optional)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the restriction save (leave empty to create a new one). | 
 **optional** | ***AttendancerestrictionSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancerestrictionSaveOpts struct


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

