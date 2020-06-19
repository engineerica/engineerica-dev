# CreditplanApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**creditplanDelete**](CreditplanApi.md#creditplanDelete) | **DELETE** /creditplan/{id} | Deletes a credit plan
[**creditplanGet**](CreditplanApi.md#creditplanGet) | **GET** /creditplan/{id} | Gets a credit plan
[**creditplanList**](CreditplanApi.md#creditplanList) | **GET** /creditplan/list | Gets the credit plans available
[**creditplanSave**](CreditplanApi.md#creditplanSave) | **POST** /creditplan/{id} | Saves a credit plan


<a name="creditplanDelete"></a>
# **creditplanDelete**
> creditplanDelete(id, body)

Deletes a credit plan

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditplanApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the credit plan to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.creditplanDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling CreditplanApi#creditplanDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditplanApi#creditplanDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the credit plan to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="creditplanGet"></a>
# **creditplanGet**
> creditplanGet(id)

Gets a credit plan

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditplanApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the credit plan to get.
try {
    apiInstance.creditplanGet(id)
} catch (e: ClientException) {
    println("4xx response calling CreditplanApi#creditplanGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditplanApi#creditplanGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the credit plan to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="creditplanList"></a>
# **creditplanList**
> creditplanList(from, count)

Gets the credit plans available

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditplanApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.creditplanList(from, count)
} catch (e: ClientException) {
    println("4xx response calling CreditplanApi#creditplanList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditplanApi#creditplanList")
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

<a name="creditplanSave"></a>
# **creditplanSave**
> creditplanSave(id, UNKNOWN_BASE_TYPE)

Saves a credit plan

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditplanApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the credit save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.creditplanSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling CreditplanApi#creditplanSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditplanApi#creditplanSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the credit save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

