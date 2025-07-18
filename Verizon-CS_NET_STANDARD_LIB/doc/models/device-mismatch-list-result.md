
# Device Mismatch List Result

Response to list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame.

*This model accepts additional fields of type object.*

## Structure

`DeviceMismatchListResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Devices` | [`List<MismatchedDevice>`](../../doc/models/mismatched-device.md) | Optional | A list of specific devices that you want to check, specified by ICCID or MDN. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "devices": [
    {
      "accountName": "0212398765-00001",
      "mdn": "5096300587",
      "activationDate": "2011-01-21T10:55:27-08:00",
      "iccid": "89148000000800784259",
      "preImei": "990003420535573",
      "postImei": "987603420573553",
      "simOtaDate": "2017-12-01T16:00:00-08:00",
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

