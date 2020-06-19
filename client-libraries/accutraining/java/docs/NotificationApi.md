# NotificationApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notificationDelete**](NotificationApi.md#notificationDelete) | **DELETE** /notification/{id} | Delete a notification
[**notificationGet**](NotificationApi.md#notificationGet) | **GET** /notification/{id} | View a notification
[**notificationGetforstation**](NotificationApi.md#notificationGetforstation) | **GET** /notification/getforstation | Gets all public (in station) notifications for the specific user
[**notificationGetunreadcount**](NotificationApi.md#notificationGetunreadcount) | **GET** /notification/getunreadcount | Get the number of unread notifications
[**notificationList**](NotificationApi.md#notificationList) | **GET** /notification/list | View a list of all sent notifications
[**notificationListmine**](NotificationApi.md#notificationListmine) | **GET** /notification/listmine | View all the notifications sent to the current user
[**notificationMarkasread**](NotificationApi.md#notificationMarkasread) | **GET** /notification/markasread | Mark a notification as read
[**notificationMarkasunread**](NotificationApi.md#notificationMarkasunread) | **GET** /notification/markasunread | Mark a notification as unread
[**notificationSend**](NotificationApi.md#notificationSend) | **GET** /notification/send | Send notifications on screen, via email or text to users
[**notificationSendonscreen**](NotificationApi.md#notificationSendonscreen) | **GET** /notification/sendonscreen | Send on-screen notifications


<a name="notificationDelete"></a>
# **notificationDelete**
> notificationDelete(id, body)

Delete a notification

Allows the user to delete an existing notification.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the notification to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.notificationDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationDelete");
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
 **id** | [**UUID**](.md)| The id of the notification to delete. |
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

<a name="notificationGet"></a>
# **notificationGet**
> notificationGet(id)

View a notification

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the notification to get.
    try {
      apiInstance.notificationGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationGet");
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
 **id** | [**UUID**](.md)| The id of the notification to get. |

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

<a name="notificationGetforstation"></a>
# **notificationGetforstation**
> notificationGetforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    String user = "user_example"; // String | The card of the user.
    try {
      apiInstance.notificationGetforstation(station, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationGetforstation");
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

<a name="notificationGetunreadcount"></a>
# **notificationGetunreadcount**
> notificationGetunreadcount()

Get the number of unread notifications

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    try {
      apiInstance.notificationGetunreadcount();
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationGetunreadcount");
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

<a name="notificationList"></a>
# **notificationList**
> notificationList(from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID recipient = new UUID(); // UUID | The recipient whose notifications have to be listed.
    Integer status = 56; // Integer | The status of the notifications to list. Read, Unread or All.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the notifications.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the notifications.
    Boolean sentonscreen = true; // Boolean | Specifies whether to list the notifications that were sent on-screen or not.
    Boolean sentemail = true; // Boolean | Specifies whether to list the notifications that were sent via e-mail or not.
    Boolean sentsms = true; // Boolean | Specifies whether to list the notifications that were sent via sms or not.
    try {
      apiInstance.notificationList(from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationList");
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
 **recipient** | [**UUID**](.md)| The recipient whose notifications have to be listed. | [optional]
 **status** | **Integer**| The status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the notifications. | [optional]
 **sentonscreen** | **Boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional]
 **sentemail** | **Boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional]
 **sentsms** | **Boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional]

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

<a name="notificationListmine"></a>
# **notificationListmine**
> notificationListmine(from, count, status, startdate, enddate)

View all the notifications sent to the current user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    Integer status = 56; // Integer | Specifies the status of the notifications to list. Read, Unread or All.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the notifications.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the notifications.
    try {
      apiInstance.notificationListmine(from, count, status, startdate, enddate);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationListmine");
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
 **status** | **Integer**| Specifies the status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

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

<a name="notificationMarkasread"></a>
# **notificationMarkasread**
> notificationMarkasread(id, status, startdate, enddate)

Mark a notification as read

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
    Integer status = 56; // Integer | Specifies the status to filter the notifications. Read, Unread or All.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the notifications.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the notifications.
    try {
      apiInstance.notificationMarkasread(id, status, startdate, enddate);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationMarkasread");
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
 **id** | [**UUID**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional]
 **status** | **Integer**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

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

<a name="notificationMarkasunread"></a>
# **notificationMarkasunread**
> notificationMarkasunread(id, status, startdate, enddate)

Mark a notification as unread

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
    Integer status = 56; // Integer | Specifies the status to filter the notifications. Read, Unread or All.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the notifications.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the notifications.
    try {
      apiInstance.notificationMarkasunread(id, status, startdate, enddate);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationMarkasunread");
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
 **id** | [**UUID**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional]
 **status** | **Integer**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

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

<a name="notificationSend"></a>
# **notificationSend**
> notificationSend(emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    Boolean emailenabled = true; // Boolean | Whether send the notification via email.
    Boolean onscreenenabled = true; // Boolean | Whether to display the notification on screen.
    Boolean smsenabled = true; // Boolean | Whether to send the notification via text message.
    String title = "title_example"; // String | Notification title.
    String tousers = "tousers_example"; // String | Comma-separated Ids of users to send the notification.
    String togroups = "togroups_example"; // String | Comma-separated Ids of user groups to send the notification.
    String onscreenbody = "onscreenbody_example"; // String | Body of the message for on-screen display.
    String onscreenclick = "onscreenclick_example"; // String | What to do when the notification is clicked. Valid values: hide, view, url.
    String onscreenurl = "onscreenurl_example"; // String | Url to redirect the user, if onscreenclick=url.
    String onscreenclass = "onscreenclass_example"; // String | How to display the notification. Valid values: info, success, warning, error
    Integer onscreenduration = 56; // Integer | Time in seconds to display the notification.
    Integer showonstation = 56; // Integer | Whether to show the notification in the sign-in station.
    String emailfromname = "emailfromname_example"; // String | Name of the email sender.
    String emailfrom = "emailfrom_example"; // String | Reply-to email.
    String emailsubject = "emailsubject_example"; // String | Subject of the email.
    String emailbody = "emailbody_example"; // String | Body of the email.
    String textmessagebody = "textmessagebody_example"; // String | Message for SMS. Max 160 characters.
    try {
      apiInstance.notificationSend(emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationSend");
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
 **emailenabled** | **Boolean**| Whether send the notification via email. |
 **onscreenenabled** | **Boolean**| Whether to display the notification on screen. |
 **smsenabled** | **Boolean**| Whether to send the notification via text message. |
 **title** | **String**| Notification title. |
 **tousers** | **String**| Comma-separated Ids of users to send the notification. | [optional]
 **togroups** | **String**| Comma-separated Ids of user groups to send the notification. | [optional]
 **onscreenbody** | **String**| Body of the message for on-screen display. | [optional]
 **onscreenclick** | **String**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional]
 **onscreenurl** | **String**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional]
 **onscreenclass** | **String**| How to display the notification. Valid values: info, success, warning, error | [optional]
 **onscreenduration** | **Integer**| Time in seconds to display the notification. | [optional]
 **showonstation** | **Integer**| Whether to show the notification in the sign-in station. | [optional]
 **emailfromname** | **String**| Name of the email sender. | [optional]
 **emailfrom** | **String**| Reply-to email. | [optional]
 **emailsubject** | **String**| Subject of the email. | [optional]
 **emailbody** | **String**| Body of the email. | [optional]
 **textmessagebody** | **String**| Message for SMS. Max 160 characters. | [optional]

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

<a name="notificationSendonscreen"></a>
# **notificationSendonscreen**
> notificationSendonscreen(notification)

Send on-screen notifications

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.NotificationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    NotificationApi apiInstance = new NotificationApi(defaultClient);
    UUID notification = new UUID(); // UUID | The ID of the notification to send.
    try {
      apiInstance.notificationSendonscreen(notification);
    } catch (ApiException e) {
      System.err.println("Exception when calling NotificationApi#notificationSendonscreen");
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
 **notification** | [**UUID**](.md)| The ID of the notification to send. |

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

