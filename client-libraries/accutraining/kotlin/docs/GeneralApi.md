# GeneralApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**changelog**](GeneralApi.md#changelog) | **GET** /changelog | Get the application change log
[**doc**](GeneralApi.md#doc) | **GET** /doc | Get the documentation
[**export**](GeneralApi.md#export) | **GET** /export | Export AccuTraining data
[**import**](GeneralApi.md#import) | **GET** /import | Import data into AccuTraining
[**listtimezones**](GeneralApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**login**](GeneralApi.md#login) | **GET** /login | Login
[**logout**](GeneralApi.md#logout) | **GET** /logout | Logout
[**search**](GeneralApi.md#search) | **GET** /search | Search
[**texttoimage**](GeneralApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
[**version**](GeneralApi.md#version) | **GET** /version | Get current version information


<a name="changelog"></a>
# **changelog**
> changelog()

Get the application change log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
try {
    apiInstance.changelog()
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#changelog")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#changelog")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="doc"></a>
# **doc**
> doc(excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
val excludeanonymous : kotlin.Boolean = true // kotlin.Boolean | If true it excludes the anonymous actions from the returned list.
try {
    apiInstance.doc(excludeanonymous)
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#doc")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#doc")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **kotlin.Boolean**| If true it excludes the anonymous actions from the returned list. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="export"></a>
# **export**
> export(exporttype, exportformat, filters)

Export AccuTraining data

Allows the user to export data from AccuTraining into a CSV, HTML, or Excel format.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
val exporttype : kotlin.String = exporttype_example // kotlin.String | What to export.
val exportformat : kotlin.String = exportformat_example // kotlin.String | The format of the resulting file. Valid types are CSV, HTML, XLS.
val filters : kotlin.String = filters_example // kotlin.String | Pipe separated filters for the export, eg: aaa=val|bbb=val|...
try {
    apiInstance.export(exporttype, exportformat, filters)
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#export")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#export")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exporttype** | **kotlin.String**| What to export. |
 **exportformat** | **kotlin.String**| The format of the resulting file. Valid types are CSV, HTML, XLS. |
 **filters** | **kotlin.String**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="import"></a>
# **import**
> import(importtype, upload, filename, parameters)

Import data into AccuTraining

Allows the user to import data into AccuTraining via CSV or flat files either manually or automatically using the import utility.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
val importtype : kotlin.String = importtype_example // kotlin.String | The kind of data that is being uploaded.
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The local name of the uploaded file. For later reference.
val parameters : kotlin.String = parameters_example // kotlin.String | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.
try {
    apiInstance.import(importtype, upload, filename, parameters)
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#import")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#import")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **importtype** | **kotlin.String**| The kind of data that is being uploaded. |
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The local name of the uploaded file. For later reference. | [optional]
 **parameters** | **kotlin.String**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="listtimezones"></a>
# **listtimezones**
> listtimezones()

Lists the available timezones

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
try {
    apiInstance.listtimezones()
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#listtimezones")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#listtimezones")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="login"></a>
# **login**
> login(domain, username, password, method, rememberme)

Login

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
val domain : kotlin.String = domain_example // kotlin.String | The account domain to login.
val username : kotlin.String = username_example // kotlin.String | The username (email) of the user to login as.
val password : kotlin.String = password_example // kotlin.String | The password of the user to login as.
val method : kotlin.String = method_example // kotlin.String | The authentication method. Valid values are 'token' and 'cookie'.
val rememberme : kotlin.Boolean = true // kotlin.Boolean | If true then the session will not expire.
try {
    apiInstance.login(domain, username, password, method, rememberme)
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#login")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#login")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **kotlin.String**| The account domain to login. |
 **username** | **kotlin.String**| The username (email) of the user to login as. |
 **password** | **kotlin.String**| The password of the user to login as. |
 **method** | **kotlin.String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. |
 **rememberme** | **kotlin.Boolean**| If true then the session will not expire. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="logout"></a>
# **logout**
> logout()

Logout

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
try {
    apiInstance.logout()
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#logout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#logout")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="search"></a>
# **search**
> search(query, page)

Search

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
val query : kotlin.String = query_example // kotlin.String | The query to search for.
val page : kotlin.Int = 56 // kotlin.Int | Current page to show, zero-based.
try {
    apiInstance.search(query, page)
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#search")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#search")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **kotlin.String**| The query to search for. |
 **page** | **kotlin.Int**| Current page to show, zero-based. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="texttoimage"></a>
# **texttoimage**
> texttoimage(text, fontcolor, fontsize, direction, width)

Generates a dynamic image from text

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
val text : kotlin.String = text_example // kotlin.String | The text to convert to an image, use double pipes (||) as a new line.
val fontcolor : kotlin.String = fontcolor_example // kotlin.String | The color of the text, in hex format, without the #.
val fontsize : kotlin.Int = 56 // kotlin.Int | The size of the text, in points.
val direction : kotlin.String = direction_example // kotlin.String | Either vertical or horizontal, default horizontal.
val width : kotlin.Int = 56 // kotlin.Int | The image width in pixels (or height if the direction is vertical).
try {
    apiInstance.texttoimage(text, fontcolor, fontsize, direction, width)
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#texttoimage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#texttoimage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **kotlin.String**| The text to convert to an image, use double pipes (||) as a new line. |
 **fontcolor** | **kotlin.String**| The color of the text, in hex format, without the #. | [optional]
 **fontsize** | **kotlin.Int**| The size of the text, in points. | [optional]
 **direction** | **kotlin.String**| Either vertical or horizontal, default horizontal. | [optional]
 **width** | **kotlin.Int**| The image width in pixels (or height if the direction is vertical). | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="version"></a>
# **version**
> version()

Get current version information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = GeneralApi()
try {
    apiInstance.version()
} catch (e: ClientException) {
    println("4xx response calling GeneralApi#version")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling GeneralApi#version")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

