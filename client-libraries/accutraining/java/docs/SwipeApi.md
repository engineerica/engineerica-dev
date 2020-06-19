# SwipeApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**swipeDelete**](SwipeApi.md#swipeDelete) | **DELETE** /swipe/{id} | Delete a swipe
[**swipeGet**](SwipeApi.md#swipeGet) | **GET** /swipe/{id} | Search and view details of a swipe
[**swipeList**](SwipeApi.md#swipeList) | **GET** /swipe/list | View a list of swipes
[**swipeSave**](SwipeApi.md#swipeSave) | **POST** /swipe/save | Create or edit a swipe, and if possible, save the related attendance log
[**swipeSaveanonym**](SwipeApi.md#swipeSaveanonym) | **POST** /swipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log


<a name="swipeDelete"></a>
# **swipeDelete**
> swipeDelete(id, body)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SwipeApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SwipeApi apiInstance = new SwipeApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the swipe to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.swipeDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling SwipeApi#swipeDelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The id of the swipe to delete. |
 **body** | **oas_any_type_not_mapped**|  | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipeGet"></a>
# **swipeGet**
> swipeGet(id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SwipeApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SwipeApi apiInstance = new SwipeApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the swipe to get.
    try {
      apiInstance.swipeGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling SwipeApi#swipeGet");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The id of the swipe to get. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipeList"></a>
# **swipeList**
> swipeList(from, count)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SwipeApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SwipeApi apiInstance = new SwipeApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.swipeList(from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling SwipeApi#swipeList");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipeSave"></a>
# **swipeSave**
> swipeSave(UNKNOWN_BASE_TYPE)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SwipeApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SwipeApi apiInstance = new SwipeApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.swipeSave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling SwipeApi#swipeSave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipeSaveanonym"></a>
# **swipeSaveanonym**
> swipeSaveanonym(UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SwipeApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");

    SwipeApi apiInstance = new SwipeApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.swipeSaveanonym(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling SwipeApi#swipeSaveanonym");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

