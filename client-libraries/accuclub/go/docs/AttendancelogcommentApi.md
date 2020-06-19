# \AttendancelogcommentApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttendancelogcommentDelete**](AttendancelogcommentApi.md#AttendancelogcommentDelete) | **Delete** /attendancelogcomment/{id} | Delete a comment on an attendance log
[**AttendancelogcommentGet**](AttendancelogcommentApi.md#AttendancelogcommentGet) | **Get** /attendancelogcomment/{id} | View a comment on an attendance log
[**AttendancelogcommentList**](AttendancelogcommentApi.md#AttendancelogcommentList) | **Get** /attendancelogcomment/list | View all the comments on a specific attendance log
[**AttendancelogcommentSave**](AttendancelogcommentApi.md#AttendancelogcommentSave) | **Post** /attendancelogcomment/{id} | Save a comment on an attendance log



## AttendancelogcommentDelete

> AttendancelogcommentDelete(ctx, id, optional)

Delete a comment on an attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the attendance log comment to delete. | 
 **optional** | ***AttendancelogcommentDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogcommentDeleteOpts struct


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


## AttendancelogcommentGet

> AttendancelogcommentGet(ctx, id)

View a comment on an attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the comment to get. | 

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


## AttendancelogcommentList

> AttendancelogcommentList(ctx, attendancelog)

View all the comments on a specific attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**attendancelog** | [**string**](.md)| The id of the attendance log whose comments have to be retrieved. | 

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


## AttendancelogcommentSave

> AttendancelogcommentSave(ctx, id, optional)

Save a comment on an attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the comment to edit (leave empty to create a new one) | 
 **optional** | ***AttendancelogcommentSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogcommentSaveOpts struct


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

