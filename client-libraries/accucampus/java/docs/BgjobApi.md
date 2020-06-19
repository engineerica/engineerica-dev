# BgjobApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bgjobGetstatus**](BgjobApi.md#bgjobGetstatus) | **GET** /bgjob/getstatus | Get background job status


<a name="bgjobGetstatus"></a>
# **bgjobGetstatus**
> bgjobGetstatus(jobid, jobtype)

Get background job status

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BgjobApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BgjobApi apiInstance = new BgjobApi(defaultClient);
    UUID jobid = new UUID(); // UUID | The ID of the job to get the status. 10 most recent will be returned if not specified.
    String jobtype = "jobtype_example"; // String | The job type to filter by.
    try {
      apiInstance.bgjobGetstatus(jobid, jobtype);
    } catch (ApiException e) {
      System.err.println("Exception when calling BgjobApi#bgjobGetstatus");
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
 **jobid** | [**UUID**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional]
 **jobtype** | **String**| The job type to filter by. | [optional]

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

