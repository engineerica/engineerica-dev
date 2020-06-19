# ActionitemApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionitemDelete**](ActionitemApi.md#actionitemDelete) | **DELETE** /actionitem/{id} | Delete an action item
[**actionitemGet**](ActionitemApi.md#actionitemGet) | **GET** /actionitem/{id} | Search and view details of an action item
[**actionitemList**](ActionitemApi.md#actionitemList) | **GET** /actionitem/list | View a list of action items
[**actionitemSave**](ActionitemApi.md#actionitemSave) | **POST** /actionitem/{id} | Create or edit an action item


<a name="actionitemDelete"></a>
# **actionitemDelete**
> actionitemDelete(id, body)

Delete an action item

Allows the user to delete an action item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionitemApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action item to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.actionitemDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling ActionitemApi#actionitemDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionitemApi#actionitemDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action item to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="actionitemGet"></a>
# **actionitemGet**
> actionitemGet(id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionitemApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action item to get.
try {
    apiInstance.actionitemGet(id)
} catch (e: ClientException) {
    println("4xx response calling ActionitemApi#actionitemGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionitemApi#actionitemGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action item to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionitemList"></a>
# **actionitemList**
> actionitemList(from, count)

View a list of action items

Allows the user to view a list of action items

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionitemApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.actionitemList(from, count)
} catch (e: ClientException) {
    println("4xx response calling ActionitemApi#actionitemList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionitemApi#actionitemList")
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

<a name="actionitemSave"></a>
# **actionitemSave**
> actionitemSave(id, UNKNOWN_BASE_TYPE)

Create or edit an action item

Allows the user to edit an action item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionitemApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action item to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actionitemSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ActionitemApi#actionitemSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionitemApi#actionitemSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action item to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

