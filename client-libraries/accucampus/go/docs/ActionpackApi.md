# \ActionpackApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionpackAssign**](ActionpackApi.md#ActionpackAssign) | **Get** /actionpack/assign | Assign an action item pack to a user
[**ActionpackDelete**](ActionpackApi.md#ActionpackDelete) | **Delete** /actionpack/{id} | Delete an action item pack
[**ActionpackGet**](ActionpackApi.md#ActionpackGet) | **Get** /actionpack/{id} | View details of an action item pack
[**ActionpackList**](ActionpackApi.md#ActionpackList) | **Get** /actionpack/list | View a list of action item packs
[**ActionpackSave**](ActionpackApi.md#ActionpackSave) | **Post** /actionpack/{id} | Create or edit an action item pack



## ActionpackAssign

> ActionpackAssign(ctx, pack, itemsdata, optional)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**pack** | [**string**](.md)| The id of the action pack to assign. | 
**itemsdata** | **bool**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **optional** | ***ActionpackAssignOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionpackAssignOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **assignee** | [**optional.Interface of string**](.md)| The assignee of the pack. | 
 **group** | [**optional.Interface of string**](.md)| The group to assign the pack. | 
 **notes** | **optional.String**| The assignment&#39;s notes. | 

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


## ActionpackDelete

> ActionpackDelete(ctx, id, optional)

Delete an action item pack

Allows the user to delete an action item pack.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the action pack to delete. | 
 **optional** | ***ActionpackDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionpackDeleteOpts struct


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


## ActionpackGet

> ActionpackGet(ctx, id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the action pack to get. | 

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


## ActionpackList

> ActionpackList(ctx, from, count)

View a list of action item packs

Allows the user to view the full list of action item packs.

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


## ActionpackSave

> ActionpackSave(ctx, id, optional)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the action pack to save (leave empty to create a new one). | 
 **optional** | ***ActionpackSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionpackSaveOpts struct


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

