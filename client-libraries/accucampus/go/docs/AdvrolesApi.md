# \AdvrolesApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdvrolesUserlist**](AdvrolesApi.md#AdvrolesUserlist) | **Get** /advroles/userlist | List users. Alias to user.list, use that one instead.



## AdvrolesUserlist

> AdvrolesUserlist(ctx, from, count, optional)

List users. Alias to user.list, use that one instead.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AdvrolesUserlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvrolesUserlistOpts struct


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

