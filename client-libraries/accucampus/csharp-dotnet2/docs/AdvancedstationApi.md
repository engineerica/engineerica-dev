# Org.OpenAPITools.Api.AdvancedstationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdvancedstationCheckunknownuser**](AdvancedstationApi.md#advancedstationcheckunknownuser) | **GET** /advancedstation/checkunknownuser | Check whether the user is known by the system.
[**AdvancedstationCheckuserrole**](AdvancedstationApi.md#advancedstationcheckuserrole) | **GET** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
[**AdvancedstationCreateuser**](AdvancedstationApi.md#advancedstationcreateuser) | **GET** /advancedstation/createuser | Creates a user via a sign-in station.
[**AdvancedstationGetevents**](AdvancedstationApi.md#advancedstationgetevents) | **GET** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
[**AdvancedstationGetinfo**](AdvancedstationApi.md#advancedstationgetinfo) | **GET** /advancedstation/getinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**AdvancedstationGetlocations**](AdvancedstationApi.md#advancedstationgetlocations) | **GET** /advancedstation/getlocations | Gets the locations available in a sign-in station.
[**AdvancedstationGetlogstaff**](AdvancedstationApi.md#advancedstationgetlogstaff) | **GET** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**AdvancedstationGetroles**](AdvancedstationApi.md#advancedstationgetroles) | **GET** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
[**AdvancedstationGetservices**](AdvancedstationApi.md#advancedstationgetservices) | **GET** /advancedstation/getservices | Gets the services available for a specific location.
[**AdvancedstationGetstaff**](AdvancedstationApi.md#advancedstationgetstaff) | **GET** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
[**AdvancedstationIssignedin**](AdvancedstationApi.md#advancedstationissignedin) | **GET** /advancedstation/issignedin | Gets whether a user is signed-in or not.


<a name="advancedstationcheckunknownuser"></a>
# **AdvancedstationCheckunknownuser**
> void AdvancedstationCheckunknownuser (Guid? station, string user, Guid? location)

Check whether the user is known by the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationCheckunknownuserExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked.

            try
            {
                // Check whether the user is known by the system.
                apiInstance.AdvancedstationCheckunknownuser(station, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationCheckunknownuser: " + e.Message );
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
 **location** | [**Guid?**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationcheckuserrole"></a>
# **AdvancedstationCheckuserrole**
> void AdvancedstationCheckuserrole (Guid? station, string user, Guid? location)

Check whether the user is a staff member, an attendee or both.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationCheckuserroleExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked.

            try
            {
                // Check whether the user is a staff member, an attendee or both.
                apiInstance.AdvancedstationCheckuserrole(station, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationCheckuserrole: " + e.Message );
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
 **location** | [**Guid?**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationcreateuser"></a>
# **AdvancedstationCreateuser**
> void AdvancedstationCreateuser (Guid? station, string user, Guid? location, string firstname, string lastname, string email, string middlename)

Creates a user via a sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationCreateuserExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user to create.
            var location = new Guid?(); // Guid? | The id of the location the user picked.
            var firstname = firstname_example;  // string | The first name of the user to create.
            var lastname = lastname_example;  // string | The last name of the user to create.
            var email = email_example;  // string | The email of the user to create.
            var middlename = middlename_example;  // string | The middle name of the user to create. (optional) 

            try
            {
                // Creates a user via a sign-in station.
                apiInstance.AdvancedstationCreateuser(station, user, location, firstname, lastname, email, middlename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationCreateuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user to create. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | 
 **firstname** | **string**| The first name of the user to create. | 
 **lastname** | **string**| The last name of the user to create. | 
 **email** | **string**| The email of the user to create. | 
 **middlename** | **string**| The middle name of the user to create. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetevents"></a>
# **AdvancedstationGetevents**
> void AdvancedstationGetevents (Guid? station, Guid? location, string user)

Gets the courses available for a specific location and a specific student.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationGeteventsExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var location = new Guid?(); // Guid? | The id of the location the student picked.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets the courses available for a specific location and a specific student.
                apiInstance.AdvancedstationGetevents(station, location, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationGetevents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **location** | [**Guid?**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetinfo"></a>
# **AdvancedstationGetinfo**
> void AdvancedstationGetinfo (Guid? id, Guid? _event)

Gets the info to display in the sign-in station by it's ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationGetinfoExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to get.
            var _event = new Guid?(); // Guid? | The id of the event (or session), to override the scheduled one. (optional) 

            try
            {
                // Gets the info to display in the sign-in station by it's ID.
                apiInstance.AdvancedstationGetinfo(id, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationGetinfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **_event** | [**Guid?**](.md)| The id of the event (or session), to override the scheduled one. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetlocations"></a>
# **AdvancedstationGetlocations**
> void AdvancedstationGetlocations (Guid? station, string user)

Gets the locations available in a sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationGetlocationsExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station whose locations have to be returned.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets the locations available in a sign-in station.
                apiInstance.AdvancedstationGetlocations(station, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationGetlocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station whose locations have to be returned. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetlogstaff"></a>
# **AdvancedstationGetlogstaff**
> void AdvancedstationGetlogstaff (Guid? station, Guid? attendancelog, int? photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationGetlogstaffExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var attendancelog = new Guid?(); // Guid? | The id of the attendance log to filter the staff members.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
                apiInstance.AdvancedstationGetlogstaff(station, attendancelog, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationGetlogstaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **attendancelog** | [**Guid?**](.md)| The id of the attendance log to filter the staff members. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetroles"></a>
# **AdvancedstationGetroles**
> void AdvancedstationGetroles (Guid? station, string signinrole, string user, Guid? location)

Gets the user roles of the user trying to sign-in.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationGetrolesExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var signinrole = signinrole_example;  // string | Specifies how the user is signing-in.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked.

            try
            {
                // Gets the user roles of the user trying to sign-in.
                apiInstance.AdvancedstationGetroles(station, signinrole, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationGetroles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **signinrole** | **string**| Specifies how the user is signing-in. | 
 **user** | **string**| The card of the user. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetservices"></a>
# **AdvancedstationGetservices**
> void AdvancedstationGetservices (Guid? station, Guid? location, string user)

Gets the services available for a specific location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationGetservicesExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var location = new Guid?(); // Guid? | The id of the location the student picked.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets the services available for a specific location.
                apiInstance.AdvancedstationGetservices(station, location, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationGetservices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **location** | [**Guid?**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetstaff"></a>
# **AdvancedstationGetstaff**
> void AdvancedstationGetstaff (Guid? station, Guid? locationid, string user, string services, Guid? eventid, int? photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationGetstaffExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var locationid = new Guid?(); // Guid? | The id of the location the student picked.
            var user = user_example;  // string | The card of the user.
            var services = services_example;  // string | The list of services selected by the user, in JSON format. (optional) 
            var eventid = new Guid?(); // Guid? | The ID of the event selected. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Gets the staff/tutors available for a specific location, course and service.
                apiInstance.AdvancedstationGetstaff(station, locationid, user, services, eventid, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationGetstaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **locationid** | [**Guid?**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 
 **services** | **string**| The list of services selected by the user, in JSON format. | [optional] 
 **eventid** | [**Guid?**](.md)| The ID of the event selected. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationissignedin"></a>
# **AdvancedstationIssignedin**
> void AdvancedstationIssignedin (Guid? station, DateTime? time, string user, Guid? location)

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
    public class AdvancedstationIssignedinExample
    {
        public void main()
        {
            var apiInstance = new AdvancedstationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var time = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time of the swipe.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked. (optional) 

            try
            {
                // Gets whether a user is signed-in or not.
                apiInstance.AdvancedstationIssignedin(station, time, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedstationApi.AdvancedstationIssignedin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **time** | **DateTime?**| The date and time of the swipe. | 
 **user** | **string**| The card of the user. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

