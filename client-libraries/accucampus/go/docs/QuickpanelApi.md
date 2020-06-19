# \QuickpanelApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QuickpanelDeletewidget**](QuickpanelApi.md#QuickpanelDeletewidget) | **Delete** /quickpanel/deletewidget | Deletes a widget from the Quick Panel
[**QuickpanelFetchwidget**](QuickpanelApi.md#QuickpanelFetchwidget) | **Get** /quickpanel/fetchwidget | Fetches the information for a specific widget.
[**QuickpanelGetwidget**](QuickpanelApi.md#QuickpanelGetwidget) | **Get** /quickpanel/getwidget | View details of a widget included in the Quick Panel
[**QuickpanelInit**](QuickpanelApi.md#QuickpanelInit) | **Get** /quickpanel/init | Returns the initial information required to show the quick panels
[**QuickpanelListwidgets**](QuickpanelApi.md#QuickpanelListwidgets) | **Get** /quickpanel/listwidgets | Lists all the widgets that are added in the Quick Panel
[**QuickpanelListwidgettypes**](QuickpanelApi.md#QuickpanelListwidgettypes) | **Get** /quickpanel/listwidgettypes | Lists all the widget types available in the system
[**QuickpanelReorderwidgets**](QuickpanelApi.md#QuickpanelReorderwidgets) | **Get** /quickpanel/reorderwidgets | Reorders the widgets and moves them to a specific column
[**QuickpanelSavewidget**](QuickpanelApi.md#QuickpanelSavewidget) | **Post** /quickpanel/savewidget | Saves a widget for the Quick Panel



## QuickpanelDeletewidget

> QuickpanelDeletewidget(ctx, optional)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***QuickpanelDeletewidgetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a QuickpanelDeletewidgetOpts struct


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


## QuickpanelFetchwidget

> QuickpanelFetchwidget(ctx, widgetid)

Fetches the information for a specific widget.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**widgetid** | [**string**](.md)| The ID of the data to fetch it&#39;s data. | 

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


## QuickpanelGetwidget

> QuickpanelGetwidget(ctx, id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the widget to get. | 

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


## QuickpanelInit

> QuickpanelInit(ctx, )

Returns the initial information required to show the quick panels

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


## QuickpanelListwidgets

> QuickpanelListwidgets(ctx, )

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

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


## QuickpanelListwidgettypes

> QuickpanelListwidgettypes(ctx, )

Lists all the widget types available in the system

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


## QuickpanelReorderwidgets

> QuickpanelReorderwidgets(ctx, sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**sectionname** | **string**| The section name where to sort the widgets. | 
**orderids** | **string**| CSV list of the widgets to reorder. | 

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


## QuickpanelSavewidget

> QuickpanelSavewidget(ctx, optional)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***QuickpanelSavewidgetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a QuickpanelSavewidgetOpts struct


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

