# \SessionregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionregAddcurrentuser**](SessionregApi.md#SessionregAddcurrentuser) | **Get** /sessionreg/addcurrentuser | Register current user to an event session
[**SessionregAdduser**](SessionregApi.md#SessionregAdduser) | **Get** /sessionreg/adduser | Register users for events
[**SessionregGetmysessions**](SessionregApi.md#SessionregGetmysessions) | **Get** /sessionreg/getmysessions | View all the sessions the logged user is registered to
[**SessionregGetsessions**](SessionregApi.md#SessionregGetsessions) | **Get** /sessionreg/getsessions | Lists the registrations for a specific user
[**SessionregGetsettings**](SessionregApi.md#SessionregGetsettings) | **Get** /sessionreg/getsettings | Get the settings for session registration
[**SessionregGetusers**](SessionregApi.md#SessionregGetusers) | **Get** /sessionreg/getusers | Lists the registrations for a specific session
[**SessionregListsessions**](SessionregApi.md#SessionregListsessions) | **Get** /sessionreg/listsessions | List the sessions available for a specific event
[**SessionregListupcoming**](SessionregApi.md#SessionregListupcoming) | **Get** /sessionreg/listupcoming | View a list of upcoming event sessions
[**SessionregListupcomingevent**](SessionregApi.md#SessionregListupcomingevent) | **Get** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
[**SessionregRemovecurrentuser**](SessionregApi.md#SessionregRemovecurrentuser) | **Get** /sessionreg/removecurrentuser | Unregister current user from an event session
[**SessionregRemoveuser**](SessionregApi.md#SessionregRemoveuser) | **Get** /sessionreg/removeuser | Removes a user from an event session
[**SessionregSavesettings**](SessionregApi.md#SessionregSavesettings) | **Post** /sessionreg/savesettings | Save the settings for an event&#39;s session registration



## SessionregAddcurrentuser

> SessionregAddcurrentuser(ctx, eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The id of the event. | 
**sessiondate** | **time.Time**| The date and time when the session starts. | 

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


## SessionregAdduser

> SessionregAdduser(ctx, userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to add. | 
**eventid** | [**string**](.md)| The id of the event. | 
**sessiondate** | **time.Time**| The date and time when the session starts. | 

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


## SessionregGetmysessions

> SessionregGetmysessions(ctx, optional)

View all the sessions the logged user is registered to

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionregGetmysessionsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionregGetmysessionsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **optional.Time**| Start date to filter the sessions. | 

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


## SessionregGetsessions

> SessionregGetsessions(ctx, userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The user id to list sessions. | 

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


## SessionregGetsettings

> SessionregGetsettings(ctx, optional)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionregGetsettingsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionregGetsettingsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**optional.Interface of string**](.md)| The id of the location to save settings. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event to save settings. | 
 **sessiondate** | **optional.Time**| The date and time when the session starts. | 
 **noinherit** | **optional.Bool**| True to get the location/event/session specific settings without looking for the more global settings. | 

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


## SessionregGetusers

> SessionregGetusers(ctx, eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The event id to list sessions. | 
**sessiondate** | **time.Time**| The date of the session to find. | 

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


## SessionregListsessions

> SessionregListsessions(ctx, eventid, optional)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The event id to list sessions. | 
 **optional** | ***SessionregListsessionsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionregListsessionsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **sessiondate** | **optional.Time**| The date of the session to find. | 

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


## SessionregListupcoming

> SessionregListupcoming(ctx, date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**date** | **time.Time**| Only sessions in the week of the specified date will be returned. | 

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


## SessionregListupcomingevent

> SessionregListupcomingevent(ctx, date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**date** | **time.Time**| Start date to filter the returned sessions. | 
**event** | [**string**](.md)| The id of the event whose sessions will be returned | 

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


## SessionregRemovecurrentuser

> SessionregRemovecurrentuser(ctx, eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The id of the event. | 
**sessiondate** | **time.Time**| The date and time when the session starts. | 

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


## SessionregRemoveuser

> SessionregRemoveuser(ctx, userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to remove. | 
**eventid** | [**string**](.md)| The id of the event. | 
**sessiondate** | **time.Time**| The date and time when the session starts. | 

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


## SessionregSavesettings

> SessionregSavesettings(ctx, optional)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionregSavesettingsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionregSavesettingsOpts struct


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

