# TextcreditApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**textcreditRemaining**](TextcreditApi.md#textcreditRemaining) | **GET** /textcredit/remaining | Gets the remaining text credits for the account


<a name="textcreditRemaining"></a>
# **textcreditRemaining**
> textcreditRemaining()

Gets the remaining text credits for the account

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TextcreditApi()
try {
    apiInstance.textcreditRemaining()
} catch (e: ClientException) {
    println("4xx response calling TextcreditApi#textcreditRemaining")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TextcreditApi#textcreditRemaining")
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

