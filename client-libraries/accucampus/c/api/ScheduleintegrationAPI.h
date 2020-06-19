#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Clear all third party IDs from specified staff member's schedule items.
//
void
ScheduleintegrationAPI_scheduleintegrationClearids(apiClient_t *apiClient, char * staff );


// Delete a schedule item looking up by a third party ID
//
void
ScheduleintegrationAPI_scheduleintegrationDeleteitem(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Delete multiple schedule items looking up by a third party master ID
//
void
ScheduleintegrationAPI_scheduleintegrationDeleteitemsbymasterid(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Get a schedule item looking up by a third party ID
//
void
ScheduleintegrationAPI_scheduleintegrationGetitem(apiClient_t *apiClient, char * thirdpartyid );


// Save a schedule item looking up by a third party ID
//
void
ScheduleintegrationAPI_scheduleintegrationSaveitem(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Set a 3rd party ID on a specific schedule item
//
void
ScheduleintegrationAPI_scheduleintegrationSetid(apiClient_t *apiClient, char * id , char * thirdpartyid , char * thirdpartymasterid );


