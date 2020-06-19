#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete an attendance log
//
// Allows the user to delete an existing attendance log.
//
void
AttendancelogAPI_attendancelogDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of an attendance log
//
// Allows the user to view an individual attendance log and its details.
//
void
AttendancelogAPI_attendancelogGet(apiClient_t *apiClient, char * id );


// Search and view details of an attendance log's swipe history
//
// Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).
//
void
AttendancelogAPI_attendancelogGetchangehistory(apiClient_t *apiClient, char * id );


// View a list of attendance logs
//
// Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.
//
void
AttendancelogAPI_attendancelogList(apiClient_t *apiClient, int from , int count , char * filter , char * userid );


// Gets the attendance logs of the current user
//
void
AttendancelogAPI_attendancelogListmine(apiClient_t *apiClient, int from , int count , char * filter );


// Create or edit an attendance log
//
// Allows the user to create or edit an attendance log.
//
void
AttendancelogAPI_attendancelogSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Sign out an attendance log
//
// Allows the user to sign out am attendance log from the Who's In page.
//
void
AttendancelogAPI_attendancelogSignout(apiClient_t *apiClient, char * id , char * location , char * event , char datetime );


// View who's in a location
//
// Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.
//
void
AttendancelogAPI_attendancelogWhosin(apiClient_t *apiClient, int from , int count , char * location , char * event , char * sorting , char * roles , int photosize , char * extensions , int export );


