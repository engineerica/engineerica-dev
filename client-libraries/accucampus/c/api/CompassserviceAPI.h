#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// View all the services added to the compass
//
void
CompassserviceAPI_compassserviceList(apiClient_t *apiClient, char * category );


// View all the locations where a service added to the compass is available
//
void
CompassserviceAPI_compassserviceListlocations(apiClient_t *apiClient, char * serviceid );


