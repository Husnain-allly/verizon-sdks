
# Dto Bulk Update

*This model accepts additional fields of type object.*

## Structure

`DtoBulkUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accountname` | `string` | Optional | The numeric account name, which must include leading zeros |
| `Resourceidentifiers` | [`List<TheIDresourceandDeviceId>`](../../doc/models/the-i-dresourceand-device-id.md) | Optional | - |
| `Smartalert` | [`BulkUpdateSmartalert`](../../doc/models/bulk-update-smartalert.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "resourceidentifiers": [
    {
      "id": "ee70a869-eeee-ffff-gggg-07c14c31f96e",
      "deviceid": "deviceid4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceid": "131501ff-eeee-ffff-gggg-647d19179a12",
      "id": "id4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "smartalert": {
    "name": "name0"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

