# \DefaultApi

All URIs are relative to *https://accucampus.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Actionassignmentdelete**](DefaultApi.md#Actionassignmentdelete) | **Get** /actionassignmentdelete | Remove an action item from an action plan
[**Actionassignmentget**](DefaultApi.md#Actionassignmentget) | **Get** /actionassignmentget | Search and view details of an action item assigned to a user
[**Actionassignmentlist**](DefaultApi.md#Actionassignmentlist) | **Get** /actionassignmentlist | View a list of action items in a user&#39;s plan
[**Actionassignmentlisthistory**](DefaultApi.md#Actionassignmentlisthistory) | **Get** /actionassignmentlisthistory | View the history of an action item assigned to a user
[**Actionassignmentlistmine**](DefaultApi.md#Actionassignmentlistmine) | **Get** /actionassignmentlistmine | List public action assignments assigned to the logged user
[**Actionassignmentlistpublichistory**](DefaultApi.md#Actionassignmentlistpublichistory) | **Get** /actionassignmentlistpublichistory | List public action assignment history
[**Actionassignmentmarkcomplete**](DefaultApi.md#Actionassignmentmarkcomplete) | **Get** /actionassignmentmarkcomplete | Bulk complete action items
[**Actionassignmentsave**](DefaultApi.md#Actionassignmentsave) | **Post** /actionassignmentsave | Add an action item to a user&#39;s action plan
[**Actionassignmentsavehistory**](DefaultApi.md#Actionassignmentsavehistory) | **Post** /actionassignmentsavehistory | Update an action item assigned to a user
[**Actionitemdelete**](DefaultApi.md#Actionitemdelete) | **Get** /actionitemdelete | Delete an action item
[**Actionitemget**](DefaultApi.md#Actionitemget) | **Get** /actionitemget | Search and view details of an action item
[**Actionitemlist**](DefaultApi.md#Actionitemlist) | **Get** /actionitemlist | View a list of action items
[**Actionitemsave**](DefaultApi.md#Actionitemsave) | **Post** /actionitemsave | Create or edit an action item
[**Actionloglist**](DefaultApi.md#Actionloglist) | **Get** /actionloglist | View a list of users action logs
[**Actionpackassign**](DefaultApi.md#Actionpackassign) | **Get** /actionpackassign | Assign an action item pack to a user
[**Actionpackdelete**](DefaultApi.md#Actionpackdelete) | **Get** /actionpackdelete | Delete an action item pack
[**Actionpackget**](DefaultApi.md#Actionpackget) | **Get** /actionpackget | View details of an action item pack
[**Actionpacklist**](DefaultApi.md#Actionpacklist) | **Get** /actionpacklist | View a list of action item packs
[**Actionpacksave**](DefaultApi.md#Actionpacksave) | **Post** /actionpacksave | Create or edit an action item pack
[**Actiontypedelete**](DefaultApi.md#Actiontypedelete) | **Get** /actiontypedelete | Delete an action item type
[**Actiontypeget**](DefaultApi.md#Actiontypeget) | **Get** /actiontypeget | View details of an action item type
[**Actiontypelist**](DefaultApi.md#Actiontypelist) | **Get** /actiontypelist | View a list of action item types
[**Actiontypesave**](DefaultApi.md#Actiontypesave) | **Post** /actiontypesave | Create or edit an action item type
[**Adhocquerycheckexecution**](DefaultApi.md#Adhocquerycheckexecution) | **Get** /adhocquerycheckexecution | Check the status of an ad hoc query execution
[**Adhocquerydelete**](DefaultApi.md#Adhocquerydelete) | **Get** /adhocquerydelete | Delete an ad hoc query
[**Adhocqueryexecute**](DefaultApi.md#Adhocqueryexecute) | **Get** /adhocqueryexecute | Execute an ad hoc query
[**Adhocqueryget**](DefaultApi.md#Adhocqueryget) | **Get** /adhocqueryget | View details of an ad hoc query
[**Adhocquerygetschema**](DefaultApi.md#Adhocquerygetschema) | **Get** /adhocquerygetschema | View the database schema for making ad hoc queries
[**Adhocquerylist**](DefaultApi.md#Adhocquerylist) | **Get** /adhocquerylist | View a list of saved ad hoc queries
[**Adhocquerylistexecutions**](DefaultApi.md#Adhocquerylistexecutions) | **Get** /adhocquerylistexecutions | View a list of ad hoc queries executions
[**Adhocquerysave**](DefaultApi.md#Adhocquerysave) | **Post** /adhocquerysave | Create or edit an ad hoc query
[**Adhocquerystopexecution**](DefaultApi.md#Adhocquerystopexecution) | **Get** /adhocquerystopexecution | Stops the execution of an ad hoc query
[**Adhocreportsreqaccess**](DefaultApi.md#Adhocreportsreqaccess) | **Get** /adhocreportsreqaccess | Request access to the ad-hoc reports
[**Advancedstationcheckunknownuser**](DefaultApi.md#Advancedstationcheckunknownuser) | **Get** /advancedstationcheckunknownuser | Check whether the user is known by the system.
[**Advancedstationcheckuserrole**](DefaultApi.md#Advancedstationcheckuserrole) | **Get** /advancedstationcheckuserrole | Check whether the user is a staff member, an attendee or both.
[**Advancedstationcreateuser**](DefaultApi.md#Advancedstationcreateuser) | **Get** /advancedstationcreateuser | Creates a user via a sign-in station.
[**Advancedstationgetevents**](DefaultApi.md#Advancedstationgetevents) | **Get** /advancedstationgetevents | Gets the courses available for a specific location and a specific student.
[**Advancedstationgetinfo**](DefaultApi.md#Advancedstationgetinfo) | **Get** /advancedstationgetinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**Advancedstationgetlocations**](DefaultApi.md#Advancedstationgetlocations) | **Get** /advancedstationgetlocations | Gets the locations available in a sign-in station.
[**Advancedstationgetlogstaff**](DefaultApi.md#Advancedstationgetlogstaff) | **Get** /advancedstationgetlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**Advancedstationgetroles**](DefaultApi.md#Advancedstationgetroles) | **Get** /advancedstationgetroles | Gets the user roles of the user trying to sign-in.
[**Advancedstationgetservices**](DefaultApi.md#Advancedstationgetservices) | **Get** /advancedstationgetservices | Gets the services available for a specific location.
[**Advancedstationgetstaff**](DefaultApi.md#Advancedstationgetstaff) | **Get** /advancedstationgetstaff | Gets the staff/tutors available for a specific location, course and service.
[**Advancedstationissignedin**](DefaultApi.md#Advancedstationissignedin) | **Get** /advancedstationissignedin | Gets whether a user is signed-in or not.
[**Advroleaddmissing**](DefaultApi.md#Advroleaddmissing) | **Get** /advroleaddmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**Advrolecheckperm**](DefaultApi.md#Advrolecheckperm) | **Get** /advrolecheckperm | Checks the permissions are assigned for the given roles
[**Advroledelete**](DefaultApi.md#Advroledelete) | **Get** /advroledelete | Delete a role
[**Advroledeletemapping**](DefaultApi.md#Advroledeletemapping) | **Get** /advroledeletemapping | Delete a role mapping
[**Advroleget**](DefaultApi.md#Advroleget) | **Get** /advroleget | View details of a role
[**Advrolelist**](DefaultApi.md#Advrolelist) | **Get** /advrolelist | Lists the roles for the current account
[**Advrolelistmaps**](DefaultApi.md#Advrolelistmaps) | **Get** /advrolelistmaps | Lists the maps a roles is mapped to
[**Advrolelistrolesmapped**](DefaultApi.md#Advrolelistrolesmapped) | **Get** /advrolelistrolesmapped | Lists the roles mappings
[**Advrolelisttemplates**](DefaultApi.md#Advrolelisttemplates) | **Get** /advrolelisttemplates | View a list of role templates
[**Advrolesave**](DefaultApi.md#Advrolesave) | **Post** /advrolesave | Create or edit a role
[**Advrolesavemapping**](DefaultApi.md#Advrolesavemapping) | **Post** /advrolesavemapping | Saves a role mapping
[**Advrolesuserlist**](DefaultApi.md#Advrolesuserlist) | **Get** /advrolesuserlist | List users. Alias to user.list, use that one instead.
[**Advroleuserupgrade**](DefaultApi.md#Advroleuserupgrade) | **Get** /advroleuserupgrade | Upgrade a user to another role (requires permission to edit those roles)
[**Appointmentcancel**](DefaultApi.md#Appointmentcancel) | **Get** /appointmentcancel | Cancel an appointment
[**Appointmentcheckisvalid**](DefaultApi.md#Appointmentcheckisvalid) | **Get** /appointmentcheckisvalid | Check if an appointment is valid or not
[**Appointmenteditanyway**](DefaultApi.md#Appointmenteditanyway) | **Get** /appointmenteditanyway | Edit an appointment even if it breaks activated rules
[**Appointmenteditpresence**](DefaultApi.md#Appointmenteditpresence) | **Get** /appointmenteditpresence | Edit the no-show status of an appointment
[**Appointmentfindallstaffslots**](DefaultApi.md#Appointmentfindallstaffslots) | **Get** /appointmentfindallstaffslots | Finds all staff available slots filtered by service, date, etc
[**Appointmentfindslots**](DefaultApi.md#Appointmentfindslots) | **Get** /appointmentfindslots | Finds available slots filtered by service, date, staff, etc
[**Appointmentfindstaff**](DefaultApi.md#Appointmentfindstaff) | **Get** /appointmentfindstaff | Finds staff available by service, date, event, etc
[**Appointmentget**](DefaultApi.md#Appointmentget) | **Get** /appointmentget | Search and view details of an appointment
[**Appointmentgetcurrent**](DefaultApi.md#Appointmentgetcurrent) | **Get** /appointmentgetcurrent | Get the current appointments for the user that is about to sign-in via the specified sign-in station.
[**Appointmentgetlocations**](DefaultApi.md#Appointmentgetlocations) | **Get** /appointmentgetlocations | Find locations where a service is available
[**Appointmentlist**](DefaultApi.md#Appointmentlist) | **Get** /appointmentlist | View a list of appointments
[**Appointmentlistmine**](DefaultApi.md#Appointmentlistmine) | **Get** /appointmentlistmine | View all my upcoming appointments
[**Appointmentlistupcoming**](DefaultApi.md#Appointmentlistupcoming) | **Get** /appointmentlistupcoming | Search and view details of all my upcoming appointments
[**Appointmentrescheduleoutlook**](DefaultApi.md#Appointmentrescheduleoutlook) | **Get** /appointmentrescheduleoutlook | Reschedule an appointment from MS Outlook.
[**Appointmentrestore**](DefaultApi.md#Appointmentrestore) | **Get** /appointmentrestore | Restore an appointment
[**Appointmentrestoreanyway**](DefaultApi.md#Appointmentrestoreanyway) | **Get** /appointmentrestoreanyway | Restore an appointment even if it breaks activated rules
[**Appointmentsave**](DefaultApi.md#Appointmentsave) | **Post** /appointmentsave | Schedule an appointment
[**Appointmentsetasvalid**](DefaultApi.md#Appointmentsetasvalid) | **Get** /appointmentsetasvalid | Schedule an appointment even if it breaks activated rules
[**Appointmentsuggestlocations**](DefaultApi.md#Appointmentsuggestlocations) | **Get** /appointmentsuggestlocations | View the locations with most appointments
[**Appointmentsuggestservices**](DefaultApi.md#Appointmentsuggestservices) | **Get** /appointmentsuggestservices | View the services with most appointments
[**Appointmentvoid**](DefaultApi.md#Appointmentvoid) | **Get** /appointmentvoid | Void an appointment
[**Appsharegetphone**](DefaultApi.md#Appsharegetphone) | **Get** /appsharegetphone | Gets the phone number of the current user
[**Appsharesendtext**](DefaultApi.md#Appsharesendtext) | **Get** /appsharesendtext | Sends an SMS with the link to the app
[**Attendancelogcommentdelete**](DefaultApi.md#Attendancelogcommentdelete) | **Get** /attendancelogcommentdelete | Delete a comment on an attendance log
[**Attendancelogcommentget**](DefaultApi.md#Attendancelogcommentget) | **Get** /attendancelogcommentget | View a comment on an attendance log
[**Attendancelogcommentlist**](DefaultApi.md#Attendancelogcommentlist) | **Get** /attendancelogcommentlist | View all the comments on a specific attendance log
[**Attendancelogcommentsave**](DefaultApi.md#Attendancelogcommentsave) | **Post** /attendancelogcommentsave | Save a comment on an attendance log
[**Attendancelogdelete**](DefaultApi.md#Attendancelogdelete) | **Get** /attendancelogdelete | Delete an attendance log
[**Attendancelogget**](DefaultApi.md#Attendancelogget) | **Get** /attendancelogget | Search and view details of an attendance log
[**Attendanceloggetchangehistory**](DefaultApi.md#Attendanceloggetchangehistory) | **Get** /attendanceloggetchangehistory | Search and view details of an attendance log&#39;s swipe history
[**Attendanceloglist**](DefaultApi.md#Attendanceloglist) | **Get** /attendanceloglist | View a list of attendance logs
[**Attendanceloglistmine**](DefaultApi.md#Attendanceloglistmine) | **Get** /attendanceloglistmine | Gets the attendance logs of the current user
[**Attendancelogliststaff**](DefaultApi.md#Attendancelogliststaff) | **Get** /attendancelogliststaff | Gets the attendance logs that the current user is involved in as staff
[**Attendancelogsave**](DefaultApi.md#Attendancelogsave) | **Post** /attendancelogsave | Create or edit an attendance log
[**Attendancelogsignout**](DefaultApi.md#Attendancelogsignout) | **Get** /attendancelogsignout | Sign out an attendance log
[**Attendancelogwhosin**](DefaultApi.md#Attendancelogwhosin) | **Get** /attendancelogwhosin | View who&#39;s in a location
[**Attendancerestrictiondelete**](DefaultApi.md#Attendancerestrictiondelete) | **Get** /attendancerestrictiondelete | Delete an attendance restriction
[**Attendancerestrictionget**](DefaultApi.md#Attendancerestrictionget) | **Get** /attendancerestrictionget | View details of an attendance restriction
[**Attendancerestrictionlist**](DefaultApi.md#Attendancerestrictionlist) | **Get** /attendancerestrictionlist | View a list of attendance restrictions
[**Attendancerestrictionsave**](DefaultApi.md#Attendancerestrictionsave) | **Post** /attendancerestrictionsave | Create or edit an attendance restriction
[**Beacondelete**](DefaultApi.md#Beacondelete) | **Get** /beacondelete | Delete a beacon profile
[**Beacondisable**](DefaultApi.md#Beacondisable) | **Get** /beacondisable | Disable beacon support account wide
[**Beaconget**](DefaultApi.md#Beaconget) | **Get** /beaconget | View details of a beacon profile
[**Beacongetlocations**](DefaultApi.md#Beacongetlocations) | **Get** /beacongetlocations | Get the sign-in stations assigned to specific beacons.
[**Beacongetstationlocation**](DefaultApi.md#Beacongetstationlocation) | **Get** /beacongetstationlocation | Get the location settings in the specified sign-in station.
[**Beacongetuuid**](DefaultApi.md#Beacongetuuid) | **Get** /beacongetuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**Beaconlist**](DefaultApi.md#Beaconlist) | **Get** /beaconlist | View a list of beacon profiles
[**Beaconlistprofiles**](DefaultApi.md#Beaconlistprofiles) | **Get** /beaconlistprofiles | View a list of beacon profiles with their characteristics
[**Beaconresetuuid**](DefaultApi.md#Beaconresetuuid) | **Get** /beaconresetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**Beaconsave**](DefaultApi.md#Beaconsave) | **Post** /beaconsave | Create or edit a beacon profile
[**Beaconscanlocations**](DefaultApi.md#Beaconscanlocations) | **Get** /beaconscanlocations | Check if there&#39;s location available to sign-in / out.
[**Beaconsetuuid**](DefaultApi.md#Beaconsetuuid) | **Get** /beaconsetuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**Beaconsilentregions**](DefaultApi.md#Beaconsilentregions) | **Get** /beaconsilentregions | View all the beacon regions defined for silent tracking
[**Beaconsilentsignin**](DefaultApi.md#Beaconsilentsignin) | **Get** /beaconsilentsignin | Sign-in silently from the location specified by a beacon
[**Beaconsilentsignout**](DefaultApi.md#Beaconsilentsignout) | **Get** /beaconsilentsignout | Sign-out silently from the location specified by a beacon
[**Bgjobgetstatus**](DefaultApi.md#Bgjobgetstatus) | **Get** /bgjobgetstatus | Get background job status
[**CallImport**](DefaultApi.md#CallImport) | **Get** /import | Import data into AccuCampus
[**Captchagetchallenge**](DefaultApi.md#Captchagetchallenge) | **Get** /captchagetchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**Captchagetimage**](DefaultApi.md#Captchagetimage) | **Get** /captchagetimage | Gets a captcha image that the user must complete to do certain requests.
[**Changelog**](DefaultApi.md#Changelog) | **Get** /changelog | Get the application change log
[**Clientget**](DefaultApi.md#Clientget) | **Get** /clientget | Get client
[**Clientlist**](DefaultApi.md#Clientlist) | **Get** /clientlist | Gets the clients of the specified conference
[**Clientsave**](DefaultApi.md#Clientsave) | **Post** /clientsave | Saves a client
[**Clientsendmessage**](DefaultApi.md#Clientsendmessage) | **Get** /clientsendmessage | Send a message to a client
[**Communityinvite**](DefaultApi.md#Communityinvite) | **Get** /communityinvite | Sends an invitation to everyone to AccuCampus Communities
[**Communityjoin**](DefaultApi.md#Communityjoin) | **Get** /communityjoin | Sends an invitation for myself to AccuCampus Communities
[**Compasscategorydelete**](DefaultApi.md#Compasscategorydelete) | **Get** /compasscategorydelete | Delete a compass category
[**Compasscategoryget**](DefaultApi.md#Compasscategoryget) | **Get** /compasscategoryget | View details of a compass category
[**Compasscategorylist**](DefaultApi.md#Compasscategorylist) | **Get** /compasscategorylist | View a list of compass categories
[**Compasscategorysave**](DefaultApi.md#Compasscategorysave) | **Post** /compasscategorysave | Create or edit a compass category
[**Compassservicelist**](DefaultApi.md#Compassservicelist) | **Get** /compassservicelist | View all the services added to the compass
[**Compassservicelistlocations**](DefaultApi.md#Compassservicelistlocations) | **Get** /compassservicelistlocations | View all the locations where a service added to the compass is available
[**Computerlabdeletecomputer**](DefaultApi.md#Computerlabdeletecomputer) | **Get** /computerlabdeletecomputer | Delete a computer
[**Computerlabgetcomputer**](DefaultApi.md#Computerlabgetcomputer) | **Get** /computerlabgetcomputer | Search and view details of a computer
[**Computerlabgetsettings**](DefaultApi.md#Computerlabgetsettings) | **Get** /computerlabgetsettings | Loads the settings for a computer lab
[**Computerlabissignedin**](DefaultApi.md#Computerlabissignedin) | **Get** /computerlabissignedin | Gets whether a user is signed-in or not.
[**Computerlablistcomputers**](DefaultApi.md#Computerlablistcomputers) | **Get** /computerlablistcomputers | View a list of computers
[**Computerlablistlabs**](DefaultApi.md#Computerlablistlabs) | **Get** /computerlablistlabs | View a list of the locations that use the Computer Lab add-on
[**Computerlabliststations**](DefaultApi.md#Computerlabliststations) | **Get** /computerlabliststations | View a list of sign-in stations available for computer labs.
[**Computerlabsavecomputer**](DefaultApi.md#Computerlabsavecomputer) | **Post** /computerlabsavecomputer | Create or edit a computer
[**Computerlabsavesettings**](DefaultApi.md#Computerlabsavesettings) | **Post** /computerlabsavesettings | Saves the settings for a computer lab
[**Computerlabsaveswipe**](DefaultApi.md#Computerlabsaveswipe) | **Post** /computerlabsaveswipe | Save a new swipe from a computer in a computer lab.
[**Deadendrecordingdelete**](DefaultApi.md#Deadendrecordingdelete) | **Get** /deadendrecordingdelete | Deletes a dead-end record group
[**Deadendrecordinglist**](DefaultApi.md#Deadendrecordinglist) | **Get** /deadendrecordinglist | Lists the recorded dead ends, if enabled
[**Deadendrecordinglistcomments**](DefaultApi.md#Deadendrecordinglistcomments) | **Get** /deadendrecordinglistcomments | Lists the comments for a specific dead end
[**Deadendrecordingsave**](DefaultApi.md#Deadendrecordingsave) | **Post** /deadendrecordingsave | Saves a dead-end record
[**Departmentdelete**](DefaultApi.md#Departmentdelete) | **Get** /departmentdelete | Delete a college department
[**Departmentget**](DefaultApi.md#Departmentget) | **Get** /departmentget | Search and view details of a college department
[**Departmentlist**](DefaultApi.md#Departmentlist) | **Get** /departmentlist | View a list of college departments
[**Departmentsave**](DefaultApi.md#Departmentsave) | **Post** /departmentsave | Create or edit a college department
[**Doc**](DefaultApi.md#Doc) | **Get** /doc | Get the documentation
[**Easyloginaddbgimage**](DefaultApi.md#Easyloginaddbgimage) | **Get** /easyloginaddbgimage | Adds background image for the login
[**Eventchecksessions**](DefaultApi.md#Eventchecksessions) | **Get** /eventchecksessions | Edit an event&#39;s sessions according to their schedule
[**Eventdelete**](DefaultApi.md#Eventdelete) | **Get** /eventdelete | Delete a course
[**Eventget**](DefaultApi.md#Eventget) | **Get** /eventget | Search and view details of a course
[**Eventgetsessionsbydate**](DefaultApi.md#Eventgetsessionsbydate) | **Get** /eventgetsessionsbydate | View a list of courses by date
[**Eventlist**](DefaultApi.md#Eventlist) | **Get** /eventlist | View a list of courses
[**Eventlistregistered**](DefaultApi.md#Eventlistregistered) | **Get** /eventlistregistered | View a list of courses I am registered to
[**Eventregaddme**](DefaultApi.md#Eventregaddme) | **Get** /eventregaddme | Register current user to a course
[**Eventregaddmetoall**](DefaultApi.md#Eventregaddmetoall) | **Get** /eventregaddmetoall | Register current user to all courses
[**Eventregaddmetogroup**](DefaultApi.md#Eventregaddmetogroup) | **Get** /eventregaddmetogroup | Register current user to a course group
[**Eventregadduser**](DefaultApi.md#Eventregadduser) | **Get** /eventregadduser | Register a user to a course for attendance
[**Eventregaddusertoall**](DefaultApi.md#Eventregaddusertoall) | **Get** /eventregaddusertoall | Register a user to assist with all courses
[**Eventregaddusertogroup**](DefaultApi.md#Eventregaddusertogroup) | **Get** /eventregaddusertogroup | Register a user to an course group
[**Eventreggetevents**](DefaultApi.md#Eventreggetevents) | **Get** /eventreggetevents | View course registration by user
[**Eventreggetgroups**](DefaultApi.md#Eventreggetgroups) | **Get** /eventreggetgroups | Lists the course group registrations of a user
[**Eventreggetmyevents**](DefaultApi.md#Eventreggetmyevents) | **Get** /eventreggetmyevents | View the event registrations of the current user
[**Eventreggetmygroups**](DefaultApi.md#Eventreggetmygroups) | **Get** /eventreggetmygroups | View all current user registrations to course groups
[**Eventreggetusers**](DefaultApi.md#Eventreggetusers) | **Get** /eventreggetusers | View course registration
[**Eventreggetusersfromgroup**](DefaultApi.md#Eventreggetusersfromgroup) | **Get** /eventreggetusersfromgroup | Lists the registrations for a course group
[**Eventreggetuserstoall**](DefaultApi.md#Eventreggetuserstoall) | **Get** /eventreggetuserstoall | View the users that are registered to all courses
[**Eventregremoveme**](DefaultApi.md#Eventregremoveme) | **Get** /eventregremoveme | Unregister current user from a course
[**Eventregremovemefromall**](DefaultApi.md#Eventregremovemefromall) | **Get** /eventregremovemefromall | Remove current user from the registration to all courses
[**Eventregremovemefromgroup**](DefaultApi.md#Eventregremovemefromgroup) | **Get** /eventregremovemefromgroup | Remove current user from a course group
[**Eventregremoveuser**](DefaultApi.md#Eventregremoveuser) | **Get** /eventregremoveuser | Remove a user from a course
[**Eventregremoveuserfromall**](DefaultApi.md#Eventregremoveuserfromall) | **Get** /eventregremoveuserfromall | Remove a user from the registration to all courses
[**Eventregremoveuserfromgroup**](DefaultApi.md#Eventregremoveuserfromgroup) | **Get** /eventregremoveuserfromgroup | Remove a user from a course group
[**Eventsave**](DefaultApi.md#Eventsave) | **Post** /eventsave | Create or edit a course
[**Eventsearchgroup**](DefaultApi.md#Eventsearchgroup) | **Get** /eventsearchgroup | Searches for the available event groups
[**Export**](DefaultApi.md#Export) | **Get** /export | Export AccuCampus data
[**Exportlisttypes**](DefaultApi.md#Exportlisttypes) | **Get** /exportlisttypes | Lists available export types
[**Featurelist**](DefaultApi.md#Featurelist) | **Get** /featurelist | Lists the available features.
[**Holidaylist**](DefaultApi.md#Holidaylist) | **Get** /holidaylist | View a list of entered holidays
[**Holidaysave**](DefaultApi.md#Holidaysave) | **Post** /holidaysave | Create or edit a list of holidays
[**Holidaysuggest**](DefaultApi.md#Holidaysuggest) | **Get** /holidaysuggest | View the holiday suggestions in the given term
[**Importlisttypes**](DefaultApi.md#Importlisttypes) | **Get** /importlisttypes | Lists available import types
[**Interactiondelete**](DefaultApi.md#Interactiondelete) | **Get** /interactiondelete | Delete an interaction
[**Interactionfeed**](DefaultApi.md#Interactionfeed) | **Get** /interactionfeed | Get the interactions feed
[**Interactionget**](DefaultApi.md#Interactionget) | **Get** /interactionget | View an interaction
[**Interactionlistprivatesummary**](DefaultApi.md#Interactionlistprivatesummary) | **Get** /interactionlistprivatesummary | Get current user&#39;s latest private interactions
[**Interactionsave**](DefaultApi.md#Interactionsave) | **Post** /interactionsave | Save an interaction
[**Licenseacceptagreement**](DefaultApi.md#Licenseacceptagreement) | **Get** /licenseacceptagreement | Accept the license agreement
[**Licensegetagreementstatus**](DefaultApi.md#Licensegetagreementstatus) | **Get** /licensegetagreementstatus | Check if license agreement has been accepted
[**Licensegetcurrent**](DefaultApi.md#Licensegetcurrent) | **Get** /licensegetcurrent | Gets the current license information
[**Licenserenew**](DefaultApi.md#Licenserenew) | **Get** /licenserenew | Contact Engineerica in order to renew the AccuCampus subscription
[**Likedelete**](DefaultApi.md#Likedelete) | **Get** /likedelete | Delete a like
[**Likelist**](DefaultApi.md#Likelist) | **Get** /likelist | View all the likes associated to a target
[**Likesave**](DefaultApi.md#Likesave) | **Post** /likesave | Save a like
[**Listtimezones**](DefaultApi.md#Listtimezones) | **Get** /listtimezones | Lists the available timezones
[**Locationdelete**](DefaultApi.md#Locationdelete) | **Get** /locationdelete | Delete a location
[**Locationget**](DefaultApi.md#Locationget) | **Get** /locationget | Search and view details of a location
[**Locationlist**](DefaultApi.md#Locationlist) | **Get** /locationlist | View a list of locations
[**Locationsave**](DefaultApi.md#Locationsave) | **Post** /locationsave | Create or edit a location
[**Login**](DefaultApi.md#Login) | **Get** /login | Login
[**Logout**](DefaultApi.md#Logout) | **Get** /logout | Logout
[**Mediacheckin**](DefaultApi.md#Mediacheckin) | **Get** /mediacheckin | Check in media item
[**Mediacheckout**](DefaultApi.md#Mediacheckout) | **Get** /mediacheckout | Check out media item
[**Mediacheckoutlist**](DefaultApi.md#Mediacheckoutlist) | **Get** /mediacheckoutlist | View a list of past media checkouts
[**Mediadelete**](DefaultApi.md#Mediadelete) | **Get** /mediadelete | Delete a media item
[**Mediadeletecheckoutlog**](DefaultApi.md#Mediadeletecheckoutlog) | **Get** /mediadeletecheckoutlog | Delete a media checkout log
[**Mediaget**](DefaultApi.md#Mediaget) | **Get** /mediaget | Search and view details of a media item
[**Mediagetbycode**](DefaultApi.md#Mediagetbycode) | **Get** /mediagetbycode | Search media item by unique code
[**Mediagetcheckout**](DefaultApi.md#Mediagetcheckout) | **Get** /mediagetcheckout | View details of a media item checkout information
[**Mediagetcheckoutlog**](DefaultApi.md#Mediagetcheckoutlog) | **Get** /mediagetcheckoutlog | View details of a media checkout log
[**Medialist**](DefaultApi.md#Medialist) | **Get** /medialist | View a list of media items
[**Mediasave**](DefaultApi.md#Mediasave) | **Post** /mediasave | Create or edit a media item
[**Mediatypedelete**](DefaultApi.md#Mediatypedelete) | **Get** /mediatypedelete | Delete a media type
[**Mediatypeget**](DefaultApi.md#Mediatypeget) | **Get** /mediatypeget | Search and view details of a media type
[**Mediatypelist**](DefaultApi.md#Mediatypelist) | **Get** /mediatypelist | View a list of media types
[**Mediatypesave**](DefaultApi.md#Mediatypesave) | **Post** /mediatypesave | Create or edit a media type
[**Memorizedreportdelete**](DefaultApi.md#Memorizedreportdelete) | **Get** /memorizedreportdelete | Delete memorized report
[**Memorizedreportget**](DefaultApi.md#Memorizedreportget) | **Get** /memorizedreportget | View details of a memorized report
[**Memorizedreportlist**](DefaultApi.md#Memorizedreportlist) | **Get** /memorizedreportlist | View a list of all his memorized reports
[**Memorizedreportsave**](DefaultApi.md#Memorizedreportsave) | **Post** /memorizedreportsave | Create or edit a memorized report
[**Menugetitems**](DefaultApi.md#Menugetitems) | **Get** /menugetitems | Gets the items on the menu
[**Myaccount**](DefaultApi.md#Myaccount) | **Get** /myaccount | Gets the logged in user account.
[**Myianatimezone**](DefaultApi.md#Myianatimezone) | **Get** /myianatimezone | Gets the current time zone&#39;s iana name
[**Myprofile**](DefaultApi.md#Myprofile) | **Get** /myprofile | Gets the logged in user information.
[**Myrights**](DefaultApi.md#Myrights) | **Get** /myrights | Gets the list of actions the user can execute.
[**Mysaveprofile**](DefaultApi.md#Mysaveprofile) | **Post** /mysaveprofile | Updates logged user&#39;s profile information
[**Notificationdelete**](DefaultApi.md#Notificationdelete) | **Get** /notificationdelete | Delete a notification
[**Notificationget**](DefaultApi.md#Notificationget) | **Get** /notificationget | View a notification
[**Notificationgetforstation**](DefaultApi.md#Notificationgetforstation) | **Get** /notificationgetforstation | Gets all public (in station) notifications for the specific user
[**Notificationgetunreadcount**](DefaultApi.md#Notificationgetunreadcount) | **Get** /notificationgetunreadcount | Get the number of unread notifications
[**Notificationlist**](DefaultApi.md#Notificationlist) | **Get** /notificationlist | View a list of all sent notifications
[**Notificationlistmine**](DefaultApi.md#Notificationlistmine) | **Get** /notificationlistmine | View all the notifications sent to the current user
[**Notificationmarkasread**](DefaultApi.md#Notificationmarkasread) | **Get** /notificationmarkasread | Mark a notification as read
[**Notificationmarkasunread**](DefaultApi.md#Notificationmarkasunread) | **Get** /notificationmarkasunread | Mark a notification as unread
[**Notificationsend**](DefaultApi.md#Notificationsend) | **Get** /notificationsend | Send notifications on screen, via email or text to users
[**Notificationsendonscreen**](DefaultApi.md#Notificationsendonscreen) | **Get** /notificationsendonscreen | Send on-screen notifications
[**Notificationtopicdelete**](DefaultApi.md#Notificationtopicdelete) | **Get** /notificationtopicdelete | Delete a notification topic
[**Notificationtopicget**](DefaultApi.md#Notificationtopicget) | **Get** /notificationtopicget | Search and view details of a notification topic
[**Notificationtopiclist**](DefaultApi.md#Notificationtopiclist) | **Get** /notificationtopiclist | List all the notification topics
[**Notificationtopiclistsubscribe**](DefaultApi.md#Notificationtopiclistsubscribe) | **Get** /notificationtopiclistsubscribe | List all the notification topics available to subscribe
[**Notificationtopicsave**](DefaultApi.md#Notificationtopicsave) | **Post** /notificationtopicsave | Create or edit a notification topic
[**Pushderegister**](DefaultApi.md#Pushderegister) | **Get** /pushderegister | Deregisters the current device to receive push notifications
[**Pushregister**](DefaultApi.md#Pushregister) | **Get** /pushregister | Registers the current device to receive push notifications
[**Qrlabelsprint**](DefaultApi.md#Qrlabelsprint) | **Get** /qrlabelsprint | Print and email QR labels
[**Qrloginget**](DefaultApi.md#Qrloginget) | **Get** /qrloginget | Gets an image of a QR token
[**Qrloginlogin**](DefaultApi.md#Qrloginlogin) | **Get** /qrloginlogin | Login
[**Quickpaneldeletewidget**](DefaultApi.md#Quickpaneldeletewidget) | **Get** /quickpaneldeletewidget | Deletes a widget from the Quick Panel
[**Quickpanelfetchwidget**](DefaultApi.md#Quickpanelfetchwidget) | **Get** /quickpanelfetchwidget | Fetches the information for a specific widget.
[**Quickpanelgetwidget**](DefaultApi.md#Quickpanelgetwidget) | **Get** /quickpanelgetwidget | View details of a widget included in the Quick Panel
[**Quickpanelinit**](DefaultApi.md#Quickpanelinit) | **Get** /quickpanelinit | Returns the initial information required to show the quick panels
[**Quickpanellistwidgets**](DefaultApi.md#Quickpanellistwidgets) | **Get** /quickpanellistwidgets | Lists all the widgets that are added in the Quick Panel
[**Quickpanellistwidgettypes**](DefaultApi.md#Quickpanellistwidgettypes) | **Get** /quickpanellistwidgettypes | Lists all the widget types available in the system
[**Quickpanelreorderwidgets**](DefaultApi.md#Quickpanelreorderwidgets) | **Get** /quickpanelreorderwidgets | Reorders the widgets and moves them to a specific column
[**Quickpanelsavewidget**](DefaultApi.md#Quickpanelsavewidget) | **Post** /quickpanelsavewidget | Saves a widget for the Quick Panel
[**Ratingflag**](DefaultApi.md#Ratingflag) | **Get** /ratingflag | Flags one rating for moderation
[**Ratingflagcomment**](DefaultApi.md#Ratingflagcomment) | **Get** /ratingflagcomment | Flags one comment for moderation
[**Ratingget**](DefaultApi.md#Ratingget) | **Get** /ratingget | Get rating for one or more entities
[**Ratinggetall**](DefaultApi.md#Ratinggetall) | **Get** /ratinggetall | Gets the full ratings and comments for a specific entity
[**Ratinggetcomments**](DefaultApi.md#Ratinggetcomments) | **Get** /ratinggetcomments | Gets all the comments for a rating
[**Ratinggetpending**](DefaultApi.md#Ratinggetpending) | **Get** /ratinggetpending | Gets info of pre-saved and pre-approved ratings
[**Ratinggetpendingmoderation**](DefaultApi.md#Ratinggetpendingmoderation) | **Get** /ratinggetpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
[**Ratingmoderate**](DefaultApi.md#Ratingmoderate) | **Get** /ratingmoderate | Allows the user to accept or reject a comment
[**Ratingpostcomment**](DefaultApi.md#Ratingpostcomment) | **Get** /ratingpostcomment | Posts a comments for in a rating
[**Ratingrate**](DefaultApi.md#Ratingrate) | **Get** /ratingrate | Rates one entity
[**Ratingratepending**](DefaultApi.md#Ratingratepending) | **Get** /ratingratepending | Rates a pre-saved and pre-approved entity
[**Ratingvote**](DefaultApi.md#Ratingvote) | **Get** /ratingvote | Votes up or down a rating
[**Reportattanalyticsprepare**](DefaultApi.md#Reportattanalyticsprepare) | **Get** /reportattanalyticsprepare | Query and load an attendance analytics report
[**Reportlist**](DefaultApi.md#Reportlist) | **Get** /reportlist | View a list of available reports
[**Reportpermissionsbyuser**](DefaultApi.md#Reportpermissionsbyuser) | **Get** /reportpermissionsbyuser | Permissions by user report
[**Reportprepare**](DefaultApi.md#Reportprepare) | **Get** /reportprepare | Queries and loads the specified report, in background.
[**Reportquery**](DefaultApi.md#Reportquery) | **Get** /reportquery | Query and load a specified report
[**Reportscheduledelete**](DefaultApi.md#Reportscheduledelete) | **Get** /reportscheduledelete | Delete a report schedule
[**Reportscheduleget**](DefaultApi.md#Reportscheduleget) | **Get** /reportscheduleget | Get a report schedule
[**Reportschedulelist**](DefaultApi.md#Reportschedulelist) | **Get** /reportschedulelist | View a list of the scheduled reports
[**Reportschedulesave**](DefaultApi.md#Reportschedulesave) | **Post** /reportschedulesave | Create or edit a report schedule
[**Reporttagresults**](DefaultApi.md#Reporttagresults) | **Get** /reporttagresults | Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
[**Riskmodelcheckanalysis**](DefaultApi.md#Riskmodelcheckanalysis) | **Get** /riskmodelcheckanalysis | Check the status of the analysis of a specified risk assessment model
[**Riskmodeldelete**](DefaultApi.md#Riskmodeldelete) | **Get** /riskmodeldelete | Delete a risk assessment model
[**Riskmodelget**](DefaultApi.md#Riskmodelget) | **Get** /riskmodelget | View details of a risk assessment model
[**Riskmodelgetscore**](DefaultApi.md#Riskmodelgetscore) | **Get** /riskmodelgetscore | View the risk score for a specific user
[**Riskmodellist**](DefaultApi.md#Riskmodellist) | **Get** /riskmodellist | View a list of risk assessment models
[**Riskmodelpredict**](DefaultApi.md#Riskmodelpredict) | **Get** /riskmodelpredict | Predict risk based on an assessment model
[**Riskmodelprocess**](DefaultApi.md#Riskmodelprocess) | **Get** /riskmodelprocess | Process a risk assessment model
[**Riskmodelrefresh**](DefaultApi.md#Riskmodelrefresh) | **Get** /riskmodelrefresh | Refresh the information used in a risk assessment model
[**Riskmodelsave**](DefaultApi.md#Riskmodelsave) | **Post** /riskmodelsave | Create or edit a risk assessment model
[**Riskmodeltermprecedences**](DefaultApi.md#Riskmodeltermprecedences) | **Get** /riskmodeltermprecedences | View all default term precedences
[**Rolelist**](DefaultApi.md#Rolelist) | **Get** /rolelist | Show a list of roles
[**Ruledelete**](DefaultApi.md#Ruledelete) | **Get** /ruledelete | Delete a rule
[**Ruleget**](DefaultApi.md#Ruleget) | **Get** /ruleget | View details of a rule
[**Rulegeteventtype**](DefaultApi.md#Rulegeteventtype) | **Get** /rulegeteventtype | View details of a rule event type
[**Rulelist**](DefaultApi.md#Rulelist) | **Get** /rulelist | View a list of user rules
[**Rulelistactions**](DefaultApi.md#Rulelistactions) | **Get** /rulelistactions | View a list of rule actions available
[**Rulelisteventtypes**](DefaultApi.md#Rulelisteventtypes) | **Get** /rulelisteventtypes | View a list of rule event types
[**Rulelisthttprequests**](DefaultApi.md#Rulelisthttprequests) | **Get** /rulelisthttprequests | View all the http requests sent as a result of a rule
[**Rulesave**](DefaultApi.md#Rulesave) | **Post** /rulesave | Create or edit a rule
[**Scheduledelete**](DefaultApi.md#Scheduledelete) | **Get** /scheduledelete | Delete a schedule slot
[**Scheduledeletemine**](DefaultApi.md#Scheduledeletemine) | **Get** /scheduledeletemine | Delete a specific block from a user&#39;s own schedule
[**Scheduleenable**](DefaultApi.md#Scheduleenable) | **Get** /scheduleenable | Enable or disable the schedule for a specific person
[**Scheduleenablemine**](DefaultApi.md#Scheduleenablemine) | **Get** /scheduleenablemine | Enable or disable current user&#39;s schedule
[**Schedulefindallstaffslots**](DefaultApi.md#Schedulefindallstaffslots) | **Get** /schedulefindallstaffslots | Search available schedule slots by service, event, date
[**Schedulefindslots**](DefaultApi.md#Schedulefindslots) | **Get** /schedulefindslots | Search available schedule slots by service, event, date and/or staff
[**Schedulefindstaffavail**](DefaultApi.md#Schedulefindstaffavail) | **Get** /schedulefindstaffavail | Search available staff members slots by service, event, and/or date
[**Scheduleget**](DefaultApi.md#Scheduleget) | **Get** /scheduleget | Search and view details of a specific schedule slot
[**Schedulegetmine**](DefaultApi.md#Schedulegetmine) | **Get** /schedulegetmine | View details of a specific schedule block, for current user
[**Schedulegetstaff**](DefaultApi.md#Schedulegetstaff) | **Get** /schedulegetstaff | View a list of schedule information of a specified person
[**Schedulegetstaffmine**](DefaultApi.md#Schedulegetstaffmine) | **Get** /schedulegetstaffmine | View current user&#39;s schedule information
[**Scheduleintegrationdeleteitem**](DefaultApi.md#Scheduleintegrationdeleteitem) | **Get** /scheduleintegrationdeleteitem | Delete a schedule item looking up by a third party ID
[**Scheduleintegrationdeleteitemsbymasterid**](DefaultApi.md#Scheduleintegrationdeleteitemsbymasterid) | **Get** /scheduleintegrationdeleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**Scheduleintegrationgetitem**](DefaultApi.md#Scheduleintegrationgetitem) | **Get** /scheduleintegrationgetitem | Get a schedule item looking up by a third party ID
[**Scheduleintegrationsaveitem**](DefaultApi.md#Scheduleintegrationsaveitem) | **Post** /scheduleintegrationsaveitem | Save a schedule item looking up by a third party ID
[**Scheduleintegrationsetid**](DefaultApi.md#Scheduleintegrationsetid) | **Get** /scheduleintegrationsetid | Set a 3rd party ID on a specific schedule item
[**Schedulemyofftimes**](DefaultApi.md#Schedulemyofftimes) | **Get** /schedulemyofftimes | View current user&#39;s schedule exceptions
[**Schedulesave**](DefaultApi.md#Schedulesave) | **Post** /schedulesave | Create or edit a schedule slot
[**Schedulesavemine**](DefaultApi.md#Schedulesavemine) | **Post** /schedulesavemine | Create or edit a block in current user&#39;s schedule
[**Search**](DefaultApi.md#Search) | **Get** /search | Search
[**Searchgetentities**](DefaultApi.md#Searchgetentities) | **Get** /searchgetentities | Get the information of the entities that can be searched
[**Securityassesspermission**](DefaultApi.md#Securityassesspermission) | **Get** /securityassesspermission | Returns the list of users for a specific permission
[**Securityassessrole**](DefaultApi.md#Securityassessrole) | **Get** /securityassessrole | Returns the list of permissions for a specific role
[**Securityassessscope**](DefaultApi.md#Securityassessscope) | **Get** /securityassessscope | Returns the list of users for a specific user
[**Securityassessuser**](DefaultApi.md#Securityassessuser) | **Get** /securityassessuser | Returns the list of permissions for a specific user
[**Seminardelete**](DefaultApi.md#Seminardelete) | **Get** /seminardelete | Delete an event
[**Seminarget**](DefaultApi.md#Seminarget) | **Get** /seminarget | Search and view details of a event
[**Seminarlist**](DefaultApi.md#Seminarlist) | **Get** /seminarlist | View a list of events
[**Seminarsave**](DefaultApi.md#Seminarsave) | **Post** /seminarsave | Create or edit a event
[**Serviceassignmentaddservice**](DefaultApi.md#Serviceassignmentaddservice) | **Get** /serviceassignmentaddservice | Enable a service in a specific location
[**Serviceassignmentgetlocation**](DefaultApi.md#Serviceassignmentgetlocation) | **Get** /serviceassignmentgetlocation | View a list of services enabled for a specific location
[**Serviceassignmentgetservice**](DefaultApi.md#Serviceassignmentgetservice) | **Get** /serviceassignmentgetservice | View a list of locations where a service is available
[**Serviceassignmentremoveservice**](DefaultApi.md#Serviceassignmentremoveservice) | **Get** /serviceassignmentremoveservice | Remove a service from a location
[**Servicedelete**](DefaultApi.md#Servicedelete) | **Get** /servicedelete | Delete a service
[**Serviceget**](DefaultApi.md#Serviceget) | **Get** /serviceget | Search and view details of a service
[**Servicelist**](DefaultApi.md#Servicelist) | **Get** /servicelist | View a list of services
[**Servicesave**](DefaultApi.md#Servicesave) | **Post** /servicesave | Create or edit a service
[**Sessionattendancelogaddnote**](DefaultApi.md#Sessionattendancelogaddnote) | **Get** /sessionattendancelogaddnote | Add a note to a class attendance log
[**Sessionattendancelogget**](DefaultApi.md#Sessionattendancelogget) | **Get** /sessionattendancelogget | View details of a class attendance log
[**Sessionattendanceloggetuser**](DefaultApi.md#Sessionattendanceloggetuser) | **Get** /sessionattendanceloggetuser | View the class session attendance information for a specific user
[**Sessionattendanceloglist**](DefaultApi.md#Sessionattendanceloglist) | **Get** /sessionattendanceloglist | View attendance logs of the specified session
[**Sessionattendanceloglistevent**](DefaultApi.md#Sessionattendanceloglistevent) | **Get** /sessionattendanceloglistevent | View the attendance information of an entire class
[**Sessionattendanceloglistsummary**](DefaultApi.md#Sessionattendanceloglistsummary) | **Get** /sessionattendanceloglistsummary | View the attendance summary for a class and/or a attendee
[**Sessionattendancelogmylistsummary**](DefaultApi.md#Sessionattendancelogmylistsummary) | **Get** /sessionattendancelogmylistsummary | View my attendance summary
[**Sessionattendancelogsave**](DefaultApi.md#Sessionattendancelogsave) | **Post** /sessionattendancelogsave | Create or edit a class attendance log
[**Sessionattendancelogsaveswipe**](DefaultApi.md#Sessionattendancelogsaveswipe) | **Post** /sessionattendancelogsaveswipe | Create or edit a class attendance log swipe
[**Sessionbulkupdate**](DefaultApi.md#Sessionbulkupdate) | **Get** /sessionbulkupdate | Bulk update event sessions
[**Sessionget**](DefaultApi.md#Sessionget) | **Get** /sessionget | View details of a session
[**Sessiongetschedule**](DefaultApi.md#Sessiongetschedule) | **Get** /sessiongetschedule | Gets the schedule for a location, instructor or attendees
[**Sessionlist**](DefaultApi.md#Sessionlist) | **Get** /sessionlist | Gets all future sessions of the current semester
[**Sessionregaddcurrentuser**](DefaultApi.md#Sessionregaddcurrentuser) | **Get** /sessionregaddcurrentuser | Register current user to an event session
[**Sessionregadduser**](DefaultApi.md#Sessionregadduser) | **Get** /sessionregadduser | Register users for events
[**Sessionreggetmysessions**](DefaultApi.md#Sessionreggetmysessions) | **Get** /sessionreggetmysessions | View all the sessions the logged user is registered to
[**Sessionreggetsessions**](DefaultApi.md#Sessionreggetsessions) | **Get** /sessionreggetsessions | Lists the registrations for a specific user
[**Sessionreggetsettings**](DefaultApi.md#Sessionreggetsettings) | **Get** /sessionreggetsettings | Get the settings for session registration
[**Sessionreggetusers**](DefaultApi.md#Sessionreggetusers) | **Get** /sessionreggetusers | Lists the registrations for a specific session
[**Sessionreglistsessions**](DefaultApi.md#Sessionreglistsessions) | **Get** /sessionreglistsessions | List the sessions available for a specific event
[**Sessionreglistupcoming**](DefaultApi.md#Sessionreglistupcoming) | **Get** /sessionreglistupcoming | View a list of upcoming event sessions
[**Sessionreglistupcomingevent**](DefaultApi.md#Sessionreglistupcomingevent) | **Get** /sessionreglistupcomingevent | View a list of upcoming sessions of a particular event
[**Sessionregremovecurrentuser**](DefaultApi.md#Sessionregremovecurrentuser) | **Get** /sessionregremovecurrentuser | Unregister current user from an event session
[**Sessionregremoveuser**](DefaultApi.md#Sessionregremoveuser) | **Get** /sessionregremoveuser | Removes a user from an event session
[**Sessionregsavesettings**](DefaultApi.md#Sessionregsavesettings) | **Post** /sessionregsavesettings | Save the settings for an event&#39;s session registration
[**Sessionswipedelete**](DefaultApi.md#Sessionswipedelete) | **Get** /sessionswipedelete | Delete a session swipe
[**Sessionswipeget**](DefaultApi.md#Sessionswipeget) | **Get** /sessionswipeget | View details of a class attendance swipe
[**Sessionswipelistunresolved**](DefaultApi.md#Sessionswipelistunresolved) | **Get** /sessionswipelistunresolved | View a list of unresolved swipes
[**Sessionswiperesolve**](DefaultApi.md#Sessionswiperesolve) | **Get** /sessionswiperesolve | Resolve a swipe and create the corresponding attendance log
[**Sessionswipesave**](DefaultApi.md#Sessionswipesave) | **Post** /sessionswipesave | Creates a new swipe, and if possible, creates the attendance log
[**Sessionswipesaveanonym**](DefaultApi.md#Sessionswipesaveanonym) | **Post** /sessionswipesaveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
[**Settingaddlogo**](DefaultApi.md#Settingaddlogo) | **Get** /settingaddlogo | Add a logo to the account
[**Settingget**](DefaultApi.md#Settingget) | **Get** /settingget | Get settings for the account or the specified scope
[**Settingsave**](DefaultApi.md#Settingsave) | **Post** /settingsave | Save settings for the account or the specified scope
[**Settingviewgeneral**](DefaultApi.md#Settingviewgeneral) | **Get** /settingviewgeneral | View general settings for the account
[**Socialcontacts**](DefaultApi.md#Socialcontacts) | **Get** /socialcontacts | Gets the list of contacts in the network
[**Socialgroupaddmembers**](DefaultApi.md#Socialgroupaddmembers) | **Get** /socialgroupaddmembers | Adds new members to a group (which the user must own already)
[**Socialgroupdelete**](DefaultApi.md#Socialgroupdelete) | **Get** /socialgroupdelete | Deletes a group
[**Socialgrouplist**](DefaultApi.md#Socialgrouplist) | **Get** /socialgrouplist | View all the groups the current user is in
[**Socialgrouplistmembers**](DefaultApi.md#Socialgrouplistmembers) | **Get** /socialgrouplistmembers | Lists the members of a group
[**Socialgroupremovemembers**](DefaultApi.md#Socialgroupremovemembers) | **Get** /socialgroupremovemembers | Removes members from a group (which the user must own already)
[**Socialgroupremovemyself**](DefaultApi.md#Socialgroupremovemyself) | **Get** /socialgroupremovemyself | Removes myself from an existent group
[**Socialgroupsave**](DefaultApi.md#Socialgroupsave) | **Post** /socialgroupsave | Saves a new group
[**Ssogeneratekey**](DefaultApi.md#Ssogeneratekey) | **Get** /ssogeneratekey | Generate/reset single sign on access key.
[**Ssogetsettings**](DefaultApi.md#Ssogetsettings) | **Get** /ssogetsettings | View single sign on settings.
[**Ssoissuetoken**](DefaultApi.md#Ssoissuetoken) | **Get** /ssoissuetoken | Issue single sign-on token
[**Ssosavesettings**](DefaultApi.md#Ssosavesettings) | **Post** /ssosavesettings | Edit single sign-on settings.
[**Staffavailaddmetoallservices**](DefaultApi.md#Staffavailaddmetoallservices) | **Get** /staffavailaddmetoallservices | Associate current user to all services
[**Staffavailaddmetoservice**](DefaultApi.md#Staffavailaddmetoservice) | **Get** /staffavailaddmetoservice | Associate current user to a service
[**Staffavailaddusertoallservices**](DefaultApi.md#Staffavailaddusertoallservices) | **Get** /staffavailaddusertoallservices | Associate a staff member to all services
[**Staffavailaddusertoservice**](DefaultApi.md#Staffavailaddusertoservice) | **Get** /staffavailaddusertoservice | Associate a staff member to a service
[**Staffavailgetmyservices**](DefaultApi.md#Staffavailgetmyservices) | **Get** /staffavailgetmyservices | View the services the current user is available for
[**Staffavailgetservices**](DefaultApi.md#Staffavailgetservices) | **Get** /staffavailgetservices | View a list of services that a staff member is available for
[**Staffavailgetusersforservice**](DefaultApi.md#Staffavailgetusersforservice) | **Get** /staffavailgetusersforservice | View a list of staff members that are available for a specific service
[**Staffavaillisttypes**](DefaultApi.md#Staffavaillisttypes) | **Get** /staffavaillisttypes | View all the availability types
[**Staffavailremovemefromallservices**](DefaultApi.md#Staffavailremovemefromallservices) | **Get** /staffavailremovemefromallservices | Remove current user from all services
[**Staffavailremovemefromservice**](DefaultApi.md#Staffavailremovemefromservice) | **Get** /staffavailremovemefromservice | Remove current user from a service
[**Staffavailremoveuserfromallservices**](DefaultApi.md#Staffavailremoveuserfromallservices) | **Get** /staffavailremoveuserfromallservices | Removes a staff member from the registration to all services
[**Staffavailremoveuserfromservice**](DefaultApi.md#Staffavailremoveuserfromservice) | **Get** /staffavailremoveuserfromservice | Remove a staff member from a service
[**Staffavailsetavailability**](DefaultApi.md#Staffavailsetavailability) | **Get** /staffavailsetavailability | Make a staff member available for a specific availability type
[**Staffavailsetmyavailability**](DefaultApi.md#Staffavailsetmyavailability) | **Get** /staffavailsetmyavailability | Change current user&#39;s availability type
[**Stationdelete**](DefaultApi.md#Stationdelete) | **Get** /stationdelete | Delete a sign-in station
[**Stationget**](DefaultApi.md#Stationget) | **Get** /stationget | View details of a sign-in station
[**Stationgetcurrentterms**](DefaultApi.md#Stationgetcurrentterms) | **Get** /stationgetcurrentterms | Get all the current terms
[**Stationgetinfo**](DefaultApi.md#Stationgetinfo) | **Get** /stationgetinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**Stationgetlicense**](DefaultApi.md#Stationgetlicense) | **Get** /stationgetlicense | Gets the current license information
[**Stationgetlocationsettings**](DefaultApi.md#Stationgetlocationsettings) | **Get** /stationgetlocationsettings | View the sign-in station settings of a specified location
[**Stationlist**](DefaultApi.md#Stationlist) | **Get** /stationlist | View a list of sign-in stations
[**Stationsave**](DefaultApi.md#Stationsave) | **Post** /stationsave | Create or edit a sign-in station
[**Stationsavemine**](DefaultApi.md#Stationsavemine) | **Post** /stationsavemine | Create or edit a class attendance sign-in station for myself
[**Stationunlock**](DefaultApi.md#Stationunlock) | **Get** /stationunlock | Unlocks the sign-in station.
[**Swipedelete**](DefaultApi.md#Swipedelete) | **Get** /swipedelete | Delete a swipe
[**Swipeget**](DefaultApi.md#Swipeget) | **Get** /swipeget | Search and view details of a swipe
[**Swipelist**](DefaultApi.md#Swipelist) | **Get** /swipelist | View a list of swipes
[**Swipesave**](DefaultApi.md#Swipesave) | **Post** /swipesave | Create or edit a swipe, and if possible, save the related attendance log
[**Swipesaveanonym**](DefaultApi.md#Swipesaveanonym) | **Post** /swipesaveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
[**Tagdelete**](DefaultApi.md#Tagdelete) | **Get** /tagdelete | Delete a tag
[**Tagget**](DefaultApi.md#Tagget) | **Get** /tagget | View details of a specified tag
[**Taglist**](DefaultApi.md#Taglist) | **Get** /taglist | View a list of tags
[**Taglistgroups**](DefaultApi.md#Taglistgroups) | **Get** /taglistgroups | View a list of entities that can be tagged
[**Tagsave**](DefaultApi.md#Tagsave) | **Post** /tagsave | Create or edit a tag
[**Tagsearch**](DefaultApi.md#Tagsearch) | **Get** /tagsearch | Search for tags in the account
[**Templateaddimage**](DefaultApi.md#Templateaddimage) | **Get** /templateaddimage | Add an image to a template
[**Templatedelete**](DefaultApi.md#Templatedelete) | **Get** /templatedelete | Delete a template
[**Templateemail**](DefaultApi.md#Templateemail) | **Get** /templateemail | Send generated templates by email
[**Templategenerate**](DefaultApi.md#Templategenerate) | **Get** /templategenerate | Generate specified templates
[**Templateget**](DefaultApi.md#Templateget) | **Get** /templateget | View details of a template
[**Templategetgenerated**](DefaultApi.md#Templategetgenerated) | **Get** /templategetgenerated | View generated templates
[**Templatelist**](DefaultApi.md#Templatelist) | **Get** /templatelist | View a list of defined templates
[**Templatelistsources**](DefaultApi.md#Templatelistsources) | **Get** /templatelistsources | View a list of templates&#39; data sources
[**Templatesave**](DefaultApi.md#Templatesave) | **Post** /templatesave | Create or edit a template
[**Templatesavelayout**](DefaultApi.md#Templatesavelayout) | **Post** /templatesavelayout | Save the layout of a template
[**Termdelete**](DefaultApi.md#Termdelete) | **Get** /termdelete | Delete a term
[**Termget**](DefaultApi.md#Termget) | **Get** /termget | Search and view details of a term
[**Termlist**](DefaultApi.md#Termlist) | **Get** /termlist | Search and view details of all terms
[**Termsave**](DefaultApi.md#Termsave) | **Post** /termsave | Create and edit terms
[**Textcreditremaining**](DefaultApi.md#Textcreditremaining) | **Get** /textcreditremaining | Gets the remaining text credits for the account
[**Texttoimage**](DefaultApi.md#Texttoimage) | **Get** /texttoimage | Generates a dynamic image from text
[**Translationget**](DefaultApi.md#Translationget) | **Get** /translationget | Gets the translations of the specified values
[**Translationgetcachefile**](DefaultApi.md#Translationgetcachefile) | **Get** /translationgetcachefile | Get the file containing the translations
[**Translationlist**](DefaultApi.md#Translationlist) | **Get** /translationlist | Lists all the available translations in the system
[**Translationsave**](DefaultApi.md#Translationsave) | **Post** /translationsave | Edit a translation
[**Userchangepwd**](DefaultApi.md#Userchangepwd) | **Get** /userchangepwd | Change user&#39;s own password
[**Userchangepwdbyreq**](DefaultApi.md#Userchangepwdbyreq) | **Get** /userchangepwdbyreq | Changes the user password using a change password request id
[**Userdelete**](DefaultApi.md#Userdelete) | **Get** /userdelete | Delete a user
[**Userfindsimilar**](DefaultApi.md#Userfindsimilar) | **Get** /userfindsimilar | Finds similar users to prevent duplicates
[**Userget**](DefaultApi.md#Userget) | **Get** /userget | Search and view details of a user
[**Usergetbycard**](DefaultApi.md#Usergetbycard) | **Get** /usergetbycard | Search user by card number
[**Usergroupaddmember**](DefaultApi.md#Usergroupaddmember) | **Get** /usergroupaddmember | Add a user to a group
[**Usergroupdelete**](DefaultApi.md#Usergroupdelete) | **Get** /usergroupdelete | Delete a group
[**Usergroupget**](DefaultApi.md#Usergroupget) | **Get** /usergroupget | Search and view details of a user group
[**Usergroupgetmembers**](DefaultApi.md#Usergroupgetmembers) | **Get** /usergroupgetmembers | View the members of a user group
[**Usergroupgetuser**](DefaultApi.md#Usergroupgetuser) | **Get** /usergroupgetuser | View the groups which a user is registered to
[**Usergrouplist**](DefaultApi.md#Usergrouplist) | **Get** /usergrouplist | View a list of user groups
[**Usergrouprefresh**](DefaultApi.md#Usergrouprefresh) | **Get** /usergrouprefresh | Refresh the dynamic group
[**Usergroupremovemember**](DefaultApi.md#Usergroupremovemember) | **Get** /usergroupremovemember | Remove a user from a group
[**Usergroupsave**](DefaultApi.md#Usergroupsave) | **Post** /usergroupsave | Create or edit a group
[**Usergrouptagmembers**](DefaultApi.md#Usergrouptagmembers) | **Get** /usergrouptagmembers | Assign tags to the members of a specified group
[**Usergroupuntagmembers**](DefaultApi.md#Usergroupuntagmembers) | **Get** /usergroupuntagmembers | Unassign tags from the members of a specified group
[**Userlist**](DefaultApi.md#Userlist) | **Get** /userlist | View a list of users
[**Userloadphoto**](DefaultApi.md#Userloadphoto) | **Get** /userloadphoto | Upload a photo for a specific user
[**Usermovedata**](DefaultApi.md#Usermovedata) | **Get** /usermovedata | Move data between users
[**Userprofiledelete**](DefaultApi.md#Userprofiledelete) | **Get** /userprofiledelete | Delete a user profile
[**Userprofileget**](DefaultApi.md#Userprofileget) | **Get** /userprofileget | View a specific user profile
[**Userprofilegetallview**](DefaultApi.md#Userprofilegetallview) | **Get** /userprofilegetallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
[**Userprofilelist**](DefaultApi.md#Userprofilelist) | **Get** /userprofilelist | View the list of user profiles
[**Userprofilelistquestions**](DefaultApi.md#Userprofilelistquestions) | **Get** /userprofilelistquestions | Gets the list of all the available user questions
[**Userprofilepreparestats**](DefaultApi.md#Userprofilepreparestats) | **Get** /userprofilepreparestats | Gets the statistics of a user group
[**Userprofilesave**](DefaultApi.md#Userprofilesave) | **Post** /userprofilesave | Create or edit user profile questions
[**Userprofilesaveanswers**](DefaultApi.md#Userprofilesaveanswers) | **Post** /userprofilesaveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
[**Userrequestpwdchange**](DefaultApi.md#Userrequestpwdchange) | **Get** /userrequestpwdchange | Requests a password change
[**Usersave**](DefaultApi.md#Usersave) | **Post** /usersave | Create or edit a user
[**Usersavepwdchange**](DefaultApi.md#Usersavepwdchange) | **Post** /usersavepwdchange | Send email to the specified user(s) to set/change their passwords
[**Usersettingsget**](DefaultApi.md#Usersettingsget) | **Get** /usersettingsget | Lists available user settings
[**Usersettingsgetmultiple**](DefaultApi.md#Usersettingsgetmultiple) | **Get** /usersettingsgetmultiple | Get multiple user settings
[**Usersettingssave**](DefaultApi.md#Usersettingssave) | **Post** /usersettingssave | Saves a user setting
[**Usersettingssavemultiple**](DefaultApi.md#Usersettingssavemultiple) | **Post** /usersettingssavemultiple | Save multiple user settings at once
[**Version**](DefaultApi.md#Version) | **Get** /version | Get current version information
[**Virtuallineaddmyself**](DefaultApi.md#Virtuallineaddmyself) | **Get** /virtuallineaddmyself | Add myself to a waiting line
[**Virtuallinelist**](DefaultApi.md#Virtuallinelist) | **Get** /virtuallinelist | Lists waiting lines that have remote access enabled
[**Virtuallineremovemyself**](DefaultApi.md#Virtuallineremovemyself) | **Get** /virtuallineremovemyself | Remove myself from a waiting line
[**Waitinglineadduser**](DefaultApi.md#Waitinglineadduser) | **Get** /waitinglineadduser | Put user in a waiting line
[**Waitinglinedelete**](DefaultApi.md#Waitinglinedelete) | **Get** /waitinglinedelete | Delete a waiting line
[**Waitinglineget**](DefaultApi.md#Waitinglineget) | **Get** /waitinglineget | View details of a waiting line
[**Waitinglineisuserin**](DefaultApi.md#Waitinglineisuserin) | **Get** /waitinglineisuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**Waitinglinelist**](DefaultApi.md#Waitinglinelist) | **Get** /waitinglinelist | View a list of waiting lines
[**Waitinglineremoveuser**](DefaultApi.md#Waitinglineremoveuser) | **Get** /waitinglineremoveuser | Remove a user from a waiting line
[**Waitinglinesave**](DefaultApi.md#Waitinglinesave) | **Post** /waitinglinesave | Create or edit a waiting line
[**Waitinglinesigninuser**](DefaultApi.md#Waitinglinesigninuser) | **Get** /waitinglinesigninuser | Sign a user in from a waiting line



## Actionassignmentdelete

> Actionassignmentdelete(ctx, token, id)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the action assignment to delete. | 

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


## Actionassignmentget

> Actionassignmentget(ctx, token, id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the action assignment to get. | 

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


## Actionassignmentlist

> Actionassignmentlist(ctx, token, from, count, optional)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***ActionassignmentlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **assignee** | **optional.Int32**| The assignee&#39;s id to filter the assignments. | 
 **status** | **optional.Int32**| The status to filter the assignments. | 

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


## Actionassignmentlisthistory

> Actionassignmentlisthistory(ctx, token, actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**actionassignment** | [**string**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

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


## Actionassignmentlistmine

> Actionassignmentlistmine(ctx, token, from, count, optional)

List public action assignments assigned to the logged user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***ActionassignmentlistmineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentlistmineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **status** | **optional.Int32**| The status to filter the assignments. | 

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


## Actionassignmentlistpublichistory

> Actionassignmentlistpublichistory(ctx, token, actionassignment)

List public action assignment history

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**actionassignment** | [**string**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

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


## Actionassignmentmarkcomplete

> Actionassignmentmarkcomplete(ctx, token, item, optional)

Bulk complete action items

Allows the user to bulk complete action items.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**item** | **string**| The action item to assign. | 
 **optional** | ***ActionassignmentmarkcompleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentmarkcompleteOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **assignee** | [**optional.Interface of string**](.md)| The assignee of the item. | 
 **group** | [**optional.Interface of string**](.md)| The group to assing the item. | 
 **notes** | **optional.String**| The assignment&#39;s notes. | 

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


## Actionassignmentsave

> Actionassignmentsave(ctx, optional)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ActionassignmentsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Actionassignmentsavehistory

> Actionassignmentsavehistory(ctx, optional)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ActionassignmentsavehistoryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionassignmentsavehistoryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Actionitemdelete

> Actionitemdelete(ctx, token, id)

Delete an action item

Allows the user to delete an action item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the action item to delete. | 

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


## Actionitemget

> Actionitemget(ctx, token, id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the action item to get. | 

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


## Actionitemlist

> Actionitemlist(ctx, token, from, count)

View a list of action items

Allows the user to view a list of action items

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Actionitemsave

> Actionitemsave(ctx, optional)

Create or edit an action item

Allows the user to edit an action item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ActionitemsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionitemsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Actionloglist

> Actionloglist(ctx, token, from, count, optional)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***ActionloglistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionloglistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **user** | [**optional.Interface of string**](.md)| The id of the user whose action logs have to be returned. | 
 **startdate** | **optional.Time**| The start date of the period to filter the logs. | 
 **enddate** | **optional.Time**| The end date of the period to filter the logs. | 
 **resource** | **optional.String**| The resource to filter the action logs. | 
 **actionfilter** | **optional.String**| The action to filter the action logs. | 
 **argument** | **optional.String**| The id of the entity that was the argument of the executed action. | 

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


## Actionpackassign

> Actionpackassign(ctx, token, pack, itemsdata, optional)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**pack** | [**string**](.md)| The id of the action pack to assign. | 
**itemsdata** | **bool**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **optional** | ***ActionpackassignOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionpackassignOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **assignee** | [**optional.Interface of string**](.md)| The assignee of the pack. | 
 **group** | [**optional.Interface of string**](.md)| The group to assign the pack. | 
 **notes** | **optional.String**| The assignment&#39;s notes. | 

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


## Actionpackdelete

> Actionpackdelete(ctx, token, id)

Delete an action item pack

Allows the user to delete an action item pack.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the action pack to delete. | 

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


## Actionpackget

> Actionpackget(ctx, token, id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the action pack to get. | 

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


## Actionpacklist

> Actionpacklist(ctx, token, from, count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Actionpacksave

> Actionpacksave(ctx, optional)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ActionpacksaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActionpacksaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Actiontypedelete

> Actiontypedelete(ctx, token, id)

Delete an action item type

Allows the user to delete an action item type.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the action type to delete. | 

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


## Actiontypeget

> Actiontypeget(ctx, token, id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the action type to get. | 

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


## Actiontypelist

> Actiontypelist(ctx, token, from, count)

View a list of action item types

Allows the user to view the full list of action item types.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Actiontypesave

> Actiontypesave(ctx, optional)

Create or edit an action item type

Allows the user to dit an action item type.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ActiontypesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ActiontypesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Adhocquerycheckexecution

> Adhocquerycheckexecution(ctx, token, id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the ad hoc query execution to be checked. | 

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


## Adhocquerydelete

> Adhocquerydelete(ctx, token, id)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the ad hoc query to delete. | 

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


## Adhocqueryexecute

> Adhocqueryexecute(ctx, token, optional)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***AdhocqueryexecuteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdhocqueryexecuteOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **id** | [**optional.Interface of string**](.md)| The id of the query to execute. | 
 **query** | **optional.String**| The query to execute. | 

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


## Adhocqueryget

> Adhocqueryget(ctx, token, id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the query to get. | 

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


## Adhocquerygetschema

> Adhocquerygetschema(ctx, token)

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Adhocquerylist

> Adhocquerylist(ctx, token, from, count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Adhocquerylistexecutions

> Adhocquerylistexecutions(ctx, token, from, count, optional)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AdhocquerylistexecutionsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdhocquerylistexecutionsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **query** | [**optional.Interface of string**](.md)| The first record to return. | 

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


## Adhocquerysave

> Adhocquerysave(ctx, optional)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AdhocquerysaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdhocquerysaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Adhocquerystopexecution

> Adhocquerystopexecution(ctx, token, id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the ad hoc query execution to be stopped. | 

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


## Adhocreportsreqaccess

> Adhocreportsreqaccess(ctx, token)

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Advancedstationcheckunknownuser

> Advancedstationcheckunknownuser(ctx, station, user, location)

Check whether the user is known by the system.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user. | 
**location** | [**string**](.md)| The id of the location the user picked. | 

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


## Advancedstationcheckuserrole

> Advancedstationcheckuserrole(ctx, station, user, location)

Check whether the user is a staff member, an attendee or both.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user. | 
**location** | [**string**](.md)| The id of the location the user picked. | 

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


## Advancedstationcreateuser

> Advancedstationcreateuser(ctx, station, user, location, firstname, lastname, email, optional)

Creates a user via a sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user to create. | 
**location** | [**string**](.md)| The id of the location the user picked. | 
**firstname** | **string**| The first name of the user to create. | 
**lastname** | **string**| The last name of the user to create. | 
**email** | **string**| The email of the user to create. | 
 **optional** | ***AdvancedstationcreateuserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationcreateuserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------






 **middlename** | **optional.String**| The middle name of the user to create. | 

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


## Advancedstationgetevents

> Advancedstationgetevents(ctx, station, location, user)

Gets the courses available for a specific location and a specific student.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**location** | [**string**](.md)| The id of the location the student picked. | 
**user** | **string**| The card of the user. | 

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


## Advancedstationgetinfo

> Advancedstationgetinfo(ctx, id, optional)

Gets the info to display in the sign-in station by it's ID.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to get. | 
 **optional** | ***AdvancedstationgetinfoOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationgetinfoOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **event** | [**optional.Interface of string**](.md)| The id of the event (or session), to override the scheduled one. | 

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


## Advancedstationgetlocations

> Advancedstationgetlocations(ctx, station, user)

Gets the locations available in a sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station whose locations have to be returned. | 
**user** | **string**| The card of the user. | 

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


## Advancedstationgetlogstaff

> Advancedstationgetlogstaff(ctx, station, attendancelog, optional)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**attendancelog** | [**string**](.md)| The id of the attendance log to filter the staff members. | 
 **optional** | ***AdvancedstationgetlogstaffOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationgetlogstaffOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Advancedstationgetroles

> Advancedstationgetroles(ctx, station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**signinrole** | **string**| Specifies how the user is signing-in. | 
**user** | **string**| The card of the user. | 
**location** | [**string**](.md)| The id of the location the user picked. | 

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


## Advancedstationgetservices

> Advancedstationgetservices(ctx, station, location, user)

Gets the services available for a specific location.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**location** | [**string**](.md)| The id of the location the student picked. | 
**user** | **string**| The card of the user. | 

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


## Advancedstationgetstaff

> Advancedstationgetstaff(ctx, station, locationid, user, optional)

Gets the staff/tutors available for a specific location, course and service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**locationid** | [**string**](.md)| The id of the location the student picked. | 
**user** | **string**| The card of the user. | 
 **optional** | ***AdvancedstationgetstaffOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationgetstaffOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **services** | **optional.String**| The list of services selected by the user, in JSON format. | 
 **eventid** | [**optional.Interface of string**](.md)| The ID of the event selected. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Advancedstationissignedin

> Advancedstationissignedin(ctx, station, time, user, optional)

Gets whether a user is signed-in or not.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**time** | **time.Time**| The date and time of the swipe. | 
**user** | **string**| The card of the user. | 
 **optional** | ***AdvancedstationissignedinOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvancedstationissignedinOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **location** | [**optional.Interface of string**](.md)| The id of the location the user picked. | 

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


## Advroleaddmissing

> Advroleaddmissing(ctx, token, roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**roles** | **string**| CSV list of the role ids to check | 
**permissions** | **string**| CSV list of the permissions to check | 

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


## Advrolecheckperm

> Advrolecheckperm(ctx, token, roles, permissions)

Checks the permissions are assigned for the given roles

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**roles** | **string**| CSV list of the role ids to check | 
**permissions** | **string**| CSV list of the permissions to check | 

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


## Advroledelete

> Advroledelete(ctx, token, id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the location to delete. | 

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


## Advroledeletemapping

> Advroledeletemapping(ctx, token, map_, roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**map_** | **string**| The map name to save the role. | 
**roleid** | [**string**](.md)| The id of the role. | 

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


## Advroleget

> Advroleget(ctx, token, id)

View details of a role

Allows the user to view a role and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the location to get. | 

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


## Advrolelist

> Advrolelist(ctx, token, optional)

Lists the roles for the current account

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***AdvrolelistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvrolelistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **includepolicies** | **optional.Bool**| True to include the policies, defaults to false. | 
 **includeinternal** | **optional.Bool**| True to include the internal roles too. | 
 **name** | **optional.String**| Filter by name of the role. | 

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


## Advrolelistmaps

> Advrolelistmaps(ctx, token, roleid)

Lists the maps a roles is mapped to

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**roleid** | [**string**](.md)| The id of the role to list the maps. | 

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


## Advrolelistrolesmapped

> Advrolelistrolesmapped(ctx, token, optional)

Lists the roles mappings

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***AdvrolelistrolesmappedOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvrolelistrolesmappedOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **map_** | **optional.String**| List only the roles in the specified map. | 

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


## Advrolelisttemplates

> Advrolelisttemplates(ctx, token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Advrolesave

> Advrolesave(ctx, optional)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AdvrolesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvrolesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Advrolesavemapping

> Advrolesavemapping(ctx, optional)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AdvrolesavemappingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvrolesavemappingOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Advrolesuserlist

> Advrolesuserlist(ctx, token, from, count, optional)

List users. Alias to user.list, use that one instead.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AdvrolesuserlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AdvrolesuserlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **roleid** | [**optional.Interface of string**](.md)| The id of the role to filter users by, or empty to return all users. | 
 **onlywithoutcard** | **optional.String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Advroleuserupgrade

> Advroleuserupgrade(ctx, token, userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| Id of the user to upgrade | 
**roleid** | [**string**](.md)| Id of the role to add | 

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


## Appointmentcancel

> Appointmentcancel(ctx, token, id)

Cancel an appointment

Allows the user to cancel an appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to cancel. | 

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


## Appointmentcheckisvalid

> Appointmentcheckisvalid(ctx, token, id, optional)

Check if an appointment is valid or not

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to check. | 
 **optional** | ***AppointmentcheckisvalidOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentcheckisvalidOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **editing** | **optional.Bool**| Specifies whether the check is for a new appointment or an existing one. | 

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


## Appointmenteditanyway

> Appointmenteditanyway(ctx, token, id, attendee, staff, location, start, end, optional)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to edit. | 
**attendee** | [**string**](.md)| The id of the attendee involved in the appointment. | 
**staff** | [**string**](.md)| The id of the staff member involved in the appointment. | 
**location** | [**string**](.md)| The id of the location where the appointment will take place. | 
**start** | **time.Time**| The appointment&#39;s start date &amp; time. | 
**end** | **time.Time**| The appointment&#39;s end date &amp; time. | 
 **optional** | ***AppointmenteditanywayOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmenteditanywayOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------







 **term** | [**optional.Interface of string**](.md)| The id of the term when the appointment takes place. | 
 **event** | [**optional.Interface of string**](.md)| The id of the event of the appointment. | 
 **services** | **optional.String**| Comma-separated string containing the ids of the services of the appointment. | 
 **notes** | **optional.String**| The notes of the appointment. | 

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


## Appointmenteditpresence

> Appointmenteditpresence(ctx, token, id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to edit its presence. | 
**showedup** | **bool**| Specifies whether the attendee was showed-up or not in the appointment. | 

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


## Appointmentfindallstaffslots

> Appointmentfindallstaffslots(ctx, token, starttime, endtime, serviceids, locationid, optional)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
**serviceids** | **string**| CSV list of the service Ids to filter by. | 
**locationid** | [**string**](.md)| The id of the service to filter by. | 
 **optional** | ***AppointmentfindallstaffslotsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentfindallstaffslotsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------





 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Appointmentfindslots

> Appointmentfindslots(ctx, token, staffid, starttime, endtime, serviceids, optional)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**staffid** | [**string**](.md)| The id of the staff to filter by. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
**serviceids** | **string**| CSV list of the service Ids to filter by. | 
 **optional** | ***AppointmentfindslotsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentfindslotsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------





 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the service to filter by. | 

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


## Appointmentfindstaff

> Appointmentfindstaff(ctx, token, serviceids, starttime, endtime, optional)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceids** | **string**| CSV list of the service ids to filter by. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
 **optional** | ***AppointmentfindstaffOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentfindstaffOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the service to filter by. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Appointmentget

> Appointmentget(ctx, token, id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to get. | 

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


## Appointmentgetcurrent

> Appointmentgetcurrent(ctx, station, user, location)

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


## Appointmentgetlocations

> Appointmentgetlocations(ctx, token, serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceid** | [**string**](.md)| The id of the service to get its locations. | 

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


## Appointmentlist

> Appointmentlist(ctx, token, from, count, optional)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AppointmentlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **startdate** | **optional.Time**| The start date of the period to filter the appointments. | 
 **enddate** | **optional.Time**| The end date of the period to filter the appointments. | 
 **userid** | [**optional.Interface of string**](.md)| The attendee id to filter the appointments. | 

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


## Appointmentlistmine

> Appointmentlistmine(ctx, token, optional)

View all my upcoming appointments

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***AppointmentlistmineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentlistmineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **start** | **optional.Time**| If specified, only appointments that start after the specified date will be returned. | 
 **modifiedafter** | **optional.Time**| If specified, only appointments modified after the specified date will be returned. | 

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


## Appointmentlistupcoming

> Appointmentlistupcoming(ctx, token, optional)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***AppointmentlistupcomingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentlistupcomingOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **start** | **optional.Time**| If specified, only appointments that start after the specified date will be returned. | 
 **modifiedafter** | **optional.Time**| If specified, only appointments modified after the specified date will be returned. | 

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


## Appointmentrescheduleoutlook

> Appointmentrescheduleoutlook(ctx, token, id, start, end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to edit. | 
**start** | **time.Time**| The appointment&#39;s start date &amp; time. | 
**end** | **time.Time**| The appointment&#39;s end date &amp; time. | 

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


## Appointmentrestore

> Appointmentrestore(ctx, token, id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to restore. | 

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


## Appointmentrestoreanyway

> Appointmentrestoreanyway(ctx, token, id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to restore. | 

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


## Appointmentsave

> Appointmentsave(ctx, optional)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AppointmentsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppointmentsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Appointmentsetasvalid

> Appointmentsetasvalid(ctx, token, id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to set as valid. | 

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


## Appointmentsuggestlocations

> Appointmentsuggestlocations(ctx, token)

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Appointmentsuggestservices

> Appointmentsuggestservices(ctx, token)

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Appointmentvoid

> Appointmentvoid(ctx, token, id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the appointment to cancel. | 

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


## Appsharegetphone

> Appsharegetphone(ctx, token)

Gets the phone number of the current user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Appsharesendtext

> Appsharesendtext(ctx, token, optional)

Sends an SMS with the link to the app

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***AppsharesendtextOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AppsharesendtextOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **phonenumber** | **optional.String**| Phone number to where to send the link. Leave empty to the number on file. | 

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


## Attendancelogcommentdelete

> Attendancelogcommentdelete(ctx, token, id)

Delete a comment on an attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the attendance log comment to delete. | 

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


## Attendancelogcommentget

> Attendancelogcommentget(ctx, token, id)

View a comment on an attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the comment to get. | 

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


## Attendancelogcommentlist

> Attendancelogcommentlist(ctx, attendancelog, optional)

View all the comments on a specific attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**attendancelog** | [**string**](.md)| The id of the attendance log whose comments have to be retrieved. | 
 **optional** | ***AttendancelogcommentlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogcommentlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **token** | **optional.String**| The authentication token. | 

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


## Attendancelogcommentsave

> Attendancelogcommentsave(ctx, optional)

Save a comment on an attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AttendancelogcommentsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogcommentsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Attendancelogdelete

> Attendancelogdelete(ctx, token, id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the attendance log to delete. | 

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


## Attendancelogget

> Attendancelogget(ctx, token, id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the attendance log to get. | 

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


## Attendanceloggetchangehistory

> Attendanceloggetchangehistory(ctx, token, id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the attendance log to get. | 

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


## Attendanceloglist

> Attendanceloglist(ctx, from, count, optional)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AttendanceloglistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendanceloglistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **token** | **optional.String**| The authentication token. | 
 **filter** | **optional.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | 
 **userid** | [**optional.Interface of string**](.md)| The user ID of the user to get the logs. | 

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


## Attendanceloglistmine

> Attendanceloglistmine(ctx, from, count, optional)

Gets the attendance logs of the current user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AttendanceloglistmineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendanceloglistmineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **token** | **optional.String**| The authentication token. | 
 **filter** | **optional.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | 

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


## Attendancelogliststaff

> Attendancelogliststaff(ctx, from, count, optional)

Gets the attendance logs that the current user is involved in as staff

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AttendancelogliststaffOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogliststaffOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **token** | **optional.String**| The authentication token. | 
 **filter** | **optional.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | 

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


## Attendancelogsave

> Attendancelogsave(ctx, optional)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AttendancelogsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Attendancelogsignout

> Attendancelogsignout(ctx, token, optional)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***AttendancelogsignoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogsignoutOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **id** | [**optional.Interface of string**](.md)| The id of the attendance log to sign-out. | 
 **location** | [**optional.Interface of string**](.md)| The id of the location to filter the users to sign out. | 
 **event** | [**optional.Interface of string**](.md)| The id of the event to filter the users to sign out. | 
 **datetime** | **optional.Time**| Specifies the date and time when the specified logs have to be signed out. | 

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


## Attendancelogwhosin

> Attendancelogwhosin(ctx, from, count, optional)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***AttendancelogwhosinOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancelogwhosinOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **token** | **optional.String**| The authentication token. | 
 **location** | [**optional.Interface of string**](.md)| The id of the location to search for users that are in. | 
 **event** | [**optional.Interface of string**](.md)| The id of the event to search for users that are in. | 
 **sorting** | **optional.String**| Field to sort by. Either first-name, last-name or sign-in-time. | 
 **roles** | **optional.String**| The comma-separated list of ids of the roles to search for users that are in. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 
 **extensions** | **optional.String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | 
 **export** | **optional.Bool**| True to export the results as CSV | 

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


## Attendancerestrictiondelete

> Attendancerestrictiondelete(ctx, token, id)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the restriction to delete. | 

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


## Attendancerestrictionget

> Attendancerestrictionget(ctx, token, id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the restriction to get. | 

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


## Attendancerestrictionlist

> Attendancerestrictionlist(ctx, token, from, count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Attendancerestrictionsave

> Attendancerestrictionsave(ctx, optional)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***AttendancerestrictionsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a AttendancerestrictionsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Beacondelete

> Beacondelete(ctx, token, id)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the beacon to delete. | 

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


## Beacondisable

> Beacondisable(ctx, token)

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Beaconget

> Beaconget(ctx, token, id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the beacon to get. | 

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


## Beacongetlocations

> Beacongetlocations(ctx, token, beacons)

Get the sign-in stations assigned to specific beacons.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

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


## Beacongetstationlocation

> Beacongetstationlocation(ctx, token, station, location)

Get the location settings in the specified sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**station** | [**string**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
**location** | [**string**](.md)| The id of the location whose information has to be retrieved. | 

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


## Beacongetuuid

> Beacongetuuid(ctx, token)

View the identifier for the account's beacon region (for sign-in stations).

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Beaconlist

> Beaconlist(ctx, token, from, count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Beaconlistprofiles

> Beaconlistprofiles(ctx, token)

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Beaconresetuuid

> Beaconresetuuid(ctx, token)

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Beaconsave

> Beaconsave(ctx, optional)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***BeaconsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a BeaconsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Beaconscanlocations

> Beaconscanlocations(ctx, token, beacons)

Check if there's location available to sign-in / out.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

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


## Beaconsetuuid

> Beaconsetuuid(ctx, token, id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The custom region UUID. | 

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


## Beaconsilentregions

> Beaconsilentregions(ctx, token)

View all the beacon regions defined for silent tracking

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Beaconsilentsignin

> Beaconsilentsignin(ctx, token, uuid)

Sign-in silently from the location specified by a beacon

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**uuid** | [**string**](.md)| The id of the region the user is in. | 

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


## Beaconsilentsignout

> Beaconsilentsignout(ctx, token, uuid)

Sign-out silently from the location specified by a beacon

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**uuid** | [**string**](.md)| The id of the region the user has left. | 

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


## Bgjobgetstatus

> Bgjobgetstatus(ctx, token, optional)

Get background job status

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***BgjobgetstatusOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a BgjobgetstatusOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **jobid** | [**optional.Interface of string**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | 
 **jobtype** | **optional.String**| The job type to filter by. | 

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


## CallImport

> CallImport(ctx, token, importtype, upload, optional)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**importtype** | **string**| The kind of data that is being uploaded. | 
**upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **optional** | ***CallImportOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CallImportOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **filename** | **optional.String**| The local name of the uploaded file. For later reference. | 
 **parameters** | **optional.String**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | 

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


## Captchagetchallenge

> Captchagetchallenge(ctx, )

Gets a captcha challenge that the user must complete to do certain requests.

### Required Parameters

This endpoint does not need any parameter.

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


## Captchagetimage

> Captchagetimage(ctx, captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**captchatoken** | **string**| The captcha token or ID returned by the captcha.getchallenge action | 

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


## Changelog

> Changelog(ctx, token)

Get the application change log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Clientget

> Clientget(ctx, token, client, optional)

Get client

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**client** | **string**| The unique id of the client. | 
 **optional** | ***ClientgetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ClientgetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **clientname** | **optional.String**| The custom name of the client. | 

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


## Clientlist

> Clientlist(ctx, token, from, count)

Gets the clients of the specified conference

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Clientsave

> Clientsave(ctx, optional)

Saves a client

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ClientsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ClientsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Clientsendmessage

> Clientsendmessage(ctx, token, uniqueclientid, message)

Send a message to a client

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**uniqueclientid** | [**string**](.md)| The unique id of the client. | 
**message** | **string**| The body of the message to send. | 

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


## Communityinvite

> Communityinvite(ctx, token)

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Communityjoin

> Communityjoin(ctx, token)

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Compasscategorydelete

> Compasscategorydelete(ctx, token, id)

Delete a compass category

Allows the user to delete an existing compass category.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the category to delete. | 

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


## Compasscategoryget

> Compasscategoryget(ctx, token, id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the category to get. | 

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


## Compasscategorylist

> Compasscategorylist(ctx, token, optional)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***CompasscategorylistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CompasscategorylistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **from** | **optional.Int32**| The first record to return. | 
 **count** | **optional.Int32**| The max number of records to return. | 
 **onlywithservices** | **optional.Bool**| Specified whether only categories with services are returned or all. | 

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


## Compasscategorysave

> Compasscategorysave(ctx, optional)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***CompasscategorysaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CompasscategorysaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Compassservicelist

> Compassservicelist(ctx, token, optional)

View all the services added to the compass

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***CompassservicelistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a CompassservicelistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **category** | [**optional.Interface of string**](.md)| The id of the category to filter the services. | 

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


## Compassservicelistlocations

> Compassservicelistlocations(ctx, token, serviceid)

View all the locations where a service added to the compass is available

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceid** | [**string**](.md)| The id of the service to get its locations. | 

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


## Computerlabdeletecomputer

> Computerlabdeletecomputer(ctx, token, id)

Delete a computer

Allows the user to delete an existing computer.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | **string**| The unique device id of the computer to delete. | 

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


## Computerlabgetcomputer

> Computerlabgetcomputer(ctx, token, id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | **string**| The unique device id of the computer to get. | 

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


## Computerlabgetsettings

> Computerlabgetsettings(ctx, id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the computer lab/location. | 

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


## Computerlabissignedin

> Computerlabissignedin(ctx, station, user)

Gets whether a user is signed-in or not.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user. | 

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


## Computerlablistcomputers

> Computerlablistcomputers(ctx, token, from, count, optional)

View a list of computers

Allows the user to view the list of all computers.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***ComputerlablistcomputersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlablistcomputersOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **location** | [**optional.Interface of string**](.md)| The id of the location whose computers have to be returned. | 
 **freeonly** | **optional.Bool**| If true, only free computers will be returned. | 

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


## Computerlablistlabs

> Computerlablistlabs(ctx, token)

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Computerlabliststations

> Computerlabliststations(ctx, token)

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Computerlabsavecomputer

> Computerlabsavecomputer(ctx, optional)

Create or edit a computer

Allows the user to create or edit a computer.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ComputerlabsavecomputerOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlabsavecomputerOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Computerlabsavesettings

> Computerlabsavesettings(ctx, optional)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ComputerlabsavesettingsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlabsavesettingsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Computerlabsaveswipe

> Computerlabsaveswipe(ctx, optional)

Save a new swipe from a computer in a computer lab.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ComputerlabsaveswipeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ComputerlabsaveswipeOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Deadendrecordingdelete

> Deadendrecordingdelete(ctx, token, hierarchykey)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**hierarchykey** | **string**| The hierarchy key of the record to delete. | 

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


## Deadendrecordinglist

> Deadendrecordinglist(ctx, token)

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Deadendrecordinglistcomments

> Deadendrecordinglistcomments(ctx, token, hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**hierarchykey** | **string**| The hierarchy key of the record to get the feedback. | 

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


## Deadendrecordingsave

> Deadendrecordingsave(ctx, optional)

Saves a dead-end record

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***DeadendrecordingsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a DeadendrecordingsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Departmentdelete

> Departmentdelete(ctx, token, id)

Delete a college department

Allows the user to delete an existing college department.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the department to delete. | 

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


## Departmentget

> Departmentget(ctx, token, id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the department to get. | 

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


## Departmentlist

> Departmentlist(ctx, token, from, count)

View a list of college departments

Allows the user to view the full list of college departments.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Departmentsave

> Departmentsave(ctx, optional)

Create or edit a college department

Allows the user to create or edit a college department.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***DepartmentsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a DepartmentsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Doc

> Doc(ctx, optional)

Get the documentation

Retrieves the list of actions available in the system.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***DocOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a DocOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **optional.Bool**| If true it excludes the anonymous actions from the returned list. | 

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


## Easyloginaddbgimage

> Easyloginaddbgimage(ctx, token, upload, filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
**filename** | **string**| The original filename, needed to process the file. | 

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


## Eventchecksessions

> Eventchecksessions(ctx, token, eventid, autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The id of the event to check. | 
**autorepair** | **bool**| True to automatically fix the invalid sessions. | 

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


## Eventdelete

> Eventdelete(ctx, token, id)

Delete a course

Allows the user to delete an existing course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the event to delete. | 

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


## Eventget

> Eventget(ctx, token, id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the event to get. | 

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


## Eventgetsessionsbydate

> Eventgetsessionsbydate(ctx, token, optional)

View a list of courses by date

Allows the user to view a list of courses by date.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***EventgetsessionsbydateOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventgetsessionsbydateOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **location** | [**optional.Interface of string**](.md)| The location to filter the events. | 
 **date** | **optional.Time**| The date to filter the events. Today will be used if this parameter is omitted. | 
 **type_** | **optional.String**| Type of event to list. | 

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


## Eventlist

> Eventlist(ctx, token, from, count, optional)

View a list of courses

Allows the user to view the full list of courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **string**| The first record to return. | 
**count** | **string**| The max number of records to return. | 
 **optional** | ***EventlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **summaryonly** | **optional.Bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | 
 **termid** | [**optional.Interface of string**](.md)| Id of the term to list the events. Null to list all events. | 

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


## Eventlistregistered

> Eventlistregistered(ctx, token, from, count, optional)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **string**| The first record to return. | 
**count** | **string**| The max number of records to return. | 
 **optional** | ***EventlistregisteredOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventlistregisteredOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **summaryonly** | **optional.Bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | 
 **termid** | [**optional.Interface of string**](.md)| Id of the term to list the events. Null to list all events. | 

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


## Eventregaddme

> Eventregaddme(ctx, token, eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The id of the event. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## Eventregaddmetoall

> Eventregaddmetoall(ctx, token, listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## Eventregaddmetogroup

> Eventregaddmetogroup(ctx, token, codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**codegroup** | **string**| The code used to group events. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## Eventregadduser

> Eventregadduser(ctx, token, userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to add. | 
**eventid** | [**string**](.md)| The id of the event. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## Eventregaddusertoall

> Eventregaddusertoall(ctx, token, userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to add. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## Eventregaddusertogroup

> Eventregaddusertogroup(ctx, token, userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to add. | 
**codegroup** | **string**| The code used to group events. | 
**listname** | **string**| The name of the list where the user has to be registered. | 

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


## Eventreggetevents

> Eventreggetevents(ctx, token, userid, listname, optional)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The user id to list events. | 
**listname** | **string**| The name of the list where the user is registered. | 
 **optional** | ***EventreggeteventsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventreggeteventsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **termid** | [**optional.Interface of string**](.md)| The term id to list events. | 
 **namefilter** | **optional.String**| The value used to filter the events by name. | 

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


## Eventreggetgroups

> Eventreggetgroups(ctx, token, userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The user id to list events. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## Eventreggetmyevents

> Eventreggetmyevents(ctx, token, listname, optional)

View the event registrations of the current user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**listname** | **string**| The name of the list where the user is registered. | 
 **optional** | ***EventreggetmyeventsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventreggetmyeventsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **termid** | [**optional.Interface of string**](.md)| The term id to list events. | 
 **namefilter** | **optional.String**| The value used to filter the events by name. | 

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


## Eventreggetmygroups

> Eventreggetmygroups(ctx, token, listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## Eventreggetusers

> Eventreggetusers(ctx, token, eventid, listname, optional)

View course registration

Allows the user to view all users registered for an individual course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The event id to list users. | 
**listname** | **string**| The name of the list to get. | 
 **optional** | ***EventreggetusersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventreggetusersOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Eventreggetusersfromgroup

> Eventreggetusersfromgroup(ctx, token, codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**codegroup** | [**string**](.md)| The code group to list users. | 
**listname** | **string**| The name of the list to get. | 

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


## Eventreggetuserstoall

> Eventreggetuserstoall(ctx, token, listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**listname** | **string**| The name of the list to get. | 

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


## Eventregremoveme

> Eventregremoveme(ctx, token, eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The id of the event. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## Eventregremovemefromall

> Eventregremovemefromall(ctx, token, listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## Eventregremovemefromgroup

> Eventregremovemefromgroup(ctx, token, codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**codegroup** | [**string**](.md)| The code group of the events/courses. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## Eventregremoveuser

> Eventregremoveuser(ctx, token, userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to remove. | 
**eventid** | [**string**](.md)| The id of the event. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## Eventregremoveuserfromall

> Eventregremoveuserfromall(ctx, token, userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to remove. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## Eventregremoveuserfromgroup

> Eventregremoveuserfromgroup(ctx, token, userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to remove. | 
**codegroup** | [**string**](.md)| The code group of the events/courses. | 
**listname** | **string**| The name of the list where the user is registered. | 

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


## Eventsave

> Eventsave(ctx, optional)

Create or edit a course

Allows the user to create or edit a course.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***EventsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a EventsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Eventsearchgroup

> Eventsearchgroup(ctx, token, query)

Searches for the available event groups

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**query** | [**string**](.md)| Query to search event groups. | 

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


## Export

> Export(ctx, token, exporttype, exportformat, optional)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**exporttype** | **string**| What to export. | 
**exportformat** | **string**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **optional** | ***ExportOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ExportOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **filters** | **optional.String**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | 

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


## Exportlisttypes

> Exportlisttypes(ctx, token)

Lists available export types

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Featurelist

> Featurelist(ctx, token)

Lists the available features.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Holidaylist

> Holidaylist(ctx, token, term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**term** | [**string**](.md)| The term to get holidays from. | 

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


## Holidaysave

> Holidaysave(ctx, optional)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***HolidaysaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a HolidaysaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Holidaysuggest

> Holidaysuggest(ctx, token, term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**term** | [**string**](.md)| The term to get holidays from. | 

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


## Importlisttypes

> Importlisttypes(ctx, token)

Lists available import types

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Interactiondelete

> Interactiondelete(ctx, token, id)

Delete an interaction

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the interaction to delete. | 

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


## Interactionfeed

> Interactionfeed(ctx, token, from, count, optional)

Get the interactions feed

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***InteractionfeedOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractionfeedOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **startdate** | **optional.Time**| If set, only interactions that happened after this date are returned. | 
 **public** | **optional.Bool**| Specifies whether to return public or private interactions. | 
 **contexttype** | **optional.String**| The type of the context of the interactions to return. | 
 **contextid** | [**optional.Interface of string**](.md)| The id of the context of the interactions to return. | 
 **types** | **optional.String**| The  comma separated types of the interactions to return. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 
 **showdefaultphoto** | **optional.Bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | 
 **orderdescending** | **optional.Bool**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | 

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


## Interactionget

> Interactionget(ctx, token, id, optional)

View an interaction

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | **string**| The id of the interaction. | 
 **optional** | ***InteractiongetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractiongetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **thumbnailmediasize** | **optional.Int32**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Interactionlistprivatesummary

> Interactionlistprivatesummary(ctx, token, optional)

Get current user's latest private interactions

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***InteractionlistprivatesummaryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractionlistprivatesummaryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 
 **showdefaultphoto** | **optional.Bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | 

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


## Interactionsave

> Interactionsave(ctx, optional)

Save an interaction

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***InteractionsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a InteractionsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Licenseacceptagreement

> Licenseacceptagreement(ctx, token)

Accept the license agreement

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Licensegetagreementstatus

> Licensegetagreementstatus(ctx, token)

Check if license agreement has been accepted

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Licensegetcurrent

> Licensegetcurrent(ctx, optional)

Gets the current license information

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***LicensegetcurrentOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LicensegetcurrentOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **optional.String**| The authentication token. | 

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


## Licenserenew

> Licenserenew(ctx, token, email, phonenumber, optional)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**email** | **string**| The e-mail of the user sending the request. | 
**phonenumber** | **string**| The phone number of the user sending the request. | 
 **optional** | ***LicenserenewOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LicenserenewOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **jobtitle** | **optional.String**| The job title of the user sending the request. | 
 **institution** | **optional.String**| The institution of the user sending the request. | 
 **comments** | **optional.String**| Comments entered by the user sending the request. | 

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


## Likedelete

> Likedelete(ctx, token, interactionid)

Delete a like

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**interactionid** | [**string**](.md)| The id of the interaction to unlike. | 

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


## Likelist

> Likelist(ctx, token, interactionid, optional)

View all the likes associated to a target

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**interactionid** | [**string**](.md)| The id of the interaction to unlike. | 
 **optional** | ***LikelistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LikelistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Likesave

> Likesave(ctx, optional)

Save a like

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***LikesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LikesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Listtimezones

> Listtimezones(ctx, )

Lists the available timezones

### Required Parameters

This endpoint does not need any parameter.

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


## Locationdelete

> Locationdelete(ctx, token, id)

Delete a location

Allows the user to delete an existing location.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the location to delete. | 

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


## Locationget

> Locationget(ctx, token, id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the location to get. | 

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


## Locationlist

> Locationlist(ctx, token, from, count, optional)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***LocationlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LocationlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **locations** | **optional.String**| The comma-separated list containing the ids of the locations to list. | 
 **sortbygroup** | **optional.Bool**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | 

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


## Locationsave

> Locationsave(ctx, optional)

Create or edit a location

Allows the user to create or edit a location.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***LocationsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LocationsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Login

> Login(ctx, domain, username, password, method, optional)

Login

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**domain** | **string**| The account domain to login. | 
**username** | **string**| The username (email) of the user to login as. | 
**password** | **string**| The password of the user to login as. | 
**method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **optional** | ***LoginOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LoginOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **rememberme** | **optional.Bool**| If true then the session will not expire. | 

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


## Logout

> Logout(ctx, optional)

Logout

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***LogoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a LogoutOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **optional.String**| The authentication token used to login. | 

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


## Mediacheckin

> Mediacheckin(ctx, token, media, checkindate, optional)

Check in media item

Allows the user to check in a media item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**media** | [**string**](.md)| The id of the media item to checkin. | 
**checkindate** | **time.Time**| The checkout date. | 
 **optional** | ***MediacheckinOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediacheckinOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **notes** | **optional.String**| The notes of the checkout. | 

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


## Mediacheckout

> Mediacheckout(ctx, token, media, user, checkoutdate, duedate, optional)

Check out media item

Allows the user to check out a media item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**media** | [**string**](.md)| The id of the media item to checkout. | 
**user** | [**string**](.md)| The id of the user that is checking the item out. | 
**checkoutdate** | **time.Time**| The checkout date. | 
**duedate** | **time.Time**| The date when the checkout is due. | 
 **optional** | ***MediacheckoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediacheckoutOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------





 **staff** | [**optional.Interface of string**](.md)| The id of the staff member related to the checkout. | 
 **event** | [**optional.Interface of string**](.md)| The id of the event related to the checkout. | 
 **notes** | **optional.String**| The notes of the checkout. | 

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


## Mediacheckoutlist

> Mediacheckoutlist(ctx, token, from, count, optional)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***MediacheckoutlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediacheckoutlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **media** | [**optional.Interface of string**](.md)| Used to filter the checkouts of a specific media item. | 
 **user** | [**optional.Interface of string**](.md)| Used to filter the checkouts made by a specific user. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Mediadelete

> Mediadelete(ctx, token, id)

Delete a media item

Allows the user to delete an existing media item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the media item to delete. | 

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


## Mediadeletecheckoutlog

> Mediadeletecheckoutlog(ctx, token, id)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the checkout log to delete. | 

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


## Mediaget

> Mediaget(ctx, token, id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the media item to get. | 

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


## Mediagetbycode

> Mediagetbycode(ctx, token, code, optional)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**code** | **string**| The code of the media item to get. | 
 **optional** | ***MediagetbycodeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediagetbycodeOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **location** | [**optional.Interface of string**](.md)| The location where to look for the media item. | 

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


## Mediagetcheckout

> Mediagetcheckout(ctx, token, id, optional)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **optional** | ***MediagetcheckoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediagetcheckoutOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Mediagetcheckoutlog

> Mediagetcheckoutlog(ctx, token, id, optional)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **optional** | ***MediagetcheckoutlogOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediagetcheckoutlogOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Medialist

> Medialist(ctx, token, from, count, optional)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***MedialistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MedialistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **status** | **optional.Int32**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | 
 **user** | [**optional.Interface of string**](.md)| Used to filter the media items that are checked-out by a specific user. | 

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


## Mediasave

> Mediasave(ctx, optional)

Create or edit a media item

Allows the user to create or edit a media item.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***MediasaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediasaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Mediatypedelete

> Mediatypedelete(ctx, token, id)

Delete a media type

Allows the user to delete an existing media type.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the media type to delete. | 

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


## Mediatypeget

> Mediatypeget(ctx, token, id)

Search and view details of a media type

Allows the user to view a media type and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the media type to get. | 

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


## Mediatypelist

> Mediatypelist(ctx, token, from, count)

View a list of media types

Allows the user to view the list of all media types.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Mediatypesave

> Mediatypesave(ctx, optional)

Create or edit a media type

Allows the user to create or edit a media type.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***MediatypesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MediatypesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Memorizedreportdelete

> Memorizedreportdelete(ctx, token, id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the report settings to delete. | 

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


## Memorizedreportget

> Memorizedreportget(ctx, token, id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the report configuration to get. | 

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


## Memorizedreportlist

> Memorizedreportlist(ctx, token, from, count, optional)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***MemorizedreportlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MemorizedreportlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **customname** | **optional.String**| If specified filters the memorized reports by custom name. | 

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


## Memorizedreportsave

> Memorizedreportsave(ctx, optional)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***MemorizedreportsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MemorizedreportsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Menugetitems

> Menugetitems(ctx, menuid)

Gets the items on the menu

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**menuid** | **string**| The Id of the menu to get. | 

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


## Myaccount

> Myaccount(ctx, token)

Gets the logged in user account.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Myianatimezone

> Myianatimezone(ctx, token)

Gets the current time zone's iana name

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Myprofile

> Myprofile(ctx, token, optional)

Gets the logged in user information.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***MyprofileOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MyprofileOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Myrights

> Myrights(ctx, token)

Gets the list of actions the user can execute.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Mysaveprofile

> Mysaveprofile(ctx, optional)

Updates logged user's profile information

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***MysaveprofileOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a MysaveprofileOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Notificationdelete

> Notificationdelete(ctx, token, id)

Delete a notification

Allows the user to delete an existing notification.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the notification to delete. | 

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


## Notificationget

> Notificationget(ctx, token, id)

View a notification

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the notification to get. | 

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


## Notificationgetforstation

> Notificationgetforstation(ctx, station, user)

Gets all public (in station) notifications for the specific user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station to get. | 
**user** | **string**| The card of the user. | 

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


## Notificationgetunreadcount

> Notificationgetunreadcount(ctx, token)

Get the number of unread notifications

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Notificationlist

> Notificationlist(ctx, token, from, count, optional)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***NotificationlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **recipient** | [**optional.Interface of string**](.md)| The recipient whose notifications have to be listed. | 
 **status** | **optional.Int32**| The status of the notifications to list. Read, Unread or All. | 
 **startdate** | **optional.Time**| The start date of the period to filter the notifications. | 
 **enddate** | **optional.Time**| The end date of the period to filter the notifications. | 
 **sentonscreen** | **optional.Bool**| Specifies whether to list the notifications that were sent on-screen or not. | 
 **sentemail** | **optional.Bool**| Specifies whether to list the notifications that were sent via e-mail or not. | 
 **sentsms** | **optional.Bool**| Specifies whether to list the notifications that were sent via sms or not. | 

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


## Notificationlistmine

> Notificationlistmine(ctx, token, from, count, optional)

View all the notifications sent to the current user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***NotificationlistmineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationlistmineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **status** | **optional.Int32**| Specifies the status of the notifications to list. Read, Unread or All. | 
 **startdate** | **optional.Time**| The start date of the period to filter the notifications. | 
 **enddate** | **optional.Time**| The end date of the period to filter the notifications. | 

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


## Notificationmarkasread

> Notificationmarkasread(ctx, token, optional)

Mark a notification as read

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***NotificationmarkasreadOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationmarkasreadOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **id** | [**optional.Interface of string**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | 
 **status** | **optional.Int32**| Specifies the status to filter the notifications. Read, Unread or All. | 
 **startdate** | **optional.Time**| The start date of the period to filter the notifications. | 
 **enddate** | **optional.Time**| The end date of the period to filter the notifications. | 

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


## Notificationmarkasunread

> Notificationmarkasunread(ctx, token, optional)

Mark a notification as unread

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***NotificationmarkasunreadOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationmarkasunreadOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **id** | [**optional.Interface of string**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | 
 **status** | **optional.Int32**| Specifies the status to filter the notifications. Read, Unread or All. | 
 **startdate** | **optional.Time**| The start date of the period to filter the notifications. | 
 **enddate** | **optional.Time**| The end date of the period to filter the notifications. | 

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


## Notificationsend

> Notificationsend(ctx, token, emailenabled, onscreenenabled, smsenabled, title, optional)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**emailenabled** | **bool**| Whether send the notification via email. | 
**onscreenenabled** | **bool**| Whether to display the notification on screen. | 
**smsenabled** | **bool**| Whether to send the notification via text message. | 
**title** | **string**| Notification title. | 
 **optional** | ***NotificationsendOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationsendOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------





 **tousers** | **optional.String**| Comma-separated Ids of users to send the notification. | 
 **togroups** | **optional.String**| Comma-separated Ids of user groups to send the notification. | 
 **onscreenbody** | **optional.String**| Body of the message for on-screen display. | 
 **onscreenclick** | **optional.String**| What to do when the notification is clicked. Valid values: hide, view, url. | 
 **onscreenurl** | **optional.String**| Url to redirect the user, if onscreenclick&#x3D;url. | 
 **onscreenclass** | **optional.String**| How to display the notification. Valid values: info, success, warning, error | 
 **onscreenduration** | **optional.Int32**| Time in seconds to display the notification. | 
 **showonstation** | **optional.Int32**| Whether to show the notification in the sign-in station. | 
 **emailfromname** | **optional.String**| Name of the email sender. | 
 **emailfrom** | **optional.String**| Reply-to email. | 
 **emailsubject** | **optional.String**| Subject of the email. | 
 **emailbody** | **optional.String**| Body of the email. | 
 **textmessagebody** | **optional.String**| Message for SMS. Max 160 characters. | 

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


## Notificationsendonscreen

> Notificationsendonscreen(ctx, token, notification)

Send on-screen notifications

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**notification** | [**string**](.md)| The ID of the notification to send. | 

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


## Notificationtopicdelete

> Notificationtopicdelete(ctx, token, id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the notification topic to delete. | 

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


## Notificationtopicget

> Notificationtopicget(ctx, token, id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the notification topic to get. | 

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


## Notificationtopiclist

> Notificationtopiclist(ctx, token, from, count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Notificationtopiclistsubscribe

> Notificationtopiclistsubscribe(ctx, token)

List all the notification topics available to subscribe

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Notificationtopicsave

> Notificationtopicsave(ctx, optional)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***NotificationtopicsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a NotificationtopicsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Pushderegister

> Pushderegister(ctx, devicetoken, platform)

Deregisters the current device to receive push notifications

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**devicetoken** | **string**| The device token where to send the notification. | 
**platform** | **string**| Either ios or android | 

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


## Pushregister

> Pushregister(ctx, devicetoken, platform)

Registers the current device to receive push notifications

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**devicetoken** | **string**| The device token where to send the notification. | 
**platform** | **string**| Either ios or android | 

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


## Qrlabelsprint

> Qrlabelsprint(ctx, token, optional)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***QrlabelsprintOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a QrlabelsprintOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **user** | [**optional.Interface of string**](.md)| The id of the user whose label needs to be printed. | 
 **group** | [**optional.Interface of string**](.md)| The id of the group whose members&#39; labels need to be printed. | 

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


## Qrloginget

> Qrloginget(ctx, token)

Gets an image of a QR token

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Qrloginlogin

> Qrloginlogin(ctx, onetimetoken)

Login

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**onetimetoken** | **string**| The token read from the QR code. | 

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


## Quickpaneldeletewidget

> Quickpaneldeletewidget(ctx, token, id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the widget. | 

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


## Quickpanelfetchwidget

> Quickpanelfetchwidget(ctx, token, widgetid)

Fetches the information for a specific widget.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**widgetid** | [**string**](.md)| The ID of the data to fetch it&#39;s data. | 

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


## Quickpanelgetwidget

> Quickpanelgetwidget(ctx, token, id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the widget to get. | 

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


## Quickpanelinit

> Quickpanelinit(ctx, token)

Returns the initial information required to show the quick panels

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Quickpanellistwidgets

> Quickpanellistwidgets(ctx, token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Quickpanellistwidgettypes

> Quickpanellistwidgettypes(ctx, token)

Lists all the widget types available in the system

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Quickpanelreorderwidgets

> Quickpanelreorderwidgets(ctx, token, sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**sectionname** | **string**| The section name where to sort the widgets. | 
**orderids** | **string**| CSV list of the widgets to reorder. | 

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


## Quickpanelsavewidget

> Quickpanelsavewidget(ctx, optional)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***QuickpanelsavewidgetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a QuickpanelsavewidgetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Ratingflag

> Ratingflag(ctx, token, id, optional)

Flags one rating for moderation

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The rating to flag. | 
 **optional** | ***RatingflagOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingflagOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **comment** | **optional.String**| Comment why should this should be removed. | 

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


## Ratingflagcomment

> Ratingflagcomment(ctx, token, id, optional)

Flags one comment for moderation

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The comment to flag. | 
 **optional** | ***RatingflagcommentOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingflagcommentOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **comment** | **optional.String**| Comment why should this should be removed. | 

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


## Ratingget

> Ratingget(ctx, token, type_, entityids)

Get rating for one or more entities

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**type_** | **string**| The entity type to get the rating. | 
**entityids** | **string**| List of ids to get the ratings. | 

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


## Ratinggetall

> Ratinggetall(ctx, token, type_, entityid, optional)

Gets the full ratings and comments for a specific entity

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**type_** | **string**| The entity type to get the rating. | 
**entityid** | **string**| Id of the entity to get the ratings. | 
 **optional** | ***RatinggetallOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatinggetallOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **mostrecentfirst** | **optional.Bool**| True to show most recent first, otherwise most helpful first. | 

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


## Ratinggetcomments

> Ratinggetcomments(ctx, token, ratingid)

Gets all the comments for a rating

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**ratingid** | [**string**](.md)| The ID of the rating to get all comments. | 

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


## Ratinggetpending

> Ratinggetpending(ctx, getgroup, optional)

Gets info of pre-saved and pre-approved ratings

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**getgroup** | [**string**](.md)| The ID of the group of pending ratings to get. | 
 **optional** | ***RatinggetpendingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatinggetpendingOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **rateid** | [**optional.Interface of string**](.md)| Rate this before returning. | 
 **rateval** | **optional.Int32**| The value used to rate the item specified in rateid. | 

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


## Ratinggetpendingmoderation

> Ratinggetpendingmoderation(ctx, token)

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Ratingmoderate

> Ratingmoderate(ctx, token, type_, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**type_** | **string**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
**id** | [**string**](.md)| Id of the rating or comment, as specified in type. | 
**approve** | **bool**| True to approve, false to reject. | 

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


## Ratingpostcomment

> Ratingpostcomment(ctx, token, ratingid, comment, annonymous)

Posts a comments for in a rating

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**ratingid** | [**string**](.md)| The ID of the rating to post the comment. | 
**comment** | **string**| Text of the comment to post. | 
**annonymous** | **bool**| True to post the comment annonymously. | 

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


## Ratingrate

> Ratingrate(ctx, token, type_, entityid, annonymous, optional)

Rates one entity

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**type_** | **string**| The entity type to rate. | 
**entityid** | **string**| Id of the entity to rate. | 
**annonymous** | **bool**| Whether to post as annonymous. | 
 **optional** | ***RatingrateOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingrateOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **value** | **optional.Int32**| Value from 0 to 100 with the rating. | 
 **comment** | **optional.String**| Comment associated with this review. Comment can be updated later on another request too. | 
 **updatecomment** | **optional.Bool**| Whether to update the comments. Defaults to true. | 

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


## Ratingratepending

> Ratingratepending(ctx, group, annonymous, optional)

Rates a pre-saved and pre-approved entity

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**group** | [**string**](.md)| The ID of the group of with pre-approved ratings. | 
**annonymous** | **bool**| Whether to post as annonymous. | 
 **optional** | ***RatingratependingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingratependingOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **rateid** | [**optional.Interface of string**](.md)| Rate this before returning. | 
 **value** | **optional.Int32**| Value from 0 to 100 with the rating. | 
 **comment** | **optional.String**| Comment associated with this review. Comment can be updated later on another request too. | 
 **updatecomment** | **optional.Bool**| Whether to update the comments. Defaults to true. | 

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


## Ratingvote

> Ratingvote(ctx, token, ratingid, vote)

Votes up or down a rating

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**ratingid** | [**string**](.md)| The ID of the rating to vote on. | 
**vote** | **int32**| 1 to vote up, -1 to vote down. | 

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


## Reportattanalyticsprepare

> Reportattanalyticsprepare(ctx, token, reportname, optional)

Query and load an attendance analytics report

Allows the user to query and load attendance analytics reports.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**reportname** | **string**| The name of the report to execute | 
 **optional** | ***ReportattanalyticsprepareOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReportattanalyticsprepareOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **params** | **optional.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | 
 **refreshgroup** | [**optional.Interface of string**](.md)| The ID of the group to check (and refresh) before processing the report. | 

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


## Reportlist

> Reportlist(ctx, token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Reportpermissionsbyuser

> Reportpermissionsbyuser(ctx, token, optional)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***ReportpermissionsbyuserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReportpermissionsbyuserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **params** | **optional.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | 

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


## Reportprepare

> Reportprepare(ctx, token, reportname, optional)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**reportname** | **string**| The name of the report to execute | 
 **optional** | ***ReportprepareOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReportprepareOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **params** | **optional.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | 
 **repformat** | **optional.String**| The format of the resulting report. Json, pdf, csv, ... | 
 **fillgroupid** | [**optional.Interface of string**](.md)| If specified, the result is used to fill the group with the given ID | 
 **groupby** | **optional.String**| How to group the records. In the format &#39;col1+col2|col3+col4 | 
 **refreshgroup** | [**optional.Interface of string**](.md)| The ID of the group to check (and refresh) before processing the report. | 
 **filtertext** | **optional.String**| The user friendly text of the applied filters. | 

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


## Reportquery

> Reportquery(ctx, token, reportname, optional)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**reportname** | **string**| The name of the report to execute | 
 **optional** | ***ReportqueryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReportqueryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **params** | **optional.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | 

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


## Reportscheduledelete

> Reportscheduledelete(ctx, token, id)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the report schedule to delete. | 

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


## Reportscheduleget

> Reportscheduleget(ctx, token, id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the schedule to get. | 

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


## Reportschedulelist

> Reportschedulelist(ctx, token, from, count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Reportschedulesave

> Reportschedulesave(ctx, optional)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ReportschedulesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReportschedulesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Reporttagresults

> Reporttagresults(ctx, token, reportname, assign, tags, optional)

Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.

Allows the user to use a report to assign or unassign tags.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**reportname** | **string**| The name of the report to execute | 
**assign** | **bool**| Specify whether the specified tags have to be assigned or unassigned. | 
**tags** | **string**| The tags to assign (or unassign) to the resulting users in the report, in JSON format. | 
 **optional** | ***ReporttagresultsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ReporttagresultsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **params** | **optional.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | 

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


## Riskmodelcheckanalysis

> Riskmodelcheckanalysis(ctx, token, id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

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


## Riskmodeldelete

> Riskmodeldelete(ctx, token, id)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the risk assessment model to delete. | 

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


## Riskmodelget

> Riskmodelget(ctx, token, id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the risk assessment model to get. | 

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


## Riskmodelgetscore

> Riskmodelgetscore(ctx, token, userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to get the risk score. | 

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


## Riskmodellist

> Riskmodellist(ctx, token, from, count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Riskmodelpredict

> Riskmodelpredict(ctx, token, id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the assessment model to use in order to predict risk. | 

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


## Riskmodelprocess

> Riskmodelprocess(ctx, token, id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the risk assessment model to process. | 

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


## Riskmodelrefresh

> Riskmodelrefresh(ctx, token, id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

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


## Riskmodelsave

> Riskmodelsave(ctx, optional)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***RiskmodelsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RiskmodelsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Riskmodeltermprecedences

> Riskmodeltermprecedences(ctx, token)

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Rolelist

> Rolelist(ctx, token, optional)

Show a list of roles

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***RolelistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RolelistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **name** | **optional.String**| Filter by name of the role. | 

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


## Ruledelete

> Ruledelete(ctx, token, id)

Delete a rule

Allows the user to delete an existing rule.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the rule to delete. | 

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


## Ruleget

> Ruleget(ctx, token, id)

View details of a rule

Allows the user to view an individual rule and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the rule to get. | 

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


## Rulegeteventtype

> Rulegeteventtype(ctx, token, event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**event** | **string**| The name of the event to refresh. | 

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


## Rulelist

> Rulelist(ctx, token, from, count)

View a list of user rules

Allows the user to view the list of all rules.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Rulelistactions

> Rulelistactions(ctx, token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Rulelisteventtypes

> Rulelisteventtypes(ctx, token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Rulelisthttprequests

> Rulelisthttprequests(ctx, token, from, count, optional)

View all the http requests sent as a result of a rule

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***RulelisthttprequestsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RulelisthttprequestsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **failed** | **optional.Bool**| If true only failed requests will be returned | 
 **status** | **optional.Int32**| The http status to filter the requests | 

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


## Rulesave

> Rulesave(ctx, optional)

Create or edit a rule

Allows the user to create or edit a rule.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***RulesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RulesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Scheduledelete

> Scheduledelete(ctx, token, scheduleid)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**scheduleid** | [**string**](.md)| The id of the schedule. | 

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


## Scheduledeletemine

> Scheduledeletemine(ctx, token, scheduleid)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**scheduleid** | [**string**](.md)| The id of the schedule. | 

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


## Scheduleenable

> Scheduleenable(ctx, token, userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to enable or disable the schedule. | 
**enable** | **bool**| True to enable schedules, false to disable. | 

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


## Scheduleenablemine

> Scheduleenablemine(ctx, token, enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**enable** | **bool**| True to enable schedules, false to disable. | 

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


## Schedulefindallstaffslots

> Schedulefindallstaffslots(ctx, token, starttime, endtime, optional)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
 **optional** | ***SchedulefindallstaffslotsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SchedulefindallstaffslotsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **staffid** | [**optional.Interface of string**](.md)| The id of the staff to filter by. | 
 **serviceids** | **optional.String**| CSV list of the service Ids to filter by. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the location to filter by. | 
 **staffroleids** | **optional.String**| CSV list of the staff member role ids to filter by. | 
 **availablefor** | **optional.String**| The specific availability type to filter by. | 

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


## Schedulefindslots

> Schedulefindslots(ctx, token, staffid, starttime, endtime, optional)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**staffid** | [**string**](.md)| The id of the staff to filter by. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
 **optional** | ***SchedulefindslotsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SchedulefindslotsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **serviceids** | **optional.String**| CSV list of the service Ids to filter by. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the service to filter by. | 
 **availablefor** | **optional.String**| The specific availability type to filter by. | 

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


## Schedulefindstaffavail

> Schedulefindstaffavail(ctx, token, starttime, endtime, optional)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**starttime** | **time.Time**| The start time of the range to look for slots. | 
**endtime** | **time.Time**| The end time of the range to look for slots. | 
 **optional** | ***SchedulefindstaffavailOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SchedulefindstaffavailOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **serviceids** | **optional.String**| CSV list of the service ids to filter by. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event to filter by. | 
 **locationid** | [**optional.Interface of string**](.md)| The id of the service to filter by. | 
 **staffroleids** | **optional.String**| CSV list of the staff member role ids to filter by. | 
 **availablefor** | **optional.String**| Filter slots by a specific availability type. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Scheduleget

> Scheduleget(ctx, token, scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**scheduleid** | [**string**](.md)| The id of the schedule. | 

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


## Schedulegetmine

> Schedulegetmine(ctx, token, scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**scheduleid** | [**string**](.md)| The id of the schedule. | 

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


## Schedulegetstaff

> Schedulegetstaff(ctx, token, userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to get info. | 

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


## Schedulegetstaffmine

> Schedulegetstaffmine(ctx, token)

View current user's schedule information

Allows the user to view their own schedule.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Scheduleintegrationdeleteitem

> Scheduleintegrationdeleteitem(ctx, token, thirdpartyid)

Delete a schedule item looking up by a third party ID

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**thirdpartyid** | **string**| The third party id to search the schedule block / appointment. | 

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


## Scheduleintegrationdeleteitemsbymasterid

> Scheduleintegrationdeleteitemsbymasterid(ctx, token, thirdpartymasterid)

Delete multiple schedule items looking up by a third party master ID

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**thirdpartymasterid** | **string**| The third party master id to search the schedule items. | 

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


## Scheduleintegrationgetitem

> Scheduleintegrationgetitem(ctx, token, thirdpartyid)

Get a schedule item looking up by a third party ID

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**thirdpartyid** | **string**| The third party id to search for the schedule item. | 

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


## Scheduleintegrationsaveitem

> Scheduleintegrationsaveitem(ctx, optional)

Save a schedule item looking up by a third party ID

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ScheduleintegrationsaveitemOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleintegrationsaveitemOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Scheduleintegrationsetid

> Scheduleintegrationsetid(ctx, token, id, thirdpartyid, optional)

Set a 3rd party ID on a specific schedule item

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the schedule block / appointment. | 
**thirdpartyid** | **string**| The 3rd party ID to set. | 
 **optional** | ***ScheduleintegrationsetidOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ScheduleintegrationsetidOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **thirdpartymasterid** | **optional.String**| The 3rd party master ID to set (useful to handle recurring items). | 

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


## Schedulemyofftimes

> Schedulemyofftimes(ctx, token, optional)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***SchedulemyofftimesOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SchedulemyofftimesOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **includedeleted** | **optional.Bool**| If true the deleted offtimes are also returned. | 
 **onlyupcoming** | **optional.Bool**| If true then only upcoming offtimes are returned. | 
 **modifiedafter** | **optional.Time**| If specified, only offtimes modified after the specified date will be returned. | 

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


## Schedulesave

> Schedulesave(ctx, optional)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SchedulesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SchedulesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Schedulesavemine

> Schedulesavemine(ctx, optional)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SchedulesavemineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SchedulesavemineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Search

> Search(ctx, token, query, optional)

Search

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**query** | **string**| The query to search for. | 
 **optional** | ***SearchOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SearchOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **page** | **optional.Int32**| Current page to show, zero-based. | 

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


## Searchgetentities

> Searchgetentities(ctx, token)

Get the information of the entities that can be searched

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Securityassesspermission

> Securityassesspermission(ctx, token, commandname)

Returns the list of users for a specific permission

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**commandname** | **string**| Name of the action or command to get the roles. | 

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


## Securityassessrole

> Securityassessrole(ctx, token, roleid)

Returns the list of permissions for a specific role

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**roleid** | [**string**](.md)| Role ID to list the effective permissions. | 

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


## Securityassessscope

> Securityassessscope(ctx, token, optional)

Returns the list of users for a specific user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***SecurityassessscopeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SecurityassessscopeOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **locationid** | [**optional.Interface of string**](.md)| Location ID to list the users with that scope. | 

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


## Securityassessuser

> Securityassessuser(ctx, token, userid)

Returns the list of permissions for a specific user

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| User ID to list the effective permissions. | 

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


## Seminardelete

> Seminardelete(ctx, token, id)

Delete an event

Allows the user to delete an existing event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the seminar to delete. | 

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


## Seminarget

> Seminarget(ctx, token, id)

Search and view details of a event

Allows the user to view a event and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the seminar to get. | 

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


## Seminarlist

> Seminarlist(ctx, token, from, count, optional)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **string**| The first record to return. | 
**count** | **string**| The max number of records to return. | 
 **optional** | ***SeminarlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SeminarlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **summaryonly** | **optional.Bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | 
 **termid** | [**optional.Interface of string**](.md)| Id of the term to list the events. Null to list all events. | 

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


## Seminarsave

> Seminarsave(ctx, optional)

Create or edit a event

Allows the user to create or edit a event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SeminarsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SeminarsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Serviceassignmentaddservice

> Serviceassignmentaddservice(ctx, token, serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceid** | [**string**](.md)| The id of the service to add. | 
**locationid** | [**string**](.md)| The id of the location. | 

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


## Serviceassignmentgetlocation

> Serviceassignmentgetlocation(ctx, token, locationid, optional)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**locationid** | [**string**](.md)| The id of the location to get. | 
 **optional** | ***ServiceassignmentgetlocationOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ServiceassignmentgetlocationOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **includegloballyavailable** | **optional.Bool**| Specifies whether the services available globally must be returned or not. | 
 **namefilter** | **optional.Bool**| Filters the name of the services to return. | 
 **count** | **optional.Int32**| The max number of services to return. | 

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


## Serviceassignmentgetservice

> Serviceassignmentgetservice(ctx, token, serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceid** | [**string**](.md)| The id of the service to get its locations. | 

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


## Serviceassignmentremoveservice

> Serviceassignmentremoveservice(ctx, token, serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceid** | [**string**](.md)| The id of the service to remove. | 
**locationid** | [**string**](.md)| The id of the location to remove the service from. | 

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


## Servicedelete

> Servicedelete(ctx, token, id)

Delete a service

Allows the user to delete a service from the existing list.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the service to delete. | 

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


## Serviceget

> Serviceget(ctx, token, id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the service to get. | 

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


## Servicelist

> Servicelist(ctx, token, from, count)

View a list of services

Allows the user to view the full list of existing services.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Servicesave

> Servicesave(ctx, optional)

Create or edit a service

Allows the user to create or edit a service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***ServicesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a ServicesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Sessionattendancelogaddnote

> Sessionattendancelogaddnote(ctx, token, id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the attendance log. | 
**text** | **string**| The text of the note to add. | 

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


## Sessionattendancelogget

> Sessionattendancelogget(ctx, token, id, optional)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the attendance log to get. | 
 **optional** | ***SessionattendanceloggetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendanceloggetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | 

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


## Sessionattendanceloggetuser

> Sessionattendanceloggetuser(ctx, attendee, eventid, optional)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**attendee** | [**string**](.md)| The id of the attendee to get statistic for. | 
**eventid** | [**string**](.md)| The id of the event whose attendee statistics have to be returned. | 
 **optional** | ***SessionattendanceloggetuserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendanceloggetuserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **token** | **optional.String**| The authentication token. | 

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


## Sessionattendanceloglist

> Sessionattendanceloglist(ctx, token, session, from, count, optional)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**session** | [**string**](.md)| The id of the session whose attendees logs have to be returned. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***SessionattendanceloglistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendanceloglistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Sessionattendanceloglistevent

> Sessionattendanceloglistevent(ctx, eventid, optional)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**eventid** | [**string**](.md)| The id of the event whose attendance has to be returned. | 
 **optional** | ***SessionattendanceloglisteventOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendanceloglisteventOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **token** | **optional.String**| The authentication token. | 

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


## Sessionattendanceloglistsummary

> Sessionattendanceloglistsummary(ctx, optional)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionattendanceloglistsummaryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendanceloglistsummaryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **optional.String**| The authentication token. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event whose attendance has to be returned. | 
 **attendeeid** | [**optional.Interface of string**](.md)| The id of the attendee whose attendance has to be returned. | 
 **groupid** | [**optional.Interface of string**](.md)| The id of the group whose attendance has to be returned. | 
 **start** | **optional.String**| The start date to filter (beginning of time by default). | 
 **end** | **optional.String**| The end date to filter (today by default). | 

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


## Sessionattendancelogmylistsummary

> Sessionattendancelogmylistsummary(ctx, optional)

View my attendance summary

Allows the user to view their own attendance summary.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionattendancelogmylistsummaryOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogmylistsummaryOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **optional.String**| The authentication token. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event whose attendance has to be returned. | 
 **start** | **optional.String**| The start date to filter (beginning of time by default). | 
 **end** | **optional.String**| The end date to filter (today by default). | 

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


## Sessionattendancelogsave

> Sessionattendancelogsave(ctx, optional)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionattendancelogsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Sessionattendancelogsaveswipe

> Sessionattendancelogsaveswipe(ctx, optional)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionattendancelogsaveswipeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionattendancelogsaveswipeOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Sessionbulkupdate

> Sessionbulkupdate(ctx, token, eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The id of the event to bulk update. | 
**sessions** | **string**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

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


## Sessionget

> Sessionget(ctx, token, id)

View details of a session

Allows the user to view a session in order to take attendance.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the session to get. | 

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


## Sessiongetschedule

> Sessiongetschedule(ctx, optional)

Gets the schedule for a location, instructor or attendees

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessiongetscheduleOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessiongetscheduleOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **optional.String**| The authentication token. | 
 **day** | **optional.Time**| The day to return. It will also return the whole week for that day. | 
 **attendee** | [**optional.Interface of string**](.md)| The id of the attendee to get the schedule. | 
 **location** | [**optional.Interface of string**](.md)| The id of the location to get the schedule. | 
 **instructor** | [**optional.Interface of string**](.md)| The id of the instructor to get the schedule. | 

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


## Sessionlist

> Sessionlist(ctx, from, count, optional)

Gets all future sessions of the current semester

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***SessionlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **token** | **optional.String**| The authentication token. | 
 **startdate** | **optional.Time**| The start date to filter the sessions | 
 **enddate** | **optional.Time**| The end date to filter the sessions. | 

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


## Sessionregaddcurrentuser

> Sessionregaddcurrentuser(ctx, token, eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The id of the event. | 
**sessiondate** | **time.Time**| The date and time when the session starts. | 

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


## Sessionregadduser

> Sessionregadduser(ctx, token, userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to add. | 
**eventid** | [**string**](.md)| The id of the event. | 
**sessiondate** | **time.Time**| The date and time when the session starts. | 

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


## Sessionreggetmysessions

> Sessionreggetmysessions(ctx, token, optional)

View all the sessions the logged user is registered to

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***SessionreggetmysessionsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionreggetmysessionsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **date** | **optional.Time**| Start date to filter the sessions. | 

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


## Sessionreggetsessions

> Sessionreggetsessions(ctx, token, userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The user id to list sessions. | 

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


## Sessionreggetsettings

> Sessionreggetsettings(ctx, token, optional)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***SessionreggetsettingsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionreggetsettingsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **locationid** | [**optional.Interface of string**](.md)| The id of the location to save settings. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event to save settings. | 
 **sessiondate** | **optional.Time**| The date and time when the session starts. | 
 **noinherit** | **optional.Bool**| True to get the location/event/session specific settings without looking for the more global settings. | 

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


## Sessionreggetusers

> Sessionreggetusers(ctx, token, eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The event id to list sessions. | 
**sessiondate** | **time.Time**| The date of the session to find. | 

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


## Sessionreglistsessions

> Sessionreglistsessions(ctx, token, eventid, optional)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The event id to list sessions. | 
 **optional** | ***SessionreglistsessionsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionreglistsessionsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **sessiondate** | **optional.Time**| The date of the session to find. | 

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


## Sessionreglistupcoming

> Sessionreglistupcoming(ctx, token, date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**date** | **time.Time**| Only sessions in the week of the specified date will be returned. | 

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


## Sessionreglistupcomingevent

> Sessionreglistupcomingevent(ctx, token, date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**date** | **time.Time**| Start date to filter the returned sessions. | 
**event** | [**string**](.md)| The id of the event whose sessions will be returned | 

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


## Sessionregremovecurrentuser

> Sessionregremovecurrentuser(ctx, token, eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**eventid** | [**string**](.md)| The id of the event. | 
**sessiondate** | **time.Time**| The date and time when the session starts. | 

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


## Sessionregremoveuser

> Sessionregremoveuser(ctx, token, userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to remove. | 
**eventid** | [**string**](.md)| The id of the event. | 
**sessiondate** | **time.Time**| The date and time when the session starts. | 

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


## Sessionregsavesettings

> Sessionregsavesettings(ctx, optional)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionregsavesettingsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionregsavesettingsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Sessionswipedelete

> Sessionswipedelete(ctx, token, id)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the session swipe to delete. | 

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


## Sessionswipeget

> Sessionswipeget(ctx, token, id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the swipe to get. | 

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


## Sessionswipelistunresolved

> Sessionswipelistunresolved(ctx, from, count, optional)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***SessionswipelistunresolvedOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionswipelistunresolvedOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **token** | **optional.String**| The authentication token. | 

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


## Sessionswiperesolve

> Sessionswiperesolve(ctx, token, id, optional)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the swipe to resolve. | 
 **optional** | ***SessionswiperesolveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionswiperesolveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **session** | [**optional.Interface of string**](.md)| The id of the session whose swipe has to be saved. | 
 **user** | [**optional.Interface of string**](.md)| The id of the user who signed-in. | 

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


## Sessionswipesave

> Sessionswipesave(ctx, optional)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionswipesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionswipesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Sessionswipesaveanonym

> Sessionswipesaveanonym(ctx, optional)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SessionswipesaveanonymOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SessionswipesaveanonymOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Settingaddlogo

> Settingaddlogo(ctx, token, upload, filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
**filename** | **string**| The original filename, needed to process the file. | 

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


## Settingget

> Settingget(ctx, keys, optional)

Get settings for the account or the specified scope

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**keys** | **string**| The option keys to get values for. Enter multiple separated by comma. | 
 **optional** | ***SettinggetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SettinggetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **token** | **optional.String**| The authentication token. | 
 **domain** | **optional.String**| The account domain, in case of reading settings annonymously. | 
 **scope** | **optional.String**| The scope of the settings to get. | 

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


## Settingsave

> Settingsave(ctx, optional)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SettingsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SettingsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Settingviewgeneral

> Settingviewgeneral(ctx, token)

View general settings for the account

Allows the user to view the settings' general section.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Socialcontacts

> Socialcontacts(ctx, token, optional)

Gets the list of contacts in the network

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***SocialcontactsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SocialcontactsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **filter** | **optional.String**| Text to filter results. | 
 **showdefaultphoto** | **optional.Bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | 

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


## Socialgroupaddmembers

> Socialgroupaddmembers(ctx, token, id, userids)

Adds new members to a group (which the user must own already)

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| ID of the group to add members to. | 
**userids** | **string**| Csv list of user Ids to add. | 

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


## Socialgroupdelete

> Socialgroupdelete(ctx, token, id)

Deletes a group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| ID of the group to delete. | 

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


## Socialgrouplist

> Socialgrouplist(ctx, token)

View all the groups the current user is in

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Socialgrouplistmembers

> Socialgrouplistmembers(ctx, token, id)

Lists the members of a group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| ID of the group to list members. | 

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


## Socialgroupremovemembers

> Socialgroupremovemembers(ctx, token, id, userids)

Removes members from a group (which the user must own already)

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| ID of the group to remove members from. | 
**userids** | **string**| Csv list of user Ids to remove. | 

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


## Socialgroupremovemyself

> Socialgroupremovemyself(ctx, token, id)

Removes myself from an existent group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| ID of the group to remove me from. | 

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


## Socialgroupsave

> Socialgroupsave(ctx, optional)

Saves a new group

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SocialgroupsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SocialgroupsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Ssogeneratekey

> Ssogeneratekey(ctx, token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Ssogetsettings

> Ssogetsettings(ctx, token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Ssoissuetoken

> Ssoissuetoken(ctx, key, username, optional)

Issue single sign-on token

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**key** | **string**| The single sign-on key of the account. | 
**username** | **string**| The email of the user to sign-on. | 
 **optional** | ***SsoissuetokenOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SsoissuetokenOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **expires** | **optional.Bool**| Specifies whether the session should expire when inactive. | 

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


## Ssosavesettings

> Ssosavesettings(ctx, optional)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SsosavesettingsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SsosavesettingsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Staffavailaddmetoallservices

> Staffavailaddmetoallservices(ctx, token)

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Staffavailaddmetoservice

> Staffavailaddmetoservice(ctx, token, serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceid** | [**string**](.md)| The id of the service. | 

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


## Staffavailaddusertoallservices

> Staffavailaddusertoallservices(ctx, token, userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to add. | 

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


## Staffavailaddusertoservice

> Staffavailaddusertoservice(ctx, token, userid, serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to add. | 
**serviceid** | [**string**](.md)| The id of the service. | 

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


## Staffavailgetmyservices

> Staffavailgetmyservices(ctx, token)

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Staffavailgetservices

> Staffavailgetservices(ctx, token, userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The user id to list services. | 

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


## Staffavailgetusersforservice

> Staffavailgetusersforservice(ctx, token, serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceid** | [**string**](.md)| The service id to list users. | 

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


## Staffavaillisttypes

> Staffavaillisttypes(ctx, token)

View all the availability types

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Staffavailremovemefromallservices

> Staffavailremovemefromallservices(ctx, token)

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Staffavailremovemefromservice

> Staffavailremovemefromservice(ctx, token, serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**serviceid** | [**string**](.md)| The id of the service. | 

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


## Staffavailremoveuserfromallservices

> Staffavailremoveuserfromallservices(ctx, token, userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to remove. | 

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


## Staffavailremoveuserfromservice

> Staffavailremoveuserfromservice(ctx, token, userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to remove. | 
**serviceid** | [**string**](.md)| The id of the service. | 

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


## Staffavailsetavailability

> Staffavailsetavailability(ctx, token, userid, optional)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user whose specific availability has to be set. | 
 **optional** | ***StaffavailsetavailabilityOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StaffavailsetavailabilityOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **availablefor** | **optional.String**| Specific availability to set. | 

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


## Staffavailsetmyavailability

> Staffavailsetmyavailability(ctx, token, optional)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***StaffavailsetmyavailabilityOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StaffavailsetmyavailabilityOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **availablefor** | **optional.String**| Specific availability to set. | 

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


## Stationdelete

> Stationdelete(ctx, token, id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the sign-in station to delete. | 

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


## Stationget

> Stationget(ctx, token, id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the sign-in station to get. | 

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


## Stationgetcurrentterms

> Stationgetcurrentterms(ctx, station)

Get all the current terms

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

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


## Stationgetinfo

> Stationgetinfo(ctx, id, optional)

Gets a the info to display in the sign-in station by it's ID.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to get. | 
 **optional** | ***StationgetinfoOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StationgetinfoOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **event** | [**optional.Interface of string**](.md)| The id of the event, to override the one by schedule. | 

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


## Stationgetlicense

> Stationgetlicense(ctx, station)

Gets the current license information

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | **string**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

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


## Stationgetlocationsettings

> Stationgetlocationsettings(ctx, location)

View the sign-in station settings of a specified location

Allows the user to view the location settings of a sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**location** | [**string**](.md)| The id of the location whose station settings have to be returned. | 

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


## Stationlist

> Stationlist(ctx, token, from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Stationsave

> Stationsave(ctx, optional)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***StationsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StationsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Stationsavemine

> Stationsavemine(ctx, optional)

Create or edit a class attendance sign-in station for myself

Allows the user to create a class attendance sign-in station for a course for which they are available as staff.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***StationsavemineOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a StationsavemineOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Stationunlock

> Stationunlock(ctx, id, passcode, method)

Unlocks the sign-in station.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the sign-in station to unlock. | 
**passcode** | **string**| The passcode to unlock the station. | 
**method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

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


## Swipedelete

> Swipedelete(ctx, token, id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the swipe to delete. | 

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


## Swipeget

> Swipeget(ctx, token, id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the swipe to get. | 

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


## Swipelist

> Swipelist(ctx, from, count, optional)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***SwipelistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SwipelistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **token** | **optional.String**| The authentication token. | 

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


## Swipesave

> Swipesave(ctx, optional)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SwipesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SwipesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Swipesaveanonym

> Swipesaveanonym(ctx, optional)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***SwipesaveanonymOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a SwipesaveanonymOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Tagdelete

> Tagdelete(ctx, token, id)

Delete a tag

Allows the user to delete an existing tag.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the tag to delete. | 

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


## Tagget

> Tagget(ctx, token, id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the tag to get. | 

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


## Taglist

> Taglist(ctx, token, group, from, count)

View a list of tags

Allows the user to view the list of tags.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**group** | **string**| The group of the tags to return. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Taglistgroups

> Taglistgroups(ctx, token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Tagsave

> Tagsave(ctx, optional)

Create or edit a tag

Allows the user to create or edit a tag.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TagsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TagsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Tagsearch

> Tagsearch(ctx, token, query, optional)

Search for tags in the account

Allows the user to search for tags.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**query** | **string**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **optional** | ***TagsearchOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TagsearchOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **allowcreatingnew** | **optional.Bool**| Specifies whether an option to create a new tag should be retrieved. | 

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


## Templateaddimage

> Templateaddimage(ctx, token, template, upload, optional)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**template** | [**string**](.md)| The id of the template where the image has to be added | 
**upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **optional** | ***TemplateaddimageOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateaddimageOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **filename** | **optional.String**| The local name of the uploaded file. For later reference. | 

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


## Templatedelete

> Templatedelete(ctx, token, id)

Delete a template

Allows the user to delete an existing template.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the template to delete. | 

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


## Templateemail

> Templateemail(ctx, token, jobid, emailsubject, emailbody, optional)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**jobid** | **string**| The id of the job that is creating the templates. | 
**emailsubject** | **string**| Args depending on the send-to flag. | 
**emailbody** | **string**| Args depending on the send-to flag. | 
 **optional** | ***TemplateemailOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplateemailOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **templatekind** | **optional.String**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | 
 **emailfrom** | **optional.String**| The name of the sender to be displayed in the receipients inbox | 
 **emailreplyto** | **optional.String**| The reply-to field for the emails. | 

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


## Templategenerate

> Templategenerate(ctx, token, template, source, singlefile, optional)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**template** | [**string**](.md)| The id of the template to generate. | 
**source** | [**string**](.md)| The source key of the selected template data source. | 
**singlefile** | **bool**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **optional** | ***TemplategenerateOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplategenerateOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **userid** | **optional.String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | 
 **forsending** | **optional.Bool**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | 
 **role** | [**optional.Interface of string**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | 
 **filters** | **optional.String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | 

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


## Templateget

> Templateget(ctx, token, id)

View details of a template

Allows the user to view a template and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the template to get. | 

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


## Templategetgenerated

> Templategetgenerated(ctx, token, jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**jobid** | **string**| The id of the job that is creating the templates. | 

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


## Templatelist

> Templatelist(ctx, token, from, count, kind, optional)

View a list of defined templates

Allows the user to view the full list of created templates.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
**kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **optional** | ***TemplatelistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplatelistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **designedonly** | **optional.Bool**| If true then it only returns the templates that were designed. Otherwise, it returns all. | 

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


## Templatelistsources

> Templatelistsources(ctx, token, kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 

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


## Templatesave

> Templatesave(ctx, optional)

Create or edit a template

Allows the user to create or edit a template.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TemplatesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplatesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Templatesavelayout

> Templatesavelayout(ctx, optional)

Save the layout of a template

Allows the user to edit a template's layout.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TemplatesavelayoutOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TemplatesavelayoutOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Termdelete

> Termdelete(ctx, token, id)

Delete a term

Allows the user to delete a term from the existing list.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the term to delete. | 

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


## Termget

> Termget(ctx, token, id)

Search and view details of a term

Allows the user to view a term and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the term to get. | 

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


## Termlist

> Termlist(ctx, token, optional)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***TermlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TermlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **from** | **optional.Int32**| The first record to return. | 
 **count** | **optional.Int32**| The max number of records to return. | 
 **notpast** | **optional.Bool**| Specifies whether the terms in the past should be returned or not. | 

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


## Termsave

> Termsave(ctx, optional)

Create and edit terms

Allows the user to create and edit terms.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TermsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TermsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Textcreditremaining

> Textcreditremaining(ctx, token)

Gets the remaining text credits for the account

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Texttoimage

> Texttoimage(ctx, token, text, optional)

Generates a dynamic image from text

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**text** | **string**| The text to convert to an image, use double pipes (||) as a new line. | 
 **optional** | ***TexttoimageOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TexttoimageOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **fontcolor** | **optional.String**| The color of the text, in hex format, without the #. | 
 **fontsize** | **optional.Int32**| The size of the text, in points. | 
 **direction** | **optional.String**| Either vertical or horizontal, default horizontal. | 
 **width** | **optional.Int32**| The image width in pixels (or height if the direction is vertical). | 

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


## Translationget

> Translationget(ctx, token, universal)

Gets the translations of the specified values

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**universal** | **string**| Pipe separated list of universal text to be translated. | 

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


## Translationgetcachefile

> Translationgetcachefile(ctx, optional)

Get the file containing the translations

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TranslationgetcachefileOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TranslationgetcachefileOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **optional.String**| The authentication token. | 
 **account** | **optional.String**| The id of the account whose translations file has to be retrieved. | 

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


## Translationlist

> Translationlist(ctx, token, optional)

Lists all the available translations in the system

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***TranslationlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TranslationlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **filter** | **optional.String**| Text to search/filter translations. | 
 **nondefaultonly** | **optional.Bool**| If true then it returns only the terms translated. Otherwise, it returns all. | 
 **appdefaultasuniversal** | **optional.Bool**| If true then it uses the app default translation as the universal term. | 

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


## Translationsave

> Translationsave(ctx, optional)

Edit a translation

Allows the user to edit a translation for the entire account.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***TranslationsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a TranslationsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Userchangepwd

> Userchangepwd(ctx, token, oldpass, newpass)

Change user's own password

Allows the user to change their own password.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**oldpass** | [**string**](.md)| The old password of the authenticated user. | 
**newpass** | [**string**](.md)| The new password of the authenticated user. | 

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


## Userchangepwdbyreq

> Userchangepwdbyreq(ctx, changereq, newpass)

Changes the user password using a change password request id

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**changereq** | **string**| The change password request ID sent by email to the user. | 
**newpass** | **string**| The new password of the user. | 

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


## Userdelete

> Userdelete(ctx, token, id)

Delete a user

Allows the user to delete a user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the user to delete. | 

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


## Userfindsimilar

> Userfindsimilar(ctx, token, optional)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***UserfindsimilarOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserfindsimilarOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **currentid** | [**optional.Interface of string**](.md)| The id of the current user. | 
 **phonenumber** | **optional.String**| A phone number to search for similar users. | 
 **cardnumber** | **optional.String**| A card number to search for similar users. | 

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


## Userget

> Userget(ctx, token, id, optional)

Search and view details of a user

Allows the user to search and view a user and their details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the user to get. | 
 **optional** | ***UsergetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Usergetbycard

> Usergetbycard(ctx, token, card, optional)

Search user by card number

Allows the user to search for a user by their card number.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**card** | **string**| The card number of the user to get. | 
 **optional** | ***UsergetbycardOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergetbycardOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Usergroupaddmember

> Usergroupaddmember(ctx, token, userid, groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to add. | 
**groupid** | [**string**](.md)| The id of the group. | 

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


## Usergroupdelete

> Usergroupdelete(ctx, token, id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the group to delete. | 

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


## Usergroupget

> Usergroupget(ctx, token, id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the user group to get. | 

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


## Usergroupgetmembers

> Usergroupgetmembers(ctx, token, groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**groupid** | [**string**](.md)| The id of the user group to get. | 

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


## Usergroupgetuser

> Usergroupgetuser(ctx, token, userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to get his groups. | 

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


## Usergrouplist

> Usergrouplist(ctx, token, optional)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***UsergrouplistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergrouplistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **from** | **optional.Int32**| The first record to return. | 
 **count** | **optional.Int32**| The max number of records to return. | 
 **type_** | **optional.String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | 

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


## Usergrouprefresh

> Usergrouprefresh(ctx, token, group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**group** | [**string**](.md)| The ID of the group to refresh. | 

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


## Usergroupremovemember

> Usergroupremovemember(ctx, token, userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**userid** | [**string**](.md)| The id of the user to remove. | 
**groupid** | [**string**](.md)| The id of the group. | 

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


## Usergroupsave

> Usergroupsave(ctx, optional)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UsergroupsaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergroupsaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Usergrouptagmembers

> Usergrouptagmembers(ctx, token, group, optional)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**group** | [**string**](.md)| The id of the group to save whose members have to be tagged. | 
 **optional** | ***UsergrouptagmembersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergrouptagmembersOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **tags** | **optional.String**| The tags to assign to the members of the specified group, in JSON format. | 

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


## Usergroupuntagmembers

> Usergroupuntagmembers(ctx, token, group, optional)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**group** | [**string**](.md)| The id of the group to save whose members have to be untagged. | 
 **optional** | ***UsergroupuntagmembersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsergroupuntagmembersOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **tags** | **optional.String**| The tags to unassign from the members of the specified group, in JSON format. | 

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


## Userlist

> Userlist(ctx, token, from, count, optional)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 
 **optional** | ***UserlistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserlistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **roleid** | [**optional.Interface of string**](.md)| The id of the role to filter users by, or empty to return all users. | 
 **onlywithoutcard** | **optional.String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | 
 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Userloadphoto

> Userloadphoto(ctx, token, upload, optional)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **optional** | ***UserloadphotoOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserloadphotoOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **filename** | **optional.String**| The local name of the uploaded file. For later reference. | 
 **userid** | [**optional.Interface of string**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | 
 **automatch** | **optional.Bool**| Set this to true to find the specific user based on the file name.  | 

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


## Usermovedata

> Usermovedata(ctx, token, source, destination)

Move data between users

Allows administrators to move data between users.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**source** | [**string**](.md)| The id of the user that is the source of the data. | 
**destination** | [**string**](.md)| The id of the user that is the destination of the data. | 

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


## Userprofiledelete

> Userprofiledelete(ctx, token, id)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the user profile to delete. | 

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


## Userprofileget

> Userprofileget(ctx, token, id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the profile question set. | 

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


## Userprofilegetallview

> Userprofilegetallview(ctx, token, optional)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***UserprofilegetallviewOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserprofilegetallviewOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **id** | [**optional.Interface of string**](.md)| The id of the user to view, or empty for current user. | 

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


## Userprofilelist

> Userprofilelist(ctx, token, optional)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***UserprofilelistOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserprofilelistOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **from** | **optional.Int32**| The first record to return. | 
 **count** | **optional.Int32**| The max number of records to return. | 

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


## Userprofilelistquestions

> Userprofilelistquestions(ctx, token)

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Userprofilepreparestats

> Userprofilepreparestats(ctx, token, optional)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
 **optional** | ***UserprofilepreparestatsOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserprofilepreparestatsOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **params** | **optional.String**| The ID of the group, specified as &#39;group&#x3D;...&#39; | 

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


## Userprofilesave

> Userprofilesave(ctx, optional)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UserprofilesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserprofilesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Userprofilesaveanswers

> Userprofilesaveanswers(ctx, optional)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UserprofilesaveanswersOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UserprofilesaveanswersOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Userrequestpwdchange

> Userrequestpwdchange(ctx, domain, email)

Requests a password change

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**domain** | **string**| The domain of the account where the user exists. | 
**email** | **string**| The email of the user. | 

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


## Usersave

> Usersave(ctx, optional)

Create or edit a user

Allows the user to create or edit a user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UsersaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Usersavepwdchange

> Usersavepwdchange(ctx, optional)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UsersavepwdchangeOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersavepwdchangeOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Usersettingsget

> Usersettingsget(ctx, token, keys, optional)

Lists available user settings

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **optional** | ***UsersettingsgetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersettingsgetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **user** | [**optional.Interface of string**](.md)| The user id whose settings have to be returned. | 

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


## Usersettingsgetmultiple

> Usersettingsgetmultiple(ctx, token, keys, optional)

Get multiple user settings

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **optional** | ***UsersettingsgetmultipleOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersettingsgetmultipleOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **user** | [**optional.Interface of string**](.md)| The user id whose settings have to be returned. | 

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


## Usersettingssave

> Usersettingssave(ctx, optional)

Saves a user setting

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UsersettingssaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersettingssaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Usersettingssavemultiple

> Usersettingssavemultiple(ctx, optional)

Save multiple user settings at once

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***UsersettingssavemultipleOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a UsersettingssavemultipleOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Version

> Version(ctx, token)

Get current version information

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Virtuallineaddmyself

> Virtuallineaddmyself(ctx, token, waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**waitinglineid** | [**string**](.md)| ID of the waiting line to join. | 

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


## Virtuallinelist

> Virtuallinelist(ctx, token)

Lists waiting lines that have remote access enabled

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Virtuallineremovemyself

> Virtuallineremovemyself(ctx, token)

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 

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


## Waitinglineadduser

> Waitinglineadduser(ctx, station, user, optional)

Put user in a waiting line

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station. | 
**user** | **string**| The user&#39;s card number. | 
 **optional** | ***WaitinglineadduserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglineadduserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **locationid** | [**optional.Interface of string**](.md)| The location&#39;s id where the swipe must be saved. | 
 **time** | **optional.Time**| The date and time of the swipe. | 
 **signinrole** | **optional.String**| Specifies if the sign-in is for an attendee or a staff member | 
 **roleid** | [**optional.Interface of string**](.md)| Specifies the role the user has selected in order to sign-in | 
 **services** | **optional.String**| The services ids the user has selected. | 
 **eventid** | [**optional.Interface of string**](.md)| The id of the event the user selected. | 
 **staff** | [**optional.Interface of string**](.md)| The id of the staff member the user selected. | 
 **photosize** | **optional.Int32**| The swiping user&#39;s photo size. | 

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


## Waitinglinedelete

> Waitinglinedelete(ctx, token, id)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the line to delete. | 

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


## Waitinglineget

> Waitinglineget(ctx, token, id, optional)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**id** | [**string**](.md)| The id of the waiting line to get. | 
 **optional** | ***WaitinglinegetOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglinegetOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **photosize** | **optional.Int32**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | 

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


## Waitinglineisuserin

> Waitinglineisuserin(ctx, station, time, user, optional)

Check whether a user is in a waiting line, signed-in or is not in the area

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**station** | [**string**](.md)| The id of the sign-in station. | 
**time** | **time.Time**| The date and time of the swipe. | 
**user** | **string**| The card number of the user. | 
 **optional** | ***WaitinglineisuserinOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglineisuserinOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **location** | [**optional.Interface of string**](.md)| The id of the location the user picked. | 

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


## Waitinglinelist

> Waitinglinelist(ctx, token, from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

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


## Waitinglineremoveuser

> Waitinglineremoveuser(ctx, token, waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**waitingline** | [**string**](.md)| The id of the waiting line whose item has to be removed. | 
**itemid** | [**string**](.md)| The ID of the item that has to be removed. | 

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


## Waitinglinesave

> Waitinglinesave(ctx, optional)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
 **optional** | ***WaitinglinesaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglinesaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Waitinglinesigninuser

> Waitinglinesigninuser(ctx, token, waitingline, itemid, staff, optional)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**token** | **string**| The authentication token. | 
**waitingline** | [**string**](.md)| The id of the waiting line whose item needs to be signed-in. | 
**itemid** | [**string**](.md)| The ID of the item that has to be signed-in. | 
**staff** | [**string**](.md)| The id of the staff member selected to sign-in. | 
 **optional** | ***WaitinglinesigninuserOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a WaitinglinesigninuserOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------




 **photosize** | **optional.Int32**| The swiping user&#39;s photo size. | 

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

