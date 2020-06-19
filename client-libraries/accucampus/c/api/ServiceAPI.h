#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a service
//
// Allows the user to delete a service from the existing list.
//
void
ServiceAPI_serviceDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a service
//
// Allows the user to view an individual service and its details.
//
void
ServiceAPI_serviceGet(apiClient_t *apiClient, char * id );


// View a list of services
//
// Allows the user to view the full list of existing services.
//
void
ServiceAPI_serviceList(apiClient_t *apiClient, int from , int count );


// Create or edit a service
//
// Allows the user to create or edit a service.
//
void
ServiceAPI_serviceSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


