# ScheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**scheduleDelete**](ScheduleApi.md#scheduleDelete) | **DELETE** /schedule/delete | Delete a schedule slot
[**scheduleDeletemine**](ScheduleApi.md#scheduleDeletemine) | **DELETE** /schedule/deletemine | Delete a specific block from a user&#39;s own schedule
[**scheduleEnable**](ScheduleApi.md#scheduleEnable) | **GET** /schedule/enable | Enable or disable the schedule for a specific person
[**scheduleEnablemine**](ScheduleApi.md#scheduleEnablemine) | **GET** /schedule/enablemine | Enable or disable current user&#39;s schedule
[**scheduleFindallstaffslots**](ScheduleApi.md#scheduleFindallstaffslots) | **GET** /schedule/findallstaffslots | Search available schedule slots by service, event, date
[**scheduleFindslots**](ScheduleApi.md#scheduleFindslots) | **GET** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
[**scheduleFindstaffavail**](ScheduleApi.md#scheduleFindstaffavail) | **GET** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
[**scheduleGet**](ScheduleApi.md#scheduleGet) | **GET** /schedule/get | Search and view details of a specific schedule slot
[**scheduleGetmine**](ScheduleApi.md#scheduleGetmine) | **GET** /schedule/getmine | View details of a specific schedule block, for current user
[**scheduleGetstaff**](ScheduleApi.md#scheduleGetstaff) | **GET** /schedule/getstaff | View a list of schedule information of a specified person
[**scheduleGetstaffmine**](ScheduleApi.md#scheduleGetstaffmine) | **GET** /schedule/getstaffmine | View current user&#39;s schedule information
[**scheduleMyofftimes**](ScheduleApi.md#scheduleMyofftimes) | **GET** /schedule/myofftimes | View current user&#39;s schedule exceptions
[**scheduleSave**](ScheduleApi.md#scheduleSave) | **POST** /schedule/save | Create or edit a schedule slot
[**scheduleSavemine**](ScheduleApi.md#scheduleSavemine) | **POST** /schedule/savemine | Create or edit a block in current user&#39;s schedule


<a name="scheduleDelete"></a>
# **scheduleDelete**
> scheduleDelete(UNKNOWN_BASE_TYPE)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.scheduleDelete(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleDelete");
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

<a name="scheduleDeletemine"></a>
# **scheduleDeletemine**
> scheduleDeletemine(UNKNOWN_BASE_TYPE)

Delete a specific block from a user&#39;s own schedule

Allows the user to delete a schedule block from their own availability.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.scheduleDeletemine(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleDeletemine");
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

<a name="scheduleEnable"></a>
# **scheduleEnable**
> scheduleEnable(userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to enable or disable the schedule.
    Boolean enable = true; // Boolean | True to enable schedules, false to disable.
    try {
      apiInstance.scheduleEnable(userid, enable);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleEnable");
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
 **userid** | [**UUID**](.md)| The id of the user to enable or disable the schedule. |
 **enable** | **Boolean**| True to enable schedules, false to disable. |

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

<a name="scheduleEnablemine"></a>
# **scheduleEnablemine**
> scheduleEnablemine(enable)

Enable or disable current user&#39;s schedule

Allows the user to enable or disable a schedule for himself.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    Boolean enable = true; // Boolean | True to enable schedules, false to disable.
    try {
      apiInstance.scheduleEnablemine(enable);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleEnablemine");
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
 **enable** | **Boolean**| True to enable schedules, false to disable. |

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

<a name="scheduleFindallstaffslots"></a>
# **scheduleFindallstaffslots**
> scheduleFindallstaffslots(starttime, endtime, staffid, serviceids, eventid, locationid, staffroleids, availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    OffsetDateTime starttime = new OffsetDateTime(); // OffsetDateTime | The start time of the range to look for slots.
    OffsetDateTime endtime = new OffsetDateTime(); // OffsetDateTime | The end time of the range to look for slots.
    UUID staffid = new UUID(); // UUID | The id of the staff to filter by.
    String serviceids = "serviceids_example"; // String | CSV list of the service Ids to filter by.
    UUID eventid = new UUID(); // UUID | The id of the event to filter by.
    UUID locationid = new UUID(); // UUID | The id of the location to filter by.
    String staffroleids = "staffroleids_example"; // String | CSV list of the staff member role ids to filter by.
    String availablefor = "availablefor_example"; // String | The specific availability type to filter by.
    try {
      apiInstance.scheduleFindallstaffslots(starttime, endtime, staffid, serviceids, eventid, locationid, staffroleids, availablefor);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleFindallstaffslots");
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
 **starttime** | **OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **OffsetDateTime**| The end time of the range to look for slots. |
 **staffid** | [**UUID**](.md)| The id of the staff to filter by. | [optional]
 **serviceids** | **String**| CSV list of the service Ids to filter by. | [optional]
 **eventid** | [**UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**UUID**](.md)| The id of the location to filter by. | [optional]
 **staffroleids** | **String**| CSV list of the staff member role ids to filter by. | [optional]
 **availablefor** | **String**| The specific availability type to filter by. | [optional]

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

<a name="scheduleFindslots"></a>
# **scheduleFindslots**
> scheduleFindslots(staffid, starttime, endtime, serviceids, eventid, locationid, availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UUID staffid = new UUID(); // UUID | The id of the staff to filter by.
    OffsetDateTime starttime = new OffsetDateTime(); // OffsetDateTime | The start time of the range to look for slots.
    OffsetDateTime endtime = new OffsetDateTime(); // OffsetDateTime | The end time of the range to look for slots.
    String serviceids = "serviceids_example"; // String | CSV list of the service Ids to filter by.
    UUID eventid = new UUID(); // UUID | The id of the event to filter by.
    UUID locationid = new UUID(); // UUID | The id of the service to filter by.
    String availablefor = "availablefor_example"; // String | The specific availability type to filter by.
    try {
      apiInstance.scheduleFindslots(staffid, starttime, endtime, serviceids, eventid, locationid, availablefor);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleFindslots");
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
 **staffid** | [**UUID**](.md)| The id of the staff to filter by. |
 **starttime** | **OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **OffsetDateTime**| The end time of the range to look for slots. |
 **serviceids** | **String**| CSV list of the service Ids to filter by. | [optional]
 **eventid** | [**UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**UUID**](.md)| The id of the service to filter by. | [optional]
 **availablefor** | **String**| The specific availability type to filter by. | [optional]

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

<a name="scheduleFindstaffavail"></a>
# **scheduleFindstaffavail**
> scheduleFindstaffavail(starttime, endtime, serviceids, eventid, locationid, staffroleids, availablefor, photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    OffsetDateTime starttime = new OffsetDateTime(); // OffsetDateTime | The start time of the range to look for slots.
    OffsetDateTime endtime = new OffsetDateTime(); // OffsetDateTime | The end time of the range to look for slots.
    String serviceids = "serviceids_example"; // String | CSV list of the service ids to filter by.
    UUID eventid = new UUID(); // UUID | The id of the event to filter by.
    UUID locationid = new UUID(); // UUID | The id of the service to filter by.
    String staffroleids = "staffroleids_example"; // String | CSV list of the staff member role ids to filter by.
    String availablefor = "availablefor_example"; // String | Filter slots by a specific availability type.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.scheduleFindstaffavail(starttime, endtime, serviceids, eventid, locationid, staffroleids, availablefor, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleFindstaffavail");
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
 **starttime** | **OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **OffsetDateTime**| The end time of the range to look for slots. |
 **serviceids** | **String**| CSV list of the service ids to filter by. | [optional]
 **eventid** | [**UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**UUID**](.md)| The id of the service to filter by. | [optional]
 **staffroleids** | **String**| CSV list of the staff member role ids to filter by. | [optional]
 **availablefor** | **String**| Filter slots by a specific availability type. | [optional]
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

<a name="scheduleGet"></a>
# **scheduleGet**
> scheduleGet(scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UUID scheduleid = new UUID(); // UUID | The id of the schedule.
    try {
      apiInstance.scheduleGet(scheduleid);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleGet");
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
 **scheduleid** | [**UUID**](.md)| The id of the schedule. |

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

<a name="scheduleGetmine"></a>
# **scheduleGetmine**
> scheduleGetmine(scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UUID scheduleid = new UUID(); // UUID | The id of the schedule.
    try {
      apiInstance.scheduleGetmine(scheduleid);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleGetmine");
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
 **scheduleid** | [**UUID**](.md)| The id of the schedule. |

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

<a name="scheduleGetstaff"></a>
# **scheduleGetstaff**
> scheduleGetstaff(userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to get info.
    try {
      apiInstance.scheduleGetstaff(userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleGetstaff");
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
 **userid** | [**UUID**](.md)| The id of the user to get info. |

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

<a name="scheduleGetstaffmine"></a>
# **scheduleGetstaffmine**
> scheduleGetstaffmine()

View current user&#39;s schedule information

Allows the user to view their own schedule.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    try {
      apiInstance.scheduleGetstaffmine();
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleGetstaffmine");
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

<a name="scheduleMyofftimes"></a>
# **scheduleMyofftimes**
> scheduleMyofftimes(includedeleted, onlyupcoming, modifiedafter)

View current user&#39;s schedule exceptions

Allows the user to view their own schedule exceptions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    Boolean includedeleted = true; // Boolean | If true the deleted offtimes are also returned.
    Boolean onlyupcoming = true; // Boolean | If true then only upcoming offtimes are returned.
    OffsetDateTime modifiedafter = new OffsetDateTime(); // OffsetDateTime | If specified, only offtimes modified after the specified date will be returned.
    try {
      apiInstance.scheduleMyofftimes(includedeleted, onlyupcoming, modifiedafter);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleMyofftimes");
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
 **includedeleted** | **Boolean**| If true the deleted offtimes are also returned. | [optional]
 **onlyupcoming** | **Boolean**| If true then only upcoming offtimes are returned. | [optional]
 **modifiedafter** | **OffsetDateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional]

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

<a name="scheduleSave"></a>
# **scheduleSave**
> scheduleSave(UNKNOWN_BASE_TYPE)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.scheduleSave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleSave");
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

<a name="scheduleSavemine"></a>
# **scheduleSavemine**
> scheduleSavemine(UNKNOWN_BASE_TYPE)

Create or edit a block in current user&#39;s schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleApi apiInstance = new ScheduleApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.scheduleSavemine(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleApi#scheduleSavemine");
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

