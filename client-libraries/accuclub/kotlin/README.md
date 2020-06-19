# org.openapitools.client - Kotlin client library for AccuClub OpenAPI 3

## Requires

* Kotlin 1.3.41
* Gradle 4.9

## Build

First, create the gradle wrapper script:

```
gradle wrapper
```

Then, run:

```
./gradlew check assemble
```

This runs all tests and packages the library.

## Features/Implementation Notes

* Supports JSON inputs/outputs, File inputs, and Form inputs.
* Supports collection formats for query parameters: csv, tsv, ssv, pipes.
* Some Kotlin and Java types are fully qualified to avoid conflicts with types defined in OpenAPI definitions.
* Implementation of ApiClient is intended to reduce method counts, specifically to benefit Android targets.

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://accuclub.net:443/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ActionlogApi* | [**actionlogList**](docs/ActionlogApi.md#actionloglist) | **GET** /actionlog/list | View a list of users action logs
*AdvroleApi* | [**advroleAddmissing**](docs/AdvroleApi.md#advroleaddmissing) | **GET** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
*AdvroleApi* | [**advroleCheckperm**](docs/AdvroleApi.md#advrolecheckperm) | **GET** /advrole/checkperm | Checks the permissions are assigned for the given roles
*AdvroleApi* | [**advroleDelete**](docs/AdvroleApi.md#advroledelete) | **DELETE** /advrole/{id} | Delete a role
*AdvroleApi* | [**advroleDeletemapping**](docs/AdvroleApi.md#advroledeletemapping) | **DELETE** /advrole/deletemapping | Delete a role mapping
*AdvroleApi* | [**advroleGet**](docs/AdvroleApi.md#advroleget) | **GET** /advrole/{id} | View details of a role
*AdvroleApi* | [**advroleList**](docs/AdvroleApi.md#advrolelist) | **GET** /advrole/list | Lists the roles for the current account
*AdvroleApi* | [**advroleListmaps**](docs/AdvroleApi.md#advrolelistmaps) | **GET** /advrole/listmaps | Lists the maps a roles is mapped to
*AdvroleApi* | [**advroleListrolesmapped**](docs/AdvroleApi.md#advrolelistrolesmapped) | **GET** /advrole/listrolesmapped | Lists the roles mappings
*AdvroleApi* | [**advroleListtemplates**](docs/AdvroleApi.md#advrolelisttemplates) | **GET** /advrole/listtemplates | View a list of role templates
*AdvroleApi* | [**advroleSave**](docs/AdvroleApi.md#advrolesave) | **POST** /advrole/{id} | Create or edit a role
*AdvroleApi* | [**advroleSavemapping**](docs/AdvroleApi.md#advrolesavemapping) | **POST** /advrole/savemapping | Saves a role mapping
*AdvroleApi* | [**advroleUserupgrade**](docs/AdvroleApi.md#advroleuserupgrade) | **GET** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)
*AdvrolesApi* | [**advrolesUserlist**](docs/AdvrolesApi.md#advrolesuserlist) | **GET** /advroles/userlist | List users. Alias to user.list, use that one instead.
*AppshareApi* | [**appshareGetphone**](docs/AppshareApi.md#appsharegetphone) | **GET** /appshare/getphone | Gets the phone number of the current user
*AppshareApi* | [**appshareSendtext**](docs/AppshareApi.md#appsharesendtext) | **GET** /appshare/sendtext | Sends an SMS with the link to the app
*AttendancelogApi* | [**attendancelogDelete**](docs/AttendancelogApi.md#attendancelogdelete) | **DELETE** /attendancelog/{id} | Delete an attendance log
*AttendancelogApi* | [**attendancelogGet**](docs/AttendancelogApi.md#attendancelogget) | **GET** /attendancelog/{id} | Search and view details of an attendance log
*AttendancelogApi* | [**attendancelogGetchangehistory**](docs/AttendancelogApi.md#attendanceloggetchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log's swipe history
*AttendancelogApi* | [**attendancelogList**](docs/AttendancelogApi.md#attendanceloglist) | **GET** /attendancelog/list | View a list of attendance logs
*AttendancelogApi* | [**attendancelogListmine**](docs/AttendancelogApi.md#attendanceloglistmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
*AttendancelogApi* | [**attendancelogSave**](docs/AttendancelogApi.md#attendancelogsave) | **POST** /attendancelog/{id} | Create or edit an attendance log
*AttendancelogApi* | [**attendancelogSignout**](docs/AttendancelogApi.md#attendancelogsignout) | **GET** /attendancelog/signout | Sign out an attendance log
*AttendancelogApi* | [**attendancelogWhosin**](docs/AttendancelogApi.md#attendancelogwhosin) | **GET** /attendancelog/whosin | View who's in a location
*AttendancelogcommentApi* | [**attendancelogcommentDelete**](docs/AttendancelogcommentApi.md#attendancelogcommentdelete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
*AttendancelogcommentApi* | [**attendancelogcommentGet**](docs/AttendancelogcommentApi.md#attendancelogcommentget) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
*AttendancelogcommentApi* | [**attendancelogcommentList**](docs/AttendancelogcommentApi.md#attendancelogcommentlist) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
*AttendancelogcommentApi* | [**attendancelogcommentSave**](docs/AttendancelogcommentApi.md#attendancelogcommentsave) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log
*BgjobApi* | [**bgjobGetstatus**](docs/BgjobApi.md#bgjobgetstatus) | **GET** /bgjob/getstatus | Get background job status
*CaptchaApi* | [**captchaGetchallenge**](docs/CaptchaApi.md#captchagetchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
*CaptchaApi* | [**captchaGetimage**](docs/CaptchaApi.md#captchagetimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.
*ClientApi* | [**clientGet**](docs/ClientApi.md#clientget) | **GET** /client/get | Get client
*ClientApi* | [**clientList**](docs/ClientApi.md#clientlist) | **GET** /client/list | Gets the clients of the specified conference
*ClientApi* | [**clientSave**](docs/ClientApi.md#clientsave) | **POST** /client/save | Saves a client
*ClientApi* | [**clientSendmessage**](docs/ClientApi.md#clientsendmessage) | **GET** /client/sendmessage | Send a message to a client
*CreditApi* | [**creditDelete**](docs/CreditApi.md#creditdelete) | **DELETE** /credit/{id} | Delete a credit
*CreditApi* | [**creditDiscountmethods**](docs/CreditApi.md#creditdiscountmethods) | **GET** /credit/discountmethods | Gets the valid discount methods.
*CreditApi* | [**creditGet**](docs/CreditApi.md#creditget) | **GET** /credit/{id} | View details of assigned credit
*CreditApi* | [**creditGetuserbalance**](docs/CreditApi.md#creditgetuserbalance) | **GET** /credit/getuserbalance | Get the total amount of credits of the specified user
*CreditApi* | [**creditList**](docs/CreditApi.md#creditlist) | **GET** /credit/list | View a list of credits for a specific user
*CreditApi* | [**creditListdetails**](docs/CreditApi.md#creditlistdetails) | **GET** /credit/listdetails | Gets the credit usage details
*CreditApi* | [**creditListmine**](docs/CreditApi.md#creditlistmine) | **GET** /credit/listmine | View the list of credits of the current user
*CreditApi* | [**creditSave**](docs/CreditApi.md#creditsave) | **POST** /credit/{id} | Create or edit credit for a user
*CreditApi* | [**creditSavedetails**](docs/CreditApi.md#creditsavedetails) | **POST** /credit/savedetails | Create or edit credit details
*CreditplanApi* | [**creditplanDelete**](docs/CreditplanApi.md#creditplandelete) | **DELETE** /creditplan/{id} | Deletes a credit plan
*CreditplanApi* | [**creditplanGet**](docs/CreditplanApi.md#creditplanget) | **GET** /creditplan/{id} | Gets a credit plan
*CreditplanApi* | [**creditplanList**](docs/CreditplanApi.md#creditplanlist) | **GET** /creditplan/list | Gets the credit plans available
*CreditplanApi* | [**creditplanSave**](docs/CreditplanApi.md#creditplansave) | **POST** /creditplan/{id} | Saves a credit plan
*EasyloginApi* | [**easyloginAddbgimage**](docs/EasyloginApi.md#easyloginaddbgimage) | **GET** /easylogin/addbgimage | Adds background image for the login
*EventApi* | [**eventDelete**](docs/EventApi.md#eventdelete) | **DELETE** /event/{id} | Delete a course
*EventApi* | [**eventGet**](docs/EventApi.md#eventget) | **GET** /event/{id} | Search and view details of a course
*EventApi* | [**eventGetsessionsbydate**](docs/EventApi.md#eventgetsessionsbydate) | **GET** /event/getsessionsbydate | View a list of courses by date
*EventApi* | [**eventList**](docs/EventApi.md#eventlist) | **GET** /event/list | View a list of courses
*EventApi* | [**eventSave**](docs/EventApi.md#eventsave) | **POST** /event/{id} | Create or edit a course
*EventApi* | [**eventSearchgroup**](docs/EventApi.md#eventsearchgroup) | **GET** /event/searchgroup | Searches for the available event groups
*ExportApi* | [**exportListtypes**](docs/ExportApi.md#exportlisttypes) | **GET** /export/listtypes | Lists available export types
*FeatureApi* | [**featureList**](docs/FeatureApi.md#featurelist) | **GET** /feature/list | Lists the available features.
*GeneralApi* | [**changelog**](docs/GeneralApi.md#changelog) | **GET** /changelog | Get the application change log
*GeneralApi* | [**doc**](docs/GeneralApi.md#doc) | **GET** /doc | Get the documentation
*GeneralApi* | [**export**](docs/GeneralApi.md#export) | **GET** /export | Export AccuClub data
*GeneralApi* | [**import**](docs/GeneralApi.md#import) | **GET** /import | Import data into AccuClub
*GeneralApi* | [**listtimezones**](docs/GeneralApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
*GeneralApi* | [**login**](docs/GeneralApi.md#login) | **GET** /login | Login
*GeneralApi* | [**logout**](docs/GeneralApi.md#logout) | **GET** /logout | Logout
*GeneralApi* | [**search**](docs/GeneralApi.md#search) | **GET** /search | Search
*GeneralApi* | [**texttoimage**](docs/GeneralApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
*GeneralApi* | [**version**](docs/GeneralApi.md#version) | **GET** /version | Get current version information
*HolidayApi* | [**holidayList**](docs/HolidayApi.md#holidaylist) | **GET** /holiday/list | View a list of entered holidays
*HolidayApi* | [**holidaySave**](docs/HolidayApi.md#holidaysave) | **POST** /holiday/save | Create or edit a list of holidays
*HolidayApi* | [**holidaySuggest**](docs/HolidayApi.md#holidaysuggest) | **GET** /holiday/suggest | View the holiday suggestions in the given term
*ImportApi* | [**importListtypes**](docs/ImportApi.md#importlisttypes) | **GET** /import/listtypes | Lists available import types
*LicenseApi* | [**licenseAcceptagreement**](docs/LicenseApi.md#licenseacceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
*LicenseApi* | [**licenseGetagreementstatus**](docs/LicenseApi.md#licensegetagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
*LicenseApi* | [**licenseGetcurrent**](docs/LicenseApi.md#licensegetcurrent) | **GET** /license/getcurrent | Gets the current license information
*LicenseApi* | [**licenseRenew**](docs/LicenseApi.md#licenserenew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuClub subscription
*LocationApi* | [**locationDelete**](docs/LocationApi.md#locationdelete) | **DELETE** /location/{id} | Delete a location
*LocationApi* | [**locationGet**](docs/LocationApi.md#locationget) | **GET** /location/{id} | Search and view details of a location
*LocationApi* | [**locationList**](docs/LocationApi.md#locationlist) | **GET** /location/list | View a list of locations
*LocationApi* | [**locationSave**](docs/LocationApi.md#locationsave) | **POST** /location/{id} | Create or edit a location
*MemorizedreportApi* | [**memorizedreportDelete**](docs/MemorizedreportApi.md#memorizedreportdelete) | **DELETE** /memorizedreport/{id} | Delete memorized report
*MemorizedreportApi* | [**memorizedreportGet**](docs/MemorizedreportApi.md#memorizedreportget) | **GET** /memorizedreport/{id} | View details of a memorized report
*MemorizedreportApi* | [**memorizedreportList**](docs/MemorizedreportApi.md#memorizedreportlist) | **GET** /memorizedreport/list | View a list of all his memorized reports
*MemorizedreportApi* | [**memorizedreportSave**](docs/MemorizedreportApi.md#memorizedreportsave) | **POST** /memorizedreport/{id} | Create or edit a memorized report
*MenuApi* | [**menuGetitems**](docs/MenuApi.md#menugetitems) | **GET** /menu/getitems | Gets the items on the menu
*MyApi* | [**myAccount**](docs/MyApi.md#myaccount) | **GET** /my/account | Gets the logged in user account.
*MyApi* | [**myIanatimezone**](docs/MyApi.md#myianatimezone) | **GET** /my/ianatimezone | Gets the current time zone's iana name
*MyApi* | [**myProfile**](docs/MyApi.md#myprofile) | **GET** /my/profile | Gets the logged in user information.
*MyApi* | [**myRights**](docs/MyApi.md#myrights) | **GET** /my/rights | Gets the list of actions the user can execute.
*MyApi* | [**mySaveprofile**](docs/MyApi.md#mysaveprofile) | **POST** /my/saveprofile | Updates logged user's profile information
*NotificationApi* | [**notificationDelete**](docs/NotificationApi.md#notificationdelete) | **DELETE** /notification/{id} | Delete a notification
*NotificationApi* | [**notificationGet**](docs/NotificationApi.md#notificationget) | **GET** /notification/{id} | View a notification
*NotificationApi* | [**notificationGetforstation**](docs/NotificationApi.md#notificationgetforstation) | **GET** /notification/getforstation | Gets all public (in station) notifications for the specific user
*NotificationApi* | [**notificationGetunreadcount**](docs/NotificationApi.md#notificationgetunreadcount) | **GET** /notification/getunreadcount | Get the number of unread notifications
*NotificationApi* | [**notificationList**](docs/NotificationApi.md#notificationlist) | **GET** /notification/list | View a list of all sent notifications
*NotificationApi* | [**notificationListmine**](docs/NotificationApi.md#notificationlistmine) | **GET** /notification/listmine | View all the notifications sent to the current user
*NotificationApi* | [**notificationMarkasread**](docs/NotificationApi.md#notificationmarkasread) | **GET** /notification/markasread | Mark a notification as read
*NotificationApi* | [**notificationMarkasunread**](docs/NotificationApi.md#notificationmarkasunread) | **GET** /notification/markasunread | Mark a notification as unread
*NotificationApi* | [**notificationSend**](docs/NotificationApi.md#notificationsend) | **GET** /notification/send | Send notifications on screen, via email or text to users
*NotificationApi* | [**notificationSendonscreen**](docs/NotificationApi.md#notificationsendonscreen) | **GET** /notification/sendonscreen | Send on-screen notifications
*NotificationtopicApi* | [**notificationtopicDelete**](docs/NotificationtopicApi.md#notificationtopicdelete) | **DELETE** /notificationtopic/{id} | Delete a notification topic
*NotificationtopicApi* | [**notificationtopicGet**](docs/NotificationtopicApi.md#notificationtopicget) | **GET** /notificationtopic/{id} | Search and view details of a notification topic
*NotificationtopicApi* | [**notificationtopicList**](docs/NotificationtopicApi.md#notificationtopiclist) | **GET** /notificationtopic/list | List all the notification topics
*NotificationtopicApi* | [**notificationtopicListsubscribe**](docs/NotificationtopicApi.md#notificationtopiclistsubscribe) | **GET** /notificationtopic/listsubscribe | List all the notification topics available to subscribe
*NotificationtopicApi* | [**notificationtopicSave**](docs/NotificationtopicApi.md#notificationtopicsave) | **POST** /notificationtopic/{id} | Create or edit a notification topic
*PushApi* | [**pushDeregister**](docs/PushApi.md#pushderegister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
*PushApi* | [**pushRegister**](docs/PushApi.md#pushregister) | **GET** /push/register | Registers the current device to receive push notifications
*QrlabelsApi* | [**qrlabelsPrint**](docs/QrlabelsApi.md#qrlabelsprint) | **GET** /qrlabels/print | Print and email QR labels
*QrloginApi* | [**qrloginGet**](docs/QrloginApi.md#qrloginget) | **GET** /qrlogin/get | Gets an image of a QR token
*QrloginApi* | [**qrloginLogin**](docs/QrloginApi.md#qrloginlogin) | **GET** /qrlogin/login | Login
*QuickpanelApi* | [**quickpanelDeletewidget**](docs/QuickpanelApi.md#quickpaneldeletewidget) | **DELETE** /quickpanel/deletewidget | Deletes a widget from the Quick Panel
*QuickpanelApi* | [**quickpanelFetchwidget**](docs/QuickpanelApi.md#quickpanelfetchwidget) | **GET** /quickpanel/fetchwidget | Fetches the information for a specific widget.
*QuickpanelApi* | [**quickpanelGetwidget**](docs/QuickpanelApi.md#quickpanelgetwidget) | **GET** /quickpanel/getwidget | View details of a widget included in the Quick Panel
*QuickpanelApi* | [**quickpanelInit**](docs/QuickpanelApi.md#quickpanelinit) | **GET** /quickpanel/init | Returns the initial information required to show the quick panels
*QuickpanelApi* | [**quickpanelListwidgets**](docs/QuickpanelApi.md#quickpanellistwidgets) | **GET** /quickpanel/listwidgets | Lists all the widgets that are added in the Quick Panel
*QuickpanelApi* | [**quickpanelListwidgettypes**](docs/QuickpanelApi.md#quickpanellistwidgettypes) | **GET** /quickpanel/listwidgettypes | Lists all the widget types available in the system
*QuickpanelApi* | [**quickpanelReorderwidgets**](docs/QuickpanelApi.md#quickpanelreorderwidgets) | **GET** /quickpanel/reorderwidgets | Reorders the widgets and moves them to a specific column
*QuickpanelApi* | [**quickpanelSavewidget**](docs/QuickpanelApi.md#quickpanelsavewidget) | **POST** /quickpanel/savewidget | Saves a widget for the Quick Panel
*ReportApi* | [**reportList**](docs/ReportApi.md#reportlist) | **GET** /report/list | View a list of available reports
*ReportApi* | [**reportPermissionsbyuser**](docs/ReportApi.md#reportpermissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
*ReportApi* | [**reportPrepare**](docs/ReportApi.md#reportprepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
*ReportApi* | [**reportQuery**](docs/ReportApi.md#reportquery) | **GET** /report/query | Query and load a specified report
*RoleApi* | [**roleList**](docs/RoleApi.md#rolelist) | **GET** /role/list | Show a list of roles
*RuleApi* | [**ruleDelete**](docs/RuleApi.md#ruledelete) | **DELETE** /rule/{id} | Delete a rule
*RuleApi* | [**ruleGet**](docs/RuleApi.md#ruleget) | **GET** /rule/{id} | View details of a rule
*RuleApi* | [**ruleGeteventtype**](docs/RuleApi.md#rulegeteventtype) | **GET** /rule/geteventtype | View details of a rule event type
*RuleApi* | [**ruleList**](docs/RuleApi.md#rulelist) | **GET** /rule/list | View a list of user rules
*RuleApi* | [**ruleListactions**](docs/RuleApi.md#rulelistactions) | **GET** /rule/listactions | View a list of rule actions available
*RuleApi* | [**ruleListeventtypes**](docs/RuleApi.md#rulelisteventtypes) | **GET** /rule/listeventtypes | View a list of rule event types
*RuleApi* | [**ruleListhttprequests**](docs/RuleApi.md#rulelisthttprequests) | **GET** /rule/listhttprequests | View all the http requests sent as a result of a rule
*RuleApi* | [**ruleSave**](docs/RuleApi.md#rulesave) | **POST** /rule/{id} | Create or edit a rule
*SearchApi* | [**searchGetentities**](docs/SearchApi.md#searchgetentities) | **GET** /search/getentities | Get the information of the entities that can be searched
*SecurityApi* | [**securityAssesspermission**](docs/SecurityApi.md#securityassesspermission) | **GET** /security/assesspermission | Returns the list of users for a specific permission
*SecurityApi* | [**securityAssessrole**](docs/SecurityApi.md#securityassessrole) | **GET** /security/assessrole | Returns the list of permissions for a specific role
*SecurityApi* | [**securityAssessscope**](docs/SecurityApi.md#securityassessscope) | **GET** /security/assessscope | Returns the list of users for a specific user
*SecurityApi* | [**securityAssessuser**](docs/SecurityApi.md#securityassessuser) | **GET** /security/assessuser | Returns the list of permissions for a specific user
*SessionregApi* | [**sessionregAddcurrentuser**](docs/SessionregApi.md#sessionregaddcurrentuser) | **GET** /sessionreg/addcurrentuser | Register current user to an event session
*SessionregApi* | [**sessionregAdduser**](docs/SessionregApi.md#sessionregadduser) | **GET** /sessionreg/adduser | Register users for events
*SessionregApi* | [**sessionregGetmysessions**](docs/SessionregApi.md#sessionreggetmysessions) | **GET** /sessionreg/getmysessions | View all the sessions the logged user is registered to
*SessionregApi* | [**sessionregGetsessions**](docs/SessionregApi.md#sessionreggetsessions) | **GET** /sessionreg/getsessions | Lists the registrations for a specific user
*SessionregApi* | [**sessionregGetsettings**](docs/SessionregApi.md#sessionreggetsettings) | **GET** /sessionreg/getsettings | Get the settings for session registration
*SessionregApi* | [**sessionregGetusers**](docs/SessionregApi.md#sessionreggetusers) | **GET** /sessionreg/getusers | Lists the registrations for a specific session
*SessionregApi* | [**sessionregListsessions**](docs/SessionregApi.md#sessionreglistsessions) | **GET** /sessionreg/listsessions | List the sessions available for a specific event
*SessionregApi* | [**sessionregListupcoming**](docs/SessionregApi.md#sessionreglistupcoming) | **GET** /sessionreg/listupcoming | View a list of upcoming event sessions
*SessionregApi* | [**sessionregListupcomingevent**](docs/SessionregApi.md#sessionreglistupcomingevent) | **GET** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
*SessionregApi* | [**sessionregRemovecurrentuser**](docs/SessionregApi.md#sessionregremovecurrentuser) | **GET** /sessionreg/removecurrentuser | Unregister current user from an event session
*SessionregApi* | [**sessionregRemoveuser**](docs/SessionregApi.md#sessionregremoveuser) | **GET** /sessionreg/removeuser | Removes a user from an event session
*SessionregApi* | [**sessionregSavesettings**](docs/SessionregApi.md#sessionregsavesettings) | **POST** /sessionreg/savesettings | Save the settings for an event's session registration
*SettingApi* | [**settingAddlogo**](docs/SettingApi.md#settingaddlogo) | **GET** /setting/addlogo | Add a logo to the account
*SettingApi* | [**settingGet**](docs/SettingApi.md#settingget) | **GET** /setting/get | Get settings for the account or the specified scope
*SettingApi* | [**settingSave**](docs/SettingApi.md#settingsave) | **POST** /setting/save | Save settings for the account or the specified scope
*SettingApi* | [**settingViewgeneral**](docs/SettingApi.md#settingviewgeneral) | **GET** /setting/viewgeneral | View general settings for the account
*SsoApi* | [**ssoGeneratekey**](docs/SsoApi.md#ssogeneratekey) | **GET** /sso/generatekey | Generate/reset single sign on access key.
*SsoApi* | [**ssoGetsettings**](docs/SsoApi.md#ssogetsettings) | **GET** /sso/getsettings | View single sign on settings.
*SsoApi* | [**ssoIssuetoken**](docs/SsoApi.md#ssoissuetoken) | **GET** /sso/issuetoken | Issue single sign-on token
*SsoApi* | [**ssoSavesettings**](docs/SsoApi.md#ssosavesettings) | **POST** /sso/savesettings | Edit single sign-on settings.
*StationApi* | [**stationDelete**](docs/StationApi.md#stationdelete) | **DELETE** /station/{id} | Delete a sign-in station
*StationApi* | [**stationGet**](docs/StationApi.md#stationget) | **GET** /station/{id} | View details of a sign-in station
*StationApi* | [**stationGetcurrentterms**](docs/StationApi.md#stationgetcurrentterms) | **GET** /station/getcurrentterms | Get all the current terms
*StationApi* | [**stationGetinfo**](docs/StationApi.md#stationgetinfo) | **GET** /station/getinfo | Gets a the info to display in the sign-in station by it's ID.
*StationApi* | [**stationGetlicense**](docs/StationApi.md#stationgetlicense) | **GET** /station/getlicense | Gets the current license information
*StationApi* | [**stationList**](docs/StationApi.md#stationlist) | **GET** /station/list | View a list of sign-in stations
*StationApi* | [**stationSave**](docs/StationApi.md#stationsave) | **POST** /station/{id} | Create or edit a sign-in station
*StationApi* | [**stationUnlock**](docs/StationApi.md#stationunlock) | **GET** /station/unlock | Unlocks the sign-in station.
*SwipeApi* | [**swipeDelete**](docs/SwipeApi.md#swipedelete) | **DELETE** /swipe/{id} | Delete a swipe
*SwipeApi* | [**swipeGet**](docs/SwipeApi.md#swipeget) | **GET** /swipe/{id} | Search and view details of a swipe
*SwipeApi* | [**swipeList**](docs/SwipeApi.md#swipelist) | **GET** /swipe/list | View a list of swipes
*SwipeApi* | [**swipeSave**](docs/SwipeApi.md#swipesave) | **POST** /swipe/save | Create or edit a swipe, and if possible, save the related attendance log
*SwipeApi* | [**swipeSaveanonym**](docs/SwipeApi.md#swipesaveanonym) | **POST** /swipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log
*TagApi* | [**tagDelete**](docs/TagApi.md#tagdelete) | **DELETE** /tag/{id} | Delete a tag
*TagApi* | [**tagGet**](docs/TagApi.md#tagget) | **GET** /tag/{id} | View details of a specified tag
*TagApi* | [**tagList**](docs/TagApi.md#taglist) | **GET** /tag/list | View a list of tags
*TagApi* | [**tagListgroups**](docs/TagApi.md#taglistgroups) | **GET** /tag/listgroups | View a list of entities that can be tagged
*TagApi* | [**tagSave**](docs/TagApi.md#tagsave) | **POST** /tag/{id} | Create or edit a tag
*TagApi* | [**tagSearch**](docs/TagApi.md#tagsearch) | **GET** /tag/search | Search for tags in the account
*TemplateApi* | [**templateAddimage**](docs/TemplateApi.md#templateaddimage) | **GET** /template/addimage | Add an image to a template
*TemplateApi* | [**templateDelete**](docs/TemplateApi.md#templatedelete) | **DELETE** /template/{id} | Delete a template
*TemplateApi* | [**templateEmail**](docs/TemplateApi.md#templateemail) | **GET** /template/email | Send generated templates by email
*TemplateApi* | [**templateGenerate**](docs/TemplateApi.md#templategenerate) | **GET** /template/generate | Generate specified templates
*TemplateApi* | [**templateGet**](docs/TemplateApi.md#templateget) | **GET** /template/{id} | View details of a template
*TemplateApi* | [**templateGetgenerated**](docs/TemplateApi.md#templategetgenerated) | **GET** /template/getgenerated | View generated templates
*TemplateApi* | [**templateList**](docs/TemplateApi.md#templatelist) | **GET** /template/list | View a list of defined templates
*TemplateApi* | [**templateListsources**](docs/TemplateApi.md#templatelistsources) | **GET** /template/listsources | View a list of templates' data sources
*TemplateApi* | [**templateSave**](docs/TemplateApi.md#templatesave) | **POST** /template/{id} | Create or edit a template
*TemplateApi* | [**templateSavelayout**](docs/TemplateApi.md#templatesavelayout) | **POST** /template/savelayout | Save the layout of a template
*TermApi* | [**termDelete**](docs/TermApi.md#termdelete) | **DELETE** /term/{id} | Delete a term
*TermApi* | [**termGet**](docs/TermApi.md#termget) | **GET** /term/{id} | Search and view details of a term
*TermApi* | [**termList**](docs/TermApi.md#termlist) | **GET** /term/list | Search and view details of all terms
*TermApi* | [**termSave**](docs/TermApi.md#termsave) | **POST** /term/{id} | Create and edit terms
*TextcreditApi* | [**textcreditRemaining**](docs/TextcreditApi.md#textcreditremaining) | **GET** /textcredit/remaining | Gets the remaining text credits for the account
*TranslationApi* | [**translationGet**](docs/TranslationApi.md#translationget) | **GET** /translation/get | Gets the translations of the specified values
*TranslationApi* | [**translationGetcachefile**](docs/TranslationApi.md#translationgetcachefile) | **GET** /translation/getcachefile | Get the file containing the translations
*TranslationApi* | [**translationList**](docs/TranslationApi.md#translationlist) | **GET** /translation/list | Lists all the available translations in the system
*TranslationApi* | [**translationSave**](docs/TranslationApi.md#translationsave) | **POST** /translation/{id} | Edit a translation
*UserApi* | [**userChangepwd**](docs/UserApi.md#userchangepwd) | **GET** /user/changepwd | Change user's own password
*UserApi* | [**userChangepwdbyreq**](docs/UserApi.md#userchangepwdbyreq) | **GET** /user/changepwdbyreq | Changes the user password using a change password request id
*UserApi* | [**userDelete**](docs/UserApi.md#userdelete) | **DELETE** /user/{id} | Delete a user
*UserApi* | [**userFindsimilar**](docs/UserApi.md#userfindsimilar) | **GET** /user/findsimilar | Finds similar users to prevent duplicates
*UserApi* | [**userGet**](docs/UserApi.md#userget) | **GET** /user/{id} | Search and view details of a user
*UserApi* | [**userGetbycard**](docs/UserApi.md#usergetbycard) | **GET** /user/getbycard | Search user by card number
*UserApi* | [**userList**](docs/UserApi.md#userlist) | **GET** /user/list | View a list of users
*UserApi* | [**userLoadphoto**](docs/UserApi.md#userloadphoto) | **GET** /user/loadphoto | Upload a photo for a specific user
*UserApi* | [**userMovedata**](docs/UserApi.md#usermovedata) | **GET** /user/movedata | Move data between users
*UserApi* | [**userRequestpwdchange**](docs/UserApi.md#userrequestpwdchange) | **GET** /user/requestpwdchange | Requests a password change
*UserApi* | [**userSave**](docs/UserApi.md#usersave) | **POST** /user/{id} | Create or edit a user
*UserApi* | [**userSavepwdchange**](docs/UserApi.md#usersavepwdchange) | **POST** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords
*UsergroupApi* | [**usergroupAddmember**](docs/UsergroupApi.md#usergroupaddmember) | **GET** /usergroup/addmember | Add a user to a group
*UsergroupApi* | [**usergroupDelete**](docs/UsergroupApi.md#usergroupdelete) | **DELETE** /usergroup/{id} | Delete a group
*UsergroupApi* | [**usergroupGet**](docs/UsergroupApi.md#usergroupget) | **GET** /usergroup/{id} | Search and view details of a user group
*UsergroupApi* | [**usergroupGetmembers**](docs/UsergroupApi.md#usergroupgetmembers) | **GET** /usergroup/getmembers | View the members of a user group
*UsergroupApi* | [**usergroupGetuser**](docs/UsergroupApi.md#usergroupgetuser) | **GET** /usergroup/getuser | View the groups which a user is registered to
*UsergroupApi* | [**usergroupList**](docs/UsergroupApi.md#usergrouplist) | **GET** /usergroup/list | View a list of user groups
*UsergroupApi* | [**usergroupRefresh**](docs/UsergroupApi.md#usergrouprefresh) | **GET** /usergroup/refresh | Refresh the dynamic group
*UsergroupApi* | [**usergroupRemovemember**](docs/UsergroupApi.md#usergroupremovemember) | **GET** /usergroup/removemember | Remove a user from a group
*UsergroupApi* | [**usergroupSave**](docs/UsergroupApi.md#usergroupsave) | **POST** /usergroup/{id} | Create or edit a group
*UsersettingsApi* | [**usersettingsGet**](docs/UsersettingsApi.md#usersettingsget) | **GET** /usersettings/get | Lists available user settings
*UsersettingsApi* | [**usersettingsGetmultiple**](docs/UsersettingsApi.md#usersettingsgetmultiple) | **GET** /usersettings/getmultiple | Get multiple user settings
*UsersettingsApi* | [**usersettingsSave**](docs/UsersettingsApi.md#usersettingssave) | **POST** /usersettings/save | Saves a user setting
*UsersettingsApi* | [**usersettingsSavemultiple**](docs/UsersettingsApi.md#usersettingssavemultiple) | **POST** /usersettings/savemultiple | Save multiple user settings at once


<a name="documentation-for-models"></a>
## Documentation for Models

 - [org.openapitools.client.models.ActionResult](docs/ActionResult.md)
 - [org.openapitools.client.models.ErrorActionResult](docs/ErrorActionResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearerAuth"></a>
### bearerAuth

- **Type**: HTTP basic authentication

