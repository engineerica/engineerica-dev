# \AppointmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppointmentCancel**](AppointmentApi.md#AppointmentCancel) | **Get** /appointment/cancel | Cancel an appointment
[**AppointmentCheckisvalid**](AppointmentApi.md#AppointmentCheckisvalid) | **Get** /appointment/checkisvalid | Check if an appointment is valid or not
[**AppointmentEditanyway**](AppointmentApi.md#AppointmentEditanyway) | **Get** /appointment/editanyway | Edit an appointment even if it breaks activated rules
[**AppointmentEditpresence**](AppointmentApi.md#AppointmentEditpresence) | **Get** /appointment/editpresence | Edit the no-show status of an appointment
[**AppointmentFindallstaffslots**](AppointmentApi.md#AppointmentFindallstaffslots) | **Get** /appointment/findallstaffslots | Finds all staff available slots filtered by service, date, etc
[**AppointmentFindslots**](AppointmentApi.md#AppointmentFindslots) | **Get** /appointment/findslots | Finds available slots filtered by service, date, staff, etc
[**AppointmentFindstaff**](AppointmentApi.md#AppointmentFindstaff) | **Get** /appointment/findstaff | Finds staff available by service, date, event, etc
[**AppointmentGet**](AppointmentApi.md#AppointmentGet) | **Get** /appointment/{id} | Search and view details of an appointment
[**AppointmentGetcurrent**](AppointmentApi.md#AppointmentGetcurrent) | **Get** /appointment/getcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**AppointmentGetlocations**](AppointmentApi.md#AppointmentGetlocations) | **Get** /appointment/getlocations | Find locations where a service is available
[**AppointmentList**](AppointmentApi.md#AppointmentList) | **Get** /appointment/list | View a list of appointments
[**AppointmentListmine**](AppointmentApi.md#AppointmentListmine) | **Get** /appointment/listmine | View all my upcoming appointments
[**AppointmentListupcoming**](AppointmentApi.md#AppointmentListupcoming) | **Get** /appointment/listupcoming | Search and view details of all my upcoming appointments
[**AppointmentRescheduleoutlook**](AppointmentApi.md#AppointmentRescheduleoutlook) | **Get** /appointment/rescheduleoutlook | Reschedule an appointment from MS Outlook.
[**AppointmentRestore**](AppointmentApi.md#AppointmentRestore) | **Get** /appointment/restore | Restore an appointment
[**AppointmentRestoreanyway**](AppointmentApi.md#AppointmentRestoreanyway) | **Get** /appointment/restoreanyway | Restore an appointment even if it breaks activated rules
[**AppointmentSave**](AppointmentApi.md#AppointmentSave) | **Post** /appointment/{id} | Schedule an appointment
[**AppointmentSetasvalid**](AppointmentApi.md#AppointmentSetasvalid) | **Get** /appointment/setasvalid | Schedule an appointment even if it breaks activated rules
[**AppointmentSuggestlocations**](AppointmentApi.md#AppointmentSuggestlocations) | **Get** /appointment/suggestlocations | View the locations with most appointments
[**AppointmentSuggestservices**](AppointmentApi.md#AppointmentSuggestservices) | **Get** /appointment/suggestservices | View the services with most appointments
[**AppointmentVoid**](AppointmentApi.md#AppointmentVoid) | **Get** /appointment/void | Void an appointment



## AppointmentCancel

> AppointmentCancel(ctx, id)

Cancel an appointment

Allows the user to cancel an appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to cancel. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentCheckisvalid

> AppointmentCheckisvalid(ctx, id, optional)

Check if an appointment is valid or not

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to check. | 
 **optional** | ***AppointmentCheckisvalidOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentCheckisvalidOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **editing** | **optional.Bool**| Specifies whether the check is for a new appointment or an existing one. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentEditanyway

> AppointmentEditanyway(ctx, id, attendee, staff, location, start, end, optional)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to edit. | 
**attendee** | [**string**](.md)| The id of the attendee involved in the appointment. | 
**staff** | [**string**](.md)| The id of the staff member involved in the appointment. | 
**location** | [**string**](.md)| The id of the location where the appointment will take place. | 
**start** | **time.Time**| The appointment&#39;s start date &amp; time. | 
**end** | **time.Time**| The appointment&#39;s end date &amp; time. | 
 **optional** | ***AppointmentEditanywayOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentEditanywayOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------






 **term** | [**optional.Interface of string**](.md)| The id of the term when the appointment takes place. | 
 **event** | [**optional.Interface of string**](.md)| The id of the event of the appointment. | 
 **services** | **optional.String**| Comma-separated string containing the ids of the services of the appointment. | 
 **notes** | **optional.String**| The notes of the appointment. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentEditpresence

> AppointmentEditpresence(ctx, id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to edit its presence. | 
**showedup** | **bool**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentFindallstaffslots

> AppointmentFindallstaffslots(ctx, starttime, endtime, serviceids, locationid, optional)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
**serviceids** | **string**| CSV list of the service Ids to filter by. | 
**locationid** | [**string**](.md)| The id of the service to filter by. | 
 **optional** | ***AppointmentFindallstaffslotsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentFindallstaffslotsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentFindslots

> AppointmentFindslots(ctx, staffid, starttime, endtime, serviceids, optional)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**staffid** | [**string**](.md)| The id of the staff to filter by. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
**serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **optional** | ***AppointmentFindslotsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentFindslotsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the service to filter by. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentFindstaff

> AppointmentFindstaff(ctx, serviceids, starttime, endtime, optional)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceids** | **string**| CSV list of the service ids to filter by. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
 **optional** | ***AppointmentFindstaffOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentFindstaffOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the service to filter by. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentGet

> AppointmentGet(ctx, id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to get. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentGetcurrent

> AppointmentGetcurrent(ctx, station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user. | 
**location** | [**string**](.md)| The id of the location where the user wants to sign-in. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentGetlocations

> AppointmentGetlocations(ctx, serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**serviceid** | [**string**](.md)| The id of the service to get its locations. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentList

> AppointmentList(ctx, from, count, optional)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AppointmentListOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentListOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **startdate** | **optional.Time**| The start date of the period to filter the appointments. | 
 **enddate** | **optional.Time**| The end date of the period to filter the appointments. | 
 **userid** | [**optional.Interface of string**](.md)| The attendee id to filter the appointments. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentListmine

> AppointmentListmine(ctx, optional)

View all my upcoming appointments

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AppointmentListmineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentListmineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **optional.Time**| If specified, only appointments that start after the specified date will be returned. | 
 **modifiedafter** | **optional.Time**| If specified, only appointments modified after the specified date will be returned. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentListupcoming

> AppointmentListupcoming(ctx, optional)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AppointmentListupcomingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentListupcomingOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **optional.Time**| If specified, only appointments that start after the specified date will be returned. | 
 **modifiedafter** | **optional.Time**| If specified, only appointments modified after the specified date will be returned. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentRescheduleoutlook

> AppointmentRescheduleoutlook(ctx, id, start, end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to edit. | 
**start** | **time.Time**| The appointment&#39;s start date &amp; time. | 
**end** | **time.Time**| The appointment&#39;s end date &amp; time. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentRestore

> AppointmentRestore(ctx, id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to restore. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentRestoreanyway

> AppointmentRestoreanyway(ctx, id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to restore. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentSave

> AppointmentSave(ctx, id, optional)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to save (leave empty to create a new one). | 
 **optional** | ***AppointmentSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentSaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentSetasvalid

> AppointmentSetasvalid(ctx, id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to set as valid. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentSuggestlocations

> AppointmentSuggestlocations(ctx, )

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Required Parameters

This endpoint does not need any parameter.

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentSuggestservices

> AppointmentSuggestservices(ctx, )

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Required Parameters

This endpoint does not need any parameter.

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AppointmentVoid

> AppointmentVoid(ctx, id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the appointment to cancel. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

