
# Callback Registration Result

*This model accepts additional fields of type unknown.*

## Structure

`CallbackRegistrationResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string \| undefined` | Optional | The name of the account that registered the callback URL. |
| `name` | [`CallbackServiceName \| undefined`](../../doc/models/callback-service-name.md) | Optional | The name of the callback service. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

