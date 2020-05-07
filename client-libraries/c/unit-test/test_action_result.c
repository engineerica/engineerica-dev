#ifndef action_result_TEST
#define action_result_TEST

// the following is to include only the main from the first c file
#ifndef TEST_MAIN
#define TEST_MAIN
#define action_result_MAIN
#endif // TEST_MAIN

#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include <stdbool.h>
#include "../external/cJSON.h"

#include "../model/action_result.h"
action_result_t* instantiate_action_result(int include_optional);



action_result_t* instantiate_action_result(int include_optional) {
  action_result_t* action_result = NULL;
  if (include_optional) {
    action_result = action_result_create(
      1,
      list_create(),
      "0"
    );
  } else {
    action_result = action_result_create(
      1,
      list_create(),
      "0"
    );
  }

  return action_result;
}


#ifdef action_result_MAIN

void test_action_result(int include_optional) {
    action_result_t* action_result_1 = instantiate_action_result(include_optional);

	cJSON* jsonaction_result_1 = action_result_convertToJSON(action_result_1);
	printf("action_result :\n%s\n", cJSON_Print(jsonaction_result_1));
	action_result_t* action_result_2 = action_result_parseFromJSON(jsonaction_result_1);
	cJSON* jsonaction_result_2 = action_result_convertToJSON(action_result_2);
	printf("repeating action_result:\n%s\n", cJSON_Print(jsonaction_result_2));
}

int main() {
  test_action_result(1);
  test_action_result(0);

  printf("Hello world \n");
  return 0;
}

#endif // action_result_MAIN
#endif // action_result_TEST
