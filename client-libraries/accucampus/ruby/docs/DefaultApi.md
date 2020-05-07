# OpenapiClient::DefaultApi

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



## actionassignmentdelete

> actionassignmentdelete(token, id)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the action assignment to delete.

begin
  #Remove an action item from an action plan
  api_instance.actionassignmentdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action assignment to delete. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentget

> actionassignmentget(token, id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the action assignment to get.

begin
  #Search and view details of an action item assigned to a user
  api_instance.actionassignmentget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action assignment to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentlist

> actionassignmentlist(token, from, count, opts)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  assignee: 56, # Integer | The assignee's id to filter the assignments.
  status: 56 # Integer | The status to filter the assignments.
}

begin
  #View a list of action items in a user's plan
  api_instance.actionassignmentlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **assignee** | **Integer**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **Integer**| The status to filter the assignments. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentlisthistory

> actionassignmentlisthistory(token, actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
actionassignment = 'actionassignment_example' # String | The action assignment's id whose history the user wants to get.

begin
  #View the history of an action item assigned to a user
  api_instance.actionassignmentlisthistory(token, actionassignment)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentlisthistory: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **actionassignment** | [**String**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentlistmine

> actionassignmentlistmine(token, from, count, opts)

List public action assignments assigned to the logged user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  status: 56 # Integer | The status to filter the assignments.
}

begin
  #List public action assignments assigned to the logged user
  api_instance.actionassignmentlistmine(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentlistmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **status** | **Integer**| The status to filter the assignments. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentlistpublichistory

> actionassignmentlistpublichistory(token, actionassignment)

List public action assignment history

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
actionassignment = 'actionassignment_example' # String | The action assignment's id whose history the user wants to get.

begin
  #List public action assignment history
  api_instance.actionassignmentlistpublichistory(token, actionassignment)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentlistpublichistory: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **actionassignment** | [**String**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
item = 'item_example' # String | The action item to assign.
opts = {
  assignee: 'assignee_example', # String | The assignee of the item.
  group: 'group_example', # String | The group to assing the item.
  notes: 'notes_example' # String | The assignment's notes.
}

begin
  #Bulk complete action items
  api_instance.actionassignmentmarkcomplete(token, item, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentmarkcomplete: #{e}"
end
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

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentsave

> actionassignmentsave(opts)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Add an action item to a user's action plan
  api_instance.actionassignmentsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Update an action item assigned to a user
  api_instance.actionassignmentsavehistory(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionassignmentsavehistory: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the action item to delete.

begin
  #Delete an action item
  api_instance.actionitemdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionitemdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action item to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the action item to get.

begin
  #Search and view details of an action item
  api_instance.actionitemget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionitemget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action item to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of action items
  api_instance.actionitemlist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionitemlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an action item
  api_instance.actionitemsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionitemsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  user: 'user_example', # String | The id of the user whose action logs have to be returned.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the logs.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The end date of the period to filter the logs.
  resource: 'resource_example', # String | The resource to filter the action logs.
  actionfilter: 'actionfilter_example', # String | The action to filter the action logs.
  argument: 'argument_example' # String | The id of the entity that was the argument of the executed action.
}

begin
  #View a list of users action logs
  api_instance.actionloglist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionloglist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **user** | [**String**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the logs. | [optional] 
 **resource** | **String**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **String**| The action to filter the action logs. | [optional] 
 **argument** | **String**| The id of the entity that was the argument of the executed action. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
pack = 'pack_example' # String | The id of the action pack to assign.
itemsdata = true # Boolean | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
opts = {
  assignee: 'assignee_example', # String | The assignee of the pack.
  group: 'group_example', # String | The group to assign the pack.
  notes: 'notes_example' # String | The assignment's notes.
}

begin
  #Assign an action item pack to a user
  api_instance.actionpackassign(token, pack, itemsdata, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionpackassign: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the action pack to delete.

begin
  #Delete an action item pack
  api_instance.actionpackdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionpackdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action pack to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the action pack to get.

begin
  #View details of an action item pack
  api_instance.actionpackget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionpackget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action pack to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of action item packs
  api_instance.actionpacklist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionpacklist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an action item pack
  api_instance.actionpacksave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actionpacksave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the action type to delete.

begin
  #Delete an action item type
  api_instance.actiontypedelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actiontypedelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action type to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the action type to get.

begin
  #View details of an action item type
  api_instance.actiontypeget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actiontypeget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the action type to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of action item types
  api_instance.actiontypelist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actiontypelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an action item type
  api_instance.actiontypesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->actiontypesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## adhocquerycheckexecution

> adhocquerycheckexecution(token, id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the ad hoc query execution to be checked.

begin
  #Check the status of an ad hoc query execution
  api_instance.adhocquerycheckexecution(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocquerycheckexecution: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the ad hoc query execution to be checked. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the ad hoc query to delete.

begin
  #Delete an ad hoc query
  api_instance.adhocquerydelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocquerydelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the ad hoc query to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  id: 'id_example', # String | The id of the query to execute.
  query: 'query_example' # String | The query to execute.
}

begin
  #Execute an ad hoc query
  api_instance.adhocqueryexecute(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocqueryexecute: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the query to execute. | [optional] 
 **query** | **String**| The query to execute. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the query to get.

begin
  #View details of an ad hoc query
  api_instance.adhocqueryget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocqueryget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the query to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View the database schema for making ad hoc queries
  api_instance.adhocquerygetschema(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocquerygetschema: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of saved ad hoc queries
  api_instance.adhocquerylist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocquerylist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  query: 'query_example' # String | The first record to return.
}

begin
  #View a list of ad hoc queries executions
  api_instance.adhocquerylistexecutions(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocquerylistexecutions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **query** | [**String**](.md)| The first record to return. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an ad hoc query
  api_instance.adhocquerysave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocquerysave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the ad hoc query execution to be stopped.

begin
  #Stops the execution of an ad hoc query
  api_instance.adhocquerystopexecution(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocquerystopexecution: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the ad hoc query execution to be stopped. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocreportsreqaccess

> adhocreportsreqaccess(token)

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Request access to the ad-hoc reports
  api_instance.adhocreportsreqaccess(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->adhocreportsreqaccess: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationcheckunknownuser

> advancedstationcheckunknownuser(station, user, location)

Check whether the user is known by the system.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.
location = 'location_example' # String | The id of the location the user picked.

begin
  #Check whether the user is known by the system.
  api_instance.advancedstationcheckunknownuser(station, user, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationcheckunknownuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationcheckuserrole

> advancedstationcheckuserrole(station, user, location)

Check whether the user is a staff member, an attendee or both.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.
location = 'location_example' # String | The id of the location the user picked.

begin
  #Check whether the user is a staff member, an attendee or both.
  api_instance.advancedstationcheckuserrole(station, user, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationcheckuserrole: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationcreateuser

> advancedstationcreateuser(station, user, location, firstname, lastname, email, opts)

Creates a user via a sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user to create.
location = 'location_example' # String | The id of the location the user picked.
firstname = 'firstname_example' # String | The first name of the user to create.
lastname = 'lastname_example' # String | The last name of the user to create.
email = 'email_example' # String | The email of the user to create.
opts = {
  middlename: 'middlename_example' # String | The middle name of the user to create.
}

begin
  #Creates a user via a sign-in station.
  api_instance.advancedstationcreateuser(station, user, location, firstname, lastname, email, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationcreateuser: #{e}"
end
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

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationgetevents

> advancedstationgetevents(station, location, user)

Gets the courses available for a specific location and a specific student.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
location = 'location_example' # String | The id of the location the student picked.
user = 'user_example' # String | The card of the user.

begin
  #Gets the courses available for a specific location and a specific student.
  api_instance.advancedstationgetevents(station, location, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationgetevents: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **location** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationgetinfo

> advancedstationgetinfo(id, opts)

Gets the info to display in the sign-in station by it's ID.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
id = 'id_example' # String | The id of the sign-in station to get.
opts = {
  event: 'event_example' # String | The id of the event (or session), to override the scheduled one.
}

begin
  #Gets the info to display in the sign-in station by it's ID.
  api_instance.advancedstationgetinfo(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationgetinfo: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to get. | 
 **event** | [**String**](.md)| The id of the event (or session), to override the scheduled one. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationgetlocations

> advancedstationgetlocations(station, user)

Gets the locations available in a sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station whose locations have to be returned.
user = 'user_example' # String | The card of the user.

begin
  #Gets the locations available in a sign-in station.
  api_instance.advancedstationgetlocations(station, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationgetlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station whose locations have to be returned. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationgetlogstaff

> advancedstationgetlogstaff(station, attendancelog, opts)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
attendancelog = 'attendancelog_example' # String | The id of the attendance log to filter the staff members.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
  api_instance.advancedstationgetlogstaff(station, attendancelog, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationgetlogstaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **attendancelog** | [**String**](.md)| The id of the attendance log to filter the staff members. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationgetroles

> advancedstationgetroles(station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
signinrole = 'signinrole_example' # String | Specifies how the user is signing-in.
user = 'user_example' # String | The card of the user.
location = 'location_example' # String | The id of the location the user picked.

begin
  #Gets the user roles of the user trying to sign-in.
  api_instance.advancedstationgetroles(station, signinrole, user, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationgetroles: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **signinrole** | **String**| Specifies how the user is signing-in. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationgetservices

> advancedstationgetservices(station, location, user)

Gets the services available for a specific location.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
location = 'location_example' # String | The id of the location the student picked.
user = 'user_example' # String | The card of the user.

begin
  #Gets the services available for a specific location.
  api_instance.advancedstationgetservices(station, location, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationgetservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **location** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationgetstaff

> advancedstationgetstaff(station, locationid, user, opts)

Gets the staff/tutors available for a specific location, course and service.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
locationid = 'locationid_example' # String | The id of the location the student picked.
user = 'user_example' # String | The card of the user.
opts = {
  services: 'services_example', # String | The list of services selected by the user, in JSON format.
  eventid: 'eventid_example', # String | The ID of the event selected.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Gets the staff/tutors available for a specific location, course and service.
  api_instance.advancedstationgetstaff(station, locationid, user, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationgetstaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **locationid** | [**String**](.md)| The id of the location the student picked. | 
 **user** | **String**| The card of the user. | 
 **services** | **String**| The list of services selected by the user, in JSON format. | [optional] 
 **eventid** | [**String**](.md)| The ID of the event selected. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advancedstationissignedin

> advancedstationissignedin(station, time, user, opts)

Gets whether a user is signed-in or not.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
time = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time of the swipe.
user = 'user_example' # String | The card of the user.
opts = {
  location: 'location_example' # String | The id of the location the user picked.
}

begin
  #Gets whether a user is signed-in or not.
  api_instance.advancedstationissignedin(station, time, user, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advancedstationissignedin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **time** | **DateTime**| The date and time of the swipe. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleaddmissing

> advroleaddmissing(token, roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
roles = 'roles_example' # String | CSV list of the role ids to check
permissions = 'permissions_example' # String | CSV list of the permissions to check

begin
  #Adds the missing permissions to a role. Requires access to advrole.save
  api_instance.advroleaddmissing(token, roles, permissions)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advroleaddmissing: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **roles** | **String**| CSV list of the role ids to check | 
 **permissions** | **String**| CSV list of the permissions to check | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolecheckperm

> advrolecheckperm(token, roles, permissions)

Checks the permissions are assigned for the given roles

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
roles = 'roles_example' # String | CSV list of the role ids to check
permissions = 'permissions_example' # String | CSV list of the permissions to check

begin
  #Checks the permissions are assigned for the given roles
  api_instance.advrolecheckperm(token, roles, permissions)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advrolecheckperm: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **roles** | **String**| CSV list of the role ids to check | 
 **permissions** | **String**| CSV list of the permissions to check | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the location to delete.

begin
  #Delete a role
  api_instance.advroledelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advroledelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the location to delete. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroledeletemapping

> advroledeletemapping(token, map, roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
map = 'map_example' # String | The map name to save the role.
roleid = 'roleid_example' # String | The id of the role.

begin
  #Delete a role mapping
  api_instance.advroledeletemapping(token, map, roleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advroledeletemapping: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **map** | **String**| The map name to save the role. | 
 **roleid** | [**String**](.md)| The id of the role. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the location to get.

begin
  #View details of a role
  api_instance.advroleget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advroleget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the location to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolelist

> advrolelist(token, opts)

Lists the roles for the current account

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  includepolicies: true, # Boolean | True to include the policies, defaults to false.
  includeinternal: true, # Boolean | True to include the internal roles too.
  name: 'name_example' # String | Filter by name of the role.
}

begin
  #Lists the roles for the current account
  api_instance.advrolelist(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advrolelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **includepolicies** | **Boolean**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **Boolean**| True to include the internal roles too. | [optional] 
 **name** | **String**| Filter by name of the role. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolelistmaps

> advrolelistmaps(token, roleid)

Lists the maps a roles is mapped to

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
roleid = 'roleid_example' # String | The id of the role to list the maps.

begin
  #Lists the maps a roles is mapped to
  api_instance.advrolelistmaps(token, roleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advrolelistmaps: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **roleid** | [**String**](.md)| The id of the role to list the maps. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolelistrolesmapped

> advrolelistrolesmapped(token, opts)

Lists the roles mappings

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  map: 'map_example' # String | List only the roles in the specified map.
}

begin
  #Lists the roles mappings
  api_instance.advrolelistrolesmapped(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advrolelistrolesmapped: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **map** | **String**| List only the roles in the specified map. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View a list of role templates
  api_instance.advrolelisttemplates(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advrolelisttemplates: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrolesave

> advrolesave(opts)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a role
  api_instance.advrolesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advrolesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## advrolesavemapping

> advrolesavemapping(opts)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a role mapping
  api_instance.advrolesavemapping(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advrolesavemapping: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## advrolesuserlist

> advrolesuserlist(token, from, count, opts)

List users. Alias to user.list, use that one instead.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  roleid: 'roleid_example', # String | The id of the role to filter users by, or empty to return all users.
  onlywithoutcard: 'onlywithoutcard_example', # String | If is 1 then only the users without a card are returned, otherwise all users are returned.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #List users. Alias to user.list, use that one instead.
  api_instance.advrolesuserlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advrolesuserlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **roleid** | [**String**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | Id of the user to upgrade
roleid = 'roleid_example' # String | Id of the role to add

begin
  #Upgrade a user to another role (requires permission to edit those roles)
  api_instance.advroleuserupgrade(token, userid, roleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->advroleuserupgrade: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| Id of the user to upgrade | 
 **roleid** | [**String**](.md)| Id of the role to add | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to cancel.

begin
  #Cancel an appointment
  api_instance.appointmentcancel(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentcancel: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to cancel. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentcheckisvalid

> appointmentcheckisvalid(token, id, opts)

Check if an appointment is valid or not

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to check.
opts = {
  editing: true # Boolean | Specifies whether the check is for a new appointment or an existing one.
}

begin
  #Check if an appointment is valid or not
  api_instance.appointmentcheckisvalid(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentcheckisvalid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to check. | 
 **editing** | **Boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmenteditanyway

> appointmenteditanyway(token, id, attendee, staff, location, start, _end, opts)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to edit.
attendee = 'attendee_example' # String | The id of the attendee involved in the appointment.
staff = 'staff_example' # String | The id of the staff member involved in the appointment.
location = 'location_example' # String | The id of the location where the appointment will take place.
start = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The appointment's start date & time.
_end = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The appointment's end date & time.
opts = {
  term: 'term_example', # String | The id of the term when the appointment takes place.
  event: 'event_example', # String | The id of the event of the appointment.
  services: 'services_example', # String | Comma-separated string containing the ids of the services of the appointment.
  notes: 'notes_example' # String | The notes of the appointment.
}

begin
  #Edit an appointment even if it breaks activated rules
  api_instance.appointmenteditanyway(token, id, attendee, staff, location, start, _end, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmenteditanyway: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to edit. | 
 **attendee** | [**String**](.md)| The id of the attendee involved in the appointment. | 
 **staff** | [**String**](.md)| The id of the staff member involved in the appointment. | 
 **location** | [**String**](.md)| The id of the location where the appointment will take place. | 
 **start** | **DateTime**| The appointment&#39;s start date &amp; time. | 
 **_end** | **DateTime**| The appointment&#39;s end date &amp; time. | 
 **term** | [**String**](.md)| The id of the term when the appointment takes place. | [optional] 
 **event** | [**String**](.md)| The id of the event of the appointment. | [optional] 
 **services** | **String**| Comma-separated string containing the ids of the services of the appointment. | [optional] 
 **notes** | **String**| The notes of the appointment. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to edit its presence.
showedup = true # Boolean | Specifies whether the attendee was showed-up or not in the appointment.

begin
  #Edit the no-show status of an appointment
  api_instance.appointmenteditpresence(token, id, showedup)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmenteditpresence: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to edit its presence. | 
 **showedup** | **Boolean**| Specifies whether the attendee was showed-up or not in the appointment. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
serviceids = 'serviceids_example' # String | CSV list of the service Ids to filter by.
locationid = 'locationid_example' # String | The id of the service to filter by.
opts = {
  eventid: 'eventid_example', # String | The id of the event to filter by.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Finds all staff available slots filtered by service, date, etc
  api_instance.appointmentfindallstaffslots(token, starttime, endtime, serviceids, locationid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentfindallstaffslots: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | 
 **locationid** | [**String**](.md)| The id of the service to filter by. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
staffid = 'staffid_example' # String | The id of the staff to filter by.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
serviceids = 'serviceids_example' # String | CSV list of the service Ids to filter by.
opts = {
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example' # String | The id of the service to filter by.
}

begin
  #Finds available slots filtered by service, date, staff, etc
  api_instance.appointmentfindslots(token, staffid, starttime, endtime, serviceids, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentfindslots: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **staffid** | [**String**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceids = 'serviceids_example' # String | CSV list of the service ids to filter by.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
opts = {
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example', # String | The id of the service to filter by.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Finds staff available by service, date, event, etc
  api_instance.appointmentfindstaff(token, serviceids, starttime, endtime, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentfindstaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceids** | **String**| CSV list of the service ids to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to get.

begin
  #Search and view details of an appointment
  api_instance.appointmentget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentgetcurrent

> appointmentgetcurrent(station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.
location = 'location_example' # String | The id of the location where the user wants to sign-in.

begin
  #Get the current appointments for the user that is about to sign-in via the specified sign-in station.
  api_instance.appointmentgetcurrent(station, user, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentgetcurrent: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 
 **location** | [**String**](.md)| The id of the location where the user wants to sign-in. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceid = 'serviceid_example' # String | The id of the service to get its locations.

begin
  #Find locations where a service is available
  api_instance.appointmentgetlocations(token, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentgetlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the appointments.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The end date of the period to filter the appointments.
  userid: 'userid_example' # String | The attendee id to filter the appointments.
}

begin
  #View a list of appointments
  api_instance.appointmentlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **startdate** | **DateTime**| The start date of the period to filter the appointments. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the appointments. | [optional] 
 **userid** | [**String**](.md)| The attendee id to filter the appointments. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentlistmine

> appointmentlistmine(token, opts)

View all my upcoming appointments

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  start: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | If specified, only appointments that start after the specified date will be returned.
  modifiedafter: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | If specified, only appointments modified after the specified date will be returned.
}

begin
  #View all my upcoming appointments
  api_instance.appointmentlistmine(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentlistmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **start** | **DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  start: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | If specified, only appointments that start after the specified date will be returned.
  modifiedafter: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | If specified, only appointments modified after the specified date will be returned.
}

begin
  #Search and view details of all my upcoming appointments
  api_instance.appointmentlistupcoming(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentlistupcoming: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **start** | **DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentrescheduleoutlook

> appointmentrescheduleoutlook(token, id, start, _end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to edit.
start = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The appointment's start date & time.
_end = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The appointment's end date & time.

begin
  #Reschedule an appointment from MS Outlook.
  api_instance.appointmentrescheduleoutlook(token, id, start, _end)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentrescheduleoutlook: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to edit. | 
 **start** | **DateTime**| The appointment&#39;s start date &amp; time. | 
 **_end** | **DateTime**| The appointment&#39;s end date &amp; time. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to restore.

begin
  #Restore an appointment
  api_instance.appointmentrestore(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentrestore: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to restore. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to restore.

begin
  #Restore an appointment even if it breaks activated rules
  api_instance.appointmentrestoreanyway(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentrestoreanyway: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to restore. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Schedule an appointment
  api_instance.appointmentsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to set as valid.

begin
  #Schedule an appointment even if it breaks activated rules
  api_instance.appointmentsetasvalid(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentsetasvalid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to set as valid. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View the locations with most appointments
  api_instance.appointmentsuggestlocations(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentsuggestlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View the services with most appointments
  api_instance.appointmentsuggestservices(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentsuggestservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appointmentvoid

> appointmentvoid(token, id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the appointment to cancel.

begin
  #Void an appointment
  api_instance.appointmentvoid(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appointmentvoid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the appointment to cancel. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appsharegetphone

> appsharegetphone(token)

Gets the phone number of the current user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Gets the phone number of the current user
  api_instance.appsharegetphone(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appsharegetphone: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## appsharesendtext

> appsharesendtext(token, opts)

Sends an SMS with the link to the app

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  phonenumber: 'phonenumber_example' # String | Phone number to where to send the link. Leave empty to the number on file.
}

begin
  #Sends an SMS with the link to the app
  api_instance.appsharesendtext(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->appsharesendtext: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **phonenumber** | **String**| Phone number to where to send the link. Leave empty to the number on file. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentdelete

> attendancelogcommentdelete(token, id)

Delete a comment on an attendance log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the attendance log comment to delete.

begin
  #Delete a comment on an attendance log
  api_instance.attendancelogcommentdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogcommentdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log comment to delete. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentget

> attendancelogcommentget(token, id)

View a comment on an attendance log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the comment to get.

begin
  #View a comment on an attendance log
  api_instance.attendancelogcommentget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogcommentget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the comment to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentlist

> attendancelogcommentlist(attendancelog, opts)

View all the comments on a specific attendance log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
attendancelog = 'attendancelog_example' # String | The id of the attendance log whose comments have to be retrieved.
opts = {
  token: 'token_example' # String | The authentication token.
}

begin
  #View all the comments on a specific attendance log
  api_instance.attendancelogcommentlist(attendancelog, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogcommentlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**String**](.md)| The id of the attendance log whose comments have to be retrieved. | 
 **token** | **String**| The authentication token. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogcommentsave

> attendancelogcommentsave(opts)

Save a comment on an attendance log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save a comment on an attendance log
  api_instance.attendancelogcommentsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogcommentsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the attendance log to delete.

begin
  #Delete an attendance log
  api_instance.attendancelogdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the attendance log to get.

begin
  #Search and view details of an attendance log
  api_instance.attendancelogget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendanceloggetchangehistory

> attendanceloggetchangehistory(token, id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the attendance log to get.

begin
  #Search and view details of an attendance log's swipe history
  api_instance.attendanceloggetchangehistory(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendanceloggetchangehistory: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  token: 'token_example', # String | The authentication token.
  filter: 'filter_example', # String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
  userid: 'userid_example' # String | The user ID of the user to get the logs.
}

begin
  #View a list of attendance logs
  api_instance.attendanceloglist(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendanceloglist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **token** | **String**| The authentication token. | [optional] 
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**String**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendanceloglistmine

> attendanceloglistmine(from, count, opts)

Gets the attendance logs of the current user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  token: 'token_example', # String | The authentication token.
  filter: 'filter_example' # String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
}

begin
  #Gets the attendance logs of the current user
  api_instance.attendanceloglistmine(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendanceloglistmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **token** | **String**| The authentication token. | [optional] 
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogliststaff

> attendancelogliststaff(from, count, opts)

Gets the attendance logs that the current user is involved in as staff

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  token: 'token_example', # String | The authentication token.
  filter: 'filter_example' # String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
}

begin
  #Gets the attendance logs that the current user is involved in as staff
  api_instance.attendancelogliststaff(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogliststaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **token** | **String**| The authentication token. | [optional] 
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an attendance log
  api_instance.attendancelogsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## attendancelogsignout

> attendancelogsignout(token, opts)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  id: 'id_example', # String | The id of the attendance log to sign-out.
  location: 'location_example', # String | The id of the location to filter the users to sign out.
  event: 'event_example', # String | The id of the event to filter the users to sign out.
  datetime: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | Specifies the date and time when the specified logs have to be signed out.
}

begin
  #Sign out an attendance log
  api_instance.attendancelogsignout(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogsignout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**String**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **event** | [**String**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **DateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## attendancelogwhosin

> attendancelogwhosin(from, count, opts)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  token: 'token_example', # String | The authentication token.
  location: 'location_example', # String | The id of the location to search for users that are in.
  event: 'event_example', # String | The id of the event to search for users that are in.
  sorting: 'sorting_example', # String | Field to sort by. Either first-name, last-name or sign-in-time.
  roles: 'roles_example', # String | The comma-separated list of ids of the roles to search for users that are in.
  photosize: 56, # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  extensions: 'extensions_example', # String | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
  export: true # Boolean | True to export the results as CSV
}

begin
  #View who's in a location
  api_instance.attendancelogwhosin(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancelogwhosin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **token** | **String**| The authentication token. | [optional] 
 **location** | [**String**](.md)| The id of the location to search for users that are in. | [optional] 
 **event** | [**String**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **String**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **String**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **Boolean**| True to export the results as CSV | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the restriction to delete.

begin
  #Delete an attendance restriction
  api_instance.attendancerestrictiondelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancerestrictiondelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the restriction to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the restriction to get.

begin
  #View details of an attendance restriction
  api_instance.attendancerestrictionget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancerestrictionget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the restriction to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of attendance restrictions
  api_instance.attendancerestrictionlist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancerestrictionlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an attendance restriction
  api_instance.attendancerestrictionsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->attendancerestrictionsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the beacon to delete.

begin
  #Delete a beacon profile
  api_instance.beacondelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beacondelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the beacon to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Disable beacon support account wide
  api_instance.beacondisable(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beacondisable: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the beacon to get.

begin
  #View details of a beacon profile
  api_instance.beaconget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the beacon to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacongetlocations

> beacongetlocations(token, beacons)

Get the sign-in stations assigned to specific beacons.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
beacons = 'beacons_example' # String | A JSON array containg the beacons data (region, minor and major) values.

begin
  #Get the sign-in stations assigned to specific beacons.
  api_instance.beacongetlocations(token, beacons)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beacongetlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacongetstationlocation

> beacongetstationlocation(token, station, location)

Get the location settings in the specified sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
station = 'station_example' # String | The id of the sign-in station whose location information has to be retrieved.
location = 'location_example' # String | The id of the location whose information has to be retrieved.

begin
  #Get the location settings in the specified sign-in station.
  api_instance.beacongetstationlocation(token, station, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beacongetstationlocation: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **station** | [**String**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
 **location** | [**String**](.md)| The id of the location whose information has to be retrieved. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacongetuuid

> beacongetuuid(token)

View the identifier for the account's beacon region (for sign-in stations).

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View the identifier for the account's beacon region (for sign-in stations).
  api_instance.beacongetuuid(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beacongetuuid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of beacon profiles
  api_instance.beaconlist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View a list of beacon profiles with their characteristics
  api_instance.beaconlistprofiles(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconlistprofiles: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconresetuuid

> beaconresetuuid(token)

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Generate or reset the identifier for the account's beacon region.
  api_instance.beaconresetuuid(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconresetuuid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a beacon profile
  api_instance.beaconsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## beaconscanlocations

> beaconscanlocations(token, beacons)

Check if there's location available to sign-in / out.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
beacons = 'beacons_example' # String | A JSON array containg the beacons data (region, minor and major) values.

begin
  #Check if there's location available to sign-in / out.
  api_instance.beaconscanlocations(token, beacons)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconscanlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsetuuid

> beaconsetuuid(token, id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The custom region UUID.

begin
  #Set the identifier for the account's beacon region (for sign-in stations).
  api_instance.beaconsetuuid(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconsetuuid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The custom region UUID. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsilentregions

> beaconsilentregions(token)

View all the beacon regions defined for silent tracking

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View all the beacon regions defined for silent tracking
  api_instance.beaconsilentregions(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconsilentregions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsilentsignin

> beaconsilentsignin(token, uuid)

Sign-in silently from the location specified by a beacon

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
uuid = 'uuid_example' # String | The id of the region the user is in.

begin
  #Sign-in silently from the location specified by a beacon
  api_instance.beaconsilentsignin(token, uuid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconsilentsignin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **uuid** | [**String**](.md)| The id of the region the user is in. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconsilentsignout

> beaconsilentsignout(token, uuid)

Sign-out silently from the location specified by a beacon

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
uuid = 'uuid_example' # String | The id of the region the user has left.

begin
  #Sign-out silently from the location specified by a beacon
  api_instance.beaconsilentsignout(token, uuid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->beaconsilentsignout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **uuid** | [**String**](.md)| The id of the region the user has left. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## bgjobgetstatus

> bgjobgetstatus(token, opts)

Get background job status

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  jobid: 'jobid_example', # String | The ID of the job to get the status. 10 most recent will be returned if not specified.
  jobtype: 'jobtype_example' # String | The job type to filter by.
}

begin
  #Get background job status
  api_instance.bgjobgetstatus(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->bgjobgetstatus: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **jobid** | [**String**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **String**| The job type to filter by. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## captchagetchallenge

> captchagetchallenge

Gets a captcha challenge that the user must complete to do certain requests.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new

begin
  #Gets a captcha challenge that the user must complete to do certain requests.
  api_instance.captchagetchallenge
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->captchagetchallenge: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## captchagetimage

> captchagetimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
captchatoken = 'captchatoken_example' # String | The captcha token or ID returned by the captcha.getchallenge action

begin
  #Gets a captcha image that the user must complete to do certain requests.
  api_instance.captchagetimage(captchatoken)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->captchagetimage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **String**| The captcha token or ID returned by the captcha.getchallenge action | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## changelog

> changelog(token)

Get the application change log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Get the application change log
  api_instance.changelog(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->changelog: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## clientget

> clientget(token, client, opts)

Get client

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
client = 'client_example' # String | The unique id of the client.
opts = {
  clientname: 'clientname_example' # String | The custom name of the client.
}

begin
  #Get client
  api_instance.clientget(token, client, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->clientget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **client** | **String**| The unique id of the client. | 
 **clientname** | **String**| The custom name of the client. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## clientlist

> clientlist(token, from, count)

Gets the clients of the specified conference

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #Gets the clients of the specified conference
  api_instance.clientlist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->clientlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## clientsave

> clientsave(opts)

Saves a client

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a client
  api_instance.clientsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->clientsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## clientsendmessage

> clientsendmessage(token, uniqueclientid, message)

Send a message to a client

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
uniqueclientid = 'uniqueclientid_example' # String | The unique id of the client.
message = 'message_example' # String | The body of the message to send.

begin
  #Send a message to a client
  api_instance.clientsendmessage(token, uniqueclientid, message)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->clientsendmessage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **uniqueclientid** | [**String**](.md)| The unique id of the client. | 
 **message** | **String**| The body of the message to send. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Sends an invitation to everyone to AccuCampus Communities
  api_instance.communityinvite(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->communityinvite: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Sends an invitation for myself to AccuCampus Communities
  api_instance.communityjoin(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->communityjoin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the category to delete.

begin
  #Delete a compass category
  api_instance.compasscategorydelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->compasscategorydelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the category to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the category to get.

begin
  #View details of a compass category
  api_instance.compasscategoryget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->compasscategoryget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the category to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  from: 56, # Integer | The first record to return.
  count: 56, # Integer | The max number of records to return.
  onlywithservices: true # Boolean | Specified whether only categories with services are returned or all.
}

begin
  #View a list of compass categories
  api_instance.compasscategorylist(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->compasscategorylist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | [optional] 
 **count** | **Integer**| The max number of records to return. | [optional] 
 **onlywithservices** | **Boolean**| Specified whether only categories with services are returned or all. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a compass category
  api_instance.compasscategorysave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->compasscategorysave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## compassservicelist

> compassservicelist(token, opts)

View all the services added to the compass

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  category: 'category_example' # String | The id of the category to filter the services.
}

begin
  #View all the services added to the compass
  api_instance.compassservicelist(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->compassservicelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **category** | [**String**](.md)| The id of the category to filter the services. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compassservicelistlocations

> compassservicelistlocations(token, serviceid)

View all the locations where a service added to the compass is available

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceid = 'serviceid_example' # String | The id of the service to get its locations.

begin
  #View all the locations where a service added to the compass is available
  api_instance.compassservicelistlocations(token, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->compassservicelistlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The unique device id of the computer to delete.

begin
  #Delete a computer
  api_instance.computerlabdeletecomputer(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlabdeletecomputer: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | **String**| The unique device id of the computer to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The unique device id of the computer to get.

begin
  #Search and view details of a computer
  api_instance.computerlabgetcomputer(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlabgetcomputer: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | **String**| The unique device id of the computer to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
id = 'id_example' # String | The id of the computer lab/location.

begin
  #Loads the settings for a computer lab
  api_instance.computerlabgetsettings(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlabgetsettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the computer lab/location. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabissignedin

> computerlabissignedin(station, user)

Gets whether a user is signed-in or not.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.

begin
  #Gets whether a user is signed-in or not.
  api_instance.computerlabissignedin(station, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlabissignedin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  location: 'location_example', # String | The id of the location whose computers have to be returned.
  freeonly: true # Boolean | If true, only free computers will be returned.
}

begin
  #View a list of computers
  api_instance.computerlablistcomputers(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlablistcomputers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **location** | [**String**](.md)| The id of the location whose computers have to be returned. | [optional] 
 **freeonly** | **Boolean**| If true, only free computers will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View a list of the locations that use the Computer Lab add-on
  api_instance.computerlablistlabs(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlablistlabs: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View a list of sign-in stations available for computer labs.
  api_instance.computerlabliststations(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlabliststations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a computer
  api_instance.computerlabsavecomputer(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlabsavecomputer: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves the settings for a computer lab
  api_instance.computerlabsavesettings(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlabsavesettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## computerlabsaveswipe

> computerlabsaveswipe(opts)

Save a new swipe from a computer in a computer lab.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save a new swipe from a computer in a computer lab.
  api_instance.computerlabsaveswipe(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->computerlabsaveswipe: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
hierarchykey = 'hierarchykey_example' # String | The hierarchy key of the record to delete.

begin
  #Deletes a dead-end record group
  api_instance.deadendrecordingdelete(token, hierarchykey)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->deadendrecordingdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **hierarchykey** | **String**| The hierarchy key of the record to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Lists the recorded dead ends, if enabled
  api_instance.deadendrecordinglist(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->deadendrecordinglist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
hierarchykey = 'hierarchykey_example' # String | The hierarchy key of the record to get the feedback.

begin
  #Lists the comments for a specific dead end
  api_instance.deadendrecordinglistcomments(token, hierarchykey)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->deadendrecordinglistcomments: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **hierarchykey** | **String**| The hierarchy key of the record to get the feedback. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## deadendrecordingsave

> deadendrecordingsave(opts)

Saves a dead-end record

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a dead-end record
  api_instance.deadendrecordingsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->deadendrecordingsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the department to delete.

begin
  #Delete a college department
  api_instance.departmentdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->departmentdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the department to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the department to get.

begin
  #Search and view details of a college department
  api_instance.departmentget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->departmentget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the department to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of college departments
  api_instance.departmentlist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->departmentlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a college department
  api_instance.departmentsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->departmentsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  excludeanonymous: true # Boolean | If true it excludes the anonymous actions from the returned list.
}

begin
  #Get the documentation
  api_instance.doc(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->doc: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **Boolean**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # String | The original filename, needed to process the file.

begin
  #Adds background image for the login
  api_instance.easyloginaddbgimage(token, upload, filename)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->easyloginaddbgimage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The original filename, needed to process the file. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventchecksessions

> eventchecksessions(token, eventid, autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The id of the event to check.
autorepair = true # Boolean | True to automatically fix the invalid sessions.

begin
  #Edit an event's sessions according to their schedule
  api_instance.eventchecksessions(token, eventid, autorepair)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventchecksessions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event to check. | 
 **autorepair** | **Boolean**| True to automatically fix the invalid sessions. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the event to delete.

begin
  #Delete a course
  api_instance.eventdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the event to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the event to get.

begin
  #Search and view details of a course
  api_instance.eventget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the event to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  location: 'location_example', # String | The location to filter the events.
  date: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The date to filter the events. Today will be used if this parameter is omitted.
  type: 'type_example' # String | Type of event to list.
}

begin
  #View a list of courses by date
  api_instance.eventgetsessionsbydate(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventgetsessionsbydate: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **location** | [**String**](.md)| The location to filter the events. | [optional] 
 **date** | **DateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **String**| Type of event to list. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 'from_example' # String | The first record to return.
count = 'count_example' # String | The max number of records to return.
opts = {
  summaryonly: true, # Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  termid: 'termid_example' # String | Id of the term to list the events. Null to list all events.
}

begin
  #View a list of courses
  api_instance.eventlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventlist: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 'from_example' # String | The first record to return.
count = 'count_example' # String | The max number of records to return.
opts = {
  summaryonly: true, # Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  termid: 'termid_example' # String | Id of the term to list the events. Null to list all events.
}

begin
  #View a list of courses I am registered to
  api_instance.eventlistregistered(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventlistregistered: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The id of the event.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register current user to a course
  api_instance.eventregaddme(token, eventid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregaddme: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register current user to all courses
  api_instance.eventregaddmetoall(token, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregaddmetoall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
codegroup = 'codegroup_example' # String | The code used to group events.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register current user to a course group
  api_instance.eventregaddmetogroup(token, codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregaddmetogroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **codegroup** | **String**| The code used to group events. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to add.
eventid = 'eventid_example' # String | The id of the event.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register a user to a course for attendance
  api_instance.eventregadduser(token, userid, eventid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregadduser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to add.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register a user to assist with all courses
  api_instance.eventregaddusertoall(token, userid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregaddusertoall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to add.
codegroup = 'codegroup_example' # String | The code used to group events.
listname = 'listname_example' # String | The name of the list where the user has to be registered.

begin
  #Register a user to an course group
  api_instance.eventregaddusertogroup(token, userid, codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregaddusertogroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **codegroup** | **String**| The code used to group events. | 
 **listname** | **String**| The name of the list where the user has to be registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The user id to list events.
listname = 'listname_example' # String | The name of the list where the user is registered.
opts = {
  termid: 'termid_example', # String | The term id to list events.
  namefilter: 'namefilter_example' # String | The value used to filter the events by name.
}

begin
  #View course registration by user
  api_instance.eventreggetevents(token, userid, listname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventreggetevents: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The user id to list events.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Lists the course group registrations of a user
  api_instance.eventreggetgroups(token, userid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventreggetgroups: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The user id to list events. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventreggetmyevents

> eventreggetmyevents(token, listname, opts)

View the event registrations of the current user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
listname = 'listname_example' # String | The name of the list where the user is registered.
opts = {
  termid: 'termid_example', # String | The term id to list events.
  namefilter: 'namefilter_example' # String | The value used to filter the events by name.
}

begin
  #View the event registrations of the current user
  api_instance.eventreggetmyevents(token, listname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventreggetmyevents: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list where the user is registered. | 
 **termid** | [**String**](.md)| The term id to list events. | [optional] 
 **namefilter** | **String**| The value used to filter the events by name. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #View all current user registrations to course groups
  api_instance.eventreggetmygroups(token, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventreggetmygroups: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The event id to list users.
listname = 'listname_example' # String | The name of the list to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View course registration
  api_instance.eventreggetusers(token, eventid, listname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventreggetusers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The event id to list users. | 
 **listname** | **String**| The name of the list to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
codegroup = 'codegroup_example' # String | The code group to list users.
listname = 'listname_example' # String | The name of the list to get.

begin
  #Lists the registrations for a course group
  api_instance.eventreggetusersfromgroup(token, codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventreggetusersfromgroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **codegroup** | [**String**](.md)| The code group to list users. | 
 **listname** | **String**| The name of the list to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
listname = 'listname_example' # String | The name of the list to get.

begin
  #View the users that are registered to all courses
  api_instance.eventreggetuserstoall(token, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventreggetuserstoall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The id of the event.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Unregister current user from a course
  api_instance.eventregremoveme(token, eventid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregremoveme: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove current user from the registration to all courses
  api_instance.eventregremovemefromall(token, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregremovemefromall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
codegroup = 'codegroup_example' # String | The code group of the events/courses.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove current user from a course group
  api_instance.eventregremovemefromgroup(token, codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregremovemefromgroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **codegroup** | [**String**](.md)| The code group of the events/courses. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## eventregremoveuser

> eventregremoveuser(token, userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to remove.
eventid = 'eventid_example' # String | The id of the event.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove a user from a course
  api_instance.eventregremoveuser(token, userid, eventid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregremoveuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to remove.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove a user from the registration to all courses
  api_instance.eventregremoveuserfromall(token, userid, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregremoveuserfromall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to remove.
codegroup = 'codegroup_example' # String | The code group of the events/courses.
listname = 'listname_example' # String | The name of the list where the user is registered.

begin
  #Remove a user from a course group
  api_instance.eventregremoveuserfromgroup(token, userid, codegroup, listname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventregremoveuserfromgroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **codegroup** | [**String**](.md)| The code group of the events/courses. | 
 **listname** | **String**| The name of the list where the user is registered. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a course
  api_instance.eventsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## eventsearchgroup

> eventsearchgroup(token, query)

Searches for the available event groups

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
query = 'query_example' # String | Query to search event groups.

begin
  #Searches for the available event groups
  api_instance.eventsearchgroup(token, query)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->eventsearchgroup: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **query** | [**String**](.md)| Query to search event groups. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## export

> export(token, exporttype, exportformat, opts)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
exporttype = 'exporttype_example' # String | What to export.
exportformat = 'exportformat_example' # String | The format of the resulting file. Valid types are CSV, HTML, XLS.
opts = {
  filters: 'filters_example' # String | Pipe separated filters for the export, eg: aaa=val|bbb=val|...
}

begin
  #Export AccuCampus data
  api_instance.export(token, exporttype, exportformat, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->export: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **exporttype** | **String**| What to export. | 
 **exportformat** | **String**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **filters** | **String**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## exportlisttypes

> exportlisttypes(token)

Lists available export types

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Lists available export types
  api_instance.exportlisttypes(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->exportlisttypes: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## featurelist

> featurelist(token)

Lists the available features.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Lists the available features.
  api_instance.featurelist(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->featurelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
term = 'term_example' # String | The term to get holidays from.

begin
  #View a list of entered holidays
  api_instance.holidaylist(token, term)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->holidaylist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **term** | [**String**](.md)| The term to get holidays from. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a list of holidays
  api_instance.holidaysave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->holidaysave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
term = 'term_example' # String | The term to get holidays from.

begin
  #View the holiday suggestions in the given term
  api_instance.holidaysuggest(token, term)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->holidaysuggest: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **term** | [**String**](.md)| The term to get holidays from. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## import

> import(token, importtype, upload, opts)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
importtype = 'importtype_example' # String | The kind of data that is being uploaded.
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
opts = {
  filename: 'filename_example', # String | The local name of the uploaded file. For later reference.
  parameters: 'parameters_example' # String | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.
}

begin
  #Import data into AccuCampus
  api_instance.import(token, importtype, upload, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->import: #{e}"
end
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

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## importlisttypes

> importlisttypes(token)

Lists available import types

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Lists available import types
  api_instance.importlisttypes(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->importlisttypes: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactiondelete

> interactiondelete(token, id)

Delete an interaction

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the interaction to delete.

begin
  #Delete an interaction
  api_instance.interactiondelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->interactiondelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the interaction to delete. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionfeed

> interactionfeed(token, from, count, opts)

Get the interactions feed

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | If set, only interactions that happened after this date are returned.
  public: true, # Boolean | Specifies whether to return public or private interactions.
  contexttype: 'contexttype_example', # String | The type of the context of the interactions to return.
  contextid: 'contextid_example', # String | The id of the context of the interactions to return.
  types: 'types_example', # String | The  comma separated types of the interactions to return.
  photosize: 56, # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  showdefaultphoto: true, # Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
  orderdescending: true # Boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.
}

begin
  #Get the interactions feed
  api_instance.interactionfeed(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->interactionfeed: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **startdate** | **DateTime**| If set, only interactions that happened after this date are returned. | [optional] 
 **public** | **Boolean**| Specifies whether to return public or private interactions. | [optional] 
 **contexttype** | **String**| The type of the context of the interactions to return. | [optional] 
 **contextid** | [**String**](.md)| The id of the context of the interactions to return. | [optional] 
 **types** | **String**| The  comma separated types of the interactions to return. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 
 **orderdescending** | **Boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionget

> interactionget(token, id, opts)

View an interaction

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the interaction.
opts = {
  thumbnailmediasize: 56, # Integer | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View an interaction
  api_instance.interactionget(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->interactionget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | **String**| The id of the interaction. | 
 **thumbnailmediasize** | **Integer**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionlistprivatesummary

> interactionlistprivatesummary(token, opts)

Get current user's latest private interactions

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  photosize: 56, # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  showdefaultphoto: true # Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
}

begin
  #Get current user's latest private interactions
  api_instance.interactionlistprivatesummary(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->interactionlistprivatesummary: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionsave

> interactionsave(opts)

Save an interaction

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save an interaction
  api_instance.interactionsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->interactionsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## licenseacceptagreement

> licenseacceptagreement(token)

Accept the license agreement

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Accept the license agreement
  api_instance.licenseacceptagreement(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->licenseacceptagreement: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## licensegetagreementstatus

> licensegetagreementstatus(token)

Check if license agreement has been accepted

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Check if license agreement has been accepted
  api_instance.licensegetagreementstatus(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->licensegetagreementstatus: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## licensegetcurrent

> licensegetcurrent(opts)

Gets the current license information

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  token: 'token_example' # String | The authentication token.
}

begin
  #Gets the current license information
  api_instance.licensegetcurrent(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->licensegetcurrent: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
email = 'email_example' # String | The e-mail of the user sending the request.
phonenumber = 'phonenumber_example' # String | The phone number of the user sending the request.
opts = {
  jobtitle: 'jobtitle_example', # String | The job title of the user sending the request.
  institution: 'institution_example', # String | The institution of the user sending the request.
  comments: 'comments_example' # String | Comments entered by the user sending the request.
}

begin
  #Contact Engineerica in order to renew the AccuCampus subscription
  api_instance.licenserenew(token, email, phonenumber, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->licenserenew: #{e}"
end
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

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## likedelete

> likedelete(token, interactionid)

Delete a like

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
interactionid = 'interactionid_example' # String | The id of the interaction to unlike.

begin
  #Delete a like
  api_instance.likedelete(token, interactionid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->likedelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **interactionid** | [**String**](.md)| The id of the interaction to unlike. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## likelist

> likelist(token, interactionid, opts)

View all the likes associated to a target

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
interactionid = 'interactionid_example' # String | The id of the interaction to unlike.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View all the likes associated to a target
  api_instance.likelist(token, interactionid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->likelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **interactionid** | [**String**](.md)| The id of the interaction to unlike. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## likesave

> likesave(opts)

Save a like

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save a like
  api_instance.likesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->likesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## listtimezones

> listtimezones

Lists the available timezones

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new

begin
  #Lists the available timezones
  api_instance.listtimezones
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->listtimezones: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the location to delete.

begin
  #Delete a location
  api_instance.locationdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->locationdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the location to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the location to get.

begin
  #Search and view details of a location
  api_instance.locationget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->locationget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the location to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  locations: 'locations_example', # String | The comma-separated list containing the ids of the locations to list.
  sortbygroup: true # Boolean | True to list locations sorted by the 'Located In' property. Defaults to false.
}

begin
  #View a list of locations
  api_instance.locationlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->locationlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **locations** | **String**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **Boolean**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a location
  api_instance.locationsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->locationsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## login

> login(domain, username, password, method, opts)

Login

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
domain = 'domain_example' # String | The account domain to login.
username = 'username_example' # String | The username (email) of the user to login as.
password = 'password_example' # String | The password of the user to login as.
method = 'method_example' # String | The authentication method. Valid values are 'token' and 'cookie'.
opts = {
  rememberme: true # Boolean | If true then the session will not expire.
}

begin
  #Login
  api_instance.login(domain, username, password, method, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->login: #{e}"
end
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

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## logout

> logout(opts)

Logout

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  token: 'token_example' # String | The authentication token used to login.
}

begin
  #Logout
  api_instance.logout(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->logout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token used to login. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
media = 'media_example' # String | The id of the media item to checkin.
checkindate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The checkout date.
opts = {
  notes: 'notes_example' # String | The notes of the checkout.
}

begin
  #Check in media item
  api_instance.mediacheckin(token, media, checkindate, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediacheckin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **media** | [**String**](.md)| The id of the media item to checkin. | 
 **checkindate** | **DateTime**| The checkout date. | 
 **notes** | **String**| The notes of the checkout. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
media = 'media_example' # String | The id of the media item to checkout.
user = 'user_example' # String | The id of the user that is checking the item out.
checkoutdate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The checkout date.
duedate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date when the checkout is due.
opts = {
  staff: 'staff_example', # String | The id of the staff member related to the checkout.
  event: 'event_example', # String | The id of the event related to the checkout.
  notes: 'notes_example' # String | The notes of the checkout.
}

begin
  #Check out media item
  api_instance.mediacheckout(token, media, user, checkoutdate, duedate, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediacheckout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **media** | [**String**](.md)| The id of the media item to checkout. | 
 **user** | [**String**](.md)| The id of the user that is checking the item out. | 
 **checkoutdate** | **DateTime**| The checkout date. | 
 **duedate** | **DateTime**| The date when the checkout is due. | 
 **staff** | [**String**](.md)| The id of the staff member related to the checkout. | [optional] 
 **event** | [**String**](.md)| The id of the event related to the checkout. | [optional] 
 **notes** | **String**| The notes of the checkout. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  media: 'media_example', # String | Used to filter the checkouts of a specific media item.
  user: 'user_example', # String | Used to filter the checkouts made by a specific user.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View a list of past media checkouts
  api_instance.mediacheckoutlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediacheckoutlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **media** | [**String**](.md)| Used to filter the checkouts of a specific media item. | [optional] 
 **user** | [**String**](.md)| Used to filter the checkouts made by a specific user. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the media item to delete.

begin
  #Delete a media item
  api_instance.mediadelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediadelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media item to delete. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediadeletecheckoutlog

> mediadeletecheckoutlog(token, id)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the checkout log to delete.

begin
  #Delete a media checkout log
  api_instance.mediadeletecheckoutlog(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediadeletecheckoutlog: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the checkout log to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the media item to get.

begin
  #Search and view details of a media item
  api_instance.mediaget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediaget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media item to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
code = 'code_example' # String | The code of the media item to get.
opts = {
  location: 'location_example' # String | The location where to look for the media item.
}

begin
  #Search media item by unique code
  api_instance.mediagetbycode(token, code, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediagetbycode: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **code** | **String**| The code of the media item to get. | 
 **location** | [**String**](.md)| The location where to look for the media item. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediagetcheckout

> mediagetcheckout(token, id, opts)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the media item whose checkout information has to be retrieved.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View details of a media item checkout information
  api_instance.mediagetcheckout(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediagetcheckout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediagetcheckoutlog

> mediagetcheckoutlog(token, id, opts)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the media item whose checkout information has to be retrieved.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View details of a media checkout log
  api_instance.mediagetcheckoutlog(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediagetcheckoutlog: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  status: 56, # Integer | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
  user: 'user_example' # String | Used to filter the media items that are checked-out by a specific user.
}

begin
  #View a list of media items
  api_instance.medialist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->medialist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **status** | **Integer**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional] 
 **user** | [**String**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a media item
  api_instance.mediasave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediasave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the media type to delete.

begin
  #Delete a media type
  api_instance.mediatypedelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediatypedelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media type to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the media type to get.

begin
  #Search and view details of a media type
  api_instance.mediatypeget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediatypeget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the media type to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of media types
  api_instance.mediatypelist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediatypelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a media type
  api_instance.mediatypesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mediatypesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the report settings to delete.

begin
  #Delete memorized report
  api_instance.memorizedreportdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->memorizedreportdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the report settings to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the report configuration to get.

begin
  #View details of a memorized report
  api_instance.memorizedreportget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->memorizedreportget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the report configuration to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  customname: 'customname_example' # String | If specified filters the memorized reports by custom name.
}

begin
  #View a list of all his memorized reports
  api_instance.memorizedreportlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->memorizedreportlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **customname** | **String**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a memorized report
  api_instance.memorizedreportsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->memorizedreportsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## menugetitems

> menugetitems(menuid)

Gets the items on the menu

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
menuid = 'menuid_example' # String | The Id of the menu to get.

begin
  #Gets the items on the menu
  api_instance.menugetitems(menuid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->menugetitems: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuid** | **String**| The Id of the menu to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## myaccount

> myaccount(token)

Gets the logged in user account.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Gets the logged in user account.
  api_instance.myaccount(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->myaccount: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## myianatimezone

> myianatimezone(token)

Gets the current time zone's iana name

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Gets the current time zone's iana name
  api_instance.myianatimezone(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->myianatimezone: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## myprofile

> myprofile(token, opts)

Gets the logged in user information.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Gets the logged in user information.
  api_instance.myprofile(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->myprofile: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## myrights

> myrights(token)

Gets the list of actions the user can execute.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Gets the list of actions the user can execute.
  api_instance.myrights(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->myrights: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mysaveprofile

> mysaveprofile(opts)

Updates logged user's profile information

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Updates logged user's profile information
  api_instance.mysaveprofile(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->mysaveprofile: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the notification to delete.

begin
  #Delete a notification
  api_instance.notificationdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification to delete. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationget

> notificationget(token, id)

View a notification

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the notification to get.

begin
  #View a notification
  api_instance.notificationget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationgetforstation

> notificationgetforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station to get.
user = 'user_example' # String | The card of the user.

begin
  #Gets all public (in station) notifications for the specific user
  api_instance.notificationgetforstation(station, user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationgetforstation: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationgetunreadcount

> notificationgetunreadcount(token)

Get the number of unread notifications

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Get the number of unread notifications
  api_instance.notificationgetunreadcount(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationgetunreadcount: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  recipient: 'recipient_example', # String | The recipient whose notifications have to be listed.
  status: 56, # Integer | The status of the notifications to list. Read, Unread or All.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the notifications.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The end date of the period to filter the notifications.
  sentonscreen: true, # Boolean | Specifies whether to list the notifications that were sent on-screen or not.
  sentemail: true, # Boolean | Specifies whether to list the notifications that were sent via e-mail or not.
  sentsms: true # Boolean | Specifies whether to list the notifications that were sent via sms or not.
}

begin
  #View a list of all sent notifications
  api_instance.notificationlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **recipient** | [**String**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **Integer**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **Boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **Boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **Boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationlistmine

> notificationlistmine(token, from, count, opts)

View all the notifications sent to the current user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  status: 56, # Integer | Specifies the status of the notifications to list. Read, Unread or All.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the notifications.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end date of the period to filter the notifications.
}

begin
  #View all the notifications sent to the current user
  api_instance.notificationlistmine(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationlistmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **status** | **Integer**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationmarkasread

> notificationmarkasread(token, opts)

Mark a notification as read

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  id: 'id_example', # String | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
  status: 56, # Integer | Specifies the status to filter the notifications. Read, Unread or All.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the notifications.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end date of the period to filter the notifications.
}

begin
  #Mark a notification as read
  api_instance.notificationmarkasread(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationmarkasread: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **Integer**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationmarkasunread

> notificationmarkasunread(token, opts)

Mark a notification as unread

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  id: 'id_example', # String | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
  status: 56, # Integer | Specifies the status to filter the notifications. Read, Unread or All.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the notifications.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end date of the period to filter the notifications.
}

begin
  #Mark a notification as unread
  api_instance.notificationmarkasunread(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationmarkasunread: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **Integer**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the notifications. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
emailenabled = true # Boolean | Whether send the notification via email.
onscreenenabled = true # Boolean | Whether to display the notification on screen.
smsenabled = true # Boolean | Whether to send the notification via text message.
title = 'title_example' # String | Notification title.
opts = {
  tousers: 'tousers_example', # String | Comma-separated Ids of users to send the notification.
  togroups: 'togroups_example', # String | Comma-separated Ids of user groups to send the notification.
  onscreenbody: 'onscreenbody_example', # String | Body of the message for on-screen display.
  onscreenclick: 'onscreenclick_example', # String | What to do when the notification is clicked. Valid values: hide, view, url.
  onscreenurl: 'onscreenurl_example', # String | Url to redirect the user, if onscreenclick=url.
  onscreenclass: 'onscreenclass_example', # String | How to display the notification. Valid values: info, success, warning, error
  onscreenduration: 56, # Integer | Time in seconds to display the notification.
  showonstation: 56, # Integer | Whether to show the notification in the sign-in station.
  emailfromname: 'emailfromname_example', # String | Name of the email sender.
  emailfrom: 'emailfrom_example', # String | Reply-to email.
  emailsubject: 'emailsubject_example', # String | Subject of the email.
  emailbody: 'emailbody_example', # String | Body of the email.
  textmessagebody: 'textmessagebody_example' # String | Message for SMS. Max 160 characters.
}

begin
  #Send notifications on screen, via email or text to users
  api_instance.notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationsend: #{e}"
end
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
 **onscreenduration** | **Integer**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **Integer**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **String**| Name of the email sender. | [optional] 
 **emailfrom** | **String**| Reply-to email. | [optional] 
 **emailsubject** | **String**| Subject of the email. | [optional] 
 **emailbody** | **String**| Body of the email. | [optional] 
 **textmessagebody** | **String**| Message for SMS. Max 160 characters. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationsendonscreen

> notificationsendonscreen(token, notification)

Send on-screen notifications

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
notification = 'notification_example' # String | The ID of the notification to send.

begin
  #Send on-screen notifications
  api_instance.notificationsendonscreen(token, notification)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationsendonscreen: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **notification** | [**String**](.md)| The ID of the notification to send. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the notification topic to delete.

begin
  #Delete a notification topic
  api_instance.notificationtopicdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationtopicdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification topic to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the notification topic to get.

begin
  #Search and view details of a notification topic
  api_instance.notificationtopicget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationtopicget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the notification topic to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #List all the notification topics
  api_instance.notificationtopiclist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationtopiclist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationtopiclistsubscribe

> notificationtopiclistsubscribe(token)

List all the notification topics available to subscribe

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #List all the notification topics available to subscribe
  api_instance.notificationtopiclistsubscribe(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationtopiclistsubscribe: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a notification topic
  api_instance.notificationtopicsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->notificationtopicsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## pushderegister

> pushderegister(devicetoken, platform)

Deregisters the current device to receive push notifications

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
devicetoken = 'devicetoken_example' # String | The device token where to send the notification.
platform = 'platform_example' # String | Either ios or android

begin
  #Deregisters the current device to receive push notifications
  api_instance.pushderegister(devicetoken, platform)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->pushderegister: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **String**| The device token where to send the notification. | 
 **platform** | **String**| Either ios or android | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## pushregister

> pushregister(devicetoken, platform)

Registers the current device to receive push notifications

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
devicetoken = 'devicetoken_example' # String | The device token where to send the notification.
platform = 'platform_example' # String | Either ios or android

begin
  #Registers the current device to receive push notifications
  api_instance.pushregister(devicetoken, platform)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->pushregister: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **String**| The device token where to send the notification. | 
 **platform** | **String**| Either ios or android | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  user: 'user_example', # String | The id of the user whose label needs to be printed.
  group: 'group_example' # String | The id of the group whose members' labels need to be printed.
}

begin
  #Print and email QR labels
  api_instance.qrlabelsprint(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->qrlabelsprint: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **user** | [**String**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**String**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## qrloginget

> qrloginget(token)

Gets an image of a QR token

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Gets an image of a QR token
  api_instance.qrloginget(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->qrloginget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## qrloginlogin

> qrloginlogin(onetimetoken)

Login

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
onetimetoken = 'onetimetoken_example' # String | The token read from the QR code.

begin
  #Login
  api_instance.qrloginlogin(onetimetoken)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->qrloginlogin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onetimetoken** | **String**| The token read from the QR code. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the widget.

begin
  #Deletes a widget from the Quick Panel
  api_instance.quickpaneldeletewidget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->quickpaneldeletewidget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the widget. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanelfetchwidget

> quickpanelfetchwidget(token, widgetid)

Fetches the information for a specific widget.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
widgetid = 'widgetid_example' # String | The ID of the data to fetch it's data.

begin
  #Fetches the information for a specific widget.
  api_instance.quickpanelfetchwidget(token, widgetid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->quickpanelfetchwidget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **widgetid** | [**String**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the widget to get.

begin
  #View details of a widget included in the Quick Panel
  api_instance.quickpanelgetwidget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->quickpanelgetwidget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the widget to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanelinit

> quickpanelinit(token)

Returns the initial information required to show the quick panels

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Returns the initial information required to show the quick panels
  api_instance.quickpanelinit(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->quickpanelinit: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Lists all the widgets that are added in the Quick Panel
  api_instance.quickpanellistwidgets(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->quickpanellistwidgets: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanellistwidgettypes

> quickpanellistwidgettypes(token)

Lists all the widget types available in the system

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Lists all the widget types available in the system
  api_instance.quickpanellistwidgettypes(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->quickpanellistwidgettypes: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanelreorderwidgets

> quickpanelreorderwidgets(token, sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
sectionname = 'sectionname_example' # String | The section name where to sort the widgets.
orderids = 'orderids_example' # String | CSV list of the widgets to reorder.

begin
  #Reorders the widgets and moves them to a specific column
  api_instance.quickpanelreorderwidgets(token, sectionname, orderids)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->quickpanelreorderwidgets: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **sectionname** | **String**| The section name where to sort the widgets. | 
 **orderids** | **String**| CSV list of the widgets to reorder. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a widget for the Quick Panel
  api_instance.quickpanelsavewidget(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->quickpanelsavewidget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## ratingflag

> ratingflag(token, id, opts)

Flags one rating for moderation

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The rating to flag.
opts = {
  comment: 'comment_example' # String | Comment why should this should be removed.
}

begin
  #Flags one rating for moderation
  api_instance.ratingflag(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratingflag: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The rating to flag. | 
 **comment** | **String**| Comment why should this should be removed. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingflagcomment

> ratingflagcomment(token, id, opts)

Flags one comment for moderation

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The comment to flag.
opts = {
  comment: 'comment_example' # String | Comment why should this should be removed.
}

begin
  #Flags one comment for moderation
  api_instance.ratingflagcomment(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratingflagcomment: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The comment to flag. | 
 **comment** | **String**| Comment why should this should be removed. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingget

> ratingget(token, type, entityids)

Get rating for one or more entities

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
type = 'type_example' # String | The entity type to get the rating.
entityids = 'entityids_example' # String | List of ids to get the ratings.

begin
  #Get rating for one or more entities
  api_instance.ratingget(token, type, entityids)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratingget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **type** | **String**| The entity type to get the rating. | 
 **entityids** | **String**| List of ids to get the ratings. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratinggetall

> ratinggetall(token, type, entityid, opts)

Gets the full ratings and comments for a specific entity

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
type = 'type_example' # String | The entity type to get the rating.
entityid = 'entityid_example' # String | Id of the entity to get the ratings.
opts = {
  mostrecentfirst: true # Boolean | True to show most recent first, otherwise most helpful first.
}

begin
  #Gets the full ratings and comments for a specific entity
  api_instance.ratinggetall(token, type, entityid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratinggetall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **type** | **String**| The entity type to get the rating. | 
 **entityid** | **String**| Id of the entity to get the ratings. | 
 **mostrecentfirst** | **Boolean**| True to show most recent first, otherwise most helpful first. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratinggetcomments

> ratinggetcomments(token, ratingid)

Gets all the comments for a rating

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
ratingid = 'ratingid_example' # String | The ID of the rating to get all comments.

begin
  #Gets all the comments for a rating
  api_instance.ratinggetcomments(token, ratingid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratinggetcomments: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **ratingid** | [**String**](.md)| The ID of the rating to get all comments. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratinggetpending

> ratinggetpending(getgroup, opts)

Gets info of pre-saved and pre-approved ratings

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
getgroup = 'getgroup_example' # String | The ID of the group of pending ratings to get.
opts = {
  rateid: 'rateid_example', # String | Rate this before returning.
  rateval: 56 # Integer | The value used to rate the item specified in rateid.
}

begin
  #Gets info of pre-saved and pre-approved ratings
  api_instance.ratinggetpending(getgroup, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratinggetpending: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**String**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**String**](.md)| Rate this before returning. | [optional] 
 **rateval** | **Integer**| The value used to rate the item specified in rateid. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Shows a list of the ratings and comments that are pending for moderation
  api_instance.ratinggetpendingmoderation(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratinggetpendingmoderation: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
type = 'type_example' # String | Either 'rating' or 'comment' depending on what you want to moderate.
id = 'id_example' # String | Id of the rating or comment, as specified in type.
approve = true # Boolean | True to approve, false to reject.

begin
  #Allows the user to accept or reject a comment
  api_instance.ratingmoderate(token, type, id, approve)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratingmoderate: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **type** | **String**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**String**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **Boolean**| True to approve, false to reject. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingpostcomment

> ratingpostcomment(token, ratingid, comment, annonymous)

Posts a comments for in a rating

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
ratingid = 'ratingid_example' # String | The ID of the rating to post the comment.
comment = 'comment_example' # String | Text of the comment to post.
annonymous = true # Boolean | True to post the comment annonymously.

begin
  #Posts a comments for in a rating
  api_instance.ratingpostcomment(token, ratingid, comment, annonymous)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratingpostcomment: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **ratingid** | [**String**](.md)| The ID of the rating to post the comment. | 
 **comment** | **String**| Text of the comment to post. | 
 **annonymous** | **Boolean**| True to post the comment annonymously. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingrate

> ratingrate(token, type, entityid, annonymous, opts)

Rates one entity

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
type = 'type_example' # String | The entity type to rate.
entityid = 'entityid_example' # String | Id of the entity to rate.
annonymous = true # Boolean | Whether to post as annonymous.
opts = {
  value: 56, # Integer | Value from 0 to 100 with the rating.
  comment: 'comment_example', # String | Comment associated with this review. Comment can be updated later on another request too.
  updatecomment: true # Boolean | Whether to update the comments. Defaults to true.
}

begin
  #Rates one entity
  api_instance.ratingrate(token, type, entityid, annonymous, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratingrate: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **type** | **String**| The entity type to rate. | 
 **entityid** | **String**| Id of the entity to rate. | 
 **annonymous** | **Boolean**| Whether to post as annonymous. | 
 **value** | **Integer**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingratepending

> ratingratepending(group, annonymous, opts)

Rates a pre-saved and pre-approved entity

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
group = 'group_example' # String | The ID of the group of with pre-approved ratings.
annonymous = true # Boolean | Whether to post as annonymous.
opts = {
  rateid: 'rateid_example', # String | Rate this before returning.
  value: 56, # Integer | Value from 0 to 100 with the rating.
  comment: 'comment_example', # String | Comment associated with this review. Comment can be updated later on another request too.
  updatecomment: true # Boolean | Whether to update the comments. Defaults to true.
}

begin
  #Rates a pre-saved and pre-approved entity
  api_instance.ratingratepending(group, annonymous, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratingratepending: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**String**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **Boolean**| Whether to post as annonymous. | 
 **rateid** | [**String**](.md)| Rate this before returning. | [optional] 
 **value** | **Integer**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingvote

> ratingvote(token, ratingid, vote)

Votes up or down a rating

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
ratingid = 'ratingid_example' # String | The ID of the rating to vote on.
vote = 56 # Integer | 1 to vote up, -1 to vote down.

begin
  #Votes up or down a rating
  api_instance.ratingvote(token, ratingid, vote)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ratingvote: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **ratingid** | [**String**](.md)| The ID of the rating to vote on. | 
 **vote** | **Integer**| 1 to vote up, -1 to vote down. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
reportname = 'reportname_example' # String | The name of the report to execute
opts = {
  params: 'params_example', # String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
  refreshgroup: 'refreshgroup_example' # String | The ID of the group to check (and refresh) before processing the report.
}

begin
  #Query and load an attendance analytics report
  api_instance.reportattanalyticsprepare(token, reportname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportattanalyticsprepare: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **reportname** | **String**| The name of the report to execute | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **refreshgroup** | [**String**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View a list of available reports
  api_instance.reportlist(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  params: 'params_example' # String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
}

begin
  #Permissions by user report
  api_instance.reportpermissionsbyuser(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportpermissionsbyuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
reportname = 'reportname_example' # String | The name of the report to execute
opts = {
  params: 'params_example', # String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
  repformat: 'repformat_example', # String | The format of the resulting report. Json, pdf, csv, ...
  fillgroupid: 'fillgroupid_example', # String | If specified, the result is used to fill the group with the given ID
  groupby: 'groupby_example', # String | How to group the records. In the format 'col1+col2|col3+col4
  refreshgroup: 'refreshgroup_example', # String | The ID of the group to check (and refresh) before processing the report.
  filtertext: 'filtertext_example' # String | The user friendly text of the applied filters.
}

begin
  #Queries and loads the specified report, in background.
  api_instance.reportprepare(token, reportname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportprepare: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
reportname = 'reportname_example' # String | The name of the report to execute
opts = {
  params: 'params_example' # String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
}

begin
  #Query and load a specified report
  api_instance.reportquery(token, reportname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportquery: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **reportname** | **String**| The name of the report to execute | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the report schedule to delete.

begin
  #Delete a report schedule
  api_instance.reportscheduledelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportscheduledelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the report schedule to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the schedule to get.

begin
  #Get a report schedule
  api_instance.reportscheduleget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportscheduleget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the schedule to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of the scheduled reports
  api_instance.reportschedulelist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportschedulelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a report schedule
  api_instance.reportschedulesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reportschedulesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
reportname = 'reportname_example' # String | The name of the report to execute
assign = true # Boolean | Specify whether the specified tags have to be assigned or unassigned.
tags = 'tags_example' # String | The tags to assign (or unassign) to the resulting users in the report, in JSON format.
opts = {
  params: 'params_example' # String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
}

begin
  #Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
  api_instance.reporttagresults(token, reportname, assign, tags, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->reporttagresults: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the risk assessment model whose analysis status has to be returned.

begin
  #Check the status of the analysis of a specified risk assessment model
  api_instance.riskmodelcheckanalysis(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodelcheckanalysis: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the risk assessment model to delete.

begin
  #Delete a risk assessment model
  api_instance.riskmodeldelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodeldelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the risk assessment model to get.

begin
  #View details of a risk assessment model
  api_instance.riskmodelget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodelget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to get the risk score.

begin
  #View the risk score for a specific user
  api_instance.riskmodelgetscore(token, userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodelgetscore: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to get the risk score. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of risk assessment models
  api_instance.riskmodellist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodellist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the assessment model to use in order to predict risk.

begin
  #Predict risk based on an assessment model
  api_instance.riskmodelpredict(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodelpredict: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the assessment model to use in order to predict risk. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the risk assessment model to process.

begin
  #Process a risk assessment model
  api_instance.riskmodelprocess(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodelprocess: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model to process. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the risk assessment model whose information has to be refreshed.

begin
  #Refresh the information used in a risk assessment model
  api_instance.riskmodelrefresh(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodelrefresh: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a risk assessment model
  api_instance.riskmodelsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodelsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View all default term precedences
  api_instance.riskmodeltermprecedences(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->riskmodeltermprecedences: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rolelist

> rolelist(token, opts)

Show a list of roles

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  name: 'name_example' # String | Filter by name of the role.
}

begin
  #Show a list of roles
  api_instance.rolelist(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->rolelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **name** | **String**| Filter by name of the role. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the rule to delete.

begin
  #Delete a rule
  api_instance.ruledelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ruledelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the rule to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the rule to get.

begin
  #View details of a rule
  api_instance.ruleget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ruleget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the rule to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
event = 'event_example' # String | The name of the event to refresh.

begin
  #View details of a rule event type
  api_instance.rulegeteventtype(token, event)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->rulegeteventtype: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **event** | **String**| The name of the event to refresh. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of user rules
  api_instance.rulelist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->rulelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View a list of rule actions available
  api_instance.rulelistactions(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->rulelistactions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View a list of rule event types
  api_instance.rulelisteventtypes(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->rulelisteventtypes: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rulelisthttprequests

> rulelisthttprequests(token, from, count, opts)

View all the http requests sent as a result of a rule

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  failed: true, # Boolean | If true only failed requests will be returned
  status: 56 # Integer | The http status to filter the requests
}

begin
  #View all the http requests sent as a result of a rule
  api_instance.rulelisthttprequests(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->rulelisthttprequests: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **failed** | **Boolean**| If true only failed requests will be returned | [optional] 
 **status** | **Integer**| The http status to filter the requests | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a rule
  api_instance.rulesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->rulesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
scheduleid = 'scheduleid_example' # String | The id of the schedule.

begin
  #Delete a schedule slot
  api_instance.scheduledelete(token, scheduleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduledelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduledeletemine

> scheduledeletemine(token, scheduleid)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
scheduleid = 'scheduleid_example' # String | The id of the schedule.

begin
  #Delete a specific block from a user's own schedule
  api_instance.scheduledeletemine(token, scheduleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduledeletemine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to enable or disable the schedule.
enable = true # Boolean | True to enable schedules, false to disable.

begin
  #Enable or disable the schedule for a specific person
  api_instance.scheduleenable(token, userid, enable)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduleenable: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to enable or disable the schedule. | 
 **enable** | **Boolean**| True to enable schedules, false to disable. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleenablemine

> scheduleenablemine(token, enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
enable = true # Boolean | True to enable schedules, false to disable.

begin
  #Enable or disable current user's schedule
  api_instance.scheduleenablemine(token, enable)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduleenablemine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **enable** | **Boolean**| True to enable schedules, false to disable. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
opts = {
  staffid: 'staffid_example', # String | The id of the staff to filter by.
  serviceids: 'serviceids_example', # String | CSV list of the service Ids to filter by.
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example', # String | The id of the location to filter by.
  staffroleids: 'staffroleids_example', # String | CSV list of the staff member role ids to filter by.
  availablefor: 'availablefor_example' # String | The specific availability type to filter by.
}

begin
  #Search available schedule slots by service, event, date
  api_instance.schedulefindallstaffslots(token, starttime, endtime, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulefindallstaffslots: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **staffid** | [**String**](.md)| The id of the staff to filter by. | [optional] 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the location to filter by. | [optional] 
 **staffroleids** | **String**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **String**| The specific availability type to filter by. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
staffid = 'staffid_example' # String | The id of the staff to filter by.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
opts = {
  serviceids: 'serviceids_example', # String | CSV list of the service Ids to filter by.
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example', # String | The id of the service to filter by.
  availablefor: 'availablefor_example' # String | The specific availability type to filter by.
}

begin
  #Search available schedule slots by service, event, date and/or staff
  api_instance.schedulefindslots(token, staffid, starttime, endtime, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulefindslots: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **staffid** | [**String**](.md)| The id of the staff to filter by. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service Ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **availablefor** | **String**| The specific availability type to filter by. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
starttime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The start time of the range to look for slots.
endtime = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end time of the range to look for slots.
opts = {
  serviceids: 'serviceids_example', # String | CSV list of the service ids to filter by.
  eventid: 'eventid_example', # String | The id of the event to filter by.
  locationid: 'locationid_example', # String | The id of the service to filter by.
  staffroleids: 'staffroleids_example', # String | CSV list of the staff member role ids to filter by.
  availablefor: 'availablefor_example', # String | Filter slots by a specific availability type.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Search available staff members slots by service, event, and/or date
  api_instance.schedulefindstaffavail(token, starttime, endtime, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulefindstaffavail: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **starttime** | **DateTime**| The start time of the range to look for slots. | 
 **endtime** | **DateTime**| The end time of the range to look for slots. | 
 **serviceids** | **String**| CSV list of the service ids to filter by. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to filter by. | [optional] 
 **locationid** | [**String**](.md)| The id of the service to filter by. | [optional] 
 **staffroleids** | **String**| CSV list of the staff member role ids to filter by. | [optional] 
 **availablefor** | **String**| Filter slots by a specific availability type. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
scheduleid = 'scheduleid_example' # String | The id of the schedule.

begin
  #Search and view details of a specific schedule slot
  api_instance.scheduleget(token, scheduleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduleget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
scheduleid = 'scheduleid_example' # String | The id of the schedule.

begin
  #View details of a specific schedule block, for current user
  api_instance.schedulegetmine(token, scheduleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulegetmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **scheduleid** | [**String**](.md)| The id of the schedule. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to get info.

begin
  #View a list of schedule information of a specified person
  api_instance.schedulegetstaff(token, userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulegetstaff: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to get info. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulegetstaffmine

> schedulegetstaffmine(token)

View current user's schedule information

Allows the user to view their own schedule.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View current user's schedule information
  api_instance.schedulegetstaffmine(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulegetstaffmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegrationdeleteitem

> scheduleintegrationdeleteitem(token, thirdpartyid)

Delete a schedule item looking up by a third party ID

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
thirdpartyid = 'thirdpartyid_example' # String | The third party id to search the schedule block / appointment.

begin
  #Delete a schedule item looking up by a third party ID
  api_instance.scheduleintegrationdeleteitem(token, thirdpartyid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduleintegrationdeleteitem: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **thirdpartyid** | **String**| The third party id to search the schedule block / appointment. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegrationdeleteitemsbymasterid

> scheduleintegrationdeleteitemsbymasterid(token, thirdpartymasterid)

Delete multiple schedule items looking up by a third party master ID

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
thirdpartymasterid = 'thirdpartymasterid_example' # String | The third party master id to search the schedule items.

begin
  #Delete multiple schedule items looking up by a third party master ID
  api_instance.scheduleintegrationdeleteitemsbymasterid(token, thirdpartymasterid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduleintegrationdeleteitemsbymasterid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **thirdpartymasterid** | **String**| The third party master id to search the schedule items. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegrationgetitem

> scheduleintegrationgetitem(token, thirdpartyid)

Get a schedule item looking up by a third party ID

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
thirdpartyid = 'thirdpartyid_example' # String | The third party id to search for the schedule item.

begin
  #Get a schedule item looking up by a third party ID
  api_instance.scheduleintegrationgetitem(token, thirdpartyid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduleintegrationgetitem: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **thirdpartyid** | **String**| The third party id to search for the schedule item. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegrationsaveitem

> scheduleintegrationsaveitem(opts)

Save a schedule item looking up by a third party ID

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save a schedule item looking up by a third party ID
  api_instance.scheduleintegrationsaveitem(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduleintegrationsaveitem: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## scheduleintegrationsetid

> scheduleintegrationsetid(token, id, thirdpartyid, opts)

Set a 3rd party ID on a specific schedule item

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the schedule block / appointment.
thirdpartyid = 'thirdpartyid_example' # String | The 3rd party ID to set.
opts = {
  thirdpartymasterid: 'thirdpartymasterid_example' # String | The 3rd party master ID to set (useful to handle recurring items).
}

begin
  #Set a 3rd party ID on a specific schedule item
  api_instance.scheduleintegrationsetid(token, id, thirdpartyid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->scheduleintegrationsetid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the schedule block / appointment. | 
 **thirdpartyid** | **String**| The 3rd party ID to set. | 
 **thirdpartymasterid** | **String**| The 3rd party master ID to set (useful to handle recurring items). | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## schedulemyofftimes

> schedulemyofftimes(token, opts)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  includedeleted: true, # Boolean | If true the deleted offtimes are also returned.
  onlyupcoming: true, # Boolean | If true then only upcoming offtimes are returned.
  modifiedafter: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | If specified, only offtimes modified after the specified date will be returned.
}

begin
  #View current user's schedule exceptions
  api_instance.schedulemyofftimes(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulemyofftimes: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **includedeleted** | **Boolean**| If true the deleted offtimes are also returned. | [optional] 
 **onlyupcoming** | **Boolean**| If true then only upcoming offtimes are returned. | [optional] 
 **modifiedafter** | **DateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a schedule slot
  api_instance.schedulesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## schedulesavemine

> schedulesavemine(opts)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a block in current user's schedule
  api_instance.schedulesavemine(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->schedulesavemine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## search

> search(token, query, opts)

Search

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
query = 'query_example' # String | The query to search for.
opts = {
  page: 56 # Integer | Current page to show, zero-based.
}

begin
  #Search
  api_instance.search(token, query, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->search: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **query** | **String**| The query to search for. | 
 **page** | **Integer**| Current page to show, zero-based. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## searchgetentities

> searchgetentities(token)

Get the information of the entities that can be searched

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Get the information of the entities that can be searched
  api_instance.searchgetentities(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->searchgetentities: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityassesspermission

> securityassesspermission(token, commandname)

Returns the list of users for a specific permission

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
commandname = 'commandname_example' # String | Name of the action or command to get the roles.

begin
  #Returns the list of users for a specific permission
  api_instance.securityassesspermission(token, commandname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->securityassesspermission: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **commandname** | **String**| Name of the action or command to get the roles. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityassessrole

> securityassessrole(token, roleid)

Returns the list of permissions for a specific role

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
roleid = 'roleid_example' # String | Role ID to list the effective permissions.

begin
  #Returns the list of permissions for a specific role
  api_instance.securityassessrole(token, roleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->securityassessrole: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **roleid** | [**String**](.md)| Role ID to list the effective permissions. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityassessscope

> securityassessscope(token, opts)

Returns the list of users for a specific user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  locationid: 'locationid_example' # String | Location ID to list the users with that scope.
}

begin
  #Returns the list of users for a specific user
  api_instance.securityassessscope(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->securityassessscope: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **locationid** | [**String**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityassessuser

> securityassessuser(token, userid)

Returns the list of permissions for a specific user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | User ID to list the effective permissions.

begin
  #Returns the list of permissions for a specific user
  api_instance.securityassessuser(token, userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->securityassessuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| User ID to list the effective permissions. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the seminar to delete.

begin
  #Delete an event
  api_instance.seminardelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->seminardelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the seminar to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the seminar to get.

begin
  #Search and view details of a event
  api_instance.seminarget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->seminarget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the seminar to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 'from_example' # String | The first record to return.
count = 'count_example' # String | The max number of records to return.
opts = {
  summaryonly: true, # Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  termid: 'termid_example' # String | Id of the term to list the events. Null to list all events.
}

begin
  #View a list of events
  api_instance.seminarlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->seminarlist: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a event
  api_instance.seminarsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->seminarsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceid = 'serviceid_example' # String | The id of the service to add.
locationid = 'locationid_example' # String | The id of the location.

begin
  #Enable a service in a specific location
  api_instance.serviceassignmentaddservice(token, serviceid, locationid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->serviceassignmentaddservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to add. | 
 **locationid** | [**String**](.md)| The id of the location. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
locationid = 'locationid_example' # String | The id of the location to get.
opts = {
  includegloballyavailable: true, # Boolean | Specifies whether the services available globally must be returned or not.
  namefilter: true, # Boolean | Filters the name of the services to return.
  count: 56 # Integer | The max number of services to return.
}

begin
  #View a list of services enabled for a specific location
  api_instance.serviceassignmentgetlocation(token, locationid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->serviceassignmentgetlocation: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **locationid** | [**String**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **Boolean**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **Boolean**| Filters the name of the services to return. | [optional] 
 **count** | **Integer**| The max number of services to return. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceid = 'serviceid_example' # String | The id of the service to get its locations.

begin
  #View a list of locations where a service is available
  api_instance.serviceassignmentgetservice(token, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->serviceassignmentgetservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceid = 'serviceid_example' # String | The id of the service to remove.
locationid = 'locationid_example' # String | The id of the location to remove the service from.

begin
  #Remove a service from a location
  api_instance.serviceassignmentremoveservice(token, serviceid, locationid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->serviceassignmentremoveservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service to remove. | 
 **locationid** | [**String**](.md)| The id of the location to remove the service from. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the service to delete.

begin
  #Delete a service
  api_instance.servicedelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->servicedelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the service to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the service to get.

begin
  #Search and view details of a service
  api_instance.serviceget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->serviceget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the service to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of services
  api_instance.servicelist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->servicelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a service
  api_instance.servicesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->servicesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the attendance log.
text = 'text_example' # String | The text of the note to add.

begin
  #Add a note to a class attendance log
  api_instance.sessionattendancelogaddnote(token, id, text)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendancelogaddnote: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log. | 
 **text** | **String**| The text of the note to add. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the attendance log to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.
}

begin
  #View details of a class attendance log
  api_instance.sessionattendancelogget(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendancelogget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the attendance log to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
attendee = 'attendee_example' # String | The id of the attendee to get statistic for.
eventid = 'eventid_example' # String | The id of the event whose attendee statistics have to be returned.
opts = {
  token: 'token_example' # String | The authentication token.
}

begin
  #View the class session attendance information for a specific user
  api_instance.sessionattendanceloggetuser(attendee, eventid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendanceloggetuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**String**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**String**](.md)| The id of the event whose attendee statistics have to be returned. | 
 **token** | **String**| The authentication token. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
session = 'session_example' # String | The id of the session whose attendees logs have to be returned.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View attendance logs of the specified session
  api_instance.sessionattendanceloglist(token, session, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendanceloglist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **session** | [**String**](.md)| The id of the session whose attendees logs have to be returned. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
eventid = 'eventid_example' # String | The id of the event whose attendance has to be returned.
opts = {
  token: 'token_example' # String | The authentication token.
}

begin
  #View the attendance information of an entire class
  api_instance.sessionattendanceloglistevent(eventid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendanceloglistevent: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | 
 **token** | **String**| The authentication token. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  token: 'token_example', # String | The authentication token.
  eventid: 'eventid_example', # String | The id of the event whose attendance has to be returned.
  attendeeid: 'attendeeid_example', # String | The id of the attendee whose attendance has to be returned.
  groupid: 'groupid_example', # String | The id of the group whose attendance has to be returned.
  start: 'start_example', # String | The start date to filter (beginning of time by default).
  _end: '_end_example' # String | The end date to filter (today by default).
}

begin
  #View the attendance summary for a class and/or a attendee
  api_instance.sessionattendanceloglistsummary(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendanceloglistsummary: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | [optional] 
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**String**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**String**](.md)| The id of the group whose attendance has to be returned. | [optional] 
 **start** | **String**| The start date to filter (beginning of time by default). | [optional] 
 **_end** | **String**| The end date to filter (today by default). | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  token: 'token_example', # String | The authentication token.
  eventid: 'eventid_example', # String | The id of the event whose attendance has to be returned.
  start: 'start_example', # String | The start date to filter (beginning of time by default).
  _end: '_end_example' # String | The end date to filter (today by default).
}

begin
  #View my attendance summary
  api_instance.sessionattendancelogmylistsummary(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendancelogmylistsummary: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | [optional] 
 **eventid** | [**String**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **start** | **String**| The start date to filter (beginning of time by default). | [optional] 
 **_end** | **String**| The end date to filter (today by default). | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a class attendance log
  api_instance.sessionattendancelogsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendancelogsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a class attendance log swipe
  api_instance.sessionattendancelogsaveswipe(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionattendancelogsaveswipe: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The id of the event to bulk update.
sessions = 'sessions_example' # String | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

begin
  #Bulk update event sessions
  api_instance.sessionbulkupdate(token, eventid, sessions)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionbulkupdate: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event to bulk update. | 
 **sessions** | **String**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the session to get.

begin
  #View details of a session
  api_instance.sessionget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the session to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessiongetschedule

> sessiongetschedule(opts)

Gets the schedule for a location, instructor or attendees

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  token: 'token_example', # String | The authentication token.
  day: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The day to return. It will also return the whole week for that day.
  attendee: 'attendee_example', # String | The id of the attendee to get the schedule.
  location: 'location_example', # String | The id of the location to get the schedule.
  instructor: 'instructor_example' # String | The id of the instructor to get the schedule.
}

begin
  #Gets the schedule for a location, instructor or attendees
  api_instance.sessiongetschedule(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessiongetschedule: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | [optional] 
 **day** | **DateTime**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**String**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**String**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**String**](.md)| The id of the instructor to get the schedule. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionlist

> sessionlist(from, count, opts)

Gets all future sessions of the current semester

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  token: 'token_example', # String | The authentication token.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date to filter the sessions
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The end date to filter the sessions.
}

begin
  #Gets all future sessions of the current semester
  api_instance.sessionlist(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **token** | **String**| The authentication token. | [optional] 
 **startdate** | **DateTime**| The start date to filter the sessions | [optional] 
 **enddate** | **DateTime**| The end date to filter the sessions. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The id of the event.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time when the session starts.

begin
  #Register current user to an event session
  api_instance.sessionregaddcurrentuser(token, eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionregaddcurrentuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to add.
eventid = 'eventid_example' # String | The id of the event.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time when the session starts.

begin
  #Register users for events
  api_instance.sessionregadduser(token, userid, eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionregadduser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreggetmysessions

> sessionreggetmysessions(token, opts)

View all the sessions the logged user is registered to

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  date: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | Start date to filter the sessions.
}

begin
  #View all the sessions the logged user is registered to
  api_instance.sessionreggetmysessions(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionreggetmysessions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **date** | **DateTime**| Start date to filter the sessions. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The user id to list sessions.

begin
  #Lists the registrations for a specific user
  api_instance.sessionreggetsessions(token, userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionreggetsessions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The user id to list sessions. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreggetsettings

> sessionreggetsettings(token, opts)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  locationid: 'locationid_example', # String | The id of the location to save settings.
  eventid: 'eventid_example', # String | The id of the event to save settings.
  sessiondate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The date and time when the session starts.
  noinherit: true # Boolean | True to get the location/event/session specific settings without looking for the more global settings.
}

begin
  #Get the settings for session registration
  api_instance.sessionreggetsettings(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionreggetsettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **locationid** | [**String**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**String**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **DateTime**| The date and time when the session starts. | [optional] 
 **noinherit** | **Boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The event id to list sessions.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date of the session to find.

begin
  #Lists the registrations for a specific session
  api_instance.sessionreggetusers(token, eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionreggetusers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime**| The date of the session to find. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The event id to list sessions.
opts = {
  sessiondate: DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date of the session to find.
}

begin
  #List the sessions available for a specific event
  api_instance.sessionreglistsessions(token, eventid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionreglistsessions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime**| The date of the session to find. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreglistupcoming

> sessionreglistupcoming(token, date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
date = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | Only sessions in the week of the specified date will be returned.

begin
  #View a list of upcoming event sessions
  api_instance.sessionreglistupcoming(token, date)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionreglistupcoming: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **date** | **DateTime**| Only sessions in the week of the specified date will be returned. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionreglistupcomingevent

> sessionreglistupcomingevent(token, date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
date = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | Start date to filter the returned sessions.
event = 'event_example' # String | The id of the event whose sessions will be returned

begin
  #View a list of upcoming sessions of a particular event
  api_instance.sessionreglistupcomingevent(token, date, event)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionreglistupcomingevent: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **date** | **DateTime**| Start date to filter the returned sessions. | 
 **event** | [**String**](.md)| The id of the event whose sessions will be returned | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
eventid = 'eventid_example' # String | The id of the event.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time when the session starts.

begin
  #Unregister current user from an event session
  api_instance.sessionregremovecurrentuser(token, eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionregremovecurrentuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to remove.
eventid = 'eventid_example' # String | The id of the event.
sessiondate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time when the session starts.

begin
  #Removes a user from an event session
  api_instance.sessionregremoveuser(token, userid, eventid, sessiondate)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionregremoveuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **eventid** | [**String**](.md)| The id of the event. | 
 **sessiondate** | **DateTime**| The date and time when the session starts. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionregsavesettings

> sessionregsavesettings(opts)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save the settings for an event's session registration
  api_instance.sessionregsavesettings(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionregsavesettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the session swipe to delete.

begin
  #Delete a session swipe
  api_instance.sessionswipedelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionswipedelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the session swipe to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the swipe to get.

begin
  #View details of a class attendance swipe
  api_instance.sessionswipeget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionswipeget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the swipe to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  token: 'token_example' # String | The authentication token.
}

begin
  #View a list of unresolved swipes
  api_instance.sessionswipelistunresolved(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionswipelistunresolved: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **token** | **String**| The authentication token. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the swipe to resolve.
opts = {
  session: 'session_example', # String | The id of the session whose swipe has to be saved.
  user: 'user_example' # String | The id of the user who signed-in.
}

begin
  #Resolve a swipe and create the corresponding attendance log
  api_instance.sessionswiperesolve(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionswiperesolve: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the swipe to resolve. | 
 **session** | [**String**](.md)| The id of the session whose swipe has to be saved. | [optional] 
 **user** | [**String**](.md)| The id of the user who signed-in. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Creates a new swipe, and if possible, creates the attendance log
  api_instance.sessionswipesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionswipesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionswipesaveanonym

> sessionswipesaveanonym(opts)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Creates a new swipe from a sign-in station, and if possible, creates the attendance log
  api_instance.sessionswipesaveanonym(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->sessionswipesaveanonym: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # String | The original filename, needed to process the file.

begin
  #Add a logo to the account
  api_instance.settingaddlogo(token, upload, filename)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->settingaddlogo: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The original filename, needed to process the file. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## settingget

> settingget(keys, opts)

Get settings for the account or the specified scope

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
keys = 'keys_example' # String | The option keys to get values for. Enter multiple separated by comma.
opts = {
  token: 'token_example', # String | The authentication token.
  domain: 'domain_example', # String | The account domain, in case of reading settings annonymously.
  scope: 'scope_example' # String | The scope of the settings to get.
}

begin
  #Get settings for the account or the specified scope
  api_instance.settingget(keys, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->settingget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **String**| The option keys to get values for. Enter multiple separated by comma. | 
 **token** | **String**| The authentication token. | [optional] 
 **domain** | **String**| The account domain, in case of reading settings annonymously. | [optional] 
 **scope** | **String**| The scope of the settings to get. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save settings for the account or the specified scope
  api_instance.settingsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->settingsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## settingviewgeneral

> settingviewgeneral(token)

View general settings for the account

Allows the user to view the settings' general section.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View general settings for the account
  api_instance.settingviewgeneral(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->settingviewgeneral: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialcontacts

> socialcontacts(token, opts)

Gets the list of contacts in the network

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  filter: 'filter_example', # String | Text to filter results.
  showdefaultphoto: true # Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
}

begin
  #Gets the list of contacts in the network
  api_instance.socialcontacts(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->socialcontacts: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **filter** | **String**| Text to filter results. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupaddmembers

> socialgroupaddmembers(token, id, userids)

Adds new members to a group (which the user must own already)

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | ID of the group to add members to.
userids = 'userids_example' # String | Csv list of user Ids to add.

begin
  #Adds new members to a group (which the user must own already)
  api_instance.socialgroupaddmembers(token, id, userids)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->socialgroupaddmembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to add members to. | 
 **userids** | **String**| Csv list of user Ids to add. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupdelete

> socialgroupdelete(token, id)

Deletes a group

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | ID of the group to delete.

begin
  #Deletes a group
  api_instance.socialgroupdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->socialgroupdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to delete. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgrouplist

> socialgrouplist(token)

View all the groups the current user is in

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View all the groups the current user is in
  api_instance.socialgrouplist(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->socialgrouplist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgrouplistmembers

> socialgrouplistmembers(token, id)

Lists the members of a group

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | ID of the group to list members.

begin
  #Lists the members of a group
  api_instance.socialgrouplistmembers(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->socialgrouplistmembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to list members. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupremovemembers

> socialgroupremovemembers(token, id, userids)

Removes members from a group (which the user must own already)

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | ID of the group to remove members from.
userids = 'userids_example' # String | Csv list of user Ids to remove.

begin
  #Removes members from a group (which the user must own already)
  api_instance.socialgroupremovemembers(token, id, userids)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->socialgroupremovemembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to remove members from. | 
 **userids** | **String**| Csv list of user Ids to remove. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupremovemyself

> socialgroupremovemyself(token, id)

Removes myself from an existent group

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | ID of the group to remove me from.

begin
  #Removes myself from an existent group
  api_instance.socialgroupremovemyself(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->socialgroupremovemyself: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| ID of the group to remove me from. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroupsave

> socialgroupsave(opts)

Saves a new group

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a new group
  api_instance.socialgroupsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->socialgroupsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Generate/reset single sign on access key.
  api_instance.ssogeneratekey(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ssogeneratekey: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View single sign on settings.
  api_instance.ssogetsettings(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ssogetsettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ssoissuetoken

> ssoissuetoken(key, username, opts)

Issue single sign-on token

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
key = 'key_example' # String | The single sign-on key of the account.
username = 'username_example' # String | The email of the user to sign-on.
opts = {
  expires: true # Boolean | Specifies whether the session should expire when inactive.
}

begin
  #Issue single sign-on token
  api_instance.ssoissuetoken(key, username, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ssoissuetoken: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **String**| The single sign-on key of the account. | 
 **username** | **String**| The email of the user to sign-on. | 
 **expires** | **Boolean**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Edit single sign-on settings.
  api_instance.ssosavesettings(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->ssosavesettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Associate current user to all services
  api_instance.staffavailaddmetoallservices(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailaddmetoallservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceid = 'serviceid_example' # String | The id of the service.

begin
  #Associate current user to a service
  api_instance.staffavailaddmetoservice(token, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailaddmetoservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to add.

begin
  #Associate a staff member to all services
  api_instance.staffavailaddusertoallservices(token, userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailaddusertoallservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to add.
serviceid = 'serviceid_example' # String | The id of the service.

begin
  #Associate a staff member to a service
  api_instance.staffavailaddusertoservice(token, userid, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailaddusertoservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View the services the current user is available for
  api_instance.staffavailgetmyservices(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailgetmyservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The user id to list services.

begin
  #View a list of services that a staff member is available for
  api_instance.staffavailgetservices(token, userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailgetservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The user id to list services. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceid = 'serviceid_example' # String | The service id to list users.

begin
  #View a list of staff members that are available for a specific service
  api_instance.staffavailgetusersforservice(token, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailgetusersforservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The service id to list users. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavaillisttypes

> staffavaillisttypes(token)

View all the availability types

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View all the availability types
  api_instance.staffavaillisttypes(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavaillisttypes: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Remove current user from all services
  api_instance.staffavailremovemefromallservices(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailremovemefromallservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
serviceid = 'serviceid_example' # String | The id of the service.

begin
  #Remove current user from a service
  api_instance.staffavailremovemefromservice(token, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailremovemefromservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailremoveuserfromallservices

> staffavailremoveuserfromallservices(token, userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to remove.

begin
  #Removes a staff member from the registration to all services
  api_instance.staffavailremoveuserfromallservices(token, userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailremoveuserfromallservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailremoveuserfromservice

> staffavailremoveuserfromservice(token, userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to remove.
serviceid = 'serviceid_example' # String | The id of the service.

begin
  #Remove a staff member from a service
  api_instance.staffavailremoveuserfromservice(token, userid, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailremoveuserfromservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user whose specific availability has to be set.
opts = {
  availablefor: 'availablefor_example' # String | Specific availability to set.
}

begin
  #Make a staff member available for a specific availability type
  api_instance.staffavailsetavailability(token, userid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailsetavailability: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user whose specific availability has to be set. | 
 **availablefor** | **String**| Specific availability to set. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailsetmyavailability

> staffavailsetmyavailability(token, opts)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  availablefor: 'availablefor_example' # String | Specific availability to set.
}

begin
  #Change current user's availability type
  api_instance.staffavailsetmyavailability(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->staffavailsetmyavailability: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **availablefor** | **String**| Specific availability to set. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the sign-in station to delete.

begin
  #Delete a sign-in station
  api_instance.stationdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the sign-in station to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the sign-in station to get.

begin
  #View details of a sign-in station
  api_instance.stationget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the sign-in station to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationgetcurrentterms

> stationgetcurrentterms(station)

Get all the current terms

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station whose account's current terms have to be retrieved.

begin
  #Get all the current terms
  api_instance.stationgetcurrentterms(station)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationgetcurrentterms: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationgetinfo

> stationgetinfo(id, opts)

Gets a the info to display in the sign-in station by it's ID.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
id = 'id_example' # String | The id of the sign-in station to get.
opts = {
  event: 'event_example' # String | The id of the event, to override the one by schedule.
}

begin
  #Gets a the info to display in the sign-in station by it's ID.
  api_instance.stationgetinfo(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationgetinfo: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to get. | 
 **event** | [**String**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationgetlicense

> stationgetlicense(station)

Gets the current license information

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station whose account's license has to be retrieved.

begin
  #Gets the current license information
  api_instance.stationgetlicense(station)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationgetlicense: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | **String**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
location = 'location_example' # String | The id of the location whose station settings have to be returned.

begin
  #View the sign-in station settings of a specified location
  api_instance.stationgetlocationsettings(location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationgetlocationsettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**String**](.md)| The id of the location whose station settings have to be returned. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of sign-in stations
  api_instance.stationlist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a sign-in station
  api_instance.stationsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a class attendance sign-in station for myself
  api_instance.stationsavemine(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationsavemine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## stationunlock

> stationunlock(id, passcode, method)

Unlocks the sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
id = 'id_example' # String | The id of the sign-in station to unlock.
passcode = 'passcode_example' # String | The passcode to unlock the station.
method = 'method_example' # String | The authentication method. Valid values are 'token' and 'cookie'.

begin
  #Unlocks the sign-in station.
  api_instance.stationunlock(id, passcode, method)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->stationunlock: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to unlock. | 
 **passcode** | **String**| The passcode to unlock the station. | 
 **method** | **String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the swipe to delete.

begin
  #Delete a swipe
  api_instance.swipedelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->swipedelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the swipe to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the swipe to get.

begin
  #Search and view details of a swipe
  api_instance.swipeget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->swipeget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the swipe to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  token: 'token_example' # String | The authentication token.
}

begin
  #View a list of swipes
  api_instance.swipelist(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->swipelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **token** | **String**| The authentication token. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a swipe, and if possible, save the related attendance log
  api_instance.swipesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->swipesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## swipesaveanonym

> swipesaveanonym(opts)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Creates a new swipe from a sign-in station, and if possible, creates the attendance log
  api_instance.swipesaveanonym(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->swipesaveanonym: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the tag to delete.

begin
  #Delete a tag
  api_instance.tagdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->tagdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the tag to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the tag to get.

begin
  #View details of a specified tag
  api_instance.tagget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->tagget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the tag to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
group = 'group_example' # String | The group of the tags to return.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of tags
  api_instance.taglist(token, group, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->taglist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **group** | **String**| The group of the tags to return. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## taglistgroups

> taglistgroups(token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #View a list of entities that can be tagged
  api_instance.taglistgroups(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->taglistgroups: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a tag
  api_instance.tagsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->tagsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
query = 'query_example' # String | The query to search tags. Use group:<group> to search in a specific group (mandatory).
opts = {
  allowcreatingnew: true # Boolean | Specifies whether an option to create a new tag should be retrieved.
}

begin
  #Search for tags in the account
  api_instance.tagsearch(token, query, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->tagsearch: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **query** | **String**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **allowcreatingnew** | **Boolean**| Specifies whether an option to create a new tag should be retrieved. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
template = 'template_example' # String | The id of the template where the image has to be added
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
opts = {
  filename: 'filename_example' # String | The local name of the uploaded file. For later reference.
}

begin
  #Add an image to a template
  api_instance.templateaddimage(token, template, upload, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templateaddimage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **template** | [**String**](.md)| The id of the template where the image has to be added | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the template to delete.

begin
  #Delete a template
  api_instance.templatedelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templatedelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the template to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
jobid = 'jobid_example' # String | The id of the job that is creating the templates.
emailsubject = 'emailsubject_example' # String | Args depending on the send-to flag.
emailbody = 'emailbody_example' # String | Args depending on the send-to flag.
opts = {
  templatekind: 'templatekind_example', # String | The kind of the template you're sending. It must be included in (badge, certificate).
  emailfrom: 'emailfrom_example', # String | The name of the sender to be displayed in the receipients inbox
  emailreplyto: 'emailreplyto_example' # String | The reply-to field for the emails.
}

begin
  #Send generated templates by email
  api_instance.templateemail(token, jobid, emailsubject, emailbody, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templateemail: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
template = 'template_example' # String | The id of the template to generate.
source = 'source_example' # String | The source key of the selected template data source.
singlefile = true # Boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
opts = {
  userid: 'userid_example', # String | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
  forsending: true, # Boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
  role: 'role_example', # String | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
  filters: 'filters_example' # String | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...
}

begin
  #Generate specified templates
  api_instance.templategenerate(token, template, source, singlefile, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templategenerate: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the template to get.

begin
  #View details of a template
  api_instance.templateget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templateget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the template to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
jobid = 'jobid_example' # String | The id of the job that is creating the templates.

begin
  #View generated templates
  api_instance.templategetgenerated(token, jobid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templategetgenerated: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **jobid** | **String**| The id of the job that is creating the templates. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
kind = 'kind_example' # String | The kind of the templates to return. It must be included in (badge, certificate).
opts = {
  designedonly: true # Boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.
}

begin
  #View a list of defined templates
  api_instance.templatelist(token, from, count, kind, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templatelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **Boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## templatelistsources

> templatelistsources(token, kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
kind = 'kind_example' # String | The kind of the templates to return. It must be included in (badge, certificate).

begin
  #View a list of templates' data sources
  api_instance.templatelistsources(token, kind)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templatelistsources: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a template
  api_instance.templatesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templatesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## templatesavelayout

> templatesavelayout(opts)

Save the layout of a template

Allows the user to edit a template's layout.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save the layout of a template
  api_instance.templatesavelayout(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->templatesavelayout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the term to delete.

begin
  #Delete a term
  api_instance.termdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->termdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the term to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the term to get.

begin
  #Search and view details of a term
  api_instance.termget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->termget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the term to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  from: 56, # Integer | The first record to return.
  count: 56, # Integer | The max number of records to return.
  notpast: true # Boolean | Specifies whether the terms in the past should be returned or not.
}

begin
  #Search and view details of all terms
  api_instance.termlist(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->termlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | [optional] 
 **count** | **Integer**| The max number of records to return. | [optional] 
 **notpast** | **Boolean**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create and edit terms
  api_instance.termsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->termsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## textcreditremaining

> textcreditremaining(token)

Gets the remaining text credits for the account

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Gets the remaining text credits for the account
  api_instance.textcreditremaining(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->textcreditremaining: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## texttoimage

> texttoimage(token, text, opts)

Generates a dynamic image from text

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
text = 'text_example' # String | The text to convert to an image, use double pipes (||) as a new line.
opts = {
  fontcolor: 'fontcolor_example', # String | The color of the text, in hex format, without the #.
  fontsize: 56, # Integer | The size of the text, in points.
  direction: 'direction_example', # String | Either vertical or horizontal, default horizontal.
  width: 56 # Integer | The image width in pixels (or height if the direction is vertical).
}

begin
  #Generates a dynamic image from text
  api_instance.texttoimage(token, text, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->texttoimage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **text** | **String**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **String**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **Integer**| The size of the text, in points. | [optional] 
 **direction** | **String**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **Integer**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translationget

> translationget(token, universal)

Gets the translations of the specified values

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
universal = 'universal_example' # String | Pipe separated list of universal text to be translated.

begin
  #Gets the translations of the specified values
  api_instance.translationget(token, universal)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->translationget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **universal** | **String**| Pipe separated list of universal text to be translated. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translationgetcachefile

> translationgetcachefile(opts)

Get the file containing the translations

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  token: 'token_example', # String | The authentication token.
  account: 'account_example' # String | The id of the account whose translations file has to be retrieved.
}

begin
  #Get the file containing the translations
  api_instance.translationgetcachefile(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->translationgetcachefile: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | [optional] 
 **account** | **String**| The id of the account whose translations file has to be retrieved. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translationlist

> translationlist(token, opts)

Lists all the available translations in the system

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  filter: 'filter_example', # String | Text to search/filter translations.
  nondefaultonly: true, # Boolean | If true then it returns only the terms translated. Otherwise, it returns all.
  appdefaultasuniversal: true # Boolean | If true then it uses the app default translation as the universal term.
}

begin
  #Lists all the available translations in the system
  api_instance.translationlist(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->translationlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **filter** | **String**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **Boolean**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **Boolean**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Edit a translation
  api_instance.translationsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->translationsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userchangepwd

> userchangepwd(token, oldpass, newpass)

Change user's own password

Allows the user to change their own password.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
oldpass = 'oldpass_example' # String | The old password of the authenticated user.
newpass = 'newpass_example' # String | The new password of the authenticated user.

begin
  #Change user's own password
  api_instance.userchangepwd(token, oldpass, newpass)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userchangepwd: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **oldpass** | [**String**](.md)| The old password of the authenticated user. | 
 **newpass** | [**String**](.md)| The new password of the authenticated user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userchangepwdbyreq

> userchangepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
changereq = 'changereq_example' # String | The change password request ID sent by email to the user.
newpass = 'newpass_example' # String | The new password of the user.

begin
  #Changes the user password using a change password request id
  api_instance.userchangepwdbyreq(changereq, newpass)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userchangepwdbyreq: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **String**| The change password request ID sent by email to the user. | 
 **newpass** | **String**| The new password of the user. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the user to delete.

begin
  #Delete a user
  api_instance.userdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  currentid: 'currentid_example', # String | The id of the current user.
  phonenumber: 'phonenumber_example', # String | A phone number to search for similar users.
  cardnumber: 'cardnumber_example' # String | A card number to search for similar users.
}

begin
  #Finds similar users to prevent duplicates
  api_instance.userfindsimilar(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userfindsimilar: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **currentid** | [**String**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **String**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **String**| A card number to search for similar users. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the user to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Search and view details of a user
  api_instance.userget(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
card = 'card_example' # String | The card number of the user to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Search user by card number
  api_instance.usergetbycard(token, card, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergetbycard: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **card** | **String**| The card number of the user to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to add.
groupid = 'groupid_example' # String | The id of the group.

begin
  #Add a user to a group
  api_instance.usergroupaddmember(token, userid, groupid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergroupaddmember: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to add. | 
 **groupid** | [**String**](.md)| The id of the group. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the group to delete.

begin
  #Delete a group
  api_instance.usergroupdelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergroupdelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the group to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the user group to get.

begin
  #Search and view details of a user group
  api_instance.usergroupget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergroupget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user group to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
groupid = 'groupid_example' # String | The id of the user group to get.

begin
  #View the members of a user group
  api_instance.usergroupgetmembers(token, groupid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergroupgetmembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **groupid** | [**String**](.md)| The id of the user group to get. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to get his groups.

begin
  #View the groups which a user is registered to
  api_instance.usergroupgetuser(token, userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergroupgetuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to get his groups. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  from: 56, # Integer | The first record to return.
  count: 56, # Integer | The max number of records to return.
  type: 'type_example' # String | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.
}

begin
  #View a list of user groups
  api_instance.usergrouplist(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergrouplist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | [optional] 
 **count** | **Integer**| The max number of records to return. | [optional] 
 **type** | **String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
group = 'group_example' # String | The ID of the group to refresh.

begin
  #Refresh the dynamic group
  api_instance.usergrouprefresh(token, group)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergrouprefresh: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **group** | [**String**](.md)| The ID of the group to refresh. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
userid = 'userid_example' # String | The id of the user to remove.
groupid = 'groupid_example' # String | The id of the group.

begin
  #Remove a user from a group
  api_instance.usergroupremovemember(token, userid, groupid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergroupremovemember: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **groupid** | [**String**](.md)| The id of the group. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a group
  api_instance.usergroupsave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergroupsave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
group = 'group_example' # String | The id of the group to save whose members have to be tagged.
opts = {
  tags: 'tags_example' # String | The tags to assign to the members of the specified group, in JSON format.
}

begin
  #Assign tags to the members of a specified group
  api_instance.usergrouptagmembers(token, group, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergrouptagmembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **group** | [**String**](.md)| The id of the group to save whose members have to be tagged. | 
 **tags** | **String**| The tags to assign to the members of the specified group, in JSON format. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
group = 'group_example' # String | The id of the group to save whose members have to be untagged.
opts = {
  tags: 'tags_example' # String | The tags to unassign from the members of the specified group, in JSON format.
}

begin
  #Unassign tags from the members of a specified group
  api_instance.usergroupuntagmembers(token, group, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usergroupuntagmembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **group** | [**String**](.md)| The id of the group to save whose members have to be untagged. | 
 **tags** | **String**| The tags to unassign from the members of the specified group, in JSON format. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  roleid: 'roleid_example', # String | The id of the role to filter users by, or empty to return all users.
  onlywithoutcard: 'onlywithoutcard_example', # String | If is 1 then only the users without a card are returned, otherwise all users are returned.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View a list of users
  api_instance.userlist(token, from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **roleid** | [**String**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
opts = {
  filename: 'filename_example', # String | The local name of the uploaded file. For later reference.
  userid: 'userid_example', # String | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
  automatch: true # Boolean | Set this to true to find the specific user based on the file name. 
}

begin
  #Upload a photo for a specific user
  api_instance.userloadphoto(token, upload, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userloadphoto: #{e}"
end
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

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
source = 'source_example' # String | The id of the user that is the source of the data.
destination = 'destination_example' # String | The id of the user that is the destination of the data.

begin
  #Move data between users
  api_instance.usermovedata(token, source, destination)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usermovedata: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **source** | [**String**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**String**](.md)| The id of the user that is the destination of the data. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the user profile to delete.

begin
  #Delete a user profile
  api_instance.userprofiledelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userprofiledelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user profile to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the profile question set.

begin
  #View a specific user profile
  api_instance.userprofileget(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userprofileget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the profile question set. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  id: 'id_example' # String | The id of the user to view, or empty for current user.
}

begin
  #Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
  api_instance.userprofilegetallview(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userprofilegetallview: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the user to view, or empty for current user. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  from: 56, # Integer | The first record to return.
  count: 56 # Integer | The max number of records to return.
}

begin
  #View the list of user profiles
  api_instance.userprofilelist(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userprofilelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | [optional] 
 **count** | **Integer**| The max number of records to return. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Gets the list of all the available user questions
  api_instance.userprofilelistquestions(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userprofilelistquestions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
opts = {
  params: 'params_example' # String | The ID of the group, specified as 'group=...'
}

begin
  #Gets the statistics of a user group
  api_instance.userprofilepreparestats(token, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userprofilepreparestats: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **params** | **String**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit user profile questions
  api_instance.userprofilesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userprofilesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
  api_instance.userprofilesaveanswers(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userprofilesaveanswers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userrequestpwdchange

> userrequestpwdchange(domain, email)

Requests a password change

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
domain = 'domain_example' # String | The domain of the account where the user exists.
email = 'email_example' # String | The email of the user.

begin
  #Requests a password change
  api_instance.userrequestpwdchange(domain, email)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->userrequestpwdchange: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **String**| The domain of the account where the user exists. | 
 **email** | **String**| The email of the user. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a user
  api_instance.usersave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usersave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Send email to the specified user(s) to set/change their passwords
  api_instance.usersavepwdchange(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usersavepwdchange: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## usersettingsget

> usersettingsget(token, keys, opts)

Lists available user settings

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
keys = 'keys_example' # String | Setting key to get. Can be multiple separated by commas.
opts = {
  user: 'user_example' # String | The user id whose settings have to be returned.
}

begin
  #Lists available user settings
  api_instance.usersettingsget(token, keys, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usersettingsget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **keys** | **String**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**String**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usersettingsgetmultiple

> usersettingsgetmultiple(token, keys, opts)

Get multiple user settings

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
keys = 'keys_example' # String | Setting key to get. Can be multiple separated by commas.
opts = {
  user: 'user_example' # String | The user id whose settings have to be returned.
}

begin
  #Get multiple user settings
  api_instance.usersettingsgetmultiple(token, keys, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usersettingsgetmultiple: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **keys** | **String**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**String**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usersettingssave

> usersettingssave(opts)

Saves a user setting

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a user setting
  api_instance.usersettingssave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usersettingssave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## usersettingssavemultiple

> usersettingssavemultiple(opts)

Save multiple user settings at once

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save multiple user settings at once
  api_instance.usersettingssavemultiple(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usersettingssavemultiple: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## version

> version(token)

Get current version information

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Get current version information
  api_instance.version(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->version: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
waitinglineid = 'waitinglineid_example' # String | ID of the waiting line to join.

begin
  #Add myself to a waiting line
  api_instance.virtuallineaddmyself(token, waitinglineid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->virtuallineaddmyself: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **waitinglineid** | [**String**](.md)| ID of the waiting line to join. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## virtuallinelist

> virtuallinelist(token)

Lists waiting lines that have remote access enabled

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Lists waiting lines that have remote access enabled
  api_instance.virtuallinelist(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->virtuallinelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Remove myself from a waiting line
  api_instance.virtuallineremovemyself(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->virtuallineremovemyself: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineadduser

> waitinglineadduser(station, user, opts)

Put user in a waiting line

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station.
user = 'user_example' # String | The user's card number.
opts = {
  locationid: 'locationid_example', # String | The location's id where the swipe must be saved.
  time: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The date and time of the swipe.
  signinrole: 'signinrole_example', # String | Specifies if the sign-in is for an attendee or a staff member
  roleid: 'roleid_example', # String | Specifies the role the user has selected in order to sign-in
  services: 'services_example', # String | The services ids the user has selected.
  eventid: 'eventid_example', # String | The id of the event the user selected.
  staff: 'staff_example', # String | The id of the staff member the user selected.
  photosize: 56 # Integer | The swiping user's photo size.
}

begin
  #Put user in a waiting line
  api_instance.waitinglineadduser(station, user, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->waitinglineadduser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station. | 
 **user** | **String**| The user&#39;s card number. | 
 **locationid** | [**String**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **DateTime**| The date and time of the swipe. | [optional] 
 **signinrole** | **String**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**String**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **String**| The services ids the user has selected. | [optional] 
 **eventid** | [**String**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**String**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **Integer**| The swiping user&#39;s photo size. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the line to delete.

begin
  #Delete a waiting line
  api_instance.waitinglinedelete(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->waitinglinedelete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the line to delete. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the waiting line to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View details of a waiting line
  api_instance.waitinglineget(token, id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->waitinglineget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the waiting line to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitinglineisuserin

> waitinglineisuserin(station, time, user, opts)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
station = 'station_example' # String | The id of the sign-in station.
time = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time of the swipe.
user = 'user_example' # String | The card number of the user.
opts = {
  location: 'location_example' # String | The id of the location the user picked.
}

begin
  #Check whether a user is in a waiting line, signed-in or is not in the area
  api_instance.waitinglineisuserin(station, time, user, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->waitinglineisuserin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station. | 
 **time** | **DateTime**| The date and time of the swipe. | 
 **user** | **String**| The card number of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of waiting lines
  api_instance.waitinglinelist(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->waitinglinelist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
waitingline = 'waitingline_example' # String | The id of the waiting line whose item has to be removed.
itemid = 'itemid_example' # String | The ID of the item that has to be removed.

begin
  #Remove a user from a waiting line
  api_instance.waitinglineremoveuser(token, waitingline, itemid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->waitinglineremoveuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **waitingline** | [**String**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**String**](.md)| The ID of the item that has to be removed. | 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a waiting line
  api_instance.waitinglinesave(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->waitinglinesave: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

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

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
waitingline = 'waitingline_example' # String | The id of the waiting line whose item needs to be signed-in.
itemid = 'itemid_example' # String | The ID of the item that has to be signed-in.
staff = 'staff_example' # String | The id of the staff member selected to sign-in.
opts = {
  photosize: 56 # Integer | The swiping user's photo size.
}

begin
  #Sign a user in from a waiting line
  api_instance.waitinglinesigninuser(token, waitingline, itemid, staff, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->waitinglinesigninuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **waitingline** | [**String**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**String**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**String**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **Integer**| The swiping user&#39;s photo size. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

