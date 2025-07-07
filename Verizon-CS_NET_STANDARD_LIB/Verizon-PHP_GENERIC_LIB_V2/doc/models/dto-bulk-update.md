
# Dto Bulk Update

*This model accepts additional fields of type array.*

## Structure

`DtoBulkUpdate`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `resourceidentifiers` | [`?(TheIDresourceandDeviceId[])`](../../doc/models/the-i-dresourceand-device-id.md) | Optional | - | getResourceidentifiers(): ?array | setResourceidentifiers(?array resourceidentifiers): void |
| `smartalert` | [`?BulkUpdateSmartalert`](../../doc/models/bulk-update-smartalert.md) | Optional | - | getSmartalert(): ?BulkUpdateSmartalert | setSmartalert(?BulkUpdateSmartalert smartalert): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

