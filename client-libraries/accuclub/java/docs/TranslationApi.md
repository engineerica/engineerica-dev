# TranslationApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**translationGet**](TranslationApi.md#translationGet) | **GET** /translation/get | Gets the translations of the specified values
[**translationGetcachefile**](TranslationApi.md#translationGetcachefile) | **GET** /translation/getcachefile | Get the file containing the translations
[**translationList**](TranslationApi.md#translationList) | **GET** /translation/list | Lists all the available translations in the system
[**translationSave**](TranslationApi.md#translationSave) | **POST** /translation/{id} | Edit a translation


<a name="translationGet"></a>
# **translationGet**
> translationGet(universal)

Gets the translations of the specified values

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TranslationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TranslationApi apiInstance = new TranslationApi(defaultClient);
    String universal = "universal_example"; // String | Pipe separated list of universal text to be translated.
    try {
      apiInstance.translationGet(universal);
    } catch (ApiException e) {
      System.err.println("Exception when calling TranslationApi#translationGet");
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
 **universal** | **String**| Pipe separated list of universal text to be translated. |

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

<a name="translationGetcachefile"></a>
# **translationGetcachefile**
> translationGetcachefile(account)

Get the file containing the translations

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TranslationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TranslationApi apiInstance = new TranslationApi(defaultClient);
    String account = "account_example"; // String | The id of the account whose translations file has to be retrieved.
    try {
      apiInstance.translationGetcachefile(account);
    } catch (ApiException e) {
      System.err.println("Exception when calling TranslationApi#translationGetcachefile");
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
 **account** | **String**| The id of the account whose translations file has to be retrieved. | [optional]

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

<a name="translationList"></a>
# **translationList**
> translationList(filter, nondefaultonly, appdefaultasuniversal)

Lists all the available translations in the system

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TranslationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TranslationApi apiInstance = new TranslationApi(defaultClient);
    String filter = "filter_example"; // String | Text to search/filter translations.
    Boolean nondefaultonly = true; // Boolean | If true then it returns only the terms translated. Otherwise, it returns all.
    Boolean appdefaultasuniversal = true; // Boolean | If true then it uses the app default translation as the universal term.
    try {
      apiInstance.translationList(filter, nondefaultonly, appdefaultasuniversal);
    } catch (ApiException e) {
      System.err.println("Exception when calling TranslationApi#translationList");
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
 **filter** | **String**| Text to search/filter translations. | [optional]
 **nondefaultonly** | **Boolean**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional]
 **appdefaultasuniversal** | **Boolean**| If true then it uses the app default translation as the universal term. | [optional]

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

<a name="translationSave"></a>
# **translationSave**
> translationSave(id, UNKNOWN_BASE_TYPE)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.TranslationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    TranslationApi apiInstance = new TranslationApi(defaultClient);
    String id = "id_example"; // String | The id of the translation as returned by translation.list.
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.translationSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling TranslationApi#translationSave");
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
 **id** | **String**| The id of the translation as returned by translation.list. |
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

