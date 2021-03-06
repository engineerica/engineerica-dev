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
from openapi_client.api.seminar_api import SeminarApi  # noqa: E501
from openapi_client.rest import ApiException


class TestSeminarApi(unittest.TestCase):
    """SeminarApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.seminar_api.SeminarApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_seminar_delete(self):
        """Test case for seminar_delete

        Delete an event  # noqa: E501
        """
        pass

    def test_seminar_get(self):
        """Test case for seminar_get

        Search and view details of a event  # noqa: E501
        """
        pass

    def test_seminar_list(self):
        """Test case for seminar_list

        View a list of events  # noqa: E501
        """
        pass

    def test_seminar_save(self):
        """Test case for seminar_save

        Create or edit a event  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
