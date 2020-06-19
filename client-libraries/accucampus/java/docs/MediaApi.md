# MediaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mediaCheckin**](MediaApi.md#mediaCheckin) | **GET** /media/checkin | Check in media item
[**mediaCheckout**](MediaApi.md#mediaCheckout) | **GET** /media/checkout | Check out media item
[**mediaCheckoutlist**](MediaApi.md#mediaCheckoutlist) | **GET** /media/checkoutlist | View a list of past media checkouts
[**mediaDelete**](MediaApi.md#mediaDelete) | **DELETE** /media/{id} | Delete a media item
[**mediaDeletecheckoutlog**](MediaApi.md#mediaDeletecheckoutlog) | **DELETE** /media/deletecheckoutlog | Delete a media checkout log
[**mediaGet**](MediaApi.md#mediaGet) | **GET** /media/{id} | Search and view details of a media item
[**mediaGetbycode**](MediaApi.md#mediaGetbycode) | **GET** /media/getbycode | Search media item by unique code
[**mediaGetcheckout**](MediaApi.md#mediaGetcheckout) | **GET** /media/getcheckout | View details of a media item checkout information
[**mediaGetcheckoutlog**](MediaApi.md#mediaGetcheckoutlog) | **GET** /media/getcheckoutlog | View details of a media checkout log
[**mediaList**](MediaApi.md#mediaList) | **GET** /media/list | View a list of media items
[**mediaSave**](MediaApi.md#mediaSave) | **POST** /media/{id} | Create or edit a media item


<a name="mediaCheckin"></a>
# **mediaCheckin**
> mediaCheckin(media, checkindate, notes)

Check in media item

Allows the user to check in a media item.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    UUID media = new UUID(); // UUID | The id of the media item to checkin.
    OffsetDateTime checkindate = new OffsetDateTime(); // OffsetDateTime | The checkout date.
    String notes = "notes_example"; // String | The notes of the checkout.
    try {
      apiInstance.mediaCheckin(media, checkindate, notes);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaCheckin");
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
 **media** | [**UUID**](.md)| The id of the media item to checkin. |
 **checkindate** | **OffsetDateTime**| The checkout date. |
 **notes** | **String**| The notes of the checkout. | [optional]

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

<a name="mediaCheckout"></a>
# **mediaCheckout**
> mediaCheckout(media, user, checkoutdate, duedate, staff, event, notes)

Check out media item

Allows the user to check out a media item.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    UUID media = new UUID(); // UUID | The id of the media item to checkout.
    UUID user = new UUID(); // UUID | The id of the user that is checking the item out.
    OffsetDateTime checkoutdate = new OffsetDateTime(); // OffsetDateTime | The checkout date.
    OffsetDateTime duedate = new OffsetDateTime(); // OffsetDateTime | The date when the checkout is due.
    UUID staff = new UUID(); // UUID | The id of the staff member related to the checkout.
    UUID event = new UUID(); // UUID | The id of the event related to the checkout.
    String notes = "notes_example"; // String | The notes of the checkout.
    try {
      apiInstance.mediaCheckout(media, user, checkoutdate, duedate, staff, event, notes);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaCheckout");
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
 **media** | [**UUID**](.md)| The id of the media item to checkout. |
 **user** | [**UUID**](.md)| The id of the user that is checking the item out. |
 **checkoutdate** | **OffsetDateTime**| The checkout date. |
 **duedate** | **OffsetDateTime**| The date when the checkout is due. |
 **staff** | [**UUID**](.md)| The id of the staff member related to the checkout. | [optional]
 **event** | [**UUID**](.md)| The id of the event related to the checkout. | [optional]
 **notes** | **String**| The notes of the checkout. | [optional]

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

<a name="mediaCheckoutlist"></a>
# **mediaCheckoutlist**
> mediaCheckoutlist(from, count, media, user, photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID media = new UUID(); // UUID | Used to filter the checkouts of a specific media item.
    UUID user = new UUID(); // UUID | Used to filter the checkouts made by a specific user.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.mediaCheckoutlist(from, count, media, user, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaCheckoutlist");
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
 **media** | [**UUID**](.md)| Used to filter the checkouts of a specific media item. | [optional]
 **user** | [**UUID**](.md)| Used to filter the checkouts made by a specific user. | [optional]
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

<a name="mediaDelete"></a>
# **mediaDelete**
> mediaDelete(id, body)

Delete a media item

Allows the user to delete an existing media item.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the media item to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.mediaDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaDelete");
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
 **id** | [**UUID**](.md)| The id of the media item to delete. |
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

<a name="mediaDeletecheckoutlog"></a>
# **mediaDeletecheckoutlog**
> mediaDeletecheckoutlog(UNKNOWN_BASE_TYPE)

Delete a media checkout log

Allows the user to delete a media item&#39;s checkout log.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.mediaDeletecheckoutlog(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaDeletecheckoutlog");
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

<a name="mediaGet"></a>
# **mediaGet**
> mediaGet(id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the media item to get.
    try {
      apiInstance.mediaGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaGet");
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
 **id** | [**UUID**](.md)| The id of the media item to get. |

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

<a name="mediaGetbycode"></a>
# **mediaGetbycode**
> mediaGetbycode(code, location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    String code = "code_example"; // String | The code of the media item to get.
    UUID location = new UUID(); // UUID | The location where to look for the media item.
    try {
      apiInstance.mediaGetbycode(code, location);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaGetbycode");
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
 **code** | **String**| The code of the media item to get. |
 **location** | [**UUID**](.md)| The location where to look for the media item. | [optional]

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

<a name="mediaGetcheckout"></a>
# **mediaGetcheckout**
> mediaGetcheckout(id, photosize)

View details of a media item checkout information

Allows the user to view a media item&#39;s checkout information.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the media item whose checkout information has to be retrieved.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.mediaGetcheckout(id, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaGetcheckout");
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
 **id** | [**UUID**](.md)| The id of the media item whose checkout information has to be retrieved. |
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

<a name="mediaGetcheckoutlog"></a>
# **mediaGetcheckoutlog**
> mediaGetcheckoutlog(id, photosize)

View details of a media checkout log

Allows the user to view a media item&#39;s checkout history.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the media item whose checkout information has to be retrieved.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.mediaGetcheckoutlog(id, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaGetcheckoutlog");
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
 **id** | [**UUID**](.md)| The id of the media item whose checkout information has to be retrieved. |
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

<a name="mediaList"></a>
# **mediaList**
> mediaList(from, count, status, user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    Integer status = 56; // Integer | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
    UUID user = new UUID(); // UUID | Used to filter the media items that are checked-out by a specific user.
    try {
      apiInstance.mediaList(from, count, status, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaList");
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
 **status** | **Integer**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional]
 **user** | [**UUID**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional]

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

<a name="mediaSave"></a>
# **mediaSave**
> mediaSave(id, UNKNOWN_BASE_TYPE)

Create or edit a media item

Allows the user to create or edit a media item.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MediaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MediaApi apiInstance = new MediaApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the media item save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.mediaSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling MediaApi#mediaSave");
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
 **id** | [**UUID**](.md)| The id of the media item save (leave empty to create a new one). |
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

