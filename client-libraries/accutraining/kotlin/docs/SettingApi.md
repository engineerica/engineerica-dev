# SettingApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**settingAddlogo**](SettingApi.md#settingAddlogo) | **GET** /setting/addlogo | Add a logo to the account
[**settingGet**](SettingApi.md#settingGet) | **GET** /setting/get | Get settings for the account or the specified scope
[**settingSave**](SettingApi.md#settingSave) | **POST** /setting/save | Save settings for the account or the specified scope
[**settingViewgeneral**](SettingApi.md#settingViewgeneral) | **GET** /setting/viewgeneral | View general settings for the account


<a name="settingAddlogo"></a>
# **settingAddlogo**
> settingAddlogo(upload, filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuTraining browser version.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SettingApi()
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The original filename, needed to process the file.
try {
    apiInstance.settingAddlogo(upload, filename)
} catch (e: ClientException) {
    println("4xx response calling SettingApi#settingAddlogo")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SettingApi#settingAddlogo")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The original filename, needed to process the file. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="settingGet"></a>
# **settingGet**
> settingGet(keys, domain, scope)

Get settings for the account or the specified scope

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SettingApi()
val keys : kotlin.String = keys_example // kotlin.String | The option keys to get values for. Enter multiple separated by comma.
val domain : kotlin.String = domain_example // kotlin.String | The account domain, in case of reading settings annonymously.
val scope : kotlin.String = scope_example // kotlin.String | The scope of the settings to get.
try {
    apiInstance.settingGet(keys, domain, scope)
} catch (e: ClientException) {
    println("4xx response calling SettingApi#settingGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SettingApi#settingGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **kotlin.String**| The option keys to get values for. Enter multiple separated by comma. |
 **domain** | **kotlin.String**| The account domain, in case of reading settings annonymously. | [optional]
 **scope** | **kotlin.String**| The scope of the settings to get. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="settingSave"></a>
# **settingSave**
> settingSave(UNKNOWN_BASE_TYPE)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SettingApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.settingSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SettingApi#settingSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SettingApi#settingSave")
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

<a name="settingViewgeneral"></a>
# **settingViewgeneral**
> settingViewgeneral()

View general settings for the account

Allows the user to view the settings&#39; general section.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SettingApi()
try {
    apiInstance.settingViewgeneral()
} catch (e: ClientException) {
    println("4xx response calling SettingApi#settingViewgeneral")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SettingApi#settingViewgeneral")
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

