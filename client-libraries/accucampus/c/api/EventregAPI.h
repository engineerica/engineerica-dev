#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Register current user to a course
//
// Allows the user to make themselves available for individual courses.
//
void
EventregAPI_eventregAddme(apiClient_t *apiClient, char * eventid , char * listname );


// Register current user to all courses
//
// Allows the user to make themselves available for all courses.
//
void
EventregAPI_eventregAddmetoall(apiClient_t *apiClient, char * listname );


// Register current user to a course group
//
// Allows the user to make themselves available for a course group.
//
void
EventregAPI_eventregAddmetogroup(apiClient_t *apiClient, char * codegroup , char * listname );


// Register a user to a course for attendance
//
// Allows the user to register a user to a course.
//
void
EventregAPI_eventregAdduser(apiClient_t *apiClient, char * userid , char * eventid , char * listname );


// Register a user to assist with all courses
//
// Allows the user to make a staff member available to assist with all courses.
//
void
EventregAPI_eventregAddusertoall(apiClient_t *apiClient, char * userid , char * listname );


// Register a user to an course group
//
// Allows the user to make a staff member available for a course group.
//
void
EventregAPI_eventregAddusertogroup(apiClient_t *apiClient, char * userid , char * codegroup , char * listname );


// View course registration by user
//
// Allows the user to view all courses a given user is registered to, provided they have permission to view that user.
//
void
EventregAPI_eventregGetevents(apiClient_t *apiClient, char * userid , char * listname , char * termid , char * namefilter );


// Lists the course group registrations of a user
//
// Allows the user to view the course groups a staff member is available for.
//
void
EventregAPI_eventregGetgroups(apiClient_t *apiClient, char * userid , char * listname );


// View the event registrations of the current user
//
void
EventregAPI_eventregGetmyevents(apiClient_t *apiClient, char * listname , char * termid , char * namefilter );


// View all current user registrations to course groups
//
// Allows the user to view all his registrations to course groups.
//
void
EventregAPI_eventregGetmygroups(apiClient_t *apiClient, char * listname );


// View course registration
//
// Allows the user to view all users registered for an individual course.
//
void
EventregAPI_eventregGetusers(apiClient_t *apiClient, char * eventid , char * listname , int photosize );


// Lists the registrations for a course group
//
// Allows the user the get the staff members registered to a specific course group
//
void
EventregAPI_eventregGetusersfromgroup(apiClient_t *apiClient, char * codegroup , char * listname );


// View the users that are registered to all courses
//
// Allows the user to view all staff members available for all courses.
//
void
EventregAPI_eventregGetuserstoall(apiClient_t *apiClient, char * listname );


// Unregister current user from a course
//
// Allows the user to remove themselves from registration to a course.
//
void
EventregAPI_eventregRemoveme(apiClient_t *apiClient, char * eventid , char * listname );


// Remove current user from the registration to all courses
//
// Allows the user to remove themselves from availability to all courses.
//
void
EventregAPI_eventregRemovemefromall(apiClient_t *apiClient, char * listname );


// Remove current user from a course group
//
// Allows the user to remove themselves from availability to a course group.
//
void
EventregAPI_eventregRemovemefromgroup(apiClient_t *apiClient, char * codegroup , char * listname );


// Remove a user from a course
//
// Allows the user to remove a user from a course's registration.
//
void
EventregAPI_eventregRemoveuser(apiClient_t *apiClient, char * userid , char * eventid , char * listname );


// Remove a user from the registration to all courses
//
// Allows the user to remove a staff member from availability to all courses.
//
void
EventregAPI_eventregRemoveuserfromall(apiClient_t *apiClient, char * userid , char * listname );


// Remove a user from a course group
//
// Allows the user to remove a staff member from availability to a course group.
//
void
EventregAPI_eventregRemoveuserfromgroup(apiClient_t *apiClient, char * userid , char * codegroup , char * listname );


