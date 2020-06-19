# MemorizedreportApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**memorizedreportDelete**](MemorizedreportApi.md#memorizedreportDelete) | **DELETE** /memorizedreport/{id} | Delete memorized report
[**memorizedreportGet**](MemorizedreportApi.md#memorizedreportGet) | **GET** /memorizedreport/{id} | View details of a memorized report
[**memorizedreportList**](MemorizedreportApi.md#memorizedreportList) | **GET** /memorizedreport/list | View a list of all his memorized reports
[**memorizedreportSave**](MemorizedreportApi.md#memorizedreportSave) | **POST** /memorizedreport/{id} | Create or edit a memorized report


<a name="memorizedreportDelete"></a>
# **memorizedreportDelete**
> memorizedreportDelete(id, body)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MemorizedreportApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the report settings to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.memorizedreportDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling MemorizedreportApi#memorizedreportDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MemorizedreportApi#memorizedreportDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the report settings to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="memorizedreportGet"></a>
# **memorizedreportGet**
> memorizedreportGet(id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MemorizedreportApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the report configuration to get.
try {
    apiInstance.memorizedreportGet(id)
} catch (e: ClientException) {
    println("4xx response calling MemorizedreportApi#memorizedreportGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MemorizedreportApi#memorizedreportGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the report configuration to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="memorizedreportList"></a>
# **memorizedreportList**
> memorizedreportList(from, count, customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MemorizedreportApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val customname : kotlin.String = customname_example // kotlin.String | If specified filters the memorized reports by custom name.
try {
    apiInstance.memorizedreportList(from, count, customname)
} catch (e: ClientException) {
    println("4xx response calling MemorizedreportApi#memorizedreportList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MemorizedreportApi#memorizedreportList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **customname** | **kotlin.String**| If specified filters the memorized reports by custom name. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="memorizedreportSave"></a>
# **memorizedreportSave**
> memorizedreportSave(id, UNKNOWN_BASE_TYPE)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MemorizedreportApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the report settings to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.memorizedreportSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling MemorizedreportApi#memorizedreportSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MemorizedreportApi#memorizedreportSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the report settings to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

