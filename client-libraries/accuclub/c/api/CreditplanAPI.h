#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Deletes a credit plan
//
void
CreditplanAPI_creditplanDelete(apiClient_t *apiClient, char * id ,  body );


// Gets a credit plan
//
void
CreditplanAPI_creditplanGet(apiClient_t *apiClient, char * id );


// Gets the credit plans available
//
void
CreditplanAPI_creditplanList(apiClient_t *apiClient, int from , int count );


// Saves a credit plan
//
void
CreditplanAPI_creditplanSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


