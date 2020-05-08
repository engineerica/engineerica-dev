# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *https://accucampus.net/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Actionloglist**](DefaultApi.md#actionloglist) | **GET** /actionloglist | View a list of users action logs
[**Advroleaddmissing**](DefaultApi.md#advroleaddmissing) | **GET** /advroleaddmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**Advrolecheckperm**](DefaultApi.md#advrolecheckperm) | **GET** /advrolecheckperm | Checks the permissions are assigned for the given roles
[**Advroledelete**](DefaultApi.md#advroledelete) | **GET** /advroledelete | Delete a role
[**Advroledeletemapping**](DefaultApi.md#advroledeletemapping) | **GET** /advroledeletemapping | Delete a role mapping
[**Advroleget**](DefaultApi.md#advroleget) | **GET** /advroleget | View details of a role
[**Advrolelist**](DefaultApi.md#advrolelist) | **GET** /advrolelist | Lists the roles for the current account
[**Advrolelistmaps**](DefaultApi.md#advrolelistmaps) | **GET** /advrolelistmaps | Lists the maps a roles is mapped to
[**Advrolelistrolesmapped**](DefaultApi.md#advrolelistrolesmapped) | **GET** /advrolelistrolesmapped | Lists the roles mappings
[**Advrolelisttemplates**](DefaultApi.md#advrolelisttemplates) | **GET** /advrolelisttemplates | View a list of role templates
[**Advrolesave**](DefaultApi.md#advrolesave) | **POST** /advrolesave | Create or edit a role
[**Advrolesavemapping**](DefaultApi.md#advrolesavemapping) | **POST** /advrolesavemapping | Saves a role mapping
[**Advrolesuserlist**](DefaultApi.md#advrolesuserlist) | **GET** /advrolesuserlist | List users. Alias to user.list, use that one instead.
[**Advroleuserupgrade**](DefaultApi.md#advroleuserupgrade) | **GET** /advroleuserupgrade | Upgrade a user to another role (requires permission to edit those roles)
[**Appsharegetphone**](DefaultApi.md#appsharegetphone) | **GET** /appsharegetphone | Gets the phone number of the current user
[**Appsharesendtext**](DefaultApi.md#appsharesendtext) | **GET** /appsharesendtext | Sends an SMS with the link to the app
[**Attendancelogcommentdelete**](DefaultApi.md#attendancelogcommentdelete) | **GET** /attendancelogcommentdelete | Delete a comment on an attendance log
[**Attendancelogcommentget**](DefaultApi.md#attendancelogcommentget) | **GET** /attendancelogcommentget | View a comment on an attendance log
[**Attendancelogcommentlist**](DefaultApi.md#attendancelogcommentlist) | **GET** /attendancelogcommentlist | View all the comments on a specific attendance log
[**Attendancelogcommentsave**](DefaultApi.md#attendancelogcommentsave) | **POST** /attendancelogcommentsave | Save a comment on an attendance log
[**Attendancelogdelete**](DefaultApi.md#attendancelogdelete) | **GET** /attendancelogdelete | Delete an attendance log
[**Attendancelogget**](DefaultApi.md#attendancelogget) | **GET** /attendancelogget | Search and view details of an attendance log
[**Attendanceloggetchangehistory**](DefaultApi.md#attendanceloggetchangehistory) | **GET** /attendanceloggetchangehistory | Search and view details of an attendance log&#39;s swipe history
[**Attendanceloglist**](DefaultApi.md#attendanceloglist) | **GET** /attendanceloglist | View a list of attendance logs
[**Attendanceloglistmine**](DefaultApi.md#attendanceloglistmine) | **GET** /attendanceloglistmine | Gets the attendance logs of the current user
[**Attendancelogsave**](DefaultApi.md#attendancelogsave) | **POST** /attendancelogsave | Create or edit an attendance log
[**Attendancelogsignout**](DefaultApi.md#attendancelogsignout) | **GET** /attendancelogsignout | Sign out an attendance log
[**Attendancelogwhosin**](DefaultApi.md#attendancelogwhosin) | **GET** /attendancelogwhosin | View who&#39;s in a location
[**Bgjobgetstatus**](DefaultApi.md#bgjobgetstatus) | **GET** /bgjobgetstatus | Get background job status
[**Captchagetchallenge**](DefaultApi.md#captchagetchallenge) | **GET** /captchagetchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**Captchagetimage**](DefaultApi.md#captchagetimage) | **GET** /captchagetimage | Gets a captcha image that the user must complete to do certain requests.
[**Changelog**](DefaultApi.md#changelog) | **GET** /changelog | Get the application change log
[**Clientget**](DefaultApi.md#clientget) | **GET** /clientget | Get client
[**Clientlist**](DefaultApi.md#clientlist) | **GET** /clientlist | Gets the clients of the specified conference
[**Clientsave**](DefaultApi.md#clientsave) | **POST** /clientsave | Saves a client
[**Clientsendmessage**](DefaultApi.md#clientsendmessage) | **GET** /clientsendmessage | Send a message to a client
[**Creditdelete**](DefaultApi.md#creditdelete) | **GET** /creditdelete | Delete a credit
[**Creditdiscountmethods**](DefaultApi.md#creditdiscountmethods) | **GET** /creditdiscountmethods | Gets the valid discount methods.
[**Creditget**](DefaultApi.md#creditget) | **GET** /creditget | View details of assigned credit
[**Creditgetuserbalance**](DefaultApi.md#creditgetuserbalance) | **GET** /creditgetuserbalance | Get the total amount of credits of the specified user
[**Creditlist**](DefaultApi.md#creditlist) | **GET** /creditlist | View a list of credits for a specific user
[**Creditlistdetails**](DefaultApi.md#creditlistdetails) | **GET** /creditlistdetails | Gets the credit usage details
[**Creditlistmine**](DefaultApi.md#creditlistmine) | **GET** /creditlistmine | View the list of credits of the current user
[**Creditplandelete**](DefaultApi.md#creditplandelete) | **GET** /creditplandelete | Deletes a credit plan
[**Creditplanget**](DefaultApi.md#creditplanget) | **GET** /creditplanget | Gets a credit plan
[**Creditplanlist**](DefaultApi.md#creditplanlist) | **GET** /creditplanlist | Gets the credit plans available
[**Creditplansave**](DefaultApi.md#creditplansave) | **POST** /creditplansave | Saves a credit plan
[**Creditsave**](DefaultApi.md#creditsave) | **POST** /creditsave | Create or edit credit for a user
[**Creditsavedetails**](DefaultApi.md#creditsavedetails) | **POST** /creditsavedetails | Create or edit credit details
[**Doc**](DefaultApi.md#doc) | **GET** /doc | Get the documentation
[**Easyloginaddbgimage**](DefaultApi.md#easyloginaddbgimage) | **GET** /easyloginaddbgimage | Adds background image for the login
[**Eventdelete**](DefaultApi.md#eventdelete) | **GET** /eventdelete | Delete a course
[**Eventget**](DefaultApi.md#eventget) | **GET** /eventget | Search and view details of a course
[**Eventgetsessionsbydate**](DefaultApi.md#eventgetsessionsbydate) | **GET** /eventgetsessionsbydate | View a list of courses by date
[**Eventlist**](DefaultApi.md#eventlist) | **GET** /eventlist | View a list of courses
[**Eventsave**](DefaultApi.md#eventsave) | **POST** /eventsave | Create or edit a course
[**Eventsearchgroup**](DefaultApi.md#eventsearchgroup) | **GET** /eventsearchgroup | Searches for the available event groups
[**Export**](DefaultApi.md#export) | **GET** /export | Export AccuCampus data
[**Exportlisttypes**](DefaultApi.md#exportlisttypes) | **GET** /exportlisttypes | Lists available export types
[**Featurelist**](DefaultApi.md#featurelist) | **GET** /featurelist | Lists the available features.
[**Holidaylist**](DefaultApi.md#holidaylist) | **GET** /holidaylist | View a list of entered holidays
[**Holidaysave**](DefaultApi.md#holidaysave) | **POST** /holidaysave | Create or edit a list of holidays
[**Holidaysuggest**](DefaultApi.md#holidaysuggest) | **GET** /holidaysuggest | View the holiday suggestions in the given term
[**Import**](DefaultApi.md#import) | **GET** /import | Import data into AccuCampus
[**Importlisttypes**](DefaultApi.md#importlisttypes) | **GET** /importlisttypes | Lists available import types
[**Licenseacceptagreement**](DefaultApi.md#licenseacceptagreement) | **GET** /licenseacceptagreement | Accept the license agreement
[**Licensegetagreementstatus**](DefaultApi.md#licensegetagreementstatus) | **GET** /licensegetagreementstatus | Check if license agreement has been accepted
[**Licensegetcurrent**](DefaultApi.md#licensegetcurrent) | **GET** /licensegetcurrent | Gets the current license information
[**Licenserenew**](DefaultApi.md#licenserenew) | **GET** /licenserenew | Contact Engineerica in order to renew the AccuCampus subscription
[**Listtimezones**](DefaultApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**Locationdelete**](DefaultApi.md#locationdelete) | **GET** /locationdelete | Delete a location
[**Locationget**](DefaultApi.md#locationget) | **GET** /locationget | Search and view details of a location
[**Locationlist**](DefaultApi.md#locationlist) | **GET** /locationlist | View a list of locations
[**Locationsave**](DefaultApi.md#locationsave) | **POST** /locationsave | Create or edit a location
[**Login**](DefaultApi.md#login) | **GET** /login | Login
[**Logout**](DefaultApi.md#logout) | **GET** /logout | Logout
[**Memorizedreportdelete**](DefaultApi.md#memorizedreportdelete) | **GET** /memorizedreportdelete | Delete memorized report
[**Memorizedreportget**](DefaultApi.md#memorizedreportget) | **GET** /memorizedreportget | View details of a memorized report
[**Memorizedreportlist**](DefaultApi.md#memorizedreportlist) | **GET** /memorizedreportlist | View a list of all his memorized reports
[**Memorizedreportsave**](DefaultApi.md#memorizedreportsave) | **POST** /memorizedreportsave | Create or edit a memorized report
[**Menugetitems**](DefaultApi.md#menugetitems) | **GET** /menugetitems | Gets the items on the menu
[**Myaccount**](DefaultApi.md#myaccount) | **GET** /myaccount | Gets the logged in user account.
[**Myianatimezone**](DefaultApi.md#myianatimezone) | **GET** /myianatimezone | Gets the current time zone&#39;s iana name
[**Myprofile**](DefaultApi.md#myprofile) | **GET** /myprofile | Gets the logged in user information.
[**Myrights**](DefaultApi.md#myrights) | **GET** /myrights | Gets the list of actions the user can execute.
[**Mysaveprofile**](DefaultApi.md#mysaveprofile) | **POST** /mysaveprofile | Updates logged user&#39;s profile information
[**Notificationdelete**](DefaultApi.md#notificationdelete) | **GET** /notificationdelete | Delete a notification
[**Notificationget**](DefaultApi.md#notificationget) | **GET** /notificationget | View a notification
[**Notificationgetforstation**](DefaultApi.md#notificationgetforstation) | **GET** /notificationgetforstation | Gets all public (in station) notifications for the specific user
[**Notificationgetunreadcount**](DefaultApi.md#notificationgetunreadcount) | **GET** /notificationgetunreadcount | Get the number of unread notifications
[**Notificationlist**](DefaultApi.md#notificationlist) | **GET** /notificationlist | View a list of all sent notifications
[**Notificationlistmine**](DefaultApi.md#notificationlistmine) | **GET** /notificationlistmine | View all the notifications sent to the current user
[**Notificationmarkasread**](DefaultApi.md#notificationmarkasread) | **GET** /notificationmarkasread | Mark a notification as read
[**Notificationmarkasunread**](DefaultApi.md#notificationmarkasunread) | **GET** /notificationmarkasunread | Mark a notification as unread
[**Notificationsend**](DefaultApi.md#notificationsend) | **GET** /notificationsend | Send notifications on screen, via email or text to users
[**Notificationsendonscreen**](DefaultApi.md#notificationsendonscreen) | **GET** /notificationsendonscreen | Send on-screen notifications
[**Notificationtopicdelete**](DefaultApi.md#notificationtopicdelete) | **GET** /notificationtopicdelete | Delete a notification topic
[**Notificationtopicget**](DefaultApi.md#notificationtopicget) | **GET** /notificationtopicget | Search and view details of a notification topic
[**Notificationtopiclist**](DefaultApi.md#notificationtopiclist) | **GET** /notificationtopiclist | List all the notification topics
[**Notificationtopiclistsubscribe**](DefaultApi.md#notificationtopiclistsubscribe) | **GET** /notificationtopiclistsubscribe | List all the notification topics available to subscribe
[**Notificationtopicsave**](DefaultApi.md#notificationtopicsave) | **POST** /notificationtopicsave | Create or edit a notification topic
[**Pushderegister**](DefaultApi.md#pushderegister) | **GET** /pushderegister | Deregisters the current device to receive push notifications
[**Pushregister**](DefaultApi.md#pushregister) | **GET** /pushregister | Registers the current device to receive push notifications
[**Qrlabelsprint**](DefaultApi.md#qrlabelsprint) | **GET** /qrlabelsprint | Print and email QR labels
[**Qrloginget**](DefaultApi.md#qrloginget) | **GET** /qrloginget | Gets an image of a QR token
[**Qrloginlogin**](DefaultApi.md#qrloginlogin) | **GET** /qrloginlogin | Login
[**Quickpaneldeletewidget**](DefaultApi.md#quickpaneldeletewidget) | **GET** /quickpaneldeletewidget | Deletes a widget from the Quick Panel
[**Quickpanelfetchwidget**](DefaultApi.md#quickpanelfetchwidget) | **GET** /quickpanelfetchwidget | Fetches the information for a specific widget.
[**Quickpanelgetwidget**](DefaultApi.md#quickpanelgetwidget) | **GET** /quickpanelgetwidget | View details of a widget included in the Quick Panel
[**Quickpanelinit**](DefaultApi.md#quickpanelinit) | **GET** /quickpanelinit | Returns the initial information required to show the quick panels
[**Quickpanellistwidgets**](DefaultApi.md#quickpanellistwidgets) | **GET** /quickpanellistwidgets | Lists all the widgets that are added in the Quick Panel
[**Quickpanellistwidgettypes**](DefaultApi.md#quickpanellistwidgettypes) | **GET** /quickpanellistwidgettypes | Lists all the widget types available in the system
[**Quickpanelreorderwidgets**](DefaultApi.md#quickpanelreorderwidgets) | **GET** /quickpanelreorderwidgets | Reorders the widgets and moves them to a specific column
[**Quickpanelsavewidget**](DefaultApi.md#quickpanelsavewidget) | **POST** /quickpanelsavewidget | Saves a widget for the Quick Panel
[**Reportlist**](DefaultApi.md#reportlist) | **GET** /reportlist | View a list of available reports
[**Reportpermissionsbyuser**](DefaultApi.md#reportpermissionsbyuser) | **GET** /reportpermissionsbyuser | Permissions by user report
[**Reportprepare**](DefaultApi.md#reportprepare) | **GET** /reportprepare | Queries and loads the specified report, in background.
[**Reportquery**](DefaultApi.md#reportquery) | **GET** /reportquery | Query and load a specified report
[**Rolelist**](DefaultApi.md#rolelist) | **GET** /rolelist | Show a list of roles
[**Ruledelete**](DefaultApi.md#ruledelete) | **GET** /ruledelete | Delete a rule
[**Ruleget**](DefaultApi.md#ruleget) | **GET** /ruleget | View details of a rule
[**Rulegeteventtype**](DefaultApi.md#rulegeteventtype) | **GET** /rulegeteventtype | View details of a rule event type
[**Rulelist**](DefaultApi.md#rulelist) | **GET** /rulelist | View a list of user rules
[**Rulelistactions**](DefaultApi.md#rulelistactions) | **GET** /rulelistactions | View a list of rule actions available
[**Rulelisteventtypes**](DefaultApi.md#rulelisteventtypes) | **GET** /rulelisteventtypes | View a list of rule event types
[**Rulelisthttprequests**](DefaultApi.md#rulelisthttprequests) | **GET** /rulelisthttprequests | View all the http requests sent as a result of a rule
[**Rulesave**](DefaultApi.md#rulesave) | **POST** /rulesave | Create or edit a rule
[**Search**](DefaultApi.md#search) | **GET** /search | Search
[**Searchgetentities**](DefaultApi.md#searchgetentities) | **GET** /searchgetentities | Get the information of the entities that can be searched
[**Securityassesspermission**](DefaultApi.md#securityassesspermission) | **GET** /securityassesspermission | Returns the list of users for a specific permission
[**Securityassessrole**](DefaultApi.md#securityassessrole) | **GET** /securityassessrole | Returns the list of permissions for a specific role
[**Securityassessscope**](DefaultApi.md#securityassessscope) | **GET** /securityassessscope | Returns the list of users for a specific user
[**Securityassessuser**](DefaultApi.md#securityassessuser) | **GET** /securityassessuser | Returns the list of permissions for a specific user
[**Sessionregaddcurrentuser**](DefaultApi.md#sessionregaddcurrentuser) | **GET** /sessionregaddcurrentuser | Register current user to an event session
[**Sessionregadduser**](DefaultApi.md#sessionregadduser) | **GET** /sessionregadduser | Register users for events
[**Sessionreggetmysessions**](DefaultApi.md#sessionreggetmysessions) | **GET** /sessionreggetmysessions | View all the sessions the logged user is registered to
[**Sessionreggetsessions**](DefaultApi.md#sessionreggetsessions) | **GET** /sessionreggetsessions | Lists the registrations for a specific user
[**Sessionreggetsettings**](DefaultApi.md#sessionreggetsettings) | **GET** /sessionreggetsettings | Get the settings for session registration
[**Sessionreggetusers**](DefaultApi.md#sessionreggetusers) | **GET** /sessionreggetusers | Lists the registrations for a specific session
[**Sessionreglistsessions**](DefaultApi.md#sessionreglistsessions) | **GET** /sessionreglistsessions | List the sessions available for a specific event
[**Sessionreglistupcoming**](DefaultApi.md#sessionreglistupcoming) | **GET** /sessionreglistupcoming | View a list of upcoming event sessions
[**Sessionreglistupcomingevent**](DefaultApi.md#sessionreglistupcomingevent) | **GET** /sessionreglistupcomingevent | View a list of upcoming sessions of a particular event
[**Sessionregremovecurrentuser**](DefaultApi.md#sessionregremovecurrentuser) | **GET** /sessionregremovecurrentuser | Unregister current user from an event session
[**Sessionregremoveuser**](DefaultApi.md#sessionregremoveuser) | **GET** /sessionregremoveuser | Removes a user from an event session
[**Sessionregsavesettings**](DefaultApi.md#sessionregsavesettings) | **POST** /sessionregsavesettings | Save the settings for an event&#39;s session registration
[**Settingaddlogo**](DefaultApi.md#settingaddlogo) | **GET** /settingaddlogo | Add a logo to the account
[**Settingget**](DefaultApi.md#settingget) | **GET** /settingget | Get settings for the account or the specified scope
[**Settingsave**](DefaultApi.md#settingsave) | **POST** /settingsave | Save settings for the account or the specified scope
[**Settingviewgeneral**](DefaultApi.md#settingviewgeneral) | **GET** /settingviewgeneral | View general settings for the account
[**Ssogeneratekey**](DefaultApi.md#ssogeneratekey) | **GET** /ssogeneratekey | Generate/reset single sign on access key.
[**Ssogetsettings**](DefaultApi.md#ssogetsettings) | **GET** /ssogetsettings | View single sign on settings.
[**Ssoissuetoken**](DefaultApi.md#ssoissuetoken) | **GET** /ssoissuetoken | Issue single sign-on token
[**Ssosavesettings**](DefaultApi.md#ssosavesettings) | **POST** /ssosavesettings | Edit single sign-on settings.
[**Stationdelete**](DefaultApi.md#stationdelete) | **GET** /stationdelete | Delete a sign-in station
[**Stationget**](DefaultApi.md#stationget) | **GET** /stationget | View details of a sign-in station
[**Stationgetcurrentterms**](DefaultApi.md#stationgetcurrentterms) | **GET** /stationgetcurrentterms | Get all the current terms
[**Stationgetinfo**](DefaultApi.md#stationgetinfo) | **GET** /stationgetinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**Stationgetlicense**](DefaultApi.md#stationgetlicense) | **GET** /stationgetlicense | Gets the current license information
[**Stationlist**](DefaultApi.md#stationlist) | **GET** /stationlist | View a list of sign-in stations
[**Stationsave**](DefaultApi.md#stationsave) | **POST** /stationsave | Create or edit a sign-in station
[**Stationunlock**](DefaultApi.md#stationunlock) | **GET** /stationunlock | Unlocks the sign-in station.
[**Swipedelete**](DefaultApi.md#swipedelete) | **GET** /swipedelete | Delete a swipe
[**Swipeget**](DefaultApi.md#swipeget) | **GET** /swipeget | Search and view details of a swipe
[**Swipelist**](DefaultApi.md#swipelist) | **GET** /swipelist | View a list of swipes
[**Swipesave**](DefaultApi.md#swipesave) | **POST** /swipesave | Create or edit a swipe, and if possible, save the related attendance log
[**Swipesaveanonym**](DefaultApi.md#swipesaveanonym) | **POST** /swipesaveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
[**Tagdelete**](DefaultApi.md#tagdelete) | **GET** /tagdelete | Delete a tag
[**Tagget**](DefaultApi.md#tagget) | **GET** /tagget | View details of a specified tag
[**Taglist**](DefaultApi.md#taglist) | **GET** /taglist | View a list of tags
[**Taglistgroups**](DefaultApi.md#taglistgroups) | **GET** /taglistgroups | View a list of entities that can be tagged
[**Tagsave**](DefaultApi.md#tagsave) | **POST** /tagsave | Create or edit a tag
[**Tagsearch**](DefaultApi.md#tagsearch) | **GET** /tagsearch | Search for tags in the account
[**Templateaddimage**](DefaultApi.md#templateaddimage) | **GET** /templateaddimage | Add an image to a template
[**Templatedelete**](DefaultApi.md#templatedelete) | **GET** /templatedelete | Delete a template
[**Templateemail**](DefaultApi.md#templateemail) | **GET** /templateemail | Send generated templates by email
[**Templategenerate**](DefaultApi.md#templategenerate) | **GET** /templategenerate | Generate specified templates
[**Templateget**](DefaultApi.md#templateget) | **GET** /templateget | View details of a template
[**Templategetgenerated**](DefaultApi.md#templategetgenerated) | **GET** /templategetgenerated | View generated templates
[**Templatelist**](DefaultApi.md#templatelist) | **GET** /templatelist | View a list of defined templates
[**Templatelistsources**](DefaultApi.md#templatelistsources) | **GET** /templatelistsources | View a list of templates&#39; data sources
[**Templatesave**](DefaultApi.md#templatesave) | **POST** /templatesave | Create or edit a template
[**Templatesavelayout**](DefaultApi.md#templatesavelayout) | **POST** /templatesavelayout | Save the layout of a template
[**Termdelete**](DefaultApi.md#termdelete) | **GET** /termdelete | Delete a term
[**Termget**](DefaultApi.md#termget) | **GET** /termget | Search and view details of a term
[**Termlist**](DefaultApi.md#termlist) | **GET** /termlist | Search and view details of all terms
[**Termsave**](DefaultApi.md#termsave) | **POST** /termsave | Create and edit terms
[**Textcreditremaining**](DefaultApi.md#textcreditremaining) | **GET** /textcreditremaining | Gets the remaining text credits for the account
[**Texttoimage**](DefaultApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
[**Translationget**](DefaultApi.md#translationget) | **GET** /translationget | Gets the translations of the specified values
[**Translationgetcachefile**](DefaultApi.md#translationgetcachefile) | **GET** /translationgetcachefile | Get the file containing the translations
[**Translationlist**](DefaultApi.md#translationlist) | **GET** /translationlist | Lists all the available translations in the system
[**Translationsave**](DefaultApi.md#translationsave) | **POST** /translationsave | Edit a translation
[**Userchangepwd**](DefaultApi.md#userchangepwd) | **GET** /userchangepwd | Change user&#39;s own password
[**Userchangepwdbyreq**](DefaultApi.md#userchangepwdbyreq) | **GET** /userchangepwdbyreq | Changes the user password using a change password request id
[**Userdelete**](DefaultApi.md#userdelete) | **GET** /userdelete | Delete a user
[**Userfindsimilar**](DefaultApi.md#userfindsimilar) | **GET** /userfindsimilar | Finds similar users to prevent duplicates
[**Userget**](DefaultApi.md#userget) | **GET** /userget | Search and view details of a user
[**Usergetbycard**](DefaultApi.md#usergetbycard) | **GET** /usergetbycard | Search user by card number
[**Usergroupaddmember**](DefaultApi.md#usergroupaddmember) | **GET** /usergroupaddmember | Add a user to a group
[**Usergroupdelete**](DefaultApi.md#usergroupdelete) | **GET** /usergroupdelete | Delete a group
[**Usergroupget**](DefaultApi.md#usergroupget) | **GET** /usergroupget | Search and view details of a user group
[**Usergroupgetmembers**](DefaultApi.md#usergroupgetmembers) | **GET** /usergroupgetmembers | View the members of a user group
[**Usergroupgetuser**](DefaultApi.md#usergroupgetuser) | **GET** /usergroupgetuser | View the groups which a user is registered to
[**Usergrouplist**](DefaultApi.md#usergrouplist) | **GET** /usergrouplist | View a list of user groups
[**Usergrouprefresh**](DefaultApi.md#usergrouprefresh) | **GET** /usergrouprefresh | Refresh the dynamic group
[**Usergroupremovemember**](DefaultApi.md#usergroupremovemember) | **GET** /usergroupremovemember | Remove a user from a group
[**Usergroupsave**](DefaultApi.md#usergroupsave) | **POST** /usergroupsave | Create or edit a group
[**Userlist**](DefaultApi.md#userlist) | **GET** /userlist | View a list of users
[**Userloadphoto**](DefaultApi.md#userloadphoto) | **GET** /userloadphoto | Upload a photo for a specific user
[**Usermovedata**](DefaultApi.md#usermovedata) | **GET** /usermovedata | Move data between users
[**Userrequestpwdchange**](DefaultApi.md#userrequestpwdchange) | **GET** /userrequestpwdchange | Requests a password change
[**Usersave**](DefaultApi.md#usersave) | **POST** /usersave | Create or edit a user
[**Usersavepwdchange**](DefaultApi.md#usersavepwdchange) | **POST** /usersavepwdchange | Send email to the specified user(s) to set/change their passwords
[**Usersettingsget**](DefaultApi.md#usersettingsget) | **GET** /usersettingsget | Lists available user settings
[**Usersettingsgetmultiple**](DefaultApi.md#usersettingsgetmultiple) | **GET** /usersettingsgetmultiple | Get multiple user settings
[**Usersettingssave**](DefaultApi.md#usersettingssave) | **POST** /usersettingssave | Saves a user setting
[**Usersettingssavemultiple**](DefaultApi.md#usersettingssavemultiple) | **POST** /usersettingssavemultiple | Save multiple user settings at once
[**Version**](DefaultApi.md#version) | **GET** /version | Get current version information


<a name="actionloglist"></a>
# **Actionloglist**
> void Actionloglist (string token, int? from, int? count, Guid? user, DateTime? startdate, DateTime? enddate, string resource, string actionfilter, string argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionloglistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var user = new Guid?(); // Guid? | The id of the user whose action logs have to be returned. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the logs. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the logs. (optional) 
            var resource = resource_example;  // string | The resource to filter the action logs. (optional) 
            var actionfilter = actionfilter_example;  // string | The action to filter the action logs. (optional) 
            var argument = argument_example;  // string | The id of the entity that was the argument of the executed action. (optional) 

            try
            {
                // View a list of users action logs
                apiInstance.Actionloglist(token, from, count, user, startdate, enddate, resource, actionfilter, argument);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Actionloglist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **user** | [**Guid?**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the logs. | [optional] 
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

<a name="advroleaddmissing"></a>
# **Advroleaddmissing**
> void Advroleaddmissing (string token, string roles, string permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleaddmissingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var roles = roles_example;  // string | CSV list of the role ids to check
            var permissions = permissions_example;  // string | CSV list of the permissions to check

            try
            {
                // Adds the missing permissions to a role. Requires access to advrole.save
                apiInstance.Advroleaddmissing(token, roles, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroleaddmissing: " + e.Message );
            }
        }
    }
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

<a name="advrolecheckperm"></a>
# **Advrolecheckperm**
> void Advrolecheckperm (string token, string roles, string permissions)

Checks the permissions are assigned for the given roles

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolecheckpermExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var roles = roles_example;  // string | CSV list of the role ids to check
            var permissions = permissions_example;  // string | CSV list of the permissions to check

            try
            {
                // Checks the permissions are assigned for the given roles
                apiInstance.Advrolecheckperm(token, roles, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolecheckperm: " + e.Message );
            }
        }
    }
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

<a name="advroledelete"></a>
# **Advroledelete**
> void Advroledelete (string token, Guid? id)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroledeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the location to delete.

            try
            {
                // Delete a role
                apiInstance.Advroledelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroledelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the location to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroledeletemapping"></a>
# **Advroledeletemapping**
> void Advroledeletemapping (string token, string map, Guid? roleid)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroledeletemappingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var map = map_example;  // string | The map name to save the role.
            var roleid = new Guid?(); // Guid? | The id of the role.

            try
            {
                // Delete a role mapping
                apiInstance.Advroledeletemapping(token, map, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroledeletemapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **map** | **string**| The map name to save the role. | 
 **roleid** | [**Guid?**](.md)| The id of the role. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroleget"></a>
# **Advroleget**
> void Advroleget (string token, Guid? id)

View details of a role

Allows the user to view a role and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the location to get.

            try
            {
                // View details of a role
                apiInstance.Advroleget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroleget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelist"></a>
# **Advrolelist**
> void Advrolelist (string token, bool? includepolicies, bool? includeinternal, string name)

Lists the roles for the current account

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var includepolicies = true;  // bool? | True to include the policies, defaults to false. (optional) 
            var includeinternal = true;  // bool? | True to include the internal roles too. (optional) 
            var name = name_example;  // string | Filter by name of the role. (optional) 

            try
            {
                // Lists the roles for the current account
                apiInstance.Advrolelist(token, includepolicies, includeinternal, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **includepolicies** | **bool?**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **bool?**| True to include the internal roles too. | [optional] 
 **name** | **string**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelistmaps"></a>
# **Advrolelistmaps**
> void Advrolelistmaps (string token, Guid? roleid)

Lists the maps a roles is mapped to

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolelistmapsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var roleid = new Guid?(); // Guid? | The id of the role to list the maps.

            try
            {
                // Lists the maps a roles is mapped to
                apiInstance.Advrolelistmaps(token, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolelistmaps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **roleid** | [**Guid?**](.md)| The id of the role to list the maps. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelistrolesmapped"></a>
# **Advrolelistrolesmapped**
> void Advrolelistrolesmapped (string token, string map)

Lists the roles mappings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolelistrolesmappedExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var map = map_example;  // string | List only the roles in the specified map. (optional) 

            try
            {
                // Lists the roles mappings
                apiInstance.Advrolelistrolesmapped(token, map);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolelistrolesmapped: " + e.Message );
            }
        }
    }
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

<a name="advrolelisttemplates"></a>
# **Advrolelisttemplates**
> void Advrolelisttemplates (string token)

View a list of role templates

Allows the user to view the full list of available role templates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolelisttemplatesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of role templates
                apiInstance.Advrolelisttemplates(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolelisttemplates: " + e.Message );
            }
        }
    }
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

<a name="advrolesave"></a>
# **Advrolesave**
> void Advrolesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a role
                apiInstance.Advrolesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolesavemapping"></a>
# **Advrolesavemapping**
> void Advrolesavemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolesavemappingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a role mapping
                apiInstance.Advrolesavemapping(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolesavemapping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolesuserlist"></a>
# **Advrolesuserlist**
> void Advrolesuserlist (string token, int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)

List users. Alias to user.list, use that one instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolesuserlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var roleid = new Guid?(); // Guid? | The id of the role to filter users by, or empty to return all users. (optional) 
            var onlywithoutcard = onlywithoutcard_example;  // string | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // List users. Alias to user.list, use that one instead.
                apiInstance.Advrolesuserlist(token, from, count, roleid, onlywithoutcard, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advrolesuserlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **roleid** | [**Guid?**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroleuserupgrade"></a>
# **Advroleuserupgrade**
> void Advroleuserupgrade (string token, Guid? userid, Guid? roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleuserupgradeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | Id of the user to upgrade
            var roleid = new Guid?(); // Guid? | Id of the role to add

            try
            {
                // Upgrade a user to another role (requires permission to edit those roles)
                apiInstance.Advroleuserupgrade(token, userid, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Advroleuserupgrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| Id of the user to upgrade | 
 **roleid** | [**Guid?**](.md)| Id of the role to add | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsharegetphone"></a>
# **Appsharegetphone**
> void Appsharegetphone (string token)

Gets the phone number of the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsharegetphoneExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the phone number of the current user
                apiInstance.Appsharegetphone(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appsharegetphone: " + e.Message );
            }
        }
    }
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

<a name="appsharesendtext"></a>
# **Appsharesendtext**
> void Appsharesendtext (string token, string phonenumber)

Sends an SMS with the link to the app

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsharesendtextExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var phonenumber = phonenumber_example;  // string | Phone number to where to send the link. Leave empty to the number on file. (optional) 

            try
            {
                // Sends an SMS with the link to the app
                apiInstance.Appsharesendtext(token, phonenumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Appsharesendtext: " + e.Message );
            }
        }
    }
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

<a name="attendancelogcommentdelete"></a>
# **Attendancelogcommentdelete**
> void Attendancelogcommentdelete (string token, Guid? id)

Delete a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log comment to delete.

            try
            {
                // Delete a comment on an attendance log
                apiInstance.Attendancelogcommentdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogcommentdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log comment to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentget"></a>
# **Attendancelogcommentget**
> void Attendancelogcommentget (string token, Guid? id)

View a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the comment to get.

            try
            {
                // View a comment on an attendance log
                apiInstance.Attendancelogcommentget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogcommentget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the comment to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentlist"></a>
# **Attendancelogcommentlist**
> void Attendancelogcommentlist (Guid? attendancelog, string token)

View all the comments on a specific attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var attendancelog = new Guid?(); // Guid? | The id of the attendance log whose comments have to be retrieved.
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // View all the comments on a specific attendance log
                apiInstance.Attendancelogcommentlist(attendancelog, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogcommentlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**Guid?**](.md)| The id of the attendance log whose comments have to be retrieved. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentsave"></a>
# **Attendancelogcommentsave**
> void Attendancelogcommentsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a comment on an attendance log
                apiInstance.Attendancelogcommentsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogcommentsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogdelete"></a>
# **Attendancelogdelete**
> void Attendancelogdelete (string token, Guid? id)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to delete.

            try
            {
                // Delete an attendance log
                apiInstance.Attendancelogdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogget"></a>
# **Attendancelogget**
> void Attendancelogget (string token, Guid? id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendanceloggetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to get.

            try
            {
                // Search and view details of an attendance log
                apiInstance.Attendancelogget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloggetchangehistory"></a>
# **Attendanceloggetchangehistory**
> void Attendanceloggetchangehistory (string token, Guid? id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendanceloggetchangehistoryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to get.

            try
            {
                // Search and view details of an attendance log's swipe history
                apiInstance.Attendanceloggetchangehistory(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendanceloggetchangehistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloglist"></a>
# **Attendanceloglist**
> void Attendanceloglist (int? from, int? count, string token, string filter, Guid? userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendanceloglistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 
            var filter = filter_example;  // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional) 
            var userid = new Guid?(); // Guid? | The user ID of the user to get the logs. (optional) 

            try
            {
                // View a list of attendance logs
                apiInstance.Attendanceloglist(from, count, token, filter, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendanceloglist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**Guid?**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloglistmine"></a>
# **Attendanceloglistmine**
> void Attendanceloglistmine (int? from, int? count, string token, string filter)

Gets the attendance logs of the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendanceloglistmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 
            var filter = filter_example;  // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional) 

            try
            {
                // Gets the attendance logs of the current user
                apiInstance.Attendanceloglistmine(from, count, token, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendanceloglistmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
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

<a name="attendancelogsave"></a>
# **Attendancelogsave**
> void Attendancelogsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an attendance log
                apiInstance.Attendancelogsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogsignout"></a>
# **Attendancelogsignout**
> void Attendancelogsignout (string token, Guid? id, Guid? location, Guid? _event, DateTime? datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogsignoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the attendance log to sign-out. (optional) 
            var location = new Guid?(); // Guid? | The id of the location to filter the users to sign out. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event to filter the users to sign out. (optional) 
            var datetime = 2013-10-20T19:20:30+01:00;  // DateTime? | Specifies the date and time when the specified logs have to be signed out. (optional) 

            try
            {
                // Sign out an attendance log
                apiInstance.Attendancelogsignout(token, id, location, _event, datetime);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogsignout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**Guid?**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **DateTime?**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogwhosin"></a>
# **Attendancelogwhosin**
> void Attendancelogwhosin (int? from, int? count, string token, Guid? location, Guid? _event, string sorting, string roles, int? photosize, string extensions, bool? export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogwhosinExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 
            var location = new Guid?(); // Guid? | The id of the location to search for users that are in. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event to search for users that are in. (optional) 
            var sorting = sorting_example;  // string | Field to sort by. Either first-name, last-name or sign-in-time. (optional) 
            var roles = roles_example;  // string | The comma-separated list of ids of the roles to search for users that are in. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 
            var extensions = extensions_example;  // string | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]). (optional) 
            var export = true;  // bool? | True to export the results as CSV (optional) 

            try
            {
                // View who's in a location
                apiInstance.Attendancelogwhosin(from, count, token, location, _event, sorting, roles, photosize, extensions, export);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Attendancelogwhosin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 
 **location** | [**Guid?**](.md)| The id of the location to search for users that are in. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **string**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **string**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **string**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **bool?**| True to export the results as CSV | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bgjobgetstatus"></a>
# **Bgjobgetstatus**
> void Bgjobgetstatus (string token, Guid? jobid, string jobtype)

Get background job status

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BgjobgetstatusExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var jobid = new Guid?(); // Guid? | The ID of the job to get the status. 10 most recent will be returned if not specified. (optional) 
            var jobtype = jobtype_example;  // string | The job type to filter by. (optional) 

            try
            {
                // Get background job status
                apiInstance.Bgjobgetstatus(token, jobid, jobtype);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Bgjobgetstatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **jobid** | [**Guid?**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **string**| The job type to filter by. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="captchagetchallenge"></a>
# **Captchagetchallenge**
> void Captchagetchallenge ()

Gets a captcha challenge that the user must complete to do certain requests.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CaptchagetchallengeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Gets a captcha challenge that the user must complete to do certain requests.
                apiInstance.Captchagetchallenge();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Captchagetchallenge: " + e.Message );
            }
        }
    }
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

<a name="captchagetimage"></a>
# **Captchagetimage**
> void Captchagetimage (string captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CaptchagetimageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var captchatoken = captchatoken_example;  // string | The captcha token or ID returned by the captcha.getchallenge action

            try
            {
                // Gets a captcha image that the user must complete to do certain requests.
                apiInstance.Captchagetimage(captchatoken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Captchagetimage: " + e.Message );
            }
        }
    }
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

<a name="changelog"></a>
# **Changelog**
> void Changelog (string token)

Get the application change log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChangelogExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Get the application change log
                apiInstance.Changelog(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Changelog: " + e.Message );
            }
        }
    }
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

<a name="clientget"></a>
# **Clientget**
> void Clientget (string token, string _client, string clientname)

Get client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var _client = _client_example;  // string | The unique id of the client.
            var clientname = clientname_example;  // string | The custom name of the client. (optional) 

            try
            {
                // Get client
                apiInstance.Clientget(token, _client, clientname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Clientget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **_client** | **string**| The unique id of the client. | 
 **clientname** | **string**| The custom name of the client. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientlist"></a>
# **Clientlist**
> void Clientlist (string token, int? from, int? count)

Gets the clients of the specified conference

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // Gets the clients of the specified conference
                apiInstance.Clientlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Clientlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsave"></a>
# **Clientsave**
> void Clientsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a client
                apiInstance.Clientsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Clientsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsendmessage"></a>
# **Clientsendmessage**
> void Clientsendmessage (string token, Guid? uniqueclientid, string message)

Send a message to a client

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientsendmessageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var uniqueclientid = new Guid?(); // Guid? | The unique id of the client.
            var message = message_example;  // string | The body of the message to send.

            try
            {
                // Send a message to a client
                apiInstance.Clientsendmessage(token, uniqueclientid, message);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Clientsendmessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **uniqueclientid** | [**Guid?**](.md)| The unique id of the client. | 
 **message** | **string**| The body of the message to send. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditdelete"></a>
# **Creditdelete**
> void Creditdelete (string token, Guid? id)

Delete a credit

Allows the user to delete credits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the credit to delete.

            try
            {
                // Delete a credit
                apiInstance.Creditdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the credit to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditdiscountmethods"></a>
# **Creditdiscountmethods**
> void Creditdiscountmethods ()

Gets the valid discount methods.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditdiscountmethodsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Gets the valid discount methods.
                apiInstance.Creditdiscountmethods();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditdiscountmethods: " + e.Message );
            }
        }
    }
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

<a name="creditget"></a>
# **Creditget**
> void Creditget (string token, Guid? id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the credit to get.

            try
            {
                // View details of assigned credit
                apiInstance.Creditget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the credit to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditgetuserbalance"></a>
# **Creditgetuserbalance**
> void Creditgetuserbalance (string token, Guid? user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditgetuserbalanceExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var user = new Guid?(); // Guid? | The id of the user whose balance has to be returned.

            try
            {
                // Get the total amount of credits of the specified user
                apiInstance.Creditgetuserbalance(token, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditgetuserbalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **user** | [**Guid?**](.md)| The id of the user whose balance has to be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditlist"></a>
# **Creditlist**
> void Creditlist (string token, Guid? user, int? from, int? count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var user = new Guid?(); // Guid? | The id of the user.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of credits for a specific user
                apiInstance.Creditlist(token, user, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **user** | [**Guid?**](.md)| The id of the user. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditlistdetails"></a>
# **Creditlistdetails**
> void Creditlistdetails (string token, Guid? credit, int? from, int? count)

Gets the credit usage details

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditlistdetailsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var credit = new Guid?(); // Guid? | The id of the credit to look up for details.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // Gets the credit usage details
                apiInstance.Creditlistdetails(token, credit, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditlistdetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **credit** | [**Guid?**](.md)| The id of the credit to look up for details. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditlistmine"></a>
# **Creditlistmine**
> void Creditlistmine (string token, int? from, int? count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditlistmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View the list of credits of the current user
                apiInstance.Creditlistmine(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditlistmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditplandelete"></a>
# **Creditplandelete**
> void Creditplandelete (string token, Guid? id)

Deletes a credit plan

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditplandeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the credit plan to delete.

            try
            {
                // Deletes a credit plan
                apiInstance.Creditplandelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditplandelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the credit plan to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditplanget"></a>
# **Creditplanget**
> void Creditplanget (string token, Guid? id)

Gets a credit plan

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditplangetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the credit plan to get.

            try
            {
                // Gets a credit plan
                apiInstance.Creditplanget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditplanget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the credit plan to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditplanlist"></a>
# **Creditplanlist**
> void Creditplanlist (string token, int? from, int? count)

Gets the credit plans available

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditplanlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // Gets the credit plans available
                apiInstance.Creditplanlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditplanlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditplansave"></a>
# **Creditplansave**
> void Creditplansave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a credit plan

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditplansaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a credit plan
                apiInstance.Creditplansave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditplansave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditsave"></a>
# **Creditsave**
> void Creditsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit credit for a user

Allows the user to create or edit credit for a user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit credit for a user
                apiInstance.Creditsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creditsavedetails"></a>
# **Creditsavedetails**
> void Creditsavedetails (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit credit details

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreditsavedetailsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit credit details
                apiInstance.Creditsavedetails(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Creditsavedetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="doc"></a>
# **Doc**
> void Doc (bool? excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DocExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var excludeanonymous = true;  // bool? | If true it excludes the anonymous actions from the returned list. (optional) 

            try
            {
                // Get the documentation
                apiInstance.Doc(excludeanonymous);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Doc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **bool?**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="easyloginaddbgimage"></a>
# **Easyloginaddbgimage**
> void Easyloginaddbgimage (string token, string upload, string filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EasyloginaddbgimageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The original filename, needed to process the file.

            try
            {
                // Adds background image for the login
                apiInstance.Easyloginaddbgimage(token, upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Easyloginaddbgimage: " + e.Message );
            }
        }
    }
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

<a name="eventdelete"></a>
# **Eventdelete**
> void Eventdelete (string token, Guid? id)

Delete a course

Allows the user to delete an existing course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the event to delete.

            try
            {
                // Delete a course
                apiInstance.Eventdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the event to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventget"></a>
# **Eventget**
> void Eventget (string token, Guid? id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the event to get.

            try
            {
                // Search and view details of a course
                apiInstance.Eventget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the event to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventgetsessionsbydate"></a>
# **Eventgetsessionsbydate**
> void Eventgetsessionsbydate (string token, Guid? location, DateTime? date, string type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventgetsessionsbydateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var location = new Guid?(); // Guid? | The location to filter the events. (optional) 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | The date to filter the events. Today will be used if this parameter is omitted. (optional) 
            var type = type_example;  // string | Type of event to list. (optional) 

            try
            {
                // View a list of courses by date
                apiInstance.Eventgetsessionsbydate(token, location, date, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventgetsessionsbydate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **location** | [**Guid?**](.md)| The location to filter the events. | [optional] 
 **date** | **DateTime?**| The date to filter the events. Today will be used if this parameter is omitted. | [optional] 
 **type** | **string**| Type of event to list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventlist"></a>
# **Eventlist**
> void Eventlist (string token, string from, string count, bool? summaryonly, Guid? termid)

View a list of courses

Allows the user to view the full list of courses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = from_example;  // string | The first record to return.
            var count = count_example;  // string | The max number of records to return.
            var summaryonly = true;  // bool? | True to return only the event information and not the associated schedule, dept, etc. Defaults to false. (optional) 
            var termid = new Guid?(); // Guid? | Id of the term to list the events. Null to list all events. (optional) 

            try
            {
                // View a list of courses
                apiInstance.Eventlist(token, from, count, summaryonly, termid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **string**| The first record to return. | 
 **count** | **string**| The max number of records to return. | 
 **summaryonly** | **bool?**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional] 
 **termid** | [**Guid?**](.md)| Id of the term to list the events. Null to list all events. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsave"></a>
# **Eventsave**
> void Eventsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a course

Allows the user to create or edit a course.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a course
                apiInstance.Eventsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsearchgroup"></a>
# **Eventsearchgroup**
> void Eventsearchgroup (string token, Guid? query)

Searches for the available event groups

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EventsearchgroupExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var query = new Guid?(); // Guid? | Query to search event groups.

            try
            {
                // Searches for the available event groups
                apiInstance.Eventsearchgroup(token, query);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Eventsearchgroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | [**Guid?**](.md)| Query to search event groups. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="export"></a>
# **Export**
> void Export (string token, string exporttype, string exportformat, string filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ExportExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var exporttype = exporttype_example;  // string | What to export.
            var exportformat = exportformat_example;  // string | The format of the resulting file. Valid types are CSV, HTML, XLS.
            var filters = filters_example;  // string | Pipe separated filters for the export, eg: aaa=val|bbb=val|... (optional) 

            try
            {
                // Export AccuCampus data
                apiInstance.Export(token, exporttype, exportformat, filters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Export: " + e.Message );
            }
        }
    }
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

<a name="exportlisttypes"></a>
# **Exportlisttypes**
> void Exportlisttypes (string token)

Lists available export types

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ExportlisttypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists available export types
                apiInstance.Exportlisttypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Exportlisttypes: " + e.Message );
            }
        }
    }
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

<a name="featurelist"></a>
# **Featurelist**
> void Featurelist (string token)

Lists the available features.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FeaturelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists the available features.
                apiInstance.Featurelist(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Featurelist: " + e.Message );
            }
        }
    }
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

<a name="holidaylist"></a>
# **Holidaylist**
> void Holidaylist (string token, Guid? term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidaylistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var term = new Guid?(); // Guid? | The term to get holidays from.

            try
            {
                // View a list of entered holidays
                apiInstance.Holidaylist(token, term);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Holidaylist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **term** | [**Guid?**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="holidaysave"></a>
# **Holidaysave**
> void Holidaysave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidaysaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a list of holidays
                apiInstance.Holidaysave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Holidaysave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="holidaysuggest"></a>
# **Holidaysuggest**
> void Holidaysuggest (string token, Guid? term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HolidaysuggestExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var term = new Guid?(); // Guid? | The term to get holidays from.

            try
            {
                // View the holiday suggestions in the given term
                apiInstance.Holidaysuggest(token, term);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Holidaysuggest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **term** | [**Guid?**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="import"></a>
# **Import**
> void Import (string token, string importtype, string upload, string filename, string parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ImportExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var importtype = importtype_example;  // string | The kind of data that is being uploaded.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 
            var parameters = parameters_example;  // string | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}. (optional) 

            try
            {
                // Import data into AccuCampus
                apiInstance.Import(token, importtype, upload, filename, parameters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Import: " + e.Message );
            }
        }
    }
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

<a name="importlisttypes"></a>
# **Importlisttypes**
> void Importlisttypes (string token)

Lists available import types

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ImportlisttypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists available import types
                apiInstance.Importlisttypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Importlisttypes: " + e.Message );
            }
        }
    }
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

<a name="licenseacceptagreement"></a>
# **Licenseacceptagreement**
> void Licenseacceptagreement (string token)

Accept the license agreement

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicenseacceptagreementExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Accept the license agreement
                apiInstance.Licenseacceptagreement(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Licenseacceptagreement: " + e.Message );
            }
        }
    }
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

<a name="licensegetagreementstatus"></a>
# **Licensegetagreementstatus**
> void Licensegetagreementstatus (string token)

Check if license agreement has been accepted

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicensegetagreementstatusExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Check if license agreement has been accepted
                apiInstance.Licensegetagreementstatus(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Licensegetagreementstatus: " + e.Message );
            }
        }
    }
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

<a name="licensegetcurrent"></a>
# **Licensegetcurrent**
> void Licensegetcurrent (string token)

Gets the current license information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicensegetcurrentExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // Gets the current license information
                apiInstance.Licensegetcurrent(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Licensegetcurrent: " + e.Message );
            }
        }
    }
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

<a name="licenserenew"></a>
# **Licenserenew**
> void Licenserenew (string token, string email, string phonenumber, string jobtitle, string institution, string comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicenserenewExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var email = email_example;  // string | The e-mail of the user sending the request.
            var phonenumber = phonenumber_example;  // string | The phone number of the user sending the request.
            var jobtitle = jobtitle_example;  // string | The job title of the user sending the request. (optional) 
            var institution = institution_example;  // string | The institution of the user sending the request. (optional) 
            var comments = comments_example;  // string | Comments entered by the user sending the request. (optional) 

            try
            {
                // Contact Engineerica in order to renew the AccuCampus subscription
                apiInstance.Licenserenew(token, email, phonenumber, jobtitle, institution, comments);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Licenserenew: " + e.Message );
            }
        }
    }
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

<a name="listtimezones"></a>
# **Listtimezones**
> void Listtimezones ()

Lists the available timezones

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListtimezonesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                // Lists the available timezones
                apiInstance.Listtimezones();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Listtimezones: " + e.Message );
            }
        }
    }
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

<a name="locationdelete"></a>
# **Locationdelete**
> void Locationdelete (string token, Guid? id)

Delete a location

Allows the user to delete an existing location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the location to delete.

            try
            {
                // Delete a location
                apiInstance.Locationdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Locationdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the location to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationget"></a>
# **Locationget**
> void Locationget (string token, Guid? id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the location to get.

            try
            {
                // Search and view details of a location
                apiInstance.Locationget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Locationget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationlist"></a>
# **Locationlist**
> void Locationlist (string token, int? from, int? count, string locations, bool? sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var locations = locations_example;  // string | The comma-separated list containing the ids of the locations to list. (optional) 
            var sortbygroup = true;  // bool? | True to list locations sorted by the 'Located In' property. Defaults to false. (optional) 

            try
            {
                // View a list of locations
                apiInstance.Locationlist(token, from, count, locations, sortbygroup);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Locationlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **locations** | **string**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **bool?**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationsave"></a>
# **Locationsave**
> void Locationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a location

Allows the user to create or edit a location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a location
                apiInstance.Locationsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Locationsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> void Login (string domain, string username, string password, string method, bool? rememberme)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var domain = domain_example;  // string | The account domain to login.
            var username = username_example;  // string | The username (email) of the user to login as.
            var password = password_example;  // string | The password of the user to login as.
            var method = method_example;  // string | The authentication method. Valid values are 'token' and 'cookie'.
            var rememberme = true;  // bool? | If true then the session will not expire. (optional) 

            try
            {
                // Login
                apiInstance.Login(domain, username, password, method, rememberme);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The account domain to login. | 
 **username** | **string**| The username (email) of the user to login as. | 
 **password** | **string**| The password of the user to login as. | 
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **bool?**| If true then the session will not expire. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout (string token)

Logout

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token used to login. (optional) 

            try
            {
                // Logout
                apiInstance.Logout(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Logout: " + e.Message );
            }
        }
    }
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

<a name="memorizedreportdelete"></a>
# **Memorizedreportdelete**
> void Memorizedreportdelete (string token, Guid? id)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the report settings to delete.

            try
            {
                // Delete memorized report
                apiInstance.Memorizedreportdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Memorizedreportdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the report settings to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportget"></a>
# **Memorizedreportget**
> void Memorizedreportget (string token, Guid? id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the report configuration to get.

            try
            {
                // View details of a memorized report
                apiInstance.Memorizedreportget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Memorizedreportget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the report configuration to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportlist"></a>
# **Memorizedreportlist**
> void Memorizedreportlist (string token, int? from, int? count, string customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var customname = customname_example;  // string | If specified filters the memorized reports by custom name. (optional) 

            try
            {
                // View a list of all his memorized reports
                apiInstance.Memorizedreportlist(token, from, count, customname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Memorizedreportlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **customname** | **string**| If specified filters the memorized reports by custom name. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="memorizedreportsave"></a>
# **Memorizedreportsave**
> void Memorizedreportsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MemorizedreportsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a memorized report
                apiInstance.Memorizedreportsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Memorizedreportsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="menugetitems"></a>
# **Menugetitems**
> void Menugetitems (string menuid)

Gets the items on the menu

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MenugetitemsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var menuid = menuid_example;  // string | The Id of the menu to get.

            try
            {
                // Gets the items on the menu
                apiInstance.Menugetitems(menuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Menugetitems: " + e.Message );
            }
        }
    }
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

<a name="myaccount"></a>
# **Myaccount**
> void Myaccount (string token)

Gets the logged in user account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyaccountExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the logged in user account.
                apiInstance.Myaccount(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Myaccount: " + e.Message );
            }
        }
    }
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

<a name="myianatimezone"></a>
# **Myianatimezone**
> void Myianatimezone (string token)

Gets the current time zone's iana name

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyianatimezoneExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the current time zone's iana name
                apiInstance.Myianatimezone(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Myianatimezone: " + e.Message );
            }
        }
    }
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

<a name="myprofile"></a>
# **Myprofile**
> void Myprofile (string token, int? photosize)

Gets the logged in user information.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyprofileExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Gets the logged in user information.
                apiInstance.Myprofile(token, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Myprofile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="myrights"></a>
# **Myrights**
> void Myrights (string token)

Gets the list of actions the user can execute.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyrightsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the list of actions the user can execute.
                apiInstance.Myrights(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Myrights: " + e.Message );
            }
        }
    }
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

<a name="mysaveprofile"></a>
# **Mysaveprofile**
> void Mysaveprofile (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Updates logged user's profile information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MysaveprofileExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Updates logged user's profile information
                apiInstance.Mysaveprofile(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Mysaveprofile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationdelete"></a>
# **Notificationdelete**
> void Notificationdelete (string token, Guid? id)

Delete a notification

Allows the user to delete an existing notification.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification to delete.

            try
            {
                // Delete a notification
                apiInstance.Notificationdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationget"></a>
# **Notificationget**
> void Notificationget (string token, Guid? id)

View a notification

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification to get.

            try
            {
                // View a notification
                apiInstance.Notificationget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationgetforstation"></a>
# **Notificationgetforstation**
> void Notificationgetforstation (Guid? station, string user)

Gets all public (in station) notifications for the specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationgetforstationExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets all public (in station) notifications for the specific user
                apiInstance.Notificationgetforstation(station, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationgetforstation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationgetunreadcount"></a>
# **Notificationgetunreadcount**
> void Notificationgetunreadcount (string token)

Get the number of unread notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationgetunreadcountExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Get the number of unread notifications
                apiInstance.Notificationgetunreadcount(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationgetunreadcount: " + e.Message );
            }
        }
    }
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

<a name="notificationlist"></a>
# **Notificationlist**
> void Notificationlist (string token, int? from, int? count, Guid? recipient, int? status, DateTime? startdate, DateTime? enddate, bool? sentonscreen, bool? sentemail, bool? sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var recipient = new Guid?(); // Guid? | The recipient whose notifications have to be listed. (optional) 
            var status = 56;  // int? | The status of the notifications to list. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 
            var sentonscreen = true;  // bool? | Specifies whether to list the notifications that were sent on-screen or not. (optional) 
            var sentemail = true;  // bool? | Specifies whether to list the notifications that were sent via e-mail or not. (optional) 
            var sentsms = true;  // bool? | Specifies whether to list the notifications that were sent via sms or not. (optional) 

            try
            {
                // View a list of all sent notifications
                apiInstance.Notificationlist(token, from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **recipient** | [**Guid?**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **int?**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **bool?**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **bool?**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **bool?**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationlistmine"></a>
# **Notificationlistmine**
> void Notificationlistmine (string token, int? from, int? count, int? status, DateTime? startdate, DateTime? enddate)

View all the notifications sent to the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationlistmineExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var status = 56;  // int? | Specifies the status of the notifications to list. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // View all the notifications sent to the current user
                apiInstance.Notificationlistmine(token, from, count, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationlistmine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **status** | **int?**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationmarkasread"></a>
# **Notificationmarkasread**
> void Notificationmarkasread (string token, Guid? id, int? status, DateTime? startdate, DateTime? enddate)

Mark a notification as read

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationmarkasreadExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. (optional) 
            var status = 56;  // int? | Specifies the status to filter the notifications. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // Mark a notification as read
                apiInstance.Notificationmarkasread(token, id, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationmarkasread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **int?**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationmarkasunread"></a>
# **Notificationmarkasunread**
> void Notificationmarkasunread (string token, Guid? id, int? status, DateTime? startdate, DateTime? enddate)

Mark a notification as unread

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationmarkasunreadExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. (optional) 
            var status = 56;  // int? | Specifies the status to filter the notifications. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // Mark a notification as unread
                apiInstance.Notificationmarkasunread(token, id, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationmarkasunread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **int?**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationsend"></a>
# **Notificationsend**
> void Notificationsend (string token, bool? emailenabled, bool? onscreenenabled, bool? smsenabled, string title, string tousers, string togroups, string onscreenbody, string onscreenclick, string onscreenurl, string onscreenclass, int? onscreenduration, int? showonstation, string emailfromname, string emailfrom, string emailsubject, string emailbody, string textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationsendExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var emailenabled = true;  // bool? | Whether send the notification via email.
            var onscreenenabled = true;  // bool? | Whether to display the notification on screen.
            var smsenabled = true;  // bool? | Whether to send the notification via text message.
            var title = title_example;  // string | Notification title.
            var tousers = tousers_example;  // string | Comma-separated Ids of users to send the notification. (optional) 
            var togroups = togroups_example;  // string | Comma-separated Ids of user groups to send the notification. (optional) 
            var onscreenbody = onscreenbody_example;  // string | Body of the message for on-screen display. (optional) 
            var onscreenclick = onscreenclick_example;  // string | What to do when the notification is clicked. Valid values: hide, view, url. (optional) 
            var onscreenurl = onscreenurl_example;  // string | Url to redirect the user, if onscreenclick=url. (optional) 
            var onscreenclass = onscreenclass_example;  // string | How to display the notification. Valid values: info, success, warning, error (optional) 
            var onscreenduration = 56;  // int? | Time in seconds to display the notification. (optional) 
            var showonstation = 56;  // int? | Whether to show the notification in the sign-in station. (optional) 
            var emailfromname = emailfromname_example;  // string | Name of the email sender. (optional) 
            var emailfrom = emailfrom_example;  // string | Reply-to email. (optional) 
            var emailsubject = emailsubject_example;  // string | Subject of the email. (optional) 
            var emailbody = emailbody_example;  // string | Body of the email. (optional) 
            var textmessagebody = textmessagebody_example;  // string | Message for SMS. Max 160 characters. (optional) 

            try
            {
                // Send notifications on screen, via email or text to users
                apiInstance.Notificationsend(token, emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationsend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **emailenabled** | **bool?**| Whether send the notification via email. | 
 **onscreenenabled** | **bool?**| Whether to display the notification on screen. | 
 **smsenabled** | **bool?**| Whether to send the notification via text message. | 
 **title** | **string**| Notification title. | 
 **tousers** | **string**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **string**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **string**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **string**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **string**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **string**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **int?**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **int?**| Whether to show the notification in the sign-in station. | [optional] 
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

<a name="notificationsendonscreen"></a>
# **Notificationsendonscreen**
> void Notificationsendonscreen (string token, Guid? notification)

Send on-screen notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationsendonscreenExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var notification = new Guid?(); // Guid? | The ID of the notification to send.

            try
            {
                // Send on-screen notifications
                apiInstance.Notificationsendonscreen(token, notification);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationsendonscreen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **notification** | [**Guid?**](.md)| The ID of the notification to send. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopicdelete"></a>
# **Notificationtopicdelete**
> void Notificationtopicdelete (string token, Guid? id)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification topic to delete.

            try
            {
                // Delete a notification topic
                apiInstance.Notificationtopicdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopicdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification topic to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopicget"></a>
# **Notificationtopicget**
> void Notificationtopicget (string token, Guid? id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the notification topic to get.

            try
            {
                // Search and view details of a notification topic
                apiInstance.Notificationtopicget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopicget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the notification topic to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopiclist"></a>
# **Notificationtopiclist**
> void Notificationtopiclist (string token, int? from, int? count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopiclistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // List all the notification topics
                apiInstance.Notificationtopiclist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopiclist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationtopiclistsubscribe"></a>
# **Notificationtopiclistsubscribe**
> void Notificationtopiclistsubscribe (string token)

List all the notification topics available to subscribe

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopiclistsubscribeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // List all the notification topics available to subscribe
                apiInstance.Notificationtopiclistsubscribe(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopiclistsubscribe: " + e.Message );
            }
        }
    }
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

<a name="notificationtopicsave"></a>
# **Notificationtopicsave**
> void Notificationtopicsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationtopicsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a notification topic
                apiInstance.Notificationtopicsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Notificationtopicsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pushderegister"></a>
# **Pushderegister**
> void Pushderegister (string devicetoken, string platform)

Deregisters the current device to receive push notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PushderegisterExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var devicetoken = devicetoken_example;  // string | The device token where to send the notification.
            var platform = platform_example;  // string | Either ios or android

            try
            {
                // Deregisters the current device to receive push notifications
                apiInstance.Pushderegister(devicetoken, platform);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Pushderegister: " + e.Message );
            }
        }
    }
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

<a name="pushregister"></a>
# **Pushregister**
> void Pushregister (string devicetoken, string platform)

Registers the current device to receive push notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PushregisterExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var devicetoken = devicetoken_example;  // string | The device token where to send the notification.
            var platform = platform_example;  // string | Either ios or android

            try
            {
                // Registers the current device to receive push notifications
                apiInstance.Pushregister(devicetoken, platform);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Pushregister: " + e.Message );
            }
        }
    }
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

<a name="qrlabelsprint"></a>
# **Qrlabelsprint**
> void Qrlabelsprint (string token, Guid? user, Guid? group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrlabelsprintExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var user = new Guid?(); // Guid? | The id of the user whose label needs to be printed. (optional) 
            var group = new Guid?(); // Guid? | The id of the group whose members' labels need to be printed. (optional) 

            try
            {
                // Print and email QR labels
                apiInstance.Qrlabelsprint(token, user, group);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Qrlabelsprint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **user** | [**Guid?**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**Guid?**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="qrloginget"></a>
# **Qrloginget**
> void Qrloginget (string token)

Gets an image of a QR token

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrlogingetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets an image of a QR token
                apiInstance.Qrloginget(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Qrloginget: " + e.Message );
            }
        }
    }
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

<a name="qrloginlogin"></a>
# **Qrloginlogin**
> void Qrloginlogin (string onetimetoken)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrloginloginExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var onetimetoken = onetimetoken_example;  // string | The token read from the QR code.

            try
            {
                // Login
                apiInstance.Qrloginlogin(onetimetoken);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Qrloginlogin: " + e.Message );
            }
        }
    }
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

<a name="quickpaneldeletewidget"></a>
# **Quickpaneldeletewidget**
> void Quickpaneldeletewidget (string token, Guid? id)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpaneldeletewidgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the widget.

            try
            {
                // Deletes a widget from the Quick Panel
                apiInstance.Quickpaneldeletewidget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpaneldeletewidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the widget. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelfetchwidget"></a>
# **Quickpanelfetchwidget**
> void Quickpanelfetchwidget (string token, Guid? widgetid)

Fetches the information for a specific widget.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelfetchwidgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var widgetid = new Guid?(); // Guid? | The ID of the data to fetch it's data.

            try
            {
                // Fetches the information for a specific widget.
                apiInstance.Quickpanelfetchwidget(token, widgetid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelfetchwidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **widgetid** | [**Guid?**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelgetwidget"></a>
# **Quickpanelgetwidget**
> void Quickpanelgetwidget (string token, Guid? id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelgetwidgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the widget to get.

            try
            {
                // View details of a widget included in the Quick Panel
                apiInstance.Quickpanelgetwidget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelgetwidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the widget to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quickpanelinit"></a>
# **Quickpanelinit**
> void Quickpanelinit (string token)

Returns the initial information required to show the quick panels

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelinitExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Returns the initial information required to show the quick panels
                apiInstance.Quickpanelinit(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelinit: " + e.Message );
            }
        }
    }
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

<a name="quickpanellistwidgets"></a>
# **Quickpanellistwidgets**
> void Quickpanellistwidgets (string token)

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanellistwidgetsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists all the widgets that are added in the Quick Panel
                apiInstance.Quickpanellistwidgets(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanellistwidgets: " + e.Message );
            }
        }
    }
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

<a name="quickpanellistwidgettypes"></a>
# **Quickpanellistwidgettypes**
> void Quickpanellistwidgettypes (string token)

Lists all the widget types available in the system

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanellistwidgettypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Lists all the widget types available in the system
                apiInstance.Quickpanellistwidgettypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanellistwidgettypes: " + e.Message );
            }
        }
    }
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

<a name="quickpanelreorderwidgets"></a>
# **Quickpanelreorderwidgets**
> void Quickpanelreorderwidgets (string token, string sectionname, string orderids)

Reorders the widgets and moves them to a specific column

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelreorderwidgetsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var sectionname = sectionname_example;  // string | The section name where to sort the widgets.
            var orderids = orderids_example;  // string | CSV list of the widgets to reorder.

            try
            {
                // Reorders the widgets and moves them to a specific column
                apiInstance.Quickpanelreorderwidgets(token, sectionname, orderids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelreorderwidgets: " + e.Message );
            }
        }
    }
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

<a name="quickpanelsavewidget"></a>
# **Quickpanelsavewidget**
> void Quickpanelsavewidget (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QuickpanelsavewidgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a widget for the Quick Panel
                apiInstance.Quickpanelsavewidget(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Quickpanelsavewidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportlist"></a>
# **Reportlist**
> void Reportlist (string token)

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of available reports
                apiInstance.Reportlist(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportlist: " + e.Message );
            }
        }
    }
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

<a name="reportpermissionsbyuser"></a>
# **Reportpermissionsbyuser**
> void Reportpermissionsbyuser (string token, string _params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportpermissionsbyuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 

            try
            {
                // Permissions by user report
                apiInstance.Reportpermissionsbyuser(token, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportpermissionsbyuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportprepare"></a>
# **Reportprepare**
> void Reportprepare (string token, string reportname, string _params, string repformat, Guid? fillgroupid, string groupby, Guid? refreshgroup, string filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportprepareExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var reportname = reportname_example;  // string | The name of the report to execute
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 
            var repformat = repformat_example;  // string | The format of the resulting report. Json, pdf, csv, ... (optional) 
            var fillgroupid = new Guid?(); // Guid? | If specified, the result is used to fill the group with the given ID (optional) 
            var groupby = groupby_example;  // string | How to group the records. In the format 'col1+col2|col3+col4 (optional) 
            var refreshgroup = new Guid?(); // Guid? | The ID of the group to check (and refresh) before processing the report. (optional) 
            var filtertext = filtertext_example;  // string | The user friendly text of the applied filters. (optional) 

            try
            {
                // Queries and loads the specified report, in background.
                apiInstance.Reportprepare(token, reportname, _params, repformat, fillgroupid, groupby, refreshgroup, filtertext);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportprepare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **string**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**Guid?**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **string**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**Guid?**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **string**| The user friendly text of the applied filters. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportquery"></a>
# **Reportquery**
> void Reportquery (string token, string reportname, string _params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReportqueryExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var reportname = reportname_example;  // string | The name of the report to execute
            var _params = _params_example;  // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3 (optional) 

            try
            {
                // Query and load a specified report
                apiInstance.Reportquery(token, reportname, _params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Reportquery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **reportname** | **string**| The name of the report to execute | 
 **_params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rolelist"></a>
# **Rolelist**
> void Rolelist (string token, string name)

Show a list of roles

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RolelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var name = name_example;  // string | Filter by name of the role. (optional) 

            try
            {
                // Show a list of roles
                apiInstance.Rolelist(token, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rolelist: " + e.Message );
            }
        }
    }
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

<a name="ruledelete"></a>
# **Ruledelete**
> void Ruledelete (string token, Guid? id)

Delete a rule

Allows the user to delete an existing rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RuledeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the rule to delete.

            try
            {
                // Delete a rule
                apiInstance.Ruledelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ruledelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the rule to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ruleget"></a>
# **Ruleget**
> void Ruleget (string token, Guid? id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the rule to get.

            try
            {
                // View details of a rule
                apiInstance.Ruleget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ruleget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the rule to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulegeteventtype"></a>
# **Rulegeteventtype**
> void Rulegeteventtype (string token, string _event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulegeteventtypeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var _event = _event_example;  // string | The name of the event to refresh.

            try
            {
                // View details of a rule event type
                apiInstance.Rulegeteventtype(token, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulegeteventtype: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **_event** | **string**| The name of the event to refresh. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulelist"></a>
# **Rulelist**
> void Rulelist (string token, int? from, int? count)

View a list of user rules

Allows the user to view the list of all rules.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of user rules
                apiInstance.Rulelist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulelistactions"></a>
# **Rulelistactions**
> void Rulelistactions (string token)

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulelistactionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of rule actions available
                apiInstance.Rulelistactions(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulelistactions: " + e.Message );
            }
        }
    }
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

<a name="rulelisteventtypes"></a>
# **Rulelisteventtypes**
> void Rulelisteventtypes (string token)

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulelisteventtypesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of rule event types
                apiInstance.Rulelisteventtypes(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulelisteventtypes: " + e.Message );
            }
        }
    }
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

<a name="rulelisthttprequests"></a>
# **Rulelisthttprequests**
> void Rulelisthttprequests (string token, int? from, int? count, bool? failed, int? status)

View all the http requests sent as a result of a rule

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulelisthttprequestsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var failed = true;  // bool? | If true only failed requests will be returned (optional) 
            var status = 56;  // int? | The http status to filter the requests (optional) 

            try
            {
                // View all the http requests sent as a result of a rule
                apiInstance.Rulelisthttprequests(token, from, count, failed, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulelisthttprequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **failed** | **bool?**| If true only failed requests will be returned | [optional] 
 **status** | **int?**| The http status to filter the requests | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rulesave"></a>
# **Rulesave**
> void Rulesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a rule

Allows the user to create or edit a rule.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a rule
                apiInstance.Rulesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Rulesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search"></a>
# **Search**
> void Search (string token, string query, int? page)

Search

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var query = query_example;  // string | The query to search for.
            var page = 56;  // int? | Current page to show, zero-based. (optional) 

            try
            {
                // Search
                apiInstance.Search(token, query, page);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | **string**| The query to search for. | 
 **page** | **int?**| Current page to show, zero-based. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchgetentities"></a>
# **Searchgetentities**
> void Searchgetentities (string token)

Get the information of the entities that can be searched

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchgetentitiesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Get the information of the entities that can be searched
                apiInstance.Searchgetentities(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Searchgetentities: " + e.Message );
            }
        }
    }
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

<a name="securityassesspermission"></a>
# **Securityassesspermission**
> void Securityassesspermission (string token, string commandname)

Returns the list of users for a specific permission

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityassesspermissionExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var commandname = commandname_example;  // string | Name of the action or command to get the roles.

            try
            {
                // Returns the list of users for a specific permission
                apiInstance.Securityassesspermission(token, commandname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Securityassesspermission: " + e.Message );
            }
        }
    }
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

<a name="securityassessrole"></a>
# **Securityassessrole**
> void Securityassessrole (string token, Guid? roleid)

Returns the list of permissions for a specific role

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityassessroleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var roleid = new Guid?(); // Guid? | Role ID to list the effective permissions.

            try
            {
                // Returns the list of permissions for a specific role
                apiInstance.Securityassessrole(token, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Securityassessrole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **roleid** | [**Guid?**](.md)| Role ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityassessscope"></a>
# **Securityassessscope**
> void Securityassessscope (string token, Guid? locationid)

Returns the list of users for a specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityassessscopeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var locationid = new Guid?(); // Guid? | Location ID to list the users with that scope. (optional) 

            try
            {
                // Returns the list of users for a specific user
                apiInstance.Securityassessscope(token, locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Securityassessscope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **locationid** | [**Guid?**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityassessuser"></a>
# **Securityassessuser**
> void Securityassessuser (string token, Guid? userid)

Returns the list of permissions for a specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityassessuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | User ID to list the effective permissions.

            try
            {
                // Returns the list of permissions for a specific user
                apiInstance.Securityassessuser(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Securityassessuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| User ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregaddcurrentuser"></a>
# **Sessionregaddcurrentuser**
> void Sessionregaddcurrentuser (string token, Guid? eventid, DateTime? sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregaddcurrentuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Register current user to an event session
                apiInstance.Sessionregaddcurrentuser(token, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregaddcurrentuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregadduser"></a>
# **Sessionregadduser**
> void Sessionregadduser (string token, Guid? userid, Guid? eventid, DateTime? sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregadduserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Register users for events
                apiInstance.Sessionregadduser(token, userid, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregadduser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetmysessions"></a>
# **Sessionreggetmysessions**
> void Sessionreggetmysessions (string token, DateTime? date)

View all the sessions the logged user is registered to

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreggetmysessionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date to filter the sessions. (optional) 

            try
            {
                // View all the sessions the logged user is registered to
                apiInstance.Sessionreggetmysessions(token, date);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreggetmysessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime?**| Start date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetsessions"></a>
# **Sessionreggetsessions**
> void Sessionreggetsessions (string token, Guid? userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreggetsessionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The user id to list sessions.

            try
            {
                // Lists the registrations for a specific user
                apiInstance.Sessionreggetsessions(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreggetsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The user id to list sessions. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetsettings"></a>
# **Sessionreggetsettings**
> void Sessionreggetsettings (string token, Guid? locationid, Guid? eventid, DateTime? sessiondate, bool? noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreggetsettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var locationid = new Guid?(); // Guid? | The id of the location to save settings. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to save settings. (optional) 
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts. (optional) 
            var noinherit = true;  // bool? | True to get the location/event/session specific settings without looking for the more global settings. (optional) 

            try
            {
                // Get the settings for session registration
                apiInstance.Sessionreggetsettings(token, locationid, eventid, sessiondate, noinherit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreggetsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **locationid** | [**Guid?**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | [optional] 
 **noinherit** | **bool?**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetusers"></a>
# **Sessionreggetusers**
> void Sessionreggetusers (string token, Guid? eventid, DateTime? sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreggetusersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The event id to list sessions.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date of the session to find.

            try
            {
                // Lists the registrations for a specific session
                apiInstance.Sessionreggetusers(token, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreggetusers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime?**| The date of the session to find. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistsessions"></a>
# **Sessionreglistsessions**
> void Sessionreglistsessions (string token, Guid? eventid, DateTime? sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreglistsessionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The event id to list sessions.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date of the session to find. (optional) 

            try
            {
                // List the sessions available for a specific event
                apiInstance.Sessionreglistsessions(token, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreglistsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime?**| The date of the session to find. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistupcoming"></a>
# **Sessionreglistupcoming**
> void Sessionreglistupcoming (string token, DateTime? date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreglistupcomingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Only sessions in the week of the specified date will be returned.

            try
            {
                // View a list of upcoming event sessions
                apiInstance.Sessionreglistupcoming(token, date);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreglistupcoming: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime?**| Only sessions in the week of the specified date will be returned. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistupcomingevent"></a>
# **Sessionreglistupcomingevent**
> void Sessionreglistupcomingevent (string token, DateTime? date, Guid? _event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionreglistupcomingeventExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date to filter the returned sessions.
            var _event = new Guid?(); // Guid? | The id of the event whose sessions will be returned

            try
            {
                // View a list of upcoming sessions of a particular event
                apiInstance.Sessionreglistupcomingevent(token, date, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionreglistupcomingevent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **date** | **DateTime?**| Start date to filter the returned sessions. | 
 **_event** | [**Guid?**](.md)| The id of the event whose sessions will be returned | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregremovecurrentuser"></a>
# **Sessionregremovecurrentuser**
> void Sessionregremovecurrentuser (string token, Guid? eventid, DateTime? sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregremovecurrentuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Unregister current user from an event session
                apiInstance.Sessionregremovecurrentuser(token, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregremovecurrentuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregremoveuser"></a>
# **Sessionregremoveuser**
> void Sessionregremoveuser (string token, Guid? userid, Guid? eventid, DateTime? sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregremoveuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Removes a user from an event session
                apiInstance.Sessionregremoveuser(token, userid, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregremoveuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregsavesettings"></a>
# **Sessionregsavesettings**
> void Sessionregsavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregsavesettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save the settings for an event's session registration
                apiInstance.Sessionregsavesettings(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Sessionregsavesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settingaddlogo"></a>
# **Settingaddlogo**
> void Settingaddlogo (string token, string upload, string filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingaddlogoExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The original filename, needed to process the file.

            try
            {
                // Add a logo to the account
                apiInstance.Settingaddlogo(token, upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Settingaddlogo: " + e.Message );
            }
        }
    }
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

<a name="settingget"></a>
# **Settingget**
> void Settingget (string keys, string token, string domain, string scope)

Get settings for the account or the specified scope

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettinggetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var keys = keys_example;  // string | The option keys to get values for. Enter multiple separated by comma.
            var token = token_example;  // string | The authentication token. (optional) 
            var domain = domain_example;  // string | The account domain, in case of reading settings annonymously. (optional) 
            var scope = scope_example;  // string | The scope of the settings to get. (optional) 

            try
            {
                // Get settings for the account or the specified scope
                apiInstance.Settingget(keys, token, domain, scope);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Settingget: " + e.Message );
            }
        }
    }
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

<a name="settingsave"></a>
# **Settingsave**
> void Settingsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save settings for the account or the specified scope
                apiInstance.Settingsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Settingsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settingviewgeneral"></a>
# **Settingviewgeneral**
> void Settingviewgeneral (string token)

View general settings for the account

Allows the user to view the settings' general section.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingviewgeneralExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View general settings for the account
                apiInstance.Settingviewgeneral(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Settingviewgeneral: " + e.Message );
            }
        }
    }
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

<a name="ssogeneratekey"></a>
# **Ssogeneratekey**
> void Ssogeneratekey (string token)

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsogeneratekeyExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Generate/reset single sign on access key.
                apiInstance.Ssogeneratekey(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ssogeneratekey: " + e.Message );
            }
        }
    }
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

<a name="ssogetsettings"></a>
# **Ssogetsettings**
> void Ssogetsettings (string token)

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsogetsettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View single sign on settings.
                apiInstance.Ssogetsettings(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ssogetsettings: " + e.Message );
            }
        }
    }
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

<a name="ssoissuetoken"></a>
# **Ssoissuetoken**
> void Ssoissuetoken (string key, string username, bool? expires)

Issue single sign-on token

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsoissuetokenExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var key = key_example;  // string | The single sign-on key of the account.
            var username = username_example;  // string | The email of the user to sign-on.
            var expires = true;  // bool? | Specifies whether the session should expire when inactive. (optional) 

            try
            {
                // Issue single sign-on token
                apiInstance.Ssoissuetoken(key, username, expires);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ssoissuetoken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The single sign-on key of the account. | 
 **username** | **string**| The email of the user to sign-on. | 
 **expires** | **bool?**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssosavesettings"></a>
# **Ssosavesettings**
> void Ssosavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsosavesettingsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Edit single sign-on settings.
                apiInstance.Ssosavesettings(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Ssosavesettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationdelete"></a>
# **Stationdelete**
> void Stationdelete (string token, Guid? id)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the sign-in station to delete.

            try
            {
                // Delete a sign-in station
                apiInstance.Stationdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the sign-in station to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationget"></a>
# **Stationget**
> void Stationget (string token, Guid? id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the sign-in station to get.

            try
            {
                // View details of a sign-in station
                apiInstance.Stationget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the sign-in station to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetcurrentterms"></a>
# **Stationgetcurrentterms**
> void Stationgetcurrentterms (Guid? station)

Get all the current terms

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetcurrenttermsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station whose account's current terms have to be retrieved.

            try
            {
                // Get all the current terms
                apiInstance.Stationgetcurrentterms(station);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationgetcurrentterms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetinfo"></a>
# **Stationgetinfo**
> void Stationgetinfo (Guid? id, Guid? _event)

Gets a the info to display in the sign-in station by it's ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetinfoExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to get.
            var _event = new Guid?(); // Guid? | The id of the event, to override the one by schedule. (optional) 

            try
            {
                // Gets a the info to display in the sign-in station by it's ID.
                apiInstance.Stationgetinfo(id, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationgetinfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **_event** | [**Guid?**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetlicense"></a>
# **Stationgetlicense**
> void Stationgetlicense (string station)

Gets the current license information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationgetlicenseExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var station = station_example;  // string | The id of the sign-in station whose account's license has to be retrieved.

            try
            {
                // Gets the current license information
                apiInstance.Stationgetlicense(station);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationgetlicense: " + e.Message );
            }
        }
    }
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

<a name="stationlist"></a>
# **Stationlist**
> void Stationlist (string token, int? from, int? count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of sign-in stations
                apiInstance.Stationlist(token, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationsave"></a>
# **Stationsave**
> void Stationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a sign-in station
                apiInstance.Stationsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationunlock"></a>
# **Stationunlock**
> void Stationunlock (Guid? id, string passcode, string method)

Unlocks the sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationunlockExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to unlock.
            var passcode = passcode_example;  // string | The passcode to unlock the station.
            var method = method_example;  // string | The authentication method. Valid values are 'token' and 'cookie'.

            try
            {
                // Unlocks the sign-in station.
                apiInstance.Stationunlock(id, passcode, method);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Stationunlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to unlock. | 
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

<a name="swipedelete"></a>
# **Swipedelete**
> void Swipedelete (string token, Guid? id)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the swipe to delete.

            try
            {
                // Delete a swipe
                apiInstance.Swipedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the swipe to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swipeget"></a>
# **Swipeget**
> void Swipeget (string token, Guid? id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipegetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the swipe to get.

            try
            {
                // Search and view details of a swipe
                apiInstance.Swipeget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipeget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swipelist"></a>
# **Swipelist**
> void Swipelist (int? from, int? count, string token)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var token = token_example;  // string | The authentication token. (optional) 

            try
            {
                // View a list of swipes
                apiInstance.Swipelist(from, count, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **token** | **string**| The authentication token. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swipesave"></a>
# **Swipesave**
> void Swipesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a swipe, and if possible, save the related attendance log
                apiInstance.Swipesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swipesaveanonym"></a>
# **Swipesaveanonym**
> void Swipesaveanonym (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwipesaveanonymExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Creates a new swipe from a sign-in station, and if possible, creates the attendance log
                apiInstance.Swipesaveanonym(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Swipesaveanonym: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagdelete"></a>
# **Tagdelete**
> void Tagdelete (string token, Guid? id)

Delete a tag

Allows the user to delete an existing tag.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TagdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the tag to delete.

            try
            {
                // Delete a tag
                apiInstance.Tagdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Tagdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the tag to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagget"></a>
# **Tagget**
> void Tagget (string token, Guid? id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaggetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the tag to get.

            try
            {
                // View details of a specified tag
                apiInstance.Tagget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Tagget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the tag to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taglist"></a>
# **Taglist**
> void Taglist (string token, string group, int? from, int? count)

View a list of tags

Allows the user to view the list of tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaglistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var group = group_example;  // string | The group of the tags to return.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of tags
                apiInstance.Taglist(token, group, from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Taglist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | **string**| The group of the tags to return. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taglistgroups"></a>
# **Taglistgroups**
> void Taglistgroups (string token)

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaglistgroupsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // View a list of entities that can be tagged
                apiInstance.Taglistgroups(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Taglistgroups: " + e.Message );
            }
        }
    }
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

<a name="tagsave"></a>
# **Tagsave**
> void Tagsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a tag

Allows the user to create or edit a tag.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TagsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a tag
                apiInstance.Tagsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Tagsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsearch"></a>
# **Tagsearch**
> void Tagsearch (string token, string query, bool? allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TagsearchExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var query = query_example;  // string | The query to search tags. Use group:<group> to search in a specific group (mandatory).
            var allowcreatingnew = true;  // bool? | Specifies whether an option to create a new tag should be retrieved. (optional) 

            try
            {
                // Search for tags in the account
                apiInstance.Tagsearch(token, query, allowcreatingnew);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Tagsearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **query** | **string**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **allowcreatingnew** | **bool?**| Specifies whether an option to create a new tag should be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateaddimage"></a>
# **Templateaddimage**
> void Templateaddimage (string token, Guid? template, string upload, string filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateaddimageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var template = new Guid?(); // Guid? | The id of the template where the image has to be added
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 

            try
            {
                // Add an image to a template
                apiInstance.Templateaddimage(token, template, upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templateaddimage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **template** | [**Guid?**](.md)| The id of the template where the image has to be added | 
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

<a name="templatedelete"></a>
# **Templatedelete**
> void Templatedelete (string token, Guid? id)

Delete a template

Allows the user to delete an existing template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatedeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the template to delete.

            try
            {
                // Delete a template
                apiInstance.Templatedelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatedelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the template to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateemail"></a>
# **Templateemail**
> void Templateemail (string token, string jobid, string emailsubject, string emailbody, string templatekind, string emailfrom, string emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplateemailExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var jobid = jobid_example;  // string | The id of the job that is creating the templates.
            var emailsubject = emailsubject_example;  // string | Args depending on the send-to flag.
            var emailbody = emailbody_example;  // string | Args depending on the send-to flag.
            var templatekind = templatekind_example;  // string | The kind of the template you're sending. It must be included in (badge, certificate). (optional) 
            var emailfrom = emailfrom_example;  // string | The name of the sender to be displayed in the receipients inbox (optional) 
            var emailreplyto = emailreplyto_example;  // string | The reply-to field for the emails. (optional) 

            try
            {
                // Send generated templates by email
                apiInstance.Templateemail(token, jobid, emailsubject, emailbody, templatekind, emailfrom, emailreplyto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templateemail: " + e.Message );
            }
        }
    }
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

<a name="templategenerate"></a>
# **Templategenerate**
> void Templategenerate (string token, Guid? template, Guid? source, bool? singlefile, string userid, bool? forsending, Guid? role, string filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplategenerateExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var template = new Guid?(); // Guid? | The id of the template to generate.
            var source = new Guid?(); // Guid? | The source key of the selected template data source.
            var singlefile = true;  // bool? | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
            var userid = userid_example;  // string | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas. (optional) 
            var forsending = true;  // bool? | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading (optional) 
            var role = new Guid?(); // Guid? | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor (optional) 
            var filters = filters_example;  // string | Pipe separated filters for the generation, eg: aaa=val|bbb=val|... (optional) 

            try
            {
                // Generate specified templates
                apiInstance.Templategenerate(token, template, source, singlefile, userid, forsending, role, filters);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templategenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **template** | [**Guid?**](.md)| The id of the template to generate. | 
 **source** | [**Guid?**](.md)| The source key of the selected template data source. | 
 **singlefile** | **bool?**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **string**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **bool?**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**Guid?**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **string**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templateget"></a>
# **Templateget**
> void Templateget (string token, Guid? id)

View details of a template

Allows the user to view a template and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplategetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the template to get.

            try
            {
                // View details of a template
                apiInstance.Templateget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templateget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the template to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templategetgenerated"></a>
# **Templategetgenerated**
> void Templategetgenerated (string token, string jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplategetgeneratedExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var jobid = jobid_example;  // string | The id of the job that is creating the templates.

            try
            {
                // View generated templates
                apiInstance.Templategetgenerated(token, jobid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templategetgenerated: " + e.Message );
            }
        }
    }
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

<a name="templatelist"></a>
# **Templatelist**
> void Templatelist (string token, int? from, int? count, string kind, bool? designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatelistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var kind = kind_example;  // string | The kind of the templates to return. It must be included in (badge, certificate).
            var designedonly = true;  // bool? | If true then it only returns the templates that were designed. Otherwise, it returns all. (optional) 

            try
            {
                // View a list of defined templates
                apiInstance.Templatelist(token, from, count, kind, designedonly);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatelist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **bool?**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatelistsources"></a>
# **Templatelistsources**
> void Templatelistsources (string token, string kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatelistsourcesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var kind = kind_example;  // string | The kind of the templates to return. It must be included in (badge, certificate).

            try
            {
                // View a list of templates' data sources
                apiInstance.Templatelistsources(token, kind);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatelistsources: " + e.Message );
            }
        }
    }
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

<a name="templatesave"></a>
# **Templatesave**
> void Templatesave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a template

Allows the user to create or edit a template.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatesaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a template
                apiInstance.Templatesave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatesave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesavelayout"></a>
# **Templatesavelayout**
> void Templatesavelayout (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save the layout of a template

Allows the user to edit a template's layout.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemplatesavelayoutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save the layout of a template
                apiInstance.Templatesavelayout(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Templatesavelayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termdelete"></a>
# **Termdelete**
> void Termdelete (string token, Guid? id)

Delete a term

Allows the user to delete a term from the existing list.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the term to delete.

            try
            {
                // Delete a term
                apiInstance.Termdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Termdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the term to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termget"></a>
# **Termget**
> void Termget (string token, Guid? id)

Search and view details of a term

Allows the user to view a term and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the term to get.

            try
            {
                // Search and view details of a term
                apiInstance.Termget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Termget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the term to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termlist"></a>
# **Termlist**
> void Termlist (string token, int? from, int? count, bool? notpast)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 
            var notpast = true;  // bool? | Specifies whether the terms in the past should be returned or not. (optional) 

            try
            {
                // Search and view details of all terms
                apiInstance.Termlist(token, from, count, notpast);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Termlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | [optional] 
 **count** | **int?**| The max number of records to return. | [optional] 
 **notpast** | **bool?**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="termsave"></a>
# **Termsave**
> void Termsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create and edit terms

Allows the user to create and edit terms.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TermsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create and edit terms
                apiInstance.Termsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Termsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="textcreditremaining"></a>
# **Textcreditremaining**
> void Textcreditremaining (string token)

Gets the remaining text credits for the account

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TextcreditremainingExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Gets the remaining text credits for the account
                apiInstance.Textcreditremaining(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Textcreditremaining: " + e.Message );
            }
        }
    }
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

<a name="texttoimage"></a>
# **Texttoimage**
> void Texttoimage (string token, string text, string fontcolor, int? fontsize, string direction, int? width)

Generates a dynamic image from text

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TexttoimageExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var text = text_example;  // string | The text to convert to an image, use double pipes (||) as a new line.
            var fontcolor = fontcolor_example;  // string | The color of the text, in hex format, without the #. (optional) 
            var fontsize = 56;  // int? | The size of the text, in points. (optional) 
            var direction = direction_example;  // string | Either vertical or horizontal, default horizontal. (optional) 
            var width = 56;  // int? | The image width in pixels (or height if the direction is vertical). (optional) 

            try
            {
                // Generates a dynamic image from text
                apiInstance.Texttoimage(token, text, fontcolor, fontsize, direction, width);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Texttoimage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **text** | **string**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **string**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **int?**| The size of the text, in points. | [optional] 
 **direction** | **string**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **int?**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translationget"></a>
# **Translationget**
> void Translationget (string token, string universal)

Gets the translations of the specified values

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var universal = universal_example;  // string | Pipe separated list of universal text to be translated.

            try
            {
                // Gets the translations of the specified values
                apiInstance.Translationget(token, universal);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Translationget: " + e.Message );
            }
        }
    }
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

<a name="translationgetcachefile"></a>
# **Translationgetcachefile**
> void Translationgetcachefile (string token, string account)

Get the file containing the translations

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationgetcachefileExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token. (optional) 
            var account = account_example;  // string | The id of the account whose translations file has to be retrieved. (optional) 

            try
            {
                // Get the file containing the translations
                apiInstance.Translationgetcachefile(token, account);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Translationgetcachefile: " + e.Message );
            }
        }
    }
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

<a name="translationlist"></a>
# **Translationlist**
> void Translationlist (string token, string filter, bool? nondefaultonly, bool? appdefaultasuniversal)

Lists all the available translations in the system

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var filter = filter_example;  // string | Text to search/filter translations. (optional) 
            var nondefaultonly = true;  // bool? | If true then it returns only the terms translated. Otherwise, it returns all. (optional) 
            var appdefaultasuniversal = true;  // bool? | If true then it uses the app default translation as the universal term. (optional) 

            try
            {
                // Lists all the available translations in the system
                apiInstance.Translationlist(token, filter, nondefaultonly, appdefaultasuniversal);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Translationlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **filter** | **string**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **bool?**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **bool?**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translationsave"></a>
# **Translationsave**
> void Translationsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Edit a translation
                apiInstance.Translationsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Translationsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userchangepwd"></a>
# **Userchangepwd**
> void Userchangepwd (string token, Guid? oldpass, Guid? newpass)

Change user's own password

Allows the user to change their own password.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserchangepwdExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var oldpass = new Guid?(); // Guid? | The old password of the authenticated user.
            var newpass = new Guid?(); // Guid? | The new password of the authenticated user.

            try
            {
                // Change user's own password
                apiInstance.Userchangepwd(token, oldpass, newpass);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userchangepwd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **oldpass** | [**Guid?**](.md)| The old password of the authenticated user. | 
 **newpass** | [**Guid?**](.md)| The new password of the authenticated user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userchangepwdbyreq"></a>
# **Userchangepwdbyreq**
> void Userchangepwdbyreq (string changereq, string newpass)

Changes the user password using a change password request id

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserchangepwdbyreqExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var changereq = changereq_example;  // string | The change password request ID sent by email to the user.
            var newpass = newpass_example;  // string | The new password of the user.

            try
            {
                // Changes the user password using a change password request id
                apiInstance.Userchangepwdbyreq(changereq, newpass);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userchangepwdbyreq: " + e.Message );
            }
        }
    }
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

<a name="userdelete"></a>
# **Userdelete**
> void Userdelete (string token, Guid? id)

Delete a user

Allows the user to delete a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the user to delete.

            try
            {
                // Delete a user
                apiInstance.Userdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the user to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userfindsimilar"></a>
# **Userfindsimilar**
> void Userfindsimilar (string token, Guid? currentid, string phonenumber, string cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserfindsimilarExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var currentid = new Guid?(); // Guid? | The id of the current user. (optional) 
            var phonenumber = phonenumber_example;  // string | A phone number to search for similar users. (optional) 
            var cardnumber = cardnumber_example;  // string | A card number to search for similar users. (optional) 

            try
            {
                // Finds similar users to prevent duplicates
                apiInstance.Userfindsimilar(token, currentid, phonenumber, cardnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userfindsimilar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **currentid** | [**Guid?**](.md)| The id of the current user. | [optional] 
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

<a name="userget"></a>
# **Userget**
> void Userget (string token, Guid? id, int? photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the user to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Search and view details of a user
                apiInstance.Userget(token, id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the user to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetbycard"></a>
# **Usergetbycard**
> void Usergetbycard (string token, string card, int? photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergetbycardExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var card = card_example;  // string | The card number of the user to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Search user by card number
                apiInstance.Usergetbycard(token, card, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergetbycard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **card** | **string**| The card number of the user to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupaddmember"></a>
# **Usergroupaddmember**
> void Usergroupaddmember (string token, Guid? userid, Guid? groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupaddmemberExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var groupid = new Guid?(); // Guid? | The id of the group.

            try
            {
                // Add a user to a group
                apiInstance.Usergroupaddmember(token, userid, groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupaddmember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **groupid** | [**Guid?**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupdelete"></a>
# **Usergroupdelete**
> void Usergroupdelete (string token, Guid? id)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupdeleteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the group to delete.

            try
            {
                // Delete a group
                apiInstance.Usergroupdelete(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupdelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the group to delete. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupget"></a>
# **Usergroupget**
> void Usergroupget (string token, Guid? id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var id = new Guid?(); // Guid? | The id of the user group to get.

            try
            {
                // Search and view details of a user group
                apiInstance.Usergroupget(token, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **id** | [**Guid?**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupgetmembers"></a>
# **Usergroupgetmembers**
> void Usergroupgetmembers (string token, Guid? groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupgetmembersExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var groupid = new Guid?(); // Guid? | The id of the user group to get.

            try
            {
                // View the members of a user group
                apiInstance.Usergroupgetmembers(token, groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupgetmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **groupid** | [**Guid?**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupgetuser"></a>
# **Usergroupgetuser**
> void Usergroupgetuser (string token, Guid? userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupgetuserExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to get his groups.

            try
            {
                // View the groups which a user is registered to
                apiInstance.Usergroupgetuser(token, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupgetuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to get his groups. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergrouplist"></a>
# **Usergrouplist**
> void Usergrouplist (string token, int? from, int? count, string type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergrouplistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 
            var type = type_example;  // string | The type of the groups to return. Either 'user', 'dynamic' or any other type of group. (optional) 

            try
            {
                // View a list of user groups
                apiInstance.Usergrouplist(token, from, count, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergrouplist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | [optional] 
 **count** | **int?**| The max number of records to return. | [optional] 
 **type** | **string**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergrouprefresh"></a>
# **Usergrouprefresh**
> void Usergrouprefresh (string token, Guid? group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergrouprefreshExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var group = new Guid?(); // Guid? | The ID of the group to refresh.

            try
            {
                // Refresh the dynamic group
                apiInstance.Usergrouprefresh(token, group);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergrouprefresh: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **group** | [**Guid?**](.md)| The ID of the group to refresh. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupremovemember"></a>
# **Usergroupremovemember**
> void Usergroupremovemember (string token, Guid? userid, Guid? groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupremovememberExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var groupid = new Guid?(); // Guid? | The id of the group.

            try
            {
                // Remove a user from a group
                apiInstance.Usergroupremovemember(token, userid, groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupremovemember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **groupid** | [**Guid?**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupsave"></a>
# **Usergroupsave**
> void Usergroupsave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupsaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a group
                apiInstance.Usergroupsave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usergroupsave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userlist"></a>
# **Userlist**
> void Userlist (string token, int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserlistExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var roleid = new Guid?(); // Guid? | The id of the role to filter users by, or empty to return all users. (optional) 
            var onlywithoutcard = onlywithoutcard_example;  // string | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View a list of users
                apiInstance.Userlist(token, from, count, roleid, onlywithoutcard, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userlist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **roleid** | [**Guid?**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userloadphoto"></a>
# **Userloadphoto**
> void Userloadphoto (string token, string upload, string filename, Guid? userid, bool? automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserloadphotoExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 
            var userid = new Guid?(); // Guid? | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'. (optional) 
            var automatch = true;  // bool? | Set this to true to find the specific user based on the file name.  (optional) 

            try
            {
                // Upload a photo for a specific user
                apiInstance.Userloadphoto(token, upload, filename, userid, automatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userloadphoto: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**Guid?**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **bool?**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usermovedata"></a>
# **Usermovedata**
> void Usermovedata (string token, Guid? source, Guid? destination)

Move data between users

Allows administrators to move data between users.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsermovedataExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var source = new Guid?(); // Guid? | The id of the user that is the source of the data.
            var destination = new Guid?(); // Guid? | The id of the user that is the destination of the data.

            try
            {
                // Move data between users
                apiInstance.Usermovedata(token, source, destination);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usermovedata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **source** | [**Guid?**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**Guid?**](.md)| The id of the user that is the destination of the data. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userrequestpwdchange"></a>
# **Userrequestpwdchange**
> void Userrequestpwdchange (string domain, string email)

Requests a password change

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserrequestpwdchangeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var domain = domain_example;  // string | The domain of the account where the user exists.
            var email = email_example;  // string | The email of the user.

            try
            {
                // Requests a password change
                apiInstance.Userrequestpwdchange(domain, email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Userrequestpwdchange: " + e.Message );
            }
        }
    }
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

<a name="usersave"></a>
# **Usersave**
> void Usersave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a user

Allows the user to create or edit a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a user
                apiInstance.Usersave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersavepwdchange"></a>
# **Usersavepwdchange**
> void Usersavepwdchange (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersavepwdchangeExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Send email to the specified user(s) to set/change their passwords
                apiInstance.Usersavepwdchange(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersavepwdchange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsget"></a>
# **Usersettingsget**
> void Usersettingsget (string token, string keys, Guid? user)

Lists available user settings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingsgetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var keys = keys_example;  // string | Setting key to get. Can be multiple separated by commas.
            var user = new Guid?(); // Guid? | The user id whose settings have to be returned. (optional) 

            try
            {
                // Lists available user settings
                apiInstance.Usersettingsget(token, keys, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersettingsget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**Guid?**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsgetmultiple"></a>
# **Usersettingsgetmultiple**
> void Usersettingsgetmultiple (string token, string keys, Guid? user)

Get multiple user settings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingsgetmultipleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.
            var keys = keys_example;  // string | Setting key to get. Can be multiple separated by commas.
            var user = new Guid?(); // Guid? | The user id whose settings have to be returned. (optional) 

            try
            {
                // Get multiple user settings
                apiInstance.Usersettingsgetmultiple(token, keys, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersettingsgetmultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The authentication token. | 
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**Guid?**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingssave"></a>
# **Usersettingssave**
> void Usersettingssave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a user setting

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingssaveExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a user setting
                apiInstance.Usersettingssave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersettingssave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingssavemultiple"></a>
# **Usersettingssavemultiple**
> void Usersettingssavemultiple (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save multiple user settings at once

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingssavemultipleExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save multiple user settings at once
                apiInstance.Usersettingssavemultiple(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Usersettingssavemultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="version"></a>
# **Version**
> void Version (string token)

Get current version information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VersionExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var token = token_example;  // string | The authentication token.

            try
            {
                // Get current version information
                apiInstance.Version(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.Version: " + e.Message );
            }
        }
    }
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

