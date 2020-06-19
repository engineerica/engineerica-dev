#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Add a note to a class attendance log
//
// Allows the user to add a note to a class attendance log.
//
void
SessionattendancelogAPI_sessionattendancelogAddnote(apiClient_t *apiClient, char * id , char * text );


// View details of a class attendance log
//
// Allows the user to view an individual class attendance log and its details.
//
void
SessionattendancelogAPI_sessionattendancelogGet(apiClient_t *apiClient, char * id , int photosize );


// View the class session attendance information for a specific user
//
// Allows the user to view the attendance for a specified student.
//
void
SessionattendancelogAPI_sessionattendancelogGetuser(apiClient_t *apiClient, char * attendee , char * eventid );


// View attendance logs of the specified session
//
// Allows the user to view the full list of logs from a specified session
//
void
SessionattendancelogAPI_sessionattendancelogList(apiClient_t *apiClient, char * session , int from , int count , int photosize );


// View the attendance information of an entire class
//
// Allows the user to view the attendance information for an entire class
//
void
SessionattendancelogAPI_sessionattendancelogListevent(apiClient_t *apiClient, char * eventid );


// View the attendance summary for a class and/or a attendee
//
// Allows the user to view the attendance summary for a given class and/or attendee.
//
void
SessionattendancelogAPI_sessionattendancelogListsummary(apiClient_t *apiClient, char * eventid , char * attendeeid , char * groupid , char * start , char * end );


// View my attendance summary
//
// Allows the user to view their own attendance summary.
//
void
SessionattendancelogAPI_sessionattendancelogMylistsummary(apiClient_t *apiClient, char * eventid , char * start , char * end );


// Create or edit a class attendance log
//
// Allows the user to create or edit a class attendance log.
//
void
SessionattendancelogAPI_sessionattendancelogSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Create or edit a class attendance log swipe
//
// Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.
//
void
SessionattendancelogAPI_sessionattendancelogSaveswipe(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


