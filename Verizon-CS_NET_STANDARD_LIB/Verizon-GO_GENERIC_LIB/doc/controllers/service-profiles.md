# Service Profiles

```go
serviceProfilesApi := client.ServiceProfilesApi()
```

## Class Name

`ServiceProfilesApi`

## Methods

* [Create Service Profile](../../doc/controllers/service-profiles.md#create-service-profile)
* [List Service Profiles](../../doc/controllers/service-profiles.md#list-service-profiles)
* [Get Service Profile](../../doc/controllers/service-profiles.md#get-service-profile)
* [Update Service Profile](../../doc/controllers/service-profiles.md#update-service-profile)
* [Delete Service Profile](../../doc/controllers/service-profiles.md#delete-service-profile)


# Create Service Profile

Creates a service profile that describes the resource requirements of a service.

```go
CreateServiceProfile(
    ctx context.Context,
    body models.ResourcesServiceProfile) (
    models.ApiResponse[models.CreateServiceProfileResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ResourcesServiceProfile`](../../doc/models/resources-service-profile.md) | Body, Required | The request body passes all of the needed parameters to create a service profile. Parameters will be edited here rather than the **Parameters** section above. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Additionally, "GPU" is future functionality and the values are not captured. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CreateServiceProfileResult](../../doc/models/create-service-profile-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.ResourcesServiceProfile{
    ClientType:        models.ClientType_V2X,
    EcspFilter:        models.ToPointer("Verizon"),
    ClientSchedule:    models.ToPointer("time windows"),
    ClientServiceArea: models.ToPointer("BAY AREA"),
    NetworkResources:  models.ToPointer(models.NetworkResourcesType{
        MinBandwidthKbits:        models.ToPointer(1),
        ServiceContinuitySupport: models.ToPointer(true),
        MaxRequestRate:           models.ToPointer(15),
        MaxLatencyMs:             20,
        MinAvailability:          models.ToPointer(1),
    }),
    ComputeResources:  models.ToPointer(models.ComputeResourcesType{
        Gpu:          models.ToPointer(models.Gpu{
            MinCoreClockMHz:   models.ToPointer(1),
            MinMemoryClockMHz: models.ToPointer(35740),
            MinBandwidthGBs:   models.ToPointer(588),
            MinTflops:         models.ToPointer(33),
        }),
        MinRamgb:     models.ToPointer(1),
        MinStorageGb: models.ToPointer(1),
    }),
}

apiResponse, err := serviceProfilesApi.CreateServiceProfile(ctx, body)
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


# List Service Profiles

List all service profiles registered under your API key.

```go
ListServiceProfiles(
    ctx context.Context) (
    models.ApiResponse[models.ListServiceProfilesResult],
    error)
```

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ListServiceProfilesResult](../../doc/models/list-service-profiles-result.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := serviceProfilesApi.ListServiceProfiles(ctx)
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
  "data": [
    "serviceProfileId"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Get Service Profile

Returns a specified service profile.

```go
GetServiceProfile(
    ctx context.Context,
    serviceProfileId string) (
    models.ApiResponse[models.ResourcesServiceProfileWithId],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceProfileId` | `string` | Template, Required | **Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ResourcesServiceProfileWithId](../../doc/models/resources-service-profile-with-id.md).

## Example Usage

```go
ctx := context.Background()

serviceProfileId := "serviceProfileId2"

apiResponse, err := serviceProfilesApi.GetServiceProfile(ctx, serviceProfileId)
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
  "serviceProfileId": "4054ea9a-593e-4776-b488-697b1bfa4f3b",
  "ecspFilter": "Verizon",
  "clientSchedule": "time windows",
  "clientServiceArea": "BAY AREA",
  "clientType": "V2X",
  "networkResources": {
    "minBandwidthKbits": 1,
    "serviceContinuitySupport": true,
    "maxRequestRate": 15,
    "maxLatencyMs": 20,
    "minAvailability": 1
  },
  "computeResources": {
    "GPU": {
      "minCoreClockMHz": 1,
      "minMemoryClockMHz": 35740,
      "minBandwidthGBs": 588,
      "minTFLOPS": 33
    },
    "minRAMGB": 1,
    "minStorageGB": 1
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Update Service Profile

Update the definition of a Service Profile.

```go
UpdateServiceProfile(
    ctx context.Context,
    serviceProfileId string,
    body models.ResourcesServiceProfile) (
    models.ApiResponse[models.UpdateServiceProfileResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceProfileId` | `string` | Template, Required | **Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |
| `body` | [`models.ResourcesServiceProfile`](../../doc/models/resources-service-profile.md) | Body, Required | The request body passes the rest of the needed parameters to create a service profile. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Additionally, "GPU" is future functionality and the values are not captured. Default values to use are shown. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UpdateServiceProfileResult](../../doc/models/update-service-profile-result.md).

## Example Usage

```go
ctx := context.Background()

serviceProfileId := "serviceProfileId2"

body := models.ResourcesServiceProfile{
    ClientType:        models.ClientType_V2X,
    EcspFilter:        models.ToPointer("Verizon"),
    ClientSchedule:    models.ToPointer("time windows"),
    ClientServiceArea: models.ToPointer("BAY AREA"),
    NetworkResources:  models.ToPointer(models.NetworkResourcesType{
        MinBandwidthKbits:        models.ToPointer(1),
        ServiceContinuitySupport: models.ToPointer(true),
        MaxRequestRate:           models.ToPointer(15),
        MaxLatencyMs:             20,
        MinAvailability:          models.ToPointer(1),
    }),
    ComputeResources:  models.ToPointer(models.ComputeResourcesType{
        Gpu:          models.ToPointer(models.Gpu{
            MinCoreClockMHz:   models.ToPointer(1),
        }),
        MinRamgb:     models.ToPointer(1),
        MinStorageGb: models.ToPointer(1),
    }),
}

apiResponse, err := serviceProfilesApi.UpdateServiceProfile(ctx, serviceProfileId, body)
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
  "message": "Service Profile Updated"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# Delete Service Profile

Delete Service Profile based on unique service profile ID.

```go
DeleteServiceProfile(
    ctx context.Context,
    serviceProfileId string) (
    models.ApiResponse[models.DeleteServiceProfileResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceProfileId` | `string` | Template, Required | **Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeleteServiceProfileResult](../../doc/models/delete-service-profile-result.md).

## Example Usage

```go
ctx := context.Background()

serviceProfileId := "serviceProfileId2"

apiResponse, err := serviceProfilesApi.DeleteServiceProfile(ctx, serviceProfileId)
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
  "message": "Service Profile Deleted"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |

