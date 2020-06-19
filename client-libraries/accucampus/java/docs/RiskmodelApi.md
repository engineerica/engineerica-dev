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
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the risk assessment model whose analysis status has to be returned.
    try {
      apiInstance.riskmodelCheckanalysis(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelCheckanalysis");
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
 **id** | [**UUID**](.md)| The id of the risk assessment model whose analysis status has to be returned. |

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

<a name="riskmodelDelete"></a>
# **riskmodelDelete**
> riskmodelDelete(id, body)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the risk assessment model to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.riskmodelDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelDelete");
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
 **id** | [**UUID**](.md)| The id of the risk assessment model to delete. |
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

<a name="riskmodelGet"></a>
# **riskmodelGet**
> riskmodelGet(id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the risk assessment model to get.
    try {
      apiInstance.riskmodelGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelGet");
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
 **id** | [**UUID**](.md)| The id of the risk assessment model to get. |

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

<a name="riskmodelGetscore"></a>
# **riskmodelGetscore**
> riskmodelGetscore(userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to get the risk score.
    try {
      apiInstance.riskmodelGetscore(userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelGetscore");
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
 **userid** | [**UUID**](.md)| The id of the user to get the risk score. |

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

<a name="riskmodelList"></a>
# **riskmodelList**
> riskmodelList(from, count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.riskmodelList(from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelList");
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

<a name="riskmodelPredict"></a>
# **riskmodelPredict**
> riskmodelPredict(id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the assessment model to use in order to predict risk.
    try {
      apiInstance.riskmodelPredict(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelPredict");
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
 **id** | [**UUID**](.md)| The id of the assessment model to use in order to predict risk. |

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

<a name="riskmodelProcess"></a>
# **riskmodelProcess**
> riskmodelProcess(id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the risk assessment model to process.
    try {
      apiInstance.riskmodelProcess(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelProcess");
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
 **id** | [**UUID**](.md)| The id of the risk assessment model to process. |

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

<a name="riskmodelRefresh"></a>
# **riskmodelRefresh**
> riskmodelRefresh(id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the risk assessment model whose information has to be refreshed.
    try {
      apiInstance.riskmodelRefresh(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelRefresh");
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
 **id** | [**UUID**](.md)| The id of the risk assessment model whose information has to be refreshed. |

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

<a name="riskmodelSave"></a>
# **riskmodelSave**
> riskmodelSave(id, UNKNOWN_BASE_TYPE)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the department save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.riskmodelSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelSave");
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
 **id** | [**UUID**](.md)| The id of the department save (leave empty to create a new one). |
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

<a name="riskmodelTermprecedences"></a>
# **riskmodelTermprecedences**
> riskmodelTermprecedences()

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RiskmodelApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RiskmodelApi apiInstance = new RiskmodelApi(defaultClient);
    try {
      apiInstance.riskmodelTermprecedences();
    } catch (ApiException e) {
      System.err.println("Exception when calling RiskmodelApi#riskmodelTermprecedences");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters
This endpoint does not need any parameter.

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

