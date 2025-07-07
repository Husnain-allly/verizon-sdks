
# History Search Filter

The selected device and attributes for which a request should retrieve data.

*This model accepts additional fields of type object.*

## Structure

`HistorySearchFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account name identifier. |
| `Device` | [`Device`](../../doc/models/device.md) | Required | Identifies a particular IoT device. |
| `Attributes` | [`HistorySearchFilterAttributes`](../../doc/models/history-search-filter-attributes.md) | Optional | Streaming RF parameters for which you want to retrieve history data. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "device": {
    "id": "15-digit IMEI",
    "kind": "IMEI",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "attributes": {
    "name": "LINK_QUALITY",
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

