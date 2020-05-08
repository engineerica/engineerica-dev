#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// View a list of users action logs
//
// Allows the user to view the audit logs for the account.
//
void
DefaultAPI_actionloglist(apiClient_t *apiClient, char * token , int from , int count , char * user , char startdate , char enddate , char * resource , char * actionfilter , char * argument );


// Adds the missing permissions to a role. Requires access to advrole.save
//
void
DefaultAPI_advroleaddmissing(apiClient_t *apiClient, char * token , char * roles , char * permissions );


// Checks the permissions are assigned for the given roles
//
void
DefaultAPI_advrolecheckperm(apiClient_t *apiClient, char * token , char * roles , char * permissions );


// Delete a role
//
// Allows the user to delete a role from the list of available roles.
//
void
DefaultAPI_advroledelete(apiClient_t *apiClient, char * token , char * id );


// Delete a role mapping
//
// Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.
//
void
DefaultAPI_advroledeletemapping(apiClient_t *apiClient, char * token , char * map , char * roleid );


// View details of a role
//
// Allows the user to view a role and its details.
//
void
DefaultAPI_advroleget(apiClient_t *apiClient, char * token , char * id );


// Lists the roles for the current account
//
void
DefaultAPI_advrolelist(apiClient_t *apiClient, char * token , int includepolicies , int includeinternal , char * name );


// Lists the maps a roles is mapped to
//
void
DefaultAPI_advrolelistmaps(apiClient_t *apiClient, char * token , char * roleid );


// Lists the roles mappings
//
void
DefaultAPI_advrolelistrolesmapped(apiClient_t *apiClient, char * token , char * map );


// View a list of role templates
//
// Allows the user to view the full list of available role templates.
//
void
DefaultAPI_advrolelisttemplates(apiClient_t *apiClient, char * token );


// Create or edit a role
//
// Allows the user to create or edit a role's permissions.
//
void
DefaultAPI_advrolesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Saves a role mapping
//
// Allows the user to add a role to a mapped category on the 'Role Mapping' page.
//
void
DefaultAPI_advrolesavemapping(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// List users. Alias to user.list, use that one instead.
//
void
DefaultAPI_advrolesuserlist(apiClient_t *apiClient, char * token , int from , int count , char * roleid , char * onlywithoutcard , int photosize );


// Upgrade a user to another role (requires permission to edit those roles)
//
// Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
//
void
DefaultAPI_advroleuserupgrade(apiClient_t *apiClient, char * token , char * userid , char * roleid );


// Gets the phone number of the current user
//
void
DefaultAPI_appsharegetphone(apiClient_t *apiClient, char * token );


// Sends an SMS with the link to the app
//
void
DefaultAPI_appsharesendtext(apiClient_t *apiClient, char * token , char * phonenumber );


// Delete a comment on an attendance log
//
void
DefaultAPI_attendancelogcommentdelete(apiClient_t *apiClient, char * token , char * id );


// View a comment on an attendance log
//
void
DefaultAPI_attendancelogcommentget(apiClient_t *apiClient, char * token , char * id );


// View all the comments on a specific attendance log
//
void
DefaultAPI_attendancelogcommentlist(apiClient_t *apiClient, char * attendancelog , char * token );


// Save a comment on an attendance log
//
void
DefaultAPI_attendancelogcommentsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete an attendance log
//
// Allows the user to delete an existing attendance log.
//
void
DefaultAPI_attendancelogdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of an attendance log
//
// Allows the user to view an individual attendance log and its details.
//
void
DefaultAPI_attendancelogget(apiClient_t *apiClient, char * token , char * id );


// Search and view details of an attendance log's swipe history
//
// Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).
//
void
DefaultAPI_attendanceloggetchangehistory(apiClient_t *apiClient, char * token , char * id );


// View a list of attendance logs
//
// Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.
//
void
DefaultAPI_attendanceloglist(apiClient_t *apiClient, int from , int count , char * token , char * filter , char * userid );


// Gets the attendance logs of the current user
//
void
DefaultAPI_attendanceloglistmine(apiClient_t *apiClient, int from , int count , char * token , char * filter );


// Create or edit an attendance log
//
// Allows the user to create or edit an attendance log.
//
void
DefaultAPI_attendancelogsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Sign out an attendance log
//
// Allows the user to sign out am attendance log from the Who's In page.
//
void
DefaultAPI_attendancelogsignout(apiClient_t *apiClient, char * token , char * id , char * location , char * event , char datetime );


// View who's in a location
//
// Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.
//
void
DefaultAPI_attendancelogwhosin(apiClient_t *apiClient, int from , int count , char * token , char * location , char * event , char * sorting , char * roles , int photosize , char * extensions , int export );


// Get background job status
//
void
DefaultAPI_bgjobgetstatus(apiClient_t *apiClient, char * token , char * jobid , char * jobtype );


// Gets a captcha challenge that the user must complete to do certain requests.
//
void
DefaultAPI_captchagetchallenge(apiClient_t *apiClient);


// Gets a captcha image that the user must complete to do certain requests.
//
void
DefaultAPI_captchagetimage(apiClient_t *apiClient, char * captchatoken );


// Get the application change log
//
void
DefaultAPI_changelog(apiClient_t *apiClient, char * token );


// Get client
//
void
DefaultAPI_clientget(apiClient_t *apiClient, char * token , char * client , char * clientname );


// Gets the clients of the specified conference
//
void
DefaultAPI_clientlist(apiClient_t *apiClient, char * token , int from , int count );


// Saves a client
//
void
DefaultAPI_clientsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Send a message to a client
//
void
DefaultAPI_clientsendmessage(apiClient_t *apiClient, char * token , char * uniqueclientid , char * message );


// Delete a credit
//
// Allows the user to delete credits.
//
void
DefaultAPI_creditdelete(apiClient_t *apiClient, char * token , char * id );


// Gets the valid discount methods.
//
void
DefaultAPI_creditdiscountmethods(apiClient_t *apiClient);


// View details of assigned credit
//
// Allows the user to view an credit and its details.
//
void
DefaultAPI_creditget(apiClient_t *apiClient, char * token , char * id );


// Get the total amount of credits of the specified user
//
// Allows the user to view the total amount of credits of a specified user.
//
void
DefaultAPI_creditgetuserbalance(apiClient_t *apiClient, char * token , char * user );


// View a list of credits for a specific user
//
// Allows the user to view the full list of credits for a user.
//
void
DefaultAPI_creditlist(apiClient_t *apiClient, char * token , char * user , int from , int count );


// Gets the credit usage details
//
void
DefaultAPI_creditlistdetails(apiClient_t *apiClient, char * token , char * credit , int from , int count );


// View the list of credits of the current user
//
// Allows the current user to view his full list of credits.
//
void
DefaultAPI_creditlistmine(apiClient_t *apiClient, char * token , int from , int count );


// Deletes a credit plan
//
void
DefaultAPI_creditplandelete(apiClient_t *apiClient, char * token , char * id );


// Gets a credit plan
//
void
DefaultAPI_creditplanget(apiClient_t *apiClient, char * token , char * id );


// Gets the credit plans available
//
void
DefaultAPI_creditplanlist(apiClient_t *apiClient, char * token , int from , int count );


// Saves a credit plan
//
void
DefaultAPI_creditplansave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Create or edit credit for a user
//
// Allows the user to create or edit credit for a user
//
void
DefaultAPI_creditsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Create or edit credit details
//
void
DefaultAPI_creditsavedetails(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Get the documentation
//
// Retrieves the list of actions available in the system.
//
void
DefaultAPI_doc(apiClient_t *apiClient, int excludeanonymous );


// Adds background image for the login
//
// Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.
//
void
DefaultAPI_easyloginaddbgimage(apiClient_t *apiClient, char * token , char * upload , char * filename );


// Delete a course
//
// Allows the user to delete an existing course.
//
void
DefaultAPI_eventdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a course
//
// Allows the user to view an individual course and its details.
//
void
DefaultAPI_eventget(apiClient_t *apiClient, char * token , char * id );


// View a list of courses by date
//
// Allows the user to view a list of courses by date.
//
void
DefaultAPI_eventgetsessionsbydate(apiClient_t *apiClient, char * token , char * location , char date , char * type );


// View a list of courses
//
// Allows the user to view the full list of courses.
//
void
DefaultAPI_eventlist(apiClient_t *apiClient, char * token , char * from , char * count , int summaryonly , char * termid );


// Create or edit a course
//
// Allows the user to create or edit a course.
//
void
DefaultAPI_eventsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Searches for the available event groups
//
void
DefaultAPI_eventsearchgroup(apiClient_t *apiClient, char * token , char * query );


// Export AccuCampus data
//
// Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.
//
void
DefaultAPI_export(apiClient_t *apiClient, char * token , char * exporttype , char * exportformat , char * filters );


// Lists available export types
//
void
DefaultAPI_exportlisttypes(apiClient_t *apiClient, char * token );


// Lists the available features.
//
void
DefaultAPI_featurelist(apiClient_t *apiClient, char * token );


// View a list of entered holidays
//
// Allows the user to view all holidays entered.
//
void
DefaultAPI_holidaylist(apiClient_t *apiClient, char * token , char * term );


// Create or edit a list of holidays
//
// Allows the user to create or edit holidays.
//
void
DefaultAPI_holidaysave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View the holiday suggestions in the given term
//
// Allows the user to view the holiday suggestions for each term.
//
void
DefaultAPI_holidaysuggest(apiClient_t *apiClient, char * token , char * term );


// Import data into AccuCampus
//
// Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.
//
void
DefaultAPI_import(apiClient_t *apiClient, char * token , char * importtype , char * upload , char * filename , char * parameters );


// Lists available import types
//
void
DefaultAPI_importlisttypes(apiClient_t *apiClient, char * token );


// Accept the license agreement
//
void
DefaultAPI_licenseacceptagreement(apiClient_t *apiClient, char * token );


// Check if license agreement has been accepted
//
void
DefaultAPI_licensegetagreementstatus(apiClient_t *apiClient, char * token );


// Gets the current license information
//
void
DefaultAPI_licensegetcurrent(apiClient_t *apiClient, char * token );


// Contact Engineerica in order to renew the AccuCampus subscription
//
// Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.
//
void
DefaultAPI_licenserenew(apiClient_t *apiClient, char * token , char * email , char * phonenumber , char * jobtitle , char * institution , char * comments );


// Lists the available timezones
//
void
DefaultAPI_listtimezones(apiClient_t *apiClient);


// Delete a location
//
// Allows the user to delete an existing location.
//
void
DefaultAPI_locationdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a location
//
// Allows the user to search and view an individual location and its details.
//
void
DefaultAPI_locationget(apiClient_t *apiClient, char * token , char * id );


// View a list of locations
//
// Allows the user to view the list of all locations to which they are scoped.
//
void
DefaultAPI_locationlist(apiClient_t *apiClient, char * token , int from , int count , char * locations , int sortbygroup );


// Create or edit a location
//
// Allows the user to create or edit a location.
//
void
DefaultAPI_locationsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Login
//
void
DefaultAPI_login(apiClient_t *apiClient, char * domain , char * username , char * password , char * method , int rememberme );


// Logout
//
void
DefaultAPI_logout(apiClient_t *apiClient, char * token );


// Delete memorized report
//
// Allows the user to delete a memorized report that they have created.
//
void
DefaultAPI_memorizedreportdelete(apiClient_t *apiClient, char * token , char * id );


// View details of a memorized report
//
// Allows the user to view an individual memorized report and its details.
//
void
DefaultAPI_memorizedreportget(apiClient_t *apiClient, char * token , char * id );


// View a list of all his memorized reports
//
// Allows the user to view the list of all memorized reports that they have created.
//
void
DefaultAPI_memorizedreportlist(apiClient_t *apiClient, char * token , int from , int count , char * customname );


// Create or edit a memorized report
//
// Allows the user to create or edit a memorized report for themselves.
//
void
DefaultAPI_memorizedreportsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Gets the items on the menu
//
void
DefaultAPI_menugetitems(apiClient_t *apiClient, char * menuid );


// Gets the logged in user account.
//
void
DefaultAPI_myaccount(apiClient_t *apiClient, char * token );


// Gets the current time zone's iana name
//
void
DefaultAPI_myianatimezone(apiClient_t *apiClient, char * token );


// Gets the logged in user information.
//
void
DefaultAPI_myprofile(apiClient_t *apiClient, char * token , int photosize );


// Gets the list of actions the user can execute.
//
void
DefaultAPI_myrights(apiClient_t *apiClient, char * token );


// Updates logged user's profile information
//
void
DefaultAPI_mysaveprofile(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete a notification
//
// Allows the user to delete an existing notification.
//
void
DefaultAPI_notificationdelete(apiClient_t *apiClient, char * token , char * id );


// View a notification
//
void
DefaultAPI_notificationget(apiClient_t *apiClient, char * token , char * id );


// Gets all public (in station) notifications for the specific user
//
void
DefaultAPI_notificationgetforstation(apiClient_t *apiClient, char * station , char * user );


// Get the number of unread notifications
//
void
DefaultAPI_notificationgetunreadcount(apiClient_t *apiClient, char * token );


// View a list of all sent notifications
//
// Allows the user to view the list of all sent notifications.
//
void
DefaultAPI_notificationlist(apiClient_t *apiClient, char * token , int from , int count , char * recipient , int status , char startdate , char enddate , int sentonscreen , int sentemail , int sentsms );


// View all the notifications sent to the current user
//
void
DefaultAPI_notificationlistmine(apiClient_t *apiClient, char * token , int from , int count , int status , char startdate , char enddate );


// Mark a notification as read
//
void
DefaultAPI_notificationmarkasread(apiClient_t *apiClient, char * token , char * id , int status , char startdate , char enddate );


// Mark a notification as unread
//
void
DefaultAPI_notificationmarkasunread(apiClient_t *apiClient, char * token , char * id , int status , char startdate , char enddate );


// Send notifications on screen, via email or text to users
//
// Allows the user to send notifications to other users through the Send Message link.
//
void
DefaultAPI_notificationsend(apiClient_t *apiClient, char * token , int emailenabled , int onscreenenabled , int smsenabled , char * title , char * tousers , char * togroups , char * onscreenbody , char * onscreenclick , char * onscreenurl , char * onscreenclass , int onscreenduration , int showonstation , char * emailfromname , char * emailfrom , char * emailsubject , char * emailbody , char * textmessagebody );


// Send on-screen notifications
//
void
DefaultAPI_notificationsendonscreen(apiClient_t *apiClient, char * token , char * notification );


// Delete a notification topic
//
// Allows the user to delete an existing notification topic.
//
void
DefaultAPI_notificationtopicdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a notification topic
//
// Allows the user to view an individual notification topic and its details.
//
void
DefaultAPI_notificationtopicget(apiClient_t *apiClient, char * token , char * id );


// List all the notification topics
//
// Allows the user to view the list of all notification topics.
//
void
DefaultAPI_notificationtopiclist(apiClient_t *apiClient, char * token , int from , int count );


// List all the notification topics available to subscribe
//
void
DefaultAPI_notificationtopiclistsubscribe(apiClient_t *apiClient, char * token );


// Create or edit a notification topic
//
// Allows the user to create and edit a notification topic.
//
void
DefaultAPI_notificationtopicsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Deregisters the current device to receive push notifications
//
void
DefaultAPI_pushderegister(apiClient_t *apiClient, char * devicetoken , char * platform );


// Registers the current device to receive push notifications
//
void
DefaultAPI_pushregister(apiClient_t *apiClient, char * devicetoken , char * platform );


// Print and email QR labels
//
// Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.
//
void
DefaultAPI_qrlabelsprint(apiClient_t *apiClient, char * token , char * user , char * group );


// Gets an image of a QR token
//
void
DefaultAPI_qrloginget(apiClient_t *apiClient, char * token );


// Login
//
void
DefaultAPI_qrloginlogin(apiClient_t *apiClient, char * onetimetoken );


// Deletes a widget from the Quick Panel
//
// Allows the user to delete a widget that has been added to the Quick Panel.
//
void
DefaultAPI_quickpaneldeletewidget(apiClient_t *apiClient, char * token , char * id );


// Fetches the information for a specific widget.
//
void
DefaultAPI_quickpanelfetchwidget(apiClient_t *apiClient, char * token , char * widgetid );


// View details of a widget included in the Quick Panel
//
// Allows the user to view a widget added in as Quick Panel.
//
void
DefaultAPI_quickpanelgetwidget(apiClient_t *apiClient, char * token , char * id );


// Returns the initial information required to show the quick panels
//
void
DefaultAPI_quickpanelinit(apiClient_t *apiClient, char * token );


// Lists all the widgets that are added in the Quick Panel
//
// Allows the user to view the widgets that have been added to the Quick Panel.
//
void
DefaultAPI_quickpanellistwidgets(apiClient_t *apiClient, char * token );


// Lists all the widget types available in the system
//
void
DefaultAPI_quickpanellistwidgettypes(apiClient_t *apiClient, char * token );


// Reorders the widgets and moves them to a specific column
//
void
DefaultAPI_quickpanelreorderwidgets(apiClient_t *apiClient, char * token , char * sectionname , char * orderids );


// Saves a widget for the Quick Panel
//
// Allows the user to save a widget to the Quick Panel.
//
void
DefaultAPI_quickpanelsavewidget(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View a list of available reports
//
// Allows the user to view the complete list of available, canned reports.
//
void
DefaultAPI_reportlist(apiClient_t *apiClient, char * token );


// Permissions by user report
//
// Lists all the users in the system including their corresponding permissions.
//
void
DefaultAPI_reportpermissionsbyuser(apiClient_t *apiClient, char * token , char * params );


// Queries and loads the specified report, in background.
//
// Allows the user to run reports, in background, with the exception of attendance analytics reports.
//
void
DefaultAPI_reportprepare(apiClient_t *apiClient, char * token , char * reportname , char * params , char * repformat , char * fillgroupid , char * groupby , char * refreshgroup , char * filtertext );


// Query and load a specified report
//
// Allows the user to run reports with the exception of attendance analytics reports.
//
void
DefaultAPI_reportquery(apiClient_t *apiClient, char * token , char * reportname , char * params );


// Show a list of roles
//
void
DefaultAPI_rolelist(apiClient_t *apiClient, char * token , char * name );


// Delete a rule
//
// Allows the user to delete an existing rule.
//
void
DefaultAPI_ruledelete(apiClient_t *apiClient, char * token , char * id );


// View details of a rule
//
// Allows the user to view an individual rule and its details.
//
void
DefaultAPI_ruleget(apiClient_t *apiClient, char * token , char * id );


// View details of a rule event type
//
// Allows the user to view the trigger and its available conditions for the rule.
//
void
DefaultAPI_rulegeteventtype(apiClient_t *apiClient, char * token , char * event );


// View a list of user rules
//
// Allows the user to view the list of all rules.
//
void
DefaultAPI_rulelist(apiClient_t *apiClient, char * token , int from , int count );


// View a list of rule actions available
//
// Allows the user to view all the available rule actions.
//
void
DefaultAPI_rulelistactions(apiClient_t *apiClient, char * token );


// View a list of rule event types
//
// Allows the user to view a list of available triggers for rules.
//
void
DefaultAPI_rulelisteventtypes(apiClient_t *apiClient, char * token );


// View all the http requests sent as a result of a rule
//
void
DefaultAPI_rulelisthttprequests(apiClient_t *apiClient, char * token , int from , int count , int failed , int status );


// Create or edit a rule
//
// Allows the user to create or edit a rule.
//
void
DefaultAPI_rulesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Search
//
void
DefaultAPI_search(apiClient_t *apiClient, char * token , char * query , int page );


// Get the information of the entities that can be searched
//
void
DefaultAPI_searchgetentities(apiClient_t *apiClient, char * token );


// Returns the list of users for a specific permission
//
void
DefaultAPI_securityassesspermission(apiClient_t *apiClient, char * token , char * commandname );


// Returns the list of permissions for a specific role
//
void
DefaultAPI_securityassessrole(apiClient_t *apiClient, char * token , char * roleid );


// Returns the list of users for a specific user
//
void
DefaultAPI_securityassessscope(apiClient_t *apiClient, char * token , char * locationid );


// Returns the list of permissions for a specific user
//
void
DefaultAPI_securityassessuser(apiClient_t *apiClient, char * token , char * userid );


// Register current user to an event session
//
// Allows the user to register themselves for an event.
//
void
DefaultAPI_sessionregaddcurrentuser(apiClient_t *apiClient, char * token , char * eventid , char sessiondate );


// Register users for events
//
// Allows the user to register another user for an upcoming event.
//
void
DefaultAPI_sessionregadduser(apiClient_t *apiClient, char * token , char * userid , char * eventid , char sessiondate );


// View all the sessions the logged user is registered to
//
void
DefaultAPI_sessionreggetmysessions(apiClient_t *apiClient, char * token , char date );


// Lists the registrations for a specific user
//
// Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.
//
void
DefaultAPI_sessionreggetsessions(apiClient_t *apiClient, char * token , char * userid );


// Get the settings for session registration
//
// Allows the user to view a event's session registration settings.
//
void
DefaultAPI_sessionreggetsettings(apiClient_t *apiClient, char * token , char * locationid , char * eventid , char sessiondate , int noinherit );


// Lists the registrations for a specific session
//
// Allows the user to view the registration for a specified event session.
//
void
DefaultAPI_sessionreggetusers(apiClient_t *apiClient, char * token , char * eventid , char sessiondate );


// List the sessions available for a specific event
//
// Allows the user to view all the sessions available for a recurring event.
//
void
DefaultAPI_sessionreglistsessions(apiClient_t *apiClient, char * token , char * eventid , char sessiondate );


// View a list of upcoming event sessions
//
// Allows the user to view the full list of upcoming events.
//
void
DefaultAPI_sessionreglistupcoming(apiClient_t *apiClient, char * token , char date );


// View a list of upcoming sessions of a particular event
//
// Allows the user to view the upcoming recurring sessions of a specified event.
//
void
DefaultAPI_sessionreglistupcomingevent(apiClient_t *apiClient, char * token , char date , char * event );


// Unregister current user from an event session
//
// Allows the user to un-register themselves from an event.
//
void
DefaultAPI_sessionregremovecurrentuser(apiClient_t *apiClient, char * token , char * eventid , char sessiondate );


// Removes a user from an event session
//
// Allows the user to un-register another user from an event.
//
void
DefaultAPI_sessionregremoveuser(apiClient_t *apiClient, char * token , char * userid , char * eventid , char sessiondate );


// Save the settings for an event's session registration
//
// Allows the user to save the settings for an event.
//
void
DefaultAPI_sessionregsavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Add a logo to the account
//
// Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.
//
void
DefaultAPI_settingaddlogo(apiClient_t *apiClient, char * token , char * upload , char * filename );


// Get settings for the account or the specified scope
//
void
DefaultAPI_settingget(apiClient_t *apiClient, char * keys , char * token , char * domain , char * scope );


// Save settings for the account or the specified scope
//
// Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.
//
void
DefaultAPI_settingsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View general settings for the account
//
// Allows the user to view the settings' general section.
//
void
DefaultAPI_settingviewgeneral(apiClient_t *apiClient, char * token );


// Generate/reset single sign on access key.
//
// Allows the user to generate or reset the access key for single sign-on.
//
void
DefaultAPI_ssogeneratekey(apiClient_t *apiClient, char * token );


// View single sign on settings.
//
// Allows the user to view settings for single sign-on.
//
void
DefaultAPI_ssogetsettings(apiClient_t *apiClient, char * token );


// Issue single sign-on token
//
void
DefaultAPI_ssoissuetoken(apiClient_t *apiClient, char * key , char * username , int expires );


// Edit single sign-on settings.
//
// Allows the user to edit settings for single sign-on.
//
void
DefaultAPI_ssosavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete a sign-in station
//
// Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.
//
void
DefaultAPI_stationdelete(apiClient_t *apiClient, char * token , char * id );


// View details of a sign-in station
//
// Allows the user to view an individual sign-in station and its details.
//
void
DefaultAPI_stationget(apiClient_t *apiClient, char * token , char * id );


// Get all the current terms
//
void
DefaultAPI_stationgetcurrentterms(apiClient_t *apiClient, char * station );


// Gets a the info to display in the sign-in station by it's ID.
//
void
DefaultAPI_stationgetinfo(apiClient_t *apiClient, char * id , char * event );


// Gets the current license information
//
void
DefaultAPI_stationgetlicense(apiClient_t *apiClient, char * station );


// View a list of sign-in stations
//
// Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.
//
void
DefaultAPI_stationlist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit a sign-in station
//
// Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.
//
void
DefaultAPI_stationsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Unlocks the sign-in station.
//
void
DefaultAPI_stationunlock(apiClient_t *apiClient, char * id , char * passcode , char * method );


// Delete a swipe
//
// Allows the user to delete an existing attendance swipe.
//
void
DefaultAPI_swipedelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a swipe
//
// Allows the user to view an individual attendance swipe.
//
void
DefaultAPI_swipeget(apiClient_t *apiClient, char * token , char * id );


// View a list of swipes
//
// Allows the user to view a list of all swipes for the location or locations in which the user is scoped.
//
void
DefaultAPI_swipelist(apiClient_t *apiClient, int from , int count , char * token );


// Create or edit a swipe, and if possible, save the related attendance log
//
// Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.
//
void
DefaultAPI_swipesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Creates a new swipe from a sign-in station, and if possible, creates the attendance log
//
void
DefaultAPI_swipesaveanonym(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete a tag
//
// Allows the user to delete an existing tag.
//
void
DefaultAPI_tagdelete(apiClient_t *apiClient, char * token , char * id );


// View details of a specified tag
//
// Allows the user to click on and view the settings for a tag.
//
void
DefaultAPI_tagget(apiClient_t *apiClient, char * token , char * id );


// View a list of tags
//
// Allows the user to view the list of tags.
//
void
DefaultAPI_taglist(apiClient_t *apiClient, char * token , char * group , int from , int count );


// View a list of entities that can be tagged
//
// Allows the user to view the list of user roles that can be tagged, according to that tag's settings.
//
void
DefaultAPI_taglistgroups(apiClient_t *apiClient, char * token );


// Create or edit a tag
//
// Allows the user to create or edit a tag.
//
void
DefaultAPI_tagsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Search for tags in the account
//
// Allows the user to search for tags.
//
void
DefaultAPI_tagsearch(apiClient_t *apiClient, char * token , char * query , int allowcreatingnew );


// Add an image to a template
//
// Allows the user to add an image to a badge or certificate template.
//
void
DefaultAPI_templateaddimage(apiClient_t *apiClient, char * token , char * template , char * upload , char * filename );


// Delete a template
//
// Allows the user to delete an existing template.
//
void
DefaultAPI_templatedelete(apiClient_t *apiClient, char * token , char * id );


// Send generated templates by email
//
// Allows the user to send generated templates via email through AccuCampus.
//
void
DefaultAPI_templateemail(apiClient_t *apiClient, char * token , char * jobid , char * emailsubject , char * emailbody , char * templatekind , char * emailfrom , char * emailreplyto );


// Generate specified templates
//
// Allows the user to generate an existing template as badges or certificates.
//
void
DefaultAPI_templategenerate(apiClient_t *apiClient, char * token , char * template , char * source , int singlefile , char * userid , int forsending , char * role , char * filters );


// View details of a template
//
// Allows the user to view a template and its details.
//
void
DefaultAPI_templateget(apiClient_t *apiClient, char * token , char * id );


// View generated templates
//
// Allows the user to view templates which have been generated as badges or certificates.
//
void
DefaultAPI_templategetgenerated(apiClient_t *apiClient, char * token , char * jobid );


// View a list of defined templates
//
// Allows the user to view the full list of created templates.
//
void
DefaultAPI_templatelist(apiClient_t *apiClient, char * token , int from , int count , char * kind , int designedonly );


// View a list of templates' data sources
//
// Allows the user to see tokens to be used in the template
//
void
DefaultAPI_templatelistsources(apiClient_t *apiClient, char * token , char * kind );


// Create or edit a template
//
// Allows the user to create or edit a template.
//
void
DefaultAPI_templatesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Save the layout of a template
//
// Allows the user to edit a template's layout.
//
void
DefaultAPI_templatesavelayout(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete a term
//
// Allows the user to delete a term from the existing list.
//
void
DefaultAPI_termdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a term
//
// Allows the user to view a term and its details.
//
void
DefaultAPI_termget(apiClient_t *apiClient, char * token , char * id );


// Search and view details of all terms
//
// Allows the user to view the full list of existing term.
//
void
DefaultAPI_termlist(apiClient_t *apiClient, char * token , int from , int count , int notpast );


// Create and edit terms
//
// Allows the user to create and edit terms.
//
void
DefaultAPI_termsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Gets the remaining text credits for the account
//
void
DefaultAPI_textcreditremaining(apiClient_t *apiClient, char * token );


// Generates a dynamic image from text
//
void
DefaultAPI_texttoimage(apiClient_t *apiClient, char * token , char * text , char * fontcolor , int fontsize , char * direction , int width );


// Gets the translations of the specified values
//
void
DefaultAPI_translationget(apiClient_t *apiClient, char * token , char * universal );


// Get the file containing the translations
//
void
DefaultAPI_translationgetcachefile(apiClient_t *apiClient, char * token , char * account );


// Lists all the available translations in the system
//
void
DefaultAPI_translationlist(apiClient_t *apiClient, char * token , char * filter , int nondefaultonly , int appdefaultasuniversal );


// Edit a translation
//
// Allows the user to edit a translation for the entire account.
//
void
DefaultAPI_translationsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Change user's own password
//
// Allows the user to change their own password.
//
void
DefaultAPI_userchangepwd(apiClient_t *apiClient, char * token , char * oldpass , char * newpass );


// Changes the user password using a change password request id
//
void
DefaultAPI_userchangepwdbyreq(apiClient_t *apiClient, char * changereq , char * newpass );


// Delete a user
//
// Allows the user to delete a user.
//
void
DefaultAPI_userdelete(apiClient_t *apiClient, char * token , char * id );


// Finds similar users to prevent duplicates
//
// Allows the user to be warned if a user they are creating has the same card number as another user.
//
void
DefaultAPI_userfindsimilar(apiClient_t *apiClient, char * token , char * currentid , char * phonenumber , char * cardnumber );


// Search and view details of a user
//
// Allows the user to search and view a user and their details.
//
void
DefaultAPI_userget(apiClient_t *apiClient, char * token , char * id , int photosize );


// Search user by card number
//
// Allows the user to search for a user by their card number.
//
void
DefaultAPI_usergetbycard(apiClient_t *apiClient, char * token , char * card , int photosize );


// Add a user to a group
//
// Allows the user to add a user to a group that they have permission to edit.
//
void
DefaultAPI_usergroupaddmember(apiClient_t *apiClient, char * token , char * userid , char * groupid );


// Delete a group
//
// Allows the user to delete a group that they have permission to edit.
//
void
DefaultAPI_usergroupdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a user group
//
// Allows the user to view a user group and its details.
//
void
DefaultAPI_usergroupget(apiClient_t *apiClient, char * token , char * id );


// View the members of a user group
//
// Allows the user to view the list of users in a group that they have permission to view.
//
void
DefaultAPI_usergroupgetmembers(apiClient_t *apiClient, char * token , char * groupid );


// View the groups which a user is registered to
//
// Allows the user to view the groups an individual user is registered to, based on group and user permissions.
//
void
DefaultAPI_usergroupgetuser(apiClient_t *apiClient, char * token , char * userid );


// View a list of user groups
//
// Allows the user to view the list of groups that they have permission to view.
//
void
DefaultAPI_usergrouplist(apiClient_t *apiClient, char * token , int from , int count , char * type );


// Refresh the dynamic group
//
// Allows the user to refresh a dynamic group that they have permission to edit.
//
void
DefaultAPI_usergrouprefresh(apiClient_t *apiClient, char * token , char * group );


// Remove a user from a group
//
// Allows the user to remove a user from a group that they have permission to edit.
//
void
DefaultAPI_usergroupremovemember(apiClient_t *apiClient, char * token , char * userid , char * groupid );


// Create or edit a group
//
// Allows the user to create a new group or edit a group that they have permission to edit.
//
void
DefaultAPI_usergroupsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View a list of users
//
// Allows the user to view the full list of users and is based on role permissions.
//
void
DefaultAPI_userlist(apiClient_t *apiClient, char * token , int from , int count , char * roleid , char * onlywithoutcard , int photosize );


// Upload a photo for a specific user
//
// Allows the user to upload a photo for a user.
//
void
DefaultAPI_userloadphoto(apiClient_t *apiClient, char * token , char * upload , char * filename , char * userid , int automatch );


// Move data between users
//
// Allows administrators to move data between users.
//
void
DefaultAPI_usermovedata(apiClient_t *apiClient, char * token , char * source , char * destination );


// Requests a password change
//
void
DefaultAPI_userrequestpwdchange(apiClient_t *apiClient, char * domain , char * email );


// Create or edit a user
//
// Allows the user to create or edit a user.
//
void
DefaultAPI_usersave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Send email to the specified user(s) to set/change their passwords
//
// Allows the user to trigger an email to another user asking them to set or change their password.
//
void
DefaultAPI_usersavepwdchange(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Lists available user settings
//
void
DefaultAPI_usersettingsget(apiClient_t *apiClient, char * token , char * keys , char * user );


// Get multiple user settings
//
void
DefaultAPI_usersettingsgetmultiple(apiClient_t *apiClient, char * token , char * keys , char * user );


// Saves a user setting
//
void
DefaultAPI_usersettingssave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Save multiple user settings at once
//
void
DefaultAPI_usersettingssavemultiple(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Get current version information
//
void
DefaultAPI_version(apiClient_t *apiClient, char * token );


