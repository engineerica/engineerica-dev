# \StationApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StationDelete**](StationApi.md#StationDelete) | **Delete** /station/{id} | Delete a sign-in station
[**StationGet**](StationApi.md#StationGet) | **Get** /station/{id} | View details of a sign-in station
[**StationGetcurrentterms**](StationApi.md#StationGetcurrentterms) | **Get** /station/getcurrentterms | Get all the current terms
[**StationGetinfo**](StationApi.md#StationGetinfo) | **Get** /station/getinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**StationGetlicense**](StationApi.md#StationGetlicense) | **Get** /station/getlicense | Gets the current license information
[**StationList**](StationApi.md#StationList) | **Get** /station/list | View a list of sign-in stations
[**StationSave**](StationApi.md#StationSave) | **Post** /station/{id} | Create or edit a sign-in station
[**StationUnlock**](StationApi.md#StationUnlock) | **Get** /station/unlock | Unlocks the sign-in station.



## StationDelete

> StationDelete(ctx, id, optional)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to delete. | 
 **optional** | ***StationDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StationDeleteOpts struct


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


## StationGet

> StationGet(ctx, id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to get. | 

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


## StationGetcurrentterms

> StationGetcurrentterms(ctx, station)

Get all the current terms

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

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


## StationGetinfo

> StationGetinfo(ctx, id, optional)

Gets a the info to display in the sign-in station by it's ID.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to get. | 
 **optional** | ***StationGetinfoOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StationGetinfoOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **event** | [**optional.Interface of string**](.md)| The id of the event, to override the one by schedule. | 

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


## StationGetlicense

> StationGetlicense(ctx, station)

Gets the current license information

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | **string**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

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


## StationList

> StationList(ctx, from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## StationSave

> StationSave(ctx, id, optional)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to save (leave empty to create a new one). | 
 **optional** | ***StationSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StationSaveOpts struct


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


## StationUnlock

> StationUnlock(ctx, id, passcode, method)

Unlocks the sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to unlock. | 
**passcode** | **string**| The passcode to unlock the station. | 
**method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

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

