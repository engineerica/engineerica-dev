# ServiceApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**serviceDelete**](ServiceApi.md#serviceDelete) | **DELETE** /service/{id} | Delete a service
[**serviceGet**](ServiceApi.md#serviceGet) | **GET** /service/{id} | Search and view details of a service
[**serviceList**](ServiceApi.md#serviceList) | **GET** /service/list | View a list of services
[**serviceSave**](ServiceApi.md#serviceSave) | **POST** /service/{id} | Create or edit a service


<a name="serviceDelete"></a>
# **serviceDelete**
> serviceDelete(id, body)

Delete a service

Allows the user to delete a service from the existing list.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ServiceApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.serviceDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling ServiceApi#serviceDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServiceApi#serviceDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the service to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="serviceGet"></a>
# **serviceGet**
> serviceGet(id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ServiceApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to get.
try {
    apiInstance.serviceGet(id)
} catch (e: ClientException) {
    println("4xx response calling ServiceApi#serviceGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServiceApi#serviceGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the service to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="serviceList"></a>
# **serviceList**
> serviceList(from, count)

View a list of services

Allows the user to view the full list of existing services.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ServiceApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.serviceList(from, count)
} catch (e: ClientException) {
    println("4xx response calling ServiceApi#serviceList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServiceApi#serviceList")
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

<a name="serviceSave"></a>
# **serviceSave**
> serviceSave(id, UNKNOWN_BASE_TYPE)

Create or edit a service

Allows the user to create or edit a service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ServiceApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.serviceSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ServiceApi#serviceSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServiceApi#serviceSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the service save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

