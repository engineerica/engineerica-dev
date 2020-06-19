# \HolidayApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HolidayList**](HolidayApi.md#HolidayList) | **Get** /holiday/list | View a list of entered holidays
[**HolidaySave**](HolidayApi.md#HolidaySave) | **Post** /holiday/save | Create or edit a list of holidays
[**HolidaySuggest**](HolidayApi.md#HolidaySuggest) | **Get** /holiday/suggest | View the holiday suggestions in the given term



## HolidayList

> HolidayList(ctx, term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**term** | [**string**](.md)| The term to get holidays from. | 

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


## HolidaySave

> HolidaySave(ctx, optional)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***HolidaySaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a HolidaySaveOpts struct


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


## HolidaySuggest

> HolidaySuggest(ctx, term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**term** | [**string**](.md)| The term to get holidays from. | 

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

