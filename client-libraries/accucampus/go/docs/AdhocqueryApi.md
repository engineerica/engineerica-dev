# \AdhocqueryApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdhocqueryCheckexecution**](AdhocqueryApi.md#AdhocqueryCheckexecution) | **Get** /adhocquery/checkexecution | Check the status of an ad hoc query execution
[**AdhocqueryDelete**](AdhocqueryApi.md#AdhocqueryDelete) | **Delete** /adhocquery/{id} | Delete an ad hoc query
[**AdhocqueryExecute**](AdhocqueryApi.md#AdhocqueryExecute) | **Get** /adhocquery/execute | Execute an ad hoc query
[**AdhocqueryGet**](AdhocqueryApi.md#AdhocqueryGet) | **Get** /adhocquery/{id} | View details of an ad hoc query
[**AdhocqueryGetschema**](AdhocqueryApi.md#AdhocqueryGetschema) | **Get** /adhocquery/getschema | View the database schema for making ad hoc queries
[**AdhocqueryList**](AdhocqueryApi.md#AdhocqueryList) | **Get** /adhocquery/list | View a list of saved ad hoc queries
[**AdhocqueryListexecutions**](AdhocqueryApi.md#AdhocqueryListexecutions) | **Get** /adhocquery/listexecutions | View a list of ad hoc queries executions
[**AdhocquerySave**](AdhocqueryApi.md#AdhocquerySave) | **Post** /adhocquery/{id} | Create or edit an ad hoc query
[**AdhocqueryStopexecution**](AdhocqueryApi.md#AdhocqueryStopexecution) | **Get** /adhocquery/stopexecution | Stops the execution of an ad hoc query



## AdhocqueryCheckexecution

> AdhocqueryCheckexecution(ctx, id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the ad hoc query execution to be checked. | 

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


## AdhocqueryDelete

> AdhocqueryDelete(ctx, id, optional)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the ad hoc query to delete. | 
 **optional** | ***AdhocqueryDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdhocqueryDeleteOpts struct


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


## AdhocqueryExecute

> AdhocqueryExecute(ctx, optional)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AdhocqueryExecuteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdhocqueryExecuteOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**optional.Interface of string**](.md)| The id of the query to execute. | 
 **query** | **optional.String**| The query to execute. | 

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


## AdhocqueryGet

> AdhocqueryGet(ctx, id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the query to get. | 

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


## AdhocqueryGetschema

> AdhocqueryGetschema(ctx, )

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

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


## AdhocqueryList

> AdhocqueryList(ctx, from, count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

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


## AdhocqueryListexecutions

> AdhocqueryListexecutions(ctx, from, count, optional)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AdhocqueryListexecutionsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdhocqueryListexecutionsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **query** | [**optional.Interface of string**](.md)| The first record to return. | 

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


## AdhocquerySave

> AdhocquerySave(ctx, id, optional)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the query to save (leave empty to create a new one). | 
 **optional** | ***AdhocquerySaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdhocquerySaveOpts struct


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


## AdhocqueryStopexecution

> AdhocqueryStopexecution(ctx, id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the ad hoc query execution to be stopped. | 

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

