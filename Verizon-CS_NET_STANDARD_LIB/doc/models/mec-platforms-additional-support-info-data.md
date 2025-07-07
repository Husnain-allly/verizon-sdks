
# Mec Platforms Additional Support Info Data

Data about additional service support information for the MEC platform.

*This model accepts additional fields of type object.*

## Structure

`MecPlatformsAdditionalSupportInfoData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalInfo` | `string` | Optional | **Constraints**: *Maximum Length*: `32` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

