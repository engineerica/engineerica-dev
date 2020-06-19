# \ReportApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportList**](ReportApi.md#ReportList) | **Get** /report/list | View a list of available reports
[**ReportPermissionsbyuser**](ReportApi.md#ReportPermissionsbyuser) | **Get** /report/permissionsbyuser | Permissions by user report
[**ReportPrepare**](ReportApi.md#ReportPrepare) | **Get** /report/prepare | Queries and loads the specified report, in background.
[**ReportQuery**](ReportApi.md#ReportQuery) | **Get** /report/query | Query and load a specified report



## ReportList

> ReportList(ctx, )

View a list of available reports

Allows the user to view the complete list of available, canned reports.

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


## ReportPermissionsbyuser

> ReportPermissionsbyuser(ctx, optional)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ReportPermissionsbyuserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReportPermissionsbyuserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **optional.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | 

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


## ReportPrepare

> ReportPrepare(ctx, reportname, optional)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**reportname** | **string**| The name of the report to execute | 
 **optional** | ***ReportPrepareOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReportPrepareOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **params** | **optional.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | 
 **repformat** | **optional.String**| The format of the resulting report. Json, pdf, csv, ... | 
 **fillgroupid** | [**optional.Interface of string**](.md)| If specified, the result is used to fill the group with the given ID | 
 **groupby** | **optional.String**| How to group the records. In the format &#39;col1+col2|col3+col4 | 
 **refreshgroup** | [**optional.Interface of string**](.md)| The ID of the group to check (and refresh) before processing the report. | 
 **filtertext** | **optional.String**| The user friendly text of the applied filters. | 

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


## ReportQuery

> ReportQuery(ctx, reportname, optional)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**reportname** | **string**| The name of the report to execute | 
 **optional** | ***ReportQueryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReportQueryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **params** | **optional.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | 

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

