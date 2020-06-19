# Org.OpenAPITools.Api.StaffavailApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StaffavailAddmetoallservices**](StaffavailApi.md#staffavailaddmetoallservices) | **GET** /staffavail/addmetoallservices | Associate current user to all services
[**StaffavailAddmetoservice**](StaffavailApi.md#staffavailaddmetoservice) | **GET** /staffavail/addmetoservice | Associate current user to a service
[**StaffavailAddusertoallservices**](StaffavailApi.md#staffavailaddusertoallservices) | **GET** /staffavail/addusertoallservices | Associate a staff member to all services
[**StaffavailAddusertoservice**](StaffavailApi.md#staffavailaddusertoservice) | **GET** /staffavail/addusertoservice | Associate a staff member to a service
[**StaffavailGetmyservices**](StaffavailApi.md#staffavailgetmyservices) | **GET** /staffavail/getmyservices | View the services the current user is available for
[**StaffavailGetservices**](StaffavailApi.md#staffavailgetservices) | **GET** /staffavail/getservices | View a list of services that a staff member is available for
[**StaffavailGetusersforservice**](StaffavailApi.md#staffavailgetusersforservice) | **GET** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
[**StaffavailListtypes**](StaffavailApi.md#staffavaillisttypes) | **GET** /staffavail/listtypes | View all the availability types
[**StaffavailRemovemefromallservices**](StaffavailApi.md#staffavailremovemefromallservices) | **GET** /staffavail/removemefromallservices | Remove current user from all services
[**StaffavailRemovemefromservice**](StaffavailApi.md#staffavailremovemefromservice) | **GET** /staffavail/removemefromservice | Remove current user from a service
[**StaffavailRemoveuserfromallservices**](StaffavailApi.md#staffavailremoveuserfromallservices) | **GET** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
[**StaffavailRemoveuserfromservice**](StaffavailApi.md#staffavailremoveuserfromservice) | **GET** /staffavail/removeuserfromservice | Remove a staff member from a service
[**StaffavailSetavailability**](StaffavailApi.md#staffavailsetavailability) | **GET** /staffavail/setavailability | Make a staff member available for a specific availability type
[**StaffavailSetmyavailability**](StaffavailApi.md#staffavailsetmyavailability) | **GET** /staffavail/setmyavailability | Change current user&#39;s availability type


<a name="staffavailaddmetoallservices"></a>
# **StaffavailAddmetoallservices**
> void StaffavailAddmetoallservices ()

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailAddmetoallservicesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();

            try
            {
                // Associate current user to all services
                apiInstance.StaffavailAddmetoallservices();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailAddmetoallservices: " + e.Message );
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

<a name="staffavailaddmetoservice"></a>
# **StaffavailAddmetoservice**
> void StaffavailAddmetoservice (Guid? serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailAddmetoserviceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var serviceid = new Guid?(); // Guid? | The id of the service.

            try
            {
                // Associate current user to a service
                apiInstance.StaffavailAddmetoservice(serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailAddmetoservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**Guid?**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailaddusertoallservices"></a>
# **StaffavailAddusertoallservices**
> void StaffavailAddusertoallservices (Guid? userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailAddusertoallservicesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var userid = new Guid?(); // Guid? | The id of the user to add.

            try
            {
                // Associate a staff member to all services
                apiInstance.StaffavailAddusertoallservices(userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailAddusertoallservices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to add. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailaddusertoservice"></a>
# **StaffavailAddusertoservice**
> void StaffavailAddusertoservice (Guid? userid, Guid? serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailAddusertoserviceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var serviceid = new Guid?(); // Guid? | The id of the service.

            try
            {
                // Associate a staff member to a service
                apiInstance.StaffavailAddusertoservice(userid, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailAddusertoservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **serviceid** | [**Guid?**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailgetmyservices"></a>
# **StaffavailGetmyservices**
> void StaffavailGetmyservices ()

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailGetmyservicesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();

            try
            {
                // View the services the current user is available for
                apiInstance.StaffavailGetmyservices();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailGetmyservices: " + e.Message );
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

<a name="staffavailgetservices"></a>
# **StaffavailGetservices**
> void StaffavailGetservices (Guid? userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailGetservicesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var userid = new Guid?(); // Guid? | The user id to list services.

            try
            {
                // View a list of services that a staff member is available for
                apiInstance.StaffavailGetservices(userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailGetservices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The user id to list services. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailgetusersforservice"></a>
# **StaffavailGetusersforservice**
> void StaffavailGetusersforservice (Guid? serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailGetusersforserviceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var serviceid = new Guid?(); // Guid? | The service id to list users.

            try
            {
                // View a list of staff members that are available for a specific service
                apiInstance.StaffavailGetusersforservice(serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailGetusersforservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**Guid?**](.md)| The service id to list users. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavaillisttypes"></a>
# **StaffavailListtypes**
> void StaffavailListtypes ()

View all the availability types

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailListtypesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();

            try
            {
                // View all the availability types
                apiInstance.StaffavailListtypes();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailListtypes: " + e.Message );
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

<a name="staffavailremovemefromallservices"></a>
# **StaffavailRemovemefromallservices**
> void StaffavailRemovemefromallservices ()

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailRemovemefromallservicesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();

            try
            {
                // Remove current user from all services
                apiInstance.StaffavailRemovemefromallservices();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailRemovemefromallservices: " + e.Message );
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

<a name="staffavailremovemefromservice"></a>
# **StaffavailRemovemefromservice**
> void StaffavailRemovemefromservice (Guid? serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailRemovemefromserviceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var serviceid = new Guid?(); // Guid? | The id of the service.

            try
            {
                // Remove current user from a service
                apiInstance.StaffavailRemovemefromservice(serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailRemovemefromservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**Guid?**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailremoveuserfromallservices"></a>
# **StaffavailRemoveuserfromallservices**
> void StaffavailRemoveuserfromallservices (Guid? userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailRemoveuserfromallservicesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var userid = new Guid?(); // Guid? | The id of the user to remove.

            try
            {
                // Removes a staff member from the registration to all services
                apiInstance.StaffavailRemoveuserfromallservices(userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailRemoveuserfromallservices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailremoveuserfromservice"></a>
# **StaffavailRemoveuserfromservice**
> void StaffavailRemoveuserfromservice (Guid? userid, Guid? serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailRemoveuserfromserviceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var serviceid = new Guid?(); // Guid? | The id of the service.

            try
            {
                // Remove a staff member from a service
                apiInstance.StaffavailRemoveuserfromservice(userid, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailRemoveuserfromservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **serviceid** | [**Guid?**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailsetavailability"></a>
# **StaffavailSetavailability**
> void StaffavailSetavailability (Guid? userid, string availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailSetavailabilityExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var userid = new Guid?(); // Guid? | The id of the user whose specific availability has to be set.
            var availablefor = availablefor_example;  // string | Specific availability to set. (optional) 

            try
            {
                // Make a staff member available for a specific availability type
                apiInstance.StaffavailSetavailability(userid, availablefor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailSetavailability: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user whose specific availability has to be set. | 
 **availablefor** | **string**| Specific availability to set. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailsetmyavailability"></a>
# **StaffavailSetmyavailability**
> void StaffavailSetmyavailability (string availablefor)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailSetmyavailabilityExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffavailApi();
            var availablefor = availablefor_example;  // string | Specific availability to set. (optional) 

            try
            {
                // Change current user's availability type
                apiInstance.StaffavailSetmyavailability(availablefor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffavailApi.StaffavailSetmyavailability: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **availablefor** | **string**| Specific availability to set. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

