# 5G Edge Platforms

```go
m5GEdgePlatformsApi := client.M5GEdgePlatformsApi()
```

## Class Name

`M5GEdgePlatformsApi`

## Methods

* [List MEC Platforms](../../doc/controllers/5g-edge-platforms.md#list-mec-platforms)
* [List Regions](../../doc/controllers/5g-edge-platforms.md#list-regions)


# List MEC Platforms

Returns a list of optimal MEC Platforms where you can register your deployed application. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - region plus Service Profile ID and subscriber density (density is optional but recommended), region plus UEIdentity(Including UEIdentity Type) or Service Profile ID plus UEIdentity(Including UEIdentity Type).

```go
ListMecPlatforms(
    ctx context.Context,
    region *string,
    serviceProfileId *string,
    subscriberDensity *int,
    ueIdentityType *models.UserEquipmentIdentityType,
    ueIdentity *string) (
    models.ApiResponse[models.ListMecPlatformsResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `region` | `*string` | Query, Optional | MEC region name. Current valid values are US_WEST_2 and US_EAST_1. |
| `serviceProfileId` | `*string` | Query, Optional | Unique identifier of the service profile.<br><br>**Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |
| `subscriberDensity` | `*int` | Query, Optional | Minimum number of 4G/5G subscribers per square kilometer.<br><br>**Constraints**: `>= 1`, `<= 100` |
| `ueIdentityType` | [`*models.UserEquipmentIdentityType`](../../doc/models/user-equipment-identity-type.md) | Query, Optional | Type of User Equipment identifier used in `UEIdentity`. |
| `ueIdentity` | `*string` | Query, Optional | The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ListMecPlatformsResult](../../doc/models/list-mec-platforms-result.md).

## Example Usage

```go
ctx := context.Background()

region := "US_WEST_2"





ueIdentityType := models.UserEquipmentIdentityType_Ipaddress

ueIdentity := "2600:1010:b1d0:0000:0000:0000:0000:0012"

apiResponse, err := m5GEdgePlatformsApi.ListMecPlatforms(ctx, &region, nil, nil, &ueIdentityType, &ueIdentity)
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
  "MECPlatforms": [
    {
      "ern": "5x4VBwmfZbzSL3",
      "zone": "e5oV52kMGjDLhnJSsLJZL",
      "region": "US_WEST_2",
      "status": "unknown"
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


# List Regions

List the geographical regions available, based on the user's bearer token. **Note:** Country code, Metropolitan area, Area and Zone are future functionality and will currently return a "null" value.

```go
ListRegions(
    ctx context.Context) (
    models.ApiResponse[models.ListRegionsResult],
    error)
```

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ListRegionsResult](../../doc/models/list-regions-result.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := m5GEdgePlatformsApi.ListRegions(ctx)
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
  "regions": [
    {
      "regionId": "consectetur",
      "name": "US_EAST_1",
      "countryCode": "nr",
      "metro": "e1D",
      "area": "IdUESF"
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

