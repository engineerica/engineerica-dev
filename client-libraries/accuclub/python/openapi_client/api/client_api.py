# coding: utf-8

"""
    AccuClub OpenAPI 3

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from openapi_client.api_client import ApiClient
from openapi_client.exceptions import (  # noqa: F401
    ApiTypeError,
    ApiValueError
)


class ClientApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def client_get(self, client, **kwargs):  # noqa: E501
        """Get client  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.client_get(client, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param str client: The unique id of the client. (required)
        :param str clientname: The custom name of the client.
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.client_get_with_http_info(client, **kwargs)  # noqa: E501

    def client_get_with_http_info(self, client, **kwargs):  # noqa: E501
        """Get client  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.client_get_with_http_info(client, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param str client: The unique id of the client. (required)
        :param str clientname: The custom name of the client.
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
            'client',
            'clientname'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method client_get" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']
        # verify the required parameter 'client' is set
        if self.api_client.client_side_validation and ('client' not in local_var_params or  # noqa: E501
                                                        local_var_params['client'] is None):  # noqa: E501
            raise ApiValueError("Missing the required parameter `client` when calling `client_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}

        query_params = []
        if 'client' in local_var_params and local_var_params['client'] is not None:  # noqa: E501
            query_params.append(('client', local_var_params['client']))  # noqa: E501
        if 'clientname' in local_var_params and local_var_params['clientname'] is not None:  # noqa: E501
            query_params.append(('clientname', local_var_params['clientname']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/client/get', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)

    def client_list(self, _from, count, **kwargs):  # noqa: E501
        """Gets the clients of the specified conference  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.client_list(_from, count, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param int _from: The first record to return. (required)
        :param int count: The max number of records to return. (required)
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.client_list_with_http_info(_from, count, **kwargs)  # noqa: E501

    def client_list_with_http_info(self, _from, count, **kwargs):  # noqa: E501
        """Gets the clients of the specified conference  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.client_list_with_http_info(_from, count, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param int _from: The first record to return. (required)
        :param int count: The max number of records to return. (required)
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
            '_from',
            'count'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method client_list" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']
        # verify the required parameter '_from' is set
        if self.api_client.client_side_validation and ('_from' not in local_var_params or  # noqa: E501
                                                        local_var_params['_from'] is None):  # noqa: E501
            raise ApiValueError("Missing the required parameter `_from` when calling `client_list`")  # noqa: E501
        # verify the required parameter 'count' is set
        if self.api_client.client_side_validation and ('count' not in local_var_params or  # noqa: E501
                                                        local_var_params['count'] is None):  # noqa: E501
            raise ApiValueError("Missing the required parameter `count` when calling `client_list`")  # noqa: E501

        collection_formats = {}

        path_params = {}

        query_params = []
        if '_from' in local_var_params and local_var_params['_from'] is not None:  # noqa: E501
            query_params.append(('from', local_var_params['_from']))  # noqa: E501
        if 'count' in local_var_params and local_var_params['count'] is not None:  # noqa: E501
            query_params.append(('count', local_var_params['count']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/client/list', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)

    def client_save(self, **kwargs):  # noqa: E501
        """Saves a client  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.client_save(async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param UNKNOWN_BASE_TYPE unknown_base_type:
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.client_save_with_http_info(**kwargs)  # noqa: E501

    def client_save_with_http_info(self, **kwargs):  # noqa: E501
        """Saves a client  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.client_save_with_http_info(async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param UNKNOWN_BASE_TYPE unknown_base_type:
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
            'unknown_base_type'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method client_save" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']

        collection_formats = {}

        path_params = {}

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'unknown_base_type' in local_var_params:
            body_params = local_var_params['unknown_base_type']
        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/client/save', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)

    def client_sendmessage(self, uniqueclientid, message, **kwargs):  # noqa: E501
        """Send a message to a client  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.client_sendmessage(uniqueclientid, message, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param str uniqueclientid: The unique id of the client. (required)
        :param str message: The body of the message to send. (required)
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        return self.client_sendmessage_with_http_info(uniqueclientid, message, **kwargs)  # noqa: E501

    def client_sendmessage_with_http_info(self, uniqueclientid, message, **kwargs):  # noqa: E501
        """Send a message to a client  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.client_sendmessage_with_http_info(uniqueclientid, message, async_req=True)
        >>> result = thread.get()

        :param async_req bool: execute request asynchronously
        :param str uniqueclientid: The unique id of the client. (required)
        :param str message: The body of the message to send. (required)
        :param _return_http_data_only: response data without head status code
                                       and headers
        :param _preload_content: if False, the urllib3.HTTPResponse object will
                                 be returned without reading/decoding response
                                 data. Default is True.
        :param _request_timeout: timeout setting for this request. If one
                                 number provided, it will be total request
                                 timeout. It can also be a pair (tuple) of
                                 (connection, read) timeouts.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        local_var_params = locals()

        all_params = [
            'uniqueclientid',
            'message'
        ]
        all_params.extend(
            [
                'async_req',
                '_return_http_data_only',
                '_preload_content',
                '_request_timeout'
            ]
        )

        for key, val in six.iteritems(local_var_params['kwargs']):
            if key not in all_params:
                raise ApiTypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method client_sendmessage" % key
                )
            local_var_params[key] = val
        del local_var_params['kwargs']
        # verify the required parameter 'uniqueclientid' is set
        if self.api_client.client_side_validation and ('uniqueclientid' not in local_var_params or  # noqa: E501
                                                        local_var_params['uniqueclientid'] is None):  # noqa: E501
            raise ApiValueError("Missing the required parameter `uniqueclientid` when calling `client_sendmessage`")  # noqa: E501
        # verify the required parameter 'message' is set
        if self.api_client.client_side_validation and ('message' not in local_var_params or  # noqa: E501
                                                        local_var_params['message'] is None):  # noqa: E501
            raise ApiValueError("Missing the required parameter `message` when calling `client_sendmessage`")  # noqa: E501

        collection_formats = {}

        path_params = {}

        query_params = []
        if 'uniqueclientid' in local_var_params and local_var_params['uniqueclientid'] is not None:  # noqa: E501
            query_params.append(('uniqueclientid', local_var_params['uniqueclientid']))  # noqa: E501
        if 'message' in local_var_params and local_var_params['message'] is not None:  # noqa: E501
            query_params.append(('message', local_var_params['message']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/client/sendmessage', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=local_var_params.get('async_req'),
            _return_http_data_only=local_var_params.get('_return_http_data_only'),  # noqa: E501
            _preload_content=local_var_params.get('_preload_content', True),
            _request_timeout=local_var_params.get('_request_timeout'),
            collection_formats=collection_formats)
