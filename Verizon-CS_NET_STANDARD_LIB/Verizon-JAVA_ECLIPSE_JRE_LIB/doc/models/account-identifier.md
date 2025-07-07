
# Account Identifier

The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.

*This model accepts additional fields of type Object.*

## Structure

`AccountIdentifier`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Billingaccountid` | `String` | Optional | - | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "billingaccountid": "0000000000-00001",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

