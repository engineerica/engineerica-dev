# AdhocreportsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocreportsReqaccess**](AdhocreportsApi.md#adhocreportsReqaccess) | **GET** /adhocreports/reqaccess | Request access to the ad-hoc reports


<a name="adhocreportsReqaccess"></a>
# **adhocreportsReqaccess**
> adhocreportsReqaccess()

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, &#39;Request Access&#39; under Institutional Research -&gt; Ad-hoc Reports

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocreportsApi()
try {
    apiInstance.adhocreportsReqaccess()
} catch (e: ClientException) {
    println("4xx response calling AdhocreportsApi#adhocreportsReqaccess")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocreportsApi#adhocreportsReqaccess")
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

