#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a compass category
//
// Allows the user to delete an existing compass category.
//
void
CompasscategoryAPI_compasscategoryDelete(apiClient_t *apiClient, char * id ,  body );


// View details of a compass category
//
// Allows the user to view an indvidiaul compass category and its details.
//
void
CompasscategoryAPI_compasscategoryGet(apiClient_t *apiClient, char * id );


// View a list of compass categories
//
// Allows the user to view the full list of compass categories.
//
void
CompasscategoryAPI_compasscategoryList(apiClient_t *apiClient, int from , int count , int onlywithservices );


// Create or edit a compass category
//
// Allows the user to create or edit a compass category.
//
void
CompasscategoryAPI_compasscategorySave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


