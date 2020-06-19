#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Lists available user settings
//
void
UsersettingsAPI_usersettingsGet(apiClient_t *apiClient, char * keys , char * user );


// Get multiple user settings
//
void
UsersettingsAPI_usersettingsGetmultiple(apiClient_t *apiClient, char * keys , char * user );


// Saves a user setting
//
void
UsersettingsAPI_usersettingsSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Save multiple user settings at once
//
void
UsersettingsAPI_usersettingsSavemultiple(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


