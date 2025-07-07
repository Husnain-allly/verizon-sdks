
# Resource Identifier

The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.

*This model accepts additional fields of type Object.*

## Structure

`ResourceIdentifier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Optional | Target ID. |
| `imei` | `String` | Optional | Device IMEI. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "id": "2e61a17d-8fd1-6816-e995-e4c2528bf535",
  "imei": "imei8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

