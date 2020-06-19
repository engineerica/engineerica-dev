# \SessionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionBulkupdate**](SessionApi.md#SessionBulkupdate) | **Get** /session/bulkupdate | Bulk update event sessions
[**SessionGet**](SessionApi.md#SessionGet) | **Get** /session/{id} | View details of a session
[**SessionGetschedule**](SessionApi.md#SessionGetschedule) | **Get** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**SessionList**](SessionApi.md#SessionList) | **Get** /session/list | Gets all future sessions of the current semester



## SessionBulkupdate

> SessionBulkupdate(ctx, eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The id of the event to bulk update. | 
**sessions** | **string**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

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


## SessionGet

> SessionGet(ctx, id)

View details of a session

Allows the user to view a session in order to take attendance.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the session to get. | 

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


## SessionGetschedule

> SessionGetschedule(ctx, optional)

Gets the schedule for a location, instructor or attendees

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionGetscheduleOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionGetscheduleOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **day** | **optional.Time**| The day to return. It will also return the whole week for that day. | 
 **attendee** | [**optional.Interface of string**](.md)| The id of the attendee to get the schedule. | 
 **location** | [**optional.Interface of string**](.md)| The id of the location to get the schedule. | 
 **instructor** | [**optional.Interface of string**](.md)| The id of the instructor to get the schedule. | 

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


## SessionList

> SessionList(ctx, from, count, optional)

Gets all future sessions of the current semester

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***SessionListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **startdate** | **optional.Time**| The start date to filter the sessions | 
 **enddate** | **optional.Time**| The end date to filter the sessions. | 

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

