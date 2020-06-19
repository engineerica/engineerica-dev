# \SocialgroupApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SocialgroupAddmembers**](SocialgroupApi.md#SocialgroupAddmembers) | **Get** /socialgroup/addmembers | Adds new members to a group (which the user must own already)
[**SocialgroupDelete**](SocialgroupApi.md#SocialgroupDelete) | **Delete** /socialgroup/{id} | Deletes a group
[**SocialgroupList**](SocialgroupApi.md#SocialgroupList) | **Get** /socialgroup/list | View all the groups the current user is in
[**SocialgroupListmembers**](SocialgroupApi.md#SocialgroupListmembers) | **Get** /socialgroup/listmembers | Lists the members of a group
[**SocialgroupRemovemembers**](SocialgroupApi.md#SocialgroupRemovemembers) | **Get** /socialgroup/removemembers | Removes members from a group (which the user must own already)
[**SocialgroupRemovemyself**](SocialgroupApi.md#SocialgroupRemovemyself) | **Get** /socialgroup/removemyself | Removes myself from an existent group
[**SocialgroupSave**](SocialgroupApi.md#SocialgroupSave) | **Post** /socialgroup/{id} | Saves a new group



## SocialgroupAddmembers

> SocialgroupAddmembers(ctx, id, userids)

Adds new members to a group (which the user must own already)

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| ID of the group to add members to. | 
**userids** | **string**| Csv list of user Ids to add. | 

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


## SocialgroupDelete

> SocialgroupDelete(ctx, id, optional)

Deletes a group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| ID of the group to delete. | 
 **optional** | ***SocialgroupDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SocialgroupDeleteOpts struct


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


## SocialgroupList

> SocialgroupList(ctx, )

View all the groups the current user is in

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


## SocialgroupListmembers

> SocialgroupListmembers(ctx, id)

Lists the members of a group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| ID of the group to list members. | 

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


## SocialgroupRemovemembers

> SocialgroupRemovemembers(ctx, id, userids)

Removes members from a group (which the user must own already)

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| ID of the group to remove members from. | 
**userids** | **string**| Csv list of user Ids to remove. | 

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


## SocialgroupRemovemyself

> SocialgroupRemovemyself(ctx, id)

Removes myself from an existent group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| ID of the group to remove me from. | 

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


## SocialgroupSave

> SocialgroupSave(ctx, id, optional)

Saves a new group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| ID of the group to update. Leave blank to create new. | 
 **optional** | ***SocialgroupSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SocialgroupSaveOpts struct


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

