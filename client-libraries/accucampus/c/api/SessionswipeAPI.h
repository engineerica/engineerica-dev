#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a session swipe
//
// Allows the user to delete an existing class attendance swipe.
//
void
SessionswipeAPI_sessionswipeDelete(apiClient_t *apiClient, char * id ,  body );


// View details of a class attendance swipe
//
// Allows the user to view an individual class attendance swipe.
//
void
SessionswipeAPI_sessionswipeGet(apiClient_t *apiClient, char * id );


// View a list of unresolved swipes
//
// Allows the user to view all unresolved swipes.
//
void
SessionswipeAPI_sessionswipeListunresolved(apiClient_t *apiClient, int from , int count );


// Resolve a swipe and create the corresponding attendance log
//
// Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.
//
void
SessionswipeAPI_sessionswipeResolve(apiClient_t *apiClient, char * id , char * session , char * user );


// Creates a new swipe, and if possible, creates the attendance log
//
// Allows the user to create a new swipe, which would usually result in an attendance log.
//
void
SessionswipeAPI_sessionswipeSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Creates a new swipe from a sign-in station, and if possible, creates the attendance log
//
void
SessionswipeAPI_sessionswipeSaveanonym(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


