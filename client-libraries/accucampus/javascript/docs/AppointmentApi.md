# AccuCampusOpenApi3.AppointmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appointmentCancel**](AppointmentApi.md#appointmentCancel) | **GET** /appointment/cancel | Cancel an appointment
[**appointmentCheckisvalid**](AppointmentApi.md#appointmentCheckisvalid) | **GET** /appointment/checkisvalid | Check if an appointment is valid or not
[**appointmentEditanyway**](AppointmentApi.md#appointmentEditanyway) | **GET** /appointment/editanyway | Edit an appointment even if it breaks activated rules
[**appointmentEditpresence**](AppointmentApi.md#appointmentEditpresence) | **GET** /appointment/editpresence | Edit the no-show status of an appointment
[**appointmentFindallstaffslots**](AppointmentApi.md#appointmentFindallstaffslots) | **GET** /appointment/findallstaffslots | Finds all staff available slots filtered by service, date, etc
[**appointmentFindslots**](AppointmentApi.md#appointmentFindslots) | **GET** /appointment/findslots | Finds available slots filtered by service, date, staff, etc
[**appointmentFindstaff**](AppointmentApi.md#appointmentFindstaff) | **GET** /appointment/findstaff | Finds staff available by service, date, event, etc
[**appointmentGet**](AppointmentApi.md#appointmentGet) | **GET** /appointment/{id} | Search and view details of an appointment
[**appointmentGetcurrent**](AppointmentApi.md#appointmentGetcurrent) | **GET** /appointment/getcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**appointmentGetlocations**](AppointmentApi.md#appointmentGetlocations) | **GET** /appointment/getlocations | Find locations where a service is available
[**appointmentList**](AppointmentApi.md#appointmentList) | **GET** /appointment/list | View a list of appointments
[**appointmentListmine**](AppointmentApi.md#appointmentListmine) | **GET** /appointment/listmine | View all my upcoming appointments
[**appointmentListupcoming**](AppointmentApi.md#appointmentListupcoming) | **GET** /appointment/listupcoming | Search and view details of all my upcoming appointments
[**appointmentRescheduleoutlook**](AppointmentApi.md#appointmentRescheduleoutlook) | **GET** /appointment/rescheduleoutlook | Reschedule an appointment from MS Outlook.
[**appointmentRestore**](AppointmentApi.md#appointmentRestore) | **GET** /appointment/restore | Restore an appointment
[**appointmentRestoreanyway**](AppointmentApi.md#appointmentRestoreanyway) | **GET** /appointment/restoreanyway | Restore an appointment even if it breaks activated rules
[**appointmentSave**](AppointmentApi.md#appointmentSave) | **POST** /appointment/{id} | Schedule an appointment
[**appointmentSetasvalid**](AppointmentApi.md#appointmentSetasvalid) | **GET** /appointment/setasvalid | Schedule an appointment even if it breaks activated rules
[**appointmentSuggestlocations**](AppointmentApi.md#appointmentSuggestlocations) | **GET** /appointment/suggestlocations | View the locations with most appointments
[**appointmentSuggestservices**](AppointmentApi.md#appointmentSuggestservices) | **GET** /appointment/suggestservices | View the services with most appointments
[**appointmentVoid**](AppointmentApi.md#appointmentVoid) | **GET** /appointment/void | Void an appointment



## appointmentCancel

> appointmentCancel(id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to cancel.
apiInstance.appointmentCancel(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to cancel. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentCheckisvalid

> appointmentCheckisvalid(id, opts)

Check if an appointment is valid or not

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to check.
let opts = {
  'editing': true // Boolean | Specifies whether the check is for a new appointment or an existing one.
};
apiInstance.appointmentCheckisvalid(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to check. | 
 **editing** | **Boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentEditanyway

> appointmentEditanyway(id, attendee, staff, location, start, end, opts)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to edit.
let attendee = null; // String | The id of the attendee involved in the appointment.
let staff = null; // String | The id of the staff member involved in the appointment.
let location = null; // String | The id of the location where the appointment will take place.
let start = new Date("2013-10-20T19:20:30+01:00"); // Date | The appointment's start date & time.
let end = new Date("2013-10-20T19:20:30+01:00"); // Date | The appointment's end date & time.
let opts = {
  'term': null, // String | The id of the term when the appointment takes place.
  'event': null, // String | The id of the event of the appointment.
  'services': "services_example", // String | Comma-separated string containing the ids of the services of the appointment.
  'notes': "notes_example" // String | The notes of the appointment.
};
apiInstance.appointmentEditanyway(id, attendee, staff, location, start, end, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to edit. | 
 **attendee** | [**String**](.md)| The id of the attendee involved in the appointment. | 
 **staff** | [**String**](.md)| The id of the staff member involved in the appointment. | 
 **location** | [**String**](.md)| The id of the location where the appointment will take place. | 
 **start** | **Date**| The appointment&#39;s start date &amp; time. | 
 **end** | **Date**| The appointment&#39;s end date &amp; time. | 
 **term** | [**String**](.md)| The id of the term when the appointment takes place. | [optional] 
 **event** | [**String**](.md)| The id of the event of the appointment. | [optional] 
 **services** | **String**| Comma-separated string containing the ids of the services of the appointment. | [optional] 
 **notes** | **String**| The notes of the appointment. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentEditpresence

> appointmentEditpresence(id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to edit its presence.
let showedup = true; // Boolean | Specifies whether the attendee was showed-up or not in the appointment.
apiInstance.appointmentEditpresence(id, showedup, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **Boolean**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentFindallstaffslots

> appointmentFindallstaffslots(starttime, endtime, serviceids, locationid, opts)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let serviceids = "serviceids_example"; // String | CSV list of the service Ids to filter by.
let locationid = null; // String | The id of the service to filter by.
let opts = {
  'eventid': null, // String | The id of the event to filter by.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.appointmentFindallstaffslots(starttime, endtime, serviceids, locationid, opts, (error, data, response) => {
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
 **starttime** | **Date**| The start time of the range to look for slots. | 
 **endtime** | **Date**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | 
 **locationid** | [**String**](.md)| The id of the service to filter by. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentFindslots

> appointmentFindslots(staffid, starttime, endtime, serviceids, opts)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let staffid = null; // String | The id of the staff to filter by.
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let serviceids = "serviceids_example"; // String | CSV list of the service Ids to filter by.
let opts = {
  'eventid': null, // String | The id of the event to filter by.
  'locationid': null // String | The id of the service to filter by.
};
apiInstance.appointmentFindslots(staffid, starttime, endtime, serviceids, opts, (error, data, response) => {
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
 **staffid** | [**String**](.md)| The id of the staff to filter by. | 
 **starttime** | **Date**| The start time of the range to look for slots. | 
 **endtime** | **Date**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentFindstaff

> appointmentFindstaff(serviceids, starttime, endtime, opts)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let serviceids = "serviceids_example"; // String | CSV list of the service ids to filter by.
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let opts = {
  'eventid': null, // String | The id of the event to filter by.
  'locationid': null, // String | The id of the service to filter by.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.appointmentFindstaff(serviceids, starttime, endtime, opts, (error, data, response) => {
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
 **serviceids** | **String**| CSV list of the service ids to filter by. | 
 **starttime** | **Date**| The start time of the range to look for slots. | 
 **endtime** | **Date**| The end time of the range to look for slots. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentGet

> appointmentGet(id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to get.
apiInstance.appointmentGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentGetcurrent

> appointmentGetcurrent(station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
let location = null; // String | The id of the location where the user wants to sign-in.
apiInstance.appointmentGetcurrent(station, user, location, (error, data, response) => {
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
 **location** | [**String**](.md)| The id of the location where the user wants to sign-in. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentGetlocations

> appointmentGetlocations(serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let serviceid = null; // String | The id of the service to get its locations.
apiInstance.appointmentGetlocations(serviceid, (error, data, response) => {
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
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentList

> appointmentList(from, count, opts)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the appointments.
  'enddate': new Date("2013-10-20T19:20:30+01:00"), // Date | The end date of the period to filter the appointments.
  'userid': null // String | The attendee id to filter the appointments.
};
apiInstance.appointmentList(from, count, opts, (error, data, response) => {
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
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **startdate** | **Date**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**String**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentListmine

> appointmentListmine(opts)

View all my upcoming appointments

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let opts = {
  'start': new Date("2013-10-20T19:20:30+01:00"), // Date | If specified, only appointments that start after the specified date will be returned.
  'modifiedafter': new Date("2013-10-20T19:20:30+01:00") // Date | If specified, only appointments modified after the specified date will be returned.
};
apiInstance.appointmentListmine(opts, (error, data, response) => {
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
 **start** | **Date**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **Date**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentListupcoming

> appointmentListupcoming(opts)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let opts = {
  'start': new Date("2013-10-20T19:20:30+01:00"), // Date | If specified, only appointments that start after the specified date will be returned.
  'modifiedafter': new Date("2013-10-20T19:20:30+01:00") // Date | If specified, only appointments modified after the specified date will be returned.
};
apiInstance.appointmentListupcoming(opts, (error, data, response) => {
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
 **start** | **Date**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **Date**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentRescheduleoutlook

> appointmentRescheduleoutlook(id, start, end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to edit.
let start = new Date("2013-10-20T19:20:30+01:00"); // Date | The appointment's start date & time.
let end = new Date("2013-10-20T19:20:30+01:00"); // Date | The appointment's end date & time.
apiInstance.appointmentRescheduleoutlook(id, start, end, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to edit. | 
 **start** | **Date**| The appointment&#39;s start date &amp; time. | 
 **end** | **Date**| The appointment&#39;s end date &amp; time. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentRestore

> appointmentRestore(id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to restore.
apiInstance.appointmentRestore(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to restore. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentRestoreanyway

> appointmentRestoreanyway(id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to restore.
apiInstance.appointmentRestoreanyway(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to restore. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentSave

> appointmentSave(id, opts)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.appointmentSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## appointmentSetasvalid

> appointmentSetasvalid(id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to set as valid.
apiInstance.appointmentSetasvalid(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to set as valid. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentSuggestlocations

> appointmentSuggestlocations()

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
apiInstance.appointmentSuggestlocations((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentSuggestservices

> appointmentSuggestservices()

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
apiInstance.appointmentSuggestservices((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentVoid

> appointmentVoid(id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student&#39;s restrictions.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AppointmentApi();
let id = null; // String | The id of the appointment to cancel.
apiInstance.appointmentVoid(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the appointment to cancel. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

