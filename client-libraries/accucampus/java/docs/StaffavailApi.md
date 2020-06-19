# StaffavailApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**staffavailAddmetoallservices**](StaffavailApi.md#staffavailAddmetoallservices) | **GET** /staffavail/addmetoallservices | Associate current user to all services
[**staffavailAddmetoservice**](StaffavailApi.md#staffavailAddmetoservice) | **GET** /staffavail/addmetoservice | Associate current user to a service
[**staffavailAddusertoallservices**](StaffavailApi.md#staffavailAddusertoallservices) | **GET** /staffavail/addusertoallservices | Associate a staff member to all services
[**staffavailAddusertoservice**](StaffavailApi.md#staffavailAddusertoservice) | **GET** /staffavail/addusertoservice | Associate a staff member to a service
[**staffavailGetmyservices**](StaffavailApi.md#staffavailGetmyservices) | **GET** /staffavail/getmyservices | View the services the current user is available for
[**staffavailGetservices**](StaffavailApi.md#staffavailGetservices) | **GET** /staffavail/getservices | View a list of services that a staff member is available for
[**staffavailGetusersforservice**](StaffavailApi.md#staffavailGetusersforservice) | **GET** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
[**staffavailListtypes**](StaffavailApi.md#staffavailListtypes) | **GET** /staffavail/listtypes | View all the availability types
[**staffavailRemovemefromallservices**](StaffavailApi.md#staffavailRemovemefromallservices) | **GET** /staffavail/removemefromallservices | Remove current user from all services
[**staffavailRemovemefromservice**](StaffavailApi.md#staffavailRemovemefromservice) | **GET** /staffavail/removemefromservice | Remove current user from a service
[**staffavailRemoveuserfromallservices**](StaffavailApi.md#staffavailRemoveuserfromallservices) | **GET** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
[**staffavailRemoveuserfromservice**](StaffavailApi.md#staffavailRemoveuserfromservice) | **GET** /staffavail/removeuserfromservice | Remove a staff member from a service
[**staffavailSetavailability**](StaffavailApi.md#staffavailSetavailability) | **GET** /staffavail/setavailability | Make a staff member available for a specific availability type
[**staffavailSetmyavailability**](StaffavailApi.md#staffavailSetmyavailability) | **GET** /staffavail/setmyavailability | Change current user&#39;s availability type


<a name="staffavailAddmetoallservices"></a>
# **staffavailAddmetoallservices**
> staffavailAddmetoallservices()

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    try {
      apiInstance.staffavailAddmetoallservices();
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailAddmetoallservices");
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

<a name="staffavailAddmetoservice"></a>
# **staffavailAddmetoservice**
> staffavailAddmetoservice(serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID serviceid = new UUID(); // UUID | The id of the service.
    try {
      apiInstance.staffavailAddmetoservice(serviceid);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailAddmetoservice");
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
 **serviceid** | [**UUID**](.md)| The id of the service. |

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

<a name="staffavailAddusertoallservices"></a>
# **staffavailAddusertoallservices**
> staffavailAddusertoallservices(userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to add.
    try {
      apiInstance.staffavailAddusertoallservices(userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailAddusertoallservices");
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
 **userid** | [**UUID**](.md)| The id of the user to add. |

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

<a name="staffavailAddusertoservice"></a>
# **staffavailAddusertoservice**
> staffavailAddusertoservice(userid, serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to add.
    UUID serviceid = new UUID(); // UUID | The id of the service.
    try {
      apiInstance.staffavailAddusertoservice(userid, serviceid);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailAddusertoservice");
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
 **userid** | [**UUID**](.md)| The id of the user to add. |
 **serviceid** | [**UUID**](.md)| The id of the service. |

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

<a name="staffavailGetmyservices"></a>
# **staffavailGetmyservices**
> staffavailGetmyservices()

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    try {
      apiInstance.staffavailGetmyservices();
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailGetmyservices");
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

<a name="staffavailGetservices"></a>
# **staffavailGetservices**
> staffavailGetservices(userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID userid = new UUID(); // UUID | The user id to list services.
    try {
      apiInstance.staffavailGetservices(userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailGetservices");
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
 **userid** | [**UUID**](.md)| The user id to list services. |

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

<a name="staffavailGetusersforservice"></a>
# **staffavailGetusersforservice**
> staffavailGetusersforservice(serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID serviceid = new UUID(); // UUID | The service id to list users.
    try {
      apiInstance.staffavailGetusersforservice(serviceid);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailGetusersforservice");
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
 **serviceid** | [**UUID**](.md)| The service id to list users. |

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

<a name="staffavailListtypes"></a>
# **staffavailListtypes**
> staffavailListtypes()

View all the availability types

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    try {
      apiInstance.staffavailListtypes();
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailListtypes");
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

<a name="staffavailRemovemefromallservices"></a>
# **staffavailRemovemefromallservices**
> staffavailRemovemefromallservices()

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    try {
      apiInstance.staffavailRemovemefromallservices();
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailRemovemefromallservices");
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

<a name="staffavailRemovemefromservice"></a>
# **staffavailRemovemefromservice**
> staffavailRemovemefromservice(serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID serviceid = new UUID(); // UUID | The id of the service.
    try {
      apiInstance.staffavailRemovemefromservice(serviceid);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailRemovemefromservice");
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
 **serviceid** | [**UUID**](.md)| The id of the service. |

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

<a name="staffavailRemoveuserfromallservices"></a>
# **staffavailRemoveuserfromallservices**
> staffavailRemoveuserfromallservices(userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member&#39;s availability to all services.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    try {
      apiInstance.staffavailRemoveuserfromallservices(userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailRemoveuserfromallservices");
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
 **userid** | [**UUID**](.md)| The id of the user to remove. |

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

<a name="staffavailRemoveuserfromservice"></a>
# **staffavailRemoveuserfromservice**
> staffavailRemoveuserfromservice(userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member&#39;s service availability.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    UUID serviceid = new UUID(); // UUID | The id of the service.
    try {
      apiInstance.staffavailRemoveuserfromservice(userid, serviceid);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailRemoveuserfromservice");
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
 **userid** | [**UUID**](.md)| The id of the user to remove. |
 **serviceid** | [**UUID**](.md)| The id of the service. |

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

<a name="staffavailSetavailability"></a>
# **staffavailSetavailability**
> staffavailSetavailability(userid, availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user whose specific availability has to be set.
    String availablefor = "availablefor_example"; // String | Specific availability to set.
    try {
      apiInstance.staffavailSetavailability(userid, availablefor);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailSetavailability");
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
 **userid** | [**UUID**](.md)| The id of the user whose specific availability has to be set. |
 **availablefor** | **String**| Specific availability to set. | [optional]

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

<a name="staffavailSetmyavailability"></a>
# **staffavailSetmyavailability**
> staffavailSetmyavailability(availablefor)

Change current user&#39;s availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.StaffavailApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    StaffavailApi apiInstance = new StaffavailApi(defaultClient);
    String availablefor = "availablefor_example"; // String | Specific availability to set.
    try {
      apiInstance.staffavailSetmyavailability(availablefor);
    } catch (ApiException e) {
      System.err.println("Exception when calling StaffavailApi#staffavailSetmyavailability");
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
 **availablefor** | **String**| Specific availability to set. | [optional]

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

