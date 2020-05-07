# AccuCampusOpenApi3Documentation.DefaultApi

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
[**callExport**](DefaultApi.md#callExport) | **GET** /export | Export AccuCampus data
[**callImport**](DefaultApi.md#callImport) | **GET** /import | Import data into AccuCampus
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
[**exportlisttypes**](DefaultApi.md#exportlisttypes) | **GET** /exportlisttypes | Lists available export types
[**featurelist**](DefaultApi.md#featurelist) | **GET** /featurelist | Lists the available features.
[**holidaylist**](DefaultApi.md#holidaylist) | **GET** /holidaylist | View a list of entered holidays
[**holidaysave**](DefaultApi.md#holidaysave) | **POST** /holidaysave | Create or edit a list of holidays
[**holidaysuggest**](DefaultApi.md#holidaysuggest) | **GET** /holidaysuggest | View the holiday suggestions in the given term
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



## actionassignmentdelete

> actionassignmentdelete(token, id)

Remove an action item from an action plan

Allows a user to remove an action item from a user&#39;s action plan.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the action assignment to delete.
apiInstance.actionassignmentdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action assignment to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentget

> actionassignmentget(token, id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the action assignment to get.
apiInstance.actionassignmentget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action assignment to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentlist

> actionassignmentlist(token, from, count, opts)

View a list of action items in a user&#39;s plan

Allows the user to view the list of all action items for a specified user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'assignee': 56, // Number | The assignee's id to filter the assignments.
  'status': 56 // Number | The status to filter the assignments.
};
apiInstance.actionassignmentlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **assignee** | **Number**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **Number**| The status to filter the assignments. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentlisthistory

> actionassignmentlisthistory(token, actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let actionassignment = null; // String | The action assignment's id whose history the user wants to get.
apiInstance.actionassignmentlisthistory(token, actionassignment, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **actionassignment** | [**String**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentlistmine

> actionassignmentlistmine(token, from, count, opts)

List public action assignments assigned to the logged user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'status': 56 // Number | The status to filter the assignments.
};
apiInstance.actionassignmentlistmine(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **status** | **Number**| The status to filter the assignments. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentlistpublichistory

> actionassignmentlistpublichistory(token, actionassignment)

List public action assignment history

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let actionassignment = null; // String | The action assignment's id whose history the user wants to get.
apiInstance.actionassignmentlistpublichistory(token, actionassignment, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **actionassignment** | [**String**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentmarkcomplete

> actionassignmentmarkcomplete(token, item, opts)

Bulk complete action items

Allows the user to bulk complete action items.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let item = "item_example"; // String | The action item to assign.
let opts = {
  'assignee': null, // String | The assignee of the item.
  'group': null, // String | The group to assing the item.
  'notes': "notes_example" // String | The assignment's notes.
};
apiInstance.actionassignmentmarkcomplete(token, item, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **item** | **String**| The action item to assign. | 
 **assignee** | [**String**](.md)| The assignee of the item. | [optional] 
 **group** | [**String**](.md)| The group to assing the item. | [optional] 
 **notes** | **String**| The assignment&#39;s notes. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentsave

> actionassignmentsave(opts)

Add an action item to a user&#39;s action plan

Allows the user to edit or assign an action item to a user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.actionassignmentsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actionassignmentsavehistory

> actionassignmentsavehistory(opts)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.actionassignmentsavehistory(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actionitemdelete

> actionitemdelete(token, id)

Delete an action item

Allows the user to delete an action item.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the action item to delete.
apiInstance.actionitemdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action item to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionitemget

> actionitemget(token, id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the action item to get.
apiInstance.actionitemget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action item to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionitemlist

> actionitemlist(token, from, count)

View a list of action items

Allows the user to view a list of action items

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.actionitemlist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionitemsave

> actionitemsave(opts)

Create or edit an action item

Allows the user to edit an action item.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.actionitemsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actionloglist

> actionloglist(token, from, count, opts)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'user': null, // String | The id of the user whose action logs have to be returned.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the logs.
  'enddate': new Date("2013-10-20T19:20:30+01:00"), // Date | The end date of the period to filter the logs.
  'resource': "resource_example", // String | The resource to filter the action logs.
  'actionfilter': "actionfilter_example", // String | The action to filter the action logs.
  'argument': "argument_example" // String | The id of the entity that was the argument of the executed action.
};
apiInstance.actionloglist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **user** | [**String**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the logs. | [optional] 
 **resource** | **String**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **String**| The action to filter the action logs. | [optional] 
 **argument** | **String**| The id of the entity that was the argument of the executed action. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionpackassign

> actionpackassign(token, pack, itemsdata, opts)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let pack = null; // String | The id of the action pack to assign.
let itemsdata = true; // Boolean | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
let opts = {
  'assignee': null, // String | The assignee of the pack.
  'group': null, // String | The group to assign the pack.
  'notes': "notes_example" // String | The assignment's notes.
};
apiInstance.actionpackassign(token, pack, itemsdata, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **pack** | [**String**](.md)| The id of the action pack to assign. | 
 **itemsdata** | **Boolean**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **assignee** | [**String**](.md)| The assignee of the pack. | [optional] 
 **group** | [**String**](.md)| The group to assign the pack. | [optional] 
 **notes** | **String**| The assignment&#39;s notes. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionpackdelete

> actionpackdelete(token, id)

Delete an action item pack

Allows the user to delete an action item pack.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the action pack to delete.
apiInstance.actionpackdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action pack to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionpackget

> actionpackget(token, id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the action pack to get.
apiInstance.actionpackget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action pack to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionpacklist

> actionpacklist(token, from, count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.actionpacklist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionpacksave

> actionpacksave(opts)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.actionpacksave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actiontypedelete

> actiontypedelete(token, id)

Delete an action item type

Allows the user to delete an action item type.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the action type to delete.
apiInstance.actiontypedelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action type to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actiontypeget

> actiontypeget(token, id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the action type to get.
apiInstance.actiontypeget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action type to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actiontypelist

> actiontypelist(token, from, count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.actiontypelist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actiontypesave

> actiontypesave(opts)

Create or edit an action item type

Allows the user to dit an action item type.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.actiontypesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## adhocquerycheckexecution

> adhocquerycheckexecution(token, id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query&#39;s execution page.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the ad hoc query execution to be checked.
apiInstance.adhocquerycheckexecution(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the ad hoc query execution to be checked. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquerydelete

> adhocquerydelete(token, id)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the ad hoc query to delete.
apiInstance.adhocquerydelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the ad hoc query to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocqueryexecute

> adhocqueryexecute(token, opts)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'id': null, // String | The id of the query to execute.
  'query': "query_example" // String | The query to execute.
};
apiInstance.adhocqueryexecute(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the query to execute. | [optional] 
 **query** | **String**| The query to execute. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocqueryget

> adhocqueryget(token, id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the query to get.
apiInstance.adhocqueryget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the query to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquerygetschema

> adhocquerygetschema(token)

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.adhocquerygetschema(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquerylist

> adhocquerylist(token, from, count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.adhocquerylist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquerylistexecutions

> adhocquerylistexecutions(token, from, count, opts)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'query': null // String | The first record to return.
};
apiInstance.adhocquerylistexecutions(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **query** | [**String**](.md)| The first record to return. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquerysave

> adhocquerysave(opts)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.adhocquerysave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## adhocquerystopexecution

> adhocquerystopexecution(token, id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the ad hoc query execution to be stopped.
apiInstance.adhocquerystopexecution(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the ad hoc query execution to be stopped. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocreportsreqaccess

> adhocreportsreqaccess(token)

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, &#39;Request Access&#39; under Institutional Research -&gt; Ad-hoc Reports

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.adhocreportsreqaccess(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationcheckunknownuser

> advancedstationcheckunknownuser(station, user, location)

Check whether the user is known by the system.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
let location = null; // String | The id of the location the user picked.
apiInstance.advancedstationcheckunknownuser(station, user, location, (error, data, response) => {
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


## advancedstationcheckuserrole

> advancedstationcheckuserrole(station, user, location)

Check whether the user is a staff member, an attendee or both.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
let location = null; // String | The id of the location the user picked.
apiInstance.advancedstationcheckuserrole(station, user, location, (error, data, response) => {
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


## advancedstationcreateuser

> advancedstationcreateuser(station, user, location, firstname, lastname, email, opts)

Creates a user via a sign-in station.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user to create.
let location = null; // String | The id of the location the user picked.
let firstname = "firstname_example"; // String | The first name of the user to create.
let lastname = "lastname_example"; // String | The last name of the user to create.
let email = "email_example"; // String | The email of the user to create.
let opts = {
  'middlename': "middlename_example" // String | The middle name of the user to create.
};
apiInstance.advancedstationcreateuser(station, user, location, firstname, lastname, email, opts, (error, data, response) => {
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


## advancedstationgetevents

> advancedstationgetevents(station, location, user)

Gets the courses available for a specific location and a specific student.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let location = null; // String | The id of the location the student picked.
let user = "user_example"; // String | The card of the user.
apiInstance.advancedstationgetevents(station, location, user, (error, data, response) => {
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


## advancedstationgetinfo

> advancedstationgetinfo(id, opts)

Gets the info to display in the sign-in station by it&#39;s ID.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let id = null; // String | The id of the sign-in station to get.
let opts = {
  'event': null // String | The id of the event (or session), to override the scheduled one.
};
apiInstance.advancedstationgetinfo(id, opts, (error, data, response) => {
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


## advancedstationgetlocations

> advancedstationgetlocations(station, user)

Gets the locations available in a sign-in station.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station whose locations have to be returned.
let user = "user_example"; // String | The card of the user.
apiInstance.advancedstationgetlocations(station, user, (error, data, response) => {
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


## advancedstationgetlogstaff

> advancedstationgetlogstaff(station, attendancelog, opts)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let attendancelog = null; // String | The id of the attendance log to filter the staff members.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.advancedstationgetlogstaff(station, attendancelog, opts, (error, data, response) => {
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


## advancedstationgetroles

> advancedstationgetroles(station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let signinrole = "signinrole_example"; // String | Specifies how the user is signing-in.
let user = "user_example"; // String | The card of the user.
let location = null; // String | The id of the location the user picked.
apiInstance.advancedstationgetroles(station, signinrole, user, location, (error, data, response) => {
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


## advancedstationgetservices

> advancedstationgetservices(station, location, user)

Gets the services available for a specific location.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let location = null; // String | The id of the location the student picked.
let user = "user_example"; // String | The card of the user.
apiInstance.advancedstationgetservices(station, location, user, (error, data, response) => {
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


## advancedstationgetstaff

> advancedstationgetstaff(station, locationid, user, opts)

Gets the staff/tutors available for a specific location, course and service.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let locationid = null; // String | The id of the location the student picked.
let user = "user_example"; // String | The card of the user.
let opts = {
  'services': "services_example", // String | The list of services selected by the user, in JSON format.
  'eventid': null, // String | The ID of the event selected.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.advancedstationgetstaff(station, locationid, user, opts, (error, data, response) => {
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


## advancedstationissignedin

> advancedstationissignedin(station, time, user, opts)

Gets whether a user is signed-in or not.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let time = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time of the swipe.
let user = "user_example"; // String | The card of the user.
let opts = {
  'location': null // String | The id of the location the user picked.
};
apiInstance.advancedstationissignedin(station, time, user, opts, (error, data, response) => {
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


## advroleaddmissing

> advroleaddmissing(token, roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let roles = "roles_example"; // String | CSV list of the role ids to check
let permissions = "permissions_example"; // String | CSV list of the permissions to check
apiInstance.advroleaddmissing(token, roles, permissions, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **roles** | **String**| CSV list of the role ids to check | 
 **permissions** | **String**| CSV list of the permissions to check | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolecheckperm

> advrolecheckperm(token, roles, permissions)

Checks the permissions are assigned for the given roles

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let roles = "roles_example"; // String | CSV list of the role ids to check
let permissions = "permissions_example"; // String | CSV list of the permissions to check
apiInstance.advrolecheckperm(token, roles, permissions, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **roles** | **String**| CSV list of the role ids to check | 
 **permissions** | **String**| CSV list of the permissions to check | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroledelete

> advroledelete(token, id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the location to delete.
apiInstance.advroledelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the location to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroledeletemapping

> advroledeletemapping(token, map, roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let map = "map_example"; // String | The map name to save the role.
let roleid = null; // String | The id of the role.
apiInstance.advroledeletemapping(token, map, roleid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **map** | **String**| The map name to save the role. | 
 **roleid** | [**String**](.md)| The id of the role. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleget

> advroleget(token, id)

View details of a role

Allows the user to view a role and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the location to get.
apiInstance.advroleget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the location to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolelist

> advrolelist(token, opts)

Lists the roles for the current account

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'includepolicies': true, // Boolean | True to include the policies, defaults to false.
  'includeinternal': true, // Boolean | True to include the internal roles too.
  'name': "name_example" // String | Filter by name of the role.
};
apiInstance.advrolelist(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **includepolicies** | **Boolean**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **Boolean**| True to include the internal roles too. | [optional] 
 **name** | **String**| Filter by name of the role. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolelistmaps

> advrolelistmaps(token, roleid)

Lists the maps a roles is mapped to

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let roleid = null; // String | The id of the role to list the maps.
apiInstance.advrolelistmaps(token, roleid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **roleid** | [**String**](.md)| The id of the role to list the maps. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolelistrolesmapped

> advrolelistrolesmapped(token, opts)

Lists the roles mappings

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'map': "map_example" // String | List only the roles in the specified map.
};
apiInstance.advrolelistrolesmapped(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **map** | **String**| List only the roles in the specified map. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolelisttemplates

> advrolelisttemplates(token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.advrolelisttemplates(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolesave

> advrolesave(opts)

Create or edit a role

Allows the user to create or edit a role&#39;s permissions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.advrolesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## advrolesavemapping

> advrolesavemapping(opts)

Saves a role mapping

Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.advrolesavemapping(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## advrolesuserlist

> advrolesuserlist(token, from, count, opts)

List users. Alias to user.list, use that one instead.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'roleid': null, // String | The id of the role to filter users by, or empty to return all users.
  'onlywithoutcard': "onlywithoutcard_example", // String | If is 1 then only the users without a card are returned, otherwise all users are returned.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.advrolesuserlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **roleid** | [**String**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleuserupgrade

> advroleuserupgrade(token, userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | Id of the user to upgrade
let roleid = null; // String | Id of the role to add
apiInstance.advroleuserupgrade(token, userid, roleid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| Id of the user to upgrade | 
 **roleid** | [**String**](.md)| Id of the role to add | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentcancel

> appointmentcancel(token, id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to cancel.
apiInstance.appointmentcancel(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to cancel. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentcheckisvalid

> appointmentcheckisvalid(token, id, opts)

Check if an appointment is valid or not

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to check.
let opts = {
  'editing': true // Boolean | Specifies whether the check is for a new appointment or an existing one.
};
apiInstance.appointmentcheckisvalid(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to check. | 
 **editing** | **Boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmenteditanyway

> appointmenteditanyway(token, id, attendee, staff, location, start, end, opts)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
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
apiInstance.appointmenteditanyway(token, id, attendee, staff, location, start, end, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
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

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmenteditpresence

> appointmenteditpresence(token, id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to edit its presence.
let showedup = true; // Boolean | Specifies whether the attendee was showed-up or not in the appointment.
apiInstance.appointmenteditpresence(token, id, showedup, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **Boolean**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentfindallstaffslots

> appointmentfindallstaffslots(token, starttime, endtime, serviceids, locationid, opts)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let serviceids = "serviceids_example"; // String | CSV list of the service Ids to filter by.
let locationid = null; // String | The id of the service to filter by.
let opts = {
  'eventid': null, // String | The id of the event to filter by.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.appointmentfindallstaffslots(token, starttime, endtime, serviceids, locationid, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **starttime** | **Date**| The start time of the range to look for slots. | 
 **endtime** | **Date**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | 
 **locationid** | [**String**](.md)| The id of the service to filter by. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentfindslots

> appointmentfindslots(token, staffid, starttime, endtime, serviceids, opts)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let staffid = null; // String | The id of the staff to filter by.
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let serviceids = "serviceids_example"; // String | CSV list of the service Ids to filter by.
let opts = {
  'eventid': null, // String | The id of the event to filter by.
  'locationid': null // String | The id of the service to filter by.
};
apiInstance.appointmentfindslots(token, staffid, starttime, endtime, serviceids, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **staffid** | [**String**](.md)| The id of the staff to filter by. | 
 **starttime** | **Date**| The start time of the range to look for slots. | 
 **endtime** | **Date**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentfindstaff

> appointmentfindstaff(token, serviceids, starttime, endtime, opts)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceids = "serviceids_example"; // String | CSV list of the service ids to filter by.
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let opts = {
  'eventid': null, // String | The id of the event to filter by.
  'locationid': null, // String | The id of the service to filter by.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.appointmentfindstaff(token, serviceids, starttime, endtime, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceids** | **String**| CSV list of the service ids to filter by. | 
 **starttime** | **Date**| The start time of the range to look for slots. | 
 **endtime** | **Date**| The end time of the range to look for slots. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentget

> appointmentget(token, id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to get.
apiInstance.appointmentget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentgetcurrent

> appointmentgetcurrent(station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
let location = null; // String | The id of the location where the user wants to sign-in.
apiInstance.appointmentgetcurrent(station, user, location, (error, data, response) => {
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


## appointmentgetlocations

> appointmentgetlocations(token, serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceid = null; // String | The id of the service to get its locations.
apiInstance.appointmentgetlocations(token, serviceid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentlist

> appointmentlist(token, from, count, opts)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the appointments.
  'enddate': new Date("2013-10-20T19:20:30+01:00"), // Date | The end date of the period to filter the appointments.
  'userid': null // String | The attendee id to filter the appointments.
};
apiInstance.appointmentlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **startdate** | **Date**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**String**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentlistmine

> appointmentlistmine(token, opts)

View all my upcoming appointments

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'start': new Date("2013-10-20T19:20:30+01:00"), // Date | If specified, only appointments that start after the specified date will be returned.
  'modifiedafter': new Date("2013-10-20T19:20:30+01:00") // Date | If specified, only appointments modified after the specified date will be returned.
};
apiInstance.appointmentlistmine(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **start** | **Date**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **Date**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentlistupcoming

> appointmentlistupcoming(token, opts)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'start': new Date("2013-10-20T19:20:30+01:00"), // Date | If specified, only appointments that start after the specified date will be returned.
  'modifiedafter': new Date("2013-10-20T19:20:30+01:00") // Date | If specified, only appointments modified after the specified date will be returned.
};
apiInstance.appointmentlistupcoming(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **start** | **Date**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **Date**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentrescheduleoutlook

> appointmentrescheduleoutlook(token, id, start, end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to edit.
let start = new Date("2013-10-20T19:20:30+01:00"); // Date | The appointment's start date & time.
let end = new Date("2013-10-20T19:20:30+01:00"); // Date | The appointment's end date & time.
apiInstance.appointmentrescheduleoutlook(token, id, start, end, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to edit. | 
 **start** | **Date**| The appointment&#39;s start date &amp; time. | 
 **end** | **Date**| The appointment&#39;s end date &amp; time. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentrestore

> appointmentrestore(token, id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to restore.
apiInstance.appointmentrestore(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to restore. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentrestoreanyway

> appointmentrestoreanyway(token, id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to restore.
apiInstance.appointmentrestoreanyway(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to restore. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentsave

> appointmentsave(opts)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.appointmentsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## appointmentsetasvalid

> appointmentsetasvalid(token, id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to set as valid.
apiInstance.appointmentsetasvalid(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to set as valid. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentsuggestlocations

> appointmentsuggestlocations(token)

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.appointmentsuggestlocations(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentsuggestservices

> appointmentsuggestservices(token)

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.appointmentsuggestservices(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentvoid

> appointmentvoid(token, id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student&#39;s restrictions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the appointment to cancel.
apiInstance.appointmentvoid(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to cancel. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appsharegetphone

> appsharegetphone(token)

Gets the phone number of the current user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.appsharegetphone(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appsharesendtext

> appsharesendtext(token, opts)

Sends an SMS with the link to the app

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'phonenumber': "phonenumber_example" // String | Phone number to where to send the link. Leave empty to the number on file.
};
apiInstance.appsharesendtext(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **phonenumber** | **String**| Phone number to where to send the link. Leave empty to the number on file. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentdelete

> attendancelogcommentdelete(token, id)

Delete a comment on an attendance log

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the attendance log comment to delete.
apiInstance.attendancelogcommentdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log comment to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentget

> attendancelogcommentget(token, id)

View a comment on an attendance log

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the comment to get.
apiInstance.attendancelogcommentget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the comment to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentlist

> attendancelogcommentlist(attendancelog, opts)

View all the comments on a specific attendance log

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let attendancelog = null; // String | The id of the attendance log whose comments have to be retrieved.
let opts = {
  'token': "token_example" // String | The authentication token.
};
apiInstance.attendancelogcommentlist(attendancelog, opts, (error, data, response) => {
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
 **attendancelog** | [**String**](.md)| The id of the attendance log whose comments have to be retrieved. | 
 **token** | **String**| The authentication token. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentsave

> attendancelogcommentsave(opts)

Save a comment on an attendance log

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.attendancelogcommentsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## attendancelogdelete

> attendancelogdelete(token, id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the attendance log to delete.
apiInstance.attendancelogdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogget

> attendancelogget(token, id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the attendance log to get.
apiInstance.attendancelogget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendanceloggetchangehistory

> attendanceloggetchangehistory(token, id)

Search and view details of an attendance log&#39;s swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the attendance log to get.
apiInstance.attendanceloggetchangehistory(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendanceloglist

> attendanceloglist(from, count, opts)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'token': "token_example", // String | The authentication token.
  'filter': "filter_example", // String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
  'userid': null // String | The user ID of the user to get the logs.
};
apiInstance.attendanceloglist(from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**String**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendanceloglistmine

> attendanceloglistmine(from, count, opts)

Gets the attendance logs of the current user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'token': "token_example", // String | The authentication token.
  'filter': "filter_example" // String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
};
apiInstance.attendanceloglistmine(from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogliststaff

> attendancelogliststaff(from, count, opts)

Gets the attendance logs that the current user is involved in as staff

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'token': "token_example", // String | The authentication token.
  'filter': "filter_example" // String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
};
apiInstance.attendancelogliststaff(from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogsave

> attendancelogsave(opts)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.attendancelogsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## attendancelogsignout

> attendancelogsignout(token, opts)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who&#39;s In page.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'id': null, // String | The id of the attendance log to sign-out.
  'location': null, // String | The id of the location to filter the users to sign out.
  'event': null, // String | The id of the event to filter the users to sign out.
  'datetime': new Date("2013-10-20T19:20:30+01:00") // Date | Specifies the date and time when the specified logs have to be signed out.
};
apiInstance.attendancelogsignout(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**String**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **event** | [**String**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **Date**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogwhosin

> attendancelogwhosin(from, count, opts)

View who&#39;s in a location

Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'token': "token_example", // String | The authentication token.
  'location': null, // String | The id of the location to search for users that are in.
  'event': null, // String | The id of the event to search for users that are in.
  'sorting': "sorting_example", // String | Field to sort by. Either first-name, last-name or sign-in-time.
  'roles': "roles_example", // String | The comma-separated list of ids of the roles to search for users that are in.
  'photosize': 56, // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  'extensions': "extensions_example", // String | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
  '_export': true // Boolean | True to export the results as CSV
};
apiInstance.attendancelogwhosin(from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **location** | [**String**](.md)| The id of the location to search for users that are in. | [optional] 
 **event** | [**String**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **String**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **String**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **_export** | **Boolean**| True to export the results as CSV | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancerestrictiondelete

> attendancerestrictiondelete(token, id)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the restriction to delete.
apiInstance.attendancerestrictiondelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the restriction to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancerestrictionget

> attendancerestrictionget(token, id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the restriction to get.
apiInstance.attendancerestrictionget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the restriction to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancerestrictionlist

> attendancerestrictionlist(token, from, count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.attendancerestrictionlist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancerestrictionsave

> attendancerestrictionsave(opts)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.attendancerestrictionsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## beacondelete

> beacondelete(token, id)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the beacon to delete.
apiInstance.beacondelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the beacon to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacondisable

> beacondisable(token)

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.beacondisable(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconget

> beaconget(token, id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the beacon to get.
apiInstance.beaconget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the beacon to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacongetlocations

> beacongetlocations(token, beacons)

Get the sign-in stations assigned to specific beacons.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let beacons = "beacons_example"; // String | A JSON array containg the beacons data (region, minor and major) values.
apiInstance.beacongetlocations(token, beacons, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacongetstationlocation

> beacongetstationlocation(token, station, location)

Get the location settings in the specified sign-in station.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let station = null; // String | The id of the sign-in station whose location information has to be retrieved.
let location = null; // String | The id of the location whose information has to be retrieved.
apiInstance.beacongetstationlocation(token, station, location, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **station** | [**String**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
 **location** | [**String**](.md)| The id of the location whose information has to be retrieved. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacongetuuid

> beacongetuuid(token)

View the identifier for the account&#39;s beacon region (for sign-in stations).

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.beacongetuuid(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconlist

> beaconlist(token, from, count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.beaconlist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconlistprofiles

> beaconlistprofiles(token)

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.beaconlistprofiles(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconresetuuid

> beaconresetuuid(token)

Generate or reset the identifier for the account&#39;s beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.beaconresetuuid(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsave

> beaconsave(opts)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.beaconsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## beaconscanlocations

> beaconscanlocations(token, beacons)

Check if there&#39;s location available to sign-in / out.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let beacons = "beacons_example"; // String | A JSON array containg the beacons data (region, minor and major) values.
apiInstance.beaconscanlocations(token, beacons, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsetuuid

> beaconsetuuid(token, id)

Set the identifier for the account&#39;s beacon region (for sign-in stations).

Allows the user to set the identifier for the account&#39;s beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The custom region UUID.
apiInstance.beaconsetuuid(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The custom region UUID. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsilentregions

> beaconsilentregions(token)

View all the beacon regions defined for silent tracking

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.beaconsilentregions(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsilentsignin

> beaconsilentsignin(token, uuid)

Sign-in silently from the location specified by a beacon

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let uuid = null; // String | The id of the region the user is in.
apiInstance.beaconsilentsignin(token, uuid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **uuid** | [**String**](.md)| The id of the region the user is in. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsilentsignout

> beaconsilentsignout(token, uuid)

Sign-out silently from the location specified by a beacon

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let uuid = null; // String | The id of the region the user has left.
apiInstance.beaconsilentsignout(token, uuid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **uuid** | [**String**](.md)| The id of the region the user has left. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## bgjobgetstatus

> bgjobgetstatus(token, opts)

Get background job status

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'jobid': null, // String | The ID of the job to get the status. 10 most recent will be returned if not specified.
  'jobtype': "jobtype_example" // String | The job type to filter by.
};
apiInstance.bgjobgetstatus(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **jobid** | [**String**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **String**| The job type to filter by. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## callExport

> callExport(token, exporttype, exportformat, opts)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let exporttype = "exporttype_example"; // String | What to export.
let exportformat = "exportformat_example"; // String | The format of the resulting file. Valid types are CSV, HTML, XLS.
let opts = {
  'filters': "filters_example" // String | Pipe separated filters for the export, eg: aaa=val|bbb=val|...
};
apiInstance.callExport(token, exporttype, exportformat, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **exporttype** | **String**| What to export. | 
 **exportformat** | **String**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **filters** | **String**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## callImport

> callImport(token, importtype, upload, opts)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let importtype = "importtype_example"; // String | The kind of data that is being uploaded.
let upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
let opts = {
  'filename': "filename_example", // String | The local name of the uploaded file. For later reference.
  'parameters': "parameters_example" // String | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.
};
apiInstance.callImport(token, importtype, upload, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **importtype** | **String**| The kind of data that is being uploaded. | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 
 **parameters** | **String**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## captchagetchallenge

> captchagetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
apiInstance.captchagetchallenge((error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## captchagetimage

> captchagetimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let captchatoken = "captchatoken_example"; // String | The captcha token or ID returned by the captcha.getchallenge action
apiInstance.captchagetimage(captchatoken, (error, data, response) => {
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
 **captchatoken** | **String**| The captcha token or ID returned by the captcha.getchallenge action | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## changelog

> changelog(token)

Get the application change log

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.changelog(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## clientget

> clientget(token, client, opts)

Get client

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let client = "client_example"; // String | The unique id of the client.
let opts = {
  'clientname': "clientname_example" // String | The custom name of the client.
};
apiInstance.clientget(token, client, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **client** | **String**| The unique id of the client. | 
 **clientname** | **String**| The custom name of the client. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## clientlist

> clientlist(token, from, count)

Gets the clients of the specified conference

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.clientlist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## clientsave

> clientsave(opts)

Saves a client

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.clientsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## clientsendmessage

> clientsendmessage(token, uniqueclientid, message)

Send a message to a client

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let uniqueclientid = null; // String | The unique id of the client.
let message = "message_example"; // String | The body of the message to send.
apiInstance.clientsendmessage(token, uniqueclientid, message, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **uniqueclientid** | [**String**](.md)| The unique id of the client. | 
 **message** | **String**| The body of the message to send. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## communityinvite

> communityinvite(token)

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.communityinvite(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## communityjoin

> communityjoin(token)

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.communityjoin(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compasscategorydelete

> compasscategorydelete(token, id)

Delete a compass category

Allows the user to delete an existing compass category.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the category to delete.
apiInstance.compasscategorydelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the category to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compasscategoryget

> compasscategoryget(token, id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the category to get.
apiInstance.compasscategoryget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the category to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compasscategorylist

> compasscategorylist(token, opts)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'from': 56, // Number | The first record to return.
  'count': 56, // Number | The max number of records to return.
  'onlywithservices': true // Boolean | Specified whether only categories with services are returned or all.
};
apiInstance.compasscategorylist(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | [optional] 
 **count** | **Number**| The max number of records to return. | [optional] 
 **onlywithservices** | **Boolean**| Specified whether only categories with services are returned or all. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compasscategorysave

> compasscategorysave(opts)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.compasscategorysave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## compassservicelist

> compassservicelist(token, opts)

View all the services added to the compass

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'category': null // String | The id of the category to filter the services.
};
apiInstance.compassservicelist(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **category** | [**String**](.md)| The id of the category to filter the services. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compassservicelistlocations

> compassservicelistlocations(token, serviceid)

View all the locations where a service added to the compass is available

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceid = null; // String | The id of the service to get its locations.
apiInstance.compassservicelistlocations(token, serviceid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabdeletecomputer

> computerlabdeletecomputer(token, id)

Delete a computer

Allows the user to delete an existing computer.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = "id_example"; // String | The unique device id of the computer to delete.
apiInstance.computerlabdeletecomputer(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | **String**| The unique device id of the computer to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabgetcomputer

> computerlabgetcomputer(token, id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = "id_example"; // String | The unique device id of the computer to get.
apiInstance.computerlabgetcomputer(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | **String**| The unique device id of the computer to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabgetsettings

> computerlabgetsettings(id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let id = null; // String | The id of the computer lab/location.
apiInstance.computerlabgetsettings(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the computer lab/location. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabissignedin

> computerlabissignedin(station, user)

Gets whether a user is signed-in or not.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
apiInstance.computerlabissignedin(station, user, (error, data, response) => {
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

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlablistcomputers

> computerlablistcomputers(token, from, count, opts)

View a list of computers

Allows the user to view the list of all computers.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'location': null, // String | The id of the location whose computers have to be returned.
  'freeonly': true // Boolean | If true, only free computers will be returned.
};
apiInstance.computerlablistcomputers(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **location** | [**String**](.md)| The id of the location whose computers have to be returned. | [optional] 
 **freeonly** | **Boolean**| If true, only free computers will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlablistlabs

> computerlablistlabs(token)

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.computerlablistlabs(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabliststations

> computerlabliststations(token)

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.computerlabliststations(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabsavecomputer

> computerlabsavecomputer(opts)

Create or edit a computer

Allows the user to create or edit a computer.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.computerlabsavecomputer(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## computerlabsavesettings

> computerlabsavesettings(opts)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.computerlabsavesettings(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## computerlabsaveswipe

> computerlabsaveswipe(opts)

Save a new swipe from a computer in a computer lab.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.computerlabsaveswipe(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## deadendrecordingdelete

> deadendrecordingdelete(token, hierarchykey)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let hierarchykey = "hierarchykey_example"; // String | The hierarchy key of the record to delete.
apiInstance.deadendrecordingdelete(token, hierarchykey, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **hierarchykey** | **String**| The hierarchy key of the record to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## deadendrecordinglist

> deadendrecordinglist(token)

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.deadendrecordinglist(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## deadendrecordinglistcomments

> deadendrecordinglistcomments(token, hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let hierarchykey = "hierarchykey_example"; // String | The hierarchy key of the record to get the feedback.
apiInstance.deadendrecordinglistcomments(token, hierarchykey, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **hierarchykey** | **String**| The hierarchy key of the record to get the feedback. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## deadendrecordingsave

> deadendrecordingsave(opts)

Saves a dead-end record

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.deadendrecordingsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## departmentdelete

> departmentdelete(token, id)

Delete a college department

Allows the user to delete an existing college department.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the department to delete.
apiInstance.departmentdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the department to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## departmentget

> departmentget(token, id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the department to get.
apiInstance.departmentget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the department to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## departmentlist

> departmentlist(token, from, count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.departmentlist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## departmentsave

> departmentsave(opts)

Create or edit a college department

Allows the user to create or edit a college department.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.departmentsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## doc

> doc(opts)

Get the documentation

Retrieves the list of actions available in the system.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'excludeanonymous': true // Boolean | If true it excludes the anonymous actions from the returned list.
};
apiInstance.doc(opts, (error, data, response) => {
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
 **excludeanonymous** | **Boolean**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## easyloginaddbgimage

> easyloginaddbgimage(token, upload, filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
let filename = "filename_example"; // String | The original filename, needed to process the file.
apiInstance.easyloginaddbgimage(token, upload, filename, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The original filename, needed to process the file. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventchecksessions

> eventchecksessions(token, eventid, autorepair)

Edit an event&#39;s sessions according to their schedule

Allows the user to edit event sessions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The id of the event to check.
let autorepair = true; // Boolean | True to automatically fix the invalid sessions.
apiInstance.eventchecksessions(token, eventid, autorepair, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event to check. | 
 **autorepair** | **Boolean**| True to automatically fix the invalid sessions. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventdelete

> eventdelete(token, id)

Delete a course

Allows the user to delete an existing course.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the event to delete.
apiInstance.eventdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the event to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventget

> eventget(token, id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the event to get.
apiInstance.eventget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the event to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventgetsessionsbydate

> eventgetsessionsbydate(token, opts)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'location': null, // String | The location to filter the events.
  '_date': new Date("2013-10-20T19:20:30+01:00"), // Date | The date to filter the events. Today will be used if this parameter is omitted.
  'type': "type_example" // String | Type of event to list.
};
apiInstance.eventgetsessionsbydate(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **location** | [**String**](.md)| The location to filter the events. | [optional] 
 **_date** | **Date**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **String**| Type of event to list. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventlist

> eventlist(token, from, count, opts)

View a list of courses

Allows the user to view the full list of courses.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = "from_example"; // String | The first record to return.
let count = "count_example"; // String | The max number of records to return.
let opts = {
  'summaryonly': true, // Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  'termid': null // String | Id of the term to list the events. Null to list all events.
};
apiInstance.eventlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **String**| The first record to return. | 
 **count** | **String**| The max number of records to return. | 
 **summaryonly** | **Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**String**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventlistregistered

> eventlistregistered(token, from, count, opts)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = "from_example"; // String | The first record to return.
let count = "count_example"; // String | The max number of records to return.
let opts = {
  'summaryonly': true, // Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  'termid': null // String | Id of the term to list the events. Null to list all events.
};
apiInstance.eventlistregistered(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **String**| The first record to return. | 
 **count** | **String**| The max number of records to return. | 
 **summaryonly** | **Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**String**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregaddme

> eventregaddme(token, eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The id of the event.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregaddme(token, eventid, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregaddmetoall

> eventregaddmetoall(token, listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregaddmetoall(token, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregaddmetogroup

> eventregaddmetogroup(token, codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let codegroup = "codegroup_example"; // String | The code used to group events.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregaddmetogroup(token, codegroup, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **codegroup** | **String**| The code used to group events. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregadduser

> eventregadduser(token, userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to add.
let eventid = null; // String | The id of the event.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregadduser(token, userid, eventid, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregaddusertoall

> eventregaddusertoall(token, userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to add.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregaddusertoall(token, userid, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregaddusertogroup

> eventregaddusertogroup(token, userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to add.
let codegroup = "codegroup_example"; // String | The code used to group events.
let listname = "listname_example"; // String | The name of the list where the user has to be registered.
apiInstance.eventregaddusertogroup(token, userid, codegroup, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **codegroup** | **String**| The code used to group events. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreggetevents

> eventreggetevents(token, userid, listname, opts)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The user id to list events.
let listname = "listname_example"; // String | The name of the list where the user is registered.
let opts = {
  'termid': null, // String | The term id to list events.
  'namefilter': "namefilter_example" // String | The value used to filter the events by name.
};
apiInstance.eventreggetevents(token, userid, listname, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The user id to list events. | 
 **listname** | **String**| The name of the list where the user is registered. | 
 **termid** | [**String**](.md)| The term id to list events. | [optional] 
 **namefilter** | **String**| The value used to filter the events by name. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreggetgroups

> eventreggetgroups(token, userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The user id to list events.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventreggetgroups(token, userid, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The user id to list events. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreggetmyevents

> eventreggetmyevents(token, listname, opts)

View the event registrations of the current user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let listname = "listname_example"; // String | The name of the list where the user is registered.
let opts = {
  'termid': null, // String | The term id to list events.
  'namefilter': "namefilter_example" // String | The value used to filter the events by name.
};
apiInstance.eventreggetmyevents(token, listname, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list where the user is registered. | 
 **termid** | [**String**](.md)| The term id to list events. | [optional] 
 **namefilter** | **String**| The value used to filter the events by name. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreggetmygroups

> eventreggetmygroups(token, listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventreggetmygroups(token, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreggetusers

> eventreggetusers(token, eventid, listname, opts)

View course registration

Allows the user to view all users registered for an individual course.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The event id to list users.
let listname = "listname_example"; // String | The name of the list to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.eventreggetusers(token, eventid, listname, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The event id to list users. | 
 **listname** | **String**| The name of the list to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreggetusersfromgroup

> eventreggetusersfromgroup(token, codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let codegroup = null; // String | The code group to list users.
let listname = "listname_example"; // String | The name of the list to get.
apiInstance.eventreggetusersfromgroup(token, codegroup, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **codegroup** | [**String**](.md)| The code group to list users. | 
 **listname** | **String**| The name of the list to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreggetuserstoall

> eventreggetuserstoall(token, listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let listname = "listname_example"; // String | The name of the list to get.
apiInstance.eventreggetuserstoall(token, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregremoveme

> eventregremoveme(token, eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The id of the event.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregremoveme(token, eventid, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregremovemefromall

> eventregremovemefromall(token, listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregremovemefromall(token, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregremovemefromgroup

> eventregremovemefromgroup(token, codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let codegroup = null; // String | The code group of the events/courses.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregremovemefromgroup(token, codegroup, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **codegroup** | [**String**](.md)| The code group of the events/courses. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregremoveuser

> eventregremoveuser(token, userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course&#39;s registration.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to remove.
let eventid = null; // String | The id of the event.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregremoveuser(token, userid, eventid, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregremoveuserfromall

> eventregremoveuserfromall(token, userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to remove.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregremoveuserfromall(token, userid, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregremoveuserfromgroup

> eventregremoveuserfromgroup(token, userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to remove.
let codegroup = null; // String | The code group of the events/courses.
let listname = "listname_example"; // String | The name of the list where the user is registered.
apiInstance.eventregremoveuserfromgroup(token, userid, codegroup, listname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **codegroup** | [**String**](.md)| The code group of the events/courses. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventsave

> eventsave(opts)

Create or edit a course

Allows the user to create or edit a course.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.eventsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## eventsearchgroup

> eventsearchgroup(token, query)

Searches for the available event groups

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let query = null; // String | Query to search event groups.
apiInstance.eventsearchgroup(token, query, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **query** | [**String**](.md)| Query to search event groups. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## exportlisttypes

> exportlisttypes(token)

Lists available export types

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.exportlisttypes(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## featurelist

> featurelist(token)

Lists the available features.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.featurelist(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## holidaylist

> holidaylist(token, term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let term = null; // String | The term to get holidays from.
apiInstance.holidaylist(token, term, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **term** | [**String**](.md)| The term to get holidays from. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## holidaysave

> holidaysave(opts)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.holidaysave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## holidaysuggest

> holidaysuggest(token, term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let term = null; // String | The term to get holidays from.
apiInstance.holidaysuggest(token, term, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **term** | [**String**](.md)| The term to get holidays from. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## importlisttypes

> importlisttypes(token)

Lists available import types

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.importlisttypes(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactiondelete

> interactiondelete(token, id)

Delete an interaction

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the interaction to delete.
apiInstance.interactiondelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the interaction to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionfeed

> interactionfeed(token, from, count, opts)

Get the interactions feed

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | If set, only interactions that happened after this date are returned.
  '_public': true, // Boolean | Specifies whether to return public or private interactions.
  'contexttype': "contexttype_example", // String | The type of the context of the interactions to return.
  'contextid': null, // String | The id of the context of the interactions to return.
  'types': "types_example", // String | The  comma separated types of the interactions to return.
  'photosize': 56, // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  'showdefaultphoto': true, // Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
  'orderdescending': true // Boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.
};
apiInstance.interactionfeed(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **startdate** | **Date**| If set, only interactions that happened after this date are returned. | [optional] 
 **_public** | **Boolean**| Specifies whether to return public or private interactions. | [optional] 
 **contexttype** | **String**| The type of the context of the interactions to return. | [optional] 
 **contextid** | [**String**](.md)| The id of the context of the interactions to return. | [optional] 
 **types** | **String**| The  comma separated types of the interactions to return. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 
 **orderdescending** | **Boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionget

> interactionget(token, id, opts)

View an interaction

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = "id_example"; // String | The id of the interaction.
let opts = {
  'thumbnailmediasize': 56, // Number | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.interactionget(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | **String**| The id of the interaction. | 
 **thumbnailmediasize** | **Number**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionlistprivatesummary

> interactionlistprivatesummary(token, opts)

Get current user&#39;s latest private interactions

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'photosize': 56, // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  'showdefaultphoto': true // Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
};
apiInstance.interactionlistprivatesummary(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionsave

> interactionsave(opts)

Save an interaction

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.interactionsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## licenseacceptagreement

> licenseacceptagreement(token)

Accept the license agreement

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.licenseacceptagreement(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## licensegetagreementstatus

> licensegetagreementstatus(token)

Check if license agreement has been accepted

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.licensegetagreementstatus(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## licensegetcurrent

> licensegetcurrent(opts)

Gets the current license information

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'token': "token_example" // String | The authentication token.
};
apiInstance.licensegetcurrent(opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## licenserenew

> licenserenew(token, email, phonenumber, opts)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let email = "email_example"; // String | The e-mail of the user sending the request.
let phonenumber = "phonenumber_example"; // String | The phone number of the user sending the request.
let opts = {
  'jobtitle': "jobtitle_example", // String | The job title of the user sending the request.
  'institution': "institution_example", // String | The institution of the user sending the request.
  'comments': "comments_example" // String | Comments entered by the user sending the request.
};
apiInstance.licenserenew(token, email, phonenumber, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **email** | **String**| The e-mail of the user sending the request. | 
 **phonenumber** | **String**| The phone number of the user sending the request. | 
 **jobtitle** | **String**| The job title of the user sending the request. | [optional] 
 **institution** | **String**| The institution of the user sending the request. | [optional] 
 **comments** | **String**| Comments entered by the user sending the request. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## likedelete

> likedelete(token, interactionid)

Delete a like

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let interactionid = null; // String | The id of the interaction to unlike.
apiInstance.likedelete(token, interactionid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **interactionid** | [**String**](.md)| The id of the interaction to unlike. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## likelist

> likelist(token, interactionid, opts)

View all the likes associated to a target

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let interactionid = null; // String | The id of the interaction to unlike.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.likelist(token, interactionid, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **interactionid** | [**String**](.md)| The id of the interaction to unlike. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## likesave

> likesave(opts)

Save a like

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.likesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## listtimezones

> listtimezones()

Lists the available timezones

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
apiInstance.listtimezones((error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## locationdelete

> locationdelete(token, id)

Delete a location

Allows the user to delete an existing location.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the location to delete.
apiInstance.locationdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the location to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## locationget

> locationget(token, id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the location to get.
apiInstance.locationget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the location to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## locationlist

> locationlist(token, from, count, opts)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'locations': "locations_example", // String | The comma-separated list containing the ids of the locations to list.
  'sortbygroup': true // Boolean | True to list locations sorted by the 'Located In' property. Defaults to false.
};
apiInstance.locationlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **locations** | **String**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **Boolean**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## locationsave

> locationsave(opts)

Create or edit a location

Allows the user to create or edit a location.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.locationsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## login

> login(domain, username, password, method, opts)

Login

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let domain = "domain_example"; // String | The account domain to login.
let username = "username_example"; // String | The username (email) of the user to login as.
let password = "password_example"; // String | The password of the user to login as.
let method = "method_example"; // String | The authentication method. Valid values are 'token' and 'cookie'.
let opts = {
  'rememberme': true // Boolean | If true then the session will not expire.
};
apiInstance.login(domain, username, password, method, opts, (error, data, response) => {
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
 **domain** | **String**| The account domain to login. | 
 **username** | **String**| The username (email) of the user to login as. | 
 **password** | **String**| The password of the user to login as. | 
 **method** | **String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **Boolean**| If true then the session will not expire. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## logout

> logout(opts)

Logout

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'token': "token_example" // String | The authentication token used to login.
};
apiInstance.logout(opts, (error, data, response) => {
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
 **token** | **String**| The authentication token used to login. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediacheckin

> mediacheckin(token, media, checkindate, opts)

Check in media item

Allows the user to check in a media item.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let media = null; // String | The id of the media item to checkin.
let checkindate = new Date("2013-10-20T19:20:30+01:00"); // Date | The checkout date.
let opts = {
  'notes': "notes_example" // String | The notes of the checkout.
};
apiInstance.mediacheckin(token, media, checkindate, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **media** | [**String**](.md)| The id of the media item to checkin. | 
 **checkindate** | **Date**| The checkout date. | 
 **notes** | **String**| The notes of the checkout. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediacheckout

> mediacheckout(token, media, user, checkoutdate, duedate, opts)

Check out media item

Allows the user to check out a media item.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let media = null; // String | The id of the media item to checkout.
let user = null; // String | The id of the user that is checking the item out.
let checkoutdate = new Date("2013-10-20T19:20:30+01:00"); // Date | The checkout date.
let duedate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date when the checkout is due.
let opts = {
  'staff': null, // String | The id of the staff member related to the checkout.
  'event': null, // String | The id of the event related to the checkout.
  'notes': "notes_example" // String | The notes of the checkout.
};
apiInstance.mediacheckout(token, media, user, checkoutdate, duedate, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **media** | [**String**](.md)| The id of the media item to checkout. | 
 **user** | [**String**](.md)| The id of the user that is checking the item out. | 
 **checkoutdate** | **Date**| The checkout date. | 
 **duedate** | **Date**| The date when the checkout is due. | 
 **staff** | [**String**](.md)| The id of the staff member related to the checkout. | [optional] 
 **event** | [**String**](.md)| The id of the event related to the checkout. | [optional] 
 **notes** | **String**| The notes of the checkout. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediacheckoutlist

> mediacheckoutlist(token, from, count, opts)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'media': null, // String | Used to filter the checkouts of a specific media item.
  'user': null, // String | Used to filter the checkouts made by a specific user.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.mediacheckoutlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **media** | [**String**](.md)| Used to filter the checkouts of a specific media item. | [optional] 
 **user** | [**String**](.md)| Used to filter the checkouts made by a specific user. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediadelete

> mediadelete(token, id)

Delete a media item

Allows the user to delete an existing media item.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the media item to delete.
apiInstance.mediadelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media item to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediadeletecheckoutlog

> mediadeletecheckoutlog(token, id)

Delete a media checkout log

Allows the user to delete a media item&#39;s checkout log.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the checkout log to delete.
apiInstance.mediadeletecheckoutlog(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the checkout log to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaget

> mediaget(token, id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the media item to get.
apiInstance.mediaget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media item to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediagetbycode

> mediagetbycode(token, code, opts)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let code = "code_example"; // String | The code of the media item to get.
let opts = {
  'location': null // String | The location where to look for the media item.
};
apiInstance.mediagetbycode(token, code, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **code** | **String**| The code of the media item to get. | 
 **location** | [**String**](.md)| The location where to look for the media item. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediagetcheckout

> mediagetcheckout(token, id, opts)

View details of a media item checkout information

Allows the user to view a media item&#39;s checkout information.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the media item whose checkout information has to be retrieved.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.mediagetcheckout(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediagetcheckoutlog

> mediagetcheckoutlog(token, id, opts)

View details of a media checkout log

Allows the user to view a media item&#39;s checkout history.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the media item whose checkout information has to be retrieved.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.mediagetcheckoutlog(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## medialist

> medialist(token, from, count, opts)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'status': 56, // Number | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
  'user': null // String | Used to filter the media items that are checked-out by a specific user.
};
apiInstance.medialist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **status** | **Number**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional] 
 **user** | [**String**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediasave

> mediasave(opts)

Create or edit a media item

Allows the user to create or edit a media item.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.mediasave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## mediatypedelete

> mediatypedelete(token, id)

Delete a media type

Allows the user to delete an existing media type.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the media type to delete.
apiInstance.mediatypedelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media type to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediatypeget

> mediatypeget(token, id)

Search and view details of a media type

Allows the user to view a media type and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the media type to get.
apiInstance.mediatypeget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media type to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediatypelist

> mediatypelist(token, from, count)

View a list of media types

Allows the user to view the list of all media types.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.mediatypelist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediatypesave

> mediatypesave(opts)

Create or edit a media type

Allows the user to create or edit a media type.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.mediatypesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## memorizedreportdelete

> memorizedreportdelete(token, id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the report settings to delete.
apiInstance.memorizedreportdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the report settings to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## memorizedreportget

> memorizedreportget(token, id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the report configuration to get.
apiInstance.memorizedreportget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the report configuration to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## memorizedreportlist

> memorizedreportlist(token, from, count, opts)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'customname': "customname_example" // String | If specified filters the memorized reports by custom name.
};
apiInstance.memorizedreportlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **customname** | **String**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## memorizedreportsave

> memorizedreportsave(opts)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.memorizedreportsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## menugetitems

> menugetitems(menuid)

Gets the items on the menu

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let menuid = "menuid_example"; // String | The Id of the menu to get.
apiInstance.menugetitems(menuid, (error, data, response) => {
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
 **menuid** | **String**| The Id of the menu to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## myaccount

> myaccount(token)

Gets the logged in user account.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.myaccount(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## myianatimezone

> myianatimezone(token)

Gets the current time zone&#39;s iana name

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.myianatimezone(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## myprofile

> myprofile(token, opts)

Gets the logged in user information.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.myprofile(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## myrights

> myrights(token)

Gets the list of actions the user can execute.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.myrights(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mysaveprofile

> mysaveprofile(opts)

Updates logged user&#39;s profile information

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.mysaveprofile(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## notificationdelete

> notificationdelete(token, id)

Delete a notification

Allows the user to delete an existing notification.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the notification to delete.
apiInstance.notificationdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationget

> notificationget(token, id)

View a notification

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the notification to get.
apiInstance.notificationget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationgetforstation

> notificationgetforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
apiInstance.notificationgetforstation(station, user, (error, data, response) => {
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

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationgetunreadcount

> notificationgetunreadcount(token)

Get the number of unread notifications

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.notificationgetunreadcount(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationlist

> notificationlist(token, from, count, opts)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'recipient': null, // String | The recipient whose notifications have to be listed.
  'status': 56, // Number | The status of the notifications to list. Read, Unread or All.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the notifications.
  'enddate': new Date("2013-10-20T19:20:30+01:00"), // Date | The end date of the period to filter the notifications.
  'sentonscreen': true, // Boolean | Specifies whether to list the notifications that were sent on-screen or not.
  'sentemail': true, // Boolean | Specifies whether to list the notifications that were sent via e-mail or not.
  'sentsms': true // Boolean | Specifies whether to list the notifications that were sent via sms or not.
};
apiInstance.notificationlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **recipient** | [**String**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **Number**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **Boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **Boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **Boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationlistmine

> notificationlistmine(token, from, count, opts)

View all the notifications sent to the current user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'status': 56, // Number | Specifies the status of the notifications to list. Read, Unread or All.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the notifications.
  'enddate': new Date("2013-10-20T19:20:30+01:00") // Date | The end date of the period to filter the notifications.
};
apiInstance.notificationlistmine(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **status** | **Number**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the notifications. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationmarkasread

> notificationmarkasread(token, opts)

Mark a notification as read

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'id': null, // String | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
  'status': 56, // Number | Specifies the status to filter the notifications. Read, Unread or All.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the notifications.
  'enddate': new Date("2013-10-20T19:20:30+01:00") // Date | The end date of the period to filter the notifications.
};
apiInstance.notificationmarkasread(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **Number**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the notifications. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationmarkasunread

> notificationmarkasunread(token, opts)

Mark a notification as unread

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'id': null, // String | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
  'status': 56, // Number | Specifies the status to filter the notifications. Read, Unread or All.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date of the period to filter the notifications.
  'enddate': new Date("2013-10-20T19:20:30+01:00") // Date | The end date of the period to filter the notifications.
};
apiInstance.notificationmarkasunread(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **Number**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **Date**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **Date**| The end date of the period to filter the notifications. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationsend

> notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, opts)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let emailenabled = true; // Boolean | Whether send the notification via email.
let onscreenenabled = true; // Boolean | Whether to display the notification on screen.
let smsenabled = true; // Boolean | Whether to send the notification via text message.
let title = "title_example"; // String | Notification title.
let opts = {
  'tousers': "tousers_example", // String | Comma-separated Ids of users to send the notification.
  'togroups': "togroups_example", // String | Comma-separated Ids of user groups to send the notification.
  'onscreenbody': "onscreenbody_example", // String | Body of the message for on-screen display.
  'onscreenclick': "onscreenclick_example", // String | What to do when the notification is clicked. Valid values: hide, view, url.
  'onscreenurl': "onscreenurl_example", // String | Url to redirect the user, if onscreenclick=url.
  'onscreenclass': "onscreenclass_example", // String | How to display the notification. Valid values: info, success, warning, error
  'onscreenduration': 56, // Number | Time in seconds to display the notification.
  'showonstation': 56, // Number | Whether to show the notification in the sign-in station.
  'emailfromname': "emailfromname_example", // String | Name of the email sender.
  'emailfrom': "emailfrom_example", // String | Reply-to email.
  'emailsubject': "emailsubject_example", // String | Subject of the email.
  'emailbody': "emailbody_example", // String | Body of the email.
  'textmessagebody': "textmessagebody_example" // String | Message for SMS. Max 160 characters.
};
apiInstance.notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **emailenabled** | **Boolean**| Whether send the notification via email. | 
 **onscreenenabled** | **Boolean**| Whether to display the notification on screen. | 
 **smsenabled** | **Boolean**| Whether to send the notification via text message. | 
 **title** | **String**| Notification title. | 
 **tousers** | **String**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **String**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **String**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **String**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **String**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **String**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **Number**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **Number**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **String**| Name of the email sender. | [optional] 
 **emailfrom** | **String**| Reply-to email. | [optional] 
 **emailsubject** | **String**| Subject of the email. | [optional] 
 **emailbody** | **String**| Body of the email. | [optional] 
 **textmessagebody** | **String**| Message for SMS. Max 160 characters. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationsendonscreen

> notificationsendonscreen(token, notification)

Send on-screen notifications

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let notification = null; // String | The ID of the notification to send.
apiInstance.notificationsendonscreen(token, notification, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **notification** | [**String**](.md)| The ID of the notification to send. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationtopicdelete

> notificationtopicdelete(token, id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the notification topic to delete.
apiInstance.notificationtopicdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification topic to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationtopicget

> notificationtopicget(token, id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the notification topic to get.
apiInstance.notificationtopicget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification topic to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationtopiclist

> notificationtopiclist(token, from, count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.notificationtopiclist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationtopiclistsubscribe

> notificationtopiclistsubscribe(token)

List all the notification topics available to subscribe

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.notificationtopiclistsubscribe(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationtopicsave

> notificationtopicsave(opts)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.notificationtopicsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## pushderegister

> pushderegister(devicetoken, platform)

Deregisters the current device to receive push notifications

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let devicetoken = "devicetoken_example"; // String | The device token where to send the notification.
let platform = "platform_example"; // String | Either ios or android
apiInstance.pushderegister(devicetoken, platform, (error, data, response) => {
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
 **devicetoken** | **String**| The device token where to send the notification. | 
 **platform** | **String**| Either ios or android | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## pushregister

> pushregister(devicetoken, platform)

Registers the current device to receive push notifications

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let devicetoken = "devicetoken_example"; // String | The device token where to send the notification.
let platform = "platform_example"; // String | Either ios or android
apiInstance.pushregister(devicetoken, platform, (error, data, response) => {
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
 **devicetoken** | **String**| The device token where to send the notification. | 
 **platform** | **String**| Either ios or android | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## qrlabelsprint

> qrlabelsprint(token, opts)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'user': null, // String | The id of the user whose label needs to be printed.
  'group': null // String | The id of the group whose members' labels need to be printed.
};
apiInstance.qrlabelsprint(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **user** | [**String**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**String**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## qrloginget

> qrloginget(token)

Gets an image of a QR token

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.qrloginget(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## qrloginlogin

> qrloginlogin(onetimetoken)

Login

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let onetimetoken = "onetimetoken_example"; // String | The token read from the QR code.
apiInstance.qrloginlogin(onetimetoken, (error, data, response) => {
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
 **onetimetoken** | **String**| The token read from the QR code. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpaneldeletewidget

> quickpaneldeletewidget(token, id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the widget.
apiInstance.quickpaneldeletewidget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the widget. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanelfetchwidget

> quickpanelfetchwidget(token, widgetid)

Fetches the information for a specific widget.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let widgetid = null; // String | The ID of the data to fetch it's data.
apiInstance.quickpanelfetchwidget(token, widgetid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **widgetid** | [**String**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanelgetwidget

> quickpanelgetwidget(token, id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the widget to get.
apiInstance.quickpanelgetwidget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the widget to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanelinit

> quickpanelinit(token)

Returns the initial information required to show the quick panels

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.quickpanelinit(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanellistwidgets

> quickpanellistwidgets(token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.quickpanellistwidgets(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanellistwidgettypes

> quickpanellistwidgettypes(token)

Lists all the widget types available in the system

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.quickpanellistwidgettypes(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanelreorderwidgets

> quickpanelreorderwidgets(token, sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let sectionname = "sectionname_example"; // String | The section name where to sort the widgets.
let orderids = "orderids_example"; // String | CSV list of the widgets to reorder.
apiInstance.quickpanelreorderwidgets(token, sectionname, orderids, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **sectionname** | **String**| The section name where to sort the widgets. | 
 **orderids** | **String**| CSV list of the widgets to reorder. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanelsavewidget

> quickpanelsavewidget(opts)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.quickpanelsavewidget(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## ratingflag

> ratingflag(token, id, opts)

Flags one rating for moderation

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The rating to flag.
let opts = {
  'comment': "comment_example" // String | Comment why should this should be removed.
};
apiInstance.ratingflag(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The rating to flag. | 
 **comment** | **String**| Comment why should this should be removed. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingflagcomment

> ratingflagcomment(token, id, opts)

Flags one comment for moderation

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The comment to flag.
let opts = {
  'comment': "comment_example" // String | Comment why should this should be removed.
};
apiInstance.ratingflagcomment(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The comment to flag. | 
 **comment** | **String**| Comment why should this should be removed. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingget

> ratingget(token, type, entityids)

Get rating for one or more entities

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let type = "type_example"; // String | The entity type to get the rating.
let entityids = "entityids_example"; // String | List of ids to get the ratings.
apiInstance.ratingget(token, type, entityids, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **type** | **String**| The entity type to get the rating. | 
 **entityids** | **String**| List of ids to get the ratings. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratinggetall

> ratinggetall(token, type, entityid, opts)

Gets the full ratings and comments for a specific entity

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let type = "type_example"; // String | The entity type to get the rating.
let entityid = "entityid_example"; // String | Id of the entity to get the ratings.
let opts = {
  'mostrecentfirst': true // Boolean | True to show most recent first, otherwise most helpful first.
};
apiInstance.ratinggetall(token, type, entityid, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **type** | **String**| The entity type to get the rating. | 
 **entityid** | **String**| Id of the entity to get the ratings. | 
 **mostrecentfirst** | **Boolean**| True to show most recent first, otherwise most helpful first. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratinggetcomments

> ratinggetcomments(token, ratingid)

Gets all the comments for a rating

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let ratingid = null; // String | The ID of the rating to get all comments.
apiInstance.ratinggetcomments(token, ratingid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **ratingid** | [**String**](.md)| The ID of the rating to get all comments. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratinggetpending

> ratinggetpending(getgroup, opts)

Gets info of pre-saved and pre-approved ratings

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let getgroup = null; // String | The ID of the group of pending ratings to get.
let opts = {
  'rateid': null, // String | Rate this before returning.
  'rateval': 56 // Number | The value used to rate the item specified in rateid.
};
apiInstance.ratinggetpending(getgroup, opts, (error, data, response) => {
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
 **getgroup** | [**String**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**String**](.md)| Rate this before returning. | [optional] 
 **rateval** | **Number**| The value used to rate the item specified in rateid. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratinggetpendingmoderation

> ratinggetpendingmoderation(token)

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.ratinggetpendingmoderation(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingmoderate

> ratingmoderate(token, type, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let type = "type_example"; // String | Either 'rating' or 'comment' depending on what you want to moderate.
let id = null; // String | Id of the rating or comment, as specified in type.
let approve = true; // Boolean | True to approve, false to reject.
apiInstance.ratingmoderate(token, type, id, approve, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **type** | **String**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**String**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **Boolean**| True to approve, false to reject. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingpostcomment

> ratingpostcomment(token, ratingid, comment, annonymous)

Posts a comments for in a rating

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let ratingid = null; // String | The ID of the rating to post the comment.
let comment = "comment_example"; // String | Text of the comment to post.
let annonymous = true; // Boolean | True to post the comment annonymously.
apiInstance.ratingpostcomment(token, ratingid, comment, annonymous, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **ratingid** | [**String**](.md)| The ID of the rating to post the comment. | 
 **comment** | **String**| Text of the comment to post. | 
 **annonymous** | **Boolean**| True to post the comment annonymously. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingrate

> ratingrate(token, type, entityid, annonymous, opts)

Rates one entity

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let type = "type_example"; // String | The entity type to rate.
let entityid = "entityid_example"; // String | Id of the entity to rate.
let annonymous = true; // Boolean | Whether to post as annonymous.
let opts = {
  'value': 56, // Number | Value from 0 to 100 with the rating.
  'comment': "comment_example", // String | Comment associated with this review. Comment can be updated later on another request too.
  'updatecomment': true // Boolean | Whether to update the comments. Defaults to true.
};
apiInstance.ratingrate(token, type, entityid, annonymous, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **type** | **String**| The entity type to rate. | 
 **entityid** | **String**| Id of the entity to rate. | 
 **annonymous** | **Boolean**| Whether to post as annonymous. | 
 **value** | **Number**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingratepending

> ratingratepending(group, annonymous, opts)

Rates a pre-saved and pre-approved entity

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let group = null; // String | The ID of the group of with pre-approved ratings.
let annonymous = true; // Boolean | Whether to post as annonymous.
let opts = {
  'rateid': null, // String | Rate this before returning.
  'value': 56, // Number | Value from 0 to 100 with the rating.
  'comment': "comment_example", // String | Comment associated with this review. Comment can be updated later on another request too.
  'updatecomment': true // Boolean | Whether to update the comments. Defaults to true.
};
apiInstance.ratingratepending(group, annonymous, opts, (error, data, response) => {
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
 **group** | [**String**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **Boolean**| Whether to post as annonymous. | 
 **rateid** | [**String**](.md)| Rate this before returning. | [optional] 
 **value** | **Number**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingvote

> ratingvote(token, ratingid, vote)

Votes up or down a rating

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let ratingid = null; // String | The ID of the rating to vote on.
let vote = 56; // Number | 1 to vote up, -1 to vote down.
apiInstance.ratingvote(token, ratingid, vote, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **ratingid** | [**String**](.md)| The ID of the rating to vote on. | 
 **vote** | **Number**| 1 to vote up, -1 to vote down. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportattanalyticsprepare

> reportattanalyticsprepare(token, reportname, opts)

Query and load an attendance analytics report

Allows the user to query and load attendance analytics reports.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let reportname = "reportname_example"; // String | The name of the report to execute
let opts = {
  'params': "params_example", // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
  'refreshgroup': null // String | The ID of the group to check (and refresh) before processing the report.
};
apiInstance.reportattanalyticsprepare(token, reportname, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **reportname** | **String**| The name of the report to execute | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **refreshgroup** | [**String**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportlist

> reportlist(token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.reportlist(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportpermissionsbyuser

> reportpermissionsbyuser(token, opts)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'params': "params_example" // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
};
apiInstance.reportpermissionsbyuser(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportprepare

> reportprepare(token, reportname, opts)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let reportname = "reportname_example"; // String | The name of the report to execute
let opts = {
  'params': "params_example", // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
  'repformat': "repformat_example", // String | The format of the resulting report. Json, pdf, csv, ...
  'fillgroupid': null, // String | If specified, the result is used to fill the group with the given ID
  'groupby': "groupby_example", // String | How to group the records. In the format 'col1+col2|col3+col4
  'refreshgroup': null, // String | The ID of the group to check (and refresh) before processing the report.
  'filtertext': "filtertext_example" // String | The user friendly text of the applied filters.
};
apiInstance.reportprepare(token, reportname, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **reportname** | **String**| The name of the report to execute | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **String**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**String**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **String**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**String**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **String**| The user friendly text of the applied filters. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportquery

> reportquery(token, reportname, opts)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let reportname = "reportname_example"; // String | The name of the report to execute
let opts = {
  'params': "params_example" // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
};
apiInstance.reportquery(token, reportname, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **reportname** | **String**| The name of the report to execute | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportscheduledelete

> reportscheduledelete(token, id)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the report schedule to delete.
apiInstance.reportscheduledelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the report schedule to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportscheduleget

> reportscheduleget(token, id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the schedule to get.
apiInstance.reportscheduleget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the schedule to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportschedulelist

> reportschedulelist(token, from, count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.reportschedulelist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportschedulesave

> reportschedulesave(opts)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.reportschedulesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## reporttagresults

> reporttagresults(token, reportname, assign, tags, opts)

Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.

Allows the user to use a report to assign or unassign tags.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let reportname = "reportname_example"; // String | The name of the report to execute
let assign = true; // Boolean | Specify whether the specified tags have to be assigned or unassigned.
let tags = "tags_example"; // String | The tags to assign (or unassign) to the resulting users in the report, in JSON format.
let opts = {
  'params': "params_example" // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
};
apiInstance.reporttagresults(token, reportname, assign, tags, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **reportname** | **String**| The name of the report to execute | 
 **assign** | **Boolean**| Specify whether the specified tags have to be assigned or unassigned. | 
 **tags** | **String**| The tags to assign (or unassign) to the resulting users in the report, in JSON format. | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodelcheckanalysis

> riskmodelcheckanalysis(token, id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the risk assessment model whose analysis status has to be returned.
apiInstance.riskmodelcheckanalysis(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodeldelete

> riskmodeldelete(token, id)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the risk assessment model to delete.
apiInstance.riskmodeldelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodelget

> riskmodelget(token, id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the risk assessment model to get.
apiInstance.riskmodelget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodelgetscore

> riskmodelgetscore(token, userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to get the risk score.
apiInstance.riskmodelgetscore(token, userid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to get the risk score. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodellist

> riskmodellist(token, from, count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.riskmodellist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodelpredict

> riskmodelpredict(token, id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the assessment model to use in order to predict risk.
apiInstance.riskmodelpredict(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the assessment model to use in order to predict risk. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodelprocess

> riskmodelprocess(token, id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the risk assessment model to process.
apiInstance.riskmodelprocess(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model to process. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodelrefresh

> riskmodelrefresh(token, id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the risk assessment model whose information has to be refreshed.
apiInstance.riskmodelrefresh(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodelsave

> riskmodelsave(opts)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.riskmodelsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## riskmodeltermprecedences

> riskmodeltermprecedences(token)

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.riskmodeltermprecedences(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rolelist

> rolelist(token, opts)

Show a list of roles

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'name': "name_example" // String | Filter by name of the role.
};
apiInstance.rolelist(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **name** | **String**| Filter by name of the role. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ruledelete

> ruledelete(token, id)

Delete a rule

Allows the user to delete an existing rule.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the rule to delete.
apiInstance.ruledelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the rule to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ruleget

> ruleget(token, id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the rule to get.
apiInstance.ruleget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the rule to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rulegeteventtype

> rulegeteventtype(token, event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let event = "event_example"; // String | The name of the event to refresh.
apiInstance.rulegeteventtype(token, event, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **event** | **String**| The name of the event to refresh. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rulelist

> rulelist(token, from, count)

View a list of user rules

Allows the user to view the list of all rules.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.rulelist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rulelistactions

> rulelistactions(token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.rulelistactions(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rulelisteventtypes

> rulelisteventtypes(token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.rulelisteventtypes(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rulelisthttprequests

> rulelisthttprequests(token, from, count, opts)

View all the http requests sent as a result of a rule

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'failed': true, // Boolean | If true only failed requests will be returned
  'status': 56 // Number | The http status to filter the requests
};
apiInstance.rulelisthttprequests(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **failed** | **Boolean**| If true only failed requests will be returned | [optional] 
 **status** | **Number**| The http status to filter the requests | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rulesave

> rulesave(opts)

Create or edit a rule

Allows the user to create or edit a rule.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.rulesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## scheduledelete

> scheduledelete(token, scheduleid)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let scheduleid = null; // String | The id of the schedule.
apiInstance.scheduledelete(token, scheduleid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduledeletemine

> scheduledeletemine(token, scheduleid)

Delete a specific block from a user&#39;s own schedule

Allows the user to delete a schedule block from their own availability.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let scheduleid = null; // String | The id of the schedule.
apiInstance.scheduledeletemine(token, scheduleid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleenable

> scheduleenable(token, userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to enable or disable the schedule.
let enable = true; // Boolean | True to enable schedules, false to disable.
apiInstance.scheduleenable(token, userid, enable, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **Boolean**| True to enable schedules, false to disable. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleenablemine

> scheduleenablemine(token, enable)

Enable or disable current user&#39;s schedule

Allows the user to enable or disable a schedule for himself.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let enable = true; // Boolean | True to enable schedules, false to disable.
apiInstance.scheduleenablemine(token, enable, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **enable** | **Boolean**| True to enable schedules, false to disable. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulefindallstaffslots

> schedulefindallstaffslots(token, starttime, endtime, opts)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
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
apiInstance.schedulefindallstaffslots(token, starttime, endtime, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
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

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulefindslots

> schedulefindslots(token, staffid, starttime, endtime, opts)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let staffid = null; // String | The id of the staff to filter by.
let starttime = new Date("2013-10-20T19:20:30+01:00"); // Date | The start time of the range to look for slots.
let endtime = new Date("2013-10-20T19:20:30+01:00"); // Date | The end time of the range to look for slots.
let opts = {
  'serviceids': "serviceids_example", // String | CSV list of the service Ids to filter by.
  'eventid': null, // String | The id of the event to filter by.
  'locationid': null, // String | The id of the service to filter by.
  'availablefor': "availablefor_example" // String | The specific availability type to filter by.
};
apiInstance.schedulefindslots(token, staffid, starttime, endtime, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
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

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulefindstaffavail

> schedulefindstaffavail(token, starttime, endtime, opts)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
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
apiInstance.schedulefindstaffavail(token, starttime, endtime, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
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

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleget

> scheduleget(token, scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let scheduleid = null; // String | The id of the schedule.
apiInstance.scheduleget(token, scheduleid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulegetmine

> schedulegetmine(token, scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let scheduleid = null; // String | The id of the schedule.
apiInstance.schedulegetmine(token, scheduleid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulegetstaff

> schedulegetstaff(token, userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to get info.
apiInstance.schedulegetstaff(token, userid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to get info. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulegetstaffmine

> schedulegetstaffmine(token)

View current user&#39;s schedule information

Allows the user to view their own schedule.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.schedulegetstaffmine(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegrationdeleteitem

> scheduleintegrationdeleteitem(token, thirdpartyid)

Delete a schedule item looking up by a third party ID

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let thirdpartyid = "thirdpartyid_example"; // String | The third party id to search the schedule block / appointment.
apiInstance.scheduleintegrationdeleteitem(token, thirdpartyid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **thirdpartyid** | **String**| The third party id to search the schedule block / appointment. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegrationdeleteitemsbymasterid

> scheduleintegrationdeleteitemsbymasterid(token, thirdpartymasterid)

Delete multiple schedule items looking up by a third party master ID

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let thirdpartymasterid = "thirdpartymasterid_example"; // String | The third party master id to search the schedule items.
apiInstance.scheduleintegrationdeleteitemsbymasterid(token, thirdpartymasterid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **thirdpartymasterid** | **String**| The third party master id to search the schedule items. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegrationgetitem

> scheduleintegrationgetitem(token, thirdpartyid)

Get a schedule item looking up by a third party ID

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let thirdpartyid = "thirdpartyid_example"; // String | The third party id to search for the schedule item.
apiInstance.scheduleintegrationgetitem(token, thirdpartyid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **thirdpartyid** | **String**| The third party id to search for the schedule item. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegrationsaveitem

> scheduleintegrationsaveitem(opts)

Save a schedule item looking up by a third party ID

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.scheduleintegrationsaveitem(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## scheduleintegrationsetid

> scheduleintegrationsetid(token, id, thirdpartyid, opts)

Set a 3rd party ID on a specific schedule item

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the schedule block / appointment.
let thirdpartyid = "thirdpartyid_example"; // String | The 3rd party ID to set.
let opts = {
  'thirdpartymasterid': "thirdpartymasterid_example" // String | The 3rd party master ID to set (useful to handle recurring items).
};
apiInstance.scheduleintegrationsetid(token, id, thirdpartyid, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the schedule block / appointment. | 
 **thirdpartyid** | **String**| The 3rd party ID to set. | 
 **thirdpartymasterid** | **String**| The 3rd party master ID to set (useful to handle recurring items). | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulemyofftimes

> schedulemyofftimes(token, opts)

View current user&#39;s schedule exceptions

Allows the user to view their own schedule exceptions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'includedeleted': true, // Boolean | If true the deleted offtimes are also returned.
  'onlyupcoming': true, // Boolean | If true then only upcoming offtimes are returned.
  'modifiedafter': new Date("2013-10-20T19:20:30+01:00") // Date | If specified, only offtimes modified after the specified date will be returned.
};
apiInstance.schedulemyofftimes(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **includedeleted** | **Boolean**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **Boolean**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **Date**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulesave

> schedulesave(opts)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.schedulesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## schedulesavemine

> schedulesavemine(opts)

Create or edit a block in current user&#39;s schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.schedulesavemine(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## search

> search(token, query, opts)

Search

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let query = "query_example"; // String | The query to search for.
let opts = {
  'page': 56 // Number | Current page to show, zero-based.
};
apiInstance.search(token, query, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **query** | **String**| The query to search for. | 
 **page** | **Number**| Current page to show, zero-based. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## searchgetentities

> searchgetentities(token)

Get the information of the entities that can be searched

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.searchgetentities(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityassesspermission

> securityassesspermission(token, commandname)

Returns the list of users for a specific permission

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let commandname = "commandname_example"; // String | Name of the action or command to get the roles.
apiInstance.securityassesspermission(token, commandname, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **commandname** | **String**| Name of the action or command to get the roles. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityassessrole

> securityassessrole(token, roleid)

Returns the list of permissions for a specific role

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let roleid = null; // String | Role ID to list the effective permissions.
apiInstance.securityassessrole(token, roleid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **roleid** | [**String**](.md)| Role ID to list the effective permissions. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityassessscope

> securityassessscope(token, opts)

Returns the list of users for a specific user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'locationid': null // String | Location ID to list the users with that scope.
};
apiInstance.securityassessscope(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **locationid** | [**String**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityassessuser

> securityassessuser(token, userid)

Returns the list of permissions for a specific user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | User ID to list the effective permissions.
apiInstance.securityassessuser(token, userid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| User ID to list the effective permissions. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## seminardelete

> seminardelete(token, id)

Delete an event

Allows the user to delete an existing event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the seminar to delete.
apiInstance.seminardelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the seminar to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## seminarget

> seminarget(token, id)

Search and view details of a event

Allows the user to view a event and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the seminar to get.
apiInstance.seminarget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the seminar to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## seminarlist

> seminarlist(token, from, count, opts)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = "from_example"; // String | The first record to return.
let count = "count_example"; // String | The max number of records to return.
let opts = {
  'summaryonly': true, // Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  'termid': null // String | Id of the term to list the events. Null to list all events.
};
apiInstance.seminarlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **String**| The first record to return. | 
 **count** | **String**| The max number of records to return. | 
 **summaryonly** | **Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**String**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## seminarsave

> seminarsave(opts)

Create or edit a event

Allows the user to create or edit a event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.seminarsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## serviceassignmentaddservice

> serviceassignmentaddservice(token, serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceid = null; // String | The id of the service to add.
let locationid = null; // String | The id of the location.
apiInstance.serviceassignmentaddservice(token, serviceid, locationid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to add. | 
 **locationid** | [**String**](.md)| The id of the location. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignmentgetlocation

> serviceassignmentgetlocation(token, locationid, opts)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let locationid = null; // String | The id of the location to get.
let opts = {
  'includegloballyavailable': true, // Boolean | Specifies whether the services available globally must be returned or not.
  'namefilter': true, // Boolean | Filters the name of the services to return.
  'count': 56 // Number | The max number of services to return.
};
apiInstance.serviceassignmentgetlocation(token, locationid, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **locationid** | [**String**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **Boolean**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **Boolean**| Filters the name of the services to return. | [optional] 
 **count** | **Number**| The max number of services to return. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignmentgetservice

> serviceassignmentgetservice(token, serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceid = null; // String | The id of the service to get its locations.
apiInstance.serviceassignmentgetservice(token, serviceid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignmentremoveservice

> serviceassignmentremoveservice(token, serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceid = null; // String | The id of the service to remove.
let locationid = null; // String | The id of the location to remove the service from.
apiInstance.serviceassignmentremoveservice(token, serviceid, locationid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to remove. | 
 **locationid** | [**String**](.md)| The id of the location to remove the service from. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## servicedelete

> servicedelete(token, id)

Delete a service

Allows the user to delete a service from the existing list.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the service to delete.
apiInstance.servicedelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the service to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceget

> serviceget(token, id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the service to get.
apiInstance.serviceget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the service to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## servicelist

> servicelist(token, from, count)

View a list of services

Allows the user to view the full list of existing services.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.servicelist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## servicesave

> servicesave(opts)

Create or edit a service

Allows the user to create or edit a service.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.servicesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionattendancelogaddnote

> sessionattendancelogaddnote(token, id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the attendance log.
let text = "text_example"; // String | The text of the note to add.
apiInstance.sessionattendancelogaddnote(token, id, text, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log. | 
 **text** | **String**| The text of the note to add. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogget

> sessionattendancelogget(token, id, opts)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the attendance log to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.
};
apiInstance.sessionattendancelogget(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendanceloggetuser

> sessionattendanceloggetuser(attendee, eventid, opts)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let attendee = null; // String | The id of the attendee to get statistic for.
let eventid = null; // String | The id of the event whose attendee statistics have to be returned.
let opts = {
  'token': "token_example" // String | The authentication token.
};
apiInstance.sessionattendanceloggetuser(attendee, eventid, opts, (error, data, response) => {
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
 **attendee** | [**String**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**String**](.md)| The id of the event whose attendee statistics have to be returned. | 
 **token** | **String**| The authentication token. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendanceloglist

> sessionattendanceloglist(token, session, from, count, opts)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let session = null; // String | The id of the session whose attendees logs have to be returned.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.sessionattendanceloglist(token, session, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **session** | [**String**](.md)| The id of the session whose attendees logs have to be returned. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendanceloglistevent

> sessionattendanceloglistevent(eventid, opts)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let eventid = null; // String | The id of the event whose attendance has to be returned.
let opts = {
  'token': "token_example" // String | The authentication token.
};
apiInstance.sessionattendanceloglistevent(eventid, opts, (error, data, response) => {
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
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | 
 **token** | **String**| The authentication token. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendanceloglistsummary

> sessionattendanceloglistsummary(opts)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'token': "token_example", // String | The authentication token.
  'eventid': null, // String | The id of the event whose attendance has to be returned.
  'attendeeid': null, // String | The id of the attendee whose attendance has to be returned.
  'groupid': null, // String | The id of the group whose attendance has to be returned.
  'start': "start_example", // String | The start date to filter (beginning of time by default).
  'end': "end_example" // String | The end date to filter (today by default).
};
apiInstance.sessionattendanceloglistsummary(opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**String**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**String**](.md)| The id of the group whose attendance has to be returned. | [optional] 
 **start** | **String**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **String**| The end date to filter (today by default). | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogmylistsummary

> sessionattendancelogmylistsummary(opts)

View my attendance summary

Allows the user to view their own attendance summary.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'token': "token_example", // String | The authentication token.
  'eventid': null, // String | The id of the event whose attendance has to be returned.
  'start': "start_example", // String | The start date to filter (beginning of time by default).
  'end': "end_example" // String | The end date to filter (today by default).
};
apiInstance.sessionattendancelogmylistsummary(opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **start** | **String**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **String**| The end date to filter (today by default). | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionattendancelogsave

> sessionattendancelogsave(opts)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionattendancelogsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionattendancelogsaveswipe

> sessionattendancelogsaveswipe(opts)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionattendancelogsaveswipe(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionbulkupdate

> sessionbulkupdate(token, eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The id of the event to bulk update.
let sessions = "sessions_example"; // String | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.
apiInstance.sessionbulkupdate(token, eventid, sessions, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event to bulk update. | 
 **sessions** | **String**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionget

> sessionget(token, id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the session to get.
apiInstance.sessionget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the session to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessiongetschedule

> sessiongetschedule(opts)

Gets the schedule for a location, instructor or attendees

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'token': "token_example", // String | The authentication token.
  'day': new Date("2013-10-20T19:20:30+01:00"), // Date | The day to return. It will also return the whole week for that day.
  'attendee': null, // String | The id of the attendee to get the schedule.
  'location': null, // String | The id of the location to get the schedule.
  'instructor': null // String | The id of the instructor to get the schedule.
};
apiInstance.sessiongetschedule(opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **day** | **Date**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**String**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**String**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**String**](.md)| The id of the instructor to get the schedule. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionlist

> sessionlist(from, count, opts)

Gets all future sessions of the current semester

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'token': "token_example", // String | The authentication token.
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | The start date to filter the sessions
  'enddate': new Date("2013-10-20T19:20:30+01:00") // Date | The end date to filter the sessions.
};
apiInstance.sessionlist(from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **startdate** | **Date**| The start date to filter the sessions | [optional] 
 **enddate** | **Date**| The end date to filter the sessions. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregaddcurrentuser

> sessionregaddcurrentuser(token, eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The id of the event.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time when the session starts.
apiInstance.sessionregaddcurrentuser(token, eventid, sessiondate, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **Date**| The date and time when the session starts. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregadduser

> sessionregadduser(token, userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to add.
let eventid = null; // String | The id of the event.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time when the session starts.
apiInstance.sessionregadduser(token, userid, eventid, sessiondate, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **Date**| The date and time when the session starts. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreggetmysessions

> sessionreggetmysessions(token, opts)

View all the sessions the logged user is registered to

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  '_date': new Date("2013-10-20T19:20:30+01:00") // Date | Start date to filter the sessions.
};
apiInstance.sessionreggetmysessions(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **_date** | **Date**| Start date to filter the sessions. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreggetsessions

> sessionreggetsessions(token, userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The user id to list sessions.
apiInstance.sessionreggetsessions(token, userid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The user id to list sessions. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreggetsettings

> sessionreggetsettings(token, opts)

Get the settings for session registration

Allows the user to view a event&#39;s session registration settings.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'locationid': null, // String | The id of the location to save settings.
  'eventid': null, // String | The id of the event to save settings.
  'sessiondate': new Date("2013-10-20T19:20:30+01:00"), // Date | The date and time when the session starts.
  'noinherit': true // Boolean | True to get the location/event/session specific settings without looking for the more global settings.
};
apiInstance.sessionreggetsettings(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **locationid** | [**String**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **Date**| The date and time when the session starts. | [optional] 
 **noinherit** | **Boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreggetusers

> sessionreggetusers(token, eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The event id to list sessions.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date of the session to find.
apiInstance.sessionreggetusers(token, eventid, sessiondate, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The event id to list sessions. | 
 **sessiondate** | **Date**| The date of the session to find. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreglistsessions

> sessionreglistsessions(token, eventid, opts)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The event id to list sessions.
let opts = {
  'sessiondate': new Date("2013-10-20T19:20:30+01:00") // Date | The date of the session to find.
};
apiInstance.sessionreglistsessions(token, eventid, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The event id to list sessions. | 
 **sessiondate** | **Date**| The date of the session to find. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreglistupcoming

> sessionreglistupcoming(token, _date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let _date = new Date("2013-10-20T19:20:30+01:00"); // Date | Only sessions in the week of the specified date will be returned.
apiInstance.sessionreglistupcoming(token, _date, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **_date** | **Date**| Only sessions in the week of the specified date will be returned. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreglistupcomingevent

> sessionreglistupcomingevent(token, _date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let _date = new Date("2013-10-20T19:20:30+01:00"); // Date | Start date to filter the returned sessions.
let event = null; // String | The id of the event whose sessions will be returned
apiInstance.sessionreglistupcomingevent(token, _date, event, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **_date** | **Date**| Start date to filter the returned sessions. | 
 **event** | [**String**](.md)| The id of the event whose sessions will be returned | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregremovecurrentuser

> sessionregremovecurrentuser(token, eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let eventid = null; // String | The id of the event.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time when the session starts.
apiInstance.sessionregremovecurrentuser(token, eventid, sessiondate, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **Date**| The date and time when the session starts. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregremoveuser

> sessionregremoveuser(token, userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to remove.
let eventid = null; // String | The id of the event.
let sessiondate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time when the session starts.
apiInstance.sessionregremoveuser(token, userid, eventid, sessiondate, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **Date**| The date and time when the session starts. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregsavesettings

> sessionregsavesettings(opts)

Save the settings for an event&#39;s session registration

Allows the user to save the settings for an event.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionregsavesettings(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionswipedelete

> sessionswipedelete(token, id)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the session swipe to delete.
apiInstance.sessionswipedelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the session swipe to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionswipeget

> sessionswipeget(token, id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the swipe to get.
apiInstance.sessionswipeget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the swipe to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionswipelistunresolved

> sessionswipelistunresolved(from, count, opts)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'token': "token_example" // String | The authentication token.
};
apiInstance.sessionswipelistunresolved(from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionswiperesolve

> sessionswiperesolve(token, id, opts)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the swipe to resolve.
let opts = {
  'session': null, // String | The id of the session whose swipe has to be saved.
  'user': null // String | The id of the user who signed-in.
};
apiInstance.sessionswiperesolve(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the swipe to resolve. | 
 **session** | [**String**](.md)| The id of the session whose swipe has to be saved. | [optional] 
 **user** | [**String**](.md)| The id of the user who signed-in. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionswipesave

> sessionswipesave(opts)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionswipesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionswipesaveanonym

> sessionswipesaveanonym(opts)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.sessionswipesaveanonym(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## settingaddlogo

> settingaddlogo(token, upload, filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
let filename = "filename_example"; // String | The original filename, needed to process the file.
apiInstance.settingaddlogo(token, upload, filename, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The original filename, needed to process the file. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## settingget

> settingget(keys, opts)

Get settings for the account or the specified scope

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let keys = "keys_example"; // String | The option keys to get values for. Enter multiple separated by comma.
let opts = {
  'token': "token_example", // String | The authentication token.
  'domain': "domain_example", // String | The account domain, in case of reading settings annonymously.
  'scope': "scope_example" // String | The scope of the settings to get.
};
apiInstance.settingget(keys, opts, (error, data, response) => {
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
 **keys** | **String**| The option keys to get values for. Enter multiple separated by comma. | 
 **token** | **String**| The authentication token. | [optional] 
 **domain** | **String**| The account domain, in case of reading settings annonymously. | [optional] 
 **scope** | **String**| The scope of the settings to get. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## settingsave

> settingsave(opts)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.settingsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## settingviewgeneral

> settingviewgeneral(token)

View general settings for the account

Allows the user to view the settings&#39; general section.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.settingviewgeneral(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialcontacts

> socialcontacts(token, opts)

Gets the list of contacts in the network

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'filter': "filter_example", // String | Text to filter results.
  'showdefaultphoto': true // Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
};
apiInstance.socialcontacts(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **filter** | **String**| Text to filter results. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupaddmembers

> socialgroupaddmembers(token, id, userids)

Adds new members to a group (which the user must own already)

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | ID of the group to add members to.
let userids = "userids_example"; // String | Csv list of user Ids to add.
apiInstance.socialgroupaddmembers(token, id, userids, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to add members to. | 
 **userids** | **String**| Csv list of user Ids to add. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupdelete

> socialgroupdelete(token, id)

Deletes a group

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | ID of the group to delete.
apiInstance.socialgroupdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgrouplist

> socialgrouplist(token)

View all the groups the current user is in

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.socialgrouplist(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgrouplistmembers

> socialgrouplistmembers(token, id)

Lists the members of a group

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | ID of the group to list members.
apiInstance.socialgrouplistmembers(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to list members. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupremovemembers

> socialgroupremovemembers(token, id, userids)

Removes members from a group (which the user must own already)

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | ID of the group to remove members from.
let userids = "userids_example"; // String | Csv list of user Ids to remove.
apiInstance.socialgroupremovemembers(token, id, userids, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to remove members from. | 
 **userids** | **String**| Csv list of user Ids to remove. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupremovemyself

> socialgroupremovemyself(token, id)

Removes myself from an existent group

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | ID of the group to remove me from.
apiInstance.socialgroupremovemyself(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to remove me from. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupsave

> socialgroupsave(opts)

Saves a new group

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.socialgroupsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## ssogeneratekey

> ssogeneratekey(token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.ssogeneratekey(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ssogetsettings

> ssogetsettings(token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.ssogetsettings(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ssoissuetoken

> ssoissuetoken(key, username, opts)

Issue single sign-on token

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let key = "key_example"; // String | The single sign-on key of the account.
let username = "username_example"; // String | The email of the user to sign-on.
let opts = {
  'expires': true // Boolean | Specifies whether the session should expire when inactive.
};
apiInstance.ssoissuetoken(key, username, opts, (error, data, response) => {
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
 **key** | **String**| The single sign-on key of the account. | 
 **username** | **String**| The email of the user to sign-on. | 
 **expires** | **Boolean**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ssosavesettings

> ssosavesettings(opts)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.ssosavesettings(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## staffavailaddmetoallservices

> staffavailaddmetoallservices(token)

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.staffavailaddmetoallservices(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailaddmetoservice

> staffavailaddmetoservice(token, serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceid = null; // String | The id of the service.
apiInstance.staffavailaddmetoservice(token, serviceid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailaddusertoallservices

> staffavailaddusertoallservices(token, userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to add.
apiInstance.staffavailaddusertoallservices(token, userid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailaddusertoservice

> staffavailaddusertoservice(token, userid, serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to add.
let serviceid = null; // String | The id of the service.
apiInstance.staffavailaddusertoservice(token, userid, serviceid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailgetmyservices

> staffavailgetmyservices(token)

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.staffavailgetmyservices(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailgetservices

> staffavailgetservices(token, userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The user id to list services.
apiInstance.staffavailgetservices(token, userid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The user id to list services. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailgetusersforservice

> staffavailgetusersforservice(token, serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceid = null; // String | The service id to list users.
apiInstance.staffavailgetusersforservice(token, serviceid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The service id to list users. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavaillisttypes

> staffavaillisttypes(token)

View all the availability types

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.staffavaillisttypes(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailremovemefromallservices

> staffavailremovemefromallservices(token)

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.staffavailremovemefromallservices(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailremovemefromservice

> staffavailremovemefromservice(token, serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let serviceid = null; // String | The id of the service.
apiInstance.staffavailremovemefromservice(token, serviceid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailremoveuserfromallservices

> staffavailremoveuserfromallservices(token, userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member&#39;s availability to all services.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to remove.
apiInstance.staffavailremoveuserfromallservices(token, userid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailremoveuserfromservice

> staffavailremoveuserfromservice(token, userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member&#39;s service availability.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to remove.
let serviceid = null; // String | The id of the service.
apiInstance.staffavailremoveuserfromservice(token, userid, serviceid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailsetavailability

> staffavailsetavailability(token, userid, opts)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user whose specific availability has to be set.
let opts = {
  'availablefor': "availablefor_example" // String | Specific availability to set.
};
apiInstance.staffavailsetavailability(token, userid, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user whose specific availability has to be set. | 
 **availablefor** | **String**| Specific availability to set. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailsetmyavailability

> staffavailsetmyavailability(token, opts)

Change current user&#39;s availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'availablefor': "availablefor_example" // String | Specific availability to set.
};
apiInstance.staffavailsetmyavailability(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **availablefor** | **String**| Specific availability to set. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationdelete

> stationdelete(token, id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the sign-in station to delete.
apiInstance.stationdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the sign-in station to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationget

> stationget(token, id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the sign-in station to get.
apiInstance.stationget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the sign-in station to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationgetcurrentterms

> stationgetcurrentterms(station)

Get all the current terms

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station whose account's current terms have to be retrieved.
apiInstance.stationgetcurrentterms(station, (error, data, response) => {
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
 **station** | [**String**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationgetinfo

> stationgetinfo(id, opts)

Gets a the info to display in the sign-in station by it&#39;s ID.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let id = null; // String | The id of the sign-in station to get.
let opts = {
  'event': null // String | The id of the event, to override the one by schedule.
};
apiInstance.stationgetinfo(id, opts, (error, data, response) => {
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
 **event** | [**String**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationgetlicense

> stationgetlicense(station)

Gets the current license information

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = "station_example"; // String | The id of the sign-in station whose account's license has to be retrieved.
apiInstance.stationgetlicense(station, (error, data, response) => {
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
 **station** | **String**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationgetlocationsettings

> stationgetlocationsettings(location)

View the sign-in station settings of a specified location

Allows the user to view the location settings of a sign-in station.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let location = null; // String | The id of the location whose station settings have to be returned.
apiInstance.stationgetlocationsettings(location, (error, data, response) => {
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
 **location** | [**String**](.md)| The id of the location whose station settings have to be returned. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationlist

> stationlist(token, from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.stationlist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationsave

> stationsave(opts)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.stationsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## stationsavemine

> stationsavemine(opts)

Create or edit a class attendance sign-in station for myself

Allows the user to create a class attendance sign-in station for a course for which they are available as staff.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.stationsavemine(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## stationunlock

> stationunlock(id, passcode, method)

Unlocks the sign-in station.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let id = null; // String | The id of the sign-in station to unlock.
let passcode = "passcode_example"; // String | The passcode to unlock the station.
let method = "method_example"; // String | The authentication method. Valid values are 'token' and 'cookie'.
apiInstance.stationunlock(id, passcode, method, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the sign-in station to unlock. | 
 **passcode** | **String**| The passcode to unlock the station. | 
 **method** | **String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## swipedelete

> swipedelete(token, id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the swipe to delete.
apiInstance.swipedelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the swipe to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## swipeget

> swipeget(token, id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the swipe to get.
apiInstance.swipeget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the swipe to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## swipelist

> swipelist(from, count, opts)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'token': "token_example" // String | The authentication token.
};
apiInstance.swipelist(from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## swipesave

> swipesave(opts)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.swipesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## swipesaveanonym

> swipesaveanonym(opts)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.swipesaveanonym(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## tagdelete

> tagdelete(token, id)

Delete a tag

Allows the user to delete an existing tag.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the tag to delete.
apiInstance.tagdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the tag to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## tagget

> tagget(token, id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the tag to get.
apiInstance.tagget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the tag to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## taglist

> taglist(token, group, from, count)

View a list of tags

Allows the user to view the list of tags.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let group = "group_example"; // String | The group of the tags to return.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.taglist(token, group, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **group** | **String**| The group of the tags to return. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## taglistgroups

> taglistgroups(token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag&#39;s settings.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.taglistgroups(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## tagsave

> tagsave(opts)

Create or edit a tag

Allows the user to create or edit a tag.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.tagsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## tagsearch

> tagsearch(token, query, opts)

Search for tags in the account

Allows the user to search for tags.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let query = "query_example"; // String | The query to search tags. Use group:<group> to search in a specific group (mandatory).
let opts = {
  'allowcreatingnew': true // Boolean | Specifies whether an option to create a new tag should be retrieved.
};
apiInstance.tagsearch(token, query, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **query** | **String**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **allowcreatingnew** | **Boolean**| Specifies whether an option to create a new tag should be retrieved. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateaddimage

> templateaddimage(token, template, upload, opts)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let template = null; // String | The id of the template where the image has to be added
let upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
let opts = {
  'filename': "filename_example" // String | The local name of the uploaded file. For later reference.
};
apiInstance.templateaddimage(token, template, upload, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **template** | [**String**](.md)| The id of the template where the image has to be added | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templatedelete

> templatedelete(token, id)

Delete a template

Allows the user to delete an existing template.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the template to delete.
apiInstance.templatedelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the template to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateemail

> templateemail(token, jobid, emailsubject, emailbody, opts)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let jobid = "jobid_example"; // String | The id of the job that is creating the templates.
let emailsubject = "emailsubject_example"; // String | Args depending on the send-to flag.
let emailbody = "emailbody_example"; // String | Args depending on the send-to flag.
let opts = {
  'templatekind': "templatekind_example", // String | The kind of the template you're sending. It must be included in (badge, certificate).
  'emailfrom': "emailfrom_example", // String | The name of the sender to be displayed in the receipients inbox
  'emailreplyto': "emailreplyto_example" // String | The reply-to field for the emails.
};
apiInstance.templateemail(token, jobid, emailsubject, emailbody, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **jobid** | **String**| The id of the job that is creating the templates. | 
 **emailsubject** | **String**| Args depending on the send-to flag. | 
 **emailbody** | **String**| Args depending on the send-to flag. | 
 **templatekind** | **String**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional] 
 **emailfrom** | **String**| The name of the sender to be displayed in the receipients inbox | [optional] 
 **emailreplyto** | **String**| The reply-to field for the emails. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templategenerate

> templategenerate(token, template, source, singlefile, opts)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let template = null; // String | The id of the template to generate.
let source = null; // String | The source key of the selected template data source.
let singlefile = true; // Boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
let opts = {
  'userid': "userid_example", // String | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
  'forsending': true, // Boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
  'role': null, // String | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
  'filters': "filters_example" // String | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...
};
apiInstance.templategenerate(token, template, source, singlefile, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **template** | [**String**](.md)| The id of the template to generate. | 
 **source** | [**String**](.md)| The source key of the selected template data source. | 
 **singlefile** | **Boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **Boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**String**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templateget

> templateget(token, id)

View details of a template

Allows the user to view a template and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the template to get.
apiInstance.templateget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the template to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templategetgenerated

> templategetgenerated(token, jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let jobid = "jobid_example"; // String | The id of the job that is creating the templates.
apiInstance.templategetgenerated(token, jobid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **jobid** | **String**| The id of the job that is creating the templates. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templatelist

> templatelist(token, from, count, kind, opts)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let kind = "kind_example"; // String | The kind of the templates to return. It must be included in (badge, certificate).
let opts = {
  'designedonly': true // Boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.
};
apiInstance.templatelist(token, from, count, kind, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **Boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templatelistsources

> templatelistsources(token, kind)

View a list of templates&#39; data sources

Allows the user to see tokens to be used in the template

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let kind = "kind_example"; // String | The kind of the templates to return. It must be included in (badge, certificate).
apiInstance.templatelistsources(token, kind, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templatesave

> templatesave(opts)

Create or edit a template

Allows the user to create or edit a template.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.templatesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## templatesavelayout

> templatesavelayout(opts)

Save the layout of a template

Allows the user to edit a template&#39;s layout.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.templatesavelayout(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## termdelete

> termdelete(token, id)

Delete a term

Allows the user to delete a term from the existing list.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the term to delete.
apiInstance.termdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the term to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## termget

> termget(token, id)

Search and view details of a term

Allows the user to view a term and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the term to get.
apiInstance.termget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the term to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## termlist

> termlist(token, opts)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'from': 56, // Number | The first record to return.
  'count': 56, // Number | The max number of records to return.
  'notpast': true // Boolean | Specifies whether the terms in the past should be returned or not.
};
apiInstance.termlist(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | [optional] 
 **count** | **Number**| The max number of records to return. | [optional] 
 **notpast** | **Boolean**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## termsave

> termsave(opts)

Create and edit terms

Allows the user to create and edit terms.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.termsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## textcreditremaining

> textcreditremaining(token)

Gets the remaining text credits for the account

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.textcreditremaining(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## texttoimage

> texttoimage(token, text, opts)

Generates a dynamic image from text

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let text = "text_example"; // String | The text to convert to an image, use double pipes (||) as a new line.
let opts = {
  'fontcolor': "fontcolor_example", // String | The color of the text, in hex format, without the #.
  'fontsize': 56, // Number | The size of the text, in points.
  'direction': "direction_example", // String | Either vertical or horizontal, default horizontal.
  'width': 56 // Number | The image width in pixels (or height if the direction is vertical).
};
apiInstance.texttoimage(token, text, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **text** | **String**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **String**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **Number**| The size of the text, in points. | [optional] 
 **direction** | **String**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **Number**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translationget

> translationget(token, universal)

Gets the translations of the specified values

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let universal = "universal_example"; // String | Pipe separated list of universal text to be translated.
apiInstance.translationget(token, universal, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **universal** | **String**| Pipe separated list of universal text to be translated. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translationgetcachefile

> translationgetcachefile(opts)

Get the file containing the translations

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'token': "token_example", // String | The authentication token.
  'account': "account_example" // String | The id of the account whose translations file has to be retrieved.
};
apiInstance.translationgetcachefile(opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | [optional] 
 **account** | **String**| The id of the account whose translations file has to be retrieved. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translationlist

> translationlist(token, opts)

Lists all the available translations in the system

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'filter': "filter_example", // String | Text to search/filter translations.
  'nondefaultonly': true, // Boolean | If true then it returns only the terms translated. Otherwise, it returns all.
  'appdefaultasuniversal': true // Boolean | If true then it uses the app default translation as the universal term.
};
apiInstance.translationlist(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **filter** | **String**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **Boolean**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **Boolean**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translationsave

> translationsave(opts)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.translationsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userchangepwd

> userchangepwd(token, oldpass, newpass)

Change user&#39;s own password

Allows the user to change their own password.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let oldpass = null; // String | The old password of the authenticated user.
let newpass = null; // String | The new password of the authenticated user.
apiInstance.userchangepwd(token, oldpass, newpass, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **oldpass** | [**String**](.md)| The old password of the authenticated user. | 
 **newpass** | [**String**](.md)| The new password of the authenticated user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userchangepwdbyreq

> userchangepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let changereq = "changereq_example"; // String | The change password request ID sent by email to the user.
let newpass = "newpass_example"; // String | The new password of the user.
apiInstance.userchangepwdbyreq(changereq, newpass, (error, data, response) => {
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
 **changereq** | **String**| The change password request ID sent by email to the user. | 
 **newpass** | **String**| The new password of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userdelete

> userdelete(token, id)

Delete a user

Allows the user to delete a user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the user to delete.
apiInstance.userdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userfindsimilar

> userfindsimilar(token, opts)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'currentid': null, // String | The id of the current user.
  'phonenumber': "phonenumber_example", // String | A phone number to search for similar users.
  'cardnumber': "cardnumber_example" // String | A card number to search for similar users.
};
apiInstance.userfindsimilar(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **currentid** | [**String**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **String**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **String**| A card number to search for similar users. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userget

> userget(token, id, opts)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the user to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.userget(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergetbycard

> usergetbycard(token, card, opts)

Search user by card number

Allows the user to search for a user by their card number.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let card = "card_example"; // String | The card number of the user to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.usergetbycard(token, card, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **card** | **String**| The card number of the user to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroupaddmember

> usergroupaddmember(token, userid, groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to add.
let groupid = null; // String | The id of the group.
apiInstance.usergroupaddmember(token, userid, groupid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **groupid** | [**String**](.md)| The id of the group. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroupdelete

> usergroupdelete(token, id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the group to delete.
apiInstance.usergroupdelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the group to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroupget

> usergroupget(token, id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the user group to get.
apiInstance.usergroupget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user group to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroupgetmembers

> usergroupgetmembers(token, groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let groupid = null; // String | The id of the user group to get.
apiInstance.usergroupgetmembers(token, groupid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **groupid** | [**String**](.md)| The id of the user group to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroupgetuser

> usergroupgetuser(token, userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to get his groups.
apiInstance.usergroupgetuser(token, userid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to get his groups. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergrouplist

> usergrouplist(token, opts)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'from': 56, // Number | The first record to return.
  'count': 56, // Number | The max number of records to return.
  'type': "type_example" // String | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.
};
apiInstance.usergrouplist(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | [optional] 
 **count** | **Number**| The max number of records to return. | [optional] 
 **type** | **String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergrouprefresh

> usergrouprefresh(token, group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let group = null; // String | The ID of the group to refresh.
apiInstance.usergrouprefresh(token, group, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **group** | [**String**](.md)| The ID of the group to refresh. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroupremovemember

> usergroupremovemember(token, userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let userid = null; // String | The id of the user to remove.
let groupid = null; // String | The id of the group.
apiInstance.usergroupremovemember(token, userid, groupid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **groupid** | [**String**](.md)| The id of the group. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroupsave

> usergroupsave(opts)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.usergroupsave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## usergrouptagmembers

> usergrouptagmembers(token, group, opts)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let group = null; // String | The id of the group to save whose members have to be tagged.
let opts = {
  'tags': "tags_example" // String | The tags to assign to the members of the specified group, in JSON format.
};
apiInstance.usergrouptagmembers(token, group, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **group** | [**String**](.md)| The id of the group to save whose members have to be tagged. | 
 **tags** | **String**| The tags to assign to the members of the specified group, in JSON format. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroupuntagmembers

> usergroupuntagmembers(token, group, opts)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let group = null; // String | The id of the group to save whose members have to be untagged.
let opts = {
  'tags': "tags_example" // String | The tags to unassign from the members of the specified group, in JSON format.
};
apiInstance.usergroupuntagmembers(token, group, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **group** | [**String**](.md)| The id of the group to save whose members have to be untagged. | 
 **tags** | **String**| The tags to unassign from the members of the specified group, in JSON format. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userlist

> userlist(token, from, count, opts)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'roleid': null, // String | The id of the role to filter users by, or empty to return all users.
  'onlywithoutcard': "onlywithoutcard_example", // String | If is 1 then only the users without a card are returned, otherwise all users are returned.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.userlist(token, from, count, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **roleid** | [**String**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userloadphoto

> userloadphoto(token, upload, opts)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
let opts = {
  'filename': "filename_example", // String | The local name of the uploaded file. For later reference.
  'userid': null, // String | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
  'automatch': true // Boolean | Set this to true to find the specific user based on the file name. 
};
apiInstance.userloadphoto(token, upload, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**String**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **Boolean**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usermovedata

> usermovedata(token, source, destination)

Move data between users

Allows administrators to move data between users.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let source = null; // String | The id of the user that is the source of the data.
let destination = null; // String | The id of the user that is the destination of the data.
apiInstance.usermovedata(token, source, destination, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **source** | [**String**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**String**](.md)| The id of the user that is the destination of the data. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofiledelete

> userprofiledelete(token, id)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the user profile to delete.
apiInstance.userprofiledelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user profile to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofileget

> userprofileget(token, id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the profile question set.
apiInstance.userprofileget(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the profile question set. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofilegetallview

> userprofilegetallview(token, opts)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'id': null // String | The id of the user to view, or empty for current user.
};
apiInstance.userprofilegetallview(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user to view, or empty for current user. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofilelist

> userprofilelist(token, opts)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'from': 56, // Number | The first record to return.
  'count': 56 // Number | The max number of records to return.
};
apiInstance.userprofilelist(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | [optional] 
 **count** | **Number**| The max number of records to return. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofilelistquestions

> userprofilelistquestions(token)

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.userprofilelistquestions(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofilepreparestats

> userprofilepreparestats(token, opts)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let opts = {
  'params': "params_example" // String | The ID of the group, specified as 'group=...'
};
apiInstance.userprofilepreparestats(token, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **params** | **String**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofilesave

> userprofilesave(opts)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.userprofilesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userprofilesaveanswers

> userprofilesaveanswers(opts)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.userprofilesaveanswers(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userrequestpwdchange

> userrequestpwdchange(domain, email)

Requests a password change

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let domain = "domain_example"; // String | The domain of the account where the user exists.
let email = "email_example"; // String | The email of the user.
apiInstance.userrequestpwdchange(domain, email, (error, data, response) => {
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
 **domain** | **String**| The domain of the account where the user exists. | 
 **email** | **String**| The email of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usersave

> usersave(opts)

Create or edit a user

Allows the user to create or edit a user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.usersave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## usersavepwdchange

> usersavepwdchange(opts)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.usersavepwdchange(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## usersettingsget

> usersettingsget(token, keys, opts)

Lists available user settings

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let keys = "keys_example"; // String | Setting key to get. Can be multiple separated by commas.
let opts = {
  'user': null // String | The user id whose settings have to be returned.
};
apiInstance.usersettingsget(token, keys, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **keys** | **String**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**String**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usersettingsgetmultiple

> usersettingsgetmultiple(token, keys, opts)

Get multiple user settings

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let keys = "keys_example"; // String | Setting key to get. Can be multiple separated by commas.
let opts = {
  'user': null // String | The user id whose settings have to be returned.
};
apiInstance.usersettingsgetmultiple(token, keys, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **keys** | **String**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**String**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usersettingssave

> usersettingssave(opts)

Saves a user setting

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.usersettingssave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## usersettingssavemultiple

> usersettingssavemultiple(opts)

Save multiple user settings at once

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.usersettingssavemultiple(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## version

> version(token)

Get current version information

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.version(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## virtuallineaddmyself

> virtuallineaddmyself(token, waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let waitinglineid = null; // String | ID of the waiting line to join.
apiInstance.virtuallineaddmyself(token, waitinglineid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **waitinglineid** | [**String**](.md)| ID of the waiting line to join. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## virtuallinelist

> virtuallinelist(token)

Lists waiting lines that have remote access enabled

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.virtuallinelist(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## virtuallineremovemyself

> virtuallineremovemyself(token)

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
apiInstance.virtuallineremovemyself(token, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineadduser

> waitinglineadduser(station, user, opts)

Put user in a waiting line

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station.
let user = "user_example"; // String | The user's card number.
let opts = {
  'locationid': null, // String | The location's id where the swipe must be saved.
  'time': new Date("2013-10-20T19:20:30+01:00"), // Date | The date and time of the swipe.
  'signinrole': "signinrole_example", // String | Specifies if the sign-in is for an attendee or a staff member
  'roleid': null, // String | Specifies the role the user has selected in order to sign-in
  'services': "services_example", // String | The services ids the user has selected.
  'eventid': null, // String | The id of the event the user selected.
  'staff': null, // String | The id of the staff member the user selected.
  'photosize': 56 // Number | The swiping user's photo size.
};
apiInstance.waitinglineadduser(station, user, opts, (error, data, response) => {
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
 **station** | [**String**](.md)| The id of the sign-in station. | 
 **user** | **String**| The user&#39;s card number. | 
 **locationid** | [**String**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **Date**| The date and time of the swipe. | [optional] 
 **signinrole** | **String**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**String**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **String**| The services ids the user has selected. | [optional] 
 **eventid** | [**String**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**String**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **Number**| The swiping user&#39;s photo size. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglinedelete

> waitinglinedelete(token, id)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the line to delete.
apiInstance.waitinglinedelete(token, id, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the line to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineget

> waitinglineget(token, id, opts)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the waiting line to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.waitinglineget(token, id, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the waiting line to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineisuserin

> waitinglineisuserin(station, time, user, opts)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let station = null; // String | The id of the sign-in station.
let time = new Date("2013-10-20T19:20:30+01:00"); // Date | The date and time of the swipe.
let user = "user_example"; // String | The card number of the user.
let opts = {
  'location': null // String | The id of the location the user picked.
};
apiInstance.waitinglineisuserin(station, time, user, opts, (error, data, response) => {
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
 **station** | [**String**](.md)| The id of the sign-in station. | 
 **time** | **Date**| The date and time of the swipe. | 
 **user** | **String**| The card number of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglinelist

> waitinglinelist(token, from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.waitinglinelist(token, from, count, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineremoveuser

> waitinglineremoveuser(token, waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let waitingline = null; // String | The id of the waiting line whose item has to be removed.
let itemid = null; // String | The ID of the item that has to be removed.
apiInstance.waitinglineremoveuser(token, waitingline, itemid, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **waitingline** | [**String**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**String**](.md)| The ID of the item that has to be removed. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglinesave

> waitinglinesave(opts)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.waitinglinesave(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## waitinglinesigninuser

> waitinglinesigninuser(token, waitingline, itemid, staff, opts)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let waitingline = null; // String | The id of the waiting line whose item needs to be signed-in.
let itemid = null; // String | The ID of the item that has to be signed-in.
let staff = null; // String | The id of the staff member selected to sign-in.
let opts = {
  'photosize': 56 // Number | The swiping user's photo size.
};
apiInstance.waitinglinesigninuser(token, waitingline, itemid, staff, opts, (error, data, response) => {
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
 **token** | **String**| The authentication token. | 
 **waitingline** | [**String**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**String**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**String**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **Number**| The swiping user&#39;s photo size. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

