# Org.OpenAPITools.Api.ReportscheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportscheduleDelete**](ReportscheduleApi.md#reportscheduledelete) | **DELETE** /reportschedule/{id} | Delete a report schedule
[**ReportscheduleGet**](ReportscheduleApi.md#reportscheduleget) | **GET** /reportschedule/{id} | Get a report schedule
[**ReportscheduleList**](ReportscheduleApi.md#reportschedulelist) | **GET** /reportschedule/list | View a list of the scheduled reports
[**ReportscheduleSave**](ReportscheduleApi.md#reportschedulesave) | **POST** /reportschedule/{id} | Create or edit a report schedule


<a name="reportscheduledelete"></a>
# **ReportscheduleDelete**
> void ReportscheduleDelete (Guid? id, AnyType body)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportscheduleDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportscheduleApi();
            var id = new Guid?(); // Guid? | The id of the report schedule to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a report schedule
                apiInstance.ReportscheduleDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportscheduleApi.ReportscheduleDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the report schedule to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportscheduleget"></a>
# **ReportscheduleGet**
> void ReportscheduleGet (Guid? id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportscheduleGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportscheduleApi();
            var id = new Guid?(); // Guid? | The id of the schedule to get.

            try
            {
                // Get a report schedule
                apiInstance.ReportscheduleGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportscheduleApi.ReportscheduleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the schedule to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportschedulelist"></a>
# **ReportscheduleList**
> void ReportscheduleList (int? from, int? count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportscheduleListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportscheduleApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of the scheduled reports
                apiInstance.ReportscheduleList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportscheduleApi.ReportscheduleList: " + e.Message );
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

<a name="reportschedulesave"></a>
# **ReportscheduleSave**
> void ReportscheduleSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportscheduleSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportscheduleApi();
            var id = new Guid?(); // Guid? | The id of the schedule save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a report schedule
                apiInstance.ReportscheduleSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportscheduleApi.ReportscheduleSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the schedule save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

