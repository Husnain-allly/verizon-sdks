
# Device Idarray

*This model accepts additional fields of type Object.*

## Structure

`DeviceIdarray`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `kind` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `id` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "kind": "imei",
  "id": "id8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

