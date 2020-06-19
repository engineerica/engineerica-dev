# \AttendancelogApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttendancelogDelete**](AttendancelogApi.md#AttendancelogDelete) | **Delete** /attendancelog/{id} | Delete an attendance log
[**AttendancelogGet**](AttendancelogApi.md#AttendancelogGet) | **Get** /attendancelog/{id} | Search and view details of an attendance log
[**AttendancelogGetchangehistory**](AttendancelogApi.md#AttendancelogGetchangehistory) | **Get** /attendancelog/getchangehistory | Search and view details of an attendance log&#39;s swipe history
[**AttendancelogList**](AttendancelogApi.md#AttendancelogList) | **Get** /attendancelog/list | View a list of attendance logs
[**AttendancelogListmine**](AttendancelogApi.md#AttendancelogListmine) | **Get** /attendancelog/listmine | Gets the attendance logs of the current user
[**AttendancelogSave**](AttendancelogApi.md#AttendancelogSave) | **Post** /attendancelog/{id} | Create or edit an attendance log
[**AttendancelogSignout**](AttendancelogApi.md#AttendancelogSignout) | **Get** /attendancelog/signout | Sign out an attendance log
[**AttendancelogWhosin**](AttendancelogApi.md#AttendancelogWhosin) | **Get** /attendancelog/whosin | View who&#39;s in a location



## AttendancelogDelete

> AttendancelogDelete(ctx, id, optional)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the attendance log to delete. | 
 **optional** | ***AttendancelogDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogDeleteOpts struct


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


## AttendancelogGet

> AttendancelogGet(ctx, id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the attendance log to get. | 

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


## AttendancelogGetchangehistory

> AttendancelogGetchangehistory(ctx, id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the attendance log to get. | 

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


## AttendancelogList

> AttendancelogList(ctx, from, count, optional)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AttendancelogListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **filter** | **optional.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | 
 **userid** | [**optional.Interface of string**](.md)| The user ID of the user to get the logs. | 

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


## AttendancelogListmine

> AttendancelogListmine(ctx, from, count, optional)

Gets the attendance logs of the current user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AttendancelogListmineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogListmineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **filter** | **optional.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | 

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


## AttendancelogSave

> AttendancelogSave(ctx, id, optional)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the room to save (leave empty to create a new one). | 
 **optional** | ***AttendancelogSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogSaveOpts struct


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


## AttendancelogSignout

> AttendancelogSignout(ctx, optional)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AttendancelogSignoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogSignoutOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**optional.Interface of string**](.md)| The id of the attendance log to sign-out. | 
 **location** | [**optional.Interface of string**](.md)| The id of the location to filter the users to sign out. | 
 **event** | [**optional.Interface of string**](.md)| The id of the event to filter the users to sign out. | 
 **datetime** | **optional.Time**| Specifies the date and time when the specified logs have to be signed out. | 

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


## AttendancelogWhosin

> AttendancelogWhosin(ctx, from, count, optional)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AttendancelogWhosinOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogWhosinOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **location** | [**optional.Interface of string**](.md)| The id of the location to search for users that are in. | 
 **event** | [**optional.Interface of string**](.md)| The id of the event to search for users that are in. | 
 **sorting** | **optional.String**| Field to sort by. Either first-name, last-name or sign-in-time. | 
 **roles** | **optional.String**| The comma-separated list of ids of the roles to search for users that are in. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 
 **extensions** | **optional.String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | 
 **export** | **optional.Bool**| True to export the results as CSV | 

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

