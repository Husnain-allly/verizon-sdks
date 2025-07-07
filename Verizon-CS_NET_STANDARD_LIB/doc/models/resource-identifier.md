
# Resource Identifier

The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.

*This model accepts additional fields of type object.*

## Structure

`ResourceIdentifier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Target ID. |
| `Imei` | `string` | Optional | Device IMEI. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

