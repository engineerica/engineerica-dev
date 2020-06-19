# AdhocreportsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocreportsReqaccess**](AdhocreportsApi.md#adhocreportsReqaccess) | **GET** /adhocreports/reqaccess | Request access to the ad-hoc reports


<a name="adhocreportsReqaccess"></a>
# **adhocreportsReqaccess**
> adhocreportsReqaccess()

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, &#39;Request Access&#39; under Institutional Research -&gt; Ad-hoc Reports

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdhocreportsApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdhocreportsApi apiInstance = new AdhocreportsApi(defaultClient);
    try {
      apiInstance.adhocreportsReqaccess();
    } catch (ApiException e) {
      System.err.println("Exception when calling AdhocreportsApi#adhocreportsReqaccess");
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

