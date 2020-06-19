# Org.OpenAPITools.Api.ScheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScheduleDelete**](ScheduleApi.md#scheduledelete) | **DELETE** /schedule/delete | Delete a schedule slot
[**ScheduleDeletemine**](ScheduleApi.md#scheduledeletemine) | **DELETE** /schedule/deletemine | Delete a specific block from a user&#39;s own schedule
[**ScheduleEnable**](ScheduleApi.md#scheduleenable) | **GET** /schedule/enable | Enable or disable the schedule for a specific person
[**ScheduleEnablemine**](ScheduleApi.md#scheduleenablemine) | **GET** /schedule/enablemine | Enable or disable current user&#39;s schedule
[**ScheduleFindallstaffslots**](ScheduleApi.md#schedulefindallstaffslots) | **GET** /schedule/findallstaffslots | Search available schedule slots by service, event, date
[**ScheduleFindslots**](ScheduleApi.md#schedulefindslots) | **GET** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
[**ScheduleFindstaffavail**](ScheduleApi.md#schedulefindstaffavail) | **GET** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
[**ScheduleGet**](ScheduleApi.md#scheduleget) | **GET** /schedule/get | Search and view details of a specific schedule slot
[**ScheduleGetmine**](ScheduleApi.md#schedulegetmine) | **GET** /schedule/getmine | View details of a specific schedule block, for current user
[**ScheduleGetstaff**](ScheduleApi.md#schedulegetstaff) | **GET** /schedule/getstaff | View a list of schedule information of a specified person
[**ScheduleGetstaffmine**](ScheduleApi.md#schedulegetstaffmine) | **GET** /schedule/getstaffmine | View current user&#39;s schedule information
[**ScheduleMyofftimes**](ScheduleApi.md#schedulemyofftimes) | **GET** /schedule/myofftimes | View current user&#39;s schedule exceptions
[**ScheduleSave**](ScheduleApi.md#schedulesave) | **POST** /schedule/save | Create or edit a schedule slot
[**ScheduleSavemine**](ScheduleApi.md#schedulesavemine) | **POST** /schedule/savemine | Create or edit a block in current user&#39;s schedule


<a name="scheduledelete"></a>
# **ScheduleDelete**
> void ScheduleDelete (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Delete a schedule slot
                apiInstance.ScheduleDelete(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleDelete: " + e.Message );
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

<a name="scheduledeletemine"></a>
# **ScheduleDeletemine**
> void ScheduleDeletemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleDeletemineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Delete a specific block from a user's own schedule
                apiInstance.ScheduleDeletemine(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleDeletemine: " + e.Message );
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

<a name="scheduleenable"></a>
# **ScheduleEnable**
> void ScheduleEnable (Guid? userid, bool? enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleEnableExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var userid = new Guid?(); // Guid? | The id of the user to enable or disable the schedule.
            var enable = true;  // bool? | True to enable schedules, false to disable.

            try
            {
                // Enable or disable the schedule for a specific person
                apiInstance.ScheduleEnable(userid, enable);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleEnable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **bool?**| True to enable schedules, false to disable. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleenablemine"></a>
# **ScheduleEnablemine**
> void ScheduleEnablemine (bool? enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleEnablemineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var enable = true;  // bool? | True to enable schedules, false to disable.

            try
            {
                // Enable or disable current user's schedule
                apiInstance.ScheduleEnablemine(enable);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleEnablemine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enable** | **bool?**| True to enable schedules, false to disable. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulefindallstaffslots"></a>
# **ScheduleFindallstaffslots**
> void ScheduleFindallstaffslots (DateTime? starttime, DateTime? endtime, Guid? staffid, string serviceids, Guid? eventid, Guid? locationid, string staffroleids, string availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleFindallstaffslotsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var staffid = new Guid?(); // Guid? | The id of the staff to filter by. (optional) 
            var serviceids = serviceids_example;  // string | CSV list of the service Ids to filter by. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the location to filter by. (optional) 
            var staffroleids = staffroleids_example;  // string | CSV list of the staff member role ids to filter by. (optional) 
            var availablefor = availablefor_example;  // string | The specific availability type to filter by. (optional) 

            try
            {
                // Search available schedule slots by service, event, date
                apiInstance.ScheduleFindallstaffslots(starttime, endtime, staffid, serviceids, eventid, locationid, staffroleids, availablefor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleFindallstaffslots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **staffid** | [**Guid?**](.md)| The id of the staff to filter by. | [optional] 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the location to filter by. | [optional] 
 **staffroleids** | **string**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **string**| The specific availability type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulefindslots"></a>
# **ScheduleFindslots**
> void ScheduleFindslots (Guid? staffid, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid, string availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleFindslotsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var staffid = new Guid?(); // Guid? | The id of the staff to filter by.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var serviceids = serviceids_example;  // string | CSV list of the service Ids to filter by. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the service to filter by. (optional) 
            var availablefor = availablefor_example;  // string | The specific availability type to filter by. (optional) 

            try
            {
                // Search available schedule slots by service, event, date and/or staff
                apiInstance.ScheduleFindslots(staffid, starttime, endtime, serviceids, eventid, locationid, availablefor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleFindslots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**Guid?**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | [optional] 
 **availablefor** | **string**| The specific availability type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulefindstaffavail"></a>
# **ScheduleFindstaffavail**
> void ScheduleFindstaffavail (DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid, string staffroleids, string availablefor, int? photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleFindstaffavailExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var serviceids = serviceids_example;  // string | CSV list of the service ids to filter by. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the service to filter by. (optional) 
            var staffroleids = staffroleids_example;  // string | CSV list of the staff member role ids to filter by. (optional) 
            var availablefor = availablefor_example;  // string | Filter slots by a specific availability type. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Search available staff members slots by service, event, and/or date
                apiInstance.ScheduleFindstaffavail(starttime, endtime, serviceids, eventid, locationid, staffroleids, availablefor, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleFindstaffavail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service ids to filter by. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | [optional] 
 **staffroleids** | **string**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **string**| Filter slots by a specific availability type. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleget"></a>
# **ScheduleGet**
> void ScheduleGet (Guid? scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var scheduleid = new Guid?(); // Guid? | The id of the schedule.

            try
            {
                // Search and view details of a specific schedule slot
                apiInstance.ScheduleGet(scheduleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**Guid?**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulegetmine"></a>
# **ScheduleGetmine**
> void ScheduleGetmine (Guid? scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleGetmineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var scheduleid = new Guid?(); // Guid? | The id of the schedule.

            try
            {
                // View details of a specific schedule block, for current user
                apiInstance.ScheduleGetmine(scheduleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleGetmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**Guid?**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulegetstaff"></a>
# **ScheduleGetstaff**
> void ScheduleGetstaff (Guid? userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleGetstaffExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var userid = new Guid?(); // Guid? | The id of the user to get info.

            try
            {
                // View a list of schedule information of a specified person
                apiInstance.ScheduleGetstaff(userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleGetstaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to get info. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulegetstaffmine"></a>
# **ScheduleGetstaffmine**
> void ScheduleGetstaffmine ()

View current user's schedule information

Allows the user to view their own schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleGetstaffmineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();

            try
            {
                // View current user's schedule information
                apiInstance.ScheduleGetstaffmine();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleGetstaffmine: " + e.Message );
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

<a name="schedulemyofftimes"></a>
# **ScheduleMyofftimes**
> void ScheduleMyofftimes (bool? includedeleted, bool? onlyupcoming, DateTime? modifiedafter)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleMyofftimesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var includedeleted = true;  // bool? | If true the deleted offtimes are also returned. (optional) 
            var onlyupcoming = true;  // bool? | If true then only upcoming offtimes are returned. (optional) 
            var modifiedafter = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only offtimes modified after the specified date will be returned. (optional) 

            try
            {
                // View current user's schedule exceptions
                apiInstance.ScheduleMyofftimes(includedeleted, onlyupcoming, modifiedafter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleMyofftimes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includedeleted** | **bool?**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **bool?**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **DateTime?**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulesave"></a>
# **ScheduleSave**
> void ScheduleSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a schedule slot
                apiInstance.ScheduleSave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleSave: " + e.Message );
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

<a name="schedulesavemine"></a>
# **ScheduleSavemine**
> void ScheduleSavemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleSavemineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a block in current user's schedule
                apiInstance.ScheduleSavemine(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.ScheduleSavemine: " + e.Message );
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

