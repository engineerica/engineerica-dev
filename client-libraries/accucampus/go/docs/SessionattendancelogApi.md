# \SessionattendancelogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionattendancelogAddnote**](SessionattendancelogApi.md#SessionattendancelogAddnote) | **Get** /sessionattendancelog/addnote | Add a note to a class attendance log
[**SessionattendancelogGet**](SessionattendancelogApi.md#SessionattendancelogGet) | **Get** /sessionattendancelog/{id} | View details of a class attendance log
[**SessionattendancelogGetuser**](SessionattendancelogApi.md#SessionattendancelogGetuser) | **Get** /sessionattendancelog/getuser | View the class session attendance information for a specific user
[**SessionattendancelogList**](SessionattendancelogApi.md#SessionattendancelogList) | **Get** /sessionattendancelog/list | View attendance logs of the specified session
[**SessionattendancelogListevent**](SessionattendancelogApi.md#SessionattendancelogListevent) | **Get** /sessionattendancelog/listevent | View the attendance information of an entire class
[**SessionattendancelogListsummary**](SessionattendancelogApi.md#SessionattendancelogListsummary) | **Get** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
[**SessionattendancelogMylistsummary**](SessionattendancelogApi.md#SessionattendancelogMylistsummary) | **Get** /sessionattendancelog/mylistsummary | View my attendance summary
[**SessionattendancelogSave**](SessionattendancelogApi.md#SessionattendancelogSave) | **Post** /sessionattendancelog/{id} | Create or edit a class attendance log
[**SessionattendancelogSaveswipe**](SessionattendancelogApi.md#SessionattendancelogSaveswipe) | **Post** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe



## SessionattendancelogAddnote

> SessionattendancelogAddnote(ctx, id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the attendance log. | 
**text** | **string**| The text of the note to add. | 

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


## SessionattendancelogGet

> SessionattendancelogGet(ctx, id, optional)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the attendance log to get. | 
 **optional** | ***SessionattendancelogGetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogGetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | 

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


## SessionattendancelogGetuser

> SessionattendancelogGetuser(ctx, attendee, eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**attendee** | [**string**](.md)| The id of the attendee to get statistic for. | 
**eventid** | [**string**](.md)| The id of the event whose attendee statistics have to be returned. | 

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


## SessionattendancelogList

> SessionattendancelogList(ctx, session, from, count, optional)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**session** | [**string**](.md)| The id of the session whose attendees logs have to be returned. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***SessionattendancelogListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## SessionattendancelogListevent

> SessionattendancelogListevent(ctx, eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The id of the event whose attendance has to be returned. | 

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


## SessionattendancelogListsummary

> SessionattendancelogListsummary(ctx, optional)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionattendancelogListsummaryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogListsummaryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**optional.Interface of string**](.md)| The id of the event whose attendance has to be returned. | 
 **attendeeid** | [**optional.Interface of string**](.md)| The id of the attendee whose attendance has to be returned. | 
 **groupid** | [**optional.Interface of string**](.md)| The id of the group whose attendance has to be returned. | 
 **start** | **optional.String**| The start date to filter (beginning of time by default). | 
 **end** | **optional.String**| The end date to filter (today by default). | 

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


## SessionattendancelogMylistsummary

> SessionattendancelogMylistsummary(ctx, optional)

View my attendance summary

Allows the user to view their own attendance summary.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionattendancelogMylistsummaryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogMylistsummaryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**optional.Interface of string**](.md)| The id of the event whose attendance has to be returned. | 
 **start** | **optional.String**| The start date to filter (beginning of time by default). | 
 **end** | **optional.String**| The end date to filter (today by default). | 

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


## SessionattendancelogSave

> SessionattendancelogSave(ctx, id, optional)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the att log to save (leave empty to create a new one). | 
 **optional** | ***SessionattendancelogSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogSaveOpts struct


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


## SessionattendancelogSaveswipe

> SessionattendancelogSaveswipe(ctx, optional)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionattendancelogSaveswipeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogSaveswipeOpts struct


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

