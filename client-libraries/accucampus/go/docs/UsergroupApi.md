# \UsergroupApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsergroupAddmember**](UsergroupApi.md#UsergroupAddmember) | **Get** /usergroup/addmember | Add a user to a group
[**UsergroupDelete**](UsergroupApi.md#UsergroupDelete) | **Delete** /usergroup/{id} | Delete a group
[**UsergroupGet**](UsergroupApi.md#UsergroupGet) | **Get** /usergroup/{id} | Search and view details of a user group
[**UsergroupGetmembers**](UsergroupApi.md#UsergroupGetmembers) | **Get** /usergroup/getmembers | View the members of a user group
[**UsergroupGetuser**](UsergroupApi.md#UsergroupGetuser) | **Get** /usergroup/getuser | View the groups which a user is registered to
[**UsergroupList**](UsergroupApi.md#UsergroupList) | **Get** /usergroup/list | View a list of user groups
[**UsergroupRefresh**](UsergroupApi.md#UsergroupRefresh) | **Get** /usergroup/refresh | Refresh the dynamic group
[**UsergroupRemovemember**](UsergroupApi.md#UsergroupRemovemember) | **Get** /usergroup/removemember | Remove a user from a group
[**UsergroupSave**](UsergroupApi.md#UsergroupSave) | **Post** /usergroup/{id} | Create or edit a group
[**UsergroupTagmembers**](UsergroupApi.md#UsergroupTagmembers) | **Get** /usergroup/tagmembers | Assign tags to the members of a specified group
[**UsergroupUntagmembers**](UsergroupApi.md#UsergroupUntagmembers) | **Get** /usergroup/untagmembers | Unassign tags from the members of a specified group



## UsergroupAddmember

> UsergroupAddmember(ctx, userid, groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to add. | 
**groupid** | [**string**](.md)| The id of the group. | 

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


## UsergroupDelete

> UsergroupDelete(ctx, id, optional)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the group to delete. | 
 **optional** | ***UsergroupDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergroupDeleteOpts struct


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


## UsergroupGet

> UsergroupGet(ctx, id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the user group to get. | 

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


## UsergroupGetmembers

> UsergroupGetmembers(ctx, groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**groupid** | [**string**](.md)| The id of the user group to get. | 

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


## UsergroupGetuser

> UsergroupGetuser(ctx, userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to get his groups. | 

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


## UsergroupList

> UsergroupList(ctx, optional)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UsergroupListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergroupListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **optional.Int32**| The first record to return. | 
 **count** | **optional.Int32**| The max number of records to return. | 
 **type_** | **optional.String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | 

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


## UsergroupRefresh

> UsergroupRefresh(ctx, group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**group** | [**string**](.md)| The ID of the group to refresh. | 

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


## UsergroupRemovemember

> UsergroupRemovemember(ctx, userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to remove. | 
**groupid** | [**string**](.md)| The id of the group. | 

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


## UsergroupSave

> UsergroupSave(ctx, id, optional)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the group to save (leave empty to create a new one). | 
 **optional** | ***UsergroupSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergroupSaveOpts struct


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


## UsergroupTagmembers

> UsergroupTagmembers(ctx, group, optional)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**group** | [**string**](.md)| The id of the group to save whose members have to be tagged. | 
 **optional** | ***UsergroupTagmembersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergroupTagmembersOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **tags** | **optional.String**| The tags to assign to the members of the specified group, in JSON format. | 

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


## UsergroupUntagmembers

> UsergroupUntagmembers(ctx, group, optional)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**group** | [**string**](.md)| The id of the group to save whose members have to be untagged. | 
 **optional** | ***UsergroupUntagmembersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergroupUntagmembersOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **tags** | **optional.String**| The tags to unassign from the members of the specified group, in JSON format. | 

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

