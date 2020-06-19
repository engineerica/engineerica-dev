# ScheduleintegrationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**scheduleintegrationClearids**](ScheduleintegrationApi.md#scheduleintegrationClearids) | **GET** /scheduleintegration/clearids | Clear all third party IDs from specified staff member&#39;s schedule items.
[**scheduleintegrationDeleteitem**](ScheduleintegrationApi.md#scheduleintegrationDeleteitem) | **DELETE** /scheduleintegration/deleteitem | Delete a schedule item looking up by a third party ID
[**scheduleintegrationDeleteitemsbymasterid**](ScheduleintegrationApi.md#scheduleintegrationDeleteitemsbymasterid) | **DELETE** /scheduleintegration/deleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**scheduleintegrationGetitem**](ScheduleintegrationApi.md#scheduleintegrationGetitem) | **GET** /scheduleintegration/getitem | Get a schedule item looking up by a third party ID
[**scheduleintegrationSaveitem**](ScheduleintegrationApi.md#scheduleintegrationSaveitem) | **POST** /scheduleintegration/saveitem | Save a schedule item looking up by a third party ID
[**scheduleintegrationSetid**](ScheduleintegrationApi.md#scheduleintegrationSetid) | **GET** /scheduleintegration/setid | Set a 3rd party ID on a specific schedule item


<a name="scheduleintegrationClearids"></a>
# **scheduleintegrationClearids**
> scheduleintegrationClearids(staff)

Clear all third party IDs from specified staff member&#39;s schedule items.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleintegrationApi()
val staff : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the staff member whose schedule items third party IDs must be cleared.
try {
    apiInstance.scheduleintegrationClearids(staff)
} catch (e: ClientException) {
    println("4xx response calling ScheduleintegrationApi#scheduleintegrationClearids")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleintegrationApi#scheduleintegrationClearids")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staff** | [**java.util.UUID**](.md)| The ID of the staff member whose schedule items third party IDs must be cleared. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleintegrationDeleteitem"></a>
# **scheduleintegrationDeleteitem**
> scheduleintegrationDeleteitem(UNKNOWN_BASE_TYPE)

Delete a schedule item looking up by a third party ID

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleintegrationApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.scheduleintegrationDeleteitem(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ScheduleintegrationApi#scheduleintegrationDeleteitem")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleintegrationApi#scheduleintegrationDeleteitem")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="scheduleintegrationDeleteitemsbymasterid"></a>
# **scheduleintegrationDeleteitemsbymasterid**
> scheduleintegrationDeleteitemsbymasterid(UNKNOWN_BASE_TYPE)

Delete multiple schedule items looking up by a third party master ID

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleintegrationApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.scheduleintegrationDeleteitemsbymasterid(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ScheduleintegrationApi#scheduleintegrationDeleteitemsbymasterid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleintegrationApi#scheduleintegrationDeleteitemsbymasterid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="scheduleintegrationGetitem"></a>
# **scheduleintegrationGetitem**
> scheduleintegrationGetitem(thirdpartyid)

Get a schedule item looking up by a third party ID

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleintegrationApi()
val thirdpartyid : kotlin.String = thirdpartyid_example // kotlin.String | The third party id to search for the schedule item.
try {
    apiInstance.scheduleintegrationGetitem(thirdpartyid)
} catch (e: ClientException) {
    println("4xx response calling ScheduleintegrationApi#scheduleintegrationGetitem")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleintegrationApi#scheduleintegrationGetitem")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thirdpartyid** | **kotlin.String**| The third party id to search for the schedule item. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleintegrationSaveitem"></a>
# **scheduleintegrationSaveitem**
> scheduleintegrationSaveitem(UNKNOWN_BASE_TYPE)

Save a schedule item looking up by a third party ID

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleintegrationApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.scheduleintegrationSaveitem(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ScheduleintegrationApi#scheduleintegrationSaveitem")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleintegrationApi#scheduleintegrationSaveitem")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="scheduleintegrationSetid"></a>
# **scheduleintegrationSetid**
> scheduleintegrationSetid(id, thirdpartyid, thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleintegrationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule block / appointment.
val thirdpartyid : kotlin.String = thirdpartyid_example // kotlin.String | The 3rd party ID to set.
val thirdpartymasterid : kotlin.String = thirdpartymasterid_example // kotlin.String | The 3rd party master ID to set (useful to handle recurring items).
try {
    apiInstance.scheduleintegrationSetid(id, thirdpartyid, thirdpartymasterid)
} catch (e: ClientException) {
    println("4xx response calling ScheduleintegrationApi#scheduleintegrationSetid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleintegrationApi#scheduleintegrationSetid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the schedule block / appointment. |
 **thirdpartyid** | **kotlin.String**| The 3rd party ID to set. |
 **thirdpartymasterid** | **kotlin.String**| The 3rd party master ID to set (useful to handle recurring items). | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

