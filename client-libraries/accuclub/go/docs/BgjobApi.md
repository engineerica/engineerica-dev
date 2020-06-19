# \BgjobApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BgjobGetstatus**](BgjobApi.md#BgjobGetstatus) | **Get** /bgjob/getstatus | Get background job status



## BgjobGetstatus

> BgjobGetstatus(ctx, optional)

Get background job status

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***BgjobGetstatusOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a BgjobGetstatusOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | [**optional.Interface of string**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | 
 **jobtype** | **optional.String**| The job type to filter by. | 

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

