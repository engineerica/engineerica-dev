# \BeaconApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BeaconDelete**](BeaconApi.md#BeaconDelete) | **Delete** /beacon/{id} | Delete a beacon profile
[**BeaconDisable**](BeaconApi.md#BeaconDisable) | **Get** /beacon/disable | Disable beacon support account wide
[**BeaconGet**](BeaconApi.md#BeaconGet) | **Get** /beacon/{id} | View details of a beacon profile
[**BeaconGetlocations**](BeaconApi.md#BeaconGetlocations) | **Get** /beacon/getlocations | Get the sign-in stations assigned to specific beacons.
[**BeaconGetstationlocation**](BeaconApi.md#BeaconGetstationlocation) | **Get** /beacon/getstationlocation | Get the location settings in the specified sign-in station.
[**BeaconGetuuid**](BeaconApi.md#BeaconGetuuid) | **Get** /beacon/getuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**BeaconList**](BeaconApi.md#BeaconList) | **Get** /beacon/list | View a list of beacon profiles
[**BeaconListprofiles**](BeaconApi.md#BeaconListprofiles) | **Get** /beacon/listprofiles | View a list of beacon profiles with their characteristics
[**BeaconResetuuid**](BeaconApi.md#BeaconResetuuid) | **Get** /beacon/resetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**BeaconSave**](BeaconApi.md#BeaconSave) | **Post** /beacon/{id} | Create or edit a beacon profile
[**BeaconScanlocations**](BeaconApi.md#BeaconScanlocations) | **Get** /beacon/scanlocations | Check if there&#39;s location available to sign-in / out.
[**BeaconSetuuid**](BeaconApi.md#BeaconSetuuid) | **Get** /beacon/setuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**BeaconSilentregions**](BeaconApi.md#BeaconSilentregions) | **Get** /beacon/silentregions | View all the beacon regions defined for silent tracking
[**BeaconSilentsignin**](BeaconApi.md#BeaconSilentsignin) | **Get** /beacon/silentsignin | Sign-in silently from the location specified by a beacon
[**BeaconSilentsignout**](BeaconApi.md#BeaconSilentsignout) | **Get** /beacon/silentsignout | Sign-out silently from the location specified by a beacon



## BeaconDelete

> BeaconDelete(ctx, id, optional)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the beacon to delete. | 
 **optional** | ***BeaconDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a BeaconDeleteOpts struct


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


## BeaconDisable

> BeaconDisable(ctx, )

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

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


## BeaconGet

> BeaconGet(ctx, id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the beacon to get. | 

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


## BeaconGetlocations

> BeaconGetlocations(ctx, beacons)

Get the sign-in stations assigned to specific beacons.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

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


## BeaconGetstationlocation

> BeaconGetstationlocation(ctx, station, location)

Get the location settings in the specified sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
**location** | [**string**](.md)| The id of the location whose information has to be retrieved. | 

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


## BeaconGetuuid

> BeaconGetuuid(ctx, )

View the identifier for the account's beacon region (for sign-in stations).

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


## BeaconList

> BeaconList(ctx, from, count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

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


## BeaconListprofiles

> BeaconListprofiles(ctx, )

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

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


## BeaconResetuuid

> BeaconResetuuid(ctx, )

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

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


## BeaconSave

> BeaconSave(ctx, id, optional)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the beacon save (leave empty to create a new one). | 
 **optional** | ***BeaconSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a BeaconSaveOpts struct


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


## BeaconScanlocations

> BeaconScanlocations(ctx, beacons)

Check if there's location available to sign-in / out.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

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


## BeaconSetuuid

> BeaconSetuuid(ctx, id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The custom region UUID. | 

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


## BeaconSilentregions

> BeaconSilentregions(ctx, )

View all the beacon regions defined for silent tracking

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


## BeaconSilentsignin

> BeaconSilentsignin(ctx, uuid)

Sign-in silently from the location specified by a beacon

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**uuid** | [**string**](.md)| The id of the region the user is in. | 

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


## BeaconSilentsignout

> BeaconSilentsignout(ctx, uuid)

Sign-out silently from the location specified by a beacon

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**uuid** | [**string**](.md)| The id of the region the user has left. | 

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

