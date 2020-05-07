# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *https://accucampus.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Actionassignmentdelete**](DefaultApi.md#actionassignmentdelete) | **GET** /actionassignmentdelete | Remove an action item from an action plan
[**Actionassignmentget**](DefaultApi.md#actionassignmentget) | **GET** /actionassignmentget | Search and view details of an action item assigned to a user
[**Actionassignmentlist**](DefaultApi.md#actionassignmentlist) | **GET** /actionassignmentlist | View a list of action items in a user&#39;s plan
[**Actionassignmentlisthistory**](DefaultApi.md#actionassignmentlisthistory) | **GET** /actionassignmentlisthistory | View the history of an action item assigned to a user
[**Actionassignmentlistmine**](DefaultApi.md#actionassignmentlistmine) | **GET** /actionassignmentlistmine | List public action assignments assigned to the logged user
[**Actionassignmentlistpublichistory**](DefaultApi.md#actionassignmentlistpublichistory) | **GET** /actionassignmentlistpublichistory | List public action assignment history
[**Actionassignmentmarkcomplete**](DefaultApi.md#actionassignmentmarkcomplete) | **GET** /actionassignmentmarkcomplete | Bulk complete action items
[**Actionassignmentsave**](DefaultApi.md#actionassignmentsave) | **POST** /actionassignmentsave | Add an action item to a user&#39;s action plan
[**Actionassignmentsavehistory**](DefaultApi.md#actionassignmentsavehistory) | **POST** /actionassignmentsavehistory | Update an action item assigned to a user
[**Actionitemdelete**](DefaultApi.md#actionitemdelete) | **GET** /actionitemdelete | Delete an action item
[**Actionitemget**](DefaultApi.md#actionitemget) | **GET** /actionitemget | Search and view details of an action item
[**Actionitemlist**](DefaultApi.md#actionitemlist) | **GET** /actionitemlist | View a list of action items
[**Actionitemsave**](DefaultApi.md#actionitemsave) | **POST** /actionitemsave | Create or edit an action item
[**Actionloglist**](DefaultApi.md#actionloglist) | **GET** /actionloglist | View a list of users action logs
[**Actionpackassign**](DefaultApi.md#actionpackassign) | **GET** /actionpackassign | Assign an action item pack to a user
[**Actionpackdelete**](DefaultApi.md#actionpackdelete) | **GET** /actionpackdelete | Delete an action item pack
[**Actionpackget**](DefaultApi.md#actionpackget) | **GET** /actionpackget | View details of an action item pack
[**Actionpacklist**](DefaultApi.md#actionpacklist) | **GET** /actionpacklist | View a list of action item packs
[**Actionpacksave**](DefaultApi.md#actionpacksave) | **POST** /actionpacksave | Create or edit an action item pack
[**Actiontypedelete**](DefaultApi.md#actiontypedelete) | **GET** /actiontypedelete | Delete an action item type
[**Actiontypeget**](DefaultApi.md#actiontypeget) | **GET** /actiontypeget | View details of an action item type
[**Actiontypelist**](DefaultApi.md#actiontypelist) | **GET** /actiontypelist | View a list of action item types
[**Actiontypesave**](DefaultApi.md#actiontypesave) | **POST** /actiontypesave | Create or edit an action item type
[**Adhocquerycheckexecution**](DefaultApi.md#adhocquerycheckexecution) | **GET** /adhocquerycheckexecution | Check the status of an ad hoc query execution
[**Adhocquerydelete**](DefaultApi.md#adhocquerydelete) | **GET** /adhocquerydelete | Delete an ad hoc query
[**Adhocqueryexecute**](DefaultApi.md#adhocqueryexecute) | **GET** /adhocqueryexecute | Execute an ad hoc query
[**Adhocqueryget**](DefaultApi.md#adhocqueryget) | **GET** /adhocqueryget | View details of an ad hoc query
[**Adhocquerygetschema**](DefaultApi.md#adhocquerygetschema) | **GET** /adhocquerygetschema | View the database schema for making ad hoc queries
[**Adhocquerylist**](DefaultApi.md#adhocquerylist) | **GET** /adhocquerylist | View a list of saved ad hoc queries
[**Adhocquerylistexecutions**](DefaultApi.md#adhocquerylistexecutions) | **GET** /adhocquerylistexecutions | View a list of ad hoc queries executions
[**Adhocquerysave**](DefaultApi.md#adhocquerysave) | **POST** /adhocquerysave | Create or edit an ad hoc query
[**Adhocquerystopexecution**](DefaultApi.md#adhocquerystopexecution) | **GET** /adhocquerystopexecution | Stops the execution of an ad hoc query
[**Adhocreportsreqaccess**](DefaultApi.md#adhocreportsreqaccess) | **GET** /adhocreportsreqaccess | Request access to the ad-hoc reports
[**Advancedstationcheckunknownuser**](DefaultApi.md#advancedstationcheckunknownuser) | **GET** /advancedstationcheckunknownuser | Check whether the user is known by the system.
[**Advancedstationcheckuserrole**](DefaultApi.md#advancedstationcheckuserrole) | **GET** /advancedstationcheckuserrole | Check whether the user is a staff member, an attendee or both.
[**Advancedstationcreateuser**](DefaultApi.md#advancedstationcreateuser) | **GET** /advancedstationcreateuser | Creates a user via a sign-in station.
[**Advancedstationgetevents**](DefaultApi.md#advancedstationgetevents) | **GET** /advancedstationgetevents | Gets the courses available for a specific location and a specific student.
[**Advancedstationgetinfo**](DefaultApi.md#advancedstationgetinfo) | **GET** /advancedstationgetinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**Advancedstationgetlocations**](DefaultApi.md#advancedstationgetlocations) | **GET** /advancedstationgetlocations | Gets the locations available in a sign-in station.
[**Advancedstationgetlogstaff**](DefaultApi.md#advancedstationgetlogstaff) | **GET** /advancedstationgetlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**Advancedstationgetroles**](DefaultApi.md#advancedstationgetroles) | **GET** /advancedstationgetroles | Gets the user roles of the user trying to sign-in.
[**Advancedstationgetservices**](DefaultApi.md#advancedstationgetservices) | **GET** /advancedstationgetservices | Gets the services available for a specific location.
[**Advancedstationgetstaff**](DefaultApi.md#advancedstationgetstaff) | **GET** /advancedstationgetstaff | Gets the staff/tutors available for a specific location, course and service.
[**Advancedstationissignedin**](DefaultApi.md#advancedstationissignedin) | **GET** /advancedstationissignedin | Gets whether a user is signed-in or not.
[**Advroleaddmissing**](DefaultApi.md#advroleaddmissing) | **GET** /advroleaddmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**Advrolecheckperm**](DefaultApi.md#advrolecheckperm) | **GET** /advrolecheckperm | Checks the permissions are assigned for the given roles
[**Advroledelete**](DefaultApi.md#advroledelete) | **GET** /advroledelete | Delete a role
[**Advroledeletemapping**](DefaultApi.md#advroledeletemapping) | **GET** /advroledeletemapping | Delete a role mapping
[**Advroleget**](DefaultApi.md#advroleget) | **GET** /advroleget | View details of a role
[**Advrolelist**](DefaultApi.md#advrolelist) | **GET** /advrolelist | Lists the roles for the current account
[**Advrolelistmaps**](DefaultApi.md#advrolelistmaps) | **GET** /advrolelistmaps | Lists the maps a roles is mapped to
[**Advrolelistrolesmapped**](DefaultApi.md#advrolelistrolesmapped) | **GET** /advrolelistrolesmapped | Lists the roles mappings
[**Advrolelisttemplates**](DefaultApi.md#advrolelisttemplates) | **GET** /advrolelisttemplates | View a list of role templates
[**Advrolesave**](DefaultApi.md#advrolesave) | **POST** /advrolesave | Create or edit a role
[**Advrolesavemapping**](DefaultApi.md#advrolesavemapping) | **POST** /advrolesavemapping | Saves a role mapping
[**Advrolesuserlist**](DefaultApi.md#advrolesuserlist) | **GET** /advrolesuserlist | List users. Alias to user.list, use that one instead.
[**Advroleuserupgrade**](DefaultApi.md#advroleuserupgrade) | **GET** /advroleuserupgrade | Upgrade a user to another role (requires permission to edit those roles)
[**Appointmentcancel**](DefaultApi.md#appointmentcancel) | **GET** /appointmentcancel | Cancel an appointment
[**Appointmentcheckisvalid**](DefaultApi.md#appointmentcheckisvalid) | **GET** /appointmentcheckisvalid | Check if an appointment is valid or not
[**Appointmenteditanyway**](DefaultApi.md#appointmenteditanyway) | **GET** /appointmenteditanyway | Edit an appointment even if it breaks activated rules
[**Appointmenteditpresence**](DefaultApi.md#appointmenteditpresence) | **GET** /appointmenteditpresence | Edit the no-show status of an appointment
[**Appointmentfindallstaffslots**](DefaultApi.md#appointmentfindallstaffslots) | **GET** /appointmentfindallstaffslots | Finds all staff available slots filtered by service, date, etc
[**Appointmentfindslots**](DefaultApi.md#appointmentfindslots) | **GET** /appointmentfindslots | Finds available slots filtered by service, date, staff, etc
[**Appointmentfindstaff**](DefaultApi.md#appointmentfindstaff) | **GET** /appointmentfindstaff | Finds staff available by service, date, event, etc
[**Appointmentget**](DefaultApi.md#appointmentget) | **GET** /appointmentget | Search and view details of an appointment
[**Appointmentgetcurrent**](DefaultApi.md#appointmentgetcurrent) | **GET** /appointmentgetcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**Appointmentgetlocations**](DefaultApi.md#appointmentgetlocations) | **GET** /appointmentgetlocations | Find locations where a service is available
[**Appointmentlist**](DefaultApi.md#appointmentlist) | **GET** /appointmentlist | View a list of appointments
[**Appointmentlistmine**](DefaultApi.md#appointmentlistmine) | **GET** /appointmentlistmine | View all my upcoming appointments
[**Appointmentlistupcoming**](DefaultApi.md#appointmentlistupcoming) | **GET** /appointmentlistupcoming | Search and view details of all my upcoming appointments
[**Appointmentrescheduleoutlook**](DefaultApi.md#appointmentrescheduleoutlook) | **GET** /appointmentrescheduleoutlook | Reschedule an appointment from MS Outlook.
[**Appointmentrestore**](DefaultApi.md#appointmentrestore) | **GET** /appointmentrestore | Restore an appointment
[**Appointmentrestoreanyway**](DefaultApi.md#appointmentrestoreanyway) | **GET** /appointmentrestoreanyway | Restore an appointment even if it breaks activated rules
[**Appointmentsave**](DefaultApi.md#appointmentsave) | **POST** /appointmentsave | Schedule an appointment
[**Appointmentsetasvalid**](DefaultApi.md#appointmentsetasvalid) | **GET** /appointmentsetasvalid | Schedule an appointment even if it breaks activated rules
[**Appointmentsuggestlocations**](DefaultApi.md#appointmentsuggestlocations) | **GET** /appointmentsuggestlocations | View the locations with most appointments
[**Appointmentsuggestservices**](DefaultApi.md#appointmentsuggestservices) | **GET** /appointmentsuggestservices | View the services with most appointments
[**Appointmentvoid**](DefaultApi.md#appointmentvoid) | **GET** /appointmentvoid | Void an appointment
[**Appsharegetphone**](DefaultApi.md#appsharegetphone) | **GET** /appsharegetphone | Gets the phone number of the current user
[**Appsharesendtext**](DefaultApi.md#appsharesendtext) | **GET** /appsharesendtext | Sends an SMS with the link to the app
[**Attendancelogcommentdelete**](DefaultApi.md#attendancelogcommentdelete) | **GET** /attendancelogcommentdelete | Delete a comment on an attendance log
[**Attendancelogcommentget**](DefaultApi.md#attendancelogcommentget) | **GET** /attendancelogcommentget | View a comment on an attendance log
[**Attendancelogcommentlist**](DefaultApi.md#attendancelogcommentlist) | **GET** /attendancelogcommentlist | View all the comments on a specific attendance log
[**Attendancelogcommentsave**](DefaultApi.md#attendancelogcommentsave) | **POST** /attendancelogcommentsave | Save a comment on an attendance log
[**Attendancelogdelete**](DefaultApi.md#attendancelogdelete) | **GET** /attendancelogdelete | Delete an attendance log
[**Attendancelogget**](DefaultApi.md#attendancelogget) | **GET** /attendancelogget | Search and view details of an attendance log
[**Attendanceloggetchangehistory**](DefaultApi.md#attendanceloggetchangehistory) | **GET** /attendanceloggetchangehistory | Search and view details of an attendance log&#39;s swipe history
[**Attendanceloglist**](DefaultApi.md#attendanceloglist) | **GET** /attendanceloglist | View a list of attendance logs
[**Attendanceloglistmine**](DefaultApi.md#attendanceloglistmine) | **GET** /attendanceloglistmine | Gets the attendance logs of the current user
[**Attendancelogliststaff**](DefaultApi.md#attendancelogliststaff) | **GET** /attendancelogliststaff | Gets the attendance logs that the current user is involved in as staff
[**Attendancelogsave**](DefaultApi.md#attendancelogsave) | **POST** /attendancelogsave | Create or edit an attendance log
[**Attendancelogsignout**](DefaultApi.md#attendancelogsignout) | **GET** /attendancelogsignout | Sign out an attendance log
[**Attendancelogwhosin**](DefaultApi.md#attendancelogwhosin) | **GET** /attendancelogwhosin | View who&#39;s in a location
[**Attendancerestrictiondelete**](DefaultApi.md#attendancerestrictiondelete) | **GET** /attendancerestrictiondelete | Delete an attendance restriction
[**Attendancerestrictionget**](DefaultApi.md#attendancerestrictionget) | **GET** /attendancerestrictionget | View details of an attendance restriction
[**Attendancerestrictionlist**](DefaultApi.md#attendancerestrictionlist) | **GET** /attendancerestrictionlist | View a list of attendance restrictions
[**Attendancerestrictionsave**](DefaultApi.md#attendancerestrictionsave) | **POST** /attendancerestrictionsave | Create or edit an attendance restriction
[**Beacondelete**](DefaultApi.md#beacondelete) | **GET** /beacondelete | Delete a beacon profile
[**Beacondisable**](DefaultApi.md#beacondisable) | **GET** /beacondisable | Disable beacon support account wide
[**Beaconget**](DefaultApi.md#beaconget) | **GET** /beaconget | View details of a beacon profile
[**Beacongetlocations**](DefaultApi.md#beacongetlocations) | **GET** /beacongetlocations | Get the sign-in stations assigned to specific beacons.
[**Beacongetstationlocation**](DefaultApi.md#beacongetstationlocation) | **GET** /beacongetstationlocation | Get the location settings in the specified sign-in station.
[**Beacongetuuid**](DefaultApi.md#beacongetuuid) | **GET** /beacongetuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**Beaconlist**](DefaultApi.md#beaconlist) | **GET** /beaconlist | View a list of beacon profiles
[**Beaconlistprofiles**](DefaultApi.md#beaconlistprofiles) | **GET** /beaconlistprofiles | View a list of beacon profiles with their characteristics
[**Beaconresetuuid**](DefaultApi.md#beaconresetuuid) | **GET** /beaconresetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**Beaconsave**](DefaultApi.md#beaconsave) | **POST** /beaconsave | Create or edit a beacon profile
[**Beaconscanlocations**](DefaultApi.md#beaconscanlocations) | **GET** /beaconscanlocations | Check if there&#39;s location available to sign-in / out.
[**Beaconsetuuid**](DefaultApi.md#beaconsetuuid) | **GET** /beaconsetuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**Beaconsilentregions**](DefaultApi.md#beaconsilentregions) | **GET** /beaconsilentregions | View all the beacon regions defined for silent tracking
[**Beaconsilentsignin**](DefaultApi.md#beaconsilentsignin) | **GET** /beaconsilentsignin | Sign-in silently from the location specified by a beacon
[**Beaconsilentsignout**](DefaultApi.md#beaconsilentsignout) | **GET** /beaconsilentsignout | Sign-out silently from the location specified by a beacon
[**Bgjobgetstatus**](DefaultApi.md#bgjobgetstatus) | **GET** /bgjobgetstatus | Get background job status
[**Captchagetchallenge**](DefaultApi.md#captchagetchallenge) | **GET** /captchagetchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**Captchagetimage**](DefaultApi.md#captchagetimage) | **GET** /captchagetimage | Gets a captcha image that the user must complete to do certain requests.
[**Changelog**](DefaultApi.md#changelog) | **GET** /changelog | Get the application change log
[**Clientget**](DefaultApi.md#clientget) | **GET** /clientget | Get client
[**Clientlist**](DefaultApi.md#clientlist) | **GET** /clientlist | Gets the clients of the specified conference
[**Clientsave**](DefaultApi.md#clientsave) | **POST** /clientsave | Saves a client
[**Clientsendmessage**](DefaultApi.md#clientsendmessage) | **GET** /clientsendmessage | Send a message to a client
[**Communityinvite**](DefaultApi.md#communityinvite) | **GET** /communityinvite | Sends an invitation to everyone to AccuCampus Communities
[**Communityjoin**](DefaultApi.md#communityjoin) | **GET** /communityjoin | Sends an invitation for myself to AccuCampus Communities
[**Compasscategorydelete**](DefaultApi.md#compasscategorydelete) | **GET** /compasscategorydelete | Delete a compass category
[**Compasscategoryget**](DefaultApi.md#compasscategoryget) | **GET** /compasscategoryget | View details of a compass category
[**Compasscategorylist**](DefaultApi.md#compasscategorylist) | **GET** /compasscategorylist | View a list of compass categories
[**Compasscategorysave**](DefaultApi.md#compasscategorysave) | **POST** /compasscategorysave | Create or edit a compass category
[**Compassservicelist**](DefaultApi.md#compassservicelist) | **GET** /compassservicelist | View all the services added to the compass
[**Compassservicelistlocations**](DefaultApi.md#compassservicelistlocations) | **GET** /compassservicelistlocations | View all the locations where a service added to the compass is available
[**Computerlabdeletecomputer**](DefaultApi.md#computerlabdeletecomputer) | **GET** /computerlabdeletecomputer | Delete a computer
[**Computerlabgetcomputer**](DefaultApi.md#computerlabgetcomputer) | **GET** /computerlabgetcomputer | Search and view details of a computer
[**Computerlabgetsettings**](DefaultApi.md#computerlabgetsettings) | **GET** /computerlabgetsettings | Loads the settings for a computer lab
[**Computerlabissignedin**](DefaultApi.md#computerlabissignedin) | **GET** /computerlabissignedin | Gets whether a user is signed-in or not.
[**Computerlablistcomputers**](DefaultApi.md#computerlablistcomputers) | **GET** /computerlablistcomputers | View a list of computers
[**Computerlablistlabs**](DefaultApi.md#computerlablistlabs) | **GET** /computerlablistlabs | View a list of the locations that use the Computer Lab add-on
[**Computerlabliststations**](DefaultApi.md#computerlabliststations) | **GET** /computerlabliststations | View a list of sign-in stations available for computer labs.
[**Computerlabsavecomputer**](DefaultApi.md#computerlabsavecomputer) | **POST** /computerlabsavecomputer | Create or edit a computer
[**Computerlabsavesettings**](DefaultApi.md#computerlabsavesettings) | **POST** /computerlabsavesettings | Saves the settings for a computer lab
[**Computerlabsaveswipe**](DefaultApi.md#computerlabsaveswipe) | **POST** /computerlabsaveswipe | Save a new swipe from a computer in a computer lab.
[**Deadendrecordingdelete**](DefaultApi.md#deadendrecordingdelete) | **GET** /deadendrecordingdelete | Deletes a dead-end record group
[**Deadendrecordinglist**](DefaultApi.md#deadendrecordinglist) | **GET** /deadendrecordinglist | Lists the recorded dead ends, if enabled
[**Deadendrecordinglistcomments**](DefaultApi.md#deadendrecordinglistcomments) | **GET** /deadendrecordinglistcomments | Lists the comments for a specific dead end
[**Deadendrecordingsave**](DefaultApi.md#deadendrecordingsave) | **POST** /deadendrecordingsave | Saves a dead-end record
[**Departmentdelete**](DefaultApi.md#departmentdelete) | **GET** /departmentdelete | Delete a college department
[**Departmentget**](DefaultApi.md#departmentget) | **GET** /departmentget | Search and view details of a college department
[**Departmentlist**](DefaultApi.md#departmentlist) | **GET** /departmentlist | View a list of college departments
[**Departmentsave**](DefaultApi.md#departmentsave) | **POST** /departmentsave | Create or edit a college department
[**Doc**](DefaultApi.md#doc) | **GET** /doc | Get the documentation
[**Easyloginaddbgimage**](DefaultApi.md#easyloginaddbgimage) | **GET** /easyloginaddbgimage | Adds background image for the login
[**Eventchecksessions**](DefaultApi.md#eventchecksessions) | **GET** /eventchecksessions | Edit an event&#39;s sessions according to their schedule
[**Eventdelete**](DefaultApi.md#eventdelete) | **GET** /eventdelete | Delete a course
[**Eventget**](DefaultApi.md#eventget) | **GET** /eventget | Search and view details of a course
[**Eventgetsessionsbydate**](DefaultApi.md#eventgetsessionsbydate) | **GET** /eventgetsessionsbydate | View a list of courses by date
[**Eventlist**](DefaultApi.md#eventlist) | **GET** /eventlist | View a list of courses
[**Eventlistregistered**](DefaultApi.md#eventlistregistered) | **GET** /eventlistregistered | View a list of courses I am registered to
[**Eventregaddme**](DefaultApi.md#eventregaddme) | **GET** /eventregaddme | Register current user to a course
[**Eventregaddmetoall**](DefaultApi.md#eventregaddmetoall) | **GET** /eventregaddmetoall | Register current user to all courses
[**Eventregaddmetogroup**](DefaultApi.md#eventregaddmetogroup) | **GET** /eventregaddmetogroup | Register current user to a course group
[**Eventregadduser**](DefaultApi.md#eventregadduser) | **GET** /eventregadduser | Register a user to a course for attendance
[**Eventregaddusertoall**](DefaultApi.md#eventregaddusertoall) | **GET** /eventregaddusertoall | Register a user to assist with all courses
[**Eventregaddusertogroup**](DefaultApi.md#eventregaddusertogroup) | **GET** /eventregaddusertogroup | Register a user to an course group
[**Eventreggetevents**](DefaultApi.md#eventreggetevents) | **GET** /eventreggetevents | View course registration by user
[**Eventreggetgroups**](DefaultApi.md#eventreggetgroups) | **GET** /eventreggetgroups | Lists the course group registrations of a user
[**Eventreggetmyevents**](DefaultApi.md#eventreggetmyevents) | **GET** /eventreggetmyevents | View the event registrations of the current user
[**Eventreggetmygroups**](DefaultApi.md#eventreggetmygroups) | **GET** /eventreggetmygroups | View all current user registrations to course groups
[**Eventreggetusers**](DefaultApi.md#eventreggetusers) | **GET** /eventreggetusers | View course registration
[**Eventreggetusersfromgroup**](DefaultApi.md#eventreggetusersfromgroup) | **GET** /eventreggetusersfromgroup | Lists the registrations for a course group
[**Eventreggetuserstoall**](DefaultApi.md#eventreggetuserstoall) | **GET** /eventreggetuserstoall | View the users that are registered to all courses
[**Eventregremoveme**](DefaultApi.md#eventregremoveme) | **GET** /eventregremoveme | Unregister current user from a course
[**Eventregremovemefromall**](DefaultApi.md#eventregremovemefromall) | **GET** /eventregremovemefromall | Remove current user from the registration to all courses
[**Eventregremovemefromgroup**](DefaultApi.md#eventregremovemefromgroup) | **GET** /eventregremovemefromgroup | Remove current user from a course group
[**Eventregremoveuser**](DefaultApi.md#eventregremoveuser) | **GET** /eventregremoveuser | Remove a user from a course
[**Eventregremoveuserfromall**](DefaultApi.md#eventregremoveuserfromall) | **GET** /eventregremoveuserfromall | Remove a user from the registration to all courses
[**Eventregremoveuserfromgroup**](DefaultApi.md#eventregremoveuserfromgroup) | **GET** /eventregremoveuserfromgroup | Remove a user from a course group
[**Eventsave**](DefaultApi.md#eventsave) | **POST** /eventsave | Create or edit a course
[**Eventsearchgroup**](DefaultApi.md#eventsearchgroup) | **GET** /eventsearchgroup | Searches for the available event groups
[**Export**](DefaultApi.md#export) | **GET** /export | Export AccuCampus data
[**Exportlisttypes**](DefaultApi.md#exportlisttypes) | **GET** /exportlisttypes | Lists available export types
[**Featurelist**](DefaultApi.md#featurelist) | **GET** /featurelist | Lists the available features.
[**Holidaylist**](DefaultApi.md#holidaylist) | **GET** /holidaylist | View a list of entered holidays
[**Holidaysave**](DefaultApi.md#holidaysave) | **POST** /holidaysave | Create or edit a list of holidays
[**Holidaysuggest**](DefaultApi.md#holidaysuggest) | **GET** /holidaysuggest | View the holiday suggestions in the given term
[**Import**](DefaultApi.md#import) | **GET** /import | Import data into AccuCampus
[**Importlisttypes**](DefaultApi.md#importlisttypes) | **GET** /importlisttypes | Lists available import types
[**Interactiondelete**](DefaultApi.md#interactiondelete) | **GET** /interactiondelete | Delete an interaction
[**Interactionfeed**](DefaultApi.md#interactionfeed) | **GET** /interactionfeed | Get the interactions feed
[**Interactionget**](DefaultApi.md#interactionget) | **GET** /interactionget | View an interaction
[**Interactionlistprivatesummary**](DefaultApi.md#interactionlistprivatesummary) | **GET** /interactionlistprivatesummary | Get current user&#39;s latest private interactions
[**Interactionsave**](DefaultApi.md#interactionsave) | **POST** /interactionsave | Save an interaction
[**Licenseacceptagreement**](DefaultApi.md#licenseacceptagreement) | **GET** /licenseacceptagreement | Accept the license agreement
[**Licensegetagreementstatus**](DefaultApi.md#licensegetagreementstatus) | **GET** /licensegetagreementstatus | Check if license agreement has been accepted
[**Licensegetcurrent**](DefaultApi.md#licensegetcurrent) | **GET** /licensegetcurrent | Gets the current license information
[**Licenserenew**](DefaultApi.md#licenserenew) | **GET** /licenserenew | Contact Engineerica in order to renew the AccuCampus subscription
[**Likedelete**](DefaultApi.md#likedelete) | **GET** /likedelete | Delete a like
[**Likelist**](DefaultApi.md#likelist) | **GET** /likelist | View all the likes associated to a target
[**Likesave**](DefaultApi.md#likesave) | **POST** /likesave | Save a like
[**Listtimezones**](DefaultApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**Locationdelete**](DefaultApi.md#locationdelete) | **GET** /locationdelete | Delete a location
[**Locationget**](DefaultApi.md#locationget) | **GET** /locationget | Search and view details of a location
[**Locationlist**](DefaultApi.md#locationlist) | **GET** /locationlist | View a list of locations
[**Locationsave**](DefaultApi.md#locationsave) | **POST** /locationsave | Create or edit a location
[**Login**](DefaultApi.md#login) | **GET** /login | Login
[**Logout**](DefaultApi.md#logout) | **GET** /logout | Logout
[**Mediacheckin**](DefaultApi.md#mediacheckin) | **GET** /mediacheckin | Check in media item
[**Mediacheckout**](DefaultApi.md#mediacheckout) | **GET** /mediacheckout | Check out media item
[**Mediacheckoutlist**](DefaultApi.md#mediacheckoutlist) | **GET** /mediacheckoutlist | View a list of past media checkouts
[**Mediadelete**](DefaultApi.md#mediadelete) | **GET** /mediadelete | Delete a media item
[**Mediadeletecheckoutlog**](DefaultApi.md#mediadeletecheckoutlog) | **GET** /mediadeletecheckoutlog | Delete a media checkout log
[**Mediaget**](DefaultApi.md#mediaget) | **GET** /mediaget | Search and view details of a media item
[**Mediagetbycode**](DefaultApi.md#mediagetbycode) | **GET** /mediagetbycode | Search media item by unique code
[**Mediagetcheckout**](DefaultApi.md#mediagetcheckout) | **GET** /mediagetcheckout | View details of a media item checkout information
[**Mediagetcheckoutlog**](DefaultApi.md#mediagetcheckoutlog) | **GET** /mediagetcheckoutlog | View details of a media checkout log
[**Medialist**](DefaultApi.md#medialist) | **GET** /medialist | View a list of media items
[**Mediasave**](DefaultApi.md#mediasave) | **POST** /mediasave | Create or edit a media item
[**Mediatypedelete**](DefaultApi.md#mediatypedelete) | **GET** /mediatypedelete | Delete a media type
[**Mediatypeget**](DefaultApi.md#mediatypeget) | **GET** /mediatypeget | Search and view details of a media type
[**Mediatypelist**](DefaultApi.md#mediatypelist) | **GET** /mediatypelist | View a list of media types
[**Mediatypesave**](DefaultApi.md#mediatypesave) | **POST** /mediatypesave | Create or edit a media type
[**Memorizedreportdelete**](DefaultApi.md#memorizedreportdelete) | **GET** /memorizedreportdelete | Delete memorized report
[**Memorizedreportget**](DefaultApi.md#memorizedreportget) | **GET** /memorizedreportget | View details of a memorized report
[**Memorizedreportlist**](DefaultApi.md#memorizedreportlist) | **GET** /memorizedreportlist | View a list of all his memorized reports
[**Memorizedreportsave**](DefaultApi.md#memorizedreportsave) | **POST** /memorizedreportsave | Create or edit a memorized report
[**Menugetitems**](DefaultApi.md#menugetitems) | **GET** /menugetitems | Gets the items on the menu
[**Myaccount**](DefaultApi.md#myaccount) | **GET** /myaccount | Gets the logged in user account.
[**Myianatimezone**](DefaultApi.md#myianatimezone) | **GET** /myianatimezone | Gets the current time zone&#39;s iana name
[**Myprofile**](DefaultApi.md#myprofile) | **GET** /myprofile | Gets the logged in user information.
[**Myrights**](DefaultApi.md#myrights) | **GET** /myrights | Gets the list of actions the user can execute.
[**Mysaveprofile**](DefaultApi.md#mysaveprofile) | **POST** /mysaveprofile | Updates logged user&#39;s profile information
[**Notificationdelete**](DefaultApi.md#notificationdelete) | **GET** /notificationdelete | Delete a notification
[**Notificationget**](DefaultApi.md#notificationget) | **GET** /notificationget | View a notification
[**Notificationgetforstation**](DefaultApi.md#notificationgetforstation) | **GET** /notificationgetforstation | Gets all public (in station) notifications for the specific user
[**Notificationgetunreadcount**](DefaultApi.md#notificationgetunreadcount) | **GET** /notificationgetunreadcount | Get the number of unread notifications
[**Notificationlist**](DefaultApi.md#notificationlist) | **GET** /notificationlist | View a list of all sent notifications
[**Notificationlistmine**](DefaultApi.md#notificationlistmine) | **GET** /notificationlistmine | View all the notifications sent to the current user
[**Notificationmarkasread**](DefaultApi.md#notificationmarkasread) | **GET** /notificationmarkasread | Mark a notification as read
[**Notificationmarkasunread**](DefaultApi.md#notificationmarkasunread) | **GET** /notificationmarkasunread | Mark a notification as unread
[**Notificationsend**](DefaultApi.md#notificationsend) | **GET** /notificationsend | Send notifications on screen, via email or text to users
[**Notificationsendonscreen**](DefaultApi.md#notificationsendonscreen) | **GET** /notificationsendonscreen | Send on-screen notifications
[**Notificationtopicdelete**](DefaultApi.md#notificationtopicdelete) | **GET** /notificationtopicdelete | Delete a notification topic
[**Notificationtopicget**](DefaultApi.md#notificationtopicget) | **GET** /notificationtopicget | Search and view details of a notification topic
[**Notificationtopiclist**](DefaultApi.md#notificationtopiclist) | **GET** /notificationtopiclist | List all the notification topics
[**Notificationtopiclistsubscribe**](DefaultApi.md#notificationtopiclistsubscribe) | **GET** /notificationtopiclistsubscribe | List all the notification topics available to subscribe
[**Notificationtopicsave**](DefaultApi.md#notificationtopicsave) | **POST** /notificationtopicsave | Create or edit a notification topic
[**Pushderegister**](DefaultApi.md#pushderegister) | **GET** /pushderegister | Deregisters the current device to receive push notifications
[**Pushregister**](DefaultApi.md#pushregister) | **GET** /pushregister | Registers the current device to receive push notifications
[**Qrlabelsprint**](DefaultApi.md#qrlabelsprint) | **GET** /qrlabelsprint | Print and email QR labels
[**Qrloginget**](DefaultApi.md#qrloginget) | **GET** /qrloginget | Gets an image of a QR token
[**Qrloginlogin**](DefaultApi.md#qrloginlogin) | **GET** /qrloginlogin | Login
[**Quickpaneldeletewidget**](DefaultApi.md#quickpaneldeletewidget) | **GET** /quickpaneldeletewidget | Deletes a widget from the Quick Panel
[**Quickpanelfetchwidget**](DefaultApi.md#quickpanelfetchwidget) | **GET** /quickpanelfetchwidget | Fetches the information for a specific widget.
[**Quickpanelgetwidget**](DefaultApi.md#quickpanelgetwidget) | **GET** /quickpanelgetwidget | View details of a widget included in the Quick Panel
[**Quickpanelinit**](DefaultApi.md#quickpanelinit) | **GET** /quickpanelinit | Returns the initial information required to show the quick panels
[**Quickpanellistwidgets**](DefaultApi.md#quickpanellistwidgets) | **GET** /quickpanellistwidgets | Lists all the widgets that are added in the Quick Panel
[**Quickpanellistwidgettypes**](DefaultApi.md#quickpanellistwidgettypes) | **GET** /quickpanellistwidgettypes | Lists all the widget types available in the system
[**Quickpanelreorderwidgets**](DefaultApi.md#quickpanelreorderwidgets) | **GET** /quickpanelreorderwidgets | Reorders the widgets and moves them to a specific column
[**Quickpanelsavewidget**](DefaultApi.md#quickpanelsavewidget) | **POST** /quickpanelsavewidget | Saves a widget for the Quick Panel
[**Ratingflag**](DefaultApi.md#ratingflag) | **GET** /ratingflag | Flags one rating for moderation
[**Ratingflagcomment**](DefaultApi.md#ratingflagcomment) | **GET** /ratingflagcomment | Flags one comment for moderation
[**Ratingget**](DefaultApi.md#ratingget) | **GET** /ratingget | Get rating for one or more entities
[**Ratinggetall**](DefaultApi.md#ratinggetall) | **GET** /ratinggetall | Gets the full ratings and comments for a specific entity
[**Ratinggetcomments**](DefaultApi.md#ratinggetcomments) | **GET** /ratinggetcomments | Gets all the comments for a rating
[**Ratinggetpending**](DefaultApi.md#ratinggetpending) | **GET** /ratinggetpending | Gets info of pre-saved and pre-approved ratings
[**Ratinggetpendingmoderation**](DefaultApi.md#ratinggetpendingmoderation) | **GET** /ratinggetpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
[**Ratingmoderate**](DefaultApi.md#ratingmoderate) | **GET** /ratingmoderate | Allows the user to accept or reject a comment
[**Ratingpostcomment**](DefaultApi.md#ratingpostcomment) | **GET** /ratingpostcomment | Posts a comments for in a rating
[**Ratingrate**](DefaultApi.md#ratingrate) | **GET** /ratingrate | Rates one entity
[**Ratingratepending**](DefaultApi.md#ratingratepending) | **GET** /ratingratepending | Rates a pre-saved and pre-approved entity
[**Ratingvote**](DefaultApi.md#ratingvote) | **GET** /ratingvote | Votes up or down a rating
[**Reportattanalyticsprepare**](DefaultApi.md#reportattanalyticsprepare) | **GET** /reportattanalyticsprepare | Query and load an attendance analytics report
[**Reportlist**](DefaultApi.md#reportlist) | **GET** /reportlist | View a list of available reports
[**Reportpermissionsbyuser**](DefaultApi.md#reportpermissionsbyuser) | **GET** /reportpermissionsbyuser | Permissions by user report
[**Reportprepare**](DefaultApi.md#reportprepare) | **GET** /reportprepare | Queries and loads the specified report, in background.
[**Reportquery**](DefaultApi.md#reportquery) | **GET** /reportquery | Query and load a specified report
[**Reportscheduledelete**](DefaultApi.md#reportscheduledelete) | **GET** /reportscheduledelete | Delete a report schedule
[**Reportscheduleget**](DefaultApi.md#reportscheduleget) | **GET** /reportscheduleget | Get a report schedule
[**Reportschedulelist**](DefaultApi.md#reportschedulelist) | **GET** /reportschedulelist | View a list of the scheduled reports
[**Reportschedulesave**](DefaultApi.md#reportschedulesave) | **POST** /reportschedulesave | Create or edit a report schedule
[**Reporttagresults**](DefaultApi.md#reporttagresults) | **GET** /reporttagresults | Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
[**Riskmodelcheckanalysis**](DefaultApi.md#riskmodelcheckanalysis) | **GET** /riskmodelcheckanalysis | Check the status of the analysis of a specified risk assessment model
[**Riskmodeldelete**](DefaultApi.md#riskmodeldelete) | **GET** /riskmodeldelete | Delete a risk assessment model
[**Riskmodelget**](DefaultApi.md#riskmodelget) | **GET** /riskmodelget | View details of a risk assessment model
[**Riskmodelgetscore**](DefaultApi.md#riskmodelgetscore) | **GET** /riskmodelgetscore | View the risk score for a specific user
[**Riskmodellist**](DefaultApi.md#riskmodellist) | **GET** /riskmodellist | View a list of risk assessment models
[**Riskmodelpredict**](DefaultApi.md#riskmodelpredict) | **GET** /riskmodelpredict | Predict risk based on an assessment model
[**Riskmodelprocess**](DefaultApi.md#riskmodelprocess) | **GET** /riskmodelprocess | Process a risk assessment model
[**Riskmodelrefresh**](DefaultApi.md#riskmodelrefresh) | **GET** /riskmodelrefresh | Refresh the information used in a risk assessment model
[**Riskmodelsave**](DefaultApi.md#riskmodelsave) | **POST** /riskmodelsave | Create or edit a risk assessment model
[**Riskmodeltermprecedences**](DefaultApi.md#riskmodeltermprecedences) | **GET** /riskmodeltermprecedences | View all default term precedences
[**Rolelist**](DefaultApi.md#rolelist) | **GET** /rolelist | Show a list of roles
[**Ruledelete**](DefaultApi.md#ruledelete) | **GET** /ruledelete | Delete a rule
[**Ruleget**](DefaultApi.md#ruleget) | **GET** /ruleget | View details of a rule
[**Rulegeteventtype**](DefaultApi.md#rulegeteventtype) | **GET** /rulegeteventtype | View details of a rule event type
[**Rulelist**](DefaultApi.md#rulelist) | **GET** /rulelist | View a list of user rules
[**Rulelistactions**](DefaultApi.md#rulelistactions) | **GET** /rulelistactions | View a list of rule actions available
[**Rulelisteventtypes**](DefaultApi.md#rulelisteventtypes) | **GET** /rulelisteventtypes | View a list of rule event types
[**Rulelisthttprequests**](DefaultApi.md#rulelisthttprequests) | **GET** /rulelisthttprequests | View all the http requests sent as a result of a rule
[**Rulesave**](DefaultApi.md#rulesave) | **POST** /rulesave | Create or edit a rule
[**Scheduledelete**](DefaultApi.md#scheduledelete) | **GET** /scheduledelete | Delete a schedule slot
[**Scheduledeletemine**](DefaultApi.md#scheduledeletemine) | **GET** /scheduledeletemine | Delete a specific block from a user&#39;s own schedule
[**Scheduleenable**](DefaultApi.md#scheduleenable) | **GET** /scheduleenable | Enable or disable the schedule for a specific person
[**Scheduleenablemine**](DefaultApi.md#scheduleenablemine) | **GET** /scheduleenablemine | Enable or disable current user&#39;s schedule
[**Schedulefindallstaffslots**](DefaultApi.md#schedulefindallstaffslots) | **GET** /schedulefindallstaffslots | Search available schedule slots by service, event, date
[**Schedulefindslots**](DefaultApi.md#schedulefindslots) | **GET** /schedulefindslots | Search available schedule slots by service, event, date and/or staff
[**Schedulefindstaffavail**](DefaultApi.md#schedulefindstaffavail) | **GET** /schedulefindstaffavail | Search available staff members slots by service, event, and/or date
[**Scheduleget**](DefaultApi.md#scheduleget) | **GET** /scheduleget | Search and view details of a specific schedule slot
[**Schedulegetmine**](DefaultApi.md#schedulegetmine) | **GET** /schedulegetmine | View details of a specific schedule block, for current user
[**Schedulegetstaff**](DefaultApi.md#schedulegetstaff) | **GET** /schedulegetstaff | View a list of schedule information of a specified person
[**Schedulegetstaffmine**](DefaultApi.md#schedulegetstaffmine) | **GET** /schedulegetstaffmine | View current user&#39;s schedule information
[**Scheduleintegrationdeleteitem**](DefaultApi.md#scheduleintegrationdeleteitem) | **GET** /scheduleintegrationdeleteitem | Delete a schedule item looking up by a third party ID
[**Scheduleintegrationdeleteitemsbymasterid**](DefaultApi.md#scheduleintegrationdeleteitemsbymasterid) | **GET** /scheduleintegrationdeleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**Scheduleintegrationgetitem**](DefaultApi.md#scheduleintegrationgetitem) | **GET** /scheduleintegrationgetitem | Get a schedule item looking up by a third party ID
[**Scheduleintegrationsaveitem**](DefaultApi.md#scheduleintegrationsaveitem) | **POST** /scheduleintegrationsaveitem | Save a schedule item looking up by a third party ID
[**Scheduleintegrationsetid**](DefaultApi.md#scheduleintegrationsetid) | **GET** /scheduleintegrationsetid | Set a 3rd party ID on a specific schedule item
[**Schedulemyofftimes**](DefaultApi.md#schedulemyofftimes) | **GET** /schedulemyofftimes | View current user&#39;s schedule exceptions
[**Schedulesave**](DefaultApi.md#schedulesave) | **POST** /schedulesave | Create or edit a schedule slot
[**Schedulesavemine**](DefaultApi.md#schedulesavemine) | **POST** /schedulesavemine | Create or edit a block in current user&#39;s schedule
[**Search**](DefaultApi.md#search) | **GET** /search | Search
[**Searchgetentities**](DefaultApi.md#searchgetentities) | **GET** /searchgetentities | Get the information of the entities that can be searched
[**Securityassesspermission**](DefaultApi.md#securityassesspermission) | **GET** /securityassesspermission | Returns the list of users for a specific permission
[**Securityassessrole**](DefaultApi.md#securityassessrole) | **GET** /securityassessrole | Returns the list of permissions for a specific role
[**Securityassessscope**](DefaultApi.md#securityassessscope) | **GET** /securityassessscope | Returns the list of users for a specific user
[**Securityassessuser**](DefaultApi.md#securityassessuser) | **GET** /securityassessuser | Returns the list of permissions for a specific user
[**Seminardelete**](DefaultApi.md#seminardelete) | **GET** /seminardelete | Delete an event
[**Seminarget**](DefaultApi.md#seminarget) | **GET** /seminarget | Search and view details of a event
[**Seminarlist**](DefaultApi.md#seminarlist) | **GET** /seminarlist | View a list of events
[**Seminarsave**](DefaultApi.md#seminarsave) | **POST** /seminarsave | Create or edit a event
[**Serviceassignmentaddservice**](DefaultApi.md#serviceassignmentaddservice) | **GET** /serviceassignmentaddservice | Enable a service in a specific location
[**Serviceassignmentgetlocation**](DefaultApi.md#serviceassignmentgetlocation) | **GET** /serviceassignmentgetlocation | View a list of services enabled for a specific location
[**Serviceassignmentgetservice**](DefaultApi.md#serviceassignmentgetservice) | **GET** /serviceassignmentgetservice | View a list of locations where a service is available
[**Serviceassignmentremoveservice**](DefaultApi.md#serviceassignmentremoveservice) | **GET** /serviceassignmentremoveservice | Remove a service from a location
[**Servicedelete**](DefaultApi.md#servicedelete) | **GET** /servicedelete | Delete a service
[**Serviceget**](DefaultApi.md#serviceget) | **GET** /serviceget | Search and view details of a service
[**Servicelist**](DefaultApi.md#servicelist) | **GET** /servicelist | View a list of services
[**Servicesave**](DefaultApi.md#servicesave) | **POST** /servicesave | Create or edit a service
[**Sessionattendancelogaddnote**](DefaultApi.md#sessionattendancelogaddnote) | **GET** /sessionattendancelogaddnote | Add a note to a class attendance log
[**Sessionattendancelogget**](DefaultApi.md#sessionattendancelogget) | **GET** /sessionattendancelogget | View details of a class attendance log
[**Sessionattendanceloggetuser**](DefaultApi.md#sessionattendanceloggetuser) | **GET** /sessionattendanceloggetuser | View the class session attendance information for a specific user
[**Sessionattendanceloglist**](DefaultApi.md#sessionattendanceloglist) | **GET** /sessionattendanceloglist | View attendance logs of the specified session
[**Sessionattendanceloglistevent**](DefaultApi.md#sessionattendanceloglistevent) | **GET** /sessionattendanceloglistevent | View the attendance information of an entire class
[**Sessionattendanceloglistsummary**](DefaultApi.md#sessionattendanceloglistsummary) | **GET** /sessionattendanceloglistsummary | View the attendance summary for a class and/or a attendee
[**Sessionattendancelogmylistsummary**](DefaultApi.md#sessionattendancelogmylistsummary) | **GET** /sessionattendancelogmylistsummary | View my attendance summary
[**Sessionattendancelogsave**](DefaultApi.md#sessionattendancelogsave) | **POST** /sessionattendancelogsave | Create or edit a class attendance log
[**Sessionattendancelogsaveswipe**](DefaultApi.md#sessionattendancelogsaveswipe) | **POST** /sessionattendancelogsaveswipe | Create or edit a class attendance log swipe
[**Sessionbulkupdate**](DefaultApi.md#sessionbulkupdate) | **GET** /sessionbulkupdate | Bulk update event sessions
[**Sessionget**](DefaultApi.md#sessionget) | **GET** /sessionget | View details of a session
[**Sessiongetschedule**](DefaultApi.md#sessiongetschedule) | **GET** /sessiongetschedule | Gets the schedule for a location, instructor or attendees
[**Sessionlist**](DefaultApi.md#sessionlist) | **GET** /sessionlist | Gets all future sessions of the current semester
[**Sessionregaddcurrentuser**](DefaultApi.md#sessionregaddcurrentuser) | **GET** /sessionregaddcurrentuser | Register current user to an event session
[**Sessionregadduser**](DefaultApi.md#sessionregadduser) | **GET** /sessionregadduser | Register users for events
[**Sessionreggetmysessions**](DefaultApi.md#sessionreggetmysessions) | **GET** /sessionreggetmysessions | View all the sessions the logged user is registered to
[**Sessionreggetsessions**](DefaultApi.md#sessionreggetsessions) | **GET** /sessionreggetsessions | Lists the registrations for a specific user
[**Sessionreggetsettings**](DefaultApi.md#sessionreggetsettings) | **GET** /sessionreggetsettings | Get the settings for session registration
[**Sessionreggetusers**](DefaultApi.md#sessionreggetusers) | **GET** /sessionreggetusers | Lists the registrations for a specific session
[**Sessionreglistsessions**](DefaultApi.md#sessionreglistsessions) | **GET** /sessionreglistsessions | List the sessions available for a specific event
[**Sessionreglistupcoming**](DefaultApi.md#sessionreglistupcoming) | **GET** /sessionreglistupcoming | View a list of upcoming event sessions
[**Sessionreglistupcomingevent**](DefaultApi.md#sessionreglistupcomingevent) | **GET** /sessionreglistupcomingevent | View a list of upcoming sessions of a particular event
[**Sessionregremovecurrentuser**](DefaultApi.md#sessionregremovecurrentuser) | **GET** /sessionregremovecurrentuser | Unregister current user from an event session
[**Sessionregremoveuser**](DefaultApi.md#sessionregremoveuser) | **GET** /sessionregremoveuser | Removes a user from an event session
[**Sessionregsavesettings**](DefaultApi.md#sessionregsavesettings) | **POST** /sessionregsavesettings | Save the settings for an event&#39;s session registration
[**Sessionswipedelete**](DefaultApi.md#sessionswipedelete) | **GET** /sessionswipedelete | Delete a session swipe
[**Sessionswipeget**](DefaultApi.md#sessionswipeget) | **GET** /sessionswipeget | View details of a class attendance swipe
[**Sessionswipelistunresolved**](DefaultApi.md#sessionswipelistunresolved) | **GET** /sessionswipelistunresolved | View a list of unresolved swipes
[**Sessionswiperesolve**](DefaultApi.md#sessionswiperesolve) | **GET** /sessionswiperesolve | Resolve a swipe and create the corresponding attendance log
[**Sessionswipesave**](DefaultApi.md#sessionswipesave) | **POST** /sessionswipesave | Creates a new swipe, and if possible, creates the attendance log
[**Sessionswipesaveanonym**](DefaultApi.md#sessionswipesaveanonym) | **POST** /sessionswipesaveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
[**Settingaddlogo**](DefaultApi.md#settingaddlogo) | **GET** /settingaddlogo | Add a logo to the account
[**Settingget**](DefaultApi.md#settingget) | **GET** /settingget | Get settings for the account or the specified scope
[**Settingsave**](DefaultApi.md#settingsave) | **POST** /settingsave | Save settings for the account or the specified scope
[**Settingviewgeneral**](DefaultApi.md#settingviewgeneral) | **GET** /settingviewgeneral | View general settings for the account
[**Socialcontacts**](DefaultApi.md#socialcontacts) | **GET** /socialcontacts | Gets the list of contacts in the network
[**Socialgroupaddmembers**](DefaultApi.md#socialgroupaddmembers) | **GET** /socialgroupaddmembers | Adds new members to a group (which the user must own already)
[**Socialgroupdelete**](DefaultApi.md#socialgroupdelete) | **GET** /socialgroupdelete | Deletes a group
[**Socialgrouplist**](DefaultApi.md#socialgrouplist) | **GET** /socialgrouplist | View all the groups the current user is in
[**Socialgrouplistmembers**](DefaultApi.md#socialgrouplistmembers) | **GET** /socialgrouplistmembers | Lists the members of a group
[**Socialgroupremovemembers**](DefaultApi.md#socialgroupremovemembers) | **GET** /socialgroupremovemembers | Removes members from a group (which the user must own already)
[**Socialgroupremovemyself**](DefaultApi.md#socialgroupremovemyself) | **GET** /socialgroupremovemyself | Removes myself from an existent group
[**Socialgroupsave**](DefaultApi.md#socialgroupsave) | **POST** /socialgroupsave | Saves a new group
[**Ssogeneratekey**](DefaultApi.md#ssogeneratekey) | **GET** /ssogeneratekey | Generate/reset single sign on access key.
[**Ssogetsettings**](DefaultApi.md#ssogetsettings) | **GET** /ssogetsettings | View single sign on settings.
[**Ssoissuetoken**](DefaultApi.md#ssoissuetoken) | **GET** /ssoissuetoken | Issue single sign-on token
[**Ssosavesettings**](DefaultApi.md#ssosavesettings) | **POST** /ssosavesettings | Edit single sign-on settings.
[**Staffavailaddmetoallservices**](DefaultApi.md#staffavailaddmetoallservices) | **GET** /staffavailaddmetoallservices | Associate current user to all services
[**Staffavailaddmetoservice**](DefaultApi.md#staffavailaddmetoservice) | **GET** /staffavailaddmetoservice | Associate current user to a service
[**Staffavailaddusertoallservices**](DefaultApi.md#staffavailaddusertoallservices) | **GET** /staffavailaddusertoallservices | Associate a staff member to all services
[**Staffavailaddusertoservice**](DefaultApi.md#staffavailaddusertoservice) | **GET** /staffavailaddusertoservice | Associate a staff member to a service
[**Staffavailgetmyservices**](DefaultApi.md#staffavailgetmyservices) | **GET** /staffavailgetmyservices | View the services the current user is available for
[**Staffavailgetservices**](DefaultApi.md#staffavailgetservices) | **GET** /staffavailgetservices | View a list of services that a staff member is available for
[**Staffavailgetusersforservice**](DefaultApi.md#staffavailgetusersforservice) | **GET** /staffavailgetusersforservice | View a list of staff members that are available for a specific service
[**Staffavaillisttypes**](DefaultApi.md#staffavaillisttypes) | **GET** /staffavaillisttypes | View all the availability types
[**Staffavailremovemefromallservices**](DefaultApi.md#staffavailremovemefromallservices) | **GET** /staffavailremovemefromallservices | Remove current user from all services
[**Staffavailremovemefromservice**](DefaultApi.md#staffavailremovemefromservice) | **GET** /staffavailremovemefromservice | Remove current user from a service
[**Staffavailremoveuserfromallservices**](DefaultApi.md#staffavailremoveuserfromallservices) | **GET** /staffavailremoveuserfromallservices | Removes a staff member from the registration to all services
[**Staffavailremoveuserfromservice**](DefaultApi.md#staffavailremoveuserfromservice) | **GET** /staffavailremoveuserfromservice | Remove a staff member from a service
[**Staffavailsetavailability**](DefaultApi.md#staffavailsetavailability) | **GET** /staffavailsetavailability | Make a staff member available for a specific availability type
[**Staffavailsetmyavailability**](DefaultApi.md#staffavailsetmyavailability) | **GET** /staffavailsetmyavailability | Change current user&#39;s availability type
[**Stationdelete**](DefaultApi.md#stationdelete) | **GET** /stationdelete | Delete a sign-in station
[**Stationget**](DefaultApi.md#stationget) | **GET** /stationget | View details of a sign-in station
[**Stationgetcurrentterms**](DefaultApi.md#stationgetcurrentterms) | **GET** /stationgetcurrentterms | Get all the current terms
[**Stationgetinfo**](DefaultApi.md#stationgetinfo) | **GET** /stationgetinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**Stationgetlicense**](DefaultApi.md#stationgetlicense) | **GET** /stationgetlicense | Gets the current license information
[**Stationgetlocationsettings**](DefaultApi.md#stationgetlocationsettings) | **GET** /stationgetlocationsettings | View the sign-in station settings of a specified location
[**Stationlist**](DefaultApi.md#stationlist) | **GET** /stationlist | View a list of sign-in stations
[**Stationsave**](DefaultApi.md#stationsave) | **POST** /stationsave | Create or edit a sign-in station
[**Stationsavemine**](DefaultApi.md#stationsavemine) | **POST** /stationsavemine | Create or edit a class attendance sign-in station for myself
[**Stationunlock**](DefaultApi.md#stationunlock) | **GET** /stationunlock | Unlocks the sign-in station.
[**Swipedelete**](DefaultApi.md#swipedelete) | **GET** /swipedelete | Delete a swipe
[**Swipeget**](DefaultApi.md#swipeget) | **GET** /swipeget | Search and view details of a swipe
[**Swipelist**](DefaultApi.md#swipelist) | **GET** /swipelist | View a list of swipes
[**Swipesave**](DefaultApi.md#swipesave) | **POST** /swipesave | Create or edit a swipe, and if possible, save the related attendance log
[**Swipesaveanonym**](DefaultApi.md#swipesaveanonym) | **POST** /swipesaveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
[**Tagdelete**](DefaultApi.md#tagdelete) | **GET** /tagdelete | Delete a tag
[**Tagget**](DefaultApi.md#tagget) | **GET** /tagget | View details of a specified tag
[**Taglist**](DefaultApi.md#taglist) | **GET** /taglist | View a list of tags
[**Taglistgroups**](DefaultApi.md#taglistgroups) | **GET** /taglistgroups | View a list of entities that can be tagged
[**Tagsave**](DefaultApi.md#tagsave) | **POST** /tagsave | Create or edit a tag
[**Tagsearch**](DefaultApi.md#tagsearch) | **GET** /tagsearch | Search for tags in the account
[**Templateaddimage**](DefaultApi.md#templateaddimage) | **GET** /templateaddimage | Add an image to a template
[**Templatedelete**](DefaultApi.md#templatedelete) | **GET** /templatedelete | Delete a template
[**Templateemail**](DefaultApi.md#templateemail) | **GET** /templateemail | Send generated templates by email
[**Templategenerate**](DefaultApi.md#templategenerate) | **GET** /templategenerate | Generate specified templates
[**Templateget**](DefaultApi.md#templateget) | **GET** /templateget | View details of a template
[**Templategetgenerated**](DefaultApi.md#templategetgenerated) | **GET** /templategetgenerated | View generated templates
[**Templatelist**](DefaultApi.md#templatelist) | **GET** /templatelist | View a list of defined templates
[**Templatelistsources**](DefaultApi.md#templatelistsources) | **GET** /templatelistsources | View a list of templates&#39; data sources
[**Templatesave**](DefaultApi.md#templatesave) | **POST** /templatesave | Create or edit a template
[**Templatesavelayout**](DefaultApi.md#templatesavelayout) | **POST** /templatesavelayout | Save the layout of a template
[**Termdelete**](DefaultApi.md#termdelete) | **GET** /termdelete | Delete a term
[**Termget**](DefaultApi.md#termget) | **GET** /termget | Search and view details of a term
[**Termlist**](DefaultApi.md#termlist) | **GET** /termlist | Search and view details of all terms
[**Termsave**](DefaultApi.md#termsave) | **POST** /termsave | Create and edit terms
[**Textcreditremaining**](DefaultApi.md#textcreditremaining) | **GET** /textcreditremaining | Gets the remaining text credits for the account
[**Texttoimage**](DefaultApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
[**Translationget**](DefaultApi.md#translationget) | **GET** /translationget | Gets the translations of the specified values
[**Translationgetcachefile**](DefaultApi.md#translationgetcachefile) | **GET** /translationgetcachefile | Get the file containing the translations
[**Translationlist**](DefaultApi.md#translationlist) | **GET** /translationlist | Lists all the available translations in the system
[**Translationsave**](DefaultApi.md#translationsave) | **POST** /translationsave | Edit a translation
[**Userchangepwd**](DefaultApi.md#userchangepwd) | **GET** /userchangepwd | Change user&#39;s own password
[**Userchangepwdbyreq**](DefaultApi.md#userchangepwdbyreq) | **GET** /userchangepwdbyreq | Changes the user password using a change password request id
[**Userdelete**](DefaultApi.md#userdelete) | **GET** /userdelete | Delete a user
[**Userfindsimilar**](DefaultApi.md#userfindsimilar) | **GET** /userfindsimilar | Finds similar users to prevent duplicates
[**Userget**](DefaultApi.md#userget) | **GET** /userget | Search and view details of a user
[**Usergetbycard**](DefaultApi.md#usergetbycard) | **GET** /usergetbycard | Search user by card number
[**Usergroupaddmember**](DefaultApi.md#usergroupaddmember) | **GET** /usergroupaddmember | Add a user to a group
[**Usergroupdelete**](DefaultApi.md#usergroupdelete) | **GET** /usergroupdelete | Delete a group
[**Usergroupget**](DefaultApi.md#usergroupget) | **GET** /usergroupget | Search and view details of a user group
[**Usergroupgetmembers**](DefaultApi.md#usergroupgetmembers) | **GET** /usergroupgetmembers | View the members of a user group
[**Usergroupgetuser**](DefaultApi.md#usergroupgetuser) | **GET** /usergroupgetuser | View the groups which a user is registered to
[**Usergrouplist**](DefaultApi.md#usergrouplist) | **GET** /usergrouplist | View a list of user groups
[**Usergrouprefresh**](DefaultApi.md#usergrouprefresh) | **GET** /usergrouprefresh | Refresh the dynamic group
[**Usergroupremovemember**](DefaultApi.md#usergroupremovemember) | **GET** /usergroupremovemember | Remove a user from a group
[**Usergroupsave**](DefaultApi.md#usergroupsave) | **POST** /usergroupsave | Create or edit a group
[**Usergrouptagmembers**](DefaultApi.md#usergrouptagmembers) | **GET** /usergrouptagmembers | Assign tags to the members of a specified group
[**Usergroupuntagmembers**](DefaultApi.md#usergroupuntagmembers) | **GET** /usergroupuntagmembers | Unassign tags from the members of a specified group
[**Userlist**](DefaultApi.md#userlist) | **GET** /userlist | View a list of users
[**Userloadphoto**](DefaultApi.md#userloadphoto) | **GET** /userloadphoto | Upload a photo for a specific user
[**Usermovedata**](DefaultApi.md#usermovedata) | **GET** /usermovedata | Move data between users
[**Userprofiledelete**](DefaultApi.md#userprofiledelete) | **GET** /userprofiledelete | Delete a user profile
[**Userprofileget**](DefaultApi.md#userprofileget) | **GET** /userprofileget | View a specific user profile
[**Userprofilegetallview**](DefaultApi.md#userprofilegetallview) | **GET** /userprofilegetallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
[**Userprofilelist**](DefaultApi.md#userprofilelist) | **GET** /userprofilelist | View the list of user profiles
[**Userprofilelistquestions**](DefaultApi.md#userprofilelistquestions) | **GET** /userprofilelistquestions | Gets the list of all the available user questions
[**Userprofilepreparestats**](DefaultApi.md#userprofilepreparestats) | **GET** /userprofilepreparestats | Gets the statistics of a user group
[**Userprofilesave**](DefaultApi.md#userprofilesave) | **POST** /userprofilesave | Create or edit user profile questions
[**Userprofilesaveanswers**](DefaultApi.md#userprofilesaveanswers) | **POST** /userprofilesaveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
[**Userrequestpwdchange**](DefaultApi.md#userrequestpwdchange) | **GET** /userrequestpwdchange | Requests a password change
[**Usersave**](DefaultApi.md#usersave) | **POST** /usersave | Create or edit a user
[**Usersavepwdchange**](DefaultApi.md#usersavepwdchange) | **POST** /usersavepwdchange | Send email to the specified user(s) to set/change their passwords
[**Usersettingsget**](DefaultApi.md#usersettingsget) | **GET** /usersettingsget | Lists available user settings
[**Usersettingsgetmultiple**](DefaultApi.md#usersettingsgetmultiple) | **GET** /usersettingsgetmultiple | Get multiple user settings
[**Usersettingssave**](DefaultApi.md#usersettingssave) | **POST** /usersettingssave | Saves a user setting
[**Usersettingssavemultiple**](DefaultApi.md#usersettingssavemultiple) | **POST** /usersettingssavemultiple | Save multiple user settings at once
[**Version**](DefaultApi.md#version) | **GET** /version | Get current version information
[**Virtuallineaddmyself**](DefaultApi.md#virtuallineaddmyself) | **GET** /virtuallineaddmyself | Add myself to a waiting line
[**Virtuallinelist**](DefaultApi.md#virtuallinelist) | **GET** /virtuallinelist | Lists waiting lines that have remote access enabled
[**Virtuallineremovemyself**](DefaultApi.md#virtuallineremovemyself) | **GET** /virtuallineremovemyself | Remove myself from a waiting line
[**Waitinglineadduser**](DefaultApi.md#waitinglineadduser) | **GET** /waitinglineadduser | Put user in a waiting line
[**Waitinglinedelete**](DefaultApi.md#waitinglinedelete) | **GET** /waitinglinedelete | Delete a waiting line
[**Waitinglineget**](DefaultApi.md#waitinglineget) | **GET** /waitinglineget | View details of a waiting line
[**Waitinglineisuserin**](DefaultApi.md#waitinglineisuserin) | **GET** /waitinglineisuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**Waitinglinelist**](DefaultApi.md#waitinglinelist) | **GET** /waitinglinelist | View a list of waiting lines
[**Waitinglineremoveuser**](DefaultApi.md#waitinglineremoveuser) | **GET** /waitinglineremoveuser | Remove a user from a waiting line
[**Waitinglinesave**](DefaultApi.md#waitinglinesave) | **POST** /waitinglinesave | Create or edit a waiting line
[**Waitinglinesigninuser**](DefaultApi.md#waitinglinesigninuser) | **GET** /waitinglinesigninuser | Sign a user in from a waiting line


<a name="actionassignmentdelete"></a>
# **Actionassignmentdelete**
> void Actionassignmentdelete (string token, Guid? id)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the action assignment to delete.

            try
            {
                // Remove an action item from an action plan
                apiInstance.Actionassignmentdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the action assignment to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentget"></a>
# **Actionassignmentget**
> void Actionassignmentget (string token, Guid? id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the action assignment to get.

            try
            {
                // Search and view details of an action item assigned to a user
                apiInstance.Actionassignmentget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the action assignment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentlist"></a>
# **Actionassignmentlist**
> void Actionassignmentlist (string token, int? from, int? count, int? assignee, int? status)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var assignee = 56;  // int? | The assignee's id to filter the assignments. (optional) 
            var status = 56;  // int? | The status to filter the assignments. (optional) 

            try
            {
                // View a list of action items in a user's plan
                apiInstance.Actionassignmentlist(token, from, count, assignee, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **assignee** | **int?**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **int?**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentlisthistory"></a>
# **Actionassignmentlisthistory**
> void Actionassignmentlisthistory (string token, Guid? actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentlisthistoryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var actionassignment = new Guid?(); // Guid? | The action assignment's id whose history the user wants to get.

            try
            {
                // View the history of an action item assigned to a user
                apiInstance.Actionassignmentlisthistory(token, actionassignment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentlisthistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **actionassignment** | [**Guid?**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentlistmine"></a>
# **Actionassignmentlistmine**
> void Actionassignmentlistmine (string token, int? from, int? count, int? status)

List public action assignments assigned to the logged user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentlistmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var status = 56;  // int? | The status to filter the assignments. (optional) 

            try
            {
                // List public action assignments assigned to the logged user
                apiInstance.Actionassignmentlistmine(token, from, count, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentlistmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **status** | **int?**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentlistpublichistory"></a>
# **Actionassignmentlistpublichistory**
> void Actionassignmentlistpublichistory (string token, Guid? actionassignment)

List public action assignment history

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentlistpublichistoryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var actionassignment = new Guid?(); // Guid? | The action assignment's id whose history the user wants to get.

            try
            {
                // List public action assignment history
                apiInstance.Actionassignmentlistpublichistory(token, actionassignment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentlistpublichistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **actionassignment** | [**Guid?**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentmarkcomplete"></a>
# **Actionassignmentmarkcomplete**
> void Actionassignmentmarkcomplete (string token, string item, Guid? assignee, Guid? group, string notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentmarkcompleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var item = item_example;  // string | The action item to assign.
            var assignee = new Guid?(); // Guid? | The assignee of the item. (optional) 
            var group = new Guid?(); // Guid? | The group to assing the item. (optional) 
            var notes = notes_example;  // string | The assignment's notes. (optional) 

            try
            {
                // Bulk complete action items
                apiInstance.Actionassignmentmarkcomplete(token, item, assignee, group, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentmarkcomplete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **item** | **string**| The action item to assign. | 
 **assignee** | [**Guid?**](.md)| The assignee of the item. | [optional] 
 **group** | [**Guid?**](.md)| The group to assing the item. | [optional] 
 **notes** | **string**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentsave"></a>
# **Actionassignmentsave**
> void Actionassignmentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Add an action item to a user's action plan
                apiInstance.Actionassignmentsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentsavehistory"></a>
# **Actionassignmentsavehistory**
> void Actionassignmentsavehistory (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentsavehistoryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Update an action item assigned to a user
                apiInstance.Actionassignmentsavehistory(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionassignmentsavehistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionitemdelete"></a>
# **Actionitemdelete**
> void Actionitemdelete (string token, Guid? id)

Delete an action item

Allows the user to delete an action item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionitemdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the action item to delete.

            try
            {
                // Delete an action item
                apiInstance.Actionitemdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionitemdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the action item to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionitemget"></a>
# **Actionitemget**
> void Actionitemget (string token, Guid? id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionitemgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the action item to get.

            try
            {
                // Search and view details of an action item
                apiInstance.Actionitemget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionitemget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the action item to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionitemlist"></a>
# **Actionitemlist**
> void Actionitemlist (string token, int? from, int? count)

View a list of action items

Allows the user to view a list of action items

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionitemlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of action items
                apiInstance.Actionitemlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionitemlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionitemsave"></a>
# **Actionitemsave**
> void Actionitemsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an action item

Allows the user to edit an action item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionitemsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an action item
                apiInstance.Actionitemsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionitemsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionloglist"></a>
# **Actionloglist**
> void Actionloglist (string token, int? from, int? count, Guid? user, DateTime? startdate, DateTime? enddate, string resource, string actionfilter, string argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionloglistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var user = new Guid?(); // Guid? | The id of the user whose action logs have to be returned. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the logs. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the logs. (optional) 
            var resource = resource_example;  // string | The resource to filter the action logs. (optional) 
            var actionfilter = actionfilter_example;  // string | The action to filter the action logs. (optional) 
            var argument = argument_example;  // string | The id of the entity that was the argument of the executed action. (optional) 

            try
            {
                // View a list of users action logs
                apiInstance.Actionloglist(token, from, count, user, startdate, enddate, resource, actionfilter, argument);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionloglist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **user** | [**Guid?**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the logs. | [optional] 
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

<a name="actionpackassign"></a>
# **Actionpackassign**
> void Actionpackassign (string token, Guid? pack, bool? itemsdata, Guid? assignee, Guid? group, string notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpackassignExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var pack = new Guid?(); // Guid? | The id of the action pack to assign.
            var itemsdata = true;  // bool? | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
            var assignee = new Guid?(); // Guid? | The assignee of the pack. (optional) 
            var group = new Guid?(); // Guid? | The group to assign the pack. (optional) 
            var notes = notes_example;  // string | The assignment's notes. (optional) 

            try
            {
                // Assign an action item pack to a user
                apiInstance.Actionpackassign(token, pack, itemsdata, assignee, group, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionpackassign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **pack** | [**Guid?**](.md)| The id of the action pack to assign. | 
 **itemsdata** | **bool?**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **assignee** | [**Guid?**](.md)| The assignee of the pack. | [optional] 
 **group** | [**Guid?**](.md)| The group to assign the pack. | [optional] 
 **notes** | **string**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionpackdelete"></a>
# **Actionpackdelete**
> void Actionpackdelete (string token, Guid? id)

Delete an action item pack

Allows the user to delete an action item pack.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpackdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the action pack to delete.

            try
            {
                // Delete an action item pack
                apiInstance.Actionpackdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionpackdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the action pack to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionpackget"></a>
# **Actionpackget**
> void Actionpackget (string token, Guid? id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpackgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the action pack to get.

            try
            {
                // View details of an action item pack
                apiInstance.Actionpackget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionpackget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the action pack to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionpacklist"></a>
# **Actionpacklist**
> void Actionpacklist (string token, int? from, int? count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpacklistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of action item packs
                apiInstance.Actionpacklist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionpacklist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionpacksave"></a>
# **Actionpacksave**
> void Actionpacksave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpacksaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an action item pack
                apiInstance.Actionpacksave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionpacksave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actiontypedelete"></a>
# **Actiontypedelete**
> void Actiontypedelete (string token, Guid? id)

Delete an action item type

Allows the user to delete an action item type.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActiontypedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the action type to delete.

            try
            {
                // Delete an action item type
                apiInstance.Actiontypedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actiontypedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the action type to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actiontypeget"></a>
# **Actiontypeget**
> void Actiontypeget (string token, Guid? id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActiontypegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the action type to get.

            try
            {
                // View details of an action item type
                apiInstance.Actiontypeget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actiontypeget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the action type to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actiontypelist"></a>
# **Actiontypelist**
> void Actiontypelist (string token, int? from, int? count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActiontypelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of action item types
                apiInstance.Actiontypelist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actiontypelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actiontypesave"></a>
# **Actiontypesave**
> void Actiontypesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an action item type

Allows the user to dit an action item type.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActiontypesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an action item type
                apiInstance.Actiontypesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actiontypesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerycheckexecution"></a>
# **Adhocquerycheckexecution**
> void Adhocquerycheckexecution (string token, Guid? id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerycheckexecutionExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the ad hoc query execution to be checked.

            try
            {
                // Check the status of an ad hoc query execution
                apiInstance.Adhocquerycheckexecution(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocquerycheckexecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the ad hoc query execution to be checked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerydelete"></a>
# **Adhocquerydelete**
> void Adhocquerydelete (string token, Guid? id)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerydeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the ad hoc query to delete.

            try
            {
                // Delete an ad hoc query
                apiInstance.Adhocquerydelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocquerydelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the ad hoc query to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocqueryexecute"></a>
# **Adhocqueryexecute**
> void Adhocqueryexecute (string token, Guid? id, string query)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocqueryexecuteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the query to execute. (optional) 
            var query = query_example;  // string | The query to execute. (optional) 

            try
            {
                // Execute an ad hoc query
                apiInstance.Adhocqueryexecute(token, id, query);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocqueryexecute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the query to execute. | [optional] 
 **query** | **string**| The query to execute. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocqueryget"></a>
# **Adhocqueryget**
> void Adhocqueryget (string token, Guid? id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerygetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the query to get.

            try
            {
                // View details of an ad hoc query
                apiInstance.Adhocqueryget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocqueryget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the query to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerygetschema"></a>
# **Adhocquerygetschema**
> void Adhocquerygetschema (string token)

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerygetschemaExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View the database schema for making ad hoc queries
                apiInstance.Adhocquerygetschema(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocquerygetschema: " + e.Message );
            }
        }
    }
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

<a name="adhocquerylist"></a>
# **Adhocquerylist**
> void Adhocquerylist (string token, int? from, int? count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerylistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of saved ad hoc queries
                apiInstance.Adhocquerylist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocquerylist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerylistexecutions"></a>
# **Adhocquerylistexecutions**
> void Adhocquerylistexecutions (string token, int? from, int? count, Guid? query)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerylistexecutionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var query = new Guid?(); // Guid? | The first record to return. (optional) 

            try
            {
                // View a list of ad hoc queries executions
                apiInstance.Adhocquerylistexecutions(token, from, count, query);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocquerylistexecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **query** | [**Guid?**](.md)| The first record to return. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerysave"></a>
# **Adhocquerysave**
> void Adhocquerysave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerysaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an ad hoc query
                apiInstance.Adhocquerysave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocquerysave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocquerystopexecution"></a>
# **Adhocquerystopexecution**
> void Adhocquerystopexecution (string token, Guid? id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocquerystopexecutionExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the ad hoc query execution to be stopped.

            try
            {
                // Stops the execution of an ad hoc query
                apiInstance.Adhocquerystopexecution(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocquerystopexecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the ad hoc query execution to be stopped. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adhocreportsreqaccess"></a>
# **Adhocreportsreqaccess**
> void Adhocreportsreqaccess (string token)

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdhocreportsreqaccessExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Request access to the ad-hoc reports
                apiInstance.Adhocreportsreqaccess(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Adhocreportsreqaccess: " + e.Message );
            }
        }
    }
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

<a name="advancedstationcheckunknownuser"></a>
# **Advancedstationcheckunknownuser**
> void Advancedstationcheckunknownuser (Guid? station, string user, Guid? location)

Check whether the user is known by the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationcheckunknownuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked.

            try
            {
                // Check whether the user is known by the system.
                apiInstance.Advancedstationcheckunknownuser(station, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationcheckunknownuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationcheckuserrole"></a>
# **Advancedstationcheckuserrole**
> void Advancedstationcheckuserrole (Guid? station, string user, Guid? location)

Check whether the user is a staff member, an attendee or both.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationcheckuserroleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked.

            try
            {
                // Check whether the user is a staff member, an attendee or both.
                apiInstance.Advancedstationcheckuserrole(station, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationcheckuserrole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationcreateuser"></a>
# **Advancedstationcreateuser**
> void Advancedstationcreateuser (Guid? station, string user, Guid? location, string firstname, string lastname, string email, string middlename)

Creates a user via a sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationcreateuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user to create.
            var location = new Guid?(); // Guid? | The id of the location the user picked.
            var firstname = firstname_example;  // string | The first name of the user to create.
            var lastname = lastname_example;  // string | The last name of the user to create.
            var email = email_example;  // string | The email of the user to create.
            var middlename = middlename_example;  // string | The middle name of the user to create. (optional) 

            try
            {
                // Creates a user via a sign-in station.
                apiInstance.Advancedstationcreateuser(station, user, location, firstname, lastname, email, middlename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationcreateuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user to create. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | 
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

<a name="advancedstationgetevents"></a>
# **Advancedstationgetevents**
> void Advancedstationgetevents (Guid? station, Guid? location, string user)

Gets the courses available for a specific location and a specific student.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationgeteventsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var location = new Guid?(); // Guid? | The id of the location the student picked.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets the courses available for a specific location and a specific student.
                apiInstance.Advancedstationgetevents(station, location, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationgetevents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **location** | [**Guid?**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetinfo"></a>
# **Advancedstationgetinfo**
> void Advancedstationgetinfo (Guid? id, Guid? _event)

Gets the info to display in the sign-in station by it's ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationgetinfoExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to get.
            var _event = new Guid?(); // Guid? | The id of the event (or session), to override the scheduled one. (optional) 

            try
            {
                // Gets the info to display in the sign-in station by it's ID.
                apiInstance.Advancedstationgetinfo(id, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationgetinfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **_event** | [**Guid?**](.md)| The id of the event (or session), to override the scheduled one. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetlocations"></a>
# **Advancedstationgetlocations**
> void Advancedstationgetlocations (Guid? station, string user)

Gets the locations available in a sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationgetlocationsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station whose locations have to be returned.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets the locations available in a sign-in station.
                apiInstance.Advancedstationgetlocations(station, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationgetlocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station whose locations have to be returned. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetlogstaff"></a>
# **Advancedstationgetlogstaff**
> void Advancedstationgetlogstaff (Guid? station, Guid? attendancelog, int? photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationgetlogstaffExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var attendancelog = new Guid?(); // Guid? | The id of the attendance log to filter the staff members.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
                apiInstance.Advancedstationgetlogstaff(station, attendancelog, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationgetlogstaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **attendancelog** | [**Guid?**](.md)| The id of the attendance log to filter the staff members. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetroles"></a>
# **Advancedstationgetroles**
> void Advancedstationgetroles (Guid? station, string signinrole, string user, Guid? location)

Gets the user roles of the user trying to sign-in.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationgetrolesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var signinrole = signinrole_example;  // string | Specifies how the user is signing-in.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked.

            try
            {
                // Gets the user roles of the user trying to sign-in.
                apiInstance.Advancedstationgetroles(station, signinrole, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationgetroles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **signinrole** | **string**| Specifies how the user is signing-in. | 
 **user** | **string**| The card of the user. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetservices"></a>
# **Advancedstationgetservices**
> void Advancedstationgetservices (Guid? station, Guid? location, string user)

Gets the services available for a specific location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationgetservicesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var location = new Guid?(); // Guid? | The id of the location the student picked.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets the services available for a specific location.
                apiInstance.Advancedstationgetservices(station, location, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationgetservices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **location** | [**Guid?**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationgetstaff"></a>
# **Advancedstationgetstaff**
> void Advancedstationgetstaff (Guid? station, Guid? locationid, string user, string services, Guid? eventid, int? photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationgetstaffExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var locationid = new Guid?(); // Guid? | The id of the location the student picked.
            var user = user_example;  // string | The card of the user.
            var services = services_example;  // string | The list of services selected by the user, in JSON format. (optional) 
            var eventid = new Guid?(); // Guid? | The ID of the event selected. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Gets the staff/tutors available for a specific location, course and service.
                apiInstance.Advancedstationgetstaff(station, locationid, user, services, eventid, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationgetstaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **locationid** | [**Guid?**](.md)| The id of the location the student picked. | 
 **user** | **string**| The card of the user. | 
 **services** | **string**| The list of services selected by the user, in JSON format. | [optional] 
 **eventid** | [**Guid?**](.md)| The ID of the event selected. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advancedstationissignedin"></a>
# **Advancedstationissignedin**
> void Advancedstationissignedin (Guid? station, DateTime? time, string user, Guid? location)

Gets whether a user is signed-in or not.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvancedstationissignedinExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var time = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time of the swipe.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked. (optional) 

            try
            {
                // Gets whether a user is signed-in or not.
                apiInstance.Advancedstationissignedin(station, time, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advancedstationissignedin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **time** | **DateTime?**| The date and time of the swipe. | 
 **user** | **string**| The card of the user. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroleaddmissing"></a>
# **Advroleaddmissing**
> void Advroleaddmissing (string token, string roles, string permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleaddmissingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var roles = roles_example;  // string | CSV list of the role ids to check
            var permissions = permissions_example;  // string | CSV list of the permissions to check

            try
            {
                // Adds the missing permissions to a role. Requires access to advrole.save
                apiInstance.Advroleaddmissing(token, roles, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroleaddmissing: " + e.Message );
            }
        }
    }
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

<a name="advrolecheckperm"></a>
# **Advrolecheckperm**
> void Advrolecheckperm (string token, string roles, string permissions)

Checks the permissions are assigned for the given roles

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolecheckpermExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var roles = roles_example;  // string | CSV list of the role ids to check
            var permissions = permissions_example;  // string | CSV list of the permissions to check

            try
            {
                // Checks the permissions are assigned for the given roles
                apiInstance.Advrolecheckperm(token, roles, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolecheckperm: " + e.Message );
            }
        }
    }
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

<a name="advroledelete"></a>
# **Advroledelete**
> void Advroledelete (string token, Guid? id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroledeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the location to delete.

            try
            {
                // Delete a role
                apiInstance.Advroledelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroledelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the location to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroledeletemapping"></a>
# **Advroledeletemapping**
> void Advroledeletemapping (string token, string map, Guid? roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroledeletemappingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var map = map_example;  // string | The map name to save the role.
            var roleid = new Guid?(); // Guid? | The id of the role.

            try
            {
                // Delete a role mapping
                apiInstance.Advroledeletemapping(token, map, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroledeletemapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **map** | **string**| The map name to save the role. | 
 **roleid** | [**Guid?**](.md)| The id of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroleget"></a>
# **Advroleget**
> void Advroleget (string token, Guid? id)

View details of a role

Allows the user to view a role and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the location to get.

            try
            {
                // View details of a role
                apiInstance.Advroleget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroleget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelist"></a>
# **Advrolelist**
> void Advrolelist (string token, bool? includepolicies, bool? includeinternal, string name)

Lists the roles for the current account

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var includepolicies = true;  // bool? | True to include the policies, defaults to false. (optional) 
            var includeinternal = true;  // bool? | True to include the internal roles too. (optional) 
            var name = name_example;  // string | Filter by name of the role. (optional) 

            try
            {
                // Lists the roles for the current account
                apiInstance.Advrolelist(token, includepolicies, includeinternal, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **includepolicies** | **bool?**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **bool?**| True to include the internal roles too. | [optional] 
 **name** | **string**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelistmaps"></a>
# **Advrolelistmaps**
> void Advrolelistmaps (string token, Guid? roleid)

Lists the maps a roles is mapped to

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolelistmapsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var roleid = new Guid?(); // Guid? | The id of the role to list the maps.

            try
            {
                // Lists the maps a roles is mapped to
                apiInstance.Advrolelistmaps(token, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolelistmaps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **roleid** | [**Guid?**](.md)| The id of the role to list the maps. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelistrolesmapped"></a>
# **Advrolelistrolesmapped**
> void Advrolelistrolesmapped (string token, string map)

Lists the roles mappings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolelistrolesmappedExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var map = map_example;  // string | List only the roles in the specified map. (optional) 

            try
            {
                // Lists the roles mappings
                apiInstance.Advrolelistrolesmapped(token, map);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolelistrolesmapped: " + e.Message );
            }
        }
    }
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

<a name="advrolelisttemplates"></a>
# **Advrolelisttemplates**
> void Advrolelisttemplates (string token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolelisttemplatesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of role templates
                apiInstance.Advrolelisttemplates(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolelisttemplates: " + e.Message );
            }
        }
    }
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

<a name="advrolesave"></a>
# **Advrolesave**
> void Advrolesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a role
                apiInstance.Advrolesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolesavemapping"></a>
# **Advrolesavemapping**
> void Advrolesavemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolesavemappingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a role mapping
                apiInstance.Advrolesavemapping(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolesavemapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolesuserlist"></a>
# **Advrolesuserlist**
> void Advrolesuserlist (string token, int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)

List users. Alias to user.list, use that one instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolesuserlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var roleid = new Guid?(); // Guid? | The id of the role to filter users by, or empty to return all users. (optional) 
            var onlywithoutcard = onlywithoutcard_example;  // string | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // List users. Alias to user.list, use that one instead.
                apiInstance.Advrolesuserlist(token, from, count, roleid, onlywithoutcard, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolesuserlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **roleid** | [**Guid?**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroleuserupgrade"></a>
# **Advroleuserupgrade**
> void Advroleuserupgrade (string token, Guid? userid, Guid? roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleuserupgradeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | Id of the user to upgrade
            var roleid = new Guid?(); // Guid? | Id of the role to add

            try
            {
                // Upgrade a user to another role (requires permission to edit those roles)
                apiInstance.Advroleuserupgrade(token, userid, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroleuserupgrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| Id of the user to upgrade | 
 **roleid** | [**Guid?**](.md)| Id of the role to add | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentcancel"></a>
# **Appointmentcancel**
> void Appointmentcancel (string token, Guid? id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentcancelExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to cancel.

            try
            {
                // Cancel an appointment
                apiInstance.Appointmentcancel(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentcancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentcheckisvalid"></a>
# **Appointmentcheckisvalid**
> void Appointmentcheckisvalid (string token, Guid? id, bool? editing)

Check if an appointment is valid or not

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentcheckisvalidExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to check.
            var editing = true;  // bool? | Specifies whether the check is for a new appointment or an existing one. (optional) 

            try
            {
                // Check if an appointment is valid or not
                apiInstance.Appointmentcheckisvalid(token, id, editing);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentcheckisvalid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to check. | 
 **editing** | **bool?**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmenteditanyway"></a>
# **Appointmenteditanyway**
> void Appointmenteditanyway (string token, Guid? id, Guid? attendee, Guid? staff, Guid? location, DateTime? start, DateTime? end, Guid? term, Guid? _event, string services, string notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmenteditanywayExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to edit.
            var attendee = new Guid?(); // Guid? | The id of the attendee involved in the appointment.
            var staff = new Guid?(); // Guid? | The id of the staff member involved in the appointment.
            var location = new Guid?(); // Guid? | The id of the location where the appointment will take place.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | The appointment's start date & time.
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | The appointment's end date & time.
            var term = new Guid?(); // Guid? | The id of the term when the appointment takes place. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event of the appointment. (optional) 
            var services = services_example;  // string | Comma-separated string containing the ids of the services of the appointment. (optional) 
            var notes = notes_example;  // string | The notes of the appointment. (optional) 

            try
            {
                // Edit an appointment even if it breaks activated rules
                apiInstance.Appointmenteditanyway(token, id, attendee, staff, location, start, end, term, _event, services, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmenteditanyway: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to edit. | 
 **attendee** | [**Guid?**](.md)| The id of the attendee involved in the appointment. | 
 **staff** | [**Guid?**](.md)| The id of the staff member involved in the appointment. | 
 **location** | [**Guid?**](.md)| The id of the location where the appointment will take place. | 
 **start** | **DateTime?**| The appointment&#39;s start date &amp; time. | 
 **end** | **DateTime?**| The appointment&#39;s end date &amp; time. | 
 **term** | [**Guid?**](.md)| The id of the term when the appointment takes place. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event of the appointment. | [optional] 
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

<a name="appointmenteditpresence"></a>
# **Appointmenteditpresence**
> void Appointmenteditpresence (string token, Guid? id, bool? showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmenteditpresenceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to edit its presence.
            var showedup = true;  // bool? | Specifies whether the attendee was showed-up or not in the appointment.

            try
            {
                // Edit the no-show status of an appointment
                apiInstance.Appointmenteditpresence(token, id, showedup);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmenteditpresence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **bool?**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentfindallstaffslots"></a>
# **Appointmentfindallstaffslots**
> void Appointmentfindallstaffslots (string token, DateTime? starttime, DateTime? endtime, string serviceids, Guid? locationid, Guid? eventid, int? photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentfindallstaffslotsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var serviceids = serviceids_example;  // string | CSV list of the service Ids to filter by.
            var locationid = new Guid?(); // Guid? | The id of the service to filter by.
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Finds all staff available slots filtered by service, date, etc
                apiInstance.Appointmentfindallstaffslots(token, starttime, endtime, serviceids, locationid, eventid, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentfindallstaffslots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentfindslots"></a>
# **Appointmentfindslots**
> void Appointmentfindslots (string token, Guid? staffid, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentfindslotsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var staffid = new Guid?(); // Guid? | The id of the staff to filter by.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var serviceids = serviceids_example;  // string | CSV list of the service Ids to filter by.
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the service to filter by. (optional) 

            try
            {
                // Finds available slots filtered by service, date, staff, etc
                apiInstance.Appointmentfindslots(token, staffid, starttime, endtime, serviceids, eventid, locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentfindslots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **staffid** | [**Guid?**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentfindstaff"></a>
# **Appointmentfindstaff**
> void Appointmentfindstaff (string token, string serviceids, DateTime? starttime, DateTime? endtime, Guid? eventid, Guid? locationid, int? photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentfindstaffExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceids = serviceids_example;  // string | CSV list of the service ids to filter by.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the service to filter by. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Finds staff available by service, date, event, etc
                apiInstance.Appointmentfindstaff(token, serviceids, starttime, endtime, eventid, locationid, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentfindstaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceids** | **string**| CSV list of the service ids to filter by. | 
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentget"></a>
# **Appointmentget**
> void Appointmentget (string token, Guid? id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to get.

            try
            {
                // Search and view details of an appointment
                apiInstance.Appointmentget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentgetcurrent"></a>
# **Appointmentgetcurrent**
> void Appointmentgetcurrent (Guid? station, string user, Guid? location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentgetcurrentExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.
            var location = new Guid?(); // Guid? | The id of the location where the user wants to sign-in.

            try
            {
                // Get the current appointments for the user that is about to sign-in via the specified sign-in station.
                apiInstance.Appointmentgetcurrent(station, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentgetcurrent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 
 **location** | [**Guid?**](.md)| The id of the location where the user wants to sign-in. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentgetlocations"></a>
# **Appointmentgetlocations**
> void Appointmentgetlocations (string token, Guid? serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentgetlocationsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceid = new Guid?(); // Guid? | The id of the service to get its locations.

            try
            {
                // Find locations where a service is available
                apiInstance.Appointmentgetlocations(token, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentgetlocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**Guid?**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentlist"></a>
# **Appointmentlist**
> void Appointmentlist (string token, int? from, int? count, DateTime? startdate, DateTime? enddate, Guid? userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the appointments. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the appointments. (optional) 
            var userid = new Guid?(); // Guid? | The attendee id to filter the appointments. (optional) 

            try
            {
                // View a list of appointments
                apiInstance.Appointmentlist(token, from, count, startdate, enddate, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **startdate** | **DateTime?**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**Guid?**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentlistmine"></a>
# **Appointmentlistmine**
> void Appointmentlistmine (string token, DateTime? start, DateTime? modifiedafter)

View all my upcoming appointments

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentlistmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only appointments that start after the specified date will be returned. (optional) 
            var modifiedafter = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only appointments modified after the specified date will be returned. (optional) 

            try
            {
                // View all my upcoming appointments
                apiInstance.Appointmentlistmine(token, start, modifiedafter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentlistmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **start** | **DateTime?**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime?**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentlistupcoming"></a>
# **Appointmentlistupcoming**
> void Appointmentlistupcoming (string token, DateTime? start, DateTime? modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentlistupcomingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only appointments that start after the specified date will be returned. (optional) 
            var modifiedafter = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only appointments modified after the specified date will be returned. (optional) 

            try
            {
                // Search and view details of all my upcoming appointments
                apiInstance.Appointmentlistupcoming(token, start, modifiedafter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentlistupcoming: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **start** | **DateTime?**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime?**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentrescheduleoutlook"></a>
# **Appointmentrescheduleoutlook**
> void Appointmentrescheduleoutlook (string token, Guid? id, DateTime? start, DateTime? end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentrescheduleoutlookExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to edit.
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | The appointment's start date & time.
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | The appointment's end date & time.

            try
            {
                // Reschedule an appointment from MS Outlook.
                apiInstance.Appointmentrescheduleoutlook(token, id, start, end);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentrescheduleoutlook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to edit. | 
 **start** | **DateTime?**| The appointment&#39;s start date &amp; time. | 
 **end** | **DateTime?**| The appointment&#39;s end date &amp; time. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentrestore"></a>
# **Appointmentrestore**
> void Appointmentrestore (string token, Guid? id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentrestoreExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to restore.

            try
            {
                // Restore an appointment
                apiInstance.Appointmentrestore(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentrestore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentrestoreanyway"></a>
# **Appointmentrestoreanyway**
> void Appointmentrestoreanyway (string token, Guid? id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentrestoreanywayExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to restore.

            try
            {
                // Restore an appointment even if it breaks activated rules
                apiInstance.Appointmentrestoreanyway(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentrestoreanyway: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to restore. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentsave"></a>
# **Appointmentsave**
> void Appointmentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Schedule an appointment
                apiInstance.Appointmentsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentsetasvalid"></a>
# **Appointmentsetasvalid**
> void Appointmentsetasvalid (string token, Guid? id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentsetasvalidExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to set as valid.

            try
            {
                // Schedule an appointment even if it breaks activated rules
                apiInstance.Appointmentsetasvalid(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentsetasvalid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to set as valid. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appointmentsuggestlocations"></a>
# **Appointmentsuggestlocations**
> void Appointmentsuggestlocations (string token)

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentsuggestlocationsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View the locations with most appointments
                apiInstance.Appointmentsuggestlocations(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentsuggestlocations: " + e.Message );
            }
        }
    }
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

<a name="appointmentsuggestservices"></a>
# **Appointmentsuggestservices**
> void Appointmentsuggestservices (string token)

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentsuggestservicesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View the services with most appointments
                apiInstance.Appointmentsuggestservices(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentsuggestservices: " + e.Message );
            }
        }
    }
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

<a name="appointmentvoid"></a>
# **Appointmentvoid**
> void Appointmentvoid (string token, Guid? id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppointmentvoidExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the appointment to cancel.

            try
            {
                // Void an appointment
                apiInstance.Appointmentvoid(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appointmentvoid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the appointment to cancel. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsharegetphone"></a>
# **Appsharegetphone**
> void Appsharegetphone (string token)

Gets the phone number of the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsharegetphoneExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the phone number of the current user
                apiInstance.Appsharegetphone(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appsharegetphone: " + e.Message );
            }
        }
    }
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

<a name="appsharesendtext"></a>
# **Appsharesendtext**
> void Appsharesendtext (string token, string phonenumber)

Sends an SMS with the link to the app

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsharesendtextExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var phonenumber = phonenumber_example;  // string | Phone number to where to send the link. Leave empty to the number on file. (optional) 

            try
            {
                // Sends an SMS with the link to the app
                apiInstance.Appsharesendtext(token, phonenumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appsharesendtext: " + e.Message );
            }
        }
    }
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

<a name="attendancelogcommentdelete"></a>
# **Attendancelogcommentdelete**
> void Attendancelogcommentdelete (string token, Guid? id)

Delete a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log comment to delete.

            try
            {
                // Delete a comment on an attendance log
                apiInstance.Attendancelogcommentdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogcommentdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log comment to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentget"></a>
# **Attendancelogcommentget**
> void Attendancelogcommentget (string token, Guid? id)

View a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the comment to get.

            try
            {
                // View a comment on an attendance log
                apiInstance.Attendancelogcommentget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogcommentget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the comment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentlist"></a>
# **Attendancelogcommentlist**
> void Attendancelogcommentlist (Guid? attendancelog, string token)

View all the comments on a specific attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var attendancelog = new Guid?(); // Guid? | The id of the attendance log whose comments have to be retrieved.
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // View all the comments on a specific attendance log
                apiInstance.Attendancelogcommentlist(attendancelog, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogcommentlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**Guid?**](.md)| The id of the attendance log whose comments have to be retrieved. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentsave"></a>
# **Attendancelogcommentsave**
> void Attendancelogcommentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a comment on an attendance log
                apiInstance.Attendancelogcommentsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogcommentsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogdelete"></a>
# **Attendancelogdelete**
> void Attendancelogdelete (string token, Guid? id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to delete.

            try
            {
                // Delete an attendance log
                apiInstance.Attendancelogdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogget"></a>
# **Attendancelogget**
> void Attendancelogget (string token, Guid? id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendanceloggetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to get.

            try
            {
                // Search and view details of an attendance log
                apiInstance.Attendancelogget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloggetchangehistory"></a>
# **Attendanceloggetchangehistory**
> void Attendanceloggetchangehistory (string token, Guid? id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendanceloggetchangehistoryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to get.

            try
            {
                // Search and view details of an attendance log's swipe history
                apiInstance.Attendanceloggetchangehistory(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendanceloggetchangehistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloglist"></a>
# **Attendanceloglist**
> void Attendanceloglist (int? from, int? count, string token, string filter, Guid? userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendanceloglistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 
            var filter = filter_example;  // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional) 
            var userid = new Guid?(); // Guid? | The user ID of the user to get the logs. (optional) 

            try
            {
                // View a list of attendance logs
                apiInstance.Attendanceloglist(from, count, token, filter, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendanceloglist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**Guid?**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloglistmine"></a>
# **Attendanceloglistmine**
> void Attendanceloglistmine (int? from, int? count, string token, string filter)

Gets the attendance logs of the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendanceloglistmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 
            var filter = filter_example;  // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional) 

            try
            {
                // Gets the attendance logs of the current user
                apiInstance.Attendanceloglistmine(from, count, token, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendanceloglistmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
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

<a name="attendancelogliststaff"></a>
# **Attendancelogliststaff**
> void Attendancelogliststaff (int? from, int? count, string token, string filter)

Gets the attendance logs that the current user is involved in as staff

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogliststaffExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 
            var filter = filter_example;  // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional) 

            try
            {
                // Gets the attendance logs that the current user is involved in as staff
                apiInstance.Attendancelogliststaff(from, count, token, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogliststaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
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

<a name="attendancelogsave"></a>
# **Attendancelogsave**
> void Attendancelogsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an attendance log
                apiInstance.Attendancelogsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogsignout"></a>
# **Attendancelogsignout**
> void Attendancelogsignout (string token, Guid? id, Guid? location, Guid? _event, DateTime? datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogsignoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to sign-out. (optional) 
            var location = new Guid?(); // Guid? | The id of the location to filter the users to sign out. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event to filter the users to sign out. (optional) 
            var datetime = 2013-10-20T19:20:30+01:00;  // DateTime? | Specifies the date and time when the specified logs have to be signed out. (optional) 

            try
            {
                // Sign out an attendance log
                apiInstance.Attendancelogsignout(token, id, location, _event, datetime);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogsignout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**Guid?**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **DateTime?**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogwhosin"></a>
# **Attendancelogwhosin**
> void Attendancelogwhosin (int? from, int? count, string token, Guid? location, Guid? _event, string sorting, string roles, int? photosize, string extensions, bool? export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogwhosinExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 
            var location = new Guid?(); // Guid? | The id of the location to search for users that are in. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event to search for users that are in. (optional) 
            var sorting = sorting_example;  // string | Field to sort by. Either first-name, last-name or sign-in-time. (optional) 
            var roles = roles_example;  // string | The comma-separated list of ids of the roles to search for users that are in. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 
            var extensions = extensions_example;  // string | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]). (optional) 
            var export = true;  // bool? | True to export the results as CSV (optional) 

            try
            {
                // View who's in a location
                apiInstance.Attendancelogwhosin(from, count, token, location, _event, sorting, roles, photosize, extensions, export);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogwhosin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **location** | [**Guid?**](.md)| The id of the location to search for users that are in. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **string**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **string**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **string**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **bool?**| True to export the results as CSV | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancerestrictiondelete"></a>
# **Attendancerestrictiondelete**
> void Attendancerestrictiondelete (string token, Guid? id)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancerestrictiondeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the restriction to delete.

            try
            {
                // Delete an attendance restriction
                apiInstance.Attendancerestrictiondelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancerestrictiondelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the restriction to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancerestrictionget"></a>
# **Attendancerestrictionget**
> void Attendancerestrictionget (string token, Guid? id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancerestrictiongetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the restriction to get.

            try
            {
                // View details of an attendance restriction
                apiInstance.Attendancerestrictionget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancerestrictionget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the restriction to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancerestrictionlist"></a>
# **Attendancerestrictionlist**
> void Attendancerestrictionlist (string token, int? from, int? count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancerestrictionlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of attendance restrictions
                apiInstance.Attendancerestrictionlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancerestrictionlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancerestrictionsave"></a>
# **Attendancerestrictionsave**
> void Attendancerestrictionsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancerestrictionsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an attendance restriction
                apiInstance.Attendancerestrictionsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancerestrictionsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beacondelete"></a>
# **Beacondelete**
> void Beacondelete (string token, Guid? id)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeacondeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the beacon to delete.

            try
            {
                // Delete a beacon profile
                apiInstance.Beacondelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beacondelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the beacon to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beacondisable"></a>
# **Beacondisable**
> void Beacondisable (string token)

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeacondisableExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Disable beacon support account wide
                apiInstance.Beacondisable(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beacondisable: " + e.Message );
            }
        }
    }
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

<a name="beaconget"></a>
# **Beaconget**
> void Beaconget (string token, Guid? id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeacongetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the beacon to get.

            try
            {
                // View details of a beacon profile
                apiInstance.Beaconget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the beacon to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beacongetlocations"></a>
# **Beacongetlocations**
> void Beacongetlocations (string token, string beacons)

Get the sign-in stations assigned to specific beacons.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeacongetlocationsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var beacons = beacons_example;  // string | A JSON array containg the beacons data (region, minor and major) values.

            try
            {
                // Get the sign-in stations assigned to specific beacons.
                apiInstance.Beacongetlocations(token, beacons);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beacongetlocations: " + e.Message );
            }
        }
    }
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

<a name="beacongetstationlocation"></a>
# **Beacongetstationlocation**
> void Beacongetstationlocation (string token, Guid? station, Guid? location)

Get the location settings in the specified sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeacongetstationlocationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var station = new Guid?(); // Guid? | The id of the sign-in station whose location information has to be retrieved.
            var location = new Guid?(); // Guid? | The id of the location whose information has to be retrieved.

            try
            {
                // Get the location settings in the specified sign-in station.
                apiInstance.Beacongetstationlocation(token, station, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beacongetstationlocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **station** | [**Guid?**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
 **location** | [**Guid?**](.md)| The id of the location whose information has to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beacongetuuid"></a>
# **Beacongetuuid**
> void Beacongetuuid (string token)

View the identifier for the account's beacon region (for sign-in stations).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeacongetuuidExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View the identifier for the account's beacon region (for sign-in stations).
                apiInstance.Beacongetuuid(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beacongetuuid: " + e.Message );
            }
        }
    }
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

<a name="beaconlist"></a>
# **Beaconlist**
> void Beaconlist (string token, int? from, int? count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of beacon profiles
                apiInstance.Beaconlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconlistprofiles"></a>
# **Beaconlistprofiles**
> void Beaconlistprofiles (string token)

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconlistprofilesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of beacon profiles with their characteristics
                apiInstance.Beaconlistprofiles(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconlistprofiles: " + e.Message );
            }
        }
    }
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

<a name="beaconresetuuid"></a>
# **Beaconresetuuid**
> void Beaconresetuuid (string token)

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconresetuuidExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Generate or reset the identifier for the account's beacon region.
                apiInstance.Beaconresetuuid(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconresetuuid: " + e.Message );
            }
        }
    }
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

<a name="beaconsave"></a>
# **Beaconsave**
> void Beaconsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a beacon profile
                apiInstance.Beaconsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconscanlocations"></a>
# **Beaconscanlocations**
> void Beaconscanlocations (string token, string beacons)

Check if there's location available to sign-in / out.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconscanlocationsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var beacons = beacons_example;  // string | A JSON array containg the beacons data (region, minor and major) values.

            try
            {
                // Check if there's location available to sign-in / out.
                apiInstance.Beaconscanlocations(token, beacons);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconscanlocations: " + e.Message );
            }
        }
    }
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

<a name="beaconsetuuid"></a>
# **Beaconsetuuid**
> void Beaconsetuuid (string token, Guid? id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconsetuuidExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The custom region UUID.

            try
            {
                // Set the identifier for the account's beacon region (for sign-in stations).
                apiInstance.Beaconsetuuid(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconsetuuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The custom region UUID. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconsilentregions"></a>
# **Beaconsilentregions**
> void Beaconsilentregions (string token)

View all the beacon regions defined for silent tracking

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconsilentregionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View all the beacon regions defined for silent tracking
                apiInstance.Beaconsilentregions(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconsilentregions: " + e.Message );
            }
        }
    }
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

<a name="beaconsilentsignin"></a>
# **Beaconsilentsignin**
> void Beaconsilentsignin (string token, Guid? uuid)

Sign-in silently from the location specified by a beacon

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconsilentsigninExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var uuid = new Guid?(); // Guid? | The id of the region the user is in.

            try
            {
                // Sign-in silently from the location specified by a beacon
                apiInstance.Beaconsilentsignin(token, uuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconsilentsignin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **uuid** | [**Guid?**](.md)| The id of the region the user is in. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconsilentsignout"></a>
# **Beaconsilentsignout**
> void Beaconsilentsignout (string token, Guid? uuid)

Sign-out silently from the location specified by a beacon

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconsilentsignoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var uuid = new Guid?(); // Guid? | The id of the region the user has left.

            try
            {
                // Sign-out silently from the location specified by a beacon
                apiInstance.Beaconsilentsignout(token, uuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Beaconsilentsignout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **uuid** | [**Guid?**](.md)| The id of the region the user has left. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bgjobgetstatus"></a>
# **Bgjobgetstatus**
> void Bgjobgetstatus (string token, Guid? jobid, string jobtype)

Get background job status

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BgjobgetstatusExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var jobid = new Guid?(); // Guid? | The ID of the job to get the status. 10 most recent will be returned if not specified. (optional) 
            var jobtype = jobtype_example;  // string | The job type to filter by. (optional) 

            try
            {
                // Get background job status
                apiInstance.Bgjobgetstatus(token, jobid, jobtype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Bgjobgetstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **jobid** | [**Guid?**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **string**| The job type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="captchagetchallenge"></a>
# **Captchagetchallenge**
> void Captchagetchallenge ()

Gets a captcha challenge that the user must complete to do certain requests.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CaptchagetchallengeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Gets a captcha challenge that the user must complete to do certain requests.
                apiInstance.Captchagetchallenge();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Captchagetchallenge: " + e.Message );
            }
        }
    }
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

<a name="captchagetimage"></a>
# **Captchagetimage**
> void Captchagetimage (string captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CaptchagetimageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var captchatoken = captchatoken_example;  // string | The captcha token or ID returned by the captcha.getchallenge action

            try
            {
                // Gets a captcha image that the user must complete to do certain requests.
                apiInstance.Captchagetimage(captchatoken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Captchagetimage: " + e.Message );
            }
        }
    }
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

<a name="changelog"></a>
# **Changelog**
> void Changelog (string token)

Get the application change log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChangelogExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Get the application change log
                apiInstance.Changelog(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Changelog: " + e.Message );
            }
        }
    }
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

<a name="clientget"></a>
# **Clientget**
> void Clientget (string token, string _client, string clientname)

Get client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var _client = _client_example;  // string | The unique id of the client.
            var clientname = clientname_example;  // string | The custom name of the client. (optional) 

            try
            {
                // Get client
                apiInstance.Clientget(token, _client, clientname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Clientget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **_client** | **string**| The unique id of the client. | 
 **clientname** | **string**| The custom name of the client. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientlist"></a>
# **Clientlist**
> void Clientlist (string token, int? from, int? count)

Gets the clients of the specified conference

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // Gets the clients of the specified conference
                apiInstance.Clientlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Clientlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsave"></a>
# **Clientsave**
> void Clientsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a client
                apiInstance.Clientsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Clientsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsendmessage"></a>
# **Clientsendmessage**
> void Clientsendmessage (string token, Guid? uniqueclientid, string message)

Send a message to a client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientsendmessageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var uniqueclientid = new Guid?(); // Guid? | The unique id of the client.
            var message = message_example;  // string | The body of the message to send.

            try
            {
                // Send a message to a client
                apiInstance.Clientsendmessage(token, uniqueclientid, message);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Clientsendmessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **uniqueclientid** | [**Guid?**](.md)| The unique id of the client. | 
 **message** | **string**| The body of the message to send. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="communityinvite"></a>
# **Communityinvite**
> void Communityinvite (string token)

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CommunityinviteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Sends an invitation to everyone to AccuCampus Communities
                apiInstance.Communityinvite(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Communityinvite: " + e.Message );
            }
        }
    }
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

<a name="communityjoin"></a>
# **Communityjoin**
> void Communityjoin (string token)

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CommunityjoinExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Sends an invitation for myself to AccuCampus Communities
                apiInstance.Communityjoin(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Communityjoin: " + e.Message );
            }
        }
    }
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

<a name="compasscategorydelete"></a>
# **Compasscategorydelete**
> void Compasscategorydelete (string token, Guid? id)

Delete a compass category

Allows the user to delete an existing compass category.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompasscategorydeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the category to delete.

            try
            {
                // Delete a compass category
                apiInstance.Compasscategorydelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Compasscategorydelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the category to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compasscategoryget"></a>
# **Compasscategoryget**
> void Compasscategoryget (string token, Guid? id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompasscategorygetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the category to get.

            try
            {
                // View details of a compass category
                apiInstance.Compasscategoryget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Compasscategoryget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the category to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compasscategorylist"></a>
# **Compasscategorylist**
> void Compasscategorylist (string token, int? from, int? count, bool? onlywithservices)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompasscategorylistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 
            var onlywithservices = true;  // bool? | Specified whether only categories with services are returned or all. (optional) 

            try
            {
                // View a list of compass categories
                apiInstance.Compasscategorylist(token, from, count, onlywithservices);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Compasscategorylist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | [optional] 
 **count** | **int?**| The max number of records to return. | [optional] 
 **onlywithservices** | **bool?**| Specified whether only categories with services are returned or all. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compasscategorysave"></a>
# **Compasscategorysave**
> void Compasscategorysave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompasscategorysaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a compass category
                apiInstance.Compasscategorysave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Compasscategorysave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compassservicelist"></a>
# **Compassservicelist**
> void Compassservicelist (string token, Guid? category)

View all the services added to the compass

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompassservicelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var category = new Guid?(); // Guid? | The id of the category to filter the services. (optional) 

            try
            {
                // View all the services added to the compass
                apiInstance.Compassservicelist(token, category);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Compassservicelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **category** | [**Guid?**](.md)| The id of the category to filter the services. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compassservicelistlocations"></a>
# **Compassservicelistlocations**
> void Compassservicelistlocations (string token, Guid? serviceid)

View all the locations where a service added to the compass is available

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompassservicelistlocationsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceid = new Guid?(); // Guid? | The id of the service to get its locations.

            try
            {
                // View all the locations where a service added to the compass is available
                apiInstance.Compassservicelistlocations(token, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Compassservicelistlocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**Guid?**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabdeletecomputer"></a>
# **Computerlabdeletecomputer**
> void Computerlabdeletecomputer (string token, string id)

Delete a computer

Allows the user to delete an existing computer.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabdeletecomputerExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = id_example;  // string | The unique device id of the computer to delete.

            try
            {
                // Delete a computer
                apiInstance.Computerlabdeletecomputer(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlabdeletecomputer: " + e.Message );
            }
        }
    }
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

<a name="computerlabgetcomputer"></a>
# **Computerlabgetcomputer**
> void Computerlabgetcomputer (string token, string id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabgetcomputerExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = id_example;  // string | The unique device id of the computer to get.

            try
            {
                // Search and view details of a computer
                apiInstance.Computerlabgetcomputer(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlabgetcomputer: " + e.Message );
            }
        }
    }
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

<a name="computerlabgetsettings"></a>
# **Computerlabgetsettings**
> void Computerlabgetsettings (Guid? id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabgetsettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = new Guid?(); // Guid? | The id of the computer lab/location.

            try
            {
                // Loads the settings for a computer lab
                apiInstance.Computerlabgetsettings(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlabgetsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the computer lab/location. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabissignedin"></a>
# **Computerlabissignedin**
> void Computerlabissignedin (Guid? station, string user)

Gets whether a user is signed-in or not.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabissignedinExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets whether a user is signed-in or not.
                apiInstance.Computerlabissignedin(station, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlabissignedin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlablistcomputers"></a>
# **Computerlablistcomputers**
> void Computerlablistcomputers (string token, int? from, int? count, Guid? location, bool? freeonly)

View a list of computers

Allows the user to view the list of all computers.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlablistcomputersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var location = new Guid?(); // Guid? | The id of the location whose computers have to be returned. (optional) 
            var freeonly = true;  // bool? | If true, only free computers will be returned. (optional) 

            try
            {
                // View a list of computers
                apiInstance.Computerlablistcomputers(token, from, count, location, freeonly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlablistcomputers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **location** | [**Guid?**](.md)| The id of the location whose computers have to be returned. | [optional] 
 **freeonly** | **bool?**| If true, only free computers will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlablistlabs"></a>
# **Computerlablistlabs**
> void Computerlablistlabs (string token)

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlablistlabsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of the locations that use the Computer Lab add-on
                apiInstance.Computerlablistlabs(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlablistlabs: " + e.Message );
            }
        }
    }
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

<a name="computerlabliststations"></a>
# **Computerlabliststations**
> void Computerlabliststations (string token)

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabliststationsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of sign-in stations available for computer labs.
                apiInstance.Computerlabliststations(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlabliststations: " + e.Message );
            }
        }
    }
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

<a name="computerlabsavecomputer"></a>
# **Computerlabsavecomputer**
> void Computerlabsavecomputer (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a computer

Allows the user to create or edit a computer.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabsavecomputerExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a computer
                apiInstance.Computerlabsavecomputer(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlabsavecomputer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabsavesettings"></a>
# **Computerlabsavesettings**
> void Computerlabsavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabsavesettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves the settings for a computer lab
                apiInstance.Computerlabsavesettings(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlabsavesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="computerlabsaveswipe"></a>
# **Computerlabsaveswipe**
> void Computerlabsaveswipe (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a new swipe from a computer in a computer lab.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ComputerlabsaveswipeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a new swipe from a computer in a computer lab.
                apiInstance.Computerlabsaveswipe(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Computerlabsaveswipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deadendrecordingdelete"></a>
# **Deadendrecordingdelete**
> void Deadendrecordingdelete (string token, string hierarchykey)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeadendrecordingdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var hierarchykey = hierarchykey_example;  // string | The hierarchy key of the record to delete.

            try
            {
                // Deletes a dead-end record group
                apiInstance.Deadendrecordingdelete(token, hierarchykey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Deadendrecordingdelete: " + e.Message );
            }
        }
    }
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

<a name="deadendrecordinglist"></a>
# **Deadendrecordinglist**
> void Deadendrecordinglist (string token)

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeadendrecordinglistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists the recorded dead ends, if enabled
                apiInstance.Deadendrecordinglist(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Deadendrecordinglist: " + e.Message );
            }
        }
    }
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

<a name="deadendrecordinglistcomments"></a>
# **Deadendrecordinglistcomments**
> void Deadendrecordinglistcomments (string token, string hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeadendrecordinglistcommentsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var hierarchykey = hierarchykey_example;  // string | The hierarchy key of the record to get the feedback.

            try
            {
                // Lists the comments for a specific dead end
                apiInstance.Deadendrecordinglistcomments(token, hierarchykey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Deadendrecordinglistcomments: " + e.Message );
            }
        }
    }
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

<a name="deadendrecordingsave"></a>
# **Deadendrecordingsave**
> void Deadendrecordingsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a dead-end record

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeadendrecordingsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a dead-end record
                apiInstance.Deadendrecordingsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Deadendrecordingsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentdelete"></a>
# **Departmentdelete**
> void Departmentdelete (string token, Guid? id)

Delete a college department

Allows the user to delete an existing college department.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepartmentdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the department to delete.

            try
            {
                // Delete a college department
                apiInstance.Departmentdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Departmentdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the department to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentget"></a>
# **Departmentget**
> void Departmentget (string token, Guid? id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepartmentgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the department to get.

            try
            {
                // Search and view details of a college department
                apiInstance.Departmentget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Departmentget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the department to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentlist"></a>
# **Departmentlist**
> void Departmentlist (string token, int? from, int? count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepartmentlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of college departments
                apiInstance.Departmentlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Departmentlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentsave"></a>
# **Departmentsave**
> void Departmentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a college department

Allows the user to create or edit a college department.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepartmentsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a college department
                apiInstance.Departmentsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Departmentsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="doc"></a>
# **Doc**
> void Doc (bool? excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DocExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var excludeanonymous = true;  // bool? | If true it excludes the anonymous actions from the returned list. (optional) 

            try
            {
                // Get the documentation
                apiInstance.Doc(excludeanonymous);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Doc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **bool?**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="easyloginaddbgimage"></a>
# **Easyloginaddbgimage**
> void Easyloginaddbgimage (string token, string upload, string filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EasyloginaddbgimageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The original filename, needed to process the file.

            try
            {
                // Adds background image for the login
                apiInstance.Easyloginaddbgimage(token, upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Easyloginaddbgimage: " + e.Message );
            }
        }
    }
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

<a name="eventchecksessions"></a>
# **Eventchecksessions**
> void Eventchecksessions (string token, Guid? eventid, bool? autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventchecksessionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The id of the event to check.
            var autorepair = true;  // bool? | True to automatically fix the invalid sessions.

            try
            {
                // Edit an event's sessions according to their schedule
                apiInstance.Eventchecksessions(token, eventid, autorepair);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventchecksessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The id of the event to check. | 
 **autorepair** | **bool?**| True to automatically fix the invalid sessions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventdelete"></a>
# **Eventdelete**
> void Eventdelete (string token, Guid? id)

Delete a course

Allows the user to delete an existing course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the event to delete.

            try
            {
                // Delete a course
                apiInstance.Eventdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the event to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventget"></a>
# **Eventget**
> void Eventget (string token, Guid? id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the event to get.

            try
            {
                // Search and view details of a course
                apiInstance.Eventget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the event to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventgetsessionsbydate"></a>
# **Eventgetsessionsbydate**
> void Eventgetsessionsbydate (string token, Guid? location, DateTime? date, string type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventgetsessionsbydateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var location = new Guid?(); // Guid? | The location to filter the events. (optional) 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | The date to filter the events. Today will be used if this parameter is omitted. (optional) 
            var type = type_example;  // string | Type of event to list. (optional) 

            try
            {
                // View a list of courses by date
                apiInstance.Eventgetsessionsbydate(token, location, date, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventgetsessionsbydate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **location** | [**Guid?**](.md)| The location to filter the events. | [optional] 
 **date** | **DateTime?**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **string**| Type of event to list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventlist"></a>
# **Eventlist**
> void Eventlist (string token, string from, string count, bool? summaryonly, Guid? termid)

View a list of courses

Allows the user to view the full list of courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = from_example;  // string | The first record to return.
            var count = count_example;  // string | The max number of records to return.
            var summaryonly = true;  // bool? | True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional) 
            var termid = new Guid?(); // Guid? | Id of the term to list the events. Null to list all events. (optional) 

            try
            {
                // View a list of courses
                apiInstance.Eventlist(token, from, count, summaryonly, termid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **bool?**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**Guid?**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventlistregistered"></a>
# **Eventlistregistered**
> void Eventlistregistered (string token, string from, string count, bool? summaryonly, Guid? termid)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventlistregisteredExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = from_example;  // string | The first record to return.
            var count = count_example;  // string | The max number of records to return.
            var summaryonly = true;  // bool? | True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional) 
            var termid = new Guid?(); // Guid? | Id of the term to list the events. Null to list all events. (optional) 

            try
            {
                // View a list of courses I am registered to
                apiInstance.Eventlistregistered(token, from, count, summaryonly, termid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventlistregistered: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **bool?**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**Guid?**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregaddme"></a>
# **Eventregaddme**
> void Eventregaddme (string token, Guid? eventid, string listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregaddmeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register current user to a course
                apiInstance.Eventregaddme(token, eventid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregaddme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregaddmetoall"></a>
# **Eventregaddmetoall**
> void Eventregaddmetoall (string token, string listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregaddmetoallExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register current user to all courses
                apiInstance.Eventregaddmetoall(token, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregaddmetoall: " + e.Message );
            }
        }
    }
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

<a name="eventregaddmetogroup"></a>
# **Eventregaddmetogroup**
> void Eventregaddmetogroup (string token, string codegroup, string listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregaddmetogroupExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var codegroup = codegroup_example;  // string | The code used to group events.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register current user to a course group
                apiInstance.Eventregaddmetogroup(token, codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregaddmetogroup: " + e.Message );
            }
        }
    }
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

<a name="eventregadduser"></a>
# **Eventregadduser**
> void Eventregadduser (string token, Guid? userid, Guid? eventid, string listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregadduserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register a user to a course for attendance
                apiInstance.Eventregadduser(token, userid, eventid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregadduser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregaddusertoall"></a>
# **Eventregaddusertoall**
> void Eventregaddusertoall (string token, Guid? userid, string listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregaddusertoallExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register a user to assist with all courses
                apiInstance.Eventregaddusertoall(token, userid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregaddusertoall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregaddusertogroup"></a>
# **Eventregaddusertogroup**
> void Eventregaddusertogroup (string token, Guid? userid, string codegroup, string listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregaddusertogroupExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var codegroup = codegroup_example;  // string | The code used to group events.
            var listname = listname_example;  // string | The name of the list where the user has to be registered.

            try
            {
                // Register a user to an course group
                apiInstance.Eventregaddusertogroup(token, userid, codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregaddusertogroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
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

<a name="eventreggetevents"></a>
# **Eventreggetevents**
> void Eventreggetevents (string token, Guid? userid, string listname, Guid? termid, string namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventreggeteventsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The user id to list events.
            var listname = listname_example;  // string | The name of the list where the user is registered.
            var termid = new Guid?(); // Guid? | The term id to list events. (optional) 
            var namefilter = namefilter_example;  // string | The value used to filter the events by name. (optional) 

            try
            {
                // View course registration by user
                apiInstance.Eventreggetevents(token, userid, listname, termid, namefilter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventreggetevents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The user id to list events. | 
 **listname** | **string**| The name of the list where the user is registered. | 
 **termid** | [**Guid?**](.md)| The term id to list events. | [optional] 
 **namefilter** | **string**| The value used to filter the events by name. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetgroups"></a>
# **Eventreggetgroups**
> void Eventreggetgroups (string token, Guid? userid, string listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventreggetgroupsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The user id to list events.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Lists the course group registrations of a user
                apiInstance.Eventreggetgroups(token, userid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventreggetgroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The user id to list events. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetmyevents"></a>
# **Eventreggetmyevents**
> void Eventreggetmyevents (string token, string listname, Guid? termid, string namefilter)

View the event registrations of the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventreggetmyeventsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var listname = listname_example;  // string | The name of the list where the user is registered.
            var termid = new Guid?(); // Guid? | The term id to list events. (optional) 
            var namefilter = namefilter_example;  // string | The value used to filter the events by name. (optional) 

            try
            {
                // View the event registrations of the current user
                apiInstance.Eventreggetmyevents(token, listname, termid, namefilter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventreggetmyevents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **listname** | **string**| The name of the list where the user is registered. | 
 **termid** | [**Guid?**](.md)| The term id to list events. | [optional] 
 **namefilter** | **string**| The value used to filter the events by name. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetmygroups"></a>
# **Eventreggetmygroups**
> void Eventreggetmygroups (string token, string listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventreggetmygroupsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // View all current user registrations to course groups
                apiInstance.Eventreggetmygroups(token, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventreggetmygroups: " + e.Message );
            }
        }
    }
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

<a name="eventreggetusers"></a>
# **Eventreggetusers**
> void Eventreggetusers (string token, Guid? eventid, string listname, int? photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventreggetusersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The event id to list users.
            var listname = listname_example;  // string | The name of the list to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View course registration
                apiInstance.Eventreggetusers(token, eventid, listname, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventreggetusers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The event id to list users. | 
 **listname** | **string**| The name of the list to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetusersfromgroup"></a>
# **Eventreggetusersfromgroup**
> void Eventreggetusersfromgroup (string token, Guid? codegroup, string listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventreggetusersfromgroupExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var codegroup = new Guid?(); // Guid? | The code group to list users.
            var listname = listname_example;  // string | The name of the list to get.

            try
            {
                // Lists the registrations for a course group
                apiInstance.Eventreggetusersfromgroup(token, codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventreggetusersfromgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **codegroup** | [**Guid?**](.md)| The code group to list users. | 
 **listname** | **string**| The name of the list to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventreggetuserstoall"></a>
# **Eventreggetuserstoall**
> void Eventreggetuserstoall (string token, string listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventreggetuserstoallExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var listname = listname_example;  // string | The name of the list to get.

            try
            {
                // View the users that are registered to all courses
                apiInstance.Eventreggetuserstoall(token, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventreggetuserstoall: " + e.Message );
            }
        }
    }
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

<a name="eventregremoveme"></a>
# **Eventregremoveme**
> void Eventregremoveme (string token, Guid? eventid, string listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregremovemeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Unregister current user from a course
                apiInstance.Eventregremoveme(token, eventid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregremoveme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremovemefromall"></a>
# **Eventregremovemefromall**
> void Eventregremovemefromall (string token, string listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregremovemefromallExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove current user from the registration to all courses
                apiInstance.Eventregremovemefromall(token, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregremovemefromall: " + e.Message );
            }
        }
    }
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

<a name="eventregremovemefromgroup"></a>
# **Eventregremovemefromgroup**
> void Eventregremovemefromgroup (string token, Guid? codegroup, string listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregremovemefromgroupExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var codegroup = new Guid?(); // Guid? | The code group of the events/courses.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove current user from a course group
                apiInstance.Eventregremovemefromgroup(token, codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregremovemefromgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **codegroup** | [**Guid?**](.md)| The code group of the events/courses. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremoveuser"></a>
# **Eventregremoveuser**
> void Eventregremoveuser (string token, Guid? userid, Guid? eventid, string listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregremoveuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove a user from a course
                apiInstance.Eventregremoveuser(token, userid, eventid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregremoveuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremoveuserfromall"></a>
# **Eventregremoveuserfromall**
> void Eventregremoveuserfromall (string token, Guid? userid, string listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregremoveuserfromallExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove a user from the registration to all courses
                apiInstance.Eventregremoveuserfromall(token, userid, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregremoveuserfromall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventregremoveuserfromgroup"></a>
# **Eventregremoveuserfromgroup**
> void Eventregremoveuserfromgroup (string token, Guid? userid, Guid? codegroup, string listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventregremoveuserfromgroupExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var codegroup = new Guid?(); // Guid? | The code group of the events/courses.
            var listname = listname_example;  // string | The name of the list where the user is registered.

            try
            {
                // Remove a user from a course group
                apiInstance.Eventregremoveuserfromgroup(token, userid, codegroup, listname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventregremoveuserfromgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **codegroup** | [**Guid?**](.md)| The code group of the events/courses. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsave"></a>
# **Eventsave**
> void Eventsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a course

Allows the user to create or edit a course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a course
                apiInstance.Eventsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsearchgroup"></a>
# **Eventsearchgroup**
> void Eventsearchgroup (string token, Guid? query)

Searches for the available event groups

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventsearchgroupExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var query = new Guid?(); // Guid? | Query to search event groups.

            try
            {
                // Searches for the available event groups
                apiInstance.Eventsearchgroup(token, query);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventsearchgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | [**Guid?**](.md)| Query to search event groups. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="export"></a>
# **Export**
> void Export (string token, string exporttype, string exportformat, string filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ExportExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var exporttype = exporttype_example;  // string | What to export.
            var exportformat = exportformat_example;  // string | The format of the resulting file. Valid types are CSV, HTML, XLS.
            var filters = filters_example;  // string | Pipe separated filters for the export, eg: aaa=val|bbb=val|... (optional) 

            try
            {
                // Export AccuCampus data
                apiInstance.Export(token, exporttype, exportformat, filters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Export: " + e.Message );
            }
        }
    }
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

<a name="exportlisttypes"></a>
# **Exportlisttypes**
> void Exportlisttypes (string token)

Lists available export types

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ExportlisttypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists available export types
                apiInstance.Exportlisttypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Exportlisttypes: " + e.Message );
            }
        }
    }
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

<a name="featurelist"></a>
# **Featurelist**
> void Featurelist (string token)

Lists the available features.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FeaturelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists the available features.
                apiInstance.Featurelist(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Featurelist: " + e.Message );
            }
        }
    }
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

<a name="holidaylist"></a>
# **Holidaylist**
> void Holidaylist (string token, Guid? term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidaylistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var term = new Guid?(); // Guid? | The term to get holidays from.

            try
            {
                // View a list of entered holidays
                apiInstance.Holidaylist(token, term);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Holidaylist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **term** | [**Guid?**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="holidaysave"></a>
# **Holidaysave**
> void Holidaysave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidaysaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a list of holidays
                apiInstance.Holidaysave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Holidaysave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="holidaysuggest"></a>
# **Holidaysuggest**
> void Holidaysuggest (string token, Guid? term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidaysuggestExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var term = new Guid?(); // Guid? | The term to get holidays from.

            try
            {
                // View the holiday suggestions in the given term
                apiInstance.Holidaysuggest(token, term);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Holidaysuggest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **term** | [**Guid?**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="import"></a>
# **Import**
> void Import (string token, string importtype, string upload, string filename, string parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ImportExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var importtype = importtype_example;  // string | The kind of data that is being uploaded.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 
            var parameters = parameters_example;  // string | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}. (optional) 

            try
            {
                // Import data into AccuCampus
                apiInstance.Import(token, importtype, upload, filename, parameters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Import: " + e.Message );
            }
        }
    }
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

<a name="importlisttypes"></a>
# **Importlisttypes**
> void Importlisttypes (string token)

Lists available import types

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ImportlisttypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists available import types
                apiInstance.Importlisttypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Importlisttypes: " + e.Message );
            }
        }
    }
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

<a name="interactiondelete"></a>
# **Interactiondelete**
> void Interactiondelete (string token, Guid? id)

Delete an interaction

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractiondeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the interaction to delete.

            try
            {
                // Delete an interaction
                apiInstance.Interactiondelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Interactiondelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the interaction to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionfeed"></a>
# **Interactionfeed**
> void Interactionfeed (string token, int? from, int? count, DateTime? startdate, bool? _public, string contexttype, Guid? contextid, string types, int? photosize, bool? showdefaultphoto, bool? orderdescending)

Get the interactions feed

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionfeedExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | If set, only interactions that happened after this date are returned. (optional) 
            var _public = true;  // bool? | Specifies whether to return public or private interactions. (optional) 
            var contexttype = contexttype_example;  // string | The type of the context of the interactions to return. (optional) 
            var contextid = new Guid?(); // Guid? | The id of the context of the interactions to return. (optional) 
            var types = types_example;  // string | The  comma separated types of the interactions to return. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 
            var showdefaultphoto = true;  // bool? | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. (optional) 
            var orderdescending = true;  // bool? | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. (optional) 

            try
            {
                // Get the interactions feed
                apiInstance.Interactionfeed(token, from, count, startdate, _public, contexttype, contextid, types, photosize, showdefaultphoto, orderdescending);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Interactionfeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **startdate** | **DateTime?**| If set, only interactions that happened after this date are returned. | [optional] 
 **_public** | **bool?**| Specifies whether to return public or private interactions. | [optional] 
 **contexttype** | **string**| The type of the context of the interactions to return. | [optional] 
 **contextid** | [**Guid?**](.md)| The id of the context of the interactions to return. | [optional] 
 **types** | **string**| The  comma separated types of the interactions to return. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **bool?**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 
 **orderdescending** | **bool?**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionget"></a>
# **Interactionget**
> void Interactionget (string token, string id, int? thumbnailmediasize, int? photosize)

View an interaction

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractiongetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = id_example;  // string | The id of the interaction.
            var thumbnailmediasize = 56;  // int? | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View an interaction
                apiInstance.Interactionget(token, id, thumbnailmediasize, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Interactionget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | **string**| The id of the interaction. | 
 **thumbnailmediasize** | **int?**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionlistprivatesummary"></a>
# **Interactionlistprivatesummary**
> void Interactionlistprivatesummary (string token, int? photosize, bool? showdefaultphoto)

Get current user's latest private interactions

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionlistprivatesummaryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 
            var showdefaultphoto = true;  // bool? | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. (optional) 

            try
            {
                // Get current user's latest private interactions
                apiInstance.Interactionlistprivatesummary(token, photosize, showdefaultphoto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Interactionlistprivatesummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **bool?**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionsave"></a>
# **Interactionsave**
> void Interactionsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save an interaction

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save an interaction
                apiInstance.Interactionsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Interactionsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="licenseacceptagreement"></a>
# **Licenseacceptagreement**
> void Licenseacceptagreement (string token)

Accept the license agreement

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicenseacceptagreementExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Accept the license agreement
                apiInstance.Licenseacceptagreement(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Licenseacceptagreement: " + e.Message );
            }
        }
    }
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

<a name="licensegetagreementstatus"></a>
# **Licensegetagreementstatus**
> void Licensegetagreementstatus (string token)

Check if license agreement has been accepted

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicensegetagreementstatusExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Check if license agreement has been accepted
                apiInstance.Licensegetagreementstatus(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Licensegetagreementstatus: " + e.Message );
            }
        }
    }
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

<a name="licensegetcurrent"></a>
# **Licensegetcurrent**
> void Licensegetcurrent (string token)

Gets the current license information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicensegetcurrentExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // Gets the current license information
                apiInstance.Licensegetcurrent(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Licensegetcurrent: " + e.Message );
            }
        }
    }
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

<a name="licenserenew"></a>
# **Licenserenew**
> void Licenserenew (string token, string email, string phonenumber, string jobtitle, string institution, string comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicenserenewExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var email = email_example;  // string | The e-mail of the user sending the request.
            var phonenumber = phonenumber_example;  // string | The phone number of the user sending the request.
            var jobtitle = jobtitle_example;  // string | The job title of the user sending the request. (optional) 
            var institution = institution_example;  // string | The institution of the user sending the request. (optional) 
            var comments = comments_example;  // string | Comments entered by the user sending the request. (optional) 

            try
            {
                // Contact Engineerica in order to renew the AccuCampus subscription
                apiInstance.Licenserenew(token, email, phonenumber, jobtitle, institution, comments);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Licenserenew: " + e.Message );
            }
        }
    }
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

<a name="likedelete"></a>
# **Likedelete**
> void Likedelete (string token, Guid? interactionid)

Delete a like

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LikedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var interactionid = new Guid?(); // Guid? | The id of the interaction to unlike.

            try
            {
                // Delete a like
                apiInstance.Likedelete(token, interactionid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Likedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **interactionid** | [**Guid?**](.md)| The id of the interaction to unlike. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="likelist"></a>
# **Likelist**
> void Likelist (string token, Guid? interactionid, int? photosize)

View all the likes associated to a target

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LikelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var interactionid = new Guid?(); // Guid? | The id of the interaction to unlike.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View all the likes associated to a target
                apiInstance.Likelist(token, interactionid, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Likelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **interactionid** | [**Guid?**](.md)| The id of the interaction to unlike. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="likesave"></a>
# **Likesave**
> void Likesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a like

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LikesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a like
                apiInstance.Likesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Likesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtimezones"></a>
# **Listtimezones**
> void Listtimezones ()

Lists the available timezones

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListtimezonesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Lists the available timezones
                apiInstance.Listtimezones();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Listtimezones: " + e.Message );
            }
        }
    }
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

<a name="locationdelete"></a>
# **Locationdelete**
> void Locationdelete (string token, Guid? id)

Delete a location

Allows the user to delete an existing location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the location to delete.

            try
            {
                // Delete a location
                apiInstance.Locationdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Locationdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the location to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationget"></a>
# **Locationget**
> void Locationget (string token, Guid? id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the location to get.

            try
            {
                // Search and view details of a location
                apiInstance.Locationget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Locationget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationlist"></a>
# **Locationlist**
> void Locationlist (string token, int? from, int? count, string locations, bool? sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var locations = locations_example;  // string | The comma-separated list containing the ids of the locations to list. (optional) 
            var sortbygroup = true;  // bool? | True to list locations sorted by the 'Located In' property. Defaults to false. (optional) 

            try
            {
                // View a list of locations
                apiInstance.Locationlist(token, from, count, locations, sortbygroup);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Locationlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **locations** | **string**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **bool?**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationsave"></a>
# **Locationsave**
> void Locationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a location

Allows the user to create or edit a location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a location
                apiInstance.Locationsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Locationsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> void Login (string domain, string username, string password, string method, bool? rememberme)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var domain = domain_example;  // string | The account domain to login.
            var username = username_example;  // string | The username (email) of the user to login as.
            var password = password_example;  // string | The password of the user to login as.
            var method = method_example;  // string | The authentication method. Valid values are 'token' and 'cookie'.
            var rememberme = true;  // bool? | If true then the session will not expire. (optional) 

            try
            {
                // Login
                apiInstance.Login(domain, username, password, method, rememberme);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The account domain to login. | 
 **username** | **string**| The username (email) of the user to login as. | 
 **password** | **string**| The password of the user to login as. | 
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **bool?**| If true then the session will not expire. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout (string token)

Logout

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token used to login. (optional) 

            try
            {
                // Logout
                apiInstance.Logout(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Logout: " + e.Message );
            }
        }
    }
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

<a name="mediacheckin"></a>
# **Mediacheckin**
> void Mediacheckin (string token, Guid? media, DateTime? checkindate, string notes)

Check in media item

Allows the user to check in a media item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediacheckinExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var media = new Guid?(); // Guid? | The id of the media item to checkin.
            var checkindate = 2013-10-20T19:20:30+01:00;  // DateTime? | The checkout date.
            var notes = notes_example;  // string | The notes of the checkout. (optional) 

            try
            {
                // Check in media item
                apiInstance.Mediacheckin(token, media, checkindate, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediacheckin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **media** | [**Guid?**](.md)| The id of the media item to checkin. | 
 **checkindate** | **DateTime?**| The checkout date. | 
 **notes** | **string**| The notes of the checkout. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediacheckout"></a>
# **Mediacheckout**
> void Mediacheckout (string token, Guid? media, Guid? user, DateTime? checkoutdate, DateTime? duedate, Guid? staff, Guid? _event, string notes)

Check out media item

Allows the user to check out a media item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediacheckoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var media = new Guid?(); // Guid? | The id of the media item to checkout.
            var user = new Guid?(); // Guid? | The id of the user that is checking the item out.
            var checkoutdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The checkout date.
            var duedate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date when the checkout is due.
            var staff = new Guid?(); // Guid? | The id of the staff member related to the checkout. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event related to the checkout. (optional) 
            var notes = notes_example;  // string | The notes of the checkout. (optional) 

            try
            {
                // Check out media item
                apiInstance.Mediacheckout(token, media, user, checkoutdate, duedate, staff, _event, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediacheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **media** | [**Guid?**](.md)| The id of the media item to checkout. | 
 **user** | [**Guid?**](.md)| The id of the user that is checking the item out. | 
 **checkoutdate** | **DateTime?**| The checkout date. | 
 **duedate** | **DateTime?**| The date when the checkout is due. | 
 **staff** | [**Guid?**](.md)| The id of the staff member related to the checkout. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event related to the checkout. | [optional] 
 **notes** | **string**| The notes of the checkout. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediacheckoutlist"></a>
# **Mediacheckoutlist**
> void Mediacheckoutlist (string token, int? from, int? count, Guid? media, Guid? user, int? photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediacheckoutlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var media = new Guid?(); // Guid? | Used to filter the checkouts of a specific media item. (optional) 
            var user = new Guid?(); // Guid? | Used to filter the checkouts made by a specific user. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View a list of past media checkouts
                apiInstance.Mediacheckoutlist(token, from, count, media, user, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediacheckoutlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **media** | [**Guid?**](.md)| Used to filter the checkouts of a specific media item. | [optional] 
 **user** | [**Guid?**](.md)| Used to filter the checkouts made by a specific user. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediadelete"></a>
# **Mediadelete**
> void Mediadelete (string token, Guid? id)

Delete a media item

Allows the user to delete an existing media item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediadeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the media item to delete.

            try
            {
                // Delete a media item
                apiInstance.Mediadelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediadelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the media item to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediadeletecheckoutlog"></a>
# **Mediadeletecheckoutlog**
> void Mediadeletecheckoutlog (string token, Guid? id)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediadeletecheckoutlogExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the checkout log to delete.

            try
            {
                // Delete a media checkout log
                apiInstance.Mediadeletecheckoutlog(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediadeletecheckoutlog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the checkout log to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediaget"></a>
# **Mediaget**
> void Mediaget (string token, Guid? id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediagetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the media item to get.

            try
            {
                // Search and view details of a media item
                apiInstance.Mediaget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediaget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the media item to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediagetbycode"></a>
# **Mediagetbycode**
> void Mediagetbycode (string token, string code, Guid? location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediagetbycodeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var code = code_example;  // string | The code of the media item to get.
            var location = new Guid?(); // Guid? | The location where to look for the media item. (optional) 

            try
            {
                // Search media item by unique code
                apiInstance.Mediagetbycode(token, code, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediagetbycode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **code** | **string**| The code of the media item to get. | 
 **location** | [**Guid?**](.md)| The location where to look for the media item. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediagetcheckout"></a>
# **Mediagetcheckout**
> void Mediagetcheckout (string token, Guid? id, int? photosize)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediagetcheckoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the media item whose checkout information has to be retrieved.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View details of a media item checkout information
                apiInstance.Mediagetcheckout(token, id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediagetcheckout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediagetcheckoutlog"></a>
# **Mediagetcheckoutlog**
> void Mediagetcheckoutlog (string token, Guid? id, int? photosize)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediagetcheckoutlogExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the media item whose checkout information has to be retrieved.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View details of a media checkout log
                apiInstance.Mediagetcheckoutlog(token, id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediagetcheckoutlog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="medialist"></a>
# **Medialist**
> void Medialist (string token, int? from, int? count, int? status, Guid? user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MedialistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var status = 56;  // int? | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All). (optional) 
            var user = new Guid?(); // Guid? | Used to filter the media items that are checked-out by a specific user. (optional) 

            try
            {
                // View a list of media items
                apiInstance.Medialist(token, from, count, status, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Medialist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **status** | **int?**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional] 
 **user** | [**Guid?**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediasave"></a>
# **Mediasave**
> void Mediasave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a media item

Allows the user to create or edit a media item.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediasaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a media item
                apiInstance.Mediasave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediasave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediatypedelete"></a>
# **Mediatypedelete**
> void Mediatypedelete (string token, Guid? id)

Delete a media type

Allows the user to delete an existing media type.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediatypedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the media type to delete.

            try
            {
                // Delete a media type
                apiInstance.Mediatypedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediatypedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the media type to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediatypeget"></a>
# **Mediatypeget**
> void Mediatypeget (string token, Guid? id)

Search and view details of a media type

Allows the user to view a media type and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediatypegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the media type to get.

            try
            {
                // Search and view details of a media type
                apiInstance.Mediatypeget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediatypeget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the media type to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediatypelist"></a>
# **Mediatypelist**
> void Mediatypelist (string token, int? from, int? count)

View a list of media types

Allows the user to view the list of all media types.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediatypelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of media types
                apiInstance.Mediatypelist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediatypelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mediatypesave"></a>
# **Mediatypesave**
> void Mediatypesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a media type

Allows the user to create or edit a media type.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MediatypesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a media type
                apiInstance.Mediatypesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mediatypesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportdelete"></a>
# **Memorizedreportdelete**
> void Memorizedreportdelete (string token, Guid? id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the report settings to delete.

            try
            {
                // Delete memorized report
                apiInstance.Memorizedreportdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Memorizedreportdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the report settings to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportget"></a>
# **Memorizedreportget**
> void Memorizedreportget (string token, Guid? id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the report configuration to get.

            try
            {
                // View details of a memorized report
                apiInstance.Memorizedreportget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Memorizedreportget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the report configuration to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportlist"></a>
# **Memorizedreportlist**
> void Memorizedreportlist (string token, int? from, int? count, string customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var customname = customname_example;  // string | If specified filters the memorized reports by custom name. (optional) 

            try
            {
                // View a list of all his memorized reports
                apiInstance.Memorizedreportlist(token, from, count, customname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Memorizedreportlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **customname** | **string**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportsave"></a>
# **Memorizedreportsave**
> void Memorizedreportsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a memorized report
                apiInstance.Memorizedreportsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Memorizedreportsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menugetitems"></a>
# **Menugetitems**
> void Menugetitems (string menuid)

Gets the items on the menu

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MenugetitemsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var menuid = menuid_example;  // string | The Id of the menu to get.

            try
            {
                // Gets the items on the menu
                apiInstance.Menugetitems(menuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Menugetitems: " + e.Message );
            }
        }
    }
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

<a name="myaccount"></a>
# **Myaccount**
> void Myaccount (string token)

Gets the logged in user account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyaccountExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the logged in user account.
                apiInstance.Myaccount(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Myaccount: " + e.Message );
            }
        }
    }
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

<a name="myianatimezone"></a>
# **Myianatimezone**
> void Myianatimezone (string token)

Gets the current time zone's iana name

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyianatimezoneExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the current time zone's iana name
                apiInstance.Myianatimezone(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Myianatimezone: " + e.Message );
            }
        }
    }
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

<a name="myprofile"></a>
# **Myprofile**
> void Myprofile (string token, int? photosize)

Gets the logged in user information.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyprofileExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Gets the logged in user information.
                apiInstance.Myprofile(token, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Myprofile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="myrights"></a>
# **Myrights**
> void Myrights (string token)

Gets the list of actions the user can execute.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyrightsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the list of actions the user can execute.
                apiInstance.Myrights(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Myrights: " + e.Message );
            }
        }
    }
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

<a name="mysaveprofile"></a>
# **Mysaveprofile**
> void Mysaveprofile (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Updates logged user's profile information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MysaveprofileExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Updates logged user's profile information
                apiInstance.Mysaveprofile(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mysaveprofile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationdelete"></a>
# **Notificationdelete**
> void Notificationdelete (string token, Guid? id)

Delete a notification

Allows the user to delete an existing notification.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification to delete.

            try
            {
                // Delete a notification
                apiInstance.Notificationdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationget"></a>
# **Notificationget**
> void Notificationget (string token, Guid? id)

View a notification

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification to get.

            try
            {
                // View a notification
                apiInstance.Notificationget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationgetforstation"></a>
# **Notificationgetforstation**
> void Notificationgetforstation (Guid? station, string user)

Gets all public (in station) notifications for the specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationgetforstationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets all public (in station) notifications for the specific user
                apiInstance.Notificationgetforstation(station, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationgetforstation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationgetunreadcount"></a>
# **Notificationgetunreadcount**
> void Notificationgetunreadcount (string token)

Get the number of unread notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationgetunreadcountExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Get the number of unread notifications
                apiInstance.Notificationgetunreadcount(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationgetunreadcount: " + e.Message );
            }
        }
    }
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

<a name="notificationlist"></a>
# **Notificationlist**
> void Notificationlist (string token, int? from, int? count, Guid? recipient, int? status, DateTime? startdate, DateTime? enddate, bool? sentonscreen, bool? sentemail, bool? sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var recipient = new Guid?(); // Guid? | The recipient whose notifications have to be listed. (optional) 
            var status = 56;  // int? | The status of the notifications to list. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 
            var sentonscreen = true;  // bool? | Specifies whether to list the notifications that were sent on-screen or not. (optional) 
            var sentemail = true;  // bool? | Specifies whether to list the notifications that were sent via e-mail or not. (optional) 
            var sentsms = true;  // bool? | Specifies whether to list the notifications that were sent via sms or not. (optional) 

            try
            {
                // View a list of all sent notifications
                apiInstance.Notificationlist(token, from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **recipient** | [**Guid?**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **int?**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **bool?**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **bool?**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **bool?**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationlistmine"></a>
# **Notificationlistmine**
> void Notificationlistmine (string token, int? from, int? count, int? status, DateTime? startdate, DateTime? enddate)

View all the notifications sent to the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationlistmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var status = 56;  // int? | Specifies the status of the notifications to list. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // View all the notifications sent to the current user
                apiInstance.Notificationlistmine(token, from, count, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationlistmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **status** | **int?**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationmarkasread"></a>
# **Notificationmarkasread**
> void Notificationmarkasread (string token, Guid? id, int? status, DateTime? startdate, DateTime? enddate)

Mark a notification as read

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationmarkasreadExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. (optional) 
            var status = 56;  // int? | Specifies the status to filter the notifications. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // Mark a notification as read
                apiInstance.Notificationmarkasread(token, id, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationmarkasread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **int?**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationmarkasunread"></a>
# **Notificationmarkasunread**
> void Notificationmarkasunread (string token, Guid? id, int? status, DateTime? startdate, DateTime? enddate)

Mark a notification as unread

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationmarkasunreadExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. (optional) 
            var status = 56;  // int? | Specifies the status to filter the notifications. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // Mark a notification as unread
                apiInstance.Notificationmarkasunread(token, id, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationmarkasunread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **int?**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationsend"></a>
# **Notificationsend**
> void Notificationsend (string token, bool? emailenabled, bool? onscreenenabled, bool? smsenabled, string title, string tousers, string togroups, string onscreenbody, string onscreenclick, string onscreenurl, string onscreenclass, int? onscreenduration, int? showonstation, string emailfromname, string emailfrom, string emailsubject, string emailbody, string textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationsendExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var emailenabled = true;  // bool? | Whether send the notification via email.
            var onscreenenabled = true;  // bool? | Whether to display the notification on screen.
            var smsenabled = true;  // bool? | Whether to send the notification via text message.
            var title = title_example;  // string | Notification title.
            var tousers = tousers_example;  // string | Comma-separated Ids of users to send the notification. (optional) 
            var togroups = togroups_example;  // string | Comma-separated Ids of user groups to send the notification. (optional) 
            var onscreenbody = onscreenbody_example;  // string | Body of the message for on-screen display. (optional) 
            var onscreenclick = onscreenclick_example;  // string | What to do when the notification is clicked. Valid values: hide, view, url. (optional) 
            var onscreenurl = onscreenurl_example;  // string | Url to redirect the user, if onscreenclick=url. (optional) 
            var onscreenclass = onscreenclass_example;  // string | How to display the notification. Valid values: info, success, warning, error (optional) 
            var onscreenduration = 56;  // int? | Time in seconds to display the notification. (optional) 
            var showonstation = 56;  // int? | Whether to show the notification in the sign-in station. (optional) 
            var emailfromname = emailfromname_example;  // string | Name of the email sender. (optional) 
            var emailfrom = emailfrom_example;  // string | Reply-to email. (optional) 
            var emailsubject = emailsubject_example;  // string | Subject of the email. (optional) 
            var emailbody = emailbody_example;  // string | Body of the email. (optional) 
            var textmessagebody = textmessagebody_example;  // string | Message for SMS. Max 160 characters. (optional) 

            try
            {
                // Send notifications on screen, via email or text to users
                apiInstance.Notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationsend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **emailenabled** | **bool?**| Whether send the notification via email. | 
 **onscreenenabled** | **bool?**| Whether to display the notification on screen. | 
 **smsenabled** | **bool?**| Whether to send the notification via text message. | 
 **title** | **string**| Notification title. | 
 **tousers** | **string**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **string**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **string**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **string**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **string**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **string**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **int?**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **int?**| Whether to show the notification in the sign-in station. | [optional] 
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

<a name="notificationsendonscreen"></a>
# **Notificationsendonscreen**
> void Notificationsendonscreen (string token, Guid? notification)

Send on-screen notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationsendonscreenExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var notification = new Guid?(); // Guid? | The ID of the notification to send.

            try
            {
                // Send on-screen notifications
                apiInstance.Notificationsendonscreen(token, notification);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationsendonscreen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **notification** | [**Guid?**](.md)| The ID of the notification to send. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopicdelete"></a>
# **Notificationtopicdelete**
> void Notificationtopicdelete (string token, Guid? id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification topic to delete.

            try
            {
                // Delete a notification topic
                apiInstance.Notificationtopicdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopicdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification topic to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopicget"></a>
# **Notificationtopicget**
> void Notificationtopicget (string token, Guid? id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification topic to get.

            try
            {
                // Search and view details of a notification topic
                apiInstance.Notificationtopicget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopicget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification topic to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopiclist"></a>
# **Notificationtopiclist**
> void Notificationtopiclist (string token, int? from, int? count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopiclistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // List all the notification topics
                apiInstance.Notificationtopiclist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopiclist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopiclistsubscribe"></a>
# **Notificationtopiclistsubscribe**
> void Notificationtopiclistsubscribe (string token)

List all the notification topics available to subscribe

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopiclistsubscribeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // List all the notification topics available to subscribe
                apiInstance.Notificationtopiclistsubscribe(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopiclistsubscribe: " + e.Message );
            }
        }
    }
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

<a name="notificationtopicsave"></a>
# **Notificationtopicsave**
> void Notificationtopicsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a notification topic
                apiInstance.Notificationtopicsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopicsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pushderegister"></a>
# **Pushderegister**
> void Pushderegister (string devicetoken, string platform)

Deregisters the current device to receive push notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PushderegisterExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var devicetoken = devicetoken_example;  // string | The device token where to send the notification.
            var platform = platform_example;  // string | Either ios or android

            try
            {
                // Deregisters the current device to receive push notifications
                apiInstance.Pushderegister(devicetoken, platform);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Pushderegister: " + e.Message );
            }
        }
    }
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

<a name="pushregister"></a>
# **Pushregister**
> void Pushregister (string devicetoken, string platform)

Registers the current device to receive push notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PushregisterExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var devicetoken = devicetoken_example;  // string | The device token where to send the notification.
            var platform = platform_example;  // string | Either ios or android

            try
            {
                // Registers the current device to receive push notifications
                apiInstance.Pushregister(devicetoken, platform);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Pushregister: " + e.Message );
            }
        }
    }
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

<a name="qrlabelsprint"></a>
# **Qrlabelsprint**
> void Qrlabelsprint (string token, Guid? user, Guid? group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrlabelsprintExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var user = new Guid?(); // Guid? | The id of the user whose label needs to be printed. (optional) 
            var group = new Guid?(); // Guid? | The id of the group whose members' labels need to be printed. (optional) 

            try
            {
                // Print and email QR labels
                apiInstance.Qrlabelsprint(token, user, group);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Qrlabelsprint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **user** | [**Guid?**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**Guid?**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="qrloginget"></a>
# **Qrloginget**
> void Qrloginget (string token)

Gets an image of a QR token

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrlogingetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets an image of a QR token
                apiInstance.Qrloginget(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Qrloginget: " + e.Message );
            }
        }
    }
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

<a name="qrloginlogin"></a>
# **Qrloginlogin**
> void Qrloginlogin (string onetimetoken)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrloginloginExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var onetimetoken = onetimetoken_example;  // string | The token read from the QR code.

            try
            {
                // Login
                apiInstance.Qrloginlogin(onetimetoken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Qrloginlogin: " + e.Message );
            }
        }
    }
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

<a name="quickpaneldeletewidget"></a>
# **Quickpaneldeletewidget**
> void Quickpaneldeletewidget (string token, Guid? id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpaneldeletewidgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the widget.

            try
            {
                // Deletes a widget from the Quick Panel
                apiInstance.Quickpaneldeletewidget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpaneldeletewidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the widget. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelfetchwidget"></a>
# **Quickpanelfetchwidget**
> void Quickpanelfetchwidget (string token, Guid? widgetid)

Fetches the information for a specific widget.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelfetchwidgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var widgetid = new Guid?(); // Guid? | The ID of the data to fetch it's data.

            try
            {
                // Fetches the information for a specific widget.
                apiInstance.Quickpanelfetchwidget(token, widgetid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelfetchwidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **widgetid** | [**Guid?**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelgetwidget"></a>
# **Quickpanelgetwidget**
> void Quickpanelgetwidget (string token, Guid? id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelgetwidgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the widget to get.

            try
            {
                // View details of a widget included in the Quick Panel
                apiInstance.Quickpanelgetwidget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelgetwidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the widget to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelinit"></a>
# **Quickpanelinit**
> void Quickpanelinit (string token)

Returns the initial information required to show the quick panels

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelinitExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Returns the initial information required to show the quick panels
                apiInstance.Quickpanelinit(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelinit: " + e.Message );
            }
        }
    }
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

<a name="quickpanellistwidgets"></a>
# **Quickpanellistwidgets**
> void Quickpanellistwidgets (string token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanellistwidgetsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists all the widgets that are added in the Quick Panel
                apiInstance.Quickpanellistwidgets(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanellistwidgets: " + e.Message );
            }
        }
    }
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

<a name="quickpanellistwidgettypes"></a>
# **Quickpanellistwidgettypes**
> void Quickpanellistwidgettypes (string token)

Lists all the widget types available in the system

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanellistwidgettypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists all the widget types available in the system
                apiInstance.Quickpanellistwidgettypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanellistwidgettypes: " + e.Message );
            }
        }
    }
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

<a name="quickpanelreorderwidgets"></a>
# **Quickpanelreorderwidgets**
> void Quickpanelreorderwidgets (string token, string sectionname, string orderids)

Reorders the widgets and moves them to a specific column

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelreorderwidgetsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var sectionname = sectionname_example;  // string | The section name where to sort the widgets.
            var orderids = orderids_example;  // string | CSV list of the widgets to reorder.

            try
            {
                // Reorders the widgets and moves them to a specific column
                apiInstance.Quickpanelreorderwidgets(token, sectionname, orderids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelreorderwidgets: " + e.Message );
            }
        }
    }
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

<a name="quickpanelsavewidget"></a>
# **Quickpanelsavewidget**
> void Quickpanelsavewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelsavewidgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a widget for the Quick Panel
                apiInstance.Quickpanelsavewidget(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelsavewidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingflag"></a>
# **Ratingflag**
> void Ratingflag (string token, Guid? id, string comment)

Flags one rating for moderation

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingflagExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The rating to flag.
            var comment = comment_example;  // string | Comment why should this should be removed. (optional) 

            try
            {
                // Flags one rating for moderation
                apiInstance.Ratingflag(token, id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratingflag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The rating to flag. | 
 **comment** | **string**| Comment why should this should be removed. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingflagcomment"></a>
# **Ratingflagcomment**
> void Ratingflagcomment (string token, Guid? id, string comment)

Flags one comment for moderation

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingflagcommentExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The comment to flag.
            var comment = comment_example;  // string | Comment why should this should be removed. (optional) 

            try
            {
                // Flags one comment for moderation
                apiInstance.Ratingflagcomment(token, id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratingflagcomment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The comment to flag. | 
 **comment** | **string**| Comment why should this should be removed. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingget"></a>
# **Ratingget**
> void Ratingget (string token, string type, string entityids)

Get rating for one or more entities

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatinggetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var type = type_example;  // string | The entity type to get the rating.
            var entityids = entityids_example;  // string | List of ids to get the ratings.

            try
            {
                // Get rating for one or more entities
                apiInstance.Ratingget(token, type, entityids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratingget: " + e.Message );
            }
        }
    }
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

<a name="ratinggetall"></a>
# **Ratinggetall**
> void Ratinggetall (string token, string type, string entityid, bool? mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatinggetallExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var type = type_example;  // string | The entity type to get the rating.
            var entityid = entityid_example;  // string | Id of the entity to get the ratings.
            var mostrecentfirst = true;  // bool? | True to show most recent first, otherwise most helpful first. (optional) 

            try
            {
                // Gets the full ratings and comments for a specific entity
                apiInstance.Ratinggetall(token, type, entityid, mostrecentfirst);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratinggetall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **type** | **string**| The entity type to get the rating. | 
 **entityid** | **string**| Id of the entity to get the ratings. | 
 **mostrecentfirst** | **bool?**| True to show most recent first, otherwise most helpful first. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratinggetcomments"></a>
# **Ratinggetcomments**
> void Ratinggetcomments (string token, Guid? ratingid)

Gets all the comments for a rating

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatinggetcommentsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var ratingid = new Guid?(); // Guid? | The ID of the rating to get all comments.

            try
            {
                // Gets all the comments for a rating
                apiInstance.Ratinggetcomments(token, ratingid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratinggetcomments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **ratingid** | [**Guid?**](.md)| The ID of the rating to get all comments. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratinggetpending"></a>
# **Ratinggetpending**
> void Ratinggetpending (Guid? getgroup, Guid? rateid, int? rateval)

Gets info of pre-saved and pre-approved ratings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatinggetpendingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var getgroup = new Guid?(); // Guid? | The ID of the group of pending ratings to get.
            var rateid = new Guid?(); // Guid? | Rate this before returning. (optional) 
            var rateval = 56;  // int? | The value used to rate the item specified in rateid. (optional) 

            try
            {
                // Gets info of pre-saved and pre-approved ratings
                apiInstance.Ratinggetpending(getgroup, rateid, rateval);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratinggetpending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**Guid?**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**Guid?**](.md)| Rate this before returning. | [optional] 
 **rateval** | **int?**| The value used to rate the item specified in rateid. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratinggetpendingmoderation"></a>
# **Ratinggetpendingmoderation**
> void Ratinggetpendingmoderation (string token)

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatinggetpendingmoderationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Shows a list of the ratings and comments that are pending for moderation
                apiInstance.Ratinggetpendingmoderation(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratinggetpendingmoderation: " + e.Message );
            }
        }
    }
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

<a name="ratingmoderate"></a>
# **Ratingmoderate**
> void Ratingmoderate (string token, string type, Guid? id, bool? approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingmoderateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var type = type_example;  // string | Either 'rating' or 'comment' depending on what you want to moderate.
            var id = new Guid?(); // Guid? | Id of the rating or comment, as specified in type.
            var approve = true;  // bool? | True to approve, false to reject.

            try
            {
                // Allows the user to accept or reject a comment
                apiInstance.Ratingmoderate(token, type, id, approve);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratingmoderate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **type** | **string**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**Guid?**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **bool?**| True to approve, false to reject. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingpostcomment"></a>
# **Ratingpostcomment**
> void Ratingpostcomment (string token, Guid? ratingid, string comment, bool? annonymous)

Posts a comments for in a rating

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingpostcommentExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var ratingid = new Guid?(); // Guid? | The ID of the rating to post the comment.
            var comment = comment_example;  // string | Text of the comment to post.
            var annonymous = true;  // bool? | True to post the comment annonymously.

            try
            {
                // Posts a comments for in a rating
                apiInstance.Ratingpostcomment(token, ratingid, comment, annonymous);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratingpostcomment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **ratingid** | [**Guid?**](.md)| The ID of the rating to post the comment. | 
 **comment** | **string**| Text of the comment to post. | 
 **annonymous** | **bool?**| True to post the comment annonymously. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingrate"></a>
# **Ratingrate**
> void Ratingrate (string token, string type, string entityid, bool? annonymous, int? value, string comment, bool? updatecomment)

Rates one entity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingrateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var type = type_example;  // string | The entity type to rate.
            var entityid = entityid_example;  // string | Id of the entity to rate.
            var annonymous = true;  // bool? | Whether to post as annonymous.
            var value = 56;  // int? | Value from 0 to 100 with the rating. (optional) 
            var comment = comment_example;  // string | Comment associated with this review. Comment can be updated later on another request too. (optional) 
            var updatecomment = true;  // bool? | Whether to update the comments. Defaults to true. (optional) 

            try
            {
                // Rates one entity
                apiInstance.Ratingrate(token, type, entityid, annonymous, value, comment, updatecomment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratingrate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **type** | **string**| The entity type to rate. | 
 **entityid** | **string**| Id of the entity to rate. | 
 **annonymous** | **bool?**| Whether to post as annonymous. | 
 **value** | **int?**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **bool?**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingratepending"></a>
# **Ratingratepending**
> void Ratingratepending (Guid? group, bool? annonymous, Guid? rateid, int? value, string comment, bool? updatecomment)

Rates a pre-saved and pre-approved entity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingratependingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var group = new Guid?(); // Guid? | The ID of the group of with pre-approved ratings.
            var annonymous = true;  // bool? | Whether to post as annonymous.
            var rateid = new Guid?(); // Guid? | Rate this before returning. (optional) 
            var value = 56;  // int? | Value from 0 to 100 with the rating. (optional) 
            var comment = comment_example;  // string | Comment associated with this review. Comment can be updated later on another request too. (optional) 
            var updatecomment = true;  // bool? | Whether to update the comments. Defaults to true. (optional) 

            try
            {
                // Rates a pre-saved and pre-approved entity
                apiInstance.Ratingratepending(group, annonymous, rateid, value, comment, updatecomment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratingratepending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**Guid?**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **bool?**| Whether to post as annonymous. | 
 **rateid** | [**Guid?**](.md)| Rate this before returning. | [optional] 
 **value** | **int?**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **bool?**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingvote"></a>
# **Ratingvote**
> void Ratingvote (string token, Guid? ratingid, int? vote)

Votes up or down a rating

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingvoteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var ratingid = new Guid?(); // Guid? | The ID of the rating to vote on.
            var vote = 56;  // int? | 1 to vote up, -1 to vote down.

            try
            {
                // Votes up or down a rating
                apiInstance.Ratingvote(token, ratingid, vote);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ratingvote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **ratingid** | [**Guid?**](.md)| The ID of the rating to vote on. | 
 **vote** | **int?**| 1 to vote up, -1 to vote down. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportattanalyticsprepare"></a>
# **Reportattanalyticsprepare**
> void Reportattanalyticsprepare (string token, string reportname, string _params, Guid? refreshgroup)

Query and load an attendance analytics report

Allows the user to query and load attendance analytics reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportattanalyticsprepareExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var reportname = reportname_example;  // string | The name of the report to execute
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 
            var refreshgroup = new Guid?(); // Guid? | The ID of the group to check (and refresh) before processing the report. (optional) 

            try
            {
                // Query and load an attendance analytics report
                apiInstance.Reportattanalyticsprepare(token, reportname, _params, refreshgroup);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportattanalyticsprepare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **refreshgroup** | [**Guid?**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportlist"></a>
# **Reportlist**
> void Reportlist (string token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of available reports
                apiInstance.Reportlist(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportlist: " + e.Message );
            }
        }
    }
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

<a name="reportpermissionsbyuser"></a>
# **Reportpermissionsbyuser**
> void Reportpermissionsbyuser (string token, string _params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportpermissionsbyuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 

            try
            {
                // Permissions by user report
                apiInstance.Reportpermissionsbyuser(token, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportpermissionsbyuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportprepare"></a>
# **Reportprepare**
> void Reportprepare (string token, string reportname, string _params, string repformat, Guid? fillgroupid, string groupby, Guid? refreshgroup, string filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportprepareExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var reportname = reportname_example;  // string | The name of the report to execute
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 
            var repformat = repformat_example;  // string | The format of the resulting report. Json, pdf, csv, ... (optional) 
            var fillgroupid = new Guid?(); // Guid? | If specified, the result is used to fill the group with the given ID (optional) 
            var groupby = groupby_example;  // string | How to group the records. In the format 'col1+col2|col3+col4 (optional) 
            var refreshgroup = new Guid?(); // Guid? | The ID of the group to check (and refresh) before processing the report. (optional) 
            var filtertext = filtertext_example;  // string | The user friendly text of the applied filters. (optional) 

            try
            {
                // Queries and loads the specified report, in background.
                apiInstance.Reportprepare(token, reportname, _params, repformat, fillgroupid, groupby, refreshgroup, filtertext);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportprepare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **string**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**Guid?**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **string**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**Guid?**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **string**| The user friendly text of the applied filters. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportquery"></a>
# **Reportquery**
> void Reportquery (string token, string reportname, string _params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportqueryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var reportname = reportname_example;  // string | The name of the report to execute
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 

            try
            {
                // Query and load a specified report
                apiInstance.Reportquery(token, reportname, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportquery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportscheduledelete"></a>
# **Reportscheduledelete**
> void Reportscheduledelete (string token, Guid? id)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportscheduledeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the report schedule to delete.

            try
            {
                // Delete a report schedule
                apiInstance.Reportscheduledelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportscheduledelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the report schedule to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportscheduleget"></a>
# **Reportscheduleget**
> void Reportscheduleget (string token, Guid? id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportschedulegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the schedule to get.

            try
            {
                // Get a report schedule
                apiInstance.Reportscheduleget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportscheduleget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the schedule to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportschedulelist"></a>
# **Reportschedulelist**
> void Reportschedulelist (string token, int? from, int? count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportschedulelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of the scheduled reports
                apiInstance.Reportschedulelist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportschedulelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportschedulesave"></a>
# **Reportschedulesave**
> void Reportschedulesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportschedulesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a report schedule
                apiInstance.Reportschedulesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportschedulesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reporttagresults"></a>
# **Reporttagresults**
> void Reporttagresults (string token, string reportname, bool? assign, string tags, string _params)

Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.

Allows the user to use a report to assign or unassign tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReporttagresultsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var reportname = reportname_example;  // string | The name of the report to execute
            var assign = true;  // bool? | Specify whether the specified tags have to be assigned or unassigned.
            var tags = tags_example;  // string | The tags to assign (or unassign) to the resulting users in the report, in JSON format.
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 

            try
            {
                // Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
                apiInstance.Reporttagresults(token, reportname, assign, tags, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reporttagresults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **assign** | **bool?**| Specify whether the specified tags have to be assigned or unassigned. | 
 **tags** | **string**| The tags to assign (or unassign) to the resulting users in the report, in JSON format. | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelcheckanalysis"></a>
# **Riskmodelcheckanalysis**
> void Riskmodelcheckanalysis (string token, Guid? id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelcheckanalysisExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the risk assessment model whose analysis status has to be returned.

            try
            {
                // Check the status of the analysis of a specified risk assessment model
                apiInstance.Riskmodelcheckanalysis(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodelcheckanalysis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodeldelete"></a>
# **Riskmodeldelete**
> void Riskmodeldelete (string token, Guid? id)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodeldeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the risk assessment model to delete.

            try
            {
                // Delete a risk assessment model
                apiInstance.Riskmodeldelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodeldelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the risk assessment model to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelget"></a>
# **Riskmodelget**
> void Riskmodelget (string token, Guid? id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the risk assessment model to get.

            try
            {
                // View details of a risk assessment model
                apiInstance.Riskmodelget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodelget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the risk assessment model to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelgetscore"></a>
# **Riskmodelgetscore**
> void Riskmodelgetscore (string token, Guid? userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelgetscoreExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to get the risk score.

            try
            {
                // View the risk score for a specific user
                apiInstance.Riskmodelgetscore(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodelgetscore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to get the risk score. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodellist"></a>
# **Riskmodellist**
> void Riskmodellist (string token, int? from, int? count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodellistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of risk assessment models
                apiInstance.Riskmodellist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodellist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelpredict"></a>
# **Riskmodelpredict**
> void Riskmodelpredict (string token, Guid? id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelpredictExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the assessment model to use in order to predict risk.

            try
            {
                // Predict risk based on an assessment model
                apiInstance.Riskmodelpredict(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodelpredict: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the assessment model to use in order to predict risk. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelprocess"></a>
# **Riskmodelprocess**
> void Riskmodelprocess (string token, Guid? id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelprocessExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the risk assessment model to process.

            try
            {
                // Process a risk assessment model
                apiInstance.Riskmodelprocess(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodelprocess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the risk assessment model to process. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelrefresh"></a>
# **Riskmodelrefresh**
> void Riskmodelrefresh (string token, Guid? id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelrefreshExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the risk assessment model whose information has to be refreshed.

            try
            {
                // Refresh the information used in a risk assessment model
                apiInstance.Riskmodelrefresh(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodelrefresh: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodelsave"></a>
# **Riskmodelsave**
> void Riskmodelsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodelsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a risk assessment model
                apiInstance.Riskmodelsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodelsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="riskmodeltermprecedences"></a>
# **Riskmodeltermprecedences**
> void Riskmodeltermprecedences (string token)

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RiskmodeltermprecedencesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View all default term precedences
                apiInstance.Riskmodeltermprecedences(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Riskmodeltermprecedences: " + e.Message );
            }
        }
    }
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

<a name="rolelist"></a>
# **Rolelist**
> void Rolelist (string token, string name)

Show a list of roles

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RolelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var name = name_example;  // string | Filter by name of the role. (optional) 

            try
            {
                // Show a list of roles
                apiInstance.Rolelist(token, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rolelist: " + e.Message );
            }
        }
    }
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

<a name="ruledelete"></a>
# **Ruledelete**
> void Ruledelete (string token, Guid? id)

Delete a rule

Allows the user to delete an existing rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuledeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the rule to delete.

            try
            {
                // Delete a rule
                apiInstance.Ruledelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ruledelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the rule to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ruleget"></a>
# **Ruleget**
> void Ruleget (string token, Guid? id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the rule to get.

            try
            {
                // View details of a rule
                apiInstance.Ruleget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ruleget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the rule to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulegeteventtype"></a>
# **Rulegeteventtype**
> void Rulegeteventtype (string token, string _event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulegeteventtypeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var _event = _event_example;  // string | The name of the event to refresh.

            try
            {
                // View details of a rule event type
                apiInstance.Rulegeteventtype(token, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulegeteventtype: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **_event** | **string**| The name of the event to refresh. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulelist"></a>
# **Rulelist**
> void Rulelist (string token, int? from, int? count)

View a list of user rules

Allows the user to view the list of all rules.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of user rules
                apiInstance.Rulelist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulelistactions"></a>
# **Rulelistactions**
> void Rulelistactions (string token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulelistactionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of rule actions available
                apiInstance.Rulelistactions(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulelistactions: " + e.Message );
            }
        }
    }
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

<a name="rulelisteventtypes"></a>
# **Rulelisteventtypes**
> void Rulelisteventtypes (string token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulelisteventtypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of rule event types
                apiInstance.Rulelisteventtypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulelisteventtypes: " + e.Message );
            }
        }
    }
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

<a name="rulelisthttprequests"></a>
# **Rulelisthttprequests**
> void Rulelisthttprequests (string token, int? from, int? count, bool? failed, int? status)

View all the http requests sent as a result of a rule

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulelisthttprequestsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var failed = true;  // bool? | If true only failed requests will be returned (optional) 
            var status = 56;  // int? | The http status to filter the requests (optional) 

            try
            {
                // View all the http requests sent as a result of a rule
                apiInstance.Rulelisthttprequests(token, from, count, failed, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulelisthttprequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **failed** | **bool?**| If true only failed requests will be returned | [optional] 
 **status** | **int?**| The http status to filter the requests | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulesave"></a>
# **Rulesave**
> void Rulesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a rule

Allows the user to create or edit a rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a rule
                apiInstance.Rulesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduledelete"></a>
# **Scheduledelete**
> void Scheduledelete (string token, Guid? scheduleid)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduledeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var scheduleid = new Guid?(); // Guid? | The id of the schedule.

            try
            {
                // Delete a schedule slot
                apiInstance.Scheduledelete(token, scheduleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduledelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **scheduleid** | [**Guid?**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduledeletemine"></a>
# **Scheduledeletemine**
> void Scheduledeletemine (string token, Guid? scheduleid)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduledeletemineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var scheduleid = new Guid?(); // Guid? | The id of the schedule.

            try
            {
                // Delete a specific block from a user's own schedule
                apiInstance.Scheduledeletemine(token, scheduleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduledeletemine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **scheduleid** | [**Guid?**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleenable"></a>
# **Scheduleenable**
> void Scheduleenable (string token, Guid? userid, bool? enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleenableExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to enable or disable the schedule.
            var enable = true;  // bool? | True to enable schedules, false to disable.

            try
            {
                // Enable or disable the schedule for a specific person
                apiInstance.Scheduleenable(token, userid, enable);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduleenable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **bool?**| True to enable schedules, false to disable. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleenablemine"></a>
# **Scheduleenablemine**
> void Scheduleenablemine (string token, bool? enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleenablemineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var enable = true;  // bool? | True to enable schedules, false to disable.

            try
            {
                // Enable or disable current user's schedule
                apiInstance.Scheduleenablemine(token, enable);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduleenablemine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **enable** | **bool?**| True to enable schedules, false to disable. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulefindallstaffslots"></a>
# **Schedulefindallstaffslots**
> void Schedulefindallstaffslots (string token, DateTime? starttime, DateTime? endtime, Guid? staffid, string serviceids, Guid? eventid, Guid? locationid, string staffroleids, string availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulefindallstaffslotsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var staffid = new Guid?(); // Guid? | The id of the staff to filter by. (optional) 
            var serviceids = serviceids_example;  // string | CSV list of the service Ids to filter by. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the location to filter by. (optional) 
            var staffroleids = staffroleids_example;  // string | CSV list of the staff member role ids to filter by. (optional) 
            var availablefor = availablefor_example;  // string | The specific availability type to filter by. (optional) 

            try
            {
                // Search available schedule slots by service, event, date
                apiInstance.Schedulefindallstaffslots(token, starttime, endtime, staffid, serviceids, eventid, locationid, staffroleids, availablefor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulefindallstaffslots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **staffid** | [**Guid?**](.md)| The id of the staff to filter by. | [optional] 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the location to filter by. | [optional] 
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

<a name="schedulefindslots"></a>
# **Schedulefindslots**
> void Schedulefindslots (string token, Guid? staffid, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid, string availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulefindslotsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var staffid = new Guid?(); // Guid? | The id of the staff to filter by.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var serviceids = serviceids_example;  // string | CSV list of the service Ids to filter by. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the service to filter by. (optional) 
            var availablefor = availablefor_example;  // string | The specific availability type to filter by. (optional) 

            try
            {
                // Search available schedule slots by service, event, date and/or staff
                apiInstance.Schedulefindslots(token, staffid, starttime, endtime, serviceids, eventid, locationid, availablefor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulefindslots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **staffid** | [**Guid?**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | [optional] 
 **availablefor** | **string**| The specific availability type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulefindstaffavail"></a>
# **Schedulefindstaffavail**
> void Schedulefindstaffavail (string token, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid, string staffroleids, string availablefor, int? photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulefindstaffavailExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var starttime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the range to look for slots.
            var endtime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the range to look for slots.
            var serviceids = serviceids_example;  // string | CSV list of the service ids to filter by. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to filter by. (optional) 
            var locationid = new Guid?(); // Guid? | The id of the service to filter by. (optional) 
            var staffroleids = staffroleids_example;  // string | CSV list of the staff member role ids to filter by. (optional) 
            var availablefor = availablefor_example;  // string | Filter slots by a specific availability type. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Search available staff members slots by service, event, and/or date
                apiInstance.Schedulefindstaffavail(token, starttime, endtime, serviceids, eventid, locationid, staffroleids, availablefor, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulefindstaffavail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **starttime** | **DateTime?**| The start time of the range to look for slots. | 
 **endtime** | **DateTime?**| The end time of the range to look for slots. | 
 **serviceids** | **string**| CSV list of the service ids to filter by. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**Guid?**](.md)| The id of the service to filter by. | [optional] 
 **staffroleids** | **string**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **string**| Filter slots by a specific availability type. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleget"></a>
# **Scheduleget**
> void Scheduleget (string token, Guid? scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var scheduleid = new Guid?(); // Guid? | The id of the schedule.

            try
            {
                // Search and view details of a specific schedule slot
                apiInstance.Scheduleget(token, scheduleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduleget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **scheduleid** | [**Guid?**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulegetmine"></a>
# **Schedulegetmine**
> void Schedulegetmine (string token, Guid? scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulegetmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var scheduleid = new Guid?(); // Guid? | The id of the schedule.

            try
            {
                // View details of a specific schedule block, for current user
                apiInstance.Schedulegetmine(token, scheduleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulegetmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **scheduleid** | [**Guid?**](.md)| The id of the schedule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulegetstaff"></a>
# **Schedulegetstaff**
> void Schedulegetstaff (string token, Guid? userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulegetstaffExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to get info.

            try
            {
                // View a list of schedule information of a specified person
                apiInstance.Schedulegetstaff(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulegetstaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to get info. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulegetstaffmine"></a>
# **Schedulegetstaffmine**
> void Schedulegetstaffmine (string token)

View current user's schedule information

Allows the user to view their own schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulegetstaffmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View current user's schedule information
                apiInstance.Schedulegetstaffmine(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulegetstaffmine: " + e.Message );
            }
        }
    }
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

<a name="scheduleintegrationdeleteitem"></a>
# **Scheduleintegrationdeleteitem**
> void Scheduleintegrationdeleteitem (string token, string thirdpartyid)

Delete a schedule item looking up by a third party ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationdeleteitemExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var thirdpartyid = thirdpartyid_example;  // string | The third party id to search the schedule block / appointment.

            try
            {
                // Delete a schedule item looking up by a third party ID
                apiInstance.Scheduleintegrationdeleteitem(token, thirdpartyid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduleintegrationdeleteitem: " + e.Message );
            }
        }
    }
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

<a name="scheduleintegrationdeleteitemsbymasterid"></a>
# **Scheduleintegrationdeleteitemsbymasterid**
> void Scheduleintegrationdeleteitemsbymasterid (string token, string thirdpartymasterid)

Delete multiple schedule items looking up by a third party master ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationdeleteitemsbymasteridExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var thirdpartymasterid = thirdpartymasterid_example;  // string | The third party master id to search the schedule items.

            try
            {
                // Delete multiple schedule items looking up by a third party master ID
                apiInstance.Scheduleintegrationdeleteitemsbymasterid(token, thirdpartymasterid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduleintegrationdeleteitemsbymasterid: " + e.Message );
            }
        }
    }
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

<a name="scheduleintegrationgetitem"></a>
# **Scheduleintegrationgetitem**
> void Scheduleintegrationgetitem (string token, string thirdpartyid)

Get a schedule item looking up by a third party ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationgetitemExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var thirdpartyid = thirdpartyid_example;  // string | The third party id to search for the schedule item.

            try
            {
                // Get a schedule item looking up by a third party ID
                apiInstance.Scheduleintegrationgetitem(token, thirdpartyid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduleintegrationgetitem: " + e.Message );
            }
        }
    }
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

<a name="scheduleintegrationsaveitem"></a>
# **Scheduleintegrationsaveitem**
> void Scheduleintegrationsaveitem (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a schedule item looking up by a third party ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationsaveitemExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a schedule item looking up by a third party ID
                apiInstance.Scheduleintegrationsaveitem(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduleintegrationsaveitem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleintegrationsetid"></a>
# **Scheduleintegrationsetid**
> void Scheduleintegrationsetid (string token, Guid? id, string thirdpartyid, string thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationsetidExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the schedule block / appointment.
            var thirdpartyid = thirdpartyid_example;  // string | The 3rd party ID to set.
            var thirdpartymasterid = thirdpartymasterid_example;  // string | The 3rd party master ID to set (useful to handle recurring items). (optional) 

            try
            {
                // Set a 3rd party ID on a specific schedule item
                apiInstance.Scheduleintegrationsetid(token, id, thirdpartyid, thirdpartymasterid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Scheduleintegrationsetid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the schedule block / appointment. | 
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

<a name="schedulemyofftimes"></a>
# **Schedulemyofftimes**
> void Schedulemyofftimes (string token, bool? includedeleted, bool? onlyupcoming, DateTime? modifiedafter)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulemyofftimesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var includedeleted = true;  // bool? | If true the deleted offtimes are also returned. (optional) 
            var onlyupcoming = true;  // bool? | If true then only upcoming offtimes are returned. (optional) 
            var modifiedafter = 2013-10-20T19:20:30+01:00;  // DateTime? | If specified, only offtimes modified after the specified date will be returned. (optional) 

            try
            {
                // View current user's schedule exceptions
                apiInstance.Schedulemyofftimes(token, includedeleted, onlyupcoming, modifiedafter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulemyofftimes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **includedeleted** | **bool?**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **bool?**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **DateTime?**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulesave"></a>
# **Schedulesave**
> void Schedulesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a schedule slot
                apiInstance.Schedulesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulesavemine"></a>
# **Schedulesavemine**
> void Schedulesavemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SchedulesavemineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a block in current user's schedule
                apiInstance.Schedulesavemine(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Schedulesavemine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search"></a>
# **Search**
> void Search (string token, string query, int? page)

Search

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var query = query_example;  // string | The query to search for.
            var page = 56;  // int? | Current page to show, zero-based. (optional) 

            try
            {
                // Search
                apiInstance.Search(token, query, page);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | **string**| The query to search for. | 
 **page** | **int?**| Current page to show, zero-based. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchgetentities"></a>
# **Searchgetentities**
> void Searchgetentities (string token)

Get the information of the entities that can be searched

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchgetentitiesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Get the information of the entities that can be searched
                apiInstance.Searchgetentities(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Searchgetentities: " + e.Message );
            }
        }
    }
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

<a name="securityassesspermission"></a>
# **Securityassesspermission**
> void Securityassesspermission (string token, string commandname)

Returns the list of users for a specific permission

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityassesspermissionExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var commandname = commandname_example;  // string | Name of the action or command to get the roles.

            try
            {
                // Returns the list of users for a specific permission
                apiInstance.Securityassesspermission(token, commandname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Securityassesspermission: " + e.Message );
            }
        }
    }
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

<a name="securityassessrole"></a>
# **Securityassessrole**
> void Securityassessrole (string token, Guid? roleid)

Returns the list of permissions for a specific role

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityassessroleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var roleid = new Guid?(); // Guid? | Role ID to list the effective permissions.

            try
            {
                // Returns the list of permissions for a specific role
                apiInstance.Securityassessrole(token, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Securityassessrole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **roleid** | [**Guid?**](.md)| Role ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityassessscope"></a>
# **Securityassessscope**
> void Securityassessscope (string token, Guid? locationid)

Returns the list of users for a specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityassessscopeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var locationid = new Guid?(); // Guid? | Location ID to list the users with that scope. (optional) 

            try
            {
                // Returns the list of users for a specific user
                apiInstance.Securityassessscope(token, locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Securityassessscope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **locationid** | [**Guid?**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityassessuser"></a>
# **Securityassessuser**
> void Securityassessuser (string token, Guid? userid)

Returns the list of permissions for a specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityassessuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | User ID to list the effective permissions.

            try
            {
                // Returns the list of permissions for a specific user
                apiInstance.Securityassessuser(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Securityassessuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| User ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="seminardelete"></a>
# **Seminardelete**
> void Seminardelete (string token, Guid? id)

Delete an event

Allows the user to delete an existing event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SeminardeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the seminar to delete.

            try
            {
                // Delete an event
                apiInstance.Seminardelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Seminardelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the seminar to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="seminarget"></a>
# **Seminarget**
> void Seminarget (string token, Guid? id)

Search and view details of a event

Allows the user to view a event and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SeminargetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the seminar to get.

            try
            {
                // Search and view details of a event
                apiInstance.Seminarget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Seminarget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the seminar to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="seminarlist"></a>
# **Seminarlist**
> void Seminarlist (string token, string from, string count, bool? summaryonly, Guid? termid)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SeminarlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = from_example;  // string | The first record to return.
            var count = count_example;  // string | The max number of records to return.
            var summaryonly = true;  // bool? | True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional) 
            var termid = new Guid?(); // Guid? | Id of the term to list the events. Null to list all events. (optional) 

            try
            {
                // View a list of events
                apiInstance.Seminarlist(token, from, count, summaryonly, termid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Seminarlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **bool?**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**Guid?**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="seminarsave"></a>
# **Seminarsave**
> void Seminarsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a event

Allows the user to create or edit a event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SeminarsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a event
                apiInstance.Seminarsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Seminarsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceassignmentaddservice"></a>
# **Serviceassignmentaddservice**
> void Serviceassignmentaddservice (string token, Guid? serviceid, Guid? locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServiceassignmentaddserviceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceid = new Guid?(); // Guid? | The id of the service to add.
            var locationid = new Guid?(); // Guid? | The id of the location.

            try
            {
                // Enable a service in a specific location
                apiInstance.Serviceassignmentaddservice(token, serviceid, locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Serviceassignmentaddservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**Guid?**](.md)| The id of the service to add. | 
 **locationid** | [**Guid?**](.md)| The id of the location. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceassignmentgetlocation"></a>
# **Serviceassignmentgetlocation**
> void Serviceassignmentgetlocation (string token, Guid? locationid, bool? includegloballyavailable, bool? namefilter, int? count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServiceassignmentgetlocationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var locationid = new Guid?(); // Guid? | The id of the location to get.
            var includegloballyavailable = true;  // bool? | Specifies whether the services available globally must be returned or not. (optional) 
            var namefilter = true;  // bool? | Filters the name of the services to return. (optional) 
            var count = 56;  // int? | The max number of services to return. (optional) 

            try
            {
                // View a list of services enabled for a specific location
                apiInstance.Serviceassignmentgetlocation(token, locationid, includegloballyavailable, namefilter, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Serviceassignmentgetlocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **locationid** | [**Guid?**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **bool?**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **bool?**| Filters the name of the services to return. | [optional] 
 **count** | **int?**| The max number of services to return. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceassignmentgetservice"></a>
# **Serviceassignmentgetservice**
> void Serviceassignmentgetservice (string token, Guid? serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServiceassignmentgetserviceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceid = new Guid?(); // Guid? | The id of the service to get its locations.

            try
            {
                // View a list of locations where a service is available
                apiInstance.Serviceassignmentgetservice(token, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Serviceassignmentgetservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**Guid?**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceassignmentremoveservice"></a>
# **Serviceassignmentremoveservice**
> void Serviceassignmentremoveservice (string token, Guid? serviceid, Guid? locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServiceassignmentremoveserviceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceid = new Guid?(); // Guid? | The id of the service to remove.
            var locationid = new Guid?(); // Guid? | The id of the location to remove the service from.

            try
            {
                // Remove a service from a location
                apiInstance.Serviceassignmentremoveservice(token, serviceid, locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Serviceassignmentremoveservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**Guid?**](.md)| The id of the service to remove. | 
 **locationid** | [**Guid?**](.md)| The id of the location to remove the service from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicedelete"></a>
# **Servicedelete**
> void Servicedelete (string token, Guid? id)

Delete a service

Allows the user to delete a service from the existing list.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServicedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the service to delete.

            try
            {
                // Delete a service
                apiInstance.Servicedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Servicedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the service to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceget"></a>
# **Serviceget**
> void Serviceget (string token, Guid? id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServicegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the service to get.

            try
            {
                // Search and view details of a service
                apiInstance.Serviceget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Serviceget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the service to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicelist"></a>
# **Servicelist**
> void Servicelist (string token, int? from, int? count)

View a list of services

Allows the user to view the full list of existing services.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServicelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of services
                apiInstance.Servicelist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Servicelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicesave"></a>
# **Servicesave**
> void Servicesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a service

Allows the user to create or edit a service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServicesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a service
                apiInstance.Servicesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Servicesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendancelogaddnote"></a>
# **Sessionattendancelogaddnote**
> void Sessionattendancelogaddnote (string token, Guid? id, string text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogaddnoteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log.
            var text = text_example;  // string | The text of the note to add.

            try
            {
                // Add a note to a class attendance log
                apiInstance.Sessionattendancelogaddnote(token, id, text);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendancelogaddnote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log. | 
 **text** | **string**| The text of the note to add. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendancelogget"></a>
# **Sessionattendancelogget**
> void Sessionattendancelogget (string token, Guid? id, int? photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendanceloggetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View details of a class attendance log
                apiInstance.Sessionattendancelogget(token, id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendancelogget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendanceloggetuser"></a>
# **Sessionattendanceloggetuser**
> void Sessionattendanceloggetuser (Guid? attendee, Guid? eventid, string token)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendanceloggetuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var attendee = new Guid?(); // Guid? | The id of the attendee to get statistic for.
            var eventid = new Guid?(); // Guid? | The id of the event whose attendee statistics have to be returned.
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // View the class session attendance information for a specific user
                apiInstance.Sessionattendanceloggetuser(attendee, eventid, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendanceloggetuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**Guid?**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**Guid?**](.md)| The id of the event whose attendee statistics have to be returned. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendanceloglist"></a>
# **Sessionattendanceloglist**
> void Sessionattendanceloglist (string token, Guid? session, int? from, int? count, int? photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendanceloglistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var session = new Guid?(); // Guid? | The id of the session whose attendees logs have to be returned.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View attendance logs of the specified session
                apiInstance.Sessionattendanceloglist(token, session, from, count, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendanceloglist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **session** | [**Guid?**](.md)| The id of the session whose attendees logs have to be returned. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendanceloglistevent"></a>
# **Sessionattendanceloglistevent**
> void Sessionattendanceloglistevent (Guid? eventid, string token)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendanceloglisteventExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var eventid = new Guid?(); // Guid? | The id of the event whose attendance has to be returned.
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // View the attendance information of an entire class
                apiInstance.Sessionattendanceloglistevent(eventid, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendanceloglistevent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event whose attendance has to be returned. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendanceloglistsummary"></a>
# **Sessionattendanceloglistsummary**
> void Sessionattendanceloglistsummary (string token, Guid? eventid, Guid? attendeeid, Guid? groupid, string start, string end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendanceloglistsummaryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event whose attendance has to be returned. (optional) 
            var attendeeid = new Guid?(); // Guid? | The id of the attendee whose attendance has to be returned. (optional) 
            var groupid = new Guid?(); // Guid? | The id of the group whose attendance has to be returned. (optional) 
            var start = start_example;  // string | The start date to filter (beginning of time by default). (optional) 
            var end = end_example;  // string | The end date to filter (today by default). (optional) 

            try
            {
                // View the attendance summary for a class and/or a attendee
                apiInstance.Sessionattendanceloglistsummary(token, eventid, attendeeid, groupid, start, end);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendanceloglistsummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**Guid?**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**Guid?**](.md)| The id of the group whose attendance has to be returned. | [optional] 
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

<a name="sessionattendancelogmylistsummary"></a>
# **Sessionattendancelogmylistsummary**
> void Sessionattendancelogmylistsummary (string token, Guid? eventid, string start, string end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogmylistsummaryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event whose attendance has to be returned. (optional) 
            var start = start_example;  // string | The start date to filter (beginning of time by default). (optional) 
            var end = end_example;  // string | The end date to filter (today by default). (optional) 

            try
            {
                // View my attendance summary
                apiInstance.Sessionattendancelogmylistsummary(token, eventid, start, end);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendancelogmylistsummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event whose attendance has to be returned. | [optional] 
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

<a name="sessionattendancelogsave"></a>
# **Sessionattendancelogsave**
> void Sessionattendancelogsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a class attendance log
                apiInstance.Sessionattendancelogsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendancelogsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendancelogsaveswipe"></a>
# **Sessionattendancelogsaveswipe**
> void Sessionattendancelogsaveswipe (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogsaveswipeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a class attendance log swipe
                apiInstance.Sessionattendancelogsaveswipe(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionattendancelogsaveswipe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionbulkupdate"></a>
# **Sessionbulkupdate**
> void Sessionbulkupdate (string token, Guid? eventid, string sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionbulkupdateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The id of the event to bulk update.
            var sessions = sessions_example;  // string | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

            try
            {
                // Bulk update event sessions
                apiInstance.Sessionbulkupdate(token, eventid, sessions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionbulkupdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The id of the event to bulk update. | 
 **sessions** | **string**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionget"></a>
# **Sessionget**
> void Sessionget (string token, Guid? id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessiongetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the session to get.

            try
            {
                // View details of a session
                apiInstance.Sessionget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the session to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessiongetschedule"></a>
# **Sessiongetschedule**
> void Sessiongetschedule (string token, DateTime? day, Guid? attendee, Guid? location, Guid? instructor)

Gets the schedule for a location, instructor or attendees

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessiongetscheduleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token. (optional) 
            var day = 2013-10-20T19:20:30+01:00;  // DateTime? | The day to return. It will also return the whole week for that day. (optional) 
            var attendee = new Guid?(); // Guid? | The id of the attendee to get the schedule. (optional) 
            var location = new Guid?(); // Guid? | The id of the location to get the schedule. (optional) 
            var instructor = new Guid?(); // Guid? | The id of the instructor to get the schedule. (optional) 

            try
            {
                // Gets the schedule for a location, instructor or attendees
                apiInstance.Sessiongetschedule(token, day, attendee, location, instructor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessiongetschedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional] 
 **day** | **DateTime?**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**Guid?**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**Guid?**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**Guid?**](.md)| The id of the instructor to get the schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionlist"></a>
# **Sessionlist**
> void Sessionlist (int? from, int? count, string token, DateTime? startdate, DateTime? enddate)

Gets all future sessions of the current semester

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date to filter the sessions (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date to filter the sessions. (optional) 

            try
            {
                // Gets all future sessions of the current semester
                apiInstance.Sessionlist(from, count, token, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **startdate** | **DateTime?**| The start date to filter the sessions | [optional] 
 **enddate** | **DateTime?**| The end date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregaddcurrentuser"></a>
# **Sessionregaddcurrentuser**
> void Sessionregaddcurrentuser (string token, Guid? eventid, DateTime? sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregaddcurrentuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Register current user to an event session
                apiInstance.Sessionregaddcurrentuser(token, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregaddcurrentuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregadduser"></a>
# **Sessionregadduser**
> void Sessionregadduser (string token, Guid? userid, Guid? eventid, DateTime? sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregadduserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Register users for events
                apiInstance.Sessionregadduser(token, userid, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregadduser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetmysessions"></a>
# **Sessionreggetmysessions**
> void Sessionreggetmysessions (string token, DateTime? date)

View all the sessions the logged user is registered to

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreggetmysessionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date to filter the sessions. (optional) 

            try
            {
                // View all the sessions the logged user is registered to
                apiInstance.Sessionreggetmysessions(token, date);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreggetmysessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime?**| Start date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetsessions"></a>
# **Sessionreggetsessions**
> void Sessionreggetsessions (string token, Guid? userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreggetsessionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The user id to list sessions.

            try
            {
                // Lists the registrations for a specific user
                apiInstance.Sessionreggetsessions(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreggetsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The user id to list sessions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetsettings"></a>
# **Sessionreggetsettings**
> void Sessionreggetsettings (string token, Guid? locationid, Guid? eventid, DateTime? sessiondate, bool? noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreggetsettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var locationid = new Guid?(); // Guid? | The id of the location to save settings. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to save settings. (optional) 
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts. (optional) 
            var noinherit = true;  // bool? | True to get the location/event/session specific settings without looking for the more global settings. (optional) 

            try
            {
                // Get the settings for session registration
                apiInstance.Sessionreggetsettings(token, locationid, eventid, sessiondate, noinherit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreggetsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **locationid** | [**Guid?**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | [optional] 
 **noinherit** | **bool?**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetusers"></a>
# **Sessionreggetusers**
> void Sessionreggetusers (string token, Guid? eventid, DateTime? sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreggetusersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The event id to list sessions.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date of the session to find.

            try
            {
                // Lists the registrations for a specific session
                apiInstance.Sessionreggetusers(token, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreggetusers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime?**| The date of the session to find. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistsessions"></a>
# **Sessionreglistsessions**
> void Sessionreglistsessions (string token, Guid? eventid, DateTime? sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreglistsessionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The event id to list sessions.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date of the session to find. (optional) 

            try
            {
                // List the sessions available for a specific event
                apiInstance.Sessionreglistsessions(token, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreglistsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime?**| The date of the session to find. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistupcoming"></a>
# **Sessionreglistupcoming**
> void Sessionreglistupcoming (string token, DateTime? date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreglistupcomingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Only sessions in the week of the specified date will be returned.

            try
            {
                // View a list of upcoming event sessions
                apiInstance.Sessionreglistupcoming(token, date);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreglistupcoming: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime?**| Only sessions in the week of the specified date will be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistupcomingevent"></a>
# **Sessionreglistupcomingevent**
> void Sessionreglistupcomingevent (string token, DateTime? date, Guid? _event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreglistupcomingeventExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date to filter the returned sessions.
            var _event = new Guid?(); // Guid? | The id of the event whose sessions will be returned

            try
            {
                // View a list of upcoming sessions of a particular event
                apiInstance.Sessionreglistupcomingevent(token, date, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreglistupcomingevent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime?**| Start date to filter the returned sessions. | 
 **_event** | [**Guid?**](.md)| The id of the event whose sessions will be returned | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregremovecurrentuser"></a>
# **Sessionregremovecurrentuser**
> void Sessionregremovecurrentuser (string token, Guid? eventid, DateTime? sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregremovecurrentuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Unregister current user from an event session
                apiInstance.Sessionregremovecurrentuser(token, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregremovecurrentuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregremoveuser"></a>
# **Sessionregremoveuser**
> void Sessionregremoveuser (string token, Guid? userid, Guid? eventid, DateTime? sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregremoveuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Removes a user from an event session
                apiInstance.Sessionregremoveuser(token, userid, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregremoveuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregsavesettings"></a>
# **Sessionregsavesettings**
> void Sessionregsavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregsavesettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save the settings for an event's session registration
                apiInstance.Sessionregsavesettings(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregsavesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswipedelete"></a>
# **Sessionswipedelete**
> void Sessionswipedelete (string token, Guid? id)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the session swipe to delete.

            try
            {
                // Delete a session swipe
                apiInstance.Sessionswipedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionswipedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the session swipe to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswipeget"></a>
# **Sessionswipeget**
> void Sessionswipeget (string token, Guid? id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the swipe to get.

            try
            {
                // View details of a class attendance swipe
                apiInstance.Sessionswipeget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionswipeget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswipelistunresolved"></a>
# **Sessionswipelistunresolved**
> void Sessionswipelistunresolved (int? from, int? count, string token)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipelistunresolvedExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // View a list of unresolved swipes
                apiInstance.Sessionswipelistunresolved(from, count, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionswipelistunresolved: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswiperesolve"></a>
# **Sessionswiperesolve**
> void Sessionswiperesolve (string token, Guid? id, Guid? session, Guid? user)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswiperesolveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the swipe to resolve.
            var session = new Guid?(); // Guid? | The id of the session whose swipe has to be saved. (optional) 
            var user = new Guid?(); // Guid? | The id of the user who signed-in. (optional) 

            try
            {
                // Resolve a swipe and create the corresponding attendance log
                apiInstance.Sessionswiperesolve(token, id, session, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionswiperesolve: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the swipe to resolve. | 
 **session** | [**Guid?**](.md)| The id of the session whose swipe has to be saved. | [optional] 
 **user** | [**Guid?**](.md)| The id of the user who signed-in. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswipesave"></a>
# **Sessionswipesave**
> void Sessionswipesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Creates a new swipe, and if possible, creates the attendance log
                apiInstance.Sessionswipesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionswipesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswipesaveanonym"></a>
# **Sessionswipesaveanonym**
> void Sessionswipesaveanonym (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipesaveanonymExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Creates a new swipe from a sign-in station, and if possible, creates the attendance log
                apiInstance.Sessionswipesaveanonym(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionswipesaveanonym: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settingaddlogo"></a>
# **Settingaddlogo**
> void Settingaddlogo (string token, string upload, string filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingaddlogoExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The original filename, needed to process the file.

            try
            {
                // Add a logo to the account
                apiInstance.Settingaddlogo(token, upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Settingaddlogo: " + e.Message );
            }
        }
    }
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

<a name="settingget"></a>
# **Settingget**
> void Settingget (string keys, string token, string domain, string scope)

Get settings for the account or the specified scope

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettinggetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var keys = keys_example;  // string | The option keys to get values for. Enter multiple separated by comma.
            var token = token_example;  // string | The authentication token. (optional) 
            var domain = domain_example;  // string | The account domain, in case of reading settings annonymously. (optional) 
            var scope = scope_example;  // string | The scope of the settings to get. (optional) 

            try
            {
                // Get settings for the account or the specified scope
                apiInstance.Settingget(keys, token, domain, scope);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Settingget: " + e.Message );
            }
        }
    }
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

<a name="settingsave"></a>
# **Settingsave**
> void Settingsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save settings for the account or the specified scope
                apiInstance.Settingsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Settingsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settingviewgeneral"></a>
# **Settingviewgeneral**
> void Settingviewgeneral (string token)

View general settings for the account

Allows the user to view the settings' general section.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingviewgeneralExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View general settings for the account
                apiInstance.Settingviewgeneral(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Settingviewgeneral: " + e.Message );
            }
        }
    }
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

<a name="socialcontacts"></a>
# **Socialcontacts**
> void Socialcontacts (string token, string filter, bool? showdefaultphoto)

Gets the list of contacts in the network

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialcontactsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var filter = filter_example;  // string | Text to filter results. (optional) 
            var showdefaultphoto = true;  // bool? | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. (optional) 

            try
            {
                // Gets the list of contacts in the network
                apiInstance.Socialcontacts(token, filter, showdefaultphoto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Socialcontacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **filter** | **string**| Text to filter results. | [optional] 
 **showdefaultphoto** | **bool?**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupaddmembers"></a>
# **Socialgroupaddmembers**
> void Socialgroupaddmembers (string token, Guid? id, string userids)

Adds new members to a group (which the user must own already)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupaddmembersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | ID of the group to add members to.
            var userids = userids_example;  // string | Csv list of user Ids to add.

            try
            {
                // Adds new members to a group (which the user must own already)
                apiInstance.Socialgroupaddmembers(token, id, userids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Socialgroupaddmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| ID of the group to add members to. | 
 **userids** | **string**| Csv list of user Ids to add. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupdelete"></a>
# **Socialgroupdelete**
> void Socialgroupdelete (string token, Guid? id)

Deletes a group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | ID of the group to delete.

            try
            {
                // Deletes a group
                apiInstance.Socialgroupdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Socialgroupdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| ID of the group to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgrouplist"></a>
# **Socialgrouplist**
> void Socialgrouplist (string token)

View all the groups the current user is in

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgrouplistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View all the groups the current user is in
                apiInstance.Socialgrouplist(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Socialgrouplist: " + e.Message );
            }
        }
    }
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

<a name="socialgrouplistmembers"></a>
# **Socialgrouplistmembers**
> void Socialgrouplistmembers (string token, Guid? id)

Lists the members of a group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgrouplistmembersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | ID of the group to list members.

            try
            {
                // Lists the members of a group
                apiInstance.Socialgrouplistmembers(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Socialgrouplistmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| ID of the group to list members. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupremovemembers"></a>
# **Socialgroupremovemembers**
> void Socialgroupremovemembers (string token, Guid? id, string userids)

Removes members from a group (which the user must own already)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupremovemembersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | ID of the group to remove members from.
            var userids = userids_example;  // string | Csv list of user Ids to remove.

            try
            {
                // Removes members from a group (which the user must own already)
                apiInstance.Socialgroupremovemembers(token, id, userids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Socialgroupremovemembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| ID of the group to remove members from. | 
 **userids** | **string**| Csv list of user Ids to remove. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupremovemyself"></a>
# **Socialgroupremovemyself**
> void Socialgroupremovemyself (string token, Guid? id)

Removes myself from an existent group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupremovemyselfExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | ID of the group to remove me from.

            try
            {
                // Removes myself from an existent group
                apiInstance.Socialgroupremovemyself(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Socialgroupremovemyself: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| ID of the group to remove me from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupsave"></a>
# **Socialgroupsave**
> void Socialgroupsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a new group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a new group
                apiInstance.Socialgroupsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Socialgroupsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssogeneratekey"></a>
# **Ssogeneratekey**
> void Ssogeneratekey (string token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsogeneratekeyExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Generate/reset single sign on access key.
                apiInstance.Ssogeneratekey(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ssogeneratekey: " + e.Message );
            }
        }
    }
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

<a name="ssogetsettings"></a>
# **Ssogetsettings**
> void Ssogetsettings (string token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsogetsettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View single sign on settings.
                apiInstance.Ssogetsettings(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ssogetsettings: " + e.Message );
            }
        }
    }
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

<a name="ssoissuetoken"></a>
# **Ssoissuetoken**
> void Ssoissuetoken (string key, string username, bool? expires)

Issue single sign-on token

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsoissuetokenExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var key = key_example;  // string | The single sign-on key of the account.
            var username = username_example;  // string | The email of the user to sign-on.
            var expires = true;  // bool? | Specifies whether the session should expire when inactive. (optional) 

            try
            {
                // Issue single sign-on token
                apiInstance.Ssoissuetoken(key, username, expires);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ssoissuetoken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The single sign-on key of the account. | 
 **username** | **string**| The email of the user to sign-on. | 
 **expires** | **bool?**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssosavesettings"></a>
# **Ssosavesettings**
> void Ssosavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsosavesettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Edit single sign-on settings.
                apiInstance.Ssosavesettings(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ssosavesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailaddmetoallservices"></a>
# **Staffavailaddmetoallservices**
> void Staffavailaddmetoallservices (string token)

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailaddmetoallservicesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Associate current user to all services
                apiInstance.Staffavailaddmetoallservices(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailaddmetoallservices: " + e.Message );
            }
        }
    }
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

<a name="staffavailaddmetoservice"></a>
# **Staffavailaddmetoservice**
> void Staffavailaddmetoservice (string token, Guid? serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailaddmetoserviceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceid = new Guid?(); // Guid? | The id of the service.

            try
            {
                // Associate current user to a service
                apiInstance.Staffavailaddmetoservice(token, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailaddmetoservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**Guid?**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailaddusertoallservices"></a>
# **Staffavailaddusertoallservices**
> void Staffavailaddusertoallservices (string token, Guid? userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailaddusertoallservicesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.

            try
            {
                // Associate a staff member to all services
                apiInstance.Staffavailaddusertoallservices(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailaddusertoallservices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailaddusertoservice"></a>
# **Staffavailaddusertoservice**
> void Staffavailaddusertoservice (string token, Guid? userid, Guid? serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailaddusertoserviceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var serviceid = new Guid?(); // Guid? | The id of the service.

            try
            {
                // Associate a staff member to a service
                apiInstance.Staffavailaddusertoservice(token, userid, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailaddusertoservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **serviceid** | [**Guid?**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailgetmyservices"></a>
# **Staffavailgetmyservices**
> void Staffavailgetmyservices (string token)

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailgetmyservicesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View the services the current user is available for
                apiInstance.Staffavailgetmyservices(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailgetmyservices: " + e.Message );
            }
        }
    }
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

<a name="staffavailgetservices"></a>
# **Staffavailgetservices**
> void Staffavailgetservices (string token, Guid? userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailgetservicesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The user id to list services.

            try
            {
                // View a list of services that a staff member is available for
                apiInstance.Staffavailgetservices(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailgetservices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The user id to list services. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailgetusersforservice"></a>
# **Staffavailgetusersforservice**
> void Staffavailgetusersforservice (string token, Guid? serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailgetusersforserviceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceid = new Guid?(); // Guid? | The service id to list users.

            try
            {
                // View a list of staff members that are available for a specific service
                apiInstance.Staffavailgetusersforservice(token, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailgetusersforservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**Guid?**](.md)| The service id to list users. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavaillisttypes"></a>
# **Staffavaillisttypes**
> void Staffavaillisttypes (string token)

View all the availability types

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavaillisttypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View all the availability types
                apiInstance.Staffavaillisttypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavaillisttypes: " + e.Message );
            }
        }
    }
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

<a name="staffavailremovemefromallservices"></a>
# **Staffavailremovemefromallservices**
> void Staffavailremovemefromallservices (string token)

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailremovemefromallservicesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Remove current user from all services
                apiInstance.Staffavailremovemefromallservices(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailremovemefromallservices: " + e.Message );
            }
        }
    }
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

<a name="staffavailremovemefromservice"></a>
# **Staffavailremovemefromservice**
> void Staffavailremovemefromservice (string token, Guid? serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailremovemefromserviceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var serviceid = new Guid?(); // Guid? | The id of the service.

            try
            {
                // Remove current user from a service
                apiInstance.Staffavailremovemefromservice(token, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailremovemefromservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **serviceid** | [**Guid?**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailremoveuserfromallservices"></a>
# **Staffavailremoveuserfromallservices**
> void Staffavailremoveuserfromallservices (string token, Guid? userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailremoveuserfromallservicesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.

            try
            {
                // Removes a staff member from the registration to all services
                apiInstance.Staffavailremoveuserfromallservices(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailremoveuserfromallservices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailremoveuserfromservice"></a>
# **Staffavailremoveuserfromservice**
> void Staffavailremoveuserfromservice (string token, Guid? userid, Guid? serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailremoveuserfromserviceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var serviceid = new Guid?(); // Guid? | The id of the service.

            try
            {
                // Remove a staff member from a service
                apiInstance.Staffavailremoveuserfromservice(token, userid, serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailremoveuserfromservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **serviceid** | [**Guid?**](.md)| The id of the service. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailsetavailability"></a>
# **Staffavailsetavailability**
> void Staffavailsetavailability (string token, Guid? userid, string availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailsetavailabilityExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user whose specific availability has to be set.
            var availablefor = availablefor_example;  // string | Specific availability to set. (optional) 

            try
            {
                // Make a staff member available for a specific availability type
                apiInstance.Staffavailsetavailability(token, userid, availablefor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailsetavailability: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user whose specific availability has to be set. | 
 **availablefor** | **string**| Specific availability to set. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffavailsetmyavailability"></a>
# **Staffavailsetmyavailability**
> void Staffavailsetmyavailability (string token, string availablefor)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StaffavailsetmyavailabilityExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var availablefor = availablefor_example;  // string | Specific availability to set. (optional) 

            try
            {
                // Change current user's availability type
                apiInstance.Staffavailsetmyavailability(token, availablefor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Staffavailsetmyavailability: " + e.Message );
            }
        }
    }
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

<a name="stationdelete"></a>
# **Stationdelete**
> void Stationdelete (string token, Guid? id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the sign-in station to delete.

            try
            {
                // Delete a sign-in station
                apiInstance.Stationdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the sign-in station to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationget"></a>
# **Stationget**
> void Stationget (string token, Guid? id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the sign-in station to get.

            try
            {
                // View details of a sign-in station
                apiInstance.Stationget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the sign-in station to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetcurrentterms"></a>
# **Stationgetcurrentterms**
> void Stationgetcurrentterms (Guid? station)

Get all the current terms

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetcurrenttermsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station whose account's current terms have to be retrieved.

            try
            {
                // Get all the current terms
                apiInstance.Stationgetcurrentterms(station);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationgetcurrentterms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetinfo"></a>
# **Stationgetinfo**
> void Stationgetinfo (Guid? id, Guid? _event)

Gets a the info to display in the sign-in station by it's ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetinfoExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to get.
            var _event = new Guid?(); // Guid? | The id of the event, to override the one by schedule. (optional) 

            try
            {
                // Gets a the info to display in the sign-in station by it's ID.
                apiInstance.Stationgetinfo(id, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationgetinfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **_event** | [**Guid?**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetlicense"></a>
# **Stationgetlicense**
> void Stationgetlicense (string station)

Gets the current license information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetlicenseExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = station_example;  // string | The id of the sign-in station whose account's license has to be retrieved.

            try
            {
                // Gets the current license information
                apiInstance.Stationgetlicense(station);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationgetlicense: " + e.Message );
            }
        }
    }
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

<a name="stationgetlocationsettings"></a>
# **Stationgetlocationsettings**
> void Stationgetlocationsettings (Guid? location)

View the sign-in station settings of a specified location

Allows the user to view the location settings of a sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetlocationsettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var location = new Guid?(); // Guid? | The id of the location whose station settings have to be returned.

            try
            {
                // View the sign-in station settings of a specified location
                apiInstance.Stationgetlocationsettings(location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationgetlocationsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**Guid?**](.md)| The id of the location whose station settings have to be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationlist"></a>
# **Stationlist**
> void Stationlist (string token, int? from, int? count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of sign-in stations
                apiInstance.Stationlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationsave"></a>
# **Stationsave**
> void Stationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a sign-in station
                apiInstance.Stationsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationsavemine"></a>
# **Stationsavemine**
> void Stationsavemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a class attendance sign-in station for myself

Allows the user to create a class attendance sign-in station for a course for which they are available as staff.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationsavemineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a class attendance sign-in station for myself
                apiInstance.Stationsavemine(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationsavemine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationunlock"></a>
# **Stationunlock**
> void Stationunlock (Guid? id, string passcode, string method)

Unlocks the sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationunlockExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to unlock.
            var passcode = passcode_example;  // string | The passcode to unlock the station.
            var method = method_example;  // string | The authentication method. Valid values are 'token' and 'cookie'.

            try
            {
                // Unlocks the sign-in station.
                apiInstance.Stationunlock(id, passcode, method);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationunlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to unlock. | 
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

<a name="swipedelete"></a>
# **Swipedelete**
> void Swipedelete (string token, Guid? id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the swipe to delete.

            try
            {
                // Delete a swipe
                apiInstance.Swipedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the swipe to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swipeget"></a>
# **Swipeget**
> void Swipeget (string token, Guid? id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the swipe to get.

            try
            {
                // Search and view details of a swipe
                apiInstance.Swipeget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipeget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swipelist"></a>
# **Swipelist**
> void Swipelist (int? from, int? count, string token)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // View a list of swipes
                apiInstance.Swipelist(from, count, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swipesave"></a>
# **Swipesave**
> void Swipesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a swipe, and if possible, save the related attendance log
                apiInstance.Swipesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swipesaveanonym"></a>
# **Swipesaveanonym**
> void Swipesaveanonym (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipesaveanonymExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Creates a new swipe from a sign-in station, and if possible, creates the attendance log
                apiInstance.Swipesaveanonym(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipesaveanonym: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagdelete"></a>
# **Tagdelete**
> void Tagdelete (string token, Guid? id)

Delete a tag

Allows the user to delete an existing tag.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TagdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the tag to delete.

            try
            {
                // Delete a tag
                apiInstance.Tagdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Tagdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the tag to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagget"></a>
# **Tagget**
> void Tagget (string token, Guid? id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaggetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the tag to get.

            try
            {
                // View details of a specified tag
                apiInstance.Tagget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Tagget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the tag to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taglist"></a>
# **Taglist**
> void Taglist (string token, string group, int? from, int? count)

View a list of tags

Allows the user to view the list of tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaglistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var group = group_example;  // string | The group of the tags to return.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of tags
                apiInstance.Taglist(token, group, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Taglist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | **string**| The group of the tags to return. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taglistgroups"></a>
# **Taglistgroups**
> void Taglistgroups (string token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaglistgroupsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of entities that can be tagged
                apiInstance.Taglistgroups(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Taglistgroups: " + e.Message );
            }
        }
    }
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

<a name="tagsave"></a>
# **Tagsave**
> void Tagsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a tag

Allows the user to create or edit a tag.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TagsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a tag
                apiInstance.Tagsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Tagsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsearch"></a>
# **Tagsearch**
> void Tagsearch (string token, string query, bool? allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TagsearchExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var query = query_example;  // string | The query to search tags. Use group:<group> to search in a specific group (mandatory).
            var allowcreatingnew = true;  // bool? | Specifies whether an option to create a new tag should be retrieved. (optional) 

            try
            {
                // Search for tags in the account
                apiInstance.Tagsearch(token, query, allowcreatingnew);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Tagsearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | **string**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **allowcreatingnew** | **bool?**| Specifies whether an option to create a new tag should be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateaddimage"></a>
# **Templateaddimage**
> void Templateaddimage (string token, Guid? template, string upload, string filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateaddimageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var template = new Guid?(); // Guid? | The id of the template where the image has to be added
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 

            try
            {
                // Add an image to a template
                apiInstance.Templateaddimage(token, template, upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templateaddimage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **template** | [**Guid?**](.md)| The id of the template where the image has to be added | 
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

<a name="templatedelete"></a>
# **Templatedelete**
> void Templatedelete (string token, Guid? id)

Delete a template

Allows the user to delete an existing template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the template to delete.

            try
            {
                // Delete a template
                apiInstance.Templatedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the template to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateemail"></a>
# **Templateemail**
> void Templateemail (string token, string jobid, string emailsubject, string emailbody, string templatekind, string emailfrom, string emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateemailExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var jobid = jobid_example;  // string | The id of the job that is creating the templates.
            var emailsubject = emailsubject_example;  // string | Args depending on the send-to flag.
            var emailbody = emailbody_example;  // string | Args depending on the send-to flag.
            var templatekind = templatekind_example;  // string | The kind of the template you're sending. It must be included in (badge, certificate). (optional) 
            var emailfrom = emailfrom_example;  // string | The name of the sender to be displayed in the receipients inbox (optional) 
            var emailreplyto = emailreplyto_example;  // string | The reply-to field for the emails. (optional) 

            try
            {
                // Send generated templates by email
                apiInstance.Templateemail(token, jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templateemail: " + e.Message );
            }
        }
    }
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

<a name="templategenerate"></a>
# **Templategenerate**
> void Templategenerate (string token, Guid? template, Guid? source, bool? singlefile, string userid, bool? forsending, Guid? role, string filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplategenerateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var template = new Guid?(); // Guid? | The id of the template to generate.
            var source = new Guid?(); // Guid? | The source key of the selected template data source.
            var singlefile = true;  // bool? | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
            var userid = userid_example;  // string | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas. (optional) 
            var forsending = true;  // bool? | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading (optional) 
            var role = new Guid?(); // Guid? | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor (optional) 
            var filters = filters_example;  // string | Pipe separated filters for the generation, eg: aaa=val|bbb=val|... (optional) 

            try
            {
                // Generate specified templates
                apiInstance.Templategenerate(token, template, source, singlefile, userid, forsending, role, filters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templategenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **template** | [**Guid?**](.md)| The id of the template to generate. | 
 **source** | [**Guid?**](.md)| The source key of the selected template data source. | 
 **singlefile** | **bool?**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **string**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **bool?**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**Guid?**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **string**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateget"></a>
# **Templateget**
> void Templateget (string token, Guid? id)

View details of a template

Allows the user to view a template and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplategetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the template to get.

            try
            {
                // View details of a template
                apiInstance.Templateget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templateget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the template to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templategetgenerated"></a>
# **Templategetgenerated**
> void Templategetgenerated (string token, string jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplategetgeneratedExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var jobid = jobid_example;  // string | The id of the job that is creating the templates.

            try
            {
                // View generated templates
                apiInstance.Templategetgenerated(token, jobid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templategetgenerated: " + e.Message );
            }
        }
    }
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

<a name="templatelist"></a>
# **Templatelist**
> void Templatelist (string token, int? from, int? count, string kind, bool? designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var kind = kind_example;  // string | The kind of the templates to return. It must be included in (badge, certificate).
            var designedonly = true;  // bool? | If true then it only returns the templates that were designed. Otherwise, it returns all. (optional) 

            try
            {
                // View a list of defined templates
                apiInstance.Templatelist(token, from, count, kind, designedonly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **bool?**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatelistsources"></a>
# **Templatelistsources**
> void Templatelistsources (string token, string kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatelistsourcesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var kind = kind_example;  // string | The kind of the templates to return. It must be included in (badge, certificate).

            try
            {
                // View a list of templates' data sources
                apiInstance.Templatelistsources(token, kind);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatelistsources: " + e.Message );
            }
        }
    }
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

<a name="templatesave"></a>
# **Templatesave**
> void Templatesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a template

Allows the user to create or edit a template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a template
                apiInstance.Templatesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesavelayout"></a>
# **Templatesavelayout**
> void Templatesavelayout (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save the layout of a template

Allows the user to edit a template's layout.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatesavelayoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save the layout of a template
                apiInstance.Templatesavelayout(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatesavelayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termdelete"></a>
# **Termdelete**
> void Termdelete (string token, Guid? id)

Delete a term

Allows the user to delete a term from the existing list.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the term to delete.

            try
            {
                // Delete a term
                apiInstance.Termdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Termdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the term to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termget"></a>
# **Termget**
> void Termget (string token, Guid? id)

Search and view details of a term

Allows the user to view a term and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the term to get.

            try
            {
                // Search and view details of a term
                apiInstance.Termget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Termget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the term to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termlist"></a>
# **Termlist**
> void Termlist (string token, int? from, int? count, bool? notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 
            var notpast = true;  // bool? | Specifies whether the terms in the past should be returned or not. (optional) 

            try
            {
                // Search and view details of all terms
                apiInstance.Termlist(token, from, count, notpast);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Termlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | [optional] 
 **count** | **int?**| The max number of records to return. | [optional] 
 **notpast** | **bool?**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termsave"></a>
# **Termsave**
> void Termsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create and edit terms

Allows the user to create and edit terms.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create and edit terms
                apiInstance.Termsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Termsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="textcreditremaining"></a>
# **Textcreditremaining**
> void Textcreditremaining (string token)

Gets the remaining text credits for the account

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TextcreditremainingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the remaining text credits for the account
                apiInstance.Textcreditremaining(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Textcreditremaining: " + e.Message );
            }
        }
    }
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

<a name="texttoimage"></a>
# **Texttoimage**
> void Texttoimage (string token, string text, string fontcolor, int? fontsize, string direction, int? width)

Generates a dynamic image from text

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TexttoimageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var text = text_example;  // string | The text to convert to an image, use double pipes (||) as a new line.
            var fontcolor = fontcolor_example;  // string | The color of the text, in hex format, without the #. (optional) 
            var fontsize = 56;  // int? | The size of the text, in points. (optional) 
            var direction = direction_example;  // string | Either vertical or horizontal, default horizontal. (optional) 
            var width = 56;  // int? | The image width in pixels (or height if the direction is vertical). (optional) 

            try
            {
                // Generates a dynamic image from text
                apiInstance.Texttoimage(token, text, fontcolor, fontsize, direction, width);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Texttoimage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **text** | **string**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **string**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **int?**| The size of the text, in points. | [optional] 
 **direction** | **string**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **int?**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translationget"></a>
# **Translationget**
> void Translationget (string token, string universal)

Gets the translations of the specified values

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var universal = universal_example;  // string | Pipe separated list of universal text to be translated.

            try
            {
                // Gets the translations of the specified values
                apiInstance.Translationget(token, universal);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Translationget: " + e.Message );
            }
        }
    }
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

<a name="translationgetcachefile"></a>
# **Translationgetcachefile**
> void Translationgetcachefile (string token, string account)

Get the file containing the translations

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationgetcachefileExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token. (optional) 
            var account = account_example;  // string | The id of the account whose translations file has to be retrieved. (optional) 

            try
            {
                // Get the file containing the translations
                apiInstance.Translationgetcachefile(token, account);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Translationgetcachefile: " + e.Message );
            }
        }
    }
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

<a name="translationlist"></a>
# **Translationlist**
> void Translationlist (string token, string filter, bool? nondefaultonly, bool? appdefaultasuniversal)

Lists all the available translations in the system

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var filter = filter_example;  // string | Text to search/filter translations. (optional) 
            var nondefaultonly = true;  // bool? | If true then it returns only the terms translated. Otherwise, it returns all. (optional) 
            var appdefaultasuniversal = true;  // bool? | If true then it uses the app default translation as the universal term. (optional) 

            try
            {
                // Lists all the available translations in the system
                apiInstance.Translationlist(token, filter, nondefaultonly, appdefaultasuniversal);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Translationlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **filter** | **string**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **bool?**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **bool?**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translationsave"></a>
# **Translationsave**
> void Translationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Edit a translation
                apiInstance.Translationsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Translationsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userchangepwd"></a>
# **Userchangepwd**
> void Userchangepwd (string token, Guid? oldpass, Guid? newpass)

Change user's own password

Allows the user to change their own password.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserchangepwdExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var oldpass = new Guid?(); // Guid? | The old password of the authenticated user.
            var newpass = new Guid?(); // Guid? | The new password of the authenticated user.

            try
            {
                // Change user's own password
                apiInstance.Userchangepwd(token, oldpass, newpass);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userchangepwd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **oldpass** | [**Guid?**](.md)| The old password of the authenticated user. | 
 **newpass** | [**Guid?**](.md)| The new password of the authenticated user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userchangepwdbyreq"></a>
# **Userchangepwdbyreq**
> void Userchangepwdbyreq (string changereq, string newpass)

Changes the user password using a change password request id

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserchangepwdbyreqExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var changereq = changereq_example;  // string | The change password request ID sent by email to the user.
            var newpass = newpass_example;  // string | The new password of the user.

            try
            {
                // Changes the user password using a change password request id
                apiInstance.Userchangepwdbyreq(changereq, newpass);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userchangepwdbyreq: " + e.Message );
            }
        }
    }
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

<a name="userdelete"></a>
# **Userdelete**
> void Userdelete (string token, Guid? id)

Delete a user

Allows the user to delete a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the user to delete.

            try
            {
                // Delete a user
                apiInstance.Userdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the user to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userfindsimilar"></a>
# **Userfindsimilar**
> void Userfindsimilar (string token, Guid? currentid, string phonenumber, string cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserfindsimilarExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var currentid = new Guid?(); // Guid? | The id of the current user. (optional) 
            var phonenumber = phonenumber_example;  // string | A phone number to search for similar users. (optional) 
            var cardnumber = cardnumber_example;  // string | A card number to search for similar users. (optional) 

            try
            {
                // Finds similar users to prevent duplicates
                apiInstance.Userfindsimilar(token, currentid, phonenumber, cardnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userfindsimilar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **currentid** | [**Guid?**](.md)| The id of the current user. | [optional] 
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

<a name="userget"></a>
# **Userget**
> void Userget (string token, Guid? id, int? photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the user to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Search and view details of a user
                apiInstance.Userget(token, id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the user to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetbycard"></a>
# **Usergetbycard**
> void Usergetbycard (string token, string card, int? photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergetbycardExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var card = card_example;  // string | The card number of the user to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Search user by card number
                apiInstance.Usergetbycard(token, card, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergetbycard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **card** | **string**| The card number of the user to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupaddmember"></a>
# **Usergroupaddmember**
> void Usergroupaddmember (string token, Guid? userid, Guid? groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupaddmemberExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var groupid = new Guid?(); // Guid? | The id of the group.

            try
            {
                // Add a user to a group
                apiInstance.Usergroupaddmember(token, userid, groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupaddmember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **groupid** | [**Guid?**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupdelete"></a>
# **Usergroupdelete**
> void Usergroupdelete (string token, Guid? id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the group to delete.

            try
            {
                // Delete a group
                apiInstance.Usergroupdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the group to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupget"></a>
# **Usergroupget**
> void Usergroupget (string token, Guid? id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the user group to get.

            try
            {
                // Search and view details of a user group
                apiInstance.Usergroupget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupgetmembers"></a>
# **Usergroupgetmembers**
> void Usergroupgetmembers (string token, Guid? groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupgetmembersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var groupid = new Guid?(); // Guid? | The id of the user group to get.

            try
            {
                // View the members of a user group
                apiInstance.Usergroupgetmembers(token, groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupgetmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **groupid** | [**Guid?**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupgetuser"></a>
# **Usergroupgetuser**
> void Usergroupgetuser (string token, Guid? userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupgetuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to get his groups.

            try
            {
                // View the groups which a user is registered to
                apiInstance.Usergroupgetuser(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupgetuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to get his groups. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergrouplist"></a>
# **Usergrouplist**
> void Usergrouplist (string token, int? from, int? count, string type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergrouplistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 
            var type = type_example;  // string | The type of the groups to return. Either 'user', 'dynamic' or any other type of group. (optional) 

            try
            {
                // View a list of user groups
                apiInstance.Usergrouplist(token, from, count, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergrouplist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | [optional] 
 **count** | **int?**| The max number of records to return. | [optional] 
 **type** | **string**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergrouprefresh"></a>
# **Usergrouprefresh**
> void Usergrouprefresh (string token, Guid? group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergrouprefreshExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var group = new Guid?(); // Guid? | The ID of the group to refresh.

            try
            {
                // Refresh the dynamic group
                apiInstance.Usergrouprefresh(token, group);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergrouprefresh: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | [**Guid?**](.md)| The ID of the group to refresh. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupremovemember"></a>
# **Usergroupremovemember**
> void Usergroupremovemember (string token, Guid? userid, Guid? groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupremovememberExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var groupid = new Guid?(); // Guid? | The id of the group.

            try
            {
                // Remove a user from a group
                apiInstance.Usergroupremovemember(token, userid, groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupremovemember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **groupid** | [**Guid?**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupsave"></a>
# **Usergroupsave**
> void Usergroupsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a group
                apiInstance.Usergroupsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergrouptagmembers"></a>
# **Usergrouptagmembers**
> void Usergrouptagmembers (string token, Guid? group, string tags)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergrouptagmembersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var group = new Guid?(); // Guid? | The id of the group to save whose members have to be tagged.
            var tags = tags_example;  // string | The tags to assign to the members of the specified group, in JSON format. (optional) 

            try
            {
                // Assign tags to the members of a specified group
                apiInstance.Usergrouptagmembers(token, group, tags);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergrouptagmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | [**Guid?**](.md)| The id of the group to save whose members have to be tagged. | 
 **tags** | **string**| The tags to assign to the members of the specified group, in JSON format. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupuntagmembers"></a>
# **Usergroupuntagmembers**
> void Usergroupuntagmembers (string token, Guid? group, string tags)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupuntagmembersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var group = new Guid?(); // Guid? | The id of the group to save whose members have to be untagged.
            var tags = tags_example;  // string | The tags to unassign from the members of the specified group, in JSON format. (optional) 

            try
            {
                // Unassign tags from the members of a specified group
                apiInstance.Usergroupuntagmembers(token, group, tags);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupuntagmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | [**Guid?**](.md)| The id of the group to save whose members have to be untagged. | 
 **tags** | **string**| The tags to unassign from the members of the specified group, in JSON format. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userlist"></a>
# **Userlist**
> void Userlist (string token, int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var roleid = new Guid?(); // Guid? | The id of the role to filter users by, or empty to return all users. (optional) 
            var onlywithoutcard = onlywithoutcard_example;  // string | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View a list of users
                apiInstance.Userlist(token, from, count, roleid, onlywithoutcard, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **roleid** | [**Guid?**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userloadphoto"></a>
# **Userloadphoto**
> void Userloadphoto (string token, string upload, string filename, Guid? userid, bool? automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserloadphotoExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 
            var userid = new Guid?(); // Guid? | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'. (optional) 
            var automatch = true;  // bool? | Set this to true to find the specific user based on the file name.  (optional) 

            try
            {
                // Upload a photo for a specific user
                apiInstance.Userloadphoto(token, upload, filename, userid, automatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userloadphoto: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**Guid?**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **bool?**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usermovedata"></a>
# **Usermovedata**
> void Usermovedata (string token, Guid? source, Guid? destination)

Move data between users

Allows administrators to move data between users.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsermovedataExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var source = new Guid?(); // Guid? | The id of the user that is the source of the data.
            var destination = new Guid?(); // Guid? | The id of the user that is the destination of the data.

            try
            {
                // Move data between users
                apiInstance.Usermovedata(token, source, destination);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usermovedata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **source** | [**Guid?**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**Guid?**](.md)| The id of the user that is the destination of the data. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofiledelete"></a>
# **Userprofiledelete**
> void Userprofiledelete (string token, Guid? id)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofiledeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the user profile to delete.

            try
            {
                // Delete a user profile
                apiInstance.Userprofiledelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userprofiledelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the user profile to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofileget"></a>
# **Userprofileget**
> void Userprofileget (string token, Guid? id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofilegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the profile question set.

            try
            {
                // View a specific user profile
                apiInstance.Userprofileget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userprofileget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the profile question set. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilegetallview"></a>
# **Userprofilegetallview**
> void Userprofilegetallview (string token, Guid? id)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofilegetallviewExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the user to view, or empty for current user. (optional) 

            try
            {
                // Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
                apiInstance.Userprofilegetallview(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userprofilegetallview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the user to view, or empty for current user. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilelist"></a>
# **Userprofilelist**
> void Userprofilelist (string token, int? from, int? count)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofilelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 

            try
            {
                // View the list of user profiles
                apiInstance.Userprofilelist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userprofilelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | [optional] 
 **count** | **int?**| The max number of records to return. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilelistquestions"></a>
# **Userprofilelistquestions**
> void Userprofilelistquestions (string token)

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofilelistquestionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the list of all the available user questions
                apiInstance.Userprofilelistquestions(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userprofilelistquestions: " + e.Message );
            }
        }
    }
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

<a name="userprofilepreparestats"></a>
# **Userprofilepreparestats**
> void Userprofilepreparestats (string token, string _params)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofilepreparestatsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var _params = _params_example;  // string | The ID of the group, specified as 'group=...' (optional) 

            try
            {
                // Gets the statistics of a user group
                apiInstance.Userprofilepreparestats(token, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userprofilepreparestats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **_params** | **string**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilesave"></a>
# **Userprofilesave**
> void Userprofilesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofilesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit user profile questions
                apiInstance.Userprofilesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userprofilesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilesaveanswers"></a>
# **Userprofilesaveanswers**
> void Userprofilesaveanswers (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofilesaveanswersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
                apiInstance.Userprofilesaveanswers(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userprofilesaveanswers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userrequestpwdchange"></a>
# **Userrequestpwdchange**
> void Userrequestpwdchange (string domain, string email)

Requests a password change

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserrequestpwdchangeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var domain = domain_example;  // string | The domain of the account where the user exists.
            var email = email_example;  // string | The email of the user.

            try
            {
                // Requests a password change
                apiInstance.Userrequestpwdchange(domain, email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userrequestpwdchange: " + e.Message );
            }
        }
    }
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

<a name="usersave"></a>
# **Usersave**
> void Usersave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a user

Allows the user to create or edit a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a user
                apiInstance.Usersave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersavepwdchange"></a>
# **Usersavepwdchange**
> void Usersavepwdchange (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersavepwdchangeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Send email to the specified user(s) to set/change their passwords
                apiInstance.Usersavepwdchange(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersavepwdchange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsget"></a>
# **Usersettingsget**
> void Usersettingsget (string token, string keys, Guid? user)

Lists available user settings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingsgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var keys = keys_example;  // string | Setting key to get. Can be multiple separated by commas.
            var user = new Guid?(); // Guid? | The user id whose settings have to be returned. (optional) 

            try
            {
                // Lists available user settings
                apiInstance.Usersettingsget(token, keys, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersettingsget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**Guid?**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsgetmultiple"></a>
# **Usersettingsgetmultiple**
> void Usersettingsgetmultiple (string token, string keys, Guid? user)

Get multiple user settings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingsgetmultipleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var keys = keys_example;  // string | Setting key to get. Can be multiple separated by commas.
            var user = new Guid?(); // Guid? | The user id whose settings have to be returned. (optional) 

            try
            {
                // Get multiple user settings
                apiInstance.Usersettingsgetmultiple(token, keys, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersettingsgetmultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**Guid?**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingssave"></a>
# **Usersettingssave**
> void Usersettingssave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a user setting

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingssaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a user setting
                apiInstance.Usersettingssave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersettingssave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingssavemultiple"></a>
# **Usersettingssavemultiple**
> void Usersettingssavemultiple (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save multiple user settings at once

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingssavemultipleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save multiple user settings at once
                apiInstance.Usersettingssavemultiple(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersettingssavemultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="version"></a>
# **Version**
> void Version (string token)

Get current version information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VersionExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Get current version information
                apiInstance.Version(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Version: " + e.Message );
            }
        }
    }
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

<a name="virtuallineaddmyself"></a>
# **Virtuallineaddmyself**
> void Virtuallineaddmyself (string token, Guid? waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VirtuallineaddmyselfExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var waitinglineid = new Guid?(); // Guid? | ID of the waiting line to join.

            try
            {
                // Add myself to a waiting line
                apiInstance.Virtuallineaddmyself(token, waitinglineid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Virtuallineaddmyself: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **waitinglineid** | [**Guid?**](.md)| ID of the waiting line to join. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="virtuallinelist"></a>
# **Virtuallinelist**
> void Virtuallinelist (string token)

Lists waiting lines that have remote access enabled

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VirtuallinelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists waiting lines that have remote access enabled
                apiInstance.Virtuallinelist(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Virtuallinelist: " + e.Message );
            }
        }
    }
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

<a name="virtuallineremovemyself"></a>
# **Virtuallineremovemyself**
> void Virtuallineremovemyself (string token)

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VirtuallineremovemyselfExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Remove myself from a waiting line
                apiInstance.Virtuallineremovemyself(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Virtuallineremovemyself: " + e.Message );
            }
        }
    }
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

<a name="waitinglineadduser"></a>
# **Waitinglineadduser**
> void Waitinglineadduser (Guid? station, string user, Guid? locationid, DateTime? time, string signinrole, Guid? roleid, string services, Guid? eventid, Guid? staff, int? photosize)

Put user in a waiting line

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineadduserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station.
            var user = user_example;  // string | The user's card number.
            var locationid = new Guid?(); // Guid? | The location's id where the swipe must be saved. (optional) 
            var time = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time of the swipe. (optional) 
            var signinrole = signinrole_example;  // string | Specifies if the sign-in is for an attendee or a staff member (optional) 
            var roleid = new Guid?(); // Guid? | Specifies the role the user has selected in order to sign-in (optional) 
            var services = services_example;  // string | The services ids the user has selected. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event the user selected. (optional) 
            var staff = new Guid?(); // Guid? | The id of the staff member the user selected. (optional) 
            var photosize = 56;  // int? | The swiping user's photo size. (optional) 

            try
            {
                // Put user in a waiting line
                apiInstance.Waitinglineadduser(station, user, locationid, time, signinrole, roleid, services, eventid, staff, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Waitinglineadduser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station. | 
 **user** | **string**| The user&#39;s card number. | 
 **locationid** | [**Guid?**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **DateTime?**| The date and time of the swipe. | [optional] 
 **signinrole** | **string**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**Guid?**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **string**| The services ids the user has selected. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**Guid?**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **int?**| The swiping user&#39;s photo size. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglinedelete"></a>
# **Waitinglinedelete**
> void Waitinglinedelete (string token, Guid? id)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglinedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the line to delete.

            try
            {
                // Delete a waiting line
                apiInstance.Waitinglinedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Waitinglinedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the line to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglineget"></a>
# **Waitinglineget**
> void Waitinglineget (string token, Guid? id, int? photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglinegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the waiting line to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View details of a waiting line
                apiInstance.Waitinglineget(token, id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Waitinglineget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the waiting line to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglineisuserin"></a>
# **Waitinglineisuserin**
> void Waitinglineisuserin (Guid? station, DateTime? time, string user, Guid? location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineisuserinExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station.
            var time = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time of the swipe.
            var user = user_example;  // string | The card number of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked. (optional) 

            try
            {
                // Check whether a user is in a waiting line, signed-in or is not in the area
                apiInstance.Waitinglineisuserin(station, time, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Waitinglineisuserin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station. | 
 **time** | **DateTime?**| The date and time of the swipe. | 
 **user** | **string**| The card number of the user. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglinelist"></a>
# **Waitinglinelist**
> void Waitinglinelist (string token, int? from, int? count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglinelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of waiting lines
                apiInstance.Waitinglinelist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Waitinglinelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglineremoveuser"></a>
# **Waitinglineremoveuser**
> void Waitinglineremoveuser (string token, Guid? waitingline, Guid? itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineremoveuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var waitingline = new Guid?(); // Guid? | The id of the waiting line whose item has to be removed.
            var itemid = new Guid?(); // Guid? | The ID of the item that has to be removed.

            try
            {
                // Remove a user from a waiting line
                apiInstance.Waitinglineremoveuser(token, waitingline, itemid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Waitinglineremoveuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **waitingline** | [**Guid?**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**Guid?**](.md)| The ID of the item that has to be removed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglinesave"></a>
# **Waitinglinesave**
> void Waitinglinesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglinesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a waiting line
                apiInstance.Waitinglinesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Waitinglinesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglinesigninuser"></a>
# **Waitinglinesigninuser**
> void Waitinglinesigninuser (string token, Guid? waitingline, Guid? itemid, Guid? staff, int? photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglinesigninuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var waitingline = new Guid?(); // Guid? | The id of the waiting line whose item needs to be signed-in.
            var itemid = new Guid?(); // Guid? | The ID of the item that has to be signed-in.
            var staff = new Guid?(); // Guid? | The id of the staff member selected to sign-in.
            var photosize = 56;  // int? | The swiping user's photo size. (optional) 

            try
            {
                // Sign a user in from a waiting line
                apiInstance.Waitinglinesigninuser(token, waitingline, itemid, staff, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Waitinglinesigninuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **waitingline** | [**Guid?**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**Guid?**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**Guid?**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **int?**| The swiping user&#39;s photo size. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

