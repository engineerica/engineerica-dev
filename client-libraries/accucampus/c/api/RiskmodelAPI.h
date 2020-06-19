#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Check the status of the analysis of a specified risk assessment model
//
// Allows the user to check the status of a risk assessment model as it is being processed.
//
void
RiskmodelAPI_riskmodelCheckanalysis(apiClient_t *apiClient, char * id );


// Delete a risk assessment model
//
// Allows the user to delete a previously created risk assessment model.
//
void
RiskmodelAPI_riskmodelDelete(apiClient_t *apiClient, char * id ,  body );


// View details of a risk assessment model
//
// Allows the user to view an individual risk assessment model and its details.
//
void
RiskmodelAPI_riskmodelGet(apiClient_t *apiClient, char * id );


// View the risk score for a specific user
//
// Allows the user to view the risk score of another user.
//
void
RiskmodelAPI_riskmodelGetscore(apiClient_t *apiClient, char * userid );


// View a list of risk assessment models
//
// Allows the user to view the full list of risk assessment models.
//
void
RiskmodelAPI_riskmodelList(apiClient_t *apiClient, int from , int count );


// Predict risk based on an assessment model
//
// Allows a user to process a risk prediction from a risk assessment model that has processed.
//
void
RiskmodelAPI_riskmodelPredict(apiClient_t *apiClient, char * id );


// Process a risk assessment model
//
// Allows the user to process a risk assessment model once it has been created.
//
void
RiskmodelAPI_riskmodelProcess(apiClient_t *apiClient, char * id );


// Refresh the information used in a risk assessment model
//
// Allows the user to refresh a risk assessment model.
//
void
RiskmodelAPI_riskmodelRefresh(apiClient_t *apiClient, char * id );


// Create or edit a risk assessment model
//
// Allows the user to create or edit a risk assessment model.
//
void
RiskmodelAPI_riskmodelSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// View all default term precedences
//
// Allows the user to view the default term precedences used in a model.
//
void
RiskmodelAPI_riskmodelTermprecedences(apiClient_t *apiClient);


