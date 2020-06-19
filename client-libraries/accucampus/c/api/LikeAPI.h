#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a like
//
void
LikeAPI_likeDelete(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View all the likes associated to a target
//
void
LikeAPI_likeList(apiClient_t *apiClient, char * interactionid , int photosize );


// Save a like
//
void
LikeAPI_likeSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


