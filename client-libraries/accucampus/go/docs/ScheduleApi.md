# \ScheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScheduleDelete**](ScheduleApi.md#ScheduleDelete) | **Delete** /schedule/delete | Delete a schedule slot
[**ScheduleDeletemine**](ScheduleApi.md#ScheduleDeletemine) | **Delete** /schedule/deletemine | Delete a specific block from a user&#39;s own schedule
[**ScheduleEnable**](ScheduleApi.md#ScheduleEnable) | **Get** /schedule/enable | Enable or disable the schedule for a specific person
[**ScheduleEnablemine**](ScheduleApi.md#ScheduleEnablemine) | **Get** /schedule/enablemine | Enable or disable current user&#39;s schedule
[**ScheduleFindallstaffslots**](ScheduleApi.md#ScheduleFindallstaffslots) | **Get** /schedule/findallstaffslots | Search available schedule slots by service, event, date
[**ScheduleFindslots**](ScheduleApi.md#ScheduleFindslots) | **Get** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
[**ScheduleFindstaffavail**](ScheduleApi.md#ScheduleFindstaffavail) | **Get** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
[**ScheduleGet**](ScheduleApi.md#ScheduleGet) | **Get** /schedule/get | Search and view details of a specific schedule slot
[**ScheduleGetmine**](ScheduleApi.md#ScheduleGetmine) | **Get** /schedule/getmine | View details of a specific schedule block, for current user
[**ScheduleGetstaff**](ScheduleApi.md#ScheduleGetstaff) | **Get** /schedule/getstaff | View a list of schedule information of a specified person
[**ScheduleGetstaffmine**](ScheduleApi.md#ScheduleGetstaffmine) | **Get** /schedule/getstaffmine | View current user&#39;s schedule information
[**ScheduleMyofftimes**](ScheduleApi.md#ScheduleMyofftimes) | **Get** /schedule/myofftimes | View current user&#39;s schedule exceptions
[**ScheduleSave**](ScheduleApi.md#ScheduleSave) | **Post** /schedule/save | Create or edit a schedule slot
[**ScheduleSavemine**](ScheduleApi.md#ScheduleSavemine) | **Post** /schedule/savemine | Create or edit a block in current user&#39;s schedule



## ScheduleDelete

> ScheduleDelete(ctx, optional)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleDeleteOpts struct


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


## ScheduleDeletemine

> ScheduleDeletemine(ctx, optional)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleDeletemineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleDeletemineOpts struct


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


## ScheduleEnable

> ScheduleEnable(ctx, userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to enable or disable the schedule. | 
**enable** | **bool**| True to enable schedules, false to disable. | 

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


## ScheduleEnablemine

> ScheduleEnablemine(ctx, enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**enable** | **bool**| True to enable schedules, false to disable. | 

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


## ScheduleFindallstaffslots

> ScheduleFindallstaffslots(ctx, starttime, endtime, optional)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
 **optional** | ***ScheduleFindallstaffslotsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleFindallstaffslotsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **staffid** | [**optional.Interface of string**](.md)| The id of the staff to filter by. | 
 **serviceids** | **optional.String**| CSV list of the service Ids to filter by. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the location to filter by. | 
 **staffroleids** | **optional.String**| CSV list of the staff member role ids to filter by. | 
 **availablefor** | **optional.String**| The specific availability type to filter by. | 

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


## ScheduleFindslots

> ScheduleFindslots(ctx, staffid, starttime, endtime, optional)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**staffid** | [**string**](.md)| The id of the staff to filter by. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
 **optional** | ***ScheduleFindslotsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleFindslotsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **serviceids** | **optional.String**| CSV list of the service Ids to filter by. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the service to filter by. | 
 **availablefor** | **optional.String**| The specific availability type to filter by. | 

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


## ScheduleFindstaffavail

> ScheduleFindstaffavail(ctx, starttime, endtime, optional)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
 **optional** | ***ScheduleFindstaffavailOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleFindstaffavailOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **serviceids** | **optional.String**| CSV list of the service ids to filter by. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the service to filter by. | 
 **staffroleids** | **optional.String**| CSV list of the staff member role ids to filter by. | 
 **availablefor** | **optional.String**| Filter slots by a specific availability type. | 
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


## ScheduleGet

> ScheduleGet(ctx, scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**scheduleid** | [**string**](.md)| The id of the schedule. | 

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


## ScheduleGetmine

> ScheduleGetmine(ctx, scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**scheduleid** | [**string**](.md)| The id of the schedule. | 

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


## ScheduleGetstaff

> ScheduleGetstaff(ctx, userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to get info. | 

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


## ScheduleGetstaffmine

> ScheduleGetstaffmine(ctx, )

View current user's schedule information

Allows the user to view their own schedule.

### Required Parameters

This endpoint does not need any parameter.

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


## ScheduleMyofftimes

> ScheduleMyofftimes(ctx, optional)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleMyofftimesOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleMyofftimesOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includedeleted** | **optional.Bool**| If true the deleted offtimes are also returned. | 
 **onlyupcoming** | **optional.Bool**| If true then only upcoming offtimes are returned. | 
 **modifiedafter** | **optional.Time**| If specified, only offtimes modified after the specified date will be returned. | 

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


## ScheduleSave

> ScheduleSave(ctx, optional)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleSaveOpts struct


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


## ScheduleSavemine

> ScheduleSavemine(ctx, optional)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleSavemineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleSavemineOpts struct


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

