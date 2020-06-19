# ScheduleApi

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


<a name="scheduleDelete"></a>
# **scheduleDelete**
> scheduleDelete(UNKNOWN_BASE_TYPE)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.scheduleDelete(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="scheduleDeletemine"></a>
# **scheduleDeletemine**
> scheduleDeletemine(UNKNOWN_BASE_TYPE)

Delete a specific block from a user&#39;s own schedule

Allows the user to delete a schedule block from their own availability.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.scheduleDeletemine(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleDeletemine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleDeletemine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="scheduleEnable"></a>
# **scheduleEnable**
> scheduleEnable(userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to enable or disable the schedule.
val enable : kotlin.Boolean = true // kotlin.Boolean | True to enable schedules, false to disable.
try {
    apiInstance.scheduleEnable(userid, enable)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleEnable")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleEnable")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to enable or disable the schedule. |
 **enable** | **kotlin.Boolean**| True to enable schedules, false to disable. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleEnablemine"></a>
# **scheduleEnablemine**
> scheduleEnablemine(enable)

Enable or disable current user&#39;s schedule

Allows the user to enable or disable a schedule for himself.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val enable : kotlin.Boolean = true // kotlin.Boolean | True to enable schedules, false to disable.
try {
    apiInstance.scheduleEnablemine(enable)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleEnablemine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleEnablemine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enable** | **kotlin.Boolean**| True to enable schedules, false to disable. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleFindallstaffslots"></a>
# **scheduleFindallstaffslots**
> scheduleFindallstaffslots(starttime, endtime, staffid, serviceids, eventid, locationid, staffroleids, availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val staffid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff to filter by.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service Ids to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to filter by.
val staffroleids : kotlin.String = staffroleids_example // kotlin.String | CSV list of the staff member role ids to filter by.
val availablefor : kotlin.String = availablefor_example // kotlin.String | The specific availability type to filter by.
try {
    apiInstance.scheduleFindallstaffslots(starttime, endtime, staffid, serviceids, eventid, locationid, staffroleids, availablefor)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleFindallstaffslots")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleFindallstaffslots")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **staffid** | [**java.util.UUID**](.md)| The id of the staff to filter by. | [optional]
 **serviceids** | **kotlin.String**| CSV list of the service Ids to filter by. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**java.util.UUID**](.md)| The id of the location to filter by. | [optional]
 **staffroleids** | **kotlin.String**| CSV list of the staff member role ids to filter by. | [optional]
 **availablefor** | **kotlin.String**| The specific availability type to filter by. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleFindslots"></a>
# **scheduleFindslots**
> scheduleFindslots(staffid, starttime, endtime, serviceids, eventid, locationid, availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val staffid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff to filter by.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service Ids to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
val availablefor : kotlin.String = availablefor_example // kotlin.String | The specific availability type to filter by.
try {
    apiInstance.scheduleFindslots(staffid, starttime, endtime, serviceids, eventid, locationid, availablefor)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleFindslots")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleFindslots")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffid** | [**java.util.UUID**](.md)| The id of the staff to filter by. |
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **serviceids** | **kotlin.String**| CSV list of the service Ids to filter by. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**java.util.UUID**](.md)| The id of the service to filter by. | [optional]
 **availablefor** | **kotlin.String**| The specific availability type to filter by. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleFindstaffavail"></a>
# **scheduleFindstaffavail**
> scheduleFindstaffavail(starttime, endtime, serviceids, eventid, locationid, staffroleids, availablefor, photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service ids to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
val staffroleids : kotlin.String = staffroleids_example // kotlin.String | CSV list of the staff member role ids to filter by.
val availablefor : kotlin.String = availablefor_example // kotlin.String | Filter slots by a specific availability type.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.scheduleFindstaffavail(starttime, endtime, serviceids, eventid, locationid, staffroleids, availablefor, photosize)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleFindstaffavail")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleFindstaffavail")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **serviceids** | **kotlin.String**| CSV list of the service ids to filter by. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**java.util.UUID**](.md)| The id of the service to filter by. | [optional]
 **staffroleids** | **kotlin.String**| CSV list of the staff member role ids to filter by. | [optional]
 **availablefor** | **kotlin.String**| Filter slots by a specific availability type. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleGet"></a>
# **scheduleGet**
> scheduleGet(scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val scheduleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule.
try {
    apiInstance.scheduleGet(scheduleid)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**java.util.UUID**](.md)| The id of the schedule. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleGetmine"></a>
# **scheduleGetmine**
> scheduleGetmine(scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val scheduleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule.
try {
    apiInstance.scheduleGetmine(scheduleid)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleGetmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleGetmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scheduleid** | [**java.util.UUID**](.md)| The id of the schedule. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleGetstaff"></a>
# **scheduleGetstaff**
> scheduleGetstaff(userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to get info.
try {
    apiInstance.scheduleGetstaff(userid)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleGetstaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleGetstaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to get info. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleGetstaffmine"></a>
# **scheduleGetstaffmine**
> scheduleGetstaffmine()

View current user&#39;s schedule information

Allows the user to view their own schedule.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
try {
    apiInstance.scheduleGetstaffmine()
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleGetstaffmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleGetstaffmine")
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

<a name="scheduleMyofftimes"></a>
# **scheduleMyofftimes**
> scheduleMyofftimes(includedeleted, onlyupcoming, modifiedafter)

View current user&#39;s schedule exceptions

Allows the user to view their own schedule exceptions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val includedeleted : kotlin.Boolean = true // kotlin.Boolean | If true the deleted offtimes are also returned.
val onlyupcoming : kotlin.Boolean = true // kotlin.Boolean | If true then only upcoming offtimes are returned.
val modifiedafter : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only offtimes modified after the specified date will be returned.
try {
    apiInstance.scheduleMyofftimes(includedeleted, onlyupcoming, modifiedafter)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleMyofftimes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleMyofftimes")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includedeleted** | **kotlin.Boolean**| If true the deleted offtimes are also returned. | [optional]
 **onlyupcoming** | **kotlin.Boolean**| If true then only upcoming offtimes are returned. | [optional]
 **modifiedafter** | **java.time.OffsetDateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleSave"></a>
# **scheduleSave**
> scheduleSave(UNKNOWN_BASE_TYPE)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.scheduleSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="scheduleSavemine"></a>
# **scheduleSavemine**
> scheduleSavemine(UNKNOWN_BASE_TYPE)

Create or edit a block in current user&#39;s schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ScheduleApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.scheduleSavemine(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ScheduleApi#scheduleSavemine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ScheduleApi#scheduleSavemine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

