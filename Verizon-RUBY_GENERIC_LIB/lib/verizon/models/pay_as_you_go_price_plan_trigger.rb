# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # PayAsYouGoPricePlanTrigger Model.
  class PayAsYouGoPricePlanTrigger < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [PayAsYouGoFilterCriteria]
    attr_accessor :pay_as_you_go

    # TODO: Write general description for this method
    # @return [Rateplantype2Condition]
    attr_accessor :condition

    # TODO: Write general description for this method
    # @return [Actionobject]
    attr_accessor :action

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['pay_as_you_go'] = 'payAsYouGo'
      @_hash['condition'] = 'condition'
      @_hash['action'] = 'action'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        pay_as_you_go
        condition
        action
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(pay_as_you_go: SKIP, condition: SKIP, action: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @pay_as_you_go = pay_as_you_go unless pay_as_you_go == SKIP
      @condition = condition unless condition == SKIP
      @action = action unless action == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      pay_as_you_go = PayAsYouGoFilterCriteria.from_hash(hash['payAsYouGo']) if hash['payAsYouGo']
      condition = Rateplantype2Condition.from_hash(hash['condition']) if hash['condition']
      action = Actionobject.from_hash(hash['action']) if hash['action']

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      PayAsYouGoPricePlanTrigger.new(pay_as_you_go: pay_as_you_go,
                                     condition: condition,
                                     action: action,
                                     additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} pay_as_you_go: #{@pay_as_you_go}, condition: #{@condition}, action:"\
      " #{@action}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} pay_as_you_go: #{@pay_as_you_go.inspect}, condition: #{@condition.inspect},"\
      " action: #{@action.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
