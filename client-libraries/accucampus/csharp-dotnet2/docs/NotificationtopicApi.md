# Org.OpenAPITools.Api.NotificationtopicApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotificationtopicDelete**](NotificationtopicApi.md#notificationtopicdelete) | **DELETE** /notificationtopic/{id} | Delete a notification topic
[**NotificationtopicGet**](NotificationtopicApi.md#notificationtopicget) | **GET** /notificationtopic/{id} | Search and view details of a notification topic
[**NotificationtopicList**](NotificationtopicApi.md#notificationtopiclist) | **GET** /notificationtopic/list | List all the notification topics
[**NotificationtopicListsubscribe**](NotificationtopicApi.md#notificationtopiclistsubscribe) | **GET** /notificationtopic/listsubscribe | List all the notification topics available to subscribe
[**NotificationtopicSave**](NotificationtopicApi.md#notificationtopicsave) | **POST** /notificationtopic/{id} | Create or edit a notification topic


<a name="notificationtopicdelete"></a>
# **NotificationtopicDelete**
> void NotificationtopicDelete (Guid? id, AnyType body)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationtopicApi();
            var id = new Guid?(); // Guid? | The id of the notification topic to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a notification topic
                apiInstance.NotificationtopicDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationtopicApi.NotificationtopicDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the notification topic to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopicget"></a>
# **NotificationtopicGet**
> void NotificationtopicGet (Guid? id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationtopicApi();
            var id = new Guid?(); // Guid? | The id of the notification topic to get.

            try
            {
                // Search and view details of a notification topic
                apiInstance.NotificationtopicGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationtopicApi.NotificationtopicGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the notification topic to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopiclist"></a>
# **NotificationtopicList**
> void NotificationtopicList (int? from, int? count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationtopicApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // List all the notification topics
                apiInstance.NotificationtopicList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationtopicApi.NotificationtopicList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopiclistsubscribe"></a>
# **NotificationtopicListsubscribe**
> void NotificationtopicListsubscribe ()

List all the notification topics available to subscribe

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicListsubscribeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationtopicApi();

            try
            {
                // List all the notification topics available to subscribe
                apiInstance.NotificationtopicListsubscribe();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationtopicApi.NotificationtopicListsubscribe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopicsave"></a>
# **NotificationtopicSave**
> void NotificationtopicSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationtopicApi();
            var id = new Guid?(); // Guid? | The id of the topic to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a notification topic
                apiInstance.NotificationtopicSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationtopicApi.NotificationtopicSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the topic to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

