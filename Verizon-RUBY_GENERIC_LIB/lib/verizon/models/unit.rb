# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Unit.
  class Unit
    UNIT = [
      # TODO: Write general description for MINUTES
      MINUTES = 'minutes'.freeze,

      # TODO: Write general description for HOURS
      HOURS = 'hours'.freeze
    ].freeze

    def self.validate(value)
      return false if value.nil?

      UNIT.include?(value)
    end
  end
end
