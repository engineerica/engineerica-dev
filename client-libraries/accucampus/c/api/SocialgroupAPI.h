#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Adds new members to a group (which the user must own already)
//
void
SocialgroupAPI_socialgroupAddmembers(apiClient_t *apiClient, char * id , char * userids );


// Deletes a group
//
void
SocialgroupAPI_socialgroupDelete(apiClient_t *apiClient, char * id ,  body );


// View all the groups the current user is in
//
void
SocialgroupAPI_socialgroupList(apiClient_t *apiClient);


// Lists the members of a group
//
void
SocialgroupAPI_socialgroupListmembers(apiClient_t *apiClient, char * id );


// Removes members from a group (which the user must own already)
//
void
SocialgroupAPI_socialgroupRemovemembers(apiClient_t *apiClient, char * id , char * userids );


// Removes myself from an existent group
//
void
SocialgroupAPI_socialgroupRemovemyself(apiClient_t *apiClient, char * id );


// Saves a new group
//
void
SocialgroupAPI_socialgroupSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


