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
[**import**](DefaultApi.md#import) | **GET** /import | Import data into AccuCampus
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


## usertaskdeleteplan

> usertaskdeleteplan(token, id)

Deletes a task plan

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the task plan to delete.

begin
  #Deletes a task plan
  api_instance.usertaskdeleteplan(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usertaskdeleteplan: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the task plan to delete. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usertaskgetmine

> usertaskgetmine(token)

Lists the task plans of the logged user

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.

begin
  #Lists the task plans of the logged user
  api_instance.usertaskgetmine(token)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usertaskgetmine: #{e}"
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


## usertaskgetplan

> usertaskgetplan(token, id)

Gets a task plan by Id

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
id = 'id_example' # String | The id of the task plan to get.

begin
  #Gets a task plan by Id
  api_instance.usertaskgetplan(token, id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usertaskgetplan: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the task plan to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usertasklistdefs

> usertasklistdefs

Lists task types or definitions

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new

begin
  #Lists task types or definitions
  api_instance.usertasklistdefs
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usertasklistdefs: #{e}"
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


## usertasklistplan

> usertasklistplan(token, from, count)

Lists task plans

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
token = 'token_example' # String | The authentication token.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #Lists task plans
  api_instance.usertasklistplan(token, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usertasklistplan: #{e}"
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


## usertasksaveplan

> usertasksaveplan(opts)

Saves a task plan

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::DefaultApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a task plan
  api_instance.usertasksaveplan(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling DefaultApi->usertasksaveplan: #{e}"
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

