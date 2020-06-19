#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Adds background image for the login
//
// Allows the user to set the background image that all users will see when logging into an AccuTraining account not using SSO.
//
void
EasyloginAPI_easyloginAddbgimage(apiClient_t *apiClient, char * upload , char * filename );


