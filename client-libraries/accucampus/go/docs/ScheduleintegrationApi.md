# \ScheduleintegrationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScheduleintegrationClearids**](ScheduleintegrationApi.md#ScheduleintegrationClearids) | **Get** /scheduleintegration/clearids | Clear all third party IDs from specified staff member&#39;s schedule items.
[**ScheduleintegrationDeleteitem**](ScheduleintegrationApi.md#ScheduleintegrationDeleteitem) | **Delete** /scheduleintegration/deleteitem | Delete a schedule item looking up by a third party ID
[**ScheduleintegrationDeleteitemsbymasterid**](ScheduleintegrationApi.md#ScheduleintegrationDeleteitemsbymasterid) | **Delete** /scheduleintegration/deleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**ScheduleintegrationGetitem**](ScheduleintegrationApi.md#ScheduleintegrationGetitem) | **Get** /scheduleintegration/getitem | Get a schedule item looking up by a third party ID
[**ScheduleintegrationSaveitem**](ScheduleintegrationApi.md#ScheduleintegrationSaveitem) | **Post** /scheduleintegration/saveitem | Save a schedule item looking up by a third party ID
[**ScheduleintegrationSetid**](ScheduleintegrationApi.md#ScheduleintegrationSetid) | **Get** /scheduleintegration/setid | Set a 3rd party ID on a specific schedule item



## ScheduleintegrationClearids

> ScheduleintegrationClearids(ctx, staff)

Clear all third party IDs from specified staff member's schedule items.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**staff** | [**string**](.md)| The ID of the staff member whose schedule items third party IDs must be cleared. | 

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


## ScheduleintegrationDeleteitem

> ScheduleintegrationDeleteitem(ctx, optional)

Delete a schedule item looking up by a third party ID

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleintegrationDeleteitemOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleintegrationDeleteitemOpts struct


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


## ScheduleintegrationDeleteitemsbymasterid

> ScheduleintegrationDeleteitemsbymasterid(ctx, optional)

Delete multiple schedule items looking up by a third party master ID

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleintegrationDeleteitemsbymasteridOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleintegrationDeleteitemsbymasteridOpts struct


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


## ScheduleintegrationGetitem

> ScheduleintegrationGetitem(ctx, thirdpartyid)

Get a schedule item looking up by a third party ID

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**thirdpartyid** | **string**| The third party id to search for the schedule item. | 

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


## ScheduleintegrationSaveitem

> ScheduleintegrationSaveitem(ctx, optional)

Save a schedule item looking up by a third party ID

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleintegrationSaveitemOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleintegrationSaveitemOpts struct


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


## ScheduleintegrationSetid

> ScheduleintegrationSetid(ctx, id, thirdpartyid, optional)

Set a 3rd party ID on a specific schedule item

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the schedule block / appointment. | 
**thirdpartyid** | **string**| The 3rd party ID to set. | 
 **optional** | ***ScheduleintegrationSetidOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleintegrationSetidOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **thirdpartymasterid** | **optional.String**| The 3rd party master ID to set (useful to handle recurring items). | 

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

