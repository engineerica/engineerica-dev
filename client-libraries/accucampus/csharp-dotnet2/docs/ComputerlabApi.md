# Org.OpenAPITools.Api.ComputerlabApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ComputerlabDeletecomputer**](ComputerlabApi.md#computerlabdeletecomputer) | **DELETE** /computerlab/deletecomputer | Delete a computer
[**ComputerlabGetcomputer**](ComputerlabApi.md#computerlabgetcomputer) | **GET** /computerlab/getcomputer | Search and view details of a computer
[**ComputerlabGetsettings**](ComputerlabApi.md#computerlabgetsettings) | **GET** /computerlab/getsettings | Loads the settings for a computer lab
[**ComputerlabIssignedin**](ComputerlabApi.md#computerlabissignedin) | **GET** /computerlab/issignedin | Gets whether a user is signed-in or not.
[**ComputerlabListcomputers**](ComputerlabApi.md#computerlablistcomputers) | **GET** /computerlab/listcomputers | View a list of computers
[**ComputerlabListlabs**](ComputerlabApi.md#computerlablistlabs) | **GET** /computerlab/listlabs | View a list of the locations that use the Computer Lab add-on
[**ComputerlabListstations**](ComputerlabApi.md#computerlabliststations) | **GET** /computerlab/liststations | View a list of sign-in stations available for computer labs.
[**ComputerlabSavecomputer**](ComputerlabApi.md#computerlabsavecomputer) | **POST** /computerlab/savecomputer | Create or edit a computer
[**ComputerlabSavesettings**](ComputerlabApi.md#computerlabsavesettings) | **POST** /computerlab/savesettings | Saves the settings for a computer lab
[**ComputerlabSaveswipe**](ComputerlabApi.md#computerlabsaveswipe) | **POST** /computerlab/saveswipe | Save a new swipe from a computer in a computer lab.


<a name="computerlabdeletecomputer"></a>
# **ComputerlabDeletecomputer**
> void ComputerlabDeletecomputer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Delete a computer

Allows the user to delete an existing computer.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabDeletecomputerExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComputerlabApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Delete a computer
                apiInstance.ComputerlabDeletecomputer(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabDeletecomputer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabgetcomputer"></a>
# **ComputerlabGetcomputer**
> void ComputerlabGetcomputer (string id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabGetcomputerExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComputerlabApi();
            var id = id_example;  // string | The unique device id of the computer to get.

            try
            {
                // Search and view details of a computer
                apiInstance.ComputerlabGetcomputer(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabGetcomputer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The unique device id of the computer to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabgetsettings"></a>
# **ComputerlabGetsettings**
> void ComputerlabGetsettings (Guid? id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabGetsettingsExample
    {
        public void main()
        {
            var apiInstance = new ComputerlabApi();
            var id = new Guid?(); // Guid? | The id of the computer lab/location.

            try
            {
                // Loads the settings for a computer lab
                apiInstance.ComputerlabGetsettings(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabGetsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the computer lab/location. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabissignedin"></a>
# **ComputerlabIssignedin**
> void ComputerlabIssignedin (Guid? station, string user)

Gets whether a user is signed-in or not.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabIssignedinExample
    {
        public void main()
        {
            var apiInstance = new ComputerlabApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets whether a user is signed-in or not.
                apiInstance.ComputerlabIssignedin(station, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabIssignedin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlablistcomputers"></a>
# **ComputerlabListcomputers**
> void ComputerlabListcomputers (int? from, int? count, Guid? location, bool? freeonly)

View a list of computers

Allows the user to view the list of all computers.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabListcomputersExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComputerlabApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var location = new Guid?(); // Guid? | The id of the location whose computers have to be returned. (optional) 
            var freeonly = true;  // bool? | If true, only free computers will be returned. (optional) 

            try
            {
                // View a list of computers
                apiInstance.ComputerlabListcomputers(from, count, location, freeonly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabListcomputers: " + e.Message );
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
 **location** | [**Guid?**](.md)| The id of the location whose computers have to be returned. | [optional] 
 **freeonly** | **bool?**| If true, only free computers will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlablistlabs"></a>
# **ComputerlabListlabs**
> void ComputerlabListlabs ()

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabListlabsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComputerlabApi();

            try
            {
                // View a list of the locations that use the Computer Lab add-on
                apiInstance.ComputerlabListlabs();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabListlabs: " + e.Message );
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

<a name="computerlabliststations"></a>
# **ComputerlabListstations**
> void ComputerlabListstations ()

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabListstationsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComputerlabApi();

            try
            {
                // View a list of sign-in stations available for computer labs.
                apiInstance.ComputerlabListstations();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabListstations: " + e.Message );
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

<a name="computerlabsavecomputer"></a>
# **ComputerlabSavecomputer**
> void ComputerlabSavecomputer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a computer

Allows the user to create or edit a computer.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabSavecomputerExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComputerlabApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a computer
                apiInstance.ComputerlabSavecomputer(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabSavecomputer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabsavesettings"></a>
# **ComputerlabSavesettings**
> void ComputerlabSavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabSavesettingsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComputerlabApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves the settings for a computer lab
                apiInstance.ComputerlabSavesettings(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabSavesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabsaveswipe"></a>
# **ComputerlabSaveswipe**
> void ComputerlabSaveswipe (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a new swipe from a computer in a computer lab.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabSaveswipeExample
    {
        public void main()
        {
            var apiInstance = new ComputerlabApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a new swipe from a computer in a computer lab.
                apiInstance.ComputerlabSaveswipe(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComputerlabApi.ComputerlabSaveswipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

