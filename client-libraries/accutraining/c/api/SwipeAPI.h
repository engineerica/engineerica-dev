#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a swipe
//
// Allows the user to delete an existing attendance swipe.
//
void
SwipeAPI_swipeDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a swipe
//
// Allows the user to view an individual attendance swipe.
//
void
SwipeAPI_swipeGet(apiClient_t *apiClient, char * id );


// View a list of swipes
//
// Allows the user to view a list of all swipes for the location or locations in which the user is scoped.
//
void
SwipeAPI_swipeList(apiClient_t *apiClient, int from , int count );


// Create or edit a swipe, and if possible, save the related attendance log
//
// Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.
//
void
SwipeAPI_swipeSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Creates a new swipe from a sign-in station, and if possible, creates the attendance log
//
void
SwipeAPI_swipeSaveanonym(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


