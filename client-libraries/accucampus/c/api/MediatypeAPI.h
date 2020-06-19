#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a media type
//
// Allows the user to delete an existing media type.
//
void
MediatypeAPI_mediatypeDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a media type
//
// Allows the user to view a media type and its details.
//
void
MediatypeAPI_mediatypeGet(apiClient_t *apiClient, char * id );


// View a list of media types
//
// Allows the user to view the list of all media types.
//
void
MediatypeAPI_mediatypeList(apiClient_t *apiClient, int from , int count );


// Create or edit a media type
//
// Allows the user to create or edit a media type.
//
void
MediatypeAPI_mediatypeSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


