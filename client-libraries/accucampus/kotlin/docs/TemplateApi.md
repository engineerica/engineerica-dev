# TemplateApi

All URIs are relative to *https://accucampus.net:443/api/v1*

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


<a name="templateAddimage"></a>
# **templateAddimage**
> templateAddimage(template, upload, filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val template : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template where the image has to be added
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The local name of the uploaded file. For later reference.
try {
    apiInstance.templateAddimage(template, upload, filename)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateAddimage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateAddimage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**java.util.UUID**](.md)| The id of the template where the image has to be added |
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The local name of the uploaded file. For later reference. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateDelete"></a>
# **templateDelete**
> templateDelete(id, body)

Delete a template

Allows the user to delete an existing template.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.templateDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the template to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="templateEmail"></a>
# **templateEmail**
> templateEmail(jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val jobid : kotlin.String = jobid_example // kotlin.String | The id of the job that is creating the templates.
val emailsubject : kotlin.String = emailsubject_example // kotlin.String | Args depending on the send-to flag.
val emailbody : kotlin.String = emailbody_example // kotlin.String | Args depending on the send-to flag.
val templatekind : kotlin.String = templatekind_example // kotlin.String | The kind of the template you're sending. It must be included in (badge, certificate).
val emailfrom : kotlin.String = emailfrom_example // kotlin.String | The name of the sender to be displayed in the receipients inbox
val emailreplyto : kotlin.String = emailreplyto_example // kotlin.String | The reply-to field for the emails.
try {
    apiInstance.templateEmail(jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateEmail")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateEmail")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **kotlin.String**| The id of the job that is creating the templates. |
 **emailsubject** | **kotlin.String**| Args depending on the send-to flag. |
 **emailbody** | **kotlin.String**| Args depending on the send-to flag. |
 **templatekind** | **kotlin.String**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional]
 **emailfrom** | **kotlin.String**| The name of the sender to be displayed in the receipients inbox | [optional]
 **emailreplyto** | **kotlin.String**| The reply-to field for the emails. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateGenerate"></a>
# **templateGenerate**
> templateGenerate(template, source, singlefile, userid, forsending, role, filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val template : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template to generate.
val source : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The source key of the selected template data source.
val singlefile : kotlin.Boolean = true // kotlin.Boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
val userid : kotlin.String = userid_example // kotlin.String | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
val forsending : kotlin.Boolean = true // kotlin.Boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
val role : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
val filters : kotlin.String = filters_example // kotlin.String | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...
try {
    apiInstance.templateGenerate(template, source, singlefile, userid, forsending, role, filters)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateGenerate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateGenerate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**java.util.UUID**](.md)| The id of the template to generate. |
 **source** | [**java.util.UUID**](.md)| The source key of the selected template data source. |
 **singlefile** | **kotlin.Boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. |
 **userid** | **kotlin.String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional]
 **forsending** | **kotlin.Boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional]
 **role** | [**java.util.UUID**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional]
 **filters** | **kotlin.String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateGet"></a>
# **templateGet**
> templateGet(id)

View details of a template

Allows the user to view a template and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template to get.
try {
    apiInstance.templateGet(id)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the template to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateGetgenerated"></a>
# **templateGetgenerated**
> templateGetgenerated(jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val jobid : kotlin.String = jobid_example // kotlin.String | The id of the job that is creating the templates.
try {
    apiInstance.templateGetgenerated(jobid)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateGetgenerated")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateGetgenerated")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **kotlin.String**| The id of the job that is creating the templates. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateList"></a>
# **templateList**
> templateList(from, count, kind, designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val kind : kotlin.String = kind_example // kotlin.String | The kind of the templates to return. It must be included in (badge, certificate).
val designedonly : kotlin.Boolean = true // kotlin.Boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.
try {
    apiInstance.templateList(from, count, kind, designedonly)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **kind** | **kotlin.String**| The kind of the templates to return. It must be included in (badge, certificate). |
 **designedonly** | **kotlin.Boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateListsources"></a>
# **templateListsources**
> templateListsources(kind)

View a list of templates&#39; data sources

Allows the user to see tokens to be used in the template

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val kind : kotlin.String = kind_example // kotlin.String | The kind of the templates to return. It must be included in (badge, certificate).
try {
    apiInstance.templateListsources(kind)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateListsources")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateListsources")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kind** | **kotlin.String**| The kind of the templates to return. It must be included in (badge, certificate). |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateSave"></a>
# **templateSave**
> templateSave(id, UNKNOWN_BASE_TYPE)

Create or edit a template

Allows the user to create or edit a template.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.templateSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the template to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="templateSavelayout"></a>
# **templateSavelayout**
> templateSavelayout(UNKNOWN_BASE_TYPE)

Save the layout of a template

Allows the user to edit a template&#39;s layout.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TemplateApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.templateSavelayout(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling TemplateApi#templateSavelayout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TemplateApi#templateSavelayout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

