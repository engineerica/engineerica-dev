# RoleApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**roleList**](RoleApi.md#roleList) | **GET** /role/list | Show a list of roles


<a name="roleList"></a>
# **roleList**
> roleList(name)

Show a list of roles

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RoleApi()
val name : kotlin.String = name_example // kotlin.String | Filter by name of the role.
try {
    apiInstance.roleList(name)
} catch (e: ClientException) {
    println("4xx response calling RoleApi#roleList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RoleApi#roleList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **kotlin.String**| Filter by name of the role. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

