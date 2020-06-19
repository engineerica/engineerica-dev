# UsertaskApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usertaskDeleteplan**](UsertaskApi.md#usertaskDeleteplan) | **DELETE** /usertask/deleteplan | Deletes a task plan
[**usertaskGetmine**](UsertaskApi.md#usertaskGetmine) | **GET** /usertask/getmine | Lists the task plans of the logged user
[**usertaskGetplan**](UsertaskApi.md#usertaskGetplan) | **GET** /usertask/getplan | Gets a task plan by Id
[**usertaskListdefs**](UsertaskApi.md#usertaskListdefs) | **GET** /usertask/listdefs | Lists task types or definitions
[**usertaskListplan**](UsertaskApi.md#usertaskListplan) | **GET** /usertask/listplan | Lists task plans
[**usertaskSaveplan**](UsertaskApi.md#usertaskSaveplan) | **POST** /usertask/saveplan | Saves a task plan


<a name="usertaskDeleteplan"></a>
# **usertaskDeleteplan**
> usertaskDeleteplan(UNKNOWN_BASE_TYPE)

Deletes a task plan

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsertaskApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usertaskDeleteplan(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UsertaskApi#usertaskDeleteplan")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsertaskApi#usertaskDeleteplan")
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

<a name="usertaskGetmine"></a>
# **usertaskGetmine**
> usertaskGetmine()

Lists the task plans of the logged user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsertaskApi()
try {
    apiInstance.usertaskGetmine()
} catch (e: ClientException) {
    println("4xx response calling UsertaskApi#usertaskGetmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsertaskApi#usertaskGetmine")
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

<a name="usertaskGetplan"></a>
# **usertaskGetplan**
> usertaskGetplan(id)

Gets a task plan by Id

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsertaskApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the task plan to get.
try {
    apiInstance.usertaskGetplan(id)
} catch (e: ClientException) {
    println("4xx response calling UsertaskApi#usertaskGetplan")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsertaskApi#usertaskGetplan")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the task plan to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usertaskListdefs"></a>
# **usertaskListdefs**
> usertaskListdefs()

Lists task types or definitions

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsertaskApi()
try {
    apiInstance.usertaskListdefs()
} catch (e: ClientException) {
    println("4xx response calling UsertaskApi#usertaskListdefs")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsertaskApi#usertaskListdefs")
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

<a name="usertaskListplan"></a>
# **usertaskListplan**
> usertaskListplan(from, count)

Lists task plans

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsertaskApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.usertaskListplan(from, count)
} catch (e: ClientException) {
    println("4xx response calling UsertaskApi#usertaskListplan")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsertaskApi#usertaskListplan")
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

<a name="usertaskSaveplan"></a>
# **usertaskSaveplan**
> usertaskSaveplan(UNKNOWN_BASE_TYPE)

Saves a task plan

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsertaskApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usertaskSaveplan(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UsertaskApi#usertaskSaveplan")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsertaskApi#usertaskSaveplan")
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

