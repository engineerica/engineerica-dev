# RiskmodelApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**riskmodelCheckanalysis**](RiskmodelApi.md#riskmodelCheckanalysis) | **GET** /riskmodel/checkanalysis | Check the status of the analysis of a specified risk assessment model
[**riskmodelDelete**](RiskmodelApi.md#riskmodelDelete) | **DELETE** /riskmodel/{id} | Delete a risk assessment model
[**riskmodelGet**](RiskmodelApi.md#riskmodelGet) | **GET** /riskmodel/{id} | View details of a risk assessment model
[**riskmodelGetscore**](RiskmodelApi.md#riskmodelGetscore) | **GET** /riskmodel/getscore | View the risk score for a specific user
[**riskmodelList**](RiskmodelApi.md#riskmodelList) | **GET** /riskmodel/list | View a list of risk assessment models
[**riskmodelPredict**](RiskmodelApi.md#riskmodelPredict) | **GET** /riskmodel/predict | Predict risk based on an assessment model
[**riskmodelProcess**](RiskmodelApi.md#riskmodelProcess) | **GET** /riskmodel/process | Process a risk assessment model
[**riskmodelRefresh**](RiskmodelApi.md#riskmodelRefresh) | **GET** /riskmodel/refresh | Refresh the information used in a risk assessment model
[**riskmodelSave**](RiskmodelApi.md#riskmodelSave) | **POST** /riskmodel/{id} | Create or edit a risk assessment model
[**riskmodelTermprecedences**](RiskmodelApi.md#riskmodelTermprecedences) | **GET** /riskmodel/termprecedences | View all default term precedences


<a name="riskmodelCheckanalysis"></a>
# **riskmodelCheckanalysis**
> riskmodelCheckanalysis(id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model whose analysis status has to be returned.
try {
    apiInstance.riskmodelCheckanalysis(id)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelCheckanalysis")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelCheckanalysis")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model whose analysis status has to be returned. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelDelete"></a>
# **riskmodelDelete**
> riskmodelDelete(id, body)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.riskmodelDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="riskmodelGet"></a>
# **riskmodelGet**
> riskmodelGet(id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model to get.
try {
    apiInstance.riskmodelGet(id)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelGetscore"></a>
# **riskmodelGetscore**
> riskmodelGetscore(userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to get the risk score.
try {
    apiInstance.riskmodelGetscore(userid)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelGetscore")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelGetscore")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to get the risk score. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelList"></a>
# **riskmodelList**
> riskmodelList(from, count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.riskmodelList(from, count)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelPredict"></a>
# **riskmodelPredict**
> riskmodelPredict(id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the assessment model to use in order to predict risk.
try {
    apiInstance.riskmodelPredict(id)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelPredict")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelPredict")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the assessment model to use in order to predict risk. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelProcess"></a>
# **riskmodelProcess**
> riskmodelProcess(id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model to process.
try {
    apiInstance.riskmodelProcess(id)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelProcess")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelProcess")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model to process. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelRefresh"></a>
# **riskmodelRefresh**
> riskmodelRefresh(id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model whose information has to be refreshed.
try {
    apiInstance.riskmodelRefresh(id)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelRefresh")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelRefresh")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model whose information has to be refreshed. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelSave"></a>
# **riskmodelSave**
> riskmodelSave(id, UNKNOWN_BASE_TYPE)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the department save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.riskmodelSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the department save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="riskmodelTermprecedences"></a>
# **riskmodelTermprecedences**
> riskmodelTermprecedences()

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RiskmodelApi()
try {
    apiInstance.riskmodelTermprecedences()
} catch (e: ClientException) {
    println("4xx response calling RiskmodelApi#riskmodelTermprecedences")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RiskmodelApi#riskmodelTermprecedences")
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

