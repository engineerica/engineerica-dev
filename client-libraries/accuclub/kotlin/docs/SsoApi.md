# SsoApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ssoGeneratekey**](SsoApi.md#ssoGeneratekey) | **GET** /sso/generatekey | Generate/reset single sign on access key.
[**ssoGetsettings**](SsoApi.md#ssoGetsettings) | **GET** /sso/getsettings | View single sign on settings.
[**ssoIssuetoken**](SsoApi.md#ssoIssuetoken) | **GET** /sso/issuetoken | Issue single sign-on token
[**ssoSavesettings**](SsoApi.md#ssoSavesettings) | **POST** /sso/savesettings | Edit single sign-on settings.


<a name="ssoGeneratekey"></a>
# **ssoGeneratekey**
> ssoGeneratekey()

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SsoApi()
try {
    apiInstance.ssoGeneratekey()
} catch (e: ClientException) {
    println("4xx response calling SsoApi#ssoGeneratekey")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SsoApi#ssoGeneratekey")
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

<a name="ssoGetsettings"></a>
# **ssoGetsettings**
> ssoGetsettings()

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SsoApi()
try {
    apiInstance.ssoGetsettings()
} catch (e: ClientException) {
    println("4xx response calling SsoApi#ssoGetsettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SsoApi#ssoGetsettings")
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

<a name="ssoIssuetoken"></a>
# **ssoIssuetoken**
> ssoIssuetoken(key, username, expires)

Issue single sign-on token

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SsoApi()
val key : kotlin.String = key_example // kotlin.String | The single sign-on key of the account.
val username : kotlin.String = username_example // kotlin.String | The email of the user to sign-on.
val expires : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the session should expire when inactive.
try {
    apiInstance.ssoIssuetoken(key, username, expires)
} catch (e: ClientException) {
    println("4xx response calling SsoApi#ssoIssuetoken")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SsoApi#ssoIssuetoken")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **kotlin.String**| The single sign-on key of the account. |
 **username** | **kotlin.String**| The email of the user to sign-on. |
 **expires** | **kotlin.Boolean**| Specifies whether the session should expire when inactive. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ssoSavesettings"></a>
# **ssoSavesettings**
> ssoSavesettings(UNKNOWN_BASE_TYPE)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SsoApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.ssoSavesettings(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SsoApi#ssoSavesettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SsoApi#ssoSavesettings")
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

