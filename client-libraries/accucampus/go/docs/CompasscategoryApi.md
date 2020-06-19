# \CompasscategoryApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompasscategoryDelete**](CompasscategoryApi.md#CompasscategoryDelete) | **Delete** /compasscategory/{id} | Delete a compass category
[**CompasscategoryGet**](CompasscategoryApi.md#CompasscategoryGet) | **Get** /compasscategory/{id} | View details of a compass category
[**CompasscategoryList**](CompasscategoryApi.md#CompasscategoryList) | **Get** /compasscategory/list | View a list of compass categories
[**CompasscategorySave**](CompasscategoryApi.md#CompasscategorySave) | **Post** /compasscategory/{id} | Create or edit a compass category



## CompasscategoryDelete

> CompasscategoryDelete(ctx, id, optional)

Delete a compass category

Allows the user to delete an existing compass category.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the category to delete. | 
 **optional** | ***CompasscategoryDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CompasscategoryDeleteOpts struct


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


## CompasscategoryGet

> CompasscategoryGet(ctx, id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the category to get. | 

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


## CompasscategoryList

> CompasscategoryList(ctx, optional)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***CompasscategoryListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CompasscategoryListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **optional.Int32**| The first record to return. | 
 **count** | **optional.Int32**| The max number of records to return. | 
 **onlywithservices** | **optional.Bool**| Specified whether only categories with services are returned or all. | 

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


## CompasscategorySave

> CompasscategorySave(ctx, id, optional)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the category save (leave empty to create a new one). | 
 **optional** | ***CompasscategorySaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CompasscategorySaveOpts struct


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

