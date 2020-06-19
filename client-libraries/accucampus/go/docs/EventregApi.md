# \EventregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventregAddme**](EventregApi.md#EventregAddme) | **Get** /eventreg/addme | Register current user to a course
[**EventregAddmetoall**](EventregApi.md#EventregAddmetoall) | **Get** /eventreg/addmetoall | Register current user to all courses
[**EventregAddmetogroup**](EventregApi.md#EventregAddmetogroup) | **Get** /eventreg/addmetogroup | Register current user to a course group
[**EventregAdduser**](EventregApi.md#EventregAdduser) | **Get** /eventreg/adduser | Register a user to a course for attendance
[**EventregAddusertoall**](EventregApi.md#EventregAddusertoall) | **Get** /eventreg/addusertoall | Register a user to assist with all courses
[**EventregAddusertogroup**](EventregApi.md#EventregAddusertogroup) | **Get** /eventreg/addusertogroup | Register a user to an course group
[**EventregGetevents**](EventregApi.md#EventregGetevents) | **Get** /eventreg/getevents | View course registration by user
[**EventregGetgroups**](EventregApi.md#EventregGetgroups) | **Get** /eventreg/getgroups | Lists the course group registrations of a user
[**EventregGetmyevents**](EventregApi.md#EventregGetmyevents) | **Get** /eventreg/getmyevents | View the event registrations of the current user
[**EventregGetmygroups**](EventregApi.md#EventregGetmygroups) | **Get** /eventreg/getmygroups | View all current user registrations to course groups
[**EventregGetusers**](EventregApi.md#EventregGetusers) | **Get** /eventreg/getusers | View course registration
[**EventregGetusersfromgroup**](EventregApi.md#EventregGetusersfromgroup) | **Get** /eventreg/getusersfromgroup | Lists the registrations for a course group
[**EventregGetuserstoall**](EventregApi.md#EventregGetuserstoall) | **Get** /eventreg/getuserstoall | View the users that are registered to all courses
[**EventregRemoveme**](EventregApi.md#EventregRemoveme) | **Get** /eventreg/removeme | Unregister current user from a course
[**EventregRemovemefromall**](EventregApi.md#EventregRemovemefromall) | **Get** /eventreg/removemefromall | Remove current user from the registration to all courses
[**EventregRemovemefromgroup**](EventregApi.md#EventregRemovemefromgroup) | **Get** /eventreg/removemefromgroup | Remove current user from a course group
[**EventregRemoveuser**](EventregApi.md#EventregRemoveuser) | **Get** /eventreg/removeuser | Remove a user from a course
[**EventregRemoveuserfromall**](EventregApi.md#EventregRemoveuserfromall) | **Get** /eventreg/removeuserfromall | Remove a user from the registration to all courses
[**EventregRemoveuserfromgroup**](EventregApi.md#EventregRemoveuserfromgroup) | **Get** /eventreg/removeuserfromgroup | Remove a user from a course group



## EventregAddme

> EventregAddme(ctx, eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The id of the event. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## EventregAddmetoall

> EventregAddmetoall(ctx, listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## EventregAddmetogroup

> EventregAddmetogroup(ctx, codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**codegroup** | **string**| The code used to group events. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## EventregAdduser

> EventregAdduser(ctx, userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to add. | 
**eventid** | [**string**](.md)| The id of the event. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## EventregAddusertoall

> EventregAddusertoall(ctx, userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to add. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## EventregAddusertogroup

> EventregAddusertogroup(ctx, userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to add. | 
**codegroup** | **string**| The code used to group events. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## EventregGetevents

> EventregGetevents(ctx, userid, listname, optional)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The user id to list events. | 
**listname** | **string**| The name of the list where the user is registered. | 
 **optional** | ***EventregGeteventsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventregGeteventsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **termid** | [**optional.Interface of string**](.md)| The term id to list events. | 
 **namefilter** | **optional.String**| The value used to filter the events by name. | 

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


## EventregGetgroups

> EventregGetgroups(ctx, userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The user id to list events. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## EventregGetmyevents

> EventregGetmyevents(ctx, listname, optional)

View the event registrations of the current user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**listname** | **string**| The name of the list where the user is registered. | 
 **optional** | ***EventregGetmyeventsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventregGetmyeventsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **termid** | [**optional.Interface of string**](.md)| The term id to list events. | 
 **namefilter** | **optional.String**| The value used to filter the events by name. | 

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


## EventregGetmygroups

> EventregGetmygroups(ctx, listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**listname** | **string**| The name of the list where the user is registered. | 

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


## EventregGetusers

> EventregGetusers(ctx, eventid, listname, optional)

View course registration

Allows the user to view all users registered for an individual course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The event id to list users. | 
**listname** | **string**| The name of the list to get. | 
 **optional** | ***EventregGetusersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventregGetusersOpts struct


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


## EventregGetusersfromgroup

> EventregGetusersfromgroup(ctx, codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**codegroup** | [**string**](.md)| The code group to list users. | 
**listname** | **string**| The name of the list to get. | 

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


## EventregGetuserstoall

> EventregGetuserstoall(ctx, listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**listname** | **string**| The name of the list to get. | 

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


## EventregRemoveme

> EventregRemoveme(ctx, eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The id of the event. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## EventregRemovemefromall

> EventregRemovemefromall(ctx, listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**listname** | **string**| The name of the list where the user is registered. | 

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


## EventregRemovemefromgroup

> EventregRemovemefromgroup(ctx, codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**codegroup** | [**string**](.md)| The code group of the events/courses. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## EventregRemoveuser

> EventregRemoveuser(ctx, userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to remove. | 
**eventid** | [**string**](.md)| The id of the event. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## EventregRemoveuserfromall

> EventregRemoveuserfromall(ctx, userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to remove. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## EventregRemoveuserfromgroup

> EventregRemoveuserfromgroup(ctx, userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to remove. | 
**codegroup** | [**string**](.md)| The code group of the events/courses. | 
**listname** | **string**| The name of the list where the user is registered. | 

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

