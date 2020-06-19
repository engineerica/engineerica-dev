# \CompassserviceApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompassserviceList**](CompassserviceApi.md#CompassserviceList) | **Get** /compassservice/list | View all the services added to the compass
[**CompassserviceListlocations**](CompassserviceApi.md#CompassserviceListlocations) | **Get** /compassservice/listlocations | View all the locations where a service added to the compass is available



## CompassserviceList

> CompassserviceList(ctx, optional)

View all the services added to the compass

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***CompassserviceListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CompassserviceListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**optional.Interface of string**](.md)| The id of the category to filter the services. | 

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


## CompassserviceListlocations

> CompassserviceListlocations(ctx, serviceid)

View all the locations where a service added to the compass is available

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceid** | [**string**](.md)| The id of the service to get its locations. | 

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

