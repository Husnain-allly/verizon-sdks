
# Callback Registration Result

*This model accepts additional fields of type Object.*

## Structure

`CallbackRegistrationResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Account` | `String` | Optional | The name of the account that registered the callback URL. | String getAccount() | setAccount(String account) |
| `Name` | [`CallbackServiceName`](../../doc/models/callback-service-name.md) | Optional | The name of the callback service. | CallbackServiceName getName() | setName(CallbackServiceName name) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

