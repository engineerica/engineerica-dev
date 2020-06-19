#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Assign an action item pack to a user
//
// Allows the user to assign an action pack to a user or group of users.
//
void
ActionpackAPI_actionpackAssign(apiClient_t *apiClient, char * pack , int itemsdata , char * assignee , char * group , char * notes );


// Delete an action item pack
//
// Allows the user to delete an action item pack.
//
void
ActionpackAPI_actionpackDelete(apiClient_t *apiClient, char * id ,  body );


// View details of an action item pack
//
// Allows the user to view an individual action pack and its details.
//
void
ActionpackAPI_actionpackGet(apiClient_t *apiClient, char * id );


// View a list of action item packs
//
// Allows the user to view the full list of action item packs.
//
void
ActionpackAPI_actionpackList(apiClient_t *apiClient, int from , int count );


// Create or edit an action item pack
//
// Allows the user to edit an action item pack.
//
void
ActionpackAPI_actionpackSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


