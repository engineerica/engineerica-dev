# \QrloginApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QrloginGet**](QrloginApi.md#QrloginGet) | **Get** /qrlogin/get | Gets an image of a QR token
[**QrloginLogin**](QrloginApi.md#QrloginLogin) | **Get** /qrlogin/login | Login



## QrloginGet

> QrloginGet(ctx, )

Gets an image of a QR token

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


## QrloginLogin

> QrloginLogin(ctx, onetimetoken)

Login

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**onetimetoken** | **string**| The token read from the QR code. | 

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

