# AccuCampusOpenApi3.AdvancedstationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advancedstationCheckunknownuser**](AdvancedstationApi.md#advancedstationCheckunknownuser) | **GET** /advancedstation/checkunknownuser | Check whether the user is known by the system.
[**advancedstationCheckuserrole**](AdvancedstationApi.md#advancedstationCheckuserrole) | **GET** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
[**advancedstationCreateuser**](AdvancedstationApi.md#advancedstationCreateuser) | **GET** /advancedstation/createuser | Creates a user via a sign-in station.
[**advancedstationGetevents**](AdvancedstationApi.md#advancedstationGetevents) | **GET** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
[**advancedstationGetinfo**](AdvancedstationApi.md#advancedstationGetinfo) | **GET** /advancedstation/getinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**advancedstationGetlocations**](AdvancedstationApi.md#advancedstationGetlocations) | **GET** /advancedstation/getlocations | Gets the locations available in a sign-in station.
[**advancedstationGetlogstaff**](AdvancedstationApi.md#advancedstationGetlogstaff) | **GET** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**advancedstationGetroles**](AdvancedstationApi.md#advancedstationGetroles) | **GET** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
[**advancedstationGetservices**](AdvancedstationApi.md#advancedstationGetservices) | **GET** /advancedstation/getservices | Gets the services available for a specific location.
[**advancedstationGetstaff**](AdvancedstationApi.md#advancedstationGetstaff) | **GET** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
[**advancedstationIssignedin**](AdvancedstationApi.md#advancedstationIssignedin) | **GET** /advancedstation/issignedin | Gets whether a user is signed-in or not.



## advancedstationCheckunknownuser

> advancedstationCheckunknownuser(station, user, location)

Check whether the user is known by the system.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
let location = null; // String | The id of the location the user picked.
apiInstance.advancedstationCheckunknownuser(station, user, location, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationCheckuserrole

> advancedstationCheckuserrole(station, user, location)

Check whether the user is a staff member, an attendee or both.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
let location = null; // String | The id of the location the user picked.
apiInstance.advancedstationCheckuserrole(station, user, location, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationCreateuser

> advancedstationCreateuser(station, user, location, firstname, lastname, email, opts)

Creates a user via a sign-in station.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user to create.
let location = null; // String | The id of the location the user picked.
let firstname = "firstname_example"; // String | The first name of the user to create.
let lastname = "lastname_example"; // String | The last name of the user to create.
let email = "email_example"; // String | The email of the user to create.
let opts = {
  'middlename': "middlename_example" // String | The middle name of the user to create.
};
apiInstance.advancedstationCreateuser(station, user, location, firstname, lastname, email, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user to create. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 
 **firstname** | **String**| The first name of the user to create. | 
 **lastname** | **String**| The last name of the user to create. | 
 **email** | **String**| The email of the user to create. | 
 **middlename** | **String**| The middle name of the user to create. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationGetevents

> advancedstationGetevents(station, location, user)

Gets the courses available for a specific location and a specific student.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let location = null; // String | The id of the location the student picked.
let user = "user_example"; // String | The card of the user.
apiInstance.advancedstationGetevents(station, location, user, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **location** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationGetinfo

> advancedstationGetinfo(id, opts)

Gets the info to display in the sign-in station by it&#39;s ID.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let id = null; // String | The id of the sign-in station to get.
let opts = {
  'event': null // String | The id of the event (or session), to override the scheduled one.
};
apiInstance.advancedstationGetinfo(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to get. | 
 **event** | [**String**](.md)| The id of the event (or session), to override the scheduled one. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationGetlocations

> advancedstationGetlocations(station, user)

Gets the locations available in a sign-in station.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station whose locations have to be returned.
let user = "user_example"; // String | The card of the user.
apiInstance.advancedstationGetlocations(station, user, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station whose locations have to be returned. | 
 **user** | **String**| The card of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationGetlogstaff

> advancedstationGetlogstaff(station, attendancelog, opts)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let attendancelog = null; // String | The id of the attendance log to filter the staff members.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.advancedstationGetlogstaff(station, attendancelog, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **attendancelog** | [**String**](.md)| The id of the attendance log to filter the staff members. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationGetroles

> advancedstationGetroles(station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let signinrole = "signinrole_example"; // String | Specifies how the user is signing-in.
let user = "user_example"; // String | The card of the user.
let location = null; // String | The id of the location the user picked.
apiInstance.advancedstationGetroles(station, signinrole, user, location, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **signinrole** | **String**| Specifies how the user is signing-in. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationGetservices

> advancedstationGetservices(station, location, user)

Gets the services available for a specific location.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let location = null; // String | The id of the location the student picked.
let user = "user_example"; // String | The card of the user.
apiInstance.advancedstationGetservices(station, location, user, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **location** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationGetstaff

> advancedstationGetstaff(station, locationid, user, opts)

Gets the staff/tutors available for a specific location, course and service.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let locationid = null; // String | The id of the location the student picked.
let user = "user_example"; // String | The card of the user.
let opts = {
  'services': "services_example", // String | The list of services selected by the user, in JSON format.
  'eventid': null, // String | The ID of the event selected.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.advancedstationGetstaff(station, locationid, user, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **locationid** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 
 **services** | **String**| The list of services selected by the user, in JSON format. | [optional] 
 **eventid** | [**String**](.md)| The ID of the event selected. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationIssignedin

> advancedstationIssignedin(station, time, user, opts)

Gets whether a user is signed-in or not.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AdvancedstationApi();
let station = null; // String | The id of the sign-in station to get.
let time = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time of the swipe.
let user = "user_example"; // String | The card of the user.
let opts = {
  'location': null // String | The id of the location the user picked.
};
apiInstance.advancedstationIssignedin(station, time, user, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **time** | **Date**| The date and time of the swipe. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

