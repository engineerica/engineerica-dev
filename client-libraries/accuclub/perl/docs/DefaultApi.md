# WWW::OpenAPIClient::DefaultApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::DefaultApi;
```

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
[**version**](DefaultApi.md#version) | **GET** /version | Get current version information


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

# **creditdelete**
> creditdelete(token => $token, id => $id)

Delete a credit

Allows the user to delete credits.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the credit to delete.

eval { 
    $api_instance->creditdelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditdelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the credit to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **creditdiscountmethods**
> creditdiscountmethods()

Gets the valid discount methods.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);


eval { 
    $api_instance->creditdiscountmethods();
};
if ($@) {
    warn "Exception when calling DefaultApi->creditdiscountmethods: $@\n";
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

# **creditget**
> creditget(token => $token, id => $id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the credit to get.

eval { 
    $api_instance->creditget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the credit to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **creditgetuserbalance**
> creditgetuserbalance(token => $token, user => $user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $user = null; # string | The id of the user whose balance has to be returned.

eval { 
    $api_instance->creditgetuserbalance(token => $token, user => $user);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditgetuserbalance: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **user** | [**string**](.md)| The id of the user whose balance has to be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **creditlist**
> creditlist(token => $token, user => $user, from => $from, count => $count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $user = null; # string | The id of the user.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->creditlist(token => $token, user => $user, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **user** | [**string**](.md)| The id of the user. | 
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

# **creditlistdetails**
> creditlistdetails(token => $token, credit => $credit, from => $from, count => $count)

Gets the credit usage details

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $credit = null; # string | The id of the credit to look up for details.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->creditlistdetails(token => $token, credit => $credit, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditlistdetails: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **credit** | [**string**](.md)| The id of the credit to look up for details. | 
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

# **creditlistmine**
> creditlistmine(token => $token, from => $from, count => $count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

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
    $api_instance->creditlistmine(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditlistmine: $@\n";
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

# **creditplandelete**
> creditplandelete(token => $token, id => $id)

Deletes a credit plan

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the credit plan to delete.

eval { 
    $api_instance->creditplandelete(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditplandelete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the credit plan to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **creditplanget**
> creditplanget(token => $token, id => $id)

Gets a credit plan

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $token = "token_example"; # string | The authentication token.
my $id = null; # string | The id of the credit plan to get.

eval { 
    $api_instance->creditplanget(token => $token, id => $id);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditplanget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**string**](.md)| The id of the credit plan to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **creditplanlist**
> creditplanlist(token => $token, from => $from, count => $count)

Gets the credit plans available

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
    $api_instance->creditplanlist(token => $token, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditplanlist: $@\n";
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

# **creditplansave**
> creditplansave(unknown_base_type => $unknown_base_type)

Saves a credit plan

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->creditplansave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditplansave: $@\n";
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

# **creditsave**
> creditsave(unknown_base_type => $unknown_base_type)

Create or edit credit for a user

Allows the user to create or edit credit for a user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->creditsave(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditsave: $@\n";
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

# **creditsavedetails**
> creditsavedetails(unknown_base_type => $unknown_base_type)

Create or edit credit details

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DefaultApi;
my $api_instance = WWW::OpenAPIClient::DefaultApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->creditsavedetails(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DefaultApi->creditsavedetails: $@\n";
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

