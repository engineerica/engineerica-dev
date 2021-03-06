=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class MediaApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Check in media item
    # Allows the user to check in a media item.
    # @param media [String] The id of the media item to checkin.
    # @param checkindate [DateTime] The checkout date.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :notes The notes of the checkout.
    # @return [nil]
    def media_checkin(media, checkindate, opts = {})
      media_checkin_with_http_info(media, checkindate, opts)
      nil
    end

    # Check in media item
    # Allows the user to check in a media item.
    # @param media [String] The id of the media item to checkin.
    # @param checkindate [DateTime] The checkout date.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :notes The notes of the checkout.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_checkin_with_http_info(media, checkindate, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_checkin ...'
      end
      # verify the required parameter 'media' is set
      if @api_client.config.client_side_validation && media.nil?
        fail ArgumentError, "Missing the required parameter 'media' when calling MediaApi.media_checkin"
      end
      # verify the required parameter 'checkindate' is set
      if @api_client.config.client_side_validation && checkindate.nil?
        fail ArgumentError, "Missing the required parameter 'checkindate' when calling MediaApi.media_checkin"
      end
      # resource path
      local_var_path = '/media/checkin'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'media'] = media
      query_params[:'checkindate'] = checkindate
      query_params[:'notes'] = opts[:'notes'] if !opts[:'notes'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_checkin\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Check out media item
    # Allows the user to check out a media item.
    # @param media [String] The id of the media item to checkout.
    # @param user [String] The id of the user that is checking the item out.
    # @param checkoutdate [DateTime] The checkout date.
    # @param duedate [DateTime] The date when the checkout is due.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :staff The id of the staff member related to the checkout.
    # @option opts [String] :event The id of the event related to the checkout.
    # @option opts [String] :notes The notes of the checkout.
    # @return [nil]
    def media_checkout(media, user, checkoutdate, duedate, opts = {})
      media_checkout_with_http_info(media, user, checkoutdate, duedate, opts)
      nil
    end

    # Check out media item
    # Allows the user to check out a media item.
    # @param media [String] The id of the media item to checkout.
    # @param user [String] The id of the user that is checking the item out.
    # @param checkoutdate [DateTime] The checkout date.
    # @param duedate [DateTime] The date when the checkout is due.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :staff The id of the staff member related to the checkout.
    # @option opts [String] :event The id of the event related to the checkout.
    # @option opts [String] :notes The notes of the checkout.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_checkout_with_http_info(media, user, checkoutdate, duedate, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_checkout ...'
      end
      # verify the required parameter 'media' is set
      if @api_client.config.client_side_validation && media.nil?
        fail ArgumentError, "Missing the required parameter 'media' when calling MediaApi.media_checkout"
      end
      # verify the required parameter 'user' is set
      if @api_client.config.client_side_validation && user.nil?
        fail ArgumentError, "Missing the required parameter 'user' when calling MediaApi.media_checkout"
      end
      # verify the required parameter 'checkoutdate' is set
      if @api_client.config.client_side_validation && checkoutdate.nil?
        fail ArgumentError, "Missing the required parameter 'checkoutdate' when calling MediaApi.media_checkout"
      end
      # verify the required parameter 'duedate' is set
      if @api_client.config.client_side_validation && duedate.nil?
        fail ArgumentError, "Missing the required parameter 'duedate' when calling MediaApi.media_checkout"
      end
      # resource path
      local_var_path = '/media/checkout'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'media'] = media
      query_params[:'user'] = user
      query_params[:'checkoutdate'] = checkoutdate
      query_params[:'duedate'] = duedate
      query_params[:'staff'] = opts[:'staff'] if !opts[:'staff'].nil?
      query_params[:'event'] = opts[:'event'] if !opts[:'event'].nil?
      query_params[:'notes'] = opts[:'notes'] if !opts[:'notes'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_checkout\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View a list of past media checkouts
    # Allows the user to view a list of all past checkouts
    # @param from [Integer] The first record to return.
    # @param count [Integer] The max number of records to return.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :media Used to filter the checkouts of a specific media item.
    # @option opts [String] :user Used to filter the checkouts made by a specific user.
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [nil]
    def media_checkoutlist(from, count, opts = {})
      media_checkoutlist_with_http_info(from, count, opts)
      nil
    end

    # View a list of past media checkouts
    # Allows the user to view a list of all past checkouts
    # @param from [Integer] The first record to return.
    # @param count [Integer] The max number of records to return.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :media Used to filter the checkouts of a specific media item.
    # @option opts [String] :user Used to filter the checkouts made by a specific user.
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_checkoutlist_with_http_info(from, count, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_checkoutlist ...'
      end
      # verify the required parameter 'from' is set
      if @api_client.config.client_side_validation && from.nil?
        fail ArgumentError, "Missing the required parameter 'from' when calling MediaApi.media_checkoutlist"
      end
      # verify the required parameter 'count' is set
      if @api_client.config.client_side_validation && count.nil?
        fail ArgumentError, "Missing the required parameter 'count' when calling MediaApi.media_checkoutlist"
      end
      # resource path
      local_var_path = '/media/checkoutlist'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'from'] = from
      query_params[:'count'] = count
      query_params[:'media'] = opts[:'media'] if !opts[:'media'].nil?
      query_params[:'user'] = opts[:'user'] if !opts[:'user'].nil?
      query_params[:'photosize'] = opts[:'photosize'] if !opts[:'photosize'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_checkoutlist\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Delete a media item
    # Allows the user to delete an existing media item.
    # @param id [String] The id of the media item to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [nil]
    def media_delete(id, opts = {})
      media_delete_with_http_info(id, opts)
      nil
    end

    # Delete a media item
    # Allows the user to delete an existing media item.
    # @param id [String] The id of the media item to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_delete_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_delete ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling MediaApi.media_delete"
      end
      # resource path
      local_var_path = '/media/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(opts[:'body']) 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Delete a media checkout log
    # Allows the user to delete a media item's checkout log.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def media_deletecheckoutlog(opts = {})
      media_deletecheckoutlog_with_http_info(opts)
      nil
    end

    # Delete a media checkout log
    # Allows the user to delete a media item&#39;s checkout log.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_deletecheckoutlog_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_deletecheckoutlog ...'
      end
      # resource path
      local_var_path = '/media/deletecheckoutlog'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(opts[:'unknown_base_type']) 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_deletecheckoutlog\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Search and view details of a media item
    # Allows the user to view an individual media item and its details.
    # @param id [String] The id of the media item to get.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def media_get(id, opts = {})
      media_get_with_http_info(id, opts)
      nil
    end

    # Search and view details of a media item
    # Allows the user to view an individual media item and its details.
    # @param id [String] The id of the media item to get.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_get_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_get ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling MediaApi.media_get"
      end
      # resource path
      local_var_path = '/media/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Search media item by unique code
    # Allows the user to search for media items by their unique code.
    # @param code [String] The code of the media item to get.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :location The location where to look for the media item.
    # @return [nil]
    def media_getbycode(code, opts = {})
      media_getbycode_with_http_info(code, opts)
      nil
    end

    # Search media item by unique code
    # Allows the user to search for media items by their unique code.
    # @param code [String] The code of the media item to get.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :location The location where to look for the media item.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_getbycode_with_http_info(code, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_getbycode ...'
      end
      # verify the required parameter 'code' is set
      if @api_client.config.client_side_validation && code.nil?
        fail ArgumentError, "Missing the required parameter 'code' when calling MediaApi.media_getbycode"
      end
      # resource path
      local_var_path = '/media/getbycode'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'code'] = code
      query_params[:'location'] = opts[:'location'] if !opts[:'location'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_getbycode\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View details of a media item checkout information
    # Allows the user to view a media item's checkout information.
    # @param id [String] The id of the media item whose checkout information has to be retrieved.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [nil]
    def media_getcheckout(id, opts = {})
      media_getcheckout_with_http_info(id, opts)
      nil
    end

    # View details of a media item checkout information
    # Allows the user to view a media item&#39;s checkout information.
    # @param id [String] The id of the media item whose checkout information has to be retrieved.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_getcheckout_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_getcheckout ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling MediaApi.media_getcheckout"
      end
      # resource path
      local_var_path = '/media/getcheckout'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'id'] = id
      query_params[:'photosize'] = opts[:'photosize'] if !opts[:'photosize'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_getcheckout\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View details of a media checkout log
    # Allows the user to view a media item's checkout history.
    # @param id [String] The id of the media item whose checkout information has to be retrieved.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [nil]
    def media_getcheckoutlog(id, opts = {})
      media_getcheckoutlog_with_http_info(id, opts)
      nil
    end

    # View details of a media checkout log
    # Allows the user to view a media item&#39;s checkout history.
    # @param id [String] The id of the media item whose checkout information has to be retrieved.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_getcheckoutlog_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_getcheckoutlog ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling MediaApi.media_getcheckoutlog"
      end
      # resource path
      local_var_path = '/media/getcheckoutlog'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'id'] = id
      query_params[:'photosize'] = opts[:'photosize'] if !opts[:'photosize'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_getcheckoutlog\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View a list of media items
    # Allows the user to view the list of all media items tied to locations in which the user is scoped.
    # @param from [Integer] The first record to return.
    # @param count [Integer] The max number of records to return.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :status Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All).
    # @option opts [String] :user Used to filter the media items that are checked-out by a specific user.
    # @return [nil]
    def media_list(from, count, opts = {})
      media_list_with_http_info(from, count, opts)
      nil
    end

    # View a list of media items
    # Allows the user to view the list of all media items tied to locations in which the user is scoped.
    # @param from [Integer] The first record to return.
    # @param count [Integer] The max number of records to return.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :status Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All).
    # @option opts [String] :user Used to filter the media items that are checked-out by a specific user.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_list_with_http_info(from, count, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_list ...'
      end
      # verify the required parameter 'from' is set
      if @api_client.config.client_side_validation && from.nil?
        fail ArgumentError, "Missing the required parameter 'from' when calling MediaApi.media_list"
      end
      # verify the required parameter 'count' is set
      if @api_client.config.client_side_validation && count.nil?
        fail ArgumentError, "Missing the required parameter 'count' when calling MediaApi.media_list"
      end
      # resource path
      local_var_path = '/media/list'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'from'] = from
      query_params[:'count'] = count
      query_params[:'status'] = opts[:'status'] if !opts[:'status'].nil?
      query_params[:'user'] = opts[:'user'] if !opts[:'user'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create or edit a media item
    # Allows the user to create or edit a media item.
    # @param id [String] The id of the media item save (leave empty to create a new one).
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def media_save(id, opts = {})
      media_save_with_http_info(id, opts)
      nil
    end

    # Create or edit a media item
    # Allows the user to create or edit a media item.
    # @param id [String] The id of the media item save (leave empty to create a new one).
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def media_save_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: MediaApi.media_save ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling MediaApi.media_save"
      end
      # resource path
      local_var_path = '/media/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(opts[:'unknown_base_type']) 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:POST, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: MediaApi#media_save\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
