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
ActionassignmentAPI_actionassignmentDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of an action item assigned to a user
//
// Allows the user to view an individual action item and its details, minus all the action item's updates.
//
void
ActionassignmentAPI_actionassignmentGet(apiClient_t *apiClient, char * id );


// View a list of action items in a user's plan
//
// Allows the user to view the list of all action items for a specified user.
//
void
ActionassignmentAPI_actionassignmentList(apiClient_t *apiClient, int from , int count , int assignee , int status );


// View the history of an action item assigned to a user
//
// Allows the user to view an individual action plan and its details, including all the action plan's updates.
//
void
ActionassignmentAPI_actionassignmentListhistory(apiClient_t *apiClient, char * actionassignment );


// List public action assignments assigned to the logged user
//
void
ActionassignmentAPI_actionassignmentListmine(apiClient_t *apiClient, int from , int count , int status );


// List public action assignment history
//
void
ActionassignmentAPI_actionassignmentListpublichistory(apiClient_t *apiClient, char * actionassignment );


// Bulk complete action items
//
// Allows the user to bulk complete action items.
//
void
ActionassignmentAPI_actionassignmentMarkcomplete(apiClient_t *apiClient, char * item , char * assignee , char * group , char * notes );


// Add an action item to a user's action plan
//
// Allows the user to edit or assign an action item to a user
//
void
ActionassignmentAPI_actionassignmentSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Update an action item assigned to a user
//
// Allows the user to update or mark an action item as complete.
//
void
ActionassignmentAPI_actionassignmentSavehistory(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


