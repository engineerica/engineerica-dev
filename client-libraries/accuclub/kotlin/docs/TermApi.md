# TermApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**termDelete**](TermApi.md#termDelete) | **DELETE** /term/{id} | Delete a term
[**termGet**](TermApi.md#termGet) | **GET** /term/{id} | Search and view details of a term
[**termList**](TermApi.md#termList) | **GET** /term/list | Search and view details of all terms
[**termSave**](TermApi.md#termSave) | **POST** /term/{id} | Create and edit terms


<a name="termDelete"></a>
# **termDelete**
> termDelete(id, body)

Delete a term

Allows the user to delete a term from the existing list.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TermApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the term to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.termDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling TermApi#termDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TermApi#termDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the term to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="termGet"></a>
# **termGet**
> termGet(id)

Search and view details of a term

Allows the user to view a term and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TermApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the term to get.
try {
    apiInstance.termGet(id)
} catch (e: ClientException) {
    println("4xx response calling TermApi#termGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TermApi#termGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the term to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="termList"></a>
# **termList**
> termList(from, count, notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TermApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val notpast : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the terms in the past should be returned or not.
try {
    apiInstance.termList(from, count, notpast)
} catch (e: ClientException) {
    println("4xx response calling TermApi#termList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TermApi#termList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. | [optional]
 **count** | **kotlin.Int**| The max number of records to return. | [optional]
 **notpast** | **kotlin.Boolean**| Specifies whether the terms in the past should be returned or not. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="termSave"></a>
# **termSave**
> termSave(id, UNKNOWN_BASE_TYPE)

Create and edit terms

Allows the user to create and edit terms.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TermApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the term to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.termSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling TermApi#termSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TermApi#termSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the term to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

