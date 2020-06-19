# \LicenseApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LicenseAcceptagreement**](LicenseApi.md#LicenseAcceptagreement) | **Get** /license/acceptagreement | Accept the license agreement
[**LicenseGetagreementstatus**](LicenseApi.md#LicenseGetagreementstatus) | **Get** /license/getagreementstatus | Check if license agreement has been accepted
[**LicenseGetcurrent**](LicenseApi.md#LicenseGetcurrent) | **Get** /license/getcurrent | Gets the current license information
[**LicenseRenew**](LicenseApi.md#LicenseRenew) | **Get** /license/renew | Contact Engineerica in order to renew the AccuClub subscription



## LicenseAcceptagreement

> LicenseAcceptagreement(ctx, )

Accept the license agreement

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


## LicenseGetagreementstatus

> LicenseGetagreementstatus(ctx, )

Check if license agreement has been accepted

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


## LicenseGetcurrent

> LicenseGetcurrent(ctx, )

Gets the current license information

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


## LicenseRenew

> LicenseRenew(ctx, email, phonenumber, optional)

Contact Engineerica in order to renew the AccuClub subscription

Allows the user to select the option to contact Engineerica when the AccuClub account is nearing its renewal date.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**email** | **string**| The e-mail of the user sending the request. | 
**phonenumber** | **string**| The phone number of the user sending the request. | 
 **optional** | ***LicenseRenewOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LicenseRenewOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **jobtitle** | **optional.String**| The job title of the user sending the request. | 
 **institution** | **optional.String**| The institution of the user sending the request. | 
 **comments** | **optional.String**| Comments entered by the user sending the request. | 

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

