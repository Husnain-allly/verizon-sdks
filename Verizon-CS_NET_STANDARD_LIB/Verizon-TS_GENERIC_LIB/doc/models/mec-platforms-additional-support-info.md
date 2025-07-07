
# Mec Platforms Additional Support Info

Additional service support information for the MEC platform.

## Structure

`MecPlatformsAdditionalSupportInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | `string \| undefined` | Optional | Type of additional service support information for the MEC platform.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `data` | [`MecPlatformsAdditionalSupportInfoData \| undefined`](../../doc/models/mec-platforms-additional-support-info-data.md) | Optional | Data about additional service support information for the MEC platform. |

## Example (as JSON)

```json
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
```

