# Org.OpenAPITools.Api.AdhocqueryApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdhocqueryCheckexecution**](AdhocqueryApi.md#adhocquerycheckexecution) | **GET** /adhocquery/checkexecution | Check the status of an ad hoc query execution
[**AdhocqueryDelete**](AdhocqueryApi.md#adhocquerydelete) | **DELETE** /adhocquery/{id} | Delete an ad hoc query
[**AdhocqueryExecute**](AdhocqueryApi.md#adhocqueryexecute) | **GET** /adhocquery/execute | Execute an ad hoc query
[**AdhocqueryGet**](AdhocqueryApi.md#adhocqueryget) | **GET** /adhocquery/{id} | View details of an ad hoc query
[**AdhocqueryGetschema**](AdhocqueryApi.md#adhocquerygetschema) | **GET** /adhocquery/getschema | View the database schema for making ad hoc queries
[**AdhocqueryList**](AdhocqueryApi.md#adhocquerylist) | **GET** /adhocquery/list | View a list of saved ad hoc queries
[**AdhocqueryListexecutions**](AdhocqueryApi.md#adhocquerylistexecutions) | **GET** /adhocquery/listexecutions | View a list of ad hoc queries executions
[**AdhocquerySave**](AdhocqueryApi.md#adhocquerysave) | **POST** /adhocquery/{id} | Create or edit an ad hoc query
[**AdhocqueryStopexecution**](AdhocqueryApi.md#adhocquerystopexecution) | **GET** /adhocquery/stopexecution | Stops the execution of an ad hoc query


<a name="adhocquerycheckexecution"></a>
# **AdhocqueryCheckexecution**
> void AdhocqueryCheckexecution (Guid? id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryCheckexecutionExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();
            var id = new Guid?(); // Guid? | The id of the ad hoc query execution to be checked.

            try
            {
                // Check the status of an ad hoc query execution
                apiInstance.AdhocqueryCheckexecution(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocqueryCheckexecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the ad hoc query execution to be checked. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerydelete"></a>
# **AdhocqueryDelete**
> void AdhocqueryDelete (Guid? id, AnyType body)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();
            var id = new Guid?(); // Guid? | The id of the ad hoc query to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete an ad hoc query
                apiInstance.AdhocqueryDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocqueryDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the ad hoc query to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocqueryexecute"></a>
# **AdhocqueryExecute**
> void AdhocqueryExecute (Guid? id, string query)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryExecuteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();
            var id = new Guid?(); // Guid? | The id of the query to execute. (optional) 
            var query = query_example;  // string | The query to execute. (optional) 

            try
            {
                // Execute an ad hoc query
                apiInstance.AdhocqueryExecute(id, query);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocqueryExecute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the query to execute. | [optional] 
 **query** | **string**| The query to execute. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocqueryget"></a>
# **AdhocqueryGet**
> void AdhocqueryGet (Guid? id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();
            var id = new Guid?(); // Guid? | The id of the query to get.

            try
            {
                // View details of an ad hoc query
                apiInstance.AdhocqueryGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocqueryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the query to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerygetschema"></a>
# **AdhocqueryGetschema**
> void AdhocqueryGetschema ()

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryGetschemaExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();

            try
            {
                // View the database schema for making ad hoc queries
                apiInstance.AdhocqueryGetschema();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocqueryGetschema: " + e.Message );
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

<a name="adhocquerylist"></a>
# **AdhocqueryList**
> void AdhocqueryList (int? from, int? count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of saved ad hoc queries
                apiInstance.AdhocqueryList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocqueryList: " + e.Message );
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

<a name="adhocquerylistexecutions"></a>
# **AdhocqueryListexecutions**
> void AdhocqueryListexecutions (int? from, int? count, Guid? query)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryListexecutionsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var query = new Guid?(); // Guid? | The first record to return. (optional) 

            try
            {
                // View a list of ad hoc queries executions
                apiInstance.AdhocqueryListexecutions(from, count, query);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocqueryListexecutions: " + e.Message );
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
 **query** | [**Guid?**](.md)| The first record to return. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerysave"></a>
# **AdhocquerySave**
> void AdhocquerySave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerySaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();
            var id = new Guid?(); // Guid? | The id of the query to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an ad hoc query
                apiInstance.AdhocquerySave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocquerySave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the query to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerystopexecution"></a>
# **AdhocqueryStopexecution**
> void AdhocqueryStopexecution (Guid? id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryStopexecutionExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdhocqueryApi();
            var id = new Guid?(); // Guid? | The id of the ad hoc query execution to be stopped.

            try
            {
                // Stops the execution of an ad hoc query
                apiInstance.AdhocqueryStopexecution(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdhocqueryApi.AdhocqueryStopexecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the ad hoc query execution to be stopped. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

