# SwipeApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**swipeDelete**](SwipeApi.md#swipeDelete) | **DELETE** /swipe/{id} | Delete a swipe
[**swipeGet**](SwipeApi.md#swipeGet) | **GET** /swipe/{id} | Search and view details of a swipe
[**swipeList**](SwipeApi.md#swipeList) | **GET** /swipe/list | View a list of swipes
[**swipeSave**](SwipeApi.md#swipeSave) | **POST** /swipe/save | Create or edit a swipe, and if possible, save the related attendance log
[**swipeSaveanonym**](SwipeApi.md#swipeSaveanonym) | **POST** /swipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log


<a name="swipeDelete"></a>
# **swipeDelete**
> swipeDelete(id, body)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SwipeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the swipe to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.swipeDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling SwipeApi#swipeDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SwipeApi#swipeDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the swipe to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="swipeGet"></a>
# **swipeGet**
> swipeGet(id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SwipeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the swipe to get.
try {
    apiInstance.swipeGet(id)
} catch (e: ClientException) {
    println("4xx response calling SwipeApi#swipeGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SwipeApi#swipeGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the swipe to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="swipeList"></a>
# **swipeList**
> swipeList(from, count)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SwipeApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.swipeList(from, count)
} catch (e: ClientException) {
    println("4xx response calling SwipeApi#swipeList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SwipeApi#swipeList")
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

<a name="swipeSave"></a>
# **swipeSave**
> swipeSave(UNKNOWN_BASE_TYPE)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SwipeApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.swipeSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SwipeApi#swipeSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SwipeApi#swipeSave")
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

<a name="swipeSaveanonym"></a>
# **swipeSaveanonym**
> swipeSaveanonym(UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SwipeApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.swipeSaveanonym(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SwipeApi#swipeSaveanonym")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SwipeApi#swipeSaveanonym")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

