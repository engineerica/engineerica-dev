# Org.OpenAPITools.Api.ReportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportList**](ReportApi.md#reportlist) | **GET** /report/list | View a list of available reports
[**ReportPermissionsbyuser**](ReportApi.md#reportpermissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
[**ReportPrepare**](ReportApi.md#reportprepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
[**ReportQuery**](ReportApi.md#reportquery) | **GET** /report/query | Query and load a specified report


<a name="reportlist"></a>
# **ReportList**
> void ReportList ()

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportApi();

            try
            {
                // View a list of available reports
                apiInstance.ReportList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportList: " + e.Message );
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

<a name="reportpermissionsbyuser"></a>
# **ReportPermissionsbyuser**
> void ReportPermissionsbyuser (string _params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportPermissionsbyuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportApi();
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 

            try
            {
                // Permissions by user report
                apiInstance.ReportPermissionsbyuser(_params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportPermissionsbyuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportprepare"></a>
# **ReportPrepare**
> void ReportPrepare (string reportname, string _params, string repformat, Guid? fillgroupid, string groupby, Guid? refreshgroup, string filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportPrepareExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportApi();
            var reportname = reportname_example;  // string | The name of the report to execute
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 
            var repformat = repformat_example;  // string | The format of the resulting report. Json, pdf, csv, ... (optional) 
            var fillgroupid = new Guid?(); // Guid? | If specified, the result is used to fill the group with the given ID (optional) 
            var groupby = groupby_example;  // string | How to group the records. In the format 'col1+col2|col3+col4 (optional) 
            var refreshgroup = new Guid?(); // Guid? | The ID of the group to check (and refresh) before processing the report. (optional) 
            var filtertext = filtertext_example;  // string | The user friendly text of the applied filters. (optional) 

            try
            {
                // Queries and loads the specified report, in background.
                apiInstance.ReportPrepare(reportname, _params, repformat, fillgroupid, groupby, refreshgroup, filtertext);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportPrepare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **string**| The name of the report to execute | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **string**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**Guid?**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **string**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**Guid?**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **string**| The user friendly text of the applied filters. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportquery"></a>
# **ReportQuery**
> void ReportQuery (string reportname, string _params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportQueryExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportApi();
            var reportname = reportname_example;  // string | The name of the report to execute
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 

            try
            {
                // Query and load a specified report
                apiInstance.ReportQuery(reportname, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportApi.ReportQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **string**| The name of the report to execute | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

