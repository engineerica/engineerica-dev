# BeaconApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**beaconDelete**](BeaconApi.md#beaconDelete) | **DELETE** /beacon/{id} | Delete a beacon profile
[**beaconDisable**](BeaconApi.md#beaconDisable) | **GET** /beacon/disable | Disable beacon support account wide
[**beaconGet**](BeaconApi.md#beaconGet) | **GET** /beacon/{id} | View details of a beacon profile
[**beaconGetlocations**](BeaconApi.md#beaconGetlocations) | **GET** /beacon/getlocations | Get the sign-in stations assigned to specific beacons.
[**beaconGetstationlocation**](BeaconApi.md#beaconGetstationlocation) | **GET** /beacon/getstationlocation | Get the location settings in the specified sign-in station.
[**beaconGetuuid**](BeaconApi.md#beaconGetuuid) | **GET** /beacon/getuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**beaconList**](BeaconApi.md#beaconList) | **GET** /beacon/list | View a list of beacon profiles
[**beaconListprofiles**](BeaconApi.md#beaconListprofiles) | **GET** /beacon/listprofiles | View a list of beacon profiles with their characteristics
[**beaconResetuuid**](BeaconApi.md#beaconResetuuid) | **GET** /beacon/resetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**beaconSave**](BeaconApi.md#beaconSave) | **POST** /beacon/{id} | Create or edit a beacon profile
[**beaconScanlocations**](BeaconApi.md#beaconScanlocations) | **GET** /beacon/scanlocations | Check if there&#39;s location available to sign-in / out.
[**beaconSetuuid**](BeaconApi.md#beaconSetuuid) | **GET** /beacon/setuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**beaconSilentregions**](BeaconApi.md#beaconSilentregions) | **GET** /beacon/silentregions | View all the beacon regions defined for silent tracking
[**beaconSilentsignin**](BeaconApi.md#beaconSilentsignin) | **GET** /beacon/silentsignin | Sign-in silently from the location specified by a beacon
[**beaconSilentsignout**](BeaconApi.md#beaconSilentsignout) | **GET** /beacon/silentsignout | Sign-out silently from the location specified by a beacon


<a name="beaconDelete"></a>
# **beaconDelete**
> beaconDelete(id, body)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the beacon to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.beaconDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconDelete");
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
 **id** | [**UUID**](.md)| The id of the beacon to delete. |
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

<a name="beaconDisable"></a>
# **beaconDisable**
> beaconDisable()

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    try {
      apiInstance.beaconDisable();
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconDisable");
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

<a name="beaconGet"></a>
# **beaconGet**
> beaconGet(id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the beacon to get.
    try {
      apiInstance.beaconGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconGet");
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
 **id** | [**UUID**](.md)| The id of the beacon to get. |

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

<a name="beaconGetlocations"></a>
# **beaconGetlocations**
> beaconGetlocations(beacons)

Get the sign-in stations assigned to specific beacons.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    String beacons = "beacons_example"; // String | A JSON array containg the beacons data (region, minor and major) values.
    try {
      apiInstance.beaconGetlocations(beacons);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconGetlocations");
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
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. |

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

<a name="beaconGetstationlocation"></a>
# **beaconGetstationlocation**
> beaconGetstationlocation(station, location)

Get the location settings in the specified sign-in station.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station whose location information has to be retrieved.
    UUID location = new UUID(); // UUID | The id of the location whose information has to be retrieved.
    try {
      apiInstance.beaconGetstationlocation(station, location);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconGetstationlocation");
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
 **station** | [**UUID**](.md)| The id of the sign-in station whose location information has to be retrieved. |
 **location** | [**UUID**](.md)| The id of the location whose information has to be retrieved. |

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

<a name="beaconGetuuid"></a>
# **beaconGetuuid**
> beaconGetuuid()

View the identifier for the account&#39;s beacon region (for sign-in stations).

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    try {
      apiInstance.beaconGetuuid();
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconGetuuid");
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

<a name="beaconList"></a>
# **beaconList**
> beaconList(from, count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.beaconList(from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconList");
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

<a name="beaconListprofiles"></a>
# **beaconListprofiles**
> beaconListprofiles()

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    try {
      apiInstance.beaconListprofiles();
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconListprofiles");
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

<a name="beaconResetuuid"></a>
# **beaconResetuuid**
> beaconResetuuid()

Generate or reset the identifier for the account&#39;s beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    try {
      apiInstance.beaconResetuuid();
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconResetuuid");
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

<a name="beaconSave"></a>
# **beaconSave**
> beaconSave(id, UNKNOWN_BASE_TYPE)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the beacon save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.beaconSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconSave");
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
 **id** | [**UUID**](.md)| The id of the beacon save (leave empty to create a new one). |
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

<a name="beaconScanlocations"></a>
# **beaconScanlocations**
> beaconScanlocations(beacons)

Check if there&#39;s location available to sign-in / out.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    String beacons = "beacons_example"; // String | A JSON array containg the beacons data (region, minor and major) values.
    try {
      apiInstance.beaconScanlocations(beacons);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconScanlocations");
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
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. |

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

<a name="beaconSetuuid"></a>
# **beaconSetuuid**
> beaconSetuuid(id)

Set the identifier for the account&#39;s beacon region (for sign-in stations).

Allows the user to set the identifier for the account&#39;s beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    UUID id = new UUID(); // UUID | The custom region UUID.
    try {
      apiInstance.beaconSetuuid(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconSetuuid");
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
 **id** | [**UUID**](.md)| The custom region UUID. |

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

<a name="beaconSilentregions"></a>
# **beaconSilentregions**
> beaconSilentregions()

View all the beacon regions defined for silent tracking

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    try {
      apiInstance.beaconSilentregions();
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconSilentregions");
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

<a name="beaconSilentsignin"></a>
# **beaconSilentsignin**
> beaconSilentsignin(uuid)

Sign-in silently from the location specified by a beacon

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    UUID uuid = new UUID(); // UUID | The id of the region the user is in.
    try {
      apiInstance.beaconSilentsignin(uuid);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconSilentsignin");
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
 **uuid** | [**UUID**](.md)| The id of the region the user is in. |

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

<a name="beaconSilentsignout"></a>
# **beaconSilentsignout**
> beaconSilentsignout(uuid)

Sign-out silently from the location specified by a beacon

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.BeaconApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    BeaconApi apiInstance = new BeaconApi(defaultClient);
    UUID uuid = new UUID(); // UUID | The id of the region the user has left.
    try {
      apiInstance.beaconSilentsignout(uuid);
    } catch (ApiException e) {
      System.err.println("Exception when calling BeaconApi#beaconSilentsignout");
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
 **uuid** | [**UUID**](.md)| The id of the region the user has left. |

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

