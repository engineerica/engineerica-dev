# coding: utf-8

"""
    AccuClub OpenAPI 3

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest

import openapi_client
from openapi_client.api.credit_api import CreditApi  # noqa: E501
from openapi_client.rest import ApiException


class TestCreditApi(unittest.TestCase):
    """CreditApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.api.credit_api.CreditApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_credit_delete(self):
        """Test case for credit_delete

        Delete a credit  # noqa: E501
        """
        pass

    def test_credit_discountmethods(self):
        """Test case for credit_discountmethods

        Gets the valid discount methods.  # noqa: E501
        """
        pass

    def test_credit_get(self):
        """Test case for credit_get

        View details of assigned credit  # noqa: E501
        """
        pass

    def test_credit_getuserbalance(self):
        """Test case for credit_getuserbalance

        Get the total amount of credits of the specified user  # noqa: E501
        """
        pass

    def test_credit_list(self):
        """Test case for credit_list

        View a list of credits for a specific user  # noqa: E501
        """
        pass

    def test_credit_listdetails(self):
        """Test case for credit_listdetails

        Gets the credit usage details  # noqa: E501
        """
        pass

    def test_credit_listmine(self):
        """Test case for credit_listmine

        View the list of credits of the current user  # noqa: E501
        """
        pass

    def test_credit_save(self):
        """Test case for credit_save

        Create or edit credit for a user  # noqa: E501
        """
        pass

    def test_credit_savedetails(self):
        """Test case for credit_savedetails

        Create or edit credit details  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
