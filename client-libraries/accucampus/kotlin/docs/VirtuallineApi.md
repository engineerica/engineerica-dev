# VirtuallineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**virtuallineAddmyself**](VirtuallineApi.md#virtuallineAddmyself) | **GET** /virtualline/addmyself | Add myself to a waiting line
[**virtuallineList**](VirtuallineApi.md#virtuallineList) | **GET** /virtualline/list | Lists waiting lines that have remote access enabled
[**virtuallineRemovemyself**](VirtuallineApi.md#virtuallineRemovemyself) | **GET** /virtualline/removemyself | Remove myself from a waiting line


<a name="virtuallineAddmyself"></a>
# **virtuallineAddmyself**
> virtuallineAddmyself(waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = VirtuallineApi()
val waitinglineid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the waiting line to join.
try {
    apiInstance.virtuallineAddmyself(waitinglineid)
} catch (e: ClientException) {
    println("4xx response calling VirtuallineApi#virtuallineAddmyself")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling VirtuallineApi#virtuallineAddmyself")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitinglineid** | [**java.util.UUID**](.md)| ID of the waiting line to join. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="virtuallineList"></a>
# **virtuallineList**
> virtuallineList()

Lists waiting lines that have remote access enabled

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = VirtuallineApi()
try {
    apiInstance.virtuallineList()
} catch (e: ClientException) {
    println("4xx response calling VirtuallineApi#virtuallineList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling VirtuallineApi#virtuallineList")
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

<a name="virtuallineRemovemyself"></a>
# **virtuallineRemovemyself**
> virtuallineRemovemyself()

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = VirtuallineApi()
try {
    apiInstance.virtuallineRemovemyself()
} catch (e: ClientException) {
    println("4xx response calling VirtuallineApi#virtuallineRemovemyself")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling VirtuallineApi#virtuallineRemovemyself")
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

