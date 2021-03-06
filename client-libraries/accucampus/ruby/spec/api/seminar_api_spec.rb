=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::SeminarApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'SeminarApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::SeminarApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of SeminarApi' do
    it 'should create an instance of SeminarApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::SeminarApi)
    end
  end

  # unit tests for seminar_delete
  # Delete an event
  # Allows the user to delete an existing event.
  # @param id The id of the seminar to delete.
  # @param [Hash] opts the optional parameters
  # @option opts [AnyType] :body 
  # @return [nil]
  describe 'seminar_delete test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for seminar_get
  # Search and view details of a event
  # Allows the user to view a event and its details.
  # @param id The id of the seminar to get.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'seminar_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for seminar_list
  # View a list of events
  # Allows the user to view the full list of events in the past, present, and future.
  # @param from The first record to return.
  # @param count The max number of records to return.
  # @param [Hash] opts the optional parameters
  # @option opts [Boolean] :summaryonly True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
  # @option opts [String] :termid Id of the term to list the events. Null to list all events.
  # @return [nil]
  describe 'seminar_list test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for seminar_save
  # Create or edit a event
  # Allows the user to create or edit a event.
  # @param id The id of the event to save (leave empty to create a new one).
  # @param [Hash] opts the optional parameters
  # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
  # @return [nil]
  describe 'seminar_save test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
