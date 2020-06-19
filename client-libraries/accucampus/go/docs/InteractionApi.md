# \InteractionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InteractionDelete**](InteractionApi.md#InteractionDelete) | **Delete** /interaction/{id} | Delete an interaction
[**InteractionFeed**](InteractionApi.md#InteractionFeed) | **Get** /interaction/feed | Get the interactions feed
[**InteractionGet**](InteractionApi.md#InteractionGet) | **Get** /interaction/{id} | View an interaction
[**InteractionListprivatesummary**](InteractionApi.md#InteractionListprivatesummary) | **Get** /interaction/listprivatesummary | Get current user&#39;s latest private interactions
[**InteractionSave**](InteractionApi.md#InteractionSave) | **Post** /interaction/{id} | Save an interaction



## InteractionDelete

> InteractionDelete(ctx, id, optional)

Delete an interaction

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the interaction to delete. | 
 **optional** | ***InteractionDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractionDeleteOpts struct


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


## InteractionFeed

> InteractionFeed(ctx, from, count, optional)

Get the interactions feed

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***InteractionFeedOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractionFeedOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **startdate** | **optional.Time**| If set, only interactions that happened after this date are returned. | 
 **public** | **optional.Bool**| Specifies whether to return public or private interactions. | 
 **contexttype** | **optional.String**| The type of the context of the interactions to return. | 
 **contextid** | [**optional.Interface of string**](.md)| The id of the context of the interactions to return. | 
 **types** | **optional.String**| The  comma separated types of the interactions to return. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 
 **showdefaultphoto** | **optional.Bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | 
 **orderdescending** | **optional.Bool**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | 

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


## InteractionGet

> InteractionGet(ctx, id, optional)

View an interaction

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | **string**| The id of the interaction. | 
 **optional** | ***InteractionGetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractionGetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **thumbnailmediasize** | **optional.Int32**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | 
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


## InteractionListprivatesummary

> InteractionListprivatesummary(ctx, optional)

Get current user's latest private interactions

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***InteractionListprivatesummaryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractionListprivatesummaryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 
 **showdefaultphoto** | **optional.Bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | 

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


## InteractionSave

> InteractionSave(ctx, id, optional)

Save an interaction

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the interaction to save (leave empty to create a new one). | 
 **optional** | ***InteractionSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractionSaveOpts struct


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

