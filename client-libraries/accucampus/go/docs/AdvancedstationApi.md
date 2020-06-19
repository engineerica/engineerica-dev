# \AdvancedstationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdvancedstationCheckunknownuser**](AdvancedstationApi.md#AdvancedstationCheckunknownuser) | **Get** /advancedstation/checkunknownuser | Check whether the user is known by the system.
[**AdvancedstationCheckuserrole**](AdvancedstationApi.md#AdvancedstationCheckuserrole) | **Get** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
[**AdvancedstationCreateuser**](AdvancedstationApi.md#AdvancedstationCreateuser) | **Get** /advancedstation/createuser | Creates a user via a sign-in station.
[**AdvancedstationGetevents**](AdvancedstationApi.md#AdvancedstationGetevents) | **Get** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
[**AdvancedstationGetinfo**](AdvancedstationApi.md#AdvancedstationGetinfo) | **Get** /advancedstation/getinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**AdvancedstationGetlocations**](AdvancedstationApi.md#AdvancedstationGetlocations) | **Get** /advancedstation/getlocations | Gets the locations available in a sign-in station.
[**AdvancedstationGetlogstaff**](AdvancedstationApi.md#AdvancedstationGetlogstaff) | **Get** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**AdvancedstationGetroles**](AdvancedstationApi.md#AdvancedstationGetroles) | **Get** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
[**AdvancedstationGetservices**](AdvancedstationApi.md#AdvancedstationGetservices) | **Get** /advancedstation/getservices | Gets the services available for a specific location.
[**AdvancedstationGetstaff**](AdvancedstationApi.md#AdvancedstationGetstaff) | **Get** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
[**AdvancedstationIssignedin**](AdvancedstationApi.md#AdvancedstationIssignedin) | **Get** /advancedstation/issignedin | Gets whether a user is signed-in or not.



## AdvancedstationCheckunknownuser

> AdvancedstationCheckunknownuser(ctx, station, user, location)

Check whether the user is known by the system.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user. | 
**location** | [**string**](.md)| The id of the location the user picked. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationCheckuserrole

> AdvancedstationCheckuserrole(ctx, station, user, location)

Check whether the user is a staff member, an attendee or both.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user. | 
**location** | [**string**](.md)| The id of the location the user picked. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationCreateuser

> AdvancedstationCreateuser(ctx, station, user, location, firstname, lastname, email, optional)

Creates a user via a sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user to create. | 
**location** | [**string**](.md)| The id of the location the user picked. | 
**firstname** | **string**| The first name of the user to create. | 
**lastname** | **string**| The last name of the user to create. | 
**email** | **string**| The email of the user to create. | 
 **optional** | ***AdvancedstationCreateuserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationCreateuserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------






 **middlename** | **optional.String**| The middle name of the user to create. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationGetevents

> AdvancedstationGetevents(ctx, station, location, user)

Gets the courses available for a specific location and a specific student.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**location** | [**string**](.md)| The id of the location the student picked. | 
**user** | **string**| The card of the user. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationGetinfo

> AdvancedstationGetinfo(ctx, id, optional)

Gets the info to display in the sign-in station by it's ID.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to get. | 
 **optional** | ***AdvancedstationGetinfoOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationGetinfoOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **event** | [**optional.Interface of string**](.md)| The id of the event (or session), to override the scheduled one. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationGetlocations

> AdvancedstationGetlocations(ctx, station, user)

Gets the locations available in a sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station whose locations have to be returned. | 
**user** | **string**| The card of the user. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationGetlogstaff

> AdvancedstationGetlogstaff(ctx, station, attendancelog, optional)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**attendancelog** | [**string**](.md)| The id of the attendance log to filter the staff members. | 
 **optional** | ***AdvancedstationGetlogstaffOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationGetlogstaffOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationGetroles

> AdvancedstationGetroles(ctx, station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**signinrole** | **string**| Specifies how the user is signing-in. | 
**user** | **string**| The card of the user. | 
**location** | [**string**](.md)| The id of the location the user picked. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationGetservices

> AdvancedstationGetservices(ctx, station, location, user)

Gets the services available for a specific location.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**location** | [**string**](.md)| The id of the location the student picked. | 
**user** | **string**| The card of the user. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationGetstaff

> AdvancedstationGetstaff(ctx, station, locationid, user, optional)

Gets the staff/tutors available for a specific location, course and service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**locationid** | [**string**](.md)| The id of the location the student picked. | 
**user** | **string**| The card of the user. | 
 **optional** | ***AdvancedstationGetstaffOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationGetstaffOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **services** | **optional.String**| The list of services selected by the user, in JSON format. | 
 **eventid** | [**optional.Interface of string**](.md)| The ID of the event selected. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdvancedstationIssignedin

> AdvancedstationIssignedin(ctx, station, time, user, optional)

Gets whether a user is signed-in or not.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**time** | **time.Time**| The date and time of the swipe. | 
**user** | **string**| The card of the user. | 
 **optional** | ***AdvancedstationIssignedinOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationIssignedinOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **location** | [**optional.Interface of string**](.md)| The id of the location the user picked. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

