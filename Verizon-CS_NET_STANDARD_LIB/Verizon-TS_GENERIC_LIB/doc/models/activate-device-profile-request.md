
# Activate Device Profile Request

## Structure

`ActivateDeviceProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `devices` | [`DeviceList[]`](../../doc/models/device-list.md) | Required | **Constraints**: *Maximum Items*: `100` |
| `accountName` | `string` | Required | - |
| `servicePlan` | `string \| undefined` | Optional | - |
| `mdnZipCode` | `string \| undefined` | Optional | - |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "accountName": "0000123456-00001",
  "servicePlan": "The service plan name",
  "mdnZipCode": "five digit zip code"
}
```

