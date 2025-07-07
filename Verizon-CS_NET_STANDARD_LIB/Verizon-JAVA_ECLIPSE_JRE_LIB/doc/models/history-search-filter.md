
# History Search Filter

The selected device and attributes for which a request should retrieve data.

*This model accepts additional fields of type Object.*

## Structure

`HistorySearchFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | Account name identifier. | String getAccountName() | setAccountName(String accountName) |
| `Device` | [`Device`](../../doc/models/device.md) | Required | Identifies a particular IoT device. | Device getDevice() | setDevice(Device device) |
| `Attributes` | [`HistorySearchFilterAttributes`](../../doc/models/history-search-filter-attributes.md) | Optional | Streaming RF parameters for which you want to retrieve history data. | HistorySearchFilterAttributes getAttributes() | setAttributes(HistorySearchFilterAttributes attributes) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

