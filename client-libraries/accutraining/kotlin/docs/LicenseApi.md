# LicenseApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**licenseAcceptagreement**](LicenseApi.md#licenseAcceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
[**licenseGetagreementstatus**](LicenseApi.md#licenseGetagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
[**licenseGetcurrent**](LicenseApi.md#licenseGetcurrent) | **GET** /license/getcurrent | Gets the current license information
[**licenseRenew**](LicenseApi.md#licenseRenew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuTraining subscription


<a name="licenseAcceptagreement"></a>
# **licenseAcceptagreement**
> licenseAcceptagreement()

Accept the license agreement

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LicenseApi()
try {
    apiInstance.licenseAcceptagreement()
} catch (e: ClientException) {
    println("4xx response calling LicenseApi#licenseAcceptagreement")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LicenseApi#licenseAcceptagreement")
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

<a name="licenseGetagreementstatus"></a>
# **licenseGetagreementstatus**
> licenseGetagreementstatus()

Check if license agreement has been accepted

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LicenseApi()
try {
    apiInstance.licenseGetagreementstatus()
} catch (e: ClientException) {
    println("4xx response calling LicenseApi#licenseGetagreementstatus")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LicenseApi#licenseGetagreementstatus")
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

<a name="licenseGetcurrent"></a>
# **licenseGetcurrent**
> licenseGetcurrent()

Gets the current license information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LicenseApi()
try {
    apiInstance.licenseGetcurrent()
} catch (e: ClientException) {
    println("4xx response calling LicenseApi#licenseGetcurrent")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LicenseApi#licenseGetcurrent")
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

<a name="licenseRenew"></a>
# **licenseRenew**
> licenseRenew(email, phonenumber, jobtitle, institution, comments)

Contact Engineerica in order to renew the AccuTraining subscription

Allows the user to select the option to contact Engineerica when the AccuTraining account is nearing its renewal date.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = LicenseApi()
val email : kotlin.String = email_example // kotlin.String | The e-mail of the user sending the request.
val phonenumber : kotlin.String = phonenumber_example // kotlin.String | The phone number of the user sending the request.
val jobtitle : kotlin.String = jobtitle_example // kotlin.String | The job title of the user sending the request.
val institution : kotlin.String = institution_example // kotlin.String | The institution of the user sending the request.
val comments : kotlin.String = comments_example // kotlin.String | Comments entered by the user sending the request.
try {
    apiInstance.licenseRenew(email, phonenumber, jobtitle, institution, comments)
} catch (e: ClientException) {
    println("4xx response calling LicenseApi#licenseRenew")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LicenseApi#licenseRenew")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **kotlin.String**| The e-mail of the user sending the request. |
 **phonenumber** | **kotlin.String**| The phone number of the user sending the request. |
 **jobtitle** | **kotlin.String**| The job title of the user sending the request. | [optional]
 **institution** | **kotlin.String**| The institution of the user sending the request. | [optional]
 **comments** | **kotlin.String**| Comments entered by the user sending the request. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

