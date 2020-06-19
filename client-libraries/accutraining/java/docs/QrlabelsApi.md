# QrlabelsApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrlabelsPrint**](QrlabelsApi.md#qrlabelsPrint) | **GET** /qrlabels/print | Print and email QR labels


<a name="qrlabelsPrint"></a>
# **qrlabelsPrint**
> qrlabelsPrint(user, group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.QrlabelsApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    QrlabelsApi apiInstance = new QrlabelsApi(defaultClient);
    UUID user = new UUID(); // UUID | The id of the user whose label needs to be printed.
    UUID group = new UUID(); // UUID | The id of the group whose members' labels need to be printed.
    try {
      apiInstance.qrlabelsPrint(user, group);
    } catch (ApiException e) {
      System.err.println("Exception when calling QrlabelsApi#qrlabelsPrint");
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
 **user** | [**UUID**](.md)| The id of the user whose label needs to be printed. | [optional]
 **group** | [**UUID**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional]

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

