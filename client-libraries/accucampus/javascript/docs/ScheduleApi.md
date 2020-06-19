# AccuCampusOpenApi3.ScheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**scheduleDelete**](ScheduleApi.md#scheduleDelete) | **DELETE** /schedule/delete | Delete a schedule slot
[**scheduleDeletemine**](ScheduleApi.md#scheduleDeletemine) | **DELETE** /schedule/deletemine | Delete a specific block from a user&#39;s own schedule
[**scheduleEnable**](ScheduleApi.md#scheduleEnable) | **GET** /schedule/enable | Enable or disable the schedule for a specific person
[**scheduleEnablemine**](ScheduleApi.md#scheduleEnablemine) | **GET** /schedule/enablemine | Enable or disable current user&#39;s schedule
[**scheduleFindallstaffslots**](ScheduleApi.md#scheduleFindallstaffslots) | **GET** /schedule/findallstaffslots | Search available schedule slots by service, event, date
[**scheduleFindslots**](ScheduleApi.md#scheduleFindslots) | **GET** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
[**scheduleFindstaffavail**](ScheduleApi.md#scheduleFindstaffavail) | **GET** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
[**scheduleGet**](ScheduleApi.md#scheduleGet) | **GET** /schedule/get | Search and view details of a specific schedule slot
[**scheduleGetmine**](ScheduleApi.md#scheduleGetmine) | **GET** /schedule/getmine | View details of a specific schedule block, for current user
[**scheduleGetstaff**](ScheduleApi.md#scheduleGetstaff) | **GET** /schedule/getstaff | View a list of schedule information of a specified person
[**scheduleGetstaffmine**](ScheduleApi.md#scheduleGetstaffmine) | **GET** /schedule/getstaffmine | View current user&#39;s schedule information
[**scheduleMyofftimes**](ScheduleApi.md#scheduleMyofftimes) | **GET** /schedule/myofftimes | View current user&#39;s schedule exceptions
[**scheduleSave**](ScheduleApi.md#scheduleSave) | **POST** /schedule/save | Create or edit a schedule slot
[**scheduleSavemine**](ScheduleApi.md#scheduleSavemine) | **POST** /schedule/savemine | Create or edit a block in current user&#39;s schedule



## scheduleDelete

> scheduleDelete(opts)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.scheduleDelete(opts, (error, data, response) => {
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## scheduleDeletemine

> scheduleDeletemine(opts)

Delete a specific block from a user&#39;s own schedule

Allows the user to delete a schedule block from their own availability.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.scheduleDeletemine(opts, (error, data, response) => {
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## scheduleEnable

> scheduleEnable(userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let userid = null; // String | The id of the user to enable or disable the schedule.
let enable = true; // Boolean | True to enable schedules, false to disable.
apiInstance.scheduleEnable(userid, enable, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **Boolean**| True to enable schedules, false to disable. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleEnablemine

> scheduleEnablemine(enable)

Enable or disable current user&#39;s schedule

Allows the user to enable or disable a schedule for himself.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let enable = true; // Boolean | True to enable schedules, false to disable.
apiInstance.scheduleEnablemine(enable, (error, data, response) => {
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
 **enable** | **Boolean**| True to enable schedules, false to disable. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleFindallstaffslots

> scheduleFindallstaffslots(starttime, endtime, opts)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let opts = {
  'staffid': null, // String | The id of the staff to filter by.
  'serviceids': "serviceids_example", // String | CSV list of the service Ids to filter by.
  'eventid': null, // String | The id of the event to filter by.
  'locationid': null, // String | The id of the location to filter by.
  'staffroleids': "staffroleids_example", // String | CSV list of the staff member role ids to filter by.
  'availablefor': "availablefor_example" // String | The specific availability type to filter by.
};
apiInstance.scheduleFindallstaffslots(starttime, endtime, opts, (error, data, response) => {
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
 **staffid** | [**String**](.md)| The id of the staff to filter by. | [optional] 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the location to filter by. | [optional] 
 **staffroleids** | **String**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **String**| The specific availability type to filter by. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleFindslots

> scheduleFindslots(staffid, starttime, endtime, opts)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let staffid = null; // String | The id of the staff to filter by.
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let opts = {
  'serviceids': "serviceids_example", // String | CSV list of the service Ids to filter by.
  'eventid': null, // String | The id of the event to filter by.
  'locationid': null, // String | The id of the service to filter by.
  'availablefor': "availablefor_example" // String | The specific availability type to filter by.
};
apiInstance.scheduleFindslots(staffid, starttime, endtime, opts, (error, data, response) => {
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
 **serviceids** | **String**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **availablefor** | **String**| The specific availability type to filter by. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleFindstaffavail

> scheduleFindstaffavail(starttime, endtime, opts)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let opts = {
  'serviceids': "serviceids_example", // String | CSV list of the service ids to filter by.
  'eventid': null, // String | The id of the event to filter by.
  'locationid': null, // String | The id of the service to filter by.
  'staffroleids': "staffroleids_example", // String | CSV list of the staff member role ids to filter by.
  'availablefor': "availablefor_example", // String | Filter slots by a specific availability type.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.scheduleFindstaffavail(starttime, endtime, opts, (error, data, response) => {
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
 **serviceids** | **String**| CSV list of the service ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **staffroleids** | **String**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **String**| Filter slots by a specific availability type. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleGet

> scheduleGet(scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let scheduleid = null; // String | The id of the schedule.
apiInstance.scheduleGet(scheduleid, (error, data, response) => {
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
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleGetmine

> scheduleGetmine(scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let scheduleid = null; // String | The id of the schedule.
apiInstance.scheduleGetmine(scheduleid, (error, data, response) => {
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
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleGetstaff

> scheduleGetstaff(userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let userid = null; // String | The id of the user to get info.
apiInstance.scheduleGetstaff(userid, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user to get info. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleGetstaffmine

> scheduleGetstaffmine()

View current user&#39;s schedule information

Allows the user to view their own schedule.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
apiInstance.scheduleGetstaffmine((error, data, response) => {
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


## scheduleMyofftimes

> scheduleMyofftimes(opts)

View current user&#39;s schedule exceptions

Allows the user to view their own schedule exceptions.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let opts = {
  'includedeleted': true, // Boolean | If true the deleted offtimes are also returned.
  'onlyupcoming': true, // Boolean | If true then only upcoming offtimes are returned.
  'modifiedafter': new Date("2013-10-20T19:20:30+01:00") // Date | If specified, only offtimes modified after the specified date will be returned.
};
apiInstance.scheduleMyofftimes(opts, (error, data, response) => {
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
 **includedeleted** | **Boolean**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **Boolean**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **Date**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleSave

> scheduleSave(opts)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.scheduleSave(opts, (error, data, response) => {
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## scheduleSavemine

> scheduleSavemine(opts)

Create or edit a block in current user&#39;s schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ScheduleApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.scheduleSavemine(opts, (error, data, response) => {
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

