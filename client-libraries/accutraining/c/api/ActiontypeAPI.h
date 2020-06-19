#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete an action item type
//
// Allows the user to delete an action item type.
//
void
ActiontypeAPI_actiontypeDelete(apiClient_t *apiClient, char * id ,  body );


// View details of an action item type
//
// Allows the user to view an individual action item type and its details.
//
void
ActiontypeAPI_actiontypeGet(apiClient_t *apiClient, char * id );


// View a list of action item types
//
// Allows the user to view the full list of action item types.
//
void
ActiontypeAPI_actiontypeList(apiClient_t *apiClient, int from , int count );


// Create or edit an action item type
//
// Allows the user to dit an action item type.
//
void
ActiontypeAPI_actiontypeSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


