# ReportApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reportAttanalyticsprepare**](ReportApi.md#reportAttanalyticsprepare) | **GET** /report/attanalyticsprepare | Query and load an attendance analytics report
[**reportList**](ReportApi.md#reportList) | **GET** /report/list | View a list of available reports
[**reportPermissionsbyuser**](ReportApi.md#reportPermissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
[**reportPrepare**](ReportApi.md#reportPrepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
[**reportQuery**](ReportApi.md#reportQuery) | **GET** /report/query | Query and load a specified report
[**reportTagresults**](ReportApi.md#reportTagresults) | **GET** /report/tagresults | Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.


<a name="reportAttanalyticsprepare"></a>
# **reportAttanalyticsprepare**
> reportAttanalyticsprepare(reportname, params, refreshgroup)

Query and load an attendance analytics report

Allows the user to query and load attendance analytics reports.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportApi apiInstance = new ReportApi(defaultClient);
    String reportname = "reportname_example"; // String | The name of the report to execute
    String params = "params_example"; // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
    UUID refreshgroup = new UUID(); // UUID | The ID of the group to check (and refresh) before processing the report.
    try {
      apiInstance.reportAttanalyticsprepare(reportname, params, refreshgroup);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportApi#reportAttanalyticsprepare");
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
 **reportname** | **String**| The name of the report to execute |
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **refreshgroup** | [**UUID**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional]

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

<a name="reportList"></a>
# **reportList**
> reportList()

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportApi apiInstance = new ReportApi(defaultClient);
    try {
      apiInstance.reportList();
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportApi#reportList");
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

<a name="reportPermissionsbyuser"></a>
# **reportPermissionsbyuser**
> reportPermissionsbyuser(params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportApi apiInstance = new ReportApi(defaultClient);
    String params = "params_example"; // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
    try {
      apiInstance.reportPermissionsbyuser(params);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportApi#reportPermissionsbyuser");
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
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

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

<a name="reportPrepare"></a>
# **reportPrepare**
> reportPrepare(reportname, params, repformat, fillgroupid, groupby, refreshgroup, filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportApi apiInstance = new ReportApi(defaultClient);
    String reportname = "reportname_example"; // String | The name of the report to execute
    String params = "params_example"; // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
    String repformat = "repformat_example"; // String | The format of the resulting report. Json, pdf, csv, ...
    UUID fillgroupid = new UUID(); // UUID | If specified, the result is used to fill the group with the given ID
    String groupby = "groupby_example"; // String | How to group the records. In the format 'col1+col2|col3+col4
    UUID refreshgroup = new UUID(); // UUID | The ID of the group to check (and refresh) before processing the report.
    String filtertext = "filtertext_example"; // String | The user friendly text of the applied filters.
    try {
      apiInstance.reportPrepare(reportname, params, repformat, fillgroupid, groupby, refreshgroup, filtertext);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportApi#reportPrepare");
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
 **reportname** | **String**| The name of the report to execute |
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **repformat** | **String**| The format of the resulting report. Json, pdf, csv, ... | [optional]
 **fillgroupid** | [**UUID**](.md)| If specified, the result is used to fill the group with the given ID | [optional]
 **groupby** | **String**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional]
 **refreshgroup** | [**UUID**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional]
 **filtertext** | **String**| The user friendly text of the applied filters. | [optional]

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

<a name="reportQuery"></a>
# **reportQuery**
> reportQuery(reportname, params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportApi apiInstance = new ReportApi(defaultClient);
    String reportname = "reportname_example"; // String | The name of the report to execute
    String params = "params_example"; // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
    try {
      apiInstance.reportQuery(reportname, params);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportApi#reportQuery");
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
 **reportname** | **String**| The name of the report to execute |
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

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

<a name="reportTagresults"></a>
# **reportTagresults**
> reportTagresults(reportname, assign, tags, params)

Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.

Allows the user to use a report to assign or unassign tags.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportApi apiInstance = new ReportApi(defaultClient);
    String reportname = "reportname_example"; // String | The name of the report to execute
    Boolean assign = true; // Boolean | Specify whether the specified tags have to be assigned or unassigned.
    String tags = "tags_example"; // String | The tags to assign (or unassign) to the resulting users in the report, in JSON format.
    String params = "params_example"; // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
    try {
      apiInstance.reportTagresults(reportname, assign, tags, params);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportApi#reportTagresults");
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
 **reportname** | **String**| The name of the report to execute |
 **assign** | **Boolean**| Specify whether the specified tags have to be assigned or unassigned. |
 **tags** | **String**| The tags to assign (or unassign) to the resulting users in the report, in JSON format. |
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

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

