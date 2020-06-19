# CompassserviceApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**compassserviceList**](CompassserviceApi.md#compassserviceList) | **GET** /compassservice/list | View all the services added to the compass
[**compassserviceListlocations**](CompassserviceApi.md#compassserviceListlocations) | **GET** /compassservice/listlocations | View all the locations where a service added to the compass is available


<a name="compassserviceList"></a>
# **compassserviceList**
> compassserviceList(category)

View all the services added to the compass

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CompassserviceApi()
val category : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the category to filter the services.
try {
    apiInstance.compassserviceList(category)
} catch (e: ClientException) {
    println("4xx response calling CompassserviceApi#compassserviceList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CompassserviceApi#compassserviceList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**java.util.UUID**](.md)| The id of the category to filter the services. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="compassserviceListlocations"></a>
# **compassserviceListlocations**
> compassserviceListlocations(serviceid)

View all the locations where a service added to the compass is available

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CompassserviceApi()
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to get its locations.
try {
    apiInstance.compassserviceListlocations(serviceid)
} catch (e: ClientException) {
    println("4xx response calling CompassserviceApi#compassserviceListlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CompassserviceApi#compassserviceListlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to get its locations. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

