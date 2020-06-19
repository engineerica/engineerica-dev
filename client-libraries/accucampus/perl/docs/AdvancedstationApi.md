# WWW::OpenAPIClient::AdvancedstationApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AdvancedstationApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advancedstation_checkunknownuser**](AdvancedstationApi.md#advancedstation_checkunknownuser) | **GET** /advancedstation/checkunknownuser | Check whether the user is known by the system.
[**advancedstation_checkuserrole**](AdvancedstationApi.md#advancedstation_checkuserrole) | **GET** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
[**advancedstation_createuser**](AdvancedstationApi.md#advancedstation_createuser) | **GET** /advancedstation/createuser | Creates a user via a sign-in station.
[**advancedstation_getevents**](AdvancedstationApi.md#advancedstation_getevents) | **GET** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
[**advancedstation_getinfo**](AdvancedstationApi.md#advancedstation_getinfo) | **GET** /advancedstation/getinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**advancedstation_getlocations**](AdvancedstationApi.md#advancedstation_getlocations) | **GET** /advancedstation/getlocations | Gets the locations available in a sign-in station.
[**advancedstation_getlogstaff**](AdvancedstationApi.md#advancedstation_getlogstaff) | **GET** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**advancedstation_getroles**](AdvancedstationApi.md#advancedstation_getroles) | **GET** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
[**advancedstation_getservices**](AdvancedstationApi.md#advancedstation_getservices) | **GET** /advancedstation/getservices | Gets the services available for a specific location.
[**advancedstation_getstaff**](AdvancedstationApi.md#advancedstation_getstaff) | **GET** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
[**advancedstation_issignedin**](AdvancedstationApi.md#advancedstation_issignedin) | **GET** /advancedstation/issignedin | Gets whether a user is signed-in or not.


# **advancedstation_checkunknownuser**
> advancedstation_checkunknownuser(station => $station, user => $user, location => $location)

Check whether the user is known by the system.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->advancedstation_checkunknownuser(station => $station, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_checkunknownuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 
 **location** | [**string**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_checkuserrole**
> advancedstation_checkuserrole(station => $station, user => $user, location => $location)

Check whether the user is a staff member, an attendee or both.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->advancedstation_checkuserrole(station => $station, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_checkuserrole: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 
 **location** | [**string**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_createuser**
> advancedstation_createuser(station => $station, user => $user, location => $location, firstname => $firstname, lastname => $lastname, email => $email, middlename => $middlename)

Creates a user via a sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user to create.
my $location = null; # string | The id of the location the user picked.
my $firstname = "firstname_example"; # string | The first name of the user to create.
my $lastname = "lastname_example"; # string | The last name of the user to create.
my $email = "email_example"; # string | The email of the user to create.
my $middlename = "middlename_example"; # string | The middle name of the user to create.

eval { 
    $api_instance->advancedstation_createuser(station => $station, user => $user, location => $location, firstname => $firstname, lastname => $lastname, email => $email, middlename => $middlename);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_createuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user to create. | 
 **location** | [**string**](.md)| The id of the location the user picked. | 
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

# **advancedstation_getevents**
> advancedstation_getevents(station => $station, location => $location, user => $user)

Gets the courses available for a specific location and a specific student.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $location = null; # string | The id of the location the student picked.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->advancedstation_getevents(station => $station, location => $location, user => $user);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_getevents: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **location** | [**string**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_getinfo**
> advancedstation_getinfo(id => $id, event => $event)

Gets the info to display in the sign-in station by it's ID.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $id = null; # string | The id of the sign-in station to get.
my $event = null; # string | The id of the event (or session), to override the scheduled one.

eval { 
    $api_instance->advancedstation_getinfo(id => $id, event => $event);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_getinfo: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the sign-in station to get. | 
 **event** | [**string**](.md)| The id of the event (or session), to override the scheduled one. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_getlocations**
> advancedstation_getlocations(station => $station, user => $user)

Gets the locations available in a sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station whose locations have to be returned.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->advancedstation_getlocations(station => $station, user => $user);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_getlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station whose locations have to be returned. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_getlogstaff**
> advancedstation_getlogstaff(station => $station, attendancelog => $attendancelog, photosize => $photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $attendancelog = null; # string | The id of the attendance log to filter the staff members.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->advancedstation_getlogstaff(station => $station, attendancelog => $attendancelog, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_getlogstaff: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **attendancelog** | [**string**](.md)| The id of the attendance log to filter the staff members. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_getroles**
> advancedstation_getroles(station => $station, signinrole => $signinrole, user => $user, location => $location)

Gets the user roles of the user trying to sign-in.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $signinrole = "signinrole_example"; # string | Specifies how the user is signing-in.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->advancedstation_getroles(station => $station, signinrole => $signinrole, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_getroles: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **signinrole** | **string**| Specifies how the user is signing-in. | 
 **user** | **string**| The card of the user. | 
 **location** | [**string**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_getservices**
> advancedstation_getservices(station => $station, location => $location, user => $user)

Gets the services available for a specific location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $location = null; # string | The id of the location the student picked.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->advancedstation_getservices(station => $station, location => $location, user => $user);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_getservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **location** | [**string**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_getstaff**
> advancedstation_getstaff(station => $station, locationid => $locationid, user => $user, services => $services, eventid => $eventid, photosize => $photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $locationid = null; # string | The id of the location the student picked.
my $user = "user_example"; # string | The card of the user.
my $services = "services_example"; # string | The list of services selected by the user, in JSON format.
my $eventid = null; # string | The ID of the event selected.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->advancedstation_getstaff(station => $station, locationid => $locationid, user => $user, services => $services, eventid => $eventid, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_getstaff: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **locationid** | [**string**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 
 **services** | **string**| The list of services selected by the user, in JSON format. | [optional] 
 **eventid** | [**string**](.md)| The ID of the event selected. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstation_issignedin**
> advancedstation_issignedin(station => $station, time => $time, user => $user, location => $location)

Gets whether a user is signed-in or not.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdvancedstationApi;
my $api_instance = WWW::OpenAPIClient::AdvancedstationApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $time = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time of the swipe.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->advancedstation_issignedin(station => $station, time => $time, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling AdvancedstationApi->advancedstation_issignedin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **time** | **DateTime**| The date and time of the swipe. | 
 **user** | **string**| The card of the user. | 
 **location** | [**string**](.md)| The id of the location the user picked. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

