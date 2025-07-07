
# Mec Platforms Additional Support Info Data

Data about additional service support information for the MEC platform.

*This model accepts additional fields of type Any.*

## Structure

`MecPlatformsAdditionalSupportInfoData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `additional_info` | `str` | Optional | **Constraints**: *Maximum Length*: `32` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "additionalInfo": "additionalInfo2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

