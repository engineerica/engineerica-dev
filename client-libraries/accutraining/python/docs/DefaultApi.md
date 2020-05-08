# openapi_client.DefaultApi

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
[**attendancelogsave**](DefaultApi.md#attendancelogsave) | **POST** /attendancelogsave | Create or edit an attendance log
[**attendancelogsignout**](DefaultApi.md#attendancelogsignout) | **GET** /attendancelogsignout | Sign out an attendance log
[**attendancelogwhosin**](DefaultApi.md#attendancelogwhosin) | **GET** /attendancelogwhosin | View who&#39;s in a location
[**bgjobgetstatus**](DefaultApi.md#bgjobgetstatus) | **GET** /bgjobgetstatus | Get background job status
[**call_import**](DefaultApi.md#call_import) | **GET** /import | Import data into AccuCampus
[**captchagetchallenge**](DefaultApi.md#captchagetchallenge) | **GET** /captchagetchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captchagetimage**](DefaultApi.md#captchagetimage) | **GET** /captchagetimage | Gets a captcha image that the user must complete to do certain requests.
[**changelog**](DefaultApi.md#changelog) | **GET** /changelog | Get the application change log
[**clientget**](DefaultApi.md#clientget) | **GET** /clientget | Get client
[**clientlist**](DefaultApi.md#clientlist) | **GET** /clientlist | Gets the clients of the specified conference
[**clientsave**](DefaultApi.md#clientsave) | **POST** /clientsave | Saves a client
[**clientsendmessage**](DefaultApi.md#clientsendmessage) | **GET** /clientsendmessage | Send a message to a client
[**departmentdelete**](DefaultApi.md#departmentdelete) | **GET** /departmentdelete | Delete a college department
[**departmentget**](DefaultApi.md#departmentget) | **GET** /departmentget | Search and view details of a college department
[**departmentlist**](DefaultApi.md#departmentlist) | **GET** /departmentlist | View a list of college departments
[**departmentsave**](DefaultApi.md#departmentsave) | **POST** /departmentsave | Create or edit a college department
[**doc**](DefaultApi.md#doc) | **GET** /doc | Get the documentation
[**easyloginaddbgimage**](DefaultApi.md#easyloginaddbgimage) | **GET** /easyloginaddbgimage | Adds background image for the login
[**eventdelete**](DefaultApi.md#eventdelete) | **GET** /eventdelete | Delete a course
[**eventget**](DefaultApi.md#eventget) | **GET** /eventget | Search and view details of a course
[**eventgetsessionsbydate**](DefaultApi.md#eventgetsessionsbydate) | **GET** /eventgetsessionsbydate | View a list of courses by date
[**eventlist**](DefaultApi.md#eventlist) | **GET** /eventlist | View a list of courses
[**eventsave**](DefaultApi.md#eventsave) | **POST** /eventsave | Create or edit a course
[**eventsearchgroup**](DefaultApi.md#eventsearchgroup) | **GET** /eventsearchgroup | Searches for the available event groups
[**export**](DefaultApi.md#export) | **GET** /export | Export AccuCampus data
[**exportlisttypes**](DefaultApi.md#exportlisttypes) | **GET** /exportlisttypes | Lists available export types
[**featurelist**](DefaultApi.md#featurelist) | **GET** /featurelist | Lists the available features.
[**holidaylist**](DefaultApi.md#holidaylist) | **GET** /holidaylist | View a list of entered holidays
[**holidaysave**](DefaultApi.md#holidaysave) | **POST** /holidaysave | Create or edit a list of holidays
[**holidaysuggest**](DefaultApi.md#holidaysuggest) | **GET** /holidaysuggest | View the holiday suggestions in the given term
[**importlisttypes**](DefaultApi.md#importlisttypes) | **GET** /importlisttypes | Lists available import types
[**licenseacceptagreement**](DefaultApi.md#licenseacceptagreement) | **GET** /licenseacceptagreement | Accept the license agreement
[**licensegetagreementstatus**](DefaultApi.md#licensegetagreementstatus) | **GET** /licensegetagreementstatus | Check if license agreement has been accepted
[**licensegetcurrent**](DefaultApi.md#licensegetcurrent) | **GET** /licensegetcurrent | Gets the current license information
[**licenserenew**](DefaultApi.md#licenserenew) | **GET** /licenserenew | Contact Engineerica in order to renew the AccuCampus subscription
[**listtimezones**](DefaultApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**locationdelete**](DefaultApi.md#locationdelete) | **GET** /locationdelete | Delete a location
[**locationget**](DefaultApi.md#locationget) | **GET** /locationget | Search and view details of a location
[**locationlist**](DefaultApi.md#locationlist) | **GET** /locationlist | View a list of locations
[**locationsave**](DefaultApi.md#locationsave) | **POST** /locationsave | Create or edit a location
[**login**](DefaultApi.md#login) | **GET** /login | Login
[**logout**](DefaultApi.md#logout) | **GET** /logout | Logout
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
[**reportlist**](DefaultApi.md#reportlist) | **GET** /reportlist | View a list of available reports
[**reportpermissionsbyuser**](DefaultApi.md#reportpermissionsbyuser) | **GET** /reportpermissionsbyuser | Permissions by user report
[**reportprepare**](DefaultApi.md#reportprepare) | **GET** /reportprepare | Queries and loads the specified report, in background.
[**reportquery**](DefaultApi.md#reportquery) | **GET** /reportquery | Query and load a specified report
[**rolelist**](DefaultApi.md#rolelist) | **GET** /rolelist | Show a list of roles
[**ruledelete**](DefaultApi.md#ruledelete) | **GET** /ruledelete | Delete a rule
[**ruleget**](DefaultApi.md#ruleget) | **GET** /ruleget | View details of a rule
[**rulegeteventtype**](DefaultApi.md#rulegeteventtype) | **GET** /rulegeteventtype | View details of a rule event type
[**rulelist**](DefaultApi.md#rulelist) | **GET** /rulelist | View a list of user rules
[**rulelistactions**](DefaultApi.md#rulelistactions) | **GET** /rulelistactions | View a list of rule actions available
[**rulelisteventtypes**](DefaultApi.md#rulelisteventtypes) | **GET** /rulelisteventtypes | View a list of rule event types
[**rulelisthttprequests**](DefaultApi.md#rulelisthttprequests) | **GET** /rulelisthttprequests | View all the http requests sent as a result of a rule
[**rulesave**](DefaultApi.md#rulesave) | **POST** /rulesave | Create or edit a rule
[**search**](DefaultApi.md#search) | **GET** /search | Search
[**searchgetentities**](DefaultApi.md#searchgetentities) | **GET** /searchgetentities | Get the information of the entities that can be searched
[**securityassesspermission**](DefaultApi.md#securityassesspermission) | **GET** /securityassesspermission | Returns the list of users for a specific permission
[**securityassessrole**](DefaultApi.md#securityassessrole) | **GET** /securityassessrole | Returns the list of permissions for a specific role
[**securityassessscope**](DefaultApi.md#securityassessscope) | **GET** /securityassessscope | Returns the list of users for a specific user
[**securityassessuser**](DefaultApi.md#securityassessuser) | **GET** /securityassessuser | Returns the list of permissions for a specific user
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
[**settingaddlogo**](DefaultApi.md#settingaddlogo) | **GET** /settingaddlogo | Add a logo to the account
[**settingget**](DefaultApi.md#settingget) | **GET** /settingget | Get settings for the account or the specified scope
[**settingsave**](DefaultApi.md#settingsave) | **POST** /settingsave | Save settings for the account or the specified scope
[**settingviewgeneral**](DefaultApi.md#settingviewgeneral) | **GET** /settingviewgeneral | View general settings for the account
[**ssogeneratekey**](DefaultApi.md#ssogeneratekey) | **GET** /ssogeneratekey | Generate/reset single sign on access key.
[**ssogetsettings**](DefaultApi.md#ssogetsettings) | **GET** /ssogetsettings | View single sign on settings.
[**ssoissuetoken**](DefaultApi.md#ssoissuetoken) | **GET** /ssoissuetoken | Issue single sign-on token
[**ssosavesettings**](DefaultApi.md#ssosavesettings) | **POST** /ssosavesettings | Edit single sign-on settings.
[**stationdelete**](DefaultApi.md#stationdelete) | **GET** /stationdelete | Delete a sign-in station
[**stationget**](DefaultApi.md#stationget) | **GET** /stationget | View details of a sign-in station
[**stationgetcurrentterms**](DefaultApi.md#stationgetcurrentterms) | **GET** /stationgetcurrentterms | Get all the current terms
[**stationgetinfo**](DefaultApi.md#stationgetinfo) | **GET** /stationgetinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**stationgetlicense**](DefaultApi.md#stationgetlicense) | **GET** /stationgetlicense | Gets the current license information
[**stationlist**](DefaultApi.md#stationlist) | **GET** /stationlist | View a list of sign-in stations
[**stationsave**](DefaultApi.md#stationsave) | **POST** /stationsave | Create or edit a sign-in station
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
[**userlist**](DefaultApi.md#userlist) | **GET** /userlist | View a list of users
[**userloadphoto**](DefaultApi.md#userloadphoto) | **GET** /userloadphoto | Upload a photo for a specific user
[**usermovedata**](DefaultApi.md#usermovedata) | **GET** /usermovedata | Move data between users
[**userrequestpwdchange**](DefaultApi.md#userrequestpwdchange) | **GET** /userrequestpwdchange | Requests a password change
[**usersave**](DefaultApi.md#usersave) | **POST** /usersave | Create or edit a user
[**usersavepwdchange**](DefaultApi.md#usersavepwdchange) | **POST** /usersavepwdchange | Send email to the specified user(s) to set/change their passwords
[**usersettingsget**](DefaultApi.md#usersettingsget) | **GET** /usersettingsget | Lists available user settings
[**usersettingsgetmultiple**](DefaultApi.md#usersettingsgetmultiple) | **GET** /usersettingsgetmultiple | Get multiple user settings
[**usersettingssave**](DefaultApi.md#usersettingssave) | **POST** /usersettingssave | Saves a user setting
[**usersettingssavemultiple**](DefaultApi.md#usersettingssavemultiple) | **POST** /usersettingssavemultiple | Save multiple user settings at once
[**usertaskdeleteplan**](DefaultApi.md#usertaskdeleteplan) | **GET** /usertaskdeleteplan | Deletes a task plan
[**usertaskgetmine**](DefaultApi.md#usertaskgetmine) | **GET** /usertaskgetmine | Lists the task plans of the logged user
[**usertaskgetplan**](DefaultApi.md#usertaskgetplan) | **GET** /usertaskgetplan | Gets a task plan by Id
[**usertasklistdefs**](DefaultApi.md#usertasklistdefs) | **GET** /usertasklistdefs | Lists task types or definitions
[**usertasklistplan**](DefaultApi.md#usertasklistplan) | **GET** /usertasklistplan | Lists task plans
[**usertasksaveplan**](DefaultApi.md#usertasksaveplan) | **POST** /usertasksaveplan | Saves a task plan
[**version**](DefaultApi.md#version) | **GET** /version | Get current version information


# **actionassignmentdelete**
> actionassignmentdelete(token, id)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the action assignment to delete.

    try:
        # Remove an action item from an action plan
        api_instance.actionassignmentdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the action assignment to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentget**
> actionassignmentget(token, id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the action assignment to get.

    try:
        # Search and view details of an action item assigned to a user
        api_instance.actionassignmentget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the action assignment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentlist**
> actionassignmentlist(token, _from, count, assignee=assignee, status=status)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
assignee = 56 # int | The assignee's id to filter the assignments. (optional)
status = 56 # int | The status to filter the assignments. (optional)

    try:
        # View a list of action items in a user's plan
        api_instance.actionassignmentlist(token, _from, count, assignee=assignee, status=status)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentlisthistory**
> actionassignmentlisthistory(token, actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
actionassignment = 'actionassignment_example' # str | The action assignment's id whose history the user wants to get.

    try:
        # View the history of an action item assigned to a user
        api_instance.actionassignmentlisthistory(token, actionassignment)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentlisthistory: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **actionassignment** | [**str**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentlistmine**
> actionassignmentlistmine(token, _from, count, status=status)

List public action assignments assigned to the logged user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
status = 56 # int | The status to filter the assignments. (optional)

    try:
        # List public action assignments assigned to the logged user
        api_instance.actionassignmentlistmine(token, _from, count, status=status)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentlistmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentlistpublichistory**
> actionassignmentlistpublichistory(token, actionassignment)

List public action assignment history

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
actionassignment = 'actionassignment_example' # str | The action assignment's id whose history the user wants to get.

    try:
        # List public action assignment history
        api_instance.actionassignmentlistpublichistory(token, actionassignment)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentlistpublichistory: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **actionassignment** | [**str**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentmarkcomplete**
> actionassignmentmarkcomplete(token, item, assignee=assignee, group=group, notes=notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
item = 'item_example' # str | The action item to assign.
assignee = 'assignee_example' # str | The assignee of the item. (optional)
group = 'group_example' # str | The group to assing the item. (optional)
notes = 'notes_example' # str | The assignment's notes. (optional)

    try:
        # Bulk complete action items
        api_instance.actionassignmentmarkcomplete(token, item, assignee=assignee, group=group, notes=notes)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentmarkcomplete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **item** | **str**| The action item to assign. | 
 **assignee** | [**str**](.md)| The assignee of the item. | [optional] 
 **group** | [**str**](.md)| The group to assing the item. | [optional] 
 **notes** | **str**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentsave**
> actionassignmentsave(unknown_base_type=unknown_base_type)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Add an action item to a user's action plan
        api_instance.actionassignmentsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignmentsavehistory**
> actionassignmentsavehistory(unknown_base_type=unknown_base_type)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Update an action item assigned to a user
        api_instance.actionassignmentsavehistory(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionassignmentsavehistory: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitemdelete**
> actionitemdelete(token, id)

Delete an action item

Allows the user to delete an action item.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the action item to delete.

    try:
        # Delete an action item
        api_instance.actionitemdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionitemdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the action item to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitemget**
> actionitemget(token, id)

Search and view details of an action item

Allows the user to view an individual action item and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the action item to get.

    try:
        # Search and view details of an action item
        api_instance.actionitemget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionitemget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the action item to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitemlist**
> actionitemlist(token, _from, count)

View a list of action items

Allows the user to view a list of action items

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # View a list of action items
        api_instance.actionitemlist(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionitemlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionitemsave**
> actionitemsave(unknown_base_type=unknown_base_type)

Create or edit an action item

Allows the user to edit an action item.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit an action item
        api_instance.actionitemsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionitemsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionloglist**
> actionloglist(token, _from, count, user=user, startdate=startdate, enddate=enddate, resource=resource, actionfilter=actionfilter, argument=argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
user = 'user_example' # str | The id of the user whose action logs have to be returned. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the logs. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the logs. (optional)
resource = 'resource_example' # str | The resource to filter the action logs. (optional)
actionfilter = 'actionfilter_example' # str | The action to filter the action logs. (optional)
argument = 'argument_example' # str | The id of the entity that was the argument of the executed action. (optional)

    try:
        # View a list of users action logs
        api_instance.actionloglist(token, _from, count, user=user, startdate=startdate, enddate=enddate, resource=resource, actionfilter=actionfilter, argument=argument)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionloglist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **user** | [**str**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the logs. | [optional] 
 **resource** | **str**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **str**| The action to filter the action logs. | [optional] 
 **argument** | **str**| The id of the entity that was the argument of the executed action. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpackassign**
> actionpackassign(token, pack, itemsdata, assignee=assignee, group=group, notes=notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
pack = 'pack_example' # str | The id of the action pack to assign.
itemsdata = True # bool | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
assignee = 'assignee_example' # str | The assignee of the pack. (optional)
group = 'group_example' # str | The group to assign the pack. (optional)
notes = 'notes_example' # str | The assignment's notes. (optional)

    try:
        # Assign an action item pack to a user
        api_instance.actionpackassign(token, pack, itemsdata, assignee=assignee, group=group, notes=notes)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionpackassign: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **pack** | [**str**](.md)| The id of the action pack to assign. | 
 **itemsdata** | **bool**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **assignee** | [**str**](.md)| The assignee of the pack. | [optional] 
 **group** | [**str**](.md)| The group to assign the pack. | [optional] 
 **notes** | **str**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpackdelete**
> actionpackdelete(token, id)

Delete an action item pack

Allows the user to delete an action item pack.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the action pack to delete.

    try:
        # Delete an action item pack
        api_instance.actionpackdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionpackdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the action pack to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpackget**
> actionpackget(token, id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the action pack to get.

    try:
        # View details of an action item pack
        api_instance.actionpackget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionpackget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the action pack to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpacklist**
> actionpacklist(token, _from, count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # View a list of action item packs
        api_instance.actionpacklist(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionpacklist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpacksave**
> actionpacksave(unknown_base_type=unknown_base_type)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit an action item pack
        api_instance.actionpacksave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->actionpacksave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontypedelete**
> actiontypedelete(token, id)

Delete an action item type

Allows the user to delete an action item type.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the action type to delete.

    try:
        # Delete an action item type
        api_instance.actiontypedelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->actiontypedelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the action type to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontypeget**
> actiontypeget(token, id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the action type to get.

    try:
        # View details of an action item type
        api_instance.actiontypeget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->actiontypeget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the action type to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontypelist**
> actiontypelist(token, _from, count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # View a list of action item types
        api_instance.actiontypelist(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->actiontypelist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actiontypesave**
> actiontypesave(unknown_base_type=unknown_base_type)

Create or edit an action item type

Allows the user to dit an action item type.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit an action item type
        api_instance.actiontypesave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->actiontypesave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroleaddmissing**
> advroleaddmissing(token, roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
roles = 'roles_example' # str | CSV list of the role ids to check
permissions = 'permissions_example' # str | CSV list of the permissions to check

    try:
        # Adds the missing permissions to a role. Requires access to advrole.save
        api_instance.advroleaddmissing(token, roles, permissions)
    except ApiException as e:
        print("Exception when calling DefaultApi->advroleaddmissing: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **roles** | **str**| CSV list of the role ids to check | 
 **permissions** | **str**| CSV list of the permissions to check | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolecheckperm**
> advrolecheckperm(token, roles, permissions)

Checks the permissions are assigned for the given roles

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
roles = 'roles_example' # str | CSV list of the role ids to check
permissions = 'permissions_example' # str | CSV list of the permissions to check

    try:
        # Checks the permissions are assigned for the given roles
        api_instance.advrolecheckperm(token, roles, permissions)
    except ApiException as e:
        print("Exception when calling DefaultApi->advrolecheckperm: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **roles** | **str**| CSV list of the role ids to check | 
 **permissions** | **str**| CSV list of the permissions to check | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroledelete**
> advroledelete(token, id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the location to delete.

    try:
        # Delete a role
        api_instance.advroledelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->advroledelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the location to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroledeletemapping**
> advroledeletemapping(token, map, roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
map = 'map_example' # str | The map name to save the role.
roleid = 'roleid_example' # str | The id of the role.

    try:
        # Delete a role mapping
        api_instance.advroledeletemapping(token, map, roleid)
    except ApiException as e:
        print("Exception when calling DefaultApi->advroledeletemapping: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **map** | **str**| The map name to save the role. | 
 **roleid** | [**str**](.md)| The id of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroleget**
> advroleget(token, id)

View details of a role

Allows the user to view a role and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the location to get.

    try:
        # View details of a role
        api_instance.advroleget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->advroleget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolelist**
> advrolelist(token, includepolicies=includepolicies, includeinternal=includeinternal, name=name)

Lists the roles for the current account

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
includepolicies = True # bool | True to include the policies, defaults to false. (optional)
includeinternal = True # bool | True to include the internal roles too. (optional)
name = 'name_example' # str | Filter by name of the role. (optional)

    try:
        # Lists the roles for the current account
        api_instance.advrolelist(token, includepolicies=includepolicies, includeinternal=includeinternal, name=name)
    except ApiException as e:
        print("Exception when calling DefaultApi->advrolelist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **includepolicies** | **bool**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **bool**| True to include the internal roles too. | [optional] 
 **name** | **str**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolelistmaps**
> advrolelistmaps(token, roleid)

Lists the maps a roles is mapped to

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
roleid = 'roleid_example' # str | The id of the role to list the maps.

    try:
        # Lists the maps a roles is mapped to
        api_instance.advrolelistmaps(token, roleid)
    except ApiException as e:
        print("Exception when calling DefaultApi->advrolelistmaps: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **roleid** | [**str**](.md)| The id of the role to list the maps. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolelistrolesmapped**
> advrolelistrolesmapped(token, map=map)

Lists the roles mappings

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
map = 'map_example' # str | List only the roles in the specified map. (optional)

    try:
        # Lists the roles mappings
        api_instance.advrolelistrolesmapped(token, map=map)
    except ApiException as e:
        print("Exception when calling DefaultApi->advrolelistrolesmapped: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **map** | **str**| List only the roles in the specified map. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolelisttemplates**
> advrolelisttemplates(token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # View a list of role templates
        api_instance.advrolelisttemplates(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->advrolelisttemplates: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolesave**
> advrolesave(unknown_base_type=unknown_base_type)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a role
        api_instance.advrolesave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->advrolesave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolesavemapping**
> advrolesavemapping(unknown_base_type=unknown_base_type)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Saves a role mapping
        api_instance.advrolesavemapping(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->advrolesavemapping: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advrolesuserlist**
> advrolesuserlist(token, _from, count, roleid=roleid, onlywithoutcard=onlywithoutcard, photosize=photosize)

List users. Alias to user.list, use that one instead.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
roleid = 'roleid_example' # str | The id of the role to filter users by, or empty to return all users. (optional)
onlywithoutcard = 'onlywithoutcard_example' # str | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # List users. Alias to user.list, use that one instead.
        api_instance.advrolesuserlist(token, _from, count, roleid=roleid, onlywithoutcard=onlywithoutcard, photosize=photosize)
    except ApiException as e:
        print("Exception when calling DefaultApi->advrolesuserlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **roleid** | [**str**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **str**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **advroleuserupgrade**
> advroleuserupgrade(token, userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
userid = 'userid_example' # str | Id of the user to upgrade
roleid = 'roleid_example' # str | Id of the role to add

    try:
        # Upgrade a user to another role (requires permission to edit those roles)
        api_instance.advroleuserupgrade(token, userid, roleid)
    except ApiException as e:
        print("Exception when calling DefaultApi->advroleuserupgrade: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **userid** | [**str**](.md)| Id of the user to upgrade | 
 **roleid** | [**str**](.md)| Id of the role to add | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appsharegetphone**
> appsharegetphone(token)

Gets the phone number of the current user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Gets the phone number of the current user
        api_instance.appsharegetphone(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->appsharegetphone: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **appsharesendtext**
> appsharesendtext(token, phonenumber=phonenumber)

Sends an SMS with the link to the app

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
phonenumber = 'phonenumber_example' # str | Phone number to where to send the link. Leave empty to the number on file. (optional)

    try:
        # Sends an SMS with the link to the app
        api_instance.appsharesendtext(token, phonenumber=phonenumber)
    except ApiException as e:
        print("Exception when calling DefaultApi->appsharesendtext: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **phonenumber** | **str**| Phone number to where to send the link. Leave empty to the number on file. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcommentdelete**
> attendancelogcommentdelete(token, id)

Delete a comment on an attendance log

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the attendance log comment to delete.

    try:
        # Delete a comment on an attendance log
        api_instance.attendancelogcommentdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogcommentdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the attendance log comment to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcommentget**
> attendancelogcommentget(token, id)

View a comment on an attendance log

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the comment to get.

    try:
        # View a comment on an attendance log
        api_instance.attendancelogcommentget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogcommentget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the comment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcommentlist**
> attendancelogcommentlist(attendancelog, token=token)

View all the comments on a specific attendance log

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    attendancelog = 'attendancelog_example' # str | The id of the attendance log whose comments have to be retrieved.
token = 'token_example' # str | The authentication token. (optional)

    try:
        # View all the comments on a specific attendance log
        api_instance.attendancelogcommentlist(attendancelog, token=token)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogcommentlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**str**](.md)| The id of the attendance log whose comments have to be retrieved. | 
 **token** | **str**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogcommentsave**
> attendancelogcommentsave(unknown_base_type=unknown_base_type)

Save a comment on an attendance log

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Save a comment on an attendance log
        api_instance.attendancelogcommentsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogcommentsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogdelete**
> attendancelogdelete(token, id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the attendance log to delete.

    try:
        # Delete an attendance log
        api_instance.attendancelogdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the attendance log to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogget**
> attendancelogget(token, id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the attendance log to get.

    try:
        # Search and view details of an attendance log
        api_instance.attendancelogget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendanceloggetchangehistory**
> attendanceloggetchangehistory(token, id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the attendance log to get.

    try:
        # Search and view details of an attendance log's swipe history
        api_instance.attendanceloggetchangehistory(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendanceloggetchangehistory: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendanceloglist**
> attendanceloglist(_from, count, token=token, filter=filter, userid=userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
token = 'token_example' # str | The authentication token. (optional)
filter = 'filter_example' # str | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional)
userid = 'userid_example' # str | The user ID of the user to get the logs. (optional)

    try:
        # View a list of attendance logs
        api_instance.attendanceloglist(_from, count, token=token, filter=filter, userid=userid)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendanceloglist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **str**| The authentication token. | [optional] 
 **filter** | **str**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**str**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendanceloglistmine**
> attendanceloglistmine(_from, count, token=token, filter=filter)

Gets the attendance logs of the current user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
token = 'token_example' # str | The authentication token. (optional)
filter = 'filter_example' # str | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional)

    try:
        # Gets the attendance logs of the current user
        api_instance.attendanceloglistmine(_from, count, token=token, filter=filter)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendanceloglistmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **str**| The authentication token. | [optional] 
 **filter** | **str**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogsave**
> attendancelogsave(unknown_base_type=unknown_base_type)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit an attendance log
        api_instance.attendancelogsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogsignout**
> attendancelogsignout(token, id=id, location=location, event=event, datetime=datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the attendance log to sign-out. (optional)
location = 'location_example' # str | The id of the location to filter the users to sign out. (optional)
event = 'event_example' # str | The id of the event to filter the users to sign out. (optional)
datetime = '2013-10-20T19:20:30+01:00' # datetime | Specifies the date and time when the specified logs have to be signed out. (optional)

    try:
        # Sign out an attendance log
        api_instance.attendancelogsignout(token, id=id, location=location, event=event, datetime=datetime)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogsignout: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**str**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **event** | [**str**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **datetime**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelogwhosin**
> attendancelogwhosin(_from, count, token=token, location=location, event=event, sorting=sorting, roles=roles, photosize=photosize, extensions=extensions, export=export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
token = 'token_example' # str | The authentication token. (optional)
location = 'location_example' # str | The id of the location to search for users that are in. (optional)
event = 'event_example' # str | The id of the event to search for users that are in. (optional)
sorting = 'sorting_example' # str | Field to sort by. Either first-name, last-name or sign-in-time. (optional)
roles = 'roles_example' # str | The comma-separated list of ids of the roles to search for users that are in. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)
extensions = 'extensions_example' # str | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]). (optional)
export = True # bool | True to export the results as CSV (optional)

    try:
        # View who's in a location
        api_instance.attendancelogwhosin(_from, count, token=token, location=location, event=event, sorting=sorting, roles=roles, photosize=photosize, extensions=extensions, export=export)
    except ApiException as e:
        print("Exception when calling DefaultApi->attendancelogwhosin: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **str**| The authentication token. | [optional] 
 **location** | [**str**](.md)| The id of the location to search for users that are in. | [optional] 
 **event** | [**str**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **str**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **str**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **str**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **bool**| True to export the results as CSV | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bgjobgetstatus**
> bgjobgetstatus(token, jobid=jobid, jobtype=jobtype)

Get background job status

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
jobid = 'jobid_example' # str | The ID of the job to get the status. 10 most recent will be returned if not specified. (optional)
jobtype = 'jobtype_example' # str | The job type to filter by. (optional)

    try:
        # Get background job status
        api_instance.bgjobgetstatus(token, jobid=jobid, jobtype=jobtype)
    except ApiException as e:
        print("Exception when calling DefaultApi->bgjobgetstatus: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **jobid** | [**str**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **str**| The job type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **call_import**
> call_import(token, importtype, upload, filename=filename, parameters=parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
importtype = 'importtype_example' # str | The kind of data that is being uploaded.
upload = 'upload_example' # str | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # str | The local name of the uploaded file. For later reference. (optional)
parameters = 'parameters_example' # str | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}. (optional)

    try:
        # Import data into AccuCampus
        api_instance.call_import(token, importtype, upload, filename=filename, parameters=parameters)
    except ApiException as e:
        print("Exception when calling DefaultApi->call_import: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **importtype** | **str**| The kind of data that is being uploaded. | 
 **upload** | **str**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **str**| The local name of the uploaded file. For later reference. | [optional] 
 **parameters** | **str**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **captchagetchallenge**
> captchagetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    
    try:
        # Gets a captcha challenge that the user must complete to do certain requests.
        api_instance.captchagetchallenge()
    except ApiException as e:
        print("Exception when calling DefaultApi->captchagetchallenge: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **captchagetimage**
> captchagetimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    captchatoken = 'captchatoken_example' # str | The captcha token or ID returned by the captcha.getchallenge action

    try:
        # Gets a captcha image that the user must complete to do certain requests.
        api_instance.captchagetimage(captchatoken)
    except ApiException as e:
        print("Exception when calling DefaultApi->captchagetimage: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **str**| The captcha token or ID returned by the captcha.getchallenge action | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **changelog**
> changelog(token)

Get the application change log

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Get the application change log
        api_instance.changelog(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->changelog: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **clientget**
> clientget(token, client, clientname=clientname)

Get client

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
client = 'client_example' # str | The unique id of the client.
clientname = 'clientname_example' # str | The custom name of the client. (optional)

    try:
        # Get client
        api_instance.clientget(token, client, clientname=clientname)
    except ApiException as e:
        print("Exception when calling DefaultApi->clientget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **client** | **str**| The unique id of the client. | 
 **clientname** | **str**| The custom name of the client. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **clientlist**
> clientlist(token, _from, count)

Gets the clients of the specified conference

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # Gets the clients of the specified conference
        api_instance.clientlist(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->clientlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **clientsave**
> clientsave(unknown_base_type=unknown_base_type)

Saves a client

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Saves a client
        api_instance.clientsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->clientsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **clientsendmessage**
> clientsendmessage(token, uniqueclientid, message)

Send a message to a client

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
uniqueclientid = 'uniqueclientid_example' # str | The unique id of the client.
message = 'message_example' # str | The body of the message to send.

    try:
        # Send a message to a client
        api_instance.clientsendmessage(token, uniqueclientid, message)
    except ApiException as e:
        print("Exception when calling DefaultApi->clientsendmessage: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **uniqueclientid** | [**str**](.md)| The unique id of the client. | 
 **message** | **str**| The body of the message to send. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departmentdelete**
> departmentdelete(token, id)

Delete a college department

Allows the user to delete an existing college department.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the department to delete.

    try:
        # Delete a college department
        api_instance.departmentdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->departmentdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the department to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departmentget**
> departmentget(token, id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the department to get.

    try:
        # Search and view details of a college department
        api_instance.departmentget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->departmentget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the department to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departmentlist**
> departmentlist(token, _from, count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # View a list of college departments
        api_instance.departmentlist(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->departmentlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departmentsave**
> departmentsave(unknown_base_type=unknown_base_type)

Create or edit a college department

Allows the user to create or edit a college department.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a college department
        api_instance.departmentsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->departmentsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **doc**
> doc(excludeanonymous=excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    excludeanonymous = True # bool | If true it excludes the anonymous actions from the returned list. (optional)

    try:
        # Get the documentation
        api_instance.doc(excludeanonymous=excludeanonymous)
    except ApiException as e:
        print("Exception when calling DefaultApi->doc: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **easyloginaddbgimage**
> easyloginaddbgimage(token, upload, filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
upload = 'upload_example' # str | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # str | The original filename, needed to process the file.

    try:
        # Adds background image for the login
        api_instance.easyloginaddbgimage(token, upload, filename)
    except ApiException as e:
        print("Exception when calling DefaultApi->easyloginaddbgimage: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **upload** | **str**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **str**| The original filename, needed to process the file. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventdelete**
> eventdelete(token, id)

Delete a course

Allows the user to delete an existing course.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the event to delete.

    try:
        # Delete a course
        api_instance.eventdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->eventdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the event to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventget**
> eventget(token, id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the event to get.

    try:
        # Search and view details of a course
        api_instance.eventget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->eventget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the event to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventgetsessionsbydate**
> eventgetsessionsbydate(token, location=location, date=date, type=type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
location = 'location_example' # str | The location to filter the events. (optional)
date = '2013-10-20T19:20:30+01:00' # datetime | The date to filter the events. Today will be used if this parameter is omitted. (optional)
type = 'type_example' # str | Type of event to list. (optional)

    try:
        # View a list of courses by date
        api_instance.eventgetsessionsbydate(token, location=location, date=date, type=type)
    except ApiException as e:
        print("Exception when calling DefaultApi->eventgetsessionsbydate: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **location** | [**str**](.md)| The location to filter the events. | [optional] 
 **date** | **datetime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **str**| Type of event to list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventlist**
> eventlist(token, _from, count, summaryonly=summaryonly, termid=termid)

View a list of courses

Allows the user to view the full list of courses.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = '_from_example' # str | The first record to return.
count = 'count_example' # str | The max number of records to return.
summaryonly = True # bool | True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional)
termid = 'termid_example' # str | Id of the term to list the events. Null to list all events. (optional)

    try:
        # View a list of courses
        api_instance.eventlist(token, _from, count, summaryonly=summaryonly, termid=termid)
    except ApiException as e:
        print("Exception when calling DefaultApi->eventlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **str**| The first record to return. | 
 **count** | **str**| The max number of records to return. | 
 **summaryonly** | **bool**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**str**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventsave**
> eventsave(unknown_base_type=unknown_base_type)

Create or edit a course

Allows the user to create or edit a course.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a course
        api_instance.eventsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->eventsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventsearchgroup**
> eventsearchgroup(token, query)

Searches for the available event groups

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
query = 'query_example' # str | Query to search event groups.

    try:
        # Searches for the available event groups
        api_instance.eventsearchgroup(token, query)
    except ApiException as e:
        print("Exception when calling DefaultApi->eventsearchgroup: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **query** | [**str**](.md)| Query to search event groups. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **export**
> export(token, exporttype, exportformat, filters=filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
exporttype = 'exporttype_example' # str | What to export.
exportformat = 'exportformat_example' # str | The format of the resulting file. Valid types are CSV, HTML, XLS.
filters = 'filters_example' # str | Pipe separated filters for the export, eg: aaa=val|bbb=val|... (optional)

    try:
        # Export AccuCampus data
        api_instance.export(token, exporttype, exportformat, filters=filters)
    except ApiException as e:
        print("Exception when calling DefaultApi->export: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **exporttype** | **str**| What to export. | 
 **exportformat** | **str**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **filters** | **str**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **exportlisttypes**
> exportlisttypes(token)

Lists available export types

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Lists available export types
        api_instance.exportlisttypes(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->exportlisttypes: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **featurelist**
> featurelist(token)

Lists the available features.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Lists the available features.
        api_instance.featurelist(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->featurelist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **holidaylist**
> holidaylist(token, term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
term = 'term_example' # str | The term to get holidays from.

    try:
        # View a list of entered holidays
        api_instance.holidaylist(token, term)
    except ApiException as e:
        print("Exception when calling DefaultApi->holidaylist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **term** | [**str**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **holidaysave**
> holidaysave(unknown_base_type=unknown_base_type)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a list of holidays
        api_instance.holidaysave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->holidaysave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **holidaysuggest**
> holidaysuggest(token, term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
term = 'term_example' # str | The term to get holidays from.

    try:
        # View the holiday suggestions in the given term
        api_instance.holidaysuggest(token, term)
    except ApiException as e:
        print("Exception when calling DefaultApi->holidaysuggest: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **term** | [**str**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **importlisttypes**
> importlisttypes(token)

Lists available import types

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Lists available import types
        api_instance.importlisttypes(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->importlisttypes: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **licenseacceptagreement**
> licenseacceptagreement(token)

Accept the license agreement

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Accept the license agreement
        api_instance.licenseacceptagreement(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->licenseacceptagreement: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **licensegetagreementstatus**
> licensegetagreementstatus(token)

Check if license agreement has been accepted

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Check if license agreement has been accepted
        api_instance.licensegetagreementstatus(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->licensegetagreementstatus: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **licensegetcurrent**
> licensegetcurrent(token=token)

Gets the current license information

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token. (optional)

    try:
        # Gets the current license information
        api_instance.licensegetcurrent(token=token)
    except ApiException as e:
        print("Exception when calling DefaultApi->licensegetcurrent: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **licenserenew**
> licenserenew(token, email, phonenumber, jobtitle=jobtitle, institution=institution, comments=comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
email = 'email_example' # str | The e-mail of the user sending the request.
phonenumber = 'phonenumber_example' # str | The phone number of the user sending the request.
jobtitle = 'jobtitle_example' # str | The job title of the user sending the request. (optional)
institution = 'institution_example' # str | The institution of the user sending the request. (optional)
comments = 'comments_example' # str | Comments entered by the user sending the request. (optional)

    try:
        # Contact Engineerica in order to renew the AccuCampus subscription
        api_instance.licenserenew(token, email, phonenumber, jobtitle=jobtitle, institution=institution, comments=comments)
    except ApiException as e:
        print("Exception when calling DefaultApi->licenserenew: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **email** | **str**| The e-mail of the user sending the request. | 
 **phonenumber** | **str**| The phone number of the user sending the request. | 
 **jobtitle** | **str**| The job title of the user sending the request. | [optional] 
 **institution** | **str**| The institution of the user sending the request. | [optional] 
 **comments** | **str**| Comments entered by the user sending the request. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **listtimezones**
> listtimezones()

Lists the available timezones

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    
    try:
        # Lists the available timezones
        api_instance.listtimezones()
    except ApiException as e:
        print("Exception when calling DefaultApi->listtimezones: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **locationdelete**
> locationdelete(token, id)

Delete a location

Allows the user to delete an existing location.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the location to delete.

    try:
        # Delete a location
        api_instance.locationdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->locationdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the location to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **locationget**
> locationget(token, id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the location to get.

    try:
        # Search and view details of a location
        api_instance.locationget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->locationget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **locationlist**
> locationlist(token, _from, count, locations=locations, sortbygroup=sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
locations = 'locations_example' # str | The comma-separated list containing the ids of the locations to list. (optional)
sortbygroup = True # bool | True to list locations sorted by the 'Located In' property. Defaults to false. (optional)

    try:
        # View a list of locations
        api_instance.locationlist(token, _from, count, locations=locations, sortbygroup=sortbygroup)
    except ApiException as e:
        print("Exception when calling DefaultApi->locationlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **locations** | **str**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **bool**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **locationsave**
> locationsave(unknown_base_type=unknown_base_type)

Create or edit a location

Allows the user to create or edit a location.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a location
        api_instance.locationsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->locationsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **login**
> login(domain, username, password, method, rememberme=rememberme)

Login

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    domain = 'domain_example' # str | The account domain to login.
username = 'username_example' # str | The username (email) of the user to login as.
password = 'password_example' # str | The password of the user to login as.
method = 'method_example' # str | The authentication method. Valid values are 'token' and 'cookie'.
rememberme = True # bool | If true then the session will not expire. (optional)

    try:
        # Login
        api_instance.login(domain, username, password, method, rememberme=rememberme)
    except ApiException as e:
        print("Exception when calling DefaultApi->login: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **str**| The account domain to login. | 
 **username** | **str**| The username (email) of the user to login as. | 
 **password** | **str**| The password of the user to login as. | 
 **method** | **str**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **bool**| If true then the session will not expire. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **logout**
> logout(token=token)

Logout

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token used to login. (optional)

    try:
        # Logout
        api_instance.logout(token=token)
    except ApiException as e:
        print("Exception when calling DefaultApi->logout: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token used to login. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreportdelete**
> memorizedreportdelete(token, id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the report settings to delete.

    try:
        # Delete memorized report
        api_instance.memorizedreportdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->memorizedreportdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the report settings to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreportget**
> memorizedreportget(token, id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the report configuration to get.

    try:
        # View details of a memorized report
        api_instance.memorizedreportget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->memorizedreportget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the report configuration to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreportlist**
> memorizedreportlist(token, _from, count, customname=customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
customname = 'customname_example' # str | If specified filters the memorized reports by custom name. (optional)

    try:
        # View a list of all his memorized reports
        api_instance.memorizedreportlist(token, _from, count, customname=customname)
    except ApiException as e:
        print("Exception when calling DefaultApi->memorizedreportlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **customname** | **str**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **memorizedreportsave**
> memorizedreportsave(unknown_base_type=unknown_base_type)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a memorized report
        api_instance.memorizedreportsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->memorizedreportsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **menugetitems**
> menugetitems(menuid)

Gets the items on the menu

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    menuid = 'menuid_example' # str | The Id of the menu to get.

    try:
        # Gets the items on the menu
        api_instance.menugetitems(menuid)
    except ApiException as e:
        print("Exception when calling DefaultApi->menugetitems: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuid** | **str**| The Id of the menu to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **myaccount**
> myaccount(token)

Gets the logged in user account.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Gets the logged in user account.
        api_instance.myaccount(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->myaccount: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **myianatimezone**
> myianatimezone(token)

Gets the current time zone's iana name

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Gets the current time zone's iana name
        api_instance.myianatimezone(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->myianatimezone: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **myprofile**
> myprofile(token, photosize=photosize)

Gets the logged in user information.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Gets the logged in user information.
        api_instance.myprofile(token, photosize=photosize)
    except ApiException as e:
        print("Exception when calling DefaultApi->myprofile: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **myrights**
> myrights(token)

Gets the list of actions the user can execute.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Gets the list of actions the user can execute.
        api_instance.myrights(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->myrights: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mysaveprofile**
> mysaveprofile(unknown_base_type=unknown_base_type)

Updates logged user's profile information

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Updates logged user's profile information
        api_instance.mysaveprofile(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->mysaveprofile: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationdelete**
> notificationdelete(token, id)

Delete a notification

Allows the user to delete an existing notification.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the notification to delete.

    try:
        # Delete a notification
        api_instance.notificationdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the notification to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationget**
> notificationget(token, id)

View a notification

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the notification to get.

    try:
        # View a notification
        api_instance.notificationget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the notification to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationgetforstation**
> notificationgetforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    station = 'station_example' # str | The id of the sign-in station to get.
user = 'user_example' # str | The card of the user.

    try:
        # Gets all public (in station) notifications for the specific user
        api_instance.notificationgetforstation(station, user)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationgetforstation: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station to get. | 
 **user** | **str**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationgetunreadcount**
> notificationgetunreadcount(token)

Get the number of unread notifications

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Get the number of unread notifications
        api_instance.notificationgetunreadcount(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationgetunreadcount: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationlist**
> notificationlist(token, _from, count, recipient=recipient, status=status, startdate=startdate, enddate=enddate, sentonscreen=sentonscreen, sentemail=sentemail, sentsms=sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
recipient = 'recipient_example' # str | The recipient whose notifications have to be listed. (optional)
status = 56 # int | The status of the notifications to list. Read, Unread or All. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the notifications. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the notifications. (optional)
sentonscreen = True # bool | Specifies whether to list the notifications that were sent on-screen or not. (optional)
sentemail = True # bool | Specifies whether to list the notifications that were sent via e-mail or not. (optional)
sentsms = True # bool | Specifies whether to list the notifications that were sent via sms or not. (optional)

    try:
        # View a list of all sent notifications
        api_instance.notificationlist(token, _from, count, recipient=recipient, status=status, startdate=startdate, enddate=enddate, sentonscreen=sentonscreen, sentemail=sentemail, sentsms=sentsms)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **recipient** | [**str**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **int**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the notifications. | [optional] 
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationlistmine**
> notificationlistmine(token, _from, count, status=status, startdate=startdate, enddate=enddate)

View all the notifications sent to the current user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
status = 56 # int | Specifies the status of the notifications to list. Read, Unread or All. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the notifications. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the notifications. (optional)

    try:
        # View all the notifications sent to the current user
        api_instance.notificationlistmine(token, _from, count, status=status, startdate=startdate, enddate=enddate)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationlistmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationmarkasread**
> notificationmarkasread(token, id=id, status=status, startdate=startdate, enddate=enddate)

Mark a notification as read

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. (optional)
status = 56 # int | Specifies the status to filter the notifications. Read, Unread or All. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the notifications. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the notifications. (optional)

    try:
        # Mark a notification as read
        api_instance.notificationmarkasread(token, id=id, status=status, startdate=startdate, enddate=enddate)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationmarkasread: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationmarkasunread**
> notificationmarkasunread(token, id=id, status=status, startdate=startdate, enddate=enddate)

Mark a notification as unread

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. (optional)
status = 56 # int | Specifies the status to filter the notifications. Read, Unread or All. (optional)
startdate = '2013-10-20T19:20:30+01:00' # datetime | The start date of the period to filter the notifications. (optional)
enddate = '2013-10-20T19:20:30+01:00' # datetime | The end date of the period to filter the notifications. (optional)

    try:
        # Mark a notification as unread
        api_instance.notificationmarkasunread(token, id=id, status=status, startdate=startdate, enddate=enddate)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationmarkasunread: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **datetime**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **datetime**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationsend**
> notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, tousers=tousers, togroups=togroups, onscreenbody=onscreenbody, onscreenclick=onscreenclick, onscreenurl=onscreenurl, onscreenclass=onscreenclass, onscreenduration=onscreenduration, showonstation=showonstation, emailfromname=emailfromname, emailfrom=emailfrom, emailsubject=emailsubject, emailbody=emailbody, textmessagebody=textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
emailenabled = True # bool | Whether send the notification via email.
onscreenenabled = True # bool | Whether to display the notification on screen.
smsenabled = True # bool | Whether to send the notification via text message.
title = 'title_example' # str | Notification title.
tousers = 'tousers_example' # str | Comma-separated Ids of users to send the notification. (optional)
togroups = 'togroups_example' # str | Comma-separated Ids of user groups to send the notification. (optional)
onscreenbody = 'onscreenbody_example' # str | Body of the message for on-screen display. (optional)
onscreenclick = 'onscreenclick_example' # str | What to do when the notification is clicked. Valid values: hide, view, url. (optional)
onscreenurl = 'onscreenurl_example' # str | Url to redirect the user, if onscreenclick=url. (optional)
onscreenclass = 'onscreenclass_example' # str | How to display the notification. Valid values: info, success, warning, error (optional)
onscreenduration = 56 # int | Time in seconds to display the notification. (optional)
showonstation = 56 # int | Whether to show the notification in the sign-in station. (optional)
emailfromname = 'emailfromname_example' # str | Name of the email sender. (optional)
emailfrom = 'emailfrom_example' # str | Reply-to email. (optional)
emailsubject = 'emailsubject_example' # str | Subject of the email. (optional)
emailbody = 'emailbody_example' # str | Body of the email. (optional)
textmessagebody = 'textmessagebody_example' # str | Message for SMS. Max 160 characters. (optional)

    try:
        # Send notifications on screen, via email or text to users
        api_instance.notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, tousers=tousers, togroups=togroups, onscreenbody=onscreenbody, onscreenclick=onscreenclick, onscreenurl=onscreenurl, onscreenclass=onscreenclass, onscreenduration=onscreenduration, showonstation=showonstation, emailfromname=emailfromname, emailfrom=emailfrom, emailsubject=emailsubject, emailbody=emailbody, textmessagebody=textmessagebody)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationsend: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **emailenabled** | **bool**| Whether send the notification via email. | 
 **onscreenenabled** | **bool**| Whether to display the notification on screen. | 
 **smsenabled** | **bool**| Whether to send the notification via text message. | 
 **title** | **str**| Notification title. | 
 **tousers** | **str**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **str**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **str**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **str**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **str**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **str**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **int**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **int**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **str**| Name of the email sender. | [optional] 
 **emailfrom** | **str**| Reply-to email. | [optional] 
 **emailsubject** | **str**| Subject of the email. | [optional] 
 **emailbody** | **str**| Body of the email. | [optional] 
 **textmessagebody** | **str**| Message for SMS. Max 160 characters. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationsendonscreen**
> notificationsendonscreen(token, notification)

Send on-screen notifications

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
notification = 'notification_example' # str | The ID of the notification to send.

    try:
        # Send on-screen notifications
        api_instance.notificationsendonscreen(token, notification)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationsendonscreen: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **notification** | [**str**](.md)| The ID of the notification to send. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopicdelete**
> notificationtopicdelete(token, id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the notification topic to delete.

    try:
        # Delete a notification topic
        api_instance.notificationtopicdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationtopicdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the notification topic to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopicget**
> notificationtopicget(token, id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the notification topic to get.

    try:
        # Search and view details of a notification topic
        api_instance.notificationtopicget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationtopicget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the notification topic to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopiclist**
> notificationtopiclist(token, _from, count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # List all the notification topics
        api_instance.notificationtopiclist(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationtopiclist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopiclistsubscribe**
> notificationtopiclistsubscribe(token)

List all the notification topics available to subscribe

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # List all the notification topics available to subscribe
        api_instance.notificationtopiclistsubscribe(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationtopiclistsubscribe: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopicsave**
> notificationtopicsave(unknown_base_type=unknown_base_type)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a notification topic
        api_instance.notificationtopicsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->notificationtopicsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pushderegister**
> pushderegister(devicetoken, platform)

Deregisters the current device to receive push notifications

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    devicetoken = 'devicetoken_example' # str | The device token where to send the notification.
platform = 'platform_example' # str | Either ios or android

    try:
        # Deregisters the current device to receive push notifications
        api_instance.pushderegister(devicetoken, platform)
    except ApiException as e:
        print("Exception when calling DefaultApi->pushderegister: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **str**| The device token where to send the notification. | 
 **platform** | **str**| Either ios or android | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pushregister**
> pushregister(devicetoken, platform)

Registers the current device to receive push notifications

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    devicetoken = 'devicetoken_example' # str | The device token where to send the notification.
platform = 'platform_example' # str | Either ios or android

    try:
        # Registers the current device to receive push notifications
        api_instance.pushregister(devicetoken, platform)
    except ApiException as e:
        print("Exception when calling DefaultApi->pushregister: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **str**| The device token where to send the notification. | 
 **platform** | **str**| Either ios or android | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **qrlabelsprint**
> qrlabelsprint(token, user=user, group=group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
user = 'user_example' # str | The id of the user whose label needs to be printed. (optional)
group = 'group_example' # str | The id of the group whose members' labels need to be printed. (optional)

    try:
        # Print and email QR labels
        api_instance.qrlabelsprint(token, user=user, group=group)
    except ApiException as e:
        print("Exception when calling DefaultApi->qrlabelsprint: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **user** | [**str**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**str**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **qrloginget**
> qrloginget(token)

Gets an image of a QR token

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Gets an image of a QR token
        api_instance.qrloginget(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->qrloginget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **qrloginlogin**
> qrloginlogin(onetimetoken)

Login

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    onetimetoken = 'onetimetoken_example' # str | The token read from the QR code.

    try:
        # Login
        api_instance.qrloginlogin(onetimetoken)
    except ApiException as e:
        print("Exception when calling DefaultApi->qrloginlogin: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onetimetoken** | **str**| The token read from the QR code. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpaneldeletewidget**
> quickpaneldeletewidget(token, id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the widget.

    try:
        # Deletes a widget from the Quick Panel
        api_instance.quickpaneldeletewidget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->quickpaneldeletewidget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the widget. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelfetchwidget**
> quickpanelfetchwidget(token, widgetid)

Fetches the information for a specific widget.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
widgetid = 'widgetid_example' # str | The ID of the data to fetch it's data.

    try:
        # Fetches the information for a specific widget.
        api_instance.quickpanelfetchwidget(token, widgetid)
    except ApiException as e:
        print("Exception when calling DefaultApi->quickpanelfetchwidget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **widgetid** | [**str**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelgetwidget**
> quickpanelgetwidget(token, id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the widget to get.

    try:
        # View details of a widget included in the Quick Panel
        api_instance.quickpanelgetwidget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->quickpanelgetwidget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the widget to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelinit**
> quickpanelinit(token)

Returns the initial information required to show the quick panels

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Returns the initial information required to show the quick panels
        api_instance.quickpanelinit(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->quickpanelinit: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanellistwidgets**
> quickpanellistwidgets(token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Lists all the widgets that are added in the Quick Panel
        api_instance.quickpanellistwidgets(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->quickpanellistwidgets: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanellistwidgettypes**
> quickpanellistwidgettypes(token)

Lists all the widget types available in the system

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Lists all the widget types available in the system
        api_instance.quickpanellistwidgettypes(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->quickpanellistwidgettypes: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelreorderwidgets**
> quickpanelreorderwidgets(token, sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
sectionname = 'sectionname_example' # str | The section name where to sort the widgets.
orderids = 'orderids_example' # str | CSV list of the widgets to reorder.

    try:
        # Reorders the widgets and moves them to a specific column
        api_instance.quickpanelreorderwidgets(token, sectionname, orderids)
    except ApiException as e:
        print("Exception when calling DefaultApi->quickpanelreorderwidgets: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **sectionname** | **str**| The section name where to sort the widgets. | 
 **orderids** | **str**| CSV list of the widgets to reorder. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanelsavewidget**
> quickpanelsavewidget(unknown_base_type=unknown_base_type)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Saves a widget for the Quick Panel
        api_instance.quickpanelsavewidget(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->quickpanelsavewidget: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportlist**
> reportlist(token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # View a list of available reports
        api_instance.reportlist(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->reportlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportpermissionsbyuser**
> reportpermissionsbyuser(token, params=params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
params = 'params_example' # str | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional)

    try:
        # Permissions by user report
        api_instance.reportpermissionsbyuser(token, params=params)
    except ApiException as e:
        print("Exception when calling DefaultApi->reportpermissionsbyuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **params** | **str**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportprepare**
> reportprepare(token, reportname, params=params, repformat=repformat, fillgroupid=fillgroupid, groupby=groupby, refreshgroup=refreshgroup, filtertext=filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
reportname = 'reportname_example' # str | The name of the report to execute
params = 'params_example' # str | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional)
repformat = 'repformat_example' # str | The format of the resulting report. Json, pdf, csv, ... (optional)
fillgroupid = 'fillgroupid_example' # str | If specified, the result is used to fill the group with the given ID (optional)
groupby = 'groupby_example' # str | How to group the records. In the format 'col1+col2|col3+col4 (optional)
refreshgroup = 'refreshgroup_example' # str | The ID of the group to check (and refresh) before processing the report. (optional)
filtertext = 'filtertext_example' # str | The user friendly text of the applied filters. (optional)

    try:
        # Queries and loads the specified report, in background.
        api_instance.reportprepare(token, reportname, params=params, repformat=repformat, fillgroupid=fillgroupid, groupby=groupby, refreshgroup=refreshgroup, filtertext=filtertext)
    except ApiException as e:
        print("Exception when calling DefaultApi->reportprepare: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **reportname** | **str**| The name of the report to execute | 
 **params** | **str**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **str**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**str**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **str**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**str**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **str**| The user friendly text of the applied filters. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reportquery**
> reportquery(token, reportname, params=params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
reportname = 'reportname_example' # str | The name of the report to execute
params = 'params_example' # str | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional)

    try:
        # Query and load a specified report
        api_instance.reportquery(token, reportname, params=params)
    except ApiException as e:
        print("Exception when calling DefaultApi->reportquery: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **reportname** | **str**| The name of the report to execute | 
 **params** | **str**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rolelist**
> rolelist(token, name=name)

Show a list of roles

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
name = 'name_example' # str | Filter by name of the role. (optional)

    try:
        # Show a list of roles
        api_instance.rolelist(token, name=name)
    except ApiException as e:
        print("Exception when calling DefaultApi->rolelist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **name** | **str**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ruledelete**
> ruledelete(token, id)

Delete a rule

Allows the user to delete an existing rule.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the rule to delete.

    try:
        # Delete a rule
        api_instance.ruledelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->ruledelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the rule to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ruleget**
> ruleget(token, id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the rule to get.

    try:
        # View details of a rule
        api_instance.ruleget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->ruleget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the rule to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulegeteventtype**
> rulegeteventtype(token, event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
event = 'event_example' # str | The name of the event to refresh.

    try:
        # View details of a rule event type
        api_instance.rulegeteventtype(token, event)
    except ApiException as e:
        print("Exception when calling DefaultApi->rulegeteventtype: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **event** | **str**| The name of the event to refresh. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulelist**
> rulelist(token, _from, count)

View a list of user rules

Allows the user to view the list of all rules.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # View a list of user rules
        api_instance.rulelist(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->rulelist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulelistactions**
> rulelistactions(token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # View a list of rule actions available
        api_instance.rulelistactions(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->rulelistactions: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulelisteventtypes**
> rulelisteventtypes(token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # View a list of rule event types
        api_instance.rulelisteventtypes(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->rulelisteventtypes: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulelisthttprequests**
> rulelisthttprequests(token, _from, count, failed=failed, status=status)

View all the http requests sent as a result of a rule

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
failed = True # bool | If true only failed requests will be returned (optional)
status = 56 # int | The http status to filter the requests (optional)

    try:
        # View all the http requests sent as a result of a rule
        api_instance.rulelisthttprequests(token, _from, count, failed=failed, status=status)
    except ApiException as e:
        print("Exception when calling DefaultApi->rulelisthttprequests: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rulesave**
> rulesave(unknown_base_type=unknown_base_type)

Create or edit a rule

Allows the user to create or edit a rule.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a rule
        api_instance.rulesave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->rulesave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **search**
> search(token, query, page=page)

Search

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
query = 'query_example' # str | The query to search for.
page = 56 # int | Current page to show, zero-based. (optional)

    try:
        # Search
        api_instance.search(token, query, page=page)
    except ApiException as e:
        print("Exception when calling DefaultApi->search: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **query** | **str**| The query to search for. | 
 **page** | **int**| Current page to show, zero-based. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **searchgetentities**
> searchgetentities(token)

Get the information of the entities that can be searched

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Get the information of the entities that can be searched
        api_instance.searchgetentities(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->searchgetentities: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **securityassesspermission**
> securityassesspermission(token, commandname)

Returns the list of users for a specific permission

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
commandname = 'commandname_example' # str | Name of the action or command to get the roles.

    try:
        # Returns the list of users for a specific permission
        api_instance.securityassesspermission(token, commandname)
    except ApiException as e:
        print("Exception when calling DefaultApi->securityassesspermission: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **commandname** | **str**| Name of the action or command to get the roles. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **securityassessrole**
> securityassessrole(token, roleid)

Returns the list of permissions for a specific role

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
roleid = 'roleid_example' # str | Role ID to list the effective permissions.

    try:
        # Returns the list of permissions for a specific role
        api_instance.securityassessrole(token, roleid)
    except ApiException as e:
        print("Exception when calling DefaultApi->securityassessrole: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **roleid** | [**str**](.md)| Role ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **securityassessscope**
> securityassessscope(token, locationid=locationid)

Returns the list of users for a specific user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
locationid = 'locationid_example' # str | Location ID to list the users with that scope. (optional)

    try:
        # Returns the list of users for a specific user
        api_instance.securityassessscope(token, locationid=locationid)
    except ApiException as e:
        print("Exception when calling DefaultApi->securityassessscope: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **locationid** | [**str**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **securityassessuser**
> securityassessuser(token, userid)

Returns the list of permissions for a specific user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
userid = 'userid_example' # str | User ID to list the effective permissions.

    try:
        # Returns the list of permissions for a specific user
        api_instance.securityassessuser(token, userid)
    except ApiException as e:
        print("Exception when calling DefaultApi->securityassessuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **userid** | [**str**](.md)| User ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregaddcurrentuser**
> sessionregaddcurrentuser(token, eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
eventid = 'eventid_example' # str | The id of the event.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts.

    try:
        # Register current user to an event session
        api_instance.sessionregaddcurrentuser(token, eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionregaddcurrentuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **eventid** | [**str**](.md)| The id of the event. | 
 **sessiondate** | **datetime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregadduser**
> sessionregadduser(token, userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
userid = 'userid_example' # str | The id of the user to add.
eventid = 'eventid_example' # str | The id of the event.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts.

    try:
        # Register users for events
        api_instance.sessionregadduser(token, userid, eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionregadduser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **userid** | [**str**](.md)| The id of the user to add. | 
 **eventid** | [**str**](.md)| The id of the event. | 
 **sessiondate** | **datetime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreggetmysessions**
> sessionreggetmysessions(token, date=date)

View all the sessions the logged user is registered to

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
date = '2013-10-20T19:20:30+01:00' # datetime | Start date to filter the sessions. (optional)

    try:
        # View all the sessions the logged user is registered to
        api_instance.sessionreggetmysessions(token, date=date)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionreggetmysessions: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **date** | **datetime**| Start date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreggetsessions**
> sessionreggetsessions(token, userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
userid = 'userid_example' # str | The user id to list sessions.

    try:
        # Lists the registrations for a specific user
        api_instance.sessionreggetsessions(token, userid)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionreggetsessions: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **userid** | [**str**](.md)| The user id to list sessions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreggetsettings**
> sessionreggetsettings(token, locationid=locationid, eventid=eventid, sessiondate=sessiondate, noinherit=noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
locationid = 'locationid_example' # str | The id of the location to save settings. (optional)
eventid = 'eventid_example' # str | The id of the event to save settings. (optional)
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts. (optional)
noinherit = True # bool | True to get the location/event/session specific settings without looking for the more global settings. (optional)

    try:
        # Get the settings for session registration
        api_instance.sessionreggetsettings(token, locationid=locationid, eventid=eventid, sessiondate=sessiondate, noinherit=noinherit)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionreggetsettings: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **locationid** | [**str**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**str**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **datetime**| The date and time when the session starts. | [optional] 
 **noinherit** | **bool**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreggetusers**
> sessionreggetusers(token, eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
eventid = 'eventid_example' # str | The event id to list sessions.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date of the session to find.

    try:
        # Lists the registrations for a specific session
        api_instance.sessionreggetusers(token, eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionreggetusers: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **eventid** | [**str**](.md)| The event id to list sessions. | 
 **sessiondate** | **datetime**| The date of the session to find. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreglistsessions**
> sessionreglistsessions(token, eventid, sessiondate=sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
eventid = 'eventid_example' # str | The event id to list sessions.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date of the session to find. (optional)

    try:
        # List the sessions available for a specific event
        api_instance.sessionreglistsessions(token, eventid, sessiondate=sessiondate)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionreglistsessions: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **eventid** | [**str**](.md)| The event id to list sessions. | 
 **sessiondate** | **datetime**| The date of the session to find. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreglistupcoming**
> sessionreglistupcoming(token, date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
date = '2013-10-20T19:20:30+01:00' # datetime | Only sessions in the week of the specified date will be returned.

    try:
        # View a list of upcoming event sessions
        api_instance.sessionreglistupcoming(token, date)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionreglistupcoming: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **date** | **datetime**| Only sessions in the week of the specified date will be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionreglistupcomingevent**
> sessionreglistupcomingevent(token, date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
date = '2013-10-20T19:20:30+01:00' # datetime | Start date to filter the returned sessions.
event = 'event_example' # str | The id of the event whose sessions will be returned

    try:
        # View a list of upcoming sessions of a particular event
        api_instance.sessionreglistupcomingevent(token, date, event)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionreglistupcomingevent: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **date** | **datetime**| Start date to filter the returned sessions. | 
 **event** | [**str**](.md)| The id of the event whose sessions will be returned | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregremovecurrentuser**
> sessionregremovecurrentuser(token, eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
eventid = 'eventid_example' # str | The id of the event.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts.

    try:
        # Unregister current user from an event session
        api_instance.sessionregremovecurrentuser(token, eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionregremovecurrentuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **eventid** | [**str**](.md)| The id of the event. | 
 **sessiondate** | **datetime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregremoveuser**
> sessionregremoveuser(token, userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
userid = 'userid_example' # str | The id of the user to remove.
eventid = 'eventid_example' # str | The id of the event.
sessiondate = '2013-10-20T19:20:30+01:00' # datetime | The date and time when the session starts.

    try:
        # Removes a user from an event session
        api_instance.sessionregremoveuser(token, userid, eventid, sessiondate)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionregremoveuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **userid** | [**str**](.md)| The id of the user to remove. | 
 **eventid** | [**str**](.md)| The id of the event. | 
 **sessiondate** | **datetime**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionregsavesettings**
> sessionregsavesettings(unknown_base_type=unknown_base_type)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Save the settings for an event's session registration
        api_instance.sessionregsavesettings(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->sessionregsavesettings: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **settingaddlogo**
> settingaddlogo(token, upload, filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
upload = 'upload_example' # str | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # str | The original filename, needed to process the file.

    try:
        # Add a logo to the account
        api_instance.settingaddlogo(token, upload, filename)
    except ApiException as e:
        print("Exception when calling DefaultApi->settingaddlogo: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **upload** | **str**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **str**| The original filename, needed to process the file. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **settingget**
> settingget(keys, token=token, domain=domain, scope=scope)

Get settings for the account or the specified scope

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    keys = 'keys_example' # str | The option keys to get values for. Enter multiple separated by comma.
token = 'token_example' # str | The authentication token. (optional)
domain = 'domain_example' # str | The account domain, in case of reading settings annonymously. (optional)
scope = 'scope_example' # str | The scope of the settings to get. (optional)

    try:
        # Get settings for the account or the specified scope
        api_instance.settingget(keys, token=token, domain=domain, scope=scope)
    except ApiException as e:
        print("Exception when calling DefaultApi->settingget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **str**| The option keys to get values for. Enter multiple separated by comma. | 
 **token** | **str**| The authentication token. | [optional] 
 **domain** | **str**| The account domain, in case of reading settings annonymously. | [optional] 
 **scope** | **str**| The scope of the settings to get. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **settingsave**
> settingsave(unknown_base_type=unknown_base_type)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Save settings for the account or the specified scope
        api_instance.settingsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->settingsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **settingviewgeneral**
> settingviewgeneral(token)

View general settings for the account

Allows the user to view the settings' general section.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # View general settings for the account
        api_instance.settingviewgeneral(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->settingviewgeneral: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ssogeneratekey**
> ssogeneratekey(token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Generate/reset single sign on access key.
        api_instance.ssogeneratekey(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->ssogeneratekey: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ssogetsettings**
> ssogetsettings(token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # View single sign on settings.
        api_instance.ssogetsettings(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->ssogetsettings: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ssoissuetoken**
> ssoissuetoken(key, username, expires=expires)

Issue single sign-on token

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    key = 'key_example' # str | The single sign-on key of the account.
username = 'username_example' # str | The email of the user to sign-on.
expires = True # bool | Specifies whether the session should expire when inactive. (optional)

    try:
        # Issue single sign-on token
        api_instance.ssoissuetoken(key, username, expires=expires)
    except ApiException as e:
        print("Exception when calling DefaultApi->ssoissuetoken: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **str**| The single sign-on key of the account. | 
 **username** | **str**| The email of the user to sign-on. | 
 **expires** | **bool**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ssosavesettings**
> ssosavesettings(unknown_base_type=unknown_base_type)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Edit single sign-on settings.
        api_instance.ssosavesettings(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->ssosavesettings: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationdelete**
> stationdelete(token, id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the sign-in station to delete.

    try:
        # Delete a sign-in station
        api_instance.stationdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->stationdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the sign-in station to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationget**
> stationget(token, id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the sign-in station to get.

    try:
        # View details of a sign-in station
        api_instance.stationget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->stationget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the sign-in station to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationgetcurrentterms**
> stationgetcurrentterms(station)

Get all the current terms

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    station = 'station_example' # str | The id of the sign-in station whose account's current terms have to be retrieved.

    try:
        # Get all the current terms
        api_instance.stationgetcurrentterms(station)
    except ApiException as e:
        print("Exception when calling DefaultApi->stationgetcurrentterms: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**str**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationgetinfo**
> stationgetinfo(id, event=event)

Gets a the info to display in the sign-in station by it's ID.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    id = 'id_example' # str | The id of the sign-in station to get.
event = 'event_example' # str | The id of the event, to override the one by schedule. (optional)

    try:
        # Gets a the info to display in the sign-in station by it's ID.
        api_instance.stationgetinfo(id, event=event)
    except ApiException as e:
        print("Exception when calling DefaultApi->stationgetinfo: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the sign-in station to get. | 
 **event** | [**str**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationgetlicense**
> stationgetlicense(station)

Gets the current license information

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    station = 'station_example' # str | The id of the sign-in station whose account's license has to be retrieved.

    try:
        # Gets the current license information
        api_instance.stationgetlicense(station)
    except ApiException as e:
        print("Exception when calling DefaultApi->stationgetlicense: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | **str**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationlist**
> stationlist(token, _from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # View a list of sign-in stations
        api_instance.stationlist(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->stationlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationsave**
> stationsave(unknown_base_type=unknown_base_type)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a sign-in station
        api_instance.stationsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->stationsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **stationunlock**
> stationunlock(id, passcode, method)

Unlocks the sign-in station.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    id = 'id_example' # str | The id of the sign-in station to unlock.
passcode = 'passcode_example' # str | The passcode to unlock the station.
method = 'method_example' # str | The authentication method. Valid values are 'token' and 'cookie'.

    try:
        # Unlocks the sign-in station.
        api_instance.stationunlock(id, passcode, method)
    except ApiException as e:
        print("Exception when calling DefaultApi->stationunlock: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the sign-in station to unlock. | 
 **passcode** | **str**| The passcode to unlock the station. | 
 **method** | **str**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipedelete**
> swipedelete(token, id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the swipe to delete.

    try:
        # Delete a swipe
        api_instance.swipedelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->swipedelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the swipe to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipeget**
> swipeget(token, id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the swipe to get.

    try:
        # Search and view details of a swipe
        api_instance.swipeget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->swipeget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipelist**
> swipelist(_from, count, token=token)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
token = 'token_example' # str | The authentication token. (optional)

    try:
        # View a list of swipes
        api_instance.swipelist(_from, count, token=token)
    except ApiException as e:
        print("Exception when calling DefaultApi->swipelist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **token** | **str**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipesave**
> swipesave(unknown_base_type=unknown_base_type)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a swipe, and if possible, save the related attendance log
        api_instance.swipesave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->swipesave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **swipesaveanonym**
> swipesaveanonym(unknown_base_type=unknown_base_type)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Creates a new swipe from a sign-in station, and if possible, creates the attendance log
        api_instance.swipesaveanonym(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->swipesaveanonym: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tagdelete**
> tagdelete(token, id)

Delete a tag

Allows the user to delete an existing tag.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the tag to delete.

    try:
        # Delete a tag
        api_instance.tagdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->tagdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the tag to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tagget**
> tagget(token, id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the tag to get.

    try:
        # View details of a specified tag
        api_instance.tagget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->tagget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the tag to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **taglist**
> taglist(token, group, _from, count)

View a list of tags

Allows the user to view the list of tags.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
group = 'group_example' # str | The group of the tags to return.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # View a list of tags
        api_instance.taglist(token, group, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->taglist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **group** | **str**| The group of the tags to return. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **taglistgroups**
> taglistgroups(token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # View a list of entities that can be tagged
        api_instance.taglistgroups(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->taglistgroups: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tagsave**
> tagsave(unknown_base_type=unknown_base_type)

Create or edit a tag

Allows the user to create or edit a tag.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a tag
        api_instance.tagsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->tagsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tagsearch**
> tagsearch(token, query, allowcreatingnew=allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
query = 'query_example' # str | The query to search tags. Use group:<group> to search in a specific group (mandatory).
allowcreatingnew = True # bool | Specifies whether an option to create a new tag should be retrieved. (optional)

    try:
        # Search for tags in the account
        api_instance.tagsearch(token, query, allowcreatingnew=allowcreatingnew)
    except ApiException as e:
        print("Exception when calling DefaultApi->tagsearch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **query** | **str**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **allowcreatingnew** | **bool**| Specifies whether an option to create a new tag should be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templateaddimage**
> templateaddimage(token, template, upload, filename=filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
template = 'template_example' # str | The id of the template where the image has to be added
upload = 'upload_example' # str | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # str | The local name of the uploaded file. For later reference. (optional)

    try:
        # Add an image to a template
        api_instance.templateaddimage(token, template, upload, filename=filename)
    except ApiException as e:
        print("Exception when calling DefaultApi->templateaddimage: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **template** | [**str**](.md)| The id of the template where the image has to be added | 
 **upload** | **str**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **str**| The local name of the uploaded file. For later reference. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatedelete**
> templatedelete(token, id)

Delete a template

Allows the user to delete an existing template.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the template to delete.

    try:
        # Delete a template
        api_instance.templatedelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->templatedelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the template to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templateemail**
> templateemail(token, jobid, emailsubject, emailbody, templatekind=templatekind, emailfrom=emailfrom, emailreplyto=emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
jobid = 'jobid_example' # str | The id of the job that is creating the templates.
emailsubject = 'emailsubject_example' # str | Args depending on the send-to flag.
emailbody = 'emailbody_example' # str | Args depending on the send-to flag.
templatekind = 'templatekind_example' # str | The kind of the template you're sending. It must be included in (badge, certificate). (optional)
emailfrom = 'emailfrom_example' # str | The name of the sender to be displayed in the receipients inbox (optional)
emailreplyto = 'emailreplyto_example' # str | The reply-to field for the emails. (optional)

    try:
        # Send generated templates by email
        api_instance.templateemail(token, jobid, emailsubject, emailbody, templatekind=templatekind, emailfrom=emailfrom, emailreplyto=emailreplyto)
    except ApiException as e:
        print("Exception when calling DefaultApi->templateemail: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **jobid** | **str**| The id of the job that is creating the templates. | 
 **emailsubject** | **str**| Args depending on the send-to flag. | 
 **emailbody** | **str**| Args depending on the send-to flag. | 
 **templatekind** | **str**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional] 
 **emailfrom** | **str**| The name of the sender to be displayed in the receipients inbox | [optional] 
 **emailreplyto** | **str**| The reply-to field for the emails. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templategenerate**
> templategenerate(token, template, source, singlefile, userid=userid, forsending=forsending, role=role, filters=filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
template = 'template_example' # str | The id of the template to generate.
source = 'source_example' # str | The source key of the selected template data source.
singlefile = True # bool | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
userid = 'userid_example' # str | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas. (optional)
forsending = True # bool | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading (optional)
role = 'role_example' # str | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor (optional)
filters = 'filters_example' # str | Pipe separated filters for the generation, eg: aaa=val|bbb=val|... (optional)

    try:
        # Generate specified templates
        api_instance.templategenerate(token, template, source, singlefile, userid=userid, forsending=forsending, role=role, filters=filters)
    except ApiException as e:
        print("Exception when calling DefaultApi->templategenerate: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **template** | [**str**](.md)| The id of the template to generate. | 
 **source** | [**str**](.md)| The source key of the selected template data source. | 
 **singlefile** | **bool**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **str**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **bool**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**str**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **str**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templateget**
> templateget(token, id)

View details of a template

Allows the user to view a template and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the template to get.

    try:
        # View details of a template
        api_instance.templateget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->templateget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the template to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templategetgenerated**
> templategetgenerated(token, jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
jobid = 'jobid_example' # str | The id of the job that is creating the templates.

    try:
        # View generated templates
        api_instance.templategetgenerated(token, jobid)
    except ApiException as e:
        print("Exception when calling DefaultApi->templategetgenerated: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **jobid** | **str**| The id of the job that is creating the templates. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatelist**
> templatelist(token, _from, count, kind, designedonly=designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
kind = 'kind_example' # str | The kind of the templates to return. It must be included in (badge, certificate).
designedonly = True # bool | If true then it only returns the templates that were designed. Otherwise, it returns all. (optional)

    try:
        # View a list of defined templates
        api_instance.templatelist(token, _from, count, kind, designedonly=designedonly)
    except ApiException as e:
        print("Exception when calling DefaultApi->templatelist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **kind** | **str**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **bool**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatelistsources**
> templatelistsources(token, kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
kind = 'kind_example' # str | The kind of the templates to return. It must be included in (badge, certificate).

    try:
        # View a list of templates' data sources
        api_instance.templatelistsources(token, kind)
    except ApiException as e:
        print("Exception when calling DefaultApi->templatelistsources: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **kind** | **str**| The kind of the templates to return. It must be included in (badge, certificate). | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatesave**
> templatesave(unknown_base_type=unknown_base_type)

Create or edit a template

Allows the user to create or edit a template.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a template
        api_instance.templatesave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->templatesave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **templatesavelayout**
> templatesavelayout(unknown_base_type=unknown_base_type)

Save the layout of a template

Allows the user to edit a template's layout.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Save the layout of a template
        api_instance.templatesavelayout(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->templatesavelayout: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termdelete**
> termdelete(token, id)

Delete a term

Allows the user to delete a term from the existing list.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the term to delete.

    try:
        # Delete a term
        api_instance.termdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->termdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the term to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termget**
> termget(token, id)

Search and view details of a term

Allows the user to view a term and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the term to get.

    try:
        # Search and view details of a term
        api_instance.termget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->termget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the term to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termlist**
> termlist(token, _from=_from, count=count, notpast=notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return. (optional)
count = 56 # int | The max number of records to return. (optional)
notpast = True # bool | Specifies whether the terms in the past should be returned or not. (optional)

    try:
        # Search and view details of all terms
        api_instance.termlist(token, _from=_from, count=count, notpast=notpast)
    except ApiException as e:
        print("Exception when calling DefaultApi->termlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 
 **notpast** | **bool**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termsave**
> termsave(unknown_base_type=unknown_base_type)

Create and edit terms

Allows the user to create and edit terms.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create and edit terms
        api_instance.termsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->termsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **textcreditremaining**
> textcreditremaining(token)

Gets the remaining text credits for the account

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Gets the remaining text credits for the account
        api_instance.textcreditremaining(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->textcreditremaining: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **texttoimage**
> texttoimage(token, text, fontcolor=fontcolor, fontsize=fontsize, direction=direction, width=width)

Generates a dynamic image from text

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
text = 'text_example' # str | The text to convert to an image, use double pipes (||) as a new line.
fontcolor = 'fontcolor_example' # str | The color of the text, in hex format, without the #. (optional)
fontsize = 56 # int | The size of the text, in points. (optional)
direction = 'direction_example' # str | Either vertical or horizontal, default horizontal. (optional)
width = 56 # int | The image width in pixels (or height if the direction is vertical). (optional)

    try:
        # Generates a dynamic image from text
        api_instance.texttoimage(token, text, fontcolor=fontcolor, fontsize=fontsize, direction=direction, width=width)
    except ApiException as e:
        print("Exception when calling DefaultApi->texttoimage: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **text** | **str**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **str**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **int**| The size of the text, in points. | [optional] 
 **direction** | **str**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **int**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translationget**
> translationget(token, universal)

Gets the translations of the specified values

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
universal = 'universal_example' # str | Pipe separated list of universal text to be translated.

    try:
        # Gets the translations of the specified values
        api_instance.translationget(token, universal)
    except ApiException as e:
        print("Exception when calling DefaultApi->translationget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **universal** | **str**| Pipe separated list of universal text to be translated. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translationgetcachefile**
> translationgetcachefile(token=token, account=account)

Get the file containing the translations

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token. (optional)
account = 'account_example' # str | The id of the account whose translations file has to be retrieved. (optional)

    try:
        # Get the file containing the translations
        api_instance.translationgetcachefile(token=token, account=account)
    except ApiException as e:
        print("Exception when calling DefaultApi->translationgetcachefile: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | [optional] 
 **account** | **str**| The id of the account whose translations file has to be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translationlist**
> translationlist(token, filter=filter, nondefaultonly=nondefaultonly, appdefaultasuniversal=appdefaultasuniversal)

Lists all the available translations in the system

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
filter = 'filter_example' # str | Text to search/filter translations. (optional)
nondefaultonly = True # bool | If true then it returns only the terms translated. Otherwise, it returns all. (optional)
appdefaultasuniversal = True # bool | If true then it uses the app default translation as the universal term. (optional)

    try:
        # Lists all the available translations in the system
        api_instance.translationlist(token, filter=filter, nondefaultonly=nondefaultonly, appdefaultasuniversal=appdefaultasuniversal)
    except ApiException as e:
        print("Exception when calling DefaultApi->translationlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **filter** | **str**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **bool**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **bool**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translationsave**
> translationsave(unknown_base_type=unknown_base_type)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Edit a translation
        api_instance.translationsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->translationsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userchangepwd**
> userchangepwd(token, oldpass, newpass)

Change user's own password

Allows the user to change their own password.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
oldpass = 'oldpass_example' # str | The old password of the authenticated user.
newpass = 'newpass_example' # str | The new password of the authenticated user.

    try:
        # Change user's own password
        api_instance.userchangepwd(token, oldpass, newpass)
    except ApiException as e:
        print("Exception when calling DefaultApi->userchangepwd: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **oldpass** | [**str**](.md)| The old password of the authenticated user. | 
 **newpass** | [**str**](.md)| The new password of the authenticated user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userchangepwdbyreq**
> userchangepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    changereq = 'changereq_example' # str | The change password request ID sent by email to the user.
newpass = 'newpass_example' # str | The new password of the user.

    try:
        # Changes the user password using a change password request id
        api_instance.userchangepwdbyreq(changereq, newpass)
    except ApiException as e:
        print("Exception when calling DefaultApi->userchangepwdbyreq: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **str**| The change password request ID sent by email to the user. | 
 **newpass** | **str**| The new password of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userdelete**
> userdelete(token, id)

Delete a user

Allows the user to delete a user.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the user to delete.

    try:
        # Delete a user
        api_instance.userdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->userdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the user to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userfindsimilar**
> userfindsimilar(token, currentid=currentid, phonenumber=phonenumber, cardnumber=cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
currentid = 'currentid_example' # str | The id of the current user. (optional)
phonenumber = 'phonenumber_example' # str | A phone number to search for similar users. (optional)
cardnumber = 'cardnumber_example' # str | A card number to search for similar users. (optional)

    try:
        # Finds similar users to prevent duplicates
        api_instance.userfindsimilar(token, currentid=currentid, phonenumber=phonenumber, cardnumber=cardnumber)
    except ApiException as e:
        print("Exception when calling DefaultApi->userfindsimilar: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **currentid** | [**str**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **str**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **str**| A card number to search for similar users. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userget**
> userget(token, id, photosize=photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the user to get.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Search and view details of a user
        api_instance.userget(token, id, photosize=photosize)
    except ApiException as e:
        print("Exception when calling DefaultApi->userget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the user to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergetbycard**
> usergetbycard(token, card, photosize=photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
card = 'card_example' # str | The card number of the user to get.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Search user by card number
        api_instance.usergetbycard(token, card, photosize=photosize)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergetbycard: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **card** | **str**| The card number of the user to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupaddmember**
> usergroupaddmember(token, userid, groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
userid = 'userid_example' # str | The id of the user to add.
groupid = 'groupid_example' # str | The id of the group.

    try:
        # Add a user to a group
        api_instance.usergroupaddmember(token, userid, groupid)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergroupaddmember: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **userid** | [**str**](.md)| The id of the user to add. | 
 **groupid** | [**str**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupdelete**
> usergroupdelete(token, id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the group to delete.

    try:
        # Delete a group
        api_instance.usergroupdelete(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergroupdelete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the group to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupget**
> usergroupget(token, id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the user group to get.

    try:
        # Search and view details of a user group
        api_instance.usergroupget(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergroupget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupgetmembers**
> usergroupgetmembers(token, groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
groupid = 'groupid_example' # str | The id of the user group to get.

    try:
        # View the members of a user group
        api_instance.usergroupgetmembers(token, groupid)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergroupgetmembers: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **groupid** | [**str**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupgetuser**
> usergroupgetuser(token, userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
userid = 'userid_example' # str | The id of the user to get his groups.

    try:
        # View the groups which a user is registered to
        api_instance.usergroupgetuser(token, userid)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergroupgetuser: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **userid** | [**str**](.md)| The id of the user to get his groups. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergrouplist**
> usergrouplist(token, _from=_from, count=count, type=type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return. (optional)
count = 56 # int | The max number of records to return. (optional)
type = 'type_example' # str | The type of the groups to return. Either 'user', 'dynamic' or any other type of group. (optional)

    try:
        # View a list of user groups
        api_instance.usergrouplist(token, _from=_from, count=count, type=type)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergrouplist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | [optional] 
 **count** | **int**| The max number of records to return. | [optional] 
 **type** | **str**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergrouprefresh**
> usergrouprefresh(token, group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
group = 'group_example' # str | The ID of the group to refresh.

    try:
        # Refresh the dynamic group
        api_instance.usergrouprefresh(token, group)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergrouprefresh: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **group** | [**str**](.md)| The ID of the group to refresh. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupremovemember**
> usergroupremovemember(token, userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
userid = 'userid_example' # str | The id of the user to remove.
groupid = 'groupid_example' # str | The id of the group.

    try:
        # Remove a user from a group
        api_instance.usergroupremovemember(token, userid, groupid)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergroupremovemember: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **userid** | [**str**](.md)| The id of the user to remove. | 
 **groupid** | [**str**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usergroupsave**
> usergroupsave(unknown_base_type=unknown_base_type)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a group
        api_instance.usergroupsave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->usergroupsave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userlist**
> userlist(token, _from, count, roleid=roleid, onlywithoutcard=onlywithoutcard, photosize=photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
roleid = 'roleid_example' # str | The id of the role to filter users by, or empty to return all users. (optional)
onlywithoutcard = 'onlywithoutcard_example' # str | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # View a list of users
        api_instance.userlist(token, _from, count, roleid=roleid, onlywithoutcard=onlywithoutcard, photosize=photosize)
    except ApiException as e:
        print("Exception when calling DefaultApi->userlist: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **roleid** | [**str**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **str**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userloadphoto**
> userloadphoto(token, upload, filename=filename, userid=userid, automatch=automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
upload = 'upload_example' # str | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # str | The local name of the uploaded file. For later reference. (optional)
userid = 'userid_example' # str | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'. (optional)
automatch = True # bool | Set this to true to find the specific user based on the file name.  (optional)

    try:
        # Upload a photo for a specific user
        api_instance.userloadphoto(token, upload, filename=filename, userid=userid, automatch=automatch)
    except ApiException as e:
        print("Exception when calling DefaultApi->userloadphoto: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **upload** | **str**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **str**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**str**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **bool**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usermovedata**
> usermovedata(token, source, destination)

Move data between users

Allows administrators to move data between users.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
source = 'source_example' # str | The id of the user that is the source of the data.
destination = 'destination_example' # str | The id of the user that is the destination of the data.

    try:
        # Move data between users
        api_instance.usermovedata(token, source, destination)
    except ApiException as e:
        print("Exception when calling DefaultApi->usermovedata: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **source** | [**str**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**str**](.md)| The id of the user that is the destination of the data. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userrequestpwdchange**
> userrequestpwdchange(domain, email)

Requests a password change

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    domain = 'domain_example' # str | The domain of the account where the user exists.
email = 'email_example' # str | The email of the user.

    try:
        # Requests a password change
        api_instance.userrequestpwdchange(domain, email)
    except ApiException as e:
        print("Exception when calling DefaultApi->userrequestpwdchange: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **str**| The domain of the account where the user exists. | 
 **email** | **str**| The email of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersave**
> usersave(unknown_base_type=unknown_base_type)

Create or edit a user

Allows the user to create or edit a user.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a user
        api_instance.usersave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->usersave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersavepwdchange**
> usersavepwdchange(unknown_base_type=unknown_base_type)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Send email to the specified user(s) to set/change their passwords
        api_instance.usersavepwdchange(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->usersavepwdchange: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettingsget**
> usersettingsget(token, keys, user=user)

Lists available user settings

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
keys = 'keys_example' # str | Setting key to get. Can be multiple separated by commas.
user = 'user_example' # str | The user id whose settings have to be returned. (optional)

    try:
        # Lists available user settings
        api_instance.usersettingsget(token, keys, user=user)
    except ApiException as e:
        print("Exception when calling DefaultApi->usersettingsget: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **keys** | **str**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**str**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettingsgetmultiple**
> usersettingsgetmultiple(token, keys, user=user)

Get multiple user settings

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
keys = 'keys_example' # str | Setting key to get. Can be multiple separated by commas.
user = 'user_example' # str | The user id whose settings have to be returned. (optional)

    try:
        # Get multiple user settings
        api_instance.usersettingsgetmultiple(token, keys, user=user)
    except ApiException as e:
        print("Exception when calling DefaultApi->usersettingsgetmultiple: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **keys** | **str**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**str**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettingssave**
> usersettingssave(unknown_base_type=unknown_base_type)

Saves a user setting

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Saves a user setting
        api_instance.usersettingssave(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->usersettingssave: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersettingssavemultiple**
> usersettingssavemultiple(unknown_base_type=unknown_base_type)

Save multiple user settings at once

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Save multiple user settings at once
        api_instance.usersettingssavemultiple(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->usersettingssavemultiple: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertaskdeleteplan**
> usertaskdeleteplan(token, id)

Deletes a task plan

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the task plan to delete.

    try:
        # Deletes a task plan
        api_instance.usertaskdeleteplan(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->usertaskdeleteplan: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the task plan to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertaskgetmine**
> usertaskgetmine(token)

Lists the task plans of the logged user

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Lists the task plans of the logged user
        api_instance.usertaskgetmine(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->usertaskgetmine: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertaskgetplan**
> usertaskgetplan(token, id)

Gets a task plan by Id

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
id = 'id_example' # str | The id of the task plan to get.

    try:
        # Gets a task plan by Id
        api_instance.usertaskgetplan(token, id)
    except ApiException as e:
        print("Exception when calling DefaultApi->usertaskgetplan: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **id** | [**str**](.md)| The id of the task plan to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertasklistdefs**
> usertasklistdefs()

Lists task types or definitions

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    
    try:
        # Lists task types or definitions
        api_instance.usertasklistdefs()
    except ApiException as e:
        print("Exception when calling DefaultApi->usertasklistdefs: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertasklistplan**
> usertasklistplan(token, _from, count)

Lists task plans

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.
_from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.

    try:
        # Lists task plans
        api_instance.usertasklistplan(token, _from, count)
    except ApiException as e:
        print("Exception when calling DefaultApi->usertasklistplan: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertasksaveplan**
> usertasksaveplan(unknown_base_type=unknown_base_type)

Saves a task plan

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Saves a task plan
        api_instance.usertasksaveplan(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling DefaultApi->usertasksaveplan: %s\n" % e)
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **version**
> version(token)

Get current version information

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.DefaultApi(api_client)
    token = 'token_example' # str | The authentication token.

    try:
        # Get current version information
        api_instance.version(token)
    except ApiException as e:
        print("Exception when calling DefaultApi->version: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The authentication token. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

