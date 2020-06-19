#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Bulk update event sessions
//
// Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.
//
void
SessionAPI_sessionBulkupdate(apiClient_t *apiClient, char * eventid , char * sessions );


// View details of a session
//
// Allows the user to view a session in order to take attendance.
//
void
SessionAPI_sessionGet(apiClient_t *apiClient, char * id );


// Gets the schedule for a location, instructor or attendees
//
void
SessionAPI_sessionGetschedule(apiClient_t *apiClient, char day , char * attendee , char * location , char * instructor );


// Gets all future sessions of the current semester
//
void
SessionAPI_sessionList(apiClient_t *apiClient, int from , int count , char startdate , char enddate );


