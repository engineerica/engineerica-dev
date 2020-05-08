# DefaultApi

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
[**version**](DefaultApi.md#version) | **GET** /version | Get current version information


<a name="actionloglist"></a>
# **actionloglist**
> actionloglist(token, from, count, user, startdate, enddate, resource, actionfilter, argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID user = new UUID(); // UUID | The id of the user whose action logs have to be returned.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the logs.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the logs.
    String resource = "resource_example"; // String | The resource to filter the action logs.
    String actionfilter = "actionfilter_example"; // String | The action to filter the action logs.
    String argument = "argument_example"; // String | The id of the entity that was the argument of the executed action.
    try {
      apiInstance.actionloglist(token, from, count, user, startdate, enddate, resource, actionfilter, argument);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#actionloglist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **user** | [**UUID**](.md)| The id of the user whose action logs have to be returned. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the logs. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the logs. | [optional]
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advroleaddmissing"></a>
# **advroleaddmissing**
> advroleaddmissing(token, roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String roles = "roles_example"; // String | CSV list of the role ids to check
    String permissions = "permissions_example"; // String | CSV list of the permissions to check
    try {
      apiInstance.advroleaddmissing(token, roles, permissions);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advroleaddmissing");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advrolecheckperm"></a>
# **advrolecheckperm**
> advrolecheckperm(token, roles, permissions)

Checks the permissions are assigned for the given roles

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String roles = "roles_example"; // String | CSV list of the role ids to check
    String permissions = "permissions_example"; // String | CSV list of the permissions to check
    try {
      apiInstance.advrolecheckperm(token, roles, permissions);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advrolecheckperm");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advroledelete"></a>
# **advroledelete**
> advroledelete(token, id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the location to delete.
    try {
      apiInstance.advroledelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advroledelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the location to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advroledeletemapping"></a>
# **advroledeletemapping**
> advroledeletemapping(token, map, roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String map = "map_example"; // String | The map name to save the role.
    UUID roleid = new UUID(); // UUID | The id of the role.
    try {
      apiInstance.advroledeletemapping(token, map, roleid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advroledeletemapping");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **map** | **String**| The map name to save the role. |
 **roleid** | [**UUID**](.md)| The id of the role. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advroleget"></a>
# **advroleget**
> advroleget(token, id)

View details of a role

Allows the user to view a role and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the location to get.
    try {
      apiInstance.advroleget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advroleget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the location to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advrolelist"></a>
# **advrolelist**
> advrolelist(token, includepolicies, includeinternal, name)

Lists the roles for the current account

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Boolean includepolicies = true; // Boolean | True to include the policies, defaults to false.
    Boolean includeinternal = true; // Boolean | True to include the internal roles too.
    String name = "name_example"; // String | Filter by name of the role.
    try {
      apiInstance.advrolelist(token, includepolicies, includeinternal, name);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advrolelist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advrolelistmaps"></a>
# **advrolelistmaps**
> advrolelistmaps(token, roleid)

Lists the maps a roles is mapped to

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID roleid = new UUID(); // UUID | The id of the role to list the maps.
    try {
      apiInstance.advrolelistmaps(token, roleid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advrolelistmaps");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **roleid** | [**UUID**](.md)| The id of the role to list the maps. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advrolelistrolesmapped"></a>
# **advrolelistrolesmapped**
> advrolelistrolesmapped(token, map)

Lists the roles mappings

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String map = "map_example"; // String | List only the roles in the specified map.
    try {
      apiInstance.advrolelistrolesmapped(token, map);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advrolelistrolesmapped");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advrolelisttemplates"></a>
# **advrolelisttemplates**
> advrolelisttemplates(token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.advrolelisttemplates(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advrolelisttemplates");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advrolesave"></a>
# **advrolesave**
> advrolesave(UNKNOWN_BASE_TYPE)

Create or edit a role

Allows the user to create or edit a role&#39;s permissions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.advrolesave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advrolesave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advrolesavemapping"></a>
# **advrolesavemapping**
> advrolesavemapping(UNKNOWN_BASE_TYPE)

Saves a role mapping

Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.advrolesavemapping(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advrolesavemapping");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advrolesuserlist"></a>
# **advrolesuserlist**
> advrolesuserlist(token, from, count, roleid, onlywithoutcard, photosize)

List users. Alias to user.list, use that one instead.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID roleid = new UUID(); // UUID | The id of the role to filter users by, or empty to return all users.
    String onlywithoutcard = "onlywithoutcard_example"; // String | If is 1 then only the users without a card are returned, otherwise all users are returned.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.advrolesuserlist(token, from, count, roleid, onlywithoutcard, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advrolesuserlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **roleid** | [**UUID**](.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="advroleuserupgrade"></a>
# **advroleuserupgrade**
> advroleuserupgrade(token, userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID userid = new UUID(); // UUID | Id of the user to upgrade
    UUID roleid = new UUID(); // UUID | Id of the role to add
    try {
      apiInstance.advroleuserupgrade(token, userid, roleid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#advroleuserupgrade");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **userid** | [**UUID**](.md)| Id of the user to upgrade |
 **roleid** | [**UUID**](.md)| Id of the role to add |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="appsharegetphone"></a>
# **appsharegetphone**
> appsharegetphone(token)

Gets the phone number of the current user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.appsharegetphone(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#appsharegetphone");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="appsharesendtext"></a>
# **appsharesendtext**
> appsharesendtext(token, phonenumber)

Sends an SMS with the link to the app

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String phonenumber = "phonenumber_example"; // String | Phone number to where to send the link. Leave empty to the number on file.
    try {
      apiInstance.appsharesendtext(token, phonenumber);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#appsharesendtext");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogcommentdelete"></a>
# **attendancelogcommentdelete**
> attendancelogcommentdelete(token, id)

Delete a comment on an attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the attendance log comment to delete.
    try {
      apiInstance.attendancelogcommentdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogcommentdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the attendance log comment to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogcommentget"></a>
# **attendancelogcommentget**
> attendancelogcommentget(token, id)

View a comment on an attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the comment to get.
    try {
      apiInstance.attendancelogcommentget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogcommentget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the comment to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogcommentlist"></a>
# **attendancelogcommentlist**
> attendancelogcommentlist(attendancelog, token)

View all the comments on a specific attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UUID attendancelog = new UUID(); // UUID | The id of the attendance log whose comments have to be retrieved.
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.attendancelogcommentlist(attendancelog, token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogcommentlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**UUID**](.md)| The id of the attendance log whose comments have to be retrieved. |
 **token** | **String**| The authentication token. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogcommentsave"></a>
# **attendancelogcommentsave**
> attendancelogcommentsave(UNKNOWN_BASE_TYPE)

Save a comment on an attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.attendancelogcommentsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogcommentsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogdelete"></a>
# **attendancelogdelete**
> attendancelogdelete(token, id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the attendance log to delete.
    try {
      apiInstance.attendancelogdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the attendance log to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogget"></a>
# **attendancelogget**
> attendancelogget(token, id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the attendance log to get.
    try {
      apiInstance.attendancelogget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the attendance log to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendanceloggetchangehistory"></a>
# **attendanceloggetchangehistory**
> attendanceloggetchangehistory(token, id)

Search and view details of an attendance log&#39;s swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the attendance log to get.
    try {
      apiInstance.attendanceloggetchangehistory(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendanceloggetchangehistory");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the attendance log to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendanceloglist"></a>
# **attendanceloglist**
> attendanceloglist(from, count, token, filter, userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String token = "token_example"; // String | The authentication token.
    String filter = "filter_example"; // String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
    UUID userid = new UUID(); // UUID | The user ID of the user to get the logs.
    try {
      apiInstance.attendanceloglist(from, count, token, filter, userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendanceloglist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **token** | **String**| The authentication token. | [optional]
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]
 **userid** | [**UUID**](.md)| The user ID of the user to get the logs. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendanceloglistmine"></a>
# **attendanceloglistmine**
> attendanceloglistmine(from, count, token, filter)

Gets the attendance logs of the current user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String token = "token_example"; // String | The authentication token.
    String filter = "filter_example"; // String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
    try {
      apiInstance.attendanceloglistmine(from, count, token, filter);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendanceloglistmine");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **token** | **String**| The authentication token. | [optional]
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogsave"></a>
# **attendancelogsave**
> attendancelogsave(UNKNOWN_BASE_TYPE)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.attendancelogsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogsignout"></a>
# **attendancelogsignout**
> attendancelogsignout(token, id, location, event, datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who&#39;s In page.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the attendance log to sign-out.
    UUID location = new UUID(); // UUID | The id of the location to filter the users to sign out.
    UUID event = new UUID(); // UUID | The id of the event to filter the users to sign out.
    OffsetDateTime datetime = new OffsetDateTime(); // OffsetDateTime | Specifies the date and time when the specified logs have to be signed out.
    try {
      apiInstance.attendancelogsignout(token, id, location, event, datetime);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogsignout");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the attendance log to sign-out. | [optional]
 **location** | [**UUID**](.md)| The id of the location to filter the users to sign out. | [optional]
 **event** | [**UUID**](.md)| The id of the event to filter the users to sign out. | [optional]
 **datetime** | **OffsetDateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="attendancelogwhosin"></a>
# **attendancelogwhosin**
> attendancelogwhosin(from, count, token, location, event, sorting, roles, photosize, extensions, export)

View who&#39;s in a location

Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String token = "token_example"; // String | The authentication token.
    UUID location = new UUID(); // UUID | The id of the location to search for users that are in.
    UUID event = new UUID(); // UUID | The id of the event to search for users that are in.
    String sorting = "sorting_example"; // String | Field to sort by. Either first-name, last-name or sign-in-time.
    String roles = "roles_example"; // String | The comma-separated list of ids of the roles to search for users that are in.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    String extensions = "extensions_example"; // String | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
    Boolean export = true; // Boolean | True to export the results as CSV
    try {
      apiInstance.attendancelogwhosin(from, count, token, location, event, sorting, roles, photosize, extensions, export);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#attendancelogwhosin");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **token** | **String**| The authentication token. | [optional]
 **location** | [**UUID**](.md)| The id of the location to search for users that are in. | [optional]
 **event** | [**UUID**](.md)| The id of the event to search for users that are in. | [optional]
 **sorting** | **String**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional]
 **roles** | **String**| The comma-separated list of ids of the roles to search for users that are in. | [optional]
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **extensions** | **String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional]
 **export** | **Boolean**| True to export the results as CSV | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="bgjobgetstatus"></a>
# **bgjobgetstatus**
> bgjobgetstatus(token, jobid, jobtype)

Get background job status

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID jobid = new UUID(); // UUID | The ID of the job to get the status. 10 most recent will be returned if not specified.
    String jobtype = "jobtype_example"; // String | The job type to filter by.
    try {
      apiInstance.bgjobgetstatus(token, jobid, jobtype);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#bgjobgetstatus");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **jobid** | [**UUID**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional]
 **jobtype** | **String**| The job type to filter by. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="callImport"></a>
# **callImport**
> callImport(token, importtype, upload, filename, parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String importtype = "importtype_example"; // String | The kind of data that is being uploaded.
    String upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
    String filename = "filename_example"; // String | The local name of the uploaded file. For later reference.
    String parameters = "parameters_example"; // String | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.
    try {
      apiInstance.callImport(token, importtype, upload, filename, parameters);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#callImport");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="captchagetchallenge"></a>
# **captchagetchallenge**
> captchagetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    try {
      apiInstance.captchagetchallenge();
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#captchagetchallenge");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="captchagetimage"></a>
# **captchagetimage**
> captchagetimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String captchatoken = "captchatoken_example"; // String | The captcha token or ID returned by the captcha.getchallenge action
    try {
      apiInstance.captchagetimage(captchatoken);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#captchagetimage");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="changelog"></a>
# **changelog**
> changelog(token)

Get the application change log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.changelog(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#changelog");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="clientget"></a>
# **clientget**
> clientget(token, client, clientname)

Get client

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String client = "client_example"; // String | The unique id of the client.
    String clientname = "clientname_example"; // String | The custom name of the client.
    try {
      apiInstance.clientget(token, client, clientname);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#clientget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="clientlist"></a>
# **clientlist**
> clientlist(token, from, count)

Gets the clients of the specified conference

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.clientlist(token, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#clientlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="clientsave"></a>
# **clientsave**
> clientsave(UNKNOWN_BASE_TYPE)

Saves a client

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.clientsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#clientsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="clientsendmessage"></a>
# **clientsendmessage**
> clientsendmessage(token, uniqueclientid, message)

Send a message to a client

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID uniqueclientid = new UUID(); // UUID | The unique id of the client.
    String message = "message_example"; // String | The body of the message to send.
    try {
      apiInstance.clientsendmessage(token, uniqueclientid, message);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#clientsendmessage");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **uniqueclientid** | [**UUID**](.md)| The unique id of the client. |
 **message** | **String**| The body of the message to send. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditdelete"></a>
# **creditdelete**
> creditdelete(token, id)

Delete a credit

Allows the user to delete credits.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the credit to delete.
    try {
      apiInstance.creditdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the credit to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditdiscountmethods"></a>
# **creditdiscountmethods**
> creditdiscountmethods()

Gets the valid discount methods.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    try {
      apiInstance.creditdiscountmethods();
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditdiscountmethods");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditget"></a>
# **creditget**
> creditget(token, id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the credit to get.
    try {
      apiInstance.creditget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the credit to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditgetuserbalance"></a>
# **creditgetuserbalance**
> creditgetuserbalance(token, user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID user = new UUID(); // UUID | The id of the user whose balance has to be returned.
    try {
      apiInstance.creditgetuserbalance(token, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditgetuserbalance");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **user** | [**UUID**](.md)| The id of the user whose balance has to be returned. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditlist"></a>
# **creditlist**
> creditlist(token, user, from, count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID user = new UUID(); // UUID | The id of the user.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.creditlist(token, user, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **user** | [**UUID**](.md)| The id of the user. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditlistdetails"></a>
# **creditlistdetails**
> creditlistdetails(token, credit, from, count)

Gets the credit usage details

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID credit = new UUID(); // UUID | The id of the credit to look up for details.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.creditlistdetails(token, credit, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditlistdetails");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **credit** | [**UUID**](.md)| The id of the credit to look up for details. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditlistmine"></a>
# **creditlistmine**
> creditlistmine(token, from, count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.creditlistmine(token, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditlistmine");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditplandelete"></a>
# **creditplandelete**
> creditplandelete(token, id)

Deletes a credit plan

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the credit plan to delete.
    try {
      apiInstance.creditplandelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditplandelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the credit plan to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditplanget"></a>
# **creditplanget**
> creditplanget(token, id)

Gets a credit plan

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the credit plan to get.
    try {
      apiInstance.creditplanget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditplanget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the credit plan to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditplanlist"></a>
# **creditplanlist**
> creditplanlist(token, from, count)

Gets the credit plans available

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.creditplanlist(token, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditplanlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditplansave"></a>
# **creditplansave**
> creditplansave(UNKNOWN_BASE_TYPE)

Saves a credit plan

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.creditplansave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditplansave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditsave"></a>
# **creditsave**
> creditsave(UNKNOWN_BASE_TYPE)

Create or edit credit for a user

Allows the user to create or edit credit for a user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.creditsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="creditsavedetails"></a>
# **creditsavedetails**
> creditsavedetails(UNKNOWN_BASE_TYPE)

Create or edit credit details

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.creditsavedetails(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#creditsavedetails");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="doc"></a>
# **doc**
> doc(excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    Boolean excludeanonymous = true; // Boolean | If true it excludes the anonymous actions from the returned list.
    try {
      apiInstance.doc(excludeanonymous);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#doc");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="easyloginaddbgimage"></a>
# **easyloginaddbgimage**
> easyloginaddbgimage(token, upload, filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
    String filename = "filename_example"; // String | The original filename, needed to process the file.
    try {
      apiInstance.easyloginaddbgimage(token, upload, filename);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#easyloginaddbgimage");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="eventdelete"></a>
# **eventdelete**
> eventdelete(token, id)

Delete a course

Allows the user to delete an existing course.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the event to delete.
    try {
      apiInstance.eventdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#eventdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the event to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="eventget"></a>
# **eventget**
> eventget(token, id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the event to get.
    try {
      apiInstance.eventget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#eventget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the event to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="eventgetsessionsbydate"></a>
# **eventgetsessionsbydate**
> eventgetsessionsbydate(token, location, date, type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID location = new UUID(); // UUID | The location to filter the events.
    OffsetDateTime date = new OffsetDateTime(); // OffsetDateTime | The date to filter the events. Today will be used if this parameter is omitted.
    String type = "type_example"; // String | Type of event to list.
    try {
      apiInstance.eventgetsessionsbydate(token, location, date, type);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#eventgetsessionsbydate");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **location** | [**UUID**](.md)| The location to filter the events. | [optional]
 **date** | **OffsetDateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional]
 **type** | **String**| Type of event to list. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="eventlist"></a>
# **eventlist**
> eventlist(token, from, count, summaryonly, termid)

View a list of courses

Allows the user to view the full list of courses.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String from = "from_example"; // String | The first record to return.
    String count = "count_example"; // String | The max number of records to return.
    Boolean summaryonly = true; // Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
    UUID termid = new UUID(); // UUID | Id of the term to list the events. Null to list all events.
    try {
      apiInstance.eventlist(token, from, count, summaryonly, termid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#eventlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **String**| The first record to return. |
 **count** | **String**| The max number of records to return. |
 **summaryonly** | **Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**UUID**](.md)| Id of the term to list the events. Null to list all events. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="eventsave"></a>
# **eventsave**
> eventsave(UNKNOWN_BASE_TYPE)

Create or edit a course

Allows the user to create or edit a course.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.eventsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#eventsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="eventsearchgroup"></a>
# **eventsearchgroup**
> eventsearchgroup(token, query)

Searches for the available event groups

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID query = new UUID(); // UUID | Query to search event groups.
    try {
      apiInstance.eventsearchgroup(token, query);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#eventsearchgroup");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **query** | [**UUID**](.md)| Query to search event groups. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="export"></a>
# **export**
> export(token, exporttype, exportformat, filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String exporttype = "exporttype_example"; // String | What to export.
    String exportformat = "exportformat_example"; // String | The format of the resulting file. Valid types are CSV, HTML, XLS.
    String filters = "filters_example"; // String | Pipe separated filters for the export, eg: aaa=val|bbb=val|...
    try {
      apiInstance.export(token, exporttype, exportformat, filters);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#export");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="exportlisttypes"></a>
# **exportlisttypes**
> exportlisttypes(token)

Lists available export types

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.exportlisttypes(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#exportlisttypes");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="featurelist"></a>
# **featurelist**
> featurelist(token)

Lists the available features.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.featurelist(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#featurelist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="holidaylist"></a>
# **holidaylist**
> holidaylist(token, term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID term = new UUID(); // UUID | The term to get holidays from.
    try {
      apiInstance.holidaylist(token, term);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#holidaylist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **term** | [**UUID**](.md)| The term to get holidays from. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="holidaysave"></a>
# **holidaysave**
> holidaysave(UNKNOWN_BASE_TYPE)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.holidaysave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#holidaysave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="holidaysuggest"></a>
# **holidaysuggest**
> holidaysuggest(token, term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID term = new UUID(); // UUID | The term to get holidays from.
    try {
      apiInstance.holidaysuggest(token, term);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#holidaysuggest");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **term** | [**UUID**](.md)| The term to get holidays from. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="importlisttypes"></a>
# **importlisttypes**
> importlisttypes(token)

Lists available import types

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.importlisttypes(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#importlisttypes");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="licenseacceptagreement"></a>
# **licenseacceptagreement**
> licenseacceptagreement(token)

Accept the license agreement

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.licenseacceptagreement(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#licenseacceptagreement");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="licensegetagreementstatus"></a>
# **licensegetagreementstatus**
> licensegetagreementstatus(token)

Check if license agreement has been accepted

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.licensegetagreementstatus(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#licensegetagreementstatus");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="licensegetcurrent"></a>
# **licensegetcurrent**
> licensegetcurrent(token)

Gets the current license information

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.licensegetcurrent(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#licensegetcurrent");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="licenserenew"></a>
# **licenserenew**
> licenserenew(token, email, phonenumber, jobtitle, institution, comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String email = "email_example"; // String | The e-mail of the user sending the request.
    String phonenumber = "phonenumber_example"; // String | The phone number of the user sending the request.
    String jobtitle = "jobtitle_example"; // String | The job title of the user sending the request.
    String institution = "institution_example"; // String | The institution of the user sending the request.
    String comments = "comments_example"; // String | Comments entered by the user sending the request.
    try {
      apiInstance.licenserenew(token, email, phonenumber, jobtitle, institution, comments);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#licenserenew");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="listtimezones"></a>
# **listtimezones**
> listtimezones()

Lists the available timezones

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    try {
      apiInstance.listtimezones();
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#listtimezones");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="locationdelete"></a>
# **locationdelete**
> locationdelete(token, id)

Delete a location

Allows the user to delete an existing location.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the location to delete.
    try {
      apiInstance.locationdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#locationdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the location to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="locationget"></a>
# **locationget**
> locationget(token, id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the location to get.
    try {
      apiInstance.locationget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#locationget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the location to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="locationlist"></a>
# **locationlist**
> locationlist(token, from, count, locations, sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String locations = "locations_example"; // String | The comma-separated list containing the ids of the locations to list.
    Boolean sortbygroup = true; // Boolean | True to list locations sorted by the 'Located In' property. Defaults to false.
    try {
      apiInstance.locationlist(token, from, count, locations, sortbygroup);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#locationlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="locationsave"></a>
# **locationsave**
> locationsave(UNKNOWN_BASE_TYPE)

Create or edit a location

Allows the user to create or edit a location.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.locationsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#locationsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="login"></a>
# **login**
> login(domain, username, password, method, rememberme)

Login

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String domain = "domain_example"; // String | The account domain to login.
    String username = "username_example"; // String | The username (email) of the user to login as.
    String password = "password_example"; // String | The password of the user to login as.
    String method = "method_example"; // String | The authentication method. Valid values are 'token' and 'cookie'.
    Boolean rememberme = true; // Boolean | If true then the session will not expire.
    try {
      apiInstance.login(domain, username, password, method, rememberme);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#login");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="logout"></a>
# **logout**
> logout(token)

Logout

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token used to login.
    try {
      apiInstance.logout(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#logout");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="memorizedreportdelete"></a>
# **memorizedreportdelete**
> memorizedreportdelete(token, id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the report settings to delete.
    try {
      apiInstance.memorizedreportdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#memorizedreportdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the report settings to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="memorizedreportget"></a>
# **memorizedreportget**
> memorizedreportget(token, id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the report configuration to get.
    try {
      apiInstance.memorizedreportget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#memorizedreportget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the report configuration to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="memorizedreportlist"></a>
# **memorizedreportlist**
> memorizedreportlist(token, from, count, customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String customname = "customname_example"; // String | If specified filters the memorized reports by custom name.
    try {
      apiInstance.memorizedreportlist(token, from, count, customname);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#memorizedreportlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **customname** | **String**| If specified filters the memorized reports by custom name. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="memorizedreportsave"></a>
# **memorizedreportsave**
> memorizedreportsave(UNKNOWN_BASE_TYPE)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.memorizedreportsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#memorizedreportsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="menugetitems"></a>
# **menugetitems**
> menugetitems(menuid)

Gets the items on the menu

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String menuid = "menuid_example"; // String | The Id of the menu to get.
    try {
      apiInstance.menugetitems(menuid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#menugetitems");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="myaccount"></a>
# **myaccount**
> myaccount(token)

Gets the logged in user account.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.myaccount(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#myaccount");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="myianatimezone"></a>
# **myianatimezone**
> myianatimezone(token)

Gets the current time zone&#39;s iana name

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.myianatimezone(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#myianatimezone");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="myprofile"></a>
# **myprofile**
> myprofile(token, photosize)

Gets the logged in user information.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.myprofile(token, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#myprofile");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="myrights"></a>
# **myrights**
> myrights(token)

Gets the list of actions the user can execute.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.myrights(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#myrights");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="mysaveprofile"></a>
# **mysaveprofile**
> mysaveprofile(UNKNOWN_BASE_TYPE)

Updates logged user&#39;s profile information

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.mysaveprofile(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#mysaveprofile");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationdelete"></a>
# **notificationdelete**
> notificationdelete(token, id)

Delete a notification

Allows the user to delete an existing notification.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the notification to delete.
    try {
      apiInstance.notificationdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the notification to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationget"></a>
# **notificationget**
> notificationget(token, id)

View a notification

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the notification to get.
    try {
      apiInstance.notificationget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the notification to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationgetforstation"></a>
# **notificationgetforstation**
> notificationgetforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station to get.
    String user = "user_example"; // String | The card of the user.
    try {
      apiInstance.notificationgetforstation(station, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationgetforstation");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**UUID**](.md)| The id of the sign-in station to get. |
 **user** | **String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationgetunreadcount"></a>
# **notificationgetunreadcount**
> notificationgetunreadcount(token)

Get the number of unread notifications

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.notificationgetunreadcount(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationgetunreadcount");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationlist"></a>
# **notificationlist**
> notificationlist(token, from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID recipient = new UUID(); // UUID | The recipient whose notifications have to be listed.
    Integer status = 56; // Integer | The status of the notifications to list. Read, Unread or All.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the notifications.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the notifications.
    Boolean sentonscreen = true; // Boolean | Specifies whether to list the notifications that were sent on-screen or not.
    Boolean sentemail = true; // Boolean | Specifies whether to list the notifications that were sent via e-mail or not.
    Boolean sentsms = true; // Boolean | Specifies whether to list the notifications that were sent via sms or not.
    try {
      apiInstance.notificationlist(token, from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **recipient** | [**UUID**](.md)| The recipient whose notifications have to be listed. | [optional]
 **status** | **Integer**| The status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the notifications. | [optional]
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationlistmine"></a>
# **notificationlistmine**
> notificationlistmine(token, from, count, status, startdate, enddate)

View all the notifications sent to the current user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    Integer status = 56; // Integer | Specifies the status of the notifications to list. Read, Unread or All.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the notifications.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the notifications.
    try {
      apiInstance.notificationlistmine(token, from, count, status, startdate, enddate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationlistmine");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **status** | **Integer**| Specifies the status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationmarkasread"></a>
# **notificationmarkasread**
> notificationmarkasread(token, id, status, startdate, enddate)

Mark a notification as read

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
    Integer status = 56; // Integer | Specifies the status to filter the notifications. Read, Unread or All.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the notifications.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the notifications.
    try {
      apiInstance.notificationmarkasread(token, id, status, startdate, enddate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationmarkasread");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional]
 **status** | **Integer**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationmarkasunread"></a>
# **notificationmarkasunread**
> notificationmarkasunread(token, id, status, startdate, enddate)

Mark a notification as unread

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
    Integer status = 56; // Integer | Specifies the status to filter the notifications. Read, Unread or All.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date of the period to filter the notifications.
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date of the period to filter the notifications.
    try {
      apiInstance.notificationmarkasunread(token, id, status, startdate, enddate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationmarkasunread");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional]
 **status** | **Integer**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationsend"></a>
# **notificationsend**
> notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Boolean emailenabled = true; // Boolean | Whether send the notification via email.
    Boolean onscreenenabled = true; // Boolean | Whether to display the notification on screen.
    Boolean smsenabled = true; // Boolean | Whether to send the notification via text message.
    String title = "title_example"; // String | Notification title.
    String tousers = "tousers_example"; // String | Comma-separated Ids of users to send the notification.
    String togroups = "togroups_example"; // String | Comma-separated Ids of user groups to send the notification.
    String onscreenbody = "onscreenbody_example"; // String | Body of the message for on-screen display.
    String onscreenclick = "onscreenclick_example"; // String | What to do when the notification is clicked. Valid values: hide, view, url.
    String onscreenurl = "onscreenurl_example"; // String | Url to redirect the user, if onscreenclick=url.
    String onscreenclass = "onscreenclass_example"; // String | How to display the notification. Valid values: info, success, warning, error
    Integer onscreenduration = 56; // Integer | Time in seconds to display the notification.
    Integer showonstation = 56; // Integer | Whether to show the notification in the sign-in station.
    String emailfromname = "emailfromname_example"; // String | Name of the email sender.
    String emailfrom = "emailfrom_example"; // String | Reply-to email.
    String emailsubject = "emailsubject_example"; // String | Subject of the email.
    String emailbody = "emailbody_example"; // String | Body of the email.
    String textmessagebody = "textmessagebody_example"; // String | Message for SMS. Max 160 characters.
    try {
      apiInstance.notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationsend");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationsendonscreen"></a>
# **notificationsendonscreen**
> notificationsendonscreen(token, notification)

Send on-screen notifications

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID notification = new UUID(); // UUID | The ID of the notification to send.
    try {
      apiInstance.notificationsendonscreen(token, notification);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationsendonscreen");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **notification** | [**UUID**](.md)| The ID of the notification to send. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationtopicdelete"></a>
# **notificationtopicdelete**
> notificationtopicdelete(token, id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the notification topic to delete.
    try {
      apiInstance.notificationtopicdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationtopicdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the notification topic to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationtopicget"></a>
# **notificationtopicget**
> notificationtopicget(token, id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the notification topic to get.
    try {
      apiInstance.notificationtopicget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationtopicget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the notification topic to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationtopiclist"></a>
# **notificationtopiclist**
> notificationtopiclist(token, from, count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.notificationtopiclist(token, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationtopiclist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationtopiclistsubscribe"></a>
# **notificationtopiclistsubscribe**
> notificationtopiclistsubscribe(token)

List all the notification topics available to subscribe

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.notificationtopiclistsubscribe(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationtopiclistsubscribe");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="notificationtopicsave"></a>
# **notificationtopicsave**
> notificationtopicsave(UNKNOWN_BASE_TYPE)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.notificationtopicsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#notificationtopicsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="pushderegister"></a>
# **pushderegister**
> pushderegister(devicetoken, platform)

Deregisters the current device to receive push notifications

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String devicetoken = "devicetoken_example"; // String | The device token where to send the notification.
    String platform = "platform_example"; // String | Either ios or android
    try {
      apiInstance.pushderegister(devicetoken, platform);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#pushderegister");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="pushregister"></a>
# **pushregister**
> pushregister(devicetoken, platform)

Registers the current device to receive push notifications

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String devicetoken = "devicetoken_example"; // String | The device token where to send the notification.
    String platform = "platform_example"; // String | Either ios or android
    try {
      apiInstance.pushregister(devicetoken, platform);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#pushregister");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="qrlabelsprint"></a>
# **qrlabelsprint**
> qrlabelsprint(token, user, group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID user = new UUID(); // UUID | The id of the user whose label needs to be printed.
    UUID group = new UUID(); // UUID | The id of the group whose members' labels need to be printed.
    try {
      apiInstance.qrlabelsprint(token, user, group);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#qrlabelsprint");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **user** | [**UUID**](.md)| The id of the user whose label needs to be printed. | [optional]
 **group** | [**UUID**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="qrloginget"></a>
# **qrloginget**
> qrloginget(token)

Gets an image of a QR token

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.qrloginget(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#qrloginget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="qrloginlogin"></a>
# **qrloginlogin**
> qrloginlogin(onetimetoken)

Login

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String onetimetoken = "onetimetoken_example"; // String | The token read from the QR code.
    try {
      apiInstance.qrloginlogin(onetimetoken);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#qrloginlogin");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="quickpaneldeletewidget"></a>
# **quickpaneldeletewidget**
> quickpaneldeletewidget(token, id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the widget.
    try {
      apiInstance.quickpaneldeletewidget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#quickpaneldeletewidget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the widget. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="quickpanelfetchwidget"></a>
# **quickpanelfetchwidget**
> quickpanelfetchwidget(token, widgetid)

Fetches the information for a specific widget.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID widgetid = new UUID(); // UUID | The ID of the data to fetch it's data.
    try {
      apiInstance.quickpanelfetchwidget(token, widgetid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#quickpanelfetchwidget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **widgetid** | [**UUID**](.md)| The ID of the data to fetch it&#39;s data. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="quickpanelgetwidget"></a>
# **quickpanelgetwidget**
> quickpanelgetwidget(token, id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the widget to get.
    try {
      apiInstance.quickpanelgetwidget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#quickpanelgetwidget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the widget to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="quickpanelinit"></a>
# **quickpanelinit**
> quickpanelinit(token)

Returns the initial information required to show the quick panels

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.quickpanelinit(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#quickpanelinit");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="quickpanellistwidgets"></a>
# **quickpanellistwidgets**
> quickpanellistwidgets(token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.quickpanellistwidgets(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#quickpanellistwidgets");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="quickpanellistwidgettypes"></a>
# **quickpanellistwidgettypes**
> quickpanellistwidgettypes(token)

Lists all the widget types available in the system

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.quickpanellistwidgettypes(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#quickpanellistwidgettypes");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="quickpanelreorderwidgets"></a>
# **quickpanelreorderwidgets**
> quickpanelreorderwidgets(token, sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String sectionname = "sectionname_example"; // String | The section name where to sort the widgets.
    String orderids = "orderids_example"; // String | CSV list of the widgets to reorder.
    try {
      apiInstance.quickpanelreorderwidgets(token, sectionname, orderids);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#quickpanelreorderwidgets");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="quickpanelsavewidget"></a>
# **quickpanelsavewidget**
> quickpanelsavewidget(UNKNOWN_BASE_TYPE)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.quickpanelsavewidget(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#quickpanelsavewidget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="reportlist"></a>
# **reportlist**
> reportlist(token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.reportlist(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#reportlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="reportpermissionsbyuser"></a>
# **reportpermissionsbyuser**
> reportpermissionsbyuser(token, params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String params = "params_example"; // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
    try {
      apiInstance.reportpermissionsbyuser(token, params);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#reportpermissionsbyuser");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="reportprepare"></a>
# **reportprepare**
> reportprepare(token, reportname, params, repformat, fillgroupid, groupby, refreshgroup, filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String reportname = "reportname_example"; // String | The name of the report to execute
    String params = "params_example"; // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
    String repformat = "repformat_example"; // String | The format of the resulting report. Json, pdf, csv, ...
    UUID fillgroupid = new UUID(); // UUID | If specified, the result is used to fill the group with the given ID
    String groupby = "groupby_example"; // String | How to group the records. In the format 'col1+col2|col3+col4
    UUID refreshgroup = new UUID(); // UUID | The ID of the group to check (and refresh) before processing the report.
    String filtertext = "filtertext_example"; // String | The user friendly text of the applied filters.
    try {
      apiInstance.reportprepare(token, reportname, params, repformat, fillgroupid, groupby, refreshgroup, filtertext);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#reportprepare");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **reportname** | **String**| The name of the report to execute |
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **repformat** | **String**| The format of the resulting report. Json, pdf, csv, ... | [optional]
 **fillgroupid** | [**UUID**](.md)| If specified, the result is used to fill the group with the given ID | [optional]
 **groupby** | **String**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional]
 **refreshgroup** | [**UUID**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional]
 **filtertext** | **String**| The user friendly text of the applied filters. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="reportquery"></a>
# **reportquery**
> reportquery(token, reportname, params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String reportname = "reportname_example"; // String | The name of the report to execute
    String params = "params_example"; // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
    try {
      apiInstance.reportquery(token, reportname, params);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#reportquery");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="rolelist"></a>
# **rolelist**
> rolelist(token, name)

Show a list of roles

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String name = "name_example"; // String | Filter by name of the role.
    try {
      apiInstance.rolelist(token, name);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#rolelist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ruledelete"></a>
# **ruledelete**
> ruledelete(token, id)

Delete a rule

Allows the user to delete an existing rule.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the rule to delete.
    try {
      apiInstance.ruledelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#ruledelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the rule to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ruleget"></a>
# **ruleget**
> ruleget(token, id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the rule to get.
    try {
      apiInstance.ruleget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#ruleget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the rule to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="rulegeteventtype"></a>
# **rulegeteventtype**
> rulegeteventtype(token, event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String event = "event_example"; // String | The name of the event to refresh.
    try {
      apiInstance.rulegeteventtype(token, event);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#rulegeteventtype");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="rulelist"></a>
# **rulelist**
> rulelist(token, from, count)

View a list of user rules

Allows the user to view the list of all rules.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.rulelist(token, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#rulelist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="rulelistactions"></a>
# **rulelistactions**
> rulelistactions(token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.rulelistactions(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#rulelistactions");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="rulelisteventtypes"></a>
# **rulelisteventtypes**
> rulelisteventtypes(token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.rulelisteventtypes(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#rulelisteventtypes");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="rulelisthttprequests"></a>
# **rulelisthttprequests**
> rulelisthttprequests(token, from, count, failed, status)

View all the http requests sent as a result of a rule

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    Boolean failed = true; // Boolean | If true only failed requests will be returned
    Integer status = 56; // Integer | The http status to filter the requests
    try {
      apiInstance.rulelisthttprequests(token, from, count, failed, status);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#rulelisthttprequests");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="rulesave"></a>
# **rulesave**
> rulesave(UNKNOWN_BASE_TYPE)

Create or edit a rule

Allows the user to create or edit a rule.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.rulesave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#rulesave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="search"></a>
# **search**
> search(token, query, page)

Search

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String query = "query_example"; // String | The query to search for.
    Integer page = 56; // Integer | Current page to show, zero-based.
    try {
      apiInstance.search(token, query, page);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#search");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **query** | **String**| The query to search for. |
 **page** | **Integer**| Current page to show, zero-based. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="searchgetentities"></a>
# **searchgetentities**
> searchgetentities(token)

Get the information of the entities that can be searched

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.searchgetentities(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#searchgetentities");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="securityassesspermission"></a>
# **securityassesspermission**
> securityassesspermission(token, commandname)

Returns the list of users for a specific permission

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String commandname = "commandname_example"; // String | Name of the action or command to get the roles.
    try {
      apiInstance.securityassesspermission(token, commandname);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#securityassesspermission");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="securityassessrole"></a>
# **securityassessrole**
> securityassessrole(token, roleid)

Returns the list of permissions for a specific role

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID roleid = new UUID(); // UUID | Role ID to list the effective permissions.
    try {
      apiInstance.securityassessrole(token, roleid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#securityassessrole");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **roleid** | [**UUID**](.md)| Role ID to list the effective permissions. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="securityassessscope"></a>
# **securityassessscope**
> securityassessscope(token, locationid)

Returns the list of users for a specific user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID locationid = new UUID(); // UUID | Location ID to list the users with that scope.
    try {
      apiInstance.securityassessscope(token, locationid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#securityassessscope");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **locationid** | [**UUID**](.md)| Location ID to list the users with that scope. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="securityassessuser"></a>
# **securityassessuser**
> securityassessuser(token, userid)

Returns the list of permissions for a specific user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID userid = new UUID(); // UUID | User ID to list the effective permissions.
    try {
      apiInstance.securityassessuser(token, userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#securityassessuser");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **userid** | [**UUID**](.md)| User ID to list the effective permissions. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionregaddcurrentuser"></a>
# **sessionregaddcurrentuser**
> sessionregaddcurrentuser(token, eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID eventid = new UUID(); // UUID | The id of the event.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    try {
      apiInstance.sessionregaddcurrentuser(token, eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionregaddcurrentuser");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **eventid** | [**UUID**](.md)| The id of the event. |
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionregadduser"></a>
# **sessionregadduser**
> sessionregadduser(token, userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID userid = new UUID(); // UUID | The id of the user to add.
    UUID eventid = new UUID(); // UUID | The id of the event.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    try {
      apiInstance.sessionregadduser(token, userid, eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionregadduser");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **userid** | [**UUID**](.md)| The id of the user to add. |
 **eventid** | [**UUID**](.md)| The id of the event. |
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionreggetmysessions"></a>
# **sessionreggetmysessions**
> sessionreggetmysessions(token, date)

View all the sessions the logged user is registered to

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    OffsetDateTime date = new OffsetDateTime(); // OffsetDateTime | Start date to filter the sessions.
    try {
      apiInstance.sessionreggetmysessions(token, date);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionreggetmysessions");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **date** | **OffsetDateTime**| Start date to filter the sessions. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionreggetsessions"></a>
# **sessionreggetsessions**
> sessionreggetsessions(token, userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID userid = new UUID(); // UUID | The user id to list sessions.
    try {
      apiInstance.sessionreggetsessions(token, userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionreggetsessions");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **userid** | [**UUID**](.md)| The user id to list sessions. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionreggetsettings"></a>
# **sessionreggetsettings**
> sessionreggetsettings(token, locationid, eventid, sessiondate, noinherit)

Get the settings for session registration

Allows the user to view a event&#39;s session registration settings.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID locationid = new UUID(); // UUID | The id of the location to save settings.
    UUID eventid = new UUID(); // UUID | The id of the event to save settings.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    Boolean noinherit = true; // Boolean | True to get the location/event/session specific settings without looking for the more global settings.
    try {
      apiInstance.sessionreggetsettings(token, locationid, eventid, sessiondate, noinherit);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionreggetsettings");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **locationid** | [**UUID**](.md)| The id of the location to save settings. | [optional]
 **eventid** | [**UUID**](.md)| The id of the event to save settings. | [optional]
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. | [optional]
 **noinherit** | **Boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionreggetusers"></a>
# **sessionreggetusers**
> sessionreggetusers(token, eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID eventid = new UUID(); // UUID | The event id to list sessions.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date of the session to find.
    try {
      apiInstance.sessionreggetusers(token, eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionreggetusers");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **eventid** | [**UUID**](.md)| The event id to list sessions. |
 **sessiondate** | **OffsetDateTime**| The date of the session to find. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionreglistsessions"></a>
# **sessionreglistsessions**
> sessionreglistsessions(token, eventid, sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID eventid = new UUID(); // UUID | The event id to list sessions.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date of the session to find.
    try {
      apiInstance.sessionreglistsessions(token, eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionreglistsessions");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **eventid** | [**UUID**](.md)| The event id to list sessions. |
 **sessiondate** | **OffsetDateTime**| The date of the session to find. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionreglistupcoming"></a>
# **sessionreglistupcoming**
> sessionreglistupcoming(token, date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    OffsetDateTime date = new OffsetDateTime(); // OffsetDateTime | Only sessions in the week of the specified date will be returned.
    try {
      apiInstance.sessionreglistupcoming(token, date);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionreglistupcoming");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **date** | **OffsetDateTime**| Only sessions in the week of the specified date will be returned. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionreglistupcomingevent"></a>
# **sessionreglistupcomingevent**
> sessionreglistupcomingevent(token, date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    OffsetDateTime date = new OffsetDateTime(); // OffsetDateTime | Start date to filter the returned sessions.
    UUID event = new UUID(); // UUID | The id of the event whose sessions will be returned
    try {
      apiInstance.sessionreglistupcomingevent(token, date, event);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionreglistupcomingevent");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **date** | **OffsetDateTime**| Start date to filter the returned sessions. |
 **event** | [**UUID**](.md)| The id of the event whose sessions will be returned |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionregremovecurrentuser"></a>
# **sessionregremovecurrentuser**
> sessionregremovecurrentuser(token, eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID eventid = new UUID(); // UUID | The id of the event.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    try {
      apiInstance.sessionregremovecurrentuser(token, eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionregremovecurrentuser");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **eventid** | [**UUID**](.md)| The id of the event. |
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionregremoveuser"></a>
# **sessionregremoveuser**
> sessionregremoveuser(token, userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    UUID eventid = new UUID(); // UUID | The id of the event.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    try {
      apiInstance.sessionregremoveuser(token, userid, eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionregremoveuser");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **userid** | [**UUID**](.md)| The id of the user to remove. |
 **eventid** | [**UUID**](.md)| The id of the event. |
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="sessionregsavesettings"></a>
# **sessionregsavesettings**
> sessionregsavesettings(UNKNOWN_BASE_TYPE)

Save the settings for an event&#39;s session registration

Allows the user to save the settings for an event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.sessionregsavesettings(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#sessionregsavesettings");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="settingaddlogo"></a>
# **settingaddlogo**
> settingaddlogo(token, upload, filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
    String filename = "filename_example"; // String | The original filename, needed to process the file.
    try {
      apiInstance.settingaddlogo(token, upload, filename);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#settingaddlogo");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="settingget"></a>
# **settingget**
> settingget(keys, token, domain, scope)

Get settings for the account or the specified scope

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String keys = "keys_example"; // String | The option keys to get values for. Enter multiple separated by comma.
    String token = "token_example"; // String | The authentication token.
    String domain = "domain_example"; // String | The account domain, in case of reading settings annonymously.
    String scope = "scope_example"; // String | The scope of the settings to get.
    try {
      apiInstance.settingget(keys, token, domain, scope);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#settingget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="settingsave"></a>
# **settingsave**
> settingsave(UNKNOWN_BASE_TYPE)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.settingsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#settingsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="settingviewgeneral"></a>
# **settingviewgeneral**
> settingviewgeneral(token)

View general settings for the account

Allows the user to view the settings&#39; general section.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.settingviewgeneral(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#settingviewgeneral");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ssogeneratekey"></a>
# **ssogeneratekey**
> ssogeneratekey(token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.ssogeneratekey(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#ssogeneratekey");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ssogetsettings"></a>
# **ssogetsettings**
> ssogetsettings(token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.ssogetsettings(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#ssogetsettings");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ssoissuetoken"></a>
# **ssoissuetoken**
> ssoissuetoken(key, username, expires)

Issue single sign-on token

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String key = "key_example"; // String | The single sign-on key of the account.
    String username = "username_example"; // String | The email of the user to sign-on.
    Boolean expires = true; // Boolean | Specifies whether the session should expire when inactive.
    try {
      apiInstance.ssoissuetoken(key, username, expires);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#ssoissuetoken");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ssosavesettings"></a>
# **ssosavesettings**
> ssosavesettings(UNKNOWN_BASE_TYPE)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.ssosavesettings(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#ssosavesettings");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="stationdelete"></a>
# **stationdelete**
> stationdelete(token, id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the sign-in station to delete.
    try {
      apiInstance.stationdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#stationdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the sign-in station to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="stationget"></a>
# **stationget**
> stationget(token, id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the sign-in station to get.
    try {
      apiInstance.stationget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#stationget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the sign-in station to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="stationgetcurrentterms"></a>
# **stationgetcurrentterms**
> stationgetcurrentterms(station)

Get all the current terms

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station whose account's current terms have to be retrieved.
    try {
      apiInstance.stationgetcurrentterms(station);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#stationgetcurrentterms");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**UUID**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="stationgetinfo"></a>
# **stationgetinfo**
> stationgetinfo(id, event)

Gets a the info to display in the sign-in station by it&#39;s ID.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the sign-in station to get.
    UUID event = new UUID(); // UUID | The id of the event, to override the one by schedule.
    try {
      apiInstance.stationgetinfo(id, event);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#stationgetinfo");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The id of the sign-in station to get. |
 **event** | [**UUID**](.md)| The id of the event, to override the one by schedule. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="stationgetlicense"></a>
# **stationgetlicense**
> stationgetlicense(station)

Gets the current license information

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String station = "station_example"; // String | The id of the sign-in station whose account's license has to be retrieved.
    try {
      apiInstance.stationgetlicense(station);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#stationgetlicense");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="stationlist"></a>
# **stationlist**
> stationlist(token, from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.stationlist(token, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#stationlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="stationsave"></a>
# **stationsave**
> stationsave(UNKNOWN_BASE_TYPE)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.stationsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#stationsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="stationunlock"></a>
# **stationunlock**
> stationunlock(id, passcode, method)

Unlocks the sign-in station.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the sign-in station to unlock.
    String passcode = "passcode_example"; // String | The passcode to unlock the station.
    String method = "method_example"; // String | The authentication method. Valid values are 'token' and 'cookie'.
    try {
      apiInstance.stationunlock(id, passcode, method);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#stationunlock");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The id of the sign-in station to unlock. |
 **passcode** | **String**| The passcode to unlock the station. |
 **method** | **String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipedelete"></a>
# **swipedelete**
> swipedelete(token, id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the swipe to delete.
    try {
      apiInstance.swipedelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#swipedelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the swipe to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipeget"></a>
# **swipeget**
> swipeget(token, id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the swipe to get.
    try {
      apiInstance.swipeget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#swipeget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the swipe to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipelist"></a>
# **swipelist**
> swipelist(from, count, token)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.swipelist(from, count, token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#swipelist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **token** | **String**| The authentication token. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipesave"></a>
# **swipesave**
> swipesave(UNKNOWN_BASE_TYPE)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.swipesave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#swipesave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="swipesaveanonym"></a>
# **swipesaveanonym**
> swipesaveanonym(UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.swipesaveanonym(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#swipesaveanonym");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="tagdelete"></a>
# **tagdelete**
> tagdelete(token, id)

Delete a tag

Allows the user to delete an existing tag.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the tag to delete.
    try {
      apiInstance.tagdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#tagdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the tag to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="tagget"></a>
# **tagget**
> tagget(token, id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the tag to get.
    try {
      apiInstance.tagget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#tagget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the tag to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="taglist"></a>
# **taglist**
> taglist(token, group, from, count)

View a list of tags

Allows the user to view the list of tags.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String group = "group_example"; // String | The group of the tags to return.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.taglist(token, group, from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#taglist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **group** | **String**| The group of the tags to return. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="taglistgroups"></a>
# **taglistgroups**
> taglistgroups(token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag&#39;s settings.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.taglistgroups(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#taglistgroups");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="tagsave"></a>
# **tagsave**
> tagsave(UNKNOWN_BASE_TYPE)

Create or edit a tag

Allows the user to create or edit a tag.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.tagsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#tagsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="tagsearch"></a>
# **tagsearch**
> tagsearch(token, query, allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String query = "query_example"; // String | The query to search tags. Use group:<group> to search in a specific group (mandatory).
    Boolean allowcreatingnew = true; // Boolean | Specifies whether an option to create a new tag should be retrieved.
    try {
      apiInstance.tagsearch(token, query, allowcreatingnew);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#tagsearch");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateaddimage"></a>
# **templateaddimage**
> templateaddimage(token, template, upload, filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID template = new UUID(); // UUID | The id of the template where the image has to be added
    String upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
    String filename = "filename_example"; // String | The local name of the uploaded file. For later reference.
    try {
      apiInstance.templateaddimage(token, template, upload, filename);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templateaddimage");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **template** | [**UUID**](.md)| The id of the template where the image has to be added |
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templatedelete"></a>
# **templatedelete**
> templatedelete(token, id)

Delete a template

Allows the user to delete an existing template.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the template to delete.
    try {
      apiInstance.templatedelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templatedelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the template to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateemail"></a>
# **templateemail**
> templateemail(token, jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String jobid = "jobid_example"; // String | The id of the job that is creating the templates.
    String emailsubject = "emailsubject_example"; // String | Args depending on the send-to flag.
    String emailbody = "emailbody_example"; // String | Args depending on the send-to flag.
    String templatekind = "templatekind_example"; // String | The kind of the template you're sending. It must be included in (badge, certificate).
    String emailfrom = "emailfrom_example"; // String | The name of the sender to be displayed in the receipients inbox
    String emailreplyto = "emailreplyto_example"; // String | The reply-to field for the emails.
    try {
      apiInstance.templateemail(token, jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templateemail");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templategenerate"></a>
# **templategenerate**
> templategenerate(token, template, source, singlefile, userid, forsending, role, filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID template = new UUID(); // UUID | The id of the template to generate.
    UUID source = new UUID(); // UUID | The source key of the selected template data source.
    Boolean singlefile = true; // Boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
    String userid = "userid_example"; // String | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
    Boolean forsending = true; // Boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
    UUID role = new UUID(); // UUID | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
    String filters = "filters_example"; // String | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...
    try {
      apiInstance.templategenerate(token, template, source, singlefile, userid, forsending, role, filters);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templategenerate");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **template** | [**UUID**](.md)| The id of the template to generate. |
 **source** | [**UUID**](.md)| The source key of the selected template data source. |
 **singlefile** | **Boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. |
 **userid** | **String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional]
 **forsending** | **Boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional]
 **role** | [**UUID**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional]
 **filters** | **String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templateget"></a>
# **templateget**
> templateget(token, id)

View details of a template

Allows the user to view a template and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the template to get.
    try {
      apiInstance.templateget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templateget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the template to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templategetgenerated"></a>
# **templategetgenerated**
> templategetgenerated(token, jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String jobid = "jobid_example"; // String | The id of the job that is creating the templates.
    try {
      apiInstance.templategetgenerated(token, jobid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templategetgenerated");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templatelist"></a>
# **templatelist**
> templatelist(token, from, count, kind, designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String kind = "kind_example"; // String | The kind of the templates to return. It must be included in (badge, certificate).
    Boolean designedonly = true; // Boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.
    try {
      apiInstance.templatelist(token, from, count, kind, designedonly);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templatelist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templatelistsources"></a>
# **templatelistsources**
> templatelistsources(token, kind)

View a list of templates&#39; data sources

Allows the user to see tokens to be used in the template

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String kind = "kind_example"; // String | The kind of the templates to return. It must be included in (badge, certificate).
    try {
      apiInstance.templatelistsources(token, kind);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templatelistsources");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templatesave"></a>
# **templatesave**
> templatesave(UNKNOWN_BASE_TYPE)

Create or edit a template

Allows the user to create or edit a template.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.templatesave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templatesave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="templatesavelayout"></a>
# **templatesavelayout**
> templatesavelayout(UNKNOWN_BASE_TYPE)

Save the layout of a template

Allows the user to edit a template&#39;s layout.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.templatesavelayout(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#templatesavelayout");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="termdelete"></a>
# **termdelete**
> termdelete(token, id)

Delete a term

Allows the user to delete a term from the existing list.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the term to delete.
    try {
      apiInstance.termdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#termdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the term to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="termget"></a>
# **termget**
> termget(token, id)

Search and view details of a term

Allows the user to view a term and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the term to get.
    try {
      apiInstance.termget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#termget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the term to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="termlist"></a>
# **termlist**
> termlist(token, from, count, notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    Boolean notpast = true; // Boolean | Specifies whether the terms in the past should be returned or not.
    try {
      apiInstance.termlist(token, from, count, notpast);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#termlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. | [optional]
 **count** | **Integer**| The max number of records to return. | [optional]
 **notpast** | **Boolean**| Specifies whether the terms in the past should be returned or not. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="termsave"></a>
# **termsave**
> termsave(UNKNOWN_BASE_TYPE)

Create and edit terms

Allows the user to create and edit terms.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.termsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#termsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="textcreditremaining"></a>
# **textcreditremaining**
> textcreditremaining(token)

Gets the remaining text credits for the account

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.textcreditremaining(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#textcreditremaining");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="texttoimage"></a>
# **texttoimage**
> texttoimage(token, text, fontcolor, fontsize, direction, width)

Generates a dynamic image from text

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String text = "text_example"; // String | The text to convert to an image, use double pipes (||) as a new line.
    String fontcolor = "fontcolor_example"; // String | The color of the text, in hex format, without the #.
    Integer fontsize = 56; // Integer | The size of the text, in points.
    String direction = "direction_example"; // String | Either vertical or horizontal, default horizontal.
    Integer width = 56; // Integer | The image width in pixels (or height if the direction is vertical).
    try {
      apiInstance.texttoimage(token, text, fontcolor, fontsize, direction, width);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#texttoimage");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="translationget"></a>
# **translationget**
> translationget(token, universal)

Gets the translations of the specified values

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String universal = "universal_example"; // String | Pipe separated list of universal text to be translated.
    try {
      apiInstance.translationget(token, universal);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#translationget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="translationgetcachefile"></a>
# **translationgetcachefile**
> translationgetcachefile(token, account)

Get the file containing the translations

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String account = "account_example"; // String | The id of the account whose translations file has to be retrieved.
    try {
      apiInstance.translationgetcachefile(token, account);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#translationgetcachefile");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="translationlist"></a>
# **translationlist**
> translationlist(token, filter, nondefaultonly, appdefaultasuniversal)

Lists all the available translations in the system

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String filter = "filter_example"; // String | Text to search/filter translations.
    Boolean nondefaultonly = true; // Boolean | If true then it returns only the terms translated. Otherwise, it returns all.
    Boolean appdefaultasuniversal = true; // Boolean | If true then it uses the app default translation as the universal term.
    try {
      apiInstance.translationlist(token, filter, nondefaultonly, appdefaultasuniversal);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#translationlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="translationsave"></a>
# **translationsave**
> translationsave(UNKNOWN_BASE_TYPE)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.translationsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#translationsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="userchangepwd"></a>
# **userchangepwd**
> userchangepwd(token, oldpass, newpass)

Change user&#39;s own password

Allows the user to change their own password.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID oldpass = new UUID(); // UUID | The old password of the authenticated user.
    UUID newpass = new UUID(); // UUID | The new password of the authenticated user.
    try {
      apiInstance.userchangepwd(token, oldpass, newpass);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#userchangepwd");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **oldpass** | [**UUID**](.md)| The old password of the authenticated user. |
 **newpass** | [**UUID**](.md)| The new password of the authenticated user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="userchangepwdbyreq"></a>
# **userchangepwdbyreq**
> userchangepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String changereq = "changereq_example"; // String | The change password request ID sent by email to the user.
    String newpass = "newpass_example"; // String | The new password of the user.
    try {
      apiInstance.userchangepwdbyreq(changereq, newpass);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#userchangepwdbyreq");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="userdelete"></a>
# **userdelete**
> userdelete(token, id)

Delete a user

Allows the user to delete a user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the user to delete.
    try {
      apiInstance.userdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#userdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the user to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="userfindsimilar"></a>
# **userfindsimilar**
> userfindsimilar(token, currentid, phonenumber, cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID currentid = new UUID(); // UUID | The id of the current user.
    String phonenumber = "phonenumber_example"; // String | A phone number to search for similar users.
    String cardnumber = "cardnumber_example"; // String | A card number to search for similar users.
    try {
      apiInstance.userfindsimilar(token, currentid, phonenumber, cardnumber);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#userfindsimilar");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **currentid** | [**UUID**](.md)| The id of the current user. | [optional]
 **phonenumber** | **String**| A phone number to search for similar users. | [optional]
 **cardnumber** | **String**| A card number to search for similar users. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="userget"></a>
# **userget**
> userget(token, id, photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the user to get.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.userget(token, id, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#userget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the user to get. |
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergetbycard"></a>
# **usergetbycard**
> usergetbycard(token, card, photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String card = "card_example"; // String | The card number of the user to get.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.usergetbycard(token, card, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergetbycard");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **card** | **String**| The card number of the user to get. |
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergroupaddmember"></a>
# **usergroupaddmember**
> usergroupaddmember(token, userid, groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID userid = new UUID(); // UUID | The id of the user to add.
    UUID groupid = new UUID(); // UUID | The id of the group.
    try {
      apiInstance.usergroupaddmember(token, userid, groupid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergroupaddmember");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **userid** | [**UUID**](.md)| The id of the user to add. |
 **groupid** | [**UUID**](.md)| The id of the group. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergroupdelete"></a>
# **usergroupdelete**
> usergroupdelete(token, id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the group to delete.
    try {
      apiInstance.usergroupdelete(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergroupdelete");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the group to delete. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergroupget"></a>
# **usergroupget**
> usergroupget(token, id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID id = new UUID(); // UUID | The id of the user group to get.
    try {
      apiInstance.usergroupget(token, id);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergroupget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **id** | [**UUID**](.md)| The id of the user group to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergroupgetmembers"></a>
# **usergroupgetmembers**
> usergroupgetmembers(token, groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID groupid = new UUID(); // UUID | The id of the user group to get.
    try {
      apiInstance.usergroupgetmembers(token, groupid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergroupgetmembers");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **groupid** | [**UUID**](.md)| The id of the user group to get. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergroupgetuser"></a>
# **usergroupgetuser**
> usergroupgetuser(token, userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID userid = new UUID(); // UUID | The id of the user to get his groups.
    try {
      apiInstance.usergroupgetuser(token, userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergroupgetuser");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **userid** | [**UUID**](.md)| The id of the user to get his groups. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergrouplist"></a>
# **usergrouplist**
> usergrouplist(token, from, count, type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String type = "type_example"; // String | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.
    try {
      apiInstance.usergrouplist(token, from, count, type);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergrouplist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. | [optional]
 **count** | **Integer**| The max number of records to return. | [optional]
 **type** | **String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergrouprefresh"></a>
# **usergrouprefresh**
> usergrouprefresh(token, group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID group = new UUID(); // UUID | The ID of the group to refresh.
    try {
      apiInstance.usergrouprefresh(token, group);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergrouprefresh");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **group** | [**UUID**](.md)| The ID of the group to refresh. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergroupremovemember"></a>
# **usergroupremovemember**
> usergroupremovemember(token, userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    UUID groupid = new UUID(); // UUID | The id of the group.
    try {
      apiInstance.usergroupremovemember(token, userid, groupid);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergroupremovemember");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **userid** | [**UUID**](.md)| The id of the user to remove. |
 **groupid** | [**UUID**](.md)| The id of the group. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usergroupsave"></a>
# **usergroupsave**
> usergroupsave(UNKNOWN_BASE_TYPE)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.usergroupsave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usergroupsave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="userlist"></a>
# **userlist**
> userlist(token, from, count, roleid, onlywithoutcard, photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID roleid = new UUID(); // UUID | The id of the role to filter users by, or empty to return all users.
    String onlywithoutcard = "onlywithoutcard_example"; // String | If is 1 then only the users without a card are returned, otherwise all users are returned.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.userlist(token, from, count, roleid, onlywithoutcard, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#userlist");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **roleid** | [**UUID**](.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="userloadphoto"></a>
# **userloadphoto**
> userloadphoto(token, upload, filename, userid, automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
    String filename = "filename_example"; // String | The local name of the uploaded file. For later reference.
    UUID userid = new UUID(); // UUID | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
    Boolean automatch = true; // Boolean | Set this to true to find the specific user based on the file name. 
    try {
      apiInstance.userloadphoto(token, upload, filename, userid, automatch);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#userloadphoto");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional]
 **userid** | [**UUID**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional]
 **automatch** | **Boolean**| Set this to true to find the specific user based on the file name.  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usermovedata"></a>
# **usermovedata**
> usermovedata(token, source, destination)

Move data between users

Allows administrators to move data between users.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    UUID source = new UUID(); // UUID | The id of the user that is the source of the data.
    UUID destination = new UUID(); // UUID | The id of the user that is the destination of the data.
    try {
      apiInstance.usermovedata(token, source, destination);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usermovedata");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **source** | [**UUID**](.md)| The id of the user that is the source of the data. |
 **destination** | [**UUID**](.md)| The id of the user that is the destination of the data. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="userrequestpwdchange"></a>
# **userrequestpwdchange**
> userrequestpwdchange(domain, email)

Requests a password change

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String domain = "domain_example"; // String | The domain of the account where the user exists.
    String email = "email_example"; // String | The email of the user.
    try {
      apiInstance.userrequestpwdchange(domain, email);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#userrequestpwdchange");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usersave"></a>
# **usersave**
> usersave(UNKNOWN_BASE_TYPE)

Create or edit a user

Allows the user to create or edit a user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.usersave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usersave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usersavepwdchange"></a>
# **usersavepwdchange**
> usersavepwdchange(UNKNOWN_BASE_TYPE)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.usersavepwdchange(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usersavepwdchange");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usersettingsget"></a>
# **usersettingsget**
> usersettingsget(token, keys, user)

Lists available user settings

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String keys = "keys_example"; // String | Setting key to get. Can be multiple separated by commas.
    UUID user = new UUID(); // UUID | The user id whose settings have to be returned.
    try {
      apiInstance.usersettingsget(token, keys, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usersettingsget");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **keys** | **String**| Setting key to get. Can be multiple separated by commas. |
 **user** | [**UUID**](.md)| The user id whose settings have to be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usersettingsgetmultiple"></a>
# **usersettingsgetmultiple**
> usersettingsgetmultiple(token, keys, user)

Get multiple user settings

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    String keys = "keys_example"; // String | Setting key to get. Can be multiple separated by commas.
    UUID user = new UUID(); // UUID | The user id whose settings have to be returned.
    try {
      apiInstance.usersettingsgetmultiple(token, keys, user);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usersettingsgetmultiple");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The authentication token. |
 **keys** | **String**| Setting key to get. Can be multiple separated by commas. |
 **user** | [**UUID**](.md)| The user id whose settings have to be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usersettingssave"></a>
# **usersettingssave**
> usersettingssave(UNKNOWN_BASE_TYPE)

Saves a user setting

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.usersettingssave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usersettingssave");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="usersettingssavemultiple"></a>
# **usersettingssavemultiple**
> usersettingssavemultiple(UNKNOWN_BASE_TYPE)

Save multiple user settings at once

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.usersettingssavemultiple(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#usersettingssavemultiple");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="version"></a>
# **version**
> version(token)

Get current version information

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.DefaultApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net/api/v1");

    DefaultApi apiInstance = new DefaultApi(defaultClient);
    String token = "token_example"; // String | The authentication token.
    try {
      apiInstance.version(token);
    } catch (ApiException e) {
      System.err.println("Exception when calling DefaultApi#version");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
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

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

