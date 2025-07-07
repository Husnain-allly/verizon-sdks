
# Resources Service Profile With Id

Information about the resource requirements and service characteristics of an edge application. Includes serviceProfileId. Used when retrieving a service profile.

## Structure

`ResourcesServiceProfileWithId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ServiceProfileId` | `String` | Optional | Unique identifier for a service profile. | String getServiceProfileId() | setServiceProfileId(String serviceProfileId) |
| `ClientType` | [`ClientType`](../../doc/models/client-type.md) | Required | The category of application client. | ClientType getClientType() | setClientType(ClientType clientType) |
| `EcspFilter` | `String` | Optional | Identity of the preferred Edge Computing Service Provider.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getEcspFilter() | setEcspFilter(String ecspFilter) |
| `ClientSchedule` | `String` | Optional | The expected operation schedule of the application client (e.g. time windows).<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` | String getClientSchedule() | setClientSchedule(String clientSchedule) |
| `ClientServiceArea` | `String` | Optional | The expected location(s) (e.g. route) of the hosting UE during the Client's operation schedule.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` | String getClientServiceArea() | setClientServiceArea(String clientServiceArea) |
| `NetworkResources` | [`NetworkResourcesType`](../../doc/models/network-resources-type.md) | Optional | Network resources of a service profile. | NetworkResourcesType getNetworkResources() | setNetworkResources(NetworkResourcesType networkResources) |
| `ComputeResources` | [`ComputeResourcesType`](../../doc/models/compute-resources-type.md) | Optional | Compute resources of a service profile. | ComputeResourcesType getComputeResources() | setComputeResources(ComputeResourcesType computeResources) |
| `Properties` | [`MecPlatformsAdditionalSupportInfo`](../../doc/models/mec-platforms-additional-support-info.md) | Optional | Additional service support information for the MEC platform. | MecPlatformsAdditionalSupportInfo getProperties() | setProperties(MecPlatformsAdditionalSupportInfo properties) |

## Example (as JSON)

```json
{
  "serviceProfileId": "4054ea9a-593e-4776-b488-697b1bfa4f3b",
  "clientType": "ComputerVision",
  "ecspFilter": "Verizon",
  "clientSchedule": "time windows",
  "clientServiceArea": "BAY AREA",
  "networkResources": {
    "minBandwidthKbits": 252,
    "serviceContinuitySupport": false,
    "maxRequestRate": 100,
    "maxLatencyMs": 146,
    "minAvailability": 100
  }
}
```

