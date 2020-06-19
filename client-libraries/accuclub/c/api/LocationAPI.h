#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a location
//
// Allows the user to delete an existing location.
//
void
LocationAPI_locationDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a location
//
// Allows the user to search and view an individual location and its details.
//
void
LocationAPI_locationGet(apiClient_t *apiClient, char * id );


// View a list of locations
//
// Allows the user to view the list of all locations to which they are scoped.
//
void
LocationAPI_locationList(apiClient_t *apiClient, int from , int count , char * locations , int sortbygroup );


// Create or edit a location
//
// Allows the user to create or edit a location.
//
void
LocationAPI_locationSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


