/*
 * action_result.h
 *
 * Default action result
 */

#ifndef _action_result_H_
#define _action_result_H_

#include <string.h>
#include "../external/cJSON.h"
#include "../include/list.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"

typedef struct action_result_t action_result_t;

#include "object.h"



typedef struct action_result_t {
    int success; //boolean
    list_t *results; //nonprimitive container
    char *message; // string

} action_result_t;

action_result_t *action_result_create(
    int success,
    list_t *results,
    char *message
);

void action_result_free(action_result_t *action_result);

action_result_t *action_result_parseFromJSON(cJSON *action_resultJSON);

cJSON *action_result_convertToJSON(action_result_t *action_result);

#endif /* _action_result_H_ */

