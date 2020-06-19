# MediatypeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mediatypeDelete**](MediatypeApi.md#mediatypeDelete) | **DELETE** /mediatype/{id} | Delete a media type
[**mediatypeGet**](MediatypeApi.md#mediatypeGet) | **GET** /mediatype/{id} | Search and view details of a media type
[**mediatypeList**](MediatypeApi.md#mediatypeList) | **GET** /mediatype/list | View a list of media types
[**mediatypeSave**](MediatypeApi.md#mediatypeSave) | **POST** /mediatype/{id} | Create or edit a media type


<a name="mediatypeDelete"></a>
# **mediatypeDelete**
> mediatypeDelete(id, body)

Delete a media type

Allows the user to delete an existing media type.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediatypeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media type to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.mediatypeDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling MediatypeApi#mediatypeDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediatypeApi#mediatypeDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the media type to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="mediatypeGet"></a>
# **mediatypeGet**
> mediatypeGet(id)

Search and view details of a media type

Allows the user to view a media type and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediatypeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media type to get.
try {
    apiInstance.mediatypeGet(id)
} catch (e: ClientException) {
    println("4xx response calling MediatypeApi#mediatypeGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediatypeApi#mediatypeGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the media type to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediatypeList"></a>
# **mediatypeList**
> mediatypeList(from, count)

View a list of media types

Allows the user to view the list of all media types.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediatypeApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.mediatypeList(from, count)
} catch (e: ClientException) {
    println("4xx response calling MediatypeApi#mediatypeList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediatypeApi#mediatypeList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediatypeSave"></a>
# **mediatypeSave**
> mediatypeSave(id, UNKNOWN_BASE_TYPE)

Create or edit a media type

Allows the user to create or edit a media type.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediatypeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the mediaType save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.mediatypeSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling MediatypeApi#mediatypeSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediatypeApi#mediatypeSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the mediaType save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

