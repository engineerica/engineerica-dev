# \SsoApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SsoGeneratekey**](SsoApi.md#SsoGeneratekey) | **Get** /sso/generatekey | Generate/reset single sign on access key.
[**SsoGetsettings**](SsoApi.md#SsoGetsettings) | **Get** /sso/getsettings | View single sign on settings.
[**SsoIssuetoken**](SsoApi.md#SsoIssuetoken) | **Get** /sso/issuetoken | Issue single sign-on token
[**SsoSavesettings**](SsoApi.md#SsoSavesettings) | **Post** /sso/savesettings | Edit single sign-on settings.



## SsoGeneratekey

> SsoGeneratekey(ctx, )

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

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


## SsoGetsettings

> SsoGetsettings(ctx, )

View single sign on settings.

Allows the user to view settings for single sign-on.

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


## SsoIssuetoken

> SsoIssuetoken(ctx, key, username, optional)

Issue single sign-on token

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**key** | **string**| The single sign-on key of the account. | 
**username** | **string**| The email of the user to sign-on. | 
 **optional** | ***SsoIssuetokenOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SsoIssuetokenOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **expires** | **optional.Bool**| Specifies whether the session should expire when inactive. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SsoSavesettings

> SsoSavesettings(ctx, optional)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SsoSavesettingsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SsoSavesettingsOpts struct


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

