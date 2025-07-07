
# Fota V1 Success Result

A response to a successful request contains a single Boolean value.

*This model accepts additional fields of type object.*

## Structure

`FotaV1SuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Success` | `bool?` | Optional | True is returned in case of success. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "success": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

