# InteractionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**interactionDelete**](InteractionApi.md#interactionDelete) | **DELETE** /interaction/{id} | Delete an interaction
[**interactionFeed**](InteractionApi.md#interactionFeed) | **GET** /interaction/feed | Get the interactions feed
[**interactionGet**](InteractionApi.md#interactionGet) | **GET** /interaction/{id} | View an interaction
[**interactionListprivatesummary**](InteractionApi.md#interactionListprivatesummary) | **GET** /interaction/listprivatesummary | Get current user&#39;s latest private interactions
[**interactionSave**](InteractionApi.md#interactionSave) | **POST** /interaction/{id} | Save an interaction


<a name="interactionDelete"></a>
# **interactionDelete**
> interactionDelete(id, body)

Delete an interaction

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.InteractionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    InteractionApi apiInstance = new InteractionApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the interaction to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.interactionDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling InteractionApi#interactionDelete");
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
 **id** | [**UUID**](.md)| The id of the interaction to delete. |
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

<a name="interactionFeed"></a>
# **interactionFeed**
> interactionFeed(from, count, startdate, _public, contexttype, contextid, types, photosize, showdefaultphoto, orderdescending)

Get the interactions feed

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.InteractionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    InteractionApi apiInstance = new InteractionApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | If set, only interactions that happened after this date are returned.
    Boolean _public = true; // Boolean | Specifies whether to return public or private interactions.
    String contexttype = "contexttype_example"; // String | The type of the context of the interactions to return.
    UUID contextid = new UUID(); // UUID | The id of the context of the interactions to return.
    String types = "types_example"; // String | The  comma separated types of the interactions to return.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    Boolean showdefaultphoto = true; // Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
    Boolean orderdescending = true; // Boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.
    try {
      apiInstance.interactionFeed(from, count, startdate, _public, contexttype, contextid, types, photosize, showdefaultphoto, orderdescending);
    } catch (ApiException e) {
      System.err.println("Exception when calling InteractionApi#interactionFeed");
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
 **startdate** | **OffsetDateTime**| If set, only interactions that happened after this date are returned. | [optional]
 **_public** | **Boolean**| Specifies whether to return public or private interactions. | [optional]
 **contexttype** | **String**| The type of the context of the interactions to return. | [optional]
 **contextid** | [**UUID**](.md)| The id of the context of the interactions to return. | [optional]
 **types** | **String**| The  comma separated types of the interactions to return. | [optional]
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]
 **orderdescending** | **Boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional]

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

<a name="interactionGet"></a>
# **interactionGet**
> interactionGet(id, thumbnailmediasize, photosize)

View an interaction

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.InteractionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    InteractionApi apiInstance = new InteractionApi(defaultClient);
    String id = "id_example"; // String | The id of the interaction.
    Integer thumbnailmediasize = 56; // Integer | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.interactionGet(id, thumbnailmediasize, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling InteractionApi#interactionGet");
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
 **id** | **String**| The id of the interaction. |
 **thumbnailmediasize** | **Integer**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional]
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

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

<a name="interactionListprivatesummary"></a>
# **interactionListprivatesummary**
> interactionListprivatesummary(photosize, showdefaultphoto)

Get current user&#39;s latest private interactions

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.InteractionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    InteractionApi apiInstance = new InteractionApi(defaultClient);
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    Boolean showdefaultphoto = true; // Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
    try {
      apiInstance.interactionListprivatesummary(photosize, showdefaultphoto);
    } catch (ApiException e) {
      System.err.println("Exception when calling InteractionApi#interactionListprivatesummary");
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
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]

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

<a name="interactionSave"></a>
# **interactionSave**
> interactionSave(id, UNKNOWN_BASE_TYPE)

Save an interaction

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.InteractionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    InteractionApi apiInstance = new InteractionApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the interaction to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.interactionSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling InteractionApi#interactionSave");
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
 **id** | [**UUID**](.md)| The id of the interaction to save (leave empty to create a new one). |
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

