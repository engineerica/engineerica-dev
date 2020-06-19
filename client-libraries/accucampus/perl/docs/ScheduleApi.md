# WWW::OpenAPIClient::ScheduleApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ScheduleApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**schedule_delete**](ScheduleApi.md#schedule_delete) | **DELETE** /schedule/delete | Delete a schedule slot
[**schedule_deletemine**](ScheduleApi.md#schedule_deletemine) | **DELETE** /schedule/deletemine | Delete a specific block from a user&#39;s own schedule
[**schedule_enable**](ScheduleApi.md#schedule_enable) | **GET** /schedule/enable | Enable or disable the schedule for a specific person
[**schedule_enablemine**](ScheduleApi.md#schedule_enablemine) | **GET** /schedule/enablemine | Enable or disable current user&#39;s schedule
[**schedule_findallstaffslots**](ScheduleApi.md#schedule_findallstaffslots) | **GET** /schedule/findallstaffslots | Search available schedule slots by service, event, date
[**schedule_findslots**](ScheduleApi.md#schedule_findslots) | **GET** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
[**schedule_findstaffavail**](ScheduleApi.md#schedule_findstaffavail) | **GET** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
[**schedule_get**](ScheduleApi.md#schedule_get) | **GET** /schedule/get | Search and view details of a specific schedule slot
[**schedule_getmine**](ScheduleApi.md#schedule_getmine) | **GET** /schedule/getmine | View details of a specific schedule block, for current user
[**schedule_getstaff**](ScheduleApi.md#schedule_getstaff) | **GET** /schedule/getstaff | View a list of schedule information of a specified person
[**schedule_getstaffmine**](ScheduleApi.md#schedule_getstaffmine) | **GET** /schedule/getstaffmine | View current user&#39;s schedule information
[**schedule_myofftimes**](ScheduleApi.md#schedule_myofftimes) | **GET** /schedule/myofftimes | View current user&#39;s schedule exceptions
[**schedule_save**](ScheduleApi.md#schedule_save) | **POST** /schedule/save | Create or edit a schedule slot
[**schedule_savemine**](ScheduleApi.md#schedule_savemine) | **POST** /schedule/savemine | Create or edit a block in current user&#39;s schedule


# **schedule_delete**
> schedule_delete(unknown_base_type => $unknown_base_type)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->schedule_delete(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_deletemine**
> schedule_deletemine(unknown_base_type => $unknown_base_type)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->schedule_deletemine(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_deletemine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_enable**
> schedule_enable(userid => $userid, enable => $enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to enable or disable the schedule.
my $enable = null; # boolean | True to enable schedules, false to disable.

eval { 
    $api_instance->schedule_enable(userid => $userid, enable => $enable);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_enable: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **boolean**| True to enable schedules, false to disable. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_enablemine**
> schedule_enablemine(enable => $enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $enable = null; # boolean | True to enable schedules, false to disable.

eval { 
    $api_instance->schedule_enablemine(enable => $enable);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_enablemine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enable** | **boolean**| True to enable schedules, false to disable. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_findallstaffslots**
> schedule_findallstaffslots(starttime => $starttime, endtime => $endtime, staffid => $staffid, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $staffid = null; # string | The id of the staff to filter by.
my $serviceids = "serviceids_example"; # string | CSV list of the service Ids to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the location to filter by.
my $staffroleids = "staffroleids_example"; # string | CSV list of the staff member role ids to filter by.
my $availablefor = "availablefor_example"; # string | The specific availability type to filter by.

eval { 
    $api_instance->schedule_findallstaffslots(starttime => $starttime, endtime => $endtime, staffid => $staffid, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_findallstaffslots: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **staffid** | [**string**](.md)| The id of the staff to filter by. | [optional] 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**string**](.md)| The id of the location to filter by. | [optional] 
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

# **schedule_findslots**
> schedule_findslots(staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, availablefor => $availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

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
my $availablefor = "availablefor_example"; # string | The specific availability type to filter by.

eval { 
    $api_instance->schedule_findslots(staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, availablefor => $availablefor);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_findslots: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**string**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**string**](.md)| The id of the service to filter by. | [optional] 
 **availablefor** | **string**| The specific availability type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_findstaffavail**
> schedule_findstaffavail(starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor, photosize => $photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $serviceids = "serviceids_example"; # string | CSV list of the service ids to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the service to filter by.
my $staffroleids = "staffroleids_example"; # string | CSV list of the staff member role ids to filter by.
my $availablefor = "availablefor_example"; # string | Filter slots by a specific availability type.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->schedule_findstaffavail(starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_findstaffavail: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service ids to filter by. | [optional] 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**string**](.md)| The id of the service to filter by. | [optional] 
 **staffroleids** | **string**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **string**| Filter slots by a specific availability type. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_get**
> schedule_get(scheduleid => $scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $scheduleid = null; # string | The id of the schedule.

eval { 
    $api_instance->schedule_get(scheduleid => $scheduleid);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**string**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_getmine**
> schedule_getmine(scheduleid => $scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $scheduleid = null; # string | The id of the schedule.

eval { 
    $api_instance->schedule_getmine(scheduleid => $scheduleid);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_getmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**string**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_getstaff**
> schedule_getstaff(userid => $userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to get info.

eval { 
    $api_instance->schedule_getstaff(userid => $userid);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_getstaff: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to get info. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_getstaffmine**
> schedule_getstaffmine()

View current user's schedule information

Allows the user to view their own schedule.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->schedule_getstaffmine();
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_getstaffmine: $@\n";
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

# **schedule_myofftimes**
> schedule_myofftimes(includedeleted => $includedeleted, onlyupcoming => $onlyupcoming, modifiedafter => $modifiedafter)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $includedeleted = null; # boolean | If true the deleted offtimes are also returned.
my $onlyupcoming = null; # boolean | If true then only upcoming offtimes are returned.
my $modifiedafter = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only offtimes modified after the specified date will be returned.

eval { 
    $api_instance->schedule_myofftimes(includedeleted => $includedeleted, onlyupcoming => $onlyupcoming, modifiedafter => $modifiedafter);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_myofftimes: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includedeleted** | **boolean**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **boolean**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_save**
> schedule_save(unknown_base_type => $unknown_base_type)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->schedule_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedule_savemine**
> schedule_savemine(unknown_base_type => $unknown_base_type)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ScheduleApi;
my $api_instance = WWW::OpenAPIClient::ScheduleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->schedule_savemine(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ScheduleApi->schedule_savemine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

