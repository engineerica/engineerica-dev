# \StaffavailApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StaffavailAddmetoallservices**](StaffavailApi.md#StaffavailAddmetoallservices) | **Get** /staffavail/addmetoallservices | Associate current user to all services
[**StaffavailAddmetoservice**](StaffavailApi.md#StaffavailAddmetoservice) | **Get** /staffavail/addmetoservice | Associate current user to a service
[**StaffavailAddusertoallservices**](StaffavailApi.md#StaffavailAddusertoallservices) | **Get** /staffavail/addusertoallservices | Associate a staff member to all services
[**StaffavailAddusertoservice**](StaffavailApi.md#StaffavailAddusertoservice) | **Get** /staffavail/addusertoservice | Associate a staff member to a service
[**StaffavailGetmyservices**](StaffavailApi.md#StaffavailGetmyservices) | **Get** /staffavail/getmyservices | View the services the current user is available for
[**StaffavailGetservices**](StaffavailApi.md#StaffavailGetservices) | **Get** /staffavail/getservices | View a list of services that a staff member is available for
[**StaffavailGetusersforservice**](StaffavailApi.md#StaffavailGetusersforservice) | **Get** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
[**StaffavailListtypes**](StaffavailApi.md#StaffavailListtypes) | **Get** /staffavail/listtypes | View all the availability types
[**StaffavailRemovemefromallservices**](StaffavailApi.md#StaffavailRemovemefromallservices) | **Get** /staffavail/removemefromallservices | Remove current user from all services
[**StaffavailRemovemefromservice**](StaffavailApi.md#StaffavailRemovemefromservice) | **Get** /staffavail/removemefromservice | Remove current user from a service
[**StaffavailRemoveuserfromallservices**](StaffavailApi.md#StaffavailRemoveuserfromallservices) | **Get** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
[**StaffavailRemoveuserfromservice**](StaffavailApi.md#StaffavailRemoveuserfromservice) | **Get** /staffavail/removeuserfromservice | Remove a staff member from a service
[**StaffavailSetavailability**](StaffavailApi.md#StaffavailSetavailability) | **Get** /staffavail/setavailability | Make a staff member available for a specific availability type
[**StaffavailSetmyavailability**](StaffavailApi.md#StaffavailSetmyavailability) | **Get** /staffavail/setmyavailability | Change current user&#39;s availability type



## StaffavailAddmetoallservices

> StaffavailAddmetoallservices(ctx, )

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

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


## StaffavailAddmetoservice

> StaffavailAddmetoservice(ctx, serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceid** | [**string**](.md)| The id of the service. | 

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


## StaffavailAddusertoallservices

> StaffavailAddusertoallservices(ctx, userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to add. | 

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


## StaffavailAddusertoservice

> StaffavailAddusertoservice(ctx, userid, serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to add. | 
**serviceid** | [**string**](.md)| The id of the service. | 

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


## StaffavailGetmyservices

> StaffavailGetmyservices(ctx, )

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

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


## StaffavailGetservices

> StaffavailGetservices(ctx, userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The user id to list services. | 

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


## StaffavailGetusersforservice

> StaffavailGetusersforservice(ctx, serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceid** | [**string**](.md)| The service id to list users. | 

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


## StaffavailListtypes

> StaffavailListtypes(ctx, )

View all the availability types

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


## StaffavailRemovemefromallservices

> StaffavailRemovemefromallservices(ctx, )

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

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


## StaffavailRemovemefromservice

> StaffavailRemovemefromservice(ctx, serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceid** | [**string**](.md)| The id of the service. | 

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


## StaffavailRemoveuserfromallservices

> StaffavailRemoveuserfromallservices(ctx, userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to remove. | 

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


## StaffavailRemoveuserfromservice

> StaffavailRemoveuserfromservice(ctx, userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to remove. | 
**serviceid** | [**string**](.md)| The id of the service. | 

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


## StaffavailSetavailability

> StaffavailSetavailability(ctx, userid, optional)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user whose specific availability has to be set. | 
 **optional** | ***StaffavailSetavailabilityOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StaffavailSetavailabilityOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **availablefor** | **optional.String**| Specific availability to set. | 

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


## StaffavailSetmyavailability

> StaffavailSetmyavailability(ctx, optional)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***StaffavailSetmyavailabilityOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StaffavailSetmyavailabilityOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **availablefor** | **optional.String**| Specific availability to set. | 

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

