#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Returns the list of users for a specific permission
//
void
SecurityAPI_securityAssesspermission(apiClient_t *apiClient, char * commandname );


// Returns the list of permissions for a specific role
//
void
SecurityAPI_securityAssessrole(apiClient_t *apiClient, char * roleid );


// Returns the list of users for a specific user
//
void
SecurityAPI_securityAssessscope(apiClient_t *apiClient, char * locationid );


// Returns the list of permissions for a specific user
//
void
SecurityAPI_securityAssessuser(apiClient_t *apiClient, char * userid );


