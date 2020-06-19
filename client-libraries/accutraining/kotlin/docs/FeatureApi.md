# FeatureApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**featureList**](FeatureApi.md#featureList) | **GET** /feature/list | Lists the available features.


<a name="featureList"></a>
# **featureList**
> featureList()

Lists the available features.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = FeatureApi()
try {
    apiInstance.featureList()
} catch (e: ClientException) {
    println("4xx response calling FeatureApi#featureList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling FeatureApi#featureList")
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

