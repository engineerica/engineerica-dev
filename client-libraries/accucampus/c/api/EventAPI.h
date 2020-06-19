#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Edit an event's sessions according to their schedule
//
// Allows the user to edit event sessions.
//
void
EventAPI_eventChecksessions(apiClient_t *apiClient, char * eventid , int autorepair );


// Delete a course
//
// Allows the user to delete an existing course.
//
void
EventAPI_eventDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a course
//
// Allows the user to view an individual course and its details.
//
void
EventAPI_eventGet(apiClient_t *apiClient, char * id );


// View a list of courses by date
//
// Allows the user to view a list of courses by date.
//
void
EventAPI_eventGetsessionsbydate(apiClient_t *apiClient, char * location , char date , char * type );


// View a list of courses
//
// Allows the user to view the full list of courses.
//
void
EventAPI_eventList(apiClient_t *apiClient, char * from , char * count , int summaryonly , char * termid );


// View a list of courses I am registered to
//
// Allows the user to view the courses they are registered to.
//
void
EventAPI_eventListregistered(apiClient_t *apiClient, char * from , char * count , int summaryonly , char * termid );


// Create or edit a course
//
// Allows the user to create or edit a course.
//
void
EventAPI_eventSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Searches for the available event groups
//
void
EventAPI_eventSearchgroup(apiClient_t *apiClient, char * query );


