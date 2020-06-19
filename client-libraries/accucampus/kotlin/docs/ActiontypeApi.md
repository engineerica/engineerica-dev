# ActiontypeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actiontypeDelete**](ActiontypeApi.md#actiontypeDelete) | **DELETE** /actiontype/{id} | Delete an action item type
[**actiontypeGet**](ActiontypeApi.md#actiontypeGet) | **GET** /actiontype/{id} | View details of an action item type
[**actiontypeList**](ActiontypeApi.md#actiontypeList) | **GET** /actiontype/list | View a list of action item types
[**actiontypeSave**](ActiontypeApi.md#actiontypeSave) | **POST** /actiontype/{id} | Create or edit an action item type


<a name="actiontypeDelete"></a>
# **actiontypeDelete**
> actiontypeDelete(id, body)

Delete an action item type

Allows the user to delete an action item type.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActiontypeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action type to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.actiontypeDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling ActiontypeApi#actiontypeDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActiontypeApi#actiontypeDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action type to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="actiontypeGet"></a>
# **actiontypeGet**
> actiontypeGet(id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActiontypeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action type to get.
try {
    apiInstance.actiontypeGet(id)
} catch (e: ClientException) {
    println("4xx response calling ActiontypeApi#actiontypeGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActiontypeApi#actiontypeGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action type to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actiontypeList"></a>
# **actiontypeList**
> actiontypeList(from, count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActiontypeApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.actiontypeList(from, count)
} catch (e: ClientException) {
    println("4xx response calling ActiontypeApi#actiontypeList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActiontypeApi#actiontypeList")
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

<a name="actiontypeSave"></a>
# **actiontypeSave**
> actiontypeSave(id, UNKNOWN_BASE_TYPE)

Create or edit an action item type

Allows the user to dit an action item type.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActiontypeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action type to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actiontypeSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ActiontypeApi#actiontypeSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActiontypeApi#actiontypeSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action type to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

