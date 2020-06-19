#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete an action item
//
// Allows the user to delete an action item.
//
void
ActionitemAPI_actionitemDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of an action item
//
// Allows the user to view an individual action item and its details.
//
void
ActionitemAPI_actionitemGet(apiClient_t *apiClient, char * id );


// View a list of action items
//
// Allows the user to view a list of action items
//
void
ActionitemAPI_actionitemList(apiClient_t *apiClient, int from , int count );


// Create or edit an action item
//
// Allows the user to edit an action item.
//
void
ActionitemAPI_actionitemSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


