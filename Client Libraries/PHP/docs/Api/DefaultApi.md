# OpenAPI\Client\DefaultApi

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

> actionassignmentdelete($token, $id)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the action assignment to delete.

try {
    $apiInstance->actionassignmentdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the action assignment to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionassignmentget

> actionassignmentget($token, $id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the action assignment to get.

try {
    $apiInstance->actionassignmentget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the action assignment to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionassignmentlist

> actionassignmentlist($token, $from, $count, $assignee, $status)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$assignee = 56; // int | The assignee's id to filter the assignments.
$status = 56; // int | The status to filter the assignments.

try {
    $apiInstance->actionassignmentlist($token, $from, $count, $assignee, $status);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionassignmentlisthistory

> actionassignmentlisthistory($token, $actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$actionassignment = 'actionassignment_example'; // string | The action assignment's id whose history the user wants to get.

try {
    $apiInstance->actionassignmentlisthistory($token, $actionassignment);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentlisthistory: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **actionassignment** | [**string**](../Model/.md)| The action assignment&#39;s id whose history the user wants to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionassignmentlistmine

> actionassignmentlistmine($token, $from, $count, $status)

List public action assignments assigned to the logged user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$status = 56; // int | The status to filter the assignments.

try {
    $apiInstance->actionassignmentlistmine($token, $from, $count, $status);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentlistmine: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionassignmentlistpublichistory

> actionassignmentlistpublichistory($token, $actionassignment)

List public action assignment history

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$actionassignment = 'actionassignment_example'; // string | The action assignment's id whose history the user wants to get.

try {
    $apiInstance->actionassignmentlistpublichistory($token, $actionassignment);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentlistpublichistory: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **actionassignment** | [**string**](../Model/.md)| The action assignment&#39;s id whose history the user wants to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionassignmentmarkcomplete

> actionassignmentmarkcomplete($token, $item, $assignee, $group, $notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$item = 'item_example'; // string | The action item to assign.
$assignee = 'assignee_example'; // string | The assignee of the item.
$group = 'group_example'; // string | The group to assing the item.
$notes = 'notes_example'; // string | The assignment's notes.

try {
    $apiInstance->actionassignmentmarkcomplete($token, $item, $assignee, $group, $notes);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentmarkcomplete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **item** | **string**| The action item to assign. |
 **assignee** | [**string**](../Model/.md)| The assignee of the item. | [optional]
 **group** | [**string**](../Model/.md)| The group to assing the item. | [optional]
 **notes** | **string**| The assignment&#39;s notes. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionassignmentsave

> actionassignmentsave($unknown_base_type)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->actionassignmentsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionassignmentsavehistory

> actionassignmentsavehistory($unknown_base_type)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->actionassignmentsavehistory($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionassignmentsavehistory: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionitemdelete

> actionitemdelete($token, $id)

Delete an action item

Allows the user to delete an action item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the action item to delete.

try {
    $apiInstance->actionitemdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionitemdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the action item to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionitemget

> actionitemget($token, $id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the action item to get.

try {
    $apiInstance->actionitemget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionitemget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the action item to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionitemlist

> actionitemlist($token, $from, $count)

View a list of action items

Allows the user to view a list of action items

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->actionitemlist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionitemlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionitemsave

> actionitemsave($unknown_base_type)

Create or edit an action item

Allows the user to edit an action item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->actionitemsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionitemsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionloglist

> actionloglist($token, $from, $count, $user, $startdate, $enddate, $resource, $actionfilter, $argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$user = 'user_example'; // string | The id of the user whose action logs have to be returned.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the logs.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the logs.
$resource = 'resource_example'; // string | The resource to filter the action logs.
$actionfilter = 'actionfilter_example'; // string | The action to filter the action logs.
$argument = 'argument_example'; // string | The id of the entity that was the argument of the executed action.

try {
    $apiInstance->actionloglist($token, $from, $count, $user, $startdate, $enddate, $resource, $actionfilter, $argument);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionloglist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **user** | [**string**](../Model/.md)| The id of the user whose action logs have to be returned. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the logs. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the logs. | [optional]
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionpackassign

> actionpackassign($token, $pack, $itemsdata, $assignee, $group, $notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$pack = 'pack_example'; // string | The id of the action pack to assign.
$itemsdata = True; // bool | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
$assignee = 'assignee_example'; // string | The assignee of the pack.
$group = 'group_example'; // string | The group to assign the pack.
$notes = 'notes_example'; // string | The assignment's notes.

try {
    $apiInstance->actionpackassign($token, $pack, $itemsdata, $assignee, $group, $notes);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionpackassign: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **pack** | [**string**](../Model/.md)| The id of the action pack to assign. |
 **itemsdata** | **bool**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). |
 **assignee** | [**string**](../Model/.md)| The assignee of the pack. | [optional]
 **group** | [**string**](../Model/.md)| The group to assign the pack. | [optional]
 **notes** | **string**| The assignment&#39;s notes. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionpackdelete

> actionpackdelete($token, $id)

Delete an action item pack

Allows the user to delete an action item pack.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the action pack to delete.

try {
    $apiInstance->actionpackdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionpackdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the action pack to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionpackget

> actionpackget($token, $id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the action pack to get.

try {
    $apiInstance->actionpackget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionpackget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the action pack to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionpacklist

> actionpacklist($token, $from, $count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->actionpacklist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionpacklist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actionpacksave

> actionpacksave($unknown_base_type)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->actionpacksave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actionpacksave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actiontypedelete

> actiontypedelete($token, $id)

Delete an action item type

Allows the user to delete an action item type.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the action type to delete.

try {
    $apiInstance->actiontypedelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actiontypedelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the action type to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actiontypeget

> actiontypeget($token, $id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the action type to get.

try {
    $apiInstance->actiontypeget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actiontypeget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the action type to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actiontypelist

> actiontypelist($token, $from, $count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->actiontypelist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actiontypelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## actiontypesave

> actiontypesave($unknown_base_type)

Create or edit an action item type

Allows the user to dit an action item type.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->actiontypesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->actiontypesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocquerycheckexecution

> adhocquerycheckexecution($token, $id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the ad hoc query execution to be checked.

try {
    $apiInstance->adhocquerycheckexecution($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocquerycheckexecution: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the ad hoc query execution to be checked. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocquerydelete

> adhocquerydelete($token, $id)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the ad hoc query to delete.

try {
    $apiInstance->adhocquerydelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocquerydelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the ad hoc query to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocqueryexecute

> adhocqueryexecute($token, $id, $query)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the query to execute.
$query = 'query_example'; // string | The query to execute.

try {
    $apiInstance->adhocqueryexecute($token, $id, $query);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocqueryexecute: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the query to execute. | [optional]
 **query** | **string**| The query to execute. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocqueryget

> adhocqueryget($token, $id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the query to get.

try {
    $apiInstance->adhocqueryget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocqueryget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the query to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocquerygetschema

> adhocquerygetschema($token)

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->adhocquerygetschema($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocquerygetschema: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocquerylist

> adhocquerylist($token, $from, $count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->adhocquerylist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocquerylist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocquerylistexecutions

> adhocquerylistexecutions($token, $from, $count, $query)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$query = 'query_example'; // string | The first record to return.

try {
    $apiInstance->adhocquerylistexecutions($token, $from, $count, $query);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocquerylistexecutions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **query** | [**string**](../Model/.md)| The first record to return. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocquerysave

> adhocquerysave($unknown_base_type)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->adhocquerysave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocquerysave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocquerystopexecution

> adhocquerystopexecution($token, $id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the ad hoc query execution to be stopped.

try {
    $apiInstance->adhocquerystopexecution($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocquerystopexecution: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the ad hoc query execution to be stopped. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## adhocreportsreqaccess

> adhocreportsreqaccess($token)

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->adhocreportsreqaccess($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->adhocreportsreqaccess: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationcheckunknownuser

> advancedstationcheckunknownuser($station, $user, $location)

Check whether the user is known by the system.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->advancedstationcheckunknownuser($station, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationcheckunknownuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationcheckuserrole

> advancedstationcheckuserrole($station, $user, $location)

Check whether the user is a staff member, an attendee or both.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->advancedstationcheckuserrole($station, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationcheckuserrole: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationcreateuser

> advancedstationcreateuser($station, $user, $location, $firstname, $lastname, $email, $middlename)

Creates a user via a sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user to create.
$location = 'location_example'; // string | The id of the location the user picked.
$firstname = 'firstname_example'; // string | The first name of the user to create.
$lastname = 'lastname_example'; // string | The last name of the user to create.
$email = 'email_example'; // string | The email of the user to create.
$middlename = 'middlename_example'; // string | The middle name of the user to create.

try {
    $apiInstance->advancedstationcreateuser($station, $user, $location, $firstname, $lastname, $email, $middlename);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationcreateuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user to create. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. |
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationgetevents

> advancedstationgetevents($station, $location, $user)

Gets the courses available for a specific location and a specific student.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$location = 'location_example'; // string | The id of the location the student picked.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->advancedstationgetevents($station, $location, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationgetevents: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **location** | [**string**](../Model/.md)| The id of the location the student picked. |
 **user** | **string**| The card of the user. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationgetinfo

> advancedstationgetinfo($id, $event)

Gets the info to display in the sign-in station by it's ID.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = 'id_example'; // string | The id of the sign-in station to get.
$event = 'event_example'; // string | The id of the event (or session), to override the scheduled one.

try {
    $apiInstance->advancedstationgetinfo($id, $event);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationgetinfo: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **event** | [**string**](../Model/.md)| The id of the event (or session), to override the scheduled one. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationgetlocations

> advancedstationgetlocations($station, $user)

Gets the locations available in a sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station whose locations have to be returned.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->advancedstationgetlocations($station, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationgetlocations: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station whose locations have to be returned. |
 **user** | **string**| The card of the user. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationgetlogstaff

> advancedstationgetlogstaff($station, $attendancelog, $photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$attendancelog = 'attendancelog_example'; // string | The id of the attendance log to filter the staff members.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->advancedstationgetlogstaff($station, $attendancelog, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationgetlogstaff: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **attendancelog** | [**string**](../Model/.md)| The id of the attendance log to filter the staff members. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationgetroles

> advancedstationgetroles($station, $signinrole, $user, $location)

Gets the user roles of the user trying to sign-in.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$signinrole = 'signinrole_example'; // string | Specifies how the user is signing-in.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->advancedstationgetroles($station, $signinrole, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationgetroles: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **signinrole** | **string**| Specifies how the user is signing-in. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationgetservices

> advancedstationgetservices($station, $location, $user)

Gets the services available for a specific location.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$location = 'location_example'; // string | The id of the location the student picked.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->advancedstationgetservices($station, $location, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationgetservices: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **location** | [**string**](../Model/.md)| The id of the location the student picked. |
 **user** | **string**| The card of the user. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationgetstaff

> advancedstationgetstaff($station, $locationid, $user, $services, $eventid, $photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$locationid = 'locationid_example'; // string | The id of the location the student picked.
$user = 'user_example'; // string | The card of the user.
$services = 'services_example'; // string | The list of services selected by the user, in JSON format.
$eventid = 'eventid_example'; // string | The ID of the event selected.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->advancedstationgetstaff($station, $locationid, $user, $services, $eventid, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationgetstaff: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **locationid** | [**string**](../Model/.md)| The id of the location the student picked. |
 **user** | **string**| The card of the user. |
 **services** | **string**| The list of services selected by the user, in JSON format. | [optional]
 **eventid** | [**string**](../Model/.md)| The ID of the event selected. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advancedstationissignedin

> advancedstationissignedin($station, $time, $user, $location)

Gets whether a user is signed-in or not.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$time = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time of the swipe.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->advancedstationissignedin($station, $time, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advancedstationissignedin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **time** | **\DateTime**| The date and time of the swipe. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advroleaddmissing

> advroleaddmissing($token, $roles, $permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$roles = 'roles_example'; // string | CSV list of the role ids to check
$permissions = 'permissions_example'; // string | CSV list of the permissions to check

try {
    $apiInstance->advroleaddmissing($token, $roles, $permissions);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advroleaddmissing: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advrolecheckperm

> advrolecheckperm($token, $roles, $permissions)

Checks the permissions are assigned for the given roles

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$roles = 'roles_example'; // string | CSV list of the role ids to check
$permissions = 'permissions_example'; // string | CSV list of the permissions to check

try {
    $apiInstance->advrolecheckperm($token, $roles, $permissions);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advrolecheckperm: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advroledelete

> advroledelete($token, $id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the location to delete.

try {
    $apiInstance->advroledelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advroledelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the location to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advroledeletemapping

> advroledeletemapping($token, $map, $roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$map = 'map_example'; // string | The map name to save the role.
$roleid = 'roleid_example'; // string | The id of the role.

try {
    $apiInstance->advroledeletemapping($token, $map, $roleid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advroledeletemapping: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **map** | **string**| The map name to save the role. |
 **roleid** | [**string**](../Model/.md)| The id of the role. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advroleget

> advroleget($token, $id)

View details of a role

Allows the user to view a role and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the location to get.

try {
    $apiInstance->advroleget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advroleget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the location to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advrolelist

> advrolelist($token, $includepolicies, $includeinternal, $name)

Lists the roles for the current account

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$includepolicies = True; // bool | True to include the policies, defaults to false.
$includeinternal = True; // bool | True to include the internal roles too.
$name = 'name_example'; // string | Filter by name of the role.

try {
    $apiInstance->advrolelist($token, $includepolicies, $includeinternal, $name);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advrolelist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **includepolicies** | **bool**| True to include the policies, defaults to false. | [optional]
 **includeinternal** | **bool**| True to include the internal roles too. | [optional]
 **name** | **string**| Filter by name of the role. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advrolelistmaps

> advrolelistmaps($token, $roleid)

Lists the maps a roles is mapped to

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$roleid = 'roleid_example'; // string | The id of the role to list the maps.

try {
    $apiInstance->advrolelistmaps($token, $roleid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advrolelistmaps: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **roleid** | [**string**](../Model/.md)| The id of the role to list the maps. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advrolelistrolesmapped

> advrolelistrolesmapped($token, $map)

Lists the roles mappings

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$map = 'map_example'; // string | List only the roles in the specified map.

try {
    $apiInstance->advrolelistrolesmapped($token, $map);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advrolelistrolesmapped: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advrolelisttemplates

> advrolelisttemplates($token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->advrolelisttemplates($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advrolelisttemplates: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advrolesave

> advrolesave($unknown_base_type)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->advrolesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advrolesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advrolesavemapping

> advrolesavemapping($unknown_base_type)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->advrolesavemapping($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advrolesavemapping: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advrolesuserlist

> advrolesuserlist($token, $from, $count, $roleid, $onlywithoutcard, $photosize)

List users. Alias to user.list, use that one instead.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$roleid = 'roleid_example'; // string | The id of the role to filter users by, or empty to return all users.
$onlywithoutcard = 'onlywithoutcard_example'; // string | If is 1 then only the users without a card are returned, otherwise all users are returned.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->advrolesuserlist($token, $from, $count, $roleid, $onlywithoutcard, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advrolesuserlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **roleid** | [**string**](../Model/.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## advroleuserupgrade

> advroleuserupgrade($token, $userid, $roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | Id of the user to upgrade
$roleid = 'roleid_example'; // string | Id of the role to add

try {
    $apiInstance->advroleuserupgrade($token, $userid, $roleid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->advroleuserupgrade: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| Id of the user to upgrade |
 **roleid** | [**string**](../Model/.md)| Id of the role to add |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentcancel

> appointmentcancel($token, $id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to cancel.

try {
    $apiInstance->appointmentcancel($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentcancel: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to cancel. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentcheckisvalid

> appointmentcheckisvalid($token, $id, $editing)

Check if an appointment is valid or not

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to check.
$editing = True; // bool | Specifies whether the check is for a new appointment or an existing one.

try {
    $apiInstance->appointmentcheckisvalid($token, $id, $editing);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentcheckisvalid: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to check. |
 **editing** | **bool**| Specifies whether the check is for a new appointment or an existing one. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmenteditanyway

> appointmenteditanyway($token, $id, $attendee, $staff, $location, $start, $end, $term, $event, $services, $notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to edit.
$attendee = 'attendee_example'; // string | The id of the attendee involved in the appointment.
$staff = 'staff_example'; // string | The id of the staff member involved in the appointment.
$location = 'location_example'; // string | The id of the location where the appointment will take place.
$start = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The appointment's start date & time.
$end = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The appointment's end date & time.
$term = 'term_example'; // string | The id of the term when the appointment takes place.
$event = 'event_example'; // string | The id of the event of the appointment.
$services = 'services_example'; // string | Comma-separated string containing the ids of the services of the appointment.
$notes = 'notes_example'; // string | The notes of the appointment.

try {
    $apiInstance->appointmenteditanyway($token, $id, $attendee, $staff, $location, $start, $end, $term, $event, $services, $notes);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmenteditanyway: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to edit. |
 **attendee** | [**string**](../Model/.md)| The id of the attendee involved in the appointment. |
 **staff** | [**string**](../Model/.md)| The id of the staff member involved in the appointment. |
 **location** | [**string**](../Model/.md)| The id of the location where the appointment will take place. |
 **start** | **\DateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **\DateTime**| The appointment&#39;s end date &amp; time. |
 **term** | [**string**](../Model/.md)| The id of the term when the appointment takes place. | [optional]
 **event** | [**string**](../Model/.md)| The id of the event of the appointment. | [optional]
 **services** | **string**| Comma-separated string containing the ids of the services of the appointment. | [optional]
 **notes** | **string**| The notes of the appointment. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmenteditpresence

> appointmenteditpresence($token, $id, $showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to edit its presence.
$showedup = True; // bool | Specifies whether the attendee was showed-up or not in the appointment.

try {
    $apiInstance->appointmenteditpresence($token, $id, $showedup);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmenteditpresence: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to edit its presence. |
 **showedup** | **bool**| Specifies whether the attendee was showed-up or not in the appointment. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentfindallstaffslots

> appointmentfindallstaffslots($token, $starttime, $endtime, $serviceids, $locationid, $eventid, $photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$serviceids = 'serviceids_example'; // string | CSV list of the service Ids to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->appointmentfindallstaffslots($token, $starttime, $endtime, $serviceids, $locationid, $eventid, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentfindallstaffslots: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **serviceids** | **string**| CSV list of the service Ids to filter by. |
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. |
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentfindslots

> appointmentfindslots($token, $staffid, $starttime, $endtime, $serviceids, $eventid, $locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$staffid = 'staffid_example'; // string | The id of the staff to filter by.
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$serviceids = 'serviceids_example'; // string | CSV list of the service Ids to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.

try {
    $apiInstance->appointmentfindslots($token, $staffid, $starttime, $endtime, $serviceids, $eventid, $locationid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentfindslots: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **staffid** | [**string**](../Model/.md)| The id of the staff to filter by. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **serviceids** | **string**| CSV list of the service Ids to filter by. |
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentfindstaff

> appointmentfindstaff($token, $serviceids, $starttime, $endtime, $eventid, $locationid, $photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceids = 'serviceids_example'; // string | CSV list of the service ids to filter by.
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->appointmentfindstaff($token, $serviceids, $starttime, $endtime, $eventid, $locationid, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentfindstaff: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceids** | **string**| CSV list of the service ids to filter by. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentget

> appointmentget($token, $id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to get.

try {
    $apiInstance->appointmentget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentgetcurrent

> appointmentgetcurrent($station, $user, $location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.
$location = 'location_example'; // string | The id of the location where the user wants to sign-in.

try {
    $apiInstance->appointmentgetcurrent($station, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentgetcurrent: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user. |
 **location** | [**string**](../Model/.md)| The id of the location where the user wants to sign-in. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentgetlocations

> appointmentgetlocations($token, $serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceid = 'serviceid_example'; // string | The id of the service to get its locations.

try {
    $apiInstance->appointmentgetlocations($token, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentgetlocations: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceid** | [**string**](../Model/.md)| The id of the service to get its locations. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentlist

> appointmentlist($token, $from, $count, $startdate, $enddate, $userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the appointments.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the appointments.
$userid = 'userid_example'; // string | The attendee id to filter the appointments.

try {
    $apiInstance->appointmentlist($token, $from, $count, $startdate, $enddate, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **startdate** | **\DateTime**| The start date of the period to filter the appointments. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the appointments. | [optional]
 **userid** | [**string**](../Model/.md)| The attendee id to filter the appointments. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentlistmine

> appointmentlistmine($token, $start, $modifiedafter)

View all my upcoming appointments

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$start = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only appointments that start after the specified date will be returned.
$modifiedafter = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only appointments modified after the specified date will be returned.

try {
    $apiInstance->appointmentlistmine($token, $start, $modifiedafter);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentlistmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **start** | **\DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **\DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentlistupcoming

> appointmentlistupcoming($token, $start, $modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$start = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only appointments that start after the specified date will be returned.
$modifiedafter = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only appointments modified after the specified date will be returned.

try {
    $apiInstance->appointmentlistupcoming($token, $start, $modifiedafter);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentlistupcoming: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **start** | **\DateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **\DateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentrescheduleoutlook

> appointmentrescheduleoutlook($token, $id, $start, $end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to edit.
$start = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The appointment's start date & time.
$end = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The appointment's end date & time.

try {
    $apiInstance->appointmentrescheduleoutlook($token, $id, $start, $end);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentrescheduleoutlook: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to edit. |
 **start** | **\DateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **\DateTime**| The appointment&#39;s end date &amp; time. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentrestore

> appointmentrestore($token, $id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to restore.

try {
    $apiInstance->appointmentrestore($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentrestore: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to restore. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentrestoreanyway

> appointmentrestoreanyway($token, $id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to restore.

try {
    $apiInstance->appointmentrestoreanyway($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentrestoreanyway: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to restore. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentsave

> appointmentsave($unknown_base_type)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->appointmentsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentsetasvalid

> appointmentsetasvalid($token, $id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to set as valid.

try {
    $apiInstance->appointmentsetasvalid($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentsetasvalid: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to set as valid. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentsuggestlocations

> appointmentsuggestlocations($token)

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->appointmentsuggestlocations($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentsuggestlocations: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentsuggestservices

> appointmentsuggestservices($token)

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->appointmentsuggestservices($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentsuggestservices: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appointmentvoid

> appointmentvoid($token, $id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the appointment to cancel.

try {
    $apiInstance->appointmentvoid($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appointmentvoid: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the appointment to cancel. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appsharegetphone

> appsharegetphone($token)

Gets the phone number of the current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->appsharegetphone($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appsharegetphone: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## appsharesendtext

> appsharesendtext($token, $phonenumber)

Sends an SMS with the link to the app

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$phonenumber = 'phonenumber_example'; // string | Phone number to where to send the link. Leave empty to the number on file.

try {
    $apiInstance->appsharesendtext($token, $phonenumber);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->appsharesendtext: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogcommentdelete

> attendancelogcommentdelete($token, $id)

Delete a comment on an attendance log

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the attendance log comment to delete.

try {
    $apiInstance->attendancelogcommentdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogcommentdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the attendance log comment to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogcommentget

> attendancelogcommentget($token, $id)

View a comment on an attendance log

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the comment to get.

try {
    $apiInstance->attendancelogcommentget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogcommentget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the comment to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogcommentlist

> attendancelogcommentlist($attendancelog, $token)

View all the comments on a specific attendance log

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$attendancelog = 'attendancelog_example'; // string | The id of the attendance log whose comments have to be retrieved.
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->attendancelogcommentlist($attendancelog, $token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogcommentlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**string**](../Model/.md)| The id of the attendance log whose comments have to be retrieved. |
 **token** | **string**| The authentication token. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogcommentsave

> attendancelogcommentsave($unknown_base_type)

Save a comment on an attendance log

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->attendancelogcommentsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogcommentsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogdelete

> attendancelogdelete($token, $id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the attendance log to delete.

try {
    $apiInstance->attendancelogdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the attendance log to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogget

> attendancelogget($token, $id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the attendance log to get.

try {
    $apiInstance->attendancelogget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the attendance log to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendanceloggetchangehistory

> attendanceloggetchangehistory($token, $id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the attendance log to get.

try {
    $apiInstance->attendanceloggetchangehistory($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendanceloggetchangehistory: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the attendance log to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendanceloglist

> attendanceloglist($from, $count, $token, $filter, $userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$token = 'token_example'; // string | The authentication token.
$filter = 'filter_example'; // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
$userid = 'userid_example'; // string | The user ID of the user to get the logs.

try {
    $apiInstance->attendanceloglist($from, $count, $token, $filter, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendanceloglist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **token** | **string**| The authentication token. | [optional]
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]
 **userid** | [**string**](../Model/.md)| The user ID of the user to get the logs. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendanceloglistmine

> attendanceloglistmine($from, $count, $token, $filter)

Gets the attendance logs of the current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$token = 'token_example'; // string | The authentication token.
$filter = 'filter_example'; // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.

try {
    $apiInstance->attendanceloglistmine($from, $count, $token, $filter);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendanceloglistmine: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogliststaff

> attendancelogliststaff($from, $count, $token, $filter)

Gets the attendance logs that the current user is involved in as staff

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$token = 'token_example'; // string | The authentication token.
$filter = 'filter_example'; // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.

try {
    $apiInstance->attendancelogliststaff($from, $count, $token, $filter);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogliststaff: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogsave

> attendancelogsave($unknown_base_type)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->attendancelogsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogsignout

> attendancelogsignout($token, $id, $location, $event, $datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the attendance log to sign-out.
$location = 'location_example'; // string | The id of the location to filter the users to sign out.
$event = 'event_example'; // string | The id of the event to filter the users to sign out.
$datetime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | Specifies the date and time when the specified logs have to be signed out.

try {
    $apiInstance->attendancelogsignout($token, $id, $location, $event, $datetime);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogsignout: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the attendance log to sign-out. | [optional]
 **location** | [**string**](../Model/.md)| The id of the location to filter the users to sign out. | [optional]
 **event** | [**string**](../Model/.md)| The id of the event to filter the users to sign out. | [optional]
 **datetime** | **\DateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancelogwhosin

> attendancelogwhosin($from, $count, $token, $location, $event, $sorting, $roles, $photosize, $extensions, $export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$token = 'token_example'; // string | The authentication token.
$location = 'location_example'; // string | The id of the location to search for users that are in.
$event = 'event_example'; // string | The id of the event to search for users that are in.
$sorting = 'sorting_example'; // string | Field to sort by. Either first-name, last-name or sign-in-time.
$roles = 'roles_example'; // string | The comma-separated list of ids of the roles to search for users that are in.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
$extensions = 'extensions_example'; // string | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
$export = True; // bool | True to export the results as CSV

try {
    $apiInstance->attendancelogwhosin($from, $count, $token, $location, $event, $sorting, $roles, $photosize, $extensions, $export);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancelogwhosin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **token** | **string**| The authentication token. | [optional]
 **location** | [**string**](../Model/.md)| The id of the location to search for users that are in. | [optional]
 **event** | [**string**](../Model/.md)| The id of the event to search for users that are in. | [optional]
 **sorting** | **string**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional]
 **roles** | **string**| The comma-separated list of ids of the roles to search for users that are in. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **extensions** | **string**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional]
 **export** | **bool**| True to export the results as CSV | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancerestrictiondelete

> attendancerestrictiondelete($token, $id)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the restriction to delete.

try {
    $apiInstance->attendancerestrictiondelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancerestrictiondelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the restriction to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancerestrictionget

> attendancerestrictionget($token, $id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the restriction to get.

try {
    $apiInstance->attendancerestrictionget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancerestrictionget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the restriction to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancerestrictionlist

> attendancerestrictionlist($token, $from, $count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->attendancerestrictionlist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancerestrictionlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## attendancerestrictionsave

> attendancerestrictionsave($unknown_base_type)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->attendancerestrictionsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->attendancerestrictionsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beacondelete

> beacondelete($token, $id)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the beacon to delete.

try {
    $apiInstance->beacondelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beacondelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the beacon to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beacondisable

> beacondisable($token)

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->beacondisable($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beacondisable: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconget

> beaconget($token, $id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the beacon to get.

try {
    $apiInstance->beaconget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the beacon to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beacongetlocations

> beacongetlocations($token, $beacons)

Get the sign-in stations assigned to specific beacons.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$beacons = 'beacons_example'; // string | A JSON array containg the beacons data (region, minor and major) values.

try {
    $apiInstance->beacongetlocations($token, $beacons);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beacongetlocations: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beacongetstationlocation

> beacongetstationlocation($token, $station, $location)

Get the location settings in the specified sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$station = 'station_example'; // string | The id of the sign-in station whose location information has to be retrieved.
$location = 'location_example'; // string | The id of the location whose information has to be retrieved.

try {
    $apiInstance->beacongetstationlocation($token, $station, $location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beacongetstationlocation: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **station** | [**string**](../Model/.md)| The id of the sign-in station whose location information has to be retrieved. |
 **location** | [**string**](../Model/.md)| The id of the location whose information has to be retrieved. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beacongetuuid

> beacongetuuid($token)

View the identifier for the account's beacon region (for sign-in stations).

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->beacongetuuid($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beacongetuuid: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconlist

> beaconlist($token, $from, $count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->beaconlist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconlistprofiles

> beaconlistprofiles($token)

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->beaconlistprofiles($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconlistprofiles: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconresetuuid

> beaconresetuuid($token)

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->beaconresetuuid($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconresetuuid: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconsave

> beaconsave($unknown_base_type)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->beaconsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconscanlocations

> beaconscanlocations($token, $beacons)

Check if there's location available to sign-in / out.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$beacons = 'beacons_example'; // string | A JSON array containg the beacons data (region, minor and major) values.

try {
    $apiInstance->beaconscanlocations($token, $beacons);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconscanlocations: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconsetuuid

> beaconsetuuid($token, $id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The custom region UUID.

try {
    $apiInstance->beaconsetuuid($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconsetuuid: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The custom region UUID. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconsilentregions

> beaconsilentregions($token)

View all the beacon regions defined for silent tracking

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->beaconsilentregions($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconsilentregions: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconsilentsignin

> beaconsilentsignin($token, $uuid)

Sign-in silently from the location specified by a beacon

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$uuid = 'uuid_example'; // string | The id of the region the user is in.

try {
    $apiInstance->beaconsilentsignin($token, $uuid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconsilentsignin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **uuid** | [**string**](../Model/.md)| The id of the region the user is in. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## beaconsilentsignout

> beaconsilentsignout($token, $uuid)

Sign-out silently from the location specified by a beacon

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$uuid = 'uuid_example'; // string | The id of the region the user has left.

try {
    $apiInstance->beaconsilentsignout($token, $uuid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->beaconsilentsignout: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **uuid** | [**string**](../Model/.md)| The id of the region the user has left. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## bgjobgetstatus

> bgjobgetstatus($token, $jobid, $jobtype)

Get background job status

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$jobid = 'jobid_example'; // string | The ID of the job to get the status. 10 most recent will be returned if not specified.
$jobtype = 'jobtype_example'; // string | The job type to filter by.

try {
    $apiInstance->bgjobgetstatus($token, $jobid, $jobtype);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->bgjobgetstatus: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **jobid** | [**string**](../Model/.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional]
 **jobtype** | **string**| The job type to filter by. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## captchagetchallenge

> captchagetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->captchagetchallenge();
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->captchagetchallenge: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## captchagetimage

> captchagetimage($captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$captchatoken = 'captchatoken_example'; // string | The captcha token or ID returned by the captcha.getchallenge action

try {
    $apiInstance->captchagetimage($captchatoken);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->captchagetimage: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## changelog

> changelog($token)

Get the application change log

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->changelog($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->changelog: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## clientget

> clientget($token, $client, $clientname)

Get client

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$client = 'client_example'; // string | The unique id of the client.
$clientname = 'clientname_example'; // string | The custom name of the client.

try {
    $apiInstance->clientget($token, $client, $clientname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->clientget: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## clientlist

> clientlist($token, $from, $count)

Gets the clients of the specified conference

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->clientlist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->clientlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## clientsave

> clientsave($unknown_base_type)

Saves a client

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->clientsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->clientsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## clientsendmessage

> clientsendmessage($token, $uniqueclientid, $message)

Send a message to a client

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$uniqueclientid = 'uniqueclientid_example'; // string | The unique id of the client.
$message = 'message_example'; // string | The body of the message to send.

try {
    $apiInstance->clientsendmessage($token, $uniqueclientid, $message);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->clientsendmessage: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **uniqueclientid** | [**string**](../Model/.md)| The unique id of the client. |
 **message** | **string**| The body of the message to send. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## communityinvite

> communityinvite($token)

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->communityinvite($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->communityinvite: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## communityjoin

> communityjoin($token)

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->communityjoin($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->communityjoin: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## compasscategorydelete

> compasscategorydelete($token, $id)

Delete a compass category

Allows the user to delete an existing compass category.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the category to delete.

try {
    $apiInstance->compasscategorydelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->compasscategorydelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the category to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## compasscategoryget

> compasscategoryget($token, $id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the category to get.

try {
    $apiInstance->compasscategoryget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->compasscategoryget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the category to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## compasscategorylist

> compasscategorylist($token, $from, $count, $onlywithservices)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$onlywithservices = True; // bool | Specified whether only categories with services are returned or all.

try {
    $apiInstance->compasscategorylist($token, $from, $count, $onlywithservices);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->compasscategorylist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. | [optional]
 **count** | **int**| The max number of records to return. | [optional]
 **onlywithservices** | **bool**| Specified whether only categories with services are returned or all. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## compasscategorysave

> compasscategorysave($unknown_base_type)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->compasscategorysave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->compasscategorysave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## compassservicelist

> compassservicelist($token, $category)

View all the services added to the compass

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$category = 'category_example'; // string | The id of the category to filter the services.

try {
    $apiInstance->compassservicelist($token, $category);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->compassservicelist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **category** | [**string**](../Model/.md)| The id of the category to filter the services. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## compassservicelistlocations

> compassservicelistlocations($token, $serviceid)

View all the locations where a service added to the compass is available

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceid = 'serviceid_example'; // string | The id of the service to get its locations.

try {
    $apiInstance->compassservicelistlocations($token, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->compassservicelistlocations: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceid** | [**string**](../Model/.md)| The id of the service to get its locations. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlabdeletecomputer

> computerlabdeletecomputer($token, $id)

Delete a computer

Allows the user to delete an existing computer.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The unique device id of the computer to delete.

try {
    $apiInstance->computerlabdeletecomputer($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlabdeletecomputer: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlabgetcomputer

> computerlabgetcomputer($token, $id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The unique device id of the computer to get.

try {
    $apiInstance->computerlabgetcomputer($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlabgetcomputer: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlabgetsettings

> computerlabgetsettings($id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = 'id_example'; // string | The id of the computer lab/location.

try {
    $apiInstance->computerlabgetsettings($id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlabgetsettings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the computer lab/location. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlabissignedin

> computerlabissignedin($station, $user)

Gets whether a user is signed-in or not.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->computerlabissignedin($station, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlabissignedin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlablistcomputers

> computerlablistcomputers($token, $from, $count, $location, $freeonly)

View a list of computers

Allows the user to view the list of all computers.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$location = 'location_example'; // string | The id of the location whose computers have to be returned.
$freeonly = True; // bool | If true, only free computers will be returned.

try {
    $apiInstance->computerlablistcomputers($token, $from, $count, $location, $freeonly);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlablistcomputers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **location** | [**string**](../Model/.md)| The id of the location whose computers have to be returned. | [optional]
 **freeonly** | **bool**| If true, only free computers will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlablistlabs

> computerlablistlabs($token)

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->computerlablistlabs($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlablistlabs: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlabliststations

> computerlabliststations($token)

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->computerlabliststations($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlabliststations: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlabsavecomputer

> computerlabsavecomputer($unknown_base_type)

Create or edit a computer

Allows the user to create or edit a computer.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->computerlabsavecomputer($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlabsavecomputer: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlabsavesettings

> computerlabsavesettings($unknown_base_type)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->computerlabsavesettings($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlabsavesettings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## computerlabsaveswipe

> computerlabsaveswipe($unknown_base_type)

Save a new swipe from a computer in a computer lab.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->computerlabsaveswipe($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->computerlabsaveswipe: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## deadendrecordingdelete

> deadendrecordingdelete($token, $hierarchykey)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$hierarchykey = 'hierarchykey_example'; // string | The hierarchy key of the record to delete.

try {
    $apiInstance->deadendrecordingdelete($token, $hierarchykey);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->deadendrecordingdelete: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## deadendrecordinglist

> deadendrecordinglist($token)

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->deadendrecordinglist($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->deadendrecordinglist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## deadendrecordinglistcomments

> deadendrecordinglistcomments($token, $hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$hierarchykey = 'hierarchykey_example'; // string | The hierarchy key of the record to get the feedback.

try {
    $apiInstance->deadendrecordinglistcomments($token, $hierarchykey);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->deadendrecordinglistcomments: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## deadendrecordingsave

> deadendrecordingsave($unknown_base_type)

Saves a dead-end record

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->deadendrecordingsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->deadendrecordingsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## departmentdelete

> departmentdelete($token, $id)

Delete a college department

Allows the user to delete an existing college department.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the department to delete.

try {
    $apiInstance->departmentdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->departmentdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the department to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## departmentget

> departmentget($token, $id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the department to get.

try {
    $apiInstance->departmentget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->departmentget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the department to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## departmentlist

> departmentlist($token, $from, $count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->departmentlist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->departmentlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## departmentsave

> departmentsave($unknown_base_type)

Create or edit a college department

Allows the user to create or edit a college department.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->departmentsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->departmentsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## doc

> doc($excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$excludeanonymous = True; // bool | If true it excludes the anonymous actions from the returned list.

try {
    $apiInstance->doc($excludeanonymous);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->doc: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **bool**| If true it excludes the anonymous actions from the returned list. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## easyloginaddbgimage

> easyloginaddbgimage($token, $upload, $filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$upload = 'upload_example'; // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
$filename = 'filename_example'; // string | The original filename, needed to process the file.

try {
    $apiInstance->easyloginaddbgimage($token, $upload, $filename);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->easyloginaddbgimage: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventchecksessions

> eventchecksessions($token, $eventid, $autorepair)

Edit an event's sessions according to their schedule

Allows the user to edit event sessions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The id of the event to check.
$autorepair = True; // bool | True to automatically fix the invalid sessions.

try {
    $apiInstance->eventchecksessions($token, $eventid, $autorepair);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventchecksessions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The id of the event to check. |
 **autorepair** | **bool**| True to automatically fix the invalid sessions. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventdelete

> eventdelete($token, $id)

Delete a course

Allows the user to delete an existing course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the event to delete.

try {
    $apiInstance->eventdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the event to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventget

> eventget($token, $id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the event to get.

try {
    $apiInstance->eventget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the event to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventgetsessionsbydate

> eventgetsessionsbydate($token, $location, $date, $type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$location = 'location_example'; // string | The location to filter the events.
$date = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date to filter the events. Today will be used if this parameter is omitted.
$type = 'type_example'; // string | Type of event to list.

try {
    $apiInstance->eventgetsessionsbydate($token, $location, $date, $type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventgetsessionsbydate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **location** | [**string**](../Model/.md)| The location to filter the events. | [optional]
 **date** | **\DateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional]
 **type** | **string**| Type of event to list. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventlist

> eventlist($token, $from, $count, $summaryonly, $termid)

View a list of courses

Allows the user to view the full list of courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 'from_example'; // string | The first record to return.
$count = 'count_example'; // string | The max number of records to return.
$summaryonly = True; // bool | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
$termid = 'termid_example'; // string | Id of the term to list the events. Null to list all events.

try {
    $apiInstance->eventlist($token, $from, $count, $summaryonly, $termid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **string**| The first record to return. |
 **count** | **string**| The max number of records to return. |
 **summaryonly** | **bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**string**](../Model/.md)| Id of the term to list the events. Null to list all events. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventlistregistered

> eventlistregistered($token, $from, $count, $summaryonly, $termid)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 'from_example'; // string | The first record to return.
$count = 'count_example'; // string | The max number of records to return.
$summaryonly = True; // bool | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
$termid = 'termid_example'; // string | Id of the term to list the events. Null to list all events.

try {
    $apiInstance->eventlistregistered($token, $from, $count, $summaryonly, $termid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventlistregistered: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **string**| The first record to return. |
 **count** | **string**| The max number of records to return. |
 **summaryonly** | **bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**string**](../Model/.md)| Id of the term to list the events. Null to list all events. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregaddme

> eventregaddme($token, $eventid, $listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The id of the event.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregaddme($token, $eventid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregaddme: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **listname** | **string**| The name of the list where the user has to be registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregaddmetoall

> eventregaddmetoall($token, $listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregaddmetoall($token, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregaddmetoall: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregaddmetogroup

> eventregaddmetogroup($token, $codegroup, $listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$codegroup = 'codegroup_example'; // string | The code used to group events.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregaddmetogroup($token, $codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregaddmetogroup: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregadduser

> eventregadduser($token, $userid, $eventid, $listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to add.
$eventid = 'eventid_example'; // string | The id of the event.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregadduser($token, $userid, $eventid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregadduser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **listname** | **string**| The name of the list where the user has to be registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregaddusertoall

> eventregaddusertoall($token, $userid, $listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to add.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregaddusertoall($token, $userid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregaddusertoall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **listname** | **string**| The name of the list where the user has to be registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregaddusertogroup

> eventregaddusertogroup($token, $userid, $codegroup, $listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to add.
$codegroup = 'codegroup_example'; // string | The code used to group events.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregaddusertogroup($token, $userid, $codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregaddusertogroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **codegroup** | **string**| The code used to group events. |
 **listname** | **string**| The name of the list where the user has to be registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventreggetevents

> eventreggetevents($token, $userid, $listname, $termid, $namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The user id to list events.
$listname = 'listname_example'; // string | The name of the list where the user is registered.
$termid = 'termid_example'; // string | The term id to list events.
$namefilter = 'namefilter_example'; // string | The value used to filter the events by name.

try {
    $apiInstance->eventreggetevents($token, $userid, $listname, $termid, $namefilter);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventreggetevents: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The user id to list events. |
 **listname** | **string**| The name of the list where the user is registered. |
 **termid** | [**string**](../Model/.md)| The term id to list events. | [optional]
 **namefilter** | **string**| The value used to filter the events by name. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventreggetgroups

> eventreggetgroups($token, $userid, $listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The user id to list events.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventreggetgroups($token, $userid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventreggetgroups: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The user id to list events. |
 **listname** | **string**| The name of the list where the user is registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventreggetmyevents

> eventreggetmyevents($token, $listname, $termid, $namefilter)

View the event registrations of the current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$listname = 'listname_example'; // string | The name of the list where the user is registered.
$termid = 'termid_example'; // string | The term id to list events.
$namefilter = 'namefilter_example'; // string | The value used to filter the events by name.

try {
    $apiInstance->eventreggetmyevents($token, $listname, $termid, $namefilter);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventreggetmyevents: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **listname** | **string**| The name of the list where the user is registered. |
 **termid** | [**string**](../Model/.md)| The term id to list events. | [optional]
 **namefilter** | **string**| The value used to filter the events by name. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventreggetmygroups

> eventreggetmygroups($token, $listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventreggetmygroups($token, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventreggetmygroups: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventreggetusers

> eventreggetusers($token, $eventid, $listname, $photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The event id to list users.
$listname = 'listname_example'; // string | The name of the list to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->eventreggetusers($token, $eventid, $listname, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventreggetusers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The event id to list users. |
 **listname** | **string**| The name of the list to get. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventreggetusersfromgroup

> eventreggetusersfromgroup($token, $codegroup, $listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$codegroup = 'codegroup_example'; // string | The code group to list users.
$listname = 'listname_example'; // string | The name of the list to get.

try {
    $apiInstance->eventreggetusersfromgroup($token, $codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventreggetusersfromgroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **codegroup** | [**string**](../Model/.md)| The code group to list users. |
 **listname** | **string**| The name of the list to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventreggetuserstoall

> eventreggetuserstoall($token, $listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$listname = 'listname_example'; // string | The name of the list to get.

try {
    $apiInstance->eventreggetuserstoall($token, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventreggetuserstoall: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregremoveme

> eventregremoveme($token, $eventid, $listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The id of the event.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregremoveme($token, $eventid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregremoveme: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **listname** | **string**| The name of the list where the user is registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregremovemefromall

> eventregremovemefromall($token, $listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregremovemefromall($token, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregremovemefromall: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregremovemefromgroup

> eventregremovemefromgroup($token, $codegroup, $listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$codegroup = 'codegroup_example'; // string | The code group of the events/courses.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregremovemefromgroup($token, $codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregremovemefromgroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **codegroup** | [**string**](../Model/.md)| The code group of the events/courses. |
 **listname** | **string**| The name of the list where the user is registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregremoveuser

> eventregremoveuser($token, $userid, $eventid, $listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to remove.
$eventid = 'eventid_example'; // string | The id of the event.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregremoveuser($token, $userid, $eventid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregremoveuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **listname** | **string**| The name of the list where the user is registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregremoveuserfromall

> eventregremoveuserfromall($token, $userid, $listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to remove.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregremoveuserfromall($token, $userid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregremoveuserfromall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **listname** | **string**| The name of the list where the user is registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventregremoveuserfromgroup

> eventregremoveuserfromgroup($token, $userid, $codegroup, $listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to remove.
$codegroup = 'codegroup_example'; // string | The code group of the events/courses.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregremoveuserfromgroup($token, $userid, $codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventregremoveuserfromgroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **codegroup** | [**string**](../Model/.md)| The code group of the events/courses. |
 **listname** | **string**| The name of the list where the user is registered. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventsave

> eventsave($unknown_base_type)

Create or edit a course

Allows the user to create or edit a course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->eventsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## eventsearchgroup

> eventsearchgroup($token, $query)

Searches for the available event groups

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$query = 'query_example'; // string | Query to search event groups.

try {
    $apiInstance->eventsearchgroup($token, $query);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->eventsearchgroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **query** | [**string**](../Model/.md)| Query to search event groups. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## export

> export($token, $exporttype, $exportformat, $filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$exporttype = 'exporttype_example'; // string | What to export.
$exportformat = 'exportformat_example'; // string | The format of the resulting file. Valid types are CSV, HTML, XLS.
$filters = 'filters_example'; // string | Pipe separated filters for the export, eg: aaa=val|bbb=val|...

try {
    $apiInstance->export($token, $exporttype, $exportformat, $filters);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->export: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## exportlisttypes

> exportlisttypes($token)

Lists available export types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->exportlisttypes($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->exportlisttypes: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## featurelist

> featurelist($token)

Lists the available features.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->featurelist($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->featurelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## holidaylist

> holidaylist($token, $term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$term = 'term_example'; // string | The term to get holidays from.

try {
    $apiInstance->holidaylist($token, $term);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->holidaylist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **term** | [**string**](../Model/.md)| The term to get holidays from. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## holidaysave

> holidaysave($unknown_base_type)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->holidaysave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->holidaysave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## holidaysuggest

> holidaysuggest($token, $term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$term = 'term_example'; // string | The term to get holidays from.

try {
    $apiInstance->holidaysuggest($token, $term);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->holidaysuggest: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **term** | [**string**](../Model/.md)| The term to get holidays from. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## import

> import($token, $importtype, $upload, $filename, $parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$importtype = 'importtype_example'; // string | The kind of data that is being uploaded.
$upload = 'upload_example'; // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
$filename = 'filename_example'; // string | The local name of the uploaded file. For later reference.
$parameters = 'parameters_example'; // string | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.

try {
    $apiInstance->import($token, $importtype, $upload, $filename, $parameters);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->import: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## importlisttypes

> importlisttypes($token)

Lists available import types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->importlisttypes($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->importlisttypes: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## interactiondelete

> interactiondelete($token, $id)

Delete an interaction

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the interaction to delete.

try {
    $apiInstance->interactiondelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->interactiondelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the interaction to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## interactionfeed

> interactionfeed($token, $from, $count, $startdate, $public, $contexttype, $contextid, $types, $photosize, $showdefaultphoto, $orderdescending)

Get the interactions feed

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If set, only interactions that happened after this date are returned.
$public = True; // bool | Specifies whether to return public or private interactions.
$contexttype = 'contexttype_example'; // string | The type of the context of the interactions to return.
$contextid = 'contextid_example'; // string | The id of the context of the interactions to return.
$types = 'types_example'; // string | The  comma separated types of the interactions to return.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
$showdefaultphoto = True; // bool | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
$orderdescending = True; // bool | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.

try {
    $apiInstance->interactionfeed($token, $from, $count, $startdate, $public, $contexttype, $contextid, $types, $photosize, $showdefaultphoto, $orderdescending);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->interactionfeed: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **startdate** | **\DateTime**| If set, only interactions that happened after this date are returned. | [optional]
 **public** | **bool**| Specifies whether to return public or private interactions. | [optional]
 **contexttype** | **string**| The type of the context of the interactions to return. | [optional]
 **contextid** | [**string**](../Model/.md)| The id of the context of the interactions to return. | [optional]
 **types** | **string**| The  comma separated types of the interactions to return. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]
 **orderdescending** | **bool**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## interactionget

> interactionget($token, $id, $thumbnailmediasize, $photosize)

View an interaction

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the interaction.
$thumbnailmediasize = 56; // int | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->interactionget($token, $id, $thumbnailmediasize, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->interactionget: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## interactionlistprivatesummary

> interactionlistprivatesummary($token, $photosize, $showdefaultphoto)

Get current user's latest private interactions

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
$showdefaultphoto = True; // bool | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.

try {
    $apiInstance->interactionlistprivatesummary($token, $photosize, $showdefaultphoto);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->interactionlistprivatesummary: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## interactionsave

> interactionsave($unknown_base_type)

Save an interaction

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->interactionsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->interactionsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## licenseacceptagreement

> licenseacceptagreement($token)

Accept the license agreement

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->licenseacceptagreement($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->licenseacceptagreement: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## licensegetagreementstatus

> licensegetagreementstatus($token)

Check if license agreement has been accepted

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->licensegetagreementstatus($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->licensegetagreementstatus: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## licensegetcurrent

> licensegetcurrent($token)

Gets the current license information

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->licensegetcurrent($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->licensegetcurrent: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## licenserenew

> licenserenew($token, $email, $phonenumber, $jobtitle, $institution, $comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$email = 'email_example'; // string | The e-mail of the user sending the request.
$phonenumber = 'phonenumber_example'; // string | The phone number of the user sending the request.
$jobtitle = 'jobtitle_example'; // string | The job title of the user sending the request.
$institution = 'institution_example'; // string | The institution of the user sending the request.
$comments = 'comments_example'; // string | Comments entered by the user sending the request.

try {
    $apiInstance->licenserenew($token, $email, $phonenumber, $jobtitle, $institution, $comments);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->licenserenew: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## likedelete

> likedelete($token, $interactionid)

Delete a like

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$interactionid = 'interactionid_example'; // string | The id of the interaction to unlike.

try {
    $apiInstance->likedelete($token, $interactionid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->likedelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **interactionid** | [**string**](../Model/.md)| The id of the interaction to unlike. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## likelist

> likelist($token, $interactionid, $photosize)

View all the likes associated to a target

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$interactionid = 'interactionid_example'; // string | The id of the interaction to unlike.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->likelist($token, $interactionid, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->likelist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **interactionid** | [**string**](../Model/.md)| The id of the interaction to unlike. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## likesave

> likesave($unknown_base_type)

Save a like

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->likesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->likesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## listtimezones

> listtimezones()

Lists the available timezones

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->listtimezones();
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->listtimezones: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## locationdelete

> locationdelete($token, $id)

Delete a location

Allows the user to delete an existing location.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the location to delete.

try {
    $apiInstance->locationdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->locationdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the location to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## locationget

> locationget($token, $id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the location to get.

try {
    $apiInstance->locationget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->locationget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the location to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## locationlist

> locationlist($token, $from, $count, $locations, $sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$locations = 'locations_example'; // string | The comma-separated list containing the ids of the locations to list.
$sortbygroup = True; // bool | True to list locations sorted by the 'Located In' property. Defaults to false.

try {
    $apiInstance->locationlist($token, $from, $count, $locations, $sortbygroup);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->locationlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **locations** | **string**| The comma-separated list containing the ids of the locations to list. | [optional]
 **sortbygroup** | **bool**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## locationsave

> locationsave($unknown_base_type)

Create or edit a location

Allows the user to create or edit a location.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->locationsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->locationsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## login

> login($domain, $username, $password, $method, $rememberme)

Login

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$domain = 'domain_example'; // string | The account domain to login.
$username = 'username_example'; // string | The username (email) of the user to login as.
$password = 'password_example'; // string | The password of the user to login as.
$method = 'method_example'; // string | The authentication method. Valid values are 'token' and 'cookie'.
$rememberme = True; // bool | If true then the session will not expire.

try {
    $apiInstance->login($domain, $username, $password, $method, $rememberme);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->login: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The account domain to login. |
 **username** | **string**| The username (email) of the user to login as. |
 **password** | **string**| The password of the user to login as. |
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. |
 **rememberme** | **bool**| If true then the session will not expire. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## logout

> logout($token)

Logout

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token used to login.

try {
    $apiInstance->logout($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->logout: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediacheckin

> mediacheckin($token, $media, $checkindate, $notes)

Check in media item

Allows the user to check in a media item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$media = 'media_example'; // string | The id of the media item to checkin.
$checkindate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The checkout date.
$notes = 'notes_example'; // string | The notes of the checkout.

try {
    $apiInstance->mediacheckin($token, $media, $checkindate, $notes);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediacheckin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **media** | [**string**](../Model/.md)| The id of the media item to checkin. |
 **checkindate** | **\DateTime**| The checkout date. |
 **notes** | **string**| The notes of the checkout. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediacheckout

> mediacheckout($token, $media, $user, $checkoutdate, $duedate, $staff, $event, $notes)

Check out media item

Allows the user to check out a media item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$media = 'media_example'; // string | The id of the media item to checkout.
$user = 'user_example'; // string | The id of the user that is checking the item out.
$checkoutdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The checkout date.
$duedate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date when the checkout is due.
$staff = 'staff_example'; // string | The id of the staff member related to the checkout.
$event = 'event_example'; // string | The id of the event related to the checkout.
$notes = 'notes_example'; // string | The notes of the checkout.

try {
    $apiInstance->mediacheckout($token, $media, $user, $checkoutdate, $duedate, $staff, $event, $notes);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediacheckout: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **media** | [**string**](../Model/.md)| The id of the media item to checkout. |
 **user** | [**string**](../Model/.md)| The id of the user that is checking the item out. |
 **checkoutdate** | **\DateTime**| The checkout date. |
 **duedate** | **\DateTime**| The date when the checkout is due. |
 **staff** | [**string**](../Model/.md)| The id of the staff member related to the checkout. | [optional]
 **event** | [**string**](../Model/.md)| The id of the event related to the checkout. | [optional]
 **notes** | **string**| The notes of the checkout. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediacheckoutlist

> mediacheckoutlist($token, $from, $count, $media, $user, $photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$media = 'media_example'; // string | Used to filter the checkouts of a specific media item.
$user = 'user_example'; // string | Used to filter the checkouts made by a specific user.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->mediacheckoutlist($token, $from, $count, $media, $user, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediacheckoutlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **media** | [**string**](../Model/.md)| Used to filter the checkouts of a specific media item. | [optional]
 **user** | [**string**](../Model/.md)| Used to filter the checkouts made by a specific user. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediadelete

> mediadelete($token, $id)

Delete a media item

Allows the user to delete an existing media item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the media item to delete.

try {
    $apiInstance->mediadelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediadelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the media item to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediadeletecheckoutlog

> mediadeletecheckoutlog($token, $id)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the checkout log to delete.

try {
    $apiInstance->mediadeletecheckoutlog($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediadeletecheckoutlog: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the checkout log to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediaget

> mediaget($token, $id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the media item to get.

try {
    $apiInstance->mediaget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediaget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the media item to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediagetbycode

> mediagetbycode($token, $code, $location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$code = 'code_example'; // string | The code of the media item to get.
$location = 'location_example'; // string | The location where to look for the media item.

try {
    $apiInstance->mediagetbycode($token, $code, $location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediagetbycode: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **code** | **string**| The code of the media item to get. |
 **location** | [**string**](../Model/.md)| The location where to look for the media item. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediagetcheckout

> mediagetcheckout($token, $id, $photosize)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the media item whose checkout information has to be retrieved.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->mediagetcheckout($token, $id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediagetcheckout: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the media item whose checkout information has to be retrieved. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediagetcheckoutlog

> mediagetcheckoutlog($token, $id, $photosize)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the media item whose checkout information has to be retrieved.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->mediagetcheckoutlog($token, $id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediagetcheckoutlog: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the media item whose checkout information has to be retrieved. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## medialist

> medialist($token, $from, $count, $status, $user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$status = 56; // int | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
$user = 'user_example'; // string | Used to filter the media items that are checked-out by a specific user.

try {
    $apiInstance->medialist($token, $from, $count, $status, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->medialist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **status** | **int**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional]
 **user** | [**string**](../Model/.md)| Used to filter the media items that are checked-out by a specific user. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediasave

> mediasave($unknown_base_type)

Create or edit a media item

Allows the user to create or edit a media item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->mediasave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediasave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediatypedelete

> mediatypedelete($token, $id)

Delete a media type

Allows the user to delete an existing media type.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the media type to delete.

try {
    $apiInstance->mediatypedelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediatypedelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the media type to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediatypeget

> mediatypeget($token, $id)

Search and view details of a media type

Allows the user to view a media type and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the media type to get.

try {
    $apiInstance->mediatypeget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediatypeget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the media type to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediatypelist

> mediatypelist($token, $from, $count)

View a list of media types

Allows the user to view the list of all media types.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->mediatypelist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediatypelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mediatypesave

> mediatypesave($unknown_base_type)

Create or edit a media type

Allows the user to create or edit a media type.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->mediatypesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mediatypesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## memorizedreportdelete

> memorizedreportdelete($token, $id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the report settings to delete.

try {
    $apiInstance->memorizedreportdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->memorizedreportdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the report settings to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## memorizedreportget

> memorizedreportget($token, $id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the report configuration to get.

try {
    $apiInstance->memorizedreportget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->memorizedreportget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the report configuration to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## memorizedreportlist

> memorizedreportlist($token, $from, $count, $customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$customname = 'customname_example'; // string | If specified filters the memorized reports by custom name.

try {
    $apiInstance->memorizedreportlist($token, $from, $count, $customname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->memorizedreportlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## memorizedreportsave

> memorizedreportsave($unknown_base_type)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->memorizedreportsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->memorizedreportsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## menugetitems

> menugetitems($menuid)

Gets the items on the menu

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$menuid = 'menuid_example'; // string | The Id of the menu to get.

try {
    $apiInstance->menugetitems($menuid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->menugetitems: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## myaccount

> myaccount($token)

Gets the logged in user account.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->myaccount($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->myaccount: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## myianatimezone

> myianatimezone($token)

Gets the current time zone's iana name

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->myianatimezone($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->myianatimezone: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## myprofile

> myprofile($token, $photosize)

Gets the logged in user information.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->myprofile($token, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->myprofile: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## myrights

> myrights($token)

Gets the list of actions the user can execute.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->myrights($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->myrights: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## mysaveprofile

> mysaveprofile($unknown_base_type)

Updates logged user's profile information

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->mysaveprofile($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->mysaveprofile: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationdelete

> notificationdelete($token, $id)

Delete a notification

Allows the user to delete an existing notification.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the notification to delete.

try {
    $apiInstance->notificationdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the notification to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationget

> notificationget($token, $id)

View a notification

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the notification to get.

try {
    $apiInstance->notificationget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the notification to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationgetforstation

> notificationgetforstation($station, $user)

Gets all public (in station) notifications for the specific user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station to get.
$user = 'user_example'; // string | The card of the user.

try {
    $apiInstance->notificationgetforstation($station, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationgetforstation: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **user** | **string**| The card of the user. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationgetunreadcount

> notificationgetunreadcount($token)

Get the number of unread notifications

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->notificationgetunreadcount($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationgetunreadcount: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationlist

> notificationlist($token, $from, $count, $recipient, $status, $startdate, $enddate, $sentonscreen, $sentemail, $sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$recipient = 'recipient_example'; // string | The recipient whose notifications have to be listed.
$status = 56; // int | The status of the notifications to list. Read, Unread or All.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the notifications.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the notifications.
$sentonscreen = True; // bool | Specifies whether to list the notifications that were sent on-screen or not.
$sentemail = True; // bool | Specifies whether to list the notifications that were sent via e-mail or not.
$sentsms = True; // bool | Specifies whether to list the notifications that were sent via sms or not.

try {
    $apiInstance->notificationlist($token, $from, $count, $recipient, $status, $startdate, $enddate, $sentonscreen, $sentemail, $sentsms);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **recipient** | [**string**](../Model/.md)| The recipient whose notifications have to be listed. | [optional]
 **status** | **int**| The status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the notifications. | [optional]
 **sentonscreen** | **bool**| Specifies whether to list the notifications that were sent on-screen or not. | [optional]
 **sentemail** | **bool**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional]
 **sentsms** | **bool**| Specifies whether to list the notifications that were sent via sms or not. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationlistmine

> notificationlistmine($token, $from, $count, $status, $startdate, $enddate)

View all the notifications sent to the current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$status = 56; // int | Specifies the status of the notifications to list. Read, Unread or All.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the notifications.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the notifications.

try {
    $apiInstance->notificationlistmine($token, $from, $count, $status, $startdate, $enddate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationlistmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **status** | **int**| Specifies the status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationmarkasread

> notificationmarkasread($token, $id, $status, $startdate, $enddate)

Mark a notification as read

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
$status = 56; // int | Specifies the status to filter the notifications. Read, Unread or All.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the notifications.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the notifications.

try {
    $apiInstance->notificationmarkasread($token, $id, $status, $startdate, $enddate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationmarkasread: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional]
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationmarkasunread

> notificationmarkasunread($token, $id, $status, $startdate, $enddate)

Mark a notification as unread

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
$status = 56; // int | Specifies the status to filter the notifications. Read, Unread or All.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the notifications.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the notifications.

try {
    $apiInstance->notificationmarkasunread($token, $id, $status, $startdate, $enddate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationmarkasunread: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional]
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationsend

> notificationsend($token, $emailenabled, $onscreenenabled, $smsenabled, $title, $tousers, $togroups, $onscreenbody, $onscreenclick, $onscreenurl, $onscreenclass, $onscreenduration, $showonstation, $emailfromname, $emailfrom, $emailsubject, $emailbody, $textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$emailenabled = True; // bool | Whether send the notification via email.
$onscreenenabled = True; // bool | Whether to display the notification on screen.
$smsenabled = True; // bool | Whether to send the notification via text message.
$title = 'title_example'; // string | Notification title.
$tousers = 'tousers_example'; // string | Comma-separated Ids of users to send the notification.
$togroups = 'togroups_example'; // string | Comma-separated Ids of user groups to send the notification.
$onscreenbody = 'onscreenbody_example'; // string | Body of the message for on-screen display.
$onscreenclick = 'onscreenclick_example'; // string | What to do when the notification is clicked. Valid values: hide, view, url.
$onscreenurl = 'onscreenurl_example'; // string | Url to redirect the user, if onscreenclick=url.
$onscreenclass = 'onscreenclass_example'; // string | How to display the notification. Valid values: info, success, warning, error
$onscreenduration = 56; // int | Time in seconds to display the notification.
$showonstation = 56; // int | Whether to show the notification in the sign-in station.
$emailfromname = 'emailfromname_example'; // string | Name of the email sender.
$emailfrom = 'emailfrom_example'; // string | Reply-to email.
$emailsubject = 'emailsubject_example'; // string | Subject of the email.
$emailbody = 'emailbody_example'; // string | Body of the email.
$textmessagebody = 'textmessagebody_example'; // string | Message for SMS. Max 160 characters.

try {
    $apiInstance->notificationsend($token, $emailenabled, $onscreenenabled, $smsenabled, $title, $tousers, $togroups, $onscreenbody, $onscreenclick, $onscreenurl, $onscreenclass, $onscreenduration, $showonstation, $emailfromname, $emailfrom, $emailsubject, $emailbody, $textmessagebody);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationsend: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **emailenabled** | **bool**| Whether send the notification via email. |
 **onscreenenabled** | **bool**| Whether to display the notification on screen. |
 **smsenabled** | **bool**| Whether to send the notification via text message. |
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationsendonscreen

> notificationsendonscreen($token, $notification)

Send on-screen notifications

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$notification = 'notification_example'; // string | The ID of the notification to send.

try {
    $apiInstance->notificationsendonscreen($token, $notification);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationsendonscreen: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **notification** | [**string**](../Model/.md)| The ID of the notification to send. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationtopicdelete

> notificationtopicdelete($token, $id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the notification topic to delete.

try {
    $apiInstance->notificationtopicdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationtopicdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the notification topic to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationtopicget

> notificationtopicget($token, $id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the notification topic to get.

try {
    $apiInstance->notificationtopicget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationtopicget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the notification topic to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationtopiclist

> notificationtopiclist($token, $from, $count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->notificationtopiclist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationtopiclist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationtopiclistsubscribe

> notificationtopiclistsubscribe($token)

List all the notification topics available to subscribe

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->notificationtopiclistsubscribe($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationtopiclistsubscribe: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## notificationtopicsave

> notificationtopicsave($unknown_base_type)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->notificationtopicsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->notificationtopicsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## pushderegister

> pushderegister($devicetoken, $platform)

Deregisters the current device to receive push notifications

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$devicetoken = 'devicetoken_example'; // string | The device token where to send the notification.
$platform = 'platform_example'; // string | Either ios or android

try {
    $apiInstance->pushderegister($devicetoken, $platform);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->pushderegister: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## pushregister

> pushregister($devicetoken, $platform)

Registers the current device to receive push notifications

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$devicetoken = 'devicetoken_example'; // string | The device token where to send the notification.
$platform = 'platform_example'; // string | Either ios or android

try {
    $apiInstance->pushregister($devicetoken, $platform);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->pushregister: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## qrlabelsprint

> qrlabelsprint($token, $user, $group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$user = 'user_example'; // string | The id of the user whose label needs to be printed.
$group = 'group_example'; // string | The id of the group whose members' labels need to be printed.

try {
    $apiInstance->qrlabelsprint($token, $user, $group);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->qrlabelsprint: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **user** | [**string**](../Model/.md)| The id of the user whose label needs to be printed. | [optional]
 **group** | [**string**](../Model/.md)| The id of the group whose members&#39; labels need to be printed. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## qrloginget

> qrloginget($token)

Gets an image of a QR token

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->qrloginget($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->qrloginget: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## qrloginlogin

> qrloginlogin($onetimetoken)

Login

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$onetimetoken = 'onetimetoken_example'; // string | The token read from the QR code.

try {
    $apiInstance->qrloginlogin($onetimetoken);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->qrloginlogin: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## quickpaneldeletewidget

> quickpaneldeletewidget($token, $id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the widget.

try {
    $apiInstance->quickpaneldeletewidget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->quickpaneldeletewidget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the widget. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## quickpanelfetchwidget

> quickpanelfetchwidget($token, $widgetid)

Fetches the information for a specific widget.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$widgetid = 'widgetid_example'; // string | The ID of the data to fetch it's data.

try {
    $apiInstance->quickpanelfetchwidget($token, $widgetid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->quickpanelfetchwidget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **widgetid** | [**string**](../Model/.md)| The ID of the data to fetch it&#39;s data. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## quickpanelgetwidget

> quickpanelgetwidget($token, $id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the widget to get.

try {
    $apiInstance->quickpanelgetwidget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->quickpanelgetwidget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the widget to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## quickpanelinit

> quickpanelinit($token)

Returns the initial information required to show the quick panels

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->quickpanelinit($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->quickpanelinit: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## quickpanellistwidgets

> quickpanellistwidgets($token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->quickpanellistwidgets($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->quickpanellistwidgets: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## quickpanellistwidgettypes

> quickpanellistwidgettypes($token)

Lists all the widget types available in the system

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->quickpanellistwidgettypes($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->quickpanellistwidgettypes: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## quickpanelreorderwidgets

> quickpanelreorderwidgets($token, $sectionname, $orderids)

Reorders the widgets and moves them to a specific column

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$sectionname = 'sectionname_example'; // string | The section name where to sort the widgets.
$orderids = 'orderids_example'; // string | CSV list of the widgets to reorder.

try {
    $apiInstance->quickpanelreorderwidgets($token, $sectionname, $orderids);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->quickpanelreorderwidgets: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## quickpanelsavewidget

> quickpanelsavewidget($unknown_base_type)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->quickpanelsavewidget($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->quickpanelsavewidget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingflag

> ratingflag($token, $id, $comment)

Flags one rating for moderation

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The rating to flag.
$comment = 'comment_example'; // string | Comment why should this should be removed.

try {
    $apiInstance->ratingflag($token, $id, $comment);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratingflag: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The rating to flag. |
 **comment** | **string**| Comment why should this should be removed. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingflagcomment

> ratingflagcomment($token, $id, $comment)

Flags one comment for moderation

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The comment to flag.
$comment = 'comment_example'; // string | Comment why should this should be removed.

try {
    $apiInstance->ratingflagcomment($token, $id, $comment);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratingflagcomment: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The comment to flag. |
 **comment** | **string**| Comment why should this should be removed. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingget

> ratingget($token, $type, $entityids)

Get rating for one or more entities

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$type = 'type_example'; // string | The entity type to get the rating.
$entityids = 'entityids_example'; // string | List of ids to get the ratings.

try {
    $apiInstance->ratingget($token, $type, $entityids);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratingget: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratinggetall

> ratinggetall($token, $type, $entityid, $mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$type = 'type_example'; // string | The entity type to get the rating.
$entityid = 'entityid_example'; // string | Id of the entity to get the ratings.
$mostrecentfirst = True; // bool | True to show most recent first, otherwise most helpful first.

try {
    $apiInstance->ratinggetall($token, $type, $entityid, $mostrecentfirst);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratinggetall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **type** | **string**| The entity type to get the rating. |
 **entityid** | **string**| Id of the entity to get the ratings. |
 **mostrecentfirst** | **bool**| True to show most recent first, otherwise most helpful first. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratinggetcomments

> ratinggetcomments($token, $ratingid)

Gets all the comments for a rating

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$ratingid = 'ratingid_example'; // string | The ID of the rating to get all comments.

try {
    $apiInstance->ratinggetcomments($token, $ratingid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratinggetcomments: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **ratingid** | [**string**](../Model/.md)| The ID of the rating to get all comments. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratinggetpending

> ratinggetpending($getgroup, $rateid, $rateval)

Gets info of pre-saved and pre-approved ratings

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$getgroup = 'getgroup_example'; // string | The ID of the group of pending ratings to get.
$rateid = 'rateid_example'; // string | Rate this before returning.
$rateval = 56; // int | The value used to rate the item specified in rateid.

try {
    $apiInstance->ratinggetpending($getgroup, $rateid, $rateval);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratinggetpending: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**string**](../Model/.md)| The ID of the group of pending ratings to get. |
 **rateid** | [**string**](../Model/.md)| Rate this before returning. | [optional]
 **rateval** | **int**| The value used to rate the item specified in rateid. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratinggetpendingmoderation

> ratinggetpendingmoderation($token)

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->ratinggetpendingmoderation($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratinggetpendingmoderation: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingmoderate

> ratingmoderate($token, $type, $id, $approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$type = 'type_example'; // string | Either 'rating' or 'comment' depending on what you want to moderate.
$id = 'id_example'; // string | Id of the rating or comment, as specified in type.
$approve = True; // bool | True to approve, false to reject.

try {
    $apiInstance->ratingmoderate($token, $type, $id, $approve);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratingmoderate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **type** | **string**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. |
 **id** | [**string**](../Model/.md)| Id of the rating or comment, as specified in type. |
 **approve** | **bool**| True to approve, false to reject. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingpostcomment

> ratingpostcomment($token, $ratingid, $comment, $annonymous)

Posts a comments for in a rating

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$ratingid = 'ratingid_example'; // string | The ID of the rating to post the comment.
$comment = 'comment_example'; // string | Text of the comment to post.
$annonymous = True; // bool | True to post the comment annonymously.

try {
    $apiInstance->ratingpostcomment($token, $ratingid, $comment, $annonymous);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratingpostcomment: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **ratingid** | [**string**](../Model/.md)| The ID of the rating to post the comment. |
 **comment** | **string**| Text of the comment to post. |
 **annonymous** | **bool**| True to post the comment annonymously. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingrate

> ratingrate($token, $type, $entityid, $annonymous, $value, $comment, $updatecomment)

Rates one entity

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$type = 'type_example'; // string | The entity type to rate.
$entityid = 'entityid_example'; // string | Id of the entity to rate.
$annonymous = True; // bool | Whether to post as annonymous.
$value = 56; // int | Value from 0 to 100 with the rating.
$comment = 'comment_example'; // string | Comment associated with this review. Comment can be updated later on another request too.
$updatecomment = True; // bool | Whether to update the comments. Defaults to true.

try {
    $apiInstance->ratingrate($token, $type, $entityid, $annonymous, $value, $comment, $updatecomment);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratingrate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **type** | **string**| The entity type to rate. |
 **entityid** | **string**| Id of the entity to rate. |
 **annonymous** | **bool**| Whether to post as annonymous. |
 **value** | **int**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **bool**| Whether to update the comments. Defaults to true. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingratepending

> ratingratepending($group, $annonymous, $rateid, $value, $comment, $updatecomment)

Rates a pre-saved and pre-approved entity

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$group = 'group_example'; // string | The ID of the group of with pre-approved ratings.
$annonymous = True; // bool | Whether to post as annonymous.
$rateid = 'rateid_example'; // string | Rate this before returning.
$value = 56; // int | Value from 0 to 100 with the rating.
$comment = 'comment_example'; // string | Comment associated with this review. Comment can be updated later on another request too.
$updatecomment = True; // bool | Whether to update the comments. Defaults to true.

try {
    $apiInstance->ratingratepending($group, $annonymous, $rateid, $value, $comment, $updatecomment);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratingratepending: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**string**](../Model/.md)| The ID of the group of with pre-approved ratings. |
 **annonymous** | **bool**| Whether to post as annonymous. |
 **rateid** | [**string**](../Model/.md)| Rate this before returning. | [optional]
 **value** | **int**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **bool**| Whether to update the comments. Defaults to true. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingvote

> ratingvote($token, $ratingid, $vote)

Votes up or down a rating

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$ratingid = 'ratingid_example'; // string | The ID of the rating to vote on.
$vote = 56; // int | 1 to vote up, -1 to vote down.

try {
    $apiInstance->ratingvote($token, $ratingid, $vote);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ratingvote: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **ratingid** | [**string**](../Model/.md)| The ID of the rating to vote on. |
 **vote** | **int**| 1 to vote up, -1 to vote down. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportattanalyticsprepare

> reportattanalyticsprepare($token, $reportname, $params, $refreshgroup)

Query and load an attendance analytics report

Allows the user to query and load attendance analytics reports.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$reportname = 'reportname_example'; // string | The name of the report to execute
$params = 'params_example'; // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
$refreshgroup = 'refreshgroup_example'; // string | The ID of the group to check (and refresh) before processing the report.

try {
    $apiInstance->reportattanalyticsprepare($token, $reportname, $params, $refreshgroup);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportattanalyticsprepare: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **reportname** | **string**| The name of the report to execute |
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **refreshgroup** | [**string**](../Model/.md)| The ID of the group to check (and refresh) before processing the report. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportlist

> reportlist($token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->reportlist($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportpermissionsbyuser

> reportpermissionsbyuser($token, $params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$params = 'params_example'; // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

try {
    $apiInstance->reportpermissionsbyuser($token, $params);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportpermissionsbyuser: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportprepare

> reportprepare($token, $reportname, $params, $repformat, $fillgroupid, $groupby, $refreshgroup, $filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$reportname = 'reportname_example'; // string | The name of the report to execute
$params = 'params_example'; // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
$repformat = 'repformat_example'; // string | The format of the resulting report. Json, pdf, csv, ...
$fillgroupid = 'fillgroupid_example'; // string | If specified, the result is used to fill the group with the given ID
$groupby = 'groupby_example'; // string | How to group the records. In the format 'col1+col2|col3+col4
$refreshgroup = 'refreshgroup_example'; // string | The ID of the group to check (and refresh) before processing the report.
$filtertext = 'filtertext_example'; // string | The user friendly text of the applied filters.

try {
    $apiInstance->reportprepare($token, $reportname, $params, $repformat, $fillgroupid, $groupby, $refreshgroup, $filtertext);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportprepare: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **reportname** | **string**| The name of the report to execute |
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **repformat** | **string**| The format of the resulting report. Json, pdf, csv, ... | [optional]
 **fillgroupid** | [**string**](../Model/.md)| If specified, the result is used to fill the group with the given ID | [optional]
 **groupby** | **string**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional]
 **refreshgroup** | [**string**](../Model/.md)| The ID of the group to check (and refresh) before processing the report. | [optional]
 **filtertext** | **string**| The user friendly text of the applied filters. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportquery

> reportquery($token, $reportname, $params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$reportname = 'reportname_example'; // string | The name of the report to execute
$params = 'params_example'; // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

try {
    $apiInstance->reportquery($token, $reportname, $params);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportquery: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportscheduledelete

> reportscheduledelete($token, $id)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the report schedule to delete.

try {
    $apiInstance->reportscheduledelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportscheduledelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the report schedule to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportscheduleget

> reportscheduleget($token, $id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the schedule to get.

try {
    $apiInstance->reportscheduleget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportscheduleget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the schedule to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportschedulelist

> reportschedulelist($token, $from, $count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->reportschedulelist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportschedulelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reportschedulesave

> reportschedulesave($unknown_base_type)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->reportschedulesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reportschedulesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## reporttagresults

> reporttagresults($token, $reportname, $assign, $tags, $params)

Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.

Allows the user to use a report to assign or unassign tags.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$reportname = 'reportname_example'; // string | The name of the report to execute
$assign = True; // bool | Specify whether the specified tags have to be assigned or unassigned.
$tags = 'tags_example'; // string | The tags to assign (or unassign) to the resulting users in the report, in JSON format.
$params = 'params_example'; // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

try {
    $apiInstance->reporttagresults($token, $reportname, $assign, $tags, $params);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->reporttagresults: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **reportname** | **string**| The name of the report to execute |
 **assign** | **bool**| Specify whether the specified tags have to be assigned or unassigned. |
 **tags** | **string**| The tags to assign (or unassign) to the resulting users in the report, in JSON format. |
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodelcheckanalysis

> riskmodelcheckanalysis($token, $id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the risk assessment model whose analysis status has to be returned.

try {
    $apiInstance->riskmodelcheckanalysis($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodelcheckanalysis: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the risk assessment model whose analysis status has to be returned. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodeldelete

> riskmodeldelete($token, $id)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the risk assessment model to delete.

try {
    $apiInstance->riskmodeldelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodeldelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the risk assessment model to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodelget

> riskmodelget($token, $id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the risk assessment model to get.

try {
    $apiInstance->riskmodelget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodelget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the risk assessment model to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodelgetscore

> riskmodelgetscore($token, $userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to get the risk score.

try {
    $apiInstance->riskmodelgetscore($token, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodelgetscore: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to get the risk score. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodellist

> riskmodellist($token, $from, $count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->riskmodellist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodellist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodelpredict

> riskmodelpredict($token, $id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the assessment model to use in order to predict risk.

try {
    $apiInstance->riskmodelpredict($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodelpredict: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the assessment model to use in order to predict risk. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodelprocess

> riskmodelprocess($token, $id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the risk assessment model to process.

try {
    $apiInstance->riskmodelprocess($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodelprocess: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the risk assessment model to process. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodelrefresh

> riskmodelrefresh($token, $id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the risk assessment model whose information has to be refreshed.

try {
    $apiInstance->riskmodelrefresh($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodelrefresh: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the risk assessment model whose information has to be refreshed. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodelsave

> riskmodelsave($unknown_base_type)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->riskmodelsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodelsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## riskmodeltermprecedences

> riskmodeltermprecedences($token)

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->riskmodeltermprecedences($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->riskmodeltermprecedences: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## rolelist

> rolelist($token, $name)

Show a list of roles

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$name = 'name_example'; // string | Filter by name of the role.

try {
    $apiInstance->rolelist($token, $name);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->rolelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ruledelete

> ruledelete($token, $id)

Delete a rule

Allows the user to delete an existing rule.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the rule to delete.

try {
    $apiInstance->ruledelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ruledelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the rule to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ruleget

> ruleget($token, $id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the rule to get.

try {
    $apiInstance->ruleget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ruleget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the rule to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## rulegeteventtype

> rulegeteventtype($token, $event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$event = 'event_example'; // string | The name of the event to refresh.

try {
    $apiInstance->rulegeteventtype($token, $event);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->rulegeteventtype: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## rulelist

> rulelist($token, $from, $count)

View a list of user rules

Allows the user to view the list of all rules.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->rulelist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->rulelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## rulelistactions

> rulelistactions($token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->rulelistactions($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->rulelistactions: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## rulelisteventtypes

> rulelisteventtypes($token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->rulelisteventtypes($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->rulelisteventtypes: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## rulelisthttprequests

> rulelisthttprequests($token, $from, $count, $failed, $status)

View all the http requests sent as a result of a rule

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$failed = True; // bool | If true only failed requests will be returned
$status = 56; // int | The http status to filter the requests

try {
    $apiInstance->rulelisthttprequests($token, $from, $count, $failed, $status);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->rulelisthttprequests: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **failed** | **bool**| If true only failed requests will be returned | [optional]
 **status** | **int**| The http status to filter the requests | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## rulesave

> rulesave($unknown_base_type)

Create or edit a rule

Allows the user to create or edit a rule.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->rulesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->rulesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduledelete

> scheduledelete($token, $scheduleid)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$scheduleid = 'scheduleid_example'; // string | The id of the schedule.

try {
    $apiInstance->scheduledelete($token, $scheduleid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduledelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **scheduleid** | [**string**](../Model/.md)| The id of the schedule. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduledeletemine

> scheduledeletemine($token, $scheduleid)

Delete a specific block from a user's own schedule

Allows the user to delete a schedule block from their own availability.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$scheduleid = 'scheduleid_example'; // string | The id of the schedule.

try {
    $apiInstance->scheduledeletemine($token, $scheduleid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduledeletemine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **scheduleid** | [**string**](../Model/.md)| The id of the schedule. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduleenable

> scheduleenable($token, $userid, $enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to enable or disable the schedule.
$enable = True; // bool | True to enable schedules, false to disable.

try {
    $apiInstance->scheduleenable($token, $userid, $enable);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduleenable: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to enable or disable the schedule. |
 **enable** | **bool**| True to enable schedules, false to disable. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduleenablemine

> scheduleenablemine($token, $enable)

Enable or disable current user's schedule

Allows the user to enable or disable a schedule for himself.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$enable = True; // bool | True to enable schedules, false to disable.

try {
    $apiInstance->scheduleenablemine($token, $enable);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduleenablemine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **enable** | **bool**| True to enable schedules, false to disable. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulefindallstaffslots

> schedulefindallstaffslots($token, $starttime, $endtime, $staffid, $serviceids, $eventid, $locationid, $staffroleids, $availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$staffid = 'staffid_example'; // string | The id of the staff to filter by.
$serviceids = 'serviceids_example'; // string | CSV list of the service Ids to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the location to filter by.
$staffroleids = 'staffroleids_example'; // string | CSV list of the staff member role ids to filter by.
$availablefor = 'availablefor_example'; // string | The specific availability type to filter by.

try {
    $apiInstance->schedulefindallstaffslots($token, $starttime, $endtime, $staffid, $serviceids, $eventid, $locationid, $staffroleids, $availablefor);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulefindallstaffslots: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **staffid** | [**string**](../Model/.md)| The id of the staff to filter by. | [optional]
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the location to filter by. | [optional]
 **staffroleids** | **string**| CSV list of the staff member role ids to filter by. | [optional]
 **availablefor** | **string**| The specific availability type to filter by. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulefindslots

> schedulefindslots($token, $staffid, $starttime, $endtime, $serviceids, $eventid, $locationid, $availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$staffid = 'staffid_example'; // string | The id of the staff to filter by.
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$serviceids = 'serviceids_example'; // string | CSV list of the service Ids to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.
$availablefor = 'availablefor_example'; // string | The specific availability type to filter by.

try {
    $apiInstance->schedulefindslots($token, $staffid, $starttime, $endtime, $serviceids, $eventid, $locationid, $availablefor);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulefindslots: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **staffid** | [**string**](../Model/.md)| The id of the staff to filter by. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **serviceids** | **string**| CSV list of the service Ids to filter by. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. | [optional]
 **availablefor** | **string**| The specific availability type to filter by. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulefindstaffavail

> schedulefindstaffavail($token, $starttime, $endtime, $serviceids, $eventid, $locationid, $staffroleids, $availablefor, $photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$starttime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start time of the range to look for slots.
$endtime = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end time of the range to look for slots.
$serviceids = 'serviceids_example'; // string | CSV list of the service ids to filter by.
$eventid = 'eventid_example'; // string | The id of the event to filter by.
$locationid = 'locationid_example'; // string | The id of the service to filter by.
$staffroleids = 'staffroleids_example'; // string | CSV list of the staff member role ids to filter by.
$availablefor = 'availablefor_example'; // string | Filter slots by a specific availability type.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->schedulefindstaffavail($token, $starttime, $endtime, $serviceids, $eventid, $locationid, $staffroleids, $availablefor, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulefindstaffavail: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **starttime** | **\DateTime**| The start time of the range to look for slots. |
 **endtime** | **\DateTime**| The end time of the range to look for slots. |
 **serviceids** | **string**| CSV list of the service ids to filter by. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event to filter by. | [optional]
 **locationid** | [**string**](../Model/.md)| The id of the service to filter by. | [optional]
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduleget

> scheduleget($token, $scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$scheduleid = 'scheduleid_example'; // string | The id of the schedule.

try {
    $apiInstance->scheduleget($token, $scheduleid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduleget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **scheduleid** | [**string**](../Model/.md)| The id of the schedule. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulegetmine

> schedulegetmine($token, $scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$scheduleid = 'scheduleid_example'; // string | The id of the schedule.

try {
    $apiInstance->schedulegetmine($token, $scheduleid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulegetmine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **scheduleid** | [**string**](../Model/.md)| The id of the schedule. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulegetstaff

> schedulegetstaff($token, $userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to get info.

try {
    $apiInstance->schedulegetstaff($token, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulegetstaff: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to get info. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulegetstaffmine

> schedulegetstaffmine($token)

View current user's schedule information

Allows the user to view their own schedule.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->schedulegetstaffmine($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulegetstaffmine: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduleintegrationdeleteitem

> scheduleintegrationdeleteitem($token, $thirdpartyid)

Delete a schedule item looking up by a third party ID

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$thirdpartyid = 'thirdpartyid_example'; // string | The third party id to search the schedule block / appointment.

try {
    $apiInstance->scheduleintegrationdeleteitem($token, $thirdpartyid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduleintegrationdeleteitem: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduleintegrationdeleteitemsbymasterid

> scheduleintegrationdeleteitemsbymasterid($token, $thirdpartymasterid)

Delete multiple schedule items looking up by a third party master ID

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$thirdpartymasterid = 'thirdpartymasterid_example'; // string | The third party master id to search the schedule items.

try {
    $apiInstance->scheduleintegrationdeleteitemsbymasterid($token, $thirdpartymasterid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduleintegrationdeleteitemsbymasterid: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduleintegrationgetitem

> scheduleintegrationgetitem($token, $thirdpartyid)

Get a schedule item looking up by a third party ID

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$thirdpartyid = 'thirdpartyid_example'; // string | The third party id to search for the schedule item.

try {
    $apiInstance->scheduleintegrationgetitem($token, $thirdpartyid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduleintegrationgetitem: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduleintegrationsaveitem

> scheduleintegrationsaveitem($unknown_base_type)

Save a schedule item looking up by a third party ID

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->scheduleintegrationsaveitem($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduleintegrationsaveitem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## scheduleintegrationsetid

> scheduleintegrationsetid($token, $id, $thirdpartyid, $thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the schedule block / appointment.
$thirdpartyid = 'thirdpartyid_example'; // string | The 3rd party ID to set.
$thirdpartymasterid = 'thirdpartymasterid_example'; // string | The 3rd party master ID to set (useful to handle recurring items).

try {
    $apiInstance->scheduleintegrationsetid($token, $id, $thirdpartyid, $thirdpartymasterid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->scheduleintegrationsetid: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the schedule block / appointment. |
 **thirdpartyid** | **string**| The 3rd party ID to set. |
 **thirdpartymasterid** | **string**| The 3rd party master ID to set (useful to handle recurring items). | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulemyofftimes

> schedulemyofftimes($token, $includedeleted, $onlyupcoming, $modifiedafter)

View current user's schedule exceptions

Allows the user to view their own schedule exceptions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$includedeleted = True; // bool | If true the deleted offtimes are also returned.
$onlyupcoming = True; // bool | If true then only upcoming offtimes are returned.
$modifiedafter = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | If specified, only offtimes modified after the specified date will be returned.

try {
    $apiInstance->schedulemyofftimes($token, $includedeleted, $onlyupcoming, $modifiedafter);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulemyofftimes: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **includedeleted** | **bool**| If true the deleted offtimes are also returned. | [optional]
 **onlyupcoming** | **bool**| If true then only upcoming offtimes are returned. | [optional]
 **modifiedafter** | **\DateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulesave

> schedulesave($unknown_base_type)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->schedulesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## schedulesavemine

> schedulesavemine($unknown_base_type)

Create or edit a block in current user's schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->schedulesavemine($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->schedulesavemine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## search

> search($token, $query, $page)

Search

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$query = 'query_example'; // string | The query to search for.
$page = 56; // int | Current page to show, zero-based.

try {
    $apiInstance->search($token, $query, $page);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->search: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## searchgetentities

> searchgetentities($token)

Get the information of the entities that can be searched

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->searchgetentities($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->searchgetentities: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## securityassesspermission

> securityassesspermission($token, $commandname)

Returns the list of users for a specific permission

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$commandname = 'commandname_example'; // string | Name of the action or command to get the roles.

try {
    $apiInstance->securityassesspermission($token, $commandname);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->securityassesspermission: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## securityassessrole

> securityassessrole($token, $roleid)

Returns the list of permissions for a specific role

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$roleid = 'roleid_example'; // string | Role ID to list the effective permissions.

try {
    $apiInstance->securityassessrole($token, $roleid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->securityassessrole: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **roleid** | [**string**](../Model/.md)| Role ID to list the effective permissions. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## securityassessscope

> securityassessscope($token, $locationid)

Returns the list of users for a specific user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$locationid = 'locationid_example'; // string | Location ID to list the users with that scope.

try {
    $apiInstance->securityassessscope($token, $locationid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->securityassessscope: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **locationid** | [**string**](../Model/.md)| Location ID to list the users with that scope. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## securityassessuser

> securityassessuser($token, $userid)

Returns the list of permissions for a specific user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | User ID to list the effective permissions.

try {
    $apiInstance->securityassessuser($token, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->securityassessuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| User ID to list the effective permissions. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## seminardelete

> seminardelete($token, $id)

Delete an event

Allows the user to delete an existing event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the seminar to delete.

try {
    $apiInstance->seminardelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->seminardelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the seminar to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## seminarget

> seminarget($token, $id)

Search and view details of a event

Allows the user to view a event and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the seminar to get.

try {
    $apiInstance->seminarget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->seminarget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the seminar to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## seminarlist

> seminarlist($token, $from, $count, $summaryonly, $termid)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 'from_example'; // string | The first record to return.
$count = 'count_example'; // string | The max number of records to return.
$summaryonly = True; // bool | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
$termid = 'termid_example'; // string | Id of the term to list the events. Null to list all events.

try {
    $apiInstance->seminarlist($token, $from, $count, $summaryonly, $termid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->seminarlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **string**| The first record to return. |
 **count** | **string**| The max number of records to return. |
 **summaryonly** | **bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**string**](../Model/.md)| Id of the term to list the events. Null to list all events. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## seminarsave

> seminarsave($unknown_base_type)

Create or edit a event

Allows the user to create or edit a event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->seminarsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->seminarsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## serviceassignmentaddservice

> serviceassignmentaddservice($token, $serviceid, $locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceid = 'serviceid_example'; // string | The id of the service to add.
$locationid = 'locationid_example'; // string | The id of the location.

try {
    $apiInstance->serviceassignmentaddservice($token, $serviceid, $locationid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->serviceassignmentaddservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceid** | [**string**](../Model/.md)| The id of the service to add. |
 **locationid** | [**string**](../Model/.md)| The id of the location. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## serviceassignmentgetlocation

> serviceassignmentgetlocation($token, $locationid, $includegloballyavailable, $namefilter, $count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$locationid = 'locationid_example'; // string | The id of the location to get.
$includegloballyavailable = True; // bool | Specifies whether the services available globally must be returned or not.
$namefilter = True; // bool | Filters the name of the services to return.
$count = 56; // int | The max number of services to return.

try {
    $apiInstance->serviceassignmentgetlocation($token, $locationid, $includegloballyavailable, $namefilter, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->serviceassignmentgetlocation: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **locationid** | [**string**](../Model/.md)| The id of the location to get. |
 **includegloballyavailable** | **bool**| Specifies whether the services available globally must be returned or not. | [optional]
 **namefilter** | **bool**| Filters the name of the services to return. | [optional]
 **count** | **int**| The max number of services to return. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## serviceassignmentgetservice

> serviceassignmentgetservice($token, $serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceid = 'serviceid_example'; // string | The id of the service to get its locations.

try {
    $apiInstance->serviceassignmentgetservice($token, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->serviceassignmentgetservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceid** | [**string**](../Model/.md)| The id of the service to get its locations. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## serviceassignmentremoveservice

> serviceassignmentremoveservice($token, $serviceid, $locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceid = 'serviceid_example'; // string | The id of the service to remove.
$locationid = 'locationid_example'; // string | The id of the location to remove the service from.

try {
    $apiInstance->serviceassignmentremoveservice($token, $serviceid, $locationid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->serviceassignmentremoveservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceid** | [**string**](../Model/.md)| The id of the service to remove. |
 **locationid** | [**string**](../Model/.md)| The id of the location to remove the service from. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## servicedelete

> servicedelete($token, $id)

Delete a service

Allows the user to delete a service from the existing list.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the service to delete.

try {
    $apiInstance->servicedelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->servicedelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the service to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## serviceget

> serviceget($token, $id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the service to get.

try {
    $apiInstance->serviceget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->serviceget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the service to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## servicelist

> servicelist($token, $from, $count)

View a list of services

Allows the user to view the full list of existing services.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->servicelist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->servicelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## servicesave

> servicesave($unknown_base_type)

Create or edit a service

Allows the user to create or edit a service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->servicesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->servicesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendancelogaddnote

> sessionattendancelogaddnote($token, $id, $text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the attendance log.
$text = 'text_example'; // string | The text of the note to add.

try {
    $apiInstance->sessionattendancelogaddnote($token, $id, $text);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendancelogaddnote: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the attendance log. |
 **text** | **string**| The text of the note to add. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendancelogget

> sessionattendancelogget($token, $id, $photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the attendance log to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->sessionattendancelogget($token, $id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendancelogget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the attendance log to get. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendanceloggetuser

> sessionattendanceloggetuser($attendee, $eventid, $token)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$attendee = 'attendee_example'; // string | The id of the attendee to get statistic for.
$eventid = 'eventid_example'; // string | The id of the event whose attendee statistics have to be returned.
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->sessionattendanceloggetuser($attendee, $eventid, $token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendanceloggetuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**string**](../Model/.md)| The id of the attendee to get statistic for. |
 **eventid** | [**string**](../Model/.md)| The id of the event whose attendee statistics have to be returned. |
 **token** | **string**| The authentication token. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendanceloglist

> sessionattendanceloglist($token, $session, $from, $count, $photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$session = 'session_example'; // string | The id of the session whose attendees logs have to be returned.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->sessionattendanceloglist($token, $session, $from, $count, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendanceloglist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **session** | [**string**](../Model/.md)| The id of the session whose attendees logs have to be returned. |
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendanceloglistevent

> sessionattendanceloglistevent($eventid, $token)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$eventid = 'eventid_example'; // string | The id of the event whose attendance has to be returned.
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->sessionattendanceloglistevent($eventid, $token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendanceloglistevent: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event whose attendance has to be returned. |
 **token** | **string**| The authentication token. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendanceloglistsummary

> sessionattendanceloglistsummary($token, $eventid, $attendeeid, $groupid, $start, $end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The id of the event whose attendance has to be returned.
$attendeeid = 'attendeeid_example'; // string | The id of the attendee whose attendance has to be returned.
$groupid = 'groupid_example'; // string | The id of the group whose attendance has to be returned.
$start = 'start_example'; // string | The start date to filter (beginning of time by default).
$end = 'end_example'; // string | The end date to filter (today by default).

try {
    $apiInstance->sessionattendanceloglistsummary($token, $eventid, $attendeeid, $groupid, $start, $end);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendanceloglistsummary: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event whose attendance has to be returned. | [optional]
 **attendeeid** | [**string**](../Model/.md)| The id of the attendee whose attendance has to be returned. | [optional]
 **groupid** | [**string**](../Model/.md)| The id of the group whose attendance has to be returned. | [optional]
 **start** | **string**| The start date to filter (beginning of time by default). | [optional]
 **end** | **string**| The end date to filter (today by default). | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendancelogmylistsummary

> sessionattendancelogmylistsummary($token, $eventid, $start, $end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The id of the event whose attendance has to be returned.
$start = 'start_example'; // string | The start date to filter (beginning of time by default).
$end = 'end_example'; // string | The end date to filter (today by default).

try {
    $apiInstance->sessionattendancelogmylistsummary($token, $eventid, $start, $end);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendancelogmylistsummary: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event whose attendance has to be returned. | [optional]
 **start** | **string**| The start date to filter (beginning of time by default). | [optional]
 **end** | **string**| The end date to filter (today by default). | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendancelogsave

> sessionattendancelogsave($unknown_base_type)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->sessionattendancelogsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendancelogsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionattendancelogsaveswipe

> sessionattendancelogsaveswipe($unknown_base_type)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->sessionattendancelogsaveswipe($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionattendancelogsaveswipe: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionbulkupdate

> sessionbulkupdate($token, $eventid, $sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The id of the event to bulk update.
$sessions = 'sessions_example'; // string | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

try {
    $apiInstance->sessionbulkupdate($token, $eventid, $sessions);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionbulkupdate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The id of the event to bulk update. |
 **sessions** | **string**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionget

> sessionget($token, $id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the session to get.

try {
    $apiInstance->sessionget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the session to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessiongetschedule

> sessiongetschedule($token, $day, $attendee, $location, $instructor)

Gets the schedule for a location, instructor or attendees

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$day = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The day to return. It will also return the whole week for that day.
$attendee = 'attendee_example'; // string | The id of the attendee to get the schedule.
$location = 'location_example'; // string | The id of the location to get the schedule.
$instructor = 'instructor_example'; // string | The id of the instructor to get the schedule.

try {
    $apiInstance->sessiongetschedule($token, $day, $attendee, $location, $instructor);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessiongetschedule: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | [optional]
 **day** | **\DateTime**| The day to return. It will also return the whole week for that day. | [optional]
 **attendee** | [**string**](../Model/.md)| The id of the attendee to get the schedule. | [optional]
 **location** | [**string**](../Model/.md)| The id of the location to get the schedule. | [optional]
 **instructor** | [**string**](../Model/.md)| The id of the instructor to get the schedule. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionlist

> sessionlist($from, $count, $token, $startdate, $enddate)

Gets all future sessions of the current semester

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$token = 'token_example'; // string | The authentication token.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date to filter the sessions
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date to filter the sessions.

try {
    $apiInstance->sessionlist($from, $count, $token, $startdate, $enddate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **token** | **string**| The authentication token. | [optional]
 **startdate** | **\DateTime**| The start date to filter the sessions | [optional]
 **enddate** | **\DateTime**| The end date to filter the sessions. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionregaddcurrentuser

> sessionregaddcurrentuser($token, $eventid, $sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The id of the event.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.

try {
    $apiInstance->sessionregaddcurrentuser($token, $eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionregaddcurrentuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **sessiondate** | **\DateTime**| The date and time when the session starts. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionregadduser

> sessionregadduser($token, $userid, $eventid, $sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to add.
$eventid = 'eventid_example'; // string | The id of the event.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.

try {
    $apiInstance->sessionregadduser($token, $userid, $eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionregadduser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **sessiondate** | **\DateTime**| The date and time when the session starts. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionreggetmysessions

> sessionreggetmysessions($token, $date)

View all the sessions the logged user is registered to

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$date = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | Start date to filter the sessions.

try {
    $apiInstance->sessionreggetmysessions($token, $date);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionreggetmysessions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **date** | **\DateTime**| Start date to filter the sessions. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionreggetsessions

> sessionreggetsessions($token, $userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The user id to list sessions.

try {
    $apiInstance->sessionreggetsessions($token, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionreggetsessions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The user id to list sessions. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionreggetsettings

> sessionreggetsettings($token, $locationid, $eventid, $sessiondate, $noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$locationid = 'locationid_example'; // string | The id of the location to save settings.
$eventid = 'eventid_example'; // string | The id of the event to save settings.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.
$noinherit = True; // bool | True to get the location/event/session specific settings without looking for the more global settings.

try {
    $apiInstance->sessionreggetsettings($token, $locationid, $eventid, $sessiondate, $noinherit);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionreggetsettings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **locationid** | [**string**](../Model/.md)| The id of the location to save settings. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event to save settings. | [optional]
 **sessiondate** | **\DateTime**| The date and time when the session starts. | [optional]
 **noinherit** | **bool**| True to get the location/event/session specific settings without looking for the more global settings. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionreggetusers

> sessionreggetusers($token, $eventid, $sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The event id to list sessions.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date of the session to find.

try {
    $apiInstance->sessionreggetusers($token, $eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionreggetusers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The event id to list sessions. |
 **sessiondate** | **\DateTime**| The date of the session to find. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionreglistsessions

> sessionreglistsessions($token, $eventid, $sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The event id to list sessions.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date of the session to find.

try {
    $apiInstance->sessionreglistsessions($token, $eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionreglistsessions: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The event id to list sessions. |
 **sessiondate** | **\DateTime**| The date of the session to find. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionreglistupcoming

> sessionreglistupcoming($token, $date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$date = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | Only sessions in the week of the specified date will be returned.

try {
    $apiInstance->sessionreglistupcoming($token, $date);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionreglistupcoming: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **date** | **\DateTime**| Only sessions in the week of the specified date will be returned. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionreglistupcomingevent

> sessionreglistupcomingevent($token, $date, $event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$date = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | Start date to filter the returned sessions.
$event = 'event_example'; // string | The id of the event whose sessions will be returned

try {
    $apiInstance->sessionreglistupcomingevent($token, $date, $event);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionreglistupcomingevent: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **date** | **\DateTime**| Start date to filter the returned sessions. |
 **event** | [**string**](../Model/.md)| The id of the event whose sessions will be returned |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionregremovecurrentuser

> sessionregremovecurrentuser($token, $eventid, $sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$eventid = 'eventid_example'; // string | The id of the event.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.

try {
    $apiInstance->sessionregremovecurrentuser($token, $eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionregremovecurrentuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **sessiondate** | **\DateTime**| The date and time when the session starts. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionregremoveuser

> sessionregremoveuser($token, $userid, $eventid, $sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to remove.
$eventid = 'eventid_example'; // string | The id of the event.
$sessiondate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time when the session starts.

try {
    $apiInstance->sessionregremoveuser($token, $userid, $eventid, $sessiondate);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionregremoveuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **sessiondate** | **\DateTime**| The date and time when the session starts. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionregsavesettings

> sessionregsavesettings($unknown_base_type)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->sessionregsavesettings($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionregsavesettings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionswipedelete

> sessionswipedelete($token, $id)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the session swipe to delete.

try {
    $apiInstance->sessionswipedelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionswipedelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the session swipe to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionswipeget

> sessionswipeget($token, $id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the swipe to get.

try {
    $apiInstance->sessionswipeget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionswipeget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the swipe to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionswipelistunresolved

> sessionswipelistunresolved($from, $count, $token)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->sessionswipelistunresolved($from, $count, $token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionswipelistunresolved: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionswiperesolve

> sessionswiperesolve($token, $id, $session, $user)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the swipe to resolve.
$session = 'session_example'; // string | The id of the session whose swipe has to be saved.
$user = 'user_example'; // string | The id of the user who signed-in.

try {
    $apiInstance->sessionswiperesolve($token, $id, $session, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionswiperesolve: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the swipe to resolve. |
 **session** | [**string**](../Model/.md)| The id of the session whose swipe has to be saved. | [optional]
 **user** | [**string**](../Model/.md)| The id of the user who signed-in. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionswipesave

> sessionswipesave($unknown_base_type)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->sessionswipesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionswipesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## sessionswipesaveanonym

> sessionswipesaveanonym($unknown_base_type)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->sessionswipesaveanonym($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->sessionswipesaveanonym: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## settingaddlogo

> settingaddlogo($token, $upload, $filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$upload = 'upload_example'; // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
$filename = 'filename_example'; // string | The original filename, needed to process the file.

try {
    $apiInstance->settingaddlogo($token, $upload, $filename);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->settingaddlogo: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## settingget

> settingget($keys, $token, $domain, $scope)

Get settings for the account or the specified scope

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$keys = 'keys_example'; // string | The option keys to get values for. Enter multiple separated by comma.
$token = 'token_example'; // string | The authentication token.
$domain = 'domain_example'; // string | The account domain, in case of reading settings annonymously.
$scope = 'scope_example'; // string | The scope of the settings to get.

try {
    $apiInstance->settingget($keys, $token, $domain, $scope);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->settingget: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## settingsave

> settingsave($unknown_base_type)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->settingsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->settingsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## settingviewgeneral

> settingviewgeneral($token)

View general settings for the account

Allows the user to view the settings' general section.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->settingviewgeneral($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->settingviewgeneral: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## socialcontacts

> socialcontacts($token, $filter, $showdefaultphoto)

Gets the list of contacts in the network

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$filter = 'filter_example'; // string | Text to filter results.
$showdefaultphoto = True; // bool | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.

try {
    $apiInstance->socialcontacts($token, $filter, $showdefaultphoto);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->socialcontacts: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **filter** | **string**| Text to filter results. | [optional]
 **showdefaultphoto** | **bool**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## socialgroupaddmembers

> socialgroupaddmembers($token, $id, $userids)

Adds new members to a group (which the user must own already)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | ID of the group to add members to.
$userids = 'userids_example'; // string | Csv list of user Ids to add.

try {
    $apiInstance->socialgroupaddmembers($token, $id, $userids);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->socialgroupaddmembers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| ID of the group to add members to. |
 **userids** | **string**| Csv list of user Ids to add. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## socialgroupdelete

> socialgroupdelete($token, $id)

Deletes a group

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | ID of the group to delete.

try {
    $apiInstance->socialgroupdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->socialgroupdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| ID of the group to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## socialgrouplist

> socialgrouplist($token)

View all the groups the current user is in

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->socialgrouplist($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->socialgrouplist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## socialgrouplistmembers

> socialgrouplistmembers($token, $id)

Lists the members of a group

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | ID of the group to list members.

try {
    $apiInstance->socialgrouplistmembers($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->socialgrouplistmembers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| ID of the group to list members. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## socialgroupremovemembers

> socialgroupremovemembers($token, $id, $userids)

Removes members from a group (which the user must own already)

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | ID of the group to remove members from.
$userids = 'userids_example'; // string | Csv list of user Ids to remove.

try {
    $apiInstance->socialgroupremovemembers($token, $id, $userids);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->socialgroupremovemembers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| ID of the group to remove members from. |
 **userids** | **string**| Csv list of user Ids to remove. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## socialgroupremovemyself

> socialgroupremovemyself($token, $id)

Removes myself from an existent group

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | ID of the group to remove me from.

try {
    $apiInstance->socialgroupremovemyself($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->socialgroupremovemyself: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| ID of the group to remove me from. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## socialgroupsave

> socialgroupsave($unknown_base_type)

Saves a new group

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->socialgroupsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->socialgroupsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ssogeneratekey

> ssogeneratekey($token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->ssogeneratekey($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ssogeneratekey: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ssogetsettings

> ssogetsettings($token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->ssogetsettings($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ssogetsettings: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ssoissuetoken

> ssoissuetoken($key, $username, $expires)

Issue single sign-on token

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$key = 'key_example'; // string | The single sign-on key of the account.
$username = 'username_example'; // string | The email of the user to sign-on.
$expires = True; // bool | Specifies whether the session should expire when inactive.

try {
    $apiInstance->ssoissuetoken($key, $username, $expires);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ssoissuetoken: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The single sign-on key of the account. |
 **username** | **string**| The email of the user to sign-on. |
 **expires** | **bool**| Specifies whether the session should expire when inactive. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ssosavesettings

> ssosavesettings($unknown_base_type)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->ssosavesettings($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->ssosavesettings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailaddmetoallservices

> staffavailaddmetoallservices($token)

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->staffavailaddmetoallservices($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailaddmetoallservices: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailaddmetoservice

> staffavailaddmetoservice($token, $serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceid = 'serviceid_example'; // string | The id of the service.

try {
    $apiInstance->staffavailaddmetoservice($token, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailaddmetoservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceid** | [**string**](../Model/.md)| The id of the service. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailaddusertoallservices

> staffavailaddusertoallservices($token, $userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to add.

try {
    $apiInstance->staffavailaddusertoallservices($token, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailaddusertoallservices: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to add. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailaddusertoservice

> staffavailaddusertoservice($token, $userid, $serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to add.
$serviceid = 'serviceid_example'; // string | The id of the service.

try {
    $apiInstance->staffavailaddusertoservice($token, $userid, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailaddusertoservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **serviceid** | [**string**](../Model/.md)| The id of the service. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailgetmyservices

> staffavailgetmyservices($token)

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->staffavailgetmyservices($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailgetmyservices: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailgetservices

> staffavailgetservices($token, $userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The user id to list services.

try {
    $apiInstance->staffavailgetservices($token, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailgetservices: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The user id to list services. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailgetusersforservice

> staffavailgetusersforservice($token, $serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceid = 'serviceid_example'; // string | The service id to list users.

try {
    $apiInstance->staffavailgetusersforservice($token, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailgetusersforservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceid** | [**string**](../Model/.md)| The service id to list users. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavaillisttypes

> staffavaillisttypes($token)

View all the availability types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->staffavaillisttypes($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavaillisttypes: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailremovemefromallservices

> staffavailremovemefromallservices($token)

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->staffavailremovemefromallservices($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailremovemefromallservices: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailremovemefromservice

> staffavailremovemefromservice($token, $serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$serviceid = 'serviceid_example'; // string | The id of the service.

try {
    $apiInstance->staffavailremovemefromservice($token, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailremovemefromservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **serviceid** | [**string**](../Model/.md)| The id of the service. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailremoveuserfromallservices

> staffavailremoveuserfromallservices($token, $userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to remove.

try {
    $apiInstance->staffavailremoveuserfromallservices($token, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailremoveuserfromallservices: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailremoveuserfromservice

> staffavailremoveuserfromservice($token, $userid, $serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to remove.
$serviceid = 'serviceid_example'; // string | The id of the service.

try {
    $apiInstance->staffavailremoveuserfromservice($token, $userid, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailremoveuserfromservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **serviceid** | [**string**](../Model/.md)| The id of the service. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailsetavailability

> staffavailsetavailability($token, $userid, $availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user whose specific availability has to be set.
$availablefor = 'availablefor_example'; // string | Specific availability to set.

try {
    $apiInstance->staffavailsetavailability($token, $userid, $availablefor);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailsetavailability: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user whose specific availability has to be set. |
 **availablefor** | **string**| Specific availability to set. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## staffavailsetmyavailability

> staffavailsetmyavailability($token, $availablefor)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$availablefor = 'availablefor_example'; // string | Specific availability to set.

try {
    $apiInstance->staffavailsetmyavailability($token, $availablefor);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->staffavailsetmyavailability: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationdelete

> stationdelete($token, $id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the sign-in station to delete.

try {
    $apiInstance->stationdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the sign-in station to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationget

> stationget($token, $id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the sign-in station to get.

try {
    $apiInstance->stationget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the sign-in station to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationgetcurrentterms

> stationgetcurrentterms($station)

Get all the current terms

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station whose account's current terms have to be retrieved.

try {
    $apiInstance->stationgetcurrentterms($station);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationgetcurrentterms: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationgetinfo

> stationgetinfo($id, $event)

Gets a the info to display in the sign-in station by it's ID.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = 'id_example'; // string | The id of the sign-in station to get.
$event = 'event_example'; // string | The id of the event, to override the one by schedule.

try {
    $apiInstance->stationgetinfo($id, $event);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationgetinfo: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the sign-in station to get. |
 **event** | [**string**](../Model/.md)| The id of the event, to override the one by schedule. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationgetlicense

> stationgetlicense($station)

Gets the current license information

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station whose account's license has to be retrieved.

try {
    $apiInstance->stationgetlicense($station);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationgetlicense: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationgetlocationsettings

> stationgetlocationsettings($location)

View the sign-in station settings of a specified location

Allows the user to view the location settings of a sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$location = 'location_example'; // string | The id of the location whose station settings have to be returned.

try {
    $apiInstance->stationgetlocationsettings($location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationgetlocationsettings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**string**](../Model/.md)| The id of the location whose station settings have to be returned. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationlist

> stationlist($token, $from, $count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->stationlist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationlist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationsave

> stationsave($unknown_base_type)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->stationsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationsavemine

> stationsavemine($unknown_base_type)

Create or edit a class attendance sign-in station for myself

Allows the user to create a class attendance sign-in station for a course for which they are available as staff.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->stationsavemine($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationsavemine: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## stationunlock

> stationunlock($id, $passcode, $method)

Unlocks the sign-in station.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = 'id_example'; // string | The id of the sign-in station to unlock.
$passcode = 'passcode_example'; // string | The passcode to unlock the station.
$method = 'method_example'; // string | The authentication method. Valid values are 'token' and 'cookie'.

try {
    $apiInstance->stationunlock($id, $passcode, $method);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->stationunlock: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the sign-in station to unlock. |
 **passcode** | **string**| The passcode to unlock the station. |
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## swipedelete

> swipedelete($token, $id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the swipe to delete.

try {
    $apiInstance->swipedelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->swipedelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the swipe to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## swipeget

> swipeget($token, $id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the swipe to get.

try {
    $apiInstance->swipeget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->swipeget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the swipe to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## swipelist

> swipelist($from, $count, $token)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->swipelist($from, $count, $token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->swipelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## swipesave

> swipesave($unknown_base_type)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->swipesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->swipesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## swipesaveanonym

> swipesaveanonym($unknown_base_type)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->swipesaveanonym($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->swipesaveanonym: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## tagdelete

> tagdelete($token, $id)

Delete a tag

Allows the user to delete an existing tag.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the tag to delete.

try {
    $apiInstance->tagdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->tagdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the tag to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## tagget

> tagget($token, $id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the tag to get.

try {
    $apiInstance->tagget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->tagget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the tag to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## taglist

> taglist($token, $group, $from, $count)

View a list of tags

Allows the user to view the list of tags.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$group = 'group_example'; // string | The group of the tags to return.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->taglist($token, $group, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->taglist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## taglistgroups

> taglistgroups($token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->taglistgroups($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->taglistgroups: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## tagsave

> tagsave($unknown_base_type)

Create or edit a tag

Allows the user to create or edit a tag.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->tagsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->tagsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## tagsearch

> tagsearch($token, $query, $allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$query = 'query_example'; // string | The query to search tags. Use group:<group> to search in a specific group (mandatory).
$allowcreatingnew = True; // bool | Specifies whether an option to create a new tag should be retrieved.

try {
    $apiInstance->tagsearch($token, $query, $allowcreatingnew);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->tagsearch: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **query** | **string**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). |
 **allowcreatingnew** | **bool**| Specifies whether an option to create a new tag should be retrieved. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templateaddimage

> templateaddimage($token, $template, $upload, $filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$template = 'template_example'; // string | The id of the template where the image has to be added
$upload = 'upload_example'; // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
$filename = 'filename_example'; // string | The local name of the uploaded file. For later reference.

try {
    $apiInstance->templateaddimage($token, $template, $upload, $filename);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templateaddimage: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **template** | [**string**](../Model/.md)| The id of the template where the image has to be added |
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templatedelete

> templatedelete($token, $id)

Delete a template

Allows the user to delete an existing template.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the template to delete.

try {
    $apiInstance->templatedelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templatedelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the template to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templateemail

> templateemail($token, $jobid, $emailsubject, $emailbody, $templatekind, $emailfrom, $emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$jobid = 'jobid_example'; // string | The id of the job that is creating the templates.
$emailsubject = 'emailsubject_example'; // string | Args depending on the send-to flag.
$emailbody = 'emailbody_example'; // string | Args depending on the send-to flag.
$templatekind = 'templatekind_example'; // string | The kind of the template you're sending. It must be included in (badge, certificate).
$emailfrom = 'emailfrom_example'; // string | The name of the sender to be displayed in the receipients inbox
$emailreplyto = 'emailreplyto_example'; // string | The reply-to field for the emails.

try {
    $apiInstance->templateemail($token, $jobid, $emailsubject, $emailbody, $templatekind, $emailfrom, $emailreplyto);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templateemail: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templategenerate

> templategenerate($token, $template, $source, $singlefile, $userid, $forsending, $role, $filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$template = 'template_example'; // string | The id of the template to generate.
$source = 'source_example'; // string | The source key of the selected template data source.
$singlefile = True; // bool | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
$userid = 'userid_example'; // string | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
$forsending = True; // bool | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
$role = 'role_example'; // string | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
$filters = 'filters_example'; // string | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...

try {
    $apiInstance->templategenerate($token, $template, $source, $singlefile, $userid, $forsending, $role, $filters);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templategenerate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **template** | [**string**](../Model/.md)| The id of the template to generate. |
 **source** | [**string**](../Model/.md)| The source key of the selected template data source. |
 **singlefile** | **bool**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. |
 **userid** | **string**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional]
 **forsending** | **bool**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional]
 **role** | [**string**](../Model/.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional]
 **filters** | **string**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templateget

> templateget($token, $id)

View details of a template

Allows the user to view a template and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the template to get.

try {
    $apiInstance->templateget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templateget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the template to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templategetgenerated

> templategetgenerated($token, $jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$jobid = 'jobid_example'; // string | The id of the job that is creating the templates.

try {
    $apiInstance->templategetgenerated($token, $jobid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templategetgenerated: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templatelist

> templatelist($token, $from, $count, $kind, $designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$kind = 'kind_example'; // string | The kind of the templates to return. It must be included in (badge, certificate).
$designedonly = True; // bool | If true then it only returns the templates that were designed. Otherwise, it returns all.

try {
    $apiInstance->templatelist($token, $from, $count, $kind, $designedonly);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templatelist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). |
 **designedonly** | **bool**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templatelistsources

> templatelistsources($token, $kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$kind = 'kind_example'; // string | The kind of the templates to return. It must be included in (badge, certificate).

try {
    $apiInstance->templatelistsources($token, $kind);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templatelistsources: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templatesave

> templatesave($unknown_base_type)

Create or edit a template

Allows the user to create or edit a template.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->templatesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templatesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## templatesavelayout

> templatesavelayout($unknown_base_type)

Save the layout of a template

Allows the user to edit a template's layout.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->templatesavelayout($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->templatesavelayout: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## termdelete

> termdelete($token, $id)

Delete a term

Allows the user to delete a term from the existing list.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the term to delete.

try {
    $apiInstance->termdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->termdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the term to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## termget

> termget($token, $id)

Search and view details of a term

Allows the user to view a term and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the term to get.

try {
    $apiInstance->termget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->termget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the term to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## termlist

> termlist($token, $from, $count, $notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$notpast = True; // bool | Specifies whether the terms in the past should be returned or not.

try {
    $apiInstance->termlist($token, $from, $count, $notpast);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->termlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. | [optional]
 **count** | **int**| The max number of records to return. | [optional]
 **notpast** | **bool**| Specifies whether the terms in the past should be returned or not. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## termsave

> termsave($unknown_base_type)

Create and edit terms

Allows the user to create and edit terms.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->termsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->termsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## textcreditremaining

> textcreditremaining($token)

Gets the remaining text credits for the account

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->textcreditremaining($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->textcreditremaining: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## texttoimage

> texttoimage($token, $text, $fontcolor, $fontsize, $direction, $width)

Generates a dynamic image from text

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$text = 'text_example'; // string | The text to convert to an image, use double pipes (||) as a new line.
$fontcolor = 'fontcolor_example'; // string | The color of the text, in hex format, without the #.
$fontsize = 56; // int | The size of the text, in points.
$direction = 'direction_example'; // string | Either vertical or horizontal, default horizontal.
$width = 56; // int | The image width in pixels (or height if the direction is vertical).

try {
    $apiInstance->texttoimage($token, $text, $fontcolor, $fontsize, $direction, $width);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->texttoimage: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## translationget

> translationget($token, $universal)

Gets the translations of the specified values

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$universal = 'universal_example'; // string | Pipe separated list of universal text to be translated.

try {
    $apiInstance->translationget($token, $universal);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->translationget: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## translationgetcachefile

> translationgetcachefile($token, $account)

Get the file containing the translations

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$account = 'account_example'; // string | The id of the account whose translations file has to be retrieved.

try {
    $apiInstance->translationgetcachefile($token, $account);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->translationgetcachefile: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## translationlist

> translationlist($token, $filter, $nondefaultonly, $appdefaultasuniversal)

Lists all the available translations in the system

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$filter = 'filter_example'; // string | Text to search/filter translations.
$nondefaultonly = True; // bool | If true then it returns only the terms translated. Otherwise, it returns all.
$appdefaultasuniversal = True; // bool | If true then it uses the app default translation as the universal term.

try {
    $apiInstance->translationlist($token, $filter, $nondefaultonly, $appdefaultasuniversal);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->translationlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **filter** | **string**| Text to search/filter translations. | [optional]
 **nondefaultonly** | **bool**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional]
 **appdefaultasuniversal** | **bool**| If true then it uses the app default translation as the universal term. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## translationsave

> translationsave($unknown_base_type)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->translationsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->translationsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userchangepwd

> userchangepwd($token, $oldpass, $newpass)

Change user's own password

Allows the user to change their own password.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$oldpass = 'oldpass_example'; // string | The old password of the authenticated user.
$newpass = 'newpass_example'; // string | The new password of the authenticated user.

try {
    $apiInstance->userchangepwd($token, $oldpass, $newpass);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userchangepwd: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **oldpass** | [**string**](../Model/.md)| The old password of the authenticated user. |
 **newpass** | [**string**](../Model/.md)| The new password of the authenticated user. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userchangepwdbyreq

> userchangepwdbyreq($changereq, $newpass)

Changes the user password using a change password request id

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$changereq = 'changereq_example'; // string | The change password request ID sent by email to the user.
$newpass = 'newpass_example'; // string | The new password of the user.

try {
    $apiInstance->userchangepwdbyreq($changereq, $newpass);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userchangepwdbyreq: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userdelete

> userdelete($token, $id)

Delete a user

Allows the user to delete a user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the user to delete.

try {
    $apiInstance->userdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the user to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userfindsimilar

> userfindsimilar($token, $currentid, $phonenumber, $cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$currentid = 'currentid_example'; // string | The id of the current user.
$phonenumber = 'phonenumber_example'; // string | A phone number to search for similar users.
$cardnumber = 'cardnumber_example'; // string | A card number to search for similar users.

try {
    $apiInstance->userfindsimilar($token, $currentid, $phonenumber, $cardnumber);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userfindsimilar: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **currentid** | [**string**](../Model/.md)| The id of the current user. | [optional]
 **phonenumber** | **string**| A phone number to search for similar users. | [optional]
 **cardnumber** | **string**| A card number to search for similar users. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userget

> userget($token, $id, $photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the user to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->userget($token, $id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the user to get. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergetbycard

> usergetbycard($token, $card, $photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$card = 'card_example'; // string | The card number of the user to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->usergetbycard($token, $card, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergetbycard: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergroupaddmember

> usergroupaddmember($token, $userid, $groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to add.
$groupid = 'groupid_example'; // string | The id of the group.

try {
    $apiInstance->usergroupaddmember($token, $userid, $groupid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergroupaddmember: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **groupid** | [**string**](../Model/.md)| The id of the group. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergroupdelete

> usergroupdelete($token, $id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the group to delete.

try {
    $apiInstance->usergroupdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergroupdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the group to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergroupget

> usergroupget($token, $id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the user group to get.

try {
    $apiInstance->usergroupget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergroupget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the user group to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergroupgetmembers

> usergroupgetmembers($token, $groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$groupid = 'groupid_example'; // string | The id of the user group to get.

try {
    $apiInstance->usergroupgetmembers($token, $groupid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergroupgetmembers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **groupid** | [**string**](../Model/.md)| The id of the user group to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergroupgetuser

> usergroupgetuser($token, $userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to get his groups.

try {
    $apiInstance->usergroupgetuser($token, $userid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergroupgetuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to get his groups. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergrouplist

> usergrouplist($token, $from, $count, $type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$type = 'type_example'; // string | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.

try {
    $apiInstance->usergrouplist($token, $from, $count, $type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergrouplist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergrouprefresh

> usergrouprefresh($token, $group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$group = 'group_example'; // string | The ID of the group to refresh.

try {
    $apiInstance->usergrouprefresh($token, $group);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergrouprefresh: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **group** | [**string**](../Model/.md)| The ID of the group to refresh. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergroupremovemember

> usergroupremovemember($token, $userid, $groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$userid = 'userid_example'; // string | The id of the user to remove.
$groupid = 'groupid_example'; // string | The id of the group.

try {
    $apiInstance->usergroupremovemember($token, $userid, $groupid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergroupremovemember: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **groupid** | [**string**](../Model/.md)| The id of the group. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergroupsave

> usergroupsave($unknown_base_type)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->usergroupsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergroupsave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergrouptagmembers

> usergrouptagmembers($token, $group, $tags)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$group = 'group_example'; // string | The id of the group to save whose members have to be tagged.
$tags = 'tags_example'; // string | The tags to assign to the members of the specified group, in JSON format.

try {
    $apiInstance->usergrouptagmembers($token, $group, $tags);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergrouptagmembers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **group** | [**string**](../Model/.md)| The id of the group to save whose members have to be tagged. |
 **tags** | **string**| The tags to assign to the members of the specified group, in JSON format. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usergroupuntagmembers

> usergroupuntagmembers($token, $group, $tags)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$group = 'group_example'; // string | The id of the group to save whose members have to be untagged.
$tags = 'tags_example'; // string | The tags to unassign from the members of the specified group, in JSON format.

try {
    $apiInstance->usergroupuntagmembers($token, $group, $tags);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usergroupuntagmembers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **group** | [**string**](../Model/.md)| The id of the group to save whose members have to be untagged. |
 **tags** | **string**| The tags to unassign from the members of the specified group, in JSON format. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userlist

> userlist($token, $from, $count, $roleid, $onlywithoutcard, $photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$roleid = 'roleid_example'; // string | The id of the role to filter users by, or empty to return all users.
$onlywithoutcard = 'onlywithoutcard_example'; // string | If is 1 then only the users without a card are returned, otherwise all users are returned.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->userlist($token, $from, $count, $roleid, $onlywithoutcard, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **roleid** | [**string**](../Model/.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userloadphoto

> userloadphoto($token, $upload, $filename, $userid, $automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$upload = 'upload_example'; // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
$filename = 'filename_example'; // string | The local name of the uploaded file. For later reference.
$userid = 'userid_example'; // string | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
$automatch = True; // bool | Set this to true to find the specific user based on the file name.

try {
    $apiInstance->userloadphoto($token, $upload, $filename, $userid, $automatch);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userloadphoto: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional]
 **userid** | [**string**](../Model/.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional]
 **automatch** | **bool**| Set this to true to find the specific user based on the file name. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usermovedata

> usermovedata($token, $source, $destination)

Move data between users

Allows administrators to move data between users.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$source = 'source_example'; // string | The id of the user that is the source of the data.
$destination = 'destination_example'; // string | The id of the user that is the destination of the data.

try {
    $apiInstance->usermovedata($token, $source, $destination);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usermovedata: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **source** | [**string**](../Model/.md)| The id of the user that is the source of the data. |
 **destination** | [**string**](../Model/.md)| The id of the user that is the destination of the data. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userprofiledelete

> userprofiledelete($token, $id)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the user profile to delete.

try {
    $apiInstance->userprofiledelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userprofiledelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the user profile to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userprofileget

> userprofileget($token, $id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the profile question set.

try {
    $apiInstance->userprofileget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userprofileget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the profile question set. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userprofilegetallview

> userprofilegetallview($token, $id)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the user to view, or empty for current user.

try {
    $apiInstance->userprofilegetallview($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userprofilegetallview: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the user to view, or empty for current user. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userprofilelist

> userprofilelist($token, $from, $count)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->userprofilelist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userprofilelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userprofilelistquestions

> userprofilelistquestions($token)

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->userprofilelistquestions($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userprofilelistquestions: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userprofilepreparestats

> userprofilepreparestats($token, $params)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$params = 'params_example'; // string | The ID of the group, specified as 'group=...'

try {
    $apiInstance->userprofilepreparestats($token, $params);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userprofilepreparestats: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userprofilesave

> userprofilesave($unknown_base_type)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->userprofilesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userprofilesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userprofilesaveanswers

> userprofilesaveanswers($unknown_base_type)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->userprofilesaveanswers($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userprofilesaveanswers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## userrequestpwdchange

> userrequestpwdchange($domain, $email)

Requests a password change

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$domain = 'domain_example'; // string | The domain of the account where the user exists.
$email = 'email_example'; // string | The email of the user.

try {
    $apiInstance->userrequestpwdchange($domain, $email);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->userrequestpwdchange: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usersave

> usersave($unknown_base_type)

Create or edit a user

Allows the user to create or edit a user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->usersave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usersave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usersavepwdchange

> usersavepwdchange($unknown_base_type)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->usersavepwdchange($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usersavepwdchange: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usersettingsget

> usersettingsget($token, $keys, $user)

Lists available user settings

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$keys = 'keys_example'; // string | Setting key to get. Can be multiple separated by commas.
$user = 'user_example'; // string | The user id whose settings have to be returned.

try {
    $apiInstance->usersettingsget($token, $keys, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usersettingsget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. |
 **user** | [**string**](../Model/.md)| The user id whose settings have to be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usersettingsgetmultiple

> usersettingsgetmultiple($token, $keys, $user)

Get multiple user settings

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$keys = 'keys_example'; // string | Setting key to get. Can be multiple separated by commas.
$user = 'user_example'; // string | The user id whose settings have to be returned.

try {
    $apiInstance->usersettingsgetmultiple($token, $keys, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usersettingsgetmultiple: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. |
 **user** | [**string**](../Model/.md)| The user id whose settings have to be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usersettingssave

> usersettingssave($unknown_base_type)

Saves a user setting

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->usersettingssave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usersettingssave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## usersettingssavemultiple

> usersettingssavemultiple($unknown_base_type)

Save multiple user settings at once

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->usersettingssavemultiple($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->usersettingssavemultiple: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## version

> version($token)

Get current version information

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->version($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->version: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## virtuallineaddmyself

> virtuallineaddmyself($token, $waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$waitinglineid = 'waitinglineid_example'; // string | ID of the waiting line to join.

try {
    $apiInstance->virtuallineaddmyself($token, $waitinglineid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->virtuallineaddmyself: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **waitinglineid** | [**string**](../Model/.md)| ID of the waiting line to join. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## virtuallinelist

> virtuallinelist($token)

Lists waiting lines that have remote access enabled

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->virtuallinelist($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->virtuallinelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## virtuallineremovemyself

> virtuallineremovemyself($token)

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.

try {
    $apiInstance->virtuallineremovemyself($token);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->virtuallineremovemyself: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglineadduser

> waitinglineadduser($station, $user, $locationid, $time, $signinrole, $roleid, $services, $eventid, $staff, $photosize)

Put user in a waiting line

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station.
$user = 'user_example'; // string | The user's card number.
$locationid = 'locationid_example'; // string | The location's id where the swipe must be saved.
$time = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time of the swipe.
$signinrole = 'signinrole_example'; // string | Specifies if the sign-in is for an attendee or a staff member
$roleid = 'roleid_example'; // string | Specifies the role the user has selected in order to sign-in
$services = 'services_example'; // string | The services ids the user has selected.
$eventid = 'eventid_example'; // string | The id of the event the user selected.
$staff = 'staff_example'; // string | The id of the staff member the user selected.
$photosize = 56; // int | The swiping user's photo size.

try {
    $apiInstance->waitinglineadduser($station, $user, $locationid, $time, $signinrole, $roleid, $services, $eventid, $staff, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->waitinglineadduser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station. |
 **user** | **string**| The user&#39;s card number. |
 **locationid** | [**string**](../Model/.md)| The location&#39;s id where the swipe must be saved. | [optional]
 **time** | **\DateTime**| The date and time of the swipe. | [optional]
 **signinrole** | **string**| Specifies if the sign-in is for an attendee or a staff member | [optional]
 **roleid** | [**string**](../Model/.md)| Specifies the role the user has selected in order to sign-in | [optional]
 **services** | **string**| The services ids the user has selected. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event the user selected. | [optional]
 **staff** | [**string**](../Model/.md)| The id of the staff member the user selected. | [optional]
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglinedelete

> waitinglinedelete($token, $id)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the line to delete.

try {
    $apiInstance->waitinglinedelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->waitinglinedelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the line to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglineget

> waitinglineget($token, $id, $photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the waiting line to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->waitinglineget($token, $id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->waitinglineget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the waiting line to get. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglineisuserin

> waitinglineisuserin($station, $time, $user, $location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station.
$time = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time of the swipe.
$user = 'user_example'; // string | The card number of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->waitinglineisuserin($station, $time, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->waitinglineisuserin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station. |
 **time** | **\DateTime**| The date and time of the swipe. |
 **user** | **string**| The card number of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglinelist

> waitinglinelist($token, $from, $count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->waitinglinelist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->waitinglinelist: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglineremoveuser

> waitinglineremoveuser($token, $waitingline, $itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$waitingline = 'waitingline_example'; // string | The id of the waiting line whose item has to be removed.
$itemid = 'itemid_example'; // string | The ID of the item that has to be removed.

try {
    $apiInstance->waitinglineremoveuser($token, $waitingline, $itemid);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->waitinglineremoveuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **waitingline** | [**string**](../Model/.md)| The id of the waiting line whose item has to be removed. |
 **itemid** | [**string**](../Model/.md)| The ID of the item that has to be removed. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglinesave

> waitinglinesave($unknown_base_type)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->waitinglinesave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->waitinglinesave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglinesigninuser

> waitinglinesigninuser($token, $waitingline, $itemid, $staff, $photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$waitingline = 'waitingline_example'; // string | The id of the waiting line whose item needs to be signed-in.
$itemid = 'itemid_example'; // string | The ID of the item that has to be signed-in.
$staff = 'staff_example'; // string | The id of the staff member selected to sign-in.
$photosize = 56; // int | The swiping user's photo size.

try {
    $apiInstance->waitinglinesigninuser($token, $waitingline, $itemid, $staff, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->waitinglinesigninuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **waitingline** | [**string**](../Model/.md)| The id of the waiting line whose item needs to be signed-in. |
 **itemid** | [**string**](../Model/.md)| The ID of the item that has to be signed-in. |
 **staff** | [**string**](../Model/.md)| The id of the staff member selected to sign-in. |
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

