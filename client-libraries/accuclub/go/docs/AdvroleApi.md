# \AdvroleApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdvroleAddmissing**](AdvroleApi.md#AdvroleAddmissing) | **Get** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**AdvroleCheckperm**](AdvroleApi.md#AdvroleCheckperm) | **Get** /advrole/checkperm | Checks the permissions are assigned for the given roles
[**AdvroleDelete**](AdvroleApi.md#AdvroleDelete) | **Delete** /advrole/{id} | Delete a role
[**AdvroleDeletemapping**](AdvroleApi.md#AdvroleDeletemapping) | **Delete** /advrole/deletemapping | Delete a role mapping
[**AdvroleGet**](AdvroleApi.md#AdvroleGet) | **Get** /advrole/{id} | View details of a role
[**AdvroleList**](AdvroleApi.md#AdvroleList) | **Get** /advrole/list | Lists the roles for the current account
[**AdvroleListmaps**](AdvroleApi.md#AdvroleListmaps) | **Get** /advrole/listmaps | Lists the maps a roles is mapped to
[**AdvroleListrolesmapped**](AdvroleApi.md#AdvroleListrolesmapped) | **Get** /advrole/listrolesmapped | Lists the roles mappings
[**AdvroleListtemplates**](AdvroleApi.md#AdvroleListtemplates) | **Get** /advrole/listtemplates | View a list of role templates
[**AdvroleSave**](AdvroleApi.md#AdvroleSave) | **Post** /advrole/{id} | Create or edit a role
[**AdvroleSavemapping**](AdvroleApi.md#AdvroleSavemapping) | **Post** /advrole/savemapping | Saves a role mapping
[**AdvroleUserupgrade**](AdvroleApi.md#AdvroleUserupgrade) | **Get** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)



## AdvroleAddmissing

> AdvroleAddmissing(ctx, roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**roles** | **string**| CSV list of the role ids to check | 
**permissions** | **string**| CSV list of the permissions to check | 

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


## AdvroleCheckperm

> AdvroleCheckperm(ctx, roles, permissions)

Checks the permissions are assigned for the given roles

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**roles** | **string**| CSV list of the role ids to check | 
**permissions** | **string**| CSV list of the permissions to check | 

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


## AdvroleDelete

> AdvroleDelete(ctx, id, optional)

Delete a role

Allows the user to delete a role from the list of available roles.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the location to delete. | 
 **optional** | ***AdvroleDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvroleDeleteOpts struct


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


## AdvroleDeletemapping

> AdvroleDeletemapping(ctx, optional)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AdvroleDeletemappingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvroleDeletemappingOpts struct


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


## AdvroleGet

> AdvroleGet(ctx, id)

View details of a role

Allows the user to view a role and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the location to get. | 

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


## AdvroleList

> AdvroleList(ctx, optional)

Lists the roles for the current account

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AdvroleListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvroleListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includepolicies** | **optional.Bool**| True to include the policies, defaults to false. | 
 **includeinternal** | **optional.Bool**| True to include the internal roles too. | 
 **name** | **optional.String**| Filter by name of the role. | 

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


## AdvroleListmaps

> AdvroleListmaps(ctx, roleid)

Lists the maps a roles is mapped to

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**roleid** | [**string**](.md)| The id of the role to list the maps. | 

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


## AdvroleListrolesmapped

> AdvroleListrolesmapped(ctx, optional)

Lists the roles mappings

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AdvroleListrolesmappedOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvroleListrolesmappedOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map_** | **optional.String**| List only the roles in the specified map. | 

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


## AdvroleListtemplates

> AdvroleListtemplates(ctx, )

View a list of role templates

Allows the user to view the full list of available role templates.

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


## AdvroleSave

> AdvroleSave(ctx, id, optional)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the role to save (leave empty to create a new one). | 
 **optional** | ***AdvroleSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvroleSaveOpts struct


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


## AdvroleSavemapping

> AdvroleSavemapping(ctx, optional)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AdvroleSavemappingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvroleSavemappingOpts struct


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


## AdvroleUserupgrade

> AdvroleUserupgrade(ctx, userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| Id of the user to upgrade | 
**roleid** | [**string**](.md)| Id of the role to add | 

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

