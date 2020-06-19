# QrloginApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrloginGet**](QrloginApi.md#qrloginGet) | **GET** /qrlogin/get | Gets an image of a QR token
[**qrloginLogin**](QrloginApi.md#qrloginLogin) | **GET** /qrlogin/login | Login


<a name="qrloginGet"></a>
# **qrloginGet**
> qrloginGet()

Gets an image of a QR token

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QrloginApi()
try {
    apiInstance.qrloginGet()
} catch (e: ClientException) {
    println("4xx response calling QrloginApi#qrloginGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QrloginApi#qrloginGet")
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

<a name="qrloginLogin"></a>
# **qrloginLogin**
> qrloginLogin(onetimetoken)

Login

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QrloginApi()
val onetimetoken : kotlin.String = onetimetoken_example // kotlin.String | The token read from the QR code.
try {
    apiInstance.qrloginLogin(onetimetoken)
} catch (e: ClientException) {
    println("4xx response calling QrloginApi#qrloginLogin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QrloginApi#qrloginLogin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onetimetoken** | **kotlin.String**| The token read from the QR code. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

