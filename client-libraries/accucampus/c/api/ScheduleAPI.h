#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a schedule slot
//
// Allows the user to delete a schedule slot from another user.
//
void
ScheduleAPI_scheduleDelete(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete a specific block from a user's own schedule
//
// Allows the user to delete a schedule block from their own availability.
//
void
ScheduleAPI_scheduleDeletemine(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Enable or disable the schedule for a specific person
//
// Allows the user to enable or disable a schedule for another user.
//
void
ScheduleAPI_scheduleEnable(apiClient_t *apiClient, char * userid , int enable );


// Enable or disable current user's schedule
//
// Allows the user to enable or disable a schedule for himself.
//
void
ScheduleAPI_scheduleEnablemine(apiClient_t *apiClient, int enable );


// Search available schedule slots by service, event, date
//
// Allows users to search available slots.
//
void
ScheduleAPI_scheduleFindallstaffslots(apiClient_t *apiClient, char starttime , char endtime , char * staffid , char * serviceids , char * eventid , char * locationid , char * staffroleids , char * availablefor );


// Search available schedule slots by service, event, date and/or staff
//
// Allows users to search available slots when making appointments.
//
void
ScheduleAPI_scheduleFindslots(apiClient_t *apiClient, char * staffid , char starttime , char endtime , char * serviceids , char * eventid , char * locationid , char * availablefor );


// Search available staff members slots by service, event, and/or date
//
// Allows users to search available staff.
//
void
ScheduleAPI_scheduleFindstaffavail(apiClient_t *apiClient, char starttime , char endtime , char * serviceids , char * eventid , char * locationid , char * staffroleids , char * availablefor , int photosize );


// Search and view details of a specific schedule slot
//
// Allows the user to view the details of schedule shifts for any user role that the user has permission to view.
//
void
ScheduleAPI_scheduleGet(apiClient_t *apiClient, char * scheduleid );


// View details of a specific schedule block, for current user
//
// Allows the user to view the details of their own schedule shifts.
//
void
ScheduleAPI_scheduleGetmine(apiClient_t *apiClient, char * scheduleid );


// View a list of schedule information of a specified person
//
// Allows the user to view the schedule shifts for user roles that the user has permission to access.
//
void
ScheduleAPI_scheduleGetstaff(apiClient_t *apiClient, char * userid );


// View current user's schedule information
//
// Allows the user to view their own schedule.
//
void
ScheduleAPI_scheduleGetstaffmine(apiClient_t *apiClient);


// View current user's schedule exceptions
//
// Allows the user to view their own schedule exceptions.
//
void
ScheduleAPI_scheduleMyofftimes(apiClient_t *apiClient, int includedeleted , int onlyupcoming , char modifiedafter );


// Create or edit a schedule slot
//
// Allows the user to create or edit a schedule slot of another user.
//
void
ScheduleAPI_scheduleSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Create or edit a block in current user's schedule
//
// Allows the user to create or edit a schedule shift in their own availability.
//
void
ScheduleAPI_scheduleSavemine(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


