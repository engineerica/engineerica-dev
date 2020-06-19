#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Gets the translations of the specified values
//
void
TranslationAPI_translationGet(apiClient_t *apiClient, char * universal );


// Get the file containing the translations
//
void
TranslationAPI_translationGetcachefile(apiClient_t *apiClient, char * account );


// Lists all the available translations in the system
//
void
TranslationAPI_translationList(apiClient_t *apiClient, char * filter , int nondefaultonly , int appdefaultasuniversal );


// Edit a translation
//
// Allows the user to edit a translation for the entire account.
//
void
TranslationAPI_translationSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


