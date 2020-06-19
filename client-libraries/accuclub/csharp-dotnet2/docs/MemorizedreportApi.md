# Org.OpenAPITools.Api.MemorizedreportApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MemorizedreportDelete**](MemorizedreportApi.md#memorizedreportdelete) | **DELETE** /memorizedreport/{id} | Delete memorized report
[**MemorizedreportGet**](MemorizedreportApi.md#memorizedreportget) | **GET** /memorizedreport/{id} | View details of a memorized report
[**MemorizedreportList**](MemorizedreportApi.md#memorizedreportlist) | **GET** /memorizedreport/list | View a list of all his memorized reports
[**MemorizedreportSave**](MemorizedreportApi.md#memorizedreportsave) | **POST** /memorizedreport/{id} | Create or edit a memorized report


<a name="memorizedreportdelete"></a>
# **MemorizedreportDelete**
> void MemorizedreportDelete (Guid? id, AnyType body)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MemorizedreportApi();
            var id = new Guid?(); // Guid? | The id of the report settings to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete memorized report
                apiInstance.MemorizedreportDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MemorizedreportApi.MemorizedreportDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the report settings to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportget"></a>
# **MemorizedreportGet**
> void MemorizedreportGet (Guid? id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MemorizedreportApi();
            var id = new Guid?(); // Guid? | The id of the report configuration to get.

            try
            {
                // View details of a memorized report
                apiInstance.MemorizedreportGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MemorizedreportApi.MemorizedreportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the report configuration to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportlist"></a>
# **MemorizedreportList**
> void MemorizedreportList (int? from, int? count, string customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MemorizedreportApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var customname = customname_example;  // string | If specified filters the memorized reports by custom name. (optional) 

            try
            {
                // View a list of all his memorized reports
                apiInstance.MemorizedreportList(from, count, customname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MemorizedreportApi.MemorizedreportList: " + e.Message );
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
 **customname** | **string**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportsave"></a>
# **MemorizedreportSave**
> void MemorizedreportSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MemorizedreportApi();
            var id = new Guid?(); // Guid? | The id of the report settings to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a memorized report
                apiInstance.MemorizedreportSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MemorizedreportApi.MemorizedreportSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the report settings to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

