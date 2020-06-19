# TranslationApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**translationGet**](TranslationApi.md#translationGet) | **GET** /translation/get | Gets the translations of the specified values
[**translationGetcachefile**](TranslationApi.md#translationGetcachefile) | **GET** /translation/getcachefile | Get the file containing the translations
[**translationList**](TranslationApi.md#translationList) | **GET** /translation/list | Lists all the available translations in the system
[**translationSave**](TranslationApi.md#translationSave) | **POST** /translation/{id} | Edit a translation


<a name="translationGet"></a>
# **translationGet**
> translationGet(universal)

Gets the translations of the specified values

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TranslationApi()
val universal : kotlin.String = universal_example // kotlin.String | Pipe separated list of universal text to be translated.
try {
    apiInstance.translationGet(universal)
} catch (e: ClientException) {
    println("4xx response calling TranslationApi#translationGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TranslationApi#translationGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **universal** | **kotlin.String**| Pipe separated list of universal text to be translated. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="translationGetcachefile"></a>
# **translationGetcachefile**
> translationGetcachefile(account)

Get the file containing the translations

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TranslationApi()
val account : kotlin.String = account_example // kotlin.String | The id of the account whose translations file has to be retrieved.
try {
    apiInstance.translationGetcachefile(account)
} catch (e: ClientException) {
    println("4xx response calling TranslationApi#translationGetcachefile")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TranslationApi#translationGetcachefile")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **kotlin.String**| The id of the account whose translations file has to be retrieved. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="translationList"></a>
# **translationList**
> translationList(filter, nondefaultonly, appdefaultasuniversal)

Lists all the available translations in the system

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TranslationApi()
val filter : kotlin.String = filter_example // kotlin.String | Text to search/filter translations.
val nondefaultonly : kotlin.Boolean = true // kotlin.Boolean | If true then it returns only the terms translated. Otherwise, it returns all.
val appdefaultasuniversal : kotlin.Boolean = true // kotlin.Boolean | If true then it uses the app default translation as the universal term.
try {
    apiInstance.translationList(filter, nondefaultonly, appdefaultasuniversal)
} catch (e: ClientException) {
    println("4xx response calling TranslationApi#translationList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TranslationApi#translationList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **kotlin.String**| Text to search/filter translations. | [optional]
 **nondefaultonly** | **kotlin.Boolean**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional]
 **appdefaultasuniversal** | **kotlin.Boolean**| If true then it uses the app default translation as the universal term. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="translationSave"></a>
# **translationSave**
> translationSave(id, UNKNOWN_BASE_TYPE)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TranslationApi()
val id : kotlin.String = id_example // kotlin.String | The id of the translation as returned by translation.list.
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.translationSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling TranslationApi#translationSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TranslationApi#translationSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.String**| The id of the translation as returned by translation.list. |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

