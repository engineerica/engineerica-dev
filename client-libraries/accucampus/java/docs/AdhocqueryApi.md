# AdhocqueryApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocqueryCheckexecution**](AdhocqueryApi.md#adhocqueryCheckexecution) | **GET** /adhocquery/checkexecution | Check the status of an ad hoc query execution
[**adhocqueryDelete**](AdhocqueryApi.md#adhocqueryDelete) | **DELETE** /adhocquery/{id} | Delete an ad hoc query
[**adhocqueryExecute**](AdhocqueryApi.md#adhocqueryExecute) | **GET** /adhocquery/execute | Execute an ad hoc query
[**adhocqueryGet**](AdhocqueryApi.md#adhocqueryGet) | **GET** /adhocquery/{id} | View details of an ad hoc query
[**adhocqueryGetschema**](AdhocqueryApi.md#adhocqueryGetschema) | **GET** /adhocquery/getschema | View the database schema for making ad hoc queries
[**adhocqueryList**](AdhocqueryApi.md#adhocqueryList) | **GET** /adhocquery/list | View a list of saved ad hoc queries
[**adhocqueryListexecutions**](AdhocqueryApi.md#adhocqueryListexecutions) | **GET** /adhocquery/listexecutions | View a list of ad hoc queries executions
[**adhocquerySave**](AdhocqueryApi.md#adhocquerySave) | **POST** /adhocquery/{id} | Create or edit an ad hoc query
[**adhocqueryStopexecution**](AdhocqueryApi.md#adhocqueryStopexecution) | **GET** /adhocquery/stopexecution | Stops the execution of an ad hoc query


<a name="adhocqueryCheckexecution"></a>
# **adhocqueryCheckexecution**
> adhocqueryCheckexecution(id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query&#39;s execution page.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the ad hoc query execution to be checked.
    try {
      apiInstance.adhocqueryCheckexecution(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocqueryCheckexecution");
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
 **id** | [**UUID**](.md)| The id of the ad hoc query execution to be checked. |

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

<a name="adhocqueryDelete"></a>
# **adhocqueryDelete**
> adhocqueryDelete(id, body)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the ad hoc query to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.adhocqueryDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocqueryDelete");
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
 **id** | [**UUID**](.md)| The id of the ad hoc query to delete. |
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

<a name="adhocqueryExecute"></a>
# **adhocqueryExecute**
> adhocqueryExecute(id, query)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the query to execute.
    String query = "query_example"; // String | The query to execute.
    try {
      apiInstance.adhocqueryExecute(id, query);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocqueryExecute");
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
 **id** | [**UUID**](.md)| The id of the query to execute. | [optional]
 **query** | **String**| The query to execute. | [optional]

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

<a name="adhocqueryGet"></a>
# **adhocqueryGet**
> adhocqueryGet(id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the query to get.
    try {
      apiInstance.adhocqueryGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocqueryGet");
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
 **id** | [**UUID**](.md)| The id of the query to get. |

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

<a name="adhocqueryGetschema"></a>
# **adhocqueryGetschema**
> adhocqueryGetschema()

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    try {
      apiInstance.adhocqueryGetschema();
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocqueryGetschema");
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

<a name="adhocqueryList"></a>
# **adhocqueryList**
> adhocqueryList(from, count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.adhocqueryList(from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocqueryList");
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

<a name="adhocqueryListexecutions"></a>
# **adhocqueryListexecutions**
> adhocqueryListexecutions(from, count, query)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID query = new UUID(); // UUID | The first record to return.
    try {
      apiInstance.adhocqueryListexecutions(from, count, query);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocqueryListexecutions");
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
 **query** | [**UUID**](.md)| The first record to return. | [optional]

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

<a name="adhocquerySave"></a>
# **adhocquerySave**
> adhocquerySave(id, UNKNOWN_BASE_TYPE)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the query to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.adhocquerySave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocquerySave");
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
 **id** | [**UUID**](.md)| The id of the query to save (leave empty to create a new one). |
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

<a name="adhocqueryStopexecution"></a>
# **adhocqueryStopexecution**
> adhocqueryStopexecution(id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocqueryApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocqueryApi apiInstance = new AdhocqueryApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the ad hoc query execution to be stopped.
    try {
      apiInstance.adhocqueryStopexecution(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocqueryApi#adhocqueryStopexecution");
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
 **id** | [**UUID**](.md)| The id of the ad hoc query execution to be stopped. |

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

