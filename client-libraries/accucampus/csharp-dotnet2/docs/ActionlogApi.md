# Org.OpenAPITools.Api.ActionlogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionlogList**](ActionlogApi.md#actionloglist) | **GET** /actionlog/list | View a list of users action logs


<a name="actionloglist"></a>
# **ActionlogList**
> void ActionlogList (int? from, int? count, Guid? user, DateTime? startdate, DateTime? enddate, string resource, string actionfilter, string argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionlogListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionlogApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var user = new Guid?(); // Guid? | The id of the user whose action logs have to be returned. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the logs. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the logs. (optional) 
            var resource = resource_example;  // string | The resource to filter the action logs. (optional) 
            var actionfilter = actionfilter_example;  // string | The action to filter the action logs. (optional) 
            var argument = argument_example;  // string | The id of the entity that was the argument of the executed action. (optional) 

            try
            {
                // View a list of users action logs
                apiInstance.ActionlogList(from, count, user, startdate, enddate, resource, actionfilter, argument);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionlogApi.ActionlogList: " + e.Message );
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
 **user** | [**Guid?**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the logs. | [optional] 
 **resource** | **string**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **string**| The action to filter the action logs. | [optional] 
 **argument** | **string**| The id of the entity that was the argument of the executed action. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

