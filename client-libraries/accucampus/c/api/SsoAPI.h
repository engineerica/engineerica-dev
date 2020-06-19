#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Generate/reset single sign on access key.
//
// Allows the user to generate or reset the access key for single sign-on.
//
void
SsoAPI_ssoGeneratekey(apiClient_t *apiClient);


// View single sign on settings.
//
// Allows the user to view settings for single sign-on.
//
void
SsoAPI_ssoGetsettings(apiClient_t *apiClient);


// Issue single sign-on token
//
void
SsoAPI_ssoIssuetoken(apiClient_t *apiClient, char * key , char * username , int expires );


// Edit single sign-on settings.
//
// Allows the user to edit settings for single sign-on.
//
void
SsoAPI_ssoSavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


