# DefaultApi

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


<a name="actionassignmentdelete"></a>
# **actionassignmentdelete**
> actionassignmentdelete(token, id)

Remove an action item from an action plan

Allows a user to remove an action item from a user&#39;s action plan.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action assignment to delete.
try {
    apiInstance.actionassignmentdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the action assignment to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentget"></a>
# **actionassignmentget**
> actionassignmentget(token, id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action assignment to get.
try {
    apiInstance.actionassignmentget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the action assignment to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentlist"></a>
# **actionassignmentlist**
> actionassignmentlist(token, from, count, assignee, status)

View a list of action items in a user&#39;s plan

Allows the user to view the list of all action items for a specified user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val assignee : kotlin.Int = 56 // kotlin.Int | The assignee's id to filter the assignments.
val status : kotlin.Int = 56 // kotlin.Int | The status to filter the assignments.
try {
    apiInstance.actionassignmentlist(token, from, count, assignee, status)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **assignee** | **kotlin.Int**| The assignee&#39;s id to filter the assignments. | [optional]
 **status** | **kotlin.Int**| The status to filter the assignments. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentlisthistory"></a>
# **actionassignmentlisthistory**
> actionassignmentlisthistory(token, actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val actionassignment : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The action assignment's id whose history the user wants to get.
try {
    apiInstance.actionassignmentlisthistory(token, actionassignment)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentlisthistory")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentlisthistory")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **actionassignment** | [**java.util.UUID**](.md)| The action assignment&#39;s id whose history the user wants to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentlistmine"></a>
# **actionassignmentlistmine**
> actionassignmentlistmine(token, from, count, status)

List public action assignments assigned to the logged user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val status : kotlin.Int = 56 // kotlin.Int | The status to filter the assignments.
try {
    apiInstance.actionassignmentlistmine(token, from, count, status)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentlistmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentlistmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **status** | **kotlin.Int**| The status to filter the assignments. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentlistpublichistory"></a>
# **actionassignmentlistpublichistory**
> actionassignmentlistpublichistory(token, actionassignment)

List public action assignment history

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val actionassignment : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The action assignment's id whose history the user wants to get.
try {
    apiInstance.actionassignmentlistpublichistory(token, actionassignment)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentlistpublichistory")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentlistpublichistory")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **actionassignment** | [**java.util.UUID**](.md)| The action assignment&#39;s id whose history the user wants to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentmarkcomplete"></a>
# **actionassignmentmarkcomplete**
> actionassignmentmarkcomplete(token, item, assignee, group, notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val item : kotlin.String = item_example // kotlin.String | The action item to assign.
val assignee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The assignee of the item.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The group to assing the item.
val notes : kotlin.String = notes_example // kotlin.String | The assignment's notes.
try {
    apiInstance.actionassignmentmarkcomplete(token, item, assignee, group, notes)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentmarkcomplete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentmarkcomplete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **item** | **kotlin.String**| The action item to assign. |
 **assignee** | [**java.util.UUID**](.md)| The assignee of the item. | [optional]
 **group** | [**java.util.UUID**](.md)| The group to assing the item. | [optional]
 **notes** | **kotlin.String**| The assignment&#39;s notes. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentsave"></a>
# **actionassignmentsave**
> actionassignmentsave(UNKNOWN_BASE_TYPE)

Add an action item to a user&#39;s action plan

Allows the user to edit or assign an action item to a user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actionassignmentsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="actionassignmentsavehistory"></a>
# **actionassignmentsavehistory**
> actionassignmentsavehistory(UNKNOWN_BASE_TYPE)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actionassignmentsavehistory(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionassignmentsavehistory")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionassignmentsavehistory")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="actionitemdelete"></a>
# **actionitemdelete**
> actionitemdelete(token, id)

Delete an action item

Allows the user to delete an action item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action item to delete.
try {
    apiInstance.actionitemdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionitemdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionitemdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the action item to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionitemget"></a>
# **actionitemget**
> actionitemget(token, id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action item to get.
try {
    apiInstance.actionitemget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionitemget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionitemget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the action item to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionitemlist"></a>
# **actionitemlist**
> actionitemlist(token, from, count)

View a list of action items

Allows the user to view a list of action items

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.actionitemlist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionitemlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionitemlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionitemsave"></a>
# **actionitemsave**
> actionitemsave(UNKNOWN_BASE_TYPE)

Create or edit an action item

Allows the user to edit an action item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actionitemsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionitemsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionitemsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="actionloglist"></a>
# **actionloglist**
> actionloglist(token, from, count, user, startdate, enddate, resource, actionfilter, argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user whose action logs have to be returned.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the logs.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the logs.
val resource : kotlin.String = resource_example // kotlin.String | The resource to filter the action logs.
val actionfilter : kotlin.String = actionfilter_example // kotlin.String | The action to filter the action logs.
val argument : kotlin.String = argument_example // kotlin.String | The id of the entity that was the argument of the executed action.
try {
    apiInstance.actionloglist(token, from, count, user, startdate, enddate, resource, actionfilter, argument)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionloglist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionloglist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **user** | [**java.util.UUID**](.md)| The id of the user whose action logs have to be returned. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the logs. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the logs. | [optional]
 **resource** | **kotlin.String**| The resource to filter the action logs. | [optional]
 **actionfilter** | **kotlin.String**| The action to filter the action logs. | [optional]
 **argument** | **kotlin.String**| The id of the entity that was the argument of the executed action. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionpackassign"></a>
# **actionpackassign**
> actionpackassign(token, pack, itemsdata, assignee, group, notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val pack : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action pack to assign.
val itemsdata : kotlin.Boolean = true // kotlin.Boolean | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
val assignee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The assignee of the pack.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The group to assign the pack.
val notes : kotlin.String = notes_example // kotlin.String | The assignment's notes.
try {
    apiInstance.actionpackassign(token, pack, itemsdata, assignee, group, notes)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionpackassign")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionpackassign")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **pack** | [**java.util.UUID**](.md)| The id of the action pack to assign. |
 **itemsdata** | **kotlin.Boolean**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). |
 **assignee** | [**java.util.UUID**](.md)| The assignee of the pack. | [optional]
 **group** | [**java.util.UUID**](.md)| The group to assign the pack. | [optional]
 **notes** | **kotlin.String**| The assignment&#39;s notes. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionpackdelete"></a>
# **actionpackdelete**
> actionpackdelete(token, id)

Delete an action item pack

Allows the user to delete an action item pack.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action pack to delete.
try {
    apiInstance.actionpackdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionpackdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionpackdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the action pack to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionpackget"></a>
# **actionpackget**
> actionpackget(token, id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action pack to get.
try {
    apiInstance.actionpackget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionpackget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionpackget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the action pack to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionpacklist"></a>
# **actionpacklist**
> actionpacklist(token, from, count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.actionpacklist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionpacklist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionpacklist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionpacksave"></a>
# **actionpacksave**
> actionpacksave(UNKNOWN_BASE_TYPE)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actionpacksave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actionpacksave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actionpacksave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="actiontypedelete"></a>
# **actiontypedelete**
> actiontypedelete(token, id)

Delete an action item type

Allows the user to delete an action item type.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action type to delete.
try {
    apiInstance.actiontypedelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actiontypedelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actiontypedelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the action type to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actiontypeget"></a>
# **actiontypeget**
> actiontypeget(token, id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action type to get.
try {
    apiInstance.actiontypeget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actiontypeget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actiontypeget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the action type to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actiontypelist"></a>
# **actiontypelist**
> actiontypelist(token, from, count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.actiontypelist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actiontypelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actiontypelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actiontypesave"></a>
# **actiontypesave**
> actiontypesave(UNKNOWN_BASE_TYPE)

Create or edit an action item type

Allows the user to dit an action item type.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actiontypesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#actiontypesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#actiontypesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="adhocquerycheckexecution"></a>
# **adhocquerycheckexecution**
> adhocquerycheckexecution(token, id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query&#39;s execution page.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the ad hoc query execution to be checked.
try {
    apiInstance.adhocquerycheckexecution(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocquerycheckexecution")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocquerycheckexecution")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the ad hoc query execution to be checked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocquerydelete"></a>
# **adhocquerydelete**
> adhocquerydelete(token, id)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the ad hoc query to delete.
try {
    apiInstance.adhocquerydelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocquerydelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocquerydelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the ad hoc query to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocqueryexecute"></a>
# **adhocqueryexecute**
> adhocqueryexecute(token, id, query)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the query to execute.
val query : kotlin.String = query_example // kotlin.String | The query to execute.
try {
    apiInstance.adhocqueryexecute(token, id, query)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocqueryexecute")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocqueryexecute")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the query to execute. | [optional]
 **query** | **kotlin.String**| The query to execute. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocqueryget"></a>
# **adhocqueryget**
> adhocqueryget(token, id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the query to get.
try {
    apiInstance.adhocqueryget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocqueryget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocqueryget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the query to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocquerygetschema"></a>
# **adhocquerygetschema**
> adhocquerygetschema(token)

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.adhocquerygetschema(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocquerygetschema")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocquerygetschema")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocquerylist"></a>
# **adhocquerylist**
> adhocquerylist(token, from, count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.adhocquerylist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocquerylist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocquerylist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocquerylistexecutions"></a>
# **adhocquerylistexecutions**
> adhocquerylistexecutions(token, from, count, query)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val query : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The first record to return.
try {
    apiInstance.adhocquerylistexecutions(token, from, count, query)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocquerylistexecutions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocquerylistexecutions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **query** | [**java.util.UUID**](.md)| The first record to return. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocquerysave"></a>
# **adhocquerysave**
> adhocquerysave(UNKNOWN_BASE_TYPE)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.adhocquerysave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocquerysave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocquerysave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="adhocquerystopexecution"></a>
# **adhocquerystopexecution**
> adhocquerystopexecution(token, id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the ad hoc query execution to be stopped.
try {
    apiInstance.adhocquerystopexecution(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocquerystopexecution")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocquerystopexecution")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the ad hoc query execution to be stopped. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocreportsreqaccess"></a>
# **adhocreportsreqaccess**
> adhocreportsreqaccess(token)

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, &#39;Request Access&#39; under Institutional Research -&gt; Ad-hoc Reports

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.adhocreportsreqaccess(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#adhocreportsreqaccess")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#adhocreportsreqaccess")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationcheckunknownuser"></a>
# **advancedstationcheckunknownuser**
> advancedstationcheckunknownuser(station, user, location)

Check whether the user is known by the system.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.advancedstationcheckunknownuser(station, user, location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationcheckunknownuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationcheckunknownuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationcheckuserrole"></a>
# **advancedstationcheckuserrole**
> advancedstationcheckuserrole(station, user, location)

Check whether the user is a staff member, an attendee or both.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.advancedstationcheckuserrole(station, user, location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationcheckuserrole")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationcheckuserrole")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationcreateuser"></a>
# **advancedstationcreateuser**
> advancedstationcreateuser(station, user, location, firstname, lastname, email, middlename)

Creates a user via a sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user to create.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
val firstname : kotlin.String = firstname_example // kotlin.String | The first name of the user to create.
val lastname : kotlin.String = lastname_example // kotlin.String | The last name of the user to create.
val email : kotlin.String = email_example // kotlin.String | The email of the user to create.
val middlename : kotlin.String = middlename_example // kotlin.String | The middle name of the user to create.
try {
    apiInstance.advancedstationcreateuser(station, user, location, firstname, lastname, email, middlename)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationcreateuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationcreateuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user to create. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. |
 **firstname** | **kotlin.String**| The first name of the user to create. |
 **lastname** | **kotlin.String**| The last name of the user to create. |
 **email** | **kotlin.String**| The email of the user to create. |
 **middlename** | **kotlin.String**| The middle name of the user to create. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationgetevents"></a>
# **advancedstationgetevents**
> advancedstationgetevents(station, location, user)

Gets the courses available for a specific location and a specific student.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the student picked.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.advancedstationgetevents(station, location, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationgetevents")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationgetevents")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **location** | [**java.util.UUID**](.md)| The id of the location the student picked. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationgetinfo"></a>
# **advancedstationgetinfo**
> advancedstationgetinfo(id, event)

Gets the info to display in the sign-in station by it&#39;s ID.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event (or session), to override the scheduled one.
try {
    apiInstance.advancedstationgetinfo(id, event)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationgetinfo")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationgetinfo")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **event** | [**java.util.UUID**](.md)| The id of the event (or session), to override the scheduled one. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationgetlocations"></a>
# **advancedstationgetlocations**
> advancedstationgetlocations(station, user)

Gets the locations available in a sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station whose locations have to be returned.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.advancedstationgetlocations(station, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationgetlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationgetlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station whose locations have to be returned. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationgetlogstaff"></a>
# **advancedstationgetlogstaff**
> advancedstationgetlogstaff(station, attendancelog, photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val attendancelog : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to filter the staff members.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.advancedstationgetlogstaff(station, attendancelog, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationgetlogstaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationgetlogstaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **attendancelog** | [**java.util.UUID**](.md)| The id of the attendance log to filter the staff members. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationgetroles"></a>
# **advancedstationgetroles**
> advancedstationgetroles(station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val signinrole : kotlin.String = signinrole_example // kotlin.String | Specifies how the user is signing-in.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.advancedstationgetroles(station, signinrole, user, location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationgetroles")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationgetroles")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **signinrole** | **kotlin.String**| Specifies how the user is signing-in. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationgetservices"></a>
# **advancedstationgetservices**
> advancedstationgetservices(station, location, user)

Gets the services available for a specific location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the student picked.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.advancedstationgetservices(station, location, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationgetservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationgetservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **location** | [**java.util.UUID**](.md)| The id of the location the student picked. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationgetstaff"></a>
# **advancedstationgetstaff**
> advancedstationgetstaff(station, locationid, user, services, eventid, photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the student picked.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val services : kotlin.String = services_example // kotlin.String | The list of services selected by the user, in JSON format.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the event selected.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.advancedstationgetstaff(station, locationid, user, services, eventid, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationgetstaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationgetstaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **locationid** | [**java.util.UUID**](.md)| The id of the location the student picked. |
 **user** | **kotlin.String**| The card of the user. |
 **services** | **kotlin.String**| The list of services selected by the user, in JSON format. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The ID of the event selected. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationissignedin"></a>
# **advancedstationissignedin**
> advancedstationissignedin(station, time, user, location)

Gets whether a user is signed-in or not.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val time : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time of the swipe.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.advancedstationissignedin(station, time, user, location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advancedstationissignedin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advancedstationissignedin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **time** | **java.time.OffsetDateTime**| The date and time of the swipe. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleaddmissing"></a>
# **advroleaddmissing**
> advroleaddmissing(token, roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val roles : kotlin.String = roles_example // kotlin.String | CSV list of the role ids to check
val permissions : kotlin.String = permissions_example // kotlin.String | CSV list of the permissions to check
try {
    apiInstance.advroleaddmissing(token, roles, permissions)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advroleaddmissing")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advroleaddmissing")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **roles** | **kotlin.String**| CSV list of the role ids to check |
 **permissions** | **kotlin.String**| CSV list of the permissions to check |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advrolecheckperm"></a>
# **advrolecheckperm**
> advrolecheckperm(token, roles, permissions)

Checks the permissions are assigned for the given roles

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val roles : kotlin.String = roles_example // kotlin.String | CSV list of the role ids to check
val permissions : kotlin.String = permissions_example // kotlin.String | CSV list of the permissions to check
try {
    apiInstance.advrolecheckperm(token, roles, permissions)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advrolecheckperm")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advrolecheckperm")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **roles** | **kotlin.String**| CSV list of the role ids to check |
 **permissions** | **kotlin.String**| CSV list of the permissions to check |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroledelete"></a>
# **advroledelete**
> advroledelete(token, id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to delete.
try {
    apiInstance.advroledelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advroledelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advroledelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the location to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroledeletemapping"></a>
# **advroledeletemapping**
> advroledeletemapping(token, map, roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val map : kotlin.String = map_example // kotlin.String | The map name to save the role.
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the role.
try {
    apiInstance.advroledeletemapping(token, map, roleid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advroledeletemapping")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advroledeletemapping")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **map** | **kotlin.String**| The map name to save the role. |
 **roleid** | [**java.util.UUID**](.md)| The id of the role. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleget"></a>
# **advroleget**
> advroleget(token, id)

View details of a role

Allows the user to view a role and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to get.
try {
    apiInstance.advroleget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advroleget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advroleget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the location to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advrolelist"></a>
# **advrolelist**
> advrolelist(token, includepolicies, includeinternal, name)

Lists the roles for the current account

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val includepolicies : kotlin.Boolean = true // kotlin.Boolean | True to include the policies, defaults to false.
val includeinternal : kotlin.Boolean = true // kotlin.Boolean | True to include the internal roles too.
val name : kotlin.String = name_example // kotlin.String | Filter by name of the role.
try {
    apiInstance.advrolelist(token, includepolicies, includeinternal, name)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advrolelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advrolelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **includepolicies** | **kotlin.Boolean**| True to include the policies, defaults to false. | [optional]
 **includeinternal** | **kotlin.Boolean**| True to include the internal roles too. | [optional]
 **name** | **kotlin.String**| Filter by name of the role. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advrolelistmaps"></a>
# **advrolelistmaps**
> advrolelistmaps(token, roleid)

Lists the maps a roles is mapped to

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the role to list the maps.
try {
    apiInstance.advrolelistmaps(token, roleid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advrolelistmaps")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advrolelistmaps")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **roleid** | [**java.util.UUID**](.md)| The id of the role to list the maps. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advrolelistrolesmapped"></a>
# **advrolelistrolesmapped**
> advrolelistrolesmapped(token, map)

Lists the roles mappings

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val map : kotlin.String = map_example // kotlin.String | List only the roles in the specified map.
try {
    apiInstance.advrolelistrolesmapped(token, map)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advrolelistrolesmapped")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advrolelistrolesmapped")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **map** | **kotlin.String**| List only the roles in the specified map. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advrolelisttemplates"></a>
# **advrolelisttemplates**
> advrolelisttemplates(token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.advrolelisttemplates(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advrolelisttemplates")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advrolelisttemplates")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advrolesave"></a>
# **advrolesave**
> advrolesave(UNKNOWN_BASE_TYPE)

Create or edit a role

Allows the user to create or edit a role&#39;s permissions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.advrolesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advrolesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advrolesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="advrolesavemapping"></a>
# **advrolesavemapping**
> advrolesavemapping(UNKNOWN_BASE_TYPE)

Saves a role mapping

Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.advrolesavemapping(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advrolesavemapping")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advrolesavemapping")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="advrolesuserlist"></a>
# **advrolesuserlist**
> advrolesuserlist(token, from, count, roleid, onlywithoutcard, photosize)

List users. Alias to user.list, use that one instead.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the role to filter users by, or empty to return all users.
val onlywithoutcard : kotlin.String = onlywithoutcard_example // kotlin.String | If is 1 then only the users without a card are returned, otherwise all users are returned.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.advrolesuserlist(token, from, count, roleid, onlywithoutcard, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advrolesuserlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advrolesuserlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **roleid** | [**java.util.UUID**](.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **kotlin.String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleuserupgrade"></a>
# **advroleuserupgrade**
> advroleuserupgrade(token, userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the user to upgrade
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the role to add
try {
    apiInstance.advroleuserupgrade(token, userid, roleid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#advroleuserupgrade")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#advroleuserupgrade")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| Id of the user to upgrade |
 **roleid** | [**java.util.UUID**](.md)| Id of the role to add |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentcancel"></a>
# **appointmentcancel**
> appointmentcancel(token, id)

Cancel an appointment

Allows the user to cancel an appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to cancel.
try {
    apiInstance.appointmentcancel(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentcancel")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentcancel")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to cancel. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentcheckisvalid"></a>
# **appointmentcheckisvalid**
> appointmentcheckisvalid(token, id, editing)

Check if an appointment is valid or not

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to check.
val editing : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the check is for a new appointment or an existing one.
try {
    apiInstance.appointmentcheckisvalid(token, id, editing)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentcheckisvalid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentcheckisvalid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to check. |
 **editing** | **kotlin.Boolean**| Specifies whether the check is for a new appointment or an existing one. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmenteditanyway"></a>
# **appointmenteditanyway**
> appointmenteditanyway(token, id, attendee, staff, location, start, end, term, event, services, notes)

Edit an appointment even if it breaks activated rules

Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
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
    apiInstance.appointmenteditanyway(token, id, attendee, staff, location, start, end, term, event, services, notes)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmenteditanyway")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmenteditanyway")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmenteditpresence"></a>
# **appointmenteditpresence**
> appointmenteditpresence(token, id, showedup)

Edit the no-show status of an appointment

Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to edit its presence.
val showedup : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the attendee was showed-up or not in the appointment.
try {
    apiInstance.appointmenteditpresence(token, id, showedup)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmenteditpresence")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmenteditpresence")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to edit its presence. |
 **showedup** | **kotlin.Boolean**| Specifies whether the attendee was showed-up or not in the appointment. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentfindallstaffslots"></a>
# **appointmentfindallstaffslots**
> appointmentfindallstaffslots(token, starttime, endtime, serviceids, locationid, eventid, photosize)

Finds all staff available slots filtered by service, date, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service Ids to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.appointmentfindallstaffslots(token, starttime, endtime, serviceids, locationid, eventid, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentfindallstaffslots")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentfindallstaffslots")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **serviceids** | **kotlin.String**| CSV list of the service Ids to filter by. |
 **locationid** | [**java.util.UUID**](.md)| The id of the service to filter by. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentfindslots"></a>
# **appointmentfindslots**
> appointmentfindslots(token, staffid, starttime, endtime, serviceids, eventid, locationid)

Finds available slots filtered by service, date, staff, etc

Allows the user to view available appointment slots when creating an appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val staffid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff to filter by.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service Ids to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
try {
    apiInstance.appointmentfindslots(token, staffid, starttime, endtime, serviceids, eventid, locationid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentfindslots")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentfindslots")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **staffid** | [**java.util.UUID**](.md)| The id of the staff to filter by. |
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **serviceids** | **kotlin.String**| CSV list of the service Ids to filter by. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**java.util.UUID**](.md)| The id of the service to filter by. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentfindstaff"></a>
# **appointmentfindstaff**
> appointmentfindstaff(token, serviceids, starttime, endtime, eventid, locationid, photosize)

Finds staff available by service, date, event, etc

Allows the user to view staff availability when creating an appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service ids to filter by.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.appointmentfindstaff(token, serviceids, starttime, endtime, eventid, locationid, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentfindstaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentfindstaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceids** | **kotlin.String**| CSV list of the service ids to filter by. |
 **starttime** | **java.time.OffsetDateTime**| The start time of the range to look for slots. |
 **endtime** | **java.time.OffsetDateTime**| The end time of the range to look for slots. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event to filter by. | [optional]
 **locationid** | [**java.util.UUID**](.md)| The id of the service to filter by. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentget"></a>
# **appointmentget**
> appointmentget(token, id)

Search and view details of an appointment

Allows the user to view an individual appointment and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to get.
try {
    apiInstance.appointmentget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentgetcurrent"></a>
# **appointmentgetcurrent**
> appointmentgetcurrent(station, user, location)

Get the current appointments for the user that is about to sign-in via the specified sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location where the user wants to sign-in.
try {
    apiInstance.appointmentgetcurrent(station, user, location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentgetcurrent")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentgetcurrent")
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

<a name="appointmentgetlocations"></a>
# **appointmentgetlocations**
> appointmentgetlocations(token, serviceid)

Find locations where a service is available

Allows the user to search for appointment availability by location or service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to get its locations.
try {
    apiInstance.appointmentgetlocations(token, serviceid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentgetlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentgetlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to get its locations. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentlist"></a>
# **appointmentlist**
> appointmentlist(token, from, count, startdate, enddate, userid)

View a list of appointments

Allows the user to view all upcoming appointments for the location or locations they are scoped to.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the appointments.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the appointments.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The attendee id to filter the appointments.
try {
    apiInstance.appointmentlist(token, from, count, startdate, enddate, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the appointments. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the appointments. | [optional]
 **userid** | [**java.util.UUID**](.md)| The attendee id to filter the appointments. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentlistmine"></a>
# **appointmentlistmine**
> appointmentlistmine(token, start, modifiedafter)

View all my upcoming appointments

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val start : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only appointments that start after the specified date will be returned.
val modifiedafter : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only appointments modified after the specified date will be returned.
try {
    apiInstance.appointmentlistmine(token, start, modifiedafter)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentlistmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentlistmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **start** | **java.time.OffsetDateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **java.time.OffsetDateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentlistupcoming"></a>
# **appointmentlistupcoming**
> appointmentlistupcoming(token, start, modifiedafter)

Search and view details of all my upcoming appointments

Allows the user to view all of their own upcoming appointments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val start : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only appointments that start after the specified date will be returned.
val modifiedafter : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only appointments modified after the specified date will be returned.
try {
    apiInstance.appointmentlistupcoming(token, start, modifiedafter)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentlistupcoming")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentlistupcoming")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **start** | **java.time.OffsetDateTime**| If specified, only appointments that start after the specified date will be returned. | [optional]
 **modifiedafter** | **java.time.OffsetDateTime**| If specified, only appointments modified after the specified date will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentrescheduleoutlook"></a>
# **appointmentrescheduleoutlook**
> appointmentrescheduleoutlook(token, id, start, end)

Reschedule an appointment from MS Outlook.

Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to edit.
val start : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The appointment's start date & time.
val end : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The appointment's end date & time.
try {
    apiInstance.appointmentrescheduleoutlook(token, id, start, end)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentrescheduleoutlook")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentrescheduleoutlook")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to edit. |
 **start** | **java.time.OffsetDateTime**| The appointment&#39;s start date &amp; time. |
 **end** | **java.time.OffsetDateTime**| The appointment&#39;s end date &amp; time. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentrestore"></a>
# **appointmentrestore**
> appointmentrestore(token, id)

Restore an appointment

Allows the user to restore a canceled appointment.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to restore.
try {
    apiInstance.appointmentrestore(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentrestore")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentrestore")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to restore. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentrestoreanyway"></a>
# **appointmentrestoreanyway**
> appointmentrestoreanyway(token, id)

Restore an appointment even if it breaks activated rules

Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to restore.
try {
    apiInstance.appointmentrestoreanyway(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentrestoreanyway")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentrestoreanyway")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to restore. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentsave"></a>
# **appointmentsave**
> appointmentsave(UNKNOWN_BASE_TYPE)

Schedule an appointment

Allows the user to schedule an appointment within the rules of the location and the availability of staff members.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.appointmentsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="appointmentsetasvalid"></a>
# **appointmentsetasvalid**
> appointmentsetasvalid(token, id)

Schedule an appointment even if it breaks activated rules

Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to set as valid.
try {
    apiInstance.appointmentsetasvalid(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentsetasvalid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentsetasvalid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to set as valid. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentsuggestlocations"></a>
# **appointmentsuggestlocations**
> appointmentsuggestlocations(token)

View the locations with most appointments

Allows the user to view suggestions for the most popular locations in which to make appointments

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.appointmentsuggestlocations(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentsuggestlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentsuggestlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentsuggestservices"></a>
# **appointmentsuggestservices**
> appointmentsuggestservices(token)

View the services with most appointments

Allows the user to view suggestions for the most popular services for which to make appointments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.appointmentsuggestservices(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentsuggestservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentsuggestservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appointmentvoid"></a>
# **appointmentvoid**
> appointmentvoid(token, id)

Void an appointment

Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student&#39;s restrictions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the appointment to cancel.
try {
    apiInstance.appointmentvoid(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appointmentvoid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appointmentvoid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the appointment to cancel. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appsharegetphone"></a>
# **appsharegetphone**
> appsharegetphone(token)

Gets the phone number of the current user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.appsharegetphone(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appsharegetphone")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appsharegetphone")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="appsharesendtext"></a>
# **appsharesendtext**
> appsharesendtext(token, phonenumber)

Sends an SMS with the link to the app

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val phonenumber : kotlin.String = phonenumber_example // kotlin.String | Phone number to where to send the link. Leave empty to the number on file.
try {
    apiInstance.appsharesendtext(token, phonenumber)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#appsharesendtext")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#appsharesendtext")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **phonenumber** | **kotlin.String**| Phone number to where to send the link. Leave empty to the number on file. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogcommentdelete"></a>
# **attendancelogcommentdelete**
> attendancelogcommentdelete(token, id)

Delete a comment on an attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log comment to delete.
try {
    apiInstance.attendancelogcommentdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogcommentdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogcommentdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the attendance log comment to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogcommentget"></a>
# **attendancelogcommentget**
> attendancelogcommentget(token, id)

View a comment on an attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the comment to get.
try {
    apiInstance.attendancelogcommentget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogcommentget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogcommentget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the comment to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogcommentlist"></a>
# **attendancelogcommentlist**
> attendancelogcommentlist(attendancelog, token)

View all the comments on a specific attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val attendancelog : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log whose comments have to be retrieved.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.attendancelogcommentlist(attendancelog, token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogcommentlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogcommentlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**java.util.UUID**](.md)| The id of the attendance log whose comments have to be retrieved. |
 **token** | **kotlin.String**| The authentication token. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogcommentsave"></a>
# **attendancelogcommentsave**
> attendancelogcommentsave(UNKNOWN_BASE_TYPE)

Save a comment on an attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.attendancelogcommentsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogcommentsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogcommentsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="attendancelogdelete"></a>
# **attendancelogdelete**
> attendancelogdelete(token, id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to delete.
try {
    apiInstance.attendancelogdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogget"></a>
# **attendancelogget**
> attendancelogget(token, id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to get.
try {
    apiInstance.attendancelogget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendanceloggetchangehistory"></a>
# **attendanceloggetchangehistory**
> attendanceloggetchangehistory(token, id)

Search and view details of an attendance log&#39;s swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to get.
try {
    apiInstance.attendanceloggetchangehistory(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendanceloggetchangehistory")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendanceloggetchangehistory")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendanceloglist"></a>
# **attendanceloglist**
> attendanceloglist(from, count, token, filter, userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val filter : kotlin.String = filter_example // kotlin.String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user ID of the user to get the logs.
try {
    apiInstance.attendanceloglist(from, count, token, filter, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendanceloglist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendanceloglist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **token** | **kotlin.String**| The authentication token. | [optional]
 **filter** | **kotlin.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]
 **userid** | [**java.util.UUID**](.md)| The user ID of the user to get the logs. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendanceloglistmine"></a>
# **attendanceloglistmine**
> attendanceloglistmine(from, count, token, filter)

Gets the attendance logs of the current user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val filter : kotlin.String = filter_example // kotlin.String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
try {
    apiInstance.attendanceloglistmine(from, count, token, filter)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendanceloglistmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendanceloglistmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **token** | **kotlin.String**| The authentication token. | [optional]
 **filter** | **kotlin.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogliststaff"></a>
# **attendancelogliststaff**
> attendancelogliststaff(from, count, token, filter)

Gets the attendance logs that the current user is involved in as staff

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val filter : kotlin.String = filter_example // kotlin.String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
try {
    apiInstance.attendancelogliststaff(from, count, token, filter)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogliststaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogliststaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **token** | **kotlin.String**| The authentication token. | [optional]
 **filter** | **kotlin.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogsave"></a>
# **attendancelogsave**
> attendancelogsave(UNKNOWN_BASE_TYPE)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.attendancelogsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="attendancelogsignout"></a>
# **attendancelogsignout**
> attendancelogsignout(token, id, location, event, datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who&#39;s In page.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to sign-out.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to filter the users to sign out.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter the users to sign out.
val datetime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | Specifies the date and time when the specified logs have to be signed out.
try {
    apiInstance.attendancelogsignout(token, id, location, event, datetime)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogsignout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogsignout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to sign-out. | [optional]
 **location** | [**java.util.UUID**](.md)| The id of the location to filter the users to sign out. | [optional]
 **event** | [**java.util.UUID**](.md)| The id of the event to filter the users to sign out. | [optional]
 **datetime** | **java.time.OffsetDateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogwhosin"></a>
# **attendancelogwhosin**
> attendancelogwhosin(from, count, token, location, event, sorting, roles, photosize, extensions, export)

View who&#39;s in a location

Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to search for users that are in.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to search for users that are in.
val sorting : kotlin.String = sorting_example // kotlin.String | Field to sort by. Either first-name, last-name or sign-in-time.
val roles : kotlin.String = roles_example // kotlin.String | The comma-separated list of ids of the roles to search for users that are in.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
val extensions : kotlin.String = extensions_example // kotlin.String | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
val export : kotlin.Boolean = true // kotlin.Boolean | True to export the results as CSV
try {
    apiInstance.attendancelogwhosin(from, count, token, location, event, sorting, roles, photosize, extensions, export)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancelogwhosin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancelogwhosin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **token** | **kotlin.String**| The authentication token. | [optional]
 **location** | [**java.util.UUID**](.md)| The id of the location to search for users that are in. | [optional]
 **event** | [**java.util.UUID**](.md)| The id of the event to search for users that are in. | [optional]
 **sorting** | **kotlin.String**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional]
 **roles** | **kotlin.String**| The comma-separated list of ids of the roles to search for users that are in. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **extensions** | **kotlin.String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional]
 **export** | **kotlin.Boolean**| True to export the results as CSV | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancerestrictiondelete"></a>
# **attendancerestrictiondelete**
> attendancerestrictiondelete(token, id)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the restriction to delete.
try {
    apiInstance.attendancerestrictiondelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancerestrictiondelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancerestrictiondelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the restriction to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancerestrictionget"></a>
# **attendancerestrictionget**
> attendancerestrictionget(token, id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the restriction to get.
try {
    apiInstance.attendancerestrictionget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancerestrictionget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancerestrictionget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the restriction to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancerestrictionlist"></a>
# **attendancerestrictionlist**
> attendancerestrictionlist(token, from, count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.attendancerestrictionlist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancerestrictionlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancerestrictionlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancerestrictionsave"></a>
# **attendancerestrictionsave**
> attendancerestrictionsave(UNKNOWN_BASE_TYPE)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.attendancerestrictionsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#attendancerestrictionsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#attendancerestrictionsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="beacondelete"></a>
# **beacondelete**
> beacondelete(token, id)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the beacon to delete.
try {
    apiInstance.beacondelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beacondelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beacondelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the beacon to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beacondisable"></a>
# **beacondisable**
> beacondisable(token)

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.beacondisable(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beacondisable")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beacondisable")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconget"></a>
# **beaconget**
> beaconget(token, id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the beacon to get.
try {
    apiInstance.beaconget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the beacon to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beacongetlocations"></a>
# **beacongetlocations**
> beacongetlocations(token, beacons)

Get the sign-in stations assigned to specific beacons.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val beacons : kotlin.String = beacons_example // kotlin.String | A JSON array containg the beacons data (region, minor and major) values.
try {
    apiInstance.beacongetlocations(token, beacons)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beacongetlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beacongetlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **beacons** | **kotlin.String**| A JSON array containg the beacons data (region, minor and major) values. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beacongetstationlocation"></a>
# **beacongetstationlocation**
> beacongetstationlocation(token, station, location)

Get the location settings in the specified sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station whose location information has to be retrieved.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location whose information has to be retrieved.
try {
    apiInstance.beacongetstationlocation(token, station, location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beacongetstationlocation")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beacongetstationlocation")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station whose location information has to be retrieved. |
 **location** | [**java.util.UUID**](.md)| The id of the location whose information has to be retrieved. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beacongetuuid"></a>
# **beacongetuuid**
> beacongetuuid(token)

View the identifier for the account&#39;s beacon region (for sign-in stations).

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.beacongetuuid(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beacongetuuid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beacongetuuid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconlist"></a>
# **beaconlist**
> beaconlist(token, from, count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.beaconlist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconlistprofiles"></a>
# **beaconlistprofiles**
> beaconlistprofiles(token)

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.beaconlistprofiles(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconlistprofiles")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconlistprofiles")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconresetuuid"></a>
# **beaconresetuuid**
> beaconresetuuid(token)

Generate or reset the identifier for the account&#39;s beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.beaconresetuuid(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconresetuuid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconresetuuid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconsave"></a>
# **beaconsave**
> beaconsave(UNKNOWN_BASE_TYPE)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.beaconsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="beaconscanlocations"></a>
# **beaconscanlocations**
> beaconscanlocations(token, beacons)

Check if there&#39;s location available to sign-in / out.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val beacons : kotlin.String = beacons_example // kotlin.String | A JSON array containg the beacons data (region, minor and major) values.
try {
    apiInstance.beaconscanlocations(token, beacons)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconscanlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconscanlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **beacons** | **kotlin.String**| A JSON array containg the beacons data (region, minor and major) values. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconsetuuid"></a>
# **beaconsetuuid**
> beaconsetuuid(token, id)

Set the identifier for the account&#39;s beacon region (for sign-in stations).

Allows the user to set the identifier for the account&#39;s beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The custom region UUID.
try {
    apiInstance.beaconsetuuid(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconsetuuid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconsetuuid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The custom region UUID. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconsilentregions"></a>
# **beaconsilentregions**
> beaconsilentregions(token)

View all the beacon regions defined for silent tracking

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.beaconsilentregions(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconsilentregions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconsilentregions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconsilentsignin"></a>
# **beaconsilentsignin**
> beaconsilentsignin(token, uuid)

Sign-in silently from the location specified by a beacon

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val uuid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the region the user is in.
try {
    apiInstance.beaconsilentsignin(token, uuid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconsilentsignin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconsilentsignin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **uuid** | [**java.util.UUID**](.md)| The id of the region the user is in. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="beaconsilentsignout"></a>
# **beaconsilentsignout**
> beaconsilentsignout(token, uuid)

Sign-out silently from the location specified by a beacon

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val uuid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the region the user has left.
try {
    apiInstance.beaconsilentsignout(token, uuid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#beaconsilentsignout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#beaconsilentsignout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **uuid** | [**java.util.UUID**](.md)| The id of the region the user has left. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="bgjobgetstatus"></a>
# **bgjobgetstatus**
> bgjobgetstatus(token, jobid, jobtype)

Get background job status

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val jobid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the job to get the status. 10 most recent will be returned if not specified.
val jobtype : kotlin.String = jobtype_example // kotlin.String | The job type to filter by.
try {
    apiInstance.bgjobgetstatus(token, jobid, jobtype)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#bgjobgetstatus")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#bgjobgetstatus")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **jobid** | [**java.util.UUID**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional]
 **jobtype** | **kotlin.String**| The job type to filter by. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="captchagetchallenge"></a>
# **captchagetchallenge**
> captchagetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
try {
    apiInstance.captchagetchallenge()
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#captchagetchallenge")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#captchagetchallenge")
    e.printStackTrace()
}
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

<a name="captchagetimage"></a>
# **captchagetimage**
> captchagetimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val captchatoken : kotlin.String = captchatoken_example // kotlin.String | The captcha token or ID returned by the captcha.getchallenge action
try {
    apiInstance.captchagetimage(captchatoken)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#captchagetimage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#captchagetimage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **kotlin.String**| The captcha token or ID returned by the captcha.getchallenge action |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="changelog"></a>
# **changelog**
> changelog(token)

Get the application change log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.changelog(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#changelog")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#changelog")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="clientget"></a>
# **clientget**
> clientget(token, client, clientname)

Get client

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val client : kotlin.String = client_example // kotlin.String | The unique id of the client.
val clientname : kotlin.String = clientname_example // kotlin.String | The custom name of the client.
try {
    apiInstance.clientget(token, client, clientname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#clientget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#clientget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **client** | **kotlin.String**| The unique id of the client. |
 **clientname** | **kotlin.String**| The custom name of the client. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="clientlist"></a>
# **clientlist**
> clientlist(token, from, count)

Gets the clients of the specified conference

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.clientlist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#clientlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#clientlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="clientsave"></a>
# **clientsave**
> clientsave(UNKNOWN_BASE_TYPE)

Saves a client

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.clientsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#clientsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#clientsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="clientsendmessage"></a>
# **clientsendmessage**
> clientsendmessage(token, uniqueclientid, message)

Send a message to a client

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val uniqueclientid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The unique id of the client.
val message : kotlin.String = message_example // kotlin.String | The body of the message to send.
try {
    apiInstance.clientsendmessage(token, uniqueclientid, message)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#clientsendmessage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#clientsendmessage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **uniqueclientid** | [**java.util.UUID**](.md)| The unique id of the client. |
 **message** | **kotlin.String**| The body of the message to send. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="communityinvite"></a>
# **communityinvite**
> communityinvite(token)

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.communityinvite(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#communityinvite")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#communityinvite")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="communityjoin"></a>
# **communityjoin**
> communityjoin(token)

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.communityjoin(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#communityjoin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#communityjoin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="compasscategorydelete"></a>
# **compasscategorydelete**
> compasscategorydelete(token, id)

Delete a compass category

Allows the user to delete an existing compass category.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the category to delete.
try {
    apiInstance.compasscategorydelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#compasscategorydelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#compasscategorydelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the category to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="compasscategoryget"></a>
# **compasscategoryget**
> compasscategoryget(token, id)

View details of a compass category

Allows the user to view an indvidiaul compass category and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the category to get.
try {
    apiInstance.compasscategoryget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#compasscategoryget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#compasscategoryget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the category to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="compasscategorylist"></a>
# **compasscategorylist**
> compasscategorylist(token, from, count, onlywithservices)

View a list of compass categories

Allows the user to view the full list of compass categories.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val onlywithservices : kotlin.Boolean = true // kotlin.Boolean | Specified whether only categories with services are returned or all.
try {
    apiInstance.compasscategorylist(token, from, count, onlywithservices)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#compasscategorylist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#compasscategorylist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. | [optional]
 **count** | **kotlin.Int**| The max number of records to return. | [optional]
 **onlywithservices** | **kotlin.Boolean**| Specified whether only categories with services are returned or all. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="compasscategorysave"></a>
# **compasscategorysave**
> compasscategorysave(UNKNOWN_BASE_TYPE)

Create or edit a compass category

Allows the user to create or edit a compass category.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.compasscategorysave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#compasscategorysave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#compasscategorysave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="compassservicelist"></a>
# **compassservicelist**
> compassservicelist(token, category)

View all the services added to the compass

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val category : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the category to filter the services.
try {
    apiInstance.compassservicelist(token, category)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#compassservicelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#compassservicelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **category** | [**java.util.UUID**](.md)| The id of the category to filter the services. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="compassservicelistlocations"></a>
# **compassservicelistlocations**
> compassservicelistlocations(token, serviceid)

View all the locations where a service added to the compass is available

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to get its locations.
try {
    apiInstance.compassservicelistlocations(token, serviceid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#compassservicelistlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#compassservicelistlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to get its locations. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabdeletecomputer"></a>
# **computerlabdeletecomputer**
> computerlabdeletecomputer(token, id)

Delete a computer

Allows the user to delete an existing computer.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : kotlin.String = id_example // kotlin.String | The unique device id of the computer to delete.
try {
    apiInstance.computerlabdeletecomputer(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlabdeletecomputer")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlabdeletecomputer")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | **kotlin.String**| The unique device id of the computer to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabgetcomputer"></a>
# **computerlabgetcomputer**
> computerlabgetcomputer(token, id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : kotlin.String = id_example // kotlin.String | The unique device id of the computer to get.
try {
    apiInstance.computerlabgetcomputer(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlabgetcomputer")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlabgetcomputer")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | **kotlin.String**| The unique device id of the computer to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabgetsettings"></a>
# **computerlabgetsettings**
> computerlabgetsettings(id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the computer lab/location.
try {
    apiInstance.computerlabgetsettings(id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlabgetsettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlabgetsettings")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the computer lab/location. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabissignedin"></a>
# **computerlabissignedin**
> computerlabissignedin(station, user)

Gets whether a user is signed-in or not.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.computerlabissignedin(station, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlabissignedin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlabissignedin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlablistcomputers"></a>
# **computerlablistcomputers**
> computerlablistcomputers(token, from, count, location, freeonly)

View a list of computers

Allows the user to view the list of all computers.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location whose computers have to be returned.
val freeonly : kotlin.Boolean = true // kotlin.Boolean | If true, only free computers will be returned.
try {
    apiInstance.computerlablistcomputers(token, from, count, location, freeonly)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlablistcomputers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlablistcomputers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **location** | [**java.util.UUID**](.md)| The id of the location whose computers have to be returned. | [optional]
 **freeonly** | **kotlin.Boolean**| If true, only free computers will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlablistlabs"></a>
# **computerlablistlabs**
> computerlablistlabs(token)

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.computerlablistlabs(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlablistlabs")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlablistlabs")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabliststations"></a>
# **computerlabliststations**
> computerlabliststations(token)

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.computerlabliststations(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlabliststations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlabliststations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabsavecomputer"></a>
# **computerlabsavecomputer**
> computerlabsavecomputer(UNKNOWN_BASE_TYPE)

Create or edit a computer

Allows the user to create or edit a computer.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.computerlabsavecomputer(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlabsavecomputer")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlabsavecomputer")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="computerlabsavesettings"></a>
# **computerlabsavesettings**
> computerlabsavesettings(UNKNOWN_BASE_TYPE)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.computerlabsavesettings(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlabsavesettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlabsavesettings")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="computerlabsaveswipe"></a>
# **computerlabsaveswipe**
> computerlabsaveswipe(UNKNOWN_BASE_TYPE)

Save a new swipe from a computer in a computer lab.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.computerlabsaveswipe(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#computerlabsaveswipe")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#computerlabsaveswipe")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="deadendrecordingdelete"></a>
# **deadendrecordingdelete**
> deadendrecordingdelete(token, hierarchykey)

Deletes a dead-end record group

Allows the user to delete a dead end record group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val hierarchykey : kotlin.String = hierarchykey_example // kotlin.String | The hierarchy key of the record to delete.
try {
    apiInstance.deadendrecordingdelete(token, hierarchykey)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#deadendrecordingdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#deadendrecordingdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **hierarchykey** | **kotlin.String**| The hierarchy key of the record to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deadendrecordinglist"></a>
# **deadendrecordinglist**
> deadendrecordinglist(token)

Lists the recorded dead ends, if enabled

Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.deadendrecordinglist(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#deadendrecordinglist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#deadendrecordinglist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deadendrecordinglistcomments"></a>
# **deadendrecordinglistcomments**
> deadendrecordinglistcomments(token, hierarchykey)

Lists the comments for a specific dead end

Allows the user to view the comments made on dead end sessions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val hierarchykey : kotlin.String = hierarchykey_example // kotlin.String | The hierarchy key of the record to get the feedback.
try {
    apiInstance.deadendrecordinglistcomments(token, hierarchykey)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#deadendrecordinglistcomments")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#deadendrecordinglistcomments")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **hierarchykey** | **kotlin.String**| The hierarchy key of the record to get the feedback. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deadendrecordingsave"></a>
# **deadendrecordingsave**
> deadendrecordingsave(UNKNOWN_BASE_TYPE)

Saves a dead-end record

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.deadendrecordingsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#deadendrecordingsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#deadendrecordingsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="departmentdelete"></a>
# **departmentdelete**
> departmentdelete(token, id)

Delete a college department

Allows the user to delete an existing college department.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the department to delete.
try {
    apiInstance.departmentdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#departmentdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#departmentdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the department to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="departmentget"></a>
# **departmentget**
> departmentget(token, id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the department to get.
try {
    apiInstance.departmentget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#departmentget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#departmentget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the department to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="departmentlist"></a>
# **departmentlist**
> departmentlist(token, from, count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.departmentlist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#departmentlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#departmentlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="departmentsave"></a>
# **departmentsave**
> departmentsave(UNKNOWN_BASE_TYPE)

Create or edit a college department

Allows the user to create or edit a college department.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.departmentsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#departmentsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#departmentsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="doc"></a>
# **doc**
> doc(excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val excludeanonymous : kotlin.Boolean = true // kotlin.Boolean | If true it excludes the anonymous actions from the returned list.
try {
    apiInstance.doc(excludeanonymous)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#doc")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#doc")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **kotlin.Boolean**| If true it excludes the anonymous actions from the returned list. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="easyloginaddbgimage"></a>
# **easyloginaddbgimage**
> easyloginaddbgimage(token, upload, filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The original filename, needed to process the file.
try {
    apiInstance.easyloginaddbgimage(token, upload, filename)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#easyloginaddbgimage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#easyloginaddbgimage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The original filename, needed to process the file. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventchecksessions"></a>
# **eventchecksessions**
> eventchecksessions(token, eventid, autorepair)

Edit an event&#39;s sessions according to their schedule

Allows the user to edit event sessions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to check.
val autorepair : kotlin.Boolean = true // kotlin.Boolean | True to automatically fix the invalid sessions.
try {
    apiInstance.eventchecksessions(token, eventid, autorepair)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventchecksessions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventchecksessions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event to check. |
 **autorepair** | **kotlin.Boolean**| True to automatically fix the invalid sessions. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventdelete"></a>
# **eventdelete**
> eventdelete(token, id)

Delete a course

Allows the user to delete an existing course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to delete.
try {
    apiInstance.eventdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the event to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventget"></a>
# **eventget**
> eventget(token, id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to get.
try {
    apiInstance.eventget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the event to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventgetsessionsbydate"></a>
# **eventgetsessionsbydate**
> eventgetsessionsbydate(token, location, date, type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The location to filter the events.
val date : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date to filter the events. Today will be used if this parameter is omitted.
val type : kotlin.String = type_example // kotlin.String | Type of event to list.
try {
    apiInstance.eventgetsessionsbydate(token, location, date, type)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventgetsessionsbydate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventgetsessionsbydate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **location** | [**java.util.UUID**](.md)| The location to filter the events. | [optional]
 **date** | **java.time.OffsetDateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional]
 **type** | **kotlin.String**| Type of event to list. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventlist"></a>
# **eventlist**
> eventlist(token, from, count, summaryonly, termid)

View a list of courses

Allows the user to view the full list of courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.String = from_example // kotlin.String | The first record to return.
val count : kotlin.String = count_example // kotlin.String | The max number of records to return.
val summaryonly : kotlin.Boolean = true // kotlin.Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the term to list the events. Null to list all events.
try {
    apiInstance.eventlist(token, from, count, summaryonly, termid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.String**| The first record to return. |
 **count** | **kotlin.String**| The max number of records to return. |
 **summaryonly** | **kotlin.Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**java.util.UUID**](.md)| Id of the term to list the events. Null to list all events. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventlistregistered"></a>
# **eventlistregistered**
> eventlistregistered(token, from, count, summaryonly, termid)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.String = from_example // kotlin.String | The first record to return.
val count : kotlin.String = count_example // kotlin.String | The max number of records to return.
val summaryonly : kotlin.Boolean = true // kotlin.Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the term to list the events. Null to list all events.
try {
    apiInstance.eventlistregistered(token, from, count, summaryonly, termid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventlistregistered")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventlistregistered")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.String**| The first record to return. |
 **count** | **kotlin.String**| The max number of records to return. |
 **summaryonly** | **kotlin.Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**java.util.UUID**](.md)| Id of the term to list the events. Null to list all events. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregaddme"></a>
# **eventregaddme**
> eventregaddme(token, eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregaddme(token, eventid, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregaddme")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregaddme")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregaddmetoall"></a>
# **eventregaddmetoall**
> eventregaddmetoall(token, listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregaddmetoall(token, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregaddmetoall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregaddmetoall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregaddmetogroup"></a>
# **eventregaddmetogroup**
> eventregaddmetogroup(token, codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val codegroup : kotlin.String = codegroup_example // kotlin.String | The code used to group events.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregaddmetogroup(token, codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregaddmetogroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregaddmetogroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **codegroup** | **kotlin.String**| The code used to group events. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregadduser"></a>
# **eventregadduser**
> eventregadduser(token, userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregadduser(token, userid, eventid, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregadduser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregadduser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregaddusertoall"></a>
# **eventregaddusertoall**
> eventregaddusertoall(token, userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregaddusertoall(token, userid, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregaddusertoall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregaddusertoall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregaddusertogroup"></a>
# **eventregaddusertogroup**
> eventregaddusertogroup(token, userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val codegroup : kotlin.String = codegroup_example // kotlin.String | The code used to group events.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregaddusertogroup(token, userid, codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregaddusertogroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregaddusertogroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **codegroup** | **kotlin.String**| The code used to group events. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventreggetevents"></a>
# **eventreggetevents**
> eventreggetevents(token, userid, listname, termid, namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id to list events.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The term id to list events.
val namefilter : kotlin.String = namefilter_example // kotlin.String | The value used to filter the events by name.
try {
    apiInstance.eventreggetevents(token, userid, listname, termid, namefilter)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventreggetevents")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventreggetevents")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The user id to list events. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |
 **termid** | [**java.util.UUID**](.md)| The term id to list events. | [optional]
 **namefilter** | **kotlin.String**| The value used to filter the events by name. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventreggetgroups"></a>
# **eventreggetgroups**
> eventreggetgroups(token, userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id to list events.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventreggetgroups(token, userid, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventreggetgroups")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventreggetgroups")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The user id to list events. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventreggetmyevents"></a>
# **eventreggetmyevents**
> eventreggetmyevents(token, listname, termid, namefilter)

View the event registrations of the current user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The term id to list events.
val namefilter : kotlin.String = namefilter_example // kotlin.String | The value used to filter the events by name.
try {
    apiInstance.eventreggetmyevents(token, listname, termid, namefilter)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventreggetmyevents")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventreggetmyevents")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |
 **termid** | [**java.util.UUID**](.md)| The term id to list events. | [optional]
 **namefilter** | **kotlin.String**| The value used to filter the events by name. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventreggetmygroups"></a>
# **eventreggetmygroups**
> eventreggetmygroups(token, listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventreggetmygroups(token, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventreggetmygroups")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventreggetmygroups")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventreggetusers"></a>
# **eventreggetusers**
> eventreggetusers(token, eventid, listname, photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The event id to list users.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.eventreggetusers(token, eventid, listname, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventreggetusers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventreggetusers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The event id to list users. |
 **listname** | **kotlin.String**| The name of the list to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventreggetusersfromgroup"></a>
# **eventreggetusersfromgroup**
> eventreggetusersfromgroup(token, codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val codegroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The code group to list users.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list to get.
try {
    apiInstance.eventreggetusersfromgroup(token, codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventreggetusersfromgroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventreggetusersfromgroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **codegroup** | [**java.util.UUID**](.md)| The code group to list users. |
 **listname** | **kotlin.String**| The name of the list to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventreggetuserstoall"></a>
# **eventreggetuserstoall**
> eventreggetuserstoall(token, listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list to get.
try {
    apiInstance.eventreggetuserstoall(token, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventreggetuserstoall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventreggetuserstoall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **listname** | **kotlin.String**| The name of the list to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregremoveme"></a>
# **eventregremoveme**
> eventregremoveme(token, eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregremoveme(token, eventid, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregremoveme")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregremoveme")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregremovemefromall"></a>
# **eventregremovemefromall**
> eventregremovemefromall(token, listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregremovemefromall(token, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregremovemefromall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregremovemefromall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregremovemefromgroup"></a>
# **eventregremovemefromgroup**
> eventregremovemefromgroup(token, codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val codegroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The code group of the events/courses.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregremovemefromgroup(token, codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregremovemefromgroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregremovemefromgroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **codegroup** | [**java.util.UUID**](.md)| The code group of the events/courses. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregremoveuser"></a>
# **eventregremoveuser**
> eventregremoveuser(token, userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course&#39;s registration.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregremoveuser(token, userid, eventid, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregremoveuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregremoveuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregremoveuserfromall"></a>
# **eventregremoveuserfromall**
> eventregremoveuserfromall(token, userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregremoveuserfromall(token, userid, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregremoveuserfromall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregremoveuserfromall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregremoveuserfromgroup"></a>
# **eventregremoveuserfromgroup**
> eventregremoveuserfromgroup(token, userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val codegroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The code group of the events/courses.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregremoveuserfromgroup(token, userid, codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventregremoveuserfromgroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventregremoveuserfromgroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **codegroup** | [**java.util.UUID**](.md)| The code group of the events/courses. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventsave"></a>
# **eventsave**
> eventsave(UNKNOWN_BASE_TYPE)

Create or edit a course

Allows the user to create or edit a course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.eventsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="eventsearchgroup"></a>
# **eventsearchgroup**
> eventsearchgroup(token, query)

Searches for the available event groups

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val query : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Query to search event groups.
try {
    apiInstance.eventsearchgroup(token, query)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#eventsearchgroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#eventsearchgroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **query** | [**java.util.UUID**](.md)| Query to search event groups. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="export"></a>
# **export**
> export(token, exporttype, exportformat, filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val exporttype : kotlin.String = exporttype_example // kotlin.String | What to export.
val exportformat : kotlin.String = exportformat_example // kotlin.String | The format of the resulting file. Valid types are CSV, HTML, XLS.
val filters : kotlin.String = filters_example // kotlin.String | Pipe separated filters for the export, eg: aaa=val|bbb=val|...
try {
    apiInstance.export(token, exporttype, exportformat, filters)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#export")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#export")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **exporttype** | **kotlin.String**| What to export. |
 **exportformat** | **kotlin.String**| The format of the resulting file. Valid types are CSV, HTML, XLS. |
 **filters** | **kotlin.String**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="exportlisttypes"></a>
# **exportlisttypes**
> exportlisttypes(token)

Lists available export types

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.exportlisttypes(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#exportlisttypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#exportlisttypes")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="featurelist"></a>
# **featurelist**
> featurelist(token)

Lists the available features.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.featurelist(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#featurelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#featurelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="holidaylist"></a>
# **holidaylist**
> holidaylist(token, term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val term : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The term to get holidays from.
try {
    apiInstance.holidaylist(token, term)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#holidaylist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#holidaylist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **term** | [**java.util.UUID**](.md)| The term to get holidays from. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="holidaysave"></a>
# **holidaysave**
> holidaysave(UNKNOWN_BASE_TYPE)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.holidaysave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#holidaysave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#holidaysave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="holidaysuggest"></a>
# **holidaysuggest**
> holidaysuggest(token, term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val term : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The term to get holidays from.
try {
    apiInstance.holidaysuggest(token, term)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#holidaysuggest")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#holidaysuggest")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **term** | [**java.util.UUID**](.md)| The term to get holidays from. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="import"></a>
# **import**
> import(token, importtype, upload, filename, parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val importtype : kotlin.String = importtype_example // kotlin.String | The kind of data that is being uploaded.
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The local name of the uploaded file. For later reference.
val parameters : kotlin.String = parameters_example // kotlin.String | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.
try {
    apiInstance.import(token, importtype, upload, filename, parameters)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#import")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#import")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **importtype** | **kotlin.String**| The kind of data that is being uploaded. |
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The local name of the uploaded file. For later reference. | [optional]
 **parameters** | **kotlin.String**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="importlisttypes"></a>
# **importlisttypes**
> importlisttypes(token)

Lists available import types

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.importlisttypes(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#importlisttypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#importlisttypes")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="interactiondelete"></a>
# **interactiondelete**
> interactiondelete(token, id)

Delete an interaction

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the interaction to delete.
try {
    apiInstance.interactiondelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#interactiondelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#interactiondelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the interaction to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="interactionfeed"></a>
# **interactionfeed**
> interactionfeed(token, from, count, startdate, public, contexttype, contextid, types, photosize, showdefaultphoto, orderdescending)

Get the interactions feed

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If set, only interactions that happened after this date are returned.
val public : kotlin.Boolean = true // kotlin.Boolean | Specifies whether to return public or private interactions.
val contexttype : kotlin.String = contexttype_example // kotlin.String | The type of the context of the interactions to return.
val contextid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the context of the interactions to return.
val types : kotlin.String = types_example // kotlin.String | The  comma separated types of the interactions to return.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
val showdefaultphoto : kotlin.Boolean = true // kotlin.Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
val orderdescending : kotlin.Boolean = true // kotlin.Boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.
try {
    apiInstance.interactionfeed(token, from, count, startdate, public, contexttype, contextid, types, photosize, showdefaultphoto, orderdescending)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#interactionfeed")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#interactionfeed")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **startdate** | **java.time.OffsetDateTime**| If set, only interactions that happened after this date are returned. | [optional]
 **public** | **kotlin.Boolean**| Specifies whether to return public or private interactions. | [optional]
 **contexttype** | **kotlin.String**| The type of the context of the interactions to return. | [optional]
 **contextid** | [**java.util.UUID**](.md)| The id of the context of the interactions to return. | [optional]
 **types** | **kotlin.String**| The  comma separated types of the interactions to return. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **kotlin.Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]
 **orderdescending** | **kotlin.Boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="interactionget"></a>
# **interactionget**
> interactionget(token, id, thumbnailmediasize, photosize)

View an interaction

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : kotlin.String = id_example // kotlin.String | The id of the interaction.
val thumbnailmediasize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.interactionget(token, id, thumbnailmediasize, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#interactionget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#interactionget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | **kotlin.String**| The id of the interaction. |
 **thumbnailmediasize** | **kotlin.Int**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="interactionlistprivatesummary"></a>
# **interactionlistprivatesummary**
> interactionlistprivatesummary(token, photosize, showdefaultphoto)

Get current user&#39;s latest private interactions

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
val showdefaultphoto : kotlin.Boolean = true // kotlin.Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
try {
    apiInstance.interactionlistprivatesummary(token, photosize, showdefaultphoto)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#interactionlistprivatesummary")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#interactionlistprivatesummary")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **showdefaultphoto** | **kotlin.Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="interactionsave"></a>
# **interactionsave**
> interactionsave(UNKNOWN_BASE_TYPE)

Save an interaction

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.interactionsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#interactionsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#interactionsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="licenseacceptagreement"></a>
# **licenseacceptagreement**
> licenseacceptagreement(token)

Accept the license agreement

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.licenseacceptagreement(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#licenseacceptagreement")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#licenseacceptagreement")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="licensegetagreementstatus"></a>
# **licensegetagreementstatus**
> licensegetagreementstatus(token)

Check if license agreement has been accepted

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.licensegetagreementstatus(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#licensegetagreementstatus")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#licensegetagreementstatus")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="licensegetcurrent"></a>
# **licensegetcurrent**
> licensegetcurrent(token)

Gets the current license information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.licensegetcurrent(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#licensegetcurrent")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#licensegetcurrent")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="licenserenew"></a>
# **licenserenew**
> licenserenew(token, email, phonenumber, jobtitle, institution, comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val email : kotlin.String = email_example // kotlin.String | The e-mail of the user sending the request.
val phonenumber : kotlin.String = phonenumber_example // kotlin.String | The phone number of the user sending the request.
val jobtitle : kotlin.String = jobtitle_example // kotlin.String | The job title of the user sending the request.
val institution : kotlin.String = institution_example // kotlin.String | The institution of the user sending the request.
val comments : kotlin.String = comments_example // kotlin.String | Comments entered by the user sending the request.
try {
    apiInstance.licenserenew(token, email, phonenumber, jobtitle, institution, comments)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#licenserenew")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#licenserenew")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **email** | **kotlin.String**| The e-mail of the user sending the request. |
 **phonenumber** | **kotlin.String**| The phone number of the user sending the request. |
 **jobtitle** | **kotlin.String**| The job title of the user sending the request. | [optional]
 **institution** | **kotlin.String**| The institution of the user sending the request. | [optional]
 **comments** | **kotlin.String**| Comments entered by the user sending the request. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="likedelete"></a>
# **likedelete**
> likedelete(token, interactionid)

Delete a like

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val interactionid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the interaction to unlike.
try {
    apiInstance.likedelete(token, interactionid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#likedelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#likedelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **interactionid** | [**java.util.UUID**](.md)| The id of the interaction to unlike. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="likelist"></a>
# **likelist**
> likelist(token, interactionid, photosize)

View all the likes associated to a target

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val interactionid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the interaction to unlike.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.likelist(token, interactionid, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#likelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#likelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **interactionid** | [**java.util.UUID**](.md)| The id of the interaction to unlike. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="likesave"></a>
# **likesave**
> likesave(UNKNOWN_BASE_TYPE)

Save a like

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.likesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#likesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#likesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="listtimezones"></a>
# **listtimezones**
> listtimezones()

Lists the available timezones

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
try {
    apiInstance.listtimezones()
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#listtimezones")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#listtimezones")
    e.printStackTrace()
}
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

<a name="locationdelete"></a>
# **locationdelete**
> locationdelete(token, id)

Delete a location

Allows the user to delete an existing location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to delete.
try {
    apiInstance.locationdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#locationdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#locationdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the location to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="locationget"></a>
# **locationget**
> locationget(token, id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to get.
try {
    apiInstance.locationget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#locationget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#locationget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the location to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="locationlist"></a>
# **locationlist**
> locationlist(token, from, count, locations, sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val locations : kotlin.String = locations_example // kotlin.String | The comma-separated list containing the ids of the locations to list.
val sortbygroup : kotlin.Boolean = true // kotlin.Boolean | True to list locations sorted by the 'Located In' property. Defaults to false.
try {
    apiInstance.locationlist(token, from, count, locations, sortbygroup)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#locationlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#locationlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **locations** | **kotlin.String**| The comma-separated list containing the ids of the locations to list. | [optional]
 **sortbygroup** | **kotlin.Boolean**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="locationsave"></a>
# **locationsave**
> locationsave(UNKNOWN_BASE_TYPE)

Create or edit a location

Allows the user to create or edit a location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.locationsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#locationsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#locationsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="login"></a>
# **login**
> login(domain, username, password, method, rememberme)

Login

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val domain : kotlin.String = domain_example // kotlin.String | The account domain to login.
val username : kotlin.String = username_example // kotlin.String | The username (email) of the user to login as.
val password : kotlin.String = password_example // kotlin.String | The password of the user to login as.
val method : kotlin.String = method_example // kotlin.String | The authentication method. Valid values are 'token' and 'cookie'.
val rememberme : kotlin.Boolean = true // kotlin.Boolean | If true then the session will not expire.
try {
    apiInstance.login(domain, username, password, method, rememberme)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#login")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#login")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **kotlin.String**| The account domain to login. |
 **username** | **kotlin.String**| The username (email) of the user to login as. |
 **password** | **kotlin.String**| The password of the user to login as. |
 **method** | **kotlin.String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. |
 **rememberme** | **kotlin.Boolean**| If true then the session will not expire. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="logout"></a>
# **logout**
> logout(token)

Logout

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token used to login.
try {
    apiInstance.logout(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#logout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#logout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token used to login. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediacheckin"></a>
# **mediacheckin**
> mediacheckin(token, media, checkindate, notes)

Check in media item

Allows the user to check in a media item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val media : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item to checkin.
val checkindate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The checkout date.
val notes : kotlin.String = notes_example // kotlin.String | The notes of the checkout.
try {
    apiInstance.mediacheckin(token, media, checkindate, notes)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediacheckin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediacheckin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **media** | [**java.util.UUID**](.md)| The id of the media item to checkin. |
 **checkindate** | **java.time.OffsetDateTime**| The checkout date. |
 **notes** | **kotlin.String**| The notes of the checkout. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediacheckout"></a>
# **mediacheckout**
> mediacheckout(token, media, user, checkoutdate, duedate, staff, event, notes)

Check out media item

Allows the user to check out a media item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val media : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item to checkout.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user that is checking the item out.
val checkoutdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The checkout date.
val duedate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date when the checkout is due.
val staff : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff member related to the checkout.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event related to the checkout.
val notes : kotlin.String = notes_example // kotlin.String | The notes of the checkout.
try {
    apiInstance.mediacheckout(token, media, user, checkoutdate, duedate, staff, event, notes)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediacheckout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediacheckout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **media** | [**java.util.UUID**](.md)| The id of the media item to checkout. |
 **user** | [**java.util.UUID**](.md)| The id of the user that is checking the item out. |
 **checkoutdate** | **java.time.OffsetDateTime**| The checkout date. |
 **duedate** | **java.time.OffsetDateTime**| The date when the checkout is due. |
 **staff** | [**java.util.UUID**](.md)| The id of the staff member related to the checkout. | [optional]
 **event** | [**java.util.UUID**](.md)| The id of the event related to the checkout. | [optional]
 **notes** | **kotlin.String**| The notes of the checkout. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediacheckoutlist"></a>
# **mediacheckoutlist**
> mediacheckoutlist(token, from, count, media, user, photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val media : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Used to filter the checkouts of a specific media item.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Used to filter the checkouts made by a specific user.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.mediacheckoutlist(token, from, count, media, user, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediacheckoutlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediacheckoutlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **media** | [**java.util.UUID**](.md)| Used to filter the checkouts of a specific media item. | [optional]
 **user** | [**java.util.UUID**](.md)| Used to filter the checkouts made by a specific user. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediadelete"></a>
# **mediadelete**
> mediadelete(token, id)

Delete a media item

Allows the user to delete an existing media item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item to delete.
try {
    apiInstance.mediadelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediadelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediadelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the media item to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediadeletecheckoutlog"></a>
# **mediadeletecheckoutlog**
> mediadeletecheckoutlog(token, id)

Delete a media checkout log

Allows the user to delete a media item&#39;s checkout log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the checkout log to delete.
try {
    apiInstance.mediadeletecheckoutlog(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediadeletecheckoutlog")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediadeletecheckoutlog")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the checkout log to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaget"></a>
# **mediaget**
> mediaget(token, id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item to get.
try {
    apiInstance.mediaget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediaget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediaget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the media item to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediagetbycode"></a>
# **mediagetbycode**
> mediagetbycode(token, code, location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val code : kotlin.String = code_example // kotlin.String | The code of the media item to get.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The location where to look for the media item.
try {
    apiInstance.mediagetbycode(token, code, location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediagetbycode")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediagetbycode")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **code** | **kotlin.String**| The code of the media item to get. |
 **location** | [**java.util.UUID**](.md)| The location where to look for the media item. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediagetcheckout"></a>
# **mediagetcheckout**
> mediagetcheckout(token, id, photosize)

View details of a media item checkout information

Allows the user to view a media item&#39;s checkout information.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item whose checkout information has to be retrieved.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.mediagetcheckout(token, id, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediagetcheckout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediagetcheckout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the media item whose checkout information has to be retrieved. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediagetcheckoutlog"></a>
# **mediagetcheckoutlog**
> mediagetcheckoutlog(token, id, photosize)

View details of a media checkout log

Allows the user to view a media item&#39;s checkout history.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item whose checkout information has to be retrieved.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.mediagetcheckoutlog(token, id, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediagetcheckoutlog")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediagetcheckoutlog")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the media item whose checkout information has to be retrieved. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="medialist"></a>
# **medialist**
> medialist(token, from, count, status, user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val status : kotlin.Int = 56 // kotlin.Int | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Used to filter the media items that are checked-out by a specific user.
try {
    apiInstance.medialist(token, from, count, status, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#medialist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#medialist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **status** | **kotlin.Int**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional]
 **user** | [**java.util.UUID**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediasave"></a>
# **mediasave**
> mediasave(UNKNOWN_BASE_TYPE)

Create or edit a media item

Allows the user to create or edit a media item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.mediasave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediasave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediasave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="mediatypedelete"></a>
# **mediatypedelete**
> mediatypedelete(token, id)

Delete a media type

Allows the user to delete an existing media type.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media type to delete.
try {
    apiInstance.mediatypedelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediatypedelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediatypedelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the media type to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediatypeget"></a>
# **mediatypeget**
> mediatypeget(token, id)

Search and view details of a media type

Allows the user to view a media type and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media type to get.
try {
    apiInstance.mediatypeget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediatypeget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediatypeget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the media type to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediatypelist"></a>
# **mediatypelist**
> mediatypelist(token, from, count)

View a list of media types

Allows the user to view the list of all media types.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.mediatypelist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediatypelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediatypelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediatypesave"></a>
# **mediatypesave**
> mediatypesave(UNKNOWN_BASE_TYPE)

Create or edit a media type

Allows the user to create or edit a media type.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.mediatypesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mediatypesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mediatypesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="memorizedreportdelete"></a>
# **memorizedreportdelete**
> memorizedreportdelete(token, id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the report settings to delete.
try {
    apiInstance.memorizedreportdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#memorizedreportdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#memorizedreportdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the report settings to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="memorizedreportget"></a>
# **memorizedreportget**
> memorizedreportget(token, id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the report configuration to get.
try {
    apiInstance.memorizedreportget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#memorizedreportget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#memorizedreportget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the report configuration to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="memorizedreportlist"></a>
# **memorizedreportlist**
> memorizedreportlist(token, from, count, customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val customname : kotlin.String = customname_example // kotlin.String | If specified filters the memorized reports by custom name.
try {
    apiInstance.memorizedreportlist(token, from, count, customname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#memorizedreportlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#memorizedreportlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **customname** | **kotlin.String**| If specified filters the memorized reports by custom name. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="memorizedreportsave"></a>
# **memorizedreportsave**
> memorizedreportsave(UNKNOWN_BASE_TYPE)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.memorizedreportsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#memorizedreportsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#memorizedreportsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="menugetitems"></a>
# **menugetitems**
> menugetitems(menuid)

Gets the items on the menu

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val menuid : kotlin.String = menuid_example // kotlin.String | The Id of the menu to get.
try {
    apiInstance.menugetitems(menuid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#menugetitems")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#menugetitems")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuid** | **kotlin.String**| The Id of the menu to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="myaccount"></a>
# **myaccount**
> myaccount(token)

Gets the logged in user account.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.myaccount(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#myaccount")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#myaccount")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="myianatimezone"></a>
# **myianatimezone**
> myianatimezone(token)

Gets the current time zone&#39;s iana name

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.myianatimezone(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#myianatimezone")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#myianatimezone")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="myprofile"></a>
# **myprofile**
> myprofile(token, photosize)

Gets the logged in user information.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.myprofile(token, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#myprofile")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#myprofile")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="myrights"></a>
# **myrights**
> myrights(token)

Gets the list of actions the user can execute.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.myrights(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#myrights")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#myrights")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mysaveprofile"></a>
# **mysaveprofile**
> mysaveprofile(UNKNOWN_BASE_TYPE)

Updates logged user&#39;s profile information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.mysaveprofile(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#mysaveprofile")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#mysaveprofile")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="notificationdelete"></a>
# **notificationdelete**
> notificationdelete(token, id)

Delete a notification

Allows the user to delete an existing notification.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification to delete.
try {
    apiInstance.notificationdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the notification to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationget"></a>
# **notificationget**
> notificationget(token, id)

View a notification

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification to get.
try {
    apiInstance.notificationget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the notification to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationgetforstation"></a>
# **notificationgetforstation**
> notificationgetforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.notificationgetforstation(station, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationgetforstation")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationgetforstation")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationgetunreadcount"></a>
# **notificationgetunreadcount**
> notificationgetunreadcount(token)

Get the number of unread notifications

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.notificationgetunreadcount(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationgetunreadcount")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationgetunreadcount")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationlist"></a>
# **notificationlist**
> notificationlist(token, from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val recipient : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The recipient whose notifications have to be listed.
val status : kotlin.Int = 56 // kotlin.Int | The status of the notifications to list. Read, Unread or All.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the notifications.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the notifications.
val sentonscreen : kotlin.Boolean = true // kotlin.Boolean | Specifies whether to list the notifications that were sent on-screen or not.
val sentemail : kotlin.Boolean = true // kotlin.Boolean | Specifies whether to list the notifications that were sent via e-mail or not.
val sentsms : kotlin.Boolean = true // kotlin.Boolean | Specifies whether to list the notifications that were sent via sms or not.
try {
    apiInstance.notificationlist(token, from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **recipient** | [**java.util.UUID**](.md)| The recipient whose notifications have to be listed. | [optional]
 **status** | **kotlin.Int**| The status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the notifications. | [optional]
 **sentonscreen** | **kotlin.Boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional]
 **sentemail** | **kotlin.Boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional]
 **sentsms** | **kotlin.Boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationlistmine"></a>
# **notificationlistmine**
> notificationlistmine(token, from, count, status, startdate, enddate)

View all the notifications sent to the current user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val status : kotlin.Int = 56 // kotlin.Int | Specifies the status of the notifications to list. Read, Unread or All.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the notifications.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the notifications.
try {
    apiInstance.notificationlistmine(token, from, count, status, startdate, enddate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationlistmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationlistmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **status** | **kotlin.Int**| Specifies the status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationmarkasread"></a>
# **notificationmarkasread**
> notificationmarkasread(token, id, status, startdate, enddate)

Mark a notification as read

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
val status : kotlin.Int = 56 // kotlin.Int | Specifies the status to filter the notifications. Read, Unread or All.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the notifications.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the notifications.
try {
    apiInstance.notificationmarkasread(token, id, status, startdate, enddate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationmarkasread")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationmarkasread")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional]
 **status** | **kotlin.Int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationmarkasunread"></a>
# **notificationmarkasunread**
> notificationmarkasunread(token, id, status, startdate, enddate)

Mark a notification as unread

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
val status : kotlin.Int = 56 // kotlin.Int | Specifies the status to filter the notifications. Read, Unread or All.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the notifications.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the notifications.
try {
    apiInstance.notificationmarkasunread(token, id, status, startdate, enddate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationmarkasunread")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationmarkasunread")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional]
 **status** | **kotlin.Int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationsend"></a>
# **notificationsend**
> notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val emailenabled : kotlin.Boolean = true // kotlin.Boolean | Whether send the notification via email.
val onscreenenabled : kotlin.Boolean = true // kotlin.Boolean | Whether to display the notification on screen.
val smsenabled : kotlin.Boolean = true // kotlin.Boolean | Whether to send the notification via text message.
val title : kotlin.String = title_example // kotlin.String | Notification title.
val tousers : kotlin.String = tousers_example // kotlin.String | Comma-separated Ids of users to send the notification.
val togroups : kotlin.String = togroups_example // kotlin.String | Comma-separated Ids of user groups to send the notification.
val onscreenbody : kotlin.String = onscreenbody_example // kotlin.String | Body of the message for on-screen display.
val onscreenclick : kotlin.String = onscreenclick_example // kotlin.String | What to do when the notification is clicked. Valid values: hide, view, url.
val onscreenurl : kotlin.String = onscreenurl_example // kotlin.String | Url to redirect the user, if onscreenclick=url.
val onscreenclass : kotlin.String = onscreenclass_example // kotlin.String | How to display the notification. Valid values: info, success, warning, error
val onscreenduration : kotlin.Int = 56 // kotlin.Int | Time in seconds to display the notification.
val showonstation : kotlin.Int = 56 // kotlin.Int | Whether to show the notification in the sign-in station.
val emailfromname : kotlin.String = emailfromname_example // kotlin.String | Name of the email sender.
val emailfrom : kotlin.String = emailfrom_example // kotlin.String | Reply-to email.
val emailsubject : kotlin.String = emailsubject_example // kotlin.String | Subject of the email.
val emailbody : kotlin.String = emailbody_example // kotlin.String | Body of the email.
val textmessagebody : kotlin.String = textmessagebody_example // kotlin.String | Message for SMS. Max 160 characters.
try {
    apiInstance.notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationsend")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationsend")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **emailenabled** | **kotlin.Boolean**| Whether send the notification via email. |
 **onscreenenabled** | **kotlin.Boolean**| Whether to display the notification on screen. |
 **smsenabled** | **kotlin.Boolean**| Whether to send the notification via text message. |
 **title** | **kotlin.String**| Notification title. |
 **tousers** | **kotlin.String**| Comma-separated Ids of users to send the notification. | [optional]
 **togroups** | **kotlin.String**| Comma-separated Ids of user groups to send the notification. | [optional]
 **onscreenbody** | **kotlin.String**| Body of the message for on-screen display. | [optional]
 **onscreenclick** | **kotlin.String**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional]
 **onscreenurl** | **kotlin.String**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional]
 **onscreenclass** | **kotlin.String**| How to display the notification. Valid values: info, success, warning, error | [optional]
 **onscreenduration** | **kotlin.Int**| Time in seconds to display the notification. | [optional]
 **showonstation** | **kotlin.Int**| Whether to show the notification in the sign-in station. | [optional]
 **emailfromname** | **kotlin.String**| Name of the email sender. | [optional]
 **emailfrom** | **kotlin.String**| Reply-to email. | [optional]
 **emailsubject** | **kotlin.String**| Subject of the email. | [optional]
 **emailbody** | **kotlin.String**| Body of the email. | [optional]
 **textmessagebody** | **kotlin.String**| Message for SMS. Max 160 characters. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationsendonscreen"></a>
# **notificationsendonscreen**
> notificationsendonscreen(token, notification)

Send on-screen notifications

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val notification : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the notification to send.
try {
    apiInstance.notificationsendonscreen(token, notification)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationsendonscreen")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationsendonscreen")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **notification** | [**java.util.UUID**](.md)| The ID of the notification to send. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationtopicdelete"></a>
# **notificationtopicdelete**
> notificationtopicdelete(token, id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification topic to delete.
try {
    apiInstance.notificationtopicdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationtopicdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationtopicdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the notification topic to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationtopicget"></a>
# **notificationtopicget**
> notificationtopicget(token, id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification topic to get.
try {
    apiInstance.notificationtopicget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationtopicget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationtopicget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the notification topic to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationtopiclist"></a>
# **notificationtopiclist**
> notificationtopiclist(token, from, count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.notificationtopiclist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationtopiclist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationtopiclist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationtopiclistsubscribe"></a>
# **notificationtopiclistsubscribe**
> notificationtopiclistsubscribe(token)

List all the notification topics available to subscribe

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.notificationtopiclistsubscribe(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationtopiclistsubscribe")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationtopiclistsubscribe")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationtopicsave"></a>
# **notificationtopicsave**
> notificationtopicsave(UNKNOWN_BASE_TYPE)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.notificationtopicsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#notificationtopicsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#notificationtopicsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="pushderegister"></a>
# **pushderegister**
> pushderegister(devicetoken, platform)

Deregisters the current device to receive push notifications

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val devicetoken : kotlin.String = devicetoken_example // kotlin.String | The device token where to send the notification.
val platform : kotlin.String = platform_example // kotlin.String | Either ios or android
try {
    apiInstance.pushderegister(devicetoken, platform)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#pushderegister")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#pushderegister")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **kotlin.String**| The device token where to send the notification. |
 **platform** | **kotlin.String**| Either ios or android |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="pushregister"></a>
# **pushregister**
> pushregister(devicetoken, platform)

Registers the current device to receive push notifications

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val devicetoken : kotlin.String = devicetoken_example // kotlin.String | The device token where to send the notification.
val platform : kotlin.String = platform_example // kotlin.String | Either ios or android
try {
    apiInstance.pushregister(devicetoken, platform)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#pushregister")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#pushregister")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **kotlin.String**| The device token where to send the notification. |
 **platform** | **kotlin.String**| Either ios or android |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="qrlabelsprint"></a>
# **qrlabelsprint**
> qrlabelsprint(token, user, group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user whose label needs to be printed.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group whose members' labels need to be printed.
try {
    apiInstance.qrlabelsprint(token, user, group)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#qrlabelsprint")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#qrlabelsprint")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **user** | [**java.util.UUID**](.md)| The id of the user whose label needs to be printed. | [optional]
 **group** | [**java.util.UUID**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="qrloginget"></a>
# **qrloginget**
> qrloginget(token)

Gets an image of a QR token

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.qrloginget(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#qrloginget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#qrloginget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="qrloginlogin"></a>
# **qrloginlogin**
> qrloginlogin(onetimetoken)

Login

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val onetimetoken : kotlin.String = onetimetoken_example // kotlin.String | The token read from the QR code.
try {
    apiInstance.qrloginlogin(onetimetoken)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#qrloginlogin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#qrloginlogin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onetimetoken** | **kotlin.String**| The token read from the QR code. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpaneldeletewidget"></a>
# **quickpaneldeletewidget**
> quickpaneldeletewidget(token, id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the widget.
try {
    apiInstance.quickpaneldeletewidget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#quickpaneldeletewidget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#quickpaneldeletewidget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the widget. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanelfetchwidget"></a>
# **quickpanelfetchwidget**
> quickpanelfetchwidget(token, widgetid)

Fetches the information for a specific widget.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val widgetid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the data to fetch it's data.
try {
    apiInstance.quickpanelfetchwidget(token, widgetid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#quickpanelfetchwidget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#quickpanelfetchwidget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **widgetid** | [**java.util.UUID**](.md)| The ID of the data to fetch it&#39;s data. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanelgetwidget"></a>
# **quickpanelgetwidget**
> quickpanelgetwidget(token, id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the widget to get.
try {
    apiInstance.quickpanelgetwidget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#quickpanelgetwidget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#quickpanelgetwidget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the widget to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanelinit"></a>
# **quickpanelinit**
> quickpanelinit(token)

Returns the initial information required to show the quick panels

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.quickpanelinit(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#quickpanelinit")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#quickpanelinit")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanellistwidgets"></a>
# **quickpanellistwidgets**
> quickpanellistwidgets(token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.quickpanellistwidgets(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#quickpanellistwidgets")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#quickpanellistwidgets")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanellistwidgettypes"></a>
# **quickpanellistwidgettypes**
> quickpanellistwidgettypes(token)

Lists all the widget types available in the system

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.quickpanellistwidgettypes(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#quickpanellistwidgettypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#quickpanellistwidgettypes")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanelreorderwidgets"></a>
# **quickpanelreorderwidgets**
> quickpanelreorderwidgets(token, sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val sectionname : kotlin.String = sectionname_example // kotlin.String | The section name where to sort the widgets.
val orderids : kotlin.String = orderids_example // kotlin.String | CSV list of the widgets to reorder.
try {
    apiInstance.quickpanelreorderwidgets(token, sectionname, orderids)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#quickpanelreorderwidgets")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#quickpanelreorderwidgets")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **sectionname** | **kotlin.String**| The section name where to sort the widgets. |
 **orderids** | **kotlin.String**| CSV list of the widgets to reorder. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="quickpanelsavewidget"></a>
# **quickpanelsavewidget**
> quickpanelsavewidget(UNKNOWN_BASE_TYPE)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.quickpanelsavewidget(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#quickpanelsavewidget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#quickpanelsavewidget")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="ratingflag"></a>
# **ratingflag**
> ratingflag(token, id, comment)

Flags one rating for moderation

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The rating to flag.
val comment : kotlin.String = comment_example // kotlin.String | Comment why should this should be removed.
try {
    apiInstance.ratingflag(token, id, comment)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratingflag")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratingflag")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The rating to flag. |
 **comment** | **kotlin.String**| Comment why should this should be removed. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingflagcomment"></a>
# **ratingflagcomment**
> ratingflagcomment(token, id, comment)

Flags one comment for moderation

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The comment to flag.
val comment : kotlin.String = comment_example // kotlin.String | Comment why should this should be removed.
try {
    apiInstance.ratingflagcomment(token, id, comment)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratingflagcomment")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratingflagcomment")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The comment to flag. |
 **comment** | **kotlin.String**| Comment why should this should be removed. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingget"></a>
# **ratingget**
> ratingget(token, type, entityids)

Get rating for one or more entities

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val type : kotlin.String = type_example // kotlin.String | The entity type to get the rating.
val entityids : kotlin.String = entityids_example // kotlin.String | List of ids to get the ratings.
try {
    apiInstance.ratingget(token, type, entityids)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratingget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratingget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **type** | **kotlin.String**| The entity type to get the rating. |
 **entityids** | **kotlin.String**| List of ids to get the ratings. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratinggetall"></a>
# **ratinggetall**
> ratinggetall(token, type, entityid, mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val type : kotlin.String = type_example // kotlin.String | The entity type to get the rating.
val entityid : kotlin.String = entityid_example // kotlin.String | Id of the entity to get the ratings.
val mostrecentfirst : kotlin.Boolean = true // kotlin.Boolean | True to show most recent first, otherwise most helpful first.
try {
    apiInstance.ratinggetall(token, type, entityid, mostrecentfirst)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratinggetall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratinggetall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **type** | **kotlin.String**| The entity type to get the rating. |
 **entityid** | **kotlin.String**| Id of the entity to get the ratings. |
 **mostrecentfirst** | **kotlin.Boolean**| True to show most recent first, otherwise most helpful first. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratinggetcomments"></a>
# **ratinggetcomments**
> ratinggetcomments(token, ratingid)

Gets all the comments for a rating

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val ratingid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the rating to get all comments.
try {
    apiInstance.ratinggetcomments(token, ratingid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratinggetcomments")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratinggetcomments")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **ratingid** | [**java.util.UUID**](.md)| The ID of the rating to get all comments. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratinggetpending"></a>
# **ratinggetpending**
> ratinggetpending(getgroup, rateid, rateval)

Gets info of pre-saved and pre-approved ratings

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val getgroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group of pending ratings to get.
val rateid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Rate this before returning.
val rateval : kotlin.Int = 56 // kotlin.Int | The value used to rate the item specified in rateid.
try {
    apiInstance.ratinggetpending(getgroup, rateid, rateval)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratinggetpending")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratinggetpending")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**java.util.UUID**](.md)| The ID of the group of pending ratings to get. |
 **rateid** | [**java.util.UUID**](.md)| Rate this before returning. | [optional]
 **rateval** | **kotlin.Int**| The value used to rate the item specified in rateid. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratinggetpendingmoderation"></a>
# **ratinggetpendingmoderation**
> ratinggetpendingmoderation(token)

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.ratinggetpendingmoderation(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratinggetpendingmoderation")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratinggetpendingmoderation")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingmoderate"></a>
# **ratingmoderate**
> ratingmoderate(token, type, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val type : kotlin.String = type_example // kotlin.String | Either 'rating' or 'comment' depending on what you want to moderate.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the rating or comment, as specified in type.
val approve : kotlin.Boolean = true // kotlin.Boolean | True to approve, false to reject.
try {
    apiInstance.ratingmoderate(token, type, id, approve)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratingmoderate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratingmoderate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **type** | **kotlin.String**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. |
 **id** | [**java.util.UUID**](.md)| Id of the rating or comment, as specified in type. |
 **approve** | **kotlin.Boolean**| True to approve, false to reject. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingpostcomment"></a>
# **ratingpostcomment**
> ratingpostcomment(token, ratingid, comment, annonymous)

Posts a comments for in a rating

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val ratingid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the rating to post the comment.
val comment : kotlin.String = comment_example // kotlin.String | Text of the comment to post.
val annonymous : kotlin.Boolean = true // kotlin.Boolean | True to post the comment annonymously.
try {
    apiInstance.ratingpostcomment(token, ratingid, comment, annonymous)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratingpostcomment")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratingpostcomment")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **ratingid** | [**java.util.UUID**](.md)| The ID of the rating to post the comment. |
 **comment** | **kotlin.String**| Text of the comment to post. |
 **annonymous** | **kotlin.Boolean**| True to post the comment annonymously. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingrate"></a>
# **ratingrate**
> ratingrate(token, type, entityid, annonymous, value, comment, updatecomment)

Rates one entity

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val type : kotlin.String = type_example // kotlin.String | The entity type to rate.
val entityid : kotlin.String = entityid_example // kotlin.String | Id of the entity to rate.
val annonymous : kotlin.Boolean = true // kotlin.Boolean | Whether to post as annonymous.
val value : kotlin.Int = 56 // kotlin.Int | Value from 0 to 100 with the rating.
val comment : kotlin.String = comment_example // kotlin.String | Comment associated with this review. Comment can be updated later on another request too.
val updatecomment : kotlin.Boolean = true // kotlin.Boolean | Whether to update the comments. Defaults to true.
try {
    apiInstance.ratingrate(token, type, entityid, annonymous, value, comment, updatecomment)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratingrate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratingrate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **type** | **kotlin.String**| The entity type to rate. |
 **entityid** | **kotlin.String**| Id of the entity to rate. |
 **annonymous** | **kotlin.Boolean**| Whether to post as annonymous. |
 **value** | **kotlin.Int**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **kotlin.String**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **kotlin.Boolean**| Whether to update the comments. Defaults to true. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingratepending"></a>
# **ratingratepending**
> ratingratepending(group, annonymous, rateid, value, comment, updatecomment)

Rates a pre-saved and pre-approved entity

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group of with pre-approved ratings.
val annonymous : kotlin.Boolean = true // kotlin.Boolean | Whether to post as annonymous.
val rateid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Rate this before returning.
val value : kotlin.Int = 56 // kotlin.Int | Value from 0 to 100 with the rating.
val comment : kotlin.String = comment_example // kotlin.String | Comment associated with this review. Comment can be updated later on another request too.
val updatecomment : kotlin.Boolean = true // kotlin.Boolean | Whether to update the comments. Defaults to true.
try {
    apiInstance.ratingratepending(group, annonymous, rateid, value, comment, updatecomment)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratingratepending")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratingratepending")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**java.util.UUID**](.md)| The ID of the group of with pre-approved ratings. |
 **annonymous** | **kotlin.Boolean**| Whether to post as annonymous. |
 **rateid** | [**java.util.UUID**](.md)| Rate this before returning. | [optional]
 **value** | **kotlin.Int**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **kotlin.String**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **kotlin.Boolean**| Whether to update the comments. Defaults to true. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingvote"></a>
# **ratingvote**
> ratingvote(token, ratingid, vote)

Votes up or down a rating

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val ratingid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the rating to vote on.
val vote : kotlin.Int = 56 // kotlin.Int | 1 to vote up, -1 to vote down.
try {
    apiInstance.ratingvote(token, ratingid, vote)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ratingvote")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ratingvote")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **ratingid** | [**java.util.UUID**](.md)| The ID of the rating to vote on. |
 **vote** | **kotlin.Int**| 1 to vote up, -1 to vote down. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportattanalyticsprepare"></a>
# **reportattanalyticsprepare**
> reportattanalyticsprepare(token, reportname, params, refreshgroup)

Query and load an attendance analytics report

Allows the user to query and load attendance analytics reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val reportname : kotlin.String = reportname_example // kotlin.String | The name of the report to execute
val params : kotlin.String = params_example // kotlin.String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
val refreshgroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group to check (and refresh) before processing the report.
try {
    apiInstance.reportattanalyticsprepare(token, reportname, params, refreshgroup)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportattanalyticsprepare")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportattanalyticsprepare")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **reportname** | **kotlin.String**| The name of the report to execute |
 **params** | **kotlin.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **refreshgroup** | [**java.util.UUID**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportlist"></a>
# **reportlist**
> reportlist(token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.reportlist(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportpermissionsbyuser"></a>
# **reportpermissionsbyuser**
> reportpermissionsbyuser(token, params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val params : kotlin.String = params_example // kotlin.String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
try {
    apiInstance.reportpermissionsbyuser(token, params)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportpermissionsbyuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportpermissionsbyuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **params** | **kotlin.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportprepare"></a>
# **reportprepare**
> reportprepare(token, reportname, params, repformat, fillgroupid, groupby, refreshgroup, filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val reportname : kotlin.String = reportname_example // kotlin.String | The name of the report to execute
val params : kotlin.String = params_example // kotlin.String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
val repformat : kotlin.String = repformat_example // kotlin.String | The format of the resulting report. Json, pdf, csv, ...
val fillgroupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | If specified, the result is used to fill the group with the given ID
val groupby : kotlin.String = groupby_example // kotlin.String | How to group the records. In the format 'col1+col2|col3+col4
val refreshgroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group to check (and refresh) before processing the report.
val filtertext : kotlin.String = filtertext_example // kotlin.String | The user friendly text of the applied filters.
try {
    apiInstance.reportprepare(token, reportname, params, repformat, fillgroupid, groupby, refreshgroup, filtertext)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportprepare")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportprepare")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **reportname** | **kotlin.String**| The name of the report to execute |
 **params** | **kotlin.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **repformat** | **kotlin.String**| The format of the resulting report. Json, pdf, csv, ... | [optional]
 **fillgroupid** | [**java.util.UUID**](.md)| If specified, the result is used to fill the group with the given ID | [optional]
 **groupby** | **kotlin.String**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional]
 **refreshgroup** | [**java.util.UUID**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional]
 **filtertext** | **kotlin.String**| The user friendly text of the applied filters. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportquery"></a>
# **reportquery**
> reportquery(token, reportname, params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val reportname : kotlin.String = reportname_example // kotlin.String | The name of the report to execute
val params : kotlin.String = params_example // kotlin.String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
try {
    apiInstance.reportquery(token, reportname, params)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportquery")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportquery")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **reportname** | **kotlin.String**| The name of the report to execute |
 **params** | **kotlin.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportscheduledelete"></a>
# **reportscheduledelete**
> reportscheduledelete(token, id)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the report schedule to delete.
try {
    apiInstance.reportscheduledelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportscheduledelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportscheduledelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the report schedule to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportscheduleget"></a>
# **reportscheduleget**
> reportscheduleget(token, id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule to get.
try {
    apiInstance.reportscheduleget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportscheduleget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportscheduleget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the schedule to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportschedulelist"></a>
# **reportschedulelist**
> reportschedulelist(token, from, count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.reportschedulelist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportschedulelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportschedulelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportschedulesave"></a>
# **reportschedulesave**
> reportschedulesave(UNKNOWN_BASE_TYPE)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.reportschedulesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reportschedulesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reportschedulesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="reporttagresults"></a>
# **reporttagresults**
> reporttagresults(token, reportname, assign, tags, params)

Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.

Allows the user to use a report to assign or unassign tags.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val reportname : kotlin.String = reportname_example // kotlin.String | The name of the report to execute
val assign : kotlin.Boolean = true // kotlin.Boolean | Specify whether the specified tags have to be assigned or unassigned.
val tags : kotlin.String = tags_example // kotlin.String | The tags to assign (or unassign) to the resulting users in the report, in JSON format.
val params : kotlin.String = params_example // kotlin.String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
try {
    apiInstance.reporttagresults(token, reportname, assign, tags, params)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#reporttagresults")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#reporttagresults")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **reportname** | **kotlin.String**| The name of the report to execute |
 **assign** | **kotlin.Boolean**| Specify whether the specified tags have to be assigned or unassigned. |
 **tags** | **kotlin.String**| The tags to assign (or unassign) to the resulting users in the report, in JSON format. |
 **params** | **kotlin.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelcheckanalysis"></a>
# **riskmodelcheckanalysis**
> riskmodelcheckanalysis(token, id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model whose analysis status has to be returned.
try {
    apiInstance.riskmodelcheckanalysis(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodelcheckanalysis")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodelcheckanalysis")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model whose analysis status has to be returned. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodeldelete"></a>
# **riskmodeldelete**
> riskmodeldelete(token, id)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model to delete.
try {
    apiInstance.riskmodeldelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodeldelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodeldelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelget"></a>
# **riskmodelget**
> riskmodelget(token, id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model to get.
try {
    apiInstance.riskmodelget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodelget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodelget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelgetscore"></a>
# **riskmodelgetscore**
> riskmodelgetscore(token, userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to get the risk score.
try {
    apiInstance.riskmodelgetscore(token, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodelgetscore")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodelgetscore")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to get the risk score. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodellist"></a>
# **riskmodellist**
> riskmodellist(token, from, count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.riskmodellist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodellist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodellist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelpredict"></a>
# **riskmodelpredict**
> riskmodelpredict(token, id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the assessment model to use in order to predict risk.
try {
    apiInstance.riskmodelpredict(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodelpredict")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodelpredict")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the assessment model to use in order to predict risk. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelprocess"></a>
# **riskmodelprocess**
> riskmodelprocess(token, id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model to process.
try {
    apiInstance.riskmodelprocess(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodelprocess")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodelprocess")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model to process. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelrefresh"></a>
# **riskmodelrefresh**
> riskmodelrefresh(token, id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the risk assessment model whose information has to be refreshed.
try {
    apiInstance.riskmodelrefresh(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodelrefresh")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodelrefresh")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the risk assessment model whose information has to be refreshed. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="riskmodelsave"></a>
# **riskmodelsave**
> riskmodelsave(UNKNOWN_BASE_TYPE)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.riskmodelsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodelsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodelsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="riskmodeltermprecedences"></a>
# **riskmodeltermprecedences**
> riskmodeltermprecedences(token)

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.riskmodeltermprecedences(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#riskmodeltermprecedences")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#riskmodeltermprecedences")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="rolelist"></a>
# **rolelist**
> rolelist(token, name)

Show a list of roles

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val name : kotlin.String = name_example // kotlin.String | Filter by name of the role.
try {
    apiInstance.rolelist(token, name)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#rolelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#rolelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **name** | **kotlin.String**| Filter by name of the role. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ruledelete"></a>
# **ruledelete**
> ruledelete(token, id)

Delete a rule

Allows the user to delete an existing rule.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the rule to delete.
try {
    apiInstance.ruledelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ruledelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ruledelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the rule to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ruleget"></a>
# **ruleget**
> ruleget(token, id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the rule to get.
try {
    apiInstance.ruleget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ruleget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ruleget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the rule to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="rulegeteventtype"></a>
# **rulegeteventtype**
> rulegeteventtype(token, event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val event : kotlin.String = event_example // kotlin.String | The name of the event to refresh.
try {
    apiInstance.rulegeteventtype(token, event)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#rulegeteventtype")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#rulegeteventtype")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **event** | **kotlin.String**| The name of the event to refresh. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="rulelist"></a>
# **rulelist**
> rulelist(token, from, count)

View a list of user rules

Allows the user to view the list of all rules.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.rulelist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#rulelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#rulelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="rulelistactions"></a>
# **rulelistactions**
> rulelistactions(token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.rulelistactions(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#rulelistactions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#rulelistactions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="rulelisteventtypes"></a>
# **rulelisteventtypes**
> rulelisteventtypes(token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.rulelisteventtypes(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#rulelisteventtypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#rulelisteventtypes")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="rulelisthttprequests"></a>
# **rulelisthttprequests**
> rulelisthttprequests(token, from, count, failed, status)

View all the http requests sent as a result of a rule

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val failed : kotlin.Boolean = true // kotlin.Boolean | If true only failed requests will be returned
val status : kotlin.Int = 56 // kotlin.Int | The http status to filter the requests
try {
    apiInstance.rulelisthttprequests(token, from, count, failed, status)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#rulelisthttprequests")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#rulelisthttprequests")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **failed** | **kotlin.Boolean**| If true only failed requests will be returned | [optional]
 **status** | **kotlin.Int**| The http status to filter the requests | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="rulesave"></a>
# **rulesave**
> rulesave(UNKNOWN_BASE_TYPE)

Create or edit a rule

Allows the user to create or edit a rule.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.rulesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#rulesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#rulesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="scheduledelete"></a>
# **scheduledelete**
> scheduledelete(token, scheduleid)

Delete a schedule slot

Allows the user to delete a schedule slot from another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val scheduleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule.
try {
    apiInstance.scheduledelete(token, scheduleid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduledelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduledelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **scheduleid** | [**java.util.UUID**](.md)| The id of the schedule. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduledeletemine"></a>
# **scheduledeletemine**
> scheduledeletemine(token, scheduleid)

Delete a specific block from a user&#39;s own schedule

Allows the user to delete a schedule block from their own availability.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val scheduleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule.
try {
    apiInstance.scheduledeletemine(token, scheduleid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduledeletemine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduledeletemine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **scheduleid** | [**java.util.UUID**](.md)| The id of the schedule. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleenable"></a>
# **scheduleenable**
> scheduleenable(token, userid, enable)

Enable or disable the schedule for a specific person

Allows the user to enable or disable a schedule for another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to enable or disable the schedule.
val enable : kotlin.Boolean = true // kotlin.Boolean | True to enable schedules, false to disable.
try {
    apiInstance.scheduleenable(token, userid, enable)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduleenable")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduleenable")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to enable or disable the schedule. |
 **enable** | **kotlin.Boolean**| True to enable schedules, false to disable. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleenablemine"></a>
# **scheduleenablemine**
> scheduleenablemine(token, enable)

Enable or disable current user&#39;s schedule

Allows the user to enable or disable a schedule for himself.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val enable : kotlin.Boolean = true // kotlin.Boolean | True to enable schedules, false to disable.
try {
    apiInstance.scheduleenablemine(token, enable)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduleenablemine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduleenablemine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **enable** | **kotlin.Boolean**| True to enable schedules, false to disable. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="schedulefindallstaffslots"></a>
# **schedulefindallstaffslots**
> schedulefindallstaffslots(token, starttime, endtime, staffid, serviceids, eventid, locationid, staffroleids, availablefor)

Search available schedule slots by service, event, date

Allows users to search available slots.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val staffid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff to filter by.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service Ids to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to filter by.
val staffroleids : kotlin.String = staffroleids_example // kotlin.String | CSV list of the staff member role ids to filter by.
val availablefor : kotlin.String = availablefor_example // kotlin.String | The specific availability type to filter by.
try {
    apiInstance.schedulefindallstaffslots(token, starttime, endtime, staffid, serviceids, eventid, locationid, staffroleids, availablefor)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulefindallstaffslots")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulefindallstaffslots")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="schedulefindslots"></a>
# **schedulefindslots**
> schedulefindslots(token, staffid, starttime, endtime, serviceids, eventid, locationid, availablefor)

Search available schedule slots by service, event, date and/or staff

Allows users to search available slots when making appointments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val staffid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff to filter by.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service Ids to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
val availablefor : kotlin.String = availablefor_example // kotlin.String | The specific availability type to filter by.
try {
    apiInstance.schedulefindslots(token, staffid, starttime, endtime, serviceids, eventid, locationid, availablefor)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulefindslots")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulefindslots")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="schedulefindstaffavail"></a>
# **schedulefindstaffavail**
> schedulefindstaffavail(token, starttime, endtime, serviceids, eventid, locationid, staffroleids, availablefor, photosize)

Search available staff members slots by service, event, and/or date

Allows users to search available staff.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val starttime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start time of the range to look for slots.
val endtime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end time of the range to look for slots.
val serviceids : kotlin.String = serviceids_example // kotlin.String | CSV list of the service ids to filter by.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter by.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to filter by.
val staffroleids : kotlin.String = staffroleids_example // kotlin.String | CSV list of the staff member role ids to filter by.
val availablefor : kotlin.String = availablefor_example // kotlin.String | Filter slots by a specific availability type.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.schedulefindstaffavail(token, starttime, endtime, serviceids, eventid, locationid, staffroleids, availablefor, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulefindstaffavail")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulefindstaffavail")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleget"></a>
# **scheduleget**
> scheduleget(token, scheduleid)

Search and view details of a specific schedule slot

Allows the user to view the details of schedule shifts for any user role that the user has permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val scheduleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule.
try {
    apiInstance.scheduleget(token, scheduleid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduleget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduleget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **scheduleid** | [**java.util.UUID**](.md)| The id of the schedule. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="schedulegetmine"></a>
# **schedulegetmine**
> schedulegetmine(token, scheduleid)

View details of a specific schedule block, for current user

Allows the user to view the details of their own schedule shifts.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val scheduleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule.
try {
    apiInstance.schedulegetmine(token, scheduleid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulegetmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulegetmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **scheduleid** | [**java.util.UUID**](.md)| The id of the schedule. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="schedulegetstaff"></a>
# **schedulegetstaff**
> schedulegetstaff(token, userid)

View a list of schedule information of a specified person

Allows the user to view the schedule shifts for user roles that the user has permission to access.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to get info.
try {
    apiInstance.schedulegetstaff(token, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulegetstaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulegetstaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to get info. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="schedulegetstaffmine"></a>
# **schedulegetstaffmine**
> schedulegetstaffmine(token)

View current user&#39;s schedule information

Allows the user to view their own schedule.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.schedulegetstaffmine(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulegetstaffmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulegetstaffmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleintegrationdeleteitem"></a>
# **scheduleintegrationdeleteitem**
> scheduleintegrationdeleteitem(token, thirdpartyid)

Delete a schedule item looking up by a third party ID

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val thirdpartyid : kotlin.String = thirdpartyid_example // kotlin.String | The third party id to search the schedule block / appointment.
try {
    apiInstance.scheduleintegrationdeleteitem(token, thirdpartyid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduleintegrationdeleteitem")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduleintegrationdeleteitem")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **thirdpartyid** | **kotlin.String**| The third party id to search the schedule block / appointment. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleintegrationdeleteitemsbymasterid"></a>
# **scheduleintegrationdeleteitemsbymasterid**
> scheduleintegrationdeleteitemsbymasterid(token, thirdpartymasterid)

Delete multiple schedule items looking up by a third party master ID

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val thirdpartymasterid : kotlin.String = thirdpartymasterid_example // kotlin.String | The third party master id to search the schedule items.
try {
    apiInstance.scheduleintegrationdeleteitemsbymasterid(token, thirdpartymasterid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduleintegrationdeleteitemsbymasterid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduleintegrationdeleteitemsbymasterid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **thirdpartymasterid** | **kotlin.String**| The third party master id to search the schedule items. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleintegrationgetitem"></a>
# **scheduleintegrationgetitem**
> scheduleintegrationgetitem(token, thirdpartyid)

Get a schedule item looking up by a third party ID

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val thirdpartyid : kotlin.String = thirdpartyid_example // kotlin.String | The third party id to search for the schedule item.
try {
    apiInstance.scheduleintegrationgetitem(token, thirdpartyid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduleintegrationgetitem")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduleintegrationgetitem")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **thirdpartyid** | **kotlin.String**| The third party id to search for the schedule item. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="scheduleintegrationsaveitem"></a>
# **scheduleintegrationsaveitem**
> scheduleintegrationsaveitem(UNKNOWN_BASE_TYPE)

Save a schedule item looking up by a third party ID

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.scheduleintegrationsaveitem(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduleintegrationsaveitem")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduleintegrationsaveitem")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="scheduleintegrationsetid"></a>
# **scheduleintegrationsetid**
> scheduleintegrationsetid(token, id, thirdpartyid, thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule block / appointment.
val thirdpartyid : kotlin.String = thirdpartyid_example // kotlin.String | The 3rd party ID to set.
val thirdpartymasterid : kotlin.String = thirdpartymasterid_example // kotlin.String | The 3rd party master ID to set (useful to handle recurring items).
try {
    apiInstance.scheduleintegrationsetid(token, id, thirdpartyid, thirdpartymasterid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#scheduleintegrationsetid")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#scheduleintegrationsetid")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the schedule block / appointment. |
 **thirdpartyid** | **kotlin.String**| The 3rd party ID to set. |
 **thirdpartymasterid** | **kotlin.String**| The 3rd party master ID to set (useful to handle recurring items). | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="schedulemyofftimes"></a>
# **schedulemyofftimes**
> schedulemyofftimes(token, includedeleted, onlyupcoming, modifiedafter)

View current user&#39;s schedule exceptions

Allows the user to view their own schedule exceptions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val includedeleted : kotlin.Boolean = true // kotlin.Boolean | If true the deleted offtimes are also returned.
val onlyupcoming : kotlin.Boolean = true // kotlin.Boolean | If true then only upcoming offtimes are returned.
val modifiedafter : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | If specified, only offtimes modified after the specified date will be returned.
try {
    apiInstance.schedulemyofftimes(token, includedeleted, onlyupcoming, modifiedafter)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulemyofftimes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulemyofftimes")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **includedeleted** | **kotlin.Boolean**| If true the deleted offtimes are also returned. | [optional]
 **onlyupcoming** | **kotlin.Boolean**| If true then only upcoming offtimes are returned. | [optional]
 **modifiedafter** | **java.time.OffsetDateTime**| If specified, only offtimes modified after the specified date will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="schedulesave"></a>
# **schedulesave**
> schedulesave(UNKNOWN_BASE_TYPE)

Create or edit a schedule slot

Allows the user to create or edit a schedule slot of another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.schedulesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="schedulesavemine"></a>
# **schedulesavemine**
> schedulesavemine(UNKNOWN_BASE_TYPE)

Create or edit a block in current user&#39;s schedule

Allows the user to create or edit a schedule shift in their own availability.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.schedulesavemine(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#schedulesavemine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#schedulesavemine")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="search"></a>
# **search**
> search(token, query, page)

Search

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val query : kotlin.String = query_example // kotlin.String | The query to search for.
val page : kotlin.Int = 56 // kotlin.Int | Current page to show, zero-based.
try {
    apiInstance.search(token, query, page)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#search")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#search")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **query** | **kotlin.String**| The query to search for. |
 **page** | **kotlin.Int**| Current page to show, zero-based. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="searchgetentities"></a>
# **searchgetentities**
> searchgetentities(token)

Get the information of the entities that can be searched

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.searchgetentities(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#searchgetentities")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#searchgetentities")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="securityassesspermission"></a>
# **securityassesspermission**
> securityassesspermission(token, commandname)

Returns the list of users for a specific permission

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val commandname : kotlin.String = commandname_example // kotlin.String | Name of the action or command to get the roles.
try {
    apiInstance.securityassesspermission(token, commandname)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#securityassesspermission")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#securityassesspermission")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **commandname** | **kotlin.String**| Name of the action or command to get the roles. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="securityassessrole"></a>
# **securityassessrole**
> securityassessrole(token, roleid)

Returns the list of permissions for a specific role

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Role ID to list the effective permissions.
try {
    apiInstance.securityassessrole(token, roleid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#securityassessrole")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#securityassessrole")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **roleid** | [**java.util.UUID**](.md)| Role ID to list the effective permissions. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="securityassessscope"></a>
# **securityassessscope**
> securityassessscope(token, locationid)

Returns the list of users for a specific user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Location ID to list the users with that scope.
try {
    apiInstance.securityassessscope(token, locationid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#securityassessscope")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#securityassessscope")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **locationid** | [**java.util.UUID**](.md)| Location ID to list the users with that scope. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="securityassessuser"></a>
# **securityassessuser**
> securityassessuser(token, userid)

Returns the list of permissions for a specific user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | User ID to list the effective permissions.
try {
    apiInstance.securityassessuser(token, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#securityassessuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#securityassessuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| User ID to list the effective permissions. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="seminardelete"></a>
# **seminardelete**
> seminardelete(token, id)

Delete an event

Allows the user to delete an existing event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the seminar to delete.
try {
    apiInstance.seminardelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#seminardelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#seminardelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the seminar to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="seminarget"></a>
# **seminarget**
> seminarget(token, id)

Search and view details of a event

Allows the user to view a event and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the seminar to get.
try {
    apiInstance.seminarget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#seminarget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#seminarget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the seminar to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="seminarlist"></a>
# **seminarlist**
> seminarlist(token, from, count, summaryonly, termid)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.String = from_example // kotlin.String | The first record to return.
val count : kotlin.String = count_example // kotlin.String | The max number of records to return.
val summaryonly : kotlin.Boolean = true // kotlin.Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the term to list the events. Null to list all events.
try {
    apiInstance.seminarlist(token, from, count, summaryonly, termid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#seminarlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#seminarlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.String**| The first record to return. |
 **count** | **kotlin.String**| The max number of records to return. |
 **summaryonly** | **kotlin.Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**java.util.UUID**](.md)| Id of the term to list the events. Null to list all events. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="seminarsave"></a>
# **seminarsave**
> seminarsave(UNKNOWN_BASE_TYPE)

Create or edit a event

Allows the user to create or edit a event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.seminarsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#seminarsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#seminarsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="serviceassignmentaddservice"></a>
# **serviceassignmentaddservice**
> serviceassignmentaddservice(token, serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to add.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location.
try {
    apiInstance.serviceassignmentaddservice(token, serviceid, locationid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#serviceassignmentaddservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#serviceassignmentaddservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to add. |
 **locationid** | [**java.util.UUID**](.md)| The id of the location. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="serviceassignmentgetlocation"></a>
# **serviceassignmentgetlocation**
> serviceassignmentgetlocation(token, locationid, includegloballyavailable, namefilter, count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to get.
val includegloballyavailable : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the services available globally must be returned or not.
val namefilter : kotlin.Boolean = true // kotlin.Boolean | Filters the name of the services to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of services to return.
try {
    apiInstance.serviceassignmentgetlocation(token, locationid, includegloballyavailable, namefilter, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#serviceassignmentgetlocation")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#serviceassignmentgetlocation")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **locationid** | [**java.util.UUID**](.md)| The id of the location to get. |
 **includegloballyavailable** | **kotlin.Boolean**| Specifies whether the services available globally must be returned or not. | [optional]
 **namefilter** | **kotlin.Boolean**| Filters the name of the services to return. | [optional]
 **count** | **kotlin.Int**| The max number of services to return. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="serviceassignmentgetservice"></a>
# **serviceassignmentgetservice**
> serviceassignmentgetservice(token, serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to get its locations.
try {
    apiInstance.serviceassignmentgetservice(token, serviceid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#serviceassignmentgetservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#serviceassignmentgetservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to get its locations. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="serviceassignmentremoveservice"></a>
# **serviceassignmentremoveservice**
> serviceassignmentremoveservice(token, serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to remove.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to remove the service from.
try {
    apiInstance.serviceassignmentremoveservice(token, serviceid, locationid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#serviceassignmentremoveservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#serviceassignmentremoveservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service to remove. |
 **locationid** | [**java.util.UUID**](.md)| The id of the location to remove the service from. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="servicedelete"></a>
# **servicedelete**
> servicedelete(token, id)

Delete a service

Allows the user to delete a service from the existing list.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to delete.
try {
    apiInstance.servicedelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#servicedelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#servicedelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the service to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="serviceget"></a>
# **serviceget**
> serviceget(token, id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service to get.
try {
    apiInstance.serviceget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#serviceget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#serviceget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the service to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="servicelist"></a>
# **servicelist**
> servicelist(token, from, count)

View a list of services

Allows the user to view the full list of existing services.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.servicelist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#servicelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#servicelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="servicesave"></a>
# **servicesave**
> servicesave(UNKNOWN_BASE_TYPE)

Create or edit a service

Allows the user to create or edit a service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.servicesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#servicesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#servicesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="sessionattendancelogaddnote"></a>
# **sessionattendancelogaddnote**
> sessionattendancelogaddnote(token, id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log.
val text : kotlin.String = text_example // kotlin.String | The text of the note to add.
try {
    apiInstance.sessionattendancelogaddnote(token, id, text)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendancelogaddnote")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendancelogaddnote")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the attendance log. |
 **text** | **kotlin.String**| The text of the note to add. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogget"></a>
# **sessionattendancelogget**
> sessionattendancelogget(token, id, photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.sessionattendancelogget(token, id, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendancelogget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendancelogget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendanceloggetuser"></a>
# **sessionattendanceloggetuser**
> sessionattendanceloggetuser(attendee, eventid, token)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val attendee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendee to get statistic for.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose attendee statistics have to be returned.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.sessionattendanceloggetuser(attendee, eventid, token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendanceloggetuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendanceloggetuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**java.util.UUID**](.md)| The id of the attendee to get statistic for. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event whose attendee statistics have to be returned. |
 **token** | **kotlin.String**| The authentication token. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendanceloglist"></a>
# **sessionattendanceloglist**
> sessionattendanceloglist(token, session, from, count, photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val session : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the session whose attendees logs have to be returned.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.sessionattendanceloglist(token, session, from, count, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendanceloglist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendanceloglist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **session** | [**java.util.UUID**](.md)| The id of the session whose attendees logs have to be returned. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendanceloglistevent"></a>
# **sessionattendanceloglistevent**
> sessionattendanceloglistevent(eventid, token)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose attendance has to be returned.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.sessionattendanceloglistevent(eventid, token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendanceloglistevent")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendanceloglistevent")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event whose attendance has to be returned. |
 **token** | **kotlin.String**| The authentication token. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendanceloglistsummary"></a>
# **sessionattendanceloglistsummary**
> sessionattendanceloglistsummary(token, eventid, attendeeid, groupid, start, end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose attendance has to be returned.
val attendeeid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendee whose attendance has to be returned.
val groupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group whose attendance has to be returned.
val start : kotlin.String = start_example // kotlin.String | The start date to filter (beginning of time by default).
val end : kotlin.String = end_example // kotlin.String | The end date to filter (today by default).
try {
    apiInstance.sessionattendanceloglistsummary(token, eventid, attendeeid, groupid, start, end)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendanceloglistsummary")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendanceloglistsummary")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event whose attendance has to be returned. | [optional]
 **attendeeid** | [**java.util.UUID**](.md)| The id of the attendee whose attendance has to be returned. | [optional]
 **groupid** | [**java.util.UUID**](.md)| The id of the group whose attendance has to be returned. | [optional]
 **start** | **kotlin.String**| The start date to filter (beginning of time by default). | [optional]
 **end** | **kotlin.String**| The end date to filter (today by default). | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogmylistsummary"></a>
# **sessionattendancelogmylistsummary**
> sessionattendancelogmylistsummary(token, eventid, start, end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose attendance has to be returned.
val start : kotlin.String = start_example // kotlin.String | The start date to filter (beginning of time by default).
val end : kotlin.String = end_example // kotlin.String | The end date to filter (today by default).
try {
    apiInstance.sessionattendancelogmylistsummary(token, eventid, start, end)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendancelogmylistsummary")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendancelogmylistsummary")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event whose attendance has to be returned. | [optional]
 **start** | **kotlin.String**| The start date to filter (beginning of time by default). | [optional]
 **end** | **kotlin.String**| The end date to filter (today by default). | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogsave"></a>
# **sessionattendancelogsave**
> sessionattendancelogsave(UNKNOWN_BASE_TYPE)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionattendancelogsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendancelogsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendancelogsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="sessionattendancelogsaveswipe"></a>
# **sessionattendancelogsaveswipe**
> sessionattendancelogsaveswipe(UNKNOWN_BASE_TYPE)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionattendancelogsaveswipe(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionattendancelogsaveswipe")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionattendancelogsaveswipe")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="sessionbulkupdate"></a>
# **sessionbulkupdate**
> sessionbulkupdate(token, eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to bulk update.
val sessions : kotlin.String = sessions_example // kotlin.String | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.
try {
    apiInstance.sessionbulkupdate(token, eventid, sessions)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionbulkupdate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionbulkupdate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event to bulk update. |
 **sessions** | **kotlin.String**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionget"></a>
# **sessionget**
> sessionget(token, id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the session to get.
try {
    apiInstance.sessionget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the session to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessiongetschedule"></a>
# **sessiongetschedule**
> sessiongetschedule(token, day, attendee, location, instructor)

Gets the schedule for a location, instructor or attendees

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val day : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The day to return. It will also return the whole week for that day.
val attendee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendee to get the schedule.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to get the schedule.
val instructor : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the instructor to get the schedule.
try {
    apiInstance.sessiongetschedule(token, day, attendee, location, instructor)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessiongetschedule")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessiongetschedule")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. | [optional]
 **day** | **java.time.OffsetDateTime**| The day to return. It will also return the whole week for that day. | [optional]
 **attendee** | [**java.util.UUID**](.md)| The id of the attendee to get the schedule. | [optional]
 **location** | [**java.util.UUID**](.md)| The id of the location to get the schedule. | [optional]
 **instructor** | [**java.util.UUID**](.md)| The id of the instructor to get the schedule. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionlist"></a>
# **sessionlist**
> sessionlist(from, count, token, startdate, enddate)

Gets all future sessions of the current semester

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date to filter the sessions
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date to filter the sessions.
try {
    apiInstance.sessionlist(from, count, token, startdate, enddate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **token** | **kotlin.String**| The authentication token. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date to filter the sessions | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date to filter the sessions. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregaddcurrentuser"></a>
# **sessionregaddcurrentuser**
> sessionregaddcurrentuser(token, eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
try {
    apiInstance.sessionregaddcurrentuser(token, eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionregaddcurrentuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionregaddcurrentuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregadduser"></a>
# **sessionregadduser**
> sessionregadduser(token, userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
try {
    apiInstance.sessionregadduser(token, userid, eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionregadduser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionregadduser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionreggetmysessions"></a>
# **sessionreggetmysessions**
> sessionreggetmysessions(token, date)

View all the sessions the logged user is registered to

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val date : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | Start date to filter the sessions.
try {
    apiInstance.sessionreggetmysessions(token, date)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionreggetmysessions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionreggetmysessions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **date** | **java.time.OffsetDateTime**| Start date to filter the sessions. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionreggetsessions"></a>
# **sessionreggetsessions**
> sessionreggetsessions(token, userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id to list sessions.
try {
    apiInstance.sessionreggetsessions(token, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionreggetsessions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionreggetsessions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The user id to list sessions. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionreggetsettings"></a>
# **sessionreggetsettings**
> sessionreggetsettings(token, locationid, eventid, sessiondate, noinherit)

Get the settings for session registration

Allows the user to view a event&#39;s session registration settings.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to save settings.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to save settings.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
val noinherit : kotlin.Boolean = true // kotlin.Boolean | True to get the location/event/session specific settings without looking for the more global settings.
try {
    apiInstance.sessionreggetsettings(token, locationid, eventid, sessiondate, noinherit)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionreggetsettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionreggetsettings")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **locationid** | [**java.util.UUID**](.md)| The id of the location to save settings. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event to save settings. | [optional]
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. | [optional]
 **noinherit** | **kotlin.Boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionreggetusers"></a>
# **sessionreggetusers**
> sessionreggetusers(token, eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The event id to list sessions.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date of the session to find.
try {
    apiInstance.sessionreggetusers(token, eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionreggetusers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionreggetusers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The event id to list sessions. |
 **sessiondate** | **java.time.OffsetDateTime**| The date of the session to find. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionreglistsessions"></a>
# **sessionreglistsessions**
> sessionreglistsessions(token, eventid, sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The event id to list sessions.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date of the session to find.
try {
    apiInstance.sessionreglistsessions(token, eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionreglistsessions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionreglistsessions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The event id to list sessions. |
 **sessiondate** | **java.time.OffsetDateTime**| The date of the session to find. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionreglistupcoming"></a>
# **sessionreglistupcoming**
> sessionreglistupcoming(token, date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val date : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | Only sessions in the week of the specified date will be returned.
try {
    apiInstance.sessionreglistupcoming(token, date)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionreglistupcoming")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionreglistupcoming")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **date** | **java.time.OffsetDateTime**| Only sessions in the week of the specified date will be returned. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionreglistupcomingevent"></a>
# **sessionreglistupcomingevent**
> sessionreglistupcomingevent(token, date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val date : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | Start date to filter the returned sessions.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose sessions will be returned
try {
    apiInstance.sessionreglistupcomingevent(token, date, event)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionreglistupcomingevent")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionreglistupcomingevent")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **date** | **java.time.OffsetDateTime**| Start date to filter the returned sessions. |
 **event** | [**java.util.UUID**](.md)| The id of the event whose sessions will be returned |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregremovecurrentuser"></a>
# **sessionregremovecurrentuser**
> sessionregremovecurrentuser(token, eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
try {
    apiInstance.sessionregremovecurrentuser(token, eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionregremovecurrentuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionregremovecurrentuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregremoveuser"></a>
# **sessionregremoveuser**
> sessionregremoveuser(token, userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
try {
    apiInstance.sessionregremoveuser(token, userid, eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionregremoveuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionregremoveuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregsavesettings"></a>
# **sessionregsavesettings**
> sessionregsavesettings(UNKNOWN_BASE_TYPE)

Save the settings for an event&#39;s session registration

Allows the user to save the settings for an event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionregsavesettings(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionregsavesettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionregsavesettings")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="sessionswipedelete"></a>
# **sessionswipedelete**
> sessionswipedelete(token, id)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the session swipe to delete.
try {
    apiInstance.sessionswipedelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionswipedelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionswipedelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the session swipe to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionswipeget"></a>
# **sessionswipeget**
> sessionswipeget(token, id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the swipe to get.
try {
    apiInstance.sessionswipeget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionswipeget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionswipeget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the swipe to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionswipelistunresolved"></a>
# **sessionswipelistunresolved**
> sessionswipelistunresolved(from, count, token)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.sessionswipelistunresolved(from, count, token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionswipelistunresolved")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionswipelistunresolved")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **token** | **kotlin.String**| The authentication token. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionswiperesolve"></a>
# **sessionswiperesolve**
> sessionswiperesolve(token, id, session, user)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the swipe to resolve.
val session : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the session whose swipe has to be saved.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user who signed-in.
try {
    apiInstance.sessionswiperesolve(token, id, session, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionswiperesolve")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionswiperesolve")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the swipe to resolve. |
 **session** | [**java.util.UUID**](.md)| The id of the session whose swipe has to be saved. | [optional]
 **user** | [**java.util.UUID**](.md)| The id of the user who signed-in. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionswipesave"></a>
# **sessionswipesave**
> sessionswipesave(UNKNOWN_BASE_TYPE)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionswipesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionswipesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionswipesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="sessionswipesaveanonym"></a>
# **sessionswipesaveanonym**
> sessionswipesaveanonym(UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionswipesaveanonym(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#sessionswipesaveanonym")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#sessionswipesaveanonym")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="settingaddlogo"></a>
# **settingaddlogo**
> settingaddlogo(token, upload, filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The original filename, needed to process the file.
try {
    apiInstance.settingaddlogo(token, upload, filename)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#settingaddlogo")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#settingaddlogo")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The original filename, needed to process the file. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="settingget"></a>
# **settingget**
> settingget(keys, token, domain, scope)

Get settings for the account or the specified scope

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val keys : kotlin.String = keys_example // kotlin.String | The option keys to get values for. Enter multiple separated by comma.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val domain : kotlin.String = domain_example // kotlin.String | The account domain, in case of reading settings annonymously.
val scope : kotlin.String = scope_example // kotlin.String | The scope of the settings to get.
try {
    apiInstance.settingget(keys, token, domain, scope)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#settingget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#settingget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **kotlin.String**| The option keys to get values for. Enter multiple separated by comma. |
 **token** | **kotlin.String**| The authentication token. | [optional]
 **domain** | **kotlin.String**| The account domain, in case of reading settings annonymously. | [optional]
 **scope** | **kotlin.String**| The scope of the settings to get. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="settingsave"></a>
# **settingsave**
> settingsave(UNKNOWN_BASE_TYPE)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.settingsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#settingsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#settingsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="settingviewgeneral"></a>
# **settingviewgeneral**
> settingviewgeneral(token)

View general settings for the account

Allows the user to view the settings&#39; general section.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.settingviewgeneral(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#settingviewgeneral")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#settingviewgeneral")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialcontacts"></a>
# **socialcontacts**
> socialcontacts(token, filter, showdefaultphoto)

Gets the list of contacts in the network

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val filter : kotlin.String = filter_example // kotlin.String | Text to filter results.
val showdefaultphoto : kotlin.Boolean = true // kotlin.Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
try {
    apiInstance.socialcontacts(token, filter, showdefaultphoto)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#socialcontacts")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#socialcontacts")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **filter** | **kotlin.String**| Text to filter results. | [optional]
 **showdefaultphoto** | **kotlin.Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupaddmembers"></a>
# **socialgroupaddmembers**
> socialgroupaddmembers(token, id, userids)

Adds new members to a group (which the user must own already)

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to add members to.
val userids : kotlin.String = userids_example // kotlin.String | Csv list of user Ids to add.
try {
    apiInstance.socialgroupaddmembers(token, id, userids)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#socialgroupaddmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#socialgroupaddmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| ID of the group to add members to. |
 **userids** | **kotlin.String**| Csv list of user Ids to add. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupdelete"></a>
# **socialgroupdelete**
> socialgroupdelete(token, id)

Deletes a group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to delete.
try {
    apiInstance.socialgroupdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#socialgroupdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#socialgroupdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| ID of the group to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgrouplist"></a>
# **socialgrouplist**
> socialgrouplist(token)

View all the groups the current user is in

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.socialgrouplist(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#socialgrouplist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#socialgrouplist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgrouplistmembers"></a>
# **socialgrouplistmembers**
> socialgrouplistmembers(token, id)

Lists the members of a group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to list members.
try {
    apiInstance.socialgrouplistmembers(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#socialgrouplistmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#socialgrouplistmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| ID of the group to list members. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupremovemembers"></a>
# **socialgroupremovemembers**
> socialgroupremovemembers(token, id, userids)

Removes members from a group (which the user must own already)

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to remove members from.
val userids : kotlin.String = userids_example // kotlin.String | Csv list of user Ids to remove.
try {
    apiInstance.socialgroupremovemembers(token, id, userids)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#socialgroupremovemembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#socialgroupremovemembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| ID of the group to remove members from. |
 **userids** | **kotlin.String**| Csv list of user Ids to remove. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupremovemyself"></a>
# **socialgroupremovemyself**
> socialgroupremovemyself(token, id)

Removes myself from an existent group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to remove me from.
try {
    apiInstance.socialgroupremovemyself(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#socialgroupremovemyself")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#socialgroupremovemyself")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| ID of the group to remove me from. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupsave"></a>
# **socialgroupsave**
> socialgroupsave(UNKNOWN_BASE_TYPE)

Saves a new group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.socialgroupsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#socialgroupsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#socialgroupsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="ssogeneratekey"></a>
# **ssogeneratekey**
> ssogeneratekey(token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.ssogeneratekey(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ssogeneratekey")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ssogeneratekey")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ssogetsettings"></a>
# **ssogetsettings**
> ssogetsettings(token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.ssogetsettings(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ssogetsettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ssogetsettings")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ssoissuetoken"></a>
# **ssoissuetoken**
> ssoissuetoken(key, username, expires)

Issue single sign-on token

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val key : kotlin.String = key_example // kotlin.String | The single sign-on key of the account.
val username : kotlin.String = username_example // kotlin.String | The email of the user to sign-on.
val expires : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the session should expire when inactive.
try {
    apiInstance.ssoissuetoken(key, username, expires)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ssoissuetoken")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ssoissuetoken")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **kotlin.String**| The single sign-on key of the account. |
 **username** | **kotlin.String**| The email of the user to sign-on. |
 **expires** | **kotlin.Boolean**| Specifies whether the session should expire when inactive. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ssosavesettings"></a>
# **ssosavesettings**
> ssosavesettings(UNKNOWN_BASE_TYPE)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.ssosavesettings(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#ssosavesettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#ssosavesettings")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="staffavailaddmetoallservices"></a>
# **staffavailaddmetoallservices**
> staffavailaddmetoallservices(token)

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.staffavailaddmetoallservices(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailaddmetoallservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailaddmetoallservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailaddmetoservice"></a>
# **staffavailaddmetoservice**
> staffavailaddmetoservice(token, serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service.
try {
    apiInstance.staffavailaddmetoservice(token, serviceid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailaddmetoservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailaddmetoservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailaddusertoallservices"></a>
# **staffavailaddusertoallservices**
> staffavailaddusertoallservices(token, userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
try {
    apiInstance.staffavailaddusertoallservices(token, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailaddusertoallservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailaddusertoallservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailaddusertoservice"></a>
# **staffavailaddusertoservice**
> staffavailaddusertoservice(token, userid, serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service.
try {
    apiInstance.staffavailaddusertoservice(token, userid, serviceid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailaddusertoservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailaddusertoservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailgetmyservices"></a>
# **staffavailgetmyservices**
> staffavailgetmyservices(token)

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.staffavailgetmyservices(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailgetmyservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailgetmyservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailgetservices"></a>
# **staffavailgetservices**
> staffavailgetservices(token, userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id to list services.
try {
    apiInstance.staffavailgetservices(token, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailgetservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailgetservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The user id to list services. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailgetusersforservice"></a>
# **staffavailgetusersforservice**
> staffavailgetusersforservice(token, serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The service id to list users.
try {
    apiInstance.staffavailgetusersforservice(token, serviceid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailgetusersforservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailgetusersforservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceid** | [**java.util.UUID**](.md)| The service id to list users. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavaillisttypes"></a>
# **staffavaillisttypes**
> staffavaillisttypes(token)

View all the availability types

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.staffavaillisttypes(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavaillisttypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavaillisttypes")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailremovemefromallservices"></a>
# **staffavailremovemefromallservices**
> staffavailremovemefromallservices(token)

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.staffavailremovemefromallservices(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailremovemefromallservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailremovemefromallservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailremovemefromservice"></a>
# **staffavailremovemefromservice**
> staffavailremovemefromservice(token, serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service.
try {
    apiInstance.staffavailremovemefromservice(token, serviceid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailremovemefromservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailremovemefromservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailremoveuserfromallservices"></a>
# **staffavailremoveuserfromallservices**
> staffavailremoveuserfromallservices(token, userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member&#39;s availability to all services.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
try {
    apiInstance.staffavailremoveuserfromallservices(token, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailremoveuserfromallservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailremoveuserfromallservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailremoveuserfromservice"></a>
# **staffavailremoveuserfromservice**
> staffavailremoveuserfromservice(token, userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member&#39;s service availability.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service.
try {
    apiInstance.staffavailremoveuserfromservice(token, userid, serviceid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailremoveuserfromservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailremoveuserfromservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailsetavailability"></a>
# **staffavailsetavailability**
> staffavailsetavailability(token, userid, availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user whose specific availability has to be set.
val availablefor : kotlin.String = availablefor_example // kotlin.String | Specific availability to set.
try {
    apiInstance.staffavailsetavailability(token, userid, availablefor)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailsetavailability")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailsetavailability")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user whose specific availability has to be set. |
 **availablefor** | **kotlin.String**| Specific availability to set. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailsetmyavailability"></a>
# **staffavailsetmyavailability**
> staffavailsetmyavailability(token, availablefor)

Change current user&#39;s availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val availablefor : kotlin.String = availablefor_example // kotlin.String | Specific availability to set.
try {
    apiInstance.staffavailsetmyavailability(token, availablefor)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#staffavailsetmyavailability")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#staffavailsetmyavailability")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **availablefor** | **kotlin.String**| Specific availability to set. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationdelete"></a>
# **stationdelete**
> stationdelete(token, id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to delete.
try {
    apiInstance.stationdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationget"></a>
# **stationget**
> stationget(token, id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
try {
    apiInstance.stationget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationgetcurrentterms"></a>
# **stationgetcurrentterms**
> stationgetcurrentterms(station)

Get all the current terms

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station whose account's current terms have to be retrieved.
try {
    apiInstance.stationgetcurrentterms(station)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationgetcurrentterms")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationgetcurrentterms")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationgetinfo"></a>
# **stationgetinfo**
> stationgetinfo(id, event)

Gets a the info to display in the sign-in station by it&#39;s ID.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event, to override the one by schedule.
try {
    apiInstance.stationgetinfo(id, event)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationgetinfo")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationgetinfo")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **event** | [**java.util.UUID**](.md)| The id of the event, to override the one by schedule. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationgetlicense"></a>
# **stationgetlicense**
> stationgetlicense(station)

Gets the current license information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : kotlin.String = station_example // kotlin.String | The id of the sign-in station whose account's license has to be retrieved.
try {
    apiInstance.stationgetlicense(station)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationgetlicense")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationgetlicense")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | **kotlin.String**| The id of the sign-in station whose account&#39;s license has to be retrieved. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationgetlocationsettings"></a>
# **stationgetlocationsettings**
> stationgetlocationsettings(location)

View the sign-in station settings of a specified location

Allows the user to view the location settings of a sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location whose station settings have to be returned.
try {
    apiInstance.stationgetlocationsettings(location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationgetlocationsettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationgetlocationsettings")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**java.util.UUID**](.md)| The id of the location whose station settings have to be returned. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationlist"></a>
# **stationlist**
> stationlist(token, from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.stationlist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="stationsave"></a>
# **stationsave**
> stationsave(UNKNOWN_BASE_TYPE)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.stationsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="stationsavemine"></a>
# **stationsavemine**
> stationsavemine(UNKNOWN_BASE_TYPE)

Create or edit a class attendance sign-in station for myself

Allows the user to create a class attendance sign-in station for a course for which they are available as staff.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.stationsavemine(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationsavemine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationsavemine")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="stationunlock"></a>
# **stationunlock**
> stationunlock(id, passcode, method)

Unlocks the sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to unlock.
val passcode : kotlin.String = passcode_example // kotlin.String | The passcode to unlock the station.
val method : kotlin.String = method_example // kotlin.String | The authentication method. Valid values are 'token' and 'cookie'.
try {
    apiInstance.stationunlock(id, passcode, method)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#stationunlock")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#stationunlock")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to unlock. |
 **passcode** | **kotlin.String**| The passcode to unlock the station. |
 **method** | **kotlin.String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="swipedelete"></a>
# **swipedelete**
> swipedelete(token, id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the swipe to delete.
try {
    apiInstance.swipedelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#swipedelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#swipedelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the swipe to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="swipeget"></a>
# **swipeget**
> swipeget(token, id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the swipe to get.
try {
    apiInstance.swipeget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#swipeget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#swipeget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the swipe to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="swipelist"></a>
# **swipelist**
> swipelist(from, count, token)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.swipelist(from, count, token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#swipelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#swipelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **token** | **kotlin.String**| The authentication token. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="swipesave"></a>
# **swipesave**
> swipesave(UNKNOWN_BASE_TYPE)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.swipesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#swipesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#swipesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="swipesaveanonym"></a>
# **swipesaveanonym**
> swipesaveanonym(UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.swipesaveanonym(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#swipesaveanonym")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#swipesaveanonym")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="tagdelete"></a>
# **tagdelete**
> tagdelete(token, id)

Delete a tag

Allows the user to delete an existing tag.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the tag to delete.
try {
    apiInstance.tagdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#tagdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#tagdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the tag to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="tagget"></a>
# **tagget**
> tagget(token, id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the tag to get.
try {
    apiInstance.tagget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#tagget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#tagget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the tag to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="taglist"></a>
# **taglist**
> taglist(token, group, from, count)

View a list of tags

Allows the user to view the list of tags.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val group : kotlin.String = group_example // kotlin.String | The group of the tags to return.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.taglist(token, group, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#taglist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#taglist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **group** | **kotlin.String**| The group of the tags to return. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="taglistgroups"></a>
# **taglistgroups**
> taglistgroups(token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag&#39;s settings.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.taglistgroups(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#taglistgroups")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#taglistgroups")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="tagsave"></a>
# **tagsave**
> tagsave(UNKNOWN_BASE_TYPE)

Create or edit a tag

Allows the user to create or edit a tag.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.tagsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#tagsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#tagsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="tagsearch"></a>
# **tagsearch**
> tagsearch(token, query, allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val query : kotlin.String = query_example // kotlin.String | The query to search tags. Use group:<group> to search in a specific group (mandatory).
val allowcreatingnew : kotlin.Boolean = true // kotlin.Boolean | Specifies whether an option to create a new tag should be retrieved.
try {
    apiInstance.tagsearch(token, query, allowcreatingnew)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#tagsearch")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#tagsearch")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **query** | **kotlin.String**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). |
 **allowcreatingnew** | **kotlin.Boolean**| Specifies whether an option to create a new tag should be retrieved. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateaddimage"></a>
# **templateaddimage**
> templateaddimage(token, template, upload, filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val template : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template where the image has to be added
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The local name of the uploaded file. For later reference.
try {
    apiInstance.templateaddimage(token, template, upload, filename)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templateaddimage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templateaddimage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **template** | [**java.util.UUID**](.md)| The id of the template where the image has to be added |
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The local name of the uploaded file. For later reference. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templatedelete"></a>
# **templatedelete**
> templatedelete(token, id)

Delete a template

Allows the user to delete an existing template.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template to delete.
try {
    apiInstance.templatedelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templatedelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templatedelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the template to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateemail"></a>
# **templateemail**
> templateemail(token, jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val jobid : kotlin.String = jobid_example // kotlin.String | The id of the job that is creating the templates.
val emailsubject : kotlin.String = emailsubject_example // kotlin.String | Args depending on the send-to flag.
val emailbody : kotlin.String = emailbody_example // kotlin.String | Args depending on the send-to flag.
val templatekind : kotlin.String = templatekind_example // kotlin.String | The kind of the template you're sending. It must be included in (badge, certificate).
val emailfrom : kotlin.String = emailfrom_example // kotlin.String | The name of the sender to be displayed in the receipients inbox
val emailreplyto : kotlin.String = emailreplyto_example // kotlin.String | The reply-to field for the emails.
try {
    apiInstance.templateemail(token, jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templateemail")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templateemail")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **jobid** | **kotlin.String**| The id of the job that is creating the templates. |
 **emailsubject** | **kotlin.String**| Args depending on the send-to flag. |
 **emailbody** | **kotlin.String**| Args depending on the send-to flag. |
 **templatekind** | **kotlin.String**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional]
 **emailfrom** | **kotlin.String**| The name of the sender to be displayed in the receipients inbox | [optional]
 **emailreplyto** | **kotlin.String**| The reply-to field for the emails. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templategenerate"></a>
# **templategenerate**
> templategenerate(token, template, source, singlefile, userid, forsending, role, filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val template : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template to generate.
val source : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The source key of the selected template data source.
val singlefile : kotlin.Boolean = true // kotlin.Boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
val userid : kotlin.String = userid_example // kotlin.String | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
val forsending : kotlin.Boolean = true // kotlin.Boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
val role : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
val filters : kotlin.String = filters_example // kotlin.String | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...
try {
    apiInstance.templategenerate(token, template, source, singlefile, userid, forsending, role, filters)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templategenerate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templategenerate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **template** | [**java.util.UUID**](.md)| The id of the template to generate. |
 **source** | [**java.util.UUID**](.md)| The source key of the selected template data source. |
 **singlefile** | **kotlin.Boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. |
 **userid** | **kotlin.String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional]
 **forsending** | **kotlin.Boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional]
 **role** | [**java.util.UUID**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional]
 **filters** | **kotlin.String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templateget"></a>
# **templateget**
> templateget(token, id)

View details of a template

Allows the user to view a template and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the template to get.
try {
    apiInstance.templateget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templateget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templateget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the template to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templategetgenerated"></a>
# **templategetgenerated**
> templategetgenerated(token, jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val jobid : kotlin.String = jobid_example // kotlin.String | The id of the job that is creating the templates.
try {
    apiInstance.templategetgenerated(token, jobid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templategetgenerated")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templategetgenerated")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **jobid** | **kotlin.String**| The id of the job that is creating the templates. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templatelist"></a>
# **templatelist**
> templatelist(token, from, count, kind, designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val kind : kotlin.String = kind_example // kotlin.String | The kind of the templates to return. It must be included in (badge, certificate).
val designedonly : kotlin.Boolean = true // kotlin.Boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.
try {
    apiInstance.templatelist(token, from, count, kind, designedonly)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templatelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templatelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **kind** | **kotlin.String**| The kind of the templates to return. It must be included in (badge, certificate). |
 **designedonly** | **kotlin.Boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templatelistsources"></a>
# **templatelistsources**
> templatelistsources(token, kind)

View a list of templates&#39; data sources

Allows the user to see tokens to be used in the template

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val kind : kotlin.String = kind_example // kotlin.String | The kind of the templates to return. It must be included in (badge, certificate).
try {
    apiInstance.templatelistsources(token, kind)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templatelistsources")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templatelistsources")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **kind** | **kotlin.String**| The kind of the templates to return. It must be included in (badge, certificate). |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="templatesave"></a>
# **templatesave**
> templatesave(UNKNOWN_BASE_TYPE)

Create or edit a template

Allows the user to create or edit a template.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.templatesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templatesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templatesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="templatesavelayout"></a>
# **templatesavelayout**
> templatesavelayout(UNKNOWN_BASE_TYPE)

Save the layout of a template

Allows the user to edit a template&#39;s layout.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.templatesavelayout(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#templatesavelayout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#templatesavelayout")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="termdelete"></a>
# **termdelete**
> termdelete(token, id)

Delete a term

Allows the user to delete a term from the existing list.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the term to delete.
try {
    apiInstance.termdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#termdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#termdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the term to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="termget"></a>
# **termget**
> termget(token, id)

Search and view details of a term

Allows the user to view a term and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the term to get.
try {
    apiInstance.termget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#termget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#termget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the term to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="termlist"></a>
# **termlist**
> termlist(token, from, count, notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val notpast : kotlin.Boolean = true // kotlin.Boolean | Specifies whether the terms in the past should be returned or not.
try {
    apiInstance.termlist(token, from, count, notpast)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#termlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#termlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. | [optional]
 **count** | **kotlin.Int**| The max number of records to return. | [optional]
 **notpast** | **kotlin.Boolean**| Specifies whether the terms in the past should be returned or not. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="termsave"></a>
# **termsave**
> termsave(UNKNOWN_BASE_TYPE)

Create and edit terms

Allows the user to create and edit terms.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.termsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#termsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#termsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="textcreditremaining"></a>
# **textcreditremaining**
> textcreditremaining(token)

Gets the remaining text credits for the account

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.textcreditremaining(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#textcreditremaining")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#textcreditremaining")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="texttoimage"></a>
# **texttoimage**
> texttoimage(token, text, fontcolor, fontsize, direction, width)

Generates a dynamic image from text

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val text : kotlin.String = text_example // kotlin.String | The text to convert to an image, use double pipes (||) as a new line.
val fontcolor : kotlin.String = fontcolor_example // kotlin.String | The color of the text, in hex format, without the #.
val fontsize : kotlin.Int = 56 // kotlin.Int | The size of the text, in points.
val direction : kotlin.String = direction_example // kotlin.String | Either vertical or horizontal, default horizontal.
val width : kotlin.Int = 56 // kotlin.Int | The image width in pixels (or height if the direction is vertical).
try {
    apiInstance.texttoimage(token, text, fontcolor, fontsize, direction, width)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#texttoimage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#texttoimage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **text** | **kotlin.String**| The text to convert to an image, use double pipes (||) as a new line. |
 **fontcolor** | **kotlin.String**| The color of the text, in hex format, without the #. | [optional]
 **fontsize** | **kotlin.Int**| The size of the text, in points. | [optional]
 **direction** | **kotlin.String**| Either vertical or horizontal, default horizontal. | [optional]
 **width** | **kotlin.Int**| The image width in pixels (or height if the direction is vertical). | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="translationget"></a>
# **translationget**
> translationget(token, universal)

Gets the translations of the specified values

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val universal : kotlin.String = universal_example // kotlin.String | Pipe separated list of universal text to be translated.
try {
    apiInstance.translationget(token, universal)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#translationget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#translationget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **universal** | **kotlin.String**| Pipe separated list of universal text to be translated. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="translationgetcachefile"></a>
# **translationgetcachefile**
> translationgetcachefile(token, account)

Get the file containing the translations

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val account : kotlin.String = account_example // kotlin.String | The id of the account whose translations file has to be retrieved.
try {
    apiInstance.translationgetcachefile(token, account)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#translationgetcachefile")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#translationgetcachefile")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. | [optional]
 **account** | **kotlin.String**| The id of the account whose translations file has to be retrieved. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="translationlist"></a>
# **translationlist**
> translationlist(token, filter, nondefaultonly, appdefaultasuniversal)

Lists all the available translations in the system

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val filter : kotlin.String = filter_example // kotlin.String | Text to search/filter translations.
val nondefaultonly : kotlin.Boolean = true // kotlin.Boolean | If true then it returns only the terms translated. Otherwise, it returns all.
val appdefaultasuniversal : kotlin.Boolean = true // kotlin.Boolean | If true then it uses the app default translation as the universal term.
try {
    apiInstance.translationlist(token, filter, nondefaultonly, appdefaultasuniversal)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#translationlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#translationlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **filter** | **kotlin.String**| Text to search/filter translations. | [optional]
 **nondefaultonly** | **kotlin.Boolean**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional]
 **appdefaultasuniversal** | **kotlin.Boolean**| If true then it uses the app default translation as the universal term. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="translationsave"></a>
# **translationsave**
> translationsave(UNKNOWN_BASE_TYPE)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.translationsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#translationsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#translationsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="userchangepwd"></a>
# **userchangepwd**
> userchangepwd(token, oldpass, newpass)

Change user&#39;s own password

Allows the user to change their own password.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val oldpass : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The old password of the authenticated user.
val newpass : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The new password of the authenticated user.
try {
    apiInstance.userchangepwd(token, oldpass, newpass)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userchangepwd")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userchangepwd")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **oldpass** | [**java.util.UUID**](.md)| The old password of the authenticated user. |
 **newpass** | [**java.util.UUID**](.md)| The new password of the authenticated user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userchangepwdbyreq"></a>
# **userchangepwdbyreq**
> userchangepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val changereq : kotlin.String = changereq_example // kotlin.String | The change password request ID sent by email to the user.
val newpass : kotlin.String = newpass_example // kotlin.String | The new password of the user.
try {
    apiInstance.userchangepwdbyreq(changereq, newpass)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userchangepwdbyreq")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userchangepwdbyreq")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **kotlin.String**| The change password request ID sent by email to the user. |
 **newpass** | **kotlin.String**| The new password of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userdelete"></a>
# **userdelete**
> userdelete(token, id)

Delete a user

Allows the user to delete a user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to delete.
try {
    apiInstance.userdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the user to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userfindsimilar"></a>
# **userfindsimilar**
> userfindsimilar(token, currentid, phonenumber, cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val currentid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the current user.
val phonenumber : kotlin.String = phonenumber_example // kotlin.String | A phone number to search for similar users.
val cardnumber : kotlin.String = cardnumber_example // kotlin.String | A card number to search for similar users.
try {
    apiInstance.userfindsimilar(token, currentid, phonenumber, cardnumber)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userfindsimilar")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userfindsimilar")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **currentid** | [**java.util.UUID**](.md)| The id of the current user. | [optional]
 **phonenumber** | **kotlin.String**| A phone number to search for similar users. | [optional]
 **cardnumber** | **kotlin.String**| A card number to search for similar users. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userget"></a>
# **userget**
> userget(token, id, photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.userget(token, id, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the user to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergetbycard"></a>
# **usergetbycard**
> usergetbycard(token, card, photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val card : kotlin.String = card_example // kotlin.String | The card number of the user to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.usergetbycard(token, card, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergetbycard")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergetbycard")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **card** | **kotlin.String**| The card number of the user to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupaddmember"></a>
# **usergroupaddmember**
> usergroupaddmember(token, userid, groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val groupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group.
try {
    apiInstance.usergroupaddmember(token, userid, groupid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergroupaddmember")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergroupaddmember")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **groupid** | [**java.util.UUID**](.md)| The id of the group. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupdelete"></a>
# **usergroupdelete**
> usergroupdelete(token, id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group to delete.
try {
    apiInstance.usergroupdelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergroupdelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergroupdelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the group to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupget"></a>
# **usergroupget**
> usergroupget(token, id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user group to get.
try {
    apiInstance.usergroupget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergroupget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergroupget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the user group to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupgetmembers"></a>
# **usergroupgetmembers**
> usergroupgetmembers(token, groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val groupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user group to get.
try {
    apiInstance.usergroupgetmembers(token, groupid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergroupgetmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergroupgetmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **groupid** | [**java.util.UUID**](.md)| The id of the user group to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupgetuser"></a>
# **usergroupgetuser**
> usergroupgetuser(token, userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to get his groups.
try {
    apiInstance.usergroupgetuser(token, userid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergroupgetuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergroupgetuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to get his groups. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergrouplist"></a>
# **usergrouplist**
> usergrouplist(token, from, count, type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val type : kotlin.String = type_example // kotlin.String | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.
try {
    apiInstance.usergrouplist(token, from, count, type)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergrouplist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergrouplist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. | [optional]
 **count** | **kotlin.Int**| The max number of records to return. | [optional]
 **type** | **kotlin.String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergrouprefresh"></a>
# **usergrouprefresh**
> usergrouprefresh(token, group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group to refresh.
try {
    apiInstance.usergrouprefresh(token, group)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergrouprefresh")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergrouprefresh")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **group** | [**java.util.UUID**](.md)| The ID of the group to refresh. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupremovemember"></a>
# **usergroupremovemember**
> usergroupremovemember(token, userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val groupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group.
try {
    apiInstance.usergroupremovemember(token, userid, groupid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergroupremovemember")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergroupremovemember")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **groupid** | [**java.util.UUID**](.md)| The id of the group. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupsave"></a>
# **usergroupsave**
> usergroupsave(UNKNOWN_BASE_TYPE)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usergroupsave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergroupsave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergroupsave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="usergrouptagmembers"></a>
# **usergrouptagmembers**
> usergrouptagmembers(token, group, tags)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group to save whose members have to be tagged.
val tags : kotlin.String = tags_example // kotlin.String | The tags to assign to the members of the specified group, in JSON format.
try {
    apiInstance.usergrouptagmembers(token, group, tags)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergrouptagmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergrouptagmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **group** | [**java.util.UUID**](.md)| The id of the group to save whose members have to be tagged. |
 **tags** | **kotlin.String**| The tags to assign to the members of the specified group, in JSON format. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupuntagmembers"></a>
# **usergroupuntagmembers**
> usergroupuntagmembers(token, group, tags)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group to save whose members have to be untagged.
val tags : kotlin.String = tags_example // kotlin.String | The tags to unassign from the members of the specified group, in JSON format.
try {
    apiInstance.usergroupuntagmembers(token, group, tags)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usergroupuntagmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usergroupuntagmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **group** | [**java.util.UUID**](.md)| The id of the group to save whose members have to be untagged. |
 **tags** | **kotlin.String**| The tags to unassign from the members of the specified group, in JSON format. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userlist"></a>
# **userlist**
> userlist(token, from, count, roleid, onlywithoutcard, photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the role to filter users by, or empty to return all users.
val onlywithoutcard : kotlin.String = onlywithoutcard_example // kotlin.String | If is 1 then only the users without a card are returned, otherwise all users are returned.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.userlist(token, from, count, roleid, onlywithoutcard, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **roleid** | [**java.util.UUID**](.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **kotlin.String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userloadphoto"></a>
# **userloadphoto**
> userloadphoto(token, upload, filename, userid, automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The local name of the uploaded file. For later reference.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
val automatch : kotlin.Boolean = true // kotlin.Boolean | Set this to true to find the specific user based on the file name. 
try {
    apiInstance.userloadphoto(token, upload, filename, userid, automatch)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userloadphoto")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userloadphoto")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The local name of the uploaded file. For later reference. | [optional]
 **userid** | [**java.util.UUID**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional]
 **automatch** | **kotlin.Boolean**| Set this to true to find the specific user based on the file name.  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usermovedata"></a>
# **usermovedata**
> usermovedata(token, source, destination)

Move data between users

Allows administrators to move data between users.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val source : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user that is the source of the data.
val destination : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user that is the destination of the data.
try {
    apiInstance.usermovedata(token, source, destination)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usermovedata")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usermovedata")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **source** | [**java.util.UUID**](.md)| The id of the user that is the source of the data. |
 **destination** | [**java.util.UUID**](.md)| The id of the user that is the destination of the data. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofiledelete"></a>
# **userprofiledelete**
> userprofiledelete(token, id)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user profile to delete.
try {
    apiInstance.userprofiledelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userprofiledelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userprofiledelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the user profile to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofileget"></a>
# **userprofileget**
> userprofileget(token, id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the profile question set.
try {
    apiInstance.userprofileget(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userprofileget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userprofileget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the profile question set. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofilegetallview"></a>
# **userprofilegetallview**
> userprofilegetallview(token, id)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to view, or empty for current user.
try {
    apiInstance.userprofilegetallview(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userprofilegetallview")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userprofilegetallview")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the user to view, or empty for current user. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofilelist"></a>
# **userprofilelist**
> userprofilelist(token, from, count)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.userprofilelist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userprofilelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userprofilelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. | [optional]
 **count** | **kotlin.Int**| The max number of records to return. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofilelistquestions"></a>
# **userprofilelistquestions**
> userprofilelistquestions(token)

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.userprofilelistquestions(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userprofilelistquestions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userprofilelistquestions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofilepreparestats"></a>
# **userprofilepreparestats**
> userprofilepreparestats(token, params)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val params : kotlin.String = params_example // kotlin.String | The ID of the group, specified as 'group=...'
try {
    apiInstance.userprofilepreparestats(token, params)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userprofilepreparestats")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userprofilepreparestats")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **params** | **kotlin.String**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofilesave"></a>
# **userprofilesave**
> userprofilesave(UNKNOWN_BASE_TYPE)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.userprofilesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userprofilesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userprofilesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="userprofilesaveanswers"></a>
# **userprofilesaveanswers**
> userprofilesaveanswers(UNKNOWN_BASE_TYPE)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.userprofilesaveanswers(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userprofilesaveanswers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userprofilesaveanswers")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="userrequestpwdchange"></a>
# **userrequestpwdchange**
> userrequestpwdchange(domain, email)

Requests a password change

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val domain : kotlin.String = domain_example // kotlin.String | The domain of the account where the user exists.
val email : kotlin.String = email_example // kotlin.String | The email of the user.
try {
    apiInstance.userrequestpwdchange(domain, email)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#userrequestpwdchange")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#userrequestpwdchange")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **kotlin.String**| The domain of the account where the user exists. |
 **email** | **kotlin.String**| The email of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usersave"></a>
# **usersave**
> usersave(UNKNOWN_BASE_TYPE)

Create or edit a user

Allows the user to create or edit a user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usersave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usersave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usersave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="usersavepwdchange"></a>
# **usersavepwdchange**
> usersavepwdchange(UNKNOWN_BASE_TYPE)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usersavepwdchange(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usersavepwdchange")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usersavepwdchange")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="usersettingsget"></a>
# **usersettingsget**
> usersettingsget(token, keys, user)

Lists available user settings

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val keys : kotlin.String = keys_example // kotlin.String | Setting key to get. Can be multiple separated by commas.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id whose settings have to be returned.
try {
    apiInstance.usersettingsget(token, keys, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usersettingsget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usersettingsget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **keys** | **kotlin.String**| Setting key to get. Can be multiple separated by commas. |
 **user** | [**java.util.UUID**](.md)| The user id whose settings have to be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usersettingsgetmultiple"></a>
# **usersettingsgetmultiple**
> usersettingsgetmultiple(token, keys, user)

Get multiple user settings

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val keys : kotlin.String = keys_example // kotlin.String | Setting key to get. Can be multiple separated by commas.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id whose settings have to be returned.
try {
    apiInstance.usersettingsgetmultiple(token, keys, user)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usersettingsgetmultiple")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usersettingsgetmultiple")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **keys** | **kotlin.String**| Setting key to get. Can be multiple separated by commas. |
 **user** | [**java.util.UUID**](.md)| The user id whose settings have to be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usersettingssave"></a>
# **usersettingssave**
> usersettingssave(UNKNOWN_BASE_TYPE)

Saves a user setting

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usersettingssave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usersettingssave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usersettingssave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="usersettingssavemultiple"></a>
# **usersettingssavemultiple**
> usersettingssavemultiple(UNKNOWN_BASE_TYPE)

Save multiple user settings at once

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usersettingssavemultiple(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#usersettingssavemultiple")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#usersettingssavemultiple")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="version"></a>
# **version**
> version(token)

Get current version information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.version(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#version")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#version")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="virtuallineaddmyself"></a>
# **virtuallineaddmyself**
> virtuallineaddmyself(token, waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val waitinglineid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the waiting line to join.
try {
    apiInstance.virtuallineaddmyself(token, waitinglineid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#virtuallineaddmyself")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#virtuallineaddmyself")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **waitinglineid** | [**java.util.UUID**](.md)| ID of the waiting line to join. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="virtuallinelist"></a>
# **virtuallinelist**
> virtuallinelist(token)

Lists waiting lines that have remote access enabled

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.virtuallinelist(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#virtuallinelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#virtuallinelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="virtuallineremovemyself"></a>
# **virtuallineremovemyself**
> virtuallineremovemyself(token)

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
try {
    apiInstance.virtuallineremovemyself(token)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#virtuallineremovemyself")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#virtuallineremovemyself")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineadduser"></a>
# **waitinglineadduser**
> waitinglineadduser(station, user, locationid, time, signinrole, roleid, services, eventid, staff, photosize)

Put user in a waiting line

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station.
val user : kotlin.String = user_example // kotlin.String | The user's card number.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The location's id where the swipe must be saved.
val time : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time of the swipe.
val signinrole : kotlin.String = signinrole_example // kotlin.String | Specifies if the sign-in is for an attendee or a staff member
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Specifies the role the user has selected in order to sign-in
val services : kotlin.String = services_example // kotlin.String | The services ids the user has selected.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event the user selected.
val staff : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff member the user selected.
val photosize : kotlin.Int = 56 // kotlin.Int | The swiping user's photo size.
try {
    apiInstance.waitinglineadduser(station, user, locationid, time, signinrole, roleid, services, eventid, staff, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#waitinglineadduser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#waitinglineadduser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station. |
 **user** | **kotlin.String**| The user&#39;s card number. |
 **locationid** | [**java.util.UUID**](.md)| The location&#39;s id where the swipe must be saved. | [optional]
 **time** | **java.time.OffsetDateTime**| The date and time of the swipe. | [optional]
 **signinrole** | **kotlin.String**| Specifies if the sign-in is for an attendee or a staff member | [optional]
 **roleid** | [**java.util.UUID**](.md)| Specifies the role the user has selected in order to sign-in | [optional]
 **services** | **kotlin.String**| The services ids the user has selected. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event the user selected. | [optional]
 **staff** | [**java.util.UUID**](.md)| The id of the staff member the user selected. | [optional]
 **photosize** | **kotlin.Int**| The swiping user&#39;s photo size. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglinedelete"></a>
# **waitinglinedelete**
> waitinglinedelete(token, id)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the line to delete.
try {
    apiInstance.waitinglinedelete(token, id)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#waitinglinedelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#waitinglinedelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the line to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineget"></a>
# **waitinglineget**
> waitinglineget(token, id, photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the waiting line to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.waitinglineget(token, id, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#waitinglineget")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#waitinglineget")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **id** | [**java.util.UUID**](.md)| The id of the waiting line to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineisuserin"></a>
# **waitinglineisuserin**
> waitinglineisuserin(station, time, user, location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station.
val time : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time of the swipe.
val user : kotlin.String = user_example // kotlin.String | The card number of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.waitinglineisuserin(station, time, user, location)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#waitinglineisuserin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#waitinglineisuserin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station. |
 **time** | **java.time.OffsetDateTime**| The date and time of the swipe. |
 **user** | **kotlin.String**| The card number of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglinelist"></a>
# **waitinglinelist**
> waitinglinelist(token, from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.waitinglinelist(token, from, count)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#waitinglinelist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#waitinglinelist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineremoveuser"></a>
# **waitinglineremoveuser**
> waitinglineremoveuser(token, waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val waitingline : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the waiting line whose item has to be removed.
val itemid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the item that has to be removed.
try {
    apiInstance.waitinglineremoveuser(token, waitingline, itemid)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#waitinglineremoveuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#waitinglineremoveuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **waitingline** | [**java.util.UUID**](.md)| The id of the waiting line whose item has to be removed. |
 **itemid** | [**java.util.UUID**](.md)| The ID of the item that has to be removed. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglinesave"></a>
# **waitinglinesave**
> waitinglinesave(UNKNOWN_BASE_TYPE)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.waitinglinesave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#waitinglinesave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#waitinglinesave")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="waitinglinesigninuser"></a>
# **waitinglinesigninuser**
> waitinglinesigninuser(token, waitingline, itemid, staff, photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = DefaultApi()
val token : kotlin.String = token_example // kotlin.String | The authentication token.
val waitingline : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the waiting line whose item needs to be signed-in.
val itemid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the item that has to be signed-in.
val staff : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff member selected to sign-in.
val photosize : kotlin.Int = 56 // kotlin.Int | The swiping user's photo size.
try {
    apiInstance.waitinglinesigninuser(token, waitingline, itemid, staff, photosize)
} catch (e: ClientException) {
    println("4xx response calling DefaultApi#waitinglinesigninuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DefaultApi#waitinglinesigninuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **kotlin.String**| The authentication token. |
 **waitingline** | [**java.util.UUID**](.md)| The id of the waiting line whose item needs to be signed-in. |
 **itemid** | [**java.util.UUID**](.md)| The ID of the item that has to be signed-in. |
 **staff** | [**java.util.UUID**](.md)| The id of the staff member selected to sign-in. |
 **photosize** | **kotlin.Int**| The swiping user&#39;s photo size. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

