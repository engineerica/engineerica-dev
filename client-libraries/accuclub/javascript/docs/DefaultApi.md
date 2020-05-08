# AccuCampusOpenApi3Documentation.DefaultApi

All URIs are relative to *https://accucampus.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionloglist**](DefaultApi.md#actionloglist) | **GET** /actionloglist | View a list of users action logs
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
[**callExport**](DefaultApi.md#callExport) | **GET** /export | Export AccuCampus data
[**callImport**](DefaultApi.md#callImport) | **GET** /import | Import data into AccuCampus
[**captchagetchallenge**](DefaultApi.md#captchagetchallenge) | **GET** /captchagetchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captchagetimage**](DefaultApi.md#captchagetimage) | **GET** /captchagetimage | Gets a captcha image that the user must complete to do certain requests.
[**changelog**](DefaultApi.md#changelog) | **GET** /changelog | Get the application change log
[**clientget**](DefaultApi.md#clientget) | **GET** /clientget | Get client
[**clientlist**](DefaultApi.md#clientlist) | **GET** /clientlist | Gets the clients of the specified conference
[**clientsave**](DefaultApi.md#clientsave) | **POST** /clientsave | Saves a client
[**clientsendmessage**](DefaultApi.md#clientsendmessage) | **GET** /clientsendmessage | Send a message to a client
[**creditdelete**](DefaultApi.md#creditdelete) | **GET** /creditdelete | Delete a credit
[**creditdiscountmethods**](DefaultApi.md#creditdiscountmethods) | **GET** /creditdiscountmethods | Gets the valid discount methods.
[**creditget**](DefaultApi.md#creditget) | **GET** /creditget | View details of assigned credit
[**creditgetuserbalance**](DefaultApi.md#creditgetuserbalance) | **GET** /creditgetuserbalance | Get the total amount of credits of the specified user
[**creditlist**](DefaultApi.md#creditlist) | **GET** /creditlist | View a list of credits for a specific user
[**creditlistdetails**](DefaultApi.md#creditlistdetails) | **GET** /creditlistdetails | Gets the credit usage details
[**creditlistmine**](DefaultApi.md#creditlistmine) | **GET** /creditlistmine | View the list of credits of the current user
[**creditplandelete**](DefaultApi.md#creditplandelete) | **GET** /creditplandelete | Deletes a credit plan
[**creditplanget**](DefaultApi.md#creditplanget) | **GET** /creditplanget | Gets a credit plan
[**creditplanlist**](DefaultApi.md#creditplanlist) | **GET** /creditplanlist | Gets the credit plans available
[**creditplansave**](DefaultApi.md#creditplansave) | **POST** /creditplansave | Saves a credit plan
[**creditsave**](DefaultApi.md#creditsave) | **POST** /creditsave | Create or edit credit for a user
[**creditsavedetails**](DefaultApi.md#creditsavedetails) | **POST** /creditsavedetails | Create or edit credit details
[**doc**](DefaultApi.md#doc) | **GET** /doc | Get the documentation
[**easyloginaddbgimage**](DefaultApi.md#easyloginaddbgimage) | **GET** /easyloginaddbgimage | Adds background image for the login
[**eventdelete**](DefaultApi.md#eventdelete) | **GET** /eventdelete | Delete a course
[**eventget**](DefaultApi.md#eventget) | **GET** /eventget | Search and view details of a course
[**eventgetsessionsbydate**](DefaultApi.md#eventgetsessionsbydate) | **GET** /eventgetsessionsbydate | View a list of courses by date
[**eventlist**](DefaultApi.md#eventlist) | **GET** /eventlist | View a list of courses
[**eventsave**](DefaultApi.md#eventsave) | **POST** /eventsave | Create or edit a course
[**eventsearchgroup**](DefaultApi.md#eventsearchgroup) | **GET** /eventsearchgroup | Searches for the available event groups
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
[**version**](DefaultApi.md#version) | **GET** /version | Get current version information



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


## creditdelete

> creditdelete(token, id)

Delete a credit

Allows the user to delete credits.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the credit to delete.
apiInstance.creditdelete(token, id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the credit to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## creditdiscountmethods

> creditdiscountmethods()

Gets the valid discount methods.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
apiInstance.creditdiscountmethods((error, data, response) => {
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


## creditget

> creditget(token, id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the credit to get.
apiInstance.creditget(token, id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the credit to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## creditgetuserbalance

> creditgetuserbalance(token, user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let user = null; // String | The id of the user whose balance has to be returned.
apiInstance.creditgetuserbalance(token, user, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **user** | [**String**](.md)| The id of the user whose balance has to be returned. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## creditlist

> creditlist(token, user, from, count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let user = null; // String | The id of the user.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.creditlist(token, user, from, count, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **user** | [**String**](.md)| The id of the user. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## creditlistdetails

> creditlistdetails(token, credit, from, count)

Gets the credit usage details

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let credit = null; // String | The id of the credit to look up for details.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.creditlistdetails(token, credit, from, count, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **credit** | [**String**](.md)| The id of the credit to look up for details. | 
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## creditlistmine

> creditlistmine(token, from, count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.creditlistmine(token, from, count, (error, data, response) => {
  if (error) {
    console.error(error);
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


## creditplandelete

> creditplandelete(token, id)

Deletes a credit plan

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the credit plan to delete.
apiInstance.creditplandelete(token, id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the credit plan to delete. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## creditplanget

> creditplanget(token, id)

Gets a credit plan

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let id = null; // String | The id of the credit plan to get.
apiInstance.creditplanget(token, id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. | 
 **id** | [**String**](.md)| The id of the credit plan to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## creditplanlist

> creditplanlist(token, from, count)

Gets the credit plans available

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let token = "token_example"; // String | The authentication token.
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.creditplanlist(token, from, count, (error, data, response) => {
  if (error) {
    console.error(error);
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


## creditplansave

> creditplansave(opts)

Saves a credit plan

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.creditplansave(opts, (error, data, response) => {
  if (error) {
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


## creditsave

> creditsave(opts)

Create or edit credit for a user

Allows the user to create or edit credit for a user

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.creditsave(opts, (error, data, response) => {
  if (error) {
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


## creditsavedetails

> creditsavedetails(opts)

Create or edit credit details

### Example

```javascript
import AccuCampusOpenApi3Documentation from 'accu_campus_open_api_3_documentation';

let apiInstance = new AccuCampusOpenApi3Documentation.DefaultApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3Documentation.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.creditsavedetails(opts, (error, data, response) => {
  if (error) {
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

