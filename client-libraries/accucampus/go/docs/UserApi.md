# \UserApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserChangepwd**](UserApi.md#UserChangepwd) | **Get** /user/changepwd | Change user&#39;s own password
[**UserChangepwdbyreq**](UserApi.md#UserChangepwdbyreq) | **Get** /user/changepwdbyreq | Changes the user password using a change password request id
[**UserDelete**](UserApi.md#UserDelete) | **Delete** /user/{id} | Delete a user
[**UserFindsimilar**](UserApi.md#UserFindsimilar) | **Get** /user/findsimilar | Finds similar users to prevent duplicates
[**UserGet**](UserApi.md#UserGet) | **Get** /user/{id} | Search and view details of a user
[**UserGetbycard**](UserApi.md#UserGetbycard) | **Get** /user/getbycard | Search user by card number
[**UserList**](UserApi.md#UserList) | **Get** /user/list | View a list of users
[**UserLoadphoto**](UserApi.md#UserLoadphoto) | **Get** /user/loadphoto | Upload a photo for a specific user
[**UserMovedata**](UserApi.md#UserMovedata) | **Get** /user/movedata | Move data between users
[**UserRequestpwdchange**](UserApi.md#UserRequestpwdchange) | **Get** /user/requestpwdchange | Requests a password change
[**UserSave**](UserApi.md#UserSave) | **Post** /user/{id} | Create or edit a user
[**UserSavepwdchange**](UserApi.md#UserSavepwdchange) | **Post** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords



## UserChangepwd

> UserChangepwd(ctx, oldpass, newpass)

Change user's own password

Allows the user to change their own password.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**oldpass** | [**string**](.md)| The old password of the authenticated user. | 
**newpass** | [**string**](.md)| The new password of the authenticated user. | 

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


## UserChangepwdbyreq

> UserChangepwdbyreq(ctx, changereq, newpass)

Changes the user password using a change password request id

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**changereq** | **string**| The change password request ID sent by email to the user. | 
**newpass** | **string**| The new password of the user. | 

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


## UserDelete

> UserDelete(ctx, id, optional)

Delete a user

Allows the user to delete a user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the user to delete. | 
 **optional** | ***UserDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserDeleteOpts struct


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


## UserFindsimilar

> UserFindsimilar(ctx, optional)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UserFindsimilarOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserFindsimilarOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentid** | [**optional.Interface of string**](.md)| The id of the current user. | 
 **phonenumber** | **optional.String**| A phone number to search for similar users. | 
 **cardnumber** | **optional.String**| A card number to search for similar users. | 

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


## UserGet

> UserGet(ctx, id, optional)

Search and view details of a user

Allows the user to search and view a user and their details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the user to get. | 
 **optional** | ***UserGetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserGetOpts struct


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


## UserGetbycard

> UserGetbycard(ctx, card, optional)

Search user by card number

Allows the user to search for a user by their card number.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**card** | **string**| The card number of the user to get. | 
 **optional** | ***UserGetbycardOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserGetbycardOpts struct


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


## UserList

> UserList(ctx, from, count, optional)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***UserListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **roleid** | [**optional.Interface of string**](.md)| The id of the role to filter users by, or empty to return all users. | 
 **onlywithoutcard** | **optional.String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | 
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


## UserLoadphoto

> UserLoadphoto(ctx, upload, optional)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **optional** | ***UserLoadphotoOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserLoadphotoOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **filename** | **optional.String**| The local name of the uploaded file. For later reference. | 
 **userid** | [**optional.Interface of string**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | 
 **automatch** | **optional.Bool**| Set this to true to find the specific user based on the file name.  | 

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


## UserMovedata

> UserMovedata(ctx, source, destination)

Move data between users

Allows administrators to move data between users.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**source** | [**string**](.md)| The id of the user that is the source of the data. | 
**destination** | [**string**](.md)| The id of the user that is the destination of the data. | 

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


## UserRequestpwdchange

> UserRequestpwdchange(ctx, domain, email)

Requests a password change

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**domain** | **string**| The domain of the account where the user exists. | 
**email** | **string**| The email of the user. | 

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


## UserSave

> UserSave(ctx, id, optional)

Create or edit a user

Allows the user to create or edit a user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the user to save (leave empty to create a new one). | 
 **optional** | ***UserSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserSaveOpts struct


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


## UserSavepwdchange

> UserSavepwdchange(ctx, optional)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UserSavepwdchangeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserSavepwdchangeOpts struct


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

