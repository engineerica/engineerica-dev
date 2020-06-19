# UsersettingsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usersettingsGet**](UsersettingsApi.md#usersettingsGet) | **GET** /usersettings/get | Lists available user settings
[**usersettingsGetmultiple**](UsersettingsApi.md#usersettingsGetmultiple) | **GET** /usersettings/getmultiple | Get multiple user settings
[**usersettingsSave**](UsersettingsApi.md#usersettingsSave) | **POST** /usersettings/save | Saves a user setting
[**usersettingsSavemultiple**](UsersettingsApi.md#usersettingsSavemultiple) | **POST** /usersettings/savemultiple | Save multiple user settings at once


<a name="usersettingsGet"></a>
# **usersettingsGet**
> usersettingsGet(keys, user)

Lists available user settings

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsersettingsApi()
val keys : kotlin.String = keys_example // kotlin.String | Setting key to get. Can be multiple separated by commas.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id whose settings have to be returned.
try {
    apiInstance.usersettingsGet(keys, user)
} catch (e: ClientException) {
    println("4xx response calling UsersettingsApi#usersettingsGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsersettingsApi#usersettingsGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **kotlin.String**| Setting key to get. Can be multiple separated by commas. |
 **user** | [**java.util.UUID**](.md)| The user id whose settings have to be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usersettingsGetmultiple"></a>
# **usersettingsGetmultiple**
> usersettingsGetmultiple(keys, user)

Get multiple user settings

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsersettingsApi()
val keys : kotlin.String = keys_example // kotlin.String | Setting key to get. Can be multiple separated by commas.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id whose settings have to be returned.
try {
    apiInstance.usersettingsGetmultiple(keys, user)
} catch (e: ClientException) {
    println("4xx response calling UsersettingsApi#usersettingsGetmultiple")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsersettingsApi#usersettingsGetmultiple")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **kotlin.String**| Setting key to get. Can be multiple separated by commas. |
 **user** | [**java.util.UUID**](.md)| The user id whose settings have to be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usersettingsSave"></a>
# **usersettingsSave**
> usersettingsSave(UNKNOWN_BASE_TYPE)

Saves a user setting

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsersettingsApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usersettingsSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UsersettingsApi#usersettingsSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsersettingsApi#usersettingsSave")
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

<a name="usersettingsSavemultiple"></a>
# **usersettingsSavemultiple**
> usersettingsSavemultiple(UNKNOWN_BASE_TYPE)

Save multiple user settings at once

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsersettingsApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usersettingsSavemultiple(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UsersettingsApi#usersettingsSavemultiple")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsersettingsApi#usersettingsSavemultiple")
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

