#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Get client
//
void
ClientAPI_clientGet(apiClient_t *apiClient, char * client , char * clientname );


// Gets the clients of the specified conference
//
void
ClientAPI_clientList(apiClient_t *apiClient, int from , int count );


// Saves a client
//
void
ClientAPI_clientSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Send a message to a client
//
void
ClientAPI_clientSendmessage(apiClient_t *apiClient, char * uniqueclientid , char * message );


