# \TemplateApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TemplateAddimage**](TemplateApi.md#TemplateAddimage) | **Get** /template/addimage | Add an image to a template
[**TemplateDelete**](TemplateApi.md#TemplateDelete) | **Delete** /template/{id} | Delete a template
[**TemplateEmail**](TemplateApi.md#TemplateEmail) | **Get** /template/email | Send generated templates by email
[**TemplateGenerate**](TemplateApi.md#TemplateGenerate) | **Get** /template/generate | Generate specified templates
[**TemplateGet**](TemplateApi.md#TemplateGet) | **Get** /template/{id} | View details of a template
[**TemplateGetgenerated**](TemplateApi.md#TemplateGetgenerated) | **Get** /template/getgenerated | View generated templates
[**TemplateList**](TemplateApi.md#TemplateList) | **Get** /template/list | View a list of defined templates
[**TemplateListsources**](TemplateApi.md#TemplateListsources) | **Get** /template/listsources | View a list of templates&#39; data sources
[**TemplateSave**](TemplateApi.md#TemplateSave) | **Post** /template/{id} | Create or edit a template
[**TemplateSavelayout**](TemplateApi.md#TemplateSavelayout) | **Post** /template/savelayout | Save the layout of a template



## TemplateAddimage

> TemplateAddimage(ctx, template, upload, optional)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**template** | [**string**](.md)| The id of the template where the image has to be added | 
**upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **optional** | ***TemplateAddimageOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateAddimageOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **filename** | **optional.String**| The local name of the uploaded file. For later reference. | 

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


## TemplateDelete

> TemplateDelete(ctx, id, optional)

Delete a template

Allows the user to delete an existing template.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the template to delete. | 
 **optional** | ***TemplateDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateDeleteOpts struct


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


## TemplateEmail

> TemplateEmail(ctx, jobid, emailsubject, emailbody, optional)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**jobid** | **string**| The id of the job that is creating the templates. | 
**emailsubject** | **string**| Args depending on the send-to flag. | 
**emailbody** | **string**| Args depending on the send-to flag. | 
 **optional** | ***TemplateEmailOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateEmailOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **templatekind** | **optional.String**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | 
 **emailfrom** | **optional.String**| The name of the sender to be displayed in the receipients inbox | 
 **emailreplyto** | **optional.String**| The reply-to field for the emails. | 

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


## TemplateGenerate

> TemplateGenerate(ctx, template, source, singlefile, optional)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**template** | [**string**](.md)| The id of the template to generate. | 
**source** | [**string**](.md)| The source key of the selected template data source. | 
**singlefile** | **bool**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **optional** | ***TemplateGenerateOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateGenerateOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **userid** | **optional.String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | 
 **forsending** | **optional.Bool**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | 
 **role** | [**optional.Interface of string**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | 
 **filters** | **optional.String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | 

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


## TemplateGet

> TemplateGet(ctx, id)

View details of a template

Allows the user to view a template and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the template to get. | 

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


## TemplateGetgenerated

> TemplateGetgenerated(ctx, jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**jobid** | **string**| The id of the job that is creating the templates. | 

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


## TemplateList

> TemplateList(ctx, from, count, kind, optional)

View a list of defined templates

Allows the user to view the full list of created templates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
**kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **optional** | ***TemplateListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **designedonly** | **optional.Bool**| If true then it only returns the templates that were designed. Otherwise, it returns all. | 

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


## TemplateListsources

> TemplateListsources(ctx, kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 

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


## TemplateSave

> TemplateSave(ctx, id, optional)

Create or edit a template

Allows the user to create or edit a template.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the template to save (leave empty to create a new one). | 
 **optional** | ***TemplateSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateSaveOpts struct


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


## TemplateSavelayout

> TemplateSavelayout(ctx, optional)

Save the layout of a template

Allows the user to edit a template's layout.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TemplateSavelayoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateSavelayoutOpts struct


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

