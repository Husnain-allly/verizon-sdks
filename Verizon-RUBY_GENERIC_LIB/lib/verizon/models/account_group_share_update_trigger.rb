# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # AccountGroupShareUpdateTrigger Model.
  class AccountGroupShareUpdateTrigger < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The system assigned UUID of the trigger
    # @return [String]
    attr_accessor :trigger_id

    # The user defined name of the trigger
    # @return [String]
    attr_accessor :trigger_name

    # The numeric name of the account and must include leading zeroes
    # @return [String]
    attr_accessor :account_name

    # The type of trigger being created or modified
    # @return [TriggerCategory]
    attr_accessor :trigger_category

    # The type of trigger being created or modified
    # @return [AccountGroupShareObject]
    attr_accessor :data_trigger

    # The type of trigger being created or modified
    # @return [Notificationarray]
    attr_accessor :notification

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['trigger_id'] = 'triggerId'
      @_hash['trigger_name'] = 'triggerName'
      @_hash['account_name'] = 'accountName'
      @_hash['trigger_category'] = 'triggerCategory'
      @_hash['data_trigger'] = 'dataTrigger'
      @_hash['notification'] = 'notification'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        trigger_id
        trigger_name
        account_name
        trigger_category
        data_trigger
        notification
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(trigger_id: SKIP, trigger_name: SKIP, account_name: SKIP,
                   trigger_category: SKIP, data_trigger: SKIP,
                   notification: SKIP)
      @trigger_id = trigger_id unless trigger_id == SKIP
      @trigger_name = trigger_name unless trigger_name == SKIP
      @account_name = account_name unless account_name == SKIP
      @trigger_category = trigger_category unless trigger_category == SKIP
      @data_trigger = data_trigger unless data_trigger == SKIP
      @notification = notification unless notification == SKIP
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      trigger_id = hash.key?('triggerId') ? hash['triggerId'] : SKIP
      trigger_name = hash.key?('triggerName') ? hash['triggerName'] : SKIP
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      trigger_category =
        hash.key?('triggerCategory') ? hash['triggerCategory'] : SKIP
      data_trigger = AccountGroupShareObject.from_hash(hash['dataTrigger']) if hash['dataTrigger']
      notification = Notificationarray.from_hash(hash['notification']) if hash['notification']

      # Create object from extracted values.
      AccountGroupShareUpdateTrigger.new(trigger_id: trigger_id,
                                         trigger_name: trigger_name,
                                         account_name: account_name,
                                         trigger_category: trigger_category,
                                         data_trigger: data_trigger,
                                         notification: notification)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} trigger_id: #{@trigger_id}, trigger_name: #{@trigger_name}, account_name:"\
      " #{@account_name}, trigger_category: #{@trigger_category}, data_trigger: #{@data_trigger},"\
      " notification: #{@notification}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} trigger_id: #{@trigger_id.inspect}, trigger_name: #{@trigger_name.inspect},"\
      " account_name: #{@account_name.inspect}, trigger_category: #{@trigger_category.inspect},"\
      " data_trigger: #{@data_trigger.inspect}, notification: #{@notification.inspect}>"
    end
  end
end
