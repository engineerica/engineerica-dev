#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Gets the phone number of the current user
//
void
AppshareAPI_appshareGetphone(apiClient_t *apiClient);


// Sends an SMS with the link to the app
//
void
AppshareAPI_appshareSendtext(apiClient_t *apiClient, char * phonenumber );


