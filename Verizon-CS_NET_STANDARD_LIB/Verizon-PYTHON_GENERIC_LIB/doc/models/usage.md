
# Usage

The daily network data usage of a single device during a specified time period.

*This model accepts additional fields of type Any.*

## Structure

`Usage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `bytes_used` | `int` | Optional | The number of bytes that the device sent or received on the report date. |
| `extended_attributes` | [`List[CustomFields]`](../../doc/models/custom-fields.md) | Optional | The number of mobile-originated and mobile-terminated SMS messages on the report date. |
| `service_plan` | `str` | Optional | The list of service plans associated with the device/account. |
| `sms_used` | `int` | Optional | The number of SMS messages that were sent or received on the report date. |
| `source` | `str` | Optional | The source of the information for the reported usage. |
| `timestamp` | `str` | Optional | The date of the recorded usage. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "bytesUsed": 4096,
  "extendedAttributes": [
    {
      "key": "MoSms",
      "value": "0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "smsUsed": 0,
  "source": "Raw Usage",
  "timestamp": "2020-12-01T00:00:00Z",
  "servicePlan": "servicePlan6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

