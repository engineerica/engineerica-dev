# Org.OpenAPITools.Api.EventApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventDelete**](EventApi.md#eventdelete) | **DELETE** /event/{id} | Delete a course
[**EventGet**](EventApi.md#eventget) | **GET** /event/{id} | Search and view details of a course
[**EventGetsessionsbydate**](EventApi.md#eventgetsessionsbydate) | **GET** /event/getsessionsbydate | View a list of courses by date
[**EventList**](EventApi.md#eventlist) | **GET** /event/list | View a list of courses
[**EventSave**](EventApi.md#eventsave) | **POST** /event/{id} | Create or edit a course
[**EventSearchgroup**](EventApi.md#eventsearchgroup) | **GET** /event/searchgroup | Searches for the available event groups


<a name="eventdelete"></a>
# **EventDelete**
> void EventDelete (Guid? id, AnyType body)

Delete a course

Allows the user to delete an existing course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var id = new Guid?(); // Guid? | The id of the event to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a course
                apiInstance.EventDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the event to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventget"></a>
# **EventGet**
> void EventGet (Guid? id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var id = new Guid?(); // Guid? | The id of the event to get.

            try
            {
                // Search and view details of a course
                apiInstance.EventGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the event to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventgetsessionsbydate"></a>
# **EventGetsessionsbydate**
> void EventGetsessionsbydate (Guid? location, DateTime? date, string type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventGetsessionsbydateExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var location = new Guid?(); // Guid? | The location to filter the events. (optional) 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | The date to filter the events. Today will be used if this parameter is omitted. (optional) 
            var type = type_example;  // string | Type of event to list. (optional) 

            try
            {
                // View a list of courses by date
                apiInstance.EventGetsessionsbydate(location, date, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventGetsessionsbydate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**Guid?**](.md)| The location to filter the events. | [optional] 
 **date** | **DateTime?**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **string**| Type of event to list. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventlist"></a>
# **EventList**
> void EventList (string from, string count, bool? summaryonly, Guid? termid)

View a list of courses

Allows the user to view the full list of courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var from = from_example;  // string | The first record to return.
            var count = count_example;  // string | The max number of records to return.
            var summaryonly = true;  // bool? | True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional) 
            var termid = new Guid?(); // Guid? | Id of the term to list the events. Null to list all events. (optional) 

            try
            {
                // View a list of courses
                apiInstance.EventList(from, count, summaryonly, termid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **bool?**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**Guid?**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsave"></a>
# **EventSave**
> void EventSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a course

Allows the user to create or edit a course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var id = new Guid?(); // Guid? | The id of the event to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a course
                apiInstance.EventSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the event to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsearchgroup"></a>
# **EventSearchgroup**
> void EventSearchgroup (Guid? query)

Searches for the available event groups

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventSearchgroupExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventApi();
            var query = new Guid?(); // Guid? | Query to search event groups.

            try
            {
                // Searches for the available event groups
                apiInstance.EventSearchgroup(query);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventApi.EventSearchgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Guid?**](.md)| Query to search event groups. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

