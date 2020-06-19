#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Deregisters the current device to receive push notifications
//
void
PushAPI_pushDeregister(apiClient_t *apiClient, char * devicetoken , char * platform );


// Registers the current device to receive push notifications
//
void
PushAPI_pushRegister(apiClient_t *apiClient, char * devicetoken , char * platform );


