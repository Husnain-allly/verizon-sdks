
# Mec Platform Resource

5G Edge platform used for deployment of a service. The ern of each platform contains the name of the matching AWS Wavelength zone that can be used when deploying.

## Structure

`MecPlatformResource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ern` | `string` | Optional | Edge Resource Name. A string identifier for a set of edge resources.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9-]{3,32}$` |
| `Zone` | `string` | Optional | Unique identifier representing a zone. *Note:* This will have a null value as a placeholder.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `Region` | `string` | Optional | MEC region name. Current valid values are US_WEST_2 and US_EAST_1. |
| `Status` | [`MecPlatformStatus?`](../../doc/models/mec-platform-status.md) | Optional | Status of the MEC Platform (default is 'unknown')<br><br>**Default**: `MecPlatformStatus.unknown` |
| `Properties` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "ern": "5x4VBwmfZbzSL3",
  "zone": "e5oV52kMGjDLhnJSsLJZL",
  "region": "US_WEST_2",
  "status": "unknown",
  "properties": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

