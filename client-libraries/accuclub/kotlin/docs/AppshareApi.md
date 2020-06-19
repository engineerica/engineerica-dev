# AppshareApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appshareGetphone**](AppshareApi.md#appshareGetphone) | **GET** /appshare/getphone | Gets the phone number of the current user
[**appshareSendtext**](AppshareApi.md#appshareSendtext) | **GET** /appshare/sendtext | Sends an SMS with the link to the app


<a name="appshareGetphone"></a>
# **appshareGetphone**
> appshareGetphone()

Gets the phone number of the current user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppshareApi()
try {
    apiInstance.appshareGetphone()
} catch (e: ClientException) {
    println("4xx response calling AppshareApi#appshareGetphone")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppshareApi#appshareGetphone")
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

<a name="appshareSendtext"></a>
# **appshareSendtext**
> appshareSendtext(phonenumber)

Sends an SMS with the link to the app

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppshareApi()
val phonenumber : kotlin.String = phonenumber_example // kotlin.String | Phone number to where to send the link. Leave empty to the number on file.
try {
    apiInstance.appshareSendtext(phonenumber)
} catch (e: ClientException) {
    println("4xx response calling AppshareApi#appshareSendtext")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppshareApi#appshareSendtext")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phonenumber** | **kotlin.String**| Phone number to where to send the link. Leave empty to the number on file. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

