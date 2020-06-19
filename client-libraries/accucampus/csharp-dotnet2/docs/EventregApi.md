# Org.OpenAPITools.Api.EventregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventregAddme**](EventregApi.md#eventregaddme) | **GET** /eventreg/addme | Register current user to a course
[**EventregAddmetoall**](EventregApi.md#eventregaddmetoall) | **GET** /eventreg/addmetoall | Register current user to all courses
[**EventregAddmetogroup**](EventregApi.md#eventregaddmetogroup) | **GET** /eventreg/addmetogroup | Register current user to a course group
[**EventregAdduser**](EventregApi.md#eventregadduser) | **GET** /eventreg/adduser | Register a user to a course for attendance
[**EventregAddusertoall**](EventregApi.md#eventregaddusertoall) | **GET** /eventreg/addusertoall | Register a user to assist with all courses
[**EventregAddusertogroup**](EventregApi.md#eventregaddusertogroup) | **GET** /eventreg/addusertogroup | Register a user to an course group
[**EventregGetevents**](EventregApi.md#eventreggetevents) | **GET** /eventreg/getevents | View course registration by user
[**EventregGetgroups**](EventregApi.md#eventreggetgroups) | **GET** /eventreg/getgroups | Lists the course group registrations of a user
[**EventregGetmyevents**](EventregApi.md#eventreggetmyevents) | **GET** /eventreg/getmyevents | View the event registrations of the current user
[**EventregGetmygroups**](EventregApi.md#eventreggetmygroups) | **GET** /eventreg/getmygroups | View all current user registrations to course groups
[**EventregGetusers**](EventregApi.md#eventreggetusers) | **GET** /eventreg/getusers | View course registration
[**EventregGetusersfromgroup**](EventregApi.md#eventreggetusersfromgroup) | **GET** /eventreg/getusersfromgroup | Lists the registrations for a course group
[**EventregGetuserstoall**](EventregApi.md#eventreggetuserstoall) | **GET** /eventreg/getuserstoall | View the users that are registered to all courses
[**EventregRemoveme**](EventregApi.md#eventregremoveme) | **GET** /eventreg/removeme | Unregister current user from a course
[**EventregRemovemefromall**](EventregApi.md#eventregremovemefromall) | **GET** /eventreg/removemefromall | Remove current user from the registration to all courses
[**EventregRemovemefromgroup**](EventregApi.md#eventregremovemefromgroup) | **GET** /eventreg/removemefromgroup | Remove current user from a course group
[**EventregRemoveuser**](EventregApi.md#eventregremoveuser) | **GET** /eventreg/removeuser | Remove a user from a course
[**EventregRemoveuserfromall**](EventregApi.md#eventregremoveuserfromall) | **GET** /eventreg/removeuserfromall | Remove a user from the registration to all courses
[**EventregRemoveuserfromgroup**](EventregApi.md#eventregremoveuserfromgroup) | **GET** /eventreg/removeuserfromgroup | Remove a user from a course group


<a name="eventregaddme"></a>
# **EventregAddme**
> void EventregAddme (Guid? eventid, string listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregAddmeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var eventid = new Guid?(); // Guid? | The id of the event.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register current user to a course
                apiInstance.EventregAddme(eventid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregAddme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregaddmetoall"></a>
# **EventregAddmetoall**
> void EventregAddmetoall (string listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregAddmetoallExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register current user to all courses
                apiInstance.EventregAddmetoall(listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregAddmetoall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregaddmetogroup"></a>
# **EventregAddmetogroup**
> void EventregAddmetogroup (string codegroup, string listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregAddmetogroupExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var codegroup = codegroup_example;  // string | The code used to group events.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register current user to a course group
                apiInstance.EventregAddmetogroup(codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregAddmetogroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | **string**| The code used to group events. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregadduser"></a>
# **EventregAdduser**
> void EventregAdduser (Guid? userid, Guid? eventid, string listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregAdduserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register a user to a course for attendance
                apiInstance.EventregAdduser(userid, eventid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregAdduser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregaddusertoall"></a>
# **EventregAddusertoall**
> void EventregAddusertoall (Guid? userid, string listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregAddusertoallExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register a user to assist with all courses
                apiInstance.EventregAddusertoall(userid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregAddusertoall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregaddusertogroup"></a>
# **EventregAddusertogroup**
> void EventregAddusertogroup (Guid? userid, string codegroup, string listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregAddusertogroupExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var codegroup = codegroup_example;  // string | The code used to group events.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register a user to an course group
                apiInstance.EventregAddusertogroup(userid, codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregAddusertogroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **codegroup** | **string**| The code used to group events. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetevents"></a>
# **EventregGetevents**
> void EventregGetevents (Guid? userid, string listname, Guid? termid, string namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregGeteventsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var userid = new Guid?(); // Guid? | The user id to list events.
            var listname = listname_example;  // string | The name of the list where the user is registered.
            var termid = new Guid?(); // Guid? | The term id to list events. (optional) 
            var namefilter = namefilter_example;  // string | The value used to filter the events by name. (optional) 

            try
            {
                // View course registration by user
                apiInstance.EventregGetevents(userid, listname, termid, namefilter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregGetevents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The user id to list events. | 
 **listname** | **string**| The name of the list where the user is registered. | 
 **termid** | [**Guid?**](.md)| The term id to list events. | [optional] 
 **namefilter** | **string**| The value used to filter the events by name. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetgroups"></a>
# **EventregGetgroups**
> void EventregGetgroups (Guid? userid, string listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregGetgroupsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var userid = new Guid?(); // Guid? | The user id to list events.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Lists the course group registrations of a user
                apiInstance.EventregGetgroups(userid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregGetgroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The user id to list events. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetmyevents"></a>
# **EventregGetmyevents**
> void EventregGetmyevents (string listname, Guid? termid, string namefilter)

View the event registrations of the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregGetmyeventsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var listname = listname_example;  // string | The name of the list where the user is registered.
            var termid = new Guid?(); // Guid? | The term id to list events. (optional) 
            var namefilter = namefilter_example;  // string | The value used to filter the events by name. (optional) 

            try
            {
                // View the event registrations of the current user
                apiInstance.EventregGetmyevents(listname, termid, namefilter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregGetmyevents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. | 
 **termid** | [**Guid?**](.md)| The term id to list events. | [optional] 
 **namefilter** | **string**| The value used to filter the events by name. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetmygroups"></a>
# **EventregGetmygroups**
> void EventregGetmygroups (string listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregGetmygroupsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // View all current user registrations to course groups
                apiInstance.EventregGetmygroups(listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregGetmygroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetusers"></a>
# **EventregGetusers**
> void EventregGetusers (Guid? eventid, string listname, int? photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregGetusersExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var eventid = new Guid?(); // Guid? | The event id to list users.
            var listname = listname_example;  // string | The name of the list to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View course registration
                apiInstance.EventregGetusers(eventid, listname, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregGetusers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The event id to list users. | 
 **listname** | **string**| The name of the list to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetusersfromgroup"></a>
# **EventregGetusersfromgroup**
> void EventregGetusersfromgroup (Guid? codegroup, string listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregGetusersfromgroupExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var codegroup = new Guid?(); // Guid? | The code group to list users.
            var listname = listname_example;  // string | The name of the list to get.

            try
            {
                // Lists the registrations for a course group
                apiInstance.EventregGetusersfromgroup(codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregGetusersfromgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**Guid?**](.md)| The code group to list users. | 
 **listname** | **string**| The name of the list to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetuserstoall"></a>
# **EventregGetuserstoall**
> void EventregGetuserstoall (string listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregGetuserstoallExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var listname = listname_example;  // string | The name of the list to get.

            try
            {
                // View the users that are registered to all courses
                apiInstance.EventregGetuserstoall(listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregGetuserstoall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremoveme"></a>
# **EventregRemoveme**
> void EventregRemoveme (Guid? eventid, string listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregRemovemeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var eventid = new Guid?(); // Guid? | The id of the event.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Unregister current user from a course
                apiInstance.EventregRemoveme(eventid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregRemoveme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremovemefromall"></a>
# **EventregRemovemefromall**
> void EventregRemovemefromall (string listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregRemovemefromallExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove current user from the registration to all courses
                apiInstance.EventregRemovemefromall(listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregRemovemefromall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremovemefromgroup"></a>
# **EventregRemovemefromgroup**
> void EventregRemovemefromgroup (Guid? codegroup, string listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregRemovemefromgroupExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var codegroup = new Guid?(); // Guid? | The code group of the events/courses.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove current user from a course group
                apiInstance.EventregRemovemefromgroup(codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregRemovemefromgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**Guid?**](.md)| The code group of the events/courses. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremoveuser"></a>
# **EventregRemoveuser**
> void EventregRemoveuser (Guid? userid, Guid? eventid, string listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregRemoveuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove a user from a course
                apiInstance.EventregRemoveuser(userid, eventid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregRemoveuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremoveuserfromall"></a>
# **EventregRemoveuserfromall**
> void EventregRemoveuserfromall (Guid? userid, string listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregRemoveuserfromallExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove a user from the registration to all courses
                apiInstance.EventregRemoveuserfromall(userid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregRemoveuserfromall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremoveuserfromgroup"></a>
# **EventregRemoveuserfromgroup**
> void EventregRemoveuserfromgroup (Guid? userid, Guid? codegroup, string listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregRemoveuserfromgroupExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventregApi();
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var codegroup = new Guid?(); // Guid? | The code group of the events/courses.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove a user from a course group
                apiInstance.EventregRemoveuserfromgroup(userid, codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventregApi.EventregRemoveuserfromgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **codegroup** | [**Guid?**](.md)| The code group of the events/courses. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

