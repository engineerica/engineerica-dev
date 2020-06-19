# ServiceassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**serviceassignmentAddservice**](ServiceassignmentApi.md#serviceassignmentAddservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
[**serviceassignmentGetlocation**](ServiceassignmentApi.md#serviceassignmentGetlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**serviceassignmentGetservice**](ServiceassignmentApi.md#serviceassignmentGetservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
[**serviceassignmentRemoveservice**](ServiceassignmentApi.md#serviceassignmentRemoveservice) | **GET** /serviceassignment/removeservice | Remove a service from a location


<a name="serviceassignmentAddservice"></a>
# **serviceassignmentAddservice**
> serviceassignmentAddservice(serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ServiceassignmentApi()
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to add.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location.
try {
    apiInstance.serviceassignmentAddservice(serviceid, locationid)
} catch (e: ClientException) {
    println("4xx response calling ServiceassignmentApi#serviceassignmentAddservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServiceassignmentApi#serviceassignmentAddservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to add. |
 **locationid** | [**java.util.UUID**](.md)| The id of the location. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="serviceassignmentGetlocation"></a>
# **serviceassignmentGetlocation**
> serviceassignmentGetlocation(locationid, includegloballyavailable, namefilter, count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ServiceassignmentApi()
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to get.
val includegloballyavailable : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the services available globally must be returned or not.
val namefilter : kotlin.Boolean = true // kotlin.Boolean | Filters the name of the services to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of services to return.
try {
    apiInstance.serviceassignmentGetlocation(locationid, includegloballyavailable, namefilter, count)
} catch (e: ClientException) {
    println("4xx response calling ServiceassignmentApi#serviceassignmentGetlocation")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServiceassignmentApi#serviceassignmentGetlocation")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**java.util.UUID**](.md)| The id of the location to get. |
 **includegloballyavailable** | **kotlin.Boolean**| Specifies whether the services available globally must be returned or not. | [optional]
 **namefilter** | **kotlin.Boolean**| Filters the name of the services to return. | [optional]
 **count** | **kotlin.Int**| The max number of services to return. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="serviceassignmentGetservice"></a>
# **serviceassignmentGetservice**
> serviceassignmentGetservice(serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ServiceassignmentApi()
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to get its locations.
try {
    apiInstance.serviceassignmentGetservice(serviceid)
} catch (e: ClientException) {
    println("4xx response calling ServiceassignmentApi#serviceassignmentGetservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServiceassignmentApi#serviceassignmentGetservice")
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

<a name="serviceassignmentRemoveservice"></a>
# **serviceassignmentRemoveservice**
> serviceassignmentRemoveservice(serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ServiceassignmentApi()
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to remove.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to remove the service from.
try {
    apiInstance.serviceassignmentRemoveservice(serviceid, locationid)
} catch (e: ClientException) {
    println("4xx response calling ServiceassignmentApi#serviceassignmentRemoveservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServiceassignmentApi#serviceassignmentRemoveservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to remove. |
 **locationid** | [**java.util.UUID**](.md)| The id of the location to remove the service from. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

