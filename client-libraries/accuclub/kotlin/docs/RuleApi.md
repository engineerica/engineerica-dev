# RuleApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ruleDelete**](RuleApi.md#ruleDelete) | **DELETE** /rule/{id} | Delete a rule
[**ruleGet**](RuleApi.md#ruleGet) | **GET** /rule/{id} | View details of a rule
[**ruleGeteventtype**](RuleApi.md#ruleGeteventtype) | **GET** /rule/geteventtype | View details of a rule event type
[**ruleList**](RuleApi.md#ruleList) | **GET** /rule/list | View a list of user rules
[**ruleListactions**](RuleApi.md#ruleListactions) | **GET** /rule/listactions | View a list of rule actions available
[**ruleListeventtypes**](RuleApi.md#ruleListeventtypes) | **GET** /rule/listeventtypes | View a list of rule event types
[**ruleListhttprequests**](RuleApi.md#ruleListhttprequests) | **GET** /rule/listhttprequests | View all the http requests sent as a result of a rule
[**ruleSave**](RuleApi.md#ruleSave) | **POST** /rule/{id} | Create or edit a rule


<a name="ruleDelete"></a>
# **ruleDelete**
> ruleDelete(id, body)

Delete a rule

Allows the user to delete an existing rule.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RuleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the rule to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.ruleDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling RuleApi#ruleDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RuleApi#ruleDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the rule to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="ruleGet"></a>
# **ruleGet**
> ruleGet(id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RuleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the rule to get.
try {
    apiInstance.ruleGet(id)
} catch (e: ClientException) {
    println("4xx response calling RuleApi#ruleGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RuleApi#ruleGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the rule to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ruleGeteventtype"></a>
# **ruleGeteventtype**
> ruleGeteventtype(event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RuleApi()
val event : kotlin.String = event_example // kotlin.String | The name of the event to refresh.
try {
    apiInstance.ruleGeteventtype(event)
} catch (e: ClientException) {
    println("4xx response calling RuleApi#ruleGeteventtype")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RuleApi#ruleGeteventtype")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **event** | **kotlin.String**| The name of the event to refresh. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ruleList"></a>
# **ruleList**
> ruleList(from, count)

View a list of user rules

Allows the user to view the list of all rules.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RuleApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.ruleList(from, count)
} catch (e: ClientException) {
    println("4xx response calling RuleApi#ruleList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RuleApi#ruleList")
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

<a name="ruleListactions"></a>
# **ruleListactions**
> ruleListactions()

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RuleApi()
try {
    apiInstance.ruleListactions()
} catch (e: ClientException) {
    println("4xx response calling RuleApi#ruleListactions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RuleApi#ruleListactions")
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

<a name="ruleListeventtypes"></a>
# **ruleListeventtypes**
> ruleListeventtypes()

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RuleApi()
try {
    apiInstance.ruleListeventtypes()
} catch (e: ClientException) {
    println("4xx response calling RuleApi#ruleListeventtypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RuleApi#ruleListeventtypes")
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

<a name="ruleListhttprequests"></a>
# **ruleListhttprequests**
> ruleListhttprequests(from, count, failed, status)

View all the http requests sent as a result of a rule

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RuleApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val failed : kotlin.Boolean = true // kotlin.Boolean | If true only failed requests will be returned
val status : kotlin.Int = 56 // kotlin.Int | The http status to filter the requests
try {
    apiInstance.ruleListhttprequests(from, count, failed, status)
} catch (e: ClientException) {
    println("4xx response calling RuleApi#ruleListhttprequests")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RuleApi#ruleListhttprequests")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **failed** | **kotlin.Boolean**| If true only failed requests will be returned | [optional]
 **status** | **kotlin.Int**| The http status to filter the requests | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ruleSave"></a>
# **ruleSave**
> ruleSave(id, UNKNOWN_BASE_TYPE)

Create or edit a rule

Allows the user to create or edit a rule.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RuleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the rule to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.ruleSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling RuleApi#ruleSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RuleApi#ruleSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the rule to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

