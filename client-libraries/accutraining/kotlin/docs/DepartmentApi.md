# DepartmentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**departmentDelete**](DepartmentApi.md#departmentDelete) | **DELETE** /department/{id} | Delete a college department
[**departmentGet**](DepartmentApi.md#departmentGet) | **GET** /department/{id} | Search and view details of a college department
[**departmentList**](DepartmentApi.md#departmentList) | **GET** /department/list | View a list of college departments
[**departmentSave**](DepartmentApi.md#departmentSave) | **POST** /department/{id} | Create or edit a college department


<a name="departmentDelete"></a>
# **departmentDelete**
> departmentDelete(id, body)

Delete a college department

Allows the user to delete an existing college department.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DepartmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the department to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.departmentDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling DepartmentApi#departmentDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepartmentApi#departmentDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the department to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="departmentGet"></a>
# **departmentGet**
> departmentGet(id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DepartmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the department to get.
try {
    apiInstance.departmentGet(id)
} catch (e: ClientException) {
    println("4xx response calling DepartmentApi#departmentGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepartmentApi#departmentGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the department to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="departmentList"></a>
# **departmentList**
> departmentList(from, count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DepartmentApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.departmentList(from, count)
} catch (e: ClientException) {
    println("4xx response calling DepartmentApi#departmentList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepartmentApi#departmentList")
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

<a name="departmentSave"></a>
# **departmentSave**
> departmentSave(id, UNKNOWN_BASE_TYPE)

Create or edit a college department

Allows the user to create or edit a college department.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DepartmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the department save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.departmentSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DepartmentApi#departmentSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DepartmentApi#departmentSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the department save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

