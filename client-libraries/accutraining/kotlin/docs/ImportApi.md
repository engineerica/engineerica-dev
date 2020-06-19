# ImportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**importListtypes**](ImportApi.md#importListtypes) | **GET** /import/listtypes | Lists available import types


<a name="importListtypes"></a>
# **importListtypes**
> importListtypes()

Lists available import types

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ImportApi()
try {
    apiInstance.importListtypes()
} catch (e: ClientException) {
    println("4xx response calling ImportApi#importListtypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ImportApi#importListtypes")
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

