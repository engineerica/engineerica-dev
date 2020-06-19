# LikeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**likeDelete**](LikeApi.md#likeDelete) | **DELETE** /like/delete | Delete a like
[**likeList**](LikeApi.md#likeList) | **GET** /like/list | View all the likes associated to a target
[**likeSave**](LikeApi.md#likeSave) | **POST** /like/save | Save a like


<a name="likeDelete"></a>
# **likeDelete**
> likeDelete(UNKNOWN_BASE_TYPE)

Delete a like

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LikeApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.likeDelete(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling LikeApi#likeDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LikeApi#likeDelete")
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

<a name="likeList"></a>
# **likeList**
> likeList(interactionid, photosize)

View all the likes associated to a target

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LikeApi()
val interactionid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the interaction to unlike.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.likeList(interactionid, photosize)
} catch (e: ClientException) {
    println("4xx response calling LikeApi#likeList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LikeApi#likeList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionid** | [**java.util.UUID**](.md)| The id of the interaction to unlike. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="likeSave"></a>
# **likeSave**
> likeSave(UNKNOWN_BASE_TYPE)

Save a like

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LikeApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.likeSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling LikeApi#likeSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LikeApi#likeSave")
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

