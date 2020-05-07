#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Remove an action item from an action plan
//
// Allows a user to remove an action item from a user's action plan.
//
void
DefaultAPI_actionassignmentdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of an action item assigned to a user
//
// Allows the user to view an individual action item and its details, minus all the action item's updates.
//
void
DefaultAPI_actionassignmentget(apiClient_t *apiClient, char * token , char * id );


// View a list of action items in a user's plan
//
// Allows the user to view the list of all action items for a specified user.
//
void
DefaultAPI_actionassignmentlist(apiClient_t *apiClient, char * token , int from , int count , int assignee , int status );


// View the history of an action item assigned to a user
//
// Allows the user to view an individual action plan and its details, including all the action plan's updates.
//
void
DefaultAPI_actionassignmentlisthistory(apiClient_t *apiClient, char * token , char * actionassignment );


// List public action assignments assigned to the logged user
//
void
DefaultAPI_actionassignmentlistmine(apiClient_t *apiClient, char * token , int from , int count , int status );


// List public action assignment history
//
void
DefaultAPI_actionassignmentlistpublichistory(apiClient_t *apiClient, char * token , char * actionassignment );


// Bulk complete action items
//
// Allows the user to bulk complete action items.
//
void
DefaultAPI_actionassignmentmarkcomplete(apiClient_t *apiClient, char * token , char * item , char * assignee , char * group , char * notes );


// Add an action item to a user's action plan
//
// Allows the user to edit or assign an action item to a user
//
void
DefaultAPI_actionassignmentsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Update an action item assigned to a user
//
// Allows the user to update or mark an action item as complete.
//
void
DefaultAPI_actionassignmentsavehistory(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete an action item
//
// Allows the user to delete an action item.
//
void
DefaultAPI_actionitemdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of an action item
//
// Allows the user to view an individual action item and its details.
//
void
DefaultAPI_actionitemget(apiClient_t *apiClient, char * token , char * id );


// View a list of action items
//
// Allows the user to view a list of action items
//
void
DefaultAPI_actionitemlist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit an action item
//
// Allows the user to edit an action item.
//
void
DefaultAPI_actionitemsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View a list of users action logs
//
// Allows the user to view the audit logs for the account.
//
void
DefaultAPI_actionloglist(apiClient_t *apiClient, char * token , int from , int count , char * user , char startdate , char enddate , char * resource , char * actionfilter , char * argument );


// Assign an action item pack to a user
//
// Allows the user to assign an action pack to a user or group of users.
//
void
DefaultAPI_actionpackassign(apiClient_t *apiClient, char * token , char * pack , int itemsdata , char * assignee , char * group , char * notes );


// Delete an action item pack
//
// Allows the user to delete an action item pack.
//
void
DefaultAPI_actionpackdelete(apiClient_t *apiClient, char * token , char * id );


// View details of an action item pack
//
// Allows the user to view an individual action pack and its details.
//
void
DefaultAPI_actionpackget(apiClient_t *apiClient, char * token , char * id );


// View a list of action item packs
//
// Allows the user to view the full list of action item packs.
//
void
DefaultAPI_actionpacklist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit an action item pack
//
// Allows the user to edit an action item pack.
//
void
DefaultAPI_actionpacksave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete an action item type
//
// Allows the user to delete an action item type.
//
void
DefaultAPI_actiontypedelete(apiClient_t *apiClient, char * token , char * id );


// View details of an action item type
//
// Allows the user to view an individual action item type and its details.
//
void
DefaultAPI_actiontypeget(apiClient_t *apiClient, char * token , char * id );


// View a list of action item types
//
// Allows the user to view the full list of action item types.
//
void
DefaultAPI_actiontypelist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit an action item type
//
// Allows the user to dit an action item type.
//
void
DefaultAPI_actiontypesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Check the status of an ad hoc query execution
//
// Allows the user to check whether a query has executed, viewable on the query's execution page.
//
void
DefaultAPI_adhocquerycheckexecution(apiClient_t *apiClient, char * token , char * id );


// Delete an ad hoc query
//
// Allows the user to delete a previously created ad hoc query.
//
void
DefaultAPI_adhocquerydelete(apiClient_t *apiClient, char * token , char * id );


// Execute an ad hoc query
//
// Allows the user to execute an ad hoc query.
//
void
DefaultAPI_adhocqueryexecute(apiClient_t *apiClient, char * token , char * id , char * query );


// View details of an ad hoc query
//
// Allows the user to view an individual ad hoc query with its settings.
//
void
DefaultAPI_adhocqueryget(apiClient_t *apiClient, char * token , char * id );


// View the database schema for making ad hoc queries
//
// Allows the user to view the list of schema for ad hoc queries.
//
void
DefaultAPI_adhocquerygetschema(apiClient_t *apiClient, char * token );


// View a list of saved ad hoc queries
//
// Allows the user to view the full list of saved queries.
//
void
DefaultAPI_adhocquerylist(apiClient_t *apiClient, char * token , int from , int count );


// View a list of ad hoc queries executions
//
// Allows the user to view the full list of past query executions.
//
void
DefaultAPI_adhocquerylistexecutions(apiClient_t *apiClient, char * token , int from , int count , char * query );


// Create or edit an ad hoc query
//
// Allows the user to edit an ad hoc query.
//
void
DefaultAPI_adhocquerysave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Stops the execution of an ad hoc query
//
// Allows the user to halt the execution of a query that is currently being executed.
//
void
DefaultAPI_adhocquerystopexecution(apiClient_t *apiClient, char * token , char * id );


// Request access to the ad-hoc reports
//
// Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports
//
void
DefaultAPI_adhocreportsreqaccess(apiClient_t *apiClient, char * token );


// Check whether the user is known by the system.
//
void
DefaultAPI_advancedstationcheckunknownuser(apiClient_t *apiClient, char * station , char * user , char * location );


// Check whether the user is a staff member, an attendee or both.
//
void
DefaultAPI_advancedstationcheckuserrole(apiClient_t *apiClient, char * station , char * user , char * location );


// Creates a user via a sign-in station.
//
void
DefaultAPI_advancedstationcreateuser(apiClient_t *apiClient, char * station , char * user , char * location , char * firstname , char * lastname , char * email , char * middlename );


// Gets the courses available for a specific location and a specific student.
//
void
DefaultAPI_advancedstationgetevents(apiClient_t *apiClient, char * station , char * location , char * user );


// Gets the info to display in the sign-in station by it's ID.
//
void
DefaultAPI_advancedstationgetinfo(apiClient_t *apiClient, char * id , char * event );


// Gets the locations available in a sign-in station.
//
void
DefaultAPI_advancedstationgetlocations(apiClient_t *apiClient, char * station , char * user );


// Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
//
void
DefaultAPI_advancedstationgetlogstaff(apiClient_t *apiClient, char * station , char * attendancelog , int photosize );


// Gets the user roles of the user trying to sign-in.
//
void
DefaultAPI_advancedstationgetroles(apiClient_t *apiClient, char * station , char * signinrole , char * user , char * location );


// Gets the services available for a specific location.
//
void
DefaultAPI_advancedstationgetservices(apiClient_t *apiClient, char * station , char * location , char * user );


// Gets the staff/tutors available for a specific location, course and service.
//
void
DefaultAPI_advancedstationgetstaff(apiClient_t *apiClient, char * station , char * locationid , char * user , char * services , char * eventid , int photosize );


// Gets whether a user is signed-in or not.
//
void
DefaultAPI_advancedstationissignedin(apiClient_t *apiClient, char * station , char time , char * user , char * location );


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


// Cancel an appointment
//
// Allows the user to cancel an appointment.
//
void
DefaultAPI_appointmentcancel(apiClient_t *apiClient, char * token , char * id );


// Check if an appointment is valid or not
//
void
DefaultAPI_appointmentcheckisvalid(apiClient_t *apiClient, char * token , char * id , int editing );


// Edit an appointment even if it breaks activated rules
//
// Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.
//
void
DefaultAPI_appointmenteditanyway(apiClient_t *apiClient, char * token , char * id , char * attendee , char * staff , char * location , char start , char end , char * term , char * event , char * services , char * notes );


// Edit the no-show status of an appointment
//
// Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.
//
void
DefaultAPI_appointmenteditpresence(apiClient_t *apiClient, char * token , char * id , int showedup );


// Finds all staff available slots filtered by service, date, etc
//
// Allows the user to view available appointment slots when creating an appointment.
//
void
DefaultAPI_appointmentfindallstaffslots(apiClient_t *apiClient, char * token , char starttime , char endtime , char * serviceids , char * locationid , char * eventid , int photosize );


// Finds available slots filtered by service, date, staff, etc
//
// Allows the user to view available appointment slots when creating an appointment.
//
void
DefaultAPI_appointmentfindslots(apiClient_t *apiClient, char * token , char * staffid , char starttime , char endtime , char * serviceids , char * eventid , char * locationid );


// Finds staff available by service, date, event, etc
//
// Allows the user to view staff availability when creating an appointment.
//
void
DefaultAPI_appointmentfindstaff(apiClient_t *apiClient, char * token , char * serviceids , char starttime , char endtime , char * eventid , char * locationid , int photosize );


// Search and view details of an appointment
//
// Allows the user to view an individual appointment and its details.
//
void
DefaultAPI_appointmentget(apiClient_t *apiClient, char * token , char * id );


// Get the current appointments for the user that is about to sign-in via the specified sign-in station.
//
void
DefaultAPI_appointmentgetcurrent(apiClient_t *apiClient, char * station , char * user , char * location );


// Find locations where a service is available
//
// Allows the user to search for appointment availability by location or service.
//
void
DefaultAPI_appointmentgetlocations(apiClient_t *apiClient, char * token , char * serviceid );


// View a list of appointments
//
// Allows the user to view all upcoming appointments for the location or locations they are scoped to.
//
void
DefaultAPI_appointmentlist(apiClient_t *apiClient, char * token , int from , int count , char startdate , char enddate , char * userid );


// View all my upcoming appointments
//
void
DefaultAPI_appointmentlistmine(apiClient_t *apiClient, char * token , char start , char modifiedafter );


// Search and view details of all my upcoming appointments
//
// Allows the user to view all of their own upcoming appointments.
//
void
DefaultAPI_appointmentlistupcoming(apiClient_t *apiClient, char * token , char start , char modifiedafter );


// Reschedule an appointment from MS Outlook.
//
// Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.
//
void
DefaultAPI_appointmentrescheduleoutlook(apiClient_t *apiClient, char * token , char * id , char start , char end );


// Restore an appointment
//
// Allows the user to restore a canceled appointment.
//
void
DefaultAPI_appointmentrestore(apiClient_t *apiClient, char * token , char * id );


// Restore an appointment even if it breaks activated rules
//
// Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.
//
void
DefaultAPI_appointmentrestoreanyway(apiClient_t *apiClient, char * token , char * id );


// Schedule an appointment
//
// Allows the user to schedule an appointment within the rules of the location and the availability of staff members.
//
void
DefaultAPI_appointmentsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Schedule an appointment even if it breaks activated rules
//
// Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.
//
void
DefaultAPI_appointmentsetasvalid(apiClient_t *apiClient, char * token , char * id );


// View the locations with most appointments
//
// Allows the user to view suggestions for the most popular locations in which to make appointments
//
void
DefaultAPI_appointmentsuggestlocations(apiClient_t *apiClient, char * token );


// View the services with most appointments
//
// Allows the user to view suggestions for the most popular services for which to make appointments.
//
void
DefaultAPI_appointmentsuggestservices(apiClient_t *apiClient, char * token );


// Void an appointment
//
// Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student's restrictions.
//
void
DefaultAPI_appointmentvoid(apiClient_t *apiClient, char * token , char * id );


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


// Gets the attendance logs that the current user is involved in as staff
//
void
DefaultAPI_attendancelogliststaff(apiClient_t *apiClient, int from , int count , char * token , char * filter );


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


// Delete an attendance restriction
//
// Allows the user to delete an existing attendance restriction.
//
void
DefaultAPI_attendancerestrictiondelete(apiClient_t *apiClient, char * token , char * id );


// View details of an attendance restriction
//
// Allows the user to view an individual attendance restriction and its details.
//
void
DefaultAPI_attendancerestrictionget(apiClient_t *apiClient, char * token , char * id );


// View a list of attendance restrictions
//
// Allows the user to view the list of all attendance restrictions.
//
void
DefaultAPI_attendancerestrictionlist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit an attendance restriction
//
// Allows the user to create or edit an attendance restriction.
//
void
DefaultAPI_attendancerestrictionsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete a beacon profile
//
// Allows the user to delete an existing beacon profile.
//
void
DefaultAPI_beacondelete(apiClient_t *apiClient, char * token , char * id );


// Disable beacon support account wide
//
// Allows the user to enable or disable beacon usage account wide.
//
void
DefaultAPI_beacondisable(apiClient_t *apiClient, char * token );


// View details of a beacon profile
//
// Allows the user to view an individual beacon profile and its details.
//
void
DefaultAPI_beaconget(apiClient_t *apiClient, char * token , char * id );


// Get the sign-in stations assigned to specific beacons.
//
void
DefaultAPI_beacongetlocations(apiClient_t *apiClient, char * token , char * beacons );


// Get the location settings in the specified sign-in station.
//
void
DefaultAPI_beacongetstationlocation(apiClient_t *apiClient, char * token , char * station , char * location );


// View the identifier for the account's beacon region (for sign-in stations).
//
void
DefaultAPI_beacongetuuid(apiClient_t *apiClient, char * token );


// View a list of beacon profiles
//
// Allows the user to view the list of all beacon profiles without their basic details.
//
void
DefaultAPI_beaconlist(apiClient_t *apiClient, char * token , int from , int count );


// View a list of beacon profiles with their characteristics
//
// Allows the user to view the list of all beacon profiles with their basic details.
//
void
DefaultAPI_beaconlistprofiles(apiClient_t *apiClient, char * token );


// Generate or reset the identifier for the account's beacon region.
//
// Allows the user to reset the identifier for the beacon region, generally not necessary.
//
void
DefaultAPI_beaconresetuuid(apiClient_t *apiClient, char * token );


// Create or edit a beacon profile
//
// Allows the user to create or edit a beacon profile.
//
void
DefaultAPI_beaconsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Check if there's location available to sign-in / out.
//
void
DefaultAPI_beaconscanlocations(apiClient_t *apiClient, char * token , char * beacons );


// Set the identifier for the account's beacon region (for sign-in stations).
//
// Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.
//
void
DefaultAPI_beaconsetuuid(apiClient_t *apiClient, char * token , char * id );


// View all the beacon regions defined for silent tracking
//
void
DefaultAPI_beaconsilentregions(apiClient_t *apiClient, char * token );


// Sign-in silently from the location specified by a beacon
//
void
DefaultAPI_beaconsilentsignin(apiClient_t *apiClient, char * token , char * uuid );


// Sign-out silently from the location specified by a beacon
//
void
DefaultAPI_beaconsilentsignout(apiClient_t *apiClient, char * token , char * uuid );


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


// Sends an invitation to everyone to AccuCampus Communities
//
// Allows the user to invite all other users to the AccuCampus Communities.
//
void
DefaultAPI_communityinvite(apiClient_t *apiClient, char * token );


// Sends an invitation for myself to AccuCampus Communities
//
// Allows the user to access the AccuCampus Communities.
//
void
DefaultAPI_communityjoin(apiClient_t *apiClient, char * token );


// Delete a compass category
//
// Allows the user to delete an existing compass category.
//
void
DefaultAPI_compasscategorydelete(apiClient_t *apiClient, char * token , char * id );


// View details of a compass category
//
// Allows the user to view an indvidiaul compass category and its details.
//
void
DefaultAPI_compasscategoryget(apiClient_t *apiClient, char * token , char * id );


// View a list of compass categories
//
// Allows the user to view the full list of compass categories.
//
void
DefaultAPI_compasscategorylist(apiClient_t *apiClient, char * token , int from , int count , int onlywithservices );


// Create or edit a compass category
//
// Allows the user to create or edit a compass category.
//
void
DefaultAPI_compasscategorysave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View all the services added to the compass
//
void
DefaultAPI_compassservicelist(apiClient_t *apiClient, char * token , char * category );


// View all the locations where a service added to the compass is available
//
void
DefaultAPI_compassservicelistlocations(apiClient_t *apiClient, char * token , char * serviceid );


// Delete a computer
//
// Allows the user to delete an existing computer.
//
void
DefaultAPI_computerlabdeletecomputer(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a computer
//
// Allows the user to search and view an individual computer and its details.
//
void
DefaultAPI_computerlabgetcomputer(apiClient_t *apiClient, char * token , char * id );


// Loads the settings for a computer lab
//
// Loads the settings for a computer lab.
//
void
DefaultAPI_computerlabgetsettings(apiClient_t *apiClient, char * id );


// Gets whether a user is signed-in or not.
//
void
DefaultAPI_computerlabissignedin(apiClient_t *apiClient, char * station , char * user );


// View a list of computers
//
// Allows the user to view the list of all computers.
//
void
DefaultAPI_computerlablistcomputers(apiClient_t *apiClient, char * token , int from , int count , char * location , int freeonly );


// View a list of the locations that use the Computer Lab add-on
//
// Allows the user to view the list of all labs.
//
void
DefaultAPI_computerlablistlabs(apiClient_t *apiClient, char * token );


// View a list of sign-in stations available for computer labs.
//
// Allows the user to view the list of sign-in stations that are available for computer labs.
//
void
DefaultAPI_computerlabliststations(apiClient_t *apiClient, char * token );


// Create or edit a computer
//
// Allows the user to create or edit a computer.
//
void
DefaultAPI_computerlabsavecomputer(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Saves the settings for a computer lab
//
// Saves the settings for a computer lab.
//
void
DefaultAPI_computerlabsavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Save a new swipe from a computer in a computer lab.
//
void
DefaultAPI_computerlabsaveswipe(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Deletes a dead-end record group
//
// Allows the user to delete a dead end record group.
//
void
DefaultAPI_deadendrecordingdelete(apiClient_t *apiClient, char * token , char * hierarchykey );


// Lists the recorded dead ends, if enabled
//
// Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.
//
void
DefaultAPI_deadendrecordinglist(apiClient_t *apiClient, char * token );


// Lists the comments for a specific dead end
//
// Allows the user to view the comments made on dead end sessions.
//
void
DefaultAPI_deadendrecordinglistcomments(apiClient_t *apiClient, char * token , char * hierarchykey );


// Saves a dead-end record
//
void
DefaultAPI_deadendrecordingsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete a college department
//
// Allows the user to delete an existing college department.
//
void
DefaultAPI_departmentdelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a college department
//
// Allows the user to view an individual college department and its details.
//
void
DefaultAPI_departmentget(apiClient_t *apiClient, char * token , char * id );


// View a list of college departments
//
// Allows the user to view the full list of college departments.
//
void
DefaultAPI_departmentlist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit a college department
//
// Allows the user to create or edit a college department.
//
void
DefaultAPI_departmentsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Edit an event's sessions according to their schedule
//
// Allows the user to edit event sessions.
//
void
DefaultAPI_eventchecksessions(apiClient_t *apiClient, char * token , char * eventid , int autorepair );


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


// View a list of courses I am registered to
//
// Allows the user to view the courses they are registered to.
//
void
DefaultAPI_eventlistregistered(apiClient_t *apiClient, char * token , char * from , char * count , int summaryonly , char * termid );


// Register current user to a course
//
// Allows the user to make themselves available for individual courses.
//
void
DefaultAPI_eventregaddme(apiClient_t *apiClient, char * token , char * eventid , char * listname );


// Register current user to all courses
//
// Allows the user to make themselves available for all courses.
//
void
DefaultAPI_eventregaddmetoall(apiClient_t *apiClient, char * token , char * listname );


// Register current user to a course group
//
// Allows the user to make themselves available for a course group.
//
void
DefaultAPI_eventregaddmetogroup(apiClient_t *apiClient, char * token , char * codegroup , char * listname );


// Register a user to a course for attendance
//
// Allows the user to register a user to a course.
//
void
DefaultAPI_eventregadduser(apiClient_t *apiClient, char * token , char * userid , char * eventid , char * listname );


// Register a user to assist with all courses
//
// Allows the user to make a staff member available to assist with all courses.
//
void
DefaultAPI_eventregaddusertoall(apiClient_t *apiClient, char * token , char * userid , char * listname );


// Register a user to an course group
//
// Allows the user to make a staff member available for a course group.
//
void
DefaultAPI_eventregaddusertogroup(apiClient_t *apiClient, char * token , char * userid , char * codegroup , char * listname );


// View course registration by user
//
// Allows the user to view all courses a given user is registered to, provided they have permission to view that user.
//
void
DefaultAPI_eventreggetevents(apiClient_t *apiClient, char * token , char * userid , char * listname , char * termid , char * namefilter );


// Lists the course group registrations of a user
//
// Allows the user to view the course groups a staff member is available for.
//
void
DefaultAPI_eventreggetgroups(apiClient_t *apiClient, char * token , char * userid , char * listname );


// View the event registrations of the current user
//
void
DefaultAPI_eventreggetmyevents(apiClient_t *apiClient, char * token , char * listname , char * termid , char * namefilter );


// View all current user registrations to course groups
//
// Allows the user to view all his registrations to course groups.
//
void
DefaultAPI_eventreggetmygroups(apiClient_t *apiClient, char * token , char * listname );


// View course registration
//
// Allows the user to view all users registered for an individual course.
//
void
DefaultAPI_eventreggetusers(apiClient_t *apiClient, char * token , char * eventid , char * listname , int photosize );


// Lists the registrations for a course group
//
// Allows the user the get the staff members registered to a specific course group
//
void
DefaultAPI_eventreggetusersfromgroup(apiClient_t *apiClient, char * token , char * codegroup , char * listname );


// View the users that are registered to all courses
//
// Allows the user to view all staff members available for all courses.
//
void
DefaultAPI_eventreggetuserstoall(apiClient_t *apiClient, char * token , char * listname );


// Unregister current user from a course
//
// Allows the user to remove themselves from registration to a course.
//
void
DefaultAPI_eventregremoveme(apiClient_t *apiClient, char * token , char * eventid , char * listname );


// Remove current user from the registration to all courses
//
// Allows the user to remove themselves from availability to all courses.
//
void
DefaultAPI_eventregremovemefromall(apiClient_t *apiClient, char * token , char * listname );


// Remove current user from a course group
//
// Allows the user to remove themselves from availability to a course group.
//
void
DefaultAPI_eventregremovemefromgroup(apiClient_t *apiClient, char * token , char * codegroup , char * listname );


// Remove a user from a course
//
// Allows the user to remove a user from a course's registration.
//
void
DefaultAPI_eventregremoveuser(apiClient_t *apiClient, char * token , char * userid , char * eventid , char * listname );


// Remove a user from the registration to all courses
//
// Allows the user to remove a staff member from availability to all courses.
//
void
DefaultAPI_eventregremoveuserfromall(apiClient_t *apiClient, char * token , char * userid , char * listname );


// Remove a user from a course group
//
// Allows the user to remove a staff member from availability to a course group.
//
void
DefaultAPI_eventregremoveuserfromgroup(apiClient_t *apiClient, char * token , char * userid , char * codegroup , char * listname );


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


// Delete an interaction
//
void
DefaultAPI_interactiondelete(apiClient_t *apiClient, char * token , char * id );


// Get the interactions feed
//
void
DefaultAPI_interactionfeed(apiClient_t *apiClient, char * token , int from , int count , char startdate , int public , char * contexttype , char * contextid , char * types , int photosize , int showdefaultphoto , int orderdescending );


// View an interaction
//
void
DefaultAPI_interactionget(apiClient_t *apiClient, char * token , char * id , int thumbnailmediasize , int photosize );


// Get current user's latest private interactions
//
void
DefaultAPI_interactionlistprivatesummary(apiClient_t *apiClient, char * token , int photosize , int showdefaultphoto );


// Save an interaction
//
void
DefaultAPI_interactionsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Delete a like
//
void
DefaultAPI_likedelete(apiClient_t *apiClient, char * token , char * interactionid );


// View all the likes associated to a target
//
void
DefaultAPI_likelist(apiClient_t *apiClient, char * token , char * interactionid , int photosize );


// Save a like
//
void
DefaultAPI_likesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Check in media item
//
// Allows the user to check in a media item.
//
void
DefaultAPI_mediacheckin(apiClient_t *apiClient, char * token , char * media , char checkindate , char * notes );


// Check out media item
//
// Allows the user to check out a media item.
//
void
DefaultAPI_mediacheckout(apiClient_t *apiClient, char * token , char * media , char * user , char checkoutdate , char duedate , char * staff , char * event , char * notes );


// View a list of past media checkouts
//
// Allows the user to view a list of all past checkouts
//
void
DefaultAPI_mediacheckoutlist(apiClient_t *apiClient, char * token , int from , int count , char * media , char * user , int photosize );


// Delete a media item
//
// Allows the user to delete an existing media item.
//
void
DefaultAPI_mediadelete(apiClient_t *apiClient, char * token , char * id );


// Delete a media checkout log
//
// Allows the user to delete a media item's checkout log.
//
void
DefaultAPI_mediadeletecheckoutlog(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a media item
//
// Allows the user to view an individual media item and its details.
//
void
DefaultAPI_mediaget(apiClient_t *apiClient, char * token , char * id );


// Search media item by unique code
//
// Allows the user to search for media items by their unique code.
//
void
DefaultAPI_mediagetbycode(apiClient_t *apiClient, char * token , char * code , char * location );


// View details of a media item checkout information
//
// Allows the user to view a media item's checkout information.
//
void
DefaultAPI_mediagetcheckout(apiClient_t *apiClient, char * token , char * id , int photosize );


// View details of a media checkout log
//
// Allows the user to view a media item's checkout history.
//
void
DefaultAPI_mediagetcheckoutlog(apiClient_t *apiClient, char * token , char * id , int photosize );


// View a list of media items
//
// Allows the user to view the list of all media items tied to locations in which the user is scoped.
//
void
DefaultAPI_medialist(apiClient_t *apiClient, char * token , int from , int count , int status , char * user );


// Create or edit a media item
//
// Allows the user to create or edit a media item.
//
void
DefaultAPI_mediasave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete a media type
//
// Allows the user to delete an existing media type.
//
void
DefaultAPI_mediatypedelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a media type
//
// Allows the user to view a media type and its details.
//
void
DefaultAPI_mediatypeget(apiClient_t *apiClient, char * token , char * id );


// View a list of media types
//
// Allows the user to view the list of all media types.
//
void
DefaultAPI_mediatypelist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit a media type
//
// Allows the user to create or edit a media type.
//
void
DefaultAPI_mediatypesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Flags one rating for moderation
//
void
DefaultAPI_ratingflag(apiClient_t *apiClient, char * token , char * id , char * comment );


// Flags one comment for moderation
//
void
DefaultAPI_ratingflagcomment(apiClient_t *apiClient, char * token , char * id , char * comment );


// Get rating for one or more entities
//
void
DefaultAPI_ratingget(apiClient_t *apiClient, char * token , char * type , char * entityids );


// Gets the full ratings and comments for a specific entity
//
void
DefaultAPI_ratinggetall(apiClient_t *apiClient, char * token , char * type , char * entityid , int mostrecentfirst );


// Gets all the comments for a rating
//
void
DefaultAPI_ratinggetcomments(apiClient_t *apiClient, char * token , char * ratingid );


// Gets info of pre-saved and pre-approved ratings
//
void
DefaultAPI_ratinggetpending(apiClient_t *apiClient, char * getgroup , char * rateid , int rateval );


// Shows a list of the ratings and comments that are pending for moderation
//
// Allows the user to view the list of pending ratings and comments.
//
void
DefaultAPI_ratinggetpendingmoderation(apiClient_t *apiClient, char * token );


// Allows the user to accept or reject a comment
//
// Allows the user to approve or reject a comment or rating.
//
void
DefaultAPI_ratingmoderate(apiClient_t *apiClient, char * token , char * type , char * id , int approve );


// Posts a comments for in a rating
//
void
DefaultAPI_ratingpostcomment(apiClient_t *apiClient, char * token , char * ratingid , char * comment , int annonymous );


// Rates one entity
//
void
DefaultAPI_ratingrate(apiClient_t *apiClient, char * token , char * type , char * entityid , int annonymous , int value , char * comment , int updatecomment );


// Rates a pre-saved and pre-approved entity
//
void
DefaultAPI_ratingratepending(apiClient_t *apiClient, char * group , int annonymous , char * rateid , int value , char * comment , int updatecomment );


// Votes up or down a rating
//
void
DefaultAPI_ratingvote(apiClient_t *apiClient, char * token , char * ratingid , int vote );


// Query and load an attendance analytics report
//
// Allows the user to query and load attendance analytics reports.
//
void
DefaultAPI_reportattanalyticsprepare(apiClient_t *apiClient, char * token , char * reportname , char * params , char * refreshgroup );


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


// Delete a report schedule
//
// Allows the user to delete a scheduled report that they created.
//
void
DefaultAPI_reportscheduledelete(apiClient_t *apiClient, char * token , char * id );


// Get a report schedule
//
// Allows the user to view the list of reports that they scheduled.
//
void
DefaultAPI_reportscheduleget(apiClient_t *apiClient, char * token , char * id );


// View a list of the scheduled reports
//
// Allows the user to view a list of the scheduled reports.
//
void
DefaultAPI_reportschedulelist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit a report schedule
//
// Allows the user to create or edit a scheduled report.
//
void
DefaultAPI_reportschedulesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Queries and loads a report in background and assigns (or unassigns) the specified tags to (from) the resulting users.
//
// Allows the user to use a report to assign or unassign tags.
//
void
DefaultAPI_reporttagresults(apiClient_t *apiClient, char * token , char * reportname , int assign , char * tags , char * params );


// Check the status of the analysis of a specified risk assessment model
//
// Allows the user to check the status of a risk assessment model as it is being processed.
//
void
DefaultAPI_riskmodelcheckanalysis(apiClient_t *apiClient, char * token , char * id );


// Delete a risk assessment model
//
// Allows the user to delete a previously created risk assessment model.
//
void
DefaultAPI_riskmodeldelete(apiClient_t *apiClient, char * token , char * id );


// View details of a risk assessment model
//
// Allows the user to view an individual risk assessment model and its details.
//
void
DefaultAPI_riskmodelget(apiClient_t *apiClient, char * token , char * id );


// View the risk score for a specific user
//
// Allows the user to view the risk score of another user.
//
void
DefaultAPI_riskmodelgetscore(apiClient_t *apiClient, char * token , char * userid );


// View a list of risk assessment models
//
// Allows the user to view the full list of risk assessment models.
//
void
DefaultAPI_riskmodellist(apiClient_t *apiClient, char * token , int from , int count );


// Predict risk based on an assessment model
//
// Allows a user to process a risk prediction from a risk assessment model that has processed.
//
void
DefaultAPI_riskmodelpredict(apiClient_t *apiClient, char * token , char * id );


// Process a risk assessment model
//
// Allows the user to process a risk assessment model once it has been created.
//
void
DefaultAPI_riskmodelprocess(apiClient_t *apiClient, char * token , char * id );


// Refresh the information used in a risk assessment model
//
// Allows the user to refresh a risk assessment model.
//
void
DefaultAPI_riskmodelrefresh(apiClient_t *apiClient, char * token , char * id );


// Create or edit a risk assessment model
//
// Allows the user to create or edit a risk assessment model.
//
void
DefaultAPI_riskmodelsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View all default term precedences
//
// Allows the user to view the default term precedences used in a model.
//
void
DefaultAPI_riskmodeltermprecedences(apiClient_t *apiClient, char * token );


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


// Delete a schedule slot
//
// Allows the user to delete a schedule slot from another user.
//
void
DefaultAPI_scheduledelete(apiClient_t *apiClient, char * token , char * scheduleid );


// Delete a specific block from a user's own schedule
//
// Allows the user to delete a schedule block from their own availability.
//
void
DefaultAPI_scheduledeletemine(apiClient_t *apiClient, char * token , char * scheduleid );


// Enable or disable the schedule for a specific person
//
// Allows the user to enable or disable a schedule for another user.
//
void
DefaultAPI_scheduleenable(apiClient_t *apiClient, char * token , char * userid , int enable );


// Enable or disable current user's schedule
//
// Allows the user to enable or disable a schedule for himself.
//
void
DefaultAPI_scheduleenablemine(apiClient_t *apiClient, char * token , int enable );


// Search available schedule slots by service, event, date
//
// Allows users to search available slots.
//
void
DefaultAPI_schedulefindallstaffslots(apiClient_t *apiClient, char * token , char starttime , char endtime , char * staffid , char * serviceids , char * eventid , char * locationid , char * staffroleids , char * availablefor );


// Search available schedule slots by service, event, date and/or staff
//
// Allows users to search available slots when making appointments.
//
void
DefaultAPI_schedulefindslots(apiClient_t *apiClient, char * token , char * staffid , char starttime , char endtime , char * serviceids , char * eventid , char * locationid , char * availablefor );


// Search available staff members slots by service, event, and/or date
//
// Allows users to search available staff.
//
void
DefaultAPI_schedulefindstaffavail(apiClient_t *apiClient, char * token , char starttime , char endtime , char * serviceids , char * eventid , char * locationid , char * staffroleids , char * availablefor , int photosize );


// Search and view details of a specific schedule slot
//
// Allows the user to view the details of schedule shifts for any user role that the user has permission to view.
//
void
DefaultAPI_scheduleget(apiClient_t *apiClient, char * token , char * scheduleid );


// View details of a specific schedule block, for current user
//
// Allows the user to view the details of their own schedule shifts.
//
void
DefaultAPI_schedulegetmine(apiClient_t *apiClient, char * token , char * scheduleid );


// View a list of schedule information of a specified person
//
// Allows the user to view the schedule shifts for user roles that the user has permission to access.
//
void
DefaultAPI_schedulegetstaff(apiClient_t *apiClient, char * token , char * userid );


// View current user's schedule information
//
// Allows the user to view their own schedule.
//
void
DefaultAPI_schedulegetstaffmine(apiClient_t *apiClient, char * token );


// Delete a schedule item looking up by a third party ID
//
void
DefaultAPI_scheduleintegrationdeleteitem(apiClient_t *apiClient, char * token , char * thirdpartyid );


// Delete multiple schedule items looking up by a third party master ID
//
void
DefaultAPI_scheduleintegrationdeleteitemsbymasterid(apiClient_t *apiClient, char * token , char * thirdpartymasterid );


// Get a schedule item looking up by a third party ID
//
void
DefaultAPI_scheduleintegrationgetitem(apiClient_t *apiClient, char * token , char * thirdpartyid );


// Save a schedule item looking up by a third party ID
//
void
DefaultAPI_scheduleintegrationsaveitem(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Set a 3rd party ID on a specific schedule item
//
void
DefaultAPI_scheduleintegrationsetid(apiClient_t *apiClient, char * token , char * id , char * thirdpartyid , char * thirdpartymasterid );


// View current user's schedule exceptions
//
// Allows the user to view their own schedule exceptions.
//
void
DefaultAPI_schedulemyofftimes(apiClient_t *apiClient, char * token , int includedeleted , int onlyupcoming , char modifiedafter );


// Create or edit a schedule slot
//
// Allows the user to create or edit a schedule slot of another user.
//
void
DefaultAPI_schedulesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Create or edit a block in current user's schedule
//
// Allows the user to create or edit a schedule shift in their own availability.
//
void
DefaultAPI_schedulesavemine(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Delete an event
//
// Allows the user to delete an existing event.
//
void
DefaultAPI_seminardelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a event
//
// Allows the user to view a event and its details.
//
void
DefaultAPI_seminarget(apiClient_t *apiClient, char * token , char * id );


// View a list of events
//
// Allows the user to view the full list of events in the past, present, and future.
//
void
DefaultAPI_seminarlist(apiClient_t *apiClient, char * token , char * from , char * count , int summaryonly , char * termid );


// Create or edit a event
//
// Allows the user to create or edit a event.
//
void
DefaultAPI_seminarsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Enable a service in a specific location
//
// Allows the user to enable a service in a location to which they are scoped.
//
void
DefaultAPI_serviceassignmentaddservice(apiClient_t *apiClient, char * token , char * serviceid , char * locationid );


// View a list of services enabled for a specific location
//
// Allows the user to view a list of services available in a location to which they are scoped.
//
void
DefaultAPI_serviceassignmentgetlocation(apiClient_t *apiClient, char * token , char * locationid , int includegloballyavailable , int namefilter , int count );


// View a list of locations where a service is available
//
// Allows the user to view a list of locations in which a service is available.
//
void
DefaultAPI_serviceassignmentgetservice(apiClient_t *apiClient, char * token , char * serviceid );


// Remove a service from a location
//
// Allows the user to disable a service from a location to which they are scoped.
//
void
DefaultAPI_serviceassignmentremoveservice(apiClient_t *apiClient, char * token , char * serviceid , char * locationid );


// Delete a service
//
// Allows the user to delete a service from the existing list.
//
void
DefaultAPI_servicedelete(apiClient_t *apiClient, char * token , char * id );


// Search and view details of a service
//
// Allows the user to view an individual service and its details.
//
void
DefaultAPI_serviceget(apiClient_t *apiClient, char * token , char * id );


// View a list of services
//
// Allows the user to view the full list of existing services.
//
void
DefaultAPI_servicelist(apiClient_t *apiClient, char * token , int from , int count );


// Create or edit a service
//
// Allows the user to create or edit a service.
//
void
DefaultAPI_servicesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Add a note to a class attendance log
//
// Allows the user to add a note to a class attendance log.
//
void
DefaultAPI_sessionattendancelogaddnote(apiClient_t *apiClient, char * token , char * id , char * text );


// View details of a class attendance log
//
// Allows the user to view an individual class attendance log and its details.
//
void
DefaultAPI_sessionattendancelogget(apiClient_t *apiClient, char * token , char * id , int photosize );


// View the class session attendance information for a specific user
//
// Allows the user to view the attendance for a specified student.
//
void
DefaultAPI_sessionattendanceloggetuser(apiClient_t *apiClient, char * attendee , char * eventid , char * token );


// View attendance logs of the specified session
//
// Allows the user to view the full list of logs from a specified session
//
void
DefaultAPI_sessionattendanceloglist(apiClient_t *apiClient, char * token , char * session , int from , int count , int photosize );


// View the attendance information of an entire class
//
// Allows the user to view the attendance information for an entire class
//
void
DefaultAPI_sessionattendanceloglistevent(apiClient_t *apiClient, char * eventid , char * token );


// View the attendance summary for a class and/or a attendee
//
// Allows the user to view the attendance summary for a given class and/or attendee.
//
void
DefaultAPI_sessionattendanceloglistsummary(apiClient_t *apiClient, char * token , char * eventid , char * attendeeid , char * groupid , char * start , char * end );


// View my attendance summary
//
// Allows the user to view their own attendance summary.
//
void
DefaultAPI_sessionattendancelogmylistsummary(apiClient_t *apiClient, char * token , char * eventid , char * start , char * end );


// Create or edit a class attendance log
//
// Allows the user to create or edit a class attendance log.
//
void
DefaultAPI_sessionattendancelogsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Create or edit a class attendance log swipe
//
// Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.
//
void
DefaultAPI_sessionattendancelogsaveswipe(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Bulk update event sessions
//
// Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.
//
void
DefaultAPI_sessionbulkupdate(apiClient_t *apiClient, char * token , char * eventid , char * sessions );


// View details of a session
//
// Allows the user to view a session in order to take attendance.
//
void
DefaultAPI_sessionget(apiClient_t *apiClient, char * token , char * id );


// Gets the schedule for a location, instructor or attendees
//
void
DefaultAPI_sessiongetschedule(apiClient_t *apiClient, char * token , char day , char * attendee , char * location , char * instructor );


// Gets all future sessions of the current semester
//
void
DefaultAPI_sessionlist(apiClient_t *apiClient, int from , int count , char * token , char startdate , char enddate );


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


// Delete a session swipe
//
// Allows the user to delete an existing class attendance swipe.
//
void
DefaultAPI_sessionswipedelete(apiClient_t *apiClient, char * token , char * id );


// View details of a class attendance swipe
//
// Allows the user to view an individual class attendance swipe.
//
void
DefaultAPI_sessionswipeget(apiClient_t *apiClient, char * token , char * id );


// View a list of unresolved swipes
//
// Allows the user to view all unresolved swipes.
//
void
DefaultAPI_sessionswipelistunresolved(apiClient_t *apiClient, int from , int count , char * token );


// Resolve a swipe and create the corresponding attendance log
//
// Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.
//
void
DefaultAPI_sessionswiperesolve(apiClient_t *apiClient, char * token , char * id , char * session , char * user );


// Creates a new swipe, and if possible, creates the attendance log
//
// Allows the user to create a new swipe, which would usually result in an attendance log.
//
void
DefaultAPI_sessionswipesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Creates a new swipe from a sign-in station, and if possible, creates the attendance log
//
void
DefaultAPI_sessionswipesaveanonym(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Gets the list of contacts in the network
//
void
DefaultAPI_socialcontacts(apiClient_t *apiClient, char * token , char * filter , int showdefaultphoto );


// Adds new members to a group (which the user must own already)
//
void
DefaultAPI_socialgroupaddmembers(apiClient_t *apiClient, char * token , char * id , char * userids );


// Deletes a group
//
void
DefaultAPI_socialgroupdelete(apiClient_t *apiClient, char * token , char * id );


// View all the groups the current user is in
//
void
DefaultAPI_socialgrouplist(apiClient_t *apiClient, char * token );


// Lists the members of a group
//
void
DefaultAPI_socialgrouplistmembers(apiClient_t *apiClient, char * token , char * id );


// Removes members from a group (which the user must own already)
//
void
DefaultAPI_socialgroupremovemembers(apiClient_t *apiClient, char * token , char * id , char * userids );


// Removes myself from an existent group
//
void
DefaultAPI_socialgroupremovemyself(apiClient_t *apiClient, char * token , char * id );


// Saves a new group
//
void
DefaultAPI_socialgroupsave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Associate current user to all services
//
// Allows the user to associate themselves to all services, provided they have a staff role.
//
void
DefaultAPI_staffavailaddmetoallservices(apiClient_t *apiClient, char * token );


// Associate current user to a service
//
// Allows the user to associate themselves to a service, provided they have a staff role.
//
void
DefaultAPI_staffavailaddmetoservice(apiClient_t *apiClient, char * token , char * serviceid );


// Associate a staff member to all services
//
// Allows the user to make a staff member available for all services.
//
void
DefaultAPI_staffavailaddusertoallservices(apiClient_t *apiClient, char * token , char * userid );


// Associate a staff member to a service
//
// Allows the user to make a staff member available for a service.
//
void
DefaultAPI_staffavailaddusertoservice(apiClient_t *apiClient, char * token , char * userid , char * serviceid );


// View the services the current user is available for
//
// Allows the user to view a list of services that they are associated with.
//
void
DefaultAPI_staffavailgetmyservices(apiClient_t *apiClient, char * token );


// View a list of services that a staff member is available for
//
// Allows the user to view the list of services that a staff member is available for.
//
void
DefaultAPI_staffavailgetservices(apiClient_t *apiClient, char * token , char * userid );


// View a list of staff members that are available for a specific service
//
// Allows the user to view all staff members who are available for a service.
//
void
DefaultAPI_staffavailgetusersforservice(apiClient_t *apiClient, char * token , char * serviceid );


// View all the availability types
//
void
DefaultAPI_staffavaillisttypes(apiClient_t *apiClient, char * token );


// Remove current user from all services
//
// Allows the user to disassociate themselves from all services, provided they have a staff role.
//
void
DefaultAPI_staffavailremovemefromallservices(apiClient_t *apiClient, char * token );


// Remove current user from a service
//
// Allows the user to disassociate themselves from a service, provided they have a staff role.
//
void
DefaultAPI_staffavailremovemefromservice(apiClient_t *apiClient, char * token , char * serviceid );


// Removes a staff member from the registration to all services
//
// Allows the user to remove a staff member's availability to all services.
//
void
DefaultAPI_staffavailremoveuserfromallservices(apiClient_t *apiClient, char * token , char * userid );


// Remove a staff member from a service
//
// Allows the user to remove a staff member's service availability.
//
void
DefaultAPI_staffavailremoveuserfromservice(apiClient_t *apiClient, char * token , char * userid , char * serviceid );


// Make a staff member available for a specific availability type
//
// Allows the user to set a staff member as available for walk ins, appointments, or both.
//
void
DefaultAPI_staffavailsetavailability(apiClient_t *apiClient, char * token , char * userid , char * availablefor );


// Change current user's availability type
//
// Allows the user to make themselves available for walk ins, appointments, or both.
//
void
DefaultAPI_staffavailsetmyavailability(apiClient_t *apiClient, char * token , char * availablefor );


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


// View the sign-in station settings of a specified location
//
// Allows the user to view the location settings of a sign-in station.
//
void
DefaultAPI_stationgetlocationsettings(apiClient_t *apiClient, char * location );


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


// Create or edit a class attendance sign-in station for myself
//
// Allows the user to create a class attendance sign-in station for a course for which they are available as staff.
//
void
DefaultAPI_stationsavemine(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Assign tags to the members of a specified group
//
// Allows the user to assign tags to the users of a group that they have permission to edit.
//
void
DefaultAPI_usergrouptagmembers(apiClient_t *apiClient, char * token , char * group , char * tags );


// Unassign tags from the members of a specified group
//
// Allows the user to unassign tags to the users of a group that they have permission to edit.
//
void
DefaultAPI_usergroupuntagmembers(apiClient_t *apiClient, char * token , char * group , char * tags );


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


// Delete a user profile
//
// Allows the user to delete a profile from the list of profiles that they have permission to edit.
//
void
DefaultAPI_userprofiledelete(apiClient_t *apiClient, char * token , char * id );


// View a specific user profile
//
// Allows the user to view individual user profiles and their details, provided they have permission to view that profile.
//
void
DefaultAPI_userprofileget(apiClient_t *apiClient, char * token , char * id );


// Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
//
// Allows the user to view a profile for a user, provided they have permission to view that user and profile.
//
void
DefaultAPI_userprofilegetallview(apiClient_t *apiClient, char * token , char * id );


// View the list of user profiles
//
// Allows the user to view the full list of profiles that they have permission to view.
//
void
DefaultAPI_userprofilelist(apiClient_t *apiClient, char * token , int from , int count );


// Gets the list of all the available user questions
//
// Allows the user to view the list of questions in a profile that they have permission to view.
//
void
DefaultAPI_userprofilelistquestions(apiClient_t *apiClient, char * token );


// Gets the statistics of a user group
//
// Allows the user to view the demographic statistics of a user group.
//
void
DefaultAPI_userprofilepreparestats(apiClient_t *apiClient, char * token , char * params );


// Create or edit user profile questions
//
// Allows the user to create or edit a user profile.
//
void
DefaultAPI_userprofilesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
//
// Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.
//
void
DefaultAPI_userprofilesaveanswers(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


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


// Add myself to a waiting line
//
// Allows the user to add themselves to a waiting line from the AccuCampus mobile app.
//
void
DefaultAPI_virtuallineaddmyself(apiClient_t *apiClient, char * token , char * waitinglineid );


// Lists waiting lines that have remote access enabled
//
void
DefaultAPI_virtuallinelist(apiClient_t *apiClient, char * token );


// Remove myself from a waiting line
//
// Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.
//
void
DefaultAPI_virtuallineremovemyself(apiClient_t *apiClient, char * token );


// Put user in a waiting line
//
void
DefaultAPI_waitinglineadduser(apiClient_t *apiClient, char * station , char * user , char * locationid , char time , char * signinrole , char * roleid , char * services , char * eventid , char * staff , int photosize );


// Delete a waiting line
//
// Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.
//
void
DefaultAPI_waitinglinedelete(apiClient_t *apiClient, char * token , char * id );


// View details of a waiting line
//
// Allows the user to view the details of a waiting line in a location to which they are scoped.
//
void
DefaultAPI_waitinglineget(apiClient_t *apiClient, char * token , char * id , int photosize );


// Check whether a user is in a waiting line, signed-in or is not in the area
//
void
DefaultAPI_waitinglineisuserin(apiClient_t *apiClient, char * station , char time , char * user , char * location );


// View a list of waiting lines
//
// Allows the user to view the list of waiting lines in locations to which they are scoped.
//
void
DefaultAPI_waitinglinelist(apiClient_t *apiClient, char * token , int from , int count );


// Remove a user from a waiting line
//
// Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.
//
void
DefaultAPI_waitinglineremoveuser(apiClient_t *apiClient, char * token , char * waitingline , char * itemid );


// Create or edit a waiting line
//
// Allows the user to create or edit a waiting line in a location to which they are scoped.
//
void
DefaultAPI_waitinglinesave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Sign a user in from a waiting line
//
// Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.
//
void
DefaultAPI_waitinglinesigninuser(apiClient_t *apiClient, char * token , char * waitingline , char * itemid , char * staff , int photosize );


