# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Http response received.
  class ApiResponse < CoreLibrary::ApiResponse
    # The constructor
    # @param [HttpResponse] http_response The original, raw response from the api.
    # @param [Object] data The data field specified for the response.
    # @param [Array<String>] errors Any errors returned by the server.
    def initialize(http_response,
                   data: nil,
                   errors: nil)
      super
    end
  end
end
