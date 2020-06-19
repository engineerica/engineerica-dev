# \ServiceassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceassignmentAddservice**](ServiceassignmentApi.md#ServiceassignmentAddservice) | **Get** /serviceassignment/addservice | Enable a service in a specific location
[**ServiceassignmentGetlocation**](ServiceassignmentApi.md#ServiceassignmentGetlocation) | **Get** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**ServiceassignmentGetservice**](ServiceassignmentApi.md#ServiceassignmentGetservice) | **Get** /serviceassignment/getservice | View a list of locations where a service is available
[**ServiceassignmentRemoveservice**](ServiceassignmentApi.md#ServiceassignmentRemoveservice) | **Get** /serviceassignment/removeservice | Remove a service from a location



## ServiceassignmentAddservice

> ServiceassignmentAddservice(ctx, serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceid** | [**string**](.md)| The id of the service to add. | 
**locationid** | [**string**](.md)| The id of the location. | 

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


## ServiceassignmentGetlocation

> ServiceassignmentGetlocation(ctx, locationid, optional)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**locationid** | [**string**](.md)| The id of the location to get. | 
 **optional** | ***ServiceassignmentGetlocationOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ServiceassignmentGetlocationOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **includegloballyavailable** | **optional.Bool**| Specifies whether the services available globally must be returned or not. | 
 **namefilter** | **optional.Bool**| Filters the name of the services to return. | 
 **count** | **optional.Int32**| The max number of services to return. | 

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


## ServiceassignmentGetservice

> ServiceassignmentGetservice(ctx, serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceid** | [**string**](.md)| The id of the service to get its locations. | 

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


## ServiceassignmentRemoveservice

> ServiceassignmentRemoveservice(ctx, serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceid** | [**string**](.md)| The id of the service to remove. | 
**locationid** | [**string**](.md)| The id of the location to remove the service from. | 

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

