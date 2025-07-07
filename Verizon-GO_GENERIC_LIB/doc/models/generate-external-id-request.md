
# Generate External Id Request

Authenticating account ID.

*This model accepts additional fields of type interface{}.*

## Structure

`GenerateExternalIdRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountidentifier` | [`*models.AccountIdentifier`](../../doc/models/account-identifier.md) | Optional | The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountidentifier": {
    "billingaccountid": "0000000000-00001",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

