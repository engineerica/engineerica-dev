# \ActionassignmentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionassignmentDelete**](ActionassignmentApi.md#ActionassignmentDelete) | **Delete** /actionassignment/{id} | Remove an action item from an action plan
[**ActionassignmentGet**](ActionassignmentApi.md#ActionassignmentGet) | **Get** /actionassignment/{id} | Search and view details of an action item assigned to a user
[**ActionassignmentList**](ActionassignmentApi.md#ActionassignmentList) | **Get** /actionassignment/list | View a list of action items in a user&#39;s plan
[**ActionassignmentListhistory**](ActionassignmentApi.md#ActionassignmentListhistory) | **Get** /actionassignment/listhistory | View the history of an action item assigned to a user
[**ActionassignmentListmine**](ActionassignmentApi.md#ActionassignmentListmine) | **Get** /actionassignment/listmine | List public action assignments assigned to the logged user
[**ActionassignmentListpublichistory**](ActionassignmentApi.md#ActionassignmentListpublichistory) | **Get** /actionassignment/listpublichistory | List public action assignment history
[**ActionassignmentMarkcomplete**](ActionassignmentApi.md#ActionassignmentMarkcomplete) | **Get** /actionassignment/markcomplete | Bulk complete action items
[**ActionassignmentSave**](ActionassignmentApi.md#ActionassignmentSave) | **Post** /actionassignment/save | Add an action item to a user&#39;s action plan
[**ActionassignmentSavehistory**](ActionassignmentApi.md#ActionassignmentSavehistory) | **Post** /actionassignment/savehistory | Update an action item assigned to a user



## ActionassignmentDelete

> ActionassignmentDelete(ctx, id, optional)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the action assignment to delete. | 
 **optional** | ***ActionassignmentDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentDeleteOpts struct


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


## ActionassignmentGet

> ActionassignmentGet(ctx, id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the action assignment to get. | 

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


## ActionassignmentList

> ActionassignmentList(ctx, from, count, optional)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***ActionassignmentListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **assignee** | **optional.Int32**| The assignee&#39;s id to filter the assignments. | 
 **status** | **optional.Int32**| The status to filter the assignments. | 

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


## ActionassignmentListhistory

> ActionassignmentListhistory(ctx, actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**actionassignment** | [**string**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

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


## ActionassignmentListmine

> ActionassignmentListmine(ctx, from, count, optional)

List public action assignments assigned to the logged user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***ActionassignmentListmineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentListmineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **status** | **optional.Int32**| The status to filter the assignments. | 

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


## ActionassignmentListpublichistory

> ActionassignmentListpublichistory(ctx, actionassignment)

List public action assignment history

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**actionassignment** | [**string**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

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


## ActionassignmentMarkcomplete

> ActionassignmentMarkcomplete(ctx, item, optional)

Bulk complete action items

Allows the user to bulk complete action items.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**item** | **string**| The action item to assign. | 
 **optional** | ***ActionassignmentMarkcompleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentMarkcompleteOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **assignee** | [**optional.Interface of string**](.md)| The assignee of the item. | 
 **group** | [**optional.Interface of string**](.md)| The group to assing the item. | 
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


## ActionassignmentSave

> ActionassignmentSave(ctx, optional)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ActionassignmentSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentSaveOpts struct


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


## ActionassignmentSavehistory

> ActionassignmentSavehistory(ctx, optional)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ActionassignmentSavehistoryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentSavehistoryOpts struct


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

