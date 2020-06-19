#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a college department
//
// Allows the user to delete an existing college department.
//
void
DepartmentAPI_departmentDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a college department
//
// Allows the user to view an individual college department and its details.
//
void
DepartmentAPI_departmentGet(apiClient_t *apiClient, char * id );


// View a list of college departments
//
// Allows the user to view the full list of college departments.
//
void
DepartmentAPI_departmentList(apiClient_t *apiClient, int from , int count );


// Create or edit a college department
//
// Allows the user to create or edit a college department.
//
void
DepartmentAPI_departmentSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


