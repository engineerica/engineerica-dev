# \WaitinglineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WaitinglineAdduser**](WaitinglineApi.md#WaitinglineAdduser) | **Get** /waitingline/adduser | Put user in a waiting line
[**WaitinglineDelete**](WaitinglineApi.md#WaitinglineDelete) | **Delete** /waitingline/{id} | Delete a waiting line
[**WaitinglineGet**](WaitinglineApi.md#WaitinglineGet) | **Get** /waitingline/{id} | View details of a waiting line
[**WaitinglineIsuserin**](WaitinglineApi.md#WaitinglineIsuserin) | **Get** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**WaitinglineList**](WaitinglineApi.md#WaitinglineList) | **Get** /waitingline/list | View a list of waiting lines
[**WaitinglineRemoveuser**](WaitinglineApi.md#WaitinglineRemoveuser) | **Get** /waitingline/removeuser | Remove a user from a waiting line
[**WaitinglineSave**](WaitinglineApi.md#WaitinglineSave) | **Post** /waitingline/{id} | Create or edit a waiting line
[**WaitinglineSigninuser**](WaitinglineApi.md#WaitinglineSigninuser) | **Get** /waitingline/signinuser | Sign a user in from a waiting line



## WaitinglineAdduser

> WaitinglineAdduser(ctx, station, user, optional)

Put user in a waiting line

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station. | 
**user** | **string**| The user&#39;s card number. | 
 **optional** | ***WaitinglineAdduserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglineAdduserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **locationid** | [**optional.Interface of string**](.md)| The location&#39;s id where the swipe must be saved. | 
 **time** | **optional.Time**| The date and time of the swipe. | 
 **signinrole** | **optional.String**| Specifies if the sign-in is for an attendee or a staff member | 
 **roleid** | [**optional.Interface of string**](.md)| Specifies the role the user has selected in order to sign-in | 
 **services** | **optional.String**| The services ids the user has selected. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event the user selected. | 
 **staff** | [**optional.Interface of string**](.md)| The id of the staff member the user selected. | 
 **photosize** | **optional.Int32**| The swiping user&#39;s photo size. | 

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


## WaitinglineDelete

> WaitinglineDelete(ctx, id, optional)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the line to delete. | 
 **optional** | ***WaitinglineDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglineDeleteOpts struct


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


## WaitinglineGet

> WaitinglineGet(ctx, id, optional)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the waiting line to get. | 
 **optional** | ***WaitinglineGetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglineGetOpts struct


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


## WaitinglineIsuserin

> WaitinglineIsuserin(ctx, station, time, user, optional)

Check whether a user is in a waiting line, signed-in or is not in the area

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station. | 
**time** | **time.Time**| The date and time of the swipe. | 
**user** | **string**| The card number of the user. | 
 **optional** | ***WaitinglineIsuserinOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglineIsuserinOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **location** | [**optional.Interface of string**](.md)| The id of the location the user picked. | 

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


## WaitinglineList

> WaitinglineList(ctx, from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

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


## WaitinglineRemoveuser

> WaitinglineRemoveuser(ctx, waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**waitingline** | [**string**](.md)| The id of the waiting line whose item has to be removed. | 
**itemid** | [**string**](.md)| The ID of the item that has to be removed. | 

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


## WaitinglineSave

> WaitinglineSave(ctx, id, optional)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the waiting line save (leave empty to create a new one). | 
 **optional** | ***WaitinglineSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglineSaveOpts struct


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


## WaitinglineSigninuser

> WaitinglineSigninuser(ctx, waitingline, itemid, staff, optional)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**waitingline** | [**string**](.md)| The id of the waiting line whose item needs to be signed-in. | 
**itemid** | [**string**](.md)| The ID of the item that has to be signed-in. | 
**staff** | [**string**](.md)| The id of the staff member selected to sign-in. | 
 **optional** | ***WaitinglineSigninuserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglineSigninuserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **photosize** | **optional.Int32**| The swiping user&#39;s photo size. | 

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

