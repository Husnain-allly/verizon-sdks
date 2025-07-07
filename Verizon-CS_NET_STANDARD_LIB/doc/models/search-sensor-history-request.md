
# Search Sensor History Request

Search Device By Property resource definition.

*This model accepts additional fields of type object.*

## Structure

`SearchSensorHistoryRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountidentifier` | [`AccountIdentifier`](../../doc/models/account-identifier.md) | Required | The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. |
| `Resourceidentifier` | [`ResourceIdentifier`](../../doc/models/resource-identifier.md) | Required | The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}. |
| `MLimitnumber` | `int?` | Optional | The maximum number of events to include in the response. |
| `MPage` | `string` | Optional | The maximum number of events to include in the response. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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
  "resourceidentifier": {
    "id": "2e61a17d-8fd1-6816-e995-e4c2528bf535",
    "imei": "imei2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "$limitnumber": 2,
  "$page": "$page4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

