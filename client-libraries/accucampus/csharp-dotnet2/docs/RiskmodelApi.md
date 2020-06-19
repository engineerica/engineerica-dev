# Org.OpenAPITools.Api.RiskmodelApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RiskmodelCheckanalysis**](RiskmodelApi.md#riskmodelcheckanalysis) | **GET** /riskmodel/checkanalysis | Check the status of the analysis of a specified risk assessment model
[**RiskmodelDelete**](RiskmodelApi.md#riskmodeldelete) | **DELETE** /riskmodel/{id} | Delete a risk assessment model
[**RiskmodelGet**](RiskmodelApi.md#riskmodelget) | **GET** /riskmodel/{id} | View details of a risk assessment model
[**RiskmodelGetscore**](RiskmodelApi.md#riskmodelgetscore) | **GET** /riskmodel/getscore | View the risk score for a specific user
[**RiskmodelList**](RiskmodelApi.md#riskmodellist) | **GET** /riskmodel/list | View a list of risk assessment models
[**RiskmodelPredict**](RiskmodelApi.md#riskmodelpredict) | **GET** /riskmodel/predict | Predict risk based on an assessment model
[**RiskmodelProcess**](RiskmodelApi.md#riskmodelprocess) | **GET** /riskmodel/process | Process a risk assessment model
[**RiskmodelRefresh**](RiskmodelApi.md#riskmodelrefresh) | **GET** /riskmodel/refresh | Refresh the information used in a risk assessment model
[**RiskmodelSave**](RiskmodelApi.md#riskmodelsave) | **POST** /riskmodel/{id} | Create or edit a risk assessment model
[**RiskmodelTermprecedences**](RiskmodelApi.md#riskmodeltermprecedences) | **GET** /riskmodel/termprecedences | View all default term precedences


<a name="riskmodelcheckanalysis"></a>
# **RiskmodelCheckanalysis**
> void RiskmodelCheckanalysis (Guid? id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelCheckanalysisExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var id = new Guid?(); // Guid? | The id of the risk assessment model whose analysis status has to be returned.

            try
            {
                // Check the status of the analysis of a specified risk assessment model
                apiInstance.RiskmodelCheckanalysis(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelCheckanalysis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodeldelete"></a>
# **RiskmodelDelete**
> void RiskmodelDelete (Guid? id, AnyType body)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var id = new Guid?(); // Guid? | The id of the risk assessment model to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a risk assessment model
                apiInstance.RiskmodelDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the risk assessment model to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelget"></a>
# **RiskmodelGet**
> void RiskmodelGet (Guid? id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var id = new Guid?(); // Guid? | The id of the risk assessment model to get.

            try
            {
                // View details of a risk assessment model
                apiInstance.RiskmodelGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the risk assessment model to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelgetscore"></a>
# **RiskmodelGetscore**
> void RiskmodelGetscore (Guid? userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelGetscoreExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var userid = new Guid?(); // Guid? | The id of the user to get the risk score.

            try
            {
                // View the risk score for a specific user
                apiInstance.RiskmodelGetscore(userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelGetscore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to get the risk score. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodellist"></a>
# **RiskmodelList**
> void RiskmodelList (int? from, int? count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of risk assessment models
                apiInstance.RiskmodelList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelList: " + e.Message );
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

<a name="riskmodelpredict"></a>
# **RiskmodelPredict**
> void RiskmodelPredict (Guid? id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelPredictExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var id = new Guid?(); // Guid? | The id of the assessment model to use in order to predict risk.

            try
            {
                // Predict risk based on an assessment model
                apiInstance.RiskmodelPredict(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelPredict: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the assessment model to use in order to predict risk. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelprocess"></a>
# **RiskmodelProcess**
> void RiskmodelProcess (Guid? id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelProcessExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var id = new Guid?(); // Guid? | The id of the risk assessment model to process.

            try
            {
                // Process a risk assessment model
                apiInstance.RiskmodelProcess(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the risk assessment model to process. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelrefresh"></a>
# **RiskmodelRefresh**
> void RiskmodelRefresh (Guid? id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelRefreshExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var id = new Guid?(); // Guid? | The id of the risk assessment model whose information has to be refreshed.

            try
            {
                // Refresh the information used in a risk assessment model
                apiInstance.RiskmodelRefresh(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelRefresh: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelsave"></a>
# **RiskmodelSave**
> void RiskmodelSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();
            var id = new Guid?(); // Guid? | The id of the department save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a risk assessment model
                apiInstance.RiskmodelSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the department save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodeltermprecedences"></a>
# **RiskmodelTermprecedences**
> void RiskmodelTermprecedences ()

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelTermprecedencesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RiskmodelApi();

            try
            {
                // View all default term precedences
                apiInstance.RiskmodelTermprecedences();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RiskmodelApi.RiskmodelTermprecedences: " + e.Message );
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

