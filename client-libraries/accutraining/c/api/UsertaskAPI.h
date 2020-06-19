#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Deletes a task plan
//
void
UsertaskAPI_usertaskDeleteplan(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Lists the task plans of the logged user
//
void
UsertaskAPI_usertaskGetmine(apiClient_t *apiClient);


// Gets a task plan by Id
//
void
UsertaskAPI_usertaskGetplan(apiClient_t *apiClient, char * id );


// Lists task types or definitions
//
void
UsertaskAPI_usertaskListdefs(apiClient_t *apiClient);


// Lists task plans
//
void
UsertaskAPI_usertaskListplan(apiClient_t *apiClient, int from , int count );


// Saves a task plan
//
void
UsertaskAPI_usertaskSaveplan(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


