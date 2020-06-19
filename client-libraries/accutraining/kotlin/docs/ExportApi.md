# ExportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**exportListtypes**](ExportApi.md#exportListtypes) | **GET** /export/listtypes | Lists available export types


<a name="exportListtypes"></a>
# **exportListtypes**
> exportListtypes()

Lists available export types

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ExportApi()
try {
    apiInstance.exportListtypes()
} catch (e: ClientException) {
    println("4xx response calling ExportApi#exportListtypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ExportApi#exportListtypes")
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

