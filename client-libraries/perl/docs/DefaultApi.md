# WWW::OpenAPIClient::DefaultApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::DefaultApi;
```

All URIs are relative to *https://accucampus.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionassignmentdelete**](DefaultApi.md#actionassignmentdelete) | **GET** /actionassignmentdelete | Remove an action item from an action plan
[**actionassignmentget**](DefaultApi.md#actionassignmentget) | **GET** /actionassignmentget | Search and view details of an action item assigned to a user
[**actionassignmentlist**](DefaultApi.md#actionassignmentlist) | **GET** /actionassignmentlist | View a list of action items in a user&#39;s plan
[**actionassignmentlisthistory**](DefaultApi.md#actionassignmentlisthistory) | **GET** /actionassignmentlisthistory | View the history of an action item assigned to a user
[**actionassignmentlistmine**](DefaultApi.md#actionassignmentlistmine) | **GET** /actionassignmentlistmine | List public action assignments assigned to the logged user
[**actionassignmentlistpublichistory**](DefaultApi.md#actionassignmentlistpublichistory) | **GET** /actionassignmentlistpublichistory | List public action assignment history
[**actionassignmentmarkcomplete**](DefaultApi.md#actionassignmentmarkcomplete) | **GET** /actionassignmentmarkcomplete | Bulk complete action items
[**actionassignmentsave**](DefaultApi.md#actionassignmentsave) | **POST** /actionassignmentsave | Add an action item to a user&#39;s action plan
[**actionassignmentsavehistory**](DefaultApi.md#actionassignmentsavehistory) | **POST** /actionassignmentsavehistory | Update an action item assigned to a user
[**actionitemdelete**](DefaultApi.md#actionitemdelete) | **GET** /actionitemdelete | Delete an action item
[**actionitemget**](DefaultApi.md#actionitemget) | **GET** /actionitemget | Search and view details of an action item
[**actionitemlist**](DefaultApi.md#actionitemlist) | **GET** /actionitemlist | View a list of action items
[**actionitemsave**](DefaultApi.md#actionitemsave) | **POST** /actionitemsave | Create or edit an action item
[**actionloglist**](DefaultApi.md#actionloglist) | **GET** /actionloglist | View a list of users action logs
[**actionpackassign**](DefaultApi.md#actionpackassign) | **GET** /actionpackassign | Assign an action item pack to a user
[**actionpackdelete**](DefaultApi.md#actionpackdelete) | **GET** /actionpackdelete | Delete an action item pack
[**actionpackget**](DefaultApi.md#actionpackget) | **GET** /actionpackget | View details of an action item pack
[**actionpacklist**](DefaultApi.md#actionpacklist) | **GET** /actionpacklist | View a list of action item packs
[**actionpacksave**](DefaultApi.md#actionpacksave) | **POST** /actionpacksave | Create or edit an action item pack
[**actiontypedelete**](DefaultApi.md#actiontypedelete) | **GET** /actiontypedelete | Delete an action item type
[**actiontypeget**](DefaultApi.md#actiontypeget) | **GET** /actiontypeget | View details of an action item type
[**actiontypelist**](DefaultApi.md#actiontypelist) | **GET** /actiontypelist | View a list of action item types
[**actiontypesave**](DefaultApi.md#actiontypesave) | **POST** /actiontypesave | Create or edit an action item type
[**adhocquerycheckexecution**](DefaultApi.md#adhocquerycheckexecution) | **GET** /adhocquerycheckexecution | Check the status of an ad hoc query execution
[**adhocquerydelete**](DefaultApi.md#adhocquerydelete) | **GET** /adhocquerydelete | Delete an ad hoc query
[**adhocqueryexecute**](DefaultApi.md#adhocqueryexecute) | **GET** /adhocqueryexecute | Execute an ad hoc query
[**adhocqueryget**](DefaultApi.md#adhocqueryget) | **GET** /adhocqueryget | View details of an ad hoc query
[**adhocquerygetschema**](DefaultApi.md#adhocquerygetschema) | **GET** /adhocquerygetschema | View the database schema for making ad hoc queries
[**adhocquerylist**](DefaultApi.md#adhocquerylist) | **GET** /adhocquerylist | View a list of saved ad hoc queries
[**adhocquerylistexecutions**](DefaultApi.md#adhocquerylistexecutions) | **GET** /adhocquerylistexecutions | View a list of ad hoc queries executions
[**adhocquerysave**](DefaultApi.md#adhocquerysave) | **POST** /adhocquerysave | Create or edit an ad hoc query
[**adhocquerystopexecution**](DefaultApi.md#adhocquerystopexecution) | **GET** /adhocquerystopexecution | Stops the execution of an ad hoc query
[**adhocreportsreqaccess**](DefaultApi.md#adhocreportsreqaccess) | **GET** /adhocreportsreqaccess | Request access to the ad-hoc reports
[**advancedstationcheckunknownuser**](DefaultApi.md#advancedstationcheckunknownuser) | **GET** /advancedstationcheckunknownuser | Check whether the user is known by the system.
[**advancedstationcheckuserrole**](DefaultApi.md#advancedstationcheckuserrole) | **GET** /advancedstationcheckuserrole | Check whether the user is a staff member, an attendee or both.
[**advancedstationcreateuser**](DefaultApi.md#advancedstationcreateuser) | **GET** /advancedstationcreateuser | Creates a user via a sign-in station.
[**advancedstationgetevents**](DefaultApi.md#advancedstationgetevents) | **GET** /advancedstationgetevents | Gets the courses available for a specific location and a specific student.
[**advancedstationgetinfo**](DefaultApi.md#advancedstationgetinfo) | **GET** /advancedstationgetinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**advancedstationgetlocations**](DefaultApi.md#advancedstationgetlocations) | **GET** /advancedstationgetlocations | Gets the locations available in a sign-in station.
[**advancedstationgetlogstaff**](DefaultApi.md#advancedstationgetlogstaff) | **GET** /advancedstationgetlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**advancedstationgetroles**](DefaultApi.md#advancedstationgetroles) | **GET** /advancedstationgetroles | Gets the user roles of the user trying to sign-in.
[**advancedstationgetservices**](DefaultApi.md#advancedstationgetservices) | **GET** /advancedstationgetservices | Gets the services available for a specific location.
[**advancedstationgetstaff**](DefaultApi.md#advancedstationgetstaff) | **GET** /advancedstationgetstaff | Gets the staff/tutors available for a specific location, course and service.
[**advancedstationissignedin**](DefaultApi.md#advancedstationissignedin) | **GET** /advancedstationissignedin | Gets whether a user is signed-in or not.
[**advroleaddmissing**](DefaultApi.md#advroleaddmissing) | **GET** /advroleaddmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**advrolecheckperm**](DefaultApi.md#advrolecheckperm) | **GET** /advrolecheckperm | Checks the permissions are assigned for the given roles
[**advroledelete**](DefaultApi.md#advroledelete) | **GET** /advroledelete | Delete a role
[**advroledeletemapping**](DefaultApi.md#advroledeletemapping) | **GET** /advroledeletemapping | Delete a role mapping
[**advroleget**](DefaultApi.md#advroleget) | **GET** /advroleget | View details of a role
[**advrolelist**](DefaultApi.md#advrolelist) | **GET** /advrolelist | Lists the roles for the current account
[**advrolelistmaps**](DefaultApi.md#advrolelistmaps) | **GET** /advrolelistmaps | Lists the maps a roles is mapped to
[**advrolelistrolesmapped**](DefaultApi.md#advrolelistrolesmapped) | **GET** /advrolelistrolesmapped | Lists the roles mappings
[**advrolelisttemplates**](DefaultApi.md#advrolelisttemplates) | **GET** /advrolelisttemplates | View a list of role templates
[**advrolesave**](DefaultApi.md#advrolesave) | **POST** /advrolesave | Create or edit a role
[**advrolesavemapping**](DefaultApi.md#advrolesavemapping) | **POST** /advrolesavemapping | Saves a role mapping
[**advrolesuserlist**](DefaultApi.md#advrolesuserlist) | **GET** /advrolesuserlist | List users. Alias to user.list, use that one instead.
[**advroleuserupgrade**](DefaultApi.md#advroleuserupgrade) | **GET** /advroleuserupgrade | Upgrade a user to another role (requires permission to edit those roles)
[**appointmentcancel**](DefaultApi.md#appointmentcancel) | **GET** /appointmentcancel | Cancel an appointment
[**appointmentcheckisvalid**](DefaultApi.md#appointmentcheckisvalid) | **GET** /appointmentcheckisvalid | Check if an appointment is valid or not
[**appointmenteditanyway**](DefaultApi.md#appointmenteditanyway) | **GET** /appointmenteditanyway | Edit an appointment even if it breaks activated rules
[**appointmenteditpresence**](DefaultApi.md#appointmenteditpresence) | **GET** /appointmenteditpresence | Edit the no-show status of an appointment
[**appointmentfindallstaffslots**](DefaultApi.md#appointmentfindallstaffslots) | **GET** /appointmentfindallstaffslots | Finds all staff available slots filtered by service, date, etc
[**appointmentfindslots**](DefaultApi.md#appointmentfindslots) | **GET** /appointmentfindslots | Finds available slots filtered by service, date, staff, etc
[**appointmentfindstaff**](DefaultApi.md#appointmentfindstaff) | **GET** /appointmentfindstaff | Finds staff available by service, date, event, etc
[**appointmentget**](DefaultApi.md#appointmentget) | **GET** /appointmentget | Search and view details of an appointment
[**appointmentgetcurrent**](DefaultApi.md#appointmentgetcurrent) | **GET** /appointmentgetcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**appointmentgetlocations**](DefaultApi.md#appointmentgetlocations) | **GET** /appointmentgetlocations | Find locations where a service is available
[**appointmentlist**](DefaultApi.md#appointmentlist) | **GET** /appointmentlist | View a list of appointments
[**appointmentlistmine**](DefaultApi.md#appointmentlistmine) | **GET** /appointmentlistmine | View all my upcoming appointments
[**appointmentlistupcoming**](DefaultApi.md#appointmentlistupcoming) | **GET** /appointmentlistupcoming | Search and view details of all my upcoming appointments
[**appointmentrescheduleoutlook**](DefaultApi.md#appointmentrescheduleoutlook) | **GET** /appointmentrescheduleoutlook | Reschedule an appointment from MS Outlook.
[**appointmentrestore**](DefaultApi.md#appointmentrestore) | **GET** /appointmentrestore | Restore an appointment
[**appointmentrestoreanyway**](DefaultApi.md#appointmentrestoreanyway) | **GET** /appointmentrestoreanyway | Restore an appointment even if it breaks activated rules
[**appointmentsave**](DefaultApi.md#appointmentsave) | **POST** /appointmentsave | Schedule an appointment
[**appointmentsetasvalid**](DefaultApi.md#appointmentsetasvalid) | **GET** /appointmentsetasvalid | Schedule an appointment even if it breaks activated rules
[**appointmentsuggestlocations**](DefaultApi.md#appointmentsuggestlocations) | **GET** /appointmentsuggestlocations | View the locations with most appointments
[**appointmentsuggestservices**](DefaultApi.md#appointmentsuggestservices) | **GET** /appointmentsuggestservices | View the services with most appointments
[**appointmentvoid**](DefaultApi.md#appointmentvoid) | **GET** /appointmentvoid | Void an appointment
[**appsharegetphone**](DefaultApi.md#appsharegetphone) | **GET** /appsharegetphone | Gets the phone number of the current user
[**appsharesendtext**](DefaultApi.md#appsharesendtext) | **GET** /appsharesendtext | Sends an SMS with the link to the app
[**attendancelogcommentdelete**](DefaultApi.md#attendancelogcommentdelete) | **GET** /attendancelogcommentdelete | Delete a comment on an attendance log
[**attendancelogcommentget**](DefaultApi.md#attendancelogcommentget) | **GET** /attendancelogcommentget | View a comment on an attendance log
[**attendancelogcommentlist**](DefaultApi.md#attendancelogcommentlist) | **GET** /attendancelogcommentlist | View all the comments on a specific attendance log
[**attendancelogcommentsave**](DefaultApi.md#attendancelogcommentsave) | **POST** /attendancelogcommentsave | Save a comment on an attendance log
[**attendancelogdelete**](DefaultApi.md#attendancelogdelete) | **GET** /attendancelogdelete | Delete an attendance log
[**attendancelogget**](DefaultApi.md#attendancelogget) | **GET** /attendancelogget | Search and view details of an attendance log
[**attendanceloggetchangehistory**](DefaultApi.md#attendanceloggetchangehistory) | **GET** /attendanceloggetchangehistory | Search and view details of an attendance log&#39;s swipe history
[**attendanceloglist**](DefaultApi.md#attendanceloglist) | **GET** /attendanceloglist | View a list of attendance logs
[**attendanceloglistmine**](DefaultApi.md#attendanceloglistmine) | **GET** /attendanceloglistmine | Gets the attendance logs of the current user
[**attendancelogliststaff**](DefaultApi.md#attendancelogliststaff) | **GET** /attendancelogliststaff | Gets the attendance logs that the current user is involved in as staff
[**attendancelogsave**](DefaultApi.md#attendancelogsave) | **POST** /attendancelogsave | Create or edit an attendance log
[**attendancelogsignout**](DefaultApi.md#attendancelogsignout) | **GET** /attendancelogsignout | Sign out an attendance log
[**attendancelogwhosin**](DefaultApi.md#attendancelogwhosin) | **GET** /attendancelogwhosin | View who&#39;s in a location
[**attendancerestrictiondelete**](DefaultApi.md#attendancerestrictiondelete) | **GET** /attendancerestrictiondelete | Delete an attendance restriction
[**attendancerestrictionget**](DefaultApi.md#attendancerestrictionget) | **GET** /attendancerestrictionget | View details of an attendance restriction
[**attendancerestrictionlist**](DefaultApi.md#attendancerestrictionlist) | **GET** /attendancerestrictionlist | View a list of attendance restrictions
[**attendancerestrictionsave**](DefaultApi.md#attendancerestrictionsave) | **POST** /attendancerestrictionsave | Create or edit an attendance restriction
[**beacondelete**](DefaultApi.md#beacondelete) | **GET** /beacondelete | Delete a beacon profile
[**beacondisable**](DefaultApi.md#beacondisable) | **GET** /beacondisable | Disable beacon support account wide
[**beaconget**](DefaultApi.md#beaconget) | **GET** /beaconget | View details of a beacon profile
[**beacongetlocations**](DefaultApi.md#beacongetlocations) | **GET** /beacongetlocations | Get the sign-in stations assigned to specific beacons.
[**beacongetstationlocation**](DefaultApi.md#beacongetstationlocation) | **GET** /beacongetstationlocation | Get the location settings in the specified sign-in station.
[**beacongetuuid**](DefaultApi.md#beacongetuuid) | **GET** /beacongetuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**beaconlist**](DefaultApi.md#beaconlist) | **GET** /beaconlist | View a list of beacon profiles
[**beaconlistprofiles**](DefaultApi.md#beaconlistprofiles) | **GET** /beaconlistprofiles | View a list of beacon profiles with their characteristics
[**beaconresetuuid**](DefaultApi.md#beaconresetuuid) | **GET** /beaconresetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**beaconsave**](DefaultApi.md#beaconsave) | **POST** /beaconsave | Create or edit a beacon profile
[**beaconscanlocations**](DefaultApi.md#beaconscanlocations) | **GET** /beaconscanlocations | Check if there&#39;s location available to sign-in / out.
[**beaconsetuuid**](DefaultApi.md#beaconsetuuid) | **GET** /beaconsetuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**beaconsilentregions**](DefaultApi.md#beaconsilentregions) | **GET** /beaconsilentregions | View all the beacon regions defined for silent tracking
[**beaconsilentsignin**](DefaultApi.md#beaconsilentsignin) | **GET** /beaconsilentsignin | Sign-in silently from the location specified by a beacon
[**beaconsilentsignout**](DefaultApi.md#beaconsilentsignout) | **GET** /beaconsilentsignout | Sign-out silently from the location specified by a beacon
[**bgjobgetstatus**](DefaultApi.md#bgjobgetstatus) | **GET** /bgjobgetstatus | Get background job status
[**captchagetchallenge**](DefaultApi.md#captchagetchallenge) | **GET** /captchagetchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captchagetimage**](DefaultApi.md#captchagetimage) | **GET** /captchagetimage | Gets a captcha image that the user must complete to do certain requests.
[**changelog**](DefaultApi.md#changelog) | **GET** /changelog | Get the application change log
[**clientget**](DefaultApi.md#clientget) | **GET** /clientget | Get client
[**clientlist**](DefaultApi.md#clientlist) | **GET** /clientlist | Gets the clients of the specified conference
[**clientsave**](DefaultApi.md#clientsave) | **POST** /clientsave | Saves a client
[**clientsendmessage**](DefaultApi.md#clientsendmessage) | **GET** /clientsendmessage | Send a message to a client
[**communityinvite**](DefaultApi.md#communityinvite) | **GET** /communityinvite | Sends an invitation to everyone to AccuCampus Communities
[**communityjoin**](DefaultApi.md#communityjoin) | **GET** /communityjoin | Sends an invitation for myself to AccuCampus Communities
[**compasscategorydelete**](DefaultApi.md#compasscategorydelete) | **GET** /compasscategorydelete | Delete a compass category
[**compasscategoryget**](DefaultApi.md#compasscategoryget) | **GET** /compasscategoryget | View details of a compass category
[**compasscategorylist**](DefaultApi.md#compasscategorylist) | **GET** /compasscategorylist | View a list of compass categories
[**compasscategorysave**](DefaultApi.md#compasscategorysave) | **POST** /compasscategorysave | Create or edit a compass category
[**compassservicelist**](DefaultApi.md#compassservicelist) | **GET** /compassservicelist | View all the services added to the compass
[**compassservicelistlocations**](DefaultApi.md#compassservicelistlocations) | **GET** /compassservicelistlocations | View all the locations where a service added to the compass is available
[**computerlabdeletecomputer**](DefaultApi.md#computerlabdeletecomputer) | **GET** /computerlabdeletecomputer | Delete a computer
[**computerlabgetcomputer**](DefaultApi.md#computerlabgetcomputer) | **GET** /computerlabgetcomputer | Search and view details of a computer
[**computerlabgetsettings**](DefaultApi.md#computerlabgetsettings) | **GET** /computerlabgetsettings | Loads the settings for a computer lab
[**computerlabissignedin**](DefaultApi.md#computerlabissignedin) | **GET** /computerlabissignedin | Gets whether a user is signed-in or not.
[**computerlablistcomputers**](DefaultApi.md#computerlablistcomputers) | **GET** /computerlablistcomputers | View a list of computers
[**computerlablistlabs**](DefaultApi.md#computerlablistlabs) | **GET** /computerlablistlabs | View a list of the locations that use the Computer Lab add-on
[**computerlabliststations**](DefaultApi.md#computerlabliststations) | **GET** /computerlabliststations | View a list of sign-in stations available for computer labs.
[**computerlabsavecomputer**](DefaultApi.md#computerlabsavecomputer) | **POST** /computerlabsavecomputer | Create or edit a computer
[**computerlabsavesettings**](DefaultApi.md#computerlabsavesettings) | **POST** /computerlabsavesettings | Saves the settings for a computer lab
[**computerlabsaveswipe**](DefaultApi.md#computerlabsaveswipe) | **POST** /computerlabsaveswipe | Save a new swipe from a computer in a computer lab.
[**deadendrecordingdelete**](DefaultApi.md#deadendrecordingdelete) | **GET** /deadendrecordingdelete | Deletes a dead-end record group
[**deadendrecordinglist**](DefaultApi.md#deadendrecordinglist) | **GET** /deadendrecordinglist | Lists the recorded dead ends, if enabled
[**deadendrecordinglistcomments**](DefaultApi.md#deadendrecordinglistcomments) | **GET** /deadendrecordinglistcomments | Lists the comments for a specific dead end
[**deadendrecordingsave**](DefaultApi.md#deadendrecordingsave) | **POST** /deadendrecordingsave | Saves a dead-end record
[**departmentdelete**](DefaultApi.md#departmentdelete) | **GET** /departmentdelete | Delete a college department
[**departmentget**](DefaultApi.md#departmentget) | **GET** /departmentget | Search and view details of a college department
[**departmentlist**](DefaultApi.md#departmentlist) | **GET** /departmentlist | View a list of college departments
[**departmentsave**](DefaultApi.md#departmentsave) | **POST** /departmentsave | Create or edit a college department
[**doc**](DefaultApi.md#doc) | **GET** /doc | Get the documentation
[**easyloginaddbgimage**](DefaultApi.md#easyloginaddbgimage) | **GET** /easyloginaddbgimage | Adds background image for the login
[**eventchecksessions**](DefaultApi.md#eventchecksessions) | **GET** /eventchecksessions | Edit an event&#39;s sessions according to their schedule
[**eventdelete**](DefaultApi.md#eventdelete) | **GET** /eventdelete | Delete a course
[**eventget**](DefaultApi.md#eventget) | **GET** /eventget | Search and view details of a course
[**eventgetsessionsbydate**](DefaultApi.md#eventgetsessionsbydate) | **GET** /eventgetsessionsbydate | View a list of courses by date
[**eventlist**](DefaultApi.md#eventlist) | **GET** /eventlist | View a list of courses
[**eventlistregistered**](DefaultApi.md#eventlistregistered) | **GET** /eventlistregistered | View a list of courses I am registered to
[**eventregaddme**](DefaultApi.md#eventregaddme) | **GET** /eventregaddme | Register current user to a course
[**eventregaddmetoall**](DefaultApi.md#eventregaddmetoall) | **GET** /eventregaddmetoall | Register current user to all courses
[**eventregaddmetogroup**](DefaultApi.md#eventregaddmetogroup) | **GET** /eventregaddmetogroup | Register current user to a course group
[**eventregadduser**](DefaultApi.md#eventregadduser) | **GET** /eventregadduser | Register a user to a course for attendance
[**eventregaddusertoall**](DefaultApi.md#eventregaddusertoall) | **GET** /eventregaddusertoall | Register a user to assist with all courses
[**eventregaddusertogroup**](DefaultApi.md#eventregaddusertogroup) | **GET** /eventregaddusertogroup | Register a user to an course group
[**eventreggetevents**](DefaultApi.md#eventreggetevents) | **GET** /eventreggetevents | View course registration by user
[**eventreggetgroups**](DefaultApi.md#eventreggetgroups) | **GET** /eventreggetgroups | Lists the course group registrations of a user
[**eventreggetmyevents**](DefaultApi.md#eventreggetmyevents) | **GET** /eventreggetmyevents | View the event registrations of the current user
[**eventreggetmygroups**](DefaultApi.md#eventreggetmygroups) | **GET** /eventreggetmygroups | View all current user registrations to course groups
[**eventreggetusers**](DefaultApi.md#eventreggetusers) | **GET** /eventreggetusers | View course registration
[**eventreggetusersfromgroup**](DefaultApi.md#eventreggetusersfromgroup) | **GET** /eventreggetusersfromgroup | Lists the registrations for a course group
[**eventreggetuserstoall**](DefaultApi.md#eventreggetuserstoall) | **GET** /eventreggetuserstoall | View the users that are registered to all courses
[**eventregremoveme**](DefaultApi.md#eventregremoveme) | **GET** /eventregremoveme | Unregister current user from a course
[**eventregremovemefromall**](DefaultApi.md#eventregremovemefromall) | **GET** /eventregremovemefromall | Remove current user from the registration to all courses
[**eventregremovemefromgroup**](DefaultApi.md#eventregremovemefromgroup) | **GET** /eventregremovemefromgroup | Remove current user from a course group
[**eventregremoveuser**](DefaultApi.md#eventregremoveuser) | **GET** /eventregremoveuser | Remove a user from a course
[**eventregremoveuserfromall**](DefaultApi.md#eventregremoveuserfromall) | **GET** /eventregremoveuserfromall | Remove a user from the registration to all courses
[**eventregremoveuserfromgroup**](DefaultApi.md#eventregremoveuserfromgroup) | **GET** /eventregremoveuserfromgroup | Remove a user from a course group
[**eventsave**](DefaultApi.md#eventsave) | **POST** /eventsave | Create or edit a course
[**eventsearchgroup**](DefaultApi.md#eventsearchgroup) | **GET** /eventsearchgroup | Searches for the available event groups
[**export**](DefaultApi.md#export) | **GET** /export | Export AccuCampus data
[**exportlisttypes**](DefaultApi.md#exportlisttypes) | **GET** /exportlisttypes | Lists available export types
[**featurelist**](DefaultApi.md#featurelist) | **GET** /featurelist | Lists the available features.
[**holidaylist**](DefaultApi.md#holidaylist) | **GET** /holidaylist | View a list of entered holidays
[**holidaysave**](DefaultApi.md#holidaysave) | **POST** /holidaysave | Create or edit a list of holidays
[**holidaysuggest**](DefaultApi.md#holidaysuggest) | **GET** /holidaysuggest | View the holiday suggestions in the given term
[**import**](DefaultApi.md#import) | **GET** /import | Import data into AccuCampus
[**importlisttypes**](DefaultApi.md#importlisttypes) | **GET** /importlisttypes | Lists available import types
[**interactiondelete**](DefaultApi.md#interactiondelete) | **GET** /interactiondelete | Delete an interaction
[**interactionfeed**](DefaultApi.md#interactionfeed) | **GET** /interactionfeed | Get the interactions feed
[**interactionget**](DefaultApi.md#interactionget) | **GET** /interactionget | View an interaction
[**interactionlistprivatesummary**](DefaultApi.md#interactionlistprivatesummary) | **GET** /interactionlistprivatesummary | Get current user&#39;s latest private interactions
[**interactionsave**](DefaultApi.md#interactionsave) | **POST** /interactionsave | Save an interaction
[**licenseacceptagreement**](DefaultApi.md#licenseacceptagreement) | **GET** /licenseacceptagreement | Accept the license agreement
[**licensegetagreementstatus**](DefaultApi.md#licensegetagreementstatus) | **GET** /licensegetagreementstatus | Check if license agreement has been accepted
[**licensegetcurrent**](DefaultApi.md#licensegetcurrent) | **GET** /licensegetcurrent | Gets the current license information
[**licenserenew**](DefaultApi.md#licenserenew) | **GET** /licenserenew | Contact Engineerica in order to renew the AccuCampus subscription
[**likedelete**](DefaultApi.md#likedelete) | **GET** /likedelete | Delete a like
[**likelist**](DefaultApi.md#likelist) | **GET** /likelist | View all the likes associated to a target
[**likesave**](DefaultApi.md#likesave) | **POST** /likesave | Save a like
[**listtimezones**](DefaultApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**locationdelete**](DefaultApi.md#locationdelete) | **GET** /locationdelete | Delete a location
[**locationget**](DefaultApi.md#locationget) | **GET** /locationget | Search and view details of a location
[**locationlist**](DefaultApi.md#locationlist) | **GET** /locationlist | View a list of locations
[**locationsave**](DefaultApi.md#locationsave) | **POST** /locationsave | Create or edit a location
[**login**](DefaultApi.md#login) | **GET** /login | Login
[**logout**](DefaultApi.md#logout) | **GET** /logout | Logout
[**mediacheckin**](DefaultApi.md#mediacheckin) | **GET** /mediacheckin | Check in media item
[**mediacheckout**](DefaultApi.md#mediacheckout) | **GET** /mediacheckout | Check out media item
[**mediacheckoutlist**](DefaultApi.md#mediacheckoutlist) | **GET** /mediacheckoutlist | View a list of past media checkouts
[**mediadelete**](DefaultApi.md#mediadelete) | **GET** /mediadelete | Delete a media item
[**mediadeletecheckoutlog**](DefaultApi.md#mediadeletecheckoutlog) | **GET** /mediadeletecheckoutlog | Delete a media checkout log
[**mediaget**](DefaultApi.md#mediaget) | **GET** /mediaget | Search and view details of a media item
[**mediagetbycode**](DefaultApi.md#mediagetbycode) | **GET** /mediagetbycode | Search media item by unique code
[**mediagetcheckout**](DefaultApi.md#mediagetcheckout) | **GET** /mediagetcheckout | View details of a media item checkout information
[**mediagetcheckoutlog**](DefaultApi.md#mediagetcheckoutlog) | **GET** /mediagetcheckoutlog | View details of a media checkout log
[**medialist**](DefaultApi.md#medialist) | **GET** /medialist | View a list of media items
[**mediasave**](DefaultApi.md#mediasave) | **POST** /mediasave | Create or edit a media item
[**mediatypedelete**](DefaultApi.md#mediatypedelete) | **GET** /mediatypedelete | Delete a media type
[**mediatypeget**](DefaultApi.md#mediatypeget) | **GET** /mediatypeget | Search and view details of a media type
[**mediatypelist**](DefaultApi.md#mediatypelist) | **GET** /mediatypelist | View a list of media types
[**mediatypesave**](DefaultApi.md#mediatypesave) | **POST** /mediatypesave | Create or edit a media type
[**memorizedreportdelete**](DefaultApi.md#memorizedreportdelete) | **GET** /memorizedreportdelete | Delete memorized report
[**memorizedreportget**](DefaultApi.md#memorizedreportget) | **GET** /memorizedreportget | View details of a memorized report
[**memorizedreportlist**](DefaultApi.md#memorizedreportlist) | **GET** /memorizedreportlist | View a list of all his memorized reports
[**memorizedreportsave**](DefaultApi.md#memorizedreportsave) | **POST** /memorizedreportsave | Create or edit a memorized report
[**menugetitems**](DefaultApi.md#menugetitems) | **GET** /menugetitems | Gets the items on the menu
[**myaccount**](DefaultApi.md#myaccount) | **GET** /myaccount | Gets the logged in user account.
[**myianatimezone**](DefaultApi.md#myianatimezone) | **GET** /myianatimezone | Gets the current time zone&#39;s iana name
[**myprofile**](DefaultApi.md#myprofile) | **GET** /myprofile | Gets the logged in user information.
[**myrights**](DefaultApi.md#myrights) | **GET** /myrights | Gets the list of actions the user can execute.
[**mysaveprofile**](DefaultApi.md#mysaveprofile) | **POST** /mysaveprofile | Updates logged user&#39;s profile information
[**notificationdelete**](DefaultApi.md#notificationdelete) | **GET** /notificationdelete | Delete a notification
[**notificationget**](DefaultApi.md#notificationget) | **GET** /notificationget | View a notification
[**notificationgetforstation**](DefaultApi.md#notificationgetforstation) | **GET** /notificationgetforstation | Gets all public (in station) notifications for the specific user
[**notificationgetunreadcount**](DefaultApi.md#notificationgetunreadcount) | **GET** /notificationgetunreadcount | Get the number of unread notifications
[**notificationlist**](DefaultApi.md#notificationlist) | **GET** /notificationlist | View a list of all sent notifications
[**notificationlistmine**](DefaultApi.md#notificationlistmine) | **GET** /notificationlistmine | View all the notifications sent to the current user
[**notificationmarkasread**](DefaultApi.md#notificationmarkasread) | **GET** /notificationmarkasread | Mark a notification as read
[**notificationmarkasunread**](DefaultApi.md#notificationmarkasunread) | **GET** /notificationmarkasunread | Mark a notification as unread
[**notificationsend**](DefaultApi.md#notificationsend) | **GET** /notificationsend | Send notifications on screen, via email or text to users
[**notificationsendonscreen**](DefaultApi.md#notificationsendonscreen) | **GET** /notificationsendonscreen | Send on-screen notifications
[**notificationtopicdelete**](DefaultApi.md#notificationtopicdelete) | **GET** /notificationtopicdelete | Delete a notification topic
[**notificationtopicget**](DefaultApi.md#notificationtopicget) | **GET** /notificationtopicget | Search and view details of a notification topic
[**notificationtopiclist**](DefaultApi.md#notificationtopiclist) | **GET** /notificationtopiclist | List all the notification topics
[**notificationtopiclistsubscribe**](DefaultApi.md#notificationtopiclistsubscribe) | **GET** /notificationtopiclistsubscribe | List all the notification topics available to subscribe
[**notificationtopicsave**](DefaultApi.md#notificationtopicsave) | **POST** /notificationtopicsave | Create or edit a notification topic
[**pushderegister**](DefaultApi.md#pushderegister) | **GET** /pushderegister | Deregisters the current device to receive push notifications
[**pushregister**](DefaultApi.md#pushregister) | **GET** /pushregister | Registers the current device to receive push notifications
[**qrlabelsprint**](DefaultApi.md#qrlabelsprint) | **GET** /qrlabelsprint | Print and email QR labels
[**qrloginget**](DefaultApi.md#qrloginget) | **GET** /qrloginget | Gets an image of a QR token
[**qrloginlogin**](DefaultApi.md#qrloginlogin) | **GET** /qrloginlogin | Login
[**quickpaneldeletewidget**](DefaultApi.md#quickpaneldeletewidget) | **GET** /quickpaneldeletewidget | Deletes a widget from the Quick Panel
[**quickpanelfetchwidget**](DefaultApi.md#quickpanelfetchwidget) | **GET** /quickpanelfetchwidget | Fetches the information for a specific widget.
[**quickpanelgetwidget**](DefaultApi.md#quickpanelgetwidget) | **GET** /quickpanelgetwidget | View details of a widget included in the Quick Panel
[**quickpanelinit**](DefaultApi.md#quickpanelinit) | **GET** /quickpanelinit | Returns the initial information required to show the quick panels
[**quickpanellistwidgets**](DefaultApi.md#quickpanellistwidgets) | **GET** /quickpanellistwidgets | Lists all the widgets that are added in the Quick Panel
[**quickpanellistwidgettypes**](DefaultApi.md#quickpanellistwidgettypes) | **GET** /quickpanellistwidgettypes | Lists all the widget types available in the system
[**quickpanelreorderwidgets**](DefaultApi.md#quickpanelreorderwidgets) | **GET** /quickpanelreorderwidgets | Reorders the widgets and moves them to a specific column
[**quickpanelsavewidget**](DefaultApi.md#quickpanelsavewidget) | **POST** /quickpanelsavewidget | Saves a widget for the Quick Panel
[**ratingflag**](DefaultApi.md#ratingflag) | **GET** /ratingflag | Flags one rating for moderation
[**ratingflagcomment**](DefaultApi.md#ratingflagcomment) | **GET** /ratingflagcomment | Flags one comment for moderation
[**ratingget**](DefaultApi.md#ratingget) | **GET** /ratingget | Get rating for one or more entities
[**ratinggetall**](DefaultApi.md#ratinggetall) | **GET** /ratinggetall | Gets the full ratings and comments for a specific entity
[**ratinggetcomments**](DefaultApi.md#ratinggetcomments) | **GET** /ratinggetcomments | Gets all the comments for a rating
[**ratinggetpending**](DefaultApi.md#ratinggetpending) | **GET** /ratinggetpending | Gets info of pre-saved and pre-approved ratings
[**ratinggetpendingmoderation**](DefaultApi.md#ratinggetpendingmoderation) | **GET** /ratinggetpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
[**ratingmoderate**](DefaultApi.md#ratingmoderate) | **GET** /ratingmoderate | Allows the user to accept or reject a comment
[**ratingpostcomment**](DefaultApi.md#ratingpostcomment) | **GET** /ratingpostcomment | Posts a comments for in a rating
[**ratingrate**](DefaultApi.md#ratingrate) | **GET** /ratingrate | Rates one entity
[**ratingratepending**](DefaultApi.md#ratingratepending) | **GET** /ratingratepending | Rates a pre-saved and pre-approved entity
[**ratingvote**](DefaultApi.md#ratingvote) | **GET** /ratingvote | Votes up or down a rating
[**reportattanalyticsprepare**](DefaultApi.md#reportattanalyticsprepare) | **GET** /reportattanalyticsprepare | Query and load an attendance analytics report
[**reportlist**](DefaultApi.md#reportlist) | **GET** /reportlist | View a list of available reports
[**reportpermissionsbyuser**](DefaultApi.md#reportpermissionsbyuser) | **GET** /reportpermissionsbyuser | Permissions by user report
[**reportprepare**](DefaultApi.md#reportprepare) | **GET** /reportprepare | Queries and loads the specified report, in background.
[**reportquery**](DefaultApi.md#reportquery) | **GET** /reportquery | Query and load a specified report
[**reportscheduledelete**](DefaultApi.md#reportscheduledelete) | **GET** /reportscheduledelete | Delete a report schedule
[**reportscheduleget**](DefaultApi.md#reportscheduleget) | **GET** /reportscheduleget | Get a report schedule
[**reportschedulelist**](DefaultApi.md#reportschedulelist) | **GET** /reportschedulelist | View a list of the scheduled reports
[**reportschedulesave**](DefaultApi.md#reportschedulesave) | **POST** /reportschedulesave | Create or edit a report schedule
[**reporttagresults**](DefaultApi.md#reporttagresults) | **GET** /reporttagresults | Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
[**riskmodelcheckanalysis**](DefaultApi.md#riskmodelcheckanalysis) | **GET** /riskmodelcheckanalysis | Check the status of the analysis of a specified risk assessment model
[**riskmodeldelete**](DefaultApi.md#riskmodeldelete) | **GET** /riskmodeldelete | Delete a risk assessment model
[**riskmodelget**](DefaultApi.md#riskmodelget) | **GET** /riskmodelget | View details of a risk assessment model
[**riskmodelgetscore**](DefaultApi.md#riskmodelgetscore) | **GET** /riskmodelgetscore | View the risk score for a specific user
[**riskmodellist**](DefaultApi.md#riskmodellist) | **GET** /riskmodellist | View a list of risk assessment models
[**riskmodelpredict**](DefaultApi.md#riskmodelpredict) | **GET** /riskmodelpredict | Predict risk based on an assessment model
[**riskmodelprocess**](DefaultApi.md#riskmodelprocess) | **GET** /riskmodelprocess | Process a risk assessment model
[**riskmodelrefresh**](DefaultApi.md#riskmodelrefresh) | **GET** /riskmodelrefresh | Refresh the information used in a risk assessment model
[**riskmodelsave**](DefaultApi.md#riskmodelsave) | **POST** /riskmodelsave | Create or edit a risk assessment model
[**riskmodeltermprecedences**](DefaultApi.md#riskmodeltermprecedences) | **GET** /riskmodeltermprecedences | View all default term precedences
[**rolelist**](DefaultApi.md#rolelist) | **GET** /rolelist | Show a list of roles
[**ruledelete**](DefaultApi.md#ruledelete) | **GET** /ruledelete | Delete a rule
[**ruleget**](DefaultApi.md#ruleget) | **GET** /ruleget | View details of a rule
[**rulegeteventtype**](DefaultApi.md#rulegeteventtype) | **GET** /rulegeteventtype | View details of a rule event type
[**rulelist**](DefaultApi.md#rulelist) | **GET** /rulelist | View a list of user rules
[**rulelistactions**](DefaultApi.md#rulelistactions) | **GET** /rulelistactions | View a list of rule actions available
[**rulelisteventtypes**](DefaultApi.md#rulelisteventtypes) | **GET** /rulelisteventtypes | View a list of rule event types
[**rulelisthttprequests**](DefaultApi.md#rulelisthttprequests) | **GET** /rulelisthttprequests | View all the http requests sent as a result of a rule
[**rulesave**](DefaultApi.md#rulesave) | **POST** /rulesave | Create or edit a rule
[**scheduledelete**](DefaultApi.md#scheduledelete) | **GET** /scheduledelete | Delete a schedule slot
[**scheduledeletemine**](DefaultApi.md#scheduledeletemine) | **GET** /scheduledeletemine | Delete a specific block from a user&#39;s own schedule
[**scheduleenable**](DefaultApi.md#scheduleenable) | **GET** /scheduleenable | Enable or disable the schedule for a specific person
[**scheduleenablemine**](DefaultApi.md#scheduleenablemine) | **GET** /scheduleenablemine | Enable or disable current user&#39;s schedule
[**schedulefindallstaffslots**](DefaultApi.md#schedulefindallstaffslots) | **GET** /schedulefindallstaffslots | Search available schedule slots by service, event, date
[**schedulefindslots**](DefaultApi.md#schedulefindslots) | **GET** /schedulefindslots | Search available schedule slots by service, event, date and/or staff
[**schedulefindstaffavail**](DefaultApi.md#schedulefindstaffavail) | **GET** /schedulefindstaffavail | Search available staff members slots by service, event, and/or date
[**scheduleget**](DefaultApi.md#scheduleget) | **GET** /scheduleget | Search and view details of a specific schedule slot
[**schedulegetmine**](DefaultApi.md#schedulegetmine) | **GET** /schedulegetmine | View details of a specific schedule block, for current user
[**schedulegetstaff**](DefaultApi.md#schedulegetstaff) | **GET** /schedulegetstaff | View a list of schedule information of a specified person
[**schedulegetstaffmine**](DefaultApi.md#schedulegetstaffmine) | **GET** /schedulegetstaffmine | View current user&#39;s schedule information
[**scheduleintegrationdeleteitem**](DefaultApi.md#scheduleintegrationdeleteitem) | **GET** /scheduleintegrationdeleteitem | Delete a schedule item looking up by a third party ID
[**scheduleintegrationdeleteitemsbymasterid**](DefaultApi.md#scheduleintegrationdeleteitemsbymasterid) | **GET** /scheduleintegrationdeleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**scheduleintegrationgetitem**](DefaultApi.md#scheduleintegrationgetitem) | **GET** /scheduleintegrationgetitem | Get a schedule item looking up by a third party ID
[**scheduleintegrationsaveitem**](DefaultApi.md#scheduleintegrationsaveitem) | **POST** /scheduleintegrationsaveitem | Save a schedule item looking up by a third party ID
[**scheduleintegrationsetid**](DefaultApi.md#scheduleintegrationsetid) | **GET** /scheduleintegrationsetid | Set a 3rd party ID on a specific schedule item
[**schedulemyofftimes**](DefaultApi.md#schedulemyofftimes) | **GET** /schedulemyofftimes | View current user&#39;s schedule exceptions
[**schedulesave**](DefaultApi.md#schedulesave) | **POST** /schedulesave | Create or edit a schedule slot
[**schedulesavemine**](DefaultApi.md#schedulesavemine) | **POST** /schedulesavemine | Create or edit a block in current user&#39;s schedule
[**search**](DefaultApi.md#search) | **GET** /search | Search
[**searchgetentities**](DefaultApi.md#searchgetentities) | **GET** /searchgetentities | Get the information of the entities that can be searched
[**securityassesspermission**](DefaultApi.md#securityassesspermission) | **GET** /securityassesspermission | Returns the list of users for a specific permission
[**securityassessrole**](DefaultApi.md#securityassessrole) | **GET** /securityassessrole | Returns the list of permissions for a specific role
[**securityassessscope**](DefaultApi.md#securityassessscope) | **GET** /securityassessscope | Returns the list of users for a specific user
[**securityassessuser**](DefaultApi.md#securityassessuser) | **GET** /securityassessuser | Returns the list of permissions for a specific user
[**seminardelete**](DefaultApi.md#seminardelete) | **GET** /seminardelete | Delete an event
[**seminarget**](DefaultApi.md#seminarget) | **GET** /seminarget | Search and view details of a event
[**seminarlist**](DefaultApi.md#seminarlist) | **GET** /seminarlist | View a list of events
[**seminarsave**](DefaultApi.md#seminarsave) | **POST** /seminarsave | Create or edit a event
[**serviceassignmentaddservice**](DefaultApi.md#serviceassignmentaddservice) | **GET** /serviceassignmentaddservice | Enable a service in a specific location
[**serviceassignmentgetlocation**](DefaultApi.md#serviceassignmentgetlocation) | **GET** /serviceassignmentgetlocation | View a list of services enabled for a specific location
[**serviceassignmentgetservice**](DefaultApi.md#serviceassignmentgetservice) | **GET** /serviceassignmentgetservice | View a list of locations where a service is available
[**serviceassignmentremoveservice**](DefaultApi.md#serviceassignmentremoveservice) | **GET** /serviceassignmentremoveservice | Remove a service from a location
[**servicedelete**](DefaultApi.md#servicedelete) | **GET** /servicedelete | Delete a service
[**serviceget**](DefaultApi.md#serviceget) | **GET** /serviceget | Search and view details of a service
[**servicelist**](DefaultApi.md#servicelist) | **GET** /servicelist | View a list of services
[**servicesave**](DefaultApi.md#servicesave) | **POST** /servicesave | Create or edit a service
[**sessionattendancelogaddnote**](DefaultApi.md#sessionattendancelogaddnote) | **GET** /sessionattendancelogaddnote | Add a note to a class attendance log
[**sessionattendancelogget**](DefaultApi.md#sessionattendancelogget) | **GET** /sessionattendancelogget | View details of a class attendance log
[**sessionattendanceloggetuser**](DefaultApi.md#sessionattendanceloggetuser) | **GET** /sessionattendanceloggetuser | View the class session attendance information for a specific user
[**sessionattendanceloglist**](DefaultApi.md#sessionattendanceloglist) | **GET** /sessionattendanceloglist | View attendance logs of the specified session
[**sessionattendanceloglistevent**](DefaultApi.md#sessionattendanceloglistevent) | **GET** /sessionattendanceloglistevent | View the attendance information of an entire class
[**sessionattendanceloglistsummary**](DefaultApi.md#sessionattendanceloglistsummary) | **GET** /sessionattendanceloglistsummary | View the attendance summary for a class and/or a attendee
[**sessionattendancelogmylistsummary**](DefaultApi.md#sessionattendancelogmylistsummary) | **GET** /sessionattendancelogmylistsummary | View my attendance summary
[**sessionattendancelogsave**](DefaultApi.md#sessionattendancelogsave) | **POST** /sessionattendancelogsave | Create or edit a class attendance log
[**sessionattendancelogsaveswipe**](DefaultApi.md#sessionattendancelogsaveswipe) | **POST** /sessionattendancelogsaveswipe | Create or edit a class attendance log swipe
[**sessionbulkupdate**](DefaultApi.md#sessionbulkupdate) | **GET** /sessionbulkupdate | Bulk update event sessions
[**sessionget**](DefaultApi.md#sessionget) | **GET** /sessionget | View details of a session
[**sessiongetschedule**](DefaultApi.md#sessiongetschedule) | **GET** /sessiongetschedule | Gets the schedule for a location, instructor or attendees
[**sessionlist**](DefaultApi.md#sessionlist) | **GET** /sessionlist | Gets all future sessions of the current semester
[**sessionregaddcurrentuser**](DefaultApi.md#sessionregaddcurrentuser) | **GET** /sessionregaddcurrentuser | Register current user to an event session
[**sessionregadduser**](DefaultApi.md#sessionregadduser) | **GET** /sessionregadduser | Register users for events
[**sessionreggetmysessions**](DefaultApi.md#sessionreggetmysessions) | **GET** /sessionreggetmysessions | View all the sessions the logged user is registered to
[**sessionreggetsessions**](DefaultApi.md#sessionreggetsessions) | **GET** /sessionreggetsessions | Lists the registrations for a specific user
[**sessionreggetsettings**](DefaultApi.md#sessionreggetsettings) | **GET** /sessionreggetsettings | Get the settings for session registration
[**sessionreggetusers**](DefaultApi.md#sessionreggetusers) | **GET** /sessionreggetusers | Lists the registrations for a specific session
[**sessionreglistsessions**](DefaultApi.md#sessionreglistsessions) | **GET** /sessionreglistsessions | List the sessions available for a specific event
[**sessionreglistupcoming**](DefaultApi.md#sessionreglistupcoming) | **GET** /sessionreglistupcoming | View a list of upcoming event sessions
[**sessionreglistupcomingevent**](DefaultApi.md#sessionreglistupcomingevent) | **GET** /sessionreglistupcomingevent | View a list of upcoming sessions of a particular event
[**sessionregremovecurrentuser**](DefaultApi.md#sessionregremovecurrentuser) | **GET** /sessionregremovecurrentuser | Unregister current user from an event session
[**sessionregremoveuser**](DefaultApi.md#sessionregremoveuser) | **GET** /sessionregremoveuser | Removes a user from an event session
[**sessionregsavesettings**](DefaultApi.md#sessionregsavesettings) | **POST** /sessionregsavesettings | Save the settings for an event&#39;s session registration
[**sessionswipedelete**](DefaultApi.md#sessionswipedelete) | **GET** /sessionswipedelete | Delete a session swipe
[**sessionswipeget**](DefaultApi.md#sessionswipeget) | **GET** /sessionswipeget | View details of a class attendance swipe
[**sessionswipelistunresolved**](DefaultApi.md#sessionswipelistunresolved) | **GET** /sessionswipelistunresolved | View a list of unresolved swipes
[**sessionswiperesolve**](DefaultApi.md#sessionswiperesolve) | **GET** /sessionswiperesolve | Resolve a swipe and create the corresponding attendance log
[**sessionswipesave**](DefaultApi.md#sessionswipesave) | **POST** /sessionswipesave | Creates a new swipe, and if possible, creates the attendance log
[**sessionswipesaveanonym**](DefaultApi.md#sessionswipesaveanonym) | **POST** /sessionswipesaveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
[**settingaddlogo**](DefaultApi.md#settingaddlogo) | **GET** /settingaddlogo | Add a logo to the account
[**settingget**](DefaultApi.md#settingget) | **GET** /settingget | Get settings for the account or the specified scope
[**settingsave**](DefaultApi.md#settingsave) | **POST** /settingsave | Save settings for the account or the specified scope
[**settingviewgeneral**](DefaultApi.md#settingviewgeneral) | **GET** /settingviewgeneral | View general settings for the account
[**socialcontacts**](DefaultApi.md#socialcontacts) | **GET** /socialcontacts | Gets the list of contacts in the network
[**socialgroupaddmembers**](DefaultApi.md#socialgroupaddmembers) | **GET** /socialgroupaddmembers | Adds new members to a group (which the user must own already)
[**socialgroupdelete**](DefaultApi.md#socialgroupdelete) | **GET** /socialgroupdelete | Deletes a group
[**socialgrouplist**](DefaultApi.md#socialgrouplist) | **GET** /socialgrouplist | View all the groups the current user is in
[**socialgrouplistmembers**](DefaultApi.md#socialgrouplistmembers) | **GET** /socialgrouplistmembers | Lists the members of a group
[**socialgroupremovemembers**](DefaultApi.md#socialgroupremovemembers) | **GET** /socialgroupremovemembers | Removes members from a group (which the user must own already)
[**socialgroupremovemyself**](DefaultApi.md#socialgroupremovemyself) | **GET** /socialgroupremovemyself | Removes myself from an existent group
[**socialgroupsave**](DefaultApi.md#socialgroupsave) | **POST** /socialgroupsave | Saves a new group
[**ssogeneratekey**](DefaultApi.md#ssogeneratekey) | **GET** /ssogeneratekey | Generate/reset single sign on access key.
[**ssogetsettings**](DefaultApi.md#ssogetsettings) | **GET** /ssogetsettings | View single sign on settings.
[**ssoissuetoken**](DefaultApi.md#ssoissuetoken) | **GET** /ssoissuetoken | Issue single sign-on token
[**ssosavesettings**](DefaultApi.md#ssosavesettings) | **POST** /ssosavesettings | Edit single sign-on settings.
[**staffavailaddmetoallservices**](DefaultApi.md#staffavailaddmetoallservices) | **GET** /staffavailaddmetoallservices | Associate current user to all services
[**staffavailaddmetoservice**](DefaultApi.md#staffavailaddmetoservice) | **GET** /staffavailaddmetoservice | Associate current user to a service
[**staffavailaddusertoallservices**](DefaultApi.md#staffavailaddusertoallservices) | **GET** /staffavailaddusertoallservices | Associate a staff member to all services
[**staffavailaddusertoservice**](DefaultApi.md#staffavailaddusertoservice) | **GET** /staffavailaddusertoservice | Associate a staff member to a service
[**staffavailgetmyservices**](DefaultApi.md#staffavailgetmyservices) | **GET** /staffavailgetmyservices | View the services the current user is available for
[**staffavailgetservices**](DefaultApi.md#staffavailgetservices) | **GET** /staffavailgetservices | View a list of services that a staff member is available for
[**staffavailgetusersforservice**](DefaultApi.md#staffavailgetusersforservice) | **GET** /staffavailgetusersforservice | View a list of staff members that are available for a specific service
[**staffavaillisttypes**](DefaultApi.md#staffavaillisttypes) | **GET** /staffavaillisttypes | View all the availability types
[**staffavailremovemefromallservices**](DefaultApi.md#staffavailremovemefromallservices) | **GET** /staffavailremovemefromallservices | Remove current user from all services
[**staffavailremovemefromservice**](DefaultApi.md#staffavailremovemefromservice) | **GET** /staffavailremovemefromservice | Remove current user from a service
[**staffavailremoveuserfromallservices**](DefaultApi.md#staffavailremoveuserfromallservices) | **GET** /staffavailremoveuserfromallservices | Removes a staff member from the registration to all services
[**staffavailremoveuserfromservice**](DefaultApi.md#staffavailremoveuserfromservice) | **GET** /staffavailremoveuserfromservice | Remove a staff member from a service
[**staffavailsetavailability**](DefaultApi.md#staffavailsetavailability) | **GET** /staffavailsetavailability | Make a staff member available for a specific availability type
[**staffavailsetmyavailability**](DefaultApi.md#staffavailsetmyavailability) | **GET** /staffavailsetmyavailability | Change current user&#39;s availability type
[**stationdelete**](DefaultApi.md#stationdelete) | **GET** /stationdelete | Delete a sign-in station
[**stationget**](DefaultApi.md#stationget) | **GET** /stationget | View details of a sign-in station
[**stationgetcurrentterms**](DefaultApi.md#stationgetcurrentterms) | **GET** /stationgetcurrentterms | Get all the current terms
[**stationgetinfo**](DefaultApi.md#stationgetinfo) | **GET** /stationgetinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**stationgetlicense**](DefaultApi.md#stationgetlicense) | **GET** /stationgetlicense | Gets the current license information
[**stationgetlocationsettings**](DefaultApi.md#stationgetlocationsettings) | **GET** /stationgetlocationsettings | View the sign-in station settings of a specified location
[**stationlist**](DefaultApi.md#stationlist) | **GET** /stationlist | View a list of sign-in stations
[**stationsave**](DefaultApi.md#stationsave) | **POST** /stationsave | Create or edit a sign-in station
[**stationsavemine**](DefaultApi.md#stationsavemine) | **POST** /stationsavemine | Create or edit a class attendance sign-in station for myself
[**stationunlock**](DefaultApi.md#stationunlock) | **GET** /stationunlock | Unlocks the sign-in station.
[**swipedelete**](DefaultApi.md#swipedelete) | **GET** /swipedelete | Delete a swipe
[**swipeget**](DefaultApi.md#swipeget) | **GET** /swipeget | Search and view details of a swipe
[**swipelist**](DefaultApi.md#swipelist) | **GET** /swipelist | View a list of swipes
[**swipesave**](DefaultApi.md#swipesave) | **POST** /swipesave | Create or edit a swipe, and if possible, save the related attendance log
[**swipesaveanonym**](DefaultApi.md#swipesaveanonym) | **POST** /swipesaveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
[**tagdelete**](DefaultApi.md#tagdelete) | **GET** /tagdelete | Delete a tag
[**tagget**](DefaultApi.md#tagget) | **GET** /tagget | View details of a specified tag
[**taglist**](DefaultApi.md#taglist) | **GET** /taglist | View a list of tags
[**taglistgroups**](DefaultApi.md#taglistgroups) | **GET** /taglistgroups | View a list of entities that can be tagged
[**tagsave**](DefaultApi.md#tagsave) | **POST** /tagsave | Create or edit a tag
[**tagsearch**](DefaultApi.md#tagsearch) | **GET** /tagsearch | Search for tags in the account
[**templateaddimage**](DefaultApi.md#templateaddimage) | **GET** /templateaddimage | Add an image to a template
[**templatedelete**](DefaultApi.md#templatedelete) | **GET** /templatedelete | Delete a template
[**templateemail**](DefaultApi.md#templateemail) | **GET** /templateemail | Send generated templates by email
[**templategenerate**](DefaultApi.md#templategenerate) | **GET** /templategenerate | Generate specified templates
[**templateget**](DefaultApi.md#templateget) | **GET** /templateget | View details of a template
[**templategetgenerated**](DefaultApi.md#templategetgenerated) | **GET** /templategetgenerated | View generated templates
[**templatelist**](DefaultApi.md#templatelist) | **GET** /templatelist | View a list of defined templates
[**templatelistsources**](DefaultApi.md#templatelistsources) | **GET** /templatelistsources | View a list of templates&#39; data sources
[**templatesave**](DefaultApi.md#templatesave) | **POST** /templatesave | Create or edit a template
[**templatesavelayout**](DefaultApi.md#templatesavelayout) | **POST** /templatesavelayout | Save the layout of a template
[**termdelete**](DefaultApi.md#termdelete) | **GET** /termdelete | Delete a term
[**termget**](DefaultApi.md#termget) | **GET** /termget | Search and view details of a term
[**termlist**](DefaultApi.md#termlist) | **GET** /termlist | Search and view details of all terms
[**termsave**](DefaultApi.md#termsave) | **POST** /termsave | Create and edit terms
[**textcreditremaining**](DefaultApi.md#textcreditremaining) | **GET** /textcreditremaining | Gets the remaining text credits for the account
[**texttoimage**](DefaultApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
[**translationget**](DefaultApi.md#translationget) | **GET** /translationget | Gets the translations of the specified values
[**translationgetcachefile**](DefaultApi.md#translationgetcachefile) | **GET** /translationgetcachefile | Get the file containing the translations
[**translationlist**](DefaultApi.md#translationlist) | **GET** /translationlist | Lists all the available translations in the system
[**translationsave**](DefaultApi.md#translationsave) | **POST** /translationsave | Edit a translation
[**userchangepwd**](DefaultApi.md#userchangepwd) | **GET** /userchangepwd | Change user&#39;s own password
[**userchangepwdbyreq**](DefaultApi.md#userchangepwdbyreq) | **GET** /userchangepwdbyreq | Changes the user password using a change password request id
[**userdelete**](DefaultApi.md#userdelete) | **GET** /userdelete | Delete a user
[**userfindsimilar**](DefaultApi.md#userfindsimilar) | **GET** /userfindsimilar | Finds similar users to prevent duplicates
[**userget**](DefaultApi.md#userget) | **GET** /userget | Search and view details of a user
[**usergetbycard**](DefaultApi.md#usergetbycard) | **GET** /usergetbycard | Search user by card number
[**usergroupaddmember**](DefaultApi.md#usergroupaddmember) | **GET** /usergroupaddmember | Add a user to a group
[**usergroupdelete**](DefaultApi.md#usergroupdelete) | **GET** /usergroupdelete | Delete a group
[**usergroupget**](DefaultApi.md#usergroupget) | **GET** /usergroupget | Search and view details of a user group
[**usergroupgetmembers**](DefaultApi.md#usergroupgetmembers) | **GET** /usergroupgetmembers | View the members of a user group
[**usergroupgetuser**](DefaultApi.md#usergroupgetuser) | **GET** /usergroupgetuser | View the groups which a user is registered to
[**usergrouplist**](DefaultApi.md#usergrouplist) | **GET** /usergrouplist | View a list of user groups
[**usergrouprefresh**](DefaultApi.md#usergrouprefresh) | **GET** /usergrouprefresh | Refresh the dynamic group
[**usergroupremovemember**](DefaultApi.md#usergroupremovemember) | **GET** /usergroupremovemember | Remove a user from a group
[**usergroupsave**](DefaultApi.md#usergroupsave) | **POST** /usergroupsave | Create or edit a group
[**usergrouptagmembers**](DefaultApi.md#usergrouptagmembers) | **GET** /usergrouptagmembers | Assign tags to the members of a specified group
[**usergroupuntagmembers**](DefaultApi.md#usergroupuntagmembers) | **GET** /usergroupuntagmembers | Unassign tags from the members of a specified group
[**userlist**](DefaultApi.md#userlist) | **GET** /userlist | View a list of users
[**userloadphoto**](DefaultApi.md#userloadphoto) | **GET** /userloadphoto | Upload a photo for a specific user
[**usermovedata**](DefaultApi.md#usermovedata) | **GET** /usermovedata | Move data between users
[**userprofiledelete**](DefaultApi.md#userprofiledelete) | **GET** /userprofiledelete | Delete a user profile
[**userprofileget**](DefaultApi.md#userprofileget) | **GET** /userprofileget | View a specific user profile
[**userprofilegetallview**](DefaultApi.md#userprofilegetallview) | **GET** /userprofilegetallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
[**userprofilelist**](DefaultApi.md#userprofilelist) | **GET** /userprofilelist | View the list of user profiles
[**userprofilelistquestions**](DefaultApi.md#userprofilelistquestions) | **GET** /userprofilelistquestions | Gets the list of all the available user questions
[**userprofilepreparestats**](DefaultApi.md#userprofilepreparestats) | **GET** /userprofilepreparestats | Gets the statistics of a user group
[**userprofilesave**](DefaultApi.md#userprofilesave) | **POST** /userprofilesave | Create or edit user profile questions
[**userprofilesaveanswers**](DefaultApi.md#userprofilesaveanswers) | **POST** /userprofilesaveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
[**userrequestpwdchange**](DefaultApi.md#userrequestpwdchange) | **GET** /userrequestpwdchange | Requests a password change
[**usersave**](DefaultApi.md#usersave) | **POST** /usersave | Create or edit a user
[**usersavepwdchange**](DefaultApi.md#usersavepwdchange) | **POST** /usersavepwdchange | Send email to the specified user(s) to set/change their passwords
[**usersettingsget**](DefaultApi.md#usersettingsget) | **GET** /usersettingsget | Lists available user settings
[**usersettingsgetmultiple**](DefaultApi.md#usersettingsgetmultiple) | **GET** /usersettingsgetmultiple | Get multiple user settings
[**usersettingssave**](DefaultApi.md#usersettingssave) | **POST** /usersettingssave | Saves a user setting
[**usersettingssavemultiple**](DefaultApi.md#usersettingssavemultiple) | **POST** /usersettingssavemultiple | Save multiple user settings at once
[**version**](DefaultApi.md#version) | **GET** /version | Get current version information
[**virtuallineaddmyself**](DefaultApi.md#virtuallineaddmyself) | **GET** /virtuallineaddmyself | Add myself to a waiting line
[**virtuallinelist**](DefaultApi.md#virtuallinelist) | **GET** /virtuallinelist | Lists waiting lines that have remote access enabled
[**virtuallineremovemyself**](DefaultApi.md#virtuallineremovemyself) | **GET** /virtuallineremovemyself | Remove myself from a waiting line
[**waitinglineadduser**](DefaultApi.md#waitinglineadduser) | **GET** /waitinglineadduser | Put user in a waiting line
[**waitinglinedelete**](DefaultApi.md#waitinglinedelete) | **GET** /waitinglinedelete | Delete a waiting line
[**waitinglineget**](DefaultApi.md#waitinglineget) | **GET** /waitinglineget | View details of a waiting line
[**waitinglineisuserin**](DefaultApi.md#waitinglineisuserin) | **GET** /waitinglineisuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**waitinglinelist**](DefaultApi.md#waitinglinelist) | **GET** /waitinglinelist | View a list of waiting lines
[**waitinglineremoveuser**](DefaultApi.md#waitinglineremoveuser) | **GET** /waitinglineremoveuser | Remove a user from a waiting line
[**waitinglinesave**](DefaultApi.md#waitinglinesave) | **POST** /waitinglinesave | Create or edit a waiting line
[**waitinglinesigninuser**](DefaultApi.md#waitinglinesigninuser) | **GET** /waitinglinesigninuser | Sign a user in from a waiting line


# **actionassignmentdelete**
> actionassignmentdelete(token => $token, id => $id)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the action assignment to delete.

eval { 
    $api_instance->actionassignmentdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the action assignment to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentget**
> actionassignmentget(token => $token, id => $id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the action assignment to get.

eval { 
    $api_instance->actionassignmentget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the action assignment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentlist**
> actionassignmentlist(token => $token, from => $from, count => $count, assignee => $assignee, status => $status)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $assignee = 56; # int | The assignee's id to filter the assignments.
my $status = 56; # int | The status to filter the assignments.

eval { 
    $api_instance->actionassignmentlist(token => $token, from => $from, count => $count, assignee => $assignee, status => $status);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **assignee** | **int**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **int**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentlisthistory**
> actionassignmentlisthistory(token => $token, actionassignment => $actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $actionassignment = null; # string | The action assignment's id whose history the user wants to get.

eval { 
    $api_instance->actionassignmentlisthistory(token => $token, actionassignment => $actionassignment);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentlisthistory: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **actionassignment** | [**string**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentlistmine**
> actionassignmentlistmine(token => $token, from => $from, count => $count, status => $status)

List public action assignments assigned to the logged user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $status = 56; # int | The status to filter the assignments.

eval { 
    $api_instance->actionassignmentlistmine(token => $token, from => $from, count => $count, status => $status);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentlistmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentlistpublichistory**
> actionassignmentlistpublichistory(token => $token, actionassignment => $actionassignment)

List public action assignment history

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $actionassignment = null; # string | The action assignment's id whose history the user wants to get.

eval { 
    $api_instance->actionassignmentlistpublichistory(token => $token, actionassignment => $actionassignment);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentlistpublichistory: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **actionassignment** | [**string**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentmarkcomplete**
> actionassignmentmarkcomplete(token => $token, item => $item, assignee => $assignee, group => $group, notes => $notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $item = "item_example"; # string | The action item to assign.
my $assignee = null; # string | The assignee of the item.
my $group = null; # string | The group to assing the item.
my $notes = "notes_example"; # string | The assignment's notes.

eval { 
    $api_instance->actionassignmentmarkcomplete(token => $token, item => $item, assignee => $assignee, group => $group, notes => $notes);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentmarkcomplete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **item** | **string**| The action item to assign. | 
 **assignee** | [**string**](.md)| The assignee of the item. | [optional] 
 **group** | [**string**](.md)| The group to assing the item. | [optional] 
 **notes** | **string**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentsave**
> actionassignmentsave(unknown_base_type => $unknown_base_type)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actionassignmentsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentsavehistory**
> actionassignmentsavehistory(unknown_base_type => $unknown_base_type)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actionassignmentsavehistory(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionassignmentsavehistory: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitemdelete**
> actionitemdelete(token => $token, id => $id)

Delete an action item

Allows the user to delete an action item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the action item to delete.

eval { 
    $api_instance->actionitemdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionitemdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the action item to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitemget**
> actionitemget(token => $token, id => $id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the action item to get.

eval { 
    $api_instance->actionitemget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionitemget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the action item to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitemlist**
> actionitemlist(token => $token, from => $from, count => $count)

View a list of action items

Allows the user to view a list of action items

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->actionitemlist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionitemlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitemsave**
> actionitemsave(unknown_base_type => $unknown_base_type)

Create or edit an action item

Allows the user to edit an action item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actionitemsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionitemsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionloglist**
> actionloglist(token => $token, from => $from, count => $count, user => $user, startdate => $startdate, enddate => $enddate, resource => $resource, actionfilter => $actionfilter, argument => $argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $user = null; # string | The id of the user whose action logs have to be returned.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the logs.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the logs.
my $resource = "resource_example"; # string | The resource to filter the action logs.
my $actionfilter = "actionfilter_example"; # string | The action to filter the action logs.
my $argument = "argument_example"; # string | The id of the entity that was the argument of the executed action.

eval { 
    $api_instance->actionloglist(token => $token, from => $from, count => $count, user => $user, startdate => $startdate, enddate => $enddate, resource => $resource, actionfilter => $actionfilter, argument => $argument);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionloglist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **user** | [**string**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the logs. | [optional] 
 **resource** | **string**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **string**| The action to filter the action logs. | [optional] 
 **argument** | **string**| The id of the entity that was the argument of the executed action. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpackassign**
> actionpackassign(token => $token, pack => $pack, itemsdata => $itemsdata, assignee => $assignee, group => $group, notes => $notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $pack = null; # string | The id of the action pack to assign.
my $itemsdata = null; # boolean | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
my $assignee = null; # string | The assignee of the pack.
my $group = null; # string | The group to assign the pack.
my $notes = "notes_example"; # string | The assignment's notes.

eval { 
    $api_instance->actionpackassign(token => $token, pack => $pack, itemsdata => $itemsdata, assignee => $assignee, group => $group, notes => $notes);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionpackassign: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **pack** | [**string**](.md)| The id of the action pack to assign. | 
 **itemsdata** | **boolean**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **assignee** | [**string**](.md)| The assignee of the pack. | [optional] 
 **group** | [**string**](.md)| The group to assign the pack. | [optional] 
 **notes** | **string**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpackdelete**
> actionpackdelete(token => $token, id => $id)

Delete an action item pack

Allows the user to delete an action item pack.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the action pack to delete.

eval { 
    $api_instance->actionpackdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionpackdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the action pack to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpackget**
> actionpackget(token => $token, id => $id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the action pack to get.

eval { 
    $api_instance->actionpackget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionpackget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the action pack to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpacklist**
> actionpacklist(token => $token, from => $from, count => $count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->actionpacklist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionpacklist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpacksave**
> actionpacksave(unknown_base_type => $unknown_base_type)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actionpacksave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->actionpacksave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontypedelete**
> actiontypedelete(token => $token, id => $id)

Delete an action item type

Allows the user to delete an action item type.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the action type to delete.

eval { 
    $api_instance->actiontypedelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->actiontypedelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the action type to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontypeget**
> actiontypeget(token => $token, id => $id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the action type to get.

eval { 
    $api_instance->actiontypeget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->actiontypeget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the action type to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontypelist**
> actiontypelist(token => $token, from => $from, count => $count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->actiontypelist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->actiontypelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontypesave**
> actiontypesave(unknown_base_type => $unknown_base_type)

Create or edit an action item type

Allows the user to dit an action item type.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actiontypesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->actiontypesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquerycheckexecution**
> adhocquerycheckexecution(token => $token, id => $id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the ad hoc query execution to be checked.

eval { 
    $api_instance->adhocquerycheckexecution(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocquerycheckexecution: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the ad hoc query execution to be checked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquerydelete**
> adhocquerydelete(token => $token, id => $id)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the ad hoc query to delete.

eval { 
    $api_instance->adhocquerydelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocquerydelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the ad hoc query to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocqueryexecute**
> adhocqueryexecute(token => $token, id => $id, query => $query)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the query to execute.
my $query = "query_example"; # string | The query to execute.

eval { 
    $api_instance->adhocqueryexecute(token => $token, id => $id, query => $query);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocqueryexecute: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the query to execute. | [optional] 
 **query** | **string**| The query to execute. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocqueryget**
> adhocqueryget(token => $token, id => $id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the query to get.

eval { 
    $api_instance->adhocqueryget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocqueryget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the query to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquerygetschema**
> adhocquerygetschema(token => $token)

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->adhocquerygetschema(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocquerygetschema: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquerylist**
> adhocquerylist(token => $token, from => $from, count => $count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->adhocquerylist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocquerylist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquerylistexecutions**
> adhocquerylistexecutions(token => $token, from => $from, count => $count, query => $query)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $query = null; # string | The first record to return.

eval { 
    $api_instance->adhocquerylistexecutions(token => $token, from => $from, count => $count, query => $query);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocquerylistexecutions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **query** | [**string**](.md)| The first record to return. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquerysave**
> adhocquerysave(unknown_base_type => $unknown_base_type)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->adhocquerysave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocquerysave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquerystopexecution**
> adhocquerystopexecution(token => $token, id => $id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the ad hoc query execution to be stopped.

eval { 
    $api_instance->adhocquerystopexecution(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocquerystopexecution: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the ad hoc query execution to be stopped. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocreportsreqaccess**
> adhocreportsreqaccess(token => $token)

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->adhocreportsreqaccess(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->adhocreportsreqaccess: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advancedstationcheckunknownuser**
> advancedstationcheckunknownuser(station => $station, user => $user, location => $location)

Check whether the user is known by the system.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->advancedstationcheckunknownuser(station => $station, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationcheckunknownuser: $@\n";
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

# **advancedstationcheckuserrole**
> advancedstationcheckuserrole(station => $station, user => $user, location => $location)

Check whether the user is a staff member, an attendee or both.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->advancedstationcheckuserrole(station => $station, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationcheckuserrole: $@\n";
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

# **advancedstationcreateuser**
> advancedstationcreateuser(station => $station, user => $user, location => $location, firstname => $firstname, lastname => $lastname, email => $email, middlename => $middlename)

Creates a user via a sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user to create.
my $location = null; # string | The id of the location the user picked.
my $firstname = "firstname_example"; # string | The first name of the user to create.
my $lastname = "lastname_example"; # string | The last name of the user to create.
my $email = "email_example"; # string | The email of the user to create.
my $middlename = "middlename_example"; # string | The middle name of the user to create.

eval { 
    $api_instance->advancedstationcreateuser(station => $station, user => $user, location => $location, firstname => $firstname, lastname => $lastname, email => $email, middlename => $middlename);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationcreateuser: $@\n";
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

# **advancedstationgetevents**
> advancedstationgetevents(station => $station, location => $location, user => $user)

Gets the courses available for a specific location and a specific student.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $location = null; # string | The id of the location the student picked.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->advancedstationgetevents(station => $station, location => $location, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationgetevents: $@\n";
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

# **advancedstationgetinfo**
> advancedstationgetinfo(id => $id, event => $event)

Gets the info to display in the sign-in station by it's ID.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $id = null; # string | The id of the sign-in station to get.
my $event = null; # string | The id of the event (or session), to override the scheduled one.

eval { 
    $api_instance->advancedstationgetinfo(id => $id, event => $event);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationgetinfo: $@\n";
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

# **advancedstationgetlocations**
> advancedstationgetlocations(station => $station, user => $user)

Gets the locations available in a sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station whose locations have to be returned.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->advancedstationgetlocations(station => $station, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationgetlocations: $@\n";
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

# **advancedstationgetlogstaff**
> advancedstationgetlogstaff(station => $station, attendancelog => $attendancelog, photosize => $photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $attendancelog = null; # string | The id of the attendance log to filter the staff members.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->advancedstationgetlogstaff(station => $station, attendancelog => $attendancelog, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationgetlogstaff: $@\n";
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

# **advancedstationgetroles**
> advancedstationgetroles(station => $station, signinrole => $signinrole, user => $user, location => $location)

Gets the user roles of the user trying to sign-in.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $signinrole = "signinrole_example"; # string | Specifies how the user is signing-in.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->advancedstationgetroles(station => $station, signinrole => $signinrole, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationgetroles: $@\n";
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

# **advancedstationgetservices**
> advancedstationgetservices(station => $station, location => $location, user => $user)

Gets the services available for a specific location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $location = null; # string | The id of the location the student picked.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->advancedstationgetservices(station => $station, location => $location, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationgetservices: $@\n";
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

# **advancedstationgetstaff**
> advancedstationgetstaff(station => $station, locationid => $locationid, user => $user, services => $services, eventid => $eventid, photosize => $photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $locationid = null; # string | The id of the location the student picked.
my $user = "user_example"; # string | The card of the user.
my $services = "services_example"; # string | The list of services selected by the user, in JSON format.
my $eventid = null; # string | The ID of the event selected.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->advancedstationgetstaff(station => $station, locationid => $locationid, user => $user, services => $services, eventid => $eventid, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationgetstaff: $@\n";
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

# **advancedstationissignedin**
> advancedstationissignedin(station => $station, time => $time, user => $user, location => $location)

Gets whether a user is signed-in or not.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $time = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time of the swipe.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->advancedstationissignedin(station => $station, time => $time, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->advancedstationissignedin: $@\n";
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

# **advroleaddmissing**
> advroleaddmissing(token => $token, roles => $roles, permissions => $permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $roles = "roles_example"; # string | CSV list of the role ids to check
my $permissions = "permissions_example"; # string | CSV list of the permissions to check

eval { 
    $api_instance->advroleaddmissing(token => $token, roles => $roles, permissions => $permissions);
};
if ($@) {
    warn "Exception when calling DefaultApi->advroleaddmissing: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **roles** | **string**| CSV list of the role ids to check | 
 **permissions** | **string**| CSV list of the permissions to check | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolecheckperm**
> advrolecheckperm(token => $token, roles => $roles, permissions => $permissions)

Checks the permissions are assigned for the given roles

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $roles = "roles_example"; # string | CSV list of the role ids to check
my $permissions = "permissions_example"; # string | CSV list of the permissions to check

eval { 
    $api_instance->advrolecheckperm(token => $token, roles => $roles, permissions => $permissions);
};
if ($@) {
    warn "Exception when calling DefaultApi->advrolecheckperm: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **roles** | **string**| CSV list of the role ids to check | 
 **permissions** | **string**| CSV list of the permissions to check | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroledelete**
> advroledelete(token => $token, id => $id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the location to delete.

eval { 
    $api_instance->advroledelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->advroledelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the location to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroledeletemapping**
> advroledeletemapping(token => $token, map => $map, roleid => $roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $map = "map_example"; # string | The map name to save the role.
my $roleid = null; # string | The id of the role.

eval { 
    $api_instance->advroledeletemapping(token => $token, map => $map, roleid => $roleid);
};
if ($@) {
    warn "Exception when calling DefaultApi->advroledeletemapping: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **map** | **string**| The map name to save the role. | 
 **roleid** | [**string**](.md)| The id of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroleget**
> advroleget(token => $token, id => $id)

View details of a role

Allows the user to view a role and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the location to get.

eval { 
    $api_instance->advroleget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->advroleget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolelist**
> advrolelist(token => $token, includepolicies => $includepolicies, includeinternal => $includeinternal, name => $name)

Lists the roles for the current account

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $includepolicies = null; # boolean | True to include the policies, defaults to false.
my $includeinternal = null; # boolean | True to include the internal roles too.
my $name = "name_example"; # string | Filter by name of the role.

eval { 
    $api_instance->advrolelist(token => $token, includepolicies => $includepolicies, includeinternal => $includeinternal, name => $name);
};
if ($@) {
    warn "Exception when calling DefaultApi->advrolelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **includepolicies** | **boolean**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **boolean**| True to include the internal roles too. | [optional] 
 **name** | **string**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolelistmaps**
> advrolelistmaps(token => $token, roleid => $roleid)

Lists the maps a roles is mapped to

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $roleid = null; # string | The id of the role to list the maps.

eval { 
    $api_instance->advrolelistmaps(token => $token, roleid => $roleid);
};
if ($@) {
    warn "Exception when calling DefaultApi->advrolelistmaps: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **roleid** | [**string**](.md)| The id of the role to list the maps. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolelistrolesmapped**
> advrolelistrolesmapped(token => $token, map => $map)

Lists the roles mappings

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $map = "map_example"; # string | List only the roles in the specified map.

eval { 
    $api_instance->advrolelistrolesmapped(token => $token, map => $map);
};
if ($@) {
    warn "Exception when calling DefaultApi->advrolelistrolesmapped: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **map** | **string**| List only the roles in the specified map. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolelisttemplates**
> advrolelisttemplates(token => $token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->advrolelisttemplates(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->advrolelisttemplates: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolesave**
> advrolesave(unknown_base_type => $unknown_base_type)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->advrolesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->advrolesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolesavemapping**
> advrolesavemapping(unknown_base_type => $unknown_base_type)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->advrolesavemapping(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->advrolesavemapping: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolesuserlist**
> advrolesuserlist(token => $token, from => $from, count => $count, roleid => $roleid, onlywithoutcard => $onlywithoutcard, photosize => $photosize)

List users. Alias to user.list, use that one instead.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $roleid = null; # string | The id of the role to filter users by, or empty to return all users.
my $onlywithoutcard = "onlywithoutcard_example"; # string | If is 1 then only the users without a card are returned, otherwise all users are returned.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->advrolesuserlist(token => $token, from => $from, count => $count, roleid => $roleid, onlywithoutcard => $onlywithoutcard, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->advrolesuserlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **roleid** | [**string**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroleuserupgrade**
> advroleuserupgrade(token => $token, userid => $userid, roleid => $roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | Id of the user to upgrade
my $roleid = null; # string | Id of the role to add

eval { 
    $api_instance->advroleuserupgrade(token => $token, userid => $userid, roleid => $roleid);
};
if ($@) {
    warn "Exception when calling DefaultApi->advroleuserupgrade: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| Id of the user to upgrade | 
 **roleid** | [**string**](.md)| Id of the role to add | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentcancel**
> appointmentcancel(token => $token, id => $id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to cancel.

eval { 
    $api_instance->appointmentcancel(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentcancel: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentcheckisvalid**
> appointmentcheckisvalid(token => $token, id => $id, editing => $editing)

Check if an appointment is valid or not

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to check.
my $editing = null; # boolean | Specifies whether the check is for a new appointment or an existing one.

eval { 
    $api_instance->appointmentcheckisvalid(token => $token, id => $id, editing => $editing);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentcheckisvalid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to check. | 
 **editing** | **boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmenteditanyway**
> appointmenteditanyway(token => $token, id => $id, attendee => $attendee, staff => $staff, location => $location, start => $start, end => $end, term => $term, event => $event, services => $services, notes => $notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
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
    $api_instance->appointmenteditanyway(token => $token, id => $id, attendee => $attendee, staff => $staff, location => $location, start => $start, end => $end, term => $term, event => $event, services => $services, notes => $notes);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmenteditanyway: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmenteditpresence**
> appointmenteditpresence(token => $token, id => $id, showedup => $showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to edit its presence.
my $showedup = null; # boolean | Specifies whether the attendee was showed-up or not in the appointment.

eval { 
    $api_instance->appointmenteditpresence(token => $token, id => $id, showedup => $showedup);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmenteditpresence: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **boolean**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentfindallstaffslots**
> appointmentfindallstaffslots(token => $token, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, locationid => $locationid, eventid => $eventid, photosize => $photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $serviceids = "serviceids_example"; # string | CSV list of the service Ids to filter by.
my $locationid = null; # string | The id of the service to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->appointmentfindallstaffslots(token => $token, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, locationid => $locationid, eventid => $eventid, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentfindallstaffslots: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **locationid** | [**string**](.md)| The id of the service to filter by. | 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentfindslots**
> appointmentfindslots(token => $token, staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $staffid = null; # string | The id of the staff to filter by.
my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $serviceids = "serviceids_example"; # string | CSV list of the service Ids to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the service to filter by.

eval { 
    $api_instance->appointmentfindslots(token => $token, staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentfindslots: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **staffid** | [**string**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**string**](.md)| The id of the service to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentfindstaff**
> appointmentfindstaff(token => $token, serviceids => $serviceids, starttime => $starttime, endtime => $endtime, eventid => $eventid, locationid => $locationid, photosize => $photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceids = "serviceids_example"; # string | CSV list of the service ids to filter by.
my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the service to filter by.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->appointmentfindstaff(token => $token, serviceids => $serviceids, starttime => $starttime, endtime => $endtime, eventid => $eventid, locationid => $locationid, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentfindstaff: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceids** | **string**| CSV list of the service ids to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **eventid** | [**string**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**string**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentget**
> appointmentget(token => $token, id => $id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to get.

eval { 
    $api_instance->appointmentget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentgetcurrent**
> appointmentgetcurrent(station => $station, user => $user, location => $location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.
my $location = null; # string | The id of the location where the user wants to sign-in.

eval { 
    $api_instance->appointmentgetcurrent(station => $station, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentgetcurrent: $@\n";
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

# **appointmentgetlocations**
> appointmentgetlocations(token => $token, serviceid => $serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceid = null; # string | The id of the service to get its locations.

eval { 
    $api_instance->appointmentgetlocations(token => $token, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentgetlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**string**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentlist**
> appointmentlist(token => $token, from => $from, count => $count, startdate => $startdate, enddate => $enddate, userid => $userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the appointments.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the appointments.
my $userid = null; # string | The attendee id to filter the appointments.

eval { 
    $api_instance->appointmentlist(token => $token, from => $from, count => $count, startdate => $startdate, enddate => $enddate, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **startdate** | **DateTime**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**string**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentlistmine**
> appointmentlistmine(token => $token, start => $start, modifiedafter => $modifiedafter)

View all my upcoming appointments

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $start = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only appointments that start after the specified date will be returned.
my $modifiedafter = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only appointments modified after the specified date will be returned.

eval { 
    $api_instance->appointmentlistmine(token => $token, start => $start, modifiedafter => $modifiedafter);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentlistmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **start** | **DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentlistupcoming**
> appointmentlistupcoming(token => $token, start => $start, modifiedafter => $modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $start = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only appointments that start after the specified date will be returned.
my $modifiedafter = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only appointments modified after the specified date will be returned.

eval { 
    $api_instance->appointmentlistupcoming(token => $token, start => $start, modifiedafter => $modifiedafter);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentlistupcoming: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **start** | **DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentrescheduleoutlook**
> appointmentrescheduleoutlook(token => $token, id => $id, start => $start, end => $end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to edit.
my $start = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The appointment's start date & time.
my $end = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The appointment's end date & time.

eval { 
    $api_instance->appointmentrescheduleoutlook(token => $token, id => $id, start => $start, end => $end);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentrescheduleoutlook: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to edit. | 
 **start** | **DateTime**| The appointment&#39;s start date &amp; time. | 
 **end** | **DateTime**| The appointment&#39;s end date &amp; time. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentrestore**
> appointmentrestore(token => $token, id => $id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to restore.

eval { 
    $api_instance->appointmentrestore(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentrestore: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentrestoreanyway**
> appointmentrestoreanyway(token => $token, id => $id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to restore.

eval { 
    $api_instance->appointmentrestoreanyway(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentrestoreanyway: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentsave**
> appointmentsave(unknown_base_type => $unknown_base_type)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->appointmentsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentsetasvalid**
> appointmentsetasvalid(token => $token, id => $id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to set as valid.

eval { 
    $api_instance->appointmentsetasvalid(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentsetasvalid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to set as valid. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentsuggestlocations**
> appointmentsuggestlocations(token => $token)

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->appointmentsuggestlocations(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentsuggestlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentsuggestservices**
> appointmentsuggestservices(token => $token)

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->appointmentsuggestservices(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentsuggestservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appointmentvoid**
> appointmentvoid(token => $token, id => $id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the appointment to cancel.

eval { 
    $api_instance->appointmentvoid(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->appointmentvoid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appsharegetphone**
> appsharegetphone(token => $token)

Gets the phone number of the current user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->appsharegetphone(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->appsharegetphone: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appsharesendtext**
> appsharesendtext(token => $token, phonenumber => $phonenumber)

Sends an SMS with the link to the app

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $phonenumber = "phonenumber_example"; # string | Phone number to where to send the link. Leave empty to the number on file.

eval { 
    $api_instance->appsharesendtext(token => $token, phonenumber => $phonenumber);
};
if ($@) {
    warn "Exception when calling DefaultApi->appsharesendtext: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **phonenumber** | **string**| Phone number to where to send the link. Leave empty to the number on file. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcommentdelete**
> attendancelogcommentdelete(token => $token, id => $id)

Delete a comment on an attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the attendance log comment to delete.

eval { 
    $api_instance->attendancelogcommentdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogcommentdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the attendance log comment to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcommentget**
> attendancelogcommentget(token => $token, id => $id)

View a comment on an attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the comment to get.

eval { 
    $api_instance->attendancelogcommentget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogcommentget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the comment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcommentlist**
> attendancelogcommentlist(attendancelog => $attendancelog, token => $token)

View all the comments on a specific attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $attendancelog = null; # string | The id of the attendance log whose comments have to be retrieved.
my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->attendancelogcommentlist(attendancelog => $attendancelog, token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogcommentlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**string**](.md)| The id of the attendance log whose comments have to be retrieved. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcommentsave**
> attendancelogcommentsave(unknown_base_type => $unknown_base_type)

Save a comment on an attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->attendancelogcommentsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogcommentsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogdelete**
> attendancelogdelete(token => $token, id => $id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the attendance log to delete.

eval { 
    $api_instance->attendancelogdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the attendance log to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogget**
> attendancelogget(token => $token, id => $id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the attendance log to get.

eval { 
    $api_instance->attendancelogget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendanceloggetchangehistory**
> attendanceloggetchangehistory(token => $token, id => $id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the attendance log to get.

eval { 
    $api_instance->attendanceloggetchangehistory(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendanceloggetchangehistory: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendanceloglist**
> attendanceloglist(from => $from, count => $count, token => $token, filter => $filter, userid => $userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $token = "token_example"; # string | The authentication token.
my $filter = "filter_example"; # string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
my $userid = null; # string | The user ID of the user to get the logs.

eval { 
    $api_instance->attendanceloglist(from => $from, count => $count, token => $token, filter => $filter, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendanceloglist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**string**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendanceloglistmine**
> attendanceloglistmine(from => $from, count => $count, token => $token, filter => $filter)

Gets the attendance logs of the current user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $token = "token_example"; # string | The authentication token.
my $filter = "filter_example"; # string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.

eval { 
    $api_instance->attendanceloglistmine(from => $from, count => $count, token => $token, filter => $filter);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendanceloglistmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogliststaff**
> attendancelogliststaff(from => $from, count => $count, token => $token, filter => $filter)

Gets the attendance logs that the current user is involved in as staff

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $token = "token_example"; # string | The authentication token.
my $filter = "filter_example"; # string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.

eval { 
    $api_instance->attendancelogliststaff(from => $from, count => $count, token => $token, filter => $filter);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogliststaff: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogsave**
> attendancelogsave(unknown_base_type => $unknown_base_type)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->attendancelogsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogsignout**
> attendancelogsignout(token => $token, id => $id, location => $location, event => $event, datetime => $datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the attendance log to sign-out.
my $location = null; # string | The id of the location to filter the users to sign out.
my $event = null; # string | The id of the event to filter the users to sign out.
my $datetime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | Specifies the date and time when the specified logs have to be signed out.

eval { 
    $api_instance->attendancelogsignout(token => $token, id => $id, location => $location, event => $event, datetime => $datetime);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogsignout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**string**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **event** | [**string**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **DateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogwhosin**
> attendancelogwhosin(from => $from, count => $count, token => $token, location => $location, event => $event, sorting => $sorting, roles => $roles, photosize => $photosize, extensions => $extensions, export => $export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $token = "token_example"; # string | The authentication token.
my $location = null; # string | The id of the location to search for users that are in.
my $event = null; # string | The id of the event to search for users that are in.
my $sorting = "sorting_example"; # string | Field to sort by. Either first-name, last-name or sign-in-time.
my $roles = "roles_example"; # string | The comma-separated list of ids of the roles to search for users that are in.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
my $extensions = "extensions_example"; # string | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
my $export = null; # boolean | True to export the results as CSV

eval { 
    $api_instance->attendancelogwhosin(from => $from, count => $count, token => $token, location => $location, event => $event, sorting => $sorting, roles => $roles, photosize => $photosize, extensions => $extensions, export => $export);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancelogwhosin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **location** | [**string**](.md)| The id of the location to search for users that are in. | [optional] 
 **event** | [**string**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **string**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **string**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **string**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **boolean**| True to export the results as CSV | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancerestrictiondelete**
> attendancerestrictiondelete(token => $token, id => $id)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the restriction to delete.

eval { 
    $api_instance->attendancerestrictiondelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancerestrictiondelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the restriction to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancerestrictionget**
> attendancerestrictionget(token => $token, id => $id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the restriction to get.

eval { 
    $api_instance->attendancerestrictionget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancerestrictionget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the restriction to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancerestrictionlist**
> attendancerestrictionlist(token => $token, from => $from, count => $count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->attendancerestrictionlist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancerestrictionlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancerestrictionsave**
> attendancerestrictionsave(unknown_base_type => $unknown_base_type)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->attendancerestrictionsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->attendancerestrictionsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacondelete**
> beacondelete(token => $token, id => $id)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the beacon to delete.

eval { 
    $api_instance->beacondelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->beacondelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the beacon to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacondisable**
> beacondisable(token => $token)

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->beacondisable(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->beacondisable: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconget**
> beaconget(token => $token, id => $id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the beacon to get.

eval { 
    $api_instance->beaconget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the beacon to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacongetlocations**
> beacongetlocations(token => $token, beacons => $beacons)

Get the sign-in stations assigned to specific beacons.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $beacons = "beacons_example"; # string | A JSON array containg the beacons data (region, minor and major) values.

eval { 
    $api_instance->beacongetlocations(token => $token, beacons => $beacons);
};
if ($@) {
    warn "Exception when calling DefaultApi->beacongetlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacongetstationlocation**
> beacongetstationlocation(token => $token, station => $station, location => $location)

Get the location settings in the specified sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $station = null; # string | The id of the sign-in station whose location information has to be retrieved.
my $location = null; # string | The id of the location whose information has to be retrieved.

eval { 
    $api_instance->beacongetstationlocation(token => $token, station => $station, location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->beacongetstationlocation: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **station** | [**string**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
 **location** | [**string**](.md)| The id of the location whose information has to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beacongetuuid**
> beacongetuuid(token => $token)

View the identifier for the account's beacon region (for sign-in stations).

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->beacongetuuid(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->beacongetuuid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconlist**
> beaconlist(token => $token, from => $from, count => $count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->beaconlist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconlistprofiles**
> beaconlistprofiles(token => $token)

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->beaconlistprofiles(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconlistprofiles: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconresetuuid**
> beaconresetuuid(token => $token)

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->beaconresetuuid(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconresetuuid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconsave**
> beaconsave(unknown_base_type => $unknown_base_type)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->beaconsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconscanlocations**
> beaconscanlocations(token => $token, beacons => $beacons)

Check if there's location available to sign-in / out.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $beacons = "beacons_example"; # string | A JSON array containg the beacons data (region, minor and major) values.

eval { 
    $api_instance->beaconscanlocations(token => $token, beacons => $beacons);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconscanlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconsetuuid**
> beaconsetuuid(token => $token, id => $id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The custom region UUID.

eval { 
    $api_instance->beaconsetuuid(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconsetuuid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The custom region UUID. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconsilentregions**
> beaconsilentregions(token => $token)

View all the beacon regions defined for silent tracking

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->beaconsilentregions(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconsilentregions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconsilentsignin**
> beaconsilentsignin(token => $token, uuid => $uuid)

Sign-in silently from the location specified by a beacon

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $uuid = null; # string | The id of the region the user is in.

eval { 
    $api_instance->beaconsilentsignin(token => $token, uuid => $uuid);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconsilentsignin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **uuid** | [**string**](.md)| The id of the region the user is in. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **beaconsilentsignout**
> beaconsilentsignout(token => $token, uuid => $uuid)

Sign-out silently from the location specified by a beacon

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $uuid = null; # string | The id of the region the user has left.

eval { 
    $api_instance->beaconsilentsignout(token => $token, uuid => $uuid);
};
if ($@) {
    warn "Exception when calling DefaultApi->beaconsilentsignout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **uuid** | [**string**](.md)| The id of the region the user has left. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bgjobgetstatus**
> bgjobgetstatus(token => $token, jobid => $jobid, jobtype => $jobtype)

Get background job status

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $jobid = null; # string | The ID of the job to get the status. 10 most recent will be returned if not specified.
my $jobtype = "jobtype_example"; # string | The job type to filter by.

eval { 
    $api_instance->bgjobgetstatus(token => $token, jobid => $jobid, jobtype => $jobtype);
};
if ($@) {
    warn "Exception when calling DefaultApi->bgjobgetstatus: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **jobid** | [**string**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **string**| The job type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **captchagetchallenge**
> captchagetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);


eval { 
    $api_instance->captchagetchallenge();
};
if ($@) {
    warn "Exception when calling DefaultApi->captchagetchallenge: $@\n";
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **captchagetimage**
> captchagetimage(captchatoken => $captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $captchatoken = "captchatoken_example"; # string | The captcha token or ID returned by the captcha.getchallenge action

eval { 
    $api_instance->captchagetimage(captchatoken => $captchatoken);
};
if ($@) {
    warn "Exception when calling DefaultApi->captchagetimage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **string**| The captcha token or ID returned by the captcha.getchallenge action | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **changelog**
> changelog(token => $token)

Get the application change log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->changelog(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->changelog: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **clientget**
> clientget(token => $token, client => $client, clientname => $clientname)

Get client

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $client = "client_example"; # string | The unique id of the client.
my $clientname = "clientname_example"; # string | The custom name of the client.

eval { 
    $api_instance->clientget(token => $token, client => $client, clientname => $clientname);
};
if ($@) {
    warn "Exception when calling DefaultApi->clientget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **client** | **string**| The unique id of the client. | 
 **clientname** | **string**| The custom name of the client. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **clientlist**
> clientlist(token => $token, from => $from, count => $count)

Gets the clients of the specified conference

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->clientlist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->clientlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **clientsave**
> clientsave(unknown_base_type => $unknown_base_type)

Saves a client

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->clientsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->clientsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **clientsendmessage**
> clientsendmessage(token => $token, uniqueclientid => $uniqueclientid, message => $message)

Send a message to a client

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $uniqueclientid = null; # string | The unique id of the client.
my $message = "message_example"; # string | The body of the message to send.

eval { 
    $api_instance->clientsendmessage(token => $token, uniqueclientid => $uniqueclientid, message => $message);
};
if ($@) {
    warn "Exception when calling DefaultApi->clientsendmessage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **uniqueclientid** | [**string**](.md)| The unique id of the client. | 
 **message** | **string**| The body of the message to send. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **communityinvite**
> communityinvite(token => $token)

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->communityinvite(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->communityinvite: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **communityjoin**
> communityjoin(token => $token)

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->communityjoin(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->communityjoin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compasscategorydelete**
> compasscategorydelete(token => $token, id => $id)

Delete a compass category

Allows the user to delete an existing compass category.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the category to delete.

eval { 
    $api_instance->compasscategorydelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->compasscategorydelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the category to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compasscategoryget**
> compasscategoryget(token => $token, id => $id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the category to get.

eval { 
    $api_instance->compasscategoryget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->compasscategoryget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the category to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compasscategorylist**
> compasscategorylist(token => $token, from => $from, count => $count, onlywithservices => $onlywithservices)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $onlywithservices = null; # boolean | Specified whether only categories with services are returned or all.

eval { 
    $api_instance->compasscategorylist(token => $token, from => $from, count => $count, onlywithservices => $onlywithservices);
};
if ($@) {
    warn "Exception when calling DefaultApi->compasscategorylist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 
 **onlywithservices** | **boolean**| Specified whether only categories with services are returned or all. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compasscategorysave**
> compasscategorysave(unknown_base_type => $unknown_base_type)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->compasscategorysave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->compasscategorysave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compassservicelist**
> compassservicelist(token => $token, category => $category)

View all the services added to the compass

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $category = null; # string | The id of the category to filter the services.

eval { 
    $api_instance->compassservicelist(token => $token, category => $category);
};
if ($@) {
    warn "Exception when calling DefaultApi->compassservicelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **category** | [**string**](.md)| The id of the category to filter the services. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **compassservicelistlocations**
> compassservicelistlocations(token => $token, serviceid => $serviceid)

View all the locations where a service added to the compass is available

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceid = null; # string | The id of the service to get its locations.

eval { 
    $api_instance->compassservicelistlocations(token => $token, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling DefaultApi->compassservicelistlocations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**string**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlabdeletecomputer**
> computerlabdeletecomputer(token => $token, id => $id)

Delete a computer

Allows the user to delete an existing computer.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = "id_example"; # string | The unique device id of the computer to delete.

eval { 
    $api_instance->computerlabdeletecomputer(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlabdeletecomputer: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | **string**| The unique device id of the computer to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlabgetcomputer**
> computerlabgetcomputer(token => $token, id => $id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = "id_example"; # string | The unique device id of the computer to get.

eval { 
    $api_instance->computerlabgetcomputer(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlabgetcomputer: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | **string**| The unique device id of the computer to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlabgetsettings**
> computerlabgetsettings(id => $id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $id = null; # string | The id of the computer lab/location.

eval { 
    $api_instance->computerlabgetsettings(id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlabgetsettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the computer lab/location. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlabissignedin**
> computerlabissignedin(station => $station, user => $user)

Gets whether a user is signed-in or not.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->computerlabissignedin(station => $station, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlabissignedin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlablistcomputers**
> computerlablistcomputers(token => $token, from => $from, count => $count, location => $location, freeonly => $freeonly)

View a list of computers

Allows the user to view the list of all computers.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $location = null; # string | The id of the location whose computers have to be returned.
my $freeonly = null; # boolean | If true, only free computers will be returned.

eval { 
    $api_instance->computerlablistcomputers(token => $token, from => $from, count => $count, location => $location, freeonly => $freeonly);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlablistcomputers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **location** | [**string**](.md)| The id of the location whose computers have to be returned. | [optional] 
 **freeonly** | **boolean**| If true, only free computers will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlablistlabs**
> computerlablistlabs(token => $token)

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->computerlablistlabs(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlablistlabs: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlabliststations**
> computerlabliststations(token => $token)

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->computerlabliststations(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlabliststations: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlabsavecomputer**
> computerlabsavecomputer(unknown_base_type => $unknown_base_type)

Create or edit a computer

Allows the user to create or edit a computer.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->computerlabsavecomputer(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlabsavecomputer: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlabsavesettings**
> computerlabsavesettings(unknown_base_type => $unknown_base_type)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->computerlabsavesettings(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlabsavesettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **computerlabsaveswipe**
> computerlabsaveswipe(unknown_base_type => $unknown_base_type)

Save a new swipe from a computer in a computer lab.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->computerlabsaveswipe(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->computerlabsaveswipe: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadendrecordingdelete**
> deadendrecordingdelete(token => $token, hierarchykey => $hierarchykey)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $hierarchykey = "hierarchykey_example"; # string | The hierarchy key of the record to delete.

eval { 
    $api_instance->deadendrecordingdelete(token => $token, hierarchykey => $hierarchykey);
};
if ($@) {
    warn "Exception when calling DefaultApi->deadendrecordingdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **hierarchykey** | **string**| The hierarchy key of the record to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadendrecordinglist**
> deadendrecordinglist(token => $token)

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->deadendrecordinglist(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->deadendrecordinglist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadendrecordinglistcomments**
> deadendrecordinglistcomments(token => $token, hierarchykey => $hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $hierarchykey = "hierarchykey_example"; # string | The hierarchy key of the record to get the feedback.

eval { 
    $api_instance->deadendrecordinglistcomments(token => $token, hierarchykey => $hierarchykey);
};
if ($@) {
    warn "Exception when calling DefaultApi->deadendrecordinglistcomments: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **hierarchykey** | **string**| The hierarchy key of the record to get the feedback. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadendrecordingsave**
> deadendrecordingsave(unknown_base_type => $unknown_base_type)

Saves a dead-end record

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->deadendrecordingsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->deadendrecordingsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departmentdelete**
> departmentdelete(token => $token, id => $id)

Delete a college department

Allows the user to delete an existing college department.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the department to delete.

eval { 
    $api_instance->departmentdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->departmentdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the department to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departmentget**
> departmentget(token => $token, id => $id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the department to get.

eval { 
    $api_instance->departmentget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->departmentget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the department to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departmentlist**
> departmentlist(token => $token, from => $from, count => $count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->departmentlist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->departmentlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departmentsave**
> departmentsave(unknown_base_type => $unknown_base_type)

Create or edit a college department

Allows the user to create or edit a college department.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->departmentsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->departmentsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **doc**
> doc(excludeanonymous => $excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $excludeanonymous = null; # boolean | If true it excludes the anonymous actions from the returned list.

eval { 
    $api_instance->doc(excludeanonymous => $excludeanonymous);
};
if ($@) {
    warn "Exception when calling DefaultApi->doc: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **boolean**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **easyloginaddbgimage**
> easyloginaddbgimage(token => $token, upload => $upload, filename => $filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The original filename, needed to process the file.

eval { 
    $api_instance->easyloginaddbgimage(token => $token, upload => $upload, filename => $filename);
};
if ($@) {
    warn "Exception when calling DefaultApi->easyloginaddbgimage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The original filename, needed to process the file. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventchecksessions**
> eventchecksessions(token => $token, eventid => $eventid, autorepair => $autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The id of the event to check.
my $autorepair = null; # boolean | True to automatically fix the invalid sessions.

eval { 
    $api_instance->eventchecksessions(token => $token, eventid => $eventid, autorepair => $autorepair);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventchecksessions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The id of the event to check. | 
 **autorepair** | **boolean**| True to automatically fix the invalid sessions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventdelete**
> eventdelete(token => $token, id => $id)

Delete a course

Allows the user to delete an existing course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the event to delete.

eval { 
    $api_instance->eventdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the event to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventget**
> eventget(token => $token, id => $id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the event to get.

eval { 
    $api_instance->eventget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the event to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventgetsessionsbydate**
> eventgetsessionsbydate(token => $token, location => $location, date => $date, type => $type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $location = null; # string | The location to filter the events.
my $date = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date to filter the events. Today will be used if this parameter is omitted.
my $type = "type_example"; # string | Type of event to list.

eval { 
    $api_instance->eventgetsessionsbydate(token => $token, location => $location, date => $date, type => $type);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventgetsessionsbydate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **location** | [**string**](.md)| The location to filter the events. | [optional] 
 **date** | **DateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **string**| Type of event to list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventlist**
> eventlist(token => $token, from => $from, count => $count, summaryonly => $summaryonly, termid => $termid)

View a list of courses

Allows the user to view the full list of courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = "from_example"; # string | The first record to return.
my $count = "count_example"; # string | The max number of records to return.
my $summaryonly = null; # boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
my $termid = null; # string | Id of the term to list the events. Null to list all events.

eval { 
    $api_instance->eventlist(token => $token, from => $from, count => $count, summaryonly => $summaryonly, termid => $termid);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**string**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventlistregistered**
> eventlistregistered(token => $token, from => $from, count => $count, summaryonly => $summaryonly, termid => $termid)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = "from_example"; # string | The first record to return.
my $count = "count_example"; # string | The max number of records to return.
my $summaryonly = null; # boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
my $termid = null; # string | Id of the term to list the events. Null to list all events.

eval { 
    $api_instance->eventlistregistered(token => $token, from => $from, count => $count, summaryonly => $summaryonly, termid => $termid);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventlistregistered: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**string**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregaddme**
> eventregaddme(token => $token, eventid => $eventid, listname => $listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The id of the event.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventregaddme(token => $token, eventid => $eventid, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregaddme: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregaddmetoall**
> eventregaddmetoall(token => $token, listname => $listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventregaddmetoall(token => $token, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregaddmetoall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregaddmetogroup**
> eventregaddmetogroup(token => $token, codegroup => $codegroup, listname => $listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $codegroup = "codegroup_example"; # string | The code used to group events.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventregaddmetogroup(token => $token, codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregaddmetogroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **codegroup** | **string**| The code used to group events. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregadduser**
> eventregadduser(token => $token, userid => $userid, eventid => $eventid, listname => $listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to add.
my $eventid = null; # string | The id of the event.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventregadduser(token => $token, userid => $userid, eventid => $eventid, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregadduser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to add. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregaddusertoall**
> eventregaddusertoall(token => $token, userid => $userid, listname => $listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to add.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventregaddusertoall(token => $token, userid => $userid, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregaddusertoall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to add. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregaddusertogroup**
> eventregaddusertogroup(token => $token, userid => $userid, codegroup => $codegroup, listname => $listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to add.
my $codegroup = "codegroup_example"; # string | The code used to group events.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventregaddusertogroup(token => $token, userid => $userid, codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregaddusertogroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to add. | 
 **codegroup** | **string**| The code used to group events. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreggetevents**
> eventreggetevents(token => $token, userid => $userid, listname => $listname, termid => $termid, namefilter => $namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The user id to list events.
my $listname = "listname_example"; # string | The name of the list where the user is registered.
my $termid = null; # string | The term id to list events.
my $namefilter = "namefilter_example"; # string | The value used to filter the events by name.

eval { 
    $api_instance->eventreggetevents(token => $token, userid => $userid, listname => $listname, termid => $termid, namefilter => $namefilter);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventreggetevents: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The user id to list events. | 
 **listname** | **string**| The name of the list where the user is registered. | 
 **termid** | [**string**](.md)| The term id to list events. | [optional] 
 **namefilter** | **string**| The value used to filter the events by name. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreggetgroups**
> eventreggetgroups(token => $token, userid => $userid, listname => $listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The user id to list events.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreggetgroups(token => $token, userid => $userid, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventreggetgroups: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The user id to list events. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreggetmyevents**
> eventreggetmyevents(token => $token, listname => $listname, termid => $termid, namefilter => $namefilter)

View the event registrations of the current user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $listname = "listname_example"; # string | The name of the list where the user is registered.
my $termid = null; # string | The term id to list events.
my $namefilter = "namefilter_example"; # string | The value used to filter the events by name.

eval { 
    $api_instance->eventreggetmyevents(token => $token, listname => $listname, termid => $termid, namefilter => $namefilter);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventreggetmyevents: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **listname** | **string**| The name of the list where the user is registered. | 
 **termid** | [**string**](.md)| The term id to list events. | [optional] 
 **namefilter** | **string**| The value used to filter the events by name. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreggetmygroups**
> eventreggetmygroups(token => $token, listname => $listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreggetmygroups(token => $token, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventreggetmygroups: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreggetusers**
> eventreggetusers(token => $token, eventid => $eventid, listname => $listname, photosize => $photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The event id to list users.
my $listname = "listname_example"; # string | The name of the list to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->eventreggetusers(token => $token, eventid => $eventid, listname => $listname, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventreggetusers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The event id to list users. | 
 **listname** | **string**| The name of the list to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreggetusersfromgroup**
> eventreggetusersfromgroup(token => $token, codegroup => $codegroup, listname => $listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $codegroup = null; # string | The code group to list users.
my $listname = "listname_example"; # string | The name of the list to get.

eval { 
    $api_instance->eventreggetusersfromgroup(token => $token, codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventreggetusersfromgroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **codegroup** | [**string**](.md)| The code group to list users. | 
 **listname** | **string**| The name of the list to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreggetuserstoall**
> eventreggetuserstoall(token => $token, listname => $listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $listname = "listname_example"; # string | The name of the list to get.

eval { 
    $api_instance->eventreggetuserstoall(token => $token, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventreggetuserstoall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **listname** | **string**| The name of the list to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregremoveme**
> eventregremoveme(token => $token, eventid => $eventid, listname => $listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The id of the event.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventregremoveme(token => $token, eventid => $eventid, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregremoveme: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregremovemefromall**
> eventregremovemefromall(token => $token, listname => $listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventregremovemefromall(token => $token, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregremovemefromall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregremovemefromgroup**
> eventregremovemefromgroup(token => $token, codegroup => $codegroup, listname => $listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $codegroup = null; # string | The code group of the events/courses.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventregremovemefromgroup(token => $token, codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregremovemefromgroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **codegroup** | [**string**](.md)| The code group of the events/courses. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregremoveuser**
> eventregremoveuser(token => $token, userid => $userid, eventid => $eventid, listname => $listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to remove.
my $eventid = null; # string | The id of the event.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventregremoveuser(token => $token, userid => $userid, eventid => $eventid, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregremoveuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregremoveuserfromall**
> eventregremoveuserfromall(token => $token, userid => $userid, listname => $listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to remove.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventregremoveuserfromall(token => $token, userid => $userid, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregremoveuserfromall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventregremoveuserfromgroup**
> eventregremoveuserfromgroup(token => $token, userid => $userid, codegroup => $codegroup, listname => $listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to remove.
my $codegroup = null; # string | The code group of the events/courses.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventregremoveuserfromgroup(token => $token, userid => $userid, codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventregremoveuserfromgroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **codegroup** | [**string**](.md)| The code group of the events/courses. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventsave**
> eventsave(unknown_base_type => $unknown_base_type)

Create or edit a course

Allows the user to create or edit a course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->eventsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventsearchgroup**
> eventsearchgroup(token => $token, query => $query)

Searches for the available event groups

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $query = null; # string | Query to search event groups.

eval { 
    $api_instance->eventsearchgroup(token => $token, query => $query);
};
if ($@) {
    warn "Exception when calling DefaultApi->eventsearchgroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | [**string**](.md)| Query to search event groups. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **export**
> export(token => $token, exporttype => $exporttype, exportformat => $exportformat, filters => $filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $exporttype = "exporttype_example"; # string | What to export.
my $exportformat = "exportformat_example"; # string | The format of the resulting file. Valid types are CSV, HTML, XLS.
my $filters = "filters_example"; # string | Pipe separated filters for the export, eg: aaa=val|bbb=val|...

eval { 
    $api_instance->export(token => $token, exporttype => $exporttype, exportformat => $exportformat, filters => $filters);
};
if ($@) {
    warn "Exception when calling DefaultApi->export: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **exporttype** | **string**| What to export. | 
 **exportformat** | **string**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **filters** | **string**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **exportlisttypes**
> exportlisttypes(token => $token)

Lists available export types

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->exportlisttypes(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->exportlisttypes: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **featurelist**
> featurelist(token => $token)

Lists the available features.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->featurelist(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->featurelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **holidaylist**
> holidaylist(token => $token, term => $term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $term = null; # string | The term to get holidays from.

eval { 
    $api_instance->holidaylist(token => $token, term => $term);
};
if ($@) {
    warn "Exception when calling DefaultApi->holidaylist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **term** | [**string**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **holidaysave**
> holidaysave(unknown_base_type => $unknown_base_type)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->holidaysave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->holidaysave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **holidaysuggest**
> holidaysuggest(token => $token, term => $term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $term = null; # string | The term to get holidays from.

eval { 
    $api_instance->holidaysuggest(token => $token, term => $term);
};
if ($@) {
    warn "Exception when calling DefaultApi->holidaysuggest: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **term** | [**string**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **import**
> import(token => $token, importtype => $importtype, upload => $upload, filename => $filename, parameters => $parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $importtype = "importtype_example"; # string | The kind of data that is being uploaded.
my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The local name of the uploaded file. For later reference.
my $parameters = "parameters_example"; # string | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.

eval { 
    $api_instance->import(token => $token, importtype => $importtype, upload => $upload, filename => $filename, parameters => $parameters);
};
if ($@) {
    warn "Exception when calling DefaultApi->import: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **importtype** | **string**| The kind of data that is being uploaded. | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 
 **parameters** | **string**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **importlisttypes**
> importlisttypes(token => $token)

Lists available import types

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->importlisttypes(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->importlisttypes: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interactiondelete**
> interactiondelete(token => $token, id => $id)

Delete an interaction

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the interaction to delete.

eval { 
    $api_instance->interactiondelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->interactiondelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the interaction to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interactionfeed**
> interactionfeed(token => $token, from => $from, count => $count, startdate => $startdate, public => $public, contexttype => $contexttype, contextid => $contextid, types => $types, photosize => $photosize, showdefaultphoto => $showdefaultphoto, orderdescending => $orderdescending)

Get the interactions feed

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If set, only interactions that happened after this date are returned.
my $public = null; # boolean | Specifies whether to return public or private interactions.
my $contexttype = "contexttype_example"; # string | The type of the context of the interactions to return.
my $contextid = null; # string | The id of the context of the interactions to return.
my $types = "types_example"; # string | The  comma separated types of the interactions to return.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
my $showdefaultphoto = null; # boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
my $orderdescending = null; # boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.

eval { 
    $api_instance->interactionfeed(token => $token, from => $from, count => $count, startdate => $startdate, public => $public, contexttype => $contexttype, contextid => $contextid, types => $types, photosize => $photosize, showdefaultphoto => $showdefaultphoto, orderdescending => $orderdescending);
};
if ($@) {
    warn "Exception when calling DefaultApi->interactionfeed: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **startdate** | **DateTime**| If set, only interactions that happened after this date are returned. | [optional] 
 **public** | **boolean**| Specifies whether to return public or private interactions. | [optional] 
 **contexttype** | **string**| The type of the context of the interactions to return. | [optional] 
 **contextid** | [**string**](.md)| The id of the context of the interactions to return. | [optional] 
 **types** | **string**| The  comma separated types of the interactions to return. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 
 **orderdescending** | **boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interactionget**
> interactionget(token => $token, id => $id, thumbnailmediasize => $thumbnailmediasize, photosize => $photosize)

View an interaction

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = "id_example"; # string | The id of the interaction.
my $thumbnailmediasize = 56; # int | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->interactionget(token => $token, id => $id, thumbnailmediasize => $thumbnailmediasize, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->interactionget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | **string**| The id of the interaction. | 
 **thumbnailmediasize** | **int**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interactionlistprivatesummary**
> interactionlistprivatesummary(token => $token, photosize => $photosize, showdefaultphoto => $showdefaultphoto)

Get current user's latest private interactions

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
my $showdefaultphoto = null; # boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.

eval { 
    $api_instance->interactionlistprivatesummary(token => $token, photosize => $photosize, showdefaultphoto => $showdefaultphoto);
};
if ($@) {
    warn "Exception when calling DefaultApi->interactionlistprivatesummary: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **interactionsave**
> interactionsave(unknown_base_type => $unknown_base_type)

Save an interaction

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->interactionsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->interactionsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **licenseacceptagreement**
> licenseacceptagreement(token => $token)

Accept the license agreement

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->licenseacceptagreement(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->licenseacceptagreement: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **licensegetagreementstatus**
> licensegetagreementstatus(token => $token)

Check if license agreement has been accepted

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->licensegetagreementstatus(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->licensegetagreementstatus: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **licensegetcurrent**
> licensegetcurrent(token => $token)

Gets the current license information

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->licensegetcurrent(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->licensegetcurrent: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **licenserenew**
> licenserenew(token => $token, email => $email, phonenumber => $phonenumber, jobtitle => $jobtitle, institution => $institution, comments => $comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $email = "email_example"; # string | The e-mail of the user sending the request.
my $phonenumber = "phonenumber_example"; # string | The phone number of the user sending the request.
my $jobtitle = "jobtitle_example"; # string | The job title of the user sending the request.
my $institution = "institution_example"; # string | The institution of the user sending the request.
my $comments = "comments_example"; # string | Comments entered by the user sending the request.

eval { 
    $api_instance->licenserenew(token => $token, email => $email, phonenumber => $phonenumber, jobtitle => $jobtitle, institution => $institution, comments => $comments);
};
if ($@) {
    warn "Exception when calling DefaultApi->licenserenew: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **email** | **string**| The e-mail of the user sending the request. | 
 **phonenumber** | **string**| The phone number of the user sending the request. | 
 **jobtitle** | **string**| The job title of the user sending the request. | [optional] 
 **institution** | **string**| The institution of the user sending the request. | [optional] 
 **comments** | **string**| Comments entered by the user sending the request. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **likedelete**
> likedelete(token => $token, interactionid => $interactionid)

Delete a like

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $interactionid = null; # string | The id of the interaction to unlike.

eval { 
    $api_instance->likedelete(token => $token, interactionid => $interactionid);
};
if ($@) {
    warn "Exception when calling DefaultApi->likedelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **interactionid** | [**string**](.md)| The id of the interaction to unlike. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **likelist**
> likelist(token => $token, interactionid => $interactionid, photosize => $photosize)

View all the likes associated to a target

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $interactionid = null; # string | The id of the interaction to unlike.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->likelist(token => $token, interactionid => $interactionid, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->likelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **interactionid** | [**string**](.md)| The id of the interaction to unlike. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **likesave**
> likesave(unknown_base_type => $unknown_base_type)

Save a like

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->likesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->likesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **listtimezones**
> listtimezones()

Lists the available timezones

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);


eval { 
    $api_instance->listtimezones();
};
if ($@) {
    warn "Exception when calling DefaultApi->listtimezones: $@\n";
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **locationdelete**
> locationdelete(token => $token, id => $id)

Delete a location

Allows the user to delete an existing location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the location to delete.

eval { 
    $api_instance->locationdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->locationdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the location to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **locationget**
> locationget(token => $token, id => $id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the location to get.

eval { 
    $api_instance->locationget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->locationget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **locationlist**
> locationlist(token => $token, from => $from, count => $count, locations => $locations, sortbygroup => $sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $locations = "locations_example"; # string | The comma-separated list containing the ids of the locations to list.
my $sortbygroup = null; # boolean | True to list locations sorted by the 'Located In' property. Defaults to false.

eval { 
    $api_instance->locationlist(token => $token, from => $from, count => $count, locations => $locations, sortbygroup => $sortbygroup);
};
if ($@) {
    warn "Exception when calling DefaultApi->locationlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **locations** | **string**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **boolean**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **locationsave**
> locationsave(unknown_base_type => $unknown_base_type)

Create or edit a location

Allows the user to create or edit a location.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->locationsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->locationsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **login**
> login(domain => $domain, username => $username, password => $password, method => $method, rememberme => $rememberme)

Login

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $domain = "domain_example"; # string | The account domain to login.
my $username = "username_example"; # string | The username (email) of the user to login as.
my $password = "password_example"; # string | The password of the user to login as.
my $method = "method_example"; # string | The authentication method. Valid values are 'token' and 'cookie'.
my $rememberme = null; # boolean | If true then the session will not expire.

eval { 
    $api_instance->login(domain => $domain, username => $username, password => $password, method => $method, rememberme => $rememberme);
};
if ($@) {
    warn "Exception when calling DefaultApi->login: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The account domain to login. | 
 **username** | **string**| The username (email) of the user to login as. | 
 **password** | **string**| The password of the user to login as. | 
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **boolean**| If true then the session will not expire. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **logout**
> logout(token => $token)

Logout

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token used to login.

eval { 
    $api_instance->logout(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->logout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token used to login. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediacheckin**
> mediacheckin(token => $token, media => $media, checkindate => $checkindate, notes => $notes)

Check in media item

Allows the user to check in a media item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $media = null; # string | The id of the media item to checkin.
my $checkindate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The checkout date.
my $notes = "notes_example"; # string | The notes of the checkout.

eval { 
    $api_instance->mediacheckin(token => $token, media => $media, checkindate => $checkindate, notes => $notes);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediacheckin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **media** | [**string**](.md)| The id of the media item to checkin. | 
 **checkindate** | **DateTime**| The checkout date. | 
 **notes** | **string**| The notes of the checkout. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediacheckout**
> mediacheckout(token => $token, media => $media, user => $user, checkoutdate => $checkoutdate, duedate => $duedate, staff => $staff, event => $event, notes => $notes)

Check out media item

Allows the user to check out a media item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $media = null; # string | The id of the media item to checkout.
my $user = null; # string | The id of the user that is checking the item out.
my $checkoutdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The checkout date.
my $duedate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date when the checkout is due.
my $staff = null; # string | The id of the staff member related to the checkout.
my $event = null; # string | The id of the event related to the checkout.
my $notes = "notes_example"; # string | The notes of the checkout.

eval { 
    $api_instance->mediacheckout(token => $token, media => $media, user => $user, checkoutdate => $checkoutdate, duedate => $duedate, staff => $staff, event => $event, notes => $notes);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediacheckout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **media** | [**string**](.md)| The id of the media item to checkout. | 
 **user** | [**string**](.md)| The id of the user that is checking the item out. | 
 **checkoutdate** | **DateTime**| The checkout date. | 
 **duedate** | **DateTime**| The date when the checkout is due. | 
 **staff** | [**string**](.md)| The id of the staff member related to the checkout. | [optional] 
 **event** | [**string**](.md)| The id of the event related to the checkout. | [optional] 
 **notes** | **string**| The notes of the checkout. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediacheckoutlist**
> mediacheckoutlist(token => $token, from => $from, count => $count, media => $media, user => $user, photosize => $photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $media = null; # string | Used to filter the checkouts of a specific media item.
my $user = null; # string | Used to filter the checkouts made by a specific user.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->mediacheckoutlist(token => $token, from => $from, count => $count, media => $media, user => $user, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediacheckoutlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **media** | [**string**](.md)| Used to filter the checkouts of a specific media item. | [optional] 
 **user** | [**string**](.md)| Used to filter the checkouts made by a specific user. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediadelete**
> mediadelete(token => $token, id => $id)

Delete a media item

Allows the user to delete an existing media item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the media item to delete.

eval { 
    $api_instance->mediadelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediadelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the media item to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediadeletecheckoutlog**
> mediadeletecheckoutlog(token => $token, id => $id)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the checkout log to delete.

eval { 
    $api_instance->mediadeletecheckoutlog(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediadeletecheckoutlog: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the checkout log to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediaget**
> mediaget(token => $token, id => $id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the media item to get.

eval { 
    $api_instance->mediaget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediaget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the media item to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediagetbycode**
> mediagetbycode(token => $token, code => $code, location => $location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $code = "code_example"; # string | The code of the media item to get.
my $location = null; # string | The location where to look for the media item.

eval { 
    $api_instance->mediagetbycode(token => $token, code => $code, location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediagetbycode: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **code** | **string**| The code of the media item to get. | 
 **location** | [**string**](.md)| The location where to look for the media item. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediagetcheckout**
> mediagetcheckout(token => $token, id => $id, photosize => $photosize)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the media item whose checkout information has to be retrieved.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->mediagetcheckout(token => $token, id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediagetcheckout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediagetcheckoutlog**
> mediagetcheckoutlog(token => $token, id => $id, photosize => $photosize)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the media item whose checkout information has to be retrieved.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->mediagetcheckoutlog(token => $token, id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediagetcheckoutlog: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **medialist**
> medialist(token => $token, from => $from, count => $count, status => $status, user => $user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $status = 56; # int | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
my $user = null; # string | Used to filter the media items that are checked-out by a specific user.

eval { 
    $api_instance->medialist(token => $token, from => $from, count => $count, status => $status, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->medialist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional] 
 **user** | [**string**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediasave**
> mediasave(unknown_base_type => $unknown_base_type)

Create or edit a media item

Allows the user to create or edit a media item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->mediasave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediasave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediatypedelete**
> mediatypedelete(token => $token, id => $id)

Delete a media type

Allows the user to delete an existing media type.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the media type to delete.

eval { 
    $api_instance->mediatypedelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediatypedelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the media type to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediatypeget**
> mediatypeget(token => $token, id => $id)

Search and view details of a media type

Allows the user to view a media type and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the media type to get.

eval { 
    $api_instance->mediatypeget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediatypeget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the media type to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediatypelist**
> mediatypelist(token => $token, from => $from, count => $count)

View a list of media types

Allows the user to view the list of all media types.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->mediatypelist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediatypelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mediatypesave**
> mediatypesave(unknown_base_type => $unknown_base_type)

Create or edit a media type

Allows the user to create or edit a media type.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->mediatypesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->mediatypesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreportdelete**
> memorizedreportdelete(token => $token, id => $id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the report settings to delete.

eval { 
    $api_instance->memorizedreportdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->memorizedreportdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the report settings to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreportget**
> memorizedreportget(token => $token, id => $id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the report configuration to get.

eval { 
    $api_instance->memorizedreportget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->memorizedreportget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the report configuration to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreportlist**
> memorizedreportlist(token => $token, from => $from, count => $count, customname => $customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $customname = "customname_example"; # string | If specified filters the memorized reports by custom name.

eval { 
    $api_instance->memorizedreportlist(token => $token, from => $from, count => $count, customname => $customname);
};
if ($@) {
    warn "Exception when calling DefaultApi->memorizedreportlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **customname** | **string**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreportsave**
> memorizedreportsave(unknown_base_type => $unknown_base_type)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->memorizedreportsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->memorizedreportsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **menugetitems**
> menugetitems(menuid => $menuid)

Gets the items on the menu

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $menuid = "menuid_example"; # string | The Id of the menu to get.

eval { 
    $api_instance->menugetitems(menuid => $menuid);
};
if ($@) {
    warn "Exception when calling DefaultApi->menugetitems: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuid** | **string**| The Id of the menu to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **myaccount**
> myaccount(token => $token)

Gets the logged in user account.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->myaccount(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->myaccount: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **myianatimezone**
> myianatimezone(token => $token)

Gets the current time zone's iana name

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->myianatimezone(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->myianatimezone: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **myprofile**
> myprofile(token => $token, photosize => $photosize)

Gets the logged in user information.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->myprofile(token => $token, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->myprofile: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **myrights**
> myrights(token => $token)

Gets the list of actions the user can execute.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->myrights(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->myrights: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mysaveprofile**
> mysaveprofile(unknown_base_type => $unknown_base_type)

Updates logged user's profile information

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->mysaveprofile(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->mysaveprofile: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationdelete**
> notificationdelete(token => $token, id => $id)

Delete a notification

Allows the user to delete an existing notification.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the notification to delete.

eval { 
    $api_instance->notificationdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the notification to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationget**
> notificationget(token => $token, id => $id)

View a notification

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the notification to get.

eval { 
    $api_instance->notificationget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the notification to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationgetforstation**
> notificationgetforstation(station => $station, user => $user)

Gets all public (in station) notifications for the specific user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station to get.
my $user = "user_example"; # string | The card of the user.

eval { 
    $api_instance->notificationgetforstation(station => $station, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationgetforstation: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationgetunreadcount**
> notificationgetunreadcount(token => $token)

Get the number of unread notifications

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->notificationgetunreadcount(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationgetunreadcount: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationlist**
> notificationlist(token => $token, from => $from, count => $count, recipient => $recipient, status => $status, startdate => $startdate, enddate => $enddate, sentonscreen => $sentonscreen, sentemail => $sentemail, sentsms => $sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $recipient = null; # string | The recipient whose notifications have to be listed.
my $status = 56; # int | The status of the notifications to list. Read, Unread or All.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the notifications.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the notifications.
my $sentonscreen = null; # boolean | Specifies whether to list the notifications that were sent on-screen or not.
my $sentemail = null; # boolean | Specifies whether to list the notifications that were sent via e-mail or not.
my $sentsms = null; # boolean | Specifies whether to list the notifications that were sent via sms or not.

eval { 
    $api_instance->notificationlist(token => $token, from => $from, count => $count, recipient => $recipient, status => $status, startdate => $startdate, enddate => $enddate, sentonscreen => $sentonscreen, sentemail => $sentemail, sentsms => $sentsms);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **recipient** | [**string**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **int**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationlistmine**
> notificationlistmine(token => $token, from => $from, count => $count, status => $status, startdate => $startdate, enddate => $enddate)

View all the notifications sent to the current user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $status = 56; # int | Specifies the status of the notifications to list. Read, Unread or All.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the notifications.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the notifications.

eval { 
    $api_instance->notificationlistmine(token => $token, from => $from, count => $count, status => $status, startdate => $startdate, enddate => $enddate);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationlistmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationmarkasread**
> notificationmarkasread(token => $token, id => $id, status => $status, startdate => $startdate, enddate => $enddate)

Mark a notification as read

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
my $status = 56; # int | Specifies the status to filter the notifications. Read, Unread or All.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the notifications.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the notifications.

eval { 
    $api_instance->notificationmarkasread(token => $token, id => $id, status => $status, startdate => $startdate, enddate => $enddate);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationmarkasread: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationmarkasunread**
> notificationmarkasunread(token => $token, id => $id, status => $status, startdate => $startdate, enddate => $enddate)

Mark a notification as unread

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
my $status = 56; # int | Specifies the status to filter the notifications. Read, Unread or All.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the notifications.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the notifications.

eval { 
    $api_instance->notificationmarkasunread(token => $token, id => $id, status => $status, startdate => $startdate, enddate => $enddate);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationmarkasunread: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationsend**
> notificationsend(token => $token, emailenabled => $emailenabled, onscreenenabled => $onscreenenabled, smsenabled => $smsenabled, title => $title, tousers => $tousers, togroups => $togroups, onscreenbody => $onscreenbody, onscreenclick => $onscreenclick, onscreenurl => $onscreenurl, onscreenclass => $onscreenclass, onscreenduration => $onscreenduration, showonstation => $showonstation, emailfromname => $emailfromname, emailfrom => $emailfrom, emailsubject => $emailsubject, emailbody => $emailbody, textmessagebody => $textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $emailenabled = null; # boolean | Whether send the notification via email.
my $onscreenenabled = null; # boolean | Whether to display the notification on screen.
my $smsenabled = null; # boolean | Whether to send the notification via text message.
my $title = "title_example"; # string | Notification title.
my $tousers = "tousers_example"; # string | Comma-separated Ids of users to send the notification.
my $togroups = "togroups_example"; # string | Comma-separated Ids of user groups to send the notification.
my $onscreenbody = "onscreenbody_example"; # string | Body of the message for on-screen display.
my $onscreenclick = "onscreenclick_example"; # string | What to do when the notification is clicked. Valid values: hide, view, url.
my $onscreenurl = "onscreenurl_example"; # string | Url to redirect the user, if onscreenclick=url.
my $onscreenclass = "onscreenclass_example"; # string | How to display the notification. Valid values: info, success, warning, error
my $onscreenduration = 56; # int | Time in seconds to display the notification.
my $showonstation = 56; # int | Whether to show the notification in the sign-in station.
my $emailfromname = "emailfromname_example"; # string | Name of the email sender.
my $emailfrom = "emailfrom_example"; # string | Reply-to email.
my $emailsubject = "emailsubject_example"; # string | Subject of the email.
my $emailbody = "emailbody_example"; # string | Body of the email.
my $textmessagebody = "textmessagebody_example"; # string | Message for SMS. Max 160 characters.

eval { 
    $api_instance->notificationsend(token => $token, emailenabled => $emailenabled, onscreenenabled => $onscreenenabled, smsenabled => $smsenabled, title => $title, tousers => $tousers, togroups => $togroups, onscreenbody => $onscreenbody, onscreenclick => $onscreenclick, onscreenurl => $onscreenurl, onscreenclass => $onscreenclass, onscreenduration => $onscreenduration, showonstation => $showonstation, emailfromname => $emailfromname, emailfrom => $emailfrom, emailsubject => $emailsubject, emailbody => $emailbody, textmessagebody => $textmessagebody);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationsend: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **emailenabled** | **boolean**| Whether send the notification via email. | 
 **onscreenenabled** | **boolean**| Whether to display the notification on screen. | 
 **smsenabled** | **boolean**| Whether to send the notification via text message. | 
 **title** | **string**| Notification title. | 
 **tousers** | **string**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **string**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **string**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **string**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **string**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **string**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **int**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **int**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **string**| Name of the email sender. | [optional] 
 **emailfrom** | **string**| Reply-to email. | [optional] 
 **emailsubject** | **string**| Subject of the email. | [optional] 
 **emailbody** | **string**| Body of the email. | [optional] 
 **textmessagebody** | **string**| Message for SMS. Max 160 characters. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationsendonscreen**
> notificationsendonscreen(token => $token, notification => $notification)

Send on-screen notifications

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $notification = null; # string | The ID of the notification to send.

eval { 
    $api_instance->notificationsendonscreen(token => $token, notification => $notification);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationsendonscreen: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **notification** | [**string**](.md)| The ID of the notification to send. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopicdelete**
> notificationtopicdelete(token => $token, id => $id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the notification topic to delete.

eval { 
    $api_instance->notificationtopicdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationtopicdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the notification topic to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopicget**
> notificationtopicget(token => $token, id => $id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the notification topic to get.

eval { 
    $api_instance->notificationtopicget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationtopicget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the notification topic to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopiclist**
> notificationtopiclist(token => $token, from => $from, count => $count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->notificationtopiclist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationtopiclist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopiclistsubscribe**
> notificationtopiclistsubscribe(token => $token)

List all the notification topics available to subscribe

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->notificationtopiclistsubscribe(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationtopiclistsubscribe: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopicsave**
> notificationtopicsave(unknown_base_type => $unknown_base_type)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->notificationtopicsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->notificationtopicsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pushderegister**
> pushderegister(devicetoken => $devicetoken, platform => $platform)

Deregisters the current device to receive push notifications

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $devicetoken = "devicetoken_example"; # string | The device token where to send the notification.
my $platform = "platform_example"; # string | Either ios or android

eval { 
    $api_instance->pushderegister(devicetoken => $devicetoken, platform => $platform);
};
if ($@) {
    warn "Exception when calling DefaultApi->pushderegister: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **string**| The device token where to send the notification. | 
 **platform** | **string**| Either ios or android | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pushregister**
> pushregister(devicetoken => $devicetoken, platform => $platform)

Registers the current device to receive push notifications

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $devicetoken = "devicetoken_example"; # string | The device token where to send the notification.
my $platform = "platform_example"; # string | Either ios or android

eval { 
    $api_instance->pushregister(devicetoken => $devicetoken, platform => $platform);
};
if ($@) {
    warn "Exception when calling DefaultApi->pushregister: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **string**| The device token where to send the notification. | 
 **platform** | **string**| Either ios or android | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **qrlabelsprint**
> qrlabelsprint(token => $token, user => $user, group => $group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $user = null; # string | The id of the user whose label needs to be printed.
my $group = null; # string | The id of the group whose members' labels need to be printed.

eval { 
    $api_instance->qrlabelsprint(token => $token, user => $user, group => $group);
};
if ($@) {
    warn "Exception when calling DefaultApi->qrlabelsprint: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **user** | [**string**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**string**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **qrloginget**
> qrloginget(token => $token)

Gets an image of a QR token

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->qrloginget(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->qrloginget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **qrloginlogin**
> qrloginlogin(onetimetoken => $onetimetoken)

Login

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $onetimetoken = "onetimetoken_example"; # string | The token read from the QR code.

eval { 
    $api_instance->qrloginlogin(onetimetoken => $onetimetoken);
};
if ($@) {
    warn "Exception when calling DefaultApi->qrloginlogin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onetimetoken** | **string**| The token read from the QR code. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpaneldeletewidget**
> quickpaneldeletewidget(token => $token, id => $id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the widget.

eval { 
    $api_instance->quickpaneldeletewidget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->quickpaneldeletewidget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the widget. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelfetchwidget**
> quickpanelfetchwidget(token => $token, widgetid => $widgetid)

Fetches the information for a specific widget.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $widgetid = null; # string | The ID of the data to fetch it's data.

eval { 
    $api_instance->quickpanelfetchwidget(token => $token, widgetid => $widgetid);
};
if ($@) {
    warn "Exception when calling DefaultApi->quickpanelfetchwidget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **widgetid** | [**string**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelgetwidget**
> quickpanelgetwidget(token => $token, id => $id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the widget to get.

eval { 
    $api_instance->quickpanelgetwidget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->quickpanelgetwidget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the widget to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelinit**
> quickpanelinit(token => $token)

Returns the initial information required to show the quick panels

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->quickpanelinit(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->quickpanelinit: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanellistwidgets**
> quickpanellistwidgets(token => $token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->quickpanellistwidgets(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->quickpanellistwidgets: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanellistwidgettypes**
> quickpanellistwidgettypes(token => $token)

Lists all the widget types available in the system

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->quickpanellistwidgettypes(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->quickpanellistwidgettypes: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelreorderwidgets**
> quickpanelreorderwidgets(token => $token, sectionname => $sectionname, orderids => $orderids)

Reorders the widgets and moves them to a specific column

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $sectionname = "sectionname_example"; # string | The section name where to sort the widgets.
my $orderids = "orderids_example"; # string | CSV list of the widgets to reorder.

eval { 
    $api_instance->quickpanelreorderwidgets(token => $token, sectionname => $sectionname, orderids => $orderids);
};
if ($@) {
    warn "Exception when calling DefaultApi->quickpanelreorderwidgets: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **sectionname** | **string**| The section name where to sort the widgets. | 
 **orderids** | **string**| CSV list of the widgets to reorder. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelsavewidget**
> quickpanelsavewidget(unknown_base_type => $unknown_base_type)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->quickpanelsavewidget(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->quickpanelsavewidget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratingflag**
> ratingflag(token => $token, id => $id, comment => $comment)

Flags one rating for moderation

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The rating to flag.
my $comment = "comment_example"; # string | Comment why should this should be removed.

eval { 
    $api_instance->ratingflag(token => $token, id => $id, comment => $comment);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratingflag: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The rating to flag. | 
 **comment** | **string**| Comment why should this should be removed. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratingflagcomment**
> ratingflagcomment(token => $token, id => $id, comment => $comment)

Flags one comment for moderation

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The comment to flag.
my $comment = "comment_example"; # string | Comment why should this should be removed.

eval { 
    $api_instance->ratingflagcomment(token => $token, id => $id, comment => $comment);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratingflagcomment: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The comment to flag. | 
 **comment** | **string**| Comment why should this should be removed. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratingget**
> ratingget(token => $token, type => $type, entityids => $entityids)

Get rating for one or more entities

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $type = "type_example"; # string | The entity type to get the rating.
my $entityids = "entityids_example"; # string | List of ids to get the ratings.

eval { 
    $api_instance->ratingget(token => $token, type => $type, entityids => $entityids);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratingget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **type** | **string**| The entity type to get the rating. | 
 **entityids** | **string**| List of ids to get the ratings. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratinggetall**
> ratinggetall(token => $token, type => $type, entityid => $entityid, mostrecentfirst => $mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $type = "type_example"; # string | The entity type to get the rating.
my $entityid = "entityid_example"; # string | Id of the entity to get the ratings.
my $mostrecentfirst = null; # boolean | True to show most recent first, otherwise most helpful first.

eval { 
    $api_instance->ratinggetall(token => $token, type => $type, entityid => $entityid, mostrecentfirst => $mostrecentfirst);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratinggetall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **type** | **string**| The entity type to get the rating. | 
 **entityid** | **string**| Id of the entity to get the ratings. | 
 **mostrecentfirst** | **boolean**| True to show most recent first, otherwise most helpful first. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratinggetcomments**
> ratinggetcomments(token => $token, ratingid => $ratingid)

Gets all the comments for a rating

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $ratingid = null; # string | The ID of the rating to get all comments.

eval { 
    $api_instance->ratinggetcomments(token => $token, ratingid => $ratingid);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratinggetcomments: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **ratingid** | [**string**](.md)| The ID of the rating to get all comments. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratinggetpending**
> ratinggetpending(getgroup => $getgroup, rateid => $rateid, rateval => $rateval)

Gets info of pre-saved and pre-approved ratings

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $getgroup = null; # string | The ID of the group of pending ratings to get.
my $rateid = null; # string | Rate this before returning.
my $rateval = 56; # int | The value used to rate the item specified in rateid.

eval { 
    $api_instance->ratinggetpending(getgroup => $getgroup, rateid => $rateid, rateval => $rateval);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratinggetpending: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**string**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**string**](.md)| Rate this before returning. | [optional] 
 **rateval** | **int**| The value used to rate the item specified in rateid. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratinggetpendingmoderation**
> ratinggetpendingmoderation(token => $token)

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->ratinggetpendingmoderation(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratinggetpendingmoderation: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratingmoderate**
> ratingmoderate(token => $token, type => $type, id => $id, approve => $approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $type = "type_example"; # string | Either 'rating' or 'comment' depending on what you want to moderate.
my $id = null; # string | Id of the rating or comment, as specified in type.
my $approve = null; # boolean | True to approve, false to reject.

eval { 
    $api_instance->ratingmoderate(token => $token, type => $type, id => $id, approve => $approve);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratingmoderate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **type** | **string**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**string**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **boolean**| True to approve, false to reject. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratingpostcomment**
> ratingpostcomment(token => $token, ratingid => $ratingid, comment => $comment, annonymous => $annonymous)

Posts a comments for in a rating

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $ratingid = null; # string | The ID of the rating to post the comment.
my $comment = "comment_example"; # string | Text of the comment to post.
my $annonymous = null; # boolean | True to post the comment annonymously.

eval { 
    $api_instance->ratingpostcomment(token => $token, ratingid => $ratingid, comment => $comment, annonymous => $annonymous);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratingpostcomment: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **ratingid** | [**string**](.md)| The ID of the rating to post the comment. | 
 **comment** | **string**| Text of the comment to post. | 
 **annonymous** | **boolean**| True to post the comment annonymously. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratingrate**
> ratingrate(token => $token, type => $type, entityid => $entityid, annonymous => $annonymous, value => $value, comment => $comment, updatecomment => $updatecomment)

Rates one entity

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $type = "type_example"; # string | The entity type to rate.
my $entityid = "entityid_example"; # string | Id of the entity to rate.
my $annonymous = null; # boolean | Whether to post as annonymous.
my $value = 56; # int | Value from 0 to 100 with the rating.
my $comment = "comment_example"; # string | Comment associated with this review. Comment can be updated later on another request too.
my $updatecomment = null; # boolean | Whether to update the comments. Defaults to true.

eval { 
    $api_instance->ratingrate(token => $token, type => $type, entityid => $entityid, annonymous => $annonymous, value => $value, comment => $comment, updatecomment => $updatecomment);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratingrate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **type** | **string**| The entity type to rate. | 
 **entityid** | **string**| Id of the entity to rate. | 
 **annonymous** | **boolean**| Whether to post as annonymous. | 
 **value** | **int**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratingratepending**
> ratingratepending(group => $group, annonymous => $annonymous, rateid => $rateid, value => $value, comment => $comment, updatecomment => $updatecomment)

Rates a pre-saved and pre-approved entity

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $group = null; # string | The ID of the group of with pre-approved ratings.
my $annonymous = null; # boolean | Whether to post as annonymous.
my $rateid = null; # string | Rate this before returning.
my $value = 56; # int | Value from 0 to 100 with the rating.
my $comment = "comment_example"; # string | Comment associated with this review. Comment can be updated later on another request too.
my $updatecomment = null; # boolean | Whether to update the comments. Defaults to true.

eval { 
    $api_instance->ratingratepending(group => $group, annonymous => $annonymous, rateid => $rateid, value => $value, comment => $comment, updatecomment => $updatecomment);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratingratepending: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**string**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **boolean**| Whether to post as annonymous. | 
 **rateid** | [**string**](.md)| Rate this before returning. | [optional] 
 **value** | **int**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ratingvote**
> ratingvote(token => $token, ratingid => $ratingid, vote => $vote)

Votes up or down a rating

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $ratingid = null; # string | The ID of the rating to vote on.
my $vote = 56; # int | 1 to vote up, -1 to vote down.

eval { 
    $api_instance->ratingvote(token => $token, ratingid => $ratingid, vote => $vote);
};
if ($@) {
    warn "Exception when calling DefaultApi->ratingvote: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **ratingid** | [**string**](.md)| The ID of the rating to vote on. | 
 **vote** | **int**| 1 to vote up, -1 to vote down. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportattanalyticsprepare**
> reportattanalyticsprepare(token => $token, reportname => $reportname, params => $params, refreshgroup => $refreshgroup)

Query and load an attendance analytics report

Allows the user to query and load attendance analytics reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $reportname = "reportname_example"; # string | The name of the report to execute
my $params = "params_example"; # string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
my $refreshgroup = null; # string | The ID of the group to check (and refresh) before processing the report.

eval { 
    $api_instance->reportattanalyticsprepare(token => $token, reportname => $reportname, params => $params, refreshgroup => $refreshgroup);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportattanalyticsprepare: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **refreshgroup** | [**string**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportlist**
> reportlist(token => $token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->reportlist(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportpermissionsbyuser**
> reportpermissionsbyuser(token => $token, params => $params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $params = "params_example"; # string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

eval { 
    $api_instance->reportpermissionsbyuser(token => $token, params => $params);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportpermissionsbyuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportprepare**
> reportprepare(token => $token, reportname => $reportname, params => $params, repformat => $repformat, fillgroupid => $fillgroupid, groupby => $groupby, refreshgroup => $refreshgroup, filtertext => $filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $reportname = "reportname_example"; # string | The name of the report to execute
my $params = "params_example"; # string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
my $repformat = "repformat_example"; # string | The format of the resulting report. Json, pdf, csv, ...
my $fillgroupid = null; # string | If specified, the result is used to fill the group with the given ID
my $groupby = "groupby_example"; # string | How to group the records. In the format 'col1+col2|col3+col4
my $refreshgroup = null; # string | The ID of the group to check (and refresh) before processing the report.
my $filtertext = "filtertext_example"; # string | The user friendly text of the applied filters.

eval { 
    $api_instance->reportprepare(token => $token, reportname => $reportname, params => $params, repformat => $repformat, fillgroupid => $fillgroupid, groupby => $groupby, refreshgroup => $refreshgroup, filtertext => $filtertext);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportprepare: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **string**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**string**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **string**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**string**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **string**| The user friendly text of the applied filters. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportquery**
> reportquery(token => $token, reportname => $reportname, params => $params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $reportname = "reportname_example"; # string | The name of the report to execute
my $params = "params_example"; # string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

eval { 
    $api_instance->reportquery(token => $token, reportname => $reportname, params => $params);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportquery: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportscheduledelete**
> reportscheduledelete(token => $token, id => $id)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the report schedule to delete.

eval { 
    $api_instance->reportscheduledelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportscheduledelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the report schedule to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportscheduleget**
> reportscheduleget(token => $token, id => $id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the schedule to get.

eval { 
    $api_instance->reportscheduleget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportscheduleget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the schedule to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportschedulelist**
> reportschedulelist(token => $token, from => $from, count => $count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->reportschedulelist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportschedulelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportschedulesave**
> reportschedulesave(unknown_base_type => $unknown_base_type)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->reportschedulesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->reportschedulesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reporttagresults**
> reporttagresults(token => $token, reportname => $reportname, assign => $assign, tags => $tags, params => $params)

Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.

Allows the user to use a report to assign or unassign tags.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $reportname = "reportname_example"; # string | The name of the report to execute
my $assign = null; # boolean | Specify whether the specified tags have to be assigned or unassigned.
my $tags = "tags_example"; # string | The tags to assign (or unassign) to the resulting users in the report, in JSON format.
my $params = "params_example"; # string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

eval { 
    $api_instance->reporttagresults(token => $token, reportname => $reportname, assign => $assign, tags => $tags, params => $params);
};
if ($@) {
    warn "Exception when calling DefaultApi->reporttagresults: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **assign** | **boolean**| Specify whether the specified tags have to be assigned or unassigned. | 
 **tags** | **string**| The tags to assign (or unassign) to the resulting users in the report, in JSON format. | 
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodelcheckanalysis**
> riskmodelcheckanalysis(token => $token, id => $id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the risk assessment model whose analysis status has to be returned.

eval { 
    $api_instance->riskmodelcheckanalysis(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodelcheckanalysis: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodeldelete**
> riskmodeldelete(token => $token, id => $id)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the risk assessment model to delete.

eval { 
    $api_instance->riskmodeldelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodeldelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the risk assessment model to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodelget**
> riskmodelget(token => $token, id => $id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the risk assessment model to get.

eval { 
    $api_instance->riskmodelget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodelget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the risk assessment model to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodelgetscore**
> riskmodelgetscore(token => $token, userid => $userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to get the risk score.

eval { 
    $api_instance->riskmodelgetscore(token => $token, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodelgetscore: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to get the risk score. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodellist**
> riskmodellist(token => $token, from => $from, count => $count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->riskmodellist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodellist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodelpredict**
> riskmodelpredict(token => $token, id => $id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the assessment model to use in order to predict risk.

eval { 
    $api_instance->riskmodelpredict(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodelpredict: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the assessment model to use in order to predict risk. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodelprocess**
> riskmodelprocess(token => $token, id => $id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the risk assessment model to process.

eval { 
    $api_instance->riskmodelprocess(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodelprocess: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the risk assessment model to process. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodelrefresh**
> riskmodelrefresh(token => $token, id => $id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the risk assessment model whose information has to be refreshed.

eval { 
    $api_instance->riskmodelrefresh(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodelrefresh: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodelsave**
> riskmodelsave(unknown_base_type => $unknown_base_type)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->riskmodelsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodelsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodeltermprecedences**
> riskmodeltermprecedences(token => $token)

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->riskmodeltermprecedences(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->riskmodeltermprecedences: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rolelist**
> rolelist(token => $token, name => $name)

Show a list of roles

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $name = "name_example"; # string | Filter by name of the role.

eval { 
    $api_instance->rolelist(token => $token, name => $name);
};
if ($@) {
    warn "Exception when calling DefaultApi->rolelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **name** | **string**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ruledelete**
> ruledelete(token => $token, id => $id)

Delete a rule

Allows the user to delete an existing rule.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the rule to delete.

eval { 
    $api_instance->ruledelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->ruledelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the rule to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ruleget**
> ruleget(token => $token, id => $id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the rule to get.

eval { 
    $api_instance->ruleget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->ruleget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the rule to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulegeteventtype**
> rulegeteventtype(token => $token, event => $event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $event = "event_example"; # string | The name of the event to refresh.

eval { 
    $api_instance->rulegeteventtype(token => $token, event => $event);
};
if ($@) {
    warn "Exception when calling DefaultApi->rulegeteventtype: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **event** | **string**| The name of the event to refresh. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulelist**
> rulelist(token => $token, from => $from, count => $count)

View a list of user rules

Allows the user to view the list of all rules.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->rulelist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->rulelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulelistactions**
> rulelistactions(token => $token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->rulelistactions(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->rulelistactions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulelisteventtypes**
> rulelisteventtypes(token => $token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->rulelisteventtypes(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->rulelisteventtypes: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulelisthttprequests**
> rulelisthttprequests(token => $token, from => $from, count => $count, failed => $failed, status => $status)

View all the http requests sent as a result of a rule

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $failed = null; # boolean | If true only failed requests will be returned
my $status = 56; # int | The http status to filter the requests

eval { 
    $api_instance->rulelisthttprequests(token => $token, from => $from, count => $count, failed => $failed, status => $status);
};
if ($@) {
    warn "Exception when calling DefaultApi->rulelisthttprequests: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **failed** | **boolean**| If true only failed requests will be returned | [optional] 
 **status** | **int**| The http status to filter the requests | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulesave**
> rulesave(unknown_base_type => $unknown_base_type)

Create or edit a rule

Allows the user to create or edit a rule.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->rulesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->rulesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduledelete**
> scheduledelete(token => $token, scheduleid => $scheduleid)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $scheduleid = null; # string | The id of the schedule.

eval { 
    $api_instance->scheduledelete(token => $token, scheduleid => $scheduleid);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduledelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **scheduleid** | [**string**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduledeletemine**
> scheduledeletemine(token => $token, scheduleid => $scheduleid)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $scheduleid = null; # string | The id of the schedule.

eval { 
    $api_instance->scheduledeletemine(token => $token, scheduleid => $scheduleid);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduledeletemine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **scheduleid** | [**string**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleenable**
> scheduleenable(token => $token, userid => $userid, enable => $enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to enable or disable the schedule.
my $enable = null; # boolean | True to enable schedules, false to disable.

eval { 
    $api_instance->scheduleenable(token => $token, userid => $userid, enable => $enable);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduleenable: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **boolean**| True to enable schedules, false to disable. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleenablemine**
> scheduleenablemine(token => $token, enable => $enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $enable = null; # boolean | True to enable schedules, false to disable.

eval { 
    $api_instance->scheduleenablemine(token => $token, enable => $enable);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduleenablemine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **enable** | **boolean**| True to enable schedules, false to disable. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulefindallstaffslots**
> schedulefindallstaffslots(token => $token, starttime => $starttime, endtime => $endtime, staffid => $staffid, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $staffid = null; # string | The id of the staff to filter by.
my $serviceids = "serviceids_example"; # string | CSV list of the service Ids to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the location to filter by.
my $staffroleids = "staffroleids_example"; # string | CSV list of the staff member role ids to filter by.
my $availablefor = "availablefor_example"; # string | The specific availability type to filter by.

eval { 
    $api_instance->schedulefindallstaffslots(token => $token, starttime => $starttime, endtime => $endtime, staffid => $staffid, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulefindallstaffslots: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulefindslots**
> schedulefindslots(token => $token, staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, availablefor => $availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $staffid = null; # string | The id of the staff to filter by.
my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $serviceids = "serviceids_example"; # string | CSV list of the service Ids to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the service to filter by.
my $availablefor = "availablefor_example"; # string | The specific availability type to filter by.

eval { 
    $api_instance->schedulefindslots(token => $token, staffid => $staffid, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, availablefor => $availablefor);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulefindslots: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulefindstaffavail**
> schedulefindstaffavail(token => $token, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor, photosize => $photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $starttime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start time of the range to look for slots.
my $endtime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end time of the range to look for slots.
my $serviceids = "serviceids_example"; # string | CSV list of the service ids to filter by.
my $eventid = null; # string | The id of the event to filter by.
my $locationid = null; # string | The id of the service to filter by.
my $staffroleids = "staffroleids_example"; # string | CSV list of the staff member role ids to filter by.
my $availablefor = "availablefor_example"; # string | Filter slots by a specific availability type.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->schedulefindstaffavail(token => $token, starttime => $starttime, endtime => $endtime, serviceids => $serviceids, eventid => $eventid, locationid => $locationid, staffroleids => $staffroleids, availablefor => $availablefor, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulefindstaffavail: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleget**
> scheduleget(token => $token, scheduleid => $scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $scheduleid = null; # string | The id of the schedule.

eval { 
    $api_instance->scheduleget(token => $token, scheduleid => $scheduleid);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduleget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **scheduleid** | [**string**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulegetmine**
> schedulegetmine(token => $token, scheduleid => $scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $scheduleid = null; # string | The id of the schedule.

eval { 
    $api_instance->schedulegetmine(token => $token, scheduleid => $scheduleid);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulegetmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **scheduleid** | [**string**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulegetstaff**
> schedulegetstaff(token => $token, userid => $userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to get info.

eval { 
    $api_instance->schedulegetstaff(token => $token, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulegetstaff: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to get info. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulegetstaffmine**
> schedulegetstaffmine(token => $token)

View current user's schedule information

Allows the user to view their own schedule.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->schedulegetstaffmine(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulegetstaffmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegrationdeleteitem**
> scheduleintegrationdeleteitem(token => $token, thirdpartyid => $thirdpartyid)

Delete a schedule item looking up by a third party ID

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $thirdpartyid = "thirdpartyid_example"; # string | The third party id to search the schedule block / appointment.

eval { 
    $api_instance->scheduleintegrationdeleteitem(token => $token, thirdpartyid => $thirdpartyid);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduleintegrationdeleteitem: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **thirdpartyid** | **string**| The third party id to search the schedule block / appointment. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegrationdeleteitemsbymasterid**
> scheduleintegrationdeleteitemsbymasterid(token => $token, thirdpartymasterid => $thirdpartymasterid)

Delete multiple schedule items looking up by a third party master ID

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $thirdpartymasterid = "thirdpartymasterid_example"; # string | The third party master id to search the schedule items.

eval { 
    $api_instance->scheduleintegrationdeleteitemsbymasterid(token => $token, thirdpartymasterid => $thirdpartymasterid);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduleintegrationdeleteitemsbymasterid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **thirdpartymasterid** | **string**| The third party master id to search the schedule items. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegrationgetitem**
> scheduleintegrationgetitem(token => $token, thirdpartyid => $thirdpartyid)

Get a schedule item looking up by a third party ID

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $thirdpartyid = "thirdpartyid_example"; # string | The third party id to search for the schedule item.

eval { 
    $api_instance->scheduleintegrationgetitem(token => $token, thirdpartyid => $thirdpartyid);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduleintegrationgetitem: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **thirdpartyid** | **string**| The third party id to search for the schedule item. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegrationsaveitem**
> scheduleintegrationsaveitem(unknown_base_type => $unknown_base_type)

Save a schedule item looking up by a third party ID

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->scheduleintegrationsaveitem(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduleintegrationsaveitem: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scheduleintegrationsetid**
> scheduleintegrationsetid(token => $token, id => $id, thirdpartyid => $thirdpartyid, thirdpartymasterid => $thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the schedule block / appointment.
my $thirdpartyid = "thirdpartyid_example"; # string | The 3rd party ID to set.
my $thirdpartymasterid = "thirdpartymasterid_example"; # string | The 3rd party master ID to set (useful to handle recurring items).

eval { 
    $api_instance->scheduleintegrationsetid(token => $token, id => $id, thirdpartyid => $thirdpartyid, thirdpartymasterid => $thirdpartymasterid);
};
if ($@) {
    warn "Exception when calling DefaultApi->scheduleintegrationsetid: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the schedule block / appointment. | 
 **thirdpartyid** | **string**| The 3rd party ID to set. | 
 **thirdpartymasterid** | **string**| The 3rd party master ID to set (useful to handle recurring items). | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulemyofftimes**
> schedulemyofftimes(token => $token, includedeleted => $includedeleted, onlyupcoming => $onlyupcoming, modifiedafter => $modifiedafter)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $includedeleted = null; # boolean | If true the deleted offtimes are also returned.
my $onlyupcoming = null; # boolean | If true then only upcoming offtimes are returned.
my $modifiedafter = DateTime->from_epoch(epoch => str2time('null')); # DateTime | If specified, only offtimes modified after the specified date will be returned.

eval { 
    $api_instance->schedulemyofftimes(token => $token, includedeleted => $includedeleted, onlyupcoming => $onlyupcoming, modifiedafter => $modifiedafter);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulemyofftimes: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **includedeleted** | **boolean**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **boolean**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulesave**
> schedulesave(unknown_base_type => $unknown_base_type)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->schedulesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schedulesavemine**
> schedulesavemine(unknown_base_type => $unknown_base_type)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->schedulesavemine(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->schedulesavemine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **search**
> search(token => $token, query => $query, page => $page)

Search

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $query = "query_example"; # string | The query to search for.
my $page = 56; # int | Current page to show, zero-based.

eval { 
    $api_instance->search(token => $token, query => $query, page => $page);
};
if ($@) {
    warn "Exception when calling DefaultApi->search: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | **string**| The query to search for. | 
 **page** | **int**| Current page to show, zero-based. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchgetentities**
> searchgetentities(token => $token)

Get the information of the entities that can be searched

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->searchgetentities(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->searchgetentities: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **securityassesspermission**
> securityassesspermission(token => $token, commandname => $commandname)

Returns the list of users for a specific permission

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $commandname = "commandname_example"; # string | Name of the action or command to get the roles.

eval { 
    $api_instance->securityassesspermission(token => $token, commandname => $commandname);
};
if ($@) {
    warn "Exception when calling DefaultApi->securityassesspermission: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **commandname** | **string**| Name of the action or command to get the roles. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **securityassessrole**
> securityassessrole(token => $token, roleid => $roleid)

Returns the list of permissions for a specific role

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $roleid = null; # string | Role ID to list the effective permissions.

eval { 
    $api_instance->securityassessrole(token => $token, roleid => $roleid);
};
if ($@) {
    warn "Exception when calling DefaultApi->securityassessrole: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **roleid** | [**string**](.md)| Role ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **securityassessscope**
> securityassessscope(token => $token, locationid => $locationid)

Returns the list of users for a specific user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $locationid = null; # string | Location ID to list the users with that scope.

eval { 
    $api_instance->securityassessscope(token => $token, locationid => $locationid);
};
if ($@) {
    warn "Exception when calling DefaultApi->securityassessscope: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **locationid** | [**string**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **securityassessuser**
> securityassessuser(token => $token, userid => $userid)

Returns the list of permissions for a specific user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | User ID to list the effective permissions.

eval { 
    $api_instance->securityassessuser(token => $token, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->securityassessuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| User ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **seminardelete**
> seminardelete(token => $token, id => $id)

Delete an event

Allows the user to delete an existing event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the seminar to delete.

eval { 
    $api_instance->seminardelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->seminardelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the seminar to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **seminarget**
> seminarget(token => $token, id => $id)

Search and view details of a event

Allows the user to view a event and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the seminar to get.

eval { 
    $api_instance->seminarget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->seminarget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the seminar to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **seminarlist**
> seminarlist(token => $token, from => $from, count => $count, summaryonly => $summaryonly, termid => $termid)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = "from_example"; # string | The first record to return.
my $count = "count_example"; # string | The max number of records to return.
my $summaryonly = null; # boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
my $termid = null; # string | Id of the term to list the events. Null to list all events.

eval { 
    $api_instance->seminarlist(token => $token, from => $from, count => $count, summaryonly => $summaryonly, termid => $termid);
};
if ($@) {
    warn "Exception when calling DefaultApi->seminarlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**string**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **seminarsave**
> seminarsave(unknown_base_type => $unknown_base_type)

Create or edit a event

Allows the user to create or edit a event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->seminarsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->seminarsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **serviceassignmentaddservice**
> serviceassignmentaddservice(token => $token, serviceid => $serviceid, locationid => $locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceid = null; # string | The id of the service to add.
my $locationid = null; # string | The id of the location.

eval { 
    $api_instance->serviceassignmentaddservice(token => $token, serviceid => $serviceid, locationid => $locationid);
};
if ($@) {
    warn "Exception when calling DefaultApi->serviceassignmentaddservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**string**](.md)| The id of the service to add. | 
 **locationid** | [**string**](.md)| The id of the location. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **serviceassignmentgetlocation**
> serviceassignmentgetlocation(token => $token, locationid => $locationid, includegloballyavailable => $includegloballyavailable, namefilter => $namefilter, count => $count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $locationid = null; # string | The id of the location to get.
my $includegloballyavailable = null; # boolean | Specifies whether the services available globally must be returned or not.
my $namefilter = null; # boolean | Filters the name of the services to return.
my $count = 56; # int | The max number of services to return.

eval { 
    $api_instance->serviceassignmentgetlocation(token => $token, locationid => $locationid, includegloballyavailable => $includegloballyavailable, namefilter => $namefilter, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->serviceassignmentgetlocation: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **locationid** | [**string**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **boolean**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **boolean**| Filters the name of the services to return. | [optional] 
 **count** | **int**| The max number of services to return. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **serviceassignmentgetservice**
> serviceassignmentgetservice(token => $token, serviceid => $serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceid = null; # string | The id of the service to get its locations.

eval { 
    $api_instance->serviceassignmentgetservice(token => $token, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling DefaultApi->serviceassignmentgetservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**string**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **serviceassignmentremoveservice**
> serviceassignmentremoveservice(token => $token, serviceid => $serviceid, locationid => $locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceid = null; # string | The id of the service to remove.
my $locationid = null; # string | The id of the location to remove the service from.

eval { 
    $api_instance->serviceassignmentremoveservice(token => $token, serviceid => $serviceid, locationid => $locationid);
};
if ($@) {
    warn "Exception when calling DefaultApi->serviceassignmentremoveservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**string**](.md)| The id of the service to remove. | 
 **locationid** | [**string**](.md)| The id of the location to remove the service from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **servicedelete**
> servicedelete(token => $token, id => $id)

Delete a service

Allows the user to delete a service from the existing list.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the service to delete.

eval { 
    $api_instance->servicedelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->servicedelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the service to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **serviceget**
> serviceget(token => $token, id => $id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the service to get.

eval { 
    $api_instance->serviceget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->serviceget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the service to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **servicelist**
> servicelist(token => $token, from => $from, count => $count)

View a list of services

Allows the user to view the full list of existing services.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->servicelist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->servicelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **servicesave**
> servicesave(unknown_base_type => $unknown_base_type)

Create or edit a service

Allows the user to create or edit a service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->servicesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->servicesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelogaddnote**
> sessionattendancelogaddnote(token => $token, id => $id, text => $text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the attendance log.
my $text = "text_example"; # string | The text of the note to add.

eval { 
    $api_instance->sessionattendancelogaddnote(token => $token, id => $id, text => $text);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendancelogaddnote: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the attendance log. | 
 **text** | **string**| The text of the note to add. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelogget**
> sessionattendancelogget(token => $token, id => $id, photosize => $photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the attendance log to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->sessionattendancelogget(token => $token, id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendancelogget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the attendance log to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendanceloggetuser**
> sessionattendanceloggetuser(attendee => $attendee, eventid => $eventid, token => $token)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $attendee = null; # string | The id of the attendee to get statistic for.
my $eventid = null; # string | The id of the event whose attendee statistics have to be returned.
my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->sessionattendanceloggetuser(attendee => $attendee, eventid => $eventid, token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendanceloggetuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**string**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**string**](.md)| The id of the event whose attendee statistics have to be returned. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendanceloglist**
> sessionattendanceloglist(token => $token, session => $session, from => $from, count => $count, photosize => $photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $session = null; # string | The id of the session whose attendees logs have to be returned.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->sessionattendanceloglist(token => $token, session => $session, from => $from, count => $count, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendanceloglist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **session** | [**string**](.md)| The id of the session whose attendees logs have to be returned. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendanceloglistevent**
> sessionattendanceloglistevent(eventid => $eventid, token => $token)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $eventid = null; # string | The id of the event whose attendance has to be returned.
my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->sessionattendanceloglistevent(eventid => $eventid, token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendanceloglistevent: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event whose attendance has to be returned. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendanceloglistsummary**
> sessionattendanceloglistsummary(token => $token, eventid => $eventid, attendeeid => $attendeeid, groupid => $groupid, start => $start, end => $end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The id of the event whose attendance has to be returned.
my $attendeeid = null; # string | The id of the attendee whose attendance has to be returned.
my $groupid = null; # string | The id of the group whose attendance has to be returned.
my $start = "start_example"; # string | The start date to filter (beginning of time by default).
my $end = "end_example"; # string | The end date to filter (today by default).

eval { 
    $api_instance->sessionattendanceloglistsummary(token => $token, eventid => $eventid, attendeeid => $attendeeid, groupid => $groupid, start => $start, end => $end);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendanceloglistsummary: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional] 
 **eventid** | [**string**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**string**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**string**](.md)| The id of the group whose attendance has to be returned. | [optional] 
 **start** | **string**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **string**| The end date to filter (today by default). | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelogmylistsummary**
> sessionattendancelogmylistsummary(token => $token, eventid => $eventid, start => $start, end => $end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The id of the event whose attendance has to be returned.
my $start = "start_example"; # string | The start date to filter (beginning of time by default).
my $end = "end_example"; # string | The end date to filter (today by default).

eval { 
    $api_instance->sessionattendancelogmylistsummary(token => $token, eventid => $eventid, start => $start, end => $end);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendancelogmylistsummary: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional] 
 **eventid** | [**string**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **start** | **string**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **string**| The end date to filter (today by default). | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelogsave**
> sessionattendancelogsave(unknown_base_type => $unknown_base_type)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionattendancelogsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendancelogsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionattendancelogsaveswipe**
> sessionattendancelogsaveswipe(unknown_base_type => $unknown_base_type)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionattendancelogsaveswipe(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionattendancelogsaveswipe: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionbulkupdate**
> sessionbulkupdate(token => $token, eventid => $eventid, sessions => $sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The id of the event to bulk update.
my $sessions = "sessions_example"; # string | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

eval { 
    $api_instance->sessionbulkupdate(token => $token, eventid => $eventid, sessions => $sessions);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionbulkupdate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The id of the event to bulk update. | 
 **sessions** | **string**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionget**
> sessionget(token => $token, id => $id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the session to get.

eval { 
    $api_instance->sessionget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the session to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessiongetschedule**
> sessiongetschedule(token => $token, day => $day, attendee => $attendee, location => $location, instructor => $instructor)

Gets the schedule for a location, instructor or attendees

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $day = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The day to return. It will also return the whole week for that day.
my $attendee = null; # string | The id of the attendee to get the schedule.
my $location = null; # string | The id of the location to get the schedule.
my $instructor = null; # string | The id of the instructor to get the schedule.

eval { 
    $api_instance->sessiongetschedule(token => $token, day => $day, attendee => $attendee, location => $location, instructor => $instructor);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessiongetschedule: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional] 
 **day** | **DateTime**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**string**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**string**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**string**](.md)| The id of the instructor to get the schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionlist**
> sessionlist(from => $from, count => $count, token => $token, startdate => $startdate, enddate => $enddate)

Gets all future sessions of the current semester

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $token = "token_example"; # string | The authentication token.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date to filter the sessions
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date to filter the sessions.

eval { 
    $api_instance->sessionlist(from => $from, count => $count, token => $token, startdate => $startdate, enddate => $enddate);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **startdate** | **DateTime**| The start date to filter the sessions | [optional] 
 **enddate** | **DateTime**| The end date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregaddcurrentuser**
> sessionregaddcurrentuser(token => $token, eventid => $eventid, sessiondate => $sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The id of the event.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.

eval { 
    $api_instance->sessionregaddcurrentuser(token => $token, eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionregaddcurrentuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregadduser**
> sessionregadduser(token => $token, userid => $userid, eventid => $eventid, sessiondate => $sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to add.
my $eventid = null; # string | The id of the event.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.

eval { 
    $api_instance->sessionregadduser(token => $token, userid => $userid, eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionregadduser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to add. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreggetmysessions**
> sessionreggetmysessions(token => $token, date => $date)

View all the sessions the logged user is registered to

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $date = DateTime->from_epoch(epoch => str2time('null')); # DateTime | Start date to filter the sessions.

eval { 
    $api_instance->sessionreggetmysessions(token => $token, date => $date);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionreggetmysessions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime**| Start date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreggetsessions**
> sessionreggetsessions(token => $token, userid => $userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The user id to list sessions.

eval { 
    $api_instance->sessionreggetsessions(token => $token, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionreggetsessions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The user id to list sessions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreggetsettings**
> sessionreggetsettings(token => $token, locationid => $locationid, eventid => $eventid, sessiondate => $sessiondate, noinherit => $noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $locationid = null; # string | The id of the location to save settings.
my $eventid = null; # string | The id of the event to save settings.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.
my $noinherit = null; # boolean | True to get the location/event/session specific settings without looking for the more global settings.

eval { 
    $api_instance->sessionreggetsettings(token => $token, locationid => $locationid, eventid => $eventid, sessiondate => $sessiondate, noinherit => $noinherit);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionreggetsettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **locationid** | [**string**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**string**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **DateTime**| The date and time when the session starts. | [optional] 
 **noinherit** | **boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreggetusers**
> sessionreggetusers(token => $token, eventid => $eventid, sessiondate => $sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The event id to list sessions.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date of the session to find.

eval { 
    $api_instance->sessionreggetusers(token => $token, eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionreggetusers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime**| The date of the session to find. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreglistsessions**
> sessionreglistsessions(token => $token, eventid => $eventid, sessiondate => $sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The event id to list sessions.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date of the session to find.

eval { 
    $api_instance->sessionreglistsessions(token => $token, eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionreglistsessions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime**| The date of the session to find. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreglistupcoming**
> sessionreglistupcoming(token => $token, date => $date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $date = DateTime->from_epoch(epoch => str2time('null')); # DateTime | Only sessions in the week of the specified date will be returned.

eval { 
    $api_instance->sessionreglistupcoming(token => $token, date => $date);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionreglistupcoming: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime**| Only sessions in the week of the specified date will be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreglistupcomingevent**
> sessionreglistupcomingevent(token => $token, date => $date, event => $event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $date = DateTime->from_epoch(epoch => str2time('null')); # DateTime | Start date to filter the returned sessions.
my $event = null; # string | The id of the event whose sessions will be returned

eval { 
    $api_instance->sessionreglistupcomingevent(token => $token, date => $date, event => $event);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionreglistupcomingevent: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime**| Start date to filter the returned sessions. | 
 **event** | [**string**](.md)| The id of the event whose sessions will be returned | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregremovecurrentuser**
> sessionregremovecurrentuser(token => $token, eventid => $eventid, sessiondate => $sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $eventid = null; # string | The id of the event.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.

eval { 
    $api_instance->sessionregremovecurrentuser(token => $token, eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionregremovecurrentuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregremoveuser**
> sessionregremoveuser(token => $token, userid => $userid, eventid => $eventid, sessiondate => $sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to remove.
my $eventid = null; # string | The id of the event.
my $sessiondate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time when the session starts.

eval { 
    $api_instance->sessionregremoveuser(token => $token, userid => $userid, eventid => $eventid, sessiondate => $sessiondate);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionregremoveuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregsavesettings**
> sessionregsavesettings(unknown_base_type => $unknown_base_type)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionregsavesettings(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionregsavesettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswipedelete**
> sessionswipedelete(token => $token, id => $id)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the session swipe to delete.

eval { 
    $api_instance->sessionswipedelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionswipedelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the session swipe to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswipeget**
> sessionswipeget(token => $token, id => $id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the swipe to get.

eval { 
    $api_instance->sessionswipeget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionswipeget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswipelistunresolved**
> sessionswipelistunresolved(from => $from, count => $count, token => $token)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->sessionswipelistunresolved(from => $from, count => $count, token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionswipelistunresolved: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswiperesolve**
> sessionswiperesolve(token => $token, id => $id, session => $session, user => $user)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the swipe to resolve.
my $session = null; # string | The id of the session whose swipe has to be saved.
my $user = null; # string | The id of the user who signed-in.

eval { 
    $api_instance->sessionswiperesolve(token => $token, id => $id, session => $session, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionswiperesolve: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the swipe to resolve. | 
 **session** | [**string**](.md)| The id of the session whose swipe has to be saved. | [optional] 
 **user** | [**string**](.md)| The id of the user who signed-in. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswipesave**
> sessionswipesave(unknown_base_type => $unknown_base_type)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionswipesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionswipesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswipesaveanonym**
> sessionswipesaveanonym(unknown_base_type => $unknown_base_type)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionswipesaveanonym(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->sessionswipesaveanonym: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **settingaddlogo**
> settingaddlogo(token => $token, upload => $upload, filename => $filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The original filename, needed to process the file.

eval { 
    $api_instance->settingaddlogo(token => $token, upload => $upload, filename => $filename);
};
if ($@) {
    warn "Exception when calling DefaultApi->settingaddlogo: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The original filename, needed to process the file. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **settingget**
> settingget(keys => $keys, token => $token, domain => $domain, scope => $scope)

Get settings for the account or the specified scope

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $keys = "keys_example"; # string | The option keys to get values for. Enter multiple separated by comma.
my $token = "token_example"; # string | The authentication token.
my $domain = "domain_example"; # string | The account domain, in case of reading settings annonymously.
my $scope = "scope_example"; # string | The scope of the settings to get.

eval { 
    $api_instance->settingget(keys => $keys, token => $token, domain => $domain, scope => $scope);
};
if ($@) {
    warn "Exception when calling DefaultApi->settingget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **string**| The option keys to get values for. Enter multiple separated by comma. | 
 **token** | **string**| The authentication token. | [optional] 
 **domain** | **string**| The account domain, in case of reading settings annonymously. | [optional] 
 **scope** | **string**| The scope of the settings to get. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **settingsave**
> settingsave(unknown_base_type => $unknown_base_type)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->settingsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->settingsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **settingviewgeneral**
> settingviewgeneral(token => $token)

View general settings for the account

Allows the user to view the settings' general section.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->settingviewgeneral(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->settingviewgeneral: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialcontacts**
> socialcontacts(token => $token, filter => $filter, showdefaultphoto => $showdefaultphoto)

Gets the list of contacts in the network

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $filter = "filter_example"; # string | Text to filter results.
my $showdefaultphoto = null; # boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.

eval { 
    $api_instance->socialcontacts(token => $token, filter => $filter, showdefaultphoto => $showdefaultphoto);
};
if ($@) {
    warn "Exception when calling DefaultApi->socialcontacts: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **filter** | **string**| Text to filter results. | [optional] 
 **showdefaultphoto** | **boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroupaddmembers**
> socialgroupaddmembers(token => $token, id => $id, userids => $userids)

Adds new members to a group (which the user must own already)

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | ID of the group to add members to.
my $userids = "userids_example"; # string | Csv list of user Ids to add.

eval { 
    $api_instance->socialgroupaddmembers(token => $token, id => $id, userids => $userids);
};
if ($@) {
    warn "Exception when calling DefaultApi->socialgroupaddmembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| ID of the group to add members to. | 
 **userids** | **string**| Csv list of user Ids to add. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroupdelete**
> socialgroupdelete(token => $token, id => $id)

Deletes a group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | ID of the group to delete.

eval { 
    $api_instance->socialgroupdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->socialgroupdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| ID of the group to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgrouplist**
> socialgrouplist(token => $token)

View all the groups the current user is in

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->socialgrouplist(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->socialgrouplist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgrouplistmembers**
> socialgrouplistmembers(token => $token, id => $id)

Lists the members of a group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | ID of the group to list members.

eval { 
    $api_instance->socialgrouplistmembers(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->socialgrouplistmembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| ID of the group to list members. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroupremovemembers**
> socialgroupremovemembers(token => $token, id => $id, userids => $userids)

Removes members from a group (which the user must own already)

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | ID of the group to remove members from.
my $userids = "userids_example"; # string | Csv list of user Ids to remove.

eval { 
    $api_instance->socialgroupremovemembers(token => $token, id => $id, userids => $userids);
};
if ($@) {
    warn "Exception when calling DefaultApi->socialgroupremovemembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| ID of the group to remove members from. | 
 **userids** | **string**| Csv list of user Ids to remove. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroupremovemyself**
> socialgroupremovemyself(token => $token, id => $id)

Removes myself from an existent group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | ID of the group to remove me from.

eval { 
    $api_instance->socialgroupremovemyself(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->socialgroupremovemyself: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| ID of the group to remove me from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **socialgroupsave**
> socialgroupsave(unknown_base_type => $unknown_base_type)

Saves a new group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->socialgroupsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->socialgroupsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ssogeneratekey**
> ssogeneratekey(token => $token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->ssogeneratekey(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->ssogeneratekey: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ssogetsettings**
> ssogetsettings(token => $token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->ssogetsettings(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->ssogetsettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ssoissuetoken**
> ssoissuetoken(key => $key, username => $username, expires => $expires)

Issue single sign-on token

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $key = "key_example"; # string | The single sign-on key of the account.
my $username = "username_example"; # string | The email of the user to sign-on.
my $expires = null; # boolean | Specifies whether the session should expire when inactive.

eval { 
    $api_instance->ssoissuetoken(key => $key, username => $username, expires => $expires);
};
if ($@) {
    warn "Exception when calling DefaultApi->ssoissuetoken: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The single sign-on key of the account. | 
 **username** | **string**| The email of the user to sign-on. | 
 **expires** | **boolean**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ssosavesettings**
> ssosavesettings(unknown_base_type => $unknown_base_type)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->ssosavesettings(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->ssosavesettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailaddmetoallservices**
> staffavailaddmetoallservices(token => $token)

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->staffavailaddmetoallservices(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailaddmetoallservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailaddmetoservice**
> staffavailaddmetoservice(token => $token, serviceid => $serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceid = null; # string | The id of the service.

eval { 
    $api_instance->staffavailaddmetoservice(token => $token, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailaddmetoservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**string**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailaddusertoallservices**
> staffavailaddusertoallservices(token => $token, userid => $userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to add.

eval { 
    $api_instance->staffavailaddusertoallservices(token => $token, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailaddusertoallservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to add. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailaddusertoservice**
> staffavailaddusertoservice(token => $token, userid => $userid, serviceid => $serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to add.
my $serviceid = null; # string | The id of the service.

eval { 
    $api_instance->staffavailaddusertoservice(token => $token, userid => $userid, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailaddusertoservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to add. | 
 **serviceid** | [**string**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailgetmyservices**
> staffavailgetmyservices(token => $token)

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->staffavailgetmyservices(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailgetmyservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailgetservices**
> staffavailgetservices(token => $token, userid => $userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The user id to list services.

eval { 
    $api_instance->staffavailgetservices(token => $token, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailgetservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The user id to list services. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailgetusersforservice**
> staffavailgetusersforservice(token => $token, serviceid => $serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceid = null; # string | The service id to list users.

eval { 
    $api_instance->staffavailgetusersforservice(token => $token, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailgetusersforservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**string**](.md)| The service id to list users. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavaillisttypes**
> staffavaillisttypes(token => $token)

View all the availability types

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->staffavaillisttypes(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavaillisttypes: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailremovemefromallservices**
> staffavailremovemefromallservices(token => $token)

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->staffavailremovemefromallservices(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailremovemefromallservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailremovemefromservice**
> staffavailremovemefromservice(token => $token, serviceid => $serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $serviceid = null; # string | The id of the service.

eval { 
    $api_instance->staffavailremovemefromservice(token => $token, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailremovemefromservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**string**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailremoveuserfromallservices**
> staffavailremoveuserfromallservices(token => $token, userid => $userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to remove.

eval { 
    $api_instance->staffavailremoveuserfromallservices(token => $token, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailremoveuserfromallservices: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to remove. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailremoveuserfromservice**
> staffavailremoveuserfromservice(token => $token, userid => $userid, serviceid => $serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to remove.
my $serviceid = null; # string | The id of the service.

eval { 
    $api_instance->staffavailremoveuserfromservice(token => $token, userid => $userid, serviceid => $serviceid);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailremoveuserfromservice: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **serviceid** | [**string**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailsetavailability**
> staffavailsetavailability(token => $token, userid => $userid, availablefor => $availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user whose specific availability has to be set.
my $availablefor = "availablefor_example"; # string | Specific availability to set.

eval { 
    $api_instance->staffavailsetavailability(token => $token, userid => $userid, availablefor => $availablefor);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailsetavailability: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user whose specific availability has to be set. | 
 **availablefor** | **string**| Specific availability to set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **staffavailsetmyavailability**
> staffavailsetmyavailability(token => $token, availablefor => $availablefor)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $availablefor = "availablefor_example"; # string | Specific availability to set.

eval { 
    $api_instance->staffavailsetmyavailability(token => $token, availablefor => $availablefor);
};
if ($@) {
    warn "Exception when calling DefaultApi->staffavailsetmyavailability: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **availablefor** | **string**| Specific availability to set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationdelete**
> stationdelete(token => $token, id => $id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the sign-in station to delete.

eval { 
    $api_instance->stationdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the sign-in station to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationget**
> stationget(token => $token, id => $id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the sign-in station to get.

eval { 
    $api_instance->stationget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the sign-in station to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationgetcurrentterms**
> stationgetcurrentterms(station => $station)

Get all the current terms

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station whose account's current terms have to be retrieved.

eval { 
    $api_instance->stationgetcurrentterms(station => $station);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationgetcurrentterms: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationgetinfo**
> stationgetinfo(id => $id, event => $event)

Gets a the info to display in the sign-in station by it's ID.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $id = null; # string | The id of the sign-in station to get.
my $event = null; # string | The id of the event, to override the one by schedule.

eval { 
    $api_instance->stationgetinfo(id => $id, event => $event);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationgetinfo: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the sign-in station to get. | 
 **event** | [**string**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationgetlicense**
> stationgetlicense(station => $station)

Gets the current license information

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = "station_example"; # string | The id of the sign-in station whose account's license has to be retrieved.

eval { 
    $api_instance->stationgetlicense(station => $station);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationgetlicense: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | **string**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationgetlocationsettings**
> stationgetlocationsettings(location => $location)

View the sign-in station settings of a specified location

Allows the user to view the location settings of a sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $location = null; # string | The id of the location whose station settings have to be returned.

eval { 
    $api_instance->stationgetlocationsettings(location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationgetlocationsettings: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**string**](.md)| The id of the location whose station settings have to be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationlist**
> stationlist(token => $token, from => $from, count => $count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->stationlist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationsave**
> stationsave(unknown_base_type => $unknown_base_type)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->stationsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationsavemine**
> stationsavemine(unknown_base_type => $unknown_base_type)

Create or edit a class attendance sign-in station for myself

Allows the user to create a class attendance sign-in station for a course for which they are available as staff.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->stationsavemine(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationsavemine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationunlock**
> stationunlock(id => $id, passcode => $passcode, method => $method)

Unlocks the sign-in station.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $id = null; # string | The id of the sign-in station to unlock.
my $passcode = "passcode_example"; # string | The passcode to unlock the station.
my $method = "method_example"; # string | The authentication method. Valid values are 'token' and 'cookie'.

eval { 
    $api_instance->stationunlock(id => $id, passcode => $passcode, method => $method);
};
if ($@) {
    warn "Exception when calling DefaultApi->stationunlock: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the sign-in station to unlock. | 
 **passcode** | **string**| The passcode to unlock the station. | 
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipedelete**
> swipedelete(token => $token, id => $id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the swipe to delete.

eval { 
    $api_instance->swipedelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->swipedelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the swipe to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipeget**
> swipeget(token => $token, id => $id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the swipe to get.

eval { 
    $api_instance->swipeget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->swipeget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipelist**
> swipelist(from => $from, count => $count, token => $token)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->swipelist(from => $from, count => $count, token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->swipelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipesave**
> swipesave(unknown_base_type => $unknown_base_type)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->swipesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->swipesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipesaveanonym**
> swipesaveanonym(unknown_base_type => $unknown_base_type)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->swipesaveanonym(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->swipesaveanonym: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tagdelete**
> tagdelete(token => $token, id => $id)

Delete a tag

Allows the user to delete an existing tag.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the tag to delete.

eval { 
    $api_instance->tagdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->tagdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the tag to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tagget**
> tagget(token => $token, id => $id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the tag to get.

eval { 
    $api_instance->tagget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->tagget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the tag to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **taglist**
> taglist(token => $token, group => $group, from => $from, count => $count)

View a list of tags

Allows the user to view the list of tags.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $group = "group_example"; # string | The group of the tags to return.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->taglist(token => $token, group => $group, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->taglist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | **string**| The group of the tags to return. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **taglistgroups**
> taglistgroups(token => $token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->taglistgroups(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->taglistgroups: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tagsave**
> tagsave(unknown_base_type => $unknown_base_type)

Create or edit a tag

Allows the user to create or edit a tag.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->tagsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->tagsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tagsearch**
> tagsearch(token => $token, query => $query, allowcreatingnew => $allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $query = "query_example"; # string | The query to search tags. Use group:<group> to search in a specific group (mandatory).
my $allowcreatingnew = null; # boolean | Specifies whether an option to create a new tag should be retrieved.

eval { 
    $api_instance->tagsearch(token => $token, query => $query, allowcreatingnew => $allowcreatingnew);
};
if ($@) {
    warn "Exception when calling DefaultApi->tagsearch: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | **string**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **allowcreatingnew** | **boolean**| Specifies whether an option to create a new tag should be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templateaddimage**
> templateaddimage(token => $token, template => $template, upload => $upload, filename => $filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $template = null; # string | The id of the template where the image has to be added
my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The local name of the uploaded file. For later reference.

eval { 
    $api_instance->templateaddimage(token => $token, template => $template, upload => $upload, filename => $filename);
};
if ($@) {
    warn "Exception when calling DefaultApi->templateaddimage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **template** | [**string**](.md)| The id of the template where the image has to be added | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatedelete**
> templatedelete(token => $token, id => $id)

Delete a template

Allows the user to delete an existing template.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the template to delete.

eval { 
    $api_instance->templatedelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->templatedelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the template to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templateemail**
> templateemail(token => $token, jobid => $jobid, emailsubject => $emailsubject, emailbody => $emailbody, templatekind => $templatekind, emailfrom => $emailfrom, emailreplyto => $emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $jobid = "jobid_example"; # string | The id of the job that is creating the templates.
my $emailsubject = "emailsubject_example"; # string | Args depending on the send-to flag.
my $emailbody = "emailbody_example"; # string | Args depending on the send-to flag.
my $templatekind = "templatekind_example"; # string | The kind of the template you're sending. It must be included in (badge, certificate).
my $emailfrom = "emailfrom_example"; # string | The name of the sender to be displayed in the receipients inbox
my $emailreplyto = "emailreplyto_example"; # string | The reply-to field for the emails.

eval { 
    $api_instance->templateemail(token => $token, jobid => $jobid, emailsubject => $emailsubject, emailbody => $emailbody, templatekind => $templatekind, emailfrom => $emailfrom, emailreplyto => $emailreplyto);
};
if ($@) {
    warn "Exception when calling DefaultApi->templateemail: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **jobid** | **string**| The id of the job that is creating the templates. | 
 **emailsubject** | **string**| Args depending on the send-to flag. | 
 **emailbody** | **string**| Args depending on the send-to flag. | 
 **templatekind** | **string**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional] 
 **emailfrom** | **string**| The name of the sender to be displayed in the receipients inbox | [optional] 
 **emailreplyto** | **string**| The reply-to field for the emails. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templategenerate**
> templategenerate(token => $token, template => $template, source => $source, singlefile => $singlefile, userid => $userid, forsending => $forsending, role => $role, filters => $filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $template = null; # string | The id of the template to generate.
my $source = null; # string | The source key of the selected template data source.
my $singlefile = null; # boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
my $userid = "userid_example"; # string | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
my $forsending = null; # boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
my $role = null; # string | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
my $filters = "filters_example"; # string | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...

eval { 
    $api_instance->templategenerate(token => $token, template => $template, source => $source, singlefile => $singlefile, userid => $userid, forsending => $forsending, role => $role, filters => $filters);
};
if ($@) {
    warn "Exception when calling DefaultApi->templategenerate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **template** | [**string**](.md)| The id of the template to generate. | 
 **source** | [**string**](.md)| The source key of the selected template data source. | 
 **singlefile** | **boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **string**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**string**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **string**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templateget**
> templateget(token => $token, id => $id)

View details of a template

Allows the user to view a template and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the template to get.

eval { 
    $api_instance->templateget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->templateget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the template to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templategetgenerated**
> templategetgenerated(token => $token, jobid => $jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $jobid = "jobid_example"; # string | The id of the job that is creating the templates.

eval { 
    $api_instance->templategetgenerated(token => $token, jobid => $jobid);
};
if ($@) {
    warn "Exception when calling DefaultApi->templategetgenerated: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **jobid** | **string**| The id of the job that is creating the templates. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatelist**
> templatelist(token => $token, from => $from, count => $count, kind => $kind, designedonly => $designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $kind = "kind_example"; # string | The kind of the templates to return. It must be included in (badge, certificate).
my $designedonly = null; # boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.

eval { 
    $api_instance->templatelist(token => $token, from => $from, count => $count, kind => $kind, designedonly => $designedonly);
};
if ($@) {
    warn "Exception when calling DefaultApi->templatelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatelistsources**
> templatelistsources(token => $token, kind => $kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $kind = "kind_example"; # string | The kind of the templates to return. It must be included in (badge, certificate).

eval { 
    $api_instance->templatelistsources(token => $token, kind => $kind);
};
if ($@) {
    warn "Exception when calling DefaultApi->templatelistsources: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatesave**
> templatesave(unknown_base_type => $unknown_base_type)

Create or edit a template

Allows the user to create or edit a template.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->templatesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->templatesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatesavelayout**
> templatesavelayout(unknown_base_type => $unknown_base_type)

Save the layout of a template

Allows the user to edit a template's layout.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->templatesavelayout(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->templatesavelayout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termdelete**
> termdelete(token => $token, id => $id)

Delete a term

Allows the user to delete a term from the existing list.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the term to delete.

eval { 
    $api_instance->termdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->termdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the term to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termget**
> termget(token => $token, id => $id)

Search and view details of a term

Allows the user to view a term and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the term to get.

eval { 
    $api_instance->termget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->termget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the term to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termlist**
> termlist(token => $token, from => $from, count => $count, notpast => $notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $notpast = null; # boolean | Specifies whether the terms in the past should be returned or not.

eval { 
    $api_instance->termlist(token => $token, from => $from, count => $count, notpast => $notpast);
};
if ($@) {
    warn "Exception when calling DefaultApi->termlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 
 **notpast** | **boolean**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termsave**
> termsave(unknown_base_type => $unknown_base_type)

Create and edit terms

Allows the user to create and edit terms.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->termsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->termsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **textcreditremaining**
> textcreditremaining(token => $token)

Gets the remaining text credits for the account

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->textcreditremaining(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->textcreditremaining: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **texttoimage**
> texttoimage(token => $token, text => $text, fontcolor => $fontcolor, fontsize => $fontsize, direction => $direction, width => $width)

Generates a dynamic image from text

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $text = "text_example"; # string | The text to convert to an image, use double pipes (||) as a new line.
my $fontcolor = "fontcolor_example"; # string | The color of the text, in hex format, without the #.
my $fontsize = 56; # int | The size of the text, in points.
my $direction = "direction_example"; # string | Either vertical or horizontal, default horizontal.
my $width = 56; # int | The image width in pixels (or height if the direction is vertical).

eval { 
    $api_instance->texttoimage(token => $token, text => $text, fontcolor => $fontcolor, fontsize => $fontsize, direction => $direction, width => $width);
};
if ($@) {
    warn "Exception when calling DefaultApi->texttoimage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **text** | **string**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **string**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **int**| The size of the text, in points. | [optional] 
 **direction** | **string**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **int**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translationget**
> translationget(token => $token, universal => $universal)

Gets the translations of the specified values

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $universal = "universal_example"; # string | Pipe separated list of universal text to be translated.

eval { 
    $api_instance->translationget(token => $token, universal => $universal);
};
if ($@) {
    warn "Exception when calling DefaultApi->translationget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **universal** | **string**| Pipe separated list of universal text to be translated. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translationgetcachefile**
> translationgetcachefile(token => $token, account => $account)

Get the file containing the translations

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $account = "account_example"; # string | The id of the account whose translations file has to be retrieved.

eval { 
    $api_instance->translationgetcachefile(token => $token, account => $account);
};
if ($@) {
    warn "Exception when calling DefaultApi->translationgetcachefile: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional] 
 **account** | **string**| The id of the account whose translations file has to be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translationlist**
> translationlist(token => $token, filter => $filter, nondefaultonly => $nondefaultonly, appdefaultasuniversal => $appdefaultasuniversal)

Lists all the available translations in the system

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $filter = "filter_example"; # string | Text to search/filter translations.
my $nondefaultonly = null; # boolean | If true then it returns only the terms translated. Otherwise, it returns all.
my $appdefaultasuniversal = null; # boolean | If true then it uses the app default translation as the universal term.

eval { 
    $api_instance->translationlist(token => $token, filter => $filter, nondefaultonly => $nondefaultonly, appdefaultasuniversal => $appdefaultasuniversal);
};
if ($@) {
    warn "Exception when calling DefaultApi->translationlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **filter** | **string**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **boolean**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **boolean**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translationsave**
> translationsave(unknown_base_type => $unknown_base_type)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->translationsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->translationsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userchangepwd**
> userchangepwd(token => $token, oldpass => $oldpass, newpass => $newpass)

Change user's own password

Allows the user to change their own password.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $oldpass = null; # string | The old password of the authenticated user.
my $newpass = null; # string | The new password of the authenticated user.

eval { 
    $api_instance->userchangepwd(token => $token, oldpass => $oldpass, newpass => $newpass);
};
if ($@) {
    warn "Exception when calling DefaultApi->userchangepwd: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **oldpass** | [**string**](.md)| The old password of the authenticated user. | 
 **newpass** | [**string**](.md)| The new password of the authenticated user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userchangepwdbyreq**
> userchangepwdbyreq(changereq => $changereq, newpass => $newpass)

Changes the user password using a change password request id

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $changereq = "changereq_example"; # string | The change password request ID sent by email to the user.
my $newpass = "newpass_example"; # string | The new password of the user.

eval { 
    $api_instance->userchangepwdbyreq(changereq => $changereq, newpass => $newpass);
};
if ($@) {
    warn "Exception when calling DefaultApi->userchangepwdbyreq: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **string**| The change password request ID sent by email to the user. | 
 **newpass** | **string**| The new password of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userdelete**
> userdelete(token => $token, id => $id)

Delete a user

Allows the user to delete a user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the user to delete.

eval { 
    $api_instance->userdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->userdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the user to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userfindsimilar**
> userfindsimilar(token => $token, currentid => $currentid, phonenumber => $phonenumber, cardnumber => $cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $currentid = null; # string | The id of the current user.
my $phonenumber = "phonenumber_example"; # string | A phone number to search for similar users.
my $cardnumber = "cardnumber_example"; # string | A card number to search for similar users.

eval { 
    $api_instance->userfindsimilar(token => $token, currentid => $currentid, phonenumber => $phonenumber, cardnumber => $cardnumber);
};
if ($@) {
    warn "Exception when calling DefaultApi->userfindsimilar: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **currentid** | [**string**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **string**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **string**| A card number to search for similar users. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userget**
> userget(token => $token, id => $id, photosize => $photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the user to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->userget(token => $token, id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->userget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the user to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergetbycard**
> usergetbycard(token => $token, card => $card, photosize => $photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $card = "card_example"; # string | The card number of the user to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->usergetbycard(token => $token, card => $card, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergetbycard: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **card** | **string**| The card number of the user to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupaddmember**
> usergroupaddmember(token => $token, userid => $userid, groupid => $groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to add.
my $groupid = null; # string | The id of the group.

eval { 
    $api_instance->usergroupaddmember(token => $token, userid => $userid, groupid => $groupid);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergroupaddmember: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to add. | 
 **groupid** | [**string**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupdelete**
> usergroupdelete(token => $token, id => $id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the group to delete.

eval { 
    $api_instance->usergroupdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergroupdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the group to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupget**
> usergroupget(token => $token, id => $id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the user group to get.

eval { 
    $api_instance->usergroupget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergroupget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupgetmembers**
> usergroupgetmembers(token => $token, groupid => $groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $groupid = null; # string | The id of the user group to get.

eval { 
    $api_instance->usergroupgetmembers(token => $token, groupid => $groupid);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergroupgetmembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **groupid** | [**string**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupgetuser**
> usergroupgetuser(token => $token, userid => $userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to get his groups.

eval { 
    $api_instance->usergroupgetuser(token => $token, userid => $userid);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergroupgetuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to get his groups. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergrouplist**
> usergrouplist(token => $token, from => $from, count => $count, type => $type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $type = "type_example"; # string | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.

eval { 
    $api_instance->usergrouplist(token => $token, from => $from, count => $count, type => $type);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergrouplist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 
 **type** | **string**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergrouprefresh**
> usergrouprefresh(token => $token, group => $group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $group = null; # string | The ID of the group to refresh.

eval { 
    $api_instance->usergrouprefresh(token => $token, group => $group);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergrouprefresh: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | [**string**](.md)| The ID of the group to refresh. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupremovemember**
> usergroupremovemember(token => $token, userid => $userid, groupid => $groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $userid = null; # string | The id of the user to remove.
my $groupid = null; # string | The id of the group.

eval { 
    $api_instance->usergroupremovemember(token => $token, userid => $userid, groupid => $groupid);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergroupremovemember: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **groupid** | [**string**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupsave**
> usergroupsave(unknown_base_type => $unknown_base_type)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usergroupsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergroupsave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergrouptagmembers**
> usergrouptagmembers(token => $token, group => $group, tags => $tags)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $group = null; # string | The id of the group to save whose members have to be tagged.
my $tags = "tags_example"; # string | The tags to assign to the members of the specified group, in JSON format.

eval { 
    $api_instance->usergrouptagmembers(token => $token, group => $group, tags => $tags);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergrouptagmembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | [**string**](.md)| The id of the group to save whose members have to be tagged. | 
 **tags** | **string**| The tags to assign to the members of the specified group, in JSON format. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupuntagmembers**
> usergroupuntagmembers(token => $token, group => $group, tags => $tags)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $group = null; # string | The id of the group to save whose members have to be untagged.
my $tags = "tags_example"; # string | The tags to unassign from the members of the specified group, in JSON format.

eval { 
    $api_instance->usergroupuntagmembers(token => $token, group => $group, tags => $tags);
};
if ($@) {
    warn "Exception when calling DefaultApi->usergroupuntagmembers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | [**string**](.md)| The id of the group to save whose members have to be untagged. | 
 **tags** | **string**| The tags to unassign from the members of the specified group, in JSON format. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userlist**
> userlist(token => $token, from => $from, count => $count, roleid => $roleid, onlywithoutcard => $onlywithoutcard, photosize => $photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $roleid = null; # string | The id of the role to filter users by, or empty to return all users.
my $onlywithoutcard = "onlywithoutcard_example"; # string | If is 1 then only the users without a card are returned, otherwise all users are returned.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->userlist(token => $token, from => $from, count => $count, roleid => $roleid, onlywithoutcard => $onlywithoutcard, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->userlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **roleid** | [**string**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userloadphoto**
> userloadphoto(token => $token, upload => $upload, filename => $filename, userid => $userid, automatch => $automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The local name of the uploaded file. For later reference.
my $userid = null; # string | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
my $automatch = null; # boolean | Set this to true to find the specific user based on the file name. 

eval { 
    $api_instance->userloadphoto(token => $token, upload => $upload, filename => $filename, userid => $userid, automatch => $automatch);
};
if ($@) {
    warn "Exception when calling DefaultApi->userloadphoto: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**string**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **boolean**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usermovedata**
> usermovedata(token => $token, source => $source, destination => $destination)

Move data between users

Allows administrators to move data between users.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $source = null; # string | The id of the user that is the source of the data.
my $destination = null; # string | The id of the user that is the destination of the data.

eval { 
    $api_instance->usermovedata(token => $token, source => $source, destination => $destination);
};
if ($@) {
    warn "Exception when calling DefaultApi->usermovedata: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **source** | [**string**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**string**](.md)| The id of the user that is the destination of the data. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofiledelete**
> userprofiledelete(token => $token, id => $id)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the user profile to delete.

eval { 
    $api_instance->userprofiledelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->userprofiledelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the user profile to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofileget**
> userprofileget(token => $token, id => $id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the profile question set.

eval { 
    $api_instance->userprofileget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->userprofileget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the profile question set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofilegetallview**
> userprofilegetallview(token => $token, id => $id)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the user to view, or empty for current user.

eval { 
    $api_instance->userprofilegetallview(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->userprofilegetallview: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the user to view, or empty for current user. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofilelist**
> userprofilelist(token => $token, from => $from, count => $count)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->userprofilelist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->userprofilelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofilelistquestions**
> userprofilelistquestions(token => $token)

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->userprofilelistquestions(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->userprofilelistquestions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofilepreparestats**
> userprofilepreparestats(token => $token, params => $params)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $params = "params_example"; # string | The ID of the group, specified as 'group=...'

eval { 
    $api_instance->userprofilepreparestats(token => $token, params => $params);
};
if ($@) {
    warn "Exception when calling DefaultApi->userprofilepreparestats: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **params** | **string**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofilesave**
> userprofilesave(unknown_base_type => $unknown_base_type)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->userprofilesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->userprofilesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userprofilesaveanswers**
> userprofilesaveanswers(unknown_base_type => $unknown_base_type)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->userprofilesaveanswers(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->userprofilesaveanswers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userrequestpwdchange**
> userrequestpwdchange(domain => $domain, email => $email)

Requests a password change

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $domain = "domain_example"; # string | The domain of the account where the user exists.
my $email = "email_example"; # string | The email of the user.

eval { 
    $api_instance->userrequestpwdchange(domain => $domain, email => $email);
};
if ($@) {
    warn "Exception when calling DefaultApi->userrequestpwdchange: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The domain of the account where the user exists. | 
 **email** | **string**| The email of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersave**
> usersave(unknown_base_type => $unknown_base_type)

Create or edit a user

Allows the user to create or edit a user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usersave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->usersave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersavepwdchange**
> usersavepwdchange(unknown_base_type => $unknown_base_type)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usersavepwdchange(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->usersavepwdchange: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettingsget**
> usersettingsget(token => $token, keys => $keys, user => $user)

Lists available user settings

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $keys = "keys_example"; # string | Setting key to get. Can be multiple separated by commas.
my $user = null; # string | The user id whose settings have to be returned.

eval { 
    $api_instance->usersettingsget(token => $token, keys => $keys, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->usersettingsget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**string**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettingsgetmultiple**
> usersettingsgetmultiple(token => $token, keys => $keys, user => $user)

Get multiple user settings

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $keys = "keys_example"; # string | Setting key to get. Can be multiple separated by commas.
my $user = null; # string | The user id whose settings have to be returned.

eval { 
    $api_instance->usersettingsgetmultiple(token => $token, keys => $keys, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->usersettingsgetmultiple: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**string**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettingssave**
> usersettingssave(unknown_base_type => $unknown_base_type)

Saves a user setting

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usersettingssave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->usersettingssave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettingssavemultiple**
> usersettingssavemultiple(unknown_base_type => $unknown_base_type)

Save multiple user settings at once

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usersettingssavemultiple(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->usersettingssavemultiple: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **version**
> version(token => $token)

Get current version information

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->version(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->version: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **virtuallineaddmyself**
> virtuallineaddmyself(token => $token, waitinglineid => $waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $waitinglineid = null; # string | ID of the waiting line to join.

eval { 
    $api_instance->virtuallineaddmyself(token => $token, waitinglineid => $waitinglineid);
};
if ($@) {
    warn "Exception when calling DefaultApi->virtuallineaddmyself: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **waitinglineid** | [**string**](.md)| ID of the waiting line to join. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **virtuallinelist**
> virtuallinelist(token => $token)

Lists waiting lines that have remote access enabled

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->virtuallinelist(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->virtuallinelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **virtuallineremovemyself**
> virtuallineremovemyself(token => $token)

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.

eval { 
    $api_instance->virtuallineremovemyself(token => $token);
};
if ($@) {
    warn "Exception when calling DefaultApi->virtuallineremovemyself: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitinglineadduser**
> waitinglineadduser(station => $station, user => $user, locationid => $locationid, time => $time, signinrole => $signinrole, roleid => $roleid, services => $services, eventid => $eventid, staff => $staff, photosize => $photosize)

Put user in a waiting line

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station.
my $user = "user_example"; # string | The user's card number.
my $locationid = null; # string | The location's id where the swipe must be saved.
my $time = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time of the swipe.
my $signinrole = "signinrole_example"; # string | Specifies if the sign-in is for an attendee or a staff member
my $roleid = null; # string | Specifies the role the user has selected in order to sign-in
my $services = "services_example"; # string | The services ids the user has selected.
my $eventid = null; # string | The id of the event the user selected.
my $staff = null; # string | The id of the staff member the user selected.
my $photosize = 56; # int | The swiping user's photo size.

eval { 
    $api_instance->waitinglineadduser(station => $station, user => $user, locationid => $locationid, time => $time, signinrole => $signinrole, roleid => $roleid, services => $services, eventid => $eventid, staff => $staff, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->waitinglineadduser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station. | 
 **user** | **string**| The user&#39;s card number. | 
 **locationid** | [**string**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **DateTime**| The date and time of the swipe. | [optional] 
 **signinrole** | **string**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**string**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **string**| The services ids the user has selected. | [optional] 
 **eventid** | [**string**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**string**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitinglinedelete**
> waitinglinedelete(token => $token, id => $id)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the line to delete.

eval { 
    $api_instance->waitinglinedelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->waitinglinedelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the line to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitinglineget**
> waitinglineget(token => $token, id => $id, photosize => $photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the waiting line to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->waitinglineget(token => $token, id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->waitinglineget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the waiting line to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitinglineisuserin**
> waitinglineisuserin(station => $station, time => $time, user => $user, location => $location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $station = null; # string | The id of the sign-in station.
my $time = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time of the swipe.
my $user = "user_example"; # string | The card number of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->waitinglineisuserin(station => $station, time => $time, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling DefaultApi->waitinglineisuserin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station. | 
 **time** | **DateTime**| The date and time of the swipe. | 
 **user** | **string**| The card number of the user. | 
 **location** | [**string**](.md)| The id of the location the user picked. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitinglinelist**
> waitinglinelist(token => $token, from => $from, count => $count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->waitinglinelist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->waitinglinelist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitinglineremoveuser**
> waitinglineremoveuser(token => $token, waitingline => $waitingline, itemid => $itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $waitingline = null; # string | The id of the waiting line whose item has to be removed.
my $itemid = null; # string | The ID of the item that has to be removed.

eval { 
    $api_instance->waitinglineremoveuser(token => $token, waitingline => $waitingline, itemid => $itemid);
};
if ($@) {
    warn "Exception when calling DefaultApi->waitinglineremoveuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **waitingline** | [**string**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**string**](.md)| The ID of the item that has to be removed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitinglinesave**
> waitinglinesave(unknown_base_type => $unknown_base_type)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->waitinglinesave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->waitinglinesave: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitinglinesigninuser**
> waitinglinesigninuser(token => $token, waitingline => $waitingline, itemid => $itemid, staff => $staff, photosize => $photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $waitingline = null; # string | The id of the waiting line whose item needs to be signed-in.
my $itemid = null; # string | The ID of the item that has to be signed-in.
my $staff = null; # string | The id of the staff member selected to sign-in.
my $photosize = 56; # int | The swiping user's photo size.

eval { 
    $api_instance->waitinglinesigninuser(token => $token, waitingline => $waitingline, itemid => $itemid, staff => $staff, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling DefaultApi->waitinglinesigninuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **waitingline** | [**string**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**string**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**string**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

