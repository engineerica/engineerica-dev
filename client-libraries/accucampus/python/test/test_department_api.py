# coding: utf-8

"""
    AccuCampus OpenAPI 3

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest

import openapi_client
from openapi_client.api.department_api import DepartmentApi  # noqa: E501
from openapi_client.rest import ApiException


class TestDepartmentApi(unittest.TestCase):
    """DepartmentApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.department_api.DepartmentApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_department_delete(self):
        """Test case for department_delete

        Delete a college department  # noqa: E501
        """
        pass

    def test_department_get(self):
        """Test case for department_get

        Search and view details of a college department  # noqa: E501
        """
        pass

    def test_department_list(self):
        """Test case for department_list

        View a list of college departments  # noqa: E501
        """
        pass

    def test_department_save(self):
        """Test case for department_save

        Create or edit a college department  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
