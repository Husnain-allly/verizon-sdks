
# Account Identifier

The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`.

*This model accepts additional fields of type Any.*

## Structure

`AccountIdentifier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `billingaccountid` | `str` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

