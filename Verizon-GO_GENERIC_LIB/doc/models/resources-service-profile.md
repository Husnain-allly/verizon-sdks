
# Resources Service Profile

Information about the resource requirements and service characteristics of an edge application. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Does not include serviceProfileId

## Structure

`ResourcesServiceProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientType` | [`models.ClientType`](../../doc/models/client-type.md) | Required | The category of application client. |
| `EcspFilter` | `*string` | Optional | Identity of the preferred Edge Computing Service Provider.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `ClientSchedule` | `*string` | Optional | The expected operation schedule of the application client (e.g. time windows).<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` |
| `ClientServiceArea` | `*string` | Optional | The expected location(s) (e.g. route) of the hosting UE during the Client's operation schedule.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` |
| `NetworkResources` | [`*models.NetworkResourcesType`](../../doc/models/network-resources-type.md) | Optional | Network resources of a service profile. |
| `ComputeResources` | [`*models.ComputeResourcesType`](../../doc/models/compute-resources-type.md) | Optional | Compute resources of a service profile. |
| `Properties` | [`*models.MecPlatformsAdditionalSupportInfo`](../../doc/models/mec-platforms-additional-support-info.md) | Optional | Additional service support information for the MEC platform. |

## Example (as JSON)

```json
{
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
  },
  "computeResources": {
    "GPU": {
      "minCoreClockMHz": 76,
      "minMemoryClockMHz": 20,
      "minBandwidthGBs": 96,
      "minTFLOPS": 100
    },
    "minRAMGB": 100,
    "minStorageGB": 100
  }
}
```

