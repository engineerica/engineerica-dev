# \ComputerlabApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ComputerlabDeletecomputer**](ComputerlabApi.md#ComputerlabDeletecomputer) | **Delete** /computerlab/deletecomputer | Delete a computer
[**ComputerlabGetcomputer**](ComputerlabApi.md#ComputerlabGetcomputer) | **Get** /computerlab/getcomputer | Search and view details of a computer
[**ComputerlabGetsettings**](ComputerlabApi.md#ComputerlabGetsettings) | **Get** /computerlab/getsettings | Loads the settings for a computer lab
[**ComputerlabIssignedin**](ComputerlabApi.md#ComputerlabIssignedin) | **Get** /computerlab/issignedin | Gets whether a user is signed-in or not.
[**ComputerlabListcomputers**](ComputerlabApi.md#ComputerlabListcomputers) | **Get** /computerlab/listcomputers | View a list of computers
[**ComputerlabListlabs**](ComputerlabApi.md#ComputerlabListlabs) | **Get** /computerlab/listlabs | View a list of the locations that use the Computer Lab add-on
[**ComputerlabListstations**](ComputerlabApi.md#ComputerlabListstations) | **Get** /computerlab/liststations | View a list of sign-in stations available for computer labs.
[**ComputerlabSavecomputer**](ComputerlabApi.md#ComputerlabSavecomputer) | **Post** /computerlab/savecomputer | Create or edit a computer
[**ComputerlabSavesettings**](ComputerlabApi.md#ComputerlabSavesettings) | **Post** /computerlab/savesettings | Saves the settings for a computer lab
[**ComputerlabSaveswipe**](ComputerlabApi.md#ComputerlabSaveswipe) | **Post** /computerlab/saveswipe | Save a new swipe from a computer in a computer lab.



## ComputerlabDeletecomputer

> ComputerlabDeletecomputer(ctx, optional)

Delete a computer

Allows the user to delete an existing computer.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ComputerlabDeletecomputerOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlabDeletecomputerOpts struct


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


## ComputerlabGetcomputer

> ComputerlabGetcomputer(ctx, id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | **string**| The unique device id of the computer to get. | 

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


## ComputerlabGetsettings

> ComputerlabGetsettings(ctx, id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the computer lab/location. | 

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


## ComputerlabIssignedin

> ComputerlabIssignedin(ctx, station, user)

Gets whether a user is signed-in or not.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
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


## ComputerlabListcomputers

> ComputerlabListcomputers(ctx, from, count, optional)

View a list of computers

Allows the user to view the list of all computers.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***ComputerlabListcomputersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlabListcomputersOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **location** | [**optional.Interface of string**](.md)| The id of the location whose computers have to be returned. | 
 **freeonly** | **optional.Bool**| If true, only free computers will be returned. | 

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


## ComputerlabListlabs

> ComputerlabListlabs(ctx, )

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

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


## ComputerlabListstations

> ComputerlabListstations(ctx, )

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

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


## ComputerlabSavecomputer

> ComputerlabSavecomputer(ctx, optional)

Create or edit a computer

Allows the user to create or edit a computer.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ComputerlabSavecomputerOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlabSavecomputerOpts struct


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


## ComputerlabSavesettings

> ComputerlabSavesettings(ctx, optional)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ComputerlabSavesettingsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlabSavesettingsOpts struct


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


## ComputerlabSaveswipe

> ComputerlabSaveswipe(ctx, optional)

Save a new swipe from a computer in a computer lab.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ComputerlabSaveswipeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlabSaveswipeOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

