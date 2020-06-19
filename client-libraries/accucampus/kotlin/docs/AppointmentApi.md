# AppointmentApi

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


<a name="appointmentCancel"></a>
# **appointmentCancel**
> appointmentCancel(id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to cancel.
try {
    apiInstance.appointmentCancel(id)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentCancel")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentCancel")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to cancel. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentCheckisvalid"></a>
# **appointmentCheckisvalid**
> appointmentCheckisvalid(id, editing)

Check if an appointment is valid or not

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to check.
val editing : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the check is for a new appointment or an existing one.
try {
    apiInstance.appointmentCheckisvalid(id, editing)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentCheckisvalid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentCheckisvalid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to check. |
 **editing** | **kotlin.Boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentEditanyway"></a>
# **appointmentEditanyway**
> appointmentEditanyway(id, attendee, staff, location, start, end, term, event, services, notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to edit.
val attendee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendee involved in the appointment.
val staff : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff member involved in the appointment.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location where the appointment will take place.
val start : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The appointment's start date & time.
val end : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The appointment's end date & time.
val term : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the term when the appointment takes place.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event of the appointment.
val services : kotlin.String = services_example // kotlin.String | Comma-separated string containing the ids of the services of the appointment.
val notes : kotlin.String = notes_example // kotlin.String | The notes of the appointment.
try {
    apiInstance.appointmentEditanyway(id, attendee, staff, location, start, end, term, event, services, notes)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentEditanyway")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentEditanyway")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to edit. |
 **attendee** | [**java.util.UUID**](.md)| The id of the attendee involved in the appointment. |
 **staff** | [**java.util.UUID**](.md)| The id of the staff member involved in the appointment. |
 **location** | [**java.util.UUID**](.md)| The id of the location where the appointment will take place. |
 **start** | **java.time.OffsetDateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **java.time.OffsetDateTime**| The appointment&#39;s end date &amp; time. |
 **term** | [**java.util.UUID**](.md)| The id of the term when the appointment takes place. | [optional]
 **event** | [**java.util.UUID**](.md)| The id of the event of the appointment. | [optional]
 **services** | **kotlin.String**| Comma-separated string containing the ids of the services of the appointment. | [optional]
 **notes** | **kotlin.String**| The notes of the appointment. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentEditpresence"></a>
# **appointmentEditpresence**
> appointmentEditpresence(id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to edit its presence.
val showedup : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the attendee was showed-up or not in the appointment.
try {
    apiInstance.appointmentEditpresence(id, showedup)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentEditpresence")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentEditpresence")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to edit its presence. |
 **showedup** | **kotlin.Boolean**| Specifies whether the attendee was showed-up or not in the appointment. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentFindallstaffslots"></a>
# **appointmentFindallstaffslots**
> appointmentFindallstaffslots(starttime, endtime, serviceids, locationid, eventid, photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service Ids to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.appointmentFindallstaffslots(starttime, endtime, serviceids, locationid, eventid, photosize)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentFindallstaffslots")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentFindallstaffslots")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **serviceids** | **kotlin.String**| CSV list of the service Ids to filter by. |
 **locationid** | [**java.util.UUID**](.md)| The id of the service to filter by. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentFindslots"></a>
# **appointmentFindslots**
> appointmentFindslots(staffid, starttime, endtime, serviceids, eventid, locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val staffid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff to filter by.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service Ids to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
try {
    apiInstance.appointmentFindslots(staffid, starttime, endtime, serviceids, eventid, locationid)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentFindslots")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentFindslots")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**java.util.UUID**](.md)| The id of the staff to filter by. |
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **serviceids** | **kotlin.String**| CSV list of the service Ids to filter by. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**java.util.UUID**](.md)| The id of the service to filter by. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentFindstaff"></a>
# **appointmentFindstaff**
> appointmentFindstaff(serviceids, starttime, endtime, eventid, locationid, photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service ids to filter by.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.appointmentFindstaff(serviceids, starttime, endtime, eventid, locationid, photosize)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentFindstaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentFindstaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceids** | **kotlin.String**| CSV list of the service ids to filter by. |
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**java.util.UUID**](.md)| The id of the service to filter by. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentGet"></a>
# **appointmentGet**
> appointmentGet(id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to get.
try {
    apiInstance.appointmentGet(id)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentGetcurrent"></a>
# **appointmentGetcurrent**
> appointmentGetcurrent(station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location where the user wants to sign-in.
try {
    apiInstance.appointmentGetcurrent(station, user, location)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentGetcurrent")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentGetcurrent")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location where the user wants to sign-in. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentGetlocations"></a>
# **appointmentGetlocations**
> appointmentGetlocations(serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to get its locations.
try {
    apiInstance.appointmentGetlocations(serviceid)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentGetlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentGetlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to get its locations. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentList"></a>
# **appointmentList**
> appointmentList(from, count, startdate, enddate, userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the appointments.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the appointments.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The attendee id to filter the appointments.
try {
    apiInstance.appointmentList(from, count, startdate, enddate, userid)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the appointments. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the appointments. | [optional]
 **userid** | [**java.util.UUID**](.md)| The attendee id to filter the appointments. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentListmine"></a>
# **appointmentListmine**
> appointmentListmine(start, modifiedafter)

View all my upcoming appointments

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val start : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only appointments that start after the specified date will be returned.
val modifiedafter : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only appointments modified after the specified date will be returned.
try {
    apiInstance.appointmentListmine(start, modifiedafter)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentListmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentListmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **java.time.OffsetDateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **java.time.OffsetDateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentListupcoming"></a>
# **appointmentListupcoming**
> appointmentListupcoming(start, modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val start : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only appointments that start after the specified date will be returned.
val modifiedafter : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only appointments modified after the specified date will be returned.
try {
    apiInstance.appointmentListupcoming(start, modifiedafter)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentListupcoming")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentListupcoming")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **java.time.OffsetDateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **java.time.OffsetDateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentRescheduleoutlook"></a>
# **appointmentRescheduleoutlook**
> appointmentRescheduleoutlook(id, start, end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to edit.
val start : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The appointment's start date & time.
val end : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The appointment's end date & time.
try {
    apiInstance.appointmentRescheduleoutlook(id, start, end)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentRescheduleoutlook")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentRescheduleoutlook")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to edit. |
 **start** | **java.time.OffsetDateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **java.time.OffsetDateTime**| The appointment&#39;s end date &amp; time. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentRestore"></a>
# **appointmentRestore**
> appointmentRestore(id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to restore.
try {
    apiInstance.appointmentRestore(id)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentRestore")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentRestore")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to restore. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentRestoreanyway"></a>
# **appointmentRestoreanyway**
> appointmentRestoreanyway(id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to restore.
try {
    apiInstance.appointmentRestoreanyway(id)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentRestoreanyway")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentRestoreanyway")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to restore. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentSave"></a>
# **appointmentSave**
> appointmentSave(id, UNKNOWN_BASE_TYPE)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.appointmentSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="appointmentSetasvalid"></a>
# **appointmentSetasvalid**
> appointmentSetasvalid(id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to set as valid.
try {
    apiInstance.appointmentSetasvalid(id)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentSetasvalid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentSetasvalid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to set as valid. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentSuggestlocations"></a>
# **appointmentSuggestlocations**
> appointmentSuggestlocations()

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
try {
    apiInstance.appointmentSuggestlocations()
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentSuggestlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentSuggestlocations")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentSuggestservices"></a>
# **appointmentSuggestservices**
> appointmentSuggestservices()

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
try {
    apiInstance.appointmentSuggestservices()
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentSuggestservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentSuggestservices")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentVoid"></a>
# **appointmentVoid**
> appointmentVoid(id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student&#39;s restrictions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AppointmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to cancel.
try {
    apiInstance.appointmentVoid(id)
} catch (e: ClientException) {
    println("4xx response calling AppointmentApi#appointmentVoid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AppointmentApi#appointmentVoid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the appointment to cancel. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

