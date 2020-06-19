#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete an interaction
//
void
InteractionAPI_interactionDelete(apiClient_t *apiClient, char * id ,  body );


// Get the interactions feed
//
void
InteractionAPI_interactionFeed(apiClient_t *apiClient, int from , int count , char startdate , int public , char * contexttype , char * contextid , char * types , int photosize , int showdefaultphoto , int orderdescending );


// View an interaction
//
void
InteractionAPI_interactionGet(apiClient_t *apiClient, char * id , int thumbnailmediasize , int photosize );


// Get current user's latest private interactions
//
void
InteractionAPI_interactionListprivatesummary(apiClient_t *apiClient, int photosize , int showdefaultphoto );


// Save an interaction
//
void
InteractionAPI_interactionSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


