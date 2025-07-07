# Service Profiles

```java
ServiceProfilesApi serviceProfilesApi = client.getServiceProfilesApi();
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

```java
CompletableFuture<ApiResponse<CreateServiceProfileResult>> createServiceProfileAsync(
    final ResourcesServiceProfile body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResourcesServiceProfile`](../../doc/models/resources-service-profile.md) | Body, Required | The request body passes all of the needed parameters to create a service profile. Parameters will be edited here rather than the **Parameters** section above. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Additionally, "GPU" is future functionality and the values are not captured. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`CreateServiceProfileResult`](../../doc/models/create-service-profile-result.md).

## Example Usage

```java
ResourcesServiceProfile body = new ResourcesServiceProfile.Builder(
    ClientType.V2_X
)
.ecspFilter("Verizon")
.clientSchedule("time windows")
.clientServiceArea("BAY AREA")
.networkResources(new NetworkResourcesType.Builder(
        20
    )
    .minBandwidthKbits(1)
    .serviceContinuitySupport(true)
    .maxRequestRate(15)
    .minAvailability(1)
    .build())
.computeResources(new ComputeResourcesType.Builder()
        .gpu(new Gpu.Builder()
            .minCoreClockMHz(1)
            .minMemoryClockMHz(35740)
            .minBandwidthGBs(588)
            .minTflops(33)
            .build())
        .minRamgb(1)
        .minStorageGb(1)
        .build())
.build();

serviceProfilesApi.createServiceProfileAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | HTTP 400 Bad Request. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| 401 | HTTP 401 Unauthorized. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |
| Default | HTTP 500 Internal Server Error. | [`EdgeDiscoveryResultException`](../../doc/models/edge-discovery-result-exception.md) |


# List Service Profiles

List all service profiles registered under your API key.

```java
CompletableFuture<ApiResponse<ListServiceProfilesResult>> listServiceProfilesAsync()
```

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ListServiceProfilesResult`](../../doc/models/list-service-profiles-result.md).

## Example Usage

```java
serviceProfilesApi.listServiceProfilesAsync().thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<ResourcesServiceProfileWithId>> getServiceProfileAsync(
    final String serviceProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceProfileId` | `String` | Template, Required | **Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ResourcesServiceProfileWithId`](../../doc/models/resources-service-profile-with-id.md).

## Example Usage

```java
String serviceProfileId = "serviceProfileId2";

serviceProfilesApi.getServiceProfileAsync(serviceProfileId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<UpdateServiceProfileResult>> updateServiceProfileAsync(
    final String serviceProfileId,
    final ResourcesServiceProfile body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceProfileId` | `String` | Template, Required | **Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |
| `body` | [`ResourcesServiceProfile`](../../doc/models/resources-service-profile.md) | Body, Required | The request body passes the rest of the needed parameters to create a service profile. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Additionally, "GPU" is future functionality and the values are not captured. Default values to use are shown. |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`UpdateServiceProfileResult`](../../doc/models/update-service-profile-result.md).

## Example Usage

```java
String serviceProfileId = "serviceProfileId2";
ResourcesServiceProfile body = new ResourcesServiceProfile.Builder(
    ClientType.V2_X
)
.ecspFilter("Verizon")
.clientSchedule("time windows")
.clientServiceArea("BAY AREA")
.networkResources(new NetworkResourcesType.Builder(
        20
    )
    .minBandwidthKbits(1)
    .serviceContinuitySupport(true)
    .maxRequestRate(15)
    .minAvailability(1)
    .build())
.computeResources(new ComputeResourcesType.Builder()
        .gpu(new Gpu.Builder()
            .minCoreClockMHz(1)
            .build())
        .minRamgb(1)
        .minStorageGb(1)
        .build())
.build();

serviceProfilesApi.updateServiceProfileAsync(serviceProfileId, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<DeleteServiceProfileResult>> deleteServiceProfileAsync(
    final String serviceProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serviceProfileId` | `String` | Template, Required | **Constraints**: *Maximum Length*: `36`, *Pattern*: ``^[a-zA-Z0-9!@#$&()\-`.+,/"]{3,36}$`` |

## Requires scope

### thingspace_oauth

`edge:discovery:read`, `edge:serviceprofile:read`, `edge:serviceprofile:write`, `edge:serviceregistry:read`, `edge:serviceregistry:write`, `ts.application.ro`, `ts.mec.fullaccess`, `ts.mec.limitaccess`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeleteServiceProfileResult`](../../doc/models/delete-service-profile-result.md).

## Example Usage

```java
String serviceProfileId = "serviceProfileId2";

serviceProfilesApi.deleteServiceProfileAsync(serviceProfileId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

