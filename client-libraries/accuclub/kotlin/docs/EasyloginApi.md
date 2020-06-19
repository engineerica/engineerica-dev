# EasyloginApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**easyloginAddbgimage**](EasyloginApi.md#easyloginAddbgimage) | **GET** /easylogin/addbgimage | Adds background image for the login


<a name="easyloginAddbgimage"></a>
# **easyloginAddbgimage**
> easyloginAddbgimage(upload, filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuClub account not using SSO.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EasyloginApi()
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The original filename, needed to process the file.
try {
    apiInstance.easyloginAddbgimage(upload, filename)
} catch (e: ClientException) {
    println("4xx response calling EasyloginApi#easyloginAddbgimage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EasyloginApi#easyloginAddbgimage")
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

