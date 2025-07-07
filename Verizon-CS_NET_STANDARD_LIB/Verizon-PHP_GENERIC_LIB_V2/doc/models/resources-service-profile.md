
# Resources Service Profile

Information about the resource requirements and service characteristics of an edge application. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Does not include serviceProfileId

## Structure

`ResourcesServiceProfile`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `clientType` | [`string(ClientType)`](../../doc/models/client-type.md) | Required | The category of application client. | getClientType(): string | setClientType(string clientType): void |
| `ecspFilter` | `?string` | Optional | Identity of the preferred Edge Computing Service Provider.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getEcspFilter(): ?string | setEcspFilter(?string ecspFilter): void |
| `clientSchedule` | `?string` | Optional | The expected operation schedule of the application client (e.g. time windows).<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` | getClientSchedule(): ?string | setClientSchedule(?string clientSchedule): void |
| `clientServiceArea` | `?string` | Optional | The expected location(s) (e.g. route) of the hosting UE during the Client's operation schedule.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` | getClientServiceArea(): ?string | setClientServiceArea(?string clientServiceArea): void |
| `networkResources` | [`?NetworkResourcesType`](../../doc/models/network-resources-type.md) | Optional | Network resources of a service profile. | getNetworkResources(): ?NetworkResourcesType | setNetworkResources(?NetworkResourcesType networkResources): void |
| `computeResources` | [`?ComputeResourcesType`](../../doc/models/compute-resources-type.md) | Optional | Compute resources of a service profile. | getComputeResources(): ?ComputeResourcesType | setComputeResources(?ComputeResourcesType computeResources): void |
| `properties` | [`?MecPlatformsAdditionalSupportInfo`](../../doc/models/mec-platforms-additional-support-info.md) | Optional | Additional service support information for the MEC platform. | getProperties(): ?MecPlatformsAdditionalSupportInfo | setProperties(?MecPlatformsAdditionalSupportInfo properties): void |

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

