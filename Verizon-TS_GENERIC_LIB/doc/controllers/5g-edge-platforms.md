# 5G Edge Platforms

```ts
const m5GEdgePlatformsApi = new M5GEdgePlatformsApi(client);
```

## Class Name

`M5GEdgePlatformsApi`

## Methods

* [List MEC Platforms](../../doc/controllers/5g-edge-platforms.md#list-mec-platforms)
* [List Regions](../../doc/controllers/5g-edge-platforms.md#list-regions)


# List MEC Platforms

Returns a list of optimal MEC Platforms where you can register your deployed application. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - region plus Service Profile ID and subscriber density (density is optional but recommended), region plus UEIdentity(Including UEIdentity Type) or Service Profile ID plus UEIdentity(Including UEIdentity Type).

```ts
async listMecPlatforms(
  region?: string,
  serviceProfileId?: string,
  subscriberDensity?: number,
  ueIdentityType?: UserEquipmentIdentityType,
  ueIdentity?: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<ListMecPlatformsResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `region` | `string \| undefined` | Query, Optional | MEC region name. Current valid values are US_WEST_2 and US_EAST_1. |
| `serviceProfileId` | `string \| undefined` | Query, Optional | Unique identifier of the service profile.<br><br>**Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |
| `subscriberDensity` | `number \| undefined` | Query, Optional | Minimum number of 4G/5G subscribers per square kilometer.<br><br>**Constraints**: `>= 1`, `<= 100` |
| `ueIdentityType` | [`UserEquipmentIdentityType \| undefined`](../../doc/models/user-equipment-identity-type.md) | Query, Optional | Type of User Equipment identifier used in `UEIdentity`. |
| `ueIdentity` | `string \| undefined` | Query, Optional | The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [ListMecPlatformsResult](../../doc/models/list-mec-platforms-result.md).

## Example Usage

```ts
const region = 'US_WEST_2';

const ueIdentityType = UserEquipmentIdentityType.Ipaddress;

const ueIdentity = '2600:1010:b1d0:0000:0000:0000:0000:0012';

try {
  const { result, ...httpResponse } = await m5GEdgePlatformsApi.listMecPlatforms(
  region,
  undefined,
  undefined,
  ueIdentityType,
  ueIdentity
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
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
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultError`](../../doc/models/edge-discovery-result-error.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultError`](../../doc/models/edge-discovery-result-error.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultError`](../../doc/models/edge-discovery-result-error.md) |


# List Regions

List the geographical regions available, based on the user's bearer token. **Note:** Country code, Metropolitan area, Area and Zone are future functionality and will currently return a "null" value.

```ts
async listRegions(
  requestOptions?: RequestOptions
): Promise<ApiResponse<ListRegionsResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [ListRegionsResult](../../doc/models/list-regions-result.md).

## Example Usage

```ts
try {
  const { result, ...httpResponse } = await m5GEdgePlatformsApi.listRegions();
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
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
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultError`](../../doc/models/edge-discovery-result-error.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultError`](../../doc/models/edge-discovery-result-error.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultError`](../../doc/models/edge-discovery-result-error.md) |

