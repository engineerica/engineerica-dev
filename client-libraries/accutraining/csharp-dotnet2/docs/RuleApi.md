# Org.OpenAPITools.Api.RuleApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RuleDelete**](RuleApi.md#ruledelete) | **DELETE** /rule/{id} | Delete a rule
[**RuleGet**](RuleApi.md#ruleget) | **GET** /rule/{id} | View details of a rule
[**RuleGeteventtype**](RuleApi.md#rulegeteventtype) | **GET** /rule/geteventtype | View details of a rule event type
[**RuleList**](RuleApi.md#rulelist) | **GET** /rule/list | View a list of user rules
[**RuleListactions**](RuleApi.md#rulelistactions) | **GET** /rule/listactions | View a list of rule actions available
[**RuleListeventtypes**](RuleApi.md#rulelisteventtypes) | **GET** /rule/listeventtypes | View a list of rule event types
[**RuleListhttprequests**](RuleApi.md#rulelisthttprequests) | **GET** /rule/listhttprequests | View all the http requests sent as a result of a rule
[**RuleSave**](RuleApi.md#rulesave) | **POST** /rule/{id} | Create or edit a rule


<a name="ruledelete"></a>
# **RuleDelete**
> void RuleDelete (Guid? id, AnyType body)

Delete a rule

Allows the user to delete an existing rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuleDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RuleApi();
            var id = new Guid?(); // Guid? | The id of the rule to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a rule
                apiInstance.RuleDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.RuleDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the rule to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ruleget"></a>
# **RuleGet**
> void RuleGet (Guid? id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuleGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RuleApi();
            var id = new Guid?(); // Guid? | The id of the rule to get.

            try
            {
                // View details of a rule
                apiInstance.RuleGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.RuleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the rule to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulegeteventtype"></a>
# **RuleGeteventtype**
> void RuleGeteventtype (string _event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuleGeteventtypeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RuleApi();
            var _event = _event_example;  // string | The name of the event to refresh.

            try
            {
                // View details of a rule event type
                apiInstance.RuleGeteventtype(_event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.RuleGeteventtype: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_event** | **string**| The name of the event to refresh. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulelist"></a>
# **RuleList**
> void RuleList (int? from, int? count)

View a list of user rules

Allows the user to view the list of all rules.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuleListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RuleApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of user rules
                apiInstance.RuleList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.RuleList: " + e.Message );
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

<a name="rulelistactions"></a>
# **RuleListactions**
> void RuleListactions ()

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuleListactionsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RuleApi();

            try
            {
                // View a list of rule actions available
                apiInstance.RuleListactions();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.RuleListactions: " + e.Message );
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

<a name="rulelisteventtypes"></a>
# **RuleListeventtypes**
> void RuleListeventtypes ()

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuleListeventtypesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RuleApi();

            try
            {
                // View a list of rule event types
                apiInstance.RuleListeventtypes();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.RuleListeventtypes: " + e.Message );
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

<a name="rulelisthttprequests"></a>
# **RuleListhttprequests**
> void RuleListhttprequests (int? from, int? count, bool? failed, int? status)

View all the http requests sent as a result of a rule

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuleListhttprequestsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RuleApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var failed = true;  // bool? | If true only failed requests will be returned (optional) 
            var status = 56;  // int? | The http status to filter the requests (optional) 

            try
            {
                // View all the http requests sent as a result of a rule
                apiInstance.RuleListhttprequests(from, count, failed, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.RuleListhttprequests: " + e.Message );
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
 **failed** | **bool?**| If true only failed requests will be returned | [optional] 
 **status** | **int?**| The http status to filter the requests | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulesave"></a>
# **RuleSave**
> void RuleSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a rule

Allows the user to create or edit a rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuleSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RuleApi();
            var id = new Guid?(); // Guid? | The id of the rule to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a rule
                apiInstance.RuleSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.RuleSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the rule to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

