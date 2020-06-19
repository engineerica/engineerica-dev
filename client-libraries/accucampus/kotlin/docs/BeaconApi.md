# BeaconApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**beaconDelete**](BeaconApi.md#beaconDelete) | **DELETE** /beacon/{id} | Delete a beacon profile
[**beaconDisable**](BeaconApi.md#beaconDisable) | **GET** /beacon/disable | Disable beacon support account wide
[**beaconGet**](BeaconApi.md#beaconGet) | **GET** /beacon/{id} | View details of a beacon profile
[**beaconGetlocations**](BeaconApi.md#beaconGetlocations) | **GET** /beacon/getlocations | Get the sign-in stations assigned to specific beacons.
[**beaconGetstationlocation**](BeaconApi.md#beaconGetstationlocation) | **GET** /beacon/getstationlocation | Get the location settings in the specified sign-in station.
[**beaconGetuuid**](BeaconApi.md#beaconGetuuid) | **GET** /beacon/getuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**beaconList**](BeaconApi.md#beaconList) | **GET** /beacon/list | View a list of beacon profiles
[**beaconListprofiles**](BeaconApi.md#beaconListprofiles) | **GET** /beacon/listprofiles | View a list of beacon profiles with their characteristics
[**beaconResetuuid**](BeaconApi.md#beaconResetuuid) | **GET** /beacon/resetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**beaconSave**](BeaconApi.md#beaconSave) | **POST** /beacon/{id} | Create or edit a beacon profile
[**beaconScanlocations**](BeaconApi.md#beaconScanlocations) | **GET** /beacon/scanlocations | Check if there&#39;s location available to sign-in / out.
[**beaconSetuuid**](BeaconApi.md#beaconSetuuid) | **GET** /beacon/setuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**beaconSilentregions**](BeaconApi.md#beaconSilentregions) | **GET** /beacon/silentregions | View all the beacon regions defined for silent tracking
[**beaconSilentsignin**](BeaconApi.md#beaconSilentsignin) | **GET** /beacon/silentsignin | Sign-in silently from the location specified by a beacon
[**beaconSilentsignout**](BeaconApi.md#beaconSilentsignout) | **GET** /beacon/silentsignout | Sign-out silently from the location specified by a beacon


<a name="beaconDelete"></a>
# **beaconDelete**
> beaconDelete(id, body)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the beacon to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.beaconDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the beacon to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="beaconDisable"></a>
# **beaconDisable**
> beaconDisable()

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
try {
    apiInstance.beaconDisable()
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconDisable")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconDisable")
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

<a name="beaconGet"></a>
# **beaconGet**
> beaconGet(id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the beacon to get.
try {
    apiInstance.beaconGet(id)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the beacon to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconGetlocations"></a>
# **beaconGetlocations**
> beaconGetlocations(beacons)

Get the sign-in stations assigned to specific beacons.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val beacons : kotlin.String = beacons_example // kotlin.String | A JSON array containg the beacons data (region, minor and major) values.
try {
    apiInstance.beaconGetlocations(beacons)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconGetlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconGetlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beacons** | **kotlin.String**| A JSON array containg the beacons data (region, minor and major) values. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconGetstationlocation"></a>
# **beaconGetstationlocation**
> beaconGetstationlocation(station, location)

Get the location settings in the specified sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station whose location information has to be retrieved.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location whose information has to be retrieved.
try {
    apiInstance.beaconGetstationlocation(station, location)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconGetstationlocation")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconGetstationlocation")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station whose location information has to be retrieved. |
 **location** | [**java.util.UUID**](.md)| The id of the location whose information has to be retrieved. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconGetuuid"></a>
# **beaconGetuuid**
> beaconGetuuid()

View the identifier for the account&#39;s beacon region (for sign-in stations).

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
try {
    apiInstance.beaconGetuuid()
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconGetuuid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconGetuuid")
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

<a name="beaconList"></a>
# **beaconList**
> beaconList(from, count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.beaconList(from, count)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconList")
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

<a name="beaconListprofiles"></a>
# **beaconListprofiles**
> beaconListprofiles()

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
try {
    apiInstance.beaconListprofiles()
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconListprofiles")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconListprofiles")
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

<a name="beaconResetuuid"></a>
# **beaconResetuuid**
> beaconResetuuid()

Generate or reset the identifier for the account&#39;s beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
try {
    apiInstance.beaconResetuuid()
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconResetuuid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconResetuuid")
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

<a name="beaconSave"></a>
# **beaconSave**
> beaconSave(id, UNKNOWN_BASE_TYPE)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the beacon save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.beaconSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the beacon save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="beaconScanlocations"></a>
# **beaconScanlocations**
> beaconScanlocations(beacons)

Check if there&#39;s location available to sign-in / out.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val beacons : kotlin.String = beacons_example // kotlin.String | A JSON array containg the beacons data (region, minor and major) values.
try {
    apiInstance.beaconScanlocations(beacons)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconScanlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconScanlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beacons** | **kotlin.String**| A JSON array containg the beacons data (region, minor and major) values. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconSetuuid"></a>
# **beaconSetuuid**
> beaconSetuuid(id)

Set the identifier for the account&#39;s beacon region (for sign-in stations).

Allows the user to set the identifier for the account&#39;s beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The custom region UUID.
try {
    apiInstance.beaconSetuuid(id)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconSetuuid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconSetuuid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The custom region UUID. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconSilentregions"></a>
# **beaconSilentregions**
> beaconSilentregions()

View all the beacon regions defined for silent tracking

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
try {
    apiInstance.beaconSilentregions()
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconSilentregions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconSilentregions")
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

<a name="beaconSilentsignin"></a>
# **beaconSilentsignin**
> beaconSilentsignin(uuid)

Sign-in silently from the location specified by a beacon

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val uuid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the region the user is in.
try {
    apiInstance.beaconSilentsignin(uuid)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconSilentsignin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconSilentsignin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**java.util.UUID**](.md)| The id of the region the user is in. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconSilentsignout"></a>
# **beaconSilentsignout**
> beaconSilentsignout(uuid)

Sign-out silently from the location specified by a beacon

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BeaconApi()
val uuid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the region the user has left.
try {
    apiInstance.beaconSilentsignout(uuid)
} catch (e: ClientException) {
    println("4xx response calling BeaconApi#beaconSilentsignout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BeaconApi#beaconSilentsignout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**java.util.UUID**](.md)| The id of the region the user has left. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

