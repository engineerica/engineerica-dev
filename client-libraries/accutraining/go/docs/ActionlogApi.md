# \ActionlogApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionlogList**](ActionlogApi.md#ActionlogList) | **Get** /actionlog/list | View a list of users action logs



## ActionlogList

> ActionlogList(ctx, from, count, optional)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***ActionlogListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionlogListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **user** | [**optional.Interface of string**](.md)| The id of the user whose action logs have to be returned. | 
 **startdate** | **optional.Time**| The start date of the period to filter the logs. | 
 **enddate** | **optional.Time**| The end date of the period to filter the logs. | 
 **resource** | **optional.String**| The resource to filter the action logs. | 
 **actionfilter** | **optional.String**| The action to filter the action logs. | 
 **argument** | **optional.String**| The id of the entity that was the argument of the executed action. | 

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

