# \LikeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LikeDelete**](LikeApi.md#LikeDelete) | **Delete** /like/delete | Delete a like
[**LikeList**](LikeApi.md#LikeList) | **Get** /like/list | View all the likes associated to a target
[**LikeSave**](LikeApi.md#LikeSave) | **Post** /like/save | Save a like



## LikeDelete

> LikeDelete(ctx, optional)

Delete a like

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***LikeDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LikeDeleteOpts struct


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


## LikeList

> LikeList(ctx, interactionid, optional)

View all the likes associated to a target

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**interactionid** | [**string**](.md)| The id of the interaction to unlike. | 
 **optional** | ***LikeListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LikeListOpts struct


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


## LikeSave

> LikeSave(ctx, optional)

Save a like

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***LikeSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LikeSaveOpts struct


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

