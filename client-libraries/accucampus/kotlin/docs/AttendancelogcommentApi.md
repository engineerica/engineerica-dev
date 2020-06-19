# AttendancelogcommentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogcommentDelete**](AttendancelogcommentApi.md#attendancelogcommentDelete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
[**attendancelogcommentGet**](AttendancelogcommentApi.md#attendancelogcommentGet) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
[**attendancelogcommentList**](AttendancelogcommentApi.md#attendancelogcommentList) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
[**attendancelogcommentSave**](AttendancelogcommentApi.md#attendancelogcommentSave) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log


<a name="attendancelogcommentDelete"></a>
# **attendancelogcommentDelete**
> attendancelogcommentDelete(id, body)

Delete a comment on an attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogcommentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log comment to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.attendancelogcommentDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogcommentApi#attendancelogcommentDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogcommentApi#attendancelogcommentDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the attendance log comment to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="attendancelogcommentGet"></a>
# **attendancelogcommentGet**
> attendancelogcommentGet(id)

View a comment on an attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogcommentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the comment to get.
try {
    apiInstance.attendancelogcommentGet(id)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogcommentApi#attendancelogcommentGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogcommentApi#attendancelogcommentGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the comment to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogcommentList"></a>
# **attendancelogcommentList**
> attendancelogcommentList(attendancelog)

View all the comments on a specific attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogcommentApi()
val attendancelog : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log whose comments have to be retrieved.
try {
    apiInstance.attendancelogcommentList(attendancelog)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogcommentApi#attendancelogcommentList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogcommentApi#attendancelogcommentList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**java.util.UUID**](.md)| The id of the attendance log whose comments have to be retrieved. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogcommentSave"></a>
# **attendancelogcommentSave**
> attendancelogcommentSave(id, UNKNOWN_BASE_TYPE)

Save a comment on an attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogcommentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the comment to edit (leave empty to create a new one)
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.attendancelogcommentSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogcommentApi#attendancelogcommentSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogcommentApi#attendancelogcommentSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the comment to edit (leave empty to create a new one) |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

