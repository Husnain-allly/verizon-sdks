
# Create Device Group Request

Create request for a new device group and optionally add devices to the group.

*This model accepts additional fields of type interface{}.*

## Structure

`CreateDeviceGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | The Verizon billing account that the device group will belong to. An account name is usually numeric, and must include any leading zeros. |
| `GroupDescription` | `string` | Required | A description for the device group. |
| `GroupName` | `string` | Required | The name for the new device group. This name must be unique within the specified account. |
| `DevicesToAdd` | [`[]models.DeviceId`](../../doc/models/device-id.md) | Optional | Zero or more devices to add to the device group. You can use POST /devices/actions/list to get a list of all devices in the account. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "10001234-0001",
  "groupName": "NV tanks",
  "groupDescription": "Nevada tank level monitors.",
  "devicesToAdd": [
    {
      "kind": "imei",
      "id": "990003420535537",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

