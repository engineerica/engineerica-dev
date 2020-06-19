# SearchApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**searchGetentities**](SearchApi.md#searchGetentities) | **GET** /search/getentities | Get the information of the entities that can be searched


<a name="searchGetentities"></a>
# **searchGetentities**
> searchGetentities()

Get the information of the entities that can be searched

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SearchApi()
try {
    apiInstance.searchGetentities()
} catch (e: ClientException) {
    println("4xx response calling SearchApi#searchGetentities")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SearchApi#searchGetentities")
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

