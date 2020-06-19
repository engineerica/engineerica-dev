# AppointmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appointmentCancel**](AppointmentApi.md#appointmentCancel) | **GET** /appointment/cancel | Cancel an appointment
[**appointmentCheckisvalid**](AppointmentApi.md#appointmentCheckisvalid) | **GET** /appointment/checkisvalid | Check if an appointment is valid or not
[**appointmentEditanyway**](AppointmentApi.md#appointmentEditanyway) | **GET** /appointment/editanyway | Edit an appointment even if it breaks activated rules
[**appointmentEditpresence**](AppointmentApi.md#appointmentEditpresence) | **GET** /appointment/editpresence | Edit the no-show status of an appointment
[**appointmentFindallstaffslots**](AppointmentApi.md#appointmentFindallstaffslots) | **GET** /appointment/findallstaffslots | Finds all staff available slots filtered by service, date, etc
[**appointmentFindslots**](AppointmentApi.md#appointmentFindslots) | **GET** /appointment/findslots | Finds available slots filtered by service, date, staff, etc
[**appointmentFindstaff**](AppointmentApi.md#appointmentFindstaff) | **GET** /appointment/findstaff | Finds staff available by service, date, event, etc
[**appointmentGet**](AppointmentApi.md#appointmentGet) | **GET** /appointment/{id} | Search and view details of an appointment
[**appointmentGetcurrent**](AppointmentApi.md#appointmentGetcurrent) | **GET** /appointment/getcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**appointmentGetlocations**](AppointmentApi.md#appointmentGetlocations) | **GET** /appointment/getlocations | Find locations where a service is available
[**appointmentList**](AppointmentApi.md#appointmentList) | **GET** /appointment/list | View a list of appointments
[**appointmentListmine**](AppointmentApi.md#appointmentListmine) | **GET** /appointment/listmine | View all my upcoming appointments
[**appointmentListupcoming**](AppointmentApi.md#appointmentListupcoming) | **GET** /appointment/listupcoming | Search and view details of all my upcoming appointments
[**appointmentRescheduleoutlook**](AppointmentApi.md#appointmentRescheduleoutlook) | **GET** /appointment/rescheduleoutlook | Reschedule an appointment from MS Outlook.
[**appointmentRestore**](AppointmentApi.md#appointmentRestore) | **GET** /appointment/restore | Restore an appointment
[**appointmentRestoreanyway**](AppointmentApi.md#appointmentRestoreanyway) | **GET** /appointment/restoreanyway | Restore an appointment even if it breaks activated rules
[**appointmentSave**](AppointmentApi.md#appointmentSave) | **POST** /appointment/{id} | Schedule an appointment
[**appointmentSetasvalid**](AppointmentApi.md#appointmentSetasvalid) | **GET** /appointment/setasvalid | Schedule an appointment even if it breaks activated rules
[**appointmentSuggestlocations**](AppointmentApi.md#appointmentSuggestlocations) | **GET** /appointment/suggestlocations | View the locations with most appointments
[**appointmentSuggestservices**](AppointmentApi.md#appointmentSuggestservices) | **GET** /appointment/suggestservices | View the services with most appointments
[**appointmentVoid**](AppointmentApi.md#appointmentVoid) | **GET** /appointment/void | Void an appointment


<a name="appointmentCancel"></a>
# **appointmentCancel**
> appointmentCancel(id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to cancel.
    try {
      apiInstance.appointmentCancel(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentCancel");
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
 **id** | [**UUID**](.md)| The id of the appointment to cancel. |

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

<a name="appointmentCheckisvalid"></a>
# **appointmentCheckisvalid**
> appointmentCheckisvalid(id, editing)

Check if an appointment is valid or not

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to check.
    Boolean editing = true; // Boolean | Specifies whether the check is for a new appointment or an existing one.
    try {
      apiInstance.appointmentCheckisvalid(id, editing);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentCheckisvalid");
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
 **id** | [**UUID**](.md)| The id of the appointment to check. |
 **editing** | **Boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional]

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

<a name="appointmentEditanyway"></a>
# **appointmentEditanyway**
> appointmentEditanyway(id, attendee, staff, location, start, end, term, event, services, notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to edit.
    UUID attendee = new UUID(); // UUID | The id of the attendee involved in the appointment.
    UUID staff = new UUID(); // UUID | The id of the staff member involved in the appointment.
    UUID location = new UUID(); // UUID | The id of the location where the appointment will take place.
    OffsetDateTime start = new OffsetDateTime(); // OffsetDateTime | The appointment's start date & time.
    OffsetDateTime end = new OffsetDateTime(); // OffsetDateTime | The appointment's end date & time.
    UUID term = new UUID(); // UUID | The id of the term when the appointment takes place.
    UUID event = new UUID(); // UUID | The id of the event of the appointment.
    String services = "services_example"; // String | Comma-separated string containing the ids of the services of the appointment.
    String notes = "notes_example"; // String | The notes of the appointment.
    try {
      apiInstance.appointmentEditanyway(id, attendee, staff, location, start, end, term, event, services, notes);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentEditanyway");
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
 **id** | [**UUID**](.md)| The id of the appointment to edit. |
 **attendee** | [**UUID**](.md)| The id of the attendee involved in the appointment. |
 **staff** | [**UUID**](.md)| The id of the staff member involved in the appointment. |
 **location** | [**UUID**](.md)| The id of the location where the appointment will take place. |
 **start** | **OffsetDateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **OffsetDateTime**| The appointment&#39;s end date &amp; time. |
 **term** | [**UUID**](.md)| The id of the term when the appointment takes place. | [optional]
 **event** | [**UUID**](.md)| The id of the event of the appointment. | [optional]
 **services** | **String**| Comma-separated string containing the ids of the services of the appointment. | [optional]
 **notes** | **String**| The notes of the appointment. | [optional]

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

<a name="appointmentEditpresence"></a>
# **appointmentEditpresence**
> appointmentEditpresence(id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to edit its presence.
    Boolean showedup = true; // Boolean | Specifies whether the attendee was showed-up or not in the appointment.
    try {
      apiInstance.appointmentEditpresence(id, showedup);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentEditpresence");
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
 **id** | [**UUID**](.md)| The id of the appointment to edit its presence. |
 **showedup** | **Boolean**| Specifies whether the attendee was showed-up or not in the appointment. |

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

<a name="appointmentFindallstaffslots"></a>
# **appointmentFindallstaffslots**
> appointmentFindallstaffslots(starttime, endtime, serviceids, locationid, eventid, photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    OffsetDateTime starttime = new OffsetDateTime(); // OffsetDateTime | The start time of the range to look for slots.
    OffsetDateTime endtime = new OffsetDateTime(); // OffsetDateTime | The end time of the range to look for slots.
    String serviceids = "serviceids_example"; // String | CSV list of the service Ids to filter by.
    UUID locationid = new UUID(); // UUID | The id of the service to filter by.
    UUID eventid = new UUID(); // UUID | The id of the event to filter by.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.appointmentFindallstaffslots(starttime, endtime, serviceids, locationid, eventid, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentFindallstaffslots");
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
 **serviceids** | **String**| CSV list of the service Ids to filter by. |
 **locationid** | [**UUID**](.md)| The id of the service to filter by. |
 **eventid** | [**UUID**](.md)| The id of the event to filter by. | [optional]
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

<a name="appointmentFindslots"></a>
# **appointmentFindslots**
> appointmentFindslots(staffid, starttime, endtime, serviceids, eventid, locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID staffid = new UUID(); // UUID | The id of the staff to filter by.
    OffsetDateTime starttime = new OffsetDateTime(); // OffsetDateTime | The start time of the range to look for slots.
    OffsetDateTime endtime = new OffsetDateTime(); // OffsetDateTime | The end time of the range to look for slots.
    String serviceids = "serviceids_example"; // String | CSV list of the service Ids to filter by.
    UUID eventid = new UUID(); // UUID | The id of the event to filter by.
    UUID locationid = new UUID(); // UUID | The id of the service to filter by.
    try {
      apiInstance.appointmentFindslots(staffid, starttime, endtime, serviceids, eventid, locationid);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentFindslots");
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
 **serviceids** | **String**| CSV list of the service Ids to filter by. |
 **eventid** | [**UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**UUID**](.md)| The id of the service to filter by. | [optional]

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

<a name="appointmentFindstaff"></a>
# **appointmentFindstaff**
> appointmentFindstaff(serviceids, starttime, endtime, eventid, locationid, photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    String serviceids = "serviceids_example"; // String | CSV list of the service ids to filter by.
    OffsetDateTime starttime = new OffsetDateTime(); // OffsetDateTime | The start time of the range to look for slots.
    OffsetDateTime endtime = new OffsetDateTime(); // OffsetDateTime | The end time of the range to look for slots.
    UUID eventid = new UUID(); // UUID | The id of the event to filter by.
    UUID locationid = new UUID(); // UUID | The id of the service to filter by.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.appointmentFindstaff(serviceids, starttime, endtime, eventid, locationid, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentFindstaff");
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
 **serviceids** | **String**| CSV list of the service ids to filter by. |
 **starttime** | **OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **OffsetDateTime**| The end time of the range to look for slots. |
 **eventid** | [**UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**UUID**](.md)| The id of the service to filter by. | [optional]
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

<a name="appointmentGet"></a>
# **appointmentGet**
> appointmentGet(id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to get.
    try {
      apiInstance.appointmentGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentGet");
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
 **id** | [**UUID**](.md)| The id of the appointment to get. |

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

<a name="appointmentGetcurrent"></a>
# **appointmentGetcurrent**
> appointmentGetcurrent(station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    String user = "user_example"; // String | The card of the user.
    UUID location = new UUID(); // UUID | The id of the location where the user wants to sign-in.
    try {
      apiInstance.appointmentGetcurrent(station, user, location);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentGetcurrent");
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
 **location** | [**UUID**](.md)| The id of the location where the user wants to sign-in. |

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

<a name="appointmentGetlocations"></a>
# **appointmentGetlocations**
> appointmentGetlocations(serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID serviceid = new UUID(); // UUID | The id of the service to get its locations.
    try {
      apiInstance.appointmentGetlocations(serviceid);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentGetlocations");
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
 **serviceid** | [**UUID**](.md)| The id of the service to get its locations. |

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

<a name="appointmentList"></a>
# **appointmentList**
> appointmentList(from, count, startdate, enddate, userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the appointments.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the appointments.
    UUID userid = new UUID(); // UUID | The attendee id to filter the appointments.
    try {
      apiInstance.appointmentList(from, count, startdate, enddate, userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentList");
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
 **startdate** | **OffsetDateTime**| The start date of the period to filter the appointments. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the appointments. | [optional]
 **userid** | [**UUID**](.md)| The attendee id to filter the appointments. | [optional]

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

<a name="appointmentListmine"></a>
# **appointmentListmine**
> appointmentListmine(start, modifiedafter)

View all my upcoming appointments

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    OffsetDateTime start = new OffsetDateTime(); // OffsetDateTime | If specified, only appointments that start after the specified date will be returned.
    OffsetDateTime modifiedafter = new OffsetDateTime(); // OffsetDateTime | If specified, only appointments modified after the specified date will be returned.
    try {
      apiInstance.appointmentListmine(start, modifiedafter);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentListmine");
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
 **start** | **OffsetDateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **OffsetDateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

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

<a name="appointmentListupcoming"></a>
# **appointmentListupcoming**
> appointmentListupcoming(start, modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    OffsetDateTime start = new OffsetDateTime(); // OffsetDateTime | If specified, only appointments that start after the specified date will be returned.
    OffsetDateTime modifiedafter = new OffsetDateTime(); // OffsetDateTime | If specified, only appointments modified after the specified date will be returned.
    try {
      apiInstance.appointmentListupcoming(start, modifiedafter);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentListupcoming");
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
 **start** | **OffsetDateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **OffsetDateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

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

<a name="appointmentRescheduleoutlook"></a>
# **appointmentRescheduleoutlook**
> appointmentRescheduleoutlook(id, start, end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to edit.
    OffsetDateTime start = new OffsetDateTime(); // OffsetDateTime | The appointment's start date & time.
    OffsetDateTime end = new OffsetDateTime(); // OffsetDateTime | The appointment's end date & time.
    try {
      apiInstance.appointmentRescheduleoutlook(id, start, end);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentRescheduleoutlook");
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
 **id** | [**UUID**](.md)| The id of the appointment to edit. |
 **start** | **OffsetDateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **OffsetDateTime**| The appointment&#39;s end date &amp; time. |

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

<a name="appointmentRestore"></a>
# **appointmentRestore**
> appointmentRestore(id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to restore.
    try {
      apiInstance.appointmentRestore(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentRestore");
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
 **id** | [**UUID**](.md)| The id of the appointment to restore. |

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

<a name="appointmentRestoreanyway"></a>
# **appointmentRestoreanyway**
> appointmentRestoreanyway(id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to restore.
    try {
      apiInstance.appointmentRestoreanyway(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentRestoreanyway");
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
 **id** | [**UUID**](.md)| The id of the appointment to restore. |

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

<a name="appointmentSave"></a>
# **appointmentSave**
> appointmentSave(id, UNKNOWN_BASE_TYPE)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.appointmentSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentSave");
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
 **id** | [**UUID**](.md)| The id of the appointment to save (leave empty to create a new one). |
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

<a name="appointmentSetasvalid"></a>
# **appointmentSetasvalid**
> appointmentSetasvalid(id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to set as valid.
    try {
      apiInstance.appointmentSetasvalid(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentSetasvalid");
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
 **id** | [**UUID**](.md)| The id of the appointment to set as valid. |

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

<a name="appointmentSuggestlocations"></a>
# **appointmentSuggestlocations**
> appointmentSuggestlocations()

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    try {
      apiInstance.appointmentSuggestlocations();
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentSuggestlocations");
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

<a name="appointmentSuggestservices"></a>
# **appointmentSuggestservices**
> appointmentSuggestservices()

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    try {
      apiInstance.appointmentSuggestservices();
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentSuggestservices");
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

<a name="appointmentVoid"></a>
# **appointmentVoid**
> appointmentVoid(id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student&#39;s restrictions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AppointmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AppointmentApi apiInstance = new AppointmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the appointment to cancel.
    try {
      apiInstance.appointmentVoid(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AppointmentApi#appointmentVoid");
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
 **id** | [**UUID**](.md)| The id of the appointment to cancel. |

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

