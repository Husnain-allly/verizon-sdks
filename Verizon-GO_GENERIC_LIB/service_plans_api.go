/*
Package verizon

This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
*/
package verizon

import (
    "context"
    "github.com/apimatic/go-core-runtime/https"
    "github.com/apimatic/go-core-runtime/utilities"
    "verizon/errors"
    "verizon/models"
)

// ServicePlansApi represents a controller struct.
type ServicePlansApi struct {
    baseApi
}

// NewServicePlansApi creates a new instance of ServicePlansApi.
// It takes a baseController as a parameter and returns a pointer to the ServicePlansApi.
func NewServicePlansApi(baseApi baseApi) *ServicePlansApi {
    servicePlansApi := ServicePlansApi{baseApi: baseApi}
    return &servicePlansApi
}

// ListAccountServicePlans takes context, aname as parameters and
// returns an models.ApiResponse with []models.ServicePlan data and
// an error if there was an issue with the request or response.
// Returns a list of all data service plans that are associated with a specified billing account. When you send a request to /devices/actions/activate to activate a line of service you must specify the code for one of the service plans associated with your account.
func (s *ServicePlansApi) ListAccountServicePlans(
    ctx context.Context,
    aname string) (
    models.ApiResponse[[]models.ServicePlan],
    error) {
    req := s.prepareRequest(ctx, "GET", "/m2m/v1/plans/%v")
    req.AppendTemplateParams(aname)
    req.BaseUrl("Thingspace")
    req.Authenticate(
        NewAndAuth(
            NewAuth("thingspace_oauth"),
            NewAuth("VZ-M2M-Token"),
        ),
    )
    req.AppendErrors(map[string]https.ErrorBuilder[error]{
        "400": {Message: "Error response.", Unmarshaller: errors.NewConnectivityManagementResult},
    })
    
    var result []models.ServicePlan
    decoder, resp, err := req.CallAsJson()
    if err != nil {
        return models.NewApiResponse(result, resp), err
    }
    
    result, err = utilities.DecodeResults[[]models.ServicePlan](decoder)
    return models.NewApiResponse(result, resp), err
}
