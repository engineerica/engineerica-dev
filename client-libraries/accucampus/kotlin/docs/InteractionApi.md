# InteractionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**interactionDelete**](InteractionApi.md#interactionDelete) | **DELETE** /interaction/{id} | Delete an interaction
[**interactionFeed**](InteractionApi.md#interactionFeed) | **GET** /interaction/feed | Get the interactions feed
[**interactionGet**](InteractionApi.md#interactionGet) | **GET** /interaction/{id} | View an interaction
[**interactionListprivatesummary**](InteractionApi.md#interactionListprivatesummary) | **GET** /interaction/listprivatesummary | Get current user&#39;s latest private interactions
[**interactionSave**](InteractionApi.md#interactionSave) | **POST** /interaction/{id} | Save an interaction


<a name="interactionDelete"></a>
# **interactionDelete**
> interactionDelete(id, body)

Delete an interaction

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = InteractionApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the interaction to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.interactionDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling InteractionApi#interactionDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling InteractionApi#interactionDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the interaction to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="interactionFeed"></a>
# **interactionFeed**
> interactionFeed(from, count, startdate, public, contexttype, contextid, types, photosize, showdefaultphoto, orderdescending)

Get the interactions feed

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = InteractionApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If set, only interactions that happened after this date are returned.
val public : kotlin.Boolean = true // kotlin.Boolean | Specifies whether to return public or private interactions.
val contexttype : kotlin.String = contexttype_example // kotlin.String | The type of the context of the interactions to return.
val contextid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the context of the interactions to return.
val types : kotlin.String = types_example // kotlin.String | The  comma separated types of the interactions to return.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
val showdefaultphoto : kotlin.Boolean = true // kotlin.Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
val orderdescending : kotlin.Boolean = true // kotlin.Boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.
try {
    apiInstance.interactionFeed(from, count, startdate, public, contexttype, contextid, types, photosize, showdefaultphoto, orderdescending)
} catch (e: ClientException) {
    println("4xx response calling InteractionApi#interactionFeed")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling InteractionApi#interactionFeed")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **startdate** | **java.time.OffsetDateTime**| If set, only interactions that happened after this date are returned. | [optional]
 **public** | **kotlin.Boolean**| Specifies whether to return public or private interactions. | [optional]
 **contexttype** | **kotlin.String**| The type of the context of the interactions to return. | [optional]
 **contextid** | [**java.util.UUID**](.md)| The id of the context of the interactions to return. | [optional]
 **types** | **kotlin.String**| The  comma separated types of the interactions to return. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **kotlin.Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]
 **orderdescending** | **kotlin.Boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="interactionGet"></a>
# **interactionGet**
> interactionGet(id, thumbnailmediasize, photosize)

View an interaction

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = InteractionApi()
val id : kotlin.String = id_example // kotlin.String | The id of the interaction.
val thumbnailmediasize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.interactionGet(id, thumbnailmediasize, photosize)
} catch (e: ClientException) {
    println("4xx response calling InteractionApi#interactionGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling InteractionApi#interactionGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.String**| The id of the interaction. |
 **thumbnailmediasize** | **kotlin.Int**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="interactionListprivatesummary"></a>
# **interactionListprivatesummary**
> interactionListprivatesummary(photosize, showdefaultphoto)

Get current user&#39;s latest private interactions

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = InteractionApi()
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
val showdefaultphoto : kotlin.Boolean = true // kotlin.Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
try {
    apiInstance.interactionListprivatesummary(photosize, showdefaultphoto)
} catch (e: ClientException) {
    println("4xx response calling InteractionApi#interactionListprivatesummary")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling InteractionApi#interactionListprivatesummary")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **kotlin.Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="interactionSave"></a>
# **interactionSave**
> interactionSave(id, UNKNOWN_BASE_TYPE)

Save an interaction

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = InteractionApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the interaction to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.interactionSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling InteractionApi#interactionSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling InteractionApi#interactionSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the interaction to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

