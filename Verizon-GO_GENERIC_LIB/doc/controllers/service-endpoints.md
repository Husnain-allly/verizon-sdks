# Service Endpoints

```go
serviceEndpointsApi := client.ServiceEndpointsApi()
```

## Class Name

`ServiceEndpointsApi`

## Methods

* [List Optimal Service Endpoints](../../doc/controllers/service-endpoints.md#list-optimal-service-endpoints)
* [Register Service Endpoints](../../doc/controllers/service-endpoints.md#register-service-endpoints)
* [List All Service Endpoints](../../doc/controllers/service-endpoints.md#list-all-service-endpoints)
* [Get Service Endpoint](../../doc/controllers/service-endpoints.md#get-service-endpoint)
* [Update Service Endpoint](../../doc/controllers/service-endpoints.md#update-service-endpoint)
* [Deregister Service Endpoint](../../doc/controllers/service-endpoints.md#deregister-service-endpoint)


# List Optimal Service Endpoints

Returns a list of optimal Service Endpoints that client devices can connect to. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - Region plus Service Endpoints IDs and Subscriber density (density is optional but recommended), Region plus Service Endpoints IDs and UEIdentity(Including UEIdentity Type) and Service Endpoints IDs plus UEIdentity(Including UEIdentity Type).

```go
ListOptimalServiceEndpoints(
    ctx context.Context,
    region *string,
    subscriberDensity *int,
    ueIdentityType *models.UserEquipmentIdentityType,
    ueIdentity *string,
    serviceEndpointsIds *string) (
    models.ApiResponse[models.ListOptimalServiceEndpointsResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `region` | `*string` | Query, Optional | MEC region name. Current valid values are US_WEST_2 and US_EAST_1. |
| `subscriberDensity` | `*int` | Query, Optional | Minimum number of 4G/5G subscribers per square kilometer.<br><br>**Constraints**: `>= 1`, `<= 100` |
| `ueIdentityType` | [`*models.UserEquipmentIdentityType`](../../doc/models/user-equipment-identity-type.md) | Query, Optional | Type of User Equipment identifier used in `UEIdentity`. |
| `ueIdentity` | `*string` | Query, Optional | The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6. |
| `serviceEndpointsIds` | `*string` | Query, Optional | A system-defined string identifier representing one or more registered Service Endpoints. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ListOptimalServiceEndpointsResult](../../doc/models/list-optimal-service-endpoints-result.md).

## Example Usage

```go
ctx := context.Background()

region := "US_WEST_2"



ueIdentityType := models.UserEquipmentIdentityType_Ipaddress

ueIdentity := "2600:1010:b1d0:0000:0000:0000:0000:0012"

serviceEndpointsIds := "43f3f7bb-d6c5-4bad-b081-9a3a0df2db98"

apiResponse, err := serviceEndpointsApi.ListOptimalServiceEndpoints(ctx, &region, nil, &ueIdentityType, &ueIdentity, &serviceEndpointsIds)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "serviceEndpoints": [
    {
      "ern": "LASVEGAS_NV_WL",
      "serviceEndpoint": {
        "URI": "http://base_path/some_segment/id",
        "FQDN": "thingtest.verizon.com",
        "IPv4Address": "192.168.11.10",
        "IPv6Address": "2001:0db8:85a3:0000:0000:8a2e:0370:1234",
        "port": 1234
      },
      "applicationServerProviderId": "AWS",
      "applicationId": "IogspaceJan15",
      "serviceDescription": "ThieIt"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Register Service Endpoints

Register Service Endpoints of a deployed application to specified MEC Platforms.

```go
RegisterServiceEndpoints(
    ctx context.Context,
    body []models.ResourcesEdgeHostedServiceWithProfileId) (
    models.ApiResponse[models.RegisterServiceEndpointResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`[]models.ResourcesEdgeHostedServiceWithProfileId`](../../doc/models/resources-edge-hosted-service-with-profile-id.md) | Body, Required | An array of Service Endpoint data for a deployed application. The request body passes all of the needed parameters to create a service endpoint. Parameters will be edited here rather than the **Parameters** section above. The `ern`,`applicationServerProviderId`, `applicationId` and `serviceProfileID` parameters are required. **Note:** Currently, the only valid value for `applicationServerProviderId`is **AWS**. Also, if you do not know one of the optional values (i.e. URI), you can erase the line from the query by back-spacing over it.<br><br>**Constraints**: *Maximum Items*: `100` |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RegisterServiceEndpointResult](../../doc/models/register-service-endpoint-result.md).

## Example Usage

```go
ctx := context.Background()

body := []models.ResourcesEdgeHostedServiceWithProfileId{
    models.ResourcesEdgeHostedServiceWithProfileId{
        Ern:                         models.ToPointer("us-east-1-wl1-atl-wlz-1"),
        ServiceEndpoint:             models.ToPointer(models.ResourcesServiceEndpoint{
            Uri:         models.ToPointer("http://base_path/some_segment/id"),
            Fqdn:        models.ToPointer("thingtest.verizon.com"),
            IPv4Address: models.ToPointer("192.168.11.10"),
            IPv6Address: models.ToPointer("2001:0db8:85a3:0000:0000:8a2e:0370:1234"),
            Port:        models.ToPointer(1234),
        }),
        ApplicationServerProviderId: models.ToPointer("AWS"),
        ApplicationId:               models.ToPointer("IogspaceJan15"),
        ServiceDescription:          models.ToPointer("ThieIt"),
        ServiceProfileId:            models.ToPointer("4054ea9a-593e-4776-b488-697b1bfa4f3b"),
    },
}

apiResponse, err := serviceEndpointsApi.RegisterServiceEndpoints(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# List All Service Endpoints

Returns a list of all registered service endpoints.

```go
ListAllServiceEndpoints(
    ctx context.Context) (
    models.ApiResponse[models.ListAllServiceEndpointsResult],
    error)
```

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ListAllServiceEndpointsResult](../../doc/models/list-all-service-endpoints-result.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := serviceEndpointsApi.ListAllServiceEndpoints(ctx)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "data": [
    "serviceEndpointsId"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Get Service Endpoint

Returns endpoint information for all Service Endpoints registered to a specified serviceEndpointId.

```go
GetServiceEndpoint(
    ctx context.Context,
    serviceEndpointsId string) (
    models.ApiResponse[[]models.ResourcesEdgeHostedServiceWithProfileId],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceEndpointsId` | `string` | Template, Required | A system-defined string identifier representing one or more registered Service Endpoints. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.ResourcesEdgeHostedServiceWithProfileId](../../doc/models/resources-edge-hosted-service-with-profile-id.md).

## Example Usage

```go
ctx := context.Background()

serviceEndpointsId := "43f3f7bb-d6c5-4bad-b081-9a3a0df2db98"

apiResponse, err := serviceEndpointsApi.GetServiceEndpoint(ctx, serviceEndpointsId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
[
  {
    "serviceEndpoint": {
      "FQDN": "thingtest.verizon.com",
      "IPv4Address": "192.168.11.10",
      "IPv6Address": "2001:0db8:85a3:0000:0000:8a2e:0370:1234",
      "port": 1234,
      "URI": "http://base_path/some_segment/id"
    },
    "applicationId": "IogspaceJan15",
    "serviceDescription": "ThieIt",
    "applicationServerProviderId": "AWS",
    "ern": "us-east-1-wl1-atl-wlz-1",
    "serviceProfileID": "4054ea9a-593e-4776-b488-697b1bfa4f3b"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Update Service Endpoint

Update registered Service Endpoint information.

```go
UpdateServiceEndpoint(
    ctx context.Context,
    serviceEndpointsId string,
    body []models.ResourcesEdgeHostedServiceWithProfileId) (
    models.ApiResponse[models.UpdateServiceEndpointResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceEndpointsId` | `string` | Template, Required | A system-defined string identifier representing one or more registered Service Endpoints. |
| `body` | [`[]models.ResourcesEdgeHostedServiceWithProfileId`](../../doc/models/resources-edge-hosted-service-with-profile-id.md) | Body, Required | Data needed for Service Endpoint information. The request body passes the rest of the needed parameters to create a service endpoint. Parameters other than `serviceEndpointsId` will be edited here rather than the **Parameters** section above. The `ern`,`applicationServerProviderId` and `applicationId` parameters are required. **Note:** Currently, the only valid value for `applicationServerProviderId`is **AWS**.<br><br>**Constraints**: *Maximum Items*: `100` |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UpdateServiceEndpointResult](../../doc/models/update-service-endpoint-result.md).

## Example Usage

```go
ctx := context.Background()

serviceEndpointsId := "43f3f7bb-d6c5-4bad-b081-9a3a0df2db98"

body := []models.ResourcesEdgeHostedServiceWithProfileId{
    models.ResourcesEdgeHostedServiceWithProfileId{
        Ern:                         models.ToPointer("us-east-1-wl1-atl-wlz-1"),
        ServiceEndpoint:             models.ToPointer(models.ResourcesServiceEndpoint{
            Uri:         models.ToPointer("http://base_path/some_segment/id"),
            Fqdn:        models.ToPointer("thingtest.verizon.com"),
            IPv4Address: models.ToPointer("192.168.11.10"),
            IPv6Address: models.ToPointer("2001:0db8:85a3:0000:0000:8a2e:0370:1234"),
            Port:        models.ToPointer(1234),
        }),
        ApplicationServerProviderId: models.ToPointer("AWS"),
        ApplicationId:               models.ToPointer("IogspaceJan15"),
        ServiceDescription:          models.ToPointer("ThieIt"),
        ServiceProfileId:            models.ToPointer("4054ea9a-593e-4776-b488-697b1bfa4f3b"),
    },
}

apiResponse, err := serviceEndpointsApi.UpdateServiceEndpoint(ctx, serviceEndpointsId, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "status": "Success",
  "message": "EdgeAppServices are updated"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Deregister Service Endpoint

Deregister an application's Service Endpoint from the MEC Platform(s).

```go
DeregisterServiceEndpoint(
    ctx context.Context,
    serviceEndpointsId string) (
    models.ApiResponse[models.DeregisterServiceEndpointResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceEndpointsId` | `string` | Template, Required | A system-defined string identifier representing one or more registered Service Endpoints. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeregisterServiceEndpointResult](../../doc/models/deregister-service-endpoint-result.md).

## Example Usage

```go
ctx := context.Background()

serviceEndpointsId := "43f3f7bb-d6c5-4bad-b081-9a3a0df2db98"

apiResponse, err := serviceEndpointsApi.DeregisterServiceEndpoint(ctx, serviceEndpointsId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "status": "Success",
  "message": "EdgeAppServicesID Deleted"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |

