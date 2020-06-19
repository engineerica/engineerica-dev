# \MediaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MediaCheckin**](MediaApi.md#MediaCheckin) | **Get** /media/checkin | Check in media item
[**MediaCheckout**](MediaApi.md#MediaCheckout) | **Get** /media/checkout | Check out media item
[**MediaCheckoutlist**](MediaApi.md#MediaCheckoutlist) | **Get** /media/checkoutlist | View a list of past media checkouts
[**MediaDelete**](MediaApi.md#MediaDelete) | **Delete** /media/{id} | Delete a media item
[**MediaDeletecheckoutlog**](MediaApi.md#MediaDeletecheckoutlog) | **Delete** /media/deletecheckoutlog | Delete a media checkout log
[**MediaGet**](MediaApi.md#MediaGet) | **Get** /media/{id} | Search and view details of a media item
[**MediaGetbycode**](MediaApi.md#MediaGetbycode) | **Get** /media/getbycode | Search media item by unique code
[**MediaGetcheckout**](MediaApi.md#MediaGetcheckout) | **Get** /media/getcheckout | View details of a media item checkout information
[**MediaGetcheckoutlog**](MediaApi.md#MediaGetcheckoutlog) | **Get** /media/getcheckoutlog | View details of a media checkout log
[**MediaList**](MediaApi.md#MediaList) | **Get** /media/list | View a list of media items
[**MediaSave**](MediaApi.md#MediaSave) | **Post** /media/{id} | Create or edit a media item



## MediaCheckin

> MediaCheckin(ctx, media, checkindate, optional)

Check in media item

Allows the user to check in a media item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**media** | [**string**](.md)| The id of the media item to checkin. | 
**checkindate** | **time.Time**| The checkout date. | 
 **optional** | ***MediaCheckinOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaCheckinOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **notes** | **optional.String**| The notes of the checkout. | 

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


## MediaCheckout

> MediaCheckout(ctx, media, user, checkoutdate, duedate, optional)

Check out media item

Allows the user to check out a media item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**media** | [**string**](.md)| The id of the media item to checkout. | 
**user** | [**string**](.md)| The id of the user that is checking the item out. | 
**checkoutdate** | **time.Time**| The checkout date. | 
**duedate** | **time.Time**| The date when the checkout is due. | 
 **optional** | ***MediaCheckoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaCheckoutOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **staff** | [**optional.Interface of string**](.md)| The id of the staff member related to the checkout. | 
 **event** | [**optional.Interface of string**](.md)| The id of the event related to the checkout. | 
 **notes** | **optional.String**| The notes of the checkout. | 

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


## MediaCheckoutlist

> MediaCheckoutlist(ctx, from, count, optional)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***MediaCheckoutlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaCheckoutlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **media** | [**optional.Interface of string**](.md)| Used to filter the checkouts of a specific media item. | 
 **user** | [**optional.Interface of string**](.md)| Used to filter the checkouts made by a specific user. | 
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


## MediaDelete

> MediaDelete(ctx, id, optional)

Delete a media item

Allows the user to delete an existing media item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the media item to delete. | 
 **optional** | ***MediaDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaDeleteOpts struct


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


## MediaDeletecheckoutlog

> MediaDeletecheckoutlog(ctx, optional)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***MediaDeletecheckoutlogOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaDeletecheckoutlogOpts struct


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


## MediaGet

> MediaGet(ctx, id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the media item to get. | 

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


## MediaGetbycode

> MediaGetbycode(ctx, code, optional)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**code** | **string**| The code of the media item to get. | 
 **optional** | ***MediaGetbycodeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaGetbycodeOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **location** | [**optional.Interface of string**](.md)| The location where to look for the media item. | 

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


## MediaGetcheckout

> MediaGetcheckout(ctx, id, optional)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **optional** | ***MediaGetcheckoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaGetcheckoutOpts struct


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


## MediaGetcheckoutlog

> MediaGetcheckoutlog(ctx, id, optional)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **optional** | ***MediaGetcheckoutlogOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaGetcheckoutlogOpts struct


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


## MediaList

> MediaList(ctx, from, count, optional)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***MediaListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **status** | **optional.Int32**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | 
 **user** | [**optional.Interface of string**](.md)| Used to filter the media items that are checked-out by a specific user. | 

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


## MediaSave

> MediaSave(ctx, id, optional)

Create or edit a media item

Allows the user to create or edit a media item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the media item save (leave empty to create a new one). | 
 **optional** | ***MediaSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediaSaveOpts struct


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

