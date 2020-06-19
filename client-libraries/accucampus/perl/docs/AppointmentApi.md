# WWW::OpenAPIClient::AppointmentApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AppointmentApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appointment_cancel**](AppointmentApi.md#appointment_cancel) | **GET** /appointment/cancel | Cancel an appointment
[**appointment_checkisvalid**](AppointmentApi.md#appointment_checkisvalid) | **GET** /appointment/checkisvalid | Check if an appointment is valid or not
[**appointment_editanyway**](AppointmentApi.md#appointment_editanyway) | **GET** /appointment/editanyway | Edit an appointment even if it breaks activated rules
[**appointment_editpresence**](AppointmentApi.md#appointment_editpresence) | **GET** /appointment/editpresence | Edit the no-show status of an appointment
[**appointment_findallstaffslots**](AppointmentApi.md#appointment_findallstaffslots) | **GET** /appointment/findallstaffslots | Finds all staff available slots filtered by service, date, etc
[**appointment_findslots**](AppointmentApi.md#appointment_findslots) | **GET** /appointment/findslots | Finds available slots filtered by service, date, staff, etc
[**appointment_findstaff**](AppointmentApi.md#appointment_findstaff) | **GET** /appointment/findstaff | Finds staff available by service, date, event, etc
[**appointment_get**](AppointmentApi.md#appointment_get) | **GET** /appointment/{id} | Search and view details of an appointment
[**appointment_getcurrent**](AppointmentApi.md#appointment_getcurrent) | **GET** /appointment/getcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**appointment_getlocations**](AppointmentApi.md#appointment_getlocations) | **GET** /appointment/getlocations | Find locations where a service is available
[**appointment_list**](AppointmentApi.md#appointment_list) | **GET** /appointment/list | View a list of appointments
[**appointment_listmine**](AppointmentApi.md#appointment_listmine) | **GET** /appointment/listmine | View all my upcoming appointments
[**appointment_listupcoming**](AppointmentApi.md#appointment_listupcoming) | **GET** /appointment/listupcoming | Search and view details of all my upcoming appointments
[**appointment_rescheduleoutlook**](AppointmentApi.md#appointment_rescheduleoutlook) | **GET** /appointment/rescheduleoutlook | Reschedule an appointment from MS Outlook.
[**appointment_restore**](AppointmentApi.md#appointment_restore) | **GET** /appointment/restore | Restore an appointment
[**appointment_restoreanyway**](AppointmentApi.md#appointment_restoreanyway) | **GET** /appointment/restoreanyway | Restore an appointment even if it breaks activated rules
[**appointment_save**](AppointmentApi.md#appointment_save) | **POST** /appointment/{id} | Schedule an appointment
[**appointment_setasvalid**](AppointmentApi.md#appointment_setasvalid) | **GET** /appointment/setasvalid | Schedule an appointment even if it breaks activated rules
[**appointment_suggestlocations**](AppointmentApi.md#appointment_suggestlocations) | **GET** /appointment/suggestlocations | View the locations with most appointments
[**appointment_suggestservices**](AppointmentApi.md#appointment_suggestservices) | **GET** /appointment/suggestservices | View the services with most appointments
[**appointment_void**](AppointmentApi.md#appointment_void) | **GET** /appointment/void | Void an appointment


# **appointment_cancel**
> appointment_cancel(id => $id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to cancel.

eval { 
    $api_instance->appointment_cancel(id => $id);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_cancel: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_checkisvalid**
> appointment_checkisvalid(id => $id, editing => $editing)

Check if an appointment is valid or not

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to check.
my $editing = null; # boolean | Specifies whether the check is for a new appointment or an existing one.

eval { 
    $api_instance->appointment_checkisvalid(id => $id, editing => $editing);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_checkisvalid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to check. | 
 **editing** | **boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_editanyway**
> appointment_editanyway(id => $id, attendee => $attendee, staff => $staff, location => $location, start => $start, end => $end, term => $term, event => $event, services => $services, notes => $notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to edit.
my $attendee = null; # string | The id of the attendee involved in the appointment.
my $staff = null; # string | The id of the staff member involved in the appointment.
my $location = null; # string | The id of the location where the appointment will take place.
my $start = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The appointment's start date & time.
my $end = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The appointment's end date & time.
my $term = null; # string | The id of the term when the appointment takes place.
my $event = null; # string | The id of the event of the appointment.
my $services = "services_example"; # string | Comma-separated string containing the ids of the services of the appointment.
my $notes = "notes_example"; # string | The notes of the appointment.

eval { 
    $api_instance->appointment_editanyway(id => $id, attendee => $attendee, staff => $staff, location => $location, start => $start, end => $end, term => $term, event => $event, services => $services, notes => $notes);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_editanyway: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to edit. | 
 **attendee** | [**string**](.md)| The id of the attendee involved in the appointment. | 
 **staff** | [**string**](.md)| The id of the staff member involved in the appointment. | 
 **location** | [**string**](.md)| The id of the location where the appointment will take place. | 
 **start** | **DateTime**| The appointment&#39;s start date &amp; time. | 
 **end** | **DateTime**| The appointment&#39;s end date &amp; time. | 
 **term** | [**string**](.md)| The id of the term when the appointment takes place. | [optional] 
 **event** | [**string**](.md)| The id of the event of the appointment. | [optional] 
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

# **appointment_editpresence**
> appointment_editpresence(id => $id, showedup => $showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to edit its presence.
my $showedup = null; # boolean | Specifies whether the attendee was showed-up or not in the appointment.

eval { 
    $api_instance->appointment_editpresence(id => $id, showedup => $showedup);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_editpresence: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **boolean**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_findallstaffslots**
> appointment_findallstaffslots(starttime => $starttime, endtime => $endtime, serviceids => $serviceids, locationid => $locationid, eventid => $eventid, photosize => $photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $serviceids = "serviceids_example"; # string | CSV list of the service Ids to filter by.
my $locationid = null; # string | The id of the service to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->appointment_findallstaffslots(starttime => $starttime, endtime => $endtime, serviceids => $serviceids, locationid => $locationid, eventid => $eventid, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_findallstaffslots: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **locationid** | [**string**](.md)| The id of the service to filter by. | 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_findslots**
> appointment_findslots(staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $staffid = null; # string | The id of the staff to filter by.
my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $serviceids = "serviceids_example"; # string | CSV list of the service Ids to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the service to filter by.

eval { 
    $api_instance->appointment_findslots(staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_findslots: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**string**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**string**](.md)| The id of the service to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_findstaff**
> appointment_findstaff(serviceids => $serviceids, starttime => $starttime, endtime => $endtime, eventid => $eventid, locationid => $locationid, photosize => $photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceids = "serviceids_example"; # string | CSV list of the service ids to filter by.
my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the service to filter by.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->appointment_findstaff(serviceids => $serviceids, starttime => $starttime, endtime => $endtime, eventid => $eventid, locationid => $locationid, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_findstaff: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceids** | **string**| CSV list of the service ids to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**string**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_get**
> appointment_get(id => $id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to get.

eval { 
    $api_instance->appointment_get(id => $id);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_getcurrent**
> appointment_getcurrent(station => $station, user => $user, location => $location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location where the user wants to sign-in.

eval { 
    $api_instance->appointment_getcurrent(station => $station, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_getcurrent: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 
 **location** | [**string**](.md)| The id of the location where the user wants to sign-in. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_getlocations**
> appointment_getlocations(serviceid => $serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $serviceid = null; # string | The id of the service to get its locations.

eval { 
    $api_instance->appointment_getlocations(serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_getlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_list**
> appointment_list(from => $from, count => $count, startdate => $startdate, enddate => $enddate, userid => $userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the appointments.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the appointments.
my $userid = null; # string | The attendee id to filter the appointments.

eval { 
    $api_instance->appointment_list(from => $from, count => $count, startdate => $startdate, enddate => $enddate, userid => $userid);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **startdate** | **DateTime**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**string**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_listmine**
> appointment_listmine(start => $start, modifiedafter => $modifiedafter)

View all my upcoming appointments

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $start = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only appointments that start after the specified date will be returned.
my $modifiedafter = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only appointments modified after the specified date will be returned.

eval { 
    $api_instance->appointment_listmine(start => $start, modifiedafter => $modifiedafter);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_listmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_listupcoming**
> appointment_listupcoming(start => $start, modifiedafter => $modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $start = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only appointments that start after the specified date will be returned.
my $modifiedafter = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only appointments modified after the specified date will be returned.

eval { 
    $api_instance->appointment_listupcoming(start => $start, modifiedafter => $modifiedafter);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_listupcoming: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_rescheduleoutlook**
> appointment_rescheduleoutlook(id => $id, start => $start, end => $end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to edit.
my $start = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The appointment's start date & time.
my $end = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The appointment's end date & time.

eval { 
    $api_instance->appointment_rescheduleoutlook(id => $id, start => $start, end => $end);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_rescheduleoutlook: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to edit. | 
 **start** | **DateTime**| The appointment&#39;s start date &amp; time. | 
 **end** | **DateTime**| The appointment&#39;s end date &amp; time. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_restore**
> appointment_restore(id => $id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to restore.

eval { 
    $api_instance->appointment_restore(id => $id);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_restore: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_restoreanyway**
> appointment_restoreanyway(id => $id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to restore.

eval { 
    $api_instance->appointment_restoreanyway(id => $id);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_restoreanyway: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_save**
> appointment_save(id => $id, unknown_base_type => $unknown_base_type)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->appointment_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_setasvalid**
> appointment_setasvalid(id => $id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to set as valid.

eval { 
    $api_instance->appointment_setasvalid(id => $id);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_setasvalid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to set as valid. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointment_suggestlocations**
> appointment_suggestlocations()

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->appointment_suggestlocations();
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_suggestlocations: $@\n";
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

# **appointment_suggestservices**
> appointment_suggestservices()

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->appointment_suggestservices();
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_suggestservices: $@\n";
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

# **appointment_void**
> appointment_void(id => $id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AppointmentApi;
my $api_instance = WWW::OpenAPIClient::AppointmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the appointment to cancel.

eval { 
    $api_instance->appointment_void(id => $id);
};
if ($@) {
    warn "Exception when calling AppointmentApi->appointment_void: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

