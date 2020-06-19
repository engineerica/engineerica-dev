#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Adds the missing permissions to a role. Requires access to advrole.save
//
void
AdvroleAPI_advroleAddmissing(apiClient_t *apiClient, char * roles , char * permissions );


// Checks the permissions are assigned for the given roles
//
void
AdvroleAPI_advroleCheckperm(apiClient_t *apiClient, char * roles , char * permissions );


// Delete a role
//
// Allows the user to delete a role from the list of available roles.
//
void
AdvroleAPI_advroleDelete(apiClient_t *apiClient, char * id ,  body );


// Delete a role mapping
//
// Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.
//
void
AdvroleAPI_advroleDeletemapping(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View details of a role
//
// Allows the user to view a role and its details.
//
void
AdvroleAPI_advroleGet(apiClient_t *apiClient, char * id );


// Lists the roles for the current account
//
void
AdvroleAPI_advroleList(apiClient_t *apiClient, int includepolicies , int includeinternal , char * name );


// Lists the maps a roles is mapped to
//
void
AdvroleAPI_advroleListmaps(apiClient_t *apiClient, char * roleid );


// Lists the roles mappings
//
void
AdvroleAPI_advroleListrolesmapped(apiClient_t *apiClient, char * map );


// View a list of role templates
//
// Allows the user to view the full list of available role templates.
//
void
AdvroleAPI_advroleListtemplates(apiClient_t *apiClient);


// Create or edit a role
//
// Allows the user to create or edit a role's permissions.
//
void
AdvroleAPI_advroleSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Saves a role mapping
//
// Allows the user to add a role to a mapped category on the 'Role Mapping' page.
//
void
AdvroleAPI_advroleSavemapping(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Upgrade a user to another role (requires permission to edit those roles)
//
// Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
//
void
AdvroleAPI_advroleUserupgrade(apiClient_t *apiClient, char * userid , char * roleid );


