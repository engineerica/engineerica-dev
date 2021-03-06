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
from openapi_client.api.attendancerestriction_api import AttendancerestrictionApi  # noqa: E501
from openapi_client.rest import ApiException


class TestAttendancerestrictionApi(unittest.TestCase):
    """AttendancerestrictionApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.attendancerestriction_api.AttendancerestrictionApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_attendancerestriction_delete(self):
        """Test case for attendancerestriction_delete

        Delete an attendance restriction  # noqa: E501
        """
        pass

    def test_attendancerestriction_get(self):
        """Test case for attendancerestriction_get

        View details of an attendance restriction  # noqa: E501
        """
        pass

    def test_attendancerestriction_list(self):
        """Test case for attendancerestriction_list

        View a list of attendance restrictions  # noqa: E501
        """
        pass

    def test_attendancerestriction_save(self):
        """Test case for attendancerestriction_save

        Create or edit an attendance restriction  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
