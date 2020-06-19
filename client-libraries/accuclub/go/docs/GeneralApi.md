# \GeneralApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallImport**](GeneralApi.md#CallImport) | **Get** /import | Import data into AccuClub
[**Changelog**](GeneralApi.md#Changelog) | **Get** /changelog | Get the application change log
[**Doc**](GeneralApi.md#Doc) | **Get** /doc | Get the documentation
[**Export**](GeneralApi.md#Export) | **Get** /export | Export AccuClub data
[**Listtimezones**](GeneralApi.md#Listtimezones) | **Get** /listtimezones | Lists the available timezones
[**Login**](GeneralApi.md#Login) | **Get** /login | Login
[**Logout**](GeneralApi.md#Logout) | **Get** /logout | Logout
[**Search**](GeneralApi.md#Search) | **Get** /search | Search
[**Texttoimage**](GeneralApi.md#Texttoimage) | **Get** /texttoimage | Generates a dynamic image from text
[**Version**](GeneralApi.md#Version) | **Get** /version | Get current version information



## CallImport

> CallImport(ctx, importtype, upload, optional)

Import data into AccuClub

Allows the user to import data into AccuClub via CSV or flat files either manually or automatically using the import utility.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**importtype** | **string**| The kind of data that is being uploaded. | 
**upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **optional** | ***CallImportOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CallImportOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **filename** | **optional.String**| The local name of the uploaded file. For later reference. | 
 **parameters** | **optional.String**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | 

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


## Changelog

> Changelog(ctx, )

Get the application change log

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


## Doc

> Doc(ctx, optional)

Get the documentation

Retrieves the list of actions available in the system.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***DocOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a DocOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **optional.Bool**| If true it excludes the anonymous actions from the returned list. | 

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


## Export

> Export(ctx, exporttype, exportformat, optional)

Export AccuClub data

Allows the user to export data from AccuClub into a CSV, HTML, or Excel format.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**exporttype** | **string**| What to export. | 
**exportformat** | **string**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **optional** | ***ExportOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ExportOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **filters** | **optional.String**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | 

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


## Listtimezones

> Listtimezones(ctx, )

Lists the available timezones

### Required Parameters

This endpoint does not need any parameter.

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


## Login

> Login(ctx, domain, username, password, method, optional)

Login

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**domain** | **string**| The account domain to login. | 
**username** | **string**| The username (email) of the user to login as. | 
**password** | **string**| The password of the user to login as. | 
**method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **optional** | ***LoginOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LoginOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **rememberme** | **optional.Bool**| If true then the session will not expire. | 

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


## Logout

> Logout(ctx, )

Logout

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


## Search

> Search(ctx, query, optional)

Search

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**query** | **string**| The query to search for. | 
 **optional** | ***SearchOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SearchOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **page** | **optional.Int32**| Current page to show, zero-based. | 

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


## Texttoimage

> Texttoimage(ctx, text, optional)

Generates a dynamic image from text

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**text** | **string**| The text to convert to an image, use double pipes (||) as a new line. | 
 **optional** | ***TexttoimageOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TexttoimageOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **fontcolor** | **optional.String**| The color of the text, in hex format, without the #. | 
 **fontsize** | **optional.Int32**| The size of the text, in points. | 
 **direction** | **optional.String**| Either vertical or horizontal, default horizontal. | 
 **width** | **optional.Int32**| The image width in pixels (or height if the direction is vertical). | 

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


## Version

> Version(ctx, )

Get current version information

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

