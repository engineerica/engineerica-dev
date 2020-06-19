#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// List users. Alias to user.list, use that one instead.
//
void
AdvrolesAPI_advrolesUserlist(apiClient_t *apiClient, int from , int count , char * roleid , char * onlywithoutcard , int photosize );


