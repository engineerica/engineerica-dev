# MenuApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**menuGetitems**](MenuApi.md#menuGetitems) | **GET** /menu/getitems | Gets the items on the menu


<a name="menuGetitems"></a>
# **menuGetitems**
> menuGetitems(menuid)

Gets the items on the menu

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MenuApi()
val menuid : kotlin.String = menuid_example // kotlin.String | The Id of the menu to get.
try {
    apiInstance.menuGetitems(menuid)
} catch (e: ClientException) {
    println("4xx response calling MenuApi#menuGetitems")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MenuApi#menuGetitems")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuid** | **kotlin.String**| The Id of the menu to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

