
# Mec Platform Resource

5G Edge platform used for deployment of a service. The ern of each platform contains the name of the matching AWS Wavelength zone that can be used when deploying.

## Structure

`MecPlatformResource`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Ern` | `String` | Optional | Edge Resource Name. A string identifier for a set of edge resources.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9-]{3,32}$` | String getErn() | setErn(String ern) |
| `Zone` | `String` | Optional | Unique identifier representing a zone. *Note:* This will have a null value as a placeholder.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getZone() | setZone(String zone) |
| `Region` | `String` | Optional | MEC region name. Current valid values are US_WEST_2 and US_EAST_1. | String getRegion() | setRegion(String region) |
| `Status` | [`MecPlatformStatus`](../../doc/models/mec-platform-status.md) | Optional | Status of the MEC Platform (default is 'unknown')<br><br>**Default**: `MecPlatformStatus.UNKNOWN` | MecPlatformStatus getStatus() | setStatus(MecPlatformStatus status) |
| `Properties` | [`MecPlatformResourceProperties`](../../doc/models/containers/mec-platform-resource-properties.md) | Optional | This is a container for one-of cases. | MecPlatformResourceProperties getProperties() | setProperties(MecPlatformResourceProperties properties) |

## Example (as JSON)

```json
{
  "ern": "5x4VBwmfZbzSL3",
  "zone": "e5oV52kMGjDLhnJSsLJZL",
  "region": "US_WEST_2",
  "status": "unknown",
  "properties": [
    {
      "type": "type8",
      "data": {
        "additionalInfo": "additionalInfo2",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    }
  ]
}
```

