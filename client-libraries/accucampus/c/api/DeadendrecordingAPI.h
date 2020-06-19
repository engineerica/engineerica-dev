#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Deletes a dead-end record group
//
// Allows the user to delete a dead end record group.
//
void
DeadendrecordingAPI_deadendrecordingDelete(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Lists the recorded dead ends, if enabled
//
// Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.
//
void
DeadendrecordingAPI_deadendrecordingList(apiClient_t *apiClient);


// Lists the comments for a specific dead end
//
// Allows the user to view the comments made on dead end sessions.
//
void
DeadendrecordingAPI_deadendrecordingListcomments(apiClient_t *apiClient, char * hierarchykey );


// Saves a dead-end record
//
void
DeadendrecordingAPI_deadendrecordingSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


