# DeadendrecordingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deadendrecordingDelete**](DeadendrecordingApi.md#deadendrecordingDelete) | **DELETE** /deadendrecording/delete | Deletes a dead-end record group
[**deadendrecordingList**](DeadendrecordingApi.md#deadendrecordingList) | **GET** /deadendrecording/list | Lists the recorded dead ends, if enabled
[**deadendrecordingListcomments**](DeadendrecordingApi.md#deadendrecordingListcomments) | **GET** /deadendrecording/listcomments | Lists the comments for a specific dead end
[**deadendrecordingSave**](DeadendrecordingApi.md#deadendrecordingSave) | **POST** /deadendrecording/save | Saves a dead-end record


<a name="deadendrecordingDelete"></a>
# **deadendrecordingDelete**
> deadendrecordingDelete(UNKNOWN_BASE_TYPE)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DeadendrecordingApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.deadendrecordingDelete(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DeadendrecordingApi#deadendrecordingDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeadendrecordingApi#deadendrecordingDelete")
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

<a name="deadendrecordingList"></a>
# **deadendrecordingList**
> deadendrecordingList()

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DeadendrecordingApi()
try {
    apiInstance.deadendrecordingList()
} catch (e: ClientException) {
    println("4xx response calling DeadendrecordingApi#deadendrecordingList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeadendrecordingApi#deadendrecordingList")
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

<a name="deadendrecordingListcomments"></a>
# **deadendrecordingListcomments**
> deadendrecordingListcomments(hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DeadendrecordingApi()
val hierarchykey : kotlin.String = hierarchykey_example // kotlin.String | The hierarchy key of the record to get the feedback.
try {
    apiInstance.deadendrecordingListcomments(hierarchykey)
} catch (e: ClientException) {
    println("4xx response calling DeadendrecordingApi#deadendrecordingListcomments")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeadendrecordingApi#deadendrecordingListcomments")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hierarchykey** | **kotlin.String**| The hierarchy key of the record to get the feedback. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deadendrecordingSave"></a>
# **deadendrecordingSave**
> deadendrecordingSave(UNKNOWN_BASE_TYPE)

Saves a dead-end record

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DeadendrecordingApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.deadendrecordingSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DeadendrecordingApi#deadendrecordingSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeadendrecordingApi#deadendrecordingSave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

