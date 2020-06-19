# LocationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**locationDelete**](LocationApi.md#locationDelete) | **DELETE** /location/{id} | Delete a location
[**locationGet**](LocationApi.md#locationGet) | **GET** /location/{id} | Search and view details of a location
[**locationList**](LocationApi.md#locationList) | **GET** /location/list | View a list of locations
[**locationSave**](LocationApi.md#locationSave) | **POST** /location/{id} | Create or edit a location


<a name="locationDelete"></a>
# **locationDelete**
> locationDelete(id, body)

Delete a location

Allows the user to delete an existing location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LocationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.locationDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling LocationApi#locationDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocationApi#locationDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the location to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="locationGet"></a>
# **locationGet**
> locationGet(id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LocationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to get.
try {
    apiInstance.locationGet(id)
} catch (e: ClientException) {
    println("4xx response calling LocationApi#locationGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocationApi#locationGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the location to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="locationList"></a>
# **locationList**
> locationList(from, count, locations, sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LocationApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val locations : kotlin.String = locations_example // kotlin.String | The comma-separated list containing the ids of the locations to list.
val sortbygroup : kotlin.Boolean = true // kotlin.Boolean | True to list locations sorted by the 'Located In' property. Defaults to false.
try {
    apiInstance.locationList(from, count, locations, sortbygroup)
} catch (e: ClientException) {
    println("4xx response calling LocationApi#locationList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocationApi#locationList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **locations** | **kotlin.String**| The comma-separated list containing the ids of the locations to list. | [optional]
 **sortbygroup** | **kotlin.Boolean**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="locationSave"></a>
# **locationSave**
> locationSave(id, UNKNOWN_BASE_TYPE)

Create or edit a location

Allows the user to create or edit a location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LocationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.locationSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling LocationApi#locationSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocationApi#locationSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the location save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

