# \EventApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventChecksessions**](EventApi.md#EventChecksessions) | **Get** /event/checksessions | Edit an event&#39;s sessions according to their schedule
[**EventDelete**](EventApi.md#EventDelete) | **Delete** /event/{id} | Delete a course
[**EventGet**](EventApi.md#EventGet) | **Get** /event/{id} | Search and view details of a course
[**EventGetsessionsbydate**](EventApi.md#EventGetsessionsbydate) | **Get** /event/getsessionsbydate | View a list of courses by date
[**EventList**](EventApi.md#EventList) | **Get** /event/list | View a list of courses
[**EventListregistered**](EventApi.md#EventListregistered) | **Get** /event/listregistered | View a list of courses I am registered to
[**EventSave**](EventApi.md#EventSave) | **Post** /event/{id} | Create or edit a course
[**EventSearchgroup**](EventApi.md#EventSearchgroup) | **Get** /event/searchgroup | Searches for the available event groups



## EventChecksessions

> EventChecksessions(ctx, eventid, autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The id of the event to check. | 
**autorepair** | **bool**| True to automatically fix the invalid sessions. | 

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


## EventDelete

> EventDelete(ctx, id, optional)

Delete a course

Allows the user to delete an existing course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the event to delete. | 
 **optional** | ***EventDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventDeleteOpts struct


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


## EventGet

> EventGet(ctx, id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the event to get. | 

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


## EventGetsessionsbydate

> EventGetsessionsbydate(ctx, optional)

View a list of courses by date

Allows the user to view a list of courses by date.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***EventGetsessionsbydateOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventGetsessionsbydateOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**optional.Interface of string**](.md)| The location to filter the events. | 
 **date** | **optional.Time**| The date to filter the events. Today will be used if this parameter is omitted. | 
 **type_** | **optional.String**| Type of event to list. | 

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


## EventList

> EventList(ctx, from, count, optional)

View a list of courses

Allows the user to view the full list of courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **string**| The first record to return. | 
**count** | **string**| The max number of records to return. | 
 **optional** | ***EventListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventListOpts struct


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


## EventListregistered

> EventListregistered(ctx, from, count, optional)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **string**| The first record to return. | 
**count** | **string**| The max number of records to return. | 
 **optional** | ***EventListregisteredOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventListregisteredOpts struct


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


## EventSave

> EventSave(ctx, id, optional)

Create or edit a course

Allows the user to create or edit a course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the event to save (leave empty to create a new one). | 
 **optional** | ***EventSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventSaveOpts struct


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


## EventSearchgroup

> EventSearchgroup(ctx, query)

Searches for the available event groups

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**query** | [**string**](.md)| Query to search event groups. | 

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

