# \SecurityApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SecurityAssesspermission**](SecurityApi.md#SecurityAssesspermission) | **Get** /security/assesspermission | Returns the list of users for a specific permission
[**SecurityAssessrole**](SecurityApi.md#SecurityAssessrole) | **Get** /security/assessrole | Returns the list of permissions for a specific role
[**SecurityAssessscope**](SecurityApi.md#SecurityAssessscope) | **Get** /security/assessscope | Returns the list of users for a specific user
[**SecurityAssessuser**](SecurityApi.md#SecurityAssessuser) | **Get** /security/assessuser | Returns the list of permissions for a specific user



## SecurityAssesspermission

> SecurityAssesspermission(ctx, commandname)

Returns the list of users for a specific permission

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**commandname** | **string**| Name of the action or command to get the roles. | 

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


## SecurityAssessrole

> SecurityAssessrole(ctx, roleid)

Returns the list of permissions for a specific role

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**roleid** | [**string**](.md)| Role ID to list the effective permissions. | 

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


## SecurityAssessscope

> SecurityAssessscope(ctx, optional)

Returns the list of users for a specific user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SecurityAssessscopeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SecurityAssessscopeOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**optional.Interface of string**](.md)| Location ID to list the users with that scope. | 

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


## SecurityAssessuser

> SecurityAssessuser(ctx, userid)

Returns the list of permissions for a specific user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| User ID to list the effective permissions. | 

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

