
# Dto Device Command

*This model accepts additional fields of type Object.*

## Structure

`DtoDeviceCommand`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | The numeric account name, which must include leading zeros |
| `configuration` | [`Rbstiltconfig`](../../doc/models/rbstiltconfig.md) | Optional | - |
| `resourceidentifier` | [`DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "configuration": {
    "RbsHighPrecisionTiltConfig": {
      "mode": "reportOnChange",
      "periodic-reporting": {
        "unit": "minutes",
        "hours": 250,
        "minutes": 232,
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "hold-time": 62,
      "angle-away": 90,
      "angle-toward": 30,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "resourceidentifier": {
    "id": "id4"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

