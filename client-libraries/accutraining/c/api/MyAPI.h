#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Gets the logged in user account.
//
void
MyAPI_myAccount(apiClient_t *apiClient);


// Gets the current time zone's iana name
//
void
MyAPI_myIanatimezone(apiClient_t *apiClient);


// Gets the logged in user information.
//
void
MyAPI_myProfile(apiClient_t *apiClient, int photosize );


// Gets the list of actions the user can execute.
//
void
MyAPI_myRights(apiClient_t *apiClient);


// Updates logged user's profile information
//
void
MyAPI_mySaveprofile(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


