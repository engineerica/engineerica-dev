# OpenAPI\Client\DefaultApi

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


## creditdelete

> creditdelete($token, $id)

Delete a credit

Allows the user to delete credits.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the credit to delete.

try {
    $apiInstance->creditdelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditdelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the credit to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## creditdiscountmethods

> creditdiscountmethods()

Gets the valid discount methods.

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
    $apiInstance->creditdiscountmethods();
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditdiscountmethods: ', $e->getMessage(), PHP_EOL;
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


## creditget

> creditget($token, $id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the credit to get.

try {
    $apiInstance->creditget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the credit to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## creditgetuserbalance

> creditgetuserbalance($token, $user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$user = 'user_example'; // string | The id of the user whose balance has to be returned.

try {
    $apiInstance->creditgetuserbalance($token, $user);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditgetuserbalance: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **user** | [**string**](../Model/.md)| The id of the user whose balance has to be returned. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## creditlist

> creditlist($token, $user, $from, $count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$user = 'user_example'; // string | The id of the user.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->creditlist($token, $user, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **user** | [**string**](../Model/.md)| The id of the user. |
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


## creditlistdetails

> creditlistdetails($token, $credit, $from, $count)

Gets the credit usage details

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$credit = 'credit_example'; // string | The id of the credit to look up for details.
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->creditlistdetails($token, $credit, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditlistdetails: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **credit** | [**string**](../Model/.md)| The id of the credit to look up for details. |
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


## creditlistmine

> creditlistmine($token, $from, $count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

### Example

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
    $apiInstance->creditlistmine($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditlistmine: ', $e->getMessage(), PHP_EOL;
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


## creditplandelete

> creditplandelete($token, $id)

Deletes a credit plan

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the credit plan to delete.

try {
    $apiInstance->creditplandelete($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditplandelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the credit plan to delete. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## creditplanget

> creditplanget($token, $id)

Gets a credit plan

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$token = 'token_example'; // string | The authentication token.
$id = 'id_example'; // string | The id of the credit plan to get.

try {
    $apiInstance->creditplanget($token, $id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditplanget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. |
 **id** | [**string**](../Model/.md)| The id of the credit plan to get. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## creditplanlist

> creditplanlist($token, $from, $count)

Gets the credit plans available

### Example

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
    $apiInstance->creditplanlist($token, $from, $count);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditplanlist: ', $e->getMessage(), PHP_EOL;
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


## creditplansave

> creditplansave($unknown_base_type)

Saves a credit plan

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
    $apiInstance->creditplansave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditplansave: ', $e->getMessage(), PHP_EOL;
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


## creditsave

> creditsave($unknown_base_type)

Create or edit credit for a user

Allows the user to create or edit credit for a user

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
    $apiInstance->creditsave($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditsave: ', $e->getMessage(), PHP_EOL;
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


## creditsavedetails

> creditsavedetails($unknown_base_type)

Create or edit credit details

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
    $apiInstance->creditsavedetails($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->creditsavedetails: ', $e->getMessage(), PHP_EOL;
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

