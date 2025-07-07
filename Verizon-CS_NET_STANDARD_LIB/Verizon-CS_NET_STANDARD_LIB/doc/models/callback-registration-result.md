
# Callback Registration Result

*This model accepts additional fields of type object.*

## Structure

`CallbackRegistrationResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Account` | `string` | Optional | The name of the account that registered the callback URL. |
| `Name` | [`CallbackServiceName?`](../../doc/models/callback-service-name.md) | Optional | The name of the callback service. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "account": "0212312345-00001",
  "name": "Location",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

