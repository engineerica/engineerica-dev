=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class ScheduleApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Delete a schedule slot
    # Allows the user to delete a schedule slot from another user.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def schedule_delete(opts = {})
      schedule_delete_with_http_info(opts)
      nil
    end

    # Delete a schedule slot
    # Allows the user to delete a schedule slot from another user.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_delete_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_delete ...'
      end
      # resource path
      local_var_path = '/schedule/delete'

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Delete a specific block from a user's own schedule
    # Allows the user to delete a schedule block from their own availability.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def schedule_deletemine(opts = {})
      schedule_deletemine_with_http_info(opts)
      nil
    end

    # Delete a specific block from a user&#39;s own schedule
    # Allows the user to delete a schedule block from their own availability.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_deletemine_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_deletemine ...'
      end
      # resource path
      local_var_path = '/schedule/deletemine'

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_deletemine\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Enable or disable the schedule for a specific person
    # Allows the user to enable or disable a schedule for another user.
    # @param userid [String] The id of the user to enable or disable the schedule.
    # @param enable [Boolean] True to enable schedules, false to disable.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def schedule_enable(userid, enable, opts = {})
      schedule_enable_with_http_info(userid, enable, opts)
      nil
    end

    # Enable or disable the schedule for a specific person
    # Allows the user to enable or disable a schedule for another user.
    # @param userid [String] The id of the user to enable or disable the schedule.
    # @param enable [Boolean] True to enable schedules, false to disable.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_enable_with_http_info(userid, enable, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_enable ...'
      end
      # verify the required parameter 'userid' is set
      if @api_client.config.client_side_validation && userid.nil?
        fail ArgumentError, "Missing the required parameter 'userid' when calling ScheduleApi.schedule_enable"
      end
      # verify the required parameter 'enable' is set
      if @api_client.config.client_side_validation && enable.nil?
        fail ArgumentError, "Missing the required parameter 'enable' when calling ScheduleApi.schedule_enable"
      end
      # resource path
      local_var_path = '/schedule/enable'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'userid'] = userid
      query_params[:'enable'] = enable

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_enable\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Enable or disable current user's schedule
    # Allows the user to enable or disable a schedule for himself.
    # @param enable [Boolean] True to enable schedules, false to disable.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def schedule_enablemine(enable, opts = {})
      schedule_enablemine_with_http_info(enable, opts)
      nil
    end

    # Enable or disable current user&#39;s schedule
    # Allows the user to enable or disable a schedule for himself.
    # @param enable [Boolean] True to enable schedules, false to disable.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_enablemine_with_http_info(enable, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_enablemine ...'
      end
      # verify the required parameter 'enable' is set
      if @api_client.config.client_side_validation && enable.nil?
        fail ArgumentError, "Missing the required parameter 'enable' when calling ScheduleApi.schedule_enablemine"
      end
      # resource path
      local_var_path = '/schedule/enablemine'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'enable'] = enable

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_enablemine\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Search available schedule slots by service, event, date
    # Allows users to search available slots.
    # @param starttime [DateTime] The start time of the range to look for slots.
    # @param endtime [DateTime] The end time of the range to look for slots.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :staffid The id of the staff to filter by.
    # @option opts [String] :serviceids CSV list of the service Ids to filter by.
    # @option opts [String] :eventid The id of the event to filter by.
    # @option opts [String] :locationid The id of the location to filter by.
    # @option opts [String] :staffroleids CSV list of the staff member role ids to filter by.
    # @option opts [String] :availablefor The specific availability type to filter by.
    # @return [nil]
    def schedule_findallstaffslots(starttime, endtime, opts = {})
      schedule_findallstaffslots_with_http_info(starttime, endtime, opts)
      nil
    end

    # Search available schedule slots by service, event, date
    # Allows users to search available slots.
    # @param starttime [DateTime] The start time of the range to look for slots.
    # @param endtime [DateTime] The end time of the range to look for slots.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :staffid The id of the staff to filter by.
    # @option opts [String] :serviceids CSV list of the service Ids to filter by.
    # @option opts [String] :eventid The id of the event to filter by.
    # @option opts [String] :locationid The id of the location to filter by.
    # @option opts [String] :staffroleids CSV list of the staff member role ids to filter by.
    # @option opts [String] :availablefor The specific availability type to filter by.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_findallstaffslots_with_http_info(starttime, endtime, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_findallstaffslots ...'
      end
      # verify the required parameter 'starttime' is set
      if @api_client.config.client_side_validation && starttime.nil?
        fail ArgumentError, "Missing the required parameter 'starttime' when calling ScheduleApi.schedule_findallstaffslots"
      end
      # verify the required parameter 'endtime' is set
      if @api_client.config.client_side_validation && endtime.nil?
        fail ArgumentError, "Missing the required parameter 'endtime' when calling ScheduleApi.schedule_findallstaffslots"
      end
      # resource path
      local_var_path = '/schedule/findallstaffslots'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'starttime'] = starttime
      query_params[:'endtime'] = endtime
      query_params[:'staffid'] = opts[:'staffid'] if !opts[:'staffid'].nil?
      query_params[:'serviceids'] = opts[:'serviceids'] if !opts[:'serviceids'].nil?
      query_params[:'eventid'] = opts[:'eventid'] if !opts[:'eventid'].nil?
      query_params[:'locationid'] = opts[:'locationid'] if !opts[:'locationid'].nil?
      query_params[:'staffroleids'] = opts[:'staffroleids'] if !opts[:'staffroleids'].nil?
      query_params[:'availablefor'] = opts[:'availablefor'] if !opts[:'availablefor'].nil?

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_findallstaffslots\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Search available schedule slots by service, event, date and/or staff
    # Allows users to search available slots when making appointments.
    # @param staffid [String] The id of the staff to filter by.
    # @param starttime [DateTime] The start time of the range to look for slots.
    # @param endtime [DateTime] The end time of the range to look for slots.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :serviceids CSV list of the service Ids to filter by.
    # @option opts [String] :eventid The id of the event to filter by.
    # @option opts [String] :locationid The id of the service to filter by.
    # @option opts [String] :availablefor The specific availability type to filter by.
    # @return [nil]
    def schedule_findslots(staffid, starttime, endtime, opts = {})
      schedule_findslots_with_http_info(staffid, starttime, endtime, opts)
      nil
    end

    # Search available schedule slots by service, event, date and/or staff
    # Allows users to search available slots when making appointments.
    # @param staffid [String] The id of the staff to filter by.
    # @param starttime [DateTime] The start time of the range to look for slots.
    # @param endtime [DateTime] The end time of the range to look for slots.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :serviceids CSV list of the service Ids to filter by.
    # @option opts [String] :eventid The id of the event to filter by.
    # @option opts [String] :locationid The id of the service to filter by.
    # @option opts [String] :availablefor The specific availability type to filter by.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_findslots_with_http_info(staffid, starttime, endtime, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_findslots ...'
      end
      # verify the required parameter 'staffid' is set
      if @api_client.config.client_side_validation && staffid.nil?
        fail ArgumentError, "Missing the required parameter 'staffid' when calling ScheduleApi.schedule_findslots"
      end
      # verify the required parameter 'starttime' is set
      if @api_client.config.client_side_validation && starttime.nil?
        fail ArgumentError, "Missing the required parameter 'starttime' when calling ScheduleApi.schedule_findslots"
      end
      # verify the required parameter 'endtime' is set
      if @api_client.config.client_side_validation && endtime.nil?
        fail ArgumentError, "Missing the required parameter 'endtime' when calling ScheduleApi.schedule_findslots"
      end
      # resource path
      local_var_path = '/schedule/findslots'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'staffid'] = staffid
      query_params[:'starttime'] = starttime
      query_params[:'endtime'] = endtime
      query_params[:'serviceids'] = opts[:'serviceids'] if !opts[:'serviceids'].nil?
      query_params[:'eventid'] = opts[:'eventid'] if !opts[:'eventid'].nil?
      query_params[:'locationid'] = opts[:'locationid'] if !opts[:'locationid'].nil?
      query_params[:'availablefor'] = opts[:'availablefor'] if !opts[:'availablefor'].nil?

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_findslots\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Search available staff members slots by service, event, and/or date
    # Allows users to search available staff.
    # @param starttime [DateTime] The start time of the range to look for slots.
    # @param endtime [DateTime] The end time of the range to look for slots.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :serviceids CSV list of the service ids to filter by.
    # @option opts [String] :eventid The id of the event to filter by.
    # @option opts [String] :locationid The id of the service to filter by.
    # @option opts [String] :staffroleids CSV list of the staff member role ids to filter by.
    # @option opts [String] :availablefor Filter slots by a specific availability type.
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [nil]
    def schedule_findstaffavail(starttime, endtime, opts = {})
      schedule_findstaffavail_with_http_info(starttime, endtime, opts)
      nil
    end

    # Search available staff members slots by service, event, and/or date
    # Allows users to search available staff.
    # @param starttime [DateTime] The start time of the range to look for slots.
    # @param endtime [DateTime] The end time of the range to look for slots.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :serviceids CSV list of the service ids to filter by.
    # @option opts [String] :eventid The id of the event to filter by.
    # @option opts [String] :locationid The id of the service to filter by.
    # @option opts [String] :staffroleids CSV list of the staff member role ids to filter by.
    # @option opts [String] :availablefor Filter slots by a specific availability type.
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_findstaffavail_with_http_info(starttime, endtime, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_findstaffavail ...'
      end
      # verify the required parameter 'starttime' is set
      if @api_client.config.client_side_validation && starttime.nil?
        fail ArgumentError, "Missing the required parameter 'starttime' when calling ScheduleApi.schedule_findstaffavail"
      end
      # verify the required parameter 'endtime' is set
      if @api_client.config.client_side_validation && endtime.nil?
        fail ArgumentError, "Missing the required parameter 'endtime' when calling ScheduleApi.schedule_findstaffavail"
      end
      # resource path
      local_var_path = '/schedule/findstaffavail'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'starttime'] = starttime
      query_params[:'endtime'] = endtime
      query_params[:'serviceids'] = opts[:'serviceids'] if !opts[:'serviceids'].nil?
      query_params[:'eventid'] = opts[:'eventid'] if !opts[:'eventid'].nil?
      query_params[:'locationid'] = opts[:'locationid'] if !opts[:'locationid'].nil?
      query_params[:'staffroleids'] = opts[:'staffroleids'] if !opts[:'staffroleids'].nil?
      query_params[:'availablefor'] = opts[:'availablefor'] if !opts[:'availablefor'].nil?
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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_findstaffavail\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Search and view details of a specific schedule slot
    # Allows the user to view the details of schedule shifts for any user role that the user has permission to view.
    # @param scheduleid [String] The id of the schedule.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def schedule_get(scheduleid, opts = {})
      schedule_get_with_http_info(scheduleid, opts)
      nil
    end

    # Search and view details of a specific schedule slot
    # Allows the user to view the details of schedule shifts for any user role that the user has permission to view.
    # @param scheduleid [String] The id of the schedule.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_get_with_http_info(scheduleid, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_get ...'
      end
      # verify the required parameter 'scheduleid' is set
      if @api_client.config.client_side_validation && scheduleid.nil?
        fail ArgumentError, "Missing the required parameter 'scheduleid' when calling ScheduleApi.schedule_get"
      end
      # resource path
      local_var_path = '/schedule/get'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'scheduleid'] = scheduleid

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View details of a specific schedule block, for current user
    # Allows the user to view the details of their own schedule shifts.
    # @param scheduleid [String] The id of the schedule.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def schedule_getmine(scheduleid, opts = {})
      schedule_getmine_with_http_info(scheduleid, opts)
      nil
    end

    # View details of a specific schedule block, for current user
    # Allows the user to view the details of their own schedule shifts.
    # @param scheduleid [String] The id of the schedule.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_getmine_with_http_info(scheduleid, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_getmine ...'
      end
      # verify the required parameter 'scheduleid' is set
      if @api_client.config.client_side_validation && scheduleid.nil?
        fail ArgumentError, "Missing the required parameter 'scheduleid' when calling ScheduleApi.schedule_getmine"
      end
      # resource path
      local_var_path = '/schedule/getmine'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'scheduleid'] = scheduleid

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_getmine\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View a list of schedule information of a specified person
    # Allows the user to view the schedule shifts for user roles that the user has permission to access.
    # @param userid [String] The id of the user to get info.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def schedule_getstaff(userid, opts = {})
      schedule_getstaff_with_http_info(userid, opts)
      nil
    end

    # View a list of schedule information of a specified person
    # Allows the user to view the schedule shifts for user roles that the user has permission to access.
    # @param userid [String] The id of the user to get info.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_getstaff_with_http_info(userid, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_getstaff ...'
      end
      # verify the required parameter 'userid' is set
      if @api_client.config.client_side_validation && userid.nil?
        fail ArgumentError, "Missing the required parameter 'userid' when calling ScheduleApi.schedule_getstaff"
      end
      # resource path
      local_var_path = '/schedule/getstaff'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'userid'] = userid

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_getstaff\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View current user's schedule information
    # Allows the user to view their own schedule.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def schedule_getstaffmine(opts = {})
      schedule_getstaffmine_with_http_info(opts)
      nil
    end

    # View current user&#39;s schedule information
    # Allows the user to view their own schedule.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_getstaffmine_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_getstaffmine ...'
      end
      # resource path
      local_var_path = '/schedule/getstaffmine'

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_getstaffmine\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View current user's schedule exceptions
    # Allows the user to view their own schedule exceptions.
    # @param [Hash] opts the optional parameters
    # @option opts [Boolean] :includedeleted If true the deleted offtimes are also returned.
    # @option opts [Boolean] :onlyupcoming If true then only upcoming offtimes are returned.
    # @option opts [DateTime] :modifiedafter If specified, only offtimes modified after the specified date will be returned.
    # @return [nil]
    def schedule_myofftimes(opts = {})
      schedule_myofftimes_with_http_info(opts)
      nil
    end

    # View current user&#39;s schedule exceptions
    # Allows the user to view their own schedule exceptions.
    # @param [Hash] opts the optional parameters
    # @option opts [Boolean] :includedeleted If true the deleted offtimes are also returned.
    # @option opts [Boolean] :onlyupcoming If true then only upcoming offtimes are returned.
    # @option opts [DateTime] :modifiedafter If specified, only offtimes modified after the specified date will be returned.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_myofftimes_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_myofftimes ...'
      end
      # resource path
      local_var_path = '/schedule/myofftimes'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'includedeleted'] = opts[:'includedeleted'] if !opts[:'includedeleted'].nil?
      query_params[:'onlyupcoming'] = opts[:'onlyupcoming'] if !opts[:'onlyupcoming'].nil?
      query_params[:'modifiedafter'] = opts[:'modifiedafter'] if !opts[:'modifiedafter'].nil?

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_myofftimes\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create or edit a schedule slot
    # Allows the user to create or edit a schedule slot of another user.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def schedule_save(opts = {})
      schedule_save_with_http_info(opts)
      nil
    end

    # Create or edit a schedule slot
    # Allows the user to create or edit a schedule slot of another user.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_save_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_save ...'
      end
      # resource path
      local_var_path = '/schedule/save'

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_save\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create or edit a block in current user's schedule
    # Allows the user to create or edit a schedule shift in their own availability.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def schedule_savemine(opts = {})
      schedule_savemine_with_http_info(opts)
      nil
    end

    # Create or edit a block in current user&#39;s schedule
    # Allows the user to create or edit a schedule shift in their own availability.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schedule_savemine_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: ScheduleApi.schedule_savemine ...'
      end
      # resource path
      local_var_path = '/schedule/savemine'

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
        @api_client.config.logger.debug "API called: ScheduleApi#schedule_savemine\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
