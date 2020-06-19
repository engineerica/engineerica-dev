# AttendancerestrictionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancerestrictionDelete**](AttendancerestrictionApi.md#attendancerestrictionDelete) | **DELETE** /attendancerestriction/{id} | Delete an attendance restriction
[**attendancerestrictionGet**](AttendancerestrictionApi.md#attendancerestrictionGet) | **GET** /attendancerestriction/{id} | View details of an attendance restriction
[**attendancerestrictionList**](AttendancerestrictionApi.md#attendancerestrictionList) | **GET** /attendancerestriction/list | View a list of attendance restrictions
[**attendancerestrictionSave**](AttendancerestrictionApi.md#attendancerestrictionSave) | **POST** /attendancerestriction/{id} | Create or edit an attendance restriction


<a name="attendancerestrictionDelete"></a>
# **attendancerestrictionDelete**
> attendancerestrictionDelete(id, body)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancerestrictionApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the restriction to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.attendancerestrictionDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling AttendancerestrictionApi#attendancerestrictionDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancerestrictionApi#attendancerestrictionDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the restriction to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="attendancerestrictionGet"></a>
# **attendancerestrictionGet**
> attendancerestrictionGet(id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancerestrictionApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the restriction to get.
try {
    apiInstance.attendancerestrictionGet(id)
} catch (e: ClientException) {
    println("4xx response calling AttendancerestrictionApi#attendancerestrictionGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancerestrictionApi#attendancerestrictionGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the restriction to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancerestrictionList"></a>
# **attendancerestrictionList**
> attendancerestrictionList(from, count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancerestrictionApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.attendancerestrictionList(from, count)
} catch (e: ClientException) {
    println("4xx response calling AttendancerestrictionApi#attendancerestrictionList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancerestrictionApi#attendancerestrictionList")
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

<a name="attendancerestrictionSave"></a>
# **attendancerestrictionSave**
> attendancerestrictionSave(id, UNKNOWN_BASE_TYPE)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancerestrictionApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the restriction save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.attendancerestrictionSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling AttendancerestrictionApi#attendancerestrictionSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancerestrictionApi#attendancerestrictionSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the restriction save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

