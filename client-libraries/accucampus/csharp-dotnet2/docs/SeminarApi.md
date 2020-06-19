# Org.OpenAPITools.Api.SeminarApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SeminarDelete**](SeminarApi.md#seminardelete) | **DELETE** /seminar/{id} | Delete an event
[**SeminarGet**](SeminarApi.md#seminarget) | **GET** /seminar/{id} | Search and view details of a event
[**SeminarList**](SeminarApi.md#seminarlist) | **GET** /seminar/list | View a list of events
[**SeminarSave**](SeminarApi.md#seminarsave) | **POST** /seminar/{id} | Create or edit a event


<a name="seminardelete"></a>
# **SeminarDelete**
> void SeminarDelete (Guid? id, AnyType body)

Delete an event

Allows the user to delete an existing event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SeminarDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SeminarApi();
            var id = new Guid?(); // Guid? | The id of the seminar to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete an event
                apiInstance.SeminarDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SeminarApi.SeminarDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the seminar to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="seminarget"></a>
# **SeminarGet**
> void SeminarGet (Guid? id)

Search and view details of a event

Allows the user to view a event and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SeminarGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SeminarApi();
            var id = new Guid?(); // Guid? | The id of the seminar to get.

            try
            {
                // Search and view details of a event
                apiInstance.SeminarGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SeminarApi.SeminarGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the seminar to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="seminarlist"></a>
# **SeminarList**
> void SeminarList (string from, string count, bool? summaryonly, Guid? termid)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SeminarListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SeminarApi();
            var from = from_example;  // string | The first record to return.
            var count = count_example;  // string | The max number of records to return.
            var summaryonly = true;  // bool? | True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional) 
            var termid = new Guid?(); // Guid? | Id of the term to list the events. Null to list all events. (optional) 

            try
            {
                // View a list of events
                apiInstance.SeminarList(from, count, summaryonly, termid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SeminarApi.SeminarList: " + e.Message );
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

<a name="seminarsave"></a>
# **SeminarSave**
> void SeminarSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a event

Allows the user to create or edit a event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SeminarSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SeminarApi();
            var id = new Guid?(); // Guid? | The id of the event to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a event
                apiInstance.SeminarSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SeminarApi.SeminarSave: " + e.Message );
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

