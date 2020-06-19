# AdvancedstationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advancedstationCheckunknownuser**](AdvancedstationApi.md#advancedstationCheckunknownuser) | **GET** /advancedstation/checkunknownuser | Check whether the user is known by the system.
[**advancedstationCheckuserrole**](AdvancedstationApi.md#advancedstationCheckuserrole) | **GET** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
[**advancedstationCreateuser**](AdvancedstationApi.md#advancedstationCreateuser) | **GET** /advancedstation/createuser | Creates a user via a sign-in station.
[**advancedstationGetevents**](AdvancedstationApi.md#advancedstationGetevents) | **GET** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
[**advancedstationGetinfo**](AdvancedstationApi.md#advancedstationGetinfo) | **GET** /advancedstation/getinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**advancedstationGetlocations**](AdvancedstationApi.md#advancedstationGetlocations) | **GET** /advancedstation/getlocations | Gets the locations available in a sign-in station.
[**advancedstationGetlogstaff**](AdvancedstationApi.md#advancedstationGetlogstaff) | **GET** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**advancedstationGetroles**](AdvancedstationApi.md#advancedstationGetroles) | **GET** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
[**advancedstationGetservices**](AdvancedstationApi.md#advancedstationGetservices) | **GET** /advancedstation/getservices | Gets the services available for a specific location.
[**advancedstationGetstaff**](AdvancedstationApi.md#advancedstationGetstaff) | **GET** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
[**advancedstationIssignedin**](AdvancedstationApi.md#advancedstationIssignedin) | **GET** /advancedstation/issignedin | Gets whether a user is signed-in or not.


<a name="advancedstationCheckunknownuser"></a>
# **advancedstationCheckunknownuser**
> advancedstationCheckunknownuser(station, user, location)

Check whether the user is known by the system.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    String user = "user_example"; // String | The card of the user.
    UUID location = new UUID(); // UUID | The id of the location the user picked.
    try {
      apiInstance.advancedstationCheckunknownuser(station, user, location);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationCheckunknownuser");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **user** | **String**| The card of the user. |
 **location** | [**UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationCheckuserrole"></a>
# **advancedstationCheckuserrole**
> advancedstationCheckuserrole(station, user, location)

Check whether the user is a staff member, an attendee or both.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    String user = "user_example"; // String | The card of the user.
    UUID location = new UUID(); // UUID | The id of the location the user picked.
    try {
      apiInstance.advancedstationCheckuserrole(station, user, location);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationCheckuserrole");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **user** | **String**| The card of the user. |
 **location** | [**UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationCreateuser"></a>
# **advancedstationCreateuser**
> advancedstationCreateuser(station, user, location, firstname, lastname, email, middlename)

Creates a user via a sign-in station.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    String user = "user_example"; // String | The card of the user to create.
    UUID location = new UUID(); // UUID | The id of the location the user picked.
    String firstname = "firstname_example"; // String | The first name of the user to create.
    String lastname = "lastname_example"; // String | The last name of the user to create.
    String email = "email_example"; // String | The email of the user to create.
    String middlename = "middlename_example"; // String | The middle name of the user to create.
    try {
      apiInstance.advancedstationCreateuser(station, user, location, firstname, lastname, email, middlename);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationCreateuser");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **user** | **String**| The card of the user to create. |
 **location** | [**UUID**](.md)| The id of the location the user picked. |
 **firstname** | **String**| The first name of the user to create. |
 **lastname** | **String**| The last name of the user to create. |
 **email** | **String**| The email of the user to create. |
 **middlename** | **String**| The middle name of the user to create. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationGetevents"></a>
# **advancedstationGetevents**
> advancedstationGetevents(station, location, user)

Gets the courses available for a specific location and a specific student.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    UUID location = new UUID(); // UUID | The id of the location the student picked.
    String user = "user_example"; // String | The card of the user.
    try {
      apiInstance.advancedstationGetevents(station, location, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationGetevents");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **location** | [**UUID**](.md)| The id of the location the student picked. |
 **user** | **String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationGetinfo"></a>
# **advancedstationGetinfo**
> advancedstationGetinfo(id, event)

Gets the info to display in the sign-in station by it&#39;s ID.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the sign-in station to get.
    UUID event = new UUID(); // UUID | The id of the event (or session), to override the scheduled one.
    try {
      apiInstance.advancedstationGetinfo(id, event);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationGetinfo");
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
 **id** | [**UUID**](.md)| The id of the sign-in station to get. |
 **event** | [**UUID**](.md)| The id of the event (or session), to override the scheduled one. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationGetlocations"></a>
# **advancedstationGetlocations**
> advancedstationGetlocations(station, user)

Gets the locations available in a sign-in station.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station whose locations have to be returned.
    String user = "user_example"; // String | The card of the user.
    try {
      apiInstance.advancedstationGetlocations(station, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationGetlocations");
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
 **station** | [**UUID**](.md)| The id of the sign-in station whose locations have to be returned. |
 **user** | **String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationGetlogstaff"></a>
# **advancedstationGetlogstaff**
> advancedstationGetlogstaff(station, attendancelog, photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    UUID attendancelog = new UUID(); // UUID | The id of the attendance log to filter the staff members.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.advancedstationGetlogstaff(station, attendancelog, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationGetlogstaff");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **attendancelog** | [**UUID**](.md)| The id of the attendance log to filter the staff members. |
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationGetroles"></a>
# **advancedstationGetroles**
> advancedstationGetroles(station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    String signinrole = "signinrole_example"; // String | Specifies how the user is signing-in.
    String user = "user_example"; // String | The card of the user.
    UUID location = new UUID(); // UUID | The id of the location the user picked.
    try {
      apiInstance.advancedstationGetroles(station, signinrole, user, location);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationGetroles");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **signinrole** | **String**| Specifies how the user is signing-in. |
 **user** | **String**| The card of the user. |
 **location** | [**UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationGetservices"></a>
# **advancedstationGetservices**
> advancedstationGetservices(station, location, user)

Gets the services available for a specific location.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    UUID location = new UUID(); // UUID | The id of the location the student picked.
    String user = "user_example"; // String | The card of the user.
    try {
      apiInstance.advancedstationGetservices(station, location, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationGetservices");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **location** | [**UUID**](.md)| The id of the location the student picked. |
 **user** | **String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationGetstaff"></a>
# **advancedstationGetstaff**
> advancedstationGetstaff(station, locationid, user, services, eventid, photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    UUID locationid = new UUID(); // UUID | The id of the location the student picked.
    String user = "user_example"; // String | The card of the user.
    String services = "services_example"; // String | The list of services selected by the user, in JSON format.
    UUID eventid = new UUID(); // UUID | The ID of the event selected.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.advancedstationGetstaff(station, locationid, user, services, eventid, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationGetstaff");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **locationid** | [**UUID**](.md)| The id of the location the student picked. |
 **user** | **String**| The card of the user. |
 **services** | **String**| The list of services selected by the user, in JSON format. | [optional]
 **eventid** | [**UUID**](.md)| The ID of the event selected. | [optional]
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advancedstationIssignedin"></a>
# **advancedstationIssignedin**
> advancedstationIssignedin(station, time, user, location)

Gets whether a user is signed-in or not.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvancedstationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AdvancedstationApi apiInstance = new AdvancedstationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    OffsetDateTime time = new OffsetDateTime(); // OffsetDateTime | The date and time of the swipe.
    String user = "user_example"; // String | The card of the user.
    UUID location = new UUID(); // UUID | The id of the location the user picked.
    try {
      apiInstance.advancedstationIssignedin(station, time, user, location);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvancedstationApi#advancedstationIssignedin");
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
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **time** | **OffsetDateTime**| The date and time of the swipe. |
 **user** | **String**| The card of the user. |
 **location** | [**UUID**](.md)| The id of the location the user picked. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

