# AccuClubOpenApi3.TemplateApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**templateAddimage**](TemplateApi.md#templateAddimage) | **GET** /template/addimage | Add an image to a template
[**templateDelete**](TemplateApi.md#templateDelete) | **DELETE** /template/{id} | Delete a template
[**templateEmail**](TemplateApi.md#templateEmail) | **GET** /template/email | Send generated templates by email
[**templateGenerate**](TemplateApi.md#templateGenerate) | **GET** /template/generate | Generate specified templates
[**templateGet**](TemplateApi.md#templateGet) | **GET** /template/{id} | View details of a template
[**templateGetgenerated**](TemplateApi.md#templateGetgenerated) | **GET** /template/getgenerated | View generated templates
[**templateList**](TemplateApi.md#templateList) | **GET** /template/list | View a list of defined templates
[**templateListsources**](TemplateApi.md#templateListsources) | **GET** /template/listsources | View a list of templates&#39; data sources
[**templateSave**](TemplateApi.md#templateSave) | **POST** /template/{id} | Create or edit a template
[**templateSavelayout**](TemplateApi.md#templateSavelayout) | **POST** /template/savelayout | Save the layout of a template



## templateAddimage

> templateAddimage(template, upload, opts)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let template = null; // String | The id of the template where the image has to be added
let upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
let opts = {
  'filename': "filename_example" // String | The local name of the uploaded file. For later reference.
};
apiInstance.templateAddimage(template, upload, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**String**](.md)| The id of the template where the image has to be added | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateDelete

> templateDelete(id, opts)

Delete a template

Allows the user to delete an existing template.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let id = null; // String | The id of the template to delete.
let opts = {
  'body': new AccuClubOpenApi3.AnyType() // AnyType | 
};
apiInstance.templateDelete(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the template to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## templateEmail

> templateEmail(jobid, emailsubject, emailbody, opts)

Send generated templates by email

Allows the user to send generated templates via email through AccuClub.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let jobid = "jobid_example"; // String | The id of the job that is creating the templates.
let emailsubject = "emailsubject_example"; // String | Args depending on the send-to flag.
let emailbody = "emailbody_example"; // String | Args depending on the send-to flag.
let opts = {
  'templatekind': "templatekind_example", // String | The kind of the template you're sending. It must be included in (badge, certificate).
  'emailfrom': "emailfrom_example", // String | The name of the sender to be displayed in the receipients inbox
  'emailreplyto': "emailreplyto_example" // String | The reply-to field for the emails.
};
apiInstance.templateEmail(jobid, emailsubject, emailbody, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| The id of the job that is creating the templates. | 
 **emailsubject** | **String**| Args depending on the send-to flag. | 
 **emailbody** | **String**| Args depending on the send-to flag. | 
 **templatekind** | **String**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional] 
 **emailfrom** | **String**| The name of the sender to be displayed in the receipients inbox | [optional] 
 **emailreplyto** | **String**| The reply-to field for the emails. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateGenerate

> templateGenerate(template, source, singlefile, opts)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let template = null; // String | The id of the template to generate.
let source = null; // String | The source key of the selected template data source.
let singlefile = true; // Boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
let opts = {
  'userid': "userid_example", // String | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
  'forsending': true, // Boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
  'role': null, // String | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
  'filters': "filters_example" // String | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...
};
apiInstance.templateGenerate(template, source, singlefile, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**String**](.md)| The id of the template to generate. | 
 **source** | [**String**](.md)| The source key of the selected template data source. | 
 **singlefile** | **Boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **Boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**String**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateGet

> templateGet(id)

View details of a template

Allows the user to view a template and its details.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let id = null; // String | The id of the template to get.
apiInstance.templateGet(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the template to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateGetgenerated

> templateGetgenerated(jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let jobid = "jobid_example"; // String | The id of the job that is creating the templates.
apiInstance.templateGetgenerated(jobid, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| The id of the job that is creating the templates. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateList

> templateList(from, count, kind, opts)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let kind = "kind_example"; // String | The kind of the templates to return. It must be included in (badge, certificate).
let opts = {
  'designedonly': true // Boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.
};
apiInstance.templateList(from, count, kind, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **Boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateListsources

> templateListsources(kind)

View a list of templates&#39; data sources

Allows the user to see tokens to be used in the template

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let kind = "kind_example"; // String | The kind of the templates to return. It must be included in (badge, certificate).
apiInstance.templateListsources(kind, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateSave

> templateSave(id, opts)

Create or edit a template

Allows the user to create or edit a template.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let id = null; // String | The id of the template to save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.templateSave(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the template to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## templateSavelayout

> templateSavelayout(opts)

Save the layout of a template

Allows the user to edit a template&#39;s layout.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.TemplateApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.templateSavelayout(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

