# Org.OpenAPITools.Api.AppointmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppointmentCancel**](AppointmentApi.md#appointmentcancel) | **GET** /appointment/cancel | Cancel an appointment
[**AppointmentCheckisvalid**](AppointmentApi.md#appointmentcheckisvalid) | **GET** /appointment/checkisvalid | Check if an appointment is valid or not
[**AppointmentEditanyway**](AppointmentApi.md#appointmenteditanyway) | **GET** /appointment/editanyway | Edit an appointment even if it breaks activated rules
[**AppointmentEditpresence**](AppointmentApi.md#appointmenteditpresence) | **GET** /appointment/editpresence | Edit the no-show status of an appointment
[**AppointmentFindallstaffslots**](AppointmentApi.md#appointmentfindallstaffslots) | **GET** /appointment/findallstaffslots | Finds all staff available slots filtered by service, date, etc
[**AppointmentFindslots**](AppointmentApi.md#appointmentfindslots) | **GET** /appointment/findslots | Finds available slots filtered by service, date, staff, etc
[**AppointmentFindstaff**](AppointmentApi.md#appointmentfindstaff) | **GET** /appointment/findstaff | Finds staff available by service, date, event, etc
[**AppointmentGet**](AppointmentApi.md#appointmentget) | **GET** /appointment/{id} | Search and view details of an appointment
[**AppointmentGetcurrent**](AppointmentApi.md#appointmentgetcurrent) | **GET** /appointment/getcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**AppointmentGetlocations**](AppointmentApi.md#appointmentgetlocations) | **GET** /appointment/getlocations | Find locations where a service is available
[**AppointmentList**](AppointmentApi.md#appointmentlist) | **GET** /appointment/list | View a list of appointments
[**AppointmentListmine**](AppointmentApi.md#appointmentlistmine) | **GET** /appointment/listmine | View all my upcoming appointments
[**AppointmentListupcoming**](AppointmentApi.md#appointmentlistupcoming) | **GET** /appointment/listupcoming | Search and view details of all my upcoming appointments
[**AppointmentRescheduleoutlook**](AppointmentApi.md#appointmentrescheduleoutlook) | **GET** /appointment/rescheduleoutlook | Reschedule an appointment from MS Outlook.
[**AppointmentRestore**](AppointmentApi.md#appointmentrestore) | **GET** /appointment/restore | Restore an appointment
[**AppointmentRestoreanyway**](AppointmentApi.md#appointmentrestoreanyway) | **GET** /appointment/restoreanyway | Restore an appointment even if it breaks activated rules
[**AppointmentSave**](AppointmentApi.md#appointmentsave) | **POST** /appointment/{id} | Schedule an appointment
[**AppointmentSetasvalid**](AppointmentApi.md#appointmentsetasvalid) | **GET** /appointment/setasvalid | Schedule an appointment even if it breaks activated rules
[**AppointmentSuggestlocations**](AppointmentApi.md#appointmentsuggestlocations) | **GET** /appointment/suggestlocations | View the locations with most appointments
[**AppointmentSuggestservices**](AppointmentApi.md#appointmentsuggestservices) | **GET** /appointment/suggestservices | View the services with most appointments
[**AppointmentVoid**](AppointmentApi.md#appointmentvoid) | **GET** /appointment/void | Void an appointment


<a name="appointmentcancel"></a>
# **AppointmentCancel**
> void AppointmentCancel (Guid? id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentCancelExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to cancel.

            try
            {
                // Cancel an appointment
                apiInstance.AppointmentCancel(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentcheckisvalid"></a>
# **AppointmentCheckisvalid**
> void AppointmentCheckisvalid (Guid? id, bool? editing)

Check if an appointment is valid or not

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentCheckisvalidExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to check.
            var editing = true;  // bool? | Specifies whether the check is for a new appointment or an existing one. (optional) 

            try
            {
                // Check if an appointment is valid or not
                apiInstance.AppointmentCheckisvalid(id, editing);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentCheckisvalid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to check. | 
 **editing** | **bool?**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmenteditanyway"></a>
# **AppointmentEditanyway**
> void AppointmentEditanyway (Guid? id, Guid? attendee, Guid? staff, Guid? location, DateTime? start, DateTime? end, Guid? term, Guid? _event, string services, string notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentEditanywayExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to edit.
            var attendee = new Guid?(); // Guid? | The id of the attendee involved in the appointment.
            var staff = new Guid?(); // Guid? | The id of the staff member involved in the appointment.
            var location = new Guid?(); // Guid? | The id of the location where the appointment will take place.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | The appointment's start date & time.
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | The appointment's end date & time.
            var term = new Guid?(); // Guid? | The id of the term when the appointment takes place. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event of the appointment. (optional) 
            var services = services_example;  // string | Comma-separated string containing the ids of the services of the appointment. (optional) 
            var notes = notes_example;  // string | The notes of the appointment. (optional) 

            try
            {
                // Edit an appointment even if it breaks activated rules
                apiInstance.AppointmentEditanyway(id, attendee, staff, location, start, end, term, _event, services, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentEditanyway: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to edit. | 
 **attendee** | [**Guid?**](.md)| The id of the attendee involved in the appointment. | 
 **staff** | [**Guid?**](.md)| The id of the staff member involved in the appointment. | 
 **location** | [**Guid?**](.md)| The id of the location where the appointment will take place. | 
 **start** | **DateTime?**| The appointment&#39;s start date &amp; time. | 
 **end** | **DateTime?**| The appointment&#39;s end date &amp; time. | 
 **term** | [**Guid?**](.md)| The id of the term when the appointment takes place. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event of the appointment. | [optional] 
 **services** | **string**| Comma-separated string containing the ids of the services of the appointment. | [optional] 
 **notes** | **string**| The notes of the appointment. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmenteditpresence"></a>
# **AppointmentEditpresence**
> void AppointmentEditpresence (Guid? id, bool? showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentEditpresenceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to edit its presence.
            var showedup = true;  // bool? | Specifies whether the attendee was showed-up or not in the appointment.

            try
            {
                // Edit the no-show status of an appointment
                apiInstance.AppointmentEditpresence(id, showedup);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentEditpresence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **bool?**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentfindallstaffslots"></a>
# **AppointmentFindallstaffslots**
> void AppointmentFindallstaffslots (DateTime? starttime, DateTime? endtime, string serviceids, Guid? locationid, Guid? eventid, int? photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentFindallstaffslotsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var serviceids = serviceids_example;  // string | CSV list of the service Ids to filter by.
            var locationid = new Guid?(); // Guid? | The id of the service to filter by.
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Finds all staff available slots filtered by service, date, etc
                apiInstance.AppointmentFindallstaffslots(starttime, endtime, serviceids, locationid, eventid, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentFindallstaffslots: " + e.Message );
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
 **serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentfindslots"></a>
# **AppointmentFindslots**
> void AppointmentFindslots (Guid? staffid, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentFindslotsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var staffid = new Guid?(); // Guid? | The id of the staff to filter by.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var serviceids = serviceids_example;  // string | CSV list of the service Ids to filter by.
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the service to filter by. (optional) 

            try
            {
                // Finds available slots filtered by service, date, staff, etc
                apiInstance.AppointmentFindslots(staffid, starttime, endtime, serviceids, eventid, locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentFindslots: " + e.Message );
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
 **serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentfindstaff"></a>
# **AppointmentFindstaff**
> void AppointmentFindstaff (string serviceids, DateTime? starttime, DateTime? endtime, Guid? eventid, Guid? locationid, int? photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentFindstaffExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var serviceids = serviceids_example;  // string | CSV list of the service ids to filter by.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the service to filter by. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Finds staff available by service, date, event, etc
                apiInstance.AppointmentFindstaff(serviceids, starttime, endtime, eventid, locationid, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentFindstaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceids** | **string**| CSV list of the service ids to filter by. | 
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentget"></a>
# **AppointmentGet**
> void AppointmentGet (Guid? id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to get.

            try
            {
                // Search and view details of an appointment
                apiInstance.AppointmentGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentgetcurrent"></a>
# **AppointmentGetcurrent**
> void AppointmentGetcurrent (Guid? station, string user, Guid? location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentGetcurrentExample
    {
        public void main()
        {
            var apiInstance = new AppointmentApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location where the user wants to sign-in.

            try
            {
                // Get the current appointments for the user that is about to sign-in via the specified sign-in station.
                apiInstance.AppointmentGetcurrent(station, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentGetcurrent: " + e.Message );
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
 **location** | [**Guid?**](.md)| The id of the location where the user wants to sign-in. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentgetlocations"></a>
# **AppointmentGetlocations**
> void AppointmentGetlocations (Guid? serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentGetlocationsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var serviceid = new Guid?(); // Guid? | The id of the service to get its locations.

            try
            {
                // Find locations where a service is available
                apiInstance.AppointmentGetlocations(serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentGetlocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**Guid?**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentlist"></a>
# **AppointmentList**
> void AppointmentList (int? from, int? count, DateTime? startdate, DateTime? enddate, Guid? userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the appointments. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the appointments. (optional) 
            var userid = new Guid?(); // Guid? | The attendee id to filter the appointments. (optional) 

            try
            {
                // View a list of appointments
                apiInstance.AppointmentList(from, count, startdate, enddate, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentList: " + e.Message );
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
 **startdate** | **DateTime?**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**Guid?**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentlistmine"></a>
# **AppointmentListmine**
> void AppointmentListmine (DateTime? start, DateTime? modifiedafter)

View all my upcoming appointments

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentListmineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only appointments that start after the specified date will be returned. (optional) 
            var modifiedafter = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only appointments modified after the specified date will be returned. (optional) 

            try
            {
                // View all my upcoming appointments
                apiInstance.AppointmentListmine(start, modifiedafter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentListmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime?**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentlistupcoming"></a>
# **AppointmentListupcoming**
> void AppointmentListupcoming (DateTime? start, DateTime? modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentListupcomingExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only appointments that start after the specified date will be returned. (optional) 
            var modifiedafter = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only appointments modified after the specified date will be returned. (optional) 

            try
            {
                // Search and view details of all my upcoming appointments
                apiInstance.AppointmentListupcoming(start, modifiedafter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentListupcoming: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime?**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime?**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentrescheduleoutlook"></a>
# **AppointmentRescheduleoutlook**
> void AppointmentRescheduleoutlook (Guid? id, DateTime? start, DateTime? end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentRescheduleoutlookExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to edit.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | The appointment's start date & time.
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | The appointment's end date & time.

            try
            {
                // Reschedule an appointment from MS Outlook.
                apiInstance.AppointmentRescheduleoutlook(id, start, end);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentRescheduleoutlook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to edit. | 
 **start** | **DateTime?**| The appointment&#39;s start date &amp; time. | 
 **end** | **DateTime?**| The appointment&#39;s end date &amp; time. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentrestore"></a>
# **AppointmentRestore**
> void AppointmentRestore (Guid? id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentRestoreExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to restore.

            try
            {
                // Restore an appointment
                apiInstance.AppointmentRestore(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentRestore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentrestoreanyway"></a>
# **AppointmentRestoreanyway**
> void AppointmentRestoreanyway (Guid? id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentRestoreanywayExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to restore.

            try
            {
                // Restore an appointment even if it breaks activated rules
                apiInstance.AppointmentRestoreanyway(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentRestoreanyway: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentsave"></a>
# **AppointmentSave**
> void AppointmentSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Schedule an appointment
                apiInstance.AppointmentSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentsetasvalid"></a>
# **AppointmentSetasvalid**
> void AppointmentSetasvalid (Guid? id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentSetasvalidExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to set as valid.

            try
            {
                // Schedule an appointment even if it breaks activated rules
                apiInstance.AppointmentSetasvalid(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentSetasvalid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to set as valid. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentsuggestlocations"></a>
# **AppointmentSuggestlocations**
> void AppointmentSuggestlocations ()

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentSuggestlocationsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();

            try
            {
                // View the locations with most appointments
                apiInstance.AppointmentSuggestlocations();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentSuggestlocations: " + e.Message );
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

<a name="appointmentsuggestservices"></a>
# **AppointmentSuggestservices**
> void AppointmentSuggestservices ()

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentSuggestservicesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();

            try
            {
                // View the services with most appointments
                apiInstance.AppointmentSuggestservices();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentSuggestservices: " + e.Message );
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

<a name="appointmentvoid"></a>
# **AppointmentVoid**
> void AppointmentVoid (Guid? id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentVoidExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentApi();
            var id = new Guid?(); // Guid? | The id of the appointment to cancel.

            try
            {
                // Void an appointment
                apiInstance.AppointmentVoid(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentApi.AppointmentVoid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

