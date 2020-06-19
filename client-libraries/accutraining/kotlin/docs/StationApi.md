# StationApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**stationDelete**](StationApi.md#stationDelete) | **DELETE** /station/{id} | Delete a sign-in station
[**stationGet**](StationApi.md#stationGet) | **GET** /station/{id} | View details of a sign-in station
[**stationGetcurrentterms**](StationApi.md#stationGetcurrentterms) | **GET** /station/getcurrentterms | Get all the current terms
[**stationGetinfo**](StationApi.md#stationGetinfo) | **GET** /station/getinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**stationGetlicense**](StationApi.md#stationGetlicense) | **GET** /station/getlicense | Gets the current license information
[**stationList**](StationApi.md#stationList) | **GET** /station/list | View a list of sign-in stations
[**stationSave**](StationApi.md#stationSave) | **POST** /station/{id} | Create or edit a sign-in station
[**stationUnlock**](StationApi.md#stationUnlock) | **GET** /station/unlock | Unlocks the sign-in station.


<a name="stationDelete"></a>
# **stationDelete**
> stationDelete(id, body)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.stationDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling StationApi#stationDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StationApi#stationDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="stationGet"></a>
# **stationGet**
> stationGet(id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
try {
    apiInstance.stationGet(id)
} catch (e: ClientException) {
    println("4xx response calling StationApi#stationGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StationApi#stationGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationGetcurrentterms"></a>
# **stationGetcurrentterms**
> stationGetcurrentterms(station)

Get all the current terms

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station whose account's current terms have to be retrieved.
try {
    apiInstance.stationGetcurrentterms(station)
} catch (e: ClientException) {
    println("4xx response calling StationApi#stationGetcurrentterms")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StationApi#stationGetcurrentterms")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationGetinfo"></a>
# **stationGetinfo**
> stationGetinfo(id, event)

Gets a the info to display in the sign-in station by it&#39;s ID.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event, to override the one by schedule.
try {
    apiInstance.stationGetinfo(id, event)
} catch (e: ClientException) {
    println("4xx response calling StationApi#stationGetinfo")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StationApi#stationGetinfo")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **event** | [**java.util.UUID**](.md)| The id of the event, to override the one by schedule. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationGetlicense"></a>
# **stationGetlicense**
> stationGetlicense(station)

Gets the current license information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StationApi()
val station : kotlin.String = station_example // kotlin.String | The id of the sign-in station whose account's license has to be retrieved.
try {
    apiInstance.stationGetlicense(station)
} catch (e: ClientException) {
    println("4xx response calling StationApi#stationGetlicense")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StationApi#stationGetlicense")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | **kotlin.String**| The id of the sign-in station whose account&#39;s license has to be retrieved. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationList"></a>
# **stationList**
> stationList(from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StationApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.stationList(from, count)
} catch (e: ClientException) {
    println("4xx response calling StationApi#stationList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StationApi#stationList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationSave"></a>
# **stationSave**
> stationSave(id, UNKNOWN_BASE_TYPE)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.stationSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling StationApi#stationSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StationApi#stationSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="stationUnlock"></a>
# **stationUnlock**
> stationUnlock(id, passcode, method)

Unlocks the sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to unlock.
val passcode : kotlin.String = passcode_example // kotlin.String | The passcode to unlock the station.
val method : kotlin.String = method_example // kotlin.String | The authentication method. Valid values are 'token' and 'cookie'.
try {
    apiInstance.stationUnlock(id, passcode, method)
} catch (e: ClientException) {
    println("4xx response calling StationApi#stationUnlock")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StationApi#stationUnlock")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to unlock. |
 **passcode** | **kotlin.String**| The passcode to unlock the station. |
 **method** | **kotlin.String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

