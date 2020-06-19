# org.openapitools.client - Kotlin client library for AccuCampus OpenAPI 3

## Requires

* Kotlin 1.3.41
* Gradle 4.9

## Build

First, create the gradle wrapper script:

```
gradle wrapper
```

Then, run:

```
./gradlew check assemble
```

This runs all tests and packages the library.

## Features/Implementation Notes

* Supports JSON inputs/outputs, File inputs, and Form inputs.
* Supports collection formats for query parameters: csv, tsv, ssv, pipes.
* Some Kotlin and Java types are fully qualified to avoid conflicts with types defined in OpenAPI definitions.
* Implementation of ApiClient is intended to reduce method counts, specifically to benefit Android targets.

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://accucampus.net:443/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ActionassignmentApi* | [**actionassignmentDelete**](docs/ActionassignmentApi.md#actionassignmentdelete) | **DELETE** /actionassignment/{id} | Remove an action item from an action plan
*ActionassignmentApi* | [**actionassignmentGet**](docs/ActionassignmentApi.md#actionassignmentget) | **GET** /actionassignment/{id} | Search and view details of an action item assigned to a user
*ActionassignmentApi* | [**actionassignmentList**](docs/ActionassignmentApi.md#actionassignmentlist) | **GET** /actionassignment/list | View a list of action items in a user's plan
*ActionassignmentApi* | [**actionassignmentListhistory**](docs/ActionassignmentApi.md#actionassignmentlisthistory) | **GET** /actionassignment/listhistory | View the history of an action item assigned to a user
*ActionassignmentApi* | [**actionassignmentListmine**](docs/ActionassignmentApi.md#actionassignmentlistmine) | **GET** /actionassignment/listmine | List public action assignments assigned to the logged user
*ActionassignmentApi* | [**actionassignmentListpublichistory**](docs/ActionassignmentApi.md#actionassignmentlistpublichistory) | **GET** /actionassignment/listpublichistory | List public action assignment history
*ActionassignmentApi* | [**actionassignmentMarkcomplete**](docs/ActionassignmentApi.md#actionassignmentmarkcomplete) | **GET** /actionassignment/markcomplete | Bulk complete action items
*ActionassignmentApi* | [**actionassignmentSave**](docs/ActionassignmentApi.md#actionassignmentsave) | **POST** /actionassignment/save | Add an action item to a user's action plan
*ActionassignmentApi* | [**actionassignmentSavehistory**](docs/ActionassignmentApi.md#actionassignmentsavehistory) | **POST** /actionassignment/savehistory | Update an action item assigned to a user
*ActionitemApi* | [**actionitemDelete**](docs/ActionitemApi.md#actionitemdelete) | **DELETE** /actionitem/{id} | Delete an action item
*ActionitemApi* | [**actionitemGet**](docs/ActionitemApi.md#actionitemget) | **GET** /actionitem/{id} | Search and view details of an action item
*ActionitemApi* | [**actionitemList**](docs/ActionitemApi.md#actionitemlist) | **GET** /actionitem/list | View a list of action items
*ActionitemApi* | [**actionitemSave**](docs/ActionitemApi.md#actionitemsave) | **POST** /actionitem/{id} | Create or edit an action item
*ActionlogApi* | [**actionlogList**](docs/ActionlogApi.md#actionloglist) | **GET** /actionlog/list | View a list of users action logs
*ActionpackApi* | [**actionpackAssign**](docs/ActionpackApi.md#actionpackassign) | **GET** /actionpack/assign | Assign an action item pack to a user
*ActionpackApi* | [**actionpackDelete**](docs/ActionpackApi.md#actionpackdelete) | **DELETE** /actionpack/{id} | Delete an action item pack
*ActionpackApi* | [**actionpackGet**](docs/ActionpackApi.md#actionpackget) | **GET** /actionpack/{id} | View details of an action item pack
*ActionpackApi* | [**actionpackList**](docs/ActionpackApi.md#actionpacklist) | **GET** /actionpack/list | View a list of action item packs
*ActionpackApi* | [**actionpackSave**](docs/ActionpackApi.md#actionpacksave) | **POST** /actionpack/{id} | Create or edit an action item pack
*ActiontypeApi* | [**actiontypeDelete**](docs/ActiontypeApi.md#actiontypedelete) | **DELETE** /actiontype/{id} | Delete an action item type
*ActiontypeApi* | [**actiontypeGet**](docs/ActiontypeApi.md#actiontypeget) | **GET** /actiontype/{id} | View details of an action item type
*ActiontypeApi* | [**actiontypeList**](docs/ActiontypeApi.md#actiontypelist) | **GET** /actiontype/list | View a list of action item types
*ActiontypeApi* | [**actiontypeSave**](docs/ActiontypeApi.md#actiontypesave) | **POST** /actiontype/{id} | Create or edit an action item type
*AdhocqueryApi* | [**adhocqueryCheckexecution**](docs/AdhocqueryApi.md#adhocquerycheckexecution) | **GET** /adhocquery/checkexecution | Check the status of an ad hoc query execution
*AdhocqueryApi* | [**adhocqueryDelete**](docs/AdhocqueryApi.md#adhocquerydelete) | **DELETE** /adhocquery/{id} | Delete an ad hoc query
*AdhocqueryApi* | [**adhocqueryExecute**](docs/AdhocqueryApi.md#adhocqueryexecute) | **GET** /adhocquery/execute | Execute an ad hoc query
*AdhocqueryApi* | [**adhocqueryGet**](docs/AdhocqueryApi.md#adhocqueryget) | **GET** /adhocquery/{id} | View details of an ad hoc query
*AdhocqueryApi* | [**adhocqueryGetschema**](docs/AdhocqueryApi.md#adhocquerygetschema) | **GET** /adhocquery/getschema | View the database schema for making ad hoc queries
*AdhocqueryApi* | [**adhocqueryList**](docs/AdhocqueryApi.md#adhocquerylist) | **GET** /adhocquery/list | View a list of saved ad hoc queries
*AdhocqueryApi* | [**adhocqueryListexecutions**](docs/AdhocqueryApi.md#adhocquerylistexecutions) | **GET** /adhocquery/listexecutions | View a list of ad hoc queries executions
*AdhocqueryApi* | [**adhocquerySave**](docs/AdhocqueryApi.md#adhocquerysave) | **POST** /adhocquery/{id} | Create or edit an ad hoc query
*AdhocqueryApi* | [**adhocqueryStopexecution**](docs/AdhocqueryApi.md#adhocquerystopexecution) | **GET** /adhocquery/stopexecution | Stops the execution of an ad hoc query
*AdhocreportsApi* | [**adhocreportsReqaccess**](docs/AdhocreportsApi.md#adhocreportsreqaccess) | **GET** /adhocreports/reqaccess | Request access to the ad-hoc reports
*AdvancedstationApi* | [**advancedstationCheckunknownuser**](docs/AdvancedstationApi.md#advancedstationcheckunknownuser) | **GET** /advancedstation/checkunknownuser | Check whether the user is known by the system.
*AdvancedstationApi* | [**advancedstationCheckuserrole**](docs/AdvancedstationApi.md#advancedstationcheckuserrole) | **GET** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
*AdvancedstationApi* | [**advancedstationCreateuser**](docs/AdvancedstationApi.md#advancedstationcreateuser) | **GET** /advancedstation/createuser | Creates a user via a sign-in station.
*AdvancedstationApi* | [**advancedstationGetevents**](docs/AdvancedstationApi.md#advancedstationgetevents) | **GET** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
*AdvancedstationApi* | [**advancedstationGetinfo**](docs/AdvancedstationApi.md#advancedstationgetinfo) | **GET** /advancedstation/getinfo | Gets the info to display in the sign-in station by it's ID.
*AdvancedstationApi* | [**advancedstationGetlocations**](docs/AdvancedstationApi.md#advancedstationgetlocations) | **GET** /advancedstation/getlocations | Gets the locations available in a sign-in station.
*AdvancedstationApi* | [**advancedstationGetlogstaff**](docs/AdvancedstationApi.md#advancedstationgetlogstaff) | **GET** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
*AdvancedstationApi* | [**advancedstationGetroles**](docs/AdvancedstationApi.md#advancedstationgetroles) | **GET** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
*AdvancedstationApi* | [**advancedstationGetservices**](docs/AdvancedstationApi.md#advancedstationgetservices) | **GET** /advancedstation/getservices | Gets the services available for a specific location.
*AdvancedstationApi* | [**advancedstationGetstaff**](docs/AdvancedstationApi.md#advancedstationgetstaff) | **GET** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
*AdvancedstationApi* | [**advancedstationIssignedin**](docs/AdvancedstationApi.md#advancedstationissignedin) | **GET** /advancedstation/issignedin | Gets whether a user is signed-in or not.
*AdvroleApi* | [**advroleAddmissing**](docs/AdvroleApi.md#advroleaddmissing) | **GET** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
*AdvroleApi* | [**advroleCheckperm**](docs/AdvroleApi.md#advrolecheckperm) | **GET** /advrole/checkperm | Checks the permissions are assigned for the given roles
*AdvroleApi* | [**advroleDelete**](docs/AdvroleApi.md#advroledelete) | **DELETE** /advrole/{id} | Delete a role
*AdvroleApi* | [**advroleDeletemapping**](docs/AdvroleApi.md#advroledeletemapping) | **DELETE** /advrole/deletemapping | Delete a role mapping
*AdvroleApi* | [**advroleGet**](docs/AdvroleApi.md#advroleget) | **GET** /advrole/{id} | View details of a role
*AdvroleApi* | [**advroleList**](docs/AdvroleApi.md#advrolelist) | **GET** /advrole/list | Lists the roles for the current account
*AdvroleApi* | [**advroleListmaps**](docs/AdvroleApi.md#advrolelistmaps) | **GET** /advrole/listmaps | Lists the maps a roles is mapped to
*AdvroleApi* | [**advroleListrolesmapped**](docs/AdvroleApi.md#advrolelistrolesmapped) | **GET** /advrole/listrolesmapped | Lists the roles mappings
*AdvroleApi* | [**advroleListtemplates**](docs/AdvroleApi.md#advrolelisttemplates) | **GET** /advrole/listtemplates | View a list of role templates
*AdvroleApi* | [**advroleSave**](docs/AdvroleApi.md#advrolesave) | **POST** /advrole/{id} | Create or edit a role
*AdvroleApi* | [**advroleSavemapping**](docs/AdvroleApi.md#advrolesavemapping) | **POST** /advrole/savemapping | Saves a role mapping
*AdvroleApi* | [**advroleUserupgrade**](docs/AdvroleApi.md#advroleuserupgrade) | **GET** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)
*AdvrolesApi* | [**advrolesUserlist**](docs/AdvrolesApi.md#advrolesuserlist) | **GET** /advroles/userlist | List users. Alias to user.list, use that one instead.
*AppointmentApi* | [**appointmentCancel**](docs/AppointmentApi.md#appointmentcancel) | **GET** /appointment/cancel | Cancel an appointment
*AppointmentApi* | [**appointmentCheckisvalid**](docs/AppointmentApi.md#appointmentcheckisvalid) | **GET** /appointment/checkisvalid | Check if an appointment is valid or not
*AppointmentApi* | [**appointmentEditanyway**](docs/AppointmentApi.md#appointmenteditanyway) | **GET** /appointment/editanyway | Edit an appointment even if it breaks activated rules
*AppointmentApi* | [**appointmentEditpresence**](docs/AppointmentApi.md#appointmenteditpresence) | **GET** /appointment/editpresence | Edit the no-show status of an appointment
*AppointmentApi* | [**appointmentFindallstaffslots**](docs/AppointmentApi.md#appointmentfindallstaffslots) | **GET** /appointment/findallstaffslots | Finds all staff available slots filtered by service, date, etc
*AppointmentApi* | [**appointmentFindslots**](docs/AppointmentApi.md#appointmentfindslots) | **GET** /appointment/findslots | Finds available slots filtered by service, date, staff, etc
*AppointmentApi* | [**appointmentFindstaff**](docs/AppointmentApi.md#appointmentfindstaff) | **GET** /appointment/findstaff | Finds staff available by service, date, event, etc
*AppointmentApi* | [**appointmentGet**](docs/AppointmentApi.md#appointmentget) | **GET** /appointment/{id} | Search and view details of an appointment
*AppointmentApi* | [**appointmentGetcurrent**](docs/AppointmentApi.md#appointmentgetcurrent) | **GET** /appointment/getcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
*AppointmentApi* | [**appointmentGetlocations**](docs/AppointmentApi.md#appointmentgetlocations) | **GET** /appointment/getlocations | Find locations where a service is available
*AppointmentApi* | [**appointmentList**](docs/AppointmentApi.md#appointmentlist) | **GET** /appointment/list | View a list of appointments
*AppointmentApi* | [**appointmentListmine**](docs/AppointmentApi.md#appointmentlistmine) | **GET** /appointment/listmine | View all my upcoming appointments
*AppointmentApi* | [**appointmentListupcoming**](docs/AppointmentApi.md#appointmentlistupcoming) | **GET** /appointment/listupcoming | Search and view details of all my upcoming appointments
*AppointmentApi* | [**appointmentRescheduleoutlook**](docs/AppointmentApi.md#appointmentrescheduleoutlook) | **GET** /appointment/rescheduleoutlook | Reschedule an appointment from MS Outlook.
*AppointmentApi* | [**appointmentRestore**](docs/AppointmentApi.md#appointmentrestore) | **GET** /appointment/restore | Restore an appointment
*AppointmentApi* | [**appointmentRestoreanyway**](docs/AppointmentApi.md#appointmentrestoreanyway) | **GET** /appointment/restoreanyway | Restore an appointment even if it breaks activated rules
*AppointmentApi* | [**appointmentSave**](docs/AppointmentApi.md#appointmentsave) | **POST** /appointment/{id} | Schedule an appointment
*AppointmentApi* | [**appointmentSetasvalid**](docs/AppointmentApi.md#appointmentsetasvalid) | **GET** /appointment/setasvalid | Schedule an appointment even if it breaks activated rules
*AppointmentApi* | [**appointmentSuggestlocations**](docs/AppointmentApi.md#appointmentsuggestlocations) | **GET** /appointment/suggestlocations | View the locations with most appointments
*AppointmentApi* | [**appointmentSuggestservices**](docs/AppointmentApi.md#appointmentsuggestservices) | **GET** /appointment/suggestservices | View the services with most appointments
*AppointmentApi* | [**appointmentVoid**](docs/AppointmentApi.md#appointmentvoid) | **GET** /appointment/void | Void an appointment
*AppshareApi* | [**appshareGetphone**](docs/AppshareApi.md#appsharegetphone) | **GET** /appshare/getphone | Gets the phone number of the current user
*AppshareApi* | [**appshareSendtext**](docs/AppshareApi.md#appsharesendtext) | **GET** /appshare/sendtext | Sends an SMS with the link to the app
*AttendancelogApi* | [**attendancelogDelete**](docs/AttendancelogApi.md#attendancelogdelete) | **DELETE** /attendancelog/{id} | Delete an attendance log
*AttendancelogApi* | [**attendancelogGet**](docs/AttendancelogApi.md#attendancelogget) | **GET** /attendancelog/{id} | Search and view details of an attendance log
*AttendancelogApi* | [**attendancelogGetchangehistory**](docs/AttendancelogApi.md#attendanceloggetchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log's swipe history
*AttendancelogApi* | [**attendancelogList**](docs/AttendancelogApi.md#attendanceloglist) | **GET** /attendancelog/list | View a list of attendance logs
*AttendancelogApi* | [**attendancelogListmine**](docs/AttendancelogApi.md#attendanceloglistmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
*AttendancelogApi* | [**attendancelogListstaff**](docs/AttendancelogApi.md#attendancelogliststaff) | **GET** /attendancelog/liststaff | Gets the attendance logs that the current user is involved in as staff
*AttendancelogApi* | [**attendancelogSave**](docs/AttendancelogApi.md#attendancelogsave) | **POST** /attendancelog/{id} | Create or edit an attendance log
*AttendancelogApi* | [**attendancelogSignout**](docs/AttendancelogApi.md#attendancelogsignout) | **GET** /attendancelog/signout | Sign out an attendance log
*AttendancelogApi* | [**attendancelogWhosin**](docs/AttendancelogApi.md#attendancelogwhosin) | **GET** /attendancelog/whosin | View who's in a location
*AttendancelogcommentApi* | [**attendancelogcommentDelete**](docs/AttendancelogcommentApi.md#attendancelogcommentdelete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
*AttendancelogcommentApi* | [**attendancelogcommentGet**](docs/AttendancelogcommentApi.md#attendancelogcommentget) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
*AttendancelogcommentApi* | [**attendancelogcommentList**](docs/AttendancelogcommentApi.md#attendancelogcommentlist) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
*AttendancelogcommentApi* | [**attendancelogcommentSave**](docs/AttendancelogcommentApi.md#attendancelogcommentsave) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log
*AttendancerestrictionApi* | [**attendancerestrictionDelete**](docs/AttendancerestrictionApi.md#attendancerestrictiondelete) | **DELETE** /attendancerestriction/{id} | Delete an attendance restriction
*AttendancerestrictionApi* | [**attendancerestrictionGet**](docs/AttendancerestrictionApi.md#attendancerestrictionget) | **GET** /attendancerestriction/{id} | View details of an attendance restriction
*AttendancerestrictionApi* | [**attendancerestrictionList**](docs/AttendancerestrictionApi.md#attendancerestrictionlist) | **GET** /attendancerestriction/list | View a list of attendance restrictions
*AttendancerestrictionApi* | [**attendancerestrictionSave**](docs/AttendancerestrictionApi.md#attendancerestrictionsave) | **POST** /attendancerestriction/{id} | Create or edit an attendance restriction
*BeaconApi* | [**beaconDelete**](docs/BeaconApi.md#beacondelete) | **DELETE** /beacon/{id} | Delete a beacon profile
*BeaconApi* | [**beaconDisable**](docs/BeaconApi.md#beacondisable) | **GET** /beacon/disable | Disable beacon support account wide
*BeaconApi* | [**beaconGet**](docs/BeaconApi.md#beaconget) | **GET** /beacon/{id} | View details of a beacon profile
*BeaconApi* | [**beaconGetlocations**](docs/BeaconApi.md#beacongetlocations) | **GET** /beacon/getlocations | Get the sign-in stations assigned to specific beacons.
*BeaconApi* | [**beaconGetstationlocation**](docs/BeaconApi.md#beacongetstationlocation) | **GET** /beacon/getstationlocation | Get the location settings in the specified sign-in station.
*BeaconApi* | [**beaconGetuuid**](docs/BeaconApi.md#beacongetuuid) | **GET** /beacon/getuuid | View the identifier for the account's beacon region (for sign-in stations).
*BeaconApi* | [**beaconList**](docs/BeaconApi.md#beaconlist) | **GET** /beacon/list | View a list of beacon profiles
*BeaconApi* | [**beaconListprofiles**](docs/BeaconApi.md#beaconlistprofiles) | **GET** /beacon/listprofiles | View a list of beacon profiles with their characteristics
*BeaconApi* | [**beaconResetuuid**](docs/BeaconApi.md#beaconresetuuid) | **GET** /beacon/resetuuid | Generate or reset the identifier for the account's beacon region.
*BeaconApi* | [**beaconSave**](docs/BeaconApi.md#beaconsave) | **POST** /beacon/{id} | Create or edit a beacon profile
*BeaconApi* | [**beaconScanlocations**](docs/BeaconApi.md#beaconscanlocations) | **GET** /beacon/scanlocations | Check if there's location available to sign-in / out.
*BeaconApi* | [**beaconSetuuid**](docs/BeaconApi.md#beaconsetuuid) | **GET** /beacon/setuuid | Set the identifier for the account's beacon region (for sign-in stations).
*BeaconApi* | [**beaconSilentregions**](docs/BeaconApi.md#beaconsilentregions) | **GET** /beacon/silentregions | View all the beacon regions defined for silent tracking
*BeaconApi* | [**beaconSilentsignin**](docs/BeaconApi.md#beaconsilentsignin) | **GET** /beacon/silentsignin | Sign-in silently from the location specified by a beacon
*BeaconApi* | [**beaconSilentsignout**](docs/BeaconApi.md#beaconsilentsignout) | **GET** /beacon/silentsignout | Sign-out silently from the location specified by a beacon
*BgjobApi* | [**bgjobGetstatus**](docs/BgjobApi.md#bgjobgetstatus) | **GET** /bgjob/getstatus | Get background job status
*CaptchaApi* | [**captchaGetchallenge**](docs/CaptchaApi.md#captchagetchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
*CaptchaApi* | [**captchaGetimage**](docs/CaptchaApi.md#captchagetimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.
*ClientApi* | [**clientGet**](docs/ClientApi.md#clientget) | **GET** /client/get | Get client
*ClientApi* | [**clientList**](docs/ClientApi.md#clientlist) | **GET** /client/list | Gets the clients of the specified conference
*ClientApi* | [**clientSave**](docs/ClientApi.md#clientsave) | **POST** /client/save | Saves a client
*ClientApi* | [**clientSendmessage**](docs/ClientApi.md#clientsendmessage) | **GET** /client/sendmessage | Send a message to a client
*CommunityApi* | [**communityInvite**](docs/CommunityApi.md#communityinvite) | **GET** /community/invite | Sends an invitation to everyone to AccuCampus Communities
*CommunityApi* | [**communityJoin**](docs/CommunityApi.md#communityjoin) | **GET** /community/join | Sends an invitation for myself to AccuCampus Communities
*CompasscategoryApi* | [**compasscategoryDelete**](docs/CompasscategoryApi.md#compasscategorydelete) | **DELETE** /compasscategory/{id} | Delete a compass category
*CompasscategoryApi* | [**compasscategoryGet**](docs/CompasscategoryApi.md#compasscategoryget) | **GET** /compasscategory/{id} | View details of a compass category
*CompasscategoryApi* | [**compasscategoryList**](docs/CompasscategoryApi.md#compasscategorylist) | **GET** /compasscategory/list | View a list of compass categories
*CompasscategoryApi* | [**compasscategorySave**](docs/CompasscategoryApi.md#compasscategorysave) | **POST** /compasscategory/{id} | Create or edit a compass category
*CompassserviceApi* | [**compassserviceList**](docs/CompassserviceApi.md#compassservicelist) | **GET** /compassservice/list | View all the services added to the compass
*CompassserviceApi* | [**compassserviceListlocations**](docs/CompassserviceApi.md#compassservicelistlocations) | **GET** /compassservice/listlocations | View all the locations where a service added to the compass is available
*ComputerlabApi* | [**computerlabDeletecomputer**](docs/ComputerlabApi.md#computerlabdeletecomputer) | **DELETE** /computerlab/deletecomputer | Delete a computer
*ComputerlabApi* | [**computerlabGetcomputer**](docs/ComputerlabApi.md#computerlabgetcomputer) | **GET** /computerlab/getcomputer | Search and view details of a computer
*ComputerlabApi* | [**computerlabGetsettings**](docs/ComputerlabApi.md#computerlabgetsettings) | **GET** /computerlab/getsettings | Loads the settings for a computer lab
*ComputerlabApi* | [**computerlabIssignedin**](docs/ComputerlabApi.md#computerlabissignedin) | **GET** /computerlab/issignedin | Gets whether a user is signed-in or not.
*ComputerlabApi* | [**computerlabListcomputers**](docs/ComputerlabApi.md#computerlablistcomputers) | **GET** /computerlab/listcomputers | View a list of computers
*ComputerlabApi* | [**computerlabListlabs**](docs/ComputerlabApi.md#computerlablistlabs) | **GET** /computerlab/listlabs | View a list of the locations that use the Computer Lab add-on
*ComputerlabApi* | [**computerlabListstations**](docs/ComputerlabApi.md#computerlabliststations) | **GET** /computerlab/liststations | View a list of sign-in stations available for computer labs.
*ComputerlabApi* | [**computerlabSavecomputer**](docs/ComputerlabApi.md#computerlabsavecomputer) | **POST** /computerlab/savecomputer | Create or edit a computer
*ComputerlabApi* | [**computerlabSavesettings**](docs/ComputerlabApi.md#computerlabsavesettings) | **POST** /computerlab/savesettings | Saves the settings for a computer lab
*ComputerlabApi* | [**computerlabSaveswipe**](docs/ComputerlabApi.md#computerlabsaveswipe) | **POST** /computerlab/saveswipe | Save a new swipe from a computer in a computer lab.
*DeadendrecordingApi* | [**deadendrecordingDelete**](docs/DeadendrecordingApi.md#deadendrecordingdelete) | **DELETE** /deadendrecording/delete | Deletes a dead-end record group
*DeadendrecordingApi* | [**deadendrecordingList**](docs/DeadendrecordingApi.md#deadendrecordinglist) | **GET** /deadendrecording/list | Lists the recorded dead ends, if enabled
*DeadendrecordingApi* | [**deadendrecordingListcomments**](docs/DeadendrecordingApi.md#deadendrecordinglistcomments) | **GET** /deadendrecording/listcomments | Lists the comments for a specific dead end
*DeadendrecordingApi* | [**deadendrecordingSave**](docs/DeadendrecordingApi.md#deadendrecordingsave) | **POST** /deadendrecording/save | Saves a dead-end record
*DepartmentApi* | [**departmentDelete**](docs/DepartmentApi.md#departmentdelete) | **DELETE** /department/{id} | Delete a college department
*DepartmentApi* | [**departmentGet**](docs/DepartmentApi.md#departmentget) | **GET** /department/{id} | Search and view details of a college department
*DepartmentApi* | [**departmentList**](docs/DepartmentApi.md#departmentlist) | **GET** /department/list | View a list of college departments
*DepartmentApi* | [**departmentSave**](docs/DepartmentApi.md#departmentsave) | **POST** /department/{id} | Create or edit a college department
*EasyloginApi* | [**easyloginAddbgimage**](docs/EasyloginApi.md#easyloginaddbgimage) | **GET** /easylogin/addbgimage | Adds background image for the login
*EventApi* | [**eventChecksessions**](docs/EventApi.md#eventchecksessions) | **GET** /event/checksessions | Edit an event's sessions according to their schedule
*EventApi* | [**eventDelete**](docs/EventApi.md#eventdelete) | **DELETE** /event/{id} | Delete a course
*EventApi* | [**eventGet**](docs/EventApi.md#eventget) | **GET** /event/{id} | Search and view details of a course
*EventApi* | [**eventGetsessionsbydate**](docs/EventApi.md#eventgetsessionsbydate) | **GET** /event/getsessionsbydate | View a list of courses by date
*EventApi* | [**eventList**](docs/EventApi.md#eventlist) | **GET** /event/list | View a list of courses
*EventApi* | [**eventListregistered**](docs/EventApi.md#eventlistregistered) | **GET** /event/listregistered | View a list of courses I am registered to
*EventApi* | [**eventSave**](docs/EventApi.md#eventsave) | **POST** /event/{id} | Create or edit a course
*EventApi* | [**eventSearchgroup**](docs/EventApi.md#eventsearchgroup) | **GET** /event/searchgroup | Searches for the available event groups
*EventregApi* | [**eventregAddme**](docs/EventregApi.md#eventregaddme) | **GET** /eventreg/addme | Register current user to a course
*EventregApi* | [**eventregAddmetoall**](docs/EventregApi.md#eventregaddmetoall) | **GET** /eventreg/addmetoall | Register current user to all courses
*EventregApi* | [**eventregAddmetogroup**](docs/EventregApi.md#eventregaddmetogroup) | **GET** /eventreg/addmetogroup | Register current user to a course group
*EventregApi* | [**eventregAdduser**](docs/EventregApi.md#eventregadduser) | **GET** /eventreg/adduser | Register a user to a course for attendance
*EventregApi* | [**eventregAddusertoall**](docs/EventregApi.md#eventregaddusertoall) | **GET** /eventreg/addusertoall | Register a user to assist with all courses
*EventregApi* | [**eventregAddusertogroup**](docs/EventregApi.md#eventregaddusertogroup) | **GET** /eventreg/addusertogroup | Register a user to an course group
*EventregApi* | [**eventregGetevents**](docs/EventregApi.md#eventreggetevents) | **GET** /eventreg/getevents | View course registration by user
*EventregApi* | [**eventregGetgroups**](docs/EventregApi.md#eventreggetgroups) | **GET** /eventreg/getgroups | Lists the course group registrations of a user
*EventregApi* | [**eventregGetmyevents**](docs/EventregApi.md#eventreggetmyevents) | **GET** /eventreg/getmyevents | View the event registrations of the current user
*EventregApi* | [**eventregGetmygroups**](docs/EventregApi.md#eventreggetmygroups) | **GET** /eventreg/getmygroups | View all current user registrations to course groups
*EventregApi* | [**eventregGetusers**](docs/EventregApi.md#eventreggetusers) | **GET** /eventreg/getusers | View course registration
*EventregApi* | [**eventregGetusersfromgroup**](docs/EventregApi.md#eventreggetusersfromgroup) | **GET** /eventreg/getusersfromgroup | Lists the registrations for a course group
*EventregApi* | [**eventregGetuserstoall**](docs/EventregApi.md#eventreggetuserstoall) | **GET** /eventreg/getuserstoall | View the users that are registered to all courses
*EventregApi* | [**eventregRemoveme**](docs/EventregApi.md#eventregremoveme) | **GET** /eventreg/removeme | Unregister current user from a course
*EventregApi* | [**eventregRemovemefromall**](docs/EventregApi.md#eventregremovemefromall) | **GET** /eventreg/removemefromall | Remove current user from the registration to all courses
*EventregApi* | [**eventregRemovemefromgroup**](docs/EventregApi.md#eventregremovemefromgroup) | **GET** /eventreg/removemefromgroup | Remove current user from a course group
*EventregApi* | [**eventregRemoveuser**](docs/EventregApi.md#eventregremoveuser) | **GET** /eventreg/removeuser | Remove a user from a course
*EventregApi* | [**eventregRemoveuserfromall**](docs/EventregApi.md#eventregremoveuserfromall) | **GET** /eventreg/removeuserfromall | Remove a user from the registration to all courses
*EventregApi* | [**eventregRemoveuserfromgroup**](docs/EventregApi.md#eventregremoveuserfromgroup) | **GET** /eventreg/removeuserfromgroup | Remove a user from a course group
*ExportApi* | [**exportListtypes**](docs/ExportApi.md#exportlisttypes) | **GET** /export/listtypes | Lists available export types
*FeatureApi* | [**featureList**](docs/FeatureApi.md#featurelist) | **GET** /feature/list | Lists the available features.
*GeneralApi* | [**changelog**](docs/GeneralApi.md#changelog) | **GET** /changelog | Get the application change log
*GeneralApi* | [**doc**](docs/GeneralApi.md#doc) | **GET** /doc | Get the documentation
*GeneralApi* | [**export**](docs/GeneralApi.md#export) | **GET** /export | Export AccuCampus data
*GeneralApi* | [**import**](docs/GeneralApi.md#import) | **GET** /import | Import data into AccuCampus
*GeneralApi* | [**listtimezones**](docs/GeneralApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
*GeneralApi* | [**login**](docs/GeneralApi.md#login) | **GET** /login | Login
*GeneralApi* | [**logout**](docs/GeneralApi.md#logout) | **GET** /logout | Logout
*GeneralApi* | [**search**](docs/GeneralApi.md#search) | **GET** /search | Search
*GeneralApi* | [**texttoimage**](docs/GeneralApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
*GeneralApi* | [**version**](docs/GeneralApi.md#version) | **GET** /version | Get current version information
*HolidayApi* | [**holidayList**](docs/HolidayApi.md#holidaylist) | **GET** /holiday/list | View a list of entered holidays
*HolidayApi* | [**holidaySave**](docs/HolidayApi.md#holidaysave) | **POST** /holiday/save | Create or edit a list of holidays
*HolidayApi* | [**holidaySuggest**](docs/HolidayApi.md#holidaysuggest) | **GET** /holiday/suggest | View the holiday suggestions in the given term
*ImportApi* | [**importListtypes**](docs/ImportApi.md#importlisttypes) | **GET** /import/listtypes | Lists available import types
*InteractionApi* | [**interactionDelete**](docs/InteractionApi.md#interactiondelete) | **DELETE** /interaction/{id} | Delete an interaction
*InteractionApi* | [**interactionFeed**](docs/InteractionApi.md#interactionfeed) | **GET** /interaction/feed | Get the interactions feed
*InteractionApi* | [**interactionGet**](docs/InteractionApi.md#interactionget) | **GET** /interaction/{id} | View an interaction
*InteractionApi* | [**interactionListprivatesummary**](docs/InteractionApi.md#interactionlistprivatesummary) | **GET** /interaction/listprivatesummary | Get current user's latest private interactions
*InteractionApi* | [**interactionSave**](docs/InteractionApi.md#interactionsave) | **POST** /interaction/{id} | Save an interaction
*LicenseApi* | [**licenseAcceptagreement**](docs/LicenseApi.md#licenseacceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
*LicenseApi* | [**licenseGetagreementstatus**](docs/LicenseApi.md#licensegetagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
*LicenseApi* | [**licenseGetcurrent**](docs/LicenseApi.md#licensegetcurrent) | **GET** /license/getcurrent | Gets the current license information
*LicenseApi* | [**licenseRenew**](docs/LicenseApi.md#licenserenew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuCampus subscription
*LikeApi* | [**likeDelete**](docs/LikeApi.md#likedelete) | **DELETE** /like/delete | Delete a like
*LikeApi* | [**likeList**](docs/LikeApi.md#likelist) | **GET** /like/list | View all the likes associated to a target
*LikeApi* | [**likeSave**](docs/LikeApi.md#likesave) | **POST** /like/save | Save a like
*LocationApi* | [**locationDelete**](docs/LocationApi.md#locationdelete) | **DELETE** /location/{id} | Delete a location
*LocationApi* | [**locationGet**](docs/LocationApi.md#locationget) | **GET** /location/{id} | Search and view details of a location
*LocationApi* | [**locationList**](docs/LocationApi.md#locationlist) | **GET** /location/list | View a list of locations
*LocationApi* | [**locationSave**](docs/LocationApi.md#locationsave) | **POST** /location/{id} | Create or edit a location
*MediaApi* | [**mediaCheckin**](docs/MediaApi.md#mediacheckin) | **GET** /media/checkin | Check in media item
*MediaApi* | [**mediaCheckout**](docs/MediaApi.md#mediacheckout) | **GET** /media/checkout | Check out media item
*MediaApi* | [**mediaCheckoutlist**](docs/MediaApi.md#mediacheckoutlist) | **GET** /media/checkoutlist | View a list of past media checkouts
*MediaApi* | [**mediaDelete**](docs/MediaApi.md#mediadelete) | **DELETE** /media/{id} | Delete a media item
*MediaApi* | [**mediaDeletecheckoutlog**](docs/MediaApi.md#mediadeletecheckoutlog) | **DELETE** /media/deletecheckoutlog | Delete a media checkout log
*MediaApi* | [**mediaGet**](docs/MediaApi.md#mediaget) | **GET** /media/{id} | Search and view details of a media item
*MediaApi* | [**mediaGetbycode**](docs/MediaApi.md#mediagetbycode) | **GET** /media/getbycode | Search media item by unique code
*MediaApi* | [**mediaGetcheckout**](docs/MediaApi.md#mediagetcheckout) | **GET** /media/getcheckout | View details of a media item checkout information
*MediaApi* | [**mediaGetcheckoutlog**](docs/MediaApi.md#mediagetcheckoutlog) | **GET** /media/getcheckoutlog | View details of a media checkout log
*MediaApi* | [**mediaList**](docs/MediaApi.md#medialist) | **GET** /media/list | View a list of media items
*MediaApi* | [**mediaSave**](docs/MediaApi.md#mediasave) | **POST** /media/{id} | Create or edit a media item
*MediatypeApi* | [**mediatypeDelete**](docs/MediatypeApi.md#mediatypedelete) | **DELETE** /mediatype/{id} | Delete a media type
*MediatypeApi* | [**mediatypeGet**](docs/MediatypeApi.md#mediatypeget) | **GET** /mediatype/{id} | Search and view details of a media type
*MediatypeApi* | [**mediatypeList**](docs/MediatypeApi.md#mediatypelist) | **GET** /mediatype/list | View a list of media types
*MediatypeApi* | [**mediatypeSave**](docs/MediatypeApi.md#mediatypesave) | **POST** /mediatype/{id} | Create or edit a media type
*MemorizedreportApi* | [**memorizedreportDelete**](docs/MemorizedreportApi.md#memorizedreportdelete) | **DELETE** /memorizedreport/{id} | Delete memorized report
*MemorizedreportApi* | [**memorizedreportGet**](docs/MemorizedreportApi.md#memorizedreportget) | **GET** /memorizedreport/{id} | View details of a memorized report
*MemorizedreportApi* | [**memorizedreportList**](docs/MemorizedreportApi.md#memorizedreportlist) | **GET** /memorizedreport/list | View a list of all his memorized reports
*MemorizedreportApi* | [**memorizedreportSave**](docs/MemorizedreportApi.md#memorizedreportsave) | **POST** /memorizedreport/{id} | Create or edit a memorized report
*MenuApi* | [**menuGetitems**](docs/MenuApi.md#menugetitems) | **GET** /menu/getitems | Gets the items on the menu
*MyApi* | [**myAccount**](docs/MyApi.md#myaccount) | **GET** /my/account | Gets the logged in user account.
*MyApi* | [**myIanatimezone**](docs/MyApi.md#myianatimezone) | **GET** /my/ianatimezone | Gets the current time zone's iana name
*MyApi* | [**myProfile**](docs/MyApi.md#myprofile) | **GET** /my/profile | Gets the logged in user information.
*MyApi* | [**myRights**](docs/MyApi.md#myrights) | **GET** /my/rights | Gets the list of actions the user can execute.
*MyApi* | [**mySaveprofile**](docs/MyApi.md#mysaveprofile) | **POST** /my/saveprofile | Updates logged user's profile information
*NotificationApi* | [**notificationDelete**](docs/NotificationApi.md#notificationdelete) | **DELETE** /notification/{id} | Delete a notification
*NotificationApi* | [**notificationGet**](docs/NotificationApi.md#notificationget) | **GET** /notification/{id} | View a notification
*NotificationApi* | [**notificationGetforstation**](docs/NotificationApi.md#notificationgetforstation) | **GET** /notification/getforstation | Gets all public (in station) notifications for the specific user
*NotificationApi* | [**notificationGetunreadcount**](docs/NotificationApi.md#notificationgetunreadcount) | **GET** /notification/getunreadcount | Get the number of unread notifications
*NotificationApi* | [**notificationList**](docs/NotificationApi.md#notificationlist) | **GET** /notification/list | View a list of all sent notifications
*NotificationApi* | [**notificationListmine**](docs/NotificationApi.md#notificationlistmine) | **GET** /notification/listmine | View all the notifications sent to the current user
*NotificationApi* | [**notificationMarkasread**](docs/NotificationApi.md#notificationmarkasread) | **GET** /notification/markasread | Mark a notification as read
*NotificationApi* | [**notificationMarkasunread**](docs/NotificationApi.md#notificationmarkasunread) | **GET** /notification/markasunread | Mark a notification as unread
*NotificationApi* | [**notificationSend**](docs/NotificationApi.md#notificationsend) | **GET** /notification/send | Send notifications on screen, via email or text to users
*NotificationApi* | [**notificationSendonscreen**](docs/NotificationApi.md#notificationsendonscreen) | **GET** /notification/sendonscreen | Send on-screen notifications
*NotificationtopicApi* | [**notificationtopicDelete**](docs/NotificationtopicApi.md#notificationtopicdelete) | **DELETE** /notificationtopic/{id} | Delete a notification topic
*NotificationtopicApi* | [**notificationtopicGet**](docs/NotificationtopicApi.md#notificationtopicget) | **GET** /notificationtopic/{id} | Search and view details of a notification topic
*NotificationtopicApi* | [**notificationtopicList**](docs/NotificationtopicApi.md#notificationtopiclist) | **GET** /notificationtopic/list | List all the notification topics
*NotificationtopicApi* | [**notificationtopicListsubscribe**](docs/NotificationtopicApi.md#notificationtopiclistsubscribe) | **GET** /notificationtopic/listsubscribe | List all the notification topics available to subscribe
*NotificationtopicApi* | [**notificationtopicSave**](docs/NotificationtopicApi.md#notificationtopicsave) | **POST** /notificationtopic/{id} | Create or edit a notification topic
*PushApi* | [**pushDeregister**](docs/PushApi.md#pushderegister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
*PushApi* | [**pushRegister**](docs/PushApi.md#pushregister) | **GET** /push/register | Registers the current device to receive push notifications
*QrlabelsApi* | [**qrlabelsPrint**](docs/QrlabelsApi.md#qrlabelsprint) | **GET** /qrlabels/print | Print and email QR labels
*QrloginApi* | [**qrloginGet**](docs/QrloginApi.md#qrloginget) | **GET** /qrlogin/get | Gets an image of a QR token
*QrloginApi* | [**qrloginLogin**](docs/QrloginApi.md#qrloginlogin) | **GET** /qrlogin/login | Login
*QuickpanelApi* | [**quickpanelDeletewidget**](docs/QuickpanelApi.md#quickpaneldeletewidget) | **DELETE** /quickpanel/deletewidget | Deletes a widget from the Quick Panel
*QuickpanelApi* | [**quickpanelFetchwidget**](docs/QuickpanelApi.md#quickpanelfetchwidget) | **GET** /quickpanel/fetchwidget | Fetches the information for a specific widget.
*QuickpanelApi* | [**quickpanelGetwidget**](docs/QuickpanelApi.md#quickpanelgetwidget) | **GET** /quickpanel/getwidget | View details of a widget included in the Quick Panel
*QuickpanelApi* | [**quickpanelInit**](docs/QuickpanelApi.md#quickpanelinit) | **GET** /quickpanel/init | Returns the initial information required to show the quick panels
*QuickpanelApi* | [**quickpanelListwidgets**](docs/QuickpanelApi.md#quickpanellistwidgets) | **GET** /quickpanel/listwidgets | Lists all the widgets that are added in the Quick Panel
*QuickpanelApi* | [**quickpanelListwidgettypes**](docs/QuickpanelApi.md#quickpanellistwidgettypes) | **GET** /quickpanel/listwidgettypes | Lists all the widget types available in the system
*QuickpanelApi* | [**quickpanelReorderwidgets**](docs/QuickpanelApi.md#quickpanelreorderwidgets) | **GET** /quickpanel/reorderwidgets | Reorders the widgets and moves them to a specific column
*QuickpanelApi* | [**quickpanelSavewidget**](docs/QuickpanelApi.md#quickpanelsavewidget) | **POST** /quickpanel/savewidget | Saves a widget for the Quick Panel
*RatingApi* | [**ratingFlag**](docs/RatingApi.md#ratingflag) | **GET** /rating/flag | Flags one rating for moderation
*RatingApi* | [**ratingFlagcomment**](docs/RatingApi.md#ratingflagcomment) | **GET** /rating/flagcomment | Flags one comment for moderation
*RatingApi* | [**ratingGet**](docs/RatingApi.md#ratingget) | **GET** /rating/get | Get rating for one or more entities
*RatingApi* | [**ratingGetall**](docs/RatingApi.md#ratinggetall) | **GET** /rating/getall | Gets the full ratings and comments for a specific entity
*RatingApi* | [**ratingGetcomments**](docs/RatingApi.md#ratinggetcomments) | **GET** /rating/getcomments | Gets all the comments for a rating
*RatingApi* | [**ratingGetpending**](docs/RatingApi.md#ratinggetpending) | **GET** /rating/getpending | Gets info of pre-saved and pre-approved ratings
*RatingApi* | [**ratingGetpendingmoderation**](docs/RatingApi.md#ratinggetpendingmoderation) | **GET** /rating/getpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
*RatingApi* | [**ratingModerate**](docs/RatingApi.md#ratingmoderate) | **GET** /rating/moderate | Allows the user to accept or reject a comment
*RatingApi* | [**ratingPostcomment**](docs/RatingApi.md#ratingpostcomment) | **GET** /rating/postcomment | Posts a comments for in a rating
*RatingApi* | [**ratingRate**](docs/RatingApi.md#ratingrate) | **GET** /rating/rate | Rates one entity
*RatingApi* | [**ratingRatepending**](docs/RatingApi.md#ratingratepending) | **GET** /rating/ratepending | Rates a pre-saved and pre-approved entity
*RatingApi* | [**ratingVote**](docs/RatingApi.md#ratingvote) | **GET** /rating/vote | Votes up or down a rating
*ReportApi* | [**reportAttanalyticsprepare**](docs/ReportApi.md#reportattanalyticsprepare) | **GET** /report/attanalyticsprepare | Query and load an attendance analytics report
*ReportApi* | [**reportList**](docs/ReportApi.md#reportlist) | **GET** /report/list | View a list of available reports
*ReportApi* | [**reportPermissionsbyuser**](docs/ReportApi.md#reportpermissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
*ReportApi* | [**reportPrepare**](docs/ReportApi.md#reportprepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
*ReportApi* | [**reportQuery**](docs/ReportApi.md#reportquery) | **GET** /report/query | Query and load a specified report
*ReportApi* | [**reportTagresults**](docs/ReportApi.md#reporttagresults) | **GET** /report/tagresults | Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
*ReportscheduleApi* | [**reportscheduleDelete**](docs/ReportscheduleApi.md#reportscheduledelete) | **DELETE** /reportschedule/{id} | Delete a report schedule
*ReportscheduleApi* | [**reportscheduleGet**](docs/ReportscheduleApi.md#reportscheduleget) | **GET** /reportschedule/{id} | Get a report schedule
*ReportscheduleApi* | [**reportscheduleList**](docs/ReportscheduleApi.md#reportschedulelist) | **GET** /reportschedule/list | View a list of the scheduled reports
*ReportscheduleApi* | [**reportscheduleSave**](docs/ReportscheduleApi.md#reportschedulesave) | **POST** /reportschedule/{id} | Create or edit a report schedule
*RiskmodelApi* | [**riskmodelCheckanalysis**](docs/RiskmodelApi.md#riskmodelcheckanalysis) | **GET** /riskmodel/checkanalysis | Check the status of the analysis of a specified risk assessment model
*RiskmodelApi* | [**riskmodelDelete**](docs/RiskmodelApi.md#riskmodeldelete) | **DELETE** /riskmodel/{id} | Delete a risk assessment model
*RiskmodelApi* | [**riskmodelGet**](docs/RiskmodelApi.md#riskmodelget) | **GET** /riskmodel/{id} | View details of a risk assessment model
*RiskmodelApi* | [**riskmodelGetscore**](docs/RiskmodelApi.md#riskmodelgetscore) | **GET** /riskmodel/getscore | View the risk score for a specific user
*RiskmodelApi* | [**riskmodelList**](docs/RiskmodelApi.md#riskmodellist) | **GET** /riskmodel/list | View a list of risk assessment models
*RiskmodelApi* | [**riskmodelPredict**](docs/RiskmodelApi.md#riskmodelpredict) | **GET** /riskmodel/predict | Predict risk based on an assessment model
*RiskmodelApi* | [**riskmodelProcess**](docs/RiskmodelApi.md#riskmodelprocess) | **GET** /riskmodel/process | Process a risk assessment model
*RiskmodelApi* | [**riskmodelRefresh**](docs/RiskmodelApi.md#riskmodelrefresh) | **GET** /riskmodel/refresh | Refresh the information used in a risk assessment model
*RiskmodelApi* | [**riskmodelSave**](docs/RiskmodelApi.md#riskmodelsave) | **POST** /riskmodel/{id} | Create or edit a risk assessment model
*RiskmodelApi* | [**riskmodelTermprecedences**](docs/RiskmodelApi.md#riskmodeltermprecedences) | **GET** /riskmodel/termprecedences | View all default term precedences
*RoleApi* | [**roleList**](docs/RoleApi.md#rolelist) | **GET** /role/list | Show a list of roles
*RuleApi* | [**ruleDelete**](docs/RuleApi.md#ruledelete) | **DELETE** /rule/{id} | Delete a rule
*RuleApi* | [**ruleGet**](docs/RuleApi.md#ruleget) | **GET** /rule/{id} | View details of a rule
*RuleApi* | [**ruleGeteventtype**](docs/RuleApi.md#rulegeteventtype) | **GET** /rule/geteventtype | View details of a rule event type
*RuleApi* | [**ruleList**](docs/RuleApi.md#rulelist) | **GET** /rule/list | View a list of user rules
*RuleApi* | [**ruleListactions**](docs/RuleApi.md#rulelistactions) | **GET** /rule/listactions | View a list of rule actions available
*RuleApi* | [**ruleListeventtypes**](docs/RuleApi.md#rulelisteventtypes) | **GET** /rule/listeventtypes | View a list of rule event types
*RuleApi* | [**ruleListhttprequests**](docs/RuleApi.md#rulelisthttprequests) | **GET** /rule/listhttprequests | View all the http requests sent as a result of a rule
*RuleApi* | [**ruleSave**](docs/RuleApi.md#rulesave) | **POST** /rule/{id} | Create or edit a rule
*ScheduleApi* | [**scheduleDelete**](docs/ScheduleApi.md#scheduledelete) | **DELETE** /schedule/delete | Delete a schedule slot
*ScheduleApi* | [**scheduleDeletemine**](docs/ScheduleApi.md#scheduledeletemine) | **DELETE** /schedule/deletemine | Delete a specific block from a user's own schedule
*ScheduleApi* | [**scheduleEnable**](docs/ScheduleApi.md#scheduleenable) | **GET** /schedule/enable | Enable or disable the schedule for a specific person
*ScheduleApi* | [**scheduleEnablemine**](docs/ScheduleApi.md#scheduleenablemine) | **GET** /schedule/enablemine | Enable or disable current user's schedule
*ScheduleApi* | [**scheduleFindallstaffslots**](docs/ScheduleApi.md#schedulefindallstaffslots) | **GET** /schedule/findallstaffslots | Search available schedule slots by service, event, date
*ScheduleApi* | [**scheduleFindslots**](docs/ScheduleApi.md#schedulefindslots) | **GET** /schedule/findslots | Search available schedule slots by service, event, date and/or staff
*ScheduleApi* | [**scheduleFindstaffavail**](docs/ScheduleApi.md#schedulefindstaffavail) | **GET** /schedule/findstaffavail | Search available staff members slots by service, event, and/or date
*ScheduleApi* | [**scheduleGet**](docs/ScheduleApi.md#scheduleget) | **GET** /schedule/get | Search and view details of a specific schedule slot
*ScheduleApi* | [**scheduleGetmine**](docs/ScheduleApi.md#schedulegetmine) | **GET** /schedule/getmine | View details of a specific schedule block, for current user
*ScheduleApi* | [**scheduleGetstaff**](docs/ScheduleApi.md#schedulegetstaff) | **GET** /schedule/getstaff | View a list of schedule information of a specified person
*ScheduleApi* | [**scheduleGetstaffmine**](docs/ScheduleApi.md#schedulegetstaffmine) | **GET** /schedule/getstaffmine | View current user's schedule information
*ScheduleApi* | [**scheduleMyofftimes**](docs/ScheduleApi.md#schedulemyofftimes) | **GET** /schedule/myofftimes | View current user's schedule exceptions
*ScheduleApi* | [**scheduleSave**](docs/ScheduleApi.md#schedulesave) | **POST** /schedule/save | Create or edit a schedule slot
*ScheduleApi* | [**scheduleSavemine**](docs/ScheduleApi.md#schedulesavemine) | **POST** /schedule/savemine | Create or edit a block in current user's schedule
*ScheduleintegrationApi* | [**scheduleintegrationClearids**](docs/ScheduleintegrationApi.md#scheduleintegrationclearids) | **GET** /scheduleintegration/clearids | Clear all third party IDs from specified staff member's schedule items.
*ScheduleintegrationApi* | [**scheduleintegrationDeleteitem**](docs/ScheduleintegrationApi.md#scheduleintegrationdeleteitem) | **DELETE** /scheduleintegration/deleteitem | Delete a schedule item looking up by a third party ID
*ScheduleintegrationApi* | [**scheduleintegrationDeleteitemsbymasterid**](docs/ScheduleintegrationApi.md#scheduleintegrationdeleteitemsbymasterid) | **DELETE** /scheduleintegration/deleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
*ScheduleintegrationApi* | [**scheduleintegrationGetitem**](docs/ScheduleintegrationApi.md#scheduleintegrationgetitem) | **GET** /scheduleintegration/getitem | Get a schedule item looking up by a third party ID
*ScheduleintegrationApi* | [**scheduleintegrationSaveitem**](docs/ScheduleintegrationApi.md#scheduleintegrationsaveitem) | **POST** /scheduleintegration/saveitem | Save a schedule item looking up by a third party ID
*ScheduleintegrationApi* | [**scheduleintegrationSetid**](docs/ScheduleintegrationApi.md#scheduleintegrationsetid) | **GET** /scheduleintegration/setid | Set a 3rd party ID on a specific schedule item
*SearchApi* | [**searchGetentities**](docs/SearchApi.md#searchgetentities) | **GET** /search/getentities | Get the information of the entities that can be searched
*SecurityApi* | [**securityAssesspermission**](docs/SecurityApi.md#securityassesspermission) | **GET** /security/assesspermission | Returns the list of users for a specific permission
*SecurityApi* | [**securityAssessrole**](docs/SecurityApi.md#securityassessrole) | **GET** /security/assessrole | Returns the list of permissions for a specific role
*SecurityApi* | [**securityAssessscope**](docs/SecurityApi.md#securityassessscope) | **GET** /security/assessscope | Returns the list of users for a specific user
*SecurityApi* | [**securityAssessuser**](docs/SecurityApi.md#securityassessuser) | **GET** /security/assessuser | Returns the list of permissions for a specific user
*SeminarApi* | [**seminarDelete**](docs/SeminarApi.md#seminardelete) | **DELETE** /seminar/{id} | Delete an event
*SeminarApi* | [**seminarGet**](docs/SeminarApi.md#seminarget) | **GET** /seminar/{id} | Search and view details of a event
*SeminarApi* | [**seminarList**](docs/SeminarApi.md#seminarlist) | **GET** /seminar/list | View a list of events
*SeminarApi* | [**seminarSave**](docs/SeminarApi.md#seminarsave) | **POST** /seminar/{id} | Create or edit a event
*ServiceApi* | [**serviceDelete**](docs/ServiceApi.md#servicedelete) | **DELETE** /service/{id} | Delete a service
*ServiceApi* | [**serviceGet**](docs/ServiceApi.md#serviceget) | **GET** /service/{id} | Search and view details of a service
*ServiceApi* | [**serviceList**](docs/ServiceApi.md#servicelist) | **GET** /service/list | View a list of services
*ServiceApi* | [**serviceSave**](docs/ServiceApi.md#servicesave) | **POST** /service/{id} | Create or edit a service
*ServiceassignmentApi* | [**serviceassignmentAddservice**](docs/ServiceassignmentApi.md#serviceassignmentaddservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
*ServiceassignmentApi* | [**serviceassignmentGetlocation**](docs/ServiceassignmentApi.md#serviceassignmentgetlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
*ServiceassignmentApi* | [**serviceassignmentGetservice**](docs/ServiceassignmentApi.md#serviceassignmentgetservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
*ServiceassignmentApi* | [**serviceassignmentRemoveservice**](docs/ServiceassignmentApi.md#serviceassignmentremoveservice) | **GET** /serviceassignment/removeservice | Remove a service from a location
*SessionApi* | [**sessionBulkupdate**](docs/SessionApi.md#sessionbulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
*SessionApi* | [**sessionGet**](docs/SessionApi.md#sessionget) | **GET** /session/{id} | View details of a session
*SessionApi* | [**sessionGetschedule**](docs/SessionApi.md#sessiongetschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
*SessionApi* | [**sessionList**](docs/SessionApi.md#sessionlist) | **GET** /session/list | Gets all future sessions of the current semester
*SessionattendancelogApi* | [**sessionattendancelogAddnote**](docs/SessionattendancelogApi.md#sessionattendancelogaddnote) | **GET** /sessionattendancelog/addnote | Add a note to a class attendance log
*SessionattendancelogApi* | [**sessionattendancelogGet**](docs/SessionattendancelogApi.md#sessionattendancelogget) | **GET** /sessionattendancelog/{id} | View details of a class attendance log
*SessionattendancelogApi* | [**sessionattendancelogGetuser**](docs/SessionattendancelogApi.md#sessionattendanceloggetuser) | **GET** /sessionattendancelog/getuser | View the class session attendance information for a specific user
*SessionattendancelogApi* | [**sessionattendancelogList**](docs/SessionattendancelogApi.md#sessionattendanceloglist) | **GET** /sessionattendancelog/list | View attendance logs of the specified session
*SessionattendancelogApi* | [**sessionattendancelogListevent**](docs/SessionattendancelogApi.md#sessionattendanceloglistevent) | **GET** /sessionattendancelog/listevent | View the attendance information of an entire class
*SessionattendancelogApi* | [**sessionattendancelogListsummary**](docs/SessionattendancelogApi.md#sessionattendanceloglistsummary) | **GET** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
*SessionattendancelogApi* | [**sessionattendancelogMylistsummary**](docs/SessionattendancelogApi.md#sessionattendancelogmylistsummary) | **GET** /sessionattendancelog/mylistsummary | View my attendance summary
*SessionattendancelogApi* | [**sessionattendancelogSave**](docs/SessionattendancelogApi.md#sessionattendancelogsave) | **POST** /sessionattendancelog/{id} | Create or edit a class attendance log
*SessionattendancelogApi* | [**sessionattendancelogSaveswipe**](docs/SessionattendancelogApi.md#sessionattendancelogsaveswipe) | **POST** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe
*SessionregApi* | [**sessionregAddcurrentuser**](docs/SessionregApi.md#sessionregaddcurrentuser) | **GET** /sessionreg/addcurrentuser | Register current user to an event session
*SessionregApi* | [**sessionregAdduser**](docs/SessionregApi.md#sessionregadduser) | **GET** /sessionreg/adduser | Register users for events
*SessionregApi* | [**sessionregGetmysessions**](docs/SessionregApi.md#sessionreggetmysessions) | **GET** /sessionreg/getmysessions | View all the sessions the logged user is registered to
*SessionregApi* | [**sessionregGetsessions**](docs/SessionregApi.md#sessionreggetsessions) | **GET** /sessionreg/getsessions | Lists the registrations for a specific user
*SessionregApi* | [**sessionregGetsettings**](docs/SessionregApi.md#sessionreggetsettings) | **GET** /sessionreg/getsettings | Get the settings for session registration
*SessionregApi* | [**sessionregGetusers**](docs/SessionregApi.md#sessionreggetusers) | **GET** /sessionreg/getusers | Lists the registrations for a specific session
*SessionregApi* | [**sessionregListsessions**](docs/SessionregApi.md#sessionreglistsessions) | **GET** /sessionreg/listsessions | List the sessions available for a specific event
*SessionregApi* | [**sessionregListupcoming**](docs/SessionregApi.md#sessionreglistupcoming) | **GET** /sessionreg/listupcoming | View a list of upcoming event sessions
*SessionregApi* | [**sessionregListupcomingevent**](docs/SessionregApi.md#sessionreglistupcomingevent) | **GET** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
*SessionregApi* | [**sessionregRemovecurrentuser**](docs/SessionregApi.md#sessionregremovecurrentuser) | **GET** /sessionreg/removecurrentuser | Unregister current user from an event session
*SessionregApi* | [**sessionregRemoveuser**](docs/SessionregApi.md#sessionregremoveuser) | **GET** /sessionreg/removeuser | Removes a user from an event session
*SessionregApi* | [**sessionregSavesettings**](docs/SessionregApi.md#sessionregsavesettings) | **POST** /sessionreg/savesettings | Save the settings for an event's session registration
*SessionswipeApi* | [**sessionswipeDelete**](docs/SessionswipeApi.md#sessionswipedelete) | **DELETE** /sessionswipe/{id} | Delete a session swipe
*SessionswipeApi* | [**sessionswipeGet**](docs/SessionswipeApi.md#sessionswipeget) | **GET** /sessionswipe/{id} | View details of a class attendance swipe
*SessionswipeApi* | [**sessionswipeListunresolved**](docs/SessionswipeApi.md#sessionswipelistunresolved) | **GET** /sessionswipe/listunresolved | View a list of unresolved swipes
*SessionswipeApi* | [**sessionswipeResolve**](docs/SessionswipeApi.md#sessionswiperesolve) | **GET** /sessionswipe/resolve | Resolve a swipe and create the corresponding attendance log
*SessionswipeApi* | [**sessionswipeSave**](docs/SessionswipeApi.md#sessionswipesave) | **POST** /sessionswipe/save | Creates a new swipe, and if possible, creates the attendance log
*SessionswipeApi* | [**sessionswipeSaveanonym**](docs/SessionswipeApi.md#sessionswipesaveanonym) | **POST** /sessionswipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
*SettingApi* | [**settingAddlogo**](docs/SettingApi.md#settingaddlogo) | **GET** /setting/addlogo | Add a logo to the account
*SettingApi* | [**settingGet**](docs/SettingApi.md#settingget) | **GET** /setting/get | Get settings for the account or the specified scope
*SettingApi* | [**settingSave**](docs/SettingApi.md#settingsave) | **POST** /setting/save | Save settings for the account or the specified scope
*SettingApi* | [**settingViewgeneral**](docs/SettingApi.md#settingviewgeneral) | **GET** /setting/viewgeneral | View general settings for the account
*SocialApi* | [**socialContacts**](docs/SocialApi.md#socialcontacts) | **GET** /social/contacts | Gets the list of contacts in the network
*SocialgroupApi* | [**socialgroupAddmembers**](docs/SocialgroupApi.md#socialgroupaddmembers) | **GET** /socialgroup/addmembers | Adds new members to a group (which the user must own already)
*SocialgroupApi* | [**socialgroupDelete**](docs/SocialgroupApi.md#socialgroupdelete) | **DELETE** /socialgroup/{id} | Deletes a group
*SocialgroupApi* | [**socialgroupList**](docs/SocialgroupApi.md#socialgrouplist) | **GET** /socialgroup/list | View all the groups the current user is in
*SocialgroupApi* | [**socialgroupListmembers**](docs/SocialgroupApi.md#socialgrouplistmembers) | **GET** /socialgroup/listmembers | Lists the members of a group
*SocialgroupApi* | [**socialgroupRemovemembers**](docs/SocialgroupApi.md#socialgroupremovemembers) | **GET** /socialgroup/removemembers | Removes members from a group (which the user must own already)
*SocialgroupApi* | [**socialgroupRemovemyself**](docs/SocialgroupApi.md#socialgroupremovemyself) | **GET** /socialgroup/removemyself | Removes myself from an existent group
*SocialgroupApi* | [**socialgroupSave**](docs/SocialgroupApi.md#socialgroupsave) | **POST** /socialgroup/{id} | Saves a new group
*SsoApi* | [**ssoGeneratekey**](docs/SsoApi.md#ssogeneratekey) | **GET** /sso/generatekey | Generate/reset single sign on access key.
*SsoApi* | [**ssoGetsettings**](docs/SsoApi.md#ssogetsettings) | **GET** /sso/getsettings | View single sign on settings.
*SsoApi* | [**ssoIssuetoken**](docs/SsoApi.md#ssoissuetoken) | **GET** /sso/issuetoken | Issue single sign-on token
*SsoApi* | [**ssoSavesettings**](docs/SsoApi.md#ssosavesettings) | **POST** /sso/savesettings | Edit single sign-on settings.
*StaffavailApi* | [**staffavailAddmetoallservices**](docs/StaffavailApi.md#staffavailaddmetoallservices) | **GET** /staffavail/addmetoallservices | Associate current user to all services
*StaffavailApi* | [**staffavailAddmetoservice**](docs/StaffavailApi.md#staffavailaddmetoservice) | **GET** /staffavail/addmetoservice | Associate current user to a service
*StaffavailApi* | [**staffavailAddusertoallservices**](docs/StaffavailApi.md#staffavailaddusertoallservices) | **GET** /staffavail/addusertoallservices | Associate a staff member to all services
*StaffavailApi* | [**staffavailAddusertoservice**](docs/StaffavailApi.md#staffavailaddusertoservice) | **GET** /staffavail/addusertoservice | Associate a staff member to a service
*StaffavailApi* | [**staffavailGetmyservices**](docs/StaffavailApi.md#staffavailgetmyservices) | **GET** /staffavail/getmyservices | View the services the current user is available for
*StaffavailApi* | [**staffavailGetservices**](docs/StaffavailApi.md#staffavailgetservices) | **GET** /staffavail/getservices | View a list of services that a staff member is available for
*StaffavailApi* | [**staffavailGetusersforservice**](docs/StaffavailApi.md#staffavailgetusersforservice) | **GET** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
*StaffavailApi* | [**staffavailListtypes**](docs/StaffavailApi.md#staffavaillisttypes) | **GET** /staffavail/listtypes | View all the availability types
*StaffavailApi* | [**staffavailRemovemefromallservices**](docs/StaffavailApi.md#staffavailremovemefromallservices) | **GET** /staffavail/removemefromallservices | Remove current user from all services
*StaffavailApi* | [**staffavailRemovemefromservice**](docs/StaffavailApi.md#staffavailremovemefromservice) | **GET** /staffavail/removemefromservice | Remove current user from a service
*StaffavailApi* | [**staffavailRemoveuserfromallservices**](docs/StaffavailApi.md#staffavailremoveuserfromallservices) | **GET** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
*StaffavailApi* | [**staffavailRemoveuserfromservice**](docs/StaffavailApi.md#staffavailremoveuserfromservice) | **GET** /staffavail/removeuserfromservice | Remove a staff member from a service
*StaffavailApi* | [**staffavailSetavailability**](docs/StaffavailApi.md#staffavailsetavailability) | **GET** /staffavail/setavailability | Make a staff member available for a specific availability type
*StaffavailApi* | [**staffavailSetmyavailability**](docs/StaffavailApi.md#staffavailsetmyavailability) | **GET** /staffavail/setmyavailability | Change current user's availability type
*StationApi* | [**stationDelete**](docs/StationApi.md#stationdelete) | **DELETE** /station/{id} | Delete a sign-in station
*StationApi* | [**stationGet**](docs/StationApi.md#stationget) | **GET** /station/{id} | View details of a sign-in station
*StationApi* | [**stationGetcurrentterms**](docs/StationApi.md#stationgetcurrentterms) | **GET** /station/getcurrentterms | Get all the current terms
*StationApi* | [**stationGetinfo**](docs/StationApi.md#stationgetinfo) | **GET** /station/getinfo | Gets a the info to display in the sign-in station by it's ID.
*StationApi* | [**stationGetlicense**](docs/StationApi.md#stationgetlicense) | **GET** /station/getlicense | Gets the current license information
*StationApi* | [**stationGetlocationsettings**](docs/StationApi.md#stationgetlocationsettings) | **GET** /station/getlocationsettings | View the sign-in station settings of a specified location
*StationApi* | [**stationList**](docs/StationApi.md#stationlist) | **GET** /station/list | View a list of sign-in stations
*StationApi* | [**stationSave**](docs/StationApi.md#stationsave) | **POST** /station/{id} | Create or edit a sign-in station
*StationApi* | [**stationSavemine**](docs/StationApi.md#stationsavemine) | **POST** /station/savemine | Create or edit a class attendance sign-in station for myself
*StationApi* | [**stationUnlock**](docs/StationApi.md#stationunlock) | **GET** /station/unlock | Unlocks the sign-in station.
*SwipeApi* | [**swipeDelete**](docs/SwipeApi.md#swipedelete) | **DELETE** /swipe/{id} | Delete a swipe
*SwipeApi* | [**swipeGet**](docs/SwipeApi.md#swipeget) | **GET** /swipe/{id} | Search and view details of a swipe
*SwipeApi* | [**swipeList**](docs/SwipeApi.md#swipelist) | **GET** /swipe/list | View a list of swipes
*SwipeApi* | [**swipeSave**](docs/SwipeApi.md#swipesave) | **POST** /swipe/save | Create or edit a swipe, and if possible, save the related attendance log
*SwipeApi* | [**swipeSaveanonym**](docs/SwipeApi.md#swipesaveanonym) | **POST** /swipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
*TagApi* | [**tagDelete**](docs/TagApi.md#tagdelete) | **DELETE** /tag/{id} | Delete a tag
*TagApi* | [**tagGet**](docs/TagApi.md#tagget) | **GET** /tag/{id} | View details of a specified tag
*TagApi* | [**tagList**](docs/TagApi.md#taglist) | **GET** /tag/list | View a list of tags
*TagApi* | [**tagListgroups**](docs/TagApi.md#taglistgroups) | **GET** /tag/listgroups | View a list of entities that can be tagged
*TagApi* | [**tagSave**](docs/TagApi.md#tagsave) | **POST** /tag/{id} | Create or edit a tag
*TagApi* | [**tagSearch**](docs/TagApi.md#tagsearch) | **GET** /tag/search | Search for tags in the account
*TemplateApi* | [**templateAddimage**](docs/TemplateApi.md#templateaddimage) | **GET** /template/addimage | Add an image to a template
*TemplateApi* | [**templateDelete**](docs/TemplateApi.md#templatedelete) | **DELETE** /template/{id} | Delete a template
*TemplateApi* | [**templateEmail**](docs/TemplateApi.md#templateemail) | **GET** /template/email | Send generated templates by email
*TemplateApi* | [**templateGenerate**](docs/TemplateApi.md#templategenerate) | **GET** /template/generate | Generate specified templates
*TemplateApi* | [**templateGet**](docs/TemplateApi.md#templateget) | **GET** /template/{id} | View details of a template
*TemplateApi* | [**templateGetgenerated**](docs/TemplateApi.md#templategetgenerated) | **GET** /template/getgenerated | View generated templates
*TemplateApi* | [**templateList**](docs/TemplateApi.md#templatelist) | **GET** /template/list | View a list of defined templates
*TemplateApi* | [**templateListsources**](docs/TemplateApi.md#templatelistsources) | **GET** /template/listsources | View a list of templates' data sources
*TemplateApi* | [**templateSave**](docs/TemplateApi.md#templatesave) | **POST** /template/{id} | Create or edit a template
*TemplateApi* | [**templateSavelayout**](docs/TemplateApi.md#templatesavelayout) | **POST** /template/savelayout | Save the layout of a template
*TermApi* | [**termDelete**](docs/TermApi.md#termdelete) | **DELETE** /term/{id} | Delete a term
*TermApi* | [**termGet**](docs/TermApi.md#termget) | **GET** /term/{id} | Search and view details of a term
*TermApi* | [**termList**](docs/TermApi.md#termlist) | **GET** /term/list | Search and view details of all terms
*TermApi* | [**termSave**](docs/TermApi.md#termsave) | **POST** /term/{id} | Create and edit terms
*TextcreditApi* | [**textcreditRemaining**](docs/TextcreditApi.md#textcreditremaining) | **GET** /textcredit/remaining | Gets the remaining text credits for the account
*TranslationApi* | [**translationGet**](docs/TranslationApi.md#translationget) | **GET** /translation/get | Gets the translations of the specified values
*TranslationApi* | [**translationGetcachefile**](docs/TranslationApi.md#translationgetcachefile) | **GET** /translation/getcachefile | Get the file containing the translations
*TranslationApi* | [**translationList**](docs/TranslationApi.md#translationlist) | **GET** /translation/list | Lists all the available translations in the system
*TranslationApi* | [**translationSave**](docs/TranslationApi.md#translationsave) | **POST** /translation/{id} | Edit a translation
*UserApi* | [**userChangepwd**](docs/UserApi.md#userchangepwd) | **GET** /user/changepwd | Change user's own password
*UserApi* | [**userChangepwdbyreq**](docs/UserApi.md#userchangepwdbyreq) | **GET** /user/changepwdbyreq | Changes the user password using a change password request id
*UserApi* | [**userDelete**](docs/UserApi.md#userdelete) | **DELETE** /user/{id} | Delete a user
*UserApi* | [**userFindsimilar**](docs/UserApi.md#userfindsimilar) | **GET** /user/findsimilar | Finds similar users to prevent duplicates
*UserApi* | [**userGet**](docs/UserApi.md#userget) | **GET** /user/{id} | Search and view details of a user
*UserApi* | [**userGetbycard**](docs/UserApi.md#usergetbycard) | **GET** /user/getbycard | Search user by card number
*UserApi* | [**userList**](docs/UserApi.md#userlist) | **GET** /user/list | View a list of users
*UserApi* | [**userLoadphoto**](docs/UserApi.md#userloadphoto) | **GET** /user/loadphoto | Upload a photo for a specific user
*UserApi* | [**userMovedata**](docs/UserApi.md#usermovedata) | **GET** /user/movedata | Move data between users
*UserApi* | [**userRequestpwdchange**](docs/UserApi.md#userrequestpwdchange) | **GET** /user/requestpwdchange | Requests a password change
*UserApi* | [**userSave**](docs/UserApi.md#usersave) | **POST** /user/{id} | Create or edit a user
*UserApi* | [**userSavepwdchange**](docs/UserApi.md#usersavepwdchange) | **POST** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords
*UsergroupApi* | [**usergroupAddmember**](docs/UsergroupApi.md#usergroupaddmember) | **GET** /usergroup/addmember | Add a user to a group
*UsergroupApi* | [**usergroupDelete**](docs/UsergroupApi.md#usergroupdelete) | **DELETE** /usergroup/{id} | Delete a group
*UsergroupApi* | [**usergroupGet**](docs/UsergroupApi.md#usergroupget) | **GET** /usergroup/{id} | Search and view details of a user group
*UsergroupApi* | [**usergroupGetmembers**](docs/UsergroupApi.md#usergroupgetmembers) | **GET** /usergroup/getmembers | View the members of a user group
*UsergroupApi* | [**usergroupGetuser**](docs/UsergroupApi.md#usergroupgetuser) | **GET** /usergroup/getuser | View the groups which a user is registered to
*UsergroupApi* | [**usergroupList**](docs/UsergroupApi.md#usergrouplist) | **GET** /usergroup/list | View a list of user groups
*UsergroupApi* | [**usergroupRefresh**](docs/UsergroupApi.md#usergrouprefresh) | **GET** /usergroup/refresh | Refresh the dynamic group
*UsergroupApi* | [**usergroupRemovemember**](docs/UsergroupApi.md#usergroupremovemember) | **GET** /usergroup/removemember | Remove a user from a group
*UsergroupApi* | [**usergroupSave**](docs/UsergroupApi.md#usergroupsave) | **POST** /usergroup/{id} | Create or edit a group
*UsergroupApi* | [**usergroupTagmembers**](docs/UsergroupApi.md#usergrouptagmembers) | **GET** /usergroup/tagmembers | Assign tags to the members of a specified group
*UsergroupApi* | [**usergroupUntagmembers**](docs/UsergroupApi.md#usergroupuntagmembers) | **GET** /usergroup/untagmembers | Unassign tags from the members of a specified group
*UserprofileApi* | [**userprofileDelete**](docs/UserprofileApi.md#userprofiledelete) | **DELETE** /userprofile/{id} | Delete a user profile
*UserprofileApi* | [**userprofileGet**](docs/UserprofileApi.md#userprofileget) | **GET** /userprofile/{id} | View a specific user profile
*UserprofileApi* | [**userprofileGetallview**](docs/UserprofileApi.md#userprofilegetallview) | **GET** /userprofile/getallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
*UserprofileApi* | [**userprofileList**](docs/UserprofileApi.md#userprofilelist) | **GET** /userprofile/list | View the list of user profiles
*UserprofileApi* | [**userprofileListquestions**](docs/UserprofileApi.md#userprofilelistquestions) | **GET** /userprofile/listquestions | Gets the list of all the available user questions
*UserprofileApi* | [**userprofilePreparestats**](docs/UserprofileApi.md#userprofilepreparestats) | **GET** /userprofile/preparestats | Gets the statistics of a user group
*UserprofileApi* | [**userprofileSave**](docs/UserprofileApi.md#userprofilesave) | **POST** /userprofile/{id} | Create or edit user profile questions
*UserprofileApi* | [**userprofileSaveanswers**](docs/UserprofileApi.md#userprofilesaveanswers) | **POST** /userprofile/saveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
*UsersettingsApi* | [**usersettingsGet**](docs/UsersettingsApi.md#usersettingsget) | **GET** /usersettings/get | Lists available user settings
*UsersettingsApi* | [**usersettingsGetmultiple**](docs/UsersettingsApi.md#usersettingsgetmultiple) | **GET** /usersettings/getmultiple | Get multiple user settings
*UsersettingsApi* | [**usersettingsSave**](docs/UsersettingsApi.md#usersettingssave) | **POST** /usersettings/save | Saves a user setting
*UsersettingsApi* | [**usersettingsSavemultiple**](docs/UsersettingsApi.md#usersettingssavemultiple) | **POST** /usersettings/savemultiple | Save multiple user settings at once
*VirtuallineApi* | [**virtuallineAddmyself**](docs/VirtuallineApi.md#virtuallineaddmyself) | **GET** /virtualline/addmyself | Add myself to a waiting line
*VirtuallineApi* | [**virtuallineList**](docs/VirtuallineApi.md#virtuallinelist) | **GET** /virtualline/list | Lists waiting lines that have remote access enabled
*VirtuallineApi* | [**virtuallineRemovemyself**](docs/VirtuallineApi.md#virtuallineremovemyself) | **GET** /virtualline/removemyself | Remove myself from a waiting line
*WaitinglineApi* | [**waitinglineAdduser**](docs/WaitinglineApi.md#waitinglineadduser) | **GET** /waitingline/adduser | Put user in a waiting line
*WaitinglineApi* | [**waitinglineDelete**](docs/WaitinglineApi.md#waitinglinedelete) | **DELETE** /waitingline/{id} | Delete a waiting line
*WaitinglineApi* | [**waitinglineGet**](docs/WaitinglineApi.md#waitinglineget) | **GET** /waitingline/{id} | View details of a waiting line
*WaitinglineApi* | [**waitinglineIsuserin**](docs/WaitinglineApi.md#waitinglineisuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
*WaitinglineApi* | [**waitinglineList**](docs/WaitinglineApi.md#waitinglinelist) | **GET** /waitingline/list | View a list of waiting lines
*WaitinglineApi* | [**waitinglineRemoveuser**](docs/WaitinglineApi.md#waitinglineremoveuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
*WaitinglineApi* | [**waitinglineSave**](docs/WaitinglineApi.md#waitinglinesave) | **POST** /waitingline/{id} | Create or edit a waiting line
*WaitinglineApi* | [**waitinglineSigninuser**](docs/WaitinglineApi.md#waitinglinesigninuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line


<a name="documentation-for-models"></a>
## Documentation for Models

 - [org.openapitools.client.models.ActionResult](docs/ActionResult.md)
 - [org.openapitools.client.models.ErrorActionResult](docs/ErrorActionResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearerAuth"></a>
### bearerAuth

- **Type**: HTTP basic authentication

