# NotificationtopicApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notificationtopicDelete**](NotificationtopicApi.md#notificationtopicDelete) | **DELETE** /notificationtopic/{id} | Delete a notification topic
[**notificationtopicGet**](NotificationtopicApi.md#notificationtopicGet) | **GET** /notificationtopic/{id} | Search and view details of a notification topic
[**notificationtopicList**](NotificationtopicApi.md#notificationtopicList) | **GET** /notificationtopic/list | List all the notification topics
[**notificationtopicListsubscribe**](NotificationtopicApi.md#notificationtopicListsubscribe) | **GET** /notificationtopic/listsubscribe | List all the notification topics available to subscribe
[**notificationtopicSave**](NotificationtopicApi.md#notificationtopicSave) | **POST** /notificationtopic/{id} | Create or edit a notification topic


<a name="notificationtopicDelete"></a>
# **notificationtopicDelete**
> notificationtopicDelete(id, body)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationtopicApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification topic to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.notificationtopicDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling NotificationtopicApi#notificationtopicDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationtopicApi#notificationtopicDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the notification topic to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="notificationtopicGet"></a>
# **notificationtopicGet**
> notificationtopicGet(id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationtopicApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification topic to get.
try {
    apiInstance.notificationtopicGet(id)
} catch (e: ClientException) {
    println("4xx response calling NotificationtopicApi#notificationtopicGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationtopicApi#notificationtopicGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the notification topic to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationtopicList"></a>
# **notificationtopicList**
> notificationtopicList(from, count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationtopicApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.notificationtopicList(from, count)
} catch (e: ClientException) {
    println("4xx response calling NotificationtopicApi#notificationtopicList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationtopicApi#notificationtopicList")
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

<a name="notificationtopicListsubscribe"></a>
# **notificationtopicListsubscribe**
> notificationtopicListsubscribe()

List all the notification topics available to subscribe

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationtopicApi()
try {
    apiInstance.notificationtopicListsubscribe()
} catch (e: ClientException) {
    println("4xx response calling NotificationtopicApi#notificationtopicListsubscribe")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationtopicApi#notificationtopicListsubscribe")
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

<a name="notificationtopicSave"></a>
# **notificationtopicSave**
> notificationtopicSave(id, UNKNOWN_BASE_TYPE)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationtopicApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the topic to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.notificationtopicSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling NotificationtopicApi#notificationtopicSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationtopicApi#notificationtopicSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the topic to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

