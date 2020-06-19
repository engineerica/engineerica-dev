#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Gets an image of a QR token
//
void
QrloginAPI_qrloginGet(apiClient_t *apiClient);


// Login
//
void
QrloginAPI_qrloginLogin(apiClient_t *apiClient, char * onetimetoken );


