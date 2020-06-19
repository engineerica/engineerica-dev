# QuickpanelApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**quickpanelDeletewidget**](QuickpanelApi.md#quickpanelDeletewidget) | **DELETE** /quickpanel/deletewidget | Deletes a widget from the Quick Panel
[**quickpanelFetchwidget**](QuickpanelApi.md#quickpanelFetchwidget) | **GET** /quickpanel/fetchwidget | Fetches the information for a specific widget.
[**quickpanelGetwidget**](QuickpanelApi.md#quickpanelGetwidget) | **GET** /quickpanel/getwidget | View details of a widget included in the Quick Panel
[**quickpanelInit**](QuickpanelApi.md#quickpanelInit) | **GET** /quickpanel/init | Returns the initial information required to show the quick panels
[**quickpanelListwidgets**](QuickpanelApi.md#quickpanelListwidgets) | **GET** /quickpanel/listwidgets | Lists all the widgets that are added in the Quick Panel
[**quickpanelListwidgettypes**](QuickpanelApi.md#quickpanelListwidgettypes) | **GET** /quickpanel/listwidgettypes | Lists all the widget types available in the system
[**quickpanelReorderwidgets**](QuickpanelApi.md#quickpanelReorderwidgets) | **GET** /quickpanel/reorderwidgets | Reorders the widgets and moves them to a specific column
[**quickpanelSavewidget**](QuickpanelApi.md#quickpanelSavewidget) | **POST** /quickpanel/savewidget | Saves a widget for the Quick Panel


<a name="quickpanelDeletewidget"></a>
# **quickpanelDeletewidget**
> quickpanelDeletewidget(UNKNOWN_BASE_TYPE)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QuickpanelApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.quickpanelDeletewidget(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling QuickpanelApi#quickpanelDeletewidget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QuickpanelApi#quickpanelDeletewidget")
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

<a name="quickpanelFetchwidget"></a>
# **quickpanelFetchwidget**
> quickpanelFetchwidget(widgetid)

Fetches the information for a specific widget.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QuickpanelApi()
val widgetid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the data to fetch it's data.
try {
    apiInstance.quickpanelFetchwidget(widgetid)
} catch (e: ClientException) {
    println("4xx response calling QuickpanelApi#quickpanelFetchwidget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QuickpanelApi#quickpanelFetchwidget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **widgetid** | [**java.util.UUID**](.md)| The ID of the data to fetch it&#39;s data. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanelGetwidget"></a>
# **quickpanelGetwidget**
> quickpanelGetwidget(id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QuickpanelApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the widget to get.
try {
    apiInstance.quickpanelGetwidget(id)
} catch (e: ClientException) {
    println("4xx response calling QuickpanelApi#quickpanelGetwidget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QuickpanelApi#quickpanelGetwidget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the widget to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanelInit"></a>
# **quickpanelInit**
> quickpanelInit()

Returns the initial information required to show the quick panels

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QuickpanelApi()
try {
    apiInstance.quickpanelInit()
} catch (e: ClientException) {
    println("4xx response calling QuickpanelApi#quickpanelInit")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QuickpanelApi#quickpanelInit")
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

<a name="quickpanelListwidgets"></a>
# **quickpanelListwidgets**
> quickpanelListwidgets()

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QuickpanelApi()
try {
    apiInstance.quickpanelListwidgets()
} catch (e: ClientException) {
    println("4xx response calling QuickpanelApi#quickpanelListwidgets")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QuickpanelApi#quickpanelListwidgets")
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

<a name="quickpanelListwidgettypes"></a>
# **quickpanelListwidgettypes**
> quickpanelListwidgettypes()

Lists all the widget types available in the system

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QuickpanelApi()
try {
    apiInstance.quickpanelListwidgettypes()
} catch (e: ClientException) {
    println("4xx response calling QuickpanelApi#quickpanelListwidgettypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QuickpanelApi#quickpanelListwidgettypes")
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

<a name="quickpanelReorderwidgets"></a>
# **quickpanelReorderwidgets**
> quickpanelReorderwidgets(sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QuickpanelApi()
val sectionname : kotlin.String = sectionname_example // kotlin.String | The section name where to sort the widgets.
val orderids : kotlin.String = orderids_example // kotlin.String | CSV list of the widgets to reorder.
try {
    apiInstance.quickpanelReorderwidgets(sectionname, orderids)
} catch (e: ClientException) {
    println("4xx response calling QuickpanelApi#quickpanelReorderwidgets")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QuickpanelApi#quickpanelReorderwidgets")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sectionname** | **kotlin.String**| The section name where to sort the widgets. |
 **orderids** | **kotlin.String**| CSV list of the widgets to reorder. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanelSavewidget"></a>
# **quickpanelSavewidget**
> quickpanelSavewidget(UNKNOWN_BASE_TYPE)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QuickpanelApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.quickpanelSavewidget(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling QuickpanelApi#quickpanelSavewidget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QuickpanelApi#quickpanelSavewidget")
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

